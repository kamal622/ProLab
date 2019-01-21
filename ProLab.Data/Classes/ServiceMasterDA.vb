Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Resources
Imports System.Windows.Controls
Imports ProLab.Core

Public Class ServiceMasterDA
    Inherits BaseDA

#Region "Desclarations"

#End Region

#Region "Iniatialising"
    Public Sub New()
        MyBase.New("ServiceMaster")
    End Sub
#End Region

#Region "Methods"

    Public Function SaveServices(ByVal ServiceId As Integer,
                                 ByVal ServiceCategoryId As Integer,
                                 ByVal ServiceName As String,
                                 ByVal ServiceAmount As String,
                                 ByVal ServiceDescription As String,
                                 ByVal AppoinmentNeeded As Boolean,
                                 ByVal ServiceIsActive As Boolean,
                                 ByVal userId As Integer)
        Dim returnValue As Integer
        Try
            If ServiceId > 0 Then
                Dim updateDate As DateTime = DateTime.Now
                Dim Qry As String = "UpdateService"
                Using db As New SqlDbConnection()
                    Dim parameter As New List(Of SqlParameter)
                    Qry = GetResourceQuery(Qry)
                    parameter.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = ServiceId, .DbType = DbType.Int32})
                    parameter.Add(New SqlParameter("@CategoryId", SqlDbType.Int) With {.Value = Convert.ToInt32(ServiceCategoryId), .DbType = DbType.Int32})
                    parameter.Add(New SqlParameter("@Name", SqlDbType.NVarChar) With {.Value = ServiceName, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@Amount", SqlDbType.Decimal) With {.Value = Convert.ToDecimal(ServiceAmount), .DbType = DbType.Decimal})
                    parameter.Add(New SqlParameter("@Description", SqlDbType.NVarChar) With {.Value = ServiceDescription, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@AppoinmentNeeded", SqlDbType.Bit) With {.Value = AppoinmentNeeded, .DbType = DbType.Boolean})
                    parameter.Add(New SqlParameter("@IsActive", SqlDbType.Bit) With {.Value = ServiceIsActive, .DbType = DbType.Boolean})
                    parameter.Add(New SqlParameter("@UpdateDate", SqlDbType.DateTime) With {.Value = updateDate, .DbType = DbType.DateTime})
                    parameter.Add(New SqlParameter("@UpdateBy", SqlDbType.Int) With {.Value = userId, .DbType = DbType.Int32})
                    returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parameter.ToArray())
                End Using
            Else
                Dim createdDate As DateTime = DateTime.Now
                Dim Qry As String = "SaveService"
                Using db As New SqlDbConnection()
                    Dim parameter As New List(Of SqlParameter)
                    Qry = GetResourceQuery(Qry)
                    parameter.Add(New SqlParameter("@CategoryId", SqlDbType.Int) With {.Value = Convert.ToInt32(ServiceCategoryId), .DbType = DbType.Int32})
                    parameter.Add(New SqlParameter("@Name", SqlDbType.NVarChar) With {.Value = ServiceName, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@Amount", SqlDbType.Decimal) With {.Value = Convert.ToDecimal(ServiceAmount), .DbType = DbType.Decimal})
                    parameter.Add(New SqlParameter("@Description", SqlDbType.NVarChar) With {.Value = ServiceDescription, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@AppoinmentNeeded", SqlDbType.Bit) With {.Value = AppoinmentNeeded, .DbType = DbType.Boolean})
                    parameter.Add(New SqlParameter("@IsActive", SqlDbType.Bit) With {.Value = ServiceIsActive, .DbType = DbType.Boolean})
                    parameter.Add(New SqlParameter("@CreateDate", SqlDbType.DateTime) With {.Value = createdDate, .DbType = DbType.DateTime})
                    parameter.Add(New SqlParameter("@CreateBy", SqlDbType.Int) With {.Value = userId, .DbType = DbType.Int32})
                    returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parameter.ToArray())
                End Using
            End If
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetAllServices(ByRef dtbl As ProLabDB.ServicesDataTable) As Integer
        Dim Qry As String = "GetAllServices"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Services"}, parms.ToArray())
                dtbl = ds.Services
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetServiceDetailsForTransction(ByVal ServiceId As String, ByVal ServiceName As String, ByRef dtbl As ProLabDB.ServicesDataTable) As Integer
        Dim Qry As String = "GetServiceDetailsForTransction"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = Convert.ToInt32(ServiceId), .DbType = DbType.Int32})
                parms.Add(New SqlParameter("@Name", SqlDbType.NVarChar) With {.Value = ServiceName, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Services"}, parms.ToArray())
                dtbl = ds.Services
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetAllServiceCategory(ByRef tbl As ProLabDB.ServiceCategoryDataTable) As Integer
        Dim Qry As String = "GetAllServiceCategory"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"ServiceCategory"}, parms.ToArray())
                tbl = ds.ServiceCategory
                returnValue = tbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetServiceCategory(ByRef tbl As ProLabDB.ServiceCategoryDataTable) As Integer
        Dim Qry As String = "GetServiceCategory"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"ServiceCategory"}, parms.ToArray())
                tbl = ds.ServiceCategory
                returnValue = tbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetServiceById(ByRef dtbl As ProLabDB.ServicesDataTable, ByVal Id As String) As Integer
        Dim Qry As String = "GetServiceById"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = Convert.ToInt32(Id), .DbType = DbType.Int32})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Services"}, parms.ToArray())
                dtbl = ds.Services
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetServiceByName(ByRef dtbl As ProLabDB.ServicesDataTable, ByVal CategoryName As String) As Integer
        Dim Qry As String = "GetServiceByName"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Name", SqlDbType.NVarChar) With {.Value = CategoryName, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Services"}, parms.ToArray())
                dtbl = ds.Services
                Return dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function DeleteServiceById(ByVal ServiceId) As Integer
        Dim ds As New ProLabDB
        Dim Qry As String = "DeleteService"
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = ServiceId, .DbType = DbType.Int32})
                returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parms.ToArray())
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function SaveHospital(ByVal HospitalId As Integer,
                                 ByVal HospitalName As String,
                                 ByVal HospitalAddress1 As String,
                                 ByVal HospitalAddress2 As String,
                                 ByVal HospitalPhone1 As String,
                                 ByVal HospitalPhone2 As String,
                                 ByVal HospitalCountry As Integer,
                                 ByVal HospitalState As Integer,
                                 ByVal HospitalCity As Integer,
                                 ByVal userId As Integer)
        Dim returnValue As Integer
        Try
            If HospitalId > 0 Then
                Dim updateDate As DateTime = DateTime.Now
                Dim Qry As String = "UpdateHospital"
                Using db As New SqlDbConnection()
                    Dim parameter As New List(Of SqlParameter)
                    Qry = GetResourceQuery(Qry)
                    parameter.Add(New SqlParameter("@Id", SqlDbType.NVarChar) With {.Value = HospitalId, .DbType = DbType.Int32})
                    parameter.Add(New SqlParameter("@Name", SqlDbType.NVarChar) With {.Value = HospitalName, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@Address1", SqlDbType.NVarChar) With {.Value = HospitalAddress1, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@Address2", SqlDbType.NVarChar) With {.Value = HospitalAddress2, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@Phone1", SqlDbType.NVarChar) With {.Value = HospitalPhone1, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@Phone2", SqlDbType.NVarChar) With {.Value = HospitalPhone2, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@CountryId", SqlDbType.Int) With {.Value = HospitalCountry, .DbType = DbType.Int32})
                    parameter.Add(New SqlParameter("@StateId", SqlDbType.Int) With {.Value = HospitalState, .DbType = DbType.Int32})
                    parameter.Add(New SqlParameter("@CityId", SqlDbType.Int) With {.Value = HospitalCity, .DbType = DbType.Int32})
                    parameter.Add(New SqlParameter("@UpdateDate", SqlDbType.DateTime) With {.Value = updateDate, .DbType = DbType.DateTime})
                    parameter.Add(New SqlParameter("@UpdateBy", SqlDbType.Int) With {.Value = userId, .DbType = DbType.Int32})
                    returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parameter.ToArray())
                End Using
            Else
                Dim createdDate As DateTime = DateTime.Now
                Dim Qry As String = "SaveHospital"
                Using db As New SqlDbConnection()
                    Dim parameter As New List(Of SqlParameter)
                    Qry = GetResourceQuery(Qry)
                    parameter.Add(New SqlParameter("@Name", SqlDbType.NVarChar) With {.Value = HospitalName, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@Address1", SqlDbType.NVarChar) With {.Value = HospitalAddress1, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@Address2", SqlDbType.NVarChar) With {.Value = HospitalAddress2, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@Phone1", SqlDbType.NVarChar) With {.Value = HospitalPhone1, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@Phone2", SqlDbType.NVarChar) With {.Value = HospitalPhone2, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@CountryId", SqlDbType.Int) With {.Value = HospitalCountry, .DbType = DbType.Int32})
                    parameter.Add(New SqlParameter("@StateId", SqlDbType.Int) With {.Value = HospitalState, .DbType = DbType.Int32})
                    parameter.Add(New SqlParameter("@CityId", SqlDbType.Int) With {.Value = HospitalCity, .DbType = DbType.Int32})
                    parameter.Add(New SqlParameter("@CreateDate", SqlDbType.DateTime) With {.Value = createdDate, .DbType = DbType.DateTime})
                    parameter.Add(New SqlParameter("@CreateBy", SqlDbType.Int) With {.Value = userId, .DbType = DbType.Int32})
                    returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parameter.ToArray())
                End Using
            End If
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetHospitalById(ByRef dtbl As ProLabDB.HospitalsDataTable, ByVal Id As String) As Integer
        Dim Qry As String = "GetHospitalById"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = Convert.ToInt32(Id), .DbType = DbType.Int32})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Hospitals"}, parms.ToArray())
                dtbl = ds.Hospitals
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetHospitalByName(ByRef dtbl As ProLabDB.HospitalsDataTable, ByVal Name As String) As Integer
        Dim Qry As String = "GetHospitalByName"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Name", SqlDbType.NVarChar) With {.Value = Name, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Hospitals"}, parms.ToArray())
                dtbl = ds.Hospitals
                Return dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function DeleteHospitalById(ByVal HospitalId) As Integer
        Dim ds As New ProLabDB
        Dim Qry As String = "DeleteHospital"
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = HospitalId, .DbType = DbType.Int32})
                returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parms.ToArray())
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetAllHospitalForDoctor(ByRef tbl As ProLabDB.HospitalsDataTable) As Integer
        Dim Qry As String = "GetHospitalForDoctor"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Hospitals"}, parms.ToArray())
                tbl = ds.Hospitals
                returnValue = tbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetAllHospitalWithCity(ByRef tbl As DataTable) As Integer
        Dim Qry As String = "GetHospitalWithCity"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"DropDownData"}, parms.ToArray())
                tbl = ds.DropDownData
                returnValue = tbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function SaveDoctros(ByVal DoctorId As Integer,
                                ByVal DoctorFname As String,
                                ByVal DoctorLame As String,
                                ByVal DoctorHospitalId As Integer,
                                ByVal userId As Integer)
        Dim returnvalue As Integer
        Try
            If DoctorId > 0 Then
                Dim updateDate As DateTime = DateTime.Now
                Dim Qry As String = "UpdateDoctors"
                Using db As New SqlDbConnection()
                    Dim parameter As New List(Of SqlParameter)
                    Qry = GetResourceQuery(Qry)
                    parameter.Add(New SqlParameter("@Id", SqlDbType.NVarChar) With {.Value = DoctorId, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@FirstName", SqlDbType.NVarChar) With {.Value = DoctorFname, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@LastName", SqlDbType.NVarChar) With {.Value = DoctorLame, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@HospitalId", SqlDbType.Int) With {.Value = DoctorHospitalId, .DbType = DbType.Int32})
                    parameter.Add(New SqlParameter("@UpdateDate", SqlDbType.DateTime) With {.Value = updateDate, .DbType = DbType.DateTime})
                    parameter.Add(New SqlParameter("@UpdateBy", SqlDbType.Int) With {.Value = userId, .DbType = DbType.Int32})
                    returnvalue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parameter.ToArray())
                End Using
            Else
                Dim Qry As String = "SaveDoctors"
                Dim createdDate As DateTime = DateTime.Now
                Using db As New SqlDbConnection()
                    Dim parameter As New List(Of SqlParameter)
                    Qry = GetResourceQuery(Qry)
                    parameter.Add(New SqlParameter("@FirstName", SqlDbType.NVarChar) With {.Value = DoctorFname, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@LastName", SqlDbType.NVarChar) With {.Value = DoctorLame, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@HospitalId", SqlDbType.Int) With {.Value = DoctorHospitalId, .DbType = DbType.Int32})
                    parameter.Add(New SqlParameter("@CreateDate", SqlDbType.DateTime) With {.Value = createdDate, .DbType = DbType.DateTime})
                    parameter.Add(New SqlParameter("@CreateBy", SqlDbType.Int) With {.Value = userId, .DbType = DbType.Int32})
                    returnvalue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parameter.ToArray())
                End Using
            End If
        Catch
            Throw
        End Try
        Return returnvalue
    End Function

    Public Function GetDoctorById(ByRef dtbl As ProLabDB.DoctorsDataTable, ByVal Id As String) As Integer
        Dim Qry As String = "GetDoctrosById"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = Convert.ToInt32(Id), .DbType = DbType.Int32})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Doctors"}, parms.ToArray())
                dtbl = ds.Doctors
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetDoctorDetailsForTransction(ByRef dtbl As ProLabDB.DoctorsDataTable, ByVal Id As String)
        Dim Qry As String = "GetDoctorDetailsForTransction"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = Convert.ToInt32(Id), .DbType = DbType.Int32})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Doctors"}, parms.ToArray())
                dtbl = ds.Doctors
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetDoctorByFirstName(ByRef dtbl As ProLabDB.DoctorsDataTable, ByVal FirstName As String) As Integer
        Dim Qry As String = "GetDoctorByFirstName"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@FirstName", SqlDbType.NVarChar) With {.Value = FirstName, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Doctors"}, parms.ToArray())
                dtbl = ds.Doctors
                Return dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetDoctorByFullName(ByRef dtbl As ProLabDB.DoctorsDataTable, ByVal firstName As String, ByVal lastName As String) As Integer
        Dim Qry As String = "GetDoctorByFullName"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@FirstName", SqlDbType.NVarChar) With {.Value = firstName, .DbType = DbType.String})
                parms.Add(New SqlParameter("@LastName", SqlDbType.NVarChar) With {.Value = lastName, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"Doctors"}, parms.ToArray())
                dtbl = ds.Doctors
                Return dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function DeleteDoctorsById(ByVal DoctorId) As Integer
        Dim ds As New ProLabDB
        Dim Qry As String = "DeleteDoctors"
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = DoctorId, .DbType = DbType.Int32})
                returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parms.ToArray())
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function SaveServiceCategory(ByVal CategoryId As Integer,
                               ByVal CategoryName As String,
                               ByVal Description As String,
                               ByVal userId As Integer)
        Dim returnvalue As Integer
        Try
            If CategoryId > 0 Then
                Dim updateDate As DateTime = DateTime.Now
                Dim Qry As String = "UpdateServiceCategory"
                Using db As New SqlDbConnection()
                    Dim parameter As New List(Of SqlParameter)
                    Qry = GetResourceQuery(Qry)
                    parameter.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = CategoryId, .DbType = DbType.Int32})
                    parameter.Add(New SqlParameter("@CategoryName", SqlDbType.NVarChar) With {.Value = CategoryName, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@Description", SqlDbType.NVarChar) With {.Value = Description, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@UpdateDate", SqlDbType.DateTime) With {.Value = updateDate, .DbType = DbType.DateTime})
                    parameter.Add(New SqlParameter("@UpdateBy", SqlDbType.Int) With {.Value = userId, .DbType = DbType.Int32})
                    returnvalue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parameter.ToArray())
                End Using
            Else
                Dim createdDate As DateTime = DateTime.Now
                Dim Qry As String = "SaveServiceCategory"
                Using db As New SqlDbConnection()
                    Dim parameter As New List(Of SqlParameter)
                    Qry = GetResourceQuery(Qry)
                    parameter.Add(New SqlParameter("@CategoryName", SqlDbType.NVarChar) With {.Value = CategoryName, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@Description", SqlDbType.NVarChar) With {.Value = Description, .DbType = DbType.String})
                    parameter.Add(New SqlParameter("@CreateDate", SqlDbType.DateTime) With {.Value = createdDate, .DbType = DbType.DateTime})
                    parameter.Add(New SqlParameter("@CreateBy", SqlDbType.Int) With {.Value = userId, .DbType = DbType.Int32})
                    returnvalue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parameter.ToArray())
                End Using
            End If
        Catch
            Throw
        End Try
        Return returnvalue
    End Function

    Public Function GetServiceCategoryById(ByRef dtbl As ProLabDB.ServiceCategoryDataTable, ByVal Id As String) As Integer
        Dim Qry As String = "GetServiceCategoryById"
        Dim ds As New ProLabDB
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = Convert.ToInt32(Id), .DbType = DbType.Int32})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"ServiceCategory"}, parms.ToArray())
                dtbl = ds.ServiceCategory
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetServiceCategoryByName(ByRef dtbl As ProLabDB.ServiceCategoryDataTable, ByVal CategoryName As String) As Integer
        Dim Qry As String = "GetServiceCategoryByName"
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@CategoryName", SqlDbType.NVarChar) With {.Value = CategoryName, .DbType = DbType.String})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"ServiceCategory"}, parms.ToArray())
                dtbl = ds.ServiceCategory
                Return dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function DeleteServiceCategoryById(ByVal CategoryId) As Integer
        Dim ds As New ProLabDB
        Dim Qry As String = "DeleteServiceCategoryById"
        Dim returnValue As Integer
        Try
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Id", SqlDbType.Int) With {.Value = CategoryId, .DbType = DbType.Int32})
                returnValue = SqlHelper.ExecuteNonQuery(db.Connection, CommandType.Text, Qry, parms.ToArray())
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function CheckExistingService(ByVal ServiceName) As Boolean
        Dim ds As New ProLabDB
        Dim returnValue As Boolean
        Try
            Dim Qry As String = "CheckService"
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@Name", SqlDbType.NVarChar) With {.Value = ServiceName, .DbType = DbType.String})
                Dim result As String = SqlHelper.ExecuteScalar(db.Connection, CommandType.Text, Qry, parms.ToArray())
                If result IsNot Nothing Then
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

    Public Function CheckExistingServiceCategory(ByVal CategoryName) As Boolean
        Dim ds As New ProLabDB
        Dim returnValue As Boolean
        Try
            Dim Qry As String = "CheckServiceCategory"
            Using db As New SqlDbConnection()
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@CategoryName", SqlDbType.NVarChar) With {.Value = CategoryName, .DbType = DbType.String})
                Dim result As String = SqlHelper.ExecuteScalar(db.Connection, CommandType.Text, Qry, parms.ToArray())
                If result IsNot Nothing Then
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
