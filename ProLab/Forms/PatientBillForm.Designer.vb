<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientBillForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientBillForm))
        Me.tblPatientBillHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlPatientBillHeader = New System.Windows.Forms.Panel()
        Me.lblPatientBillMode = New System.Windows.Forms.Label()
        Me.lblPatientBillHeader = New System.Windows.Forms.Label()
        Me.gbPatientBillSearch = New System.Windows.Forms.GroupBox()
        Me.pnlBillPatineDetails = New System.Windows.Forms.Panel()
        Me.lblBillPatMobile = New System.Windows.Forms.Label()
        Me.lblBillPatAddress = New System.Windows.Forms.Label()
        Me.lblBillPatFullName = New System.Windows.Forms.Label()
        Me.lblBMobile = New System.Windows.Forms.Label()
        Me.lblBAddress = New System.Windows.Forms.Label()
        Me.lblPatName = New System.Windows.Forms.Label()
        Me.btnFindBillByMobile = New System.Windows.Forms.Button()
        Me.txtBillFindByMobile = New System.Windows.Forms.TextBox()
        Me.lblBillFindByPatMobile = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRemainingBalance = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDiscountAmount = New System.Windows.Forms.Label()
        Me.lblPatPaidAmount = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPatUnpaidAmount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlCreadiPosition = New System.Windows.Forms.Panel()
        Me.tabPatientBill = New System.Windows.Forms.TabControl()
        Me.tabPatientBillDetails = New System.Windows.Forms.TabPage()
        Me.dtInvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.lblInvoiceDate = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBillClose = New System.Windows.Forms.Button()
        Me.btnBillClear = New System.Windows.Forms.Button()
        Me.btnGenerateBill = New System.Windows.Forms.Button()
        Me.txtBillRemarks = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbtnPaymentCheque = New System.Windows.Forms.RadioButton()
        Me.rbtnPaymentCash = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDiscountAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiscountByPercentage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalBillAmount = New System.Windows.Forms.Label()
        Me.lblTotalBeforeDisc = New System.Windows.Forms.Label()
        Me.lblTotalPayableAmount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dataGridPatientBill = New System.Windows.Forms.DataGridView()
        Me.btnSelectTranasction = New System.Windows.Forms.Button()
        Me.tblPatientBillHeader.SuspendLayout()
        Me.pnlPatientBillHeader.SuspendLayout()
        Me.gbPatientBillSearch.SuspendLayout()
        Me.pnlBillPatineDetails.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlCreadiPosition.SuspendLayout()
        Me.tabPatientBill.SuspendLayout()
        Me.tabPatientBillDetails.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dataGridPatientBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblPatientBillHeader
        '
        Me.tblPatientBillHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tblPatientBillHeader.ColumnCount = 1
        Me.tblPatientBillHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPatientBillHeader.Controls.Add(Me.pnlPatientBillHeader, 0, 0)
        Me.tblPatientBillHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblPatientBillHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblPatientBillHeader.Name = "tblPatientBillHeader"
        Me.tblPatientBillHeader.RowCount = 1
        Me.tblPatientBillHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPatientBillHeader.Size = New System.Drawing.Size(734, 40)
        Me.tblPatientBillHeader.TabIndex = 0
        '
        'pnlPatientBillHeader
        '
        Me.pnlPatientBillHeader.Controls.Add(Me.lblPatientBillMode)
        Me.pnlPatientBillHeader.Controls.Add(Me.lblPatientBillHeader)
        Me.pnlPatientBillHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPatientBillHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlPatientBillHeader.Name = "pnlPatientBillHeader"
        Me.pnlPatientBillHeader.Size = New System.Drawing.Size(728, 34)
        Me.pnlPatientBillHeader.TabIndex = 0
        '
        'lblPatientBillMode
        '
        Me.lblPatientBillMode.AutoSize = True
        Me.lblPatientBillMode.BackColor = System.Drawing.Color.Maroon
        Me.lblPatientBillMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblPatientBillMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientBillMode.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPatientBillMode.Location = New System.Drawing.Point(635, 9)
        Me.lblPatientBillMode.Name = "lblPatientBillMode"
        Me.lblPatientBillMode.Size = New System.Drawing.Size(74, 17)
        Me.lblPatientBillMode.TabIndex = 1
        Me.lblPatientBillMode.Text = "New Mode"
        '
        'lblPatientBillHeader
        '
        Me.lblPatientBillHeader.AutoSize = True
        Me.lblPatientBillHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientBillHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPatientBillHeader.Location = New System.Drawing.Point(17, 9)
        Me.lblPatientBillHeader.Name = "lblPatientBillHeader"
        Me.lblPatientBillHeader.Size = New System.Drawing.Size(86, 17)
        Me.lblPatientBillHeader.TabIndex = 0
        Me.lblPatientBillHeader.Text = "Patient Bill"
        '
        'gbPatientBillSearch
        '
        Me.gbPatientBillSearch.BackColor = System.Drawing.Color.Transparent
        Me.gbPatientBillSearch.Controls.Add(Me.pnlBillPatineDetails)
        Me.gbPatientBillSearch.Controls.Add(Me.btnFindBillByMobile)
        Me.gbPatientBillSearch.Controls.Add(Me.txtBillFindByMobile)
        Me.gbPatientBillSearch.Controls.Add(Me.lblBillFindByPatMobile)
        Me.gbPatientBillSearch.Location = New System.Drawing.Point(9, 50)
        Me.gbPatientBillSearch.Name = "gbPatientBillSearch"
        Me.gbPatientBillSearch.Size = New System.Drawing.Size(356, 176)
        Me.gbPatientBillSearch.TabIndex = 1
        Me.gbPatientBillSearch.TabStop = False
        Me.gbPatientBillSearch.Text = "Search"
        '
        'pnlBillPatineDetails
        '
        Me.pnlBillPatineDetails.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlBillPatineDetails.Controls.Add(Me.lblBillPatMobile)
        Me.pnlBillPatineDetails.Controls.Add(Me.lblBillPatAddress)
        Me.pnlBillPatineDetails.Controls.Add(Me.lblBillPatFullName)
        Me.pnlBillPatineDetails.Controls.Add(Me.lblBMobile)
        Me.pnlBillPatineDetails.Controls.Add(Me.lblBAddress)
        Me.pnlBillPatineDetails.Controls.Add(Me.lblPatName)
        Me.pnlBillPatineDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlBillPatineDetails.ForeColor = System.Drawing.Color.DarkBlue
        Me.pnlBillPatineDetails.Location = New System.Drawing.Point(9, 54)
        Me.pnlBillPatineDetails.Name = "pnlBillPatineDetails"
        Me.pnlBillPatineDetails.Size = New System.Drawing.Size(338, 115)
        Me.pnlBillPatineDetails.TabIndex = 3
        '
        'lblBillPatMobile
        '
        Me.lblBillPatMobile.AutoSize = True
        Me.lblBillPatMobile.Location = New System.Drawing.Point(79, 66)
        Me.lblBillPatMobile.Name = "lblBillPatMobile"
        Me.lblBillPatMobile.Size = New System.Drawing.Size(0, 13)
        Me.lblBillPatMobile.TabIndex = 5
        '
        'lblBillPatAddress
        '
        Me.lblBillPatAddress.AutoSize = True
        Me.lblBillPatAddress.Location = New System.Drawing.Point(79, 41)
        Me.lblBillPatAddress.Name = "lblBillPatAddress"
        Me.lblBillPatAddress.Size = New System.Drawing.Size(0, 13)
        Me.lblBillPatAddress.TabIndex = 4
        '
        'lblBillPatFullName
        '
        Me.lblBillPatFullName.AutoSize = True
        Me.lblBillPatFullName.Location = New System.Drawing.Point(79, 15)
        Me.lblBillPatFullName.Name = "lblBillPatFullName"
        Me.lblBillPatFullName.Size = New System.Drawing.Size(0, 13)
        Me.lblBillPatFullName.TabIndex = 3
        '
        'lblBMobile
        '
        Me.lblBMobile.AutoSize = True
        Me.lblBMobile.Location = New System.Drawing.Point(20, 66)
        Me.lblBMobile.Name = "lblBMobile"
        Me.lblBMobile.Size = New System.Drawing.Size(44, 13)
        Me.lblBMobile.TabIndex = 2
        Me.lblBMobile.Text = "Mobile"
        '
        'lblBAddress
        '
        Me.lblBAddress.AutoSize = True
        Me.lblBAddress.Location = New System.Drawing.Point(20, 41)
        Me.lblBAddress.Name = "lblBAddress"
        Me.lblBAddress.Size = New System.Drawing.Size(52, 13)
        Me.lblBAddress.TabIndex = 1
        Me.lblBAddress.Text = "Address"
        '
        'lblPatName
        '
        Me.lblPatName.AutoSize = True
        Me.lblPatName.Location = New System.Drawing.Point(20, 15)
        Me.lblPatName.Name = "lblPatName"
        Me.lblPatName.Size = New System.Drawing.Size(39, 13)
        Me.lblPatName.TabIndex = 0
        Me.lblPatName.Text = "Name"
        '
        'btnFindBillByMobile
        '
        Me.btnFindBillByMobile.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnFindBillByMobile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindBillByMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindBillByMobile.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFindBillByMobile.Location = New System.Drawing.Point(317, 21)
        Me.btnFindBillByMobile.Name = "btnFindBillByMobile"
        Me.btnFindBillByMobile.Size = New System.Drawing.Size(30, 20)
        Me.btnFindBillByMobile.TabIndex = 2
        Me.btnFindBillByMobile.Text = "F2"
        Me.btnFindBillByMobile.UseVisualStyleBackColor = True
        '
        'txtBillFindByMobile
        '
        Me.txtBillFindByMobile.Location = New System.Drawing.Point(76, 21)
        Me.txtBillFindByMobile.Name = "txtBillFindByMobile"
        Me.txtBillFindByMobile.Size = New System.Drawing.Size(235, 20)
        Me.txtBillFindByMobile.TabIndex = 1
        '
        'lblBillFindByPatMobile
        '
        Me.lblBillFindByPatMobile.AutoSize = True
        Me.lblBillFindByPatMobile.Location = New System.Drawing.Point(6, 21)
        Me.lblBillFindByPatMobile.Name = "lblBillFindByPatMobile"
        Me.lblBillFindByPatMobile.Size = New System.Drawing.Size(38, 13)
        Me.lblBillFindByPatMobile.TabIndex = 0
        Me.lblBillFindByPatMobile.Text = "Mobile"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.09571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.90429!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblRemainingBalance, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDiscountAmount, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPatPaidAmount, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPatUnpaidAmount, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(16, 15)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(303, 87)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'lblRemainingBalance
        '
        Me.lblRemainingBalance.AutoSize = True
        Me.lblRemainingBalance.Location = New System.Drawing.Point(176, 66)
        Me.lblRemainingBalance.Margin = New System.Windows.Forms.Padding(3)
        Me.lblRemainingBalance.Name = "lblRemainingBalance"
        Me.lblRemainingBalance.Size = New System.Drawing.Size(53, 13)
        Me.lblRemainingBalance.TabIndex = 7
        Me.lblRemainingBalance.Text = "0000.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 3)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Advance Amount"
        '
        'lblDiscountAmount
        '
        Me.lblDiscountAmount.AutoSize = True
        Me.lblDiscountAmount.Location = New System.Drawing.Point(176, 45)
        Me.lblDiscountAmount.Margin = New System.Windows.Forms.Padding(3)
        Me.lblDiscountAmount.Name = "lblDiscountAmount"
        Me.lblDiscountAmount.Size = New System.Drawing.Size(53, 13)
        Me.lblDiscountAmount.TabIndex = 6
        Me.lblDiscountAmount.Text = "0000.00"
        '
        'lblPatPaidAmount
        '
        Me.lblPatPaidAmount.AutoSize = True
        Me.lblPatPaidAmount.Location = New System.Drawing.Point(176, 3)
        Me.lblPatPaidAmount.Margin = New System.Windows.Forms.Padding(3)
        Me.lblPatPaidAmount.Name = "lblPatPaidAmount"
        Me.lblPatPaidAmount.Size = New System.Drawing.Size(53, 13)
        Me.lblPatPaidAmount.TabIndex = 1
        Me.lblPatPaidAmount.Text = "0000.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total Amount"
        '
        'lblPatUnpaidAmount
        '
        Me.lblPatUnpaidAmount.AutoSize = True
        Me.lblPatUnpaidAmount.Location = New System.Drawing.Point(176, 24)
        Me.lblPatUnpaidAmount.Margin = New System.Windows.Forms.Padding(3)
        Me.lblPatUnpaidAmount.Name = "lblPatUnpaidAmount"
        Me.lblPatUnpaidAmount.Size = New System.Drawing.Size(53, 13)
        Me.lblPatUnpaidAmount.TabIndex = 3
        Me.lblPatUnpaidAmount.Text = "0000.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 66)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Remaining Balance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 45)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Discount"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.pnlCreadiPosition)
        Me.GroupBox1.Location = New System.Drawing.Point(369, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 176)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Credit Position"
        '
        'pnlCreadiPosition
        '
        Me.pnlCreadiPosition.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlCreadiPosition.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlCreadiPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlCreadiPosition.ForeColor = System.Drawing.Color.DarkBlue
        Me.pnlCreadiPosition.Location = New System.Drawing.Point(6, 54)
        Me.pnlCreadiPosition.Name = "pnlCreadiPosition"
        Me.pnlCreadiPosition.Size = New System.Drawing.Size(335, 115)
        Me.pnlCreadiPosition.TabIndex = 0
        '
        'tabPatientBill
        '
        Me.tabPatientBill.Controls.Add(Me.tabPatientBillDetails)
        Me.tabPatientBill.Location = New System.Drawing.Point(9, 232)
        Me.tabPatientBill.Name = "tabPatientBill"
        Me.tabPatientBill.SelectedIndex = 0
        Me.tabPatientBill.Size = New System.Drawing.Size(716, 361)
        Me.tabPatientBill.TabIndex = 3
        '
        'tabPatientBillDetails
        '
        Me.tabPatientBillDetails.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.tabPatientBillDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabPatientBillDetails.Controls.Add(Me.dtInvoiceDate)
        Me.tabPatientBillDetails.Controls.Add(Me.lblInvoiceDate)
        Me.tabPatientBillDetails.Controls.Add(Me.Panel1)
        Me.tabPatientBillDetails.Controls.Add(Me.txtBillRemarks)
        Me.tabPatientBillDetails.Controls.Add(Me.Label5)
        Me.tabPatientBillDetails.Controls.Add(Me.rbtnPaymentCheque)
        Me.tabPatientBillDetails.Controls.Add(Me.rbtnPaymentCash)
        Me.tabPatientBillDetails.Controls.Add(Me.Label4)
        Me.tabPatientBillDetails.Controls.Add(Me.txtDiscountAmount)
        Me.tabPatientBillDetails.Controls.Add(Me.Label3)
        Me.tabPatientBillDetails.Controls.Add(Me.txtDiscountByPercentage)
        Me.tabPatientBillDetails.Controls.Add(Me.Label2)
        Me.tabPatientBillDetails.Controls.Add(Me.txtBillNo)
        Me.tabPatientBillDetails.Controls.Add(Me.Label1)
        Me.tabPatientBillDetails.Controls.Add(Me.lblTotalBillAmount)
        Me.tabPatientBillDetails.Controls.Add(Me.lblTotalBeforeDisc)
        Me.tabPatientBillDetails.Controls.Add(Me.lblTotalPayableAmount)
        Me.tabPatientBillDetails.Controls.Add(Me.lblTotal)
        Me.tabPatientBillDetails.Controls.Add(Me.dataGridPatientBill)
        Me.tabPatientBillDetails.Controls.Add(Me.btnSelectTranasction)
        Me.tabPatientBillDetails.Location = New System.Drawing.Point(4, 22)
        Me.tabPatientBillDetails.Name = "tabPatientBillDetails"
        Me.tabPatientBillDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPatientBillDetails.Size = New System.Drawing.Size(708, 335)
        Me.tabPatientBillDetails.TabIndex = 0
        Me.tabPatientBillDetails.Text = "Bill Details"
        Me.tabPatientBillDetails.UseVisualStyleBackColor = True
        '
        'dtInvoiceDate
        '
        Me.dtInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInvoiceDate.Location = New System.Drawing.Point(605, 7)
        Me.dtInvoiceDate.Name = "dtInvoiceDate"
        Me.dtInvoiceDate.Size = New System.Drawing.Size(92, 20)
        Me.dtInvoiceDate.TabIndex = 1
        '
        'lblInvoiceDate
        '
        Me.lblInvoiceDate.AutoSize = True
        Me.lblInvoiceDate.Location = New System.Drawing.Point(528, 11)
        Me.lblInvoiceDate.Name = "lblInvoiceDate"
        Me.lblInvoiceDate.Size = New System.Drawing.Size(68, 13)
        Me.lblInvoiceDate.TabIndex = 35
        Me.lblInvoiceDate.Text = "Invoice Date"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnBillClose)
        Me.Panel1.Controls.Add(Me.btnBillClear)
        Me.Panel1.Controls.Add(Me.btnGenerateBill)
        Me.Panel1.Location = New System.Drawing.Point(485, 294)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 35)
        Me.Panel1.TabIndex = 34
        '
        'btnBillClose
        '
        Me.btnBillClose.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnBillClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillClose.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBillClose.Location = New System.Drawing.Point(156, 3)
        Me.btnBillClose.Name = "btnBillClose"
        Me.btnBillClose.Size = New System.Drawing.Size(56, 30)
        Me.btnBillClose.TabIndex = 5
        Me.btnBillClose.Text = "&Close"
        Me.btnBillClose.UseVisualStyleBackColor = True
        '
        'btnBillClear
        '
        Me.btnBillClear.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnBillClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBillClear.Location = New System.Drawing.Point(98, 3)
        Me.btnBillClear.Name = "btnBillClear"
        Me.btnBillClear.Size = New System.Drawing.Size(56, 30)
        Me.btnBillClear.TabIndex = 2
        Me.btnBillClear.Text = "C&lear"
        Me.btnBillClear.UseVisualStyleBackColor = True
        '
        'btnGenerateBill
        '
        Me.btnGenerateBill.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnGenerateBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateBill.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGenerateBill.Location = New System.Drawing.Point(2, 3)
        Me.btnGenerateBill.Name = "btnGenerateBill"
        Me.btnGenerateBill.Size = New System.Drawing.Size(95, 30)
        Me.btnGenerateBill.TabIndex = 0
        Me.btnGenerateBill.Text = "&Generate Bill"
        Me.btnGenerateBill.UseVisualStyleBackColor = True
        '
        'txtBillRemarks
        '
        Me.txtBillRemarks.Location = New System.Drawing.Point(143, 263)
        Me.txtBillRemarks.Name = "txtBillRemarks"
        Me.txtBillRemarks.ReadOnly = True
        Me.txtBillRemarks.Size = New System.Drawing.Size(377, 20)
        Me.txtBillRemarks.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Remarks"
        '
        'rbtnPaymentCheque
        '
        Me.rbtnPaymentCheque.AutoSize = True
        Me.rbtnPaymentCheque.Location = New System.Drawing.Point(201, 241)
        Me.rbtnPaymentCheque.Name = "rbtnPaymentCheque"
        Me.rbtnPaymentCheque.Size = New System.Drawing.Size(62, 17)
        Me.rbtnPaymentCheque.TabIndex = 31
        Me.rbtnPaymentCheque.TabStop = True
        Me.rbtnPaymentCheque.Text = "Cheque"
        Me.rbtnPaymentCheque.UseVisualStyleBackColor = True
        '
        'rbtnPaymentCash
        '
        Me.rbtnPaymentCash.AutoSize = True
        Me.rbtnPaymentCash.Checked = True
        Me.rbtnPaymentCash.Location = New System.Drawing.Point(143, 241)
        Me.rbtnPaymentCash.Name = "rbtnPaymentCash"
        Me.rbtnPaymentCash.Size = New System.Drawing.Size(49, 17)
        Me.rbtnPaymentCash.TabIndex = 30
        Me.rbtnPaymentCash.TabStop = True
        Me.rbtnPaymentCash.Text = "Cash"
        Me.rbtnPaymentCash.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Payment Mode"
        '
        'txtDiscountAmount
        '
        Me.txtDiscountAmount.Location = New System.Drawing.Point(389, 208)
        Me.txtDiscountAmount.Name = "txtDiscountAmount"
        Me.txtDiscountAmount.ReadOnly = True
        Me.txtDiscountAmount.Size = New System.Drawing.Size(131, 20)
        Me.txtDiscountAmount.TabIndex = 28
        Me.txtDiscountAmount.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Discount Amount"
        '
        'txtDiscountByPercentage
        '
        Me.txtDiscountByPercentage.Location = New System.Drawing.Point(141, 212)
        Me.txtDiscountByPercentage.Name = "txtDiscountByPercentage"
        Me.txtDiscountByPercentage.ReadOnly = True
        Me.txtDiscountByPercentage.Size = New System.Drawing.Size(150, 20)
        Me.txtDiscountByPercentage.TabIndex = 26
        Me.txtDiscountByPercentage.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Discount By Percentage"
        '
        'txtBillNo
        '
        Me.txtBillNo.Location = New System.Drawing.Point(141, 185)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.ReadOnly = True
        Me.txtBillNo.Size = New System.Drawing.Size(150, 20)
        Me.txtBillNo.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "BillNo"
        '
        'lblTotalBillAmount
        '
        Me.lblTotalBillAmount.AutoSize = True
        Me.lblTotalBillAmount.Location = New System.Drawing.Point(654, 188)
        Me.lblTotalBillAmount.Name = "lblTotalBillAmount"
        Me.lblTotalBillAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblTotalBillAmount.TabIndex = 22
        Me.lblTotalBillAmount.Text = "0000.00"
        '
        'lblTotalBeforeDisc
        '
        Me.lblTotalBeforeDisc.AutoSize = True
        Me.lblTotalBeforeDisc.Location = New System.Drawing.Point(558, 188)
        Me.lblTotalBeforeDisc.Name = "lblTotalBeforeDisc"
        Me.lblTotalBeforeDisc.Size = New System.Drawing.Size(70, 13)
        Me.lblTotalBeforeDisc.TabIndex = 21
        Me.lblTotalBeforeDisc.Text = "Total Amount"
        '
        'lblTotalPayableAmount
        '
        Me.lblTotalPayableAmount.AutoSize = True
        Me.lblTotalPayableAmount.Location = New System.Drawing.Point(653, 211)
        Me.lblTotalPayableAmount.Name = "lblTotalPayableAmount"
        Me.lblTotalPayableAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblTotalPayableAmount.TabIndex = 14
        Me.lblTotalPayableAmount.Text = "0000.00"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(558, 212)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(84, 13)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "Payable Amount"
        '
        'dataGridPatientBill
        '
        Me.dataGridPatientBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridPatientBill.Location = New System.Drawing.Point(9, 35)
        Me.dataGridPatientBill.Name = "dataGridPatientBill"
        Me.dataGridPatientBill.Size = New System.Drawing.Size(690, 145)
        Me.dataGridPatientBill.TabIndex = 1
        '
        'btnSelectTranasction
        '
        Me.btnSelectTranasction.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnSelectTranasction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelectTranasction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectTranasction.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSelectTranasction.Location = New System.Drawing.Point(9, 7)
        Me.btnSelectTranasction.Name = "btnSelectTranasction"
        Me.btnSelectTranasction.Size = New System.Drawing.Size(133, 23)
        Me.btnSelectTranasction.TabIndex = 0
        Me.btnSelectTranasction.Text = "Select Transaction"
        Me.btnSelectTranasction.UseVisualStyleBackColor = True
        '
        'PatientBillForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 605)
        Me.Controls.Add(Me.tabPatientBill)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbPatientBillSearch)
        Me.Controls.Add(Me.tblPatientBillHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PatientBillForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Bill"
        Me.tblPatientBillHeader.ResumeLayout(False)
        Me.pnlPatientBillHeader.ResumeLayout(False)
        Me.pnlPatientBillHeader.PerformLayout()
        Me.gbPatientBillSearch.ResumeLayout(False)
        Me.gbPatientBillSearch.PerformLayout()
        Me.pnlBillPatineDetails.ResumeLayout(False)
        Me.pnlBillPatineDetails.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlCreadiPosition.ResumeLayout(False)
        Me.tabPatientBill.ResumeLayout(False)
        Me.tabPatientBillDetails.ResumeLayout(False)
        Me.tabPatientBillDetails.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dataGridPatientBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblPatientBillHeader As TableLayoutPanel
    Friend WithEvents pnlPatientBillHeader As Panel
    Friend WithEvents lblPatientBillHeader As Label
    Friend WithEvents lblPatientBillMode As Label
    Friend WithEvents gbPatientBillSearch As GroupBox
    Friend WithEvents lblBillFindByPatMobile As Label
    Friend WithEvents txtBillFindByMobile As TextBox
    Friend WithEvents btnFindBillByMobile As Button
    Friend WithEvents pnlBillPatineDetails As Panel
    Friend WithEvents lblPatName As Label
    Friend WithEvents lblBAddress As Label
    Friend WithEvents lblBMobile As Label
    Friend WithEvents lblBillPatFullName As Label
    Friend WithEvents lblBillPatAddress As Label
    Friend WithEvents lblBillPatMobile As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tabPatientBill As TabControl
    Friend WithEvents tabPatientBillDetails As TabPage
    Friend WithEvents lblTotalBillAmount As Label
    Friend WithEvents lblTotalBeforeDisc As Label
    Friend WithEvents lblTotalPayableAmount As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents dataGridPatientBill As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBillNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiscountByPercentage As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDiscountAmount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rbtnPaymentCash As RadioButton
    Friend WithEvents rbtnPaymentCheque As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBillRemarks As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGenerateBill As Button
    Friend WithEvents btnBillClear As Button
    Friend WithEvents btnBillClose As Button
    Friend WithEvents pnlCreadiPosition As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPatPaidAmount As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPatUnpaidAmount As Label
    Friend WithEvents btnSelectTranasction As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDiscountAmount As Label
    Friend WithEvents lblRemainingBalance As Label
    Friend WithEvents lblInvoiceDate As Label
    Friend WithEvents dtInvoiceDate As DateTimePicker
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
