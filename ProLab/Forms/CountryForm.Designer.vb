<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CountryForm))
        Me.tblCountry = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlCountryHeader = New System.Windows.Forms.Panel()
        Me.lblCountryMode = New System.Windows.Forms.Label()
        Me.lblCountryHeader = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlCountry = New System.Windows.Forms.Panel()
        Me.FindCountry = New System.Windows.Forms.Button()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkCountryActive = New System.Windows.Forms.CheckBox()
        Me.pnlCountryBtn = New System.Windows.Forms.Panel()
        Me.btnCoutryDelete = New System.Windows.Forms.Button()
        Me.btnCountryClear = New System.Windows.Forms.Button()
        Me.btnCountryClose = New System.Windows.Forms.Button()
        Me.btnCountrySave = New System.Windows.Forms.Button()
        Me.tblCountry.SuspendLayout()
        Me.pnlCountryHeader.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.pnlCountry.SuspendLayout()
        Me.pnlCountryBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblCountry
        '
        Me.tblCountry.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tblCountry.ColumnCount = 1
        Me.tblCountry.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblCountry.Controls.Add(Me.pnlCountryHeader, 0, 0)
        Me.tblCountry.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblCountry.Location = New System.Drawing.Point(0, 0)
        Me.tblCountry.Name = "tblCountry"
        Me.tblCountry.RowCount = 1
        Me.tblCountry.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblCountry.Size = New System.Drawing.Size(353, 40)
        Me.tblCountry.TabIndex = 0
        '
        'pnlCountryHeader
        '
        Me.pnlCountryHeader.Controls.Add(Me.lblCountryMode)
        Me.pnlCountryHeader.Controls.Add(Me.lblCountryHeader)
        Me.pnlCountryHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCountryHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlCountryHeader.Name = "pnlCountryHeader"
        Me.pnlCountryHeader.Size = New System.Drawing.Size(347, 34)
        Me.pnlCountryHeader.TabIndex = 0
        '
        'lblCountryMode
        '
        Me.lblCountryMode.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCountryMode.AutoSize = True
        Me.lblCountryMode.BackColor = System.Drawing.Color.Maroon
        Me.lblCountryMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCountryMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountryMode.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCountryMode.Location = New System.Drawing.Point(261, 6)
        Me.lblCountryMode.Name = "lblCountryMode"
        Me.lblCountryMode.Size = New System.Drawing.Size(76, 19)
        Me.lblCountryMode.TabIndex = 5
        Me.lblCountryMode.Text = "New Mode"
        Me.lblCountryMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCountryHeader
        '
        Me.lblCountryHeader.AutoSize = True
        Me.lblCountryHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountryHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCountryHeader.Location = New System.Drawing.Point(9, 6)
        Me.lblCountryHeader.Name = "lblCountryHeader"
        Me.lblCountryHeader.Size = New System.Drawing.Size(64, 17)
        Me.lblCountryHeader.TabIndex = 0
        Me.lblCountryHeader.Text = "Country"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.BackgroundImage = CType(resources.GetObject("TableLayoutPanel2.BackgroundImage"), System.Drawing.Image)
        Me.TableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.pnlCountry, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.chkCountryActive, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(15, 50)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(328, 60)
        Me.TableLayoutPanel2.TabIndex = 1
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
        'pnlCountry
        '
        Me.pnlCountry.Controls.Add(Me.FindCountry)
        Me.pnlCountry.Controls.Add(Me.txtCountry)
        Me.pnlCountry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCountry.Location = New System.Drawing.Point(101, 3)
        Me.pnlCountry.Name = "pnlCountry"
        Me.pnlCountry.Size = New System.Drawing.Size(224, 24)
        Me.pnlCountry.TabIndex = 1
        '
        'FindCountry
        '
        Me.FindCountry.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.FindCountry.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FindCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindCountry.ForeColor = System.Drawing.Color.White
        Me.FindCountry.Location = New System.Drawing.Point(192, 0)
        Me.FindCountry.Name = "FindCountry"
        Me.FindCountry.Size = New System.Drawing.Size(29, 20)
        Me.FindCountry.TabIndex = 2
        Me.FindCountry.Text = "F2"
        Me.FindCountry.UseVisualStyleBackColor = True
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(9, 0)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(177, 20)
        Me.txtCountry.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IsActive"
        '
        'chkCountryActive
        '
        Me.chkCountryActive.Checked = True
        Me.chkCountryActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCountryActive.Location = New System.Drawing.Point(101, 33)
        Me.chkCountryActive.Name = "chkCountryActive"
        Me.chkCountryActive.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.chkCountryActive.Size = New System.Drawing.Size(95, 24)
        Me.chkCountryActive.TabIndex = 3
        Me.chkCountryActive.UseVisualStyleBackColor = True
        '
        'pnlCountryBtn
        '
        Me.pnlCountryBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.pnlCountryBtn.Controls.Add(Me.btnCoutryDelete)
        Me.pnlCountryBtn.Controls.Add(Me.btnCountryClear)
        Me.pnlCountryBtn.Controls.Add(Me.btnCountryClose)
        Me.pnlCountryBtn.Controls.Add(Me.btnCountrySave)
        Me.pnlCountryBtn.Location = New System.Drawing.Point(112, 116)
        Me.pnlCountryBtn.Name = "pnlCountryBtn"
        Me.pnlCountryBtn.Size = New System.Drawing.Size(231, 37)
        Me.pnlCountryBtn.TabIndex = 2
        '
        'btnCoutryDelete
        '
        Me.btnCoutryDelete.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnCoutryDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoutryDelete.ForeColor = System.Drawing.Color.White
        Me.btnCoutryDelete.Location = New System.Drawing.Point(59, 4)
        Me.btnCoutryDelete.Name = "btnCoutryDelete"
        Me.btnCoutryDelete.Size = New System.Drawing.Size(56, 30)
        Me.btnCoutryDelete.TabIndex = 2
        Me.btnCoutryDelete.Text = "&Delete"
        Me.btnCoutryDelete.UseVisualStyleBackColor = True
        '
        'btnCountryClear
        '
        Me.btnCountryClear.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnCountryClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCountryClear.ForeColor = System.Drawing.Color.White
        Me.btnCountryClear.Location = New System.Drawing.Point(115, 4)
        Me.btnCountryClear.Name = "btnCountryClear"
        Me.btnCountryClear.Size = New System.Drawing.Size(56, 30)
        Me.btnCountryClear.TabIndex = 3
        Me.btnCountryClear.Text = "C&lear"
        Me.btnCountryClear.UseVisualStyleBackColor = True
        '
        'btnCountryClose
        '
        Me.btnCountryClose.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnCountryClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCountryClose.ForeColor = System.Drawing.Color.White
        Me.btnCountryClose.Location = New System.Drawing.Point(172, 4)
        Me.btnCountryClose.Name = "btnCountryClose"
        Me.btnCountryClose.Size = New System.Drawing.Size(56, 30)
        Me.btnCountryClose.TabIndex = 4
        Me.btnCountryClose.Text = "&Close"
        Me.btnCountryClose.UseVisualStyleBackColor = True
        '
        'btnCountrySave
        '
        Me.btnCountrySave.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnCountrySave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCountrySave.ForeColor = System.Drawing.Color.White
        Me.btnCountrySave.Location = New System.Drawing.Point(3, 4)
        Me.btnCountrySave.Name = "btnCountrySave"
        Me.btnCountrySave.Size = New System.Drawing.Size(56, 30)
        Me.btnCountrySave.TabIndex = 0
        Me.btnCountrySave.Text = "&Save"
        Me.btnCountrySave.UseVisualStyleBackColor = True
        '
        'CountryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(353, 159)
        Me.Controls.Add(Me.pnlCountryBtn)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.tblCountry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CountryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Country"
        Me.tblCountry.ResumeLayout(False)
        Me.pnlCountryHeader.ResumeLayout(False)
        Me.pnlCountryHeader.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.pnlCountry.ResumeLayout(False)
        Me.pnlCountry.PerformLayout()
        Me.pnlCountryBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblCountry As TableLayoutPanel
    Friend WithEvents pnlCountryHeader As Panel
    Friend WithEvents lblCountryHeader As Label
    Friend WithEvents lblCountryMode As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents pnlCountryBtn As Panel
    Friend WithEvents btnCountrySave As Button
    Friend WithEvents btnCountryClose As Button
    Friend WithEvents pnlCountry As Panel
    Friend WithEvents FindCountry As Button
    Friend WithEvents btnCoutryDelete As Button
    Friend WithEvents btnCountryClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents chkCountryActive As CheckBox
End Class
