Imports ProLab.Service

Public Class ReportStatusForm

    Private mStatus As Integer = 0
    Public WriteOnly Property StatusId() As Integer
        Set(ByVal Value As Integer)
            mStatus = (Value - 1)
        End Set
    End Property

    Private mServiceTransactionId As Integer = 0
    Public WriteOnly Property ServiceTransactionId() As Integer
        Set(ByVal Value As Integer)
            mServiceTransactionId = Value
        End Set
    End Property

    Private mPatientTransactionId As Integer = 0
    Public WriteOnly Property PatientTransactionId() As Integer
        Set(ByVal Value As Integer)
            mPatientTransactionId = Value
        End Set
    End Property

    Private Sub ReportStatusForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindReportStatus()
    End Sub

    Private commanService As CommonService
    Private Sub BindReportStatus()
        Try
            commanService = New CommonService()
            commanService.GetDefaultCountry()
            Dim dtbl As Data.ProLabDB.ReportStatusDataTable = Nothing
            Dim country = commanService.GetAllReportStatus(dtbl)
            comboReportData.ValueMember = "Id"
            comboReportData.DisplayMember = "Name"
            comboReportData.DataSource = dtbl
            'comboReportData.SelectedValue = mStatus.ToString
            comboReportData.SelectedIndex = mStatus
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private transctionService As PatientTransctionService
    Private Sub btnStatusChangeSave_Click(sender As Object, e As EventArgs) Handles btnStatusChangeSave.Click
        Try
            Dim PatientTransactionId As Integer = mPatientTransactionId
            Dim ServiceTransactionsId As Integer = mServiceTransactionId
            Dim ReportStatusId As Integer = comboReportData.SelectedValue
            transctionService = New PatientTransctionService()
            transctionService.UpdatePatientTranction(PatientTransactionId, ServiceTransactionsId, ReportStatusId)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class