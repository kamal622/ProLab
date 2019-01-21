Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Resources
Imports ProLab.Core

Public Class CommonDA
    Inherits BaseDA
#Region "Declarations"

#End Region

#Region "Iniatialising"
    Public Sub New()
        MyBase.New("Common")
    End Sub
#End Region

#Region "Methods"

    Public Function GetUserDetails(ByVal userName As String) As ProLabDB.UsersDataTable
        Dim Qry As String = "GetUserByName"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@UserName", SqlDbType.VarChar) With {.Value = userName, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Users"}, parms.ToArray())
                Return ds.Users
            End Using
        Catch
            Throw
        End Try
    End Function

    Public Function SaveCountry(ByVal CountryId, ByVal CountryName, ByVal IsActive, ByVal userId) As Integer
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Dim createdDate As DateTime = DateTime.Now
            Dim updateDate As DateTime = DateTime.Now
            Dim Qry As String = "CheckCountryName"
            Using db As New SqlDbConnection
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = CountryId, .DbType = DbType.Int32})
                parms.Add(New SqlParameter("@CountryName", SqlDbType.VarChar) With {.Value = CountryName, .DbType = DbType.String})
                parms.Add(New SqlParameter("@IsActive", SqlDbType.Bit) With {.Value = IsActive, .DbType = DbType.Boolean})
                parms.Add(New SqlParameter("@CreateDate", SqlDbType.DateTime) With {.Value = createdDate, .DbType = DbType.DateTime})
                parms.Add(New SqlParameter("@CreateBy", SqlDbType.Int) With {.Value = userId, .DbType = DbType.Int32})
                parms.Add(New SqlParameter("@UpdateDate", SqlDbType.DateTime) With {.Value = updateDate, .DbType = DbType.DateTime})
                parms.Add(New SqlParameter("@UpdateBy", SqlDbType.Int) With {.Value = userId, .DbType = DbType.Int32})
                Dim result As String = SqlHelper.ExecuteScalar(db.Connection, CommandType.Text, Qry, parms.ToArray())
                If result IsNot Nothing Then
                    MsgBox("CountryName is already exists")
                    Return 0
                Else
                    If CountryId > 0 Then
                        Dim q As String = "UpdateCountry"
                        q = GetResourceQuery(q)
                        returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, q, parms.ToArray())
                    Else
                        Dim Q As String = "SaveCountry"
                        Q = GetResourceQuery(Q)
                        returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Q, parms.ToArray())
                    End If
                End If
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function DeleteCountry(ByVal CountryId) As Integer
        Dim ds As New ProLabDB
        Dim Qry As String = "DeleteCountry"
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = CountryId, .DbType = DbType.Int64})
                returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parms.ToArray())
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetAllCountry(ByRef dtbl As ProLabDB.CountryDataTable) As Integer
        Dim Qry As String = "GETALLCOUNTRY"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Country"}, parms.ToArray())
                dtbl = ds.Country
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetAllReportStatus(ByRef dtbl As ProLabDB.ReportStatusDataTable) As Integer
        Dim Qry As String = "GetAllReportStatus"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"ReportStatus"}, parms.ToArray())
                dtbl = ds.ReportStatus
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetDefaultCountry() As String
        Dim Qry As String = "GetDefaultCountry"
        Dim ds As New ProLabDB
        Dim result As String = ""
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                result = SqlHelper.ExecuteScalar(db.Connection, CommandType.Text, Qry, parms.ToArray())
            End Using
        Catch
            Throw
        End Try
        Return result
    End Function

    Public Function GetAllCountryById(ByRef dtbl As ProLabDB.CountryDataTable, ByVal Id As String) As Integer
        Dim Qry As String = "GetCountryById"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = Convert.ToInt64(Id), .DbType = DbType.Int64})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Country"}, parms.ToArray())
                dtbl = ds.Country
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetCountryByName(ByRef dtbl As ProLabDB.CountryDataTable, ByVal CountryName As String) As Integer
        Dim Qry As String = "GetCountryByName"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Name", SqlDbType.NVarChar) With {.Value = CountryName, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Country"}, parms.ToArray())
                dtbl = ds.Country
                Return dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function SaveState(ByVal StateId, ByVal CountryId, ByVal stateName, ByVal IsActive, ByVal userId) As Integer
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Dim Qry As String = "CheckStateName"
            Dim createdDate As DateTime = DateTime.Now
            Dim updateDate As DateTime = DateTime.Now
            Using db As New SqlDbConnection
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = StateId, .DbType = DbType.Int32})
                parms.Add(New SqlParameter("@CountryId", SqlDbType.Int) With {.Value = CountryId, .DbType = DbType.Int32})
                parms.Add(New SqlParameter("@StateName", SqlDbType.VarChar) With {.Value = stateName, .DbType = DbType.String})
                parms.Add(New SqlParameter("@IsActive", SqlDbType.Bit) With {.Value = IsActive, .DbType = DbType.Boolean})
                parms.Add(New SqlParameter("@CreateDate", SqlDbType.DateTime) With {.Value = createdDate, .DbType = DbType.DateTime})
                parms.Add(New SqlParameter("@CreateBy", SqlDbType.Int) With {.Value = userId, .DbType = DbType.Int32})
                parms.Add(New SqlParameter("@UpdateDate", SqlDbType.DateTime) With {.Value = updateDate, .DbType = DbType.DateTime})
                parms.Add(New SqlParameter("@UpdateBy", SqlDbType.Int) With {.Value = userId, .DbType = DbType.Int32})
                Dim result As String = SqlHelper.ExecuteScalar(db.Connection, CommandType.Text, Qry, parms.ToArray())
                If result IsNot Nothing Then
                    MsgBox("StateName is already exists")
                    Return 0
                Else
                    If StateId > 0 Then
                        Dim Q As String = "UpdateState"
                        Q = GetResourceQuery(Q)
                        returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Q, parms.ToArray())
                    Else
                        Dim Q As String = "SaveState"
                        Q = GetResourceQuery(Q)
                        returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Q, parms.ToArray())
                    End If
                End If
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetAllStateByCountryId(ByRef dtbl As ProLabDB.StateDataTable, ByVal CountryId As Integer) As Integer
        Dim Qry As String = "GetStateByCountryId"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@CountryId", SqlDbType.VarChar) With {.Value = CountryId, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"State"}, parms.ToArray())
                dtbl = ds.State
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetDefaultState() As String
        Dim Qry As String = "GetDefaultState"
        Dim ds As New ProLabDB
        Dim result As String = ""
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                result = SqlHelper.ExecuteScalar(db.Connection, CommandType.Text, Qry, parms.ToArray())
            End Using
        Catch
            Throw
        End Try
        Return result
    End Function

    Public Function GetStateById(ByRef dtbl As ProLabDB.StateDataTable, ByVal Id As String) As Integer
        Dim Qry As String = "GetStateById"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = Convert.ToInt64(Id), .DbType = DbType.Int64})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"State"}, parms.ToArray())
                dtbl = ds.State
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetSateByName(ByRef dtbl As ProLabDB.StateDataTable, ByVal StateName As String) As Integer
        Dim Qry As String = "GetStateByName"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@StateName", SqlDbType.NVarChar) With {.Value = StateName, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"State"}, parms.ToArray())
                dtbl = ds.State
                Return dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function DeleteState(ByVal StateId) As Integer
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Dim Qry As String = "DeleteState"
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = StateId, .DbType = DbType.Int64})
                returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parms.ToArray())
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function SaveCity(ByVal CityId, ByVal CountryId, ByVal StateId, ByVal CityName, ByVal IsActive, ByVal userId) As Integer
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Dim createdDate As DateTime = DateTime.Now
            Dim updateDate As DateTime = DateTime.Now
            Dim Qry As String = "CheckCityName"
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = CityId, .DbType = DbType.Int64})
                parms.Add(New SqlParameter("@CountryId", SqlDbType.Int) With {.Value = CountryId, .DbType = DbType.Int64})
                parms.Add(New SqlParameter("@StateId", SqlDbType.Int) With {.Value = StateId, .DbType = DbType.Int64})
                parms.Add(New SqlParameter("@CityName", SqlDbType.VarChar) With {.Value = CityName, .DbType = DbType.String})
                parms.Add(New SqlParameter("@IsActive", SqlDbType.Bit) With {.Value = IsActive, .DbType = DbType.Boolean})
                parms.Add(New SqlParameter("@CreateDate", SqlDbType.DateTime) With {.Value = createdDate, .DbType = DbType.DateTime})
                parms.Add(New SqlParameter("@CreateBy", SqlDbType.Int) With {.Value = userId, .DbType = DbType.Int32})
                parms.Add(New SqlParameter("@UpdateDate", SqlDbType.DateTime) With {.Value = updateDate, .DbType = DbType.DateTime})
                parms.Add(New SqlParameter("@UpdateBy", SqlDbType.Int) With {.Value = userId, .DbType = DbType.Int32})
                Dim result As String = SqlHelper.ExecuteScalar(db.Connection, CommandType.Text, Qry, parms.ToArray())
                If result IsNot Nothing Then
                    MsgBox("CityName is already exists")
                    Return 0
                Else
                    If CityId > 0 Then
                        Dim UpdateQry As String = "UpdateCity"
                        UpdateQry = GetResourceQuery(UpdateQry)
                        returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, UpdateQry, parms.ToArray())
                    Else
                        Dim SaveQry As String = "SaveCity"
                        SaveQry = GetResourceQuery(SaveQry)
                        returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, SaveQry, parms.ToArray())
                    End If
                End If
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetAllCityByStateId(ByVal CountryId, ByVal StateId) As ProLabDB.CityDataTable
        Dim Qry As String = "GetCityByStateId"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@CountryId", SqlDbType.VarChar) With {.Value = CountryId, .DbType = DbType.String})
                parms.Add(New SqlParameter("@StateId", SqlDbType.VarChar) With {.Value = StateId, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"City"}, parms.ToArray())
                Return ds.City
            End Using
        Catch
            Throw
        End Try

    End Function

    Public Function GetDefaultCity() As String
        Dim Qry As String = "GetDefaultCity"
        Dim ds As New ProLabDB
        Dim result As String = ""
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                result = SqlHelper.ExecuteScalar(db.Connection, CommandType.Text, Qry, parms.ToArray())
            End Using
        Catch
            Throw
        End Try
        Return result
    End Function

    Public Function GetCityById(ByRef dtbl As ProLabDB.CityDataTable, ByVal Id As String) As Integer
        Dim Qry As String = "GetCityById"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = Convert.ToInt64(Id), .DbType = DbType.Int64})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"City"}, parms.ToArray())
                dtbl = ds.City
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetCityByName(ByRef dtbl As ProLabDB.CityDataTable, ByVal CityName As String) As Integer
        Dim Qry As String = "GetCityByName"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@CityName", SqlDbType.NVarChar) With {.Value = CityName, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"City"}, parms.ToArray())
                dtbl = ds.City
                Return dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function DeleteCity(ByVal CityId) As Integer
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Dim Qry As String = "DeleteCity"
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = CityId, .DbType = DbType.Int64})
                returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parms.ToArray())
            End Using
        Catch
            Throw
            Return 0
        End Try
        Return returnValue
    End Function

    Public Function GetData(ByVal Qry As String, ByRef DataSrc_Tbl As DataTable) As Integer
        Dim ds As New DataSet
        Dim returnValue As Integer
        Try
            Dim q As String = ""
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                'q = GetResourceQuery(Qry)
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Table1"}, parms.ToArray())
                DataSrc_Tbl = ds.Tables(0)
                returnValue = DataSrc_Tbl.Rows.Count
            End Using
        Catch
            Throw
            Return 0
        End Try
        Return returnValue
    End Function

    Public Function GetAllCity(ByRef dtbl As ProLabDB.CityDataTable) As Integer
        Dim Qry As String = "GetAllCity"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"City"}, parms.ToArray())
                dtbl = ds.City
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

#End Region
End Class
