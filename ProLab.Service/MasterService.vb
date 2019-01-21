Imports ProLab.Data
Imports ProLab.Service.ServiceMaster

Public Class MasterService
#Region "Declarations"
    Private da As ServiceMasterDA
#End Region

    Sub New()
        da = New ServiceMasterDA
    End Sub

#Region "Methods"
    Public Function SaveServices(ByRef msg, ByVal userId) As Boolean
        Dim service As Integer
        Try
            service = da.SaveServices(Service_Id,
                                      Service_Category,
                                      Service_Name,
                                      Service_Amount,
                                      Service_Description,
                                      Service_Appoiment,
                                      Service_IsActive,
                                      userId)
            If (service <= 0) Then
                msg = "Service details not saved"
                Return False
            Else
                msg = "Service details saved"
                Return True
            End If
        Catch
            Throw
        End Try
        Return True
    End Function

    Public Function GetAllServies(ByRef dtbl As ProLabDB.ServicesDataTable) As Boolean
        Try
            If da.GetAllServices(dtbl) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetServiceDetailsForTranasction(ByVal ServiceId As String, ByVal ServiceName As String, ByRef dtbl As ProLabDB.ServicesDataTable) As Boolean
        Try
            If da.GetServiceDetailsForTransction(ServiceId, ServiceName, dtbl) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetAllServiceCategory(ByRef tbl As ProLabDB.ServiceCategoryDataTable) As Boolean
        Try
            If da.GetAllServiceCategory(tbl) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetServiceCategory(ByRef tbl As ProLabDB.ServiceCategoryDataTable) As Boolean
        Try
            If da.GetServiceCategory(tbl) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetServiceById(ByRef dtbl As ProLabDB.ServicesDataTable, ByVal Id As String) As Boolean
        Try
            If da.GetServiceById(dtbl, Id) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetServiceByName(ByRef dtbl As ProLabDB.ServicesDataTable, ByVal Name As String) As Boolean
        Try
            If da.GetServiceByName(dtbl, Name) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function DeleteServiceById(ByVal ServiceId) As Boolean
        Dim row As Integer
        Try
            row = da.DeleteServiceById(ServiceId)
            If (row > 0) Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
    End Function

    Public Function SaveHospital(ByRef msg, ByVal userId) As Boolean
        Dim hospital As Integer
        Try
            hospital = da.SaveHospital(Hospital_Id,
                                      Hospital_Name,
                                      Hospital_Address1,
                                      Hospital_Address2,
                                      Hospital_Phone1,
                                      Hospital_Phone2,
                                      Hospital_Country,
                                      Hospital_State,
                                      Hospital_City,
                                       userId)
            If (hospital <= 0) Then
                msg = "Hospital details not saved"
                Return False
            Else
                msg = "Hospital details saved"
                Return True
            End If
        Catch
            Throw
        End Try
        Return True
    End Function

    Public Function GetHospitalById(ByRef dtbl As ProLabDB.HospitalsDataTable, ByVal Id As String) As Boolean
        Try
            If da.GetHospitalById(dtbl, Id) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetHospitalByName(ByRef dtbl As ProLabDB.HospitalsDataTable, ByVal Name As String) As Boolean
        Try
            If da.GetHospitalByName(dtbl, Name) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function DeleteHospitalById(ByVal HospitalId) As Boolean
        Dim row As Integer
        Try
            row = da.DeleteHospitalById(HospitalId)
            If (row > 0) Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetHospitalForDoctor(ByRef tbl As ProLabDB.HospitalsDataTable) As Boolean
        Try
            If da.GetAllHospitalForDoctor(tbl) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetHospitalWithCity(ByRef dtbl As DataTable) As Boolean
        Try
            If da.GetAllHospitalWithCity(dtbl) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function SaveDoctor(ByRef msg, ByVal userId) As Boolean
        Dim service As Integer
        Try
            service = da.SaveDoctros(Doctor_Id,
                                      Doctor_FName,
                                      Doctor_LName,
                                      Doctor_HospitalId,
                                     userId)
            If (service <= 0) Then
                msg = "Doctor details not saved"
                Return False
            Else
                msg = "Doctor details saved"
                Return True
            End If
        Catch
            Throw
        End Try
        Return True
    End Function

    Public Function GetDoctorById(ByRef dtbl As ProLabDB.DoctorsDataTable, ByVal Id As String) As Boolean
        Try
            If da.GetDoctorById(dtbl, Id) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetDoctorDetailsForTransctionId(ByRef dtbl As ProLabDB.DoctorsDataTable, ByVal Id As String) As Boolean
        Try
            If da.GetDoctorDetailsForTransction(dtbl, Id) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetDocrorByFirstName(ByRef dtbl As ProLabDB.DoctorsDataTable, ByVal FirstName As String) As Boolean
        Try
            If da.GetDoctorByFirstName(dtbl, FirstName) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetDocrorByFullName(ByRef dtbl As ProLabDB.DoctorsDataTable, ByVal firstName As String, ByVal lastName As String) As Boolean
        Try
            If da.GetDoctorByFullName(dtbl, firstName, lastName) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function DeleteDoctorById(ByVal DoctorId) As Boolean
        Dim row As Integer
        Try
            row = da.DeleteDoctorsById(DoctorId)
            If (row > 0) Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function


    Public Function SaveServiceCategory(ByRef msg, ByVal userId) As Boolean
        Dim service As Integer
        Try
            service = da.SaveServiceCategory(SCategory_Id,
                                      SCategory_Name,
                                      SCategory_Description,
                                             userId)
            If (service <= 0) Then
                msg = "Service category not saved"
                Return False
            Else
                msg = "Service category saved"
                Return True
            End If
        Catch
            Throw
        End Try
        Return True
    End Function

    Public Function GetServiceCategoryById(ByRef dtbl As ProLabDB.ServiceCategoryDataTable, ByVal Id As String) As Boolean
        Try
            If da.GetServiceCategoryById(dtbl, Id) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetServiceCategoryByName(ByRef dtbl As ProLabDB.ServiceCategoryDataTable, ByVal CategoryName As String) As Boolean
        Try
            If da.GetServiceCategoryByName(dtbl, CategoryName) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function DeleteServiceCategoryById(ByVal CategoryId) As Boolean
        Dim row As Integer
        Try
            row = da.DeleteServiceCategoryById(CategoryId)
            If (row > 0) Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function CheckExistingService(ByVal ServiceName) As Boolean
        Dim status = False
        Try
            If da.CheckExistingService(ServiceName) Then
                status = True
            Else
                status = False
            End If
        Catch
            Throw
        End Try
        Return status
    End Function

    Public Function CheckExistingServiceCategory(ByVal ServiceCategoryName) As Boolean
        Dim status = False
        Try
            If da.CheckExistingServiceCategory(ServiceCategoryName) Then
                status = True
            Else
                status = False
            End If
        Catch
            Throw
        End Try
        Return status
    End Function

#End Region
End Class
