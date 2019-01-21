Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Resources
Imports ProLab.Core

Public Class PatientBillDA
    Inherits BaseDA

#Region "Declaration"

#End Region

#Region "Iniatialising"
    Public Sub New()
        MyBase.New("PatientBill")
    End Sub
#End Region

#Region "Methods"

    Public Function SavePatientBill(ByVal Id As Integer,
                             ByVal BillId As String,
                             ByVal PatientId As Integer,
                             ByVal PatientTransactionId As Integer,
                             ByVal TotalAmount As String,
                             ByVal DiscountPercentage As String,
                             ByVal DiscountAmount As String,
                             ByVal Status As String,
                             ByVal IsCancel As String,
                             ByVal PaymentMode As String,
                             ByVal Remarks As String,
                             ByVal InvoiceDate As Date,
                             ByVal Bill_ChequeNo As String,
                             ByVal Bill_ChequeDate As Date,
                             ByVal Bill_BankName As String,
                             ByVal Bill_IFSCCode As String,
                             ByVal obj As Object,
                             ByVal userId As Integer) As Integer
        Dim BId As Integer = 0
        Try
            If Id > 0 Then

            Else
                Dim Qry As String = "SavePatientBill"
                Dim currentDate As DateTime = DateTime.Now
                Using db As New SqlDbConnection()
                    Dim parameter As New List(Of SqlParameter)
                    Qry = GetResourceQuery(Qry)
                    parameter.Add(New SqlParameter("@BillNo", BillId))
                    parameter.Add(New SqlParameter("@PatientId", PatientId))
                    parameter.Add(New SqlParameter("@TotalAmount", TotalAmount))
                    parameter.Add(New SqlParameter("@DiscountPercentage", DiscountPercentage))
                    parameter.Add(New SqlParameter("@DiscountAmount", DiscountAmount))
                    parameter.Add(New SqlParameter("@Status", "Paid"))
                    parameter.Add(New SqlParameter("@IsCancel", IsCancel))
                    parameter.Add(New SqlParameter("@PaymentDateTime", currentDate))
                    parameter.Add(New SqlParameter("@PaymentMode", PaymentMode))
                    parameter.Add(New SqlParameter("@InvoiceDate", InvoiceDate))
                    parameter.Add(New SqlParameter("@CreateDate", currentDate))
                    parameter.Add(New SqlParameter("@CreateBy", userId))
                    parameter.Add(New SqlParameter("@Remarks", Remarks))
                    BId = Convert.ToInt32(SqlHelper.ExecuteScalar(db.Connection, CommandType.Text, Qry, parameter.ToArray()))
                    If BId Then

                        If PaymentMode = "Cheque" Then
                            parameter = New List(Of SqlParameter)
                            parameter.Add(New SqlParameter("@BillId", BId))
                            parameter.Add(New SqlParameter("@ChequeNo", Bill_ChequeNo))
                            parameter.Add(New SqlParameter("@ChequeDate", Bill_ChequeDate))
                            parameter.Add(New SqlParameter("@IFSCCode", Bill_IFSCCode))
                            parameter.Add(New SqlParameter("@BankName", Bill_BankName))
                            parameter.Add(New SqlParameter("@CreateDate", currentDate))
                            parameter.Add(New SqlParameter("@CreateBy", userId))

                            Dim qr As String = "SaveBillChequeDetails"
                            qr = GetResourceQuery(qr)
                            Dim result As Integer = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, qr, parameter.ToArray())
                        End If

                        Dim q As String = "UpdatePatientBillStatus"
                        q = GetResourceQuery(q)
                        Dim query As String = "SavePatientBillTransctions"
                        query = GetResourceQuery(query)
                        Dim parms As New List(Of SqlParameter)
                        parms.Add(New SqlParameter("@PatientBillId", BId))
                        parms.Add(New SqlParameter("@PatientTransactionId", 0))
                        parms.Add(New SqlParameter("@ServiceTransactionId", 0))
                        parms.Add(New SqlParameter("@CreateDate", currentDate))
                        parms.Add(New SqlParameter("@CreateBy", userId))
                        For Each billData In obj
                            parms(1).Value = billData.BillTransction_TransactionId
                            parms(2).Value = billData.BillTransction_ServiceTransactionId
                            SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, query, parms.ToArray())
                            SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, q, parms.ToArray())
                        Next
                    End If
                End Using
            End If
        Catch
            Throw
        End Try
        Return BId
    End Function

    Public Function GetPatientBillByName(ByVal FirstName As String, ByRef dtdl As DataTable) As Integer
        Dim returnValue As Integer
        Dim ds As New ProLabDB
        Try
            Dim Qry As String = "GetAllPatientBills"
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@FirstName", SqlDbType.NVarChar) With {.Value = FirstName, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"PatientBillUtility"}, parms.ToArray())
                dtdl = ds.PatientBillUtility
                returnValue = dtdl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetPatientBillById(ByVal BillId As Integer, ByRef dtbl As DataTable) As Integer
        Dim returnValue As Integer
        Dim Qry As String = "GetPatientBillById"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@BillId", SqlDbType.Int) With {.Value = BillId, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"PatientBillData"}, parms.ToArray())
                dtbl = ds.PatientBillData
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetPatientBillDetailsById(ByVal BillId As Integer, ByRef dtbl As ProLabDB.PatientBillsDataTable) As Integer
        Dim Qry As String = "GetPatientBillDetailsById"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.NVarChar) With {.Value = BillId, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"PatientBills"}, parms.ToArray())
                dtbl = ds.PatientBills
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetPatientBillReceiptId(ByVal PatientId As Integer, ByVal BillId As Integer, ByRef dtbl As ProLabDB.PatientBillMasterDataTable) As Integer
        Dim Qry As String = "GetPatientReceiptById"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@PatientId", SqlDbType.Int) With {.Value = PatientId, .DbType = DbType.Int32})
                parms.Add(New SqlParameter("@BillId", SqlDbType.Int) With {.Value = BillId, .DbType = DbType.Int32})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"PatientBillMaster"}, parms.ToArray())
                dtbl = ds.PatientBillMaster
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function IsBillNumberExists(ByVal BillNum As String) As Boolean
        Dim Qry As String = "FindBillNumber"
        Dim ds As New ProLabDB
        Dim returnValue As Object
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@BillNo", SqlDbType.Text) With {.Value = BillNum, .DbType = DbType.String})
                returnValue = SqlHelper.ExecuteScalar(db.Connection, CommandType.Text, Qry, parms.ToArray)
            End Using
        Catch
            Throw
        End Try
        Return (Convert.ToString(returnValue) = "1")
    End Function

#End Region

End Class
