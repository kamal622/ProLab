Imports ProLab.Service.ServiceMaster
Imports ProLab.Core.Common
Imports ProLab.Service
Imports ProLab.Data

Public Class ServiceMasterForm

    Private masterService As MasterService
    Private commanService As CommonService
    Private ServiceId As Integer = 0

    Private Sub ServiceMasterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ServiceId = 0
        Try
            btnServiceDelete.Enabled = False
            RequiredServiceFieldBackground()
            BindServiceCategory()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindServiceCategory()
        masterService = New MasterService()
        Dim tbl As Data.ProLabDB.ServiceCategoryDataTable = Nothing
        masterService.GetAllServiceCategory(tbl)
        ComboServiceCategory.ValueMember = "Id"
        ComboServiceCategory.DisplayMember = "CategoryName"
        ComboServiceCategory.DataSource = tbl
        ComboServiceCategory.SelectedIndex = -1
    End Sub

    Private Sub btnFindService_Click(sender As Object, e As EventArgs) Handles btnFindService.Click
        Try
            FindAllService()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFindService_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFindService.KeyUp
        Try
            If e.KeyCode = Keys.F2 Then
                FindAllService()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FindAllService()
        Try
            Dim Qry As String
            Dim Colwidth As String = ""
            If Not LocateValues(txtFindService.Text.Trim) Then
                Qry = "select s.Id,sc.Categoryname,s.Name,s.Amount,s.Description,s.AppoinmentNeeded,s.IsActive from Services s join ServiceCategory sc on s.CategoryId=sc.Id "
                Call ShowSearchengine(txtFindService, Qry, 0, "Name", Colwidth,, 0)
                If mId > 0 Then
                    GetServiceById(mId)
                End If
                If IsFormClear Then
                    ClearServiceFormFieldValues()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function LocateValues(ByVal Name As String) As Boolean
        masterService = New MasterService()
        Dim dtbl As Data.ProLabDB.ServicesDataTable = Nothing
        Dim status As Boolean
        Try
            status = masterService.GetServiceByName(dtbl, Name)
            If status Then
                Call AssignToControl(dtbl)
            Else
                ClearServiceFormFieldValues()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Function GetServiceById(ByVal Id As Int32) As Boolean
        masterService = New MasterService()
        Dim dtbl As Data.ProLabDB.ServicesDataTable = Nothing
        Dim status As Boolean
        Try
            status = masterService.GetServiceById(dtbl, Id)
            If status Then
                Call AssignToControl(dtbl)
            Else
                ClearServiceFormFieldValues()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Private Sub AssignToControl(ByRef dtbl As ProLabDB.ServicesDataTable)
        Try
            With dtbl(0)
                ServiceId = .Id
                txtFindService.Text = .Name
                ComboServiceCategory.SelectedValue = .CategoryId
                txtServiceName.Text = .Name
                txtServiceDescription.Text = .Description
                txtServiceAmount.Text = .Amount
                If (.IsActive = "True") Then
                    chkServiceActive.Checked = True
                Else
                    chkServiceActive.Checked = False
                End If
                If (.AppoinmentNeeded = "True") Then
                    rbtnAppoitYes.Checked = True
                Else
                    rbtnAppointNo.Checked = True
                End If

            End With
            lblServiceMode.Text = "Edit Mode"
            btnServiceDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearServiceFormFieldValues()
        Try
            txtFindService.Text = ""
            ComboServiceCategory.SelectedIndex = -1
            txtServiceName.Text = ""
            txtServiceAmount.Text = ""
            txtServiceDescription.Text = ""
            ServiceId = 0
            txtFindService.Focus()
            btnServiceDelete.Enabled = False
            lblServiceMode.Text = "New Mode"
            RequiredServiceFieldBackground()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFindService_LostFocus(sender As Object, e As EventArgs) Handles txtFindService.LostFocus
        Try
            If (txtFindService.Text IsNot "") Then
                LocateValues(txtFindService.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RequiredServiceFieldBackground()
        Try
            txtServiceName.BackColor = Color.LightYellow
            txtServiceAmount.BackColor = Color.LightYellow
            ComboServiceCategory.BackColor = Color.LightYellow
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboServiceCategory_SelectedIndexChanged(sender As Object, e As EventArgs)
        ComboServiceCategory.BackColor = Color.White
    End Sub

    Private Sub txtServiceName_TextChanged(sender As Object, e As EventArgs)
        txtServiceName.BackColor = Color.White
    End Sub


    Private Function ValidateServiceFormFields() As Boolean
        Dim status As Boolean = True
        Dim ServiceCategoryMsg As String = ""
        Dim ServiceNameMsg As String = ""
        Dim ServiceAmountMsg As String = ""
        Try
            If ComboServiceCategory.SelectedIndex = -1 Then
                ServiceCategoryMsg = "Category is required" + vbCrLf
                ComboServiceCategory.Focus()
                status = False
            End If
            If txtServiceName.Text.Trim = "" Then
                ServiceNameMsg = "Name is requried" + vbCrLf
                txtServiceName.Focus()
                status = False
            End If
            If txtServiceAmount.Text.Trim = "" Then
                ServiceAmountMsg = "Amount is requried" + vbCrLf
                txtServiceAmount.Focus()
                status = False
            End If

            If status = False Then
                MsgBox(ServiceCategoryMsg + ServiceNameMsg + ServiceAmountMsg)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return status
    End Function

    Private Sub btnServiceSave_Click(sender As Object, e As EventArgs) Handles btnServiceSave.Click
        masterService = New MasterService()
        Dim msg As String = ""
        Dim userId As Integer
        Try
            If ValidateServiceFormFields() Then
                Service_Id = ServiceId
                Service_Category = ComboServiceCategory.SelectedValue
                Service_Name = txtServiceName.Text
                Service_Amount = txtServiceAmount.Text
                Service_Description = txtServiceDescription.Text
                userId = User_ID
                If (rbtnAppoitYes.Checked) Then
                    Service_Appoiment = True
                Else
                    Service_Appoiment = False
                End If
                Service_IsActive = chkServiceActive.Checked

                If (masterService.SaveServices(msg, userId)) Then
                    MsgBox(msg)
                    ClearServiceFormFieldValues()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnServiceDelete_Click(sender As Object, e As EventArgs) Handles btnServiceDelete.Click
        Try
            masterService = New MasterService()
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete service?", Product_Name, MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If (ServiceId > 0) Then
                    masterService.DeleteServiceById(ServiceId)
                    ClearServiceFormFieldValues()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnServiceClear_Click(sender As Object, e As EventArgs) Handles btnServiceClear.Click
        Try
            ClearServiceFormFieldValues()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnServiceClose_Click(sender As Object, e As EventArgs) Handles btnServiceClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function CheckExistingService(ByVal ServiceName)
        Try
            masterService = New MasterService()
            If masterService.CheckExistingService(ServiceName) Then
                MsgBox("Service is already exist!")
                ' txtServiceName.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub txtServiceName_LostFocus(sender As Object, e As EventArgs) Handles txtServiceName.LostFocus
        CheckExistingService(txtServiceName.Text)
    End Sub

    Private Sub btnAddServiceCategory_Click(sender As Object, e As EventArgs) Handles btnAddServiceCategory.Click
        Dim frmServiceCategory As New ServiceCategoryForm
        frmServiceCategory.ShowDialog(Me)
        ComboServiceCategory.DataSource = Nothing
        BindServiceCategory()
    End Sub
End Class