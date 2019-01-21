<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StateForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StateForm))
        Me.tblStateHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlStateHeader = New System.Windows.Forms.Panel()
        Me.lblStateMode = New System.Windows.Forms.Label()
        Me.lblStateHeader = New System.Windows.Forms.Label()
        Me.tblState = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnFindState = New System.Windows.Forms.Button()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAddCountry = New System.Windows.Forms.Button()
        Me.comboCountry = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkStateActive = New System.Windows.Forms.CheckBox()
        Me.pnlStateBtn = New System.Windows.Forms.Panel()
        Me.btnStateDelete = New System.Windows.Forms.Button()
        Me.btnStateClear = New System.Windows.Forms.Button()
        Me.btnStateClose = New System.Windows.Forms.Button()
        Me.btnStateSave = New System.Windows.Forms.Button()
        Me.tblStateHeader.SuspendLayout()
        Me.pnlStateHeader.SuspendLayout()
        Me.tblState.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlStateBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblStateHeader
        '
        Me.tblStateHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tblStateHeader.ColumnCount = 1
        Me.tblStateHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblStateHeader.Controls.Add(Me.pnlStateHeader, 0, 0)
        Me.tblStateHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblStateHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblStateHeader.Name = "tblStateHeader"
        Me.tblStateHeader.RowCount = 1
        Me.tblStateHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblStateHeader.Size = New System.Drawing.Size(367, 40)
        Me.tblStateHeader.TabIndex = 0
        '
        'pnlStateHeader
        '
        Me.pnlStateHeader.Controls.Add(Me.lblStateMode)
        Me.pnlStateHeader.Controls.Add(Me.lblStateHeader)
        Me.pnlStateHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStateHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlStateHeader.Name = "pnlStateHeader"
        Me.pnlStateHeader.Size = New System.Drawing.Size(361, 34)
        Me.pnlStateHeader.TabIndex = 0
        '
        'lblStateMode
        '
        Me.lblStateMode.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblStateMode.AutoSize = True
        Me.lblStateMode.BackColor = System.Drawing.Color.Maroon
        Me.lblStateMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStateMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateMode.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblStateMode.Location = New System.Drawing.Point(265, 7)
        Me.lblStateMode.Name = "lblStateMode"
        Me.lblStateMode.Size = New System.Drawing.Size(76, 19)
        Me.lblStateMode.TabIndex = 6
        Me.lblStateMode.Text = "New Mode"
        Me.lblStateMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStateHeader
        '
        Me.lblStateHeader.AutoSize = True
        Me.lblStateHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblStateHeader.Location = New System.Drawing.Point(9, 6)
        Me.lblStateHeader.Name = "lblStateHeader"
        Me.lblStateHeader.Size = New System.Drawing.Size(46, 17)
        Me.lblStateHeader.TabIndex = 0
        Me.lblStateHeader.Text = "State"
        '
        'tblState
        '
        Me.tblState.BackColor = System.Drawing.Color.Transparent
        Me.tblState.BackgroundImage = CType(resources.GetObject("tblState.BackgroundImage"), System.Drawing.Image)
        Me.tblState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tblState.ColumnCount = 2
        Me.tblState.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblState.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tblState.Controls.Add(Me.Panel4, 1, 1)
        Me.tblState.Controls.Add(Me.Label2, 0, 0)
        Me.tblState.Controls.Add(Me.Label3, 0, 1)
        Me.tblState.Controls.Add(Me.Panel3, 1, 0)
        Me.tblState.Controls.Add(Me.Label1, 0, 2)
        Me.tblState.Controls.Add(Me.chkStateActive, 1, 2)
        Me.tblState.Location = New System.Drawing.Point(12, 50)
        Me.tblState.Name = "tblState"
        Me.tblState.RowCount = 3
        Me.tblState.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblState.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblState.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblState.Size = New System.Drawing.Size(341, 98)
        Me.tblState.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnFindState)
        Me.Panel4.Controls.Add(Me.txtState)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(105, 35)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(233, 26)
        Me.Panel4.TabIndex = 3
        '
        'btnFindState
        '
        Me.btnFindState.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnFindState.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindState.ForeColor = System.Drawing.Color.White
        Me.btnFindState.Location = New System.Drawing.Point(198, 4)
        Me.btnFindState.Name = "btnFindState"
        Me.btnFindState.Size = New System.Drawing.Size(29, 20)
        Me.btnFindState.TabIndex = 4
        Me.btnFindState.Text = "F2"
        Me.btnFindState.UseVisualStyleBackColor = True
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(3, 3)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(189, 20)
        Me.txtState.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Country"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "State"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnAddCountry)
        Me.Panel3.Controls.Add(Me.comboCountry)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(105, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(233, 26)
        Me.Panel3.TabIndex = 2
        '
        'btnAddCountry
        '
        Me.btnAddCountry.BackgroundImage = Global.ProLab.My.Resources.Resources.add
        Me.btnAddCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddCountry.Location = New System.Drawing.Point(206, 3)
        Me.btnAddCountry.Name = "btnAddCountry"
        Me.btnAddCountry.Size = New System.Drawing.Size(21, 21)
        Me.btnAddCountry.TabIndex = 3
        Me.btnAddCountry.UseVisualStyleBackColor = True
        Me.btnAddCountry.Visible = False
        '
        'comboCountry
        '
        Me.comboCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboCountry.FormattingEnabled = True
        Me.comboCountry.Location = New System.Drawing.Point(3, 3)
        Me.comboCountry.Name = "comboCountry"
        Me.comboCountry.Size = New System.Drawing.Size(189, 21)
        Me.comboCountry.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Active"
        '
        'chkStateActive
        '
        Me.chkStateActive.AutoSize = True
        Me.chkStateActive.Checked = True
        Me.chkStateActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStateActive.Location = New System.Drawing.Point(105, 67)
        Me.chkStateActive.Name = "chkStateActive"
        Me.chkStateActive.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.chkStateActive.Size = New System.Drawing.Size(17, 14)
        Me.chkStateActive.TabIndex = 5
        Me.chkStateActive.UseVisualStyleBackColor = True
        '
        'pnlStateBtn
        '
        Me.pnlStateBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.pnlStateBtn.Controls.Add(Me.btnStateDelete)
        Me.pnlStateBtn.Controls.Add(Me.btnStateClear)
        Me.pnlStateBtn.Controls.Add(Me.btnStateClose)
        Me.pnlStateBtn.Controls.Add(Me.btnStateSave)
        Me.pnlStateBtn.Location = New System.Drawing.Point(122, 154)
        Me.pnlStateBtn.Name = "pnlStateBtn"
        Me.pnlStateBtn.Size = New System.Drawing.Size(231, 35)
        Me.pnlStateBtn.TabIndex = 2
        '
        'btnStateDelete
        '
        Me.btnStateDelete.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnStateDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStateDelete.ForeColor = System.Drawing.Color.White
        Me.btnStateDelete.Location = New System.Drawing.Point(60, 3)
        Me.btnStateDelete.Name = "btnStateDelete"
        Me.btnStateDelete.Size = New System.Drawing.Size(56, 30)
        Me.btnStateDelete.TabIndex = 3
        Me.btnStateDelete.Text = "&Delete"
        Me.btnStateDelete.UseVisualStyleBackColor = True
        '
        'btnStateClear
        '
        Me.btnStateClear.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnStateClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStateClear.ForeColor = System.Drawing.Color.White
        Me.btnStateClear.Location = New System.Drawing.Point(115, 3)
        Me.btnStateClear.Name = "btnStateClear"
        Me.btnStateClear.Size = New System.Drawing.Size(56, 30)
        Me.btnStateClear.TabIndex = 2
        Me.btnStateClear.Text = "C&lear"
        Me.btnStateClear.UseVisualStyleBackColor = True
        '
        'btnStateClose
        '
        Me.btnStateClose.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnStateClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStateClose.ForeColor = System.Drawing.Color.White
        Me.btnStateClose.Location = New System.Drawing.Point(170, 3)
        Me.btnStateClose.Name = "btnStateClose"
        Me.btnStateClose.Size = New System.Drawing.Size(56, 30)
        Me.btnStateClose.TabIndex = 1
        Me.btnStateClose.Text = "&Close"
        Me.btnStateClose.UseVisualStyleBackColor = True
        '
        'btnStateSave
        '
        Me.btnStateSave.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnStateSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStateSave.ForeColor = System.Drawing.Color.White
        Me.btnStateSave.Location = New System.Drawing.Point(5, 3)
        Me.btnStateSave.Name = "btnStateSave"
        Me.btnStateSave.Size = New System.Drawing.Size(56, 30)
        Me.btnStateSave.TabIndex = 0
        Me.btnStateSave.Text = "&Save"
        Me.btnStateSave.UseVisualStyleBackColor = True
        '
        'StateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(367, 203)
        Me.Controls.Add(Me.pnlStateBtn)
        Me.Controls.Add(Me.tblState)
        Me.Controls.Add(Me.tblStateHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StateForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "State"
        Me.tblStateHeader.ResumeLayout(False)
        Me.pnlStateHeader.ResumeLayout(False)
        Me.pnlStateHeader.PerformLayout()
        Me.tblState.ResumeLayout(False)
        Me.tblState.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.pnlStateBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblStateHeader As TableLayoutPanel
    Friend WithEvents pnlStateHeader As Panel
    Friend WithEvents lblStateHeader As Label
    Friend WithEvents lblStateMode As Label
    Friend WithEvents tblState As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlStateBtn As Panel
    Friend WithEvents btnStateSave As Button
    Friend WithEvents btnStateClose As Button
    Friend WithEvents comboCountry As ComboBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAddCountry As Button
    Friend WithEvents btnStateDelete As Button
    Friend WithEvents btnStateClear As Button
    Friend WithEvents btnFindState As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents chkStateActive As CheckBox
End Class
