Imports ProLab.Service
Imports ProLab.Data
Imports ProLab.Service.PatientBill

Public Class BillChequeForm
    Public chequeNo As String = ""
    Public chequeDate As Date
    Public bankNam As String = ""
    Public ifscCode As String = ""
    Public branchName As String = ""

    Private Sub BillChequeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chequeNo = 0
        chequeDate = dtChequeDate.Value
        bankNam = ""
        ifscCode = ""
    End Sub

    Private Sub btnChequeSave_Click(sender As Object, e As EventArgs) Handles btnChequeSave.Click
        Dim bankName As String = ""
        Dim iFSC As String = ""
        Dim checkNo As String = ""
        Dim status As Boolean = True
        If txtBankName.Text.Trim = "" Then
            bankName = "Bank name is requried" + vbCrLf
            txtBankName.Focus()
            status = False
        End If
        If txtIFSCCode.Text.Trim = "" Then
            iFSC = "IFSC Code is requried" + vbCrLf
            txtIFSCCode.Focus()
            status = False
        End If
        If txtChequeNo.Text.Trim = "" Then
            checkNo = "Check Number is required" + vbCrLf
            txtChequeNo.Focus()
            status = False
        End If
        If status = False Then
            MsgBox(bankName + iFSC + checkNo)
        End If
        bankNam = txtBankName.Text
        ifscCode = txtIFSCCode.Text
        chequeNo = txtChequeNo.Text
        chequeDate = dtChequeDate.Value
        Me.Close()
    End Sub

    Private Sub btnChequeClear_Click(sender As Object, e As EventArgs) Handles btnChequeClear.Click
        dtChequeDate.Value = DateTime.Now
        txtBankName.Text = ""
        txtIFSCCode.Text = ""
        txtChequeNo.Text = ""
    End Sub

    Private Sub btnChequeClose_Click(sender As Object, e As EventArgs) Handles btnChequeClose.Click
        Me.Close()
    End Sub

End Class