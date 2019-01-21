Imports System.Configuration
Imports System.Reflection

Public Class Patient
    Public Shared MPatient_Id As String
    Public Shared MPatient_FirstName As String
    Public Shared MPatient_MiddleName As String
    Public Shared MPatient_LastName As String
    Public Shared MPatient_Address1 As String
    Public Shared MPatient_Address2 As String
    Public Shared MPatient_City As String
    Public Shared MPatient_ZipCode As String
    Public Shared MPatient_Mobile As String
    Public Shared MPatient_Email As String
    Public Shared MPatient_Landine As String
    Public Shared MPatient_DOB As String
    Public Shared MPatient_Age As String
    Public Shared MPatient_Gender As String
    Public Shared MPatient_Occupation As String
    Public Shared MPatient_CountryId As String
    Public Shared MPatient_StateId As String
    Public Shared MPatient_UserId As String


    Public Shared Property Patient_Id As String
        Get
            Return MPatient_Id
        End Get
        Set(ByVal value As String)
            MPatient_Id = value
        End Set
    End Property

    Public Shared Property Patient_FirstName As String
        Get
            Return MPatient_FirstName
        End Get
        Set(ByVal value As String)
            MPatient_FirstName = value
        End Set
    End Property

    Public Shared Property Patient_MiddleName As String
        Get
            Return MPatient_MiddleName
        End Get
        Set(ByVal value As String)
            MPatient_MiddleName = value
        End Set
    End Property

    Public Shared Property Patient_LastName As String
        Get
            Return MPatient_LastName
        End Get
        Set(ByVal value As String)
            MPatient_LastName = value
        End Set
    End Property

    Public Shared Property Patient_Address1 As String
        Get
            Return MPatient_Address1
        End Get
        Set(ByVal value As String)
            MPatient_Address1 = value
        End Set
    End Property

    Public Shared Property Patient_Address2 As String
        Get
            Return MPatient_Address2
        End Get
        Set(ByVal value As String)
            MPatient_Address2 = value
        End Set
    End Property

    Public Shared Property Patient_City As String
        Get
            Return MPatient_City
        End Get
        Set(ByVal value As String)
            MPatient_City = value
        End Set
    End Property

    Public Shared Property Patient_ZipCode As String
        Get
            Return MPatient_ZipCode
        End Get
        Set(ByVal value As String)
            MPatient_ZipCode = value
        End Set
    End Property

    Public Shared Property Patient_Mobile As String
        Get
            Return MPatient_Mobile
        End Get
        Set(ByVal value As String)
            MPatient_Mobile = value
        End Set
    End Property

    Public Shared Property Patient_Landine As String
        Get
            Return MPatient_Landine
        End Get
        Set(ByVal value As String)
            MPatient_Landine = value
        End Set
    End Property

    Public Shared Property Patient_Email As String
        Get
            Return MPatient_Email
        End Get
        Set(ByVal value As String)
            MPatient_Email = value
        End Set
    End Property

    Public Shared Property Patient_DOB As String
        Get
            Return MPatient_DOB
        End Get
        Set(ByVal value As String)
            MPatient_DOB = value
        End Set
    End Property

    Public Shared Property Patient_Age As String
        Get
            Return MPatient_Age
        End Get
        Set(ByVal value As String)
            MPatient_Age = value
        End Set
    End Property

    Public Shared Property Patient_Gender As String
        Get
            Return MPatient_Gender
        End Get
        Set(ByVal value As String)
            MPatient_Gender = value
        End Set
    End Property

    Public Shared Property Patient_StateId As String
        Get
            Return MPatient_StateId
        End Get
        Set(ByVal value As String)
            MPatient_StateId = value
        End Set
    End Property

    Public Shared Property Patient_CountryId As String
        Get
            Return MPatient_CountryId
        End Get
        Set(ByVal value As String)
            MPatient_CountryId = value
        End Set
    End Property

    Public Shared Property Patient_UserId As String
        Get
            Return MPatient_UserId
        End Get
        Set(ByVal value As String)
            MPatient_UserId = value
        End Set
    End Property

    Public Shared Property Patient_Occupation As String
        Get
            Return MPatient_Occupation
        End Get
        Set(ByVal value As String)
            MPatient_Occupation = value
        End Set
    End Property


    Public Function GetResourceFile(ByVal Resorcefilename As String) As Resources.ResourceManager
        Dim lresNamespace As String = "ProLab.Data" 'ConfigurationManager.AppSettings("RESOURCE_NAMESPACE").ToString()
        Dim lresFile As String = lresNamespace & "." & Resorcefilename
        Return New Resources.ResourceManager(lresFile, Assembly.Load(lresNamespace))
    End Function
End Class
