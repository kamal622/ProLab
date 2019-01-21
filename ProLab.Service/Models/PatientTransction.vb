Imports System.Configuration
Imports System.Reflection


Public Class PatientTransction
    Public Shared MTransction_Id As String
    Public Shared MTransction_SCategory As String
    Public Shared MTransction_SName As String
    Public Shared MTransction_SAmount As String
    Public Shared MTransction_SDateTime As String
    Public Shared MTransction_SDepoiteAmount As String
    Public Shared MTransction_SRemarks As String
    Public Shared MTransction_SPatientId As String
    Public Shared ReportStatusId As String
    Public Shared MTransction_SDoctorId As String
    Public Shared MTransction_SServiceId As String
    Public Shared MTransction_UserId As String
    Public Shared MTransction_SampleRequired As Boolean
    Public Shared MTransction_SampleReceived As Boolean
    Public Shared MTransction_SampleNumber As String

    Private MServiceTransaction_Id As String
    Private MServiceTransaction_ServiceId As String
    Private MServiceTransaction_SCategory As String
    Private MServiceTransaction_SName As String
    Private MServiceTransaction_SAmount As String
    Private MService_PatientTransactionId As String
    Public Sub New(ServiceTransaction_Id As String, ServiceTransaction_ServiceId As String, ServiceTransaction_SCategory As String, ServiceTransaction_SName As String, ServiceTransaction_SAmount As String, Service_PatientTransactionId As String)
        MServiceTransaction_Id = ServiceTransaction_Id
        MServiceTransaction_ServiceId = ServiceTransaction_ServiceId
        MServiceTransaction_SCategory = ServiceTransaction_SCategory
        MServiceTransaction_SName = ServiceTransaction_SName
        MServiceTransaction_SAmount = ServiceTransaction_SAmount
        MService_PatientTransactionId = Service_PatientTransactionId
    End Sub

    Public Property ServiceTransaction_Id As String
        Get
            Return MServiceTransaction_Id
        End Get
        Set(ByVal value As String)
            MServiceTransaction_Id = value
        End Set
    End Property

    Public Property ServiceTransaction_ServiceId As String
        Get
            Return MServiceTransaction_ServiceId
        End Get
        Set(ByVal value As String)
            MServiceTransaction_ServiceId = value
        End Set
    End Property

    Public Property ServiceTransaction_SCategory As String
        Get
            Return MServiceTransaction_SCategory
        End Get
        Set(ByVal value As String)
            MServiceTransaction_SCategory = value
        End Set
    End Property

    Public Property ServiceTransaction_SName As String
        Get
            Return MServiceTransaction_SName
        End Get
        Set(ByVal value As String)
            MServiceTransaction_SName = value
        End Set
    End Property

    Public Property ServiceTransaction_SAmount As String
        Get
            Return MServiceTransaction_SAmount
        End Get
        Set(ByVal value As String)
            MServiceTransaction_SAmount = value
        End Set
    End Property

    Public Property Service_PatientTransactionId As String
        Get
            Return MService_PatientTransactionId
        End Get
        Set(ByVal value As String)
            MService_PatientTransactionId = value
        End Set
    End Property


    Public Shared Property Transction_Id As String
        Get
            Return MTransction_Id
        End Get
        Set(ByVal value As String)
            MTransction_Id = value
        End Set
    End Property

    Public Shared Property Transction_SCategory As String
        Get
            Return MTransction_SCategory
        End Get
        Set(ByVal value As String)
            MTransction_SCategory = value
        End Set
    End Property

    Public Shared Property Transction_SName As String
        Get
            Return MTransction_SName
        End Get
        Set(ByVal value As String)
            MTransction_SName = value
        End Set
    End Property

    Public Shared Property Transction_SAmount As String
        Get
            Return MTransction_SAmount
        End Get
        Set(ByVal value As String)
            MTransction_SAmount = value
        End Set
    End Property

    Public Shared Property Transction_SDateTime As String
        Get
            Return MTransction_SDateTime
        End Get
        Set(ByVal value As String)
            MTransction_SDateTime = value
        End Set
    End Property

    Public Shared Property Transction_SDepoiteAmount As String
        Get
            Return MTransction_SDepoiteAmount
        End Get
        Set(ByVal value As String)
            MTransction_SDepoiteAmount = value
        End Set
    End Property

    Public Shared Property Transction_SRemarks As String
        Get
            Return MTransction_SRemarks
        End Get
        Set(ByVal value As String)
            MTransction_SRemarks = value
        End Set
    End Property

    Public Shared Property Transction_SPatientId As String
        Get
            Return MTransction_SPatientId
        End Get
        Set(ByVal value As String)
            MTransction_SPatientId = value
        End Set
    End Property

    Public Shared Property Transction_SReportStatusId As String
        Get
            Return ReportStatusId
        End Get
        Set(ByVal value As String)
            ReportStatusId = value
        End Set
    End Property

    Public Shared Property Transction_SDoctorId As String
        Get
            Return MTransction_SDoctorId
        End Get
        Set(ByVal value As String)
            MTransction_SDoctorId = value
        End Set
    End Property

    Public Shared Property Transction_SServiceId As String
        Get
            Return MTransction_SServiceId
        End Get
        Set(ByVal value As String)
            MTransction_SServiceId = value
        End Set
    End Property

    Public Shared Property Transction_UserId As String
        Get
            Return MTransction_UserId
        End Get
        Set(ByVal value As String)
            MTransction_UserId = value
        End Set
    End Property

    Public Shared Property Transction_SampleRequired As String
        Get
            Return MTransction_SampleRequired
        End Get
        Set(ByVal value As String)
            MTransction_SampleRequired = value
        End Set
    End Property

    Public Shared Property Transction_SampleReceived As String
        Get
            Return MTransction_SampleReceived
        End Get
        Set(ByVal value As String)
            MTransction_SampleReceived = value
        End Set
    End Property

    Public Shared Property Transction_SampleNumber As String
        Get
            Return MTransction_SampleNumber
        End Get
        Set(ByVal value As String)
            MTransction_SampleNumber = value
        End Set
    End Property


End Class
