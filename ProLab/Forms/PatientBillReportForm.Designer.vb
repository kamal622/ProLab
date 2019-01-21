<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientBillReportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientBillReportForm))
        Me.tblBillUtilityHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlBillUtilityHeader = New System.Windows.Forms.Panel()
        Me.lnlBillUtilityHeader = New System.Windows.Forms.Label()
        Me.gbPatientBillSearch = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboReportData = New System.Windows.Forms.ComboBox()
        Me.dtToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtFromDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchTestList = New System.Windows.Forms.Button()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.gbBills = New System.Windows.Forms.GroupBox()
        Me.dataGridViewTestReportList = New System.Windows.Forms.DataGridView()
        Me.pnlBillUtilityBtn = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tblBillUtilityHeader.SuspendLayout()
        Me.pnlBillUtilityHeader.SuspendLayout()
        Me.gbPatientBillSearch.SuspendLayout()
        Me.gbBills.SuspendLayout()
        CType(Me.dataGridViewTestReportList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tblBillUtilityHeader.Size = New System.Drawing.Size(740, 40)
        Me.tblBillUtilityHeader.TabIndex = 4
        '
        'pnlBillUtilityHeader
        '
        Me.pnlBillUtilityHeader.Controls.Add(Me.lnlBillUtilityHeader)
        Me.pnlBillUtilityHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBillUtilityHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlBillUtilityHeader.Name = "pnlBillUtilityHeader"
        Me.pnlBillUtilityHeader.Size = New System.Drawing.Size(734, 34)
        Me.pnlBillUtilityHeader.TabIndex = 0
        '
        'lnlBillUtilityHeader
        '
        Me.lnlBillUtilityHeader.AutoSize = True
        Me.lnlBillUtilityHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlBillUtilityHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lnlBillUtilityHeader.Location = New System.Drawing.Point(1, 8)
        Me.lnlBillUtilityHeader.Name = "lnlBillUtilityHeader"
        Me.lnlBillUtilityHeader.Size = New System.Drawing.Size(110, 17)
        Me.lnlBillUtilityHeader.TabIndex = 0
        Me.lnlBillUtilityHeader.Text = "BillReport List"
        '
        'gbPatientBillSearch
        '
        Me.gbPatientBillSearch.BackColor = System.Drawing.Color.Transparent
        Me.gbPatientBillSearch.Controls.Add(Me.Label1)
        Me.gbPatientBillSearch.Controls.Add(Me.comboReportData)
        Me.gbPatientBillSearch.Controls.Add(Me.dtToDate)
        Me.gbPatientBillSearch.Controls.Add(Me.dtFromDate)
        Me.gbPatientBillSearch.Controls.Add(Me.btnSearchTestList)
        Me.gbPatientBillSearch.Controls.Add(Me.lblToDate)
        Me.gbPatientBillSearch.Controls.Add(Me.lblFromDate)
        Me.gbPatientBillSearch.Location = New System.Drawing.Point(7, 55)
        Me.gbPatientBillSearch.Name = "gbPatientBillSearch"
        Me.gbPatientBillSearch.Size = New System.Drawing.Size(721, 58)
        Me.gbPatientBillSearch.TabIndex = 5
        Me.gbPatientBillSearch.TabStop = False
        Me.gbPatientBillSearch.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Status"
        '
        'comboReportData
        '
        Me.comboReportData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboReportData.FormattingEnabled = True
        Me.comboReportData.Location = New System.Drawing.Point(486, 19)
        Me.comboReportData.Name = "comboReportData"
        Me.comboReportData.Size = New System.Drawing.Size(101, 21)
        Me.comboReportData.TabIndex = 8
        '
        'dtToDate
        '
        Me.dtToDate.CustomFormat = "dd-MM-yyyy"
        Me.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtToDate.Location = New System.Drawing.Point(285, 20)
        Me.dtToDate.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.dtToDate.Name = "dtToDate"
        Me.dtToDate.Size = New System.Drawing.Size(128, 20)
        Me.dtToDate.TabIndex = 7
        '
        'dtFromDate
        '
        Me.dtFromDate.CustomFormat = "dd-MM-yyyy"
        Me.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFromDate.Location = New System.Drawing.Point(81, 20)
        Me.dtFromDate.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.dtFromDate.Name = "dtFromDate"
        Me.dtFromDate.Size = New System.Drawing.Size(126, 20)
        Me.dtFromDate.TabIndex = 6
        '
        'btnSearchTestList
        '
        Me.btnSearchTestList.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnSearchTestList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchTestList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchTestList.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSearchTestList.Location = New System.Drawing.Point(616, 20)
        Me.btnSearchTestList.Name = "btnSearchTestList"
        Me.btnSearchTestList.Size = New System.Drawing.Size(72, 20)
        Me.btnSearchTestList.TabIndex = 5
        Me.btnSearchTestList.Text = "Search"
        Me.btnSearchTestList.UseVisualStyleBackColor = True
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(230, 25)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(43, 13)
        Me.lblToDate.TabIndex = 3
        Me.lblToDate.Text = "ToDate"
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Location = New System.Drawing.Point(15, 25)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(56, 13)
        Me.lblFromDate.TabIndex = 0
        Me.lblFromDate.Text = "From Date"
        '
        'gbBills
        '
        Me.gbBills.BackColor = System.Drawing.Color.Transparent
        Me.gbBills.Controls.Add(Me.dataGridViewTestReportList)
        Me.gbBills.Location = New System.Drawing.Point(7, 118)
        Me.gbBills.Name = "gbBills"
        Me.gbBills.Size = New System.Drawing.Size(721, 271)
        Me.gbBills.TabIndex = 6
        Me.gbBills.TabStop = False
        Me.gbBills.Text = "Test Report List"
        '
        'dataGridViewTestReportList
        '
        Me.dataGridViewTestReportList.AllowUserToDeleteRows = False
        Me.dataGridViewTestReportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewTestReportList.Location = New System.Drawing.Point(5, 19)
        Me.dataGridViewTestReportList.Name = "dataGridViewTestReportList"
        Me.dataGridViewTestReportList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridViewTestReportList.Size = New System.Drawing.Size(710, 246)
        Me.dataGridViewTestReportList.TabIndex = 0
        '
        'pnlBillUtilityBtn
        '
        Me.pnlBillUtilityBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.pnlBillUtilityBtn.Controls.Add(Me.btnClose)
        Me.pnlBillUtilityBtn.Controls.Add(Me.btnClear)
        Me.pnlBillUtilityBtn.Location = New System.Drawing.Point(600, 395)
        Me.pnlBillUtilityBtn.Name = "pnlBillUtilityBtn"
        Me.pnlBillUtilityBtn.Size = New System.Drawing.Size(122, 35)
        Me.pnlBillUtilityBtn.TabIndex = 7
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClose.Location = New System.Drawing.Point(60, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(61, 30)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClear.Location = New System.Drawing.Point(3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(55, 30)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'PatientBillReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(740, 442)
        Me.Controls.Add(Me.tblBillUtilityHeader)
        Me.Controls.Add(Me.gbPatientBillSearch)
        Me.Controls.Add(Me.gbBills)
        Me.Controls.Add(Me.pnlBillUtilityBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PatientBillReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PatientBillReportForm"
        Me.tblBillUtilityHeader.ResumeLayout(False)
        Me.pnlBillUtilityHeader.ResumeLayout(False)
        Me.pnlBillUtilityHeader.PerformLayout()
        Me.gbPatientBillSearch.ResumeLayout(False)
        Me.gbPatientBillSearch.PerformLayout()
        Me.gbBills.ResumeLayout(False)
        CType(Me.dataGridViewTestReportList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBillUtilityBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblBillUtilityHeader As TableLayoutPanel
    Friend WithEvents pnlBillUtilityHeader As Panel
    Friend WithEvents lnlBillUtilityHeader As Label
    Friend WithEvents gbPatientBillSearch As GroupBox
    Friend WithEvents btnSearchTestList As Button
    Friend WithEvents lblToDate As Label
    Friend WithEvents lblFromDate As Label
    Friend WithEvents gbBills As GroupBox
    Friend WithEvents dataGridViewTestReportList As DataGridView
    Friend WithEvents pnlBillUtilityBtn As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents dtToDate As DateTimePicker
    Friend WithEvents dtFromDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents comboReportData As ComboBox
End Class
