Imports ProLab.Service.PatientService
Imports ProLab.Core.Common
Imports ProLab.Service
Imports ProLab.Data
Imports ProLab.Service.PatientTransction
Imports ProLab.Service.PatientTransctionService
Imports ProLab.Service.Patient

Public Class PatientTransactionUtilityForm
    Private patientService As PatientService
    Private commanService As CommonService
    Private masterService As MasterService
    Private transctionService As PatientTransctionService

    Private PatientTranctionId As Integer = 0
    Public PatientId As Integer = 0
    Private DoctorId As Integer = 0
    Private TServiceId As Integer = 0

    Private Sub PatientTransactionUtilityForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'dataGridPatientTransactions.ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSearchTransactions_Click(sender As Object, e As EventArgs) Handles btnSearchTransactions.Click
        Try
            GetAllPatientTransactionByName(True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFindTransactionByName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchName.KeyUp
        Try
            If e.KeyCode = Keys.F2 Then
                FindPatientDetails()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFindPatient_Click(sender As Object, e As EventArgs) Handles btnFindPatient.Click
        Try
            FindPatientDetails()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FindPatientDetails()
        Try
            Dim Qry As String
            Dim Colwidth As String = ""
            If Not LocateValues(txtSearchName.Text.Trim) Then
                Qry = "select p.Id,p.FirstName,p.Lastname,p.Mobile,p.LandLine,p.Email,p.Address1,p.Address2,ct.CityName ,s.StateName,c.CountryName,p.Age,p.Gender,p.DOB,p.Occupation,p.Zipcode from Patients p join City ct on p.CityId=ct.Id join State s on p.StateId=s.Id join Country c on p.CountryId=c.Id"
                Call ShowSearchengine(txtSearchName, Qry, 0, "FirstName", Colwidth, "", 0)
                If mId > 0 Then
                    GetPatientDetailsById(mId)
                End If
                If IsFormClear Then
                    'ClearPatientFormValues()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetPatientDetailsById(ByVal Id As Integer) As Boolean
        patientService = New PatientService()
        Dim dtbl As Data.ProLabDB.PatientsDataTable = Nothing
        Dim status As Boolean
        Try
            status = patientService.GetPatientDetailsById(dtbl, Id)
            If status Then
                Call AssignToControl(dtbl)
            Else
                'ClearPatientFormValues()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Function LocateValues(ByVal Id As String) As Boolean
        patientService = New PatientService()
        Dim dtbl As Data.ProLabDB.PatientsDataTable = Nothing
        Dim status As Boolean
        Try
            status = patientService.GetPatientDetailsByMobile(dtbl, Id)
            If status Then
                Call AssignToControl(dtbl)
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Private Sub AssignToControl(ByRef dtbl As ProLabDB.PatientsDataTable)
        Try
            With dtbl(0)
                PatientId = .Id
                txtSearchName.Text = .FirstName
                txtSearchMobile.Text = .Mobile
                dataGridPatientTransactions.DataSource = Nothing
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnTransactionUClear_Click(sender As Object, e As EventArgs) Handles btnTransactionUClear.Click
        Try
            txtSearchName.Text = ""
            txtSearchMobile.Text = ""
            dataGridPatientTransactions.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnTransactionUClose_Click(sender As Object, e As EventArgs) Handles btnTransactionUClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dataGridPatientTransactions_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dataGridPatientTransactions.UserDeletingRow
        Try
            If e.Row.Cells("BillGenerated").Value <> True Then
                Dim result As Integer = MessageBox.Show("Are you sure you want to delete patient?", Product_Name, MessageBoxButtons.YesNo)
                transctionService = New PatientTransctionService()
                Dim msg As String = ""
                If result = DialogResult.Yes Then
                    Dim TransactionId As Integer = e.Row.Cells("Id").Value
                    If transctionService.DeletePatientTransactionById(TransactionId, msg) Then
                        MsgBox(msg)
                    End If
                Else
                    e.Cancel = True
                End If
            Else
                e.Cancel = True
                MsgBox("Bill generated already. Can not delete this transaction.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dataGridPatientTransactions_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridPatientTransactions.CellDoubleClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim Did = dataGridPatientTransactions.Rows(e.RowIndex).Cells("RefDocId").Value.ToString()
                Dim DoctorId As Integer = 0
                If String.IsNullOrEmpty(Did) Then
                    DoctorId = 0
                Else
                    DoctorId = dataGridPatientTransactions.Rows(e.RowIndex).Cells("RefDocId").Value
                End If
                Dim PatientId As Integer = dataGridPatientTransactions.Rows(e.RowIndex).Cells("PatientId").Value
                Dim TransactionId As Integer = dataGridPatientTransactions.Rows(e.RowIndex).Cells("Id").Value
                PatientTranctionId = dataGridPatientTransactions.Rows(e.RowIndex).Cells("Id").Value
                Dim billStatus = dataGridPatientTransactions.Rows(e.RowIndex).Cells("BillGenerated").Value
                If btnFindPatient.Enabled Then
                    Dim frmPatientTransaction As New PatientTransactionsForm
                    frmPatientTransaction.GetPatientTransactionDetails(TransactionId, PatientId, DoctorId, billStatus)
                    frmPatientTransaction.ShowDialog(Me)
                Else
                    If dataGridPatientTransactions.Rows(e.RowIndex).Cells("BillGenerated").Value <> True Then
                        patientTransId = TransactionId
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Select Valid Transaction")
        End Try
    End Sub

    Private Sub GetAllPatientTransactionByName(ByVal transactionStatus As Boolean)
        Try
            Dim dtbl As DataTable = Nothing
            Dim FirstName As String = txtSearchName.Text
            Dim Mobile As String = txtSearchMobile.Text
            transctionService = New PatientTransctionService()
            transctionService.GetAllUnPaidPatientTransaction(PatientId, FirstName, Mobile, transactionStatus, dtbl)
            dataGridPatientTransactions.DataSource = dtbl
            dataGridPatientTransactions.Columns("Id").Visible = False
            dataGridPatientTransactions.Columns("CreateDate").DefaultCellStyle.Format = "dd-MM-yyyy"
            dataGridPatientTransactions.Columns("CreateDate").HeaderText = "TransactionDate"
            dataGridPatientTransactions.ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetPatientTransactionByPatientId(ByVal PatientId)
        Try
            Dim transactionStatus As Boolean = True
            GetPatientDetailsById(PatientId)
            GetAllPatientTransactionByName(transactionStatus)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function
End Class