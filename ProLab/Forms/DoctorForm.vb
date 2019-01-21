Imports ProLab.Service.ServiceMaster
Imports ProLab.Core.Common
Imports ProLab.Service
Imports ProLab.Data
Public Class DoctorForm

    Private DoctorId As Integer = 0
    Private masterService As MasterService
    Private commonService As CommonService

    Private Sub DoctorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindHospitals()
        DoctorId = 0
        RequiredDoctorFieldBackground()
        btnDoctorDelete.Enabled = False
    End Sub

    Private Sub btnDoctorSave_Click_1(sender As Object, e As EventArgs) Handles btnDoctorSave.Click
        Dim msg As String = ""
        Dim userId As Integer
        masterService = New MasterService()
        Try
            If ValidateDoctorFormFields() Then
                Doctor_Id = DoctorId
                Doctor_FName = txtDoctorFname.Text
                Doctor_LName = txtDoctorLName.Text
                If comboDoctroHospital.SelectedValue = Nothing Then
                    Doctor_HospitalId = 5
                Else
                    Doctor_HospitalId = comboDoctroHospital.SelectedValue
                End If
                userId = User_ID
                If (masterService.SaveDoctor(msg, userId)) Then
                    MsgBox(msg)
                    ClearDoctorFormValues()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDoctorDelete_Click_1(sender As Object, e As EventArgs) Handles btnDoctorDelete.Click
        Try
            masterService = New MasterService()
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete doctor?", Product_Name, MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If (DoctorId > 0) Then
                    masterService.DeleteDoctorById(DoctorId)
                    ClearDoctorFormValues()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDoctorClear_Click_1(sender As Object, e As EventArgs) Handles btnDoctorClear.Click
        ClearDoctorFormValues()
    End Sub

    Private Sub btnDoctorClose_Click_1(sender As Object, e As EventArgs) Handles btnDoctorClose.Click
        Me.Close()
    End Sub

    Private Sub btnFindDoctor_Click(sender As Object, e As EventArgs) Handles btnFindDoctor.Click
        FindAllDoctors()
    End Sub

    Private Sub txtFIndDoctor_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFIndDoctor.KeyUp
        If e.KeyCode = Keys.F2 Then
            FindAllDoctors()
        End If
    End Sub

    Private Sub txtFIndDoctor_LostFocus(sender As Object, e As EventArgs) Handles txtFIndDoctor.LostFocus
        Try
            If (txtFIndDoctor.Text IsNot "") Then
                LocateValues(txtFIndDoctor.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearDoctorFormValues()
        txtFIndDoctor.Text = ""
        txtDoctorFname.Text = ""
        txtDoctorLName.Text = ""
        comboDoctroHospital.SelectedIndex = -1
        DoctorId = 0
        txtFIndDoctor.Focus()
        RequiredDoctorFieldBackground()
        btnDoctorDelete.Enabled = False
    End Sub

    Private Sub BindHospitals()
        Try
            masterService = New MasterService()
            Dim dtbl As DataTable = Nothing
            masterService.GetHospitalWithCity(dtbl)
            comboDoctroHospital.ValueMember = "Id"
            comboDoctroHospital.DisplayMember = "Name"
            comboDoctroHospital.DataSource = dtbl
            comboDoctroHospital.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FindAllDoctors()
        Try
            Dim Qry As String
            Dim Colwidth As String = ""
            If Not LocateValues(txtFIndDoctor.Text.Trim) Then
                Qry = "select d.Id,d.FirstName,d.LastName,h.Name from Doctors d join Hospitals h on d.HospitalId=h.Id"
                Call ShowSearchengine(txtFIndDoctor, Qry, 0, "Name", Colwidth,, 0)
                If mId > 0 Then
                    GetDoctorDetailsById(mId)
                End If
                If IsFormClear Then
                    ClearDoctorFormValues()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function LocateValues(ByVal FirstName As String) As Boolean
        masterService = New MasterService()
        Dim dtbl As Data.ProLabDB.DoctorsDataTable = Nothing
        Dim status As Boolean
        Try
            status = masterService.GetDocrorByFirstName(dtbl, FirstName)
            If status Then
                Call AssignToControl(dtbl)
            Else
                ClearDoctorFormValues()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Private Sub AssignToControl(ByRef dtbl As ProLabDB.DoctorsDataTable)
        Try
            With dtbl(0)
                DoctorId = .Id
                txtFIndDoctor.Text = .FirstName
                comboDoctroHospital.SelectedValue = .HospitalId
                txtDoctorFname.Text = .FirstName
                txtDoctorLName.Text = .LastName
            End With
            lblDoctorMode.Text = "Edit Mode"
            btnDoctorDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetDoctorDetailsById(ByVal Id As Int32) As Boolean
        masterService = New MasterService()
        Dim dtbl As Data.ProLabDB.DoctorsDataTable = Nothing
        Dim status As Boolean
        Try
            status = masterService.GetDoctorById(dtbl, Id)
            If status Then
                Call AssignToControl(dtbl)
            Else
                ClearDoctorFormValues()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Private Function ValidateDoctorFormFields() As Boolean
        Dim status As Boolean = True
        Dim docfnameMsg As String = ""
        Dim doclnameMsg As String = ""
        Dim hospitalMsg As String = ""
        If txtDoctorFname.Text.Trim = "" Then
                docfnameMsg = "First name is requried" + vbCrLf
                txtDoctorFname.Focus()
                status = False
            End If

            If txtDoctorLName.Text.Trim = "" Then
                doclnameMsg = "Last name is requried" + vbCrLf
                txtDoctorLName.Focus()
                status = False
            End If
        If status = False Then
            MsgBox(docfnameMsg + doclnameMsg + hospitalMsg)
        End If
        Return status
    End Function

    Private Sub RequiredDoctorFieldBackground()
        txtDoctorFname.BackColor = Color.LightYellow
        txtDoctorLName.BackColor = Color.LightYellow
        comboDoctroHospital.BackColor = Color.LightYellow
    End Sub

    Private Sub btnAddHospital_Click(sender As Object, e As EventArgs) Handles btnAddHospital.Click
        Dim hospital As New HospitalForm
        hospital.ShowDialog(Me)
        comboDoctroHospital.DataSource = Nothing
        BindHospitals()
    End Sub

    Private Sub txtDoctorFname_TextChanged(sender As Object, e As EventArgs) Handles txtDoctorFname.TextChanged
        txtDoctorFname.BackColor = Color.White
    End Sub

    Private Sub txtDoctorLName_TextChanged(sender As Object, e As EventArgs) Handles txtDoctorLName.TextChanged
        txtDoctorLName.BackColor = Color.White
    End Sub

    Private Sub comboDoctroHospital_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboDoctroHospital.SelectedIndexChanged
        comboDoctroHospital.BackColor = Color.White
    End Sub
End Class