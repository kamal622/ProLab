<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientTransactionsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientTransactionsForm))
        Me.tblTransactionHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlTransactionHeader = New System.Windows.Forms.Panel()
        Me.lblTransactionMode = New System.Windows.Forms.Label()
        Me.lblTranasctionHeader = New System.Windows.Forms.Label()
        Me.gbPatientDetails = New System.Windows.Forms.GroupBox()
        Me.pnlPatientDetails = New System.Windows.Forms.Panel()
        Me.lblPatientMobile = New System.Windows.Forms.Label()
        Me.lblMobileNo = New System.Windows.Forms.Label()
        Me.lblPatientAddress = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPatientFullName = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnFindPatientByMobile = New System.Windows.Forms.Button()
        Me.txtFindPatientByMobile = New System.Windows.Forms.TextBox()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlRefernceDoctor = New System.Windows.Forms.Panel()
        Me.lblHospitalName = New System.Windows.Forms.Label()
        Me.lblHname = New System.Windows.Forms.Label()
        Me.lblDoctorFullName = New System.Windows.Forms.Label()
        Me.lblDName = New System.Windows.Forms.Label()
        Me.btnFindDoctorByName = New System.Windows.Forms.Button()
        Me.txtFindDoctorByName = New System.Windows.Forms.TextBox()
        Me.lblDRName = New System.Windows.Forms.Label()
        Me.pnlTransaction = New System.Windows.Forms.Panel()
        Me.btnServiceClear = New System.Windows.Forms.Button()
        Me.btnServiceAdd = New System.Windows.Forms.Button()
        Me.txtServiceAmount = New System.Windows.Forms.TextBox()
        Me.txtServiceName = New System.Windows.Forms.TextBox()
        Me.txtServiceCategory = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlTreeView = New System.Windows.Forms.Panel()
        Me.treeViewServiceCategory = New System.Windows.Forms.TreeView()
        Me.dataGridPatientTransaction = New System.Windows.Forms.DataGridView()
        Me.ServiceTransaction_ServiceId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceTransaction_SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceTransaction_SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceTransaction_SAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceTransaction_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlAdvance = New System.Windows.Forms.Panel()
        Me.txtDepositeAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.pnlSample = New System.Windows.Forms.Panel()
        Me.txtTransactionRemarks = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTransactionSampleNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkSampleRecevied = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkSampleRequired = New System.Windows.Forms.CheckBox()
        Me.lblSampleRequired = New System.Windows.Forms.Label()
        Me.pnlTransactionsBtn = New System.Windows.Forms.Panel()
        Me.btnTransactionsClose = New System.Windows.Forms.Button()
        Me.btnTransactionClear = New System.Windows.Forms.Button()
        Me.btnTransactionSave = New System.Windows.Forms.Button()
        Me.tblTransactionHeader.SuspendLayout()
        Me.pnlTransactionHeader.SuspendLayout()
        Me.gbPatientDetails.SuspendLayout()
        Me.pnlPatientDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlRefernceDoctor.SuspendLayout()
        Me.pnlTransaction.SuspendLayout()
        Me.pnlTreeView.SuspendLayout()
        CType(Me.dataGridPatientTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAdvance.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlSample.SuspendLayout()
        Me.pnlTransactionsBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblTransactionHeader
        '
        Me.tblTransactionHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tblTransactionHeader.ColumnCount = 1
        Me.tblTransactionHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTransactionHeader.Controls.Add(Me.pnlTransactionHeader, 0, 0)
        Me.tblTransactionHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblTransactionHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblTransactionHeader.Name = "tblTransactionHeader"
        Me.tblTransactionHeader.RowCount = 1
        Me.tblTransactionHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTransactionHeader.Size = New System.Drawing.Size(725, 35)
        Me.tblTransactionHeader.TabIndex = 0
        '
        'pnlTransactionHeader
        '
        Me.pnlTransactionHeader.Controls.Add(Me.lblTransactionMode)
        Me.pnlTransactionHeader.Controls.Add(Me.lblTranasctionHeader)
        Me.pnlTransactionHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTransactionHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlTransactionHeader.Name = "pnlTransactionHeader"
        Me.pnlTransactionHeader.Size = New System.Drawing.Size(719, 29)
        Me.pnlTransactionHeader.TabIndex = 0
        '
        'lblTransactionMode
        '
        Me.lblTransactionMode.AutoSize = True
        Me.lblTransactionMode.BackColor = System.Drawing.Color.Maroon
        Me.lblTransactionMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTransactionMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionMode.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTransactionMode.Location = New System.Drawing.Point(639, 6)
        Me.lblTransactionMode.Name = "lblTransactionMode"
        Me.lblTransactionMode.Size = New System.Drawing.Size(74, 17)
        Me.lblTransactionMode.TabIndex = 1
        Me.lblTransactionMode.Text = "New Mode"
        '
        'lblTranasctionHeader
        '
        Me.lblTranasctionHeader.AutoSize = True
        Me.lblTranasctionHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTranasctionHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTranasctionHeader.Location = New System.Drawing.Point(9, 6)
        Me.lblTranasctionHeader.Name = "lblTranasctionHeader"
        Me.lblTranasctionHeader.Size = New System.Drawing.Size(150, 17)
        Me.lblTranasctionHeader.TabIndex = 0
        Me.lblTranasctionHeader.Text = "Patient Transaction"
        '
        'gbPatientDetails
        '
        Me.gbPatientDetails.BackColor = System.Drawing.Color.Transparent
        Me.gbPatientDetails.Controls.Add(Me.pnlPatientDetails)
        Me.gbPatientDetails.Controls.Add(Me.btnFindPatientByMobile)
        Me.gbPatientDetails.Controls.Add(Me.txtFindPatientByMobile)
        Me.gbPatientDetails.Controls.Add(Me.lblMobile)
        Me.gbPatientDetails.Location = New System.Drawing.Point(8, 43)
        Me.gbPatientDetails.Name = "gbPatientDetails"
        Me.gbPatientDetails.Size = New System.Drawing.Size(350, 143)
        Me.gbPatientDetails.TabIndex = 1
        Me.gbPatientDetails.TabStop = False
        Me.gbPatientDetails.Text = "Patient Details"
        '
        'pnlPatientDetails
        '
        Me.pnlPatientDetails.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlPatientDetails.Controls.Add(Me.lblPatientMobile)
        Me.pnlPatientDetails.Controls.Add(Me.lblMobileNo)
        Me.pnlPatientDetails.Controls.Add(Me.lblPatientAddress)
        Me.pnlPatientDetails.Controls.Add(Me.lblAddress)
        Me.pnlPatientDetails.Controls.Add(Me.lblPatientFullName)
        Me.pnlPatientDetails.Controls.Add(Me.lblName)
        Me.pnlPatientDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlPatientDetails.ForeColor = System.Drawing.Color.DarkBlue
        Me.pnlPatientDetails.Location = New System.Drawing.Point(7, 49)
        Me.pnlPatientDetails.Name = "pnlPatientDetails"
        Me.pnlPatientDetails.Size = New System.Drawing.Size(337, 85)
        Me.pnlPatientDetails.TabIndex = 3
        '
        'lblPatientMobile
        '
        Me.lblPatientMobile.AutoSize = True
        Me.lblPatientMobile.Location = New System.Drawing.Point(84, 56)
        Me.lblPatientMobile.Name = "lblPatientMobile"
        Me.lblPatientMobile.Size = New System.Drawing.Size(0, 13)
        Me.lblPatientMobile.TabIndex = 5
        '
        'lblMobileNo
        '
        Me.lblMobileNo.AutoSize = True
        Me.lblMobileNo.Location = New System.Drawing.Point(9, 56)
        Me.lblMobileNo.Name = "lblMobileNo"
        Me.lblMobileNo.Size = New System.Drawing.Size(44, 13)
        Me.lblMobileNo.TabIndex = 4
        Me.lblMobileNo.Text = "Mobile"
        '
        'lblPatientAddress
        '
        Me.lblPatientAddress.AutoSize = True
        Me.lblPatientAddress.Location = New System.Drawing.Point(84, 37)
        Me.lblPatientAddress.Name = "lblPatientAddress"
        Me.lblPatientAddress.Size = New System.Drawing.Size(0, 13)
        Me.lblPatientAddress.TabIndex = 3
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(9, 37)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(52, 13)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address"
        '
        'lblPatientFullName
        '
        Me.lblPatientFullName.AutoSize = True
        Me.lblPatientFullName.Location = New System.Drawing.Point(84, 14)
        Me.lblPatientFullName.Name = "lblPatientFullName"
        Me.lblPatientFullName.Size = New System.Drawing.Size(0, 13)
        Me.lblPatientFullName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(9, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(39, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'btnFindPatientByMobile
        '
        Me.btnFindPatientByMobile.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnFindPatientByMobile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindPatientByMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindPatientByMobile.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFindPatientByMobile.Location = New System.Drawing.Point(292, 26)
        Me.btnFindPatientByMobile.Name = "btnFindPatientByMobile"
        Me.btnFindPatientByMobile.Size = New System.Drawing.Size(30, 20)
        Me.btnFindPatientByMobile.TabIndex = 2
        Me.btnFindPatientByMobile.Text = "F2"
        Me.btnFindPatientByMobile.UseVisualStyleBackColor = True
        '
        'txtFindPatientByMobile
        '
        Me.txtFindPatientByMobile.Location = New System.Drawing.Point(54, 26)
        Me.txtFindPatientByMobile.Name = "txtFindPatientByMobile"
        Me.txtFindPatientByMobile.Size = New System.Drawing.Size(223, 20)
        Me.txtFindPatientByMobile.TabIndex = 1
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(9, 26)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(38, 13)
        Me.lblMobile.TabIndex = 0
        Me.lblMobile.Text = "Mobile"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.pnlRefernceDoctor)
        Me.GroupBox1.Controls.Add(Me.btnFindDoctorByName)
        Me.GroupBox1.Controls.Add(Me.txtFindDoctorByName)
        Me.GroupBox1.Controls.Add(Me.lblDRName)
        Me.GroupBox1.Location = New System.Drawing.Point(366, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 143)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Refernce Doctor"
        '
        'pnlRefernceDoctor
        '
        Me.pnlRefernceDoctor.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlRefernceDoctor.Controls.Add(Me.lblHospitalName)
        Me.pnlRefernceDoctor.Controls.Add(Me.lblHname)
        Me.pnlRefernceDoctor.Controls.Add(Me.lblDoctorFullName)
        Me.pnlRefernceDoctor.Controls.Add(Me.lblDName)
        Me.pnlRefernceDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlRefernceDoctor.ForeColor = System.Drawing.Color.DarkBlue
        Me.pnlRefernceDoctor.Location = New System.Drawing.Point(7, 49)
        Me.pnlRefernceDoctor.Name = "pnlRefernceDoctor"
        Me.pnlRefernceDoctor.Size = New System.Drawing.Size(337, 85)
        Me.pnlRefernceDoctor.TabIndex = 3
        '
        'lblHospitalName
        '
        Me.lblHospitalName.AutoSize = True
        Me.lblHospitalName.Location = New System.Drawing.Point(109, 37)
        Me.lblHospitalName.Name = "lblHospitalName"
        Me.lblHospitalName.Size = New System.Drawing.Size(0, 13)
        Me.lblHospitalName.TabIndex = 3
        '
        'lblHname
        '
        Me.lblHname.AutoSize = True
        Me.lblHname.Location = New System.Drawing.Point(13, 37)
        Me.lblHname.Name = "lblHname"
        Me.lblHname.Size = New System.Drawing.Size(89, 13)
        Me.lblHname.TabIndex = 2
        Me.lblHname.Text = "Hospital Name"
        '
        'lblDoctorFullName
        '
        Me.lblDoctorFullName.AutoSize = True
        Me.lblDoctorFullName.Location = New System.Drawing.Point(109, 13)
        Me.lblDoctorFullName.Name = "lblDoctorFullName"
        Me.lblDoctorFullName.Size = New System.Drawing.Size(0, 13)
        Me.lblDoctorFullName.TabIndex = 1
        '
        'lblDName
        '
        Me.lblDName.AutoSize = True
        Me.lblDName.Location = New System.Drawing.Point(13, 13)
        Me.lblDName.Name = "lblDName"
        Me.lblDName.Size = New System.Drawing.Size(39, 13)
        Me.lblDName.TabIndex = 0
        Me.lblDName.Text = "Name"
        '
        'btnFindDoctorByName
        '
        Me.btnFindDoctorByName.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnFindDoctorByName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindDoctorByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindDoctorByName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFindDoctorByName.Location = New System.Drawing.Point(297, 24)
        Me.btnFindDoctorByName.Name = "btnFindDoctorByName"
        Me.btnFindDoctorByName.Size = New System.Drawing.Size(30, 20)
        Me.btnFindDoctorByName.TabIndex = 2
        Me.btnFindDoctorByName.Text = "F2"
        Me.btnFindDoctorByName.UseVisualStyleBackColor = True
        '
        'txtFindDoctorByName
        '
        Me.txtFindDoctorByName.Location = New System.Drawing.Point(67, 24)
        Me.txtFindDoctorByName.Name = "txtFindDoctorByName"
        Me.txtFindDoctorByName.Size = New System.Drawing.Size(213, 20)
        Me.txtFindDoctorByName.TabIndex = 1
        '
        'lblDRName
        '
        Me.lblDRName.AutoSize = True
        Me.lblDRName.Location = New System.Drawing.Point(4, 27)
        Me.lblDRName.Name = "lblDRName"
        Me.lblDRName.Size = New System.Drawing.Size(35, 13)
        Me.lblDRName.TabIndex = 0
        Me.lblDRName.Text = "Name"
        '
        'pnlTransaction
        '
        Me.pnlTransaction.BackColor = System.Drawing.Color.Transparent
        Me.pnlTransaction.Controls.Add(Me.btnServiceClear)
        Me.pnlTransaction.Controls.Add(Me.btnServiceAdd)
        Me.pnlTransaction.Controls.Add(Me.txtServiceAmount)
        Me.pnlTransaction.Controls.Add(Me.txtServiceName)
        Me.pnlTransaction.Controls.Add(Me.txtServiceCategory)
        Me.pnlTransaction.Controls.Add(Me.Label3)
        Me.pnlTransaction.Location = New System.Drawing.Point(8, 192)
        Me.pnlTransaction.Name = "pnlTransaction"
        Me.pnlTransaction.Size = New System.Drawing.Size(708, 30)
        Me.pnlTransaction.TabIndex = 4
        '
        'btnServiceClear
        '
        Me.btnServiceClear.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnServiceClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnServiceClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnServiceClear.Location = New System.Drawing.Point(652, 5)
        Me.btnServiceClear.Name = "btnServiceClear"
        Me.btnServiceClear.Size = New System.Drawing.Size(50, 20)
        Me.btnServiceClear.TabIndex = 6
        Me.btnServiceClear.Text = "Clear"
        Me.btnServiceClear.UseVisualStyleBackColor = True
        '
        'btnServiceAdd
        '
        Me.btnServiceAdd.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnServiceAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnServiceAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceAdd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnServiceAdd.Location = New System.Drawing.Point(599, 5)
        Me.btnServiceAdd.Name = "btnServiceAdd"
        Me.btnServiceAdd.Size = New System.Drawing.Size(50, 20)
        Me.btnServiceAdd.TabIndex = 5
        Me.btnServiceAdd.Text = "Add"
        Me.btnServiceAdd.UseVisualStyleBackColor = True
        '
        'txtServiceAmount
        '
        Me.txtServiceAmount.Location = New System.Drawing.Point(487, 5)
        Me.txtServiceAmount.Name = "txtServiceAmount"
        Me.txtServiceAmount.Size = New System.Drawing.Size(108, 20)
        Me.txtServiceAmount.TabIndex = 4
        '
        'txtServiceName
        '
        Me.txtServiceName.Location = New System.Drawing.Point(300, 5)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.Size = New System.Drawing.Size(180, 20)
        Me.txtServiceName.TabIndex = 3
        '
        'txtServiceCategory
        '
        Me.txtServiceCategory.Location = New System.Drawing.Point(112, 5)
        Me.txtServiceCategory.Name = "txtServiceCategory"
        Me.txtServiceCategory.Size = New System.Drawing.Size(180, 20)
        Me.txtServiceCategory.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Service Details"
        '
        'pnlTreeView
        '
        Me.pnlTreeView.BackColor = System.Drawing.Color.Transparent
        Me.pnlTreeView.Controls.Add(Me.treeViewServiceCategory)
        Me.pnlTreeView.Location = New System.Drawing.Point(8, 227)
        Me.pnlTreeView.Name = "pnlTreeView"
        Me.pnlTreeView.Size = New System.Drawing.Size(169, 314)
        Me.pnlTreeView.TabIndex = 6
        '
        'treeViewServiceCategory
        '
        Me.treeViewServiceCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeViewServiceCategory.Location = New System.Drawing.Point(0, 0)
        Me.treeViewServiceCategory.Name = "treeViewServiceCategory"
        Me.treeViewServiceCategory.Size = New System.Drawing.Size(169, 314)
        Me.treeViewServiceCategory.TabIndex = 0
        '
        'dataGridPatientTransaction
        '
        Me.dataGridPatientTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridPatientTransaction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceTransaction_ServiceId, Me.ServiceTransaction_SCategory, Me.ServiceTransaction_SName, Me.ServiceTransaction_SAmount, Me.ServiceTransaction_Id})
        Me.dataGridPatientTransaction.Location = New System.Drawing.Point(181, 229)
        Me.dataGridPatientTransaction.Name = "dataGridPatientTransaction"
        Me.dataGridPatientTransaction.Size = New System.Drawing.Size(535, 150)
        Me.dataGridPatientTransaction.TabIndex = 7
        '
        'ServiceTransaction_ServiceId
        '
        Me.ServiceTransaction_ServiceId.DataPropertyName = "ServiceTransaction_ServiceId"
        Me.ServiceTransaction_ServiceId.HeaderText = "Service Id"
        Me.ServiceTransaction_ServiceId.Name = "ServiceTransaction_ServiceId"
        Me.ServiceTransaction_ServiceId.Visible = False
        '
        'ServiceTransaction_SCategory
        '
        Me.ServiceTransaction_SCategory.DataPropertyName = "ServiceTransaction_SCategory"
        Me.ServiceTransaction_SCategory.HeaderText = "Category"
        Me.ServiceTransaction_SCategory.Name = "ServiceTransaction_SCategory"
        '
        'ServiceTransaction_SName
        '
        Me.ServiceTransaction_SName.DataPropertyName = "ServiceTransaction_SName"
        Me.ServiceTransaction_SName.HeaderText = "Service Name"
        Me.ServiceTransaction_SName.Name = "ServiceTransaction_SName"
        '
        'ServiceTransaction_SAmount
        '
        Me.ServiceTransaction_SAmount.DataPropertyName = "ServiceTransaction_SAmount"
        Me.ServiceTransaction_SAmount.HeaderText = "Amount"
        Me.ServiceTransaction_SAmount.Name = "ServiceTransaction_SAmount"
        '
        'ServiceTransaction_Id
        '
        Me.ServiceTransaction_Id.DataPropertyName = "ServiceTransaction_Id"
        Me.ServiceTransaction_Id.HeaderText = "TransactionId"
        Me.ServiceTransaction_Id.Name = "ServiceTransaction_Id"
        Me.ServiceTransaction_Id.Visible = False
        '
        'pnlAdvance
        '
        Me.pnlAdvance.BackColor = System.Drawing.Color.Transparent
        Me.pnlAdvance.Controls.Add(Me.txtDepositeAmount)
        Me.pnlAdvance.Controls.Add(Me.Label4)
        Me.pnlAdvance.Location = New System.Drawing.Point(181, 384)
        Me.pnlAdvance.Name = "pnlAdvance"
        Me.pnlAdvance.Size = New System.Drawing.Size(214, 30)
        Me.pnlAdvance.TabIndex = 8
        '
        'txtDepositeAmount
        '
        Me.txtDepositeAmount.Location = New System.Drawing.Point(108, 5)
        Me.txtDepositeAmount.Name = "txtDepositeAmount"
        Me.txtDepositeAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtDepositeAmount.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Advance Payment"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblTotalAmount)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Location = New System.Drawing.Point(516, 384)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 30)
        Me.Panel1.TabIndex = 9
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Location = New System.Drawing.Point(144, 8)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblTotalAmount.TabIndex = 1
        Me.lblTotalAmount.Text = "0000.00"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(3, 8)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(70, 13)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total Amount"
        '
        'pnlSample
        '
        Me.pnlSample.BackColor = System.Drawing.Color.Transparent
        Me.pnlSample.Controls.Add(Me.txtTransactionRemarks)
        Me.pnlSample.Controls.Add(Me.Label6)
        Me.pnlSample.Controls.Add(Me.txtTransactionSampleNo)
        Me.pnlSample.Controls.Add(Me.Label5)
        Me.pnlSample.Controls.Add(Me.chkSampleRecevied)
        Me.pnlSample.Controls.Add(Me.Label2)
        Me.pnlSample.Controls.Add(Me.chkSampleRequired)
        Me.pnlSample.Controls.Add(Me.lblSampleRequired)
        Me.pnlSample.Location = New System.Drawing.Point(181, 420)
        Me.pnlSample.Name = "pnlSample"
        Me.pnlSample.Size = New System.Drawing.Size(535, 80)
        Me.pnlSample.TabIndex = 10
        '
        'txtTransactionRemarks
        '
        Me.txtTransactionRemarks.Location = New System.Drawing.Point(108, 34)
        Me.txtTransactionRemarks.Multiline = True
        Me.txtTransactionRemarks.Name = "txtTransactionRemarks"
        Me.txtTransactionRemarks.Size = New System.Drawing.Size(421, 43)
        Me.txtTransactionRemarks.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Remarks"
        '
        'txtTransactionSampleNo
        '
        Me.txtTransactionSampleNo.Location = New System.Drawing.Point(429, 5)
        Me.txtTransactionSampleNo.Name = "txtTransactionSampleNo"
        Me.txtTransactionSampleNo.Size = New System.Drawing.Size(100, 20)
        Me.txtTransactionSampleNo.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(338, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sample No#"
        '
        'chkSampleRecevied
        '
        Me.chkSampleRecevied.AutoSize = True
        Me.chkSampleRecevied.Location = New System.Drawing.Point(269, 8)
        Me.chkSampleRecevied.Name = "chkSampleRecevied"
        Me.chkSampleRecevied.Size = New System.Drawing.Size(15, 14)
        Me.chkSampleRecevied.TabIndex = 3
        Me.chkSampleRecevied.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sample Recevied"
        '
        'chkSampleRequired
        '
        Me.chkSampleRequired.AutoSize = True
        Me.chkSampleRequired.Location = New System.Drawing.Point(108, 8)
        Me.chkSampleRequired.Name = "chkSampleRequired"
        Me.chkSampleRequired.Size = New System.Drawing.Size(15, 14)
        Me.chkSampleRequired.TabIndex = 1
        Me.chkSampleRequired.UseVisualStyleBackColor = True
        '
        'lblSampleRequired
        '
        Me.lblSampleRequired.AutoSize = True
        Me.lblSampleRequired.Location = New System.Drawing.Point(8, 9)
        Me.lblSampleRequired.Name = "lblSampleRequired"
        Me.lblSampleRequired.Size = New System.Drawing.Size(88, 13)
        Me.lblSampleRequired.TabIndex = 0
        Me.lblSampleRequired.Text = "Sample Required"
        '
        'pnlTransactionsBtn
        '
        Me.pnlTransactionsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.pnlTransactionsBtn.Controls.Add(Me.btnTransactionsClose)
        Me.pnlTransactionsBtn.Controls.Add(Me.btnTransactionClear)
        Me.pnlTransactionsBtn.Controls.Add(Me.btnTransactionSave)
        Me.pnlTransactionsBtn.Location = New System.Drawing.Point(540, 506)
        Me.pnlTransactionsBtn.Name = "pnlTransactionsBtn"
        Me.pnlTransactionsBtn.Size = New System.Drawing.Size(176, 35)
        Me.pnlTransactionsBtn.TabIndex = 11
        '
        'btnTransactionsClose
        '
        Me.btnTransactionsClose.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnTransactionsClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactionsClose.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTransactionsClose.Location = New System.Drawing.Point(116, 3)
        Me.btnTransactionsClose.Name = "btnTransactionsClose"
        Me.btnTransactionsClose.Size = New System.Drawing.Size(56, 30)
        Me.btnTransactionsClose.TabIndex = 3
        Me.btnTransactionsClose.Text = "&Close"
        Me.btnTransactionsClose.UseVisualStyleBackColor = True
        '
        'btnTransactionClear
        '
        Me.btnTransactionClear.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnTransactionClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactionClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTransactionClear.Location = New System.Drawing.Point(60, 4)
        Me.btnTransactionClear.Name = "btnTransactionClear"
        Me.btnTransactionClear.Size = New System.Drawing.Size(56, 30)
        Me.btnTransactionClear.TabIndex = 2
        Me.btnTransactionClear.Text = "C&lear"
        Me.btnTransactionClear.UseVisualStyleBackColor = True
        '
        'btnTransactionSave
        '
        Me.btnTransactionSave.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnTransactionSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactionSave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTransactionSave.Location = New System.Drawing.Point(3, 3)
        Me.btnTransactionSave.Name = "btnTransactionSave"
        Me.btnTransactionSave.Size = New System.Drawing.Size(56, 30)
        Me.btnTransactionSave.TabIndex = 0
        Me.btnTransactionSave.Text = "&Save"
        Me.btnTransactionSave.UseVisualStyleBackColor = True
        '
        'PatientTransactionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(725, 545)
        Me.Controls.Add(Me.pnlTransactionsBtn)
        Me.Controls.Add(Me.pnlSample)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlAdvance)
        Me.Controls.Add(Me.dataGridPatientTransaction)
        Me.Controls.Add(Me.pnlTreeView)
        Me.Controls.Add(Me.pnlTransaction)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbPatientDetails)
        Me.Controls.Add(Me.tblTransactionHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PatientTransactionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Transactions"
        Me.tblTransactionHeader.ResumeLayout(False)
        Me.pnlTransactionHeader.ResumeLayout(False)
        Me.pnlTransactionHeader.PerformLayout()
        Me.gbPatientDetails.ResumeLayout(False)
        Me.gbPatientDetails.PerformLayout()
        Me.pnlPatientDetails.ResumeLayout(False)
        Me.pnlPatientDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlRefernceDoctor.ResumeLayout(False)
        Me.pnlRefernceDoctor.PerformLayout()
        Me.pnlTransaction.ResumeLayout(False)
        Me.pnlTransaction.PerformLayout()
        Me.pnlTreeView.ResumeLayout(False)
        CType(Me.dataGridPatientTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAdvance.ResumeLayout(False)
        Me.pnlAdvance.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlSample.ResumeLayout(False)
        Me.pnlSample.PerformLayout()
        Me.pnlTransactionsBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblTransactionHeader As TableLayoutPanel
    Friend WithEvents pnlTransactionHeader As Panel
    Friend WithEvents lblTranasctionHeader As Label
    Friend WithEvents lblTransactionMode As Label
    Friend WithEvents gbPatientDetails As GroupBox
    Friend WithEvents lblMobile As Label
    Friend WithEvents txtFindPatientByMobile As TextBox
    Friend WithEvents btnFindPatientByMobile As Button
    Friend WithEvents pnlPatientDetails As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents lblPatientFullName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblPatientAddress As Label
    Friend WithEvents lblMobileNo As Label
    Friend WithEvents lblPatientMobile As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDRName As Label
    Friend WithEvents txtFindDoctorByName As TextBox
    Friend WithEvents btnFindDoctorByName As Button
    Friend WithEvents pnlRefernceDoctor As Panel
    Friend WithEvents lblDName As Label
    Friend WithEvents lblDoctorFullName As Label
    Friend WithEvents lblHname As Label
    Friend WithEvents lblHospitalName As Label
    Friend WithEvents pnlTransaction As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtServiceCategory As TextBox
    Friend WithEvents txtServiceName As TextBox
    Friend WithEvents txtServiceAmount As TextBox
    Friend WithEvents btnServiceAdd As Button
    Friend WithEvents btnServiceClear As Button
    Friend WithEvents pnlTreeView As Panel
    Friend WithEvents treeViewServiceCategory As TreeView
    Friend WithEvents dataGridPatientTransaction As DataGridView
    Friend WithEvents pnlAdvance As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDepositeAmount As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents ServiceTransaction_ServiceId As DataGridViewTextBoxColumn
    Friend WithEvents ServiceTransaction_SCategory As DataGridViewTextBoxColumn
    Friend WithEvents ServiceTransaction_SName As DataGridViewTextBoxColumn
    Friend WithEvents ServiceTransaction_SAmount As DataGridViewTextBoxColumn
    Friend WithEvents ServiceTransaction_Id As DataGridViewTextBoxColumn
    Friend WithEvents pnlSample As Panel
    Friend WithEvents lblSampleRequired As Label
    Friend WithEvents chkSampleRequired As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkSampleRecevied As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTransactionSampleNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTransactionRemarks As TextBox
    Friend WithEvents pnlTransactionsBtn As Panel
    Friend WithEvents btnTransactionSave As Button
    Friend WithEvents btnTransactionClear As Button
    Friend WithEvents btnTransactionsClose As Button
End Class
