Imports System.Configuration
Imports System.Reflection

Public Class PatientBill
    Public Shared MBill_Id As String
    Public Shared MBill_BillId As String
    Public Shared MBill_PatientId As String
    Public Shared MBill_TransactionId As String
    Public Shared MBill_TotalAmount As String
    Public Shared MBill_DiscountPercentage As String
    Public Shared MBill_DiscountAmount As String
    Public Shared MBill_Status As String
    Public Shared MBill_IsCancel As String
    Public Shared MBill_PaymentMode As String
    Public Shared MBill_Remarks As String
    Public Shared MBill_InvoiceDate As Date
    Public Shared MBill_UserId As String
    Public Shared MBill_ChequeAmount As String
    Public Shared MBill_ChequeNo As String
    Public Shared MBill_ChequeDate As Date
    Public Shared MBill_BankName As String
    Public Shared MBill_BranchName As String
    Public Shared MBill_IFSCCode As String


    Private MBillTransction_Id As String
    Private MBillTransction_BillId As String
    Private MBillTransction_TransactionId As String
    Private MBillTransction_ServiceTransactionId As String
    Public Sub New(BillTransction_Id As String, BillTransction_BillId As String, BillTransction_TransactionId As String, BillTransction_ServiceTransactionId As String)
        MBillTransction_Id = BillTransction_Id
        MBillTransction_BillId = BillTransction_BillId
        MBillTransction_TransactionId = BillTransction_TransactionId
        MBillTransction_ServiceTransactionId = BillTransction_ServiceTransactionId
    End Sub

    Public Property BillTransction_Id As String
        Get
            Return MBillTransction_Id
        End Get
        Set(ByVal value As String)
            MBillTransction_Id = value
        End Set
    End Property

    Public Property BillTransction_BillId As String
        Get
            Return MBillTransction_BillId
        End Get
        Set(ByVal value As String)
            MBillTransction_BillId = value
        End Set
    End Property

    Public Property BillTransction_ServiceTransactionId As String
        Get
            Return MBillTransction_ServiceTransactionId
        End Get
        Set(ByVal value As String)
            MBillTransction_ServiceTransactionId = value
        End Set
    End Property

    Public Property BillTransction_TransactionId As String
        Get
            Return MBillTransction_TransactionId
        End Get
        Set(ByVal value As String)
            MBillTransction_TransactionId = value
        End Set
    End Property

    Public Shared Property Bill_Id As String
        Get
            Return MBill_Id
        End Get
        Set(ByVal value As String)
            MBill_Id = value
        End Set
    End Property

    Public Shared Property Bill_BillId As String
        Get
            Return MBill_BillId
        End Get
        Set(ByVal value As String)
            MBill_BillId = value
        End Set
    End Property

    Public Shared Property Bill_PatientId As String
        Get
            Return MBill_PatientId
        End Get
        Set(ByVal value As String)
            MBill_PatientId = value
        End Set
    End Property

    Public Shared Property Bill_TransactionId As String
        Get
            Return MBill_TransactionId
        End Get
        Set(ByVal value As String)
            MBill_TransactionId = value
        End Set
    End Property

    Public Shared Property Bill_TotalAmount As String
        Get
            Return MBill_TotalAmount
        End Get
        Set(ByVal value As String)
            MBill_TotalAmount = value
        End Set
    End Property

    Public Shared Property Bill_DiscountPercentage As String
        Get
            Return MBill_DiscountPercentage
        End Get
        Set(ByVal value As String)
            MBill_DiscountPercentage = value
        End Set
    End Property

    Public Shared Property Bill_DiscountAmount As String
        Get
            Return MBill_DiscountAmount
        End Get
        Set(ByVal value As String)
            MBill_DiscountAmount = value
        End Set
    End Property

    Public Shared Property Bill_Status As String
        Get
            Return MBill_Status
        End Get
        Set(ByVal value As String)
            MBill_Status = value
        End Set
    End Property

    Public Shared Property Bill_IsCancel As String
        Get
            Return MBill_IsCancel
        End Get
        Set(ByVal value As String)
            MBill_IsCancel = value
        End Set
    End Property

    Public Shared Property Bill_PaymentMode As String
        Get
            Return MBill_PaymentMode
        End Get
        Set(ByVal value As String)
            MBill_PaymentMode = value
        End Set
    End Property

    Public Shared Property Bill_Remarks As String
        Get
            Return MBill_Remarks
        End Get
        Set(ByVal value As String)
            MBill_Remarks = value
        End Set
    End Property

    Public Shared Property Bill_InvoiceDate As String
        Get
            Return MBill_InvoiceDate
        End Get
        Set(ByVal value As String)
            MBill_InvoiceDate = value
        End Set
    End Property

    Public Shared Property Bill_UserId As String
        Get
            Return MBill_UserId
        End Get
        Set(ByVal value As String)
            MBill_UserId = value
        End Set
    End Property

    Public Shared Property Bill_ChequeAmount As String
        Get
            Return MBill_ChequeAmount
        End Get
        Set(ByVal value As String)
            MBill_ChequeAmount = value
        End Set
    End Property

    Public Shared Property Bill_ChequeNo As String
        Get
            Return MBill_ChequeNo
        End Get
        Set(ByVal value As String)
            MBill_ChequeNo = value
        End Set
    End Property

    Public Shared Property Bill_ChequeDate As Date
        Get
            Return MBill_ChequeDate
        End Get
        Set(ByVal value As Date)
            MBill_ChequeDate = value
        End Set
    End Property

    Public Shared Property Bill_BankName As String
        Get
            Return MBill_BankName
        End Get
        Set(ByVal value As String)
            MBill_BankName = value
        End Set
    End Property

    Public Shared Property Bill_BranchName As String
        Get
            Return MBill_BranchName
        End Get
        Set(ByVal value As String)
            MBill_BranchName = value
        End Set
    End Property

    Public Shared Property Bill_IFSCCode As String
        Get
            Return MBill_IFSCCode
        End Get
        Set(ByVal value As String)
            MBill_IFSCCode = value
        End Set
    End Property

End Class
