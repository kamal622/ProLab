Imports System.Configuration
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.Data.OracleClient
Imports System.Data.SqlClient
Imports ProLab.Data

Public Class SqlDbConnection : Implements IDisposable, IConnection
    Private _mConnection As SqlConnection
    Private mIsDBConnected As Boolean
    'Private _mExceptionMsg As String
    Private _mTransaction As IDbTransaction

    Public ReadOnly Property Connection As SqlConnection
        Get
            Return _mConnection
        End Get
    End Property


    Public ReadOnly Property IsDBConnected As Boolean Implements IConnection.IsDBConnected
        Get
            Return mIsDBConnected
        End Get
    End Property

    Public Sub New()
        _mConnection = New SqlConnection(GetConnectionString)
        mIsDBConnected = OpenConnection()
    End Sub

    'Public Function Connect() As Boolean
    '    Try
    '        Return OpenConnection()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False

    '    End Try
    'End Function

    Public Function OpenConnection() Implements IConnection.OpenConnection
        Try
            _mConnection.Open()
        Catch ex As Exception
            Throw New Exception("The connection with the database can't be established", ex)
        End Try
    End Function

    Public Sub CloseConnection() Implements IConnection.CloseConnection
        Try
            _mConnection.Close()
        Catch ex As Exception
            Throw New Exception("The connection with the database can't be closed", ex)
        End Try
    End Sub

    Public Function GetConnectionString() As String
        If (_mConnection Is Nothing) Then
            Return ConfigurationManager.ConnectionStrings("ProLabConn").ConnectionString
        Else
            Return _mConnection.ConnectionString
        End If
    End Function

    Public Sub BeginTransaction()
        _mTransaction = _mConnection.BeginTransaction
    End Sub

    Public Sub CommitTransaction()
        _mTransaction.Commit()
    End Sub

    Public Sub RollBackTransaction()
        _mTransaction.Rollback()
    End Sub

    'Public Function CreateParameter(ByVal paramField As String, ByVal paramValue As Object, ByVal isReturn As Boolean) As IDataParameter
    '    _mParameter = New SqlParameter(paramField, paramValue)
    '    If isReturn Then
    '        _mParameter.Direction = ParameterDirection.ReturnValue
    '    End If
    '    Return _mParameter
    'End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                If Not (_mConnection Is Nothing) Then
                    If _mConnection.State = ConnectionState.Open Then
                        _mConnection.Close()
                    End If
                    _mConnection.Dispose()
                    _mConnection = Nothing
                End If
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
