Imports System.Configuration
Imports System.Reflection

Public Class Common
    Public Shared mUser_ID As String
    Public Shared mUser_Name As String
    Public Shared mUser_Password As String
    Public Shared mProduct_Name As String

    Public Shared Property User_ID() As String
        Get
            Return mUser_ID
        End Get
        Set(ByVal value As String)
            mUser_ID = value
        End Set
    End Property
    Public Shared Property User_Name() As String
        Get
            Return mUser_Name
        End Get
        Set(ByVal value As String)
            mUser_Name = value
        End Set
    End Property
    Public Shared Property User_Password() As String
        Get
            Return mUser_Password
        End Get
        Set(ByVal value As String)
            mUser_Password = value
        End Set
    End Property
    Public Shared Property Product_Name() As String
        Get
            If Len(mProduct_Name) = 0 Then mProduct_Name = "Laboratory Management System"
            Return mProduct_Name
        End Get
        Set(ByVal value As String)
            mProduct_Name = value
        End Set
    End Property
    Public Function GetResourceFile(ByVal Resorcefilename As String) As Resources.ResourceManager
        Dim lresNamespace As String = "ProLab.Data"
        Dim lresFile As String = lresNamespace & "." & Resorcefilename
        Return New Resources.ResourceManager(lresFile, Assembly.Load(lresNamespace))
    End Function

End Class
