Imports ProLab.Service.PatientTransction
Imports ProLab.Data

Public Class PatientTransctionService
#Region "Declarations"
    Private da As PatientTransctionDA
#End Region
    Sub New()
        da = New PatientTransctionDA
    End Sub

#Region "Methods"
    Public Function SavePatientTranction(ByRef msg As String, ByVal obj As List(Of PatientTransction), ByVal userId As Integer, ByVal DeletedServiceId() As Integer) As Boolean
        Dim transction As Integer
        Try
            transction = da.SavePatientTransction(Transction_Id,
                                                  Transction_SDateTime,
                                                  Transction_SDepoiteAmount,
                                                  Transction_SDoctorId,
                                                  Transction_SPatientId,
                                                  Transction_SServiceId,
                                                  Transction_SRemarks,
                                                  Transction_SampleRequired,
                                                  Transction_SampleReceived,
                                                  Transction_SampleNumber,
                                                  Transction_SReportStatusId,
                                                  obj,
                                                  userId,
                                                  DeletedServiceId)
            If transction > 0 Then
                msg = "Patient transaction saved"
            End If
        Catch
            Throw
        End Try
        Return True
    End Function

    Public Function UpdatePatientTranction(ByVal PatientTransactionId As Integer,
                                           ByVal ServiceTransactionsId As Integer,
                                           ByVal ReportStatusId As Integer) As Boolean
        Dim transction As Integer
        Try
            transction = da.UpdateReportStatus(PatientTransactionId,
                                                  ServiceTransactionsId,
                                                  ReportStatusId)
        Catch
            Throw
        End Try
        Return True
    End Function

    Public Function GetPatientTransctionForBill(ByVal TransactionId As Integer, ByRef tbl As DataTable) As Boolean
        Dim status As Boolean = False
        Try
            If da.GetPatientAlltransactionForBill(TransactionId, tbl) > 0 Then
                status = True
            End If
        Catch
            Throw
        End Try
        Return status
    End Function

    Public Function GetBillNoForTransaction(ByRef BillNo As String) As String
        Dim status As String = ""
        Try
            If da.GetBillIdForTransction(BillNo) > 0 Then
                status = BillNo
            End If
        Catch
            Throw
        End Try
        Return status
    End Function

    Public Function GetAllUnPaidPatientTransaction(ByVal PatientId As Integer, ByVal Name As String,
                                             ByVal Mobile As String,
                                             ByVal transactionStatus As Boolean,
                                             ByRef dtbl As DataTable) As Boolean
        Dim status As Boolean = False
        Try
            If da.GetAllUnPaidPatientTransactions(PatientId, Name, Mobile, transactionStatus, dtbl) > 0 Then
                status = True
            Else
                status = False
            End If
        Catch
            Throw
        End Try
        Return status
    End Function

    Public Function GetPatientTransactionsById(ByVal TransactionsId As Integer, ByRef dtbl As DataTable) As Boolean
        Dim status As Boolean
        Try
            If da.GetPatientTransactionsById(TransactionsId, dtbl) > 0 Then
                status = True
            Else
                status = False
            End If
        Catch
            Throw
        End Try
        Return status
    End Function

    Public Function DeletePatientTransactionById(ByVal TransactionId, ByRef msg) As Boolean
        Dim row As Integer
        Try
            row = da.DeletePatientTransactionById(TransactionId)
            If (row > 0) Then
                msg = "Patient transaction deleted"
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
    End Function

    Public Function GetTransactionDetailsById(ByVal TransactionId As Integer, ByRef dtbl As ProLabDB.PatientTransactionsUtilityDataTable) As Boolean
        Try
            If da.GetTransactionDetailsById(TransactionId, dtbl) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetDepositeAmountById(ByVal TransactionId As Integer, ByRef amount As Decimal) As Boolean
        Dim status = False
        Try
            If da.GetDepositeAmountById(TransactionId, amount) Then
                status = True
            Else
                status = False
            End If
        Catch
            Throw
        End Try
        Return status
    End Function

    Public Function GetTransactionListByDate(ByVal FromDate As Date, ByVal ToDate As Date, ByVal ReportStatus As Integer) As DataTable
        Return da.TansactionList(FromDate, ToDate, ReportStatus)
    End Function

#End Region
End Class
