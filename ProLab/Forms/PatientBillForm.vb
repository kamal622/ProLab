Imports ProLab.Service.PatientService
Imports ProLab.Service.PatientTransctionService
Imports ProLab.Service.PatientBillService
Imports ProLab.Service.PatientBill
Imports ProLab.Core.Common
Imports ProLab.Service
Imports ProLab.Data

Public Class PatientBillForm

    Private patientService As PatientService
    Private patientTransactionService As PatientTransctionService
    Private patientBillService As PatientBillService
    Private PatientTranctionId As Integer = 0
    Private PatientId As Integer = 0
    Private PatientBillId As Integer = 0
    Private totalAmount As String = ""
    Private afterDiscountAmount As String = ""
    Private Amount As Integer = 0
    Private depositeAmount As Integer = 0
    Dim billtransctionlist As New List(Of PatientBill)

    Private Sub PatientBillForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSelectTranasction.Enabled = False
    End Sub

    Private Sub btnFindBillByMobile_Click(sender As Object, e As EventArgs) Handles btnFindBillByMobile.Click
        txtBillFindByMobile.Text = ""
        FindAllPatientDetailsForBills()
    End Sub

    Private Sub txtBillFindByMobile_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBillFindByMobile.KeyUp
        If e.KeyCode = Keys.F2 Then
            FindAllPatientDetailsForBills()
        End If
    End Sub

    Private Sub FindAllPatientDetailsForBills()
        Try
            Dim Qry As String
            Dim Colwidth As String = ""
            If Not LocatePatientValues(txtBillFindByMobile.Text.Trim) Then
                Qry = "select p.Id,p.FirstName,p.Lastname,p.Mobile,p.LandLine,p.Email,p.Address1,p.Address2,ct.CityName ,s.StateName,c.CountryName,p.Age,p.Gender,p.DOB,p.Occupation,p.Zipcode from Patients p join City ct on p.CityId=ct.Id join State s on p.StateId=s.Id join Country c on p.CountryId=c.Id"
                Call ShowSearchengine(txtBillFindByMobile, Qry, 0, "FirstName", Colwidth, "", 0)
                If mId > 0 Then
                    PatientId = mId
                    GetPatientDetailsById(mId)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function LocatePatientValues(ByVal Mobile As String) As Boolean
        Dim result As Boolean = False
        Try
            patientService = New PatientService()
            Dim dtbl As Data.ProLabDB.PatientsDataTable = Nothing
            result = patientService.GetPatientDetailsByMobile(dtbl, Mobile)
            If result Then
                Call AssignToBillFieldsControl(dtbl)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

    Public Function GetPatientDetailsById(ByVal Id As Integer) As Boolean
        patientService = New PatientService()
        Dim dtbl As Data.ProLabDB.PatientsDataTable = Nothing
        Dim status As Boolean
        Try
            status = patientService.GetPatientDetailsById(dtbl, Id)
            If status Then
                Call AssignToBillFieldsControl(dtbl)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Private Sub AssignToBillFieldsControl(ByRef dtbl As ProLabDB.PatientsDataTable)
        Try
            With dtbl(0)
                PatientId = .Id
                txtBillFindByMobile.Text = .Mobile
                lblBillPatFullName.Text = .FirstName + "  " + .Lastname
                lblBillPatAddress.Text = .Address1
                lblBillPatMobile.Text = .Mobile
                btnSelectTranasction.Enabled = True
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBillFindByMobile_LostFocus(sender As Object, e As EventArgs) Handles txtBillFindByMobile.LostFocus
        If (txtBillFindByMobile.Text IsNot "") Then
            LocatePatientValues(txtBillFindByMobile.Text)
        End If
    End Sub

    Private Sub txtDiscountByPercentage_TextChanged(sender As Object, e As EventArgs) Handles txtDiscountByPercentage.TextChanged
        Try
            Dim percentage As Decimal = 0.0
            Decimal.TryParse(txtDiscountByPercentage.Text, percentage)

            If percentage > 0 Then
                Bill_DiscountAmount = (Val(txtDiscountByPercentage.Text) / 100) * totalAmount
                afterDiscountAmount = FormatNumber(lblTotalPayableAmount.Text)
                txtDiscountAmount.Text = Val(Bill_DiscountAmount)
                lblDiscountAmount.Text = FormatNumber(Val(Bill_DiscountAmount))
                If Val(lblPatUnpaidAmount.Text) <> 0 Then
                    lblRemainingBalance.Text = FormatNumber(Val(lblPatUnpaidAmount.Text) - Val(lblDiscountAmount.Text) - Val(lblPatPaidAmount.Text))
                End If
                lblTotalPayableAmount.Text = FormatNumber(lblRemainingBalance.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbtnPaymentCheque_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPaymentCheque.CheckedChanged
        Try
            If PatientBillId = 0 Then
                If rbtnPaymentCheque.Checked Then
                    Dim frmcheque As New BillChequeForm
                    frmcheque.ShowDialog(Me)
                    Bill_ChequeNo = frmcheque.chequeNo
                    Bill_BankName = frmcheque.bankNam
                    Bill_ChequeDate = frmcheque.chequeDate
                    Bill_IFSCCode = frmcheque.ifscCode

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBillClear_Click(sender As Object, e As EventArgs) Handles btnBillClear.Click
        Try
            ClearBillFormFieldsValues()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBillClose_Click(sender As Object, e As EventArgs) Handles btnBillClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGenerateBill_Click(sender As Object, e As EventArgs) Handles btnGenerateBill.Click
        Try
            If PatientBillId > 0 Then
                Dim frmreceipt = New PatientBillReceipt()
                frmreceipt.ShowDialog()
            Else
                If ValidationData() Then
                    patientBillService = New PatientBillService()
                    Dim msg As String = ""
                    Bill_BillId = txtBillNo.Text.Trim
                    Bill_PatientId = PatientId
                    Bill_TransactionId = PatientTranctionId
                    Bill_TotalAmount = lblTotalBillAmount.Text
                    Bill_DiscountPercentage = txtDiscountByPercentage.Text
                    Bill_DiscountAmount = txtDiscountAmount.Text
                    Bill_Status = ""
                    Bill_IsCancel = False
                    Bill_Remarks = txtBillRemarks.Text
                    Bill_InvoiceDate = dtInvoiceDate.Value
                    If rbtnPaymentCash.Checked Then
                        Bill_PaymentMode = rbtnPaymentCash.Text
                    Else
                        Bill_PaymentMode = rbtnPaymentCheque.Text
                    End If
                    Dim transactionId As Integer
                    Dim serviceTransctionId As Integer
                    With dataGridPatientBill
                        For i = 0 To .Rows.Count - 1
                            transactionId = .Rows(i).Cells("PatientTransactionId").Value
                            serviceTransctionId = .Rows(i).Cells("Id").Value
                            If transactionId <> 0 Then
                                billtransctionlist.Add(New PatientBill(0, 0, transactionId, serviceTransctionId))
                            End If
                        Next
                    End With
                    bPatientId = 0
                    Dim obj As List(Of PatientBill) = billtransctionlist
                    Bill_UserId = User_ID

                    patBillId = patientBillService.SavePatientBill(msg, billtransctionlist, Bill_UserId)
                    If patBillId > 0 Then
                        bPatientId = PatientId
                        patBillId = patBillId
                        ClearBillFormFieldsValues()
                        Dim frmreceipt = New PatientBillReceipt()
                        frmreceipt.ShowDialog()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidationData() As Boolean
        Dim status As Boolean = True
        If String.IsNullOrEmpty(txtBillNo.Text) Then
            status = False
            MsgBox("Fill all Required Data")
        ElseIf patientBillService.IsBillNumberExists(txtBillNo.Text.Trim) Then
            status = False
            MsgBox("Bill number already exists.")
        Else
            status = True
        End If
        Return status
    End Function

    Public Function GetPatientBillDetails(ByVal BillId As Integer)
        Dim result As Boolean = False
        Try
            patientBillService = New PatientBillService()
            Dim dtbl As Data.ProLabDB.PatientBillsDataTable = Nothing
            result = patientBillService.GetPatientDetailsById(BillId, dtbl)
            If result Then
                Call AssignToControl(dtbl)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

    Private Sub AssignToControl(ByRef dtbl As ProLabDB.PatientBillsDataTable)
        Try
            With dtbl(0)
                txtBillNo.Text = .BillNo
                txtBillRemarks.Text = .Remarks
                totalAmount = .TotalAmount
                txtDiscountByPercentage.Text = .DiscountPercentage
                txtDiscountAmount.Text = .DiscountAmount
                lblPatUnpaidAmount.Text = .TotalAmount
                lblDiscountAmount.Text = .DiscountAmount
                dtInvoiceDate.Value = .InvoiceDate
                lblTotalBillAmount.Text = .TotalAmount
                If (.PaymentMode = "Cash") Then
                    rbtnPaymentCash.Checked = True
                Else
                    rbtnPaymentCheque.Checked = True
                End If
                lblPatientBillMode.Text = "Edit Mode"
                PatientBillId = .Id
                lblTotalPayableAmount.Text = .TotalAmount - .DiscountAmount
                'txtBillNo.Enabled = True
                'txtBillRemarks.Enabled = True
                'txtDiscountAmount.Enabled = True
                'txtDiscountByPercentage.Enabled = True
                btnSelectTranasction.Enabled = False
                rbtnPaymentCash.Enabled = False
                rbtnPaymentCheque.Enabled = False
                dtInvoiceDate.Enabled = False
                dataGridPatientBill.Enabled = False
                txtBillNo.ReadOnly = True
                txtDiscountAmount.ReadOnly = True
                txtDiscountByPercentage.ReadOnly = True
                txtBillRemarks.ReadOnly = True
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearBillFormFieldsValues()
        Try
            txtBillFindByMobile.Text = ""
            txtBillRemarks.Text = ""
            rbtnPaymentCash.Checked = True
            PatientId = 0
            PatientTranctionId = 0
            afterDiscountAmount = 0
            Amount = 0
            depositeAmount = 0
            txtBillFindByMobile.Text = ""
            lblBillPatFullName.Text = ""
            lblBillPatAddress.Text = ""
            lblBillPatMobile.Text = ""
            'lblBillPatLandLine.Text = ""
            lblTotalBillAmount.Text = "0000.00"
            lblTotalPayableAmount.Text = "0000.00"
            lblPatPaidAmount.Text = "0000.00"
            lblPatUnpaidAmount.Text = "0000.00"
            lblRemainingBalance.Text = "0000.00"
            txtDiscountAmount.Text = 0
            txtDiscountByPercentage.Text = 0
            totalAmount = 0000.00
            txtBillNo.Text = ""
            btnSelectTranasction.Enabled = False
            txtBillNo.ReadOnly = True
            txtDiscountByPercentage.ReadOnly = True
            txtDiscountAmount.ReadOnly = True
            txtBillRemarks.ReadOnly = True
            rbtnPaymentCash.Enabled = True
            rbtnPaymentCheque.Enabled = True
            dataGridPatientBill.DataSource = Nothing
            dataGridPatientBill.Rows.Clear()
            billtransctionlist = New List(Of PatientBill)
            Bill_ChequeNo = ""
            Bill_IFSCCode = ""
            Bill_ChequeDate = DateTime.Now
            Bill_BankName = ""
            PatientBillId = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetPatientBillById(ByVal BillId As Integer) As Boolean
        Try
            lblPatPaidAmount.Text = 0
            lblPatUnpaidAmount.Text = 0
            Dim trasId As Integer = 0
            patientBillService = New PatientBillService()
            Dim dtbl As DataTable = Nothing
            Dim status As Boolean
            status = patientBillService.GetPatientBillById(BillId, dtbl)
            If status Then
                dataGridPatientBill.DataSource = dtbl
                dataGridPatientBill.Columns("Id").Visible = False
                dataGridPatientBill.Columns("BillId").Visible = False
                dataGridPatientBill.Columns("PatientTransactionId").Visible = False
                dataGridPatientBill.Columns("TransactionDate").DefaultCellStyle.Format = "dd-MM-yyyy"
                dataGridPatientBill.ReadOnly = True
                With dataGridPatientBill
                    For i = 0 To .Rows.Count - 1
                        If Val(.Rows(i).Cells("PatientTransactionId").Value) <> 0 Then
                            trasId = Val(.Rows(i).Cells("PatientTransactionId").Value)
                        End If
                    Next
                    patientTransactionService = New PatientTransctionService()
                    Dim amount As Decimal = 0
                    patientTransactionService.GetDepositeAmountById(trasId, amount)
                    lblPatPaidAmount.Text = amount
                    lblPatUnpaidAmount.Text = 0
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function GetPatientBillDeatils(ByVal BillId As Integer, ByVal PatientId As Integer)
        Try
            If BillId > 0 Then
                PatientBillId = BillId
                Call GetPatientDetailsById(PatientId)
                Call GetPatientBillById(BillId)
                Call GetPatientBillDetails(BillId)

                btnBillClear.Enabled = False
                btnSelectTranasction.Enabled = False

                lblTotalPayableAmount.Text = FormatNumber(Val(lblPatUnpaidAmount.Text) - Val(lblPatPaidAmount.Text) - Val(lblDiscountAmount.Text))
                lblRemainingBalance.Text = FormatNumber(lblTotalPayableAmount.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Return 0
    End Function

    Private Sub btnSelectTranasction_Click(sender As Object, e As EventArgs) Handles btnSelectTranasction.Click
        Try
            dataGridPatientBill.DataSource = Nothing
            lblTotalBillAmount.Text = 0
            Dim frmTransactionUtility As New PatientTransactionUtilityForm
            frmTransactionUtility.GetPatientTransactionByPatientId(PatientId)
            frmTransactionUtility.btnFindPatient.Enabled = False
            frmTransactionUtility.btnSearchTransactions.Enabled = False
            frmTransactionUtility.txtSearchName.ReadOnly = True
            frmTransactionUtility.ShowDialog(Me)
            Dim dtbl As DataTable = Nothing
            patientTransactionService = New PatientTransctionService()
            If (patientTransactionService.GetPatientTransctionForBill(patientTransId, dtbl)) Then
                dataGridPatientBill.DataSource = Nothing
                dataGridPatientBill.DataSource = dtbl
                dataGridPatientBill.Columns("Id").Visible = False
                dataGridPatientBill.Columns("BillId").Visible = False
                dataGridPatientBill.Columns("PatientTransactionId").Visible = False
                dataGridPatientBill.Columns("TransactionDate").DefaultCellStyle.Format = "dd-MM-yyyy"
                dataGridPatientBill.Refresh()
                With dataGridPatientBill
                    For i = 0 To .Rows.Count - 1
                        lblTotalBillAmount.Text = Val(.Rows(i).Cells("Amount").Value) + Val(lblTotalBillAmount.Text)
                        totalAmount = FormatNumber(Val(lblTotalBillAmount.Text))
                    Next
                End With
                Dim amount As Decimal = 0
                patientTransactionService.GetDepositeAmountById(patientTransId, amount)
                lblPatPaidAmount.Text = amount
                lblPatUnpaidAmount.Text = Val(lblTotalBillAmount.Text).ToString("F2")
                'lblTotalPayableAmount.Text = Val(lblTotalBillAmount.Text).ToString("F2")
                dataGridPatientBill.Enabled = False
                dataGridPatientBill.ReadOnly = True
                lblTotalPayableAmount.Text = FormatNumber(Val(lblPatUnpaidAmount.Text) - Val(lblPatPaidAmount.Text))
                lblRemainingBalance.Text = FormatNumber(lblTotalPayableAmount.Text)
                txtBillNo.ReadOnly = False
                txtDiscountByPercentage.ReadOnly = False
                txtDiscountAmount.ReadOnly = False
                txtBillRemarks.ReadOnly = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDiscountAmount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscountAmount.TextChanged
        Try
            If txtDiscountAmount.Text IsNot Nothing Then
                Bill_DiscountAmount = (Val(txtDiscountAmount.Text))
                txtDiscountAmount.Text = Val(Bill_DiscountAmount)
                lblDiscountAmount.Text = FormatNumber(Val(Bill_DiscountAmount))
                If Val(lblPatUnpaidAmount.Text) <> 0 Then
                    lblRemainingBalance.Text = FormatNumber(Val(lblPatUnpaidAmount.Text) - Val(lblDiscountAmount.Text) - Val(lblPatPaidAmount.Text))
                End If
                lblTotalPayableAmount.Text = FormatNumber(lblRemainingBalance.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDiscountByPercentage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscountByPercentage.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtDiscountAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscountAmount.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtBillFindByMobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBillFindByMobile.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtBillNo_TabIndexChanged(sender As Object, e As EventArgs) Handles txtBillNo.TabIndexChanged
        patientBillService = New PatientBillService()
        Dim Bilno As String = txtBillNo.Text
        Dim oldBilno As String
    End Sub

End Class