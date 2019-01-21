Imports System.Configuration
Imports System.Reflection
Imports ProLab.Core.Common

Module CommonModule
#Region "P r o c e d u r e s"
    Public mId As Integer = 0
    Public IsFormClear As Boolean = False
    Public patientTransId As Integer = 0
    Public patBillId As Integer = 0
    Public bPatientId As Integer = 0

    Public Sub ShowSearchengine(ByRef Req_Ctrl As Object,
                                    ByVal Req_Qry As String,
                                    ByVal Req_Fieldno As Short,
                                    ByVal Def_Filterfield As String,
                                    Optional ByVal Req_Colwidth As String = "",
                                    Optional ByVal Req_Orderbyfield As String = "",
                                    Optional ByVal Def_Rowsdiplayed As Short = 0
                                    )
        Try
            With SearchForm
                .Clear_Values()
                .Req_Ctrl = Req_Ctrl
                .Req_Qry = Req_Qry
                .Req_Fieldno = Req_Fieldno
                .Def_Filterfield = Def_Filterfield
                .Req_Colwidth = Req_Colwidth
                .Req_Orderbyfield = Req_Orderbyfield
                .Def_Rowsdiplayed = Def_Rowsdiplayed
                .Search()
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ShowReportStatusForm(ByVal StatusId As Integer)
        Try
            With ReportStatusForm
                .StatusId = StatusId
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
End Module
