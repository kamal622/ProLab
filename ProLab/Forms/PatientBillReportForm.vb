Imports ProLab.Core.Common
Imports ProLab.Service
Imports ProLab.Data
Imports ProLab.Service.PatientTransction

Public Class PatientBillReportForm

    Private transctionService As PatientTransctionService
    Private patientService As PatientService
    Private commanService As CommonService
    Private masterService As MasterService
    Private PatientTranctionId As Integer = 0
    Public PatientId As Integer = 0
    Private DoctorId As Integer = 0
    Private TServiceId As Integer = 0

    Private Sub btnSearchTestList_Click(sender As Object, e As EventArgs) Handles btnSearchTestList.Click
        SearchList()
    End Sub

    Private Sub SearchList()
        Try
            transctionService = New PatientTransctionService()
            Dim dtbl As DataTable = transctionService.GetTransactionListByDate(dtFromDate.Value, dtToDate.Value, comboReportData.SelectedValue)
            dataGridViewTestReportList.DataSource = dtbl
            dataGridViewTestReportList.Columns("ServiceTransactionId").Visible = False
            dataGridViewTestReportList.Columns("PatientTransactionId").Visible = False
            dataGridViewTestReportList.Columns("PatientId").Visible = False
            dataGridViewTestReportList.Columns("ReportStatusId").Visible = False
            dataGridViewTestReportList.ReadOnly = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub PatientBillReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFromDate.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        dtToDate.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
        BindReportStatus()
    End Sub

    Private Sub BindReportStatus()
        Try
            comboReportData.DataSource = Nothing
            commanService = New CommonService()
            'Dim defaultCountry As String = commanService.GetDefaultCountry()
            Dim dtbl As Data.ProLabDB.ReportStatusDataTable = Nothing
            If commanService.GetAllReportStatus(dtbl) Then
                Dim dr As ProLabDB.ReportStatusRow = dtbl.NewReportStatusRow()
                dr.Id = 0
                dr.Name = "All"
                dtbl.Rows.InsertAt(dr, 0)
                comboReportData.ValueMember = "Id"
                comboReportData.DisplayMember = "Name"
                comboReportData.DataSource = dtbl
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dataGridViewTestReportList.DataSource = ""
    End Sub

    Private Sub dataGridViewTestReportList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridViewTestReportList.CellDoubleClick
        Dim frmReportStatus As New ReportStatusForm
        frmReportStatus.StatusId = dataGridViewTestReportList.SelectedRows(0).Cells(9).Value
        frmReportStatus.ServiceTransactionId = dataGridViewTestReportList.SelectedRows(0).Cells(0).Value
        frmReportStatus.PatientTransactionId = dataGridViewTestReportList.SelectedRows(0).Cells(3).Value
        frmReportStatus.ShowDialog(Me)
        SearchList()
    End Sub

End Class