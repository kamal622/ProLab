Imports ProLab.Service.Patient
Imports ProLab.Data

Public Class PatientService
#Region "Declarations"
    Private da As PatientDA
#End Region

    Sub New()
        da = New PatientDA
    End Sub

#Region "Methods"
    Public Function SavePatientInformation(ByRef msg, ByVal userId) As Boolean
        Dim patient As Integer
        Try
            patient = da.SavePatientInformation(Patient_Id,
                                                Patient_FirstName,
                                                Patient_LastName,
                                                Patient_Mobile,
                                                Patient_Landine,
                                                Patient_Email,
                                                Patient_Address1,
                                                Patient_Address2,
                                                Patient_City,
                                                Patient_Age,
                                                Patient_Gender,
                                                Patient_DOB,
                                                Patient_Occupation,
                                                Patient_ZipCode,
                                                Patient_CountryId,
                                                Patient_StateId,
                                                userId)
            If (patient > 0) Then
                msg = "Patient information saved"
                Return True
            Else
                msg = "Patient information not saved"
                Return False
            End If
        Catch
            Throw
        End Try
        Return True
    End Function

    Public Function GetAllPatientInformartion(ByRef src_dtble As DataTable) As ProLabDB.PatientsDataTable
        Dim patient As ProLabDB.PatientsDataTable
        Try
            patient = da.GetPatientDetails()
            src_dtble = patient
            'If (patient Is Nothing) Then
            '    Return "NO RECORD FOUNND"
            'End If
        Catch
            Throw
        End Try
        Return patient
    End Function

    Public Function GetPatientByName(ByVal FirstName As String, ByRef src_dtble As DataTable) As ProLabDB.PatientsDataTable
        Dim patient As ProLabDB.PatientsDataTable
        Try
            patient = da.GetPatientByName(FirstName)
            src_dtble = patient
        Catch
            Throw
        End Try
    End Function

    Public Function GetPatientDetailsByMobile(ByRef dtbl As ProLabDB.PatientsDataTable, ByVal Mobile As String) As Boolean
        Try
            If da.GetPatientByMobile(dtbl, Mobile) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function GetPatientDetailsById(ByRef dtbl As ProLabDB.PatientsDataTable, ByVal Id As Int32) As Boolean
        Try
            If da.GetPatientDetailsById(dtbl, Id) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return False
    End Function

    Public Function DeletePatientById(ByVal PatientId) As Boolean
        Dim row As Integer
        Try
            row = da.DeletePatientById(PatientId)
            If (row > 0) Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
    End Function

    Public Function CheckExistingMobile(ByVal Mobile) As Boolean
        Dim result As Integer
        Try
            result = da.CheckExistingMobile(Mobile)
            If result = 0 Then
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
