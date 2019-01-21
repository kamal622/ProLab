Imports System.Configuration
Imports System.Reflection
Imports ProLab

Public Class ServiceMaster
    Public Shared MService_Id As String
    Public Shared MService_Category As String
    Public Shared MService_Name As String
    Public Shared MService_Amount As String
    Public Shared MService_Description As String
    Public Shared MService_Appoiment As String
    Public Shared MService_IsActive As String

    Public Shared MHospital_Id As String
    Public Shared MHospital_Name As String
    Public Shared MHospital_Address1 As String
    Public Shared MHospital_Address2 As String
    Public Shared MHospital_Phone1 As String
    Public Shared MHospital_Phone2 As String
    Public Shared MHospital_Country As String
    Public Shared MHospital_State As String
    Public Shared MHospital_City As String

    Public Shared MDoctor_Id As String
    Public Shared MDoctor_FName As String
    Public Shared MDoctor_LName As String
    Public Shared MDoctor_HospitalId As String

    Public Shared MSCategory_Id As String
    Public Shared MSCategory_Name As String
    Public Shared MSCategory_Description As String

    Public Shared Mservice_UserId As String

    Public Shared Property Service_Id As String
        Get
            Return MService_Id
        End Get
        Set(ByVal value As String)
            MService_Id = value
        End Set
    End Property

    Public Shared Property Service_Category As String
        Get
            Return MService_Category
        End Get
        Set(ByVal value As String)
            MService_Category = value
        End Set
    End Property

    Public Shared Property Service_Name As String
        Get
            Return MService_Name
        End Get
        Set(ByVal value As String)
            MService_Name = value
        End Set
    End Property

    Public Shared Property Service_Amount As String
        Get
            Return MService_Amount
        End Get
        Set(ByVal value As String)
            MService_Amount = value
        End Set
    End Property

    Public Shared Property Service_Description As String
        Get
            Return MService_Description
        End Get
        Set(ByVal value As String)
            MService_Description = value
        End Set
    End Property

    Public Shared Property Service_Appoiment As String
        Get
            Return MService_Appoiment
        End Get
        Set(ByVal value As String)
            MService_Appoiment = value
        End Set
    End Property

    Public Shared Property Service_IsActive As String
        Get
            Return MService_IsActive
        End Get
        Set(ByVal value As String)
            MService_IsActive = value
        End Set
    End Property


    Public Shared Property Hospital_Id As String
        Get
            Return MHospital_Id
        End Get
        Set(ByVal value As String)
            MHospital_Id = value
        End Set
    End Property

    Public Shared Property Hospital_Name As String
        Get
            Return MHospital_Name
        End Get
        Set(ByVal value As String)
            MHospital_Name = value
        End Set
    End Property

    Public Shared Property Hospital_Address1 As String
        Get
            Return MHospital_Address1
        End Get
        Set(ByVal value As String)
            MHospital_Address1 = value
        End Set
    End Property

    Public Shared Property Hospital_Address2 As String
        Get
            Return MHospital_Address2
        End Get
        Set(ByVal value As String)
            MHospital_Address2 = value
        End Set
    End Property

    Public Shared Property Hospital_Phone1 As String
        Get
            Return MHospital_Phone1
        End Get
        Set(ByVal value As String)
            MHospital_Phone1 = value
        End Set
    End Property

    Public Shared Property Hospital_Phone2 As String
        Get
            Return MHospital_Phone2
        End Get
        Set(ByVal value As String)
            MHospital_Phone2 = value
        End Set
    End Property

    Public Shared Property Hospital_Country As String
        Get
            Return MHospital_Country
        End Get
        Set(ByVal value As String)
            MHospital_Country = value
        End Set
    End Property

    Public Shared Property Hospital_State As String
        Get
            Return MHospital_State
        End Get
        Set(ByVal value As String)
            MHospital_State = value
        End Set
    End Property

    Public Shared Property Hospital_City As String
        Get
            Return MHospital_City
        End Get
        Set(ByVal value As String)
            MHospital_City = value
        End Set
    End Property

    Public Shared Property Doctor_Id As String
        Get
            Return MDoctor_Id
        End Get
        Set(ByVal value As String)
            MDoctor_Id = value
        End Set
    End Property

    Public Shared Property Doctor_FName As String
        Get
            Return MDoctor_FName
        End Get
        Set(ByVal value As String)
            MDoctor_FName = value
        End Set
    End Property

    Public Shared Property Doctor_LName As String
        Get
            Return MDoctor_LName
        End Get
        Set(ByVal value As String)
            MDoctor_LName = value
        End Set
    End Property

    Public Shared Property Doctor_HospitalId As String
        Get
            Return MDoctor_HospitalId
        End Get
        Set(ByVal value As String)
            MDoctor_HospitalId = value
        End Set
    End Property

    Public Shared Property SCategory_Id As String
        Get
            Return MSCategory_Id
        End Get
        Set(ByVal value As String)
            MSCategory_Id = value
        End Set
    End Property

    Public Shared Property SCategory_Name As String
        Get
            Return MSCategory_Name
        End Get
        Set(ByVal value As String)
            MSCategory_Name = value
        End Set
    End Property

    Public Shared Property SCategory_Description As String
        Get
            Return MSCategory_Description
        End Get
        Set(ByVal value As String)
            MSCategory_Description = value
        End Set
    End Property

    Public Shared Property service_UserId As String
        Get
            Return Mservice_UserId
        End Get
        Set(ByVal value As String)
            Mservice_UserId = value
        End Set
    End Property

End Class
