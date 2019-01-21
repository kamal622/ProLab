Imports Microsoft.Reporting.WinForms
Imports ProLab.Service

Public Class TestReportListByGroup

    Public patientTransctionService As PatientTransctionService
    Private Function GetPatientReportListData() As DataTable
        Try
            patientTransctionService = New PatientTransctionService()
            Dim dtbl As DataTable = Nothing
            Dim status As Boolean
            If patientTransId > 0 Then
                If status Then
                    Return dtbl
                Else
                    Return Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub btnSearchTestList_Click(sender As Object, e As EventArgs) Handles btnSearchTestList.Click
        Try
            Dim s As Integer
            Int32.TryParse("All", s)
            Dim reportData = GetPatientReportListData()
            Dim dtbl As DataTable = patientTransctionService.GetTransactionListByDate(dtFromDate.Value, dtToDate.Value, s)
            Dim rptDataSource = New ReportDataSource
            Dim dataSource = New ReportDataSource("ReportListByGroupDataSet", dtbl)
            ReportViewer1.LocalReport.DataSources.Add(dataSource)
            ReportViewer1.ProcessingMode = ProcessingMode.Local
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TestReportListByGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFromDate.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, (DateTime.Now.Day - 1))
    End Sub
End Class