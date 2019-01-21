Imports ProLab.Service.Patient
Imports ProLab.Core.Common
Imports ProLab.Service
Imports ProLab.Data

Public Class PatientForm
    Private patientService As PatientService
    Private commanService As CommonService
    Private PatientId As Integer = 0

    Private Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            BindCountry()
            RequiredFieldBackground()
            PatientId = 0
            btnPatDelete.Enabled = False
            rbtnMale.Checked = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPatSave_Click(sender As Object, e As EventArgs) Handles btnPatSave.Click
        Dim userId As Integer
        Try
            If ValidateFields() Then
                patientService = New PatientService
                Patient_Id = PatientId
                Patient_FirstName = txtPatFName.Text
                Patient_LastName = txtPatLName.Text
                Patient_Mobile = txtPatMobile.Text
                Patient_Landine = txtPatLandLine.Text
                Patient_Address1 = txtPatAddress1.Text
                Patient_Address2 = txtPatAddress2.Text
                Patient_Email = txtPatEmail.Text
                Patient_Age = txtPatAge.Text
                Patient_City = comboPatCity.SelectedValue
                Patient_DOB = dtPatDOB.Text
                Patient_Occupation = txtPatOccupation.Text
                Patient_ZipCode = txtPatZipcode.Text
                Patient_CountryId = comboPatCountry.SelectedValue
                Patient_StateId = comboPatState.SelectedValue
                userId = User_ID
                If (rbtnMale.Checked) Then
                    MPatient_Gender = rbtnMale.Text
                Else
                    MPatient_Gender = rbtnFemale.Text
                End If
                Dim msg As String = ""

                If (patientService.SavePatientInformation(msg, userId)) Then
                    MsgBox(msg)
                    ClearPatientFormValues()
                Else
                    MsgBox(msg)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnPatDelete_Click(sender As Object, e As EventArgs) Handles btnPatDelete.Click
        Try
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete patient?", Product_Name, MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If PatientId > 0 Then
                    patientService.DeletePatientById(PatientId)
                    ClearPatientFormValues()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ClearPatientFormValues()
        Try
            txtPatFName.Text = ""
            txtPatLName.Text = ""
            txtPatAddress1.Text = ""
            txtPatAddress2.Text = ""
            BindCountry()
            txtPatZipcode.Text = ""
            txtPatMobile.Text = ""
            txtPatLandLine.Text = ""
            txtPatEmail.Text = ""
            txtPatOccupation.Text = ""
            dtPatDOB.Value = Now
            txtPatientSearchByMobile.Text = ""
            PatientId = 0
            lblPatientMode.Text = "New Mode"
            btnPatDelete.Enabled = False
            rbtnMale.Checked = True
            RequiredFieldBackground()
            txtPatientSearchByMobile.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPatClear_Click(sender As Object, e As EventArgs) Handles btnPatClear.Click
        Try
            ClearPatientFormValues()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPatClose_Click(sender As Object, e As EventArgs) Handles btnPatClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtPatDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtPatDOB.ValueChanged
        Try
            Dim age As Integer
            age = DateTime.Now.Year - dtPatDOB.Value.Year
            txtPatAge.Text = age.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPatientSearch_Click(sender As Object, e As EventArgs) Handles btnPatientSearch.Click
        Try
            FindPatientDetails()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtPatentSearchById_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPatientSearchByMobile.KeyUp
        Try
            If e.KeyCode = Keys.F2 Then
                FindPatientDetails()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCity_Click(sender As Object, e As EventArgs) Handles btnAddCity.Click
        Try
            Dim frmCity As New CityForm
            Dim oldForm = Application.OpenForms.OfType(Of CityForm)
            If oldForm.Any Then
                oldForm.First.Focus()
            Else
                frmCity.ShowDialog(Me)
            End If
            Dim CountryId As Integer
            Dim StateId As Integer
            CountryId = comboPatCountry.SelectedValue
            StateId = comboPatState.SelectedValue
            BindCity(CountryId, StateId)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCountry_Click(sender As Object, e As EventArgs) Handles btnAddCountry.Click
        Try
            Dim frmCountry As New CountryForm
            Dim oldForm = Application.OpenForms.OfType(Of CountryForm)
            If oldForm.Any Then
                oldForm.First.Focus()
            Else
                frmCountry.ShowDialog(Me)
            End If
            BindCountry()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddState_Click(sender As Object, e As EventArgs) Handles btnAddState.Click
        Try
            Dim frmState As New StateForm
            Dim oldForm = Application.OpenForms.OfType(Of StateForm)
            If oldForm.Any Then
                oldForm.First.Focus()
            Else
                frmState.ShowDialog(Me)
            End If
            comboPatState.DataSource = Nothing
            Dim CountryId As Integer
            CountryId = comboPatCountry.SelectedValue
            BindState(CountryId)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub comboPatCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboPatCountry.SelectedIndexChanged
        commanService = New CommonService()
        Dim dtbl As DataTable = Nothing
        Dim CountryId As Integer
        comboPatState.DataSource = Nothing
        Try
            CountryId = comboPatCountry.SelectedValue
            BindState(CountryId)
            comboPatCountry.BackColor = Color.White
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub comboPatState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboPatState.SelectedIndexChanged
        commanService = New CommonService()
        Dim countryId As Integer
        Dim stateId As Integer
        comboPatCity.DataSource = Nothing
        Try
            countryId = comboPatCountry.SelectedValue
            stateId = comboPatState.SelectedValue
            BindCity(countryId, stateId)
            comboPatState.BackColor = Color.White
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FindPatientDetails()
        Try
            Dim Qry As String
            Dim Colwidth As String = ""
            If Not LocateValues(txtPatientSearchByMobile.Text.Trim) Then
                Qry = "select p.Id,p.FirstName,p.Lastname,p.Mobile,p.LandLine,p.Email,p.Address1,p.Address2,ct.CityName ,s.StateName,c.CountryName,p.Age,p.Gender,p.DOB,p.Occupation,p.Zipcode from Patients p join City ct on p.CityId=ct.Id join State s on p.StateId=s.Id join Country c on p.CountryId=c.Id"
                Call ShowSearchengine(txtPatientSearchByMobile, Qry, 0, "FirstName", Colwidth, "", 0)
                If mId > 0 Then
                    GetPatientDetailsById(mId)
                End If
                If IsFormClear Then
                    ClearPatientFormValues()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindCountry()
        Try
            comboPatCountry.DataSource = Nothing
            commanService = New CommonService()
            Dim defaultCountry As String = commanService.GetDefaultCountry()
            Dim dtbl As Data.ProLabDB.CountryDataTable = Nothing
            Dim country = commanService.GetAllCountry(dtbl)
            comboPatCountry.ValueMember = "Id"
            comboPatCountry.DisplayMember = "CountryName"
            comboPatCountry.DataSource = dtbl
            If defaultCountry IsNot Nothing Then
                comboPatCountry.SelectedValue = defaultCountry
            Else
                comboPatCountry.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindState(ByVal CountryId)
        Try
            Dim status As Boolean
            Dim defaultState As String = commanService.GetDefaultState()
            Dim dtbl As Data.ProLabDB.StateDataTable = Nothing
            status = commanService.GetAllStateByCountryId(dtbl, CountryId)
            If (status) Then
                comboPatState.ValueMember = "Id"
                comboPatState.DisplayMember = "StateName"
                comboPatState.Enabled = True
                comboPatState.DataSource = dtbl
                If defaultState IsNot Nothing Then
                    comboPatState.SelectedValue = defaultState
                Else
                    comboPatState.SelectedIndex = -1
                End If
            Else
                comboPatState.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindCity(ByVal countryId, ByVal stateId)
        Try
            Dim defaultCity As String = commanService.GetDefaultCity()
            Dim city = commanService.GetAllCityByStateId(countryId, stateId)
            If (city.Rows.Count > 0) Then
                comboPatCity.DataSource = city
                comboPatCity.ValueMember = "Id"
                comboPatCity.DisplayMember = "CityName"
                If defaultCity IsNot Nothing Then
                    comboPatCity.SelectedValue = defaultCity
                Else
                    comboPatCity.SelectedIndex = -1
                End If
                comboPatCity.Enabled = True
                comboPatCity.BackColor = Color.White
            Else
                comboPatCity.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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

    Public Function GetPatientDetailsById(ByVal Id As Int32) As Boolean
        patientService = New PatientService()
        Dim dtbl As Data.ProLabDB.PatientsDataTable = Nothing
        Dim status As Boolean
        Try
            status = patientService.GetPatientDetailsById(dtbl, Id)
            If status Then
                Call AssignToControl(dtbl)
            Else
                ClearPatientFormValues()
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
                txtPatientSearchByMobile.Text = .Mobile
                txtPatFName.Text = .FirstName
                txtPatLName.Text = .Lastname
                txtPatAddress1.Text = .Address1
                txtPatAddress2.Text = .Address2
                txtPatMobile.Text = .Mobile
                txtPatLandLine.Text = .LandLine
                txtPatEmail.Text = .Email
                comboPatCountry.SelectedValue = .CountryId
                comboPatState.SelectedValue = .StateId
                comboPatCity.SelectedValue = .CityId
                dtPatDOB.Value = .DOB
                txtPatAge.Text = .Age
                txtPatZipcode.Text = .Zipcode
                txtPatOccupation.Text = .Occupation
                If (.Gender = "Male") Then
                    rbtnMale.Checked = True
                Else
                    rbtnFemale.Checked = True
                End If
            End With

            lblPatientMode.Text = "Edit Mode"
            btnPatDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RequiredFieldBackground()
        Try
            txtPatFName.BackColor = Color.LightYellow
            txtPatLName.BackColor = Color.LightYellow
            txtPatAddress1.BackColor = Color.LightYellow
            txtPatMobile.BackColor = Color.LightYellow
            txtPatAge.BackColor = Color.LightYellow
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPatFName_TextChanged(sender As Object, e As EventArgs) Handles txtPatFName.TextChanged
        txtPatFName.BackColor = Color.White
    End Sub

    Private Sub txtPatLName_TextChanged(sender As Object, e As EventArgs) Handles txtPatLName.TextChanged
        txtPatLName.BackColor = Color.White
    End Sub

    Private Sub txtPatMobile_TextChanged(sender As Object, e As EventArgs) Handles txtPatMobile.TextChanged
        txtPatMobile.BackColor = Color.White
    End Sub

    Private Sub txtPatAge_TextChanged(sender As Object, e As EventArgs) Handles txtPatAge.TextChanged
        txtPatAge.BackColor = Color.White
    End Sub

    Private Sub txtPatientSearchByMobile_LostFocus(sender As Object, e As EventArgs) Handles txtPatientSearchByMobile.LostFocus
        Try
            If (txtPatientSearchByMobile.Text IsNot "") Then
                LocateValues(txtPatientSearchByMobile.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidateFields() As Boolean
        Dim status As Boolean = True
        Dim fnameMsg As String = ""
        Dim lnameMsg As String = ""
        Dim addressMsg As String = ""
        Dim countryMsg As String = ""
        Dim cityMsg As String = ""
        Dim stateMsg As String = ""
        Dim mobileMsg As String = ""
        Dim AgeMsg As String = ""
        patientService = New PatientService()
        Try
            If txtPatFName.Text.Trim = "" Then
                fnameMsg = "First name is requried" + vbCrLf
                txtPatFName.Focus()
                status = False
                txtPatFName.Focus()
            End If
            If txtPatLName.Text.Trim = "" Then
                lnameMsg = "Last name is requried" + vbCrLf
                status = False
                txtPatLName.Focus()
            End If

            If txtPatAddress1.Text.Trim = "" Then
                addressMsg = "Address is required" + vbCrLf
                status = False
                txtPatAddress1.Focus()
            End If

            If comboPatCountry.SelectedIndex = -1 Then
                countryMsg = "Country is required" + vbCrLf
                status = False
            End If
            If comboPatState.SelectedIndex = -1 Then
                stateMsg = "State is required" + vbCrLf
                status = False
            End If
            If comboPatCity.SelectedIndex = -1 Then
                cityMsg = "City is required" + vbCrLf
                status = False
            End If
            If txtPatMobile.Text.Trim = "" Then
                mobileMsg = "Mobile is requried" + vbCrLf
                status = False
                txtPatMobile.Focus()
            End If
            If txtPatAge.Text = "" Then
                AgeMsg = "Age is required" + vbCrLf
                status = False
                txtPatAge.Focus()
            End If

            If status = False Then
                MsgBox(fnameMsg + lnameMsg + addressMsg + countryMsg + stateMsg + cityMsg + mobileMsg + AgeMsg)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return status
    End Function

    Private Sub txtPatAddress1_TextChanged(sender As Object, e As EventArgs) Handles txtPatAddress1.TextChanged
        txtPatAddress1.BackColor = Color.White
    End Sub

    Private Sub txtPatMobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPatMobile.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtPatZipcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPatZipcode.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtPatLandLine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPatLandLine.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtPatientSearchByMobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPatientSearchByMobile.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
End Class