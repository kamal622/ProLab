Imports Microsoft.Reporting.WinForms
Imports ProLab.Service
Imports ProLab.Service.PatientBillService

Public Class PatientBillReceipt

    Private patientBillService As PatientBillService

    Private Sub PatientBillReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim reportData = GetPatientReportData()
            Dim masterData = GetPatientMasterData()

            Dim rptDataSource = New ReportDataSource
            ReportViewer1.ProcessingMode = ProcessingMode.Local
            Dim dataSource = New ReportDataSource("PatientBillDataSet", reportData)
            With masterData(0)
                Dim doctorname = ""
                If .DoctorFname IsNot Nothing And .DoctorLname IsNot Nothing Then
                    doctorname = .DoctorFname + " " + .DoctorLname
                Else
                    doctorname = " "
                End If
                ReportViewer1.LocalReport.SetParameters(New ReportParameter("InvoiceDate", .InvoiceDate))
                ReportViewer1.LocalReport.SetParameters(New ReportParameter("PatientName", .FirstName + " " + .LastName))
                ReportViewer1.LocalReport.SetParameters(New ReportParameter("Mobile", .Mobile))
                ReportViewer1.LocalReport.SetParameters(New ReportParameter("Gender", .Gender))
                ReportViewer1.LocalReport.SetParameters(New ReportParameter("Age", .Age))
                ReportViewer1.LocalReport.SetParameters(New ReportParameter("DiscountAmount", .DiscountAmount))
                ReportViewer1.LocalReport.SetParameters(New ReportParameter("TotalAmount", .TotalAmount))
                ReportViewer1.LocalReport.SetParameters(New ReportParameter("PaymentMode", .PaymentMode))
                ReportViewer1.LocalReport.SetParameters(New ReportParameter("AdvanceAmount", .DepositAmount))
                ReportViewer1.LocalReport.SetParameters(New ReportParameter("DoctorName", doctorname))
            End With

            ReportViewer1.RefreshReport()
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(dataSource)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Function GetPatientReportData() As DataTable
        Try
            patientBillService = New PatientBillService()
            Dim dtbl As DataTable = Nothing
            Dim status As Boolean
            If patBillId > 0 Then
                status = patientBillService.GetPatientBillById(patBillId, dtbl)
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

    Private Function GetPatientMasterData() As Data.ProLabDB.PatientBillMasterDataTable
        Try
            patientBillService = New PatientBillService()
            Dim dtbl As Data.ProLabDB.PatientBillMasterDataTable = Nothing
            Dim status As Boolean
            If patBillId > 0 Then
                status = patientBillService.GetPatientMasterById(bPatientId, patBillId, dtbl)
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

End Class