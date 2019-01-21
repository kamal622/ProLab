Imports ProLab.Service.PatientService
Imports ProLab.Core.Common
Imports ProLab.Service
Imports ProLab.Data
Imports ProLab.Service.PatientTransction
Imports ProLab.Service.PatientTransctionService
Imports ProLab.Service.Patient

Public Class PatientTransactionsForm
    Private patientService As PatientService
    Private commanService As CommonService
    Private masterService As MasterService
    Private transctionService As PatientTransctionService
    Private PatientTranctionId As Integer = 0
    Private PatientId As Integer = 0
    Private DoctorId As Integer = 0
    Private TServiceId As Integer = 0
    Private TResponceStatusId As Integer
    Private DeletedServiceId() As Integer
    Dim Transctionlist As New List(Of PatientTransction)

    Private Sub PatientTransactionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'PatientTranctionId = 0
            'PatientId = 0
            Call GetAllServiceCategory(treeViewServiceCategory)
            Call GetAllServices(treeViewServiceCategory)
            If Me.treeViewServiceCategory.Nodes.Count > 0 Then
                Me.treeViewServiceCategory.ExpandAll()
                Me.treeViewServiceCategory.TopNode = treeViewServiceCategory.Nodes(0)
            End If
            dataGridPatientTransaction.AutoGenerateColumns = False
            txtServiceCategory.ReadOnly = True
            txtServiceAmount.ReadOnly = True
            txtServiceName.ReadOnly = True
            txtDepositeAmount.Text = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFindPatientByMobile_Click(sender As Object, e As EventArgs) Handles btnFindPatientByMobile.Click
        Try
            FindAllPatientDetails()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFindPatientByMobile_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFindPatientByMobile.KeyUp
        Try
            If e.KeyCode = Keys.F2 Then
                FindAllPatientDetails()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFindDoctorByName_Click(sender As Object, e As EventArgs) Handles btnFindDoctorByName.Click
        Try
            FindRefrenceDoctorDetails()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFindDoctorByName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFindDoctorByName.KeyUp
        Try
            If e.KeyCode = Keys.F2 Then
                FindRefrenceDoctorDetails()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnServiceAdd_Click(sender As Object, e As EventArgs) Handles btnServiceAdd.Click
        Try
            Dim PTransactionId As Integer = 0
            masterService = New MasterService()
            If txtFindPatientByMobile.Text.Trim = "" Then
                MessageBox.Show("Patient mobile number is required", Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : txtFindPatientByMobile.Focus() : Exit Sub
            End If

            If txtServiceAmount.Text.Trim Is "" Or txtServiceCategory.Text Is "" Or txtServiceName.Text Is "" Then
                MsgBox("select service category")
                Exit Sub
            End If
            If PatientTranctionId > 0 Then
                PTransactionId = PatientTranctionId
            Else
                PTransactionId = 0
            End If

            If txtServiceAmount.Text.Trim IsNot "" Then
                Transctionlist.Add(New PatientTransction(0, TServiceId, txtServiceCategory.Text, txtServiceName.Text, txtServiceAmount.Text, PTransactionId))
            End If
            dataGridPatientTransaction.DataSource = Nothing
            dataGridPatientTransaction.DataSource = Transctionlist
            'dataGridPatientTransaction.ReadOnly = True
            Dim amount As Integer = 0
            For Each grid As DataGridViewRow In dataGridPatientTransaction.Rows
                amount += grid.Cells("ServiceTransaction_SAmount").Value
                lblTotalAmount.Text = amount
            Next

            ClearServiceFieldValues()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnServiceClear_Click(sender As Object, e As EventArgs) Handles btnServiceClear.Click
        Try
            ClearServiceFieldValues()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub treeViewServiceCategory_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeViewServiceCategory.AfterSelect
        Try
            masterService = New MasterService()
            Dim ServiceId As String = ""
            Dim iServiceId As Integer = 0
            Dim ServiceName As String = ""
            Dim status As Boolean
            With treeViewServiceCategory
                Try
                    ServiceId = .SelectedNode.Name
                    ServiceName = .SelectedNode.Tag
                    If ServiceName Is Nothing Then
                        ServiceName = ""
                    End If
                    If ServiceName.Trim = "" Then
                        Exit Sub
                    End If
                    ServiceName = IIf(Strings.Left(ServiceName, 1) = "\", Strings.Right(ServiceName, Len(ServiceName) - 1), ServiceName)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                If ServiceId <> "" Then
                    If Strings.Left(ServiceId, 1) = "G" Then
                        ServiceId = "G"
                    ElseIf Strings.Left(ServiceId, 1) = "M" Then
                        ServiceId = Strings.Right(ServiceId, Len(ServiceId) - 1)
                        TServiceId = ServiceId
                    End If
                Else
                    ServiceId = "G"
                End If
            End With

            If ServiceId IsNot Nothing And ServiceName IsNot Nothing Then
                Dim dtbl As Data.ProLabDB.ServicesDataTable = Nothing
                status = masterService.GetServiceDetailsForTranasction(ServiceId, ServiceName, dtbl)
                If status Then
                    With dtbl(0)
                        txtServiceName.Text = .Name
                        txtServiceAmount.Text = .Amount
                        txtServiceCategory.Text = .CategoryName
                        txtServiceCategory.ReadOnly = True
                        txtServiceName.ReadOnly = True
                        txtServiceAmount.ReadOnly = True
                    End With
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub treeViewServiceCategory_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles treeViewServiceCategory.NodeMouseClick
        Try
            Dim Original As TreeNode = e.Node
            treeViewServiceCategory.SelectedNode = Nothing
            treeViewServiceCategory.SelectedNode = Original
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnTransactionSave_Click(sender As Object, e As EventArgs) Handles btnTransactionSave.Click
        Try
            Dim msg As String = "Patient Transaction Added"
            Dim userId As Integer
            transctionService = New PatientTransctionService()
            Transction_Id = PatientTranctionId
            If DoctorId > 0 Then
                Transction_SDoctorId = DoctorId
            Else
                Transction_SDoctorId = Nothing
            End If

            Transction_SPatientId = PatientId

            Transction_SReportStatusId = TResponceStatusId

            Transction_SRemarks = txtTransactionRemarks.Text
            Transction_SServiceId = TServiceId
            If chkSampleRequired.Checked Then
                Transction_SampleRequired = True
            Else
                Transction_SampleRequired = False
            End If

            If chkSampleRecevied.Checked Then
                Transction_SampleReceived = True
            Else
                Transction_SampleReceived = False
            End If
            Transction_SampleNumber = txtTransactionSampleNo.Text
            If txtDepositeAmount.Text.Trim = "" Then
                Transction_SDepoiteAmount = "0"
            Else
                Transction_SDepoiteAmount = txtDepositeAmount.Text
            End If
            userId = User_ID
            Dim obj As List(Of PatientTransction) = Transctionlist

            transctionService.SavePatientTranction(msg, obj, userId, DeletedServiceId)
            MsgBox(msg)
            ClearAllServiceFieldsValues()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnTransactionsClose_Click(sender As Object, e As EventArgs) Handles btnTransactionsClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FindAllPatientDetails()
        Try
            Dim Qry As String
            Dim Colwidth As String = ""
            If Not LocatePatientValues(txtFindPatientByMobile.Text.Trim) Then
                Qry = "select p.Id,p.FirstName,p.Lastname,p.Mobile,p.LandLine,p.Email,p.Address1,p.Address2,ct.CityName ,s.StateName,c.CountryName,p.Age,p.Gender,p.DOB,p.Occupation,p.Zipcode from Patients p join City ct on p.CityId=ct.Id join State s on p.StateId=s.Id join Country c on p.CountryId=c.Id"
                Call ShowSearchengine(txtFindPatientByMobile, Qry, 0, "FirstName", Colwidth, "", 0)
                If mId > 0 Then
                    GetPatientDetailsById(mId)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FindRefrenceDoctorDetails()
        Try
            Dim Qry As String
            Dim Colwidth As String = ""
            Qry = "select d.Id,d.FirstName,d.LastName,h.Name from Doctors d join Hospitals h on d.HospitalId=h.Id"
            Call ShowSearchengine(txtFindDoctorByName, Qry, 0, "Name", Colwidth,, 0)
            If mId > 0 Then
                GetDoctorDetailsById(mId)
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
                Call AssignToPatientFieldsControl(dtbl)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Function LocatePatientValues(ByVal Mobile As String) As Boolean
        Dim status As Boolean
        Try
            PatientService = New PatientService()
            Dim dtbl As Data.ProLabDB.PatientsDataTable = Nothing
            status = PatientService.GetPatientDetailsByMobile(dtbl, Mobile)
            If status Then
                Call AssignToPatientFieldsControl(dtbl)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Sub AssignToPatientFieldsControl(ByRef dtbl As ProLabDB.PatientsDataTable)
        Try
            With dtbl(0)
                PatientId = .Id
                txtFindPatientByMobile.Text = .Mobile
                lblPatientFullName.Text = .FirstName + "  " + .Lastname
                lblPatientAddress.Text = .Address1
                lblPatientMobile.Text = .Mobile
                'lblPatientLandline.Text = .LandLine
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetDoctorDetailsById(ByVal Id As Int32) As Boolean
        masterService = New MasterService()
        Dim dtbl As Data.ProLabDB.DoctorsDataTable = Nothing
        Dim status As Boolean
        Try
            status = masterService.GetDoctorDetailsForTransctionId(dtbl, Id)
            If status Then
                Call AssignToDoctorFieldsControl(dtbl)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Function GetPatientTransactionsById(ByVal TransactionsId As Integer) As Boolean
        transctionService = New PatientTransctionService()
        Dim dtbl As DataTable = Nothing
        Dim SCategory As String = ""
        Dim SName As String = ""
        Dim SAmount As String = ""
        Dim STransactionId As String = ""
        Dim ServiceId As String = ""
        Dim status As Boolean
        lblTotalAmount.Text = 0
        Try
            status = transctionService.GetPatientTransactionsById(TransactionsId, dtbl)
            If status Then

                For Each serviceData In dtbl.Rows
                    TServiceId = serviceData(0)
                    SCategory = serviceData(1)
                    SName = serviceData(2)
                    SAmount = serviceData(3)
                    STransactionId = serviceData(4)
                    PatientTranctionId = serviceData(4)
                    ServiceId = serviceData(5)
                    Transctionlist.Add(New PatientTransction(ServiceId, TServiceId, SCategory, SName, SAmount, STransactionId))
                    lblTotalAmount.Text = SAmount + Val(lblTotalAmount.Text)
                Next
                'dataGridPatientTransaction.ReadOnly = True
                dataGridPatientTransaction.DataSource = Nothing
                dataGridPatientTransaction.DataSource = Transctionlist
                dataGridPatientTransaction.Columns("Service_PatientTransactionId").Visible = False
                lblTransactionMode.Text = "Edit Mode"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Private Sub AssignToDoctorFieldsControl(ByRef dtbl As ProLabDB.DoctorsDataTable)
        Try
            With dtbl(0)
                DoctorId = .Id
                txtFindDoctorByName.Text = .FirstName + " " + .LastName
                lblDoctorFullName.Text = .FirstName + " " + .LastName
                lblHospitalName.Text = .HospitalName
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GetAllServiceCategory(ByRef treeView As TreeView)
        Try
            masterService = New MasterService
            Dim tvRoot As TreeNode
            Dim tvNode As TreeNode
            Dim dr As DataTableReader = Nothing
            Dim dtbl As Data.ProLabDB.ServiceCategoryDataTable = Nothing
            If masterService.GetServiceCategory(dtbl) Then
                tvRoot = treeViewServiceCategory.Nodes.Add("Service Category")
                tvRoot.Name = "G" & "- Root"
                dr = dtbl.CreateDataReader
                With dr
                    While dr.Read
                        tvNode = tvRoot.Nodes.Add(dr.Item(0), dr.Item(1))
                        tvNode.ForeColor = System.Drawing.Color.Maroon
                        tvNode.Name = "G" & dr.Item(0).ToString
                        tvNode.NodeFont = New System.Drawing.Font("Tahoma", 8, System.Drawing.FontStyle.Bold)
                    End While
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GetAllServices(ByRef treeView As TreeView)
        Try
            masterService = New MasterService
            Dim tvRoot As TreeNode
            Dim tvNode As TreeNode
            Dim dr As DataTableReader = Nothing
            Dim dtbl As Data.ProLabDB.ServicesDataTable = Nothing
            If masterService.GetAllServies(dtbl) Then
                dr = dtbl.CreateDataReader
                With treeView
                    While dr.Read
                        For i = 0 To .Nodes(0).Nodes.Count - 1
                            If .Nodes(0).Nodes(i).Name = "G" & dr.Item("CategoryId").ToString Then
                                tvRoot = .Nodes(0).Nodes(i)
                                tvNode = tvRoot.Nodes.Add(dr.Item("Id"), dr.Item("Name"))
                                tvNode.ForeColor = System.Drawing.Color.DarkBlue
                                tvNode.Name = "M" & dr.Item("Id").ToString
                                tvNode.Tag = dr.Item("Name").ToString

                                tvNode.NodeFont = New System.Drawing.Font("Tahoma", 8, System.Drawing.FontStyle.Regular)
                                .Nodes(0).Nodes(i).Expand()
                                Exit For
                            End If
                        Next
                    End While
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearServiceFieldValues()
        Try
            txtServiceCategory.Text = ""
            txtServiceName.Text = ""
            txtServiceAmount.Text = ""
            txtServiceCategory.ReadOnly = True
            txtServiceName.ReadOnly = True
            txtServiceAmount.ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearAllServiceFieldsValues()
        Try
            ClearServiceFieldValues()
            txtFindPatientByMobile.Text = ""
            txtFindPatientByMobile.Focus()
            txtFindDoctorByName.Text = ""
            lblPatientFullName.Text = ""
            lblPatientAddress.Text = ""
            lblTotalAmount.Text = "0000.00"
            lblPatientMobile.Text = ""
            lblDoctorFullName.Text = ""
            lblHospitalName.Text = ""
            txtServiceCategory.Text = ""
            txtTransactionRemarks.Text = ""
            txtDepositeAmount.Text = 0
            TServiceId = 0
            PatientTranctionId = 0
            DoctorId = 0
            PatientId = 0
            Transction_Id = 0
            chkSampleRecevied.Checked = False
            chkSampleRequired.Checked = False
            txtTransactionSampleNo.Text = ""
            dataGridPatientTransaction.DataSource = Nothing
            lblTransactionMode.Text = "New Mode"
            Transctionlist = New List(Of PatientTransction)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFindPatientByMobile_LostFocus(sender As Object, e As EventArgs) Handles txtFindPatientByMobile.LostFocus
        Try
            If (txtFindPatientByMobile.Text IsNot "") Then
                LocatePatientValues(txtFindPatientByMobile.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetPatientTransactionDetails(ByVal TransId As Integer, ByVal patientId As Integer, ByVal doctorId As Integer, ByVal billStatus As Boolean)
        Try
            If TransId > 0 Then
                Call GetPatientDetailsById(patientId)
                Call GetDoctorDetailsById(doctorId)
                Call GetPatientTransactionsById(TransId)
                Call GetTransactionDetailsById(TransId)

                If billStatus Then
                    btnTransactionSave.Enabled = False
                    btnTransactionClear.Text = "Delete"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function

    Public Function GetTransactionDetailsById(ByVal TransactionId)
        Dim result As Boolean = False
        Try
            transctionService = New PatientTransctionService()
            Dim dtbl As Data.ProLabDB.PatientTransactionsUtilityDataTable = Nothing
            result = transctionService.GetTransactionDetailsById(TransactionId, dtbl)
            If result Then
                Call AssignToControl(dtbl)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

    Private Sub AssignToControl(ByRef dtbl As ProLabDB.PatientTransactionsUtilityDataTable)
        Try
            With dtbl(0)
                PatientTranctionId = .Id
                txtDepositeAmount.Text = .DepositAmount
                txtTransactionRemarks.Text = .Remarks
                txtTransactionSampleNo.Text = .SampleNumber
                If (.SampleReceived = True) Then
                    chkSampleRecevied.Checked = True
                Else
                    chkSampleRecevied.Checked = False
                End If
                If (.SampleRequired = True) Then
                    chkSampleRequired.Checked = True
                Else
                    chkSampleRequired.Checked = False
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnTransactionClear_Click(sender As Object, e As EventArgs) Handles btnTransactionClear.Click
        Try
            If btnServiceClear.Text <> "Clear" Then
                ClearAllServiceFieldsValues()
            Else
                'MsgBox("Delete")
                ClearAllServiceFieldsValues()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDepositeAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDepositeAmount.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtFindPatientByMobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFindPatientByMobile.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

End Class