Imports ProLab.Core.Common
Imports ProLab.Data

Public Class CommonService
#Region "Declarations"
    Private da As CommonDA
#End Region

    Sub New()
        da = New CommonDA
    End Sub

#Region "Methods"
    Public Function IsValidUser(ByRef msg) As Boolean
        Dim user As ProLabDB.UsersDataTable
        Try
            user = da.GetUserDetails(User_Name)
            If (user Is Nothing Or user.Rows.Count <= 0) Then
                msg = "Invalid User,Please Check"
                Return False
            End If

            'Go for Password Validation
            Dim Dcode_PWd As String = ""
            Dim Ecode_Pwd As String = ""

            Ecode_Pwd = Core.Cryptography.EncryptString(User_Password)

            If Not (String.Compare(user(0).Password, Ecode_Pwd, StringComparison.Ordinal) = 0) Then
                msg = "Incorrect Password,Please Check"
                Return False
            End If
            User_ID = user(0).Id
        Catch
            Throw
        End Try
        Return True
    End Function

    Public Function SaveCountry(ByVal CountryId, ByVal countryName, ByVal IsActive, ByVal userId) As Integer
        Dim country As Integer
        Try
            country = da.SaveCountry(CountryId, countryName, IsActive, userId)
            If (country <= 0) Then
                Return False
            Else
                Return True
            End If
        Catch
            Throw
        End Try
    End Function

    Public Function DeleteCountry(ByVal CountryId) As Boolean
        Dim row As Integer
        Try
            row = da.DeleteCountry(CountryId)
            If (row > 0) Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
    End Function

    Public Function GetAllCountry(ByRef dtbl As ProLabDB.CountryDataTable) As Boolean
        Try
            If da.GetAllCountry(dtbl) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetAllReportStatus(ByRef dtbl As ProLabDB.ReportStatusDataTable) As Boolean
        Try
            If da.GetAllReportStatus(dtbl) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetDefaultCountry() As String
        Dim result As String = ""
        Try
            result = da.GetDefaultCountry()
        Catch
            Throw
        End Try
        Return result
    End Function

    Public Function GetAllCountryById(ByRef dtbl As ProLabDB.CountryDataTable, ByVal Id As String) As Boolean
        Try
            If da.GetAllCountryById(dtbl, Id) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetCountryByName(ByRef dtbl As ProLabDB.CountryDataTable, ByVal CountryName As String) As Boolean
        Try
            If da.GetCountryByName(dtbl, CountryName) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function SaveState(ByVal StateId, ByVal CountryId, ByVal stateName, ByVal IsActive, ByVal userId) As Integer
        Dim state As Integer
        Try
            state = da.SaveState(StateId, CountryId, stateName, IsActive, userId)
            If (state <= 0) Then
                Return False
            Else
                Return True
            End If
        Catch
            Throw
        End Try
    End Function

    Public Function GetAllStateByCountryId(ByRef dtbl As ProLabDB.StateDataTable, ByVal CountryId As Integer) As Boolean
        Try
            If da.GetAllStateByCountryId(dtbl, CountryId) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetDefaultState() As String
        Dim result As String = ""
        Try
            result = da.GetDefaultState()
        Catch
            Throw
        End Try
        Return result
    End Function

    Public Function GetStateById(ByRef dtbl As ProLabDB.StateDataTable, ByVal Id As String) As Boolean
        Try
            If da.GetStateById(dtbl, Id) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetStateByName(ByRef dtbl As ProLabDB.StateDataTable, ByVal StateName As String) As Boolean
        Try
            If da.GetSateByName(dtbl, StateName) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function DeleteState(ByVal StateId) As Boolean
        Dim row As Integer
        Try
            row = da.DeleteState(StateId)
            If (row > 0) Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
    End Function

    Public Function SaveCity(ByVal CityId, ByVal CountryId, ByVal StateId, ByVal CityName, IsActive, ByVal userId) As Integer
        Dim city As Integer
        Try
            city = da.SaveCity(CityId, CountryId, StateId, CityName, IsActive, userId)
            If (city <= 0) Then
                Return False
            Else
                Return True
            End If
        Catch
            Throw
        End Try
    End Function

    Public Function GetAllCityByStateId(ByVal CountryId, ByVal StateId) As ProLabDB.CityDataTable
        Dim city As ProLabDB.CityDataTable
        Try
            city = da.GetAllCityByStateId(CountryId, StateId)
        Catch
            Throw
        End Try
        Return city
    End Function

    Public Function GetDefaultCity() As String
        Dim result As String = ""
        Try
            result = da.GetDefaultCity()
        Catch
            Throw
        End Try
        Return result
    End Function

    Public Function GetCityById(ByRef dtbl As ProLabDB.CityDataTable, ByVal Id As String) As Boolean
        Try
            If da.GetCityById(dtbl, Id) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetCityByName(ByRef dtbl As ProLabDB.CityDataTable, ByVal CityName As String) As Boolean
        Try
            If da.GetCityByName(dtbl, CityName) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function DeleteCity(ByVal CityId) As Boolean
        Dim row As Integer
        Try
            row = da.DeleteCity(CityId)
            If (row > 0) Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
    End Function

    Public Function Get_Data(ByVal Qry As String, ByRef DataSrc_Tbl As DataTable) As Boolean
        Try
            Dim Cnt As Int16

            Cnt = da.GetData(Qry, DataSrc_Tbl)
            Return True

        Catch
            Return False
        End Try

    End Function

    Public Function GetAllCity(ByRef dtbl As ProLabDB.CityDataTable) As Boolean
        Try
            If da.GetAllCity(dtbl) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function
#End Region
End Class
