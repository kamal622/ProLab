Imports System.Windows.Forms
Imports ProLab.Service.Menu
Imports ProLab.Data

Public Class MenuService
#Region "Declarations"
    Private da As MenuDA
#End Region

    Sub New()
        da = New MenuDA
    End Sub

#Region "Methods"
    Public Function GetAllMenuGroup(ByRef dtbl As ProLabDB.MenuGroupDataTable) As Boolean
        Try
            If da.GetAllMenuGroups(dtbl) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return 0
    End Function

    Public Function GetAllChildMenu(ByRef dtbl As ProLabDB.MenuMasterDataTable) As Boolean
        Try
            If da.GetAllChildMenu(dtbl) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch
            Throw
        End Try
        Return 0
    End Function
#End Region

End Class
