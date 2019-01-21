Imports ProLab.Core.Common
Imports ProLab.Service
Imports ProLab.Data


Public Class StateForm
    Private commonService As CommonService
    Private StateId As Integer = 0
    Private Sub StateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateCountryComboBoxValue()
        StateId = 0
        btnStateDelete.Enabled = False
        lblStateMode.Text = "New Mode"
        txtState.BackColor = Color.LightYellow
        comboCountry.BackColor = Color.LightYellow
    End Sub

    Private Sub btnStateClose_Click(sender As Object, e As EventArgs) Handles btnStateClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnStateSave_Click(sender As Object, e As EventArgs) Handles btnStateSave.Click
        commonService = New CommonService()
        Dim countryId As Integer
        Dim stateName As String
        Dim IsActive As Boolean
        Dim userId As Integer
        Try
            If (ValidateFields()) Then
                countryId = comboCountry.SelectedValue
                stateName = txtState.Text
                IsActive = chkStateActive.Checked
                userId = User_ID
                commonService.SaveState(StateId, countryId, stateName, IsActive, userId)
                'Me.Close()
                txtState.Text = ""
                comboCountry.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStateClear.Click
        Try
            ClearStateFormFieldValues()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtState_KeyUp(sender As Object, e As KeyEventArgs) Handles txtState.KeyUp
        Try
            If e.KeyCode = Keys.F2 Then
                FindAllState()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFindState_Click(sender As Object, e As EventArgs) Handles btnFindState.Click
        Try
            FindAllState()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function LocateValues(ByVal Id As String) As Boolean
        commonService = New CommonService()
        Dim dtbl As Data.ProLabDB.StateDataTable = Nothing
        Try
            If Id IsNot "" Then
                commonService.GetStateById(dtbl, Id)
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

    Private Sub AssignToControl(ByRef dtbl As ProLabDB.StateDataTable)
        Try
            With dtbl(0)
                StateId = .Id
                comboCountry.SelectedValue = .CountryId
                txtState.Text = .StateName
                If (.IsActive = "True") Then
                    chkStateActive.Checked = True
                Else
                    chkStateActive.Checked = False
                End If
            End With
            lblStateMode.Text = "Edit Mode"
            btnStateDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnStateDelete_Click(sender As Object, e As EventArgs) Handles btnStateDelete.Click
        Try
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete state?", Product_Name, MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                commonService = New CommonService()
                If (StateId > 0) Then
                    commonService.DeleteState(StateId)
                    txtState.Text = ""
                    comboCountry.SelectedIndex = -1
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddCountry_Click(sender As Object, e As EventArgs) Handles btnAddCountry.Click
        Dim frmCountry As New CountryForm
        frmCountry.ShowDialog(Me)
        UpdateCountryComboBoxValue()
    End Sub

    Private Sub FindAllState()
        Try
            Dim Qry As String
            Dim Colwidth As String = ""

            Qry = "select s.Id,s.StateName,c.CountryName,s.IsActive from State s join Country c on s.CountryId=c.Id "
            Call ShowSearchengine(txtState, Qry, 0, "StateName", Colwidth,, 0)
            If (mId > 0) Then
                LocateValues(mId)
            Else
                txtState.Focus()
            End If
            If IsFormClear Then
                ClearStateFormFieldValues()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UpdateCountryComboBoxValue()
        Try
            commonService = New CommonService()
            Dim dtbl As Data.ProLabDB.CountryDataTable = Nothing
            Dim country = commonService.GetAllCountry(dtbl)
            comboCountry.DataSource = dtbl
            comboCountry.ValueMember = "Id"
            comboCountry.DisplayMember = "CountryName"
            comboCountry.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub comboCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCountry.SelectedIndexChanged
        comboCountry.BackColor = Color.White
    End Sub

    Private Sub txtState_TextChanged(sender As Object, e As EventArgs) Handles txtState.TextChanged
        txtState.BackColor = Color.White
    End Sub

    Private Sub ClearStateFormFieldValues()
        txtState.Text = ""
        comboCountry.SelectedIndex = -1
        StateId = 0
        btnStateDelete.Enabled = False
        lblStateMode.Text = "New Mode"
        UpdateCountryComboBoxValue()
        txtState.BackColor = Color.LightYellow
        comboCountry.BackColor = Color.LightYellow
    End Sub

    Private Function ValidateFields() As Boolean
        Dim status As Boolean = True
        Dim countryMsg As String = ""
        Dim stateMsg As String = ""
        Try
            If comboCountry.SelectedIndex = -1 Then
                countryMsg = "Country is required" + vbCrLf
                status = False
            End If
            If txtState.Text.Trim = "" Then
                stateMsg = "State is requried" + vbCrLf
                status = False
                txtState.Focus()
            End If
            If status = False Then
                MsgBox(countryMsg + stateMsg)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return status
    End Function

End Class