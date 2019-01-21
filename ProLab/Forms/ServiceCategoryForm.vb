Imports ProLab.Service.ServiceMaster
Imports ProLab.Core.Common
Imports ProLab.Service
Imports ProLab.Data


Public Class ServiceCategoryForm

    Private CategoryId As Integer = 0
    Private masterService As MasterService
    Private commonService As CommonService

    Private Sub ServiceCategoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryId = 0
        txtServiceCategoryName.Focus()
        RequiredServiceCategoryFieldBackground()
        btnCategoryDelete.Enabled = False
    End Sub

    Private Sub btnFindCategory_Click(sender As Object, e As EventArgs) Handles btnFindCategory.Click
        Try
            FindAllServiceCategory()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFindCategory_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFindCategory.KeyUp
        Try
            If e.KeyCode = Keys.F2 Then
                FindAllServiceCategory()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearCategoryFormFields()
        Try
            CategoryId = 0
            txtFindCategory.Text = ""
            txtServiceCategoryName.Text = ""
            txtServiceDescription.Text = ""
            RequiredServiceCategoryFieldBackground()
            txtFindCategory.Focus()
            btnCategoryDelete.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FindAllServiceCategory()
        Try
            Dim Qry As String
            Dim Colwidth As String = ""
            If Not LocateValues(txtFindCategory.Text.Trim) Then
                Qry = "select sc.Id,sc.CategoryName,sc.Description from ServiceCategory sc"
                Call ShowSearchengine(txtFindCategory, Qry, 0, "Name", Colwidth,, 0)

                If mId > 0 Then
                    GetServiceCategoryById(mId)
                End If
                If IsFormClear Then
                    ClearCategoryFormFields()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function LocateValues(ByVal Category As String) As Boolean
        masterService = New MasterService()
        Dim dtbl As Data.ProLabDB.ServiceCategoryDataTable = Nothing
        Dim status As Boolean
        Try
            status = masterService.GetServiceCategoryByName(dtbl, Category)
            If status Then
                Call AssignToControl(dtbl)
            Else
                ClearCategoryFormFields()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Private Sub AssignToControl(ByRef dtbl As ProLabDB.ServiceCategoryDataTable)
        Try
            With dtbl(0)
                CategoryId = .Id
                txtFindCategory.Text = .CategoryName
                txtServiceCategoryName.Text = .CategoryName
                txtServiceDescription.Text = .Description
            End With
            lblCategoryMode.Text = "Edit Mode"
            btnCategoryDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetServiceCategoryById(ByVal Id As Int32) As Boolean
        masterService = New MasterService()
        Dim dtbl As Data.ProLabDB.ServiceCategoryDataTable = Nothing
        Dim status As Boolean
        Try
            status = masterService.GetServiceCategoryById(dtbl, Id)
            If status Then
                Call AssignToControl(dtbl)
            Else
                ClearCategoryFormFields()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Private Sub txtFindCategory_LostFocus(sender As Object, e As EventArgs) Handles txtFindCategory.LostFocus
        Try
            If (txtFindCategory.Text IsNot "") Then
                LocateValues(txtFindCategory.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidateDoctorFormFields() As Boolean
        Dim status As Boolean = True
        Dim categoryMsg As String = ""
        Try
            If txtServiceCategoryName.Text.Trim = "" Then
                categoryMsg = "Category name is requried" + vbCrLf
                txtServiceCategoryName.Focus()
                status = False
            End If

            If status = False Then
                MsgBox(categoryMsg)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return status
    End Function

    Private Sub btnCategorySave_Click(sender As Object, e As EventArgs) Handles btnCategorySave.Click
        Dim msg As String = ""
        Dim userId As Integer
        masterService = New MasterService()
        Try
            If ValidateDoctorFormFields() Then
                SCategory_Id = CategoryId
                SCategory_Name = txtServiceCategoryName.Text
                SCategory_Description = txtServiceDescription.Text
                userId = User_ID
                If (masterService.SaveServiceCategory(msg, userId)) Then
                    MsgBox(msg)
                    ClearCategoryFormFields()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCategoryDelete_Click(sender As Object, e As EventArgs) Handles btnCategoryDelete.Click
        Try
            masterService = New MasterService()
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete service category?", Product_Name, MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If (CategoryId > 0) Then
                    masterService.DeleteServiceCategoryById(CategoryId)
                    ClearCategoryFormFields()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub txtServiceCategoryName_TextChanged(sender As Object, e As EventArgs) Handles txtServiceCategoryName.TextChanged
        txtServiceCategoryName.BackColor = Color.White
        'CheckExistingServiceCategory(txtServiceCategoryName.Text)
    End Sub

    Private Sub RequiredServiceCategoryFieldBackground()
        Try
            txtServiceCategoryName.BackColor = Color.LightYellow
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCategoryClear_Click(sender As Object, e As EventArgs) Handles btnCategoryClear.Click
        Try
            ClearCategoryFormFields()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCategoryClose_Click(sender As Object, e As EventArgs) Handles btnCategoryClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function CheckExistingServiceCategory(ByVal ServiceCategory)
        Try
            masterService = New MasterService()
            If masterService.CheckExistingServiceCategory(ServiceCategory) Then
                MsgBox("Category is already exist!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub txtServiceCategoryName_LostFocus(sender As Object, e As EventArgs) Handles txtServiceCategoryName.LostFocus
        CheckExistingServiceCategory(txtServiceCategoryName.Text)
        'txtServiceCategoryName.Focus()
    End Sub
End Class