Imports System.Configuration
Imports System.Reflection
Imports ProLab

Public Class Menu
    Public Shared MMenuGroup_Id As String
    Public Shared MMenuGroup_GroupName As String
    Public Shared MMenuGroup_GroupOrder As String
    Public Shared MMenuGroup_ParentId As String
    Public Shared MMenuGroup_IsActive As String
    Public Shared MMenuGroup_SerialNo As String
    Public Shared MMenuMaster_Id As String
    Public Shared MMenuMaster_MenuOrder As String
    Public Shared MMenuMaster_MenuParentId As String
    Public Shared MMenuMaster_GroupId As String
    Public Shared MMenuMaster_IsActive As String
    Public Shared MMenuMaster_FormName As String
    Public Shared MMenuMaster_MenuShortcutKey As String
    Public Shared MMenuMaster_SerialNo As String

    Public Shared Property MenuGroup_Id As String
        Get
            Return MMenuGroup_Id
        End Get
        Set(ByVal value As String)
            MMenuGroup_Id = value
        End Set
    End Property

    Public Shared Property MenuGroup_GroupName As String
        Get
            Return MMenuGroup_GroupName
        End Get
        Set(ByVal value As String)
            MMenuGroup_GroupName = value
        End Set
    End Property

    Public Shared Property MenuGroup_GroupOrder As String
        Get
            Return MMenuGroup_GroupOrder
        End Get
        Set(ByVal value As String)
            MMenuGroup_GroupOrder = value
        End Set
    End Property

    Public Shared Property MenuGroup_ParentId As String
        Get
            Return MMenuGroup_ParentId
        End Get
        Set(ByVal value As String)
            MMenuGroup_ParentId = value
        End Set
    End Property

    Public Shared Property MenuGroup_IsActive As String
        Get
            Return MMenuGroup_IsActive
        End Get
        Set(ByVal value As String)
            MMenuGroup_IsActive = value
        End Set
    End Property

    Public Shared Property MenuGroup_SerialNo As String
        Get
            Return MMenuGroup_SerialNo
        End Get
        Set(ByVal value As String)
            MMenuGroup_SerialNo = value
        End Set
    End Property

    Public Shared Property MenuMaster_Id As String
        Get
            Return MMenuMaster_Id
        End Get
        Set(ByVal value As String)
            MMenuMaster_Id = value
        End Set
    End Property

    Public Shared Property MenuMaster_MenuOrder As String
        Get
            Return MMenuMaster_MenuOrder
        End Get
        Set(ByVal value As String)
            MMenuMaster_MenuOrder = value
        End Set
    End Property

    Public Shared Property MenuMaster_MenuParentId As String
        Get
            Return MMenuMaster_MenuParentId
        End Get
        Set(ByVal value As String)
            MMenuMaster_MenuParentId = value
        End Set
    End Property

    Public Shared Property MenuMaster_GroupId As String
        Get
            Return MMenuMaster_GroupId
        End Get
        Set(ByVal value As String)
            MMenuMaster_GroupId = value
        End Set
    End Property

    Public Shared Property MenuMaster_IsActive As String
        Get
            Return MMenuMaster_IsActive
        End Get
        Set(ByVal value As String)
            MMenuMaster_IsActive = value
        End Set
    End Property

    Public Shared Property MenuMaster_FormName As String
        Get
            Return MMenuMaster_FormName
        End Get
        Set(ByVal value As String)
            MMenuMaster_FormName = value
        End Set
    End Property

    Public Shared Property MenuMaster_MenuShortcutKey As String
        Get
            Return MMenuMaster_MenuShortcutKey
        End Get
        Set(ByVal value As String)
            MMenuMaster_MenuShortcutKey = value
        End Set
    End Property

    Public Shared Property MenuMaster_SerialNo As String
        Get
            Return MMenuMaster_SerialNo
        End Get
        Set(ByVal value As String)
            MMenuMaster_SerialNo = value
        End Set
    End Property

End Class
