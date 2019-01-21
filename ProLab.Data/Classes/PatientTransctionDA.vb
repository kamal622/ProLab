Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Resources
Imports ProLab.Core

Public Class PatientTransctionDA
    Inherits BaseDA
#Region "Declaration"

#End Region

#Region "Iniatialising"
    Public Sub New()
        MyBase.New("PatientTransction")
    End Sub
#End Region

#Region "Methods"

    Public Function TansactionList(ByVal FromDate As Date, ByVal ToDate As Date, ByVal ReportStatus As Integer) As DataTable
        Dim Qry As String = ""
        Dim ds As New DataSet
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = "GetAllTransactionListByDate"
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@FromDate", SqlDbType.Date) With {.Value = FromDate, .DbType = DbType.Date})
                parms.Add(New SqlParameter("@ToDate", SqlDbType.Date) With {.Value = ToDate, .DbType = DbType.Date})
                parms.Add(New SqlParameter("@ReportStatus", SqlDbType.Int) With {.Value = ReportStatus, .DbType = DbType.Int32})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Table1"}, parms.ToArray())
                Return ds.Tables(0)
            End Using
        Catch
            Throw
        End Try
    End Function

    Public Function UpdateReportStatus(ByVal PatientTransactionId As Integer,
                                       ByVal ServiceTransactionsId As Integer,
                                       ByVal ReportStatusId As Integer) As Integer
        Dim returnvalue As Integer
        Try
            If PatientTransactionId > 0 Then
                Dim Qry As String = "UpdateServiceTransaction"
                Dim currentDate As DateTime = DateTime.Now
                Using db As New SqlDbConnection()
                    Dim parameter As New List(Of SqlParameter)
                    Qry = GetResourceQuery(Qry)
                    parameter.Add(New SqlParameter("@Id", ServiceTransactionsId))
                    parameter.Add(New SqlParameter("@UpdateDate", currentDate))
                    parameter.Add(New SqlParameter("@ReportStatusId", ReportStatusId))
                    returnvalue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parameter.ToArray())
                End Using
            End If
        Catch
            Throw
        End Try
        Return returnvalue
    End Function

    Public Function SavePatientTransction(ByVal TransctionId As Integer,
                                          ByVal TransctionDateTime As String,
                                          ByVal TransctionDepositeAmount As String,
                                          ByVal TransctionDoctorId As String,
                                          ByVal TransctionPatientId As String,
                                          ByVal TransactionServiceId As String,
                                          ByVal TransctionRemarks As String,
                                          ByVal TransactionSampleRequird As Boolean,
                                          ByVal TransactionSampleRecevied As Boolean,
                                          ByVal TransactionSampleNo As String,
                                          ByVal ReportStatusId As String,
                                          ByVal obj As Object,
                                          ByVal userId As Integer,
                                          ByVal DeletedServiceId() As Integer
                                         ) As Integer
        Dim returnvalue As Integer
        Try
            If TransctionId > 0 Then
                Dim Qry As String = "UpdatePatientTransaction"
                Dim currentDate As DateTime = DateTime.Now
                Using db As New SqlDbConnection()
                    Dim parameter As New List(Of SqlParameter)
                    Qry = GetResourceQuery(Qry)
                    parameter.Add(New SqlParameter("@Id", TransctionId))
                    parameter.Add(New SqlParameter("@DepositAmount", TransctionDepositeAmount))
                    parameter.Add(New SqlParameter("@SampleRequired", TransactionSampleRequird))
                    parameter.Add(New SqlParameter("@SampleReceived", TransactionSampleRecevied))
                    parameter.Add(New SqlParameter("@SampleNumber", TransactionSampleNo))
                    parameter.Add(New SqlParameter("@BillGenerated", False))
                    parameter.Add(New SqlParameter("@RefDocId", TransctionDoctorId))
                    parameter.Add(New SqlParameter("@PatientId", TransctionPatientId))
                    parameter.Add(New SqlParameter("@Remarks", TransctionRemarks))
                    parameter.Add(New SqlParameter("@UpdateDate", currentDate))
                    parameter.Add(New SqlParameter("@UpdateBy", userId))
                    'parameter.Add(New SqlParameter("@ReportStatusId", 4))
                    returnvalue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parameter.ToArray())
                    'Dim TransId As Integer = Convert.ToInt32(SqlHelper.ExecuteScalar(db.Connection, CommandType.Text, Qry, parameter.ToArray()))
                    Dim q As String = "UpdatePatientServicess"
                    Dim parms As New List(Of SqlParameter)
                    q = GetResourceQuery(q)
                    parms.Add(New SqlParameter("@ServiceID", 0))
                    parms.Add(New SqlParameter("@PatientTransactionId", TransctionId))
                    parms.Add(New SqlParameter("@Amount", 0))
                    parms.Add(New SqlParameter("@UpdateDate", currentDate))
                    parms.Add(New SqlParameter("@UpdateBy", userId))
                    'parms.Add(New SqlParameter("@ReportStatusId", 4))
                    For Each serviceData In obj
                        If serviceData.ServiceTransaction_Id > 0 Then

                        Else
                            parms(0).Value = serviceData.ServiceTransaction_ServiceId
                            parms(2).Value = serviceData.ServiceTransaction_SAmount
                            returnvalue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, q, parms.ToArray())
                        End If
                    Next
                End Using
            Else
                Dim Qry As String = "SavePatientTransction"
                Dim currentDate As DateTime = DateTime.Now
                Using db As New SqlDbConnection()
                    Dim parameter As New List(Of SqlParameter)
                    Qry = GetResourceQuery(Qry)
                    parameter.Add(New SqlParameter("@DepositAmount", TransctionDepositeAmount))
                    parameter.Add(New SqlParameter("@SampleRequired", TransactionSampleRequird))
                    parameter.Add(New SqlParameter("@SampleReceived", TransactionSampleRecevied))
                    parameter.Add(New SqlParameter("@SampleNumber", TransactionSampleNo))
                    parameter.Add(New SqlParameter("@BillGenerated", False))
                    parameter.Add(New SqlParameter("@RefDocId", TransctionDoctorId))
                    parameter.Add(New SqlParameter("@PatientId", TransctionPatientId))
                    parameter.Add(New SqlParameter("@Remarks", TransctionRemarks))
                    parameter.Add(New SqlParameter("@CreateDate", currentDate))
                    parameter.Add(New SqlParameter("@CreateBy", userId))
                    parameter.Add(New SqlParameter("@ReportStatusId", 1))
                    Dim TransId As Integer = Convert.ToInt32(SqlHelper.ExecuteScalar(db.Connection, CommandType.Text, Qry, parameter.ToArray()))
                    Dim q As String = "SavePatientServices"
                    Dim parms As New List(Of SqlParameter)
                    q = GetResourceQuery(q)
                    parms.Add(New SqlParameter("@ServiceID", 0))
                    parms.Add(New SqlParameter("@PatientTransactionId", TransId))
                    parms.Add(New SqlParameter("@Amount", 0))
                    parms.Add(New SqlParameter("@CreateDate", currentDate))
                    parms.Add(New SqlParameter("@CreateBy", userId))
                    parms.Add(New SqlParameter("@ReportStatusId", 1))
                    For Each serviceData In obj
                        parms(0).Value = serviceData.ServiceTransaction_ServiceId
                        parms(2).Value = serviceData.ServiceTransaction_SAmount
                        returnvalue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, q, parms.ToArray())
                    Next
                End Using
            End If
        Catch
            Throw
        End Try
        Return returnvalue
    End Function

    Public Function GetPatientAlltransactionForBill(ByVal TransactionId As Integer, ByRef tbl As DataTable) As Integer
        Dim returnValue As Integer
        Dim ds As New ProLabDB
        Dim Qry As String = "GetPatientTransctionForBill"
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = TransactionId, .DbType = DbType.Int32})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"PatientBillData"}, parms.ToArray())
                tbl = ds.PatientBillData
                returnValue = tbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetBillIdForTransction(ByRef GetBillNo As String) As Integer
        Dim returnValue As Integer
        Try
            Dim Qry As String = "GetBillNoForTransction"
            Using db As New SqlDbConnection
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                Dim result As String = SqlHelper.ExecuteScalar(db.Connection, CommandType.Text, Qry, parms.ToArray())
                If result IsNot Nothing Then
                    GetBillNo = result
                    returnValue = 1
                Else
                    returnValue = 0
                End If
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetAllUnPaidPatientTransactions(ByVal PatientId As Integer,
                                                    ByVal Name As String,
                                              ByVal Mobile As String,
                                              ByVal transactionStatus As Boolean,
                                              ByRef dtbl As DataTable) As Integer
        Dim returnValue As Integer
        Dim Qry As String = ""
        Dim ds As New DataSet
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)

                If transactionStatus Then
                    Qry = "GetAllPatientUnpaidTransactions"
                    Qry = GetResourceQuery(Qry)
                Else
                    Qry = "GetAllPatientTransactions"
                    Qry = GetResourceQuery(Qry)
                End If
                parms.Add(New SqlParameter("@PatientId", SqlDbType.Int) With {.Value = PatientId, .DbType = DbType.Int32})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Table1"}, parms.ToArray())
                dtbl = ds.Tables(0)
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetPatientTransactionsById(ByVal TransactionsId As Integer, ByRef dtbl As DataTable) As Integer
        Dim returnValue As Integer
        Dim Qry As String = "GetPatientTransactionsById"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@TransactionsId", SqlDbType.Int) With {.Value = TransactionsId, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"PatientServiceTransactions"}, parms.ToArray())
                dtbl = ds.PatientServiceTransactions
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function DeletePatientTransactionById(ByVal TransactionId) As Integer
        Dim ds As New ProLabDB
        Dim Qry As String = "DeleteTransactionById"
        Dim query As String = "DeleteTransactionServiceByTrasId"
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = TransactionId, .DbType = DbType.Int32})
                query = GetResourceQuery(query)
                SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, query, parms.ToArray())
                Qry = GetResourceQuery(Qry)
                Dim row As Integer = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parms.ToArray())
                Return row
            End Using
        Catch
            Throw
        End Try
        Return True
    End Function

    Public Function GetTransactionDetailsById(ByVal TransactionId As Integer, ByRef dtbl As ProLabDB.PatientTransactionsUtilityDataTable) As Integer
        Dim Qry As String = "GetTransactionDetailsById"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.NVarChar) With {.Value = TransactionId, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"PatientTransactionsUtility"}, parms.ToArray())
                dtbl = ds.PatientTransactionsUtility
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetDepositeAmountById(ByVal TransactionId As Integer, ByRef amount As Decimal) As Integer
        Dim returnValue As Integer = 0
        Try
            Dim Qry As String = "GetDepositeAmountById"
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.NVarChar) With {.Value = TransactionId, .DbType = DbType.String})
                Dim result As String = SqlHelper.ExecuteScalar(db.Connection, CommandType.Text, Qry, parms.ToArray())
                If result IsNot Nothing Then
                    amount = result
                    returnValue = True
                Else
                    returnValue = False
                End If
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

#End Region

End Class
