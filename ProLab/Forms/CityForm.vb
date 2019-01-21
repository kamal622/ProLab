Imports ProLab.Core.Common
Imports ProLab.Service
Imports ProLab.Data

Public Class CityForm
    Private commonService As CommonService
    Private CityId As Integer = 0

    Private Sub CityForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindCountry()
        CityId = 0
        chkCityActive.Checked = True
        lblCityMode.Text = "New Mode"
        btnCityDelete.Enabled = False
        txtCity.BackColor = Color.LightYellow
    End Sub

    Private Sub comboCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCountry.SelectedIndexChanged
        commonService = New CommonService()
        Dim countryId As Integer
        Try
            Dim dtbl As DataTable = Nothing
            countryId = comboCountry.SelectedValue
            BindState(countryId)
            comboCountry.BackColor = Color.White
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveCity_Click(sender As Object, e As EventArgs) Handles btnSaveCity.Click
        commonService = New CommonService()
        Try
            If (ValidateFields()) Then
                Dim countryId As Integer = comboCountry.SelectedValue
                Dim stateId As Integer = comboState.SelectedValue
                Dim CityName As String = txtCity.Text
                Dim IsActive As Boolean = chkCityActive.Checked
                Dim userId As Integer = User_ID
                commonService.SaveCity(CityId, countryId, stateId, CityName, IsActive, userId)
                ClearCityFiledValues()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCountry_Click(sender As Object, e As EventArgs) Handles btnAddCountry.Click
        Try
            Dim frmCountry As New CountryForm
            frmCountry.ShowDialog(Me)
            comboCountry.DataSource = Nothing
            BindCountry()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddState.Click
        Try
            Dim frmState As New StateForm
            frmState.ShowDialog(Me)
            Dim countryId As Integer
            countryId = comboCountry.SelectedValue
            BindCountry()
            BindState(countryId)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnCityClose_Click(sender As Object, e As EventArgs) Handles btnCityClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCityClear_Click(sender As Object, e As EventArgs) Handles btnCityClear.Click
        Try
            ClearCityFiledValues()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCity_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCity.KeyUp
        Try
            If e.KeyCode = Keys.F2 Then
                FindAllCity()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFindCity_Click(sender As Object, e As EventArgs) Handles btnFindCity.Click
        Try
            FindAllCity()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function LocateValues(ByVal Id As String) As Boolean
        commonService = New CommonService()
        Dim dtbl As Data.ProLabDB.CityDataTable = Nothing
        Try
            If Id IsNot "" Then
                commonService.GetCityById(dtbl, Id)
                Call AssignToControl(dtbl)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Private Sub AssignToControl(ByRef dtbl As ProLabDB.CityDataTable)
        Try
            With dtbl(0)
                CityId = .Id
                comboCountry.SelectedValue = .CountryId
                comboState.SelectedValue = .StateId
                txtCity.Text = .CityName
                If (.IsActive = "True") Then
                    chkCityActive.Checked = True
                Else
                    chkCityActive.Checked = False
                End If
            End With
            lblCityMode.Text = "Edit Mode"
            btnCityDelete.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCityDelete_Click(sender As Object, e As EventArgs) Handles btnCityDelete.Click
        Try
            commonService = New CommonService()
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete city?", Product_Name, MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If (CityId > 0) Then
                    commonService.DeleteCity(CityId)
                    ClearCityFiledValues()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FindAllCity()
        Try
            Dim Qry As String
            Dim Colwidth As String = ""
            Qry = "select ct.Id,ct.CityName,ct.IsActive,s.StateName,c.CountryName from City ct join State s on s.Id=ct.StateId join Country c on ct.CountryId=c.Id "
            Call ShowSearchengine(txtCity, Qry, 0, "CityName", Colwidth,, 0)

            If IsFormClear Then
                ClearCityFiledValues()
            End If

            If Not LocateValues(mId) Then
                txtCity.Focus() : Exit Sub
            Else
                txtCity.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub BindCountry()
        Try
            commonService = New CommonService()
            Dim dtbl As Data.ProLabDB.CountryDataTable = Nothing
            Dim country = commonService.GetAllCountry(dtbl)
            comboCountry.ValueMember = "Id"
            comboCountry.DisplayMember = "CountryName"
            comboCountry.DataSource = dtbl
            comboCountry.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindState(ByVal CountryId)
        Dim status As Boolean
        Dim dtbl As DataTable = Nothing
        status = commonService.GetAllStateByCountryId(dtbl, CountryId)
        If (status) Then
            comboState.DataSource = dtbl
            comboState.ValueMember = "Id"
            comboState.DisplayMember = "StateName"
            comboState.Enabled = True
        Else
            comboState.SelectedIndex = -1

        End If
    End Sub

    Private Sub comboState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboState.SelectedIndexChanged
        comboState.BackColor = Color.White
    End Sub

    Private Sub ClearCityFiledValues()
        comboCountry.SelectedIndex = -1
        comboState.SelectedIndex = -1
        txtCity.Text = ""
        CityId = 0
        lblCityMode.Text = "New Mode"
        btnCityDelete.Enabled = False
        comboState.DataSource = Nothing
        txtCity.BackColor = Color.LightYellow
        comboCountry.BackColor = Color.LightYellow
        comboState.BackColor = Color.LightYellow
    End Sub

    Private Function ValidateFields() As Boolean
        Dim status As Boolean = True
        Dim cityMsg As String = ""
        Dim countryMsg As String = ""
        Dim stateMsg As String = ""
        Try
            If txtCity.Text.Trim = "" Then
                cityMsg = "City is requried" + vbCrLf
                status = False
                txtCity.Focus()
            End If
            If comboCountry.SelectedIndex = -1 Then
                countryMsg = "Country is required" + vbCrLf
                status = False
            End If
            If comboState.SelectedIndex = -1 Then
                stateMsg = "State is required" + vbCrLf
                status = False
            End If
            If status = False Then
                MsgBox(countryMsg + stateMsg + cityMsg)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return status
    End Function

End Class