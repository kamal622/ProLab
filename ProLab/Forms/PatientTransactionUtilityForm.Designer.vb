<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientTransactionUtilityForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientTransactionUtilityForm))
        Me.tblTransactionUtlityHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.pnluHeader = New System.Windows.Forms.Panel()
        Me.lblTransactionUtilityMode = New System.Windows.Forms.Label()
        Me.lblTransactionUHeader = New System.Windows.Forms.Label()
        Me.gbTransactionUtilityHeader = New System.Windows.Forms.GroupBox()
        Me.btnSearchTransactions = New System.Windows.Forms.Button()
        Me.txtSearchMobile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFindPatient = New System.Windows.Forms.Button()
        Me.txtSearchName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dataGridPatientTransactions = New System.Windows.Forms.DataGridView()
        Me.pnlTransactionUtilityBtn = New System.Windows.Forms.Panel()
        Me.btnTransactionUClose = New System.Windows.Forms.Button()
        Me.btnTransactionUClear = New System.Windows.Forms.Button()
        Me.tblTransactionUtlityHeader.SuspendLayout()
        Me.pnluHeader.SuspendLayout()
        Me.gbTransactionUtilityHeader.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataGridPatientTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTransactionUtilityBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblTransactionUtlityHeader
        '
        Me.tblTransactionUtlityHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tblTransactionUtlityHeader.ColumnCount = 1
        Me.tblTransactionUtlityHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTransactionUtlityHeader.Controls.Add(Me.pnluHeader, 0, 0)
        Me.tblTransactionUtlityHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblTransactionUtlityHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblTransactionUtlityHeader.Name = "tblTransactionUtlityHeader"
        Me.tblTransactionUtlityHeader.RowCount = 1
        Me.tblTransactionUtlityHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTransactionUtlityHeader.Size = New System.Drawing.Size(781, 40)
        Me.tblTransactionUtlityHeader.TabIndex = 0
        '
        'pnluHeader
        '
        Me.pnluHeader.Controls.Add(Me.lblTransactionUtilityMode)
        Me.pnluHeader.Controls.Add(Me.lblTransactionUHeader)
        Me.pnluHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnluHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnluHeader.Name = "pnluHeader"
        Me.pnluHeader.Size = New System.Drawing.Size(775, 34)
        Me.pnluHeader.TabIndex = 0
        '
        'lblTransactionUtilityMode
        '
        Me.lblTransactionUtilityMode.AutoSize = True
        Me.lblTransactionUtilityMode.BackColor = System.Drawing.Color.Maroon
        Me.lblTransactionUtilityMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTransactionUtilityMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionUtilityMode.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTransactionUtilityMode.Location = New System.Drawing.Point(696, 8)
        Me.lblTransactionUtilityMode.Name = "lblTransactionUtilityMode"
        Me.lblTransactionUtilityMode.Size = New System.Drawing.Size(74, 17)
        Me.lblTransactionUtilityMode.TabIndex = 1
        Me.lblTransactionUtilityMode.Text = "New Mode"
        '
        'lblTransactionUHeader
        '
        Me.lblTransactionUHeader.AutoSize = True
        Me.lblTransactionUHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionUHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTransactionUHeader.Location = New System.Drawing.Point(4, 8)
        Me.lblTransactionUHeader.Name = "lblTransactionUHeader"
        Me.lblTransactionUHeader.Size = New System.Drawing.Size(140, 17)
        Me.lblTransactionUHeader.TabIndex = 0
        Me.lblTransactionUHeader.Text = "Transaction Utility"
        '
        'gbTransactionUtilityHeader
        '
        Me.gbTransactionUtilityHeader.BackColor = System.Drawing.Color.Transparent
        Me.gbTransactionUtilityHeader.Controls.Add(Me.btnSearchTransactions)
        Me.gbTransactionUtilityHeader.Controls.Add(Me.txtSearchMobile)
        Me.gbTransactionUtilityHeader.Controls.Add(Me.Label2)
        Me.gbTransactionUtilityHeader.Controls.Add(Me.btnFindPatient)
        Me.gbTransactionUtilityHeader.Controls.Add(Me.txtSearchName)
        Me.gbTransactionUtilityHeader.Controls.Add(Me.lblName)
        Me.gbTransactionUtilityHeader.Location = New System.Drawing.Point(10, 46)
        Me.gbTransactionUtilityHeader.Name = "gbTransactionUtilityHeader"
        Me.gbTransactionUtilityHeader.Size = New System.Drawing.Size(763, 53)
        Me.gbTransactionUtilityHeader.TabIndex = 1
        Me.gbTransactionUtilityHeader.TabStop = False
        Me.gbTransactionUtilityHeader.Text = "Search"
        '
        'btnSearchTransactions
        '
        Me.btnSearchTransactions.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnSearchTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchTransactions.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSearchTransactions.Location = New System.Drawing.Point(679, 18)
        Me.btnSearchTransactions.Name = "btnSearchTransactions"
        Me.btnSearchTransactions.Size = New System.Drawing.Size(75, 20)
        Me.btnSearchTransactions.TabIndex = 7
        Me.btnSearchTransactions.Text = "Search"
        Me.btnSearchTransactions.UseVisualStyleBackColor = True
        '
        'txtSearchMobile
        '
        Me.txtSearchMobile.Location = New System.Drawing.Point(411, 18)
        Me.txtSearchMobile.Name = "txtSearchMobile"
        Me.txtSearchMobile.ReadOnly = True
        Me.txtSearchMobile.Size = New System.Drawing.Size(252, 20)
        Me.txtSearchMobile.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(361, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mobile"
        '
        'btnFindPatient
        '
        Me.btnFindPatient.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnFindPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindPatient.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFindPatient.Location = New System.Drawing.Point(309, 18)
        Me.btnFindPatient.Name = "btnFindPatient"
        Me.btnFindPatient.Size = New System.Drawing.Size(30, 20)
        Me.btnFindPatient.TabIndex = 2
        Me.btnFindPatient.Text = "F2"
        Me.btnFindPatient.UseVisualStyleBackColor = True
        '
        'txtSearchName
        '
        Me.txtSearchName.Location = New System.Drawing.Point(47, 18)
        Me.txtSearchName.Name = "txtSearchName"
        Me.txtSearchName.Size = New System.Drawing.Size(249, 20)
        Me.txtSearchName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(6, 18)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dataGridPatientTransactions)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 186)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transactions"
        '
        'dataGridPatientTransactions
        '
        Me.dataGridPatientTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridPatientTransactions.Location = New System.Drawing.Point(9, 19)
        Me.dataGridPatientTransactions.Name = "dataGridPatientTransactions"
        Me.dataGridPatientTransactions.Size = New System.Drawing.Size(745, 160)
        Me.dataGridPatientTransactions.TabIndex = 0
        '
        'pnlTransactionUtilityBtn
        '
        Me.pnlTransactionUtilityBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.pnlTransactionUtilityBtn.Controls.Add(Me.btnTransactionUClose)
        Me.pnlTransactionUtilityBtn.Controls.Add(Me.btnTransactionUClear)
        Me.pnlTransactionUtilityBtn.Location = New System.Drawing.Point(655, 327)
        Me.pnlTransactionUtilityBtn.Name = "pnlTransactionUtilityBtn"
        Me.pnlTransactionUtilityBtn.Size = New System.Drawing.Size(118, 35)
        Me.pnlTransactionUtilityBtn.TabIndex = 3
        '
        'btnTransactionUClose
        '
        Me.btnTransactionUClose.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnTransactionUClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactionUClose.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTransactionUClose.Location = New System.Drawing.Point(59, 3)
        Me.btnTransactionUClose.Name = "btnTransactionUClose"
        Me.btnTransactionUClose.Size = New System.Drawing.Size(56, 30)
        Me.btnTransactionUClose.TabIndex = 1
        Me.btnTransactionUClose.Text = "&Close"
        Me.btnTransactionUClose.UseVisualStyleBackColor = True
        '
        'btnTransactionUClear
        '
        Me.btnTransactionUClear.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnTransactionUClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactionUClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTransactionUClear.Location = New System.Drawing.Point(3, 3)
        Me.btnTransactionUClear.Name = "btnTransactionUClear"
        Me.btnTransactionUClear.Size = New System.Drawing.Size(56, 30)
        Me.btnTransactionUClear.TabIndex = 0
        Me.btnTransactionUClear.Text = "C&lear"
        Me.btnTransactionUClear.UseVisualStyleBackColor = True
        '
        'PatientTransactionUtilityForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(781, 367)
        Me.Controls.Add(Me.pnlTransactionUtilityBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbTransactionUtilityHeader)
        Me.Controls.Add(Me.tblTransactionUtlityHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PatientTransactionUtilityForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Transaction Utility"
        Me.tblTransactionUtlityHeader.ResumeLayout(False)
        Me.pnluHeader.ResumeLayout(False)
        Me.pnluHeader.PerformLayout()
        Me.gbTransactionUtilityHeader.ResumeLayout(False)
        Me.gbTransactionUtilityHeader.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dataGridPatientTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTransactionUtilityBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblTransactionUtlityHeader As TableLayoutPanel
    Friend WithEvents pnluHeader As Panel
    Friend WithEvents lblTransactionUHeader As Label
    Friend WithEvents lblTransactionUtilityMode As Label
    Friend WithEvents gbTransactionUtilityHeader As GroupBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtSearchName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFindTransactionByMobile As TextBox
    Friend WithEvents dtTransactionDate As DateTimePicker
    Friend WithEvents btnSearchPatientTransactions As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dataGridViewTransactionUtility As DataGridView
    Friend WithEvents pnlTUtilityBtn As Panel
    Friend WithEvents btnTUtilityClear As Button
    Friend WithEvents btnTUtilityClose As Button
    Friend WithEvents btnFindPatient As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearchMobile As TextBox
    Friend WithEvents btnSearchTransactions As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dataGridPatientTransactions As DataGridView
    Friend WithEvents pnlTransactionUtilityBtn As Panel
    Friend WithEvents btnTransactionUClear As Button
    Friend WithEvents btnTransactionUClose As Button
End Class
