<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportStatusForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportStatusForm))
        Me.comboReportData = New System.Windows.Forms.ComboBox()
        Me.btnStatusChangeSave = New System.Windows.Forms.Button()
        Me.tblServiceHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlServiceHeader = New System.Windows.Forms.Panel()
        Me.lblServiceMode = New System.Windows.Forms.Label()
        Me.lblService = New System.Windows.Forms.Label()
        Me.lblReportStatus = New System.Windows.Forms.Label()
        Me.tblServiceHeader.SuspendLayout()
        Me.pnlServiceHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'comboReportData
        '
        Me.comboReportData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboReportData.FormattingEnabled = True
        Me.comboReportData.Location = New System.Drawing.Point(107, 61)
        Me.comboReportData.Name = "comboReportData"
        Me.comboReportData.Size = New System.Drawing.Size(121, 21)
        Me.comboReportData.TabIndex = 0
        '
        'btnStatusChangeSave
        '
        Me.btnStatusChangeSave.Location = New System.Drawing.Point(108, 95)
        Me.btnStatusChangeSave.Name = "btnStatusChangeSave"
        Me.btnStatusChangeSave.Size = New System.Drawing.Size(75, 23)
        Me.btnStatusChangeSave.TabIndex = 1
        Me.btnStatusChangeSave.Text = "Save"
        Me.btnStatusChangeSave.UseVisualStyleBackColor = True
        '
        'tblServiceHeader
        '
        Me.tblServiceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tblServiceHeader.ColumnCount = 1
        Me.tblServiceHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblServiceHeader.Controls.Add(Me.pnlServiceHeader, 0, 0)
        Me.tblServiceHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblServiceHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblServiceHeader.Name = "tblServiceHeader"
        Me.tblServiceHeader.RowCount = 2
        Me.tblServiceHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblServiceHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tblServiceHeader.Size = New System.Drawing.Size(273, 43)
        Me.tblServiceHeader.TabIndex = 2
        '
        'pnlServiceHeader
        '
        Me.pnlServiceHeader.Controls.Add(Me.lblServiceMode)
        Me.pnlServiceHeader.Controls.Add(Me.lblService)
        Me.pnlServiceHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlServiceHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlServiceHeader.Name = "pnlServiceHeader"
        Me.pnlServiceHeader.Size = New System.Drawing.Size(267, 29)
        Me.pnlServiceHeader.TabIndex = 0
        '
        'lblServiceMode
        '
        Me.lblServiceMode.AutoSize = True
        Me.lblServiceMode.BackColor = System.Drawing.Color.Maroon
        Me.lblServiceMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblServiceMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceMode.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblServiceMode.Location = New System.Drawing.Point(399, 6)
        Me.lblServiceMode.Name = "lblServiceMode"
        Me.lblServiceMode.Size = New System.Drawing.Size(76, 19)
        Me.lblServiceMode.TabIndex = 1
        Me.lblServiceMode.Text = "New Mode"
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblService.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblService.Location = New System.Drawing.Point(12, 8)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(108, 17)
        Me.lblService.TabIndex = 0
        Me.lblService.Text = "Report Status"
        '
        'lblReportStatus
        '
        Me.lblReportStatus.AutoSize = True
        Me.lblReportStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblReportStatus.Location = New System.Drawing.Point(31, 66)
        Me.lblReportStatus.Name = "lblReportStatus"
        Me.lblReportStatus.Size = New System.Drawing.Size(69, 13)
        Me.lblReportStatus.TabIndex = 1
        Me.lblReportStatus.Text = "ReportStatus"
        '
        'ReportStatusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(273, 164)
        Me.Controls.Add(Me.tblServiceHeader)
        Me.Controls.Add(Me.lblReportStatus)
        Me.Controls.Add(Me.btnStatusChangeSave)
        Me.Controls.Add(Me.comboReportData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportStatusForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportStatusForm"
        Me.tblServiceHeader.ResumeLayout(False)
        Me.pnlServiceHeader.ResumeLayout(False)
        Me.pnlServiceHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboReportData As ComboBox
    Friend WithEvents btnStatusChangeSave As Button
    Friend WithEvents tblServiceHeader As TableLayoutPanel
    Friend WithEvents pnlServiceHeader As Panel
    Friend WithEvents lblServiceMode As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblReportStatus As Label
End Class
