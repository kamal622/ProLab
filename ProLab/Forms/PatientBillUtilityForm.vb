Imports ProLab.Service.PatientService
Imports ProLab.Core.Common
Imports ProLab.Service.PatientBillService
Imports ProLab.Service
Imports ProLab.Data

Public Class PatientBillUtilityForm
    Private patientService As PatientService
    Private commanService As CommonService
    Private patientBillService As PatientBillService
    Private PatientBillId As Integer = 0
    Private PatientId As Integer = 0

    Private Sub btnFindPatientByName_Click(sender As Object, e As EventArgs) Handles btnFindPatientByName.Click
        Try
            Dim Qry As String
            Dim Colwidth As String = ""
            If Not LocateValues(txtSearchName.Text.Trim) Then
                Qry = "select p.Id,p.FirstName,p.Lastname,p.Mobile,p.LandLine,p.Email,p.Address1,p.Address2,ct.CityName ,s.StateName,c.CountryName,p.Age,p.Gender,p.DOB,p.Occupation,p.Zipcode from Patients p join City ct on p.CityId=ct.Id join State s on p.StateId=s.Id join Country c on p.CountryId=c.Id"
                Call ShowSearchengine(txtSearchName, Qry, 0, "FirstName", Colwidth, "", 0)
                If mId > 0 Then
                    GetPatientDetailsById(mId)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBillUtilityClear_Click(sender As Object, e As EventArgs) Handles btnBillUtilityClear.Click
        txtSearchName.Text = ""
        txtSearchMobile.Text = ""
        dataGridViewPatinetBills.DataSource = Nothing
    End Sub

    Private Sub btnFindPatientBills_Click(sender As Object, e As EventArgs) Handles btnFindPatientBills.Click
        Try
            patientBillService = New PatientBillService()
            Dim dtbl As DataTable = Nothing
            Dim FirstName As String = txtSearchName.Text
            Dim Mobile As String = txtSearchMobile.Text
            If patientBillService.GetPatientBillByName(FirstName, dtbl) Then
                dataGridViewPatinetBills.DataSource = dtbl
                dataGridViewPatinetBills.Columns("Id").Visible = False
                dataGridViewPatinetBills.Columns("PatientId").Visible = False
                dataGridViewPatinetBills.Columns("InvoiceDate").DefaultCellStyle.Format = "dd-MM-yyyy"
                dataGridViewPatinetBills.ReadOnly = True
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
                dataGridViewPatinetBills.DataSource = Nothing
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
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dataGridViewPatinetBills_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewPatinetBills.CellDoubleClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim PatientId As Integer = dataGridViewPatinetBills.Rows(e.RowIndex).Cells("PatientId").Value
                Dim BillId As Integer = dataGridViewPatinetBills.Rows(e.RowIndex).Cells("Id").Value
                PatientBillId = dataGridViewPatinetBills.Rows(e.RowIndex).Cells("Id").Value
                bPatientId = PatientId
                patBillId = BillId
                Dim frmPatientbills As New PatientBillForm
                frmPatientbills.GetPatientBillDeatils(BillId, PatientId)
                frmPatientbills.ShowDialog(Me)
            End If
        Catch ex As Exception
            MsgBox("Select Valid Bill")
        End Try
    End Sub

    Private Sub btnBillUtilityClose_Click(sender As Object, e As EventArgs) Handles btnBillUtilityClose.Click
        Me.Close()
    End Sub

End Class