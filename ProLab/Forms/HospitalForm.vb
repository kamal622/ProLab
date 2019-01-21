Imports ProLab.Service.ServiceMaster
Imports ProLab.Core.Common
Imports ProLab.Service
Imports ProLab.Data

Public Class HospitalForm

    Private commonService As CommonService
    Private masterService As MasterService
    Private HospitalId As Integer = 0

    Private Sub HospitalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RequiredHospitalFieldBackground()
        HospitalId = 0
        btnHospitalDelete.Enabled = False
        BindCountry()
    End Sub

    Private Sub btnFindHospital_Click(sender As Object, e As EventArgs) Handles btnFindHospital.Click
        FindAllHospital()
    End Sub

    Private Sub txtFindHospital_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFindHospital.KeyUp
        If e.KeyCode = Keys.F2 Then
            FindAllHospital()
        End If
    End Sub

    Public Function LocateValues(ByVal Name As String) As Boolean
        masterService = New MasterService()
        Dim dtbl As Data.ProLabDB.HospitalsDataTable = Nothing
        Dim status As Boolean
        Try
            status = masterService.GetHospitalByName(dtbl, Name)
            If status Then
                Call AssignToControl(dtbl)
            Else
                ClearHospitalFieldValues()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Private Sub btnAddHCity_Click(sender As Object, e As EventArgs)
        Try
            Dim frm As New CityForm
            frm.ShowDialog(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFindHospital_LostFocus(sender As Object, e As EventArgs) Handles txtFindHospital.LostFocus
        Try
            If (txtFindHospital.Text IsNot "") Then
                LocateValues(txtFindHospital.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtHospitalName_TextChanged(sender As Object, e As EventArgs) Handles txtHospitalName.TextChanged
        txtHospitalName.BackColor = Color.White
    End Sub

    Private Sub txtHospitalAddress1_TextChanged(sender As Object, e As EventArgs) Handles txtHospitalAddress1.TextChanged
        txtHospitalAddress1.BackColor = Color.White
    End Sub

    Private Sub txtHospitalPhone1_TextChanged(sender As Object, e As EventArgs) Handles txtHospitalPhone1.TextChanged
        txtHospitalPhone1.BackColor = Color.White
    End Sub

    Private Sub btnHospitalSave_Click(sender As Object, e As EventArgs) Handles btnHospitalSave.Click
        Try
            Dim msg As String = ""
            Dim userId As Integer

            Dim status As Boolean = True
            Dim HospitalNameMsg As String = ""
            Dim HospitalAddressMsg As String = ""
            Dim HospitalPhoneMsg As String = ""
            Dim HospitalCityMsg As String = ""
            If txtHospitalName.Text.Trim = "" Then
                HospitalNameMsg = "Hospital name is requried" + vbCrLf
                txtHospitalName.Focus()
                status = False
            End If
            If txtHospitalAddress1.Text.Trim = "" Then
                HospitalAddressMsg = "Address1 is requried" + vbCrLf
                txtHospitalAddress1.Focus()
                status = False
            End If
            If comboHositalCity.SelectedIndex = -1 Then
                HospitalCityMsg = "City is required" + vbCrLf
                comboHositalCity.Focus()
                status = False
            End If
            If status = False Then
                MsgBox(HospitalNameMsg + HospitalAddressMsg + HospitalPhoneMsg + HospitalCityMsg)
            End If

            Hospital_Id = HospitalId
            Hospital_Name = txtHospitalName.Text
            Hospital_Address1 = txtHospitalAddress1.Text
            Hospital_Address2 = txtHospitalAddress2.Text
            If txtHospitalPhone1.Text Is Nothing Then
                Hospital_Phone1 = vbNull
            Else
                Hospital_Phone1 = txtHospitalPhone1.Text
            End If
            If txtHospitalPhone2.Text Is Nothing Then
                Hospital_Phone2 = vbNull
            Else
                Hospital_Phone2 = txtHospitalPhone2.Text
            End If
            Hospital_Country = comboHositalCountry.SelectedValue
            Hospital_State = comboHositalState.SelectedValue
            Hospital_City = comboHositalCity.SelectedValue
            userId = User_ID
            masterService = New MasterService()
            If (masterService.SaveHospital(msg, userId)) Then
                MsgBox(msg)
                ClearHospitalFieldValues()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHospitalDelete_Click(sender As Object, e As EventArgs) Handles btnHospitalDelete.Click
        masterService = New MasterService()
        Try
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete hospital?", Product_Name, MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If (HospitalId > 0) Then
                    masterService.DeleteHospitalById(HospitalId)
                    ClearHospitalFieldValues()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHospitalClear_Click(sender As Object, e As EventArgs) Handles btnHospitalClear.Click
        Try
            ClearHospitalFieldValues()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHospitalClose_Click(sender As Object, e As EventArgs) Handles btnHospitalClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub comboHositalCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboHositalCountry.SelectedIndexChanged
        commonService = New CommonService()
        Dim dtbl As DataTable = Nothing
        Dim CountryId As Integer
        comboHositalState.DataSource = Nothing
        Try
            CountryId = comboHositalCountry.SelectedValue
            BindState(CountryId)
            comboHositalCountry.BackColor = Color.White
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub comboHositalState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboHositalState.SelectedIndexChanged
        commonService = New CommonService()
        Dim countryId As Integer
        Dim stateId As Integer
        comboHositalCity.DataSource = Nothing
        Try
            countryId = comboHositalCountry.SelectedValue
            stateId = comboHositalState.SelectedValue
            BindCity(countryId, stateId)
            comboHositalState.BackColor = Color.White
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindCountry()
        Try
            commonService = New CommonService()
            Dim defaultCountry As String = commonService.GetDefaultCountry()
            Dim dtbl As Data.ProLabDB.CountryDataTable = Nothing
            Dim country = commonService.GetAllCountry(dtbl)
            comboHositalCountry.ValueMember = "Id"
            comboHositalCountry.DisplayMember = "CountryName"
            comboHositalCountry.DataSource = dtbl
            If defaultCountry IsNot Nothing Then
                comboHositalCountry.SelectedValue = defaultCountry
            Else
                comboHositalCountry.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindState(ByVal CountryId)
        Try
            commonService = New CommonService()
            Dim defaultState As String = commonService.GetDefaultState()
            Dim status As Boolean
            Dim dtbl As Data.ProLabDB.StateDataTable = Nothing
            status = commonService.GetAllStateByCountryId(dtbl, CountryId)
            If (status) Then
                comboHositalState.ValueMember = "Id"
                comboHositalState.DisplayMember = "StateName"
                comboHositalState.Enabled = True
                comboHositalState.DataSource = dtbl
                If defaultState IsNot Nothing Then
                    comboHositalState.SelectedValue = defaultState
                Else
                    comboHositalState.SelectedIndex = 0
                End If
            Else
                comboHositalState.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindCity(ByVal countryId, ByVal stateId)
        Try
            commonService = New CommonService()
            Dim defaultCity As String = commonService.GetDefaultCity()
            Dim city = commonService.GetAllCityByStateId(countryId, stateId)
            If (city.Rows.Count > 0) Then
                comboHositalCity.DataSource = city
                comboHositalCity.ValueMember = "Id"
                comboHositalCity.DisplayMember = "CityName"
                If defaultCity IsNot Nothing Then
                    comboHositalCity.SelectedValue = defaultCity
                Else
                    comboHositalCity.SelectedIndex = 0
                End If
                comboHositalCity.BackColor = Color.White
            Else
                    comboHositalCity.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidateHospitalFormFields() As Boolean
        Dim status As Boolean = True
        Dim HospitalNameMsg As String = ""
        Dim HospitalAddressMsg As String = ""
        Dim HospitalPhoneMsg As String = ""
        Dim HospitalCityMsg As String = ""
        Try
            If txtHospitalName.Text.Trim = "" Then
                HospitalNameMsg = "Hospital name is requried" + vbCrLf
                txtHospitalName.Focus()
                status = False
            End If

            If txtHospitalAddress1.Text.Trim = "" Then
                HospitalAddressMsg = "Address1 is requried" + vbCrLf
                txtHospitalAddress1.Focus()
                status = False
            End If

            If comboHositalCity.SelectedIndex = -1 Then
                HospitalCityMsg = "City is required" + vbCrLf
                comboHositalCity.Focus()
                status = False
            End If

            If status = False Then
                MsgBox(HospitalNameMsg + HospitalAddressMsg + HospitalPhoneMsg + HospitalCityMsg)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return status
    End Function

    Private Sub RequiredHospitalFieldBackground()
        txtHospitalName.BackColor = Color.LightYellow
        txtHospitalAddress1.BackColor = Color.LightYellow
        txtHospitalPhone1.BackColor = Color.LightYellow
    End Sub

    Private Sub FindAllHospital()
        Try
            Dim Qry As String
            Dim Colwidth As String = ""
            If Not LocateValues(txtFindHospital.Text.Trim) Then
                Qry = "select a.Id,a.Name,a.Address1,a.Address2,a.Phone1,a.Phone2,b.CountryName,c.StateName,d.CityName from Hospitals a join Country b on a.CountryId=b.Id join State c on a.StateId=c.id join City d on a.CityId=d.Id"
                Call ShowSearchengine(txtFindHospital, Qry, 0, "Name", Colwidth,, 0)
                If mId > 0 Then
                    GetHospitalDetailsById(mId)
                End If
                If IsFormClear Then
                    ClearHospitalFieldValues()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AssignToControl(ByRef dtbl As ProLabDB.HospitalsDataTable)
        Try
            With dtbl(0)
                HospitalId = .Id
                txtFindHospital.Text = .Name
                comboHositalCountry.SelectedValue = .CountryId
                comboHositalState.SelectedValue = .StateId
                comboHositalCity.SelectedValue = .CityId
                txtHospitalName.Text = .Name
                txtHospitalAddress1.Text = .Address1
                txtHospitalAddress2.Text = .Address2
                txtHospitalPhone1.Text = .Phone1
                txtHospitalPhone2.Text = .Phone2
            End With
            lblHospitalMode.Text = "Edit Mode"
            btnHospitalDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetHospitalDetailsById(ByVal Id As Int32) As Boolean
        masterService = New MasterService()
        Dim dtbl As Data.ProLabDB.HospitalsDataTable = Nothing
        Dim status As Boolean
        Try
            status = masterService.GetHospitalById(dtbl, Id)
            If status Then
                Call AssignToControl(dtbl)
            Else
                ClearHospitalFieldValues()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Private Sub ClearHospitalFieldValues()
        txtFindHospital.Text = ""
        txtHospitalName.Text = ""
        txtHospitalAddress1.Text = ""
        txtHospitalAddress2.Text = ""
        txtHospitalPhone1.Text = ""
        txtHospitalPhone2.Text = ""
        BindCountry()
        HospitalId = 0
        btnHospitalDelete.Enabled = False
        txtFindHospital.Focus()
        RequiredHospitalFieldBackground()
    End Sub

    Private Sub btnAddHCity_Click_2(sender As Object, e As EventArgs) Handles btnAddHCity.Click
        Try
            Dim city As New CityForm
            Dim oldForm = Application.OpenForms.OfType(Of CountryForm)
            If oldForm.Any Then
                oldForm.First.Focus()
            Else
                city.ShowDialog(Me)
                Dim countryId As Integer = comboHositalCountry.SelectedValue
                Dim stateId As Integer = comboHositalState.SelectedValue
                BindCity(countryId, stateId)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHAddCountry_Click(sender As Object, e As EventArgs) Handles btnHAddCountry.Click
        Try
            Dim country As New CountryForm
            Dim oldForm = Application.OpenForms.OfType(Of CountryForm)
            If oldForm.Any Then
                oldForm.First.Focus()
            Else
                country.ShowDialog(Me)
                BindCountry()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddHState_Click(sender As Object, e As EventArgs) Handles btnAddHState.Click
        Try
            Dim state As New StateForm
            Dim oldForm = Application.OpenForms.OfType(Of StateForm)
            If oldForm.Any Then
                oldForm.First.Focus()
            Else
                state.ShowDialog(Me)
                BindState(comboHositalCountry.SelectedValue)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class