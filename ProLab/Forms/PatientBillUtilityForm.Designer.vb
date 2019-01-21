<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientBillUtilityForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientBillUtilityForm))
        Me.tblBillUtilityHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlBillUtilityHeader = New System.Windows.Forms.Panel()
        Me.lnlBillUtilityHeader = New System.Windows.Forms.Label()
        Me.gbPatientBillSearch = New System.Windows.Forms.GroupBox()
        Me.btnFindPatientBills = New System.Windows.Forms.Button()
        Me.txtSearchMobile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFindPatientByName = New System.Windows.Forms.Button()
        Me.txtSearchName = New System.Windows.Forms.TextBox()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.gbBills = New System.Windows.Forms.GroupBox()
        Me.dataGridViewPatinetBills = New System.Windows.Forms.DataGridView()
        Me.pnlBillUtilityBtn = New System.Windows.Forms.Panel()
        Me.btnBillUtilityClose = New System.Windows.Forms.Button()
        Me.btnBillUtilityClear = New System.Windows.Forms.Button()
        Me.tblBillUtilityHeader.SuspendLayout()
        Me.pnlBillUtilityHeader.SuspendLayout()
        Me.gbPatientBillSearch.SuspendLayout()
        Me.gbBills.SuspendLayout()
        CType(Me.dataGridViewPatinetBills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBillUtilityBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblBillUtilityHeader
        '
        Me.tblBillUtilityHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tblBillUtilityHeader.ColumnCount = 1
        Me.tblBillUtilityHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblBillUtilityHeader.Controls.Add(Me.pnlBillUtilityHeader, 0, 0)
        Me.tblBillUtilityHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblBillUtilityHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblBillUtilityHeader.Name = "tblBillUtilityHeader"
        Me.tblBillUtilityHeader.RowCount = 1
        Me.tblBillUtilityHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblBillUtilityHeader.Size = New System.Drawing.Size(571, 40)
        Me.tblBillUtilityHeader.TabIndex = 0
        '
        'pnlBillUtilityHeader
        '
        Me.pnlBillUtilityHeader.Controls.Add(Me.lnlBillUtilityHeader)
        Me.pnlBillUtilityHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBillUtilityHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlBillUtilityHeader.Name = "pnlBillUtilityHeader"
        Me.pnlBillUtilityHeader.Size = New System.Drawing.Size(565, 34)
        Me.pnlBillUtilityHeader.TabIndex = 0
        '
        'lnlBillUtilityHeader
        '
        Me.lnlBillUtilityHeader.AutoSize = True
        Me.lnlBillUtilityHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlBillUtilityHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lnlBillUtilityHeader.Location = New System.Drawing.Point(1, 8)
        Me.lnlBillUtilityHeader.Name = "lnlBillUtilityHeader"
        Me.lnlBillUtilityHeader.Size = New System.Drawing.Size(76, 17)
        Me.lnlBillUtilityHeader.TabIndex = 0
        Me.lnlBillUtilityHeader.Text = "Bill Utility"
        '
        'gbPatientBillSearch
        '
        Me.gbPatientBillSearch.BackColor = System.Drawing.Color.Transparent
        Me.gbPatientBillSearch.Controls.Add(Me.btnFindPatientBills)
        Me.gbPatientBillSearch.Controls.Add(Me.txtSearchMobile)
        Me.gbPatientBillSearch.Controls.Add(Me.Label1)
        Me.gbPatientBillSearch.Controls.Add(Me.btnFindPatientByName)
        Me.gbPatientBillSearch.Controls.Add(Me.txtSearchName)
        Me.gbPatientBillSearch.Controls.Add(Me.lblPatientName)
        Me.gbPatientBillSearch.Location = New System.Drawing.Point(7, 48)
        Me.gbPatientBillSearch.Name = "gbPatientBillSearch"
        Me.gbPatientBillSearch.Size = New System.Drawing.Size(557, 58)
        Me.gbPatientBillSearch.TabIndex = 1
        Me.gbPatientBillSearch.TabStop = False
        Me.gbPatientBillSearch.Text = "Search"
        '
        'btnFindPatientBills
        '
        Me.btnFindPatientBills.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnFindPatientBills.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindPatientBills.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindPatientBills.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFindPatientBills.Location = New System.Drawing.Point(478, 22)
        Me.btnFindPatientBills.Name = "btnFindPatientBills"
        Me.btnFindPatientBills.Size = New System.Drawing.Size(72, 20)
        Me.btnFindPatientBills.TabIndex = 5
        Me.btnFindPatientBills.Text = "Search"
        Me.btnFindPatientBills.UseVisualStyleBackColor = True
        '
        'txtSearchMobile
        '
        Me.txtSearchMobile.Location = New System.Drawing.Point(304, 22)
        Me.txtSearchMobile.Name = "txtSearchMobile"
        Me.txtSearchMobile.ReadOnly = True
        Me.txtSearchMobile.Size = New System.Drawing.Size(170, 20)
        Me.txtSearchMobile.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(262, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mobile"
        '
        'btnFindPatientByName
        '
        Me.btnFindPatientByName.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnFindPatientByName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindPatientByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindPatientByName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFindPatientByName.Location = New System.Drawing.Point(222, 22)
        Me.btnFindPatientByName.Name = "btnFindPatientByName"
        Me.btnFindPatientByName.Size = New System.Drawing.Size(32, 20)
        Me.btnFindPatientByName.TabIndex = 2
        Me.btnFindPatientByName.Text = "F2"
        Me.btnFindPatientByName.UseVisualStyleBackColor = True
        '
        'txtSearchName
        '
        Me.txtSearchName.Location = New System.Drawing.Point(48, 22)
        Me.txtSearchName.Name = "txtSearchName"
        Me.txtSearchName.ReadOnly = True
        Me.txtSearchName.Size = New System.Drawing.Size(170, 20)
        Me.txtSearchName.TabIndex = 1
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Location = New System.Drawing.Point(11, 25)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(35, 13)
        Me.lblPatientName.TabIndex = 0
        Me.lblPatientName.Text = "Name"
        '
        'gbBills
        '
        Me.gbBills.BackColor = System.Drawing.Color.Transparent
        Me.gbBills.Controls.Add(Me.dataGridViewPatinetBills)
        Me.gbBills.Location = New System.Drawing.Point(7, 112)
        Me.gbBills.Name = "gbBills"
        Me.gbBills.Size = New System.Drawing.Size(557, 157)
        Me.gbBills.TabIndex = 2
        Me.gbBills.TabStop = False
        Me.gbBills.Text = "Bills"
        '
        'dataGridViewPatinetBills
        '
        Me.dataGridViewPatinetBills.AllowUserToDeleteRows = False
        Me.dataGridViewPatinetBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewPatinetBills.Location = New System.Drawing.Point(5, 19)
        Me.dataGridViewPatinetBills.Name = "dataGridViewPatinetBills"
        Me.dataGridViewPatinetBills.Size = New System.Drawing.Size(545, 131)
        Me.dataGridViewPatinetBills.TabIndex = 0
        '
        'pnlBillUtilityBtn
        '
        Me.pnlBillUtilityBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.pnlBillUtilityBtn.Controls.Add(Me.btnBillUtilityClose)
        Me.pnlBillUtilityBtn.Controls.Add(Me.btnBillUtilityClear)
        Me.pnlBillUtilityBtn.Location = New System.Drawing.Point(448, 275)
        Me.pnlBillUtilityBtn.Name = "pnlBillUtilityBtn"
        Me.pnlBillUtilityBtn.Size = New System.Drawing.Size(116, 35)
        Me.pnlBillUtilityBtn.TabIndex = 3
        '
        'btnBillUtilityClose
        '
        Me.btnBillUtilityClose.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnBillUtilityClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillUtilityClose.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBillUtilityClose.Location = New System.Drawing.Point(58, 3)
        Me.btnBillUtilityClose.Name = "btnBillUtilityClose"
        Me.btnBillUtilityClose.Size = New System.Drawing.Size(55, 30)
        Me.btnBillUtilityClose.TabIndex = 1
        Me.btnBillUtilityClose.Text = "Close"
        Me.btnBillUtilityClose.UseVisualStyleBackColor = True
        '
        'btnBillUtilityClear
        '
        Me.btnBillUtilityClear.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnBillUtilityClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillUtilityClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBillUtilityClear.Location = New System.Drawing.Point(3, 3)
        Me.btnBillUtilityClear.Name = "btnBillUtilityClear"
        Me.btnBillUtilityClear.Size = New System.Drawing.Size(55, 30)
        Me.btnBillUtilityClear.TabIndex = 0
        Me.btnBillUtilityClear.Text = "Clear"
        Me.btnBillUtilityClear.UseVisualStyleBackColor = True
        '
        'PatientBillUtilityForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(571, 315)
        Me.Controls.Add(Me.pnlBillUtilityBtn)
        Me.Controls.Add(Me.gbBills)
        Me.Controls.Add(Me.gbPatientBillSearch)
        Me.Controls.Add(Me.tblBillUtilityHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PatientBillUtilityForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Bill Utility"
        Me.tblBillUtilityHeader.ResumeLayout(False)
        Me.pnlBillUtilityHeader.ResumeLayout(False)
        Me.pnlBillUtilityHeader.PerformLayout()
        Me.gbPatientBillSearch.ResumeLayout(False)
        Me.gbPatientBillSearch.PerformLayout()
        Me.gbBills.ResumeLayout(False)
        CType(Me.dataGridViewPatinetBills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBillUtilityBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblBillUtilityHeader As TableLayoutPanel
    Friend WithEvents pnlBillUtilityHeader As Panel
    Friend WithEvents lnlBillUtilityHeader As Label
    Friend WithEvents gbPatientBillSearch As GroupBox
    Friend WithEvents lblPatientName As Label
    Friend WithEvents txtSearchName As TextBox
    Friend WithEvents btnFindPatientByName As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchMobile As TextBox
    Friend WithEvents btnFindPatientBills As Button
    Friend WithEvents gbBills As GroupBox
    Friend WithEvents dataGridViewPatinetBills As DataGridView
    Friend WithEvents pnlBillUtilityBtn As Panel
    Friend WithEvents btnBillUtilityClear As Button
    Friend WithEvents btnBillUtilityClose As Button
End Class
