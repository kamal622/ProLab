Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Resources
Imports System.Windows.Controls
Imports ProLab.Core

Public Class MenuDA
    Inherits BaseDA

#Region "Declarations"

#End Region

#Region "Iniatialising"
    Public Sub New()
        MyBase.New("Menu")
    End Sub
#End Region

#Region "Methods"

    Public Function GetAllMenuGroups(ByRef dtbl As ProLabDB.MenuGroupDataTable) As Integer
        Dim Qry As String = "GetAllMenuGroup"
        Dim returnValue As Integer
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection()
                Dim parm As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parm.Add(New SqlParameter("@IsActive", SqlDbType.Bit) With {.Value = True, .DbType = DbType.Boolean})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"MenuGroup"}, parm.ToArray())
                dtbl = ds.MenuGroup
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

    Public Function GetAllChildMenu(ByRef dtbl As ProLabDB.MenuMasterDataTable) As Integer
        Dim Qry As String = "GetAllMenuChild"
        Dim returnValue As Integer
        Dim ds As New ProLabDB
        Try
            Using db As New SqlDbConnection
                Dim parms As New List(Of SqlParameter)
                Qry = GetResourceQuery(Qry)
                parms.Add(New SqlParameter("@IsActive", SqlDbType.Bit) With {.Value = True, .DbType = DbType.Boolean})
                SqlHelper.FillDataset(db.Connection, CommandType.Text, Qry, ds, New String() {"MenuMaster"}, parms.ToArray())
                dtbl = ds.MenuMaster
                returnValue = dtbl.Rows.Count
            End Using
        Catch
            Throw
        End Try
        Return returnValue
    End Function

#End Region
End Class
