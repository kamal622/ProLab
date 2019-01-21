Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Resources
Imports ProLab.Core

Public Class PatientDA
    Inherits BaseDA
#Region "Declaration"

#End Region

#Region "Iniatialising"
    Public Sub New()
        MyBase.New("Patient")
    End Sub
#End Region

#Region "Methods"

    Public Function SavePatientInformation(ByVal PatientId As Integer,
                                           ByVal FirstName As String,
                                           ByVal LastName As String,
                                           ByVal Mobile As String,
                                           ByVal LandLine As String,
                                           ByVal Email As String,
                                           ByVal Address1 As String,
                                           ByVal Address2 As String,
                                           ByVal CityId As String,
                                           ByVal Age As String,
                                           ByVal Gender As String,
                                           ByVal DOB As String,
                                           ByVal Occupation As String,
                                           ByVal Zipcode As String,
                                           ByVal CountryId As String,
                                           ByVal StateId As String,
                                           ByVal userId As Integer) As Integer

        Dim returnValue As Integer
        Try
            If (PatientId > 0) Then
                Dim Qry As String = "UpdatePatientDetails"
                Dim updateDate As DateTime = DateTime.Now
                Using db As New SqlDbConnection()
                    Dim parameter As New List(Of SqlParameter)
                    Qry = GetResourceQuery(Qry)
                    parameter.Add(New SqlParameter("@Id", PatientId))
                    parameter.Add(New SqlParameter("@FirstName", FirstName))
                    parameter.Add(New SqlParameter("@Lastname", LastName))
                    parameter.Add(New SqlParameter("@Mobile", Mobile))
                    parameter.Add(New SqlParameter("@LandLine", LandLine))
                    parameter.Add(New SqlParameter("@Email", Email))
                    parameter.Add(New SqlParameter("@Address1", Address1))
                    parameter.Add(New SqlParameter("@Address2", Address2))
                    parameter.Add(New SqlParameter("@CityId", Convert.ToInt64(CityId)))
                    parameter.Add(New SqlParameter("@Age", Convert.ToInt64(Age)))
                    parameter.Add(New SqlParameter("@Gender", Gender))
                    parameter.Add(New SqlParameter("@DOB", Convert.ToDateTime(DOB)))
                    parameter.Add(New SqlParameter("@Occupation", Occupation))
                    parameter.Add(New SqlParameter("@Zipcode", Zipcode))
                    parameter.Add(New SqlParameter("@CountryId", Convert.ToInt64(CountryId)))
                    parameter.Add(New SqlParameter("@StateId", Convert.ToInt64(StateId)))
                    parameter.Add(New SqlParameter("@UpdateDate", updateDate))
                    parameter.Add(New SqlParameter("@UpdateBy", userId))
                    returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parameter.ToArray())
                End Using
            Else
                Dim Qry As String = "SavePatientDetails"
                Dim currentDate As DateTime = DateTime.Now
                Using db As New SqlDbConnection()
                    Dim parameter As New List(Of SqlParameter)
                    Qry = GetResourceQuery(Qry)
                    parameter.Add(New SqlParameter("@FirstName", FirstName))
                    parameter.Add(New SqlParameter("@Lastname", LastName))
                    parameter.Add(New SqlParameter("@Mobile", Mobile))
                    parameter.Add(New SqlParameter("@LandLine", LandLine))
                    parameter.Add(New SqlParameter("@Email", Email))
                    parameter.Add(New SqlParameter("@Address1", Address1))
                    parameter.Add(New SqlParameter("@Address2", Address2))
                    parameter.Add(New SqlParameter("@CityId", Convert.ToInt64(CityId)))
                    parameter.Add(New SqlParameter("@Age", Convert.ToInt64(Age)))
                    parameter.Add(New SqlParameter("@Gender", Gender))
                    parameter.Add(New SqlParameter("@DOB", Convert.ToDateTime(DOB)))
                    parameter.Add(New SqlParameter("@Occupation", Occupation))
                    parameter.Add(New SqlParameter("@Zipcode", Zipcode))
                    parameter.Add(New SqlParameter("@CountryId", Convert.ToInt64(CountryId)))
                    parameter.Add(New SqlParameter("@StateId", Convert.ToInt64(StateId)))
                    parameter.Add(New SqlParameter("@CreateDate", currentDate))
                    parameter.Add(New SqlParameter("@CreateBy", userId))
                    returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parameter.ToArray())
                End Using
            End If
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetPatientDetails() As ProLabDB.PatientsDataTable
        Dim Qry As String = "GetAllPatientDetails"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Patients"}, parms.ToArray())
                Return ds.Patients
            End Using
        Catch
            Throw
        End Try
    End Function

    Public Function GetPatientByName(ByVal FirstName As String) As ProLabDB.PatientsDataTable
        Dim Qry As String = "GetPatientByName"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parameter As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parameter.Add(New SqlParameter("@FirstName", SqlDbType.VarChar) With {.Value = FirstName, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Patients"}, parameter.ToArray())
                Return ds.Patients
            End Using

        Catch
            Throw
        End Try
    End Function

    Public Function GetPatientDetailsById(ByRef dtbl As ProLabDB.PatientsDataTable, ByVal Id As Integer) As Integer
        Dim Qry As String = "GetPatientById"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = Id, .DbType = DbType.Int32})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Patients"}, parms.ToArray())
                dtbl = ds.Patients
                Return dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetPatientByMobile(ByRef dtbl As ProLabDB.PatientsDataTable, ByVal Mobile As String) As Integer
        Dim Qry As String = "GetPatientByMobile"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Mobile", SqlDbType.NVarChar) With {.Value = Mobile, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Patients"}, parms.ToArray())
                dtbl = ds.Patients
                Return dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function DeletePatientById(ByVal PatientId) As Integer
        Dim ds As New ProLabDB
        Dim Qry As String = "DeletePatientById"
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = PatientId, .DbType = DbType.Int64})
                Dim row As Integer = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parms.ToArray())
                Return row
            End Using
        Catch
            Throw
        End Try
        Return True
    End Function

    Public Function CheckExistingMobile(ByVal Mobile) As Integer
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Dim Qry As String = "CheckMobile"
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Mobile", SqlDbType.NVarChar) With {.Value = Mobile, .DbType = DbType.String})
                Dim result As String = SqlHelper.ExecuteScalar(db.Connection, CommandType.Text, Qry, parms.ToArray())
                If result IsNot Nothing Then
                    'MsgBox("Mobile is already exists")
                    Return 0
                Else
                    Return 1
                End If
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

#End Region

End Class
