<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BillChequeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BillChequeForm))
        Me.tblChequeHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlChequeDetails = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblChequeHeader = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtChequeDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIFSCCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtChequeNo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnChequeClose = New System.Windows.Forms.Button()
        Me.btnChequeClear = New System.Windows.Forms.Button()
        Me.btnChequeSave = New System.Windows.Forms.Button()
        Me.tblChequeHeader.SuspendLayout()
        Me.pnlChequeDetails.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblChequeHeader
        '
        Me.tblChequeHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tblChequeHeader.ColumnCount = 1
        Me.tblChequeHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblChequeHeader.Controls.Add(Me.pnlChequeDetails, 0, 0)
        Me.tblChequeHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblChequeHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblChequeHeader.Name = "tblChequeHeader"
        Me.tblChequeHeader.RowCount = 1
        Me.tblChequeHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblChequeHeader.Size = New System.Drawing.Size(477, 40)
        Me.tblChequeHeader.TabIndex = 0
        '
        'pnlChequeDetails
        '
        Me.pnlChequeDetails.Controls.Add(Me.Label1)
        Me.pnlChequeDetails.Controls.Add(Me.lblChequeHeader)
        Me.pnlChequeDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChequeDetails.Location = New System.Drawing.Point(3, 3)
        Me.pnlChequeDetails.Name = "pnlChequeDetails"
        Me.pnlChequeDetails.Size = New System.Drawing.Size(471, 34)
        Me.pnlChequeDetails.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(395, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "New Mode"
        '
        'lblChequeHeader
        '
        Me.lblChequeHeader.AutoSize = True
        Me.lblChequeHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequeHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblChequeHeader.Location = New System.Drawing.Point(6, 8)
        Me.lblChequeHeader.Name = "lblChequeHeader"
        Me.lblChequeHeader.Size = New System.Drawing.Size(118, 17)
        Me.lblChequeHeader.TabIndex = 0
        Me.lblChequeHeader.Text = "Cheque Details"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtChequeDate, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBankName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtIFSCCode, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtChequeNo, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 49)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(463, 79)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cheque Date"
        '
        'dtChequeDate
        '
        Me.dtChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtChequeDate.Location = New System.Drawing.Point(325, 3)
        Me.dtChequeDate.Name = "dtChequeDate"
        Me.dtChequeDate.Size = New System.Drawing.Size(135, 20)
        Me.dtChequeDate.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 29)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Bank Name"
        '
        'txtBankName
        '
        Me.txtBankName.Location = New System.Drawing.Point(95, 29)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(132, 20)
        Me.txtBankName.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "IFSC Code"
        '
        'txtIFSCCode
        '
        Me.txtIFSCCode.Location = New System.Drawing.Point(325, 29)
        Me.txtIFSCCode.Name = "txtIFSCCode"
        Me.txtIFSCCode.Size = New System.Drawing.Size(135, 20)
        Me.txtIFSCCode.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Cheque No"
        '
        'txtChequeNo
        '
        Me.txtChequeNo.Location = New System.Drawing.Point(95, 55)
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(132, 20)
        Me.txtChequeNo.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnChequeClose)
        Me.Panel1.Controls.Add(Me.btnChequeClear)
        Me.Panel1.Controls.Add(Me.btnChequeSave)
        Me.Panel1.Location = New System.Drawing.Point(287, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 35)
        Me.Panel1.TabIndex = 2
        '
        'btnChequeClose
        '
        Me.btnChequeClose.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnChequeClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChequeClose.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnChequeClose.Location = New System.Drawing.Point(119, 3)
        Me.btnChequeClose.Name = "btnChequeClose"
        Me.btnChequeClose.Size = New System.Drawing.Size(56, 30)
        Me.btnChequeClose.TabIndex = 3
        Me.btnChequeClose.Text = "&Close"
        Me.btnChequeClose.UseVisualStyleBackColor = True
        '
        'btnChequeClear
        '
        Me.btnChequeClear.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnChequeClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChequeClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnChequeClear.Location = New System.Drawing.Point(63, 3)
        Me.btnChequeClear.Name = "btnChequeClear"
        Me.btnChequeClear.Size = New System.Drawing.Size(56, 30)
        Me.btnChequeClear.TabIndex = 2
        Me.btnChequeClear.Text = "C&lear"
        Me.btnChequeClear.UseVisualStyleBackColor = True
        '
        'btnChequeSave
        '
        Me.btnChequeSave.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnChequeSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChequeSave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnChequeSave.Location = New System.Drawing.Point(4, 3)
        Me.btnChequeSave.Name = "btnChequeSave"
        Me.btnChequeSave.Size = New System.Drawing.Size(56, 30)
        Me.btnChequeSave.TabIndex = 0
        Me.btnChequeSave.Text = "&Save"
        Me.btnChequeSave.UseVisualStyleBackColor = True
        '
        'BillChequeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(477, 176)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.tblChequeHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BillChequeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheque Details"
        Me.tblChequeHeader.ResumeLayout(False)
        Me.pnlChequeDetails.ResumeLayout(False)
        Me.pnlChequeDetails.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblChequeHeader As TableLayoutPanel
    Friend WithEvents pnlChequeDetails As Panel
    Friend WithEvents lblChequeHeader As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtChequeDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBankName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIFSCCode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtChequeNo As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnChequeSave As Button
    Friend WithEvents btnChequeClear As Button
    Friend WithEvents btnChequeClose As Button
End Class
