Imports ProLab.Core.Common
Imports ProLab.Service
Imports ProLab.Data

Public Class CountryForm
    Private commonService As CommonService
    Private CountryId As Integer = 0

    Private Sub btnCountrySave_Click(sender As Object, e As EventArgs) Handles btnCountrySave.Click
        commonService = New CommonService()
        Try
            If ValidateCountryFormFields() Then
                Dim countryName As String = txtCountry.Text
                Dim IsActive As Boolean = chkCountryActive.Checked
                Dim userId As Integer = User_ID
                commonService.SaveCountry(CountryId, countryName, IsActive, userId)
                txtCountry.Text = ""
                txtCountry.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCountryClose_Click(sender As Object, e As EventArgs) Handles btnCountryClose.Click
        Me.Close()
    End Sub

    Private Sub txtCountry_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCountry.KeyUp
        Try
            If e.KeyCode = Keys.F2 Then
                FindAllCountry()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FindCountry_Click(sender As Object, e As EventArgs) Handles FindCountry.Click
        Try
            FindAllCountry()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function LocateValues(ByVal Id As String) As Boolean
        commonService = New CommonService()
        Dim dtbl As Data.ProLabDB.CountryDataTable = Nothing
        Try
            If Id IsNot "" Then
                commonService.GetAllCountryById(dtbl, Id)
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

    Private Sub AssignToControl(ByRef dtbl As ProLabDB.CountryDataTable)
        Try
            With dtbl(0)
                CountryId = .Id
                txtCountry.Text = .CountryName
                If (.IsActive = "True") Then
                    chkCountryActive.Checked = True
                Else
                    chkCountryActive.Checked = False
                End If
            End With
            lblCountryMode.Text = "Edit Mode"
            btnCoutryDelete.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CountryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCoutryDelete.Enabled = False
        CountryId = 0
        txtCountry.Text = ""
        txtCountry.BackColor = Color.LightYellow
    End Sub

    Private Sub btnCoutryDelete_Click(sender As Object, e As EventArgs) Handles btnCoutryDelete.Click
        Try
            commonService = New CommonService()
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete country?", Product_Name, MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If (CountryId > 0) Then
                    commonService.DeleteCountry(CountryId)
                    txtCountry.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FindAllCountry()
        Try
            Dim Qry As String = "select Id,CountryName,IsActive from Country"
            Dim Colwidth As String = ""
            Call ShowSearchengine(txtCountry, Qry, 0, "CountryName", Colwidth,, 0)
            If IsFormClear Then
                txtCountry.Text = ""
            End If
            If mId > 0 Then
                LocateValues(mId)
            Else
                txtCountry.Focus() : Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidateCountryFormFields() As Boolean
        Dim status As Boolean = True
        Dim categoryMsg As String = ""
        Try
            If txtCountry.Text.Trim = "" Then
                categoryMsg = "Country name is requried" + vbCrLf
                txtCountry.Focus()
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

    Private Sub txtCountry_TextChanged(sender As Object, e As EventArgs) Handles txtCountry.TextChanged
        txtCountry.BackColor = Color.White
    End Sub
End Class