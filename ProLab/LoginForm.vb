Imports ProLab.Core.Common
Imports ProLab.Service

Public Class LoginForm
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private commonService As CommonService

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim msg As String = ""
            User_Name = UsernameTextBox.Text
            User_Password = PasswordTextBox.Text
            commonService = New CommonService
            If (commonService.IsValidUser(msg)) Then
                PLMDIForm.Show()
                Me.Hide()
            Else
                MessageBox.Show(msg, "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        Application.Exit()
    End Sub

End Class
