Imports System
Imports System.Resources

Public Class BaseDA

    Private objCommon As New Core.Common
    Private resManager As ResourceManager

    Protected ReadOnly Property QueryResource As ResourceManager
        Get
            Return resManager
        End Get
    End Property


    Public Sub New(ByVal resourceFileName As String)
        resManager = objCommon.GetResourceFile(resourceFileName)
    End Sub

    Protected Function GetResourceQuery(ByVal QueryName As String) As String
        Try
            Return resManager.GetString(QueryName).ToString()
        Catch ex As Exception
            Return ""
        End Try
    End Function
End Class
