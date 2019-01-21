Imports ProLab.Service.PatientBill
Imports ProLab.Data

Public Class PatientBillService

#Region "Declarations"
    Private da As PatientBillDA
#End Region
    Sub New()
        da = New PatientBillDA
    End Sub

#Region "Methods"
    Public Function SavePatientBill(ByRef msg As String,
                                    ByVal billtransctionlist As List(Of PatientBill),
                                    ByVal userId As String) As Integer
        Dim BillId As Integer
        Try
            BillId = da.SavePatientBill(Bill_Id,
                               Bill_BillId,
                               Bill_PatientId,
                               Bill_TransactionId,
                               Bill_TotalAmount,
                               Bill_DiscountPercentage,
                               Bill_DiscountAmount,
                               Bill_Status,
                               Bill_IsCancel,
                               Bill_PaymentMode,
                               Bill_Remarks,
                               Bill_InvoiceDate,
                               Bill_ChequeNo,
                               Bill_ChequeDate,
                               Bill_BankName,
                               Bill_IFSCCode,
                               billtransctionlist,
                               userId)
            If BillId > 0 Then
                msg = "Patient Bill Generated"
                Return BillId
            End If
        Catch
            Throw
        End Try
        Return BillId
    End Function

    Public Function GetPatientBillByName(ByVal FirstName As String, ByRef dtbl As DataTable) As Boolean
        Dim status As Boolean = False
        Try
            If da.GetPatientBillByName(FirstName, dtbl) > 0 Then
                status = True
            Else
                status = False
            End If
        Catch
            Throw
        End Try
        Return status
    End Function

    Public Function GetPatientBillById(ByVal BillId As String, ByRef dtbl As DataTable) As Boolean
        Dim status As Boolean = False
        Try
            If da.GetPatientBillById(BillId, dtbl) > 0 Then
                status = True
            Else
                status = False
            End If
        Catch
            Throw
        End Try
        Return status
    End Function

    Public Function GetPatientDetailsById(ByVal BillId As Integer, ByRef dtbl As ProLabDB.PatientBillsDataTable) As Boolean
        Try
            If da.GetPatientBillDetailsById(BillId, dtbl) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetPatientMasterById(ByVal PatientId As Integer, ByVal BillId As Integer, ByRef dtbl As ProLabDB.PatientBillMasterDataTable) As Boolean
        Try
            If da.GetPatientBillReceiptId(PatientId, BillId, dtbl) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function IsBillNumberExists(ByVal BillNum As String) As Boolean
        Return da.IsBillNumberExists(BillNum)
    End Function

#End Region

End Class
