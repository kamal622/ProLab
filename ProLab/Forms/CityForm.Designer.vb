<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CityForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CityForm))
        Me.tblCityHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlCityHeader = New System.Windows.Forms.Panel()
        Me.lblCityMode = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tblCity = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlCountryArea = New System.Windows.Forms.Panel()
        Me.btnAddCountry = New System.Windows.Forms.Button()
        Me.comboCountry = New System.Windows.Forms.ComboBox()
        Me.pnlStateArea = New System.Windows.Forms.Panel()
        Me.btnAddState = New System.Windows.Forms.Button()
        Me.comboState = New System.Windows.Forms.ComboBox()
        Me.pnlCityArea = New System.Windows.Forms.Panel()
        Me.btnFindCity = New System.Windows.Forms.Button()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkCityActive = New System.Windows.Forms.CheckBox()
        Me.pnlCityBtn = New System.Windows.Forms.Panel()
        Me.btnCityClose = New System.Windows.Forms.Button()
        Me.btnCityClear = New System.Windows.Forms.Button()
        Me.btnCityDelete = New System.Windows.Forms.Button()
        Me.btnSaveCity = New System.Windows.Forms.Button()
        Me.tblCityHeader.SuspendLayout()
        Me.pnlCityHeader.SuspendLayout()
        Me.tblCity.SuspendLayout()
        Me.pnlCountryArea.SuspendLayout()
        Me.pnlStateArea.SuspendLayout()
        Me.pnlCityArea.SuspendLayout()
        Me.pnlCityBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblCityHeader
        '
        Me.tblCityHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tblCityHeader.ColumnCount = 1
        Me.tblCityHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblCityHeader.Controls.Add(Me.pnlCityHeader, 0, 0)
        Me.tblCityHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblCityHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblCityHeader.Name = "tblCityHeader"
        Me.tblCityHeader.RowCount = 1
        Me.tblCityHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblCityHeader.Size = New System.Drawing.Size(385, 40)
        Me.tblCityHeader.TabIndex = 3
        '
        'pnlCityHeader
        '
        Me.pnlCityHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.pnlCityHeader.Controls.Add(Me.lblCityMode)
        Me.pnlCityHeader.Controls.Add(Me.Label2)
        Me.pnlCityHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCityHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlCityHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.pnlCityHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlCityHeader.Name = "pnlCityHeader"
        Me.pnlCityHeader.Size = New System.Drawing.Size(379, 34)
        Me.pnlCityHeader.TabIndex = 0
        '
        'lblCityMode
        '
        Me.lblCityMode.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCityMode.AutoSize = True
        Me.lblCityMode.BackColor = System.Drawing.Color.Maroon
        Me.lblCityMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCityMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityMode.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCityMode.Location = New System.Drawing.Point(289, 7)
        Me.lblCityMode.Name = "lblCityMode"
        Me.lblCityMode.Size = New System.Drawing.Size(76, 19)
        Me.lblCityMode.TabIndex = 4
        Me.lblCityMode.Text = "New Mode"
        Me.lblCityMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "City"
        '
        'tblCity
        '
        Me.tblCity.BackColor = System.Drawing.Color.Transparent
        Me.tblCity.BackgroundImage = CType(resources.GetObject("tblCity.BackgroundImage"), System.Drawing.Image)
        Me.tblCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tblCity.ColumnCount = 2
        Me.tblCity.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblCity.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tblCity.Controls.Add(Me.Label1, 0, 0)
        Me.tblCity.Controls.Add(Me.Label3, 0, 1)
        Me.tblCity.Controls.Add(Me.Label4, 0, 2)
        Me.tblCity.Controls.Add(Me.pnlCountryArea, 1, 0)
        Me.tblCity.Controls.Add(Me.pnlStateArea, 1, 1)
        Me.tblCity.Controls.Add(Me.pnlCityArea, 1, 2)
        Me.tblCity.Controls.Add(Me.Label5, 0, 3)
        Me.tblCity.Controls.Add(Me.chkCityActive, 1, 3)
        Me.tblCity.Location = New System.Drawing.Point(15, 51)
        Me.tblCity.Name = "tblCity"
        Me.tblCity.RowCount = 4
        Me.tblCity.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblCity.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblCity.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblCity.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblCity.Size = New System.Drawing.Size(359, 137)
        Me.tblCity.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Country"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "State"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 71)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "City"
        '
        'pnlCountryArea
        '
        Me.pnlCountryArea.Controls.Add(Me.btnAddCountry)
        Me.pnlCountryArea.Controls.Add(Me.comboCountry)
        Me.pnlCountryArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCountryArea.Location = New System.Drawing.Point(110, 3)
        Me.pnlCountryArea.Name = "pnlCountryArea"
        Me.pnlCountryArea.Size = New System.Drawing.Size(246, 28)
        Me.pnlCountryArea.TabIndex = 6
        '
        'btnAddCountry
        '
        Me.btnAddCountry.BackgroundImage = Global.ProLab.My.Resources.Resources.add
        Me.btnAddCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddCountry.Location = New System.Drawing.Point(215, 3)
        Me.btnAddCountry.Name = "btnAddCountry"
        Me.btnAddCountry.Size = New System.Drawing.Size(21, 21)
        Me.btnAddCountry.TabIndex = 4
        Me.btnAddCountry.UseVisualStyleBackColor = True
        Me.btnAddCountry.Visible = False
        '
        'comboCountry
        '
        Me.comboCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboCountry.FormattingEnabled = True
        Me.comboCountry.Location = New System.Drawing.Point(0, 3)
        Me.comboCountry.Name = "comboCountry"
        Me.comboCountry.Size = New System.Drawing.Size(209, 21)
        Me.comboCountry.TabIndex = 3
        '
        'pnlStateArea
        '
        Me.pnlStateArea.Controls.Add(Me.btnAddState)
        Me.pnlStateArea.Controls.Add(Me.comboState)
        Me.pnlStateArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStateArea.Location = New System.Drawing.Point(110, 37)
        Me.pnlStateArea.Name = "pnlStateArea"
        Me.pnlStateArea.Size = New System.Drawing.Size(246, 28)
        Me.pnlStateArea.TabIndex = 7
        '
        'btnAddState
        '
        Me.btnAddState.BackgroundImage = Global.ProLab.My.Resources.Resources.add
        Me.btnAddState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddState.Location = New System.Drawing.Point(215, 3)
        Me.btnAddState.Name = "btnAddState"
        Me.btnAddState.Size = New System.Drawing.Size(21, 21)
        Me.btnAddState.TabIndex = 5
        Me.btnAddState.UseVisualStyleBackColor = True
        Me.btnAddState.Visible = False
        '
        'comboState
        '
        Me.comboState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboState.FormattingEnabled = True
        Me.comboState.Location = New System.Drawing.Point(0, 3)
        Me.comboState.Name = "comboState"
        Me.comboState.Size = New System.Drawing.Size(209, 21)
        Me.comboState.TabIndex = 4
        '
        'pnlCityArea
        '
        Me.pnlCityArea.Controls.Add(Me.btnFindCity)
        Me.pnlCityArea.Controls.Add(Me.txtCity)
        Me.pnlCityArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCityArea.Location = New System.Drawing.Point(110, 71)
        Me.pnlCityArea.Name = "pnlCityArea"
        Me.pnlCityArea.Size = New System.Drawing.Size(246, 28)
        Me.pnlCityArea.TabIndex = 8
        '
        'btnFindCity
        '
        Me.btnFindCity.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnFindCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindCity.ForeColor = System.Drawing.Color.White
        Me.btnFindCity.Location = New System.Drawing.Point(215, 3)
        Me.btnFindCity.Name = "btnFindCity"
        Me.btnFindCity.Size = New System.Drawing.Size(29, 20)
        Me.btnFindCity.TabIndex = 6
        Me.btnFindCity.Text = "F2"
        Me.btnFindCity.UseVisualStyleBackColor = True
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(0, 3)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(209, 20)
        Me.txtCity.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Active"
        '
        'chkCityActive
        '
        Me.chkCityActive.AutoSize = True
        Me.chkCityActive.Location = New System.Drawing.Point(110, 105)
        Me.chkCityActive.Name = "chkCityActive"
        Me.chkCityActive.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.chkCityActive.Size = New System.Drawing.Size(16, 14)
        Me.chkCityActive.TabIndex = 10
        Me.chkCityActive.UseVisualStyleBackColor = True
        '
        'pnlCityBtn
        '
        Me.pnlCityBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.pnlCityBtn.Controls.Add(Me.btnCityClose)
        Me.pnlCityBtn.Controls.Add(Me.btnCityClear)
        Me.pnlCityBtn.Controls.Add(Me.btnCityDelete)
        Me.pnlCityBtn.Controls.Add(Me.btnSaveCity)
        Me.pnlCityBtn.Location = New System.Drawing.Point(143, 191)
        Me.pnlCityBtn.Name = "pnlCityBtn"
        Me.pnlCityBtn.Size = New System.Drawing.Size(231, 35)
        Me.pnlCityBtn.TabIndex = 5
        '
        'btnCityClose
        '
        Me.btnCityClose.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnCityClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCityClose.ForeColor = System.Drawing.Color.White
        Me.btnCityClose.Location = New System.Drawing.Point(171, 3)
        Me.btnCityClose.Name = "btnCityClose"
        Me.btnCityClose.Size = New System.Drawing.Size(56, 30)
        Me.btnCityClose.TabIndex = 3
        Me.btnCityClose.Text = "&Close"
        Me.btnCityClose.UseVisualStyleBackColor = True
        '
        'btnCityClear
        '
        Me.btnCityClear.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnCityClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCityClear.ForeColor = System.Drawing.Color.White
        Me.btnCityClear.Location = New System.Drawing.Point(115, 3)
        Me.btnCityClear.Name = "btnCityClear"
        Me.btnCityClear.Size = New System.Drawing.Size(56, 30)
        Me.btnCityClear.TabIndex = 2
        Me.btnCityClear.Text = "C&lear"
        Me.btnCityClear.UseVisualStyleBackColor = True
        '
        'btnCityDelete
        '
        Me.btnCityDelete.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnCityDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCityDelete.ForeColor = System.Drawing.Color.White
        Me.btnCityDelete.Location = New System.Drawing.Point(59, 3)
        Me.btnCityDelete.Name = "btnCityDelete"
        Me.btnCityDelete.Size = New System.Drawing.Size(56, 30)
        Me.btnCityDelete.TabIndex = 1
        Me.btnCityDelete.Text = "&Delete"
        Me.btnCityDelete.UseVisualStyleBackColor = True
        '
        'btnSaveCity
        '
        Me.btnSaveCity.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnSaveCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveCity.ForeColor = System.Drawing.Color.White
        Me.btnSaveCity.Location = New System.Drawing.Point(3, 3)
        Me.btnSaveCity.Name = "btnSaveCity"
        Me.btnSaveCity.Size = New System.Drawing.Size(56, 30)
        Me.btnSaveCity.TabIndex = 0
        Me.btnSaveCity.Text = "&Save"
        Me.btnSaveCity.UseVisualStyleBackColor = True
        '
        'CityForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(385, 233)
        Me.Controls.Add(Me.pnlCityBtn)
        Me.Controls.Add(Me.tblCity)
        Me.Controls.Add(Me.tblCityHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CityForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "City"
        Me.tblCityHeader.ResumeLayout(False)
        Me.pnlCityHeader.ResumeLayout(False)
        Me.pnlCityHeader.PerformLayout()
        Me.tblCity.ResumeLayout(False)
        Me.tblCity.PerformLayout()
        Me.pnlCountryArea.ResumeLayout(False)
        Me.pnlStateArea.ResumeLayout(False)
        Me.pnlCityArea.ResumeLayout(False)
        Me.pnlCityArea.PerformLayout()
        Me.pnlCityBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblCityHeader As TableLayoutPanel
    Friend WithEvents pnlCityHeader As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCityMode As Label
    Friend WithEvents tblCity As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents comboCountry As ComboBox
    Friend WithEvents pnlCityBtn As Panel
    Friend WithEvents btnSaveCity As Button
    Friend WithEvents btnCityDelete As Button
    Friend WithEvents comboState As ComboBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents pnlCountryArea As Panel
    Friend WithEvents pnlStateArea As Panel
    Friend WithEvents btnAddCountry As Button
    Friend WithEvents btnAddState As Button
    Friend WithEvents pnlCityArea As Panel
    Friend WithEvents btnFindCity As Button
    Friend WithEvents btnCityClose As Button
    Friend WithEvents btnCityClear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents chkCityActive As CheckBox
End Class
