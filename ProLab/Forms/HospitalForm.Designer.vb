<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HospitalForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HospitalForm))
        Me.tblHospitalHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlServiceHeader = New System.Windows.Forms.Panel()
        Me.lblHospitalMode = New System.Windows.Forms.Label()
        Me.lblHospitalHeader = New System.Windows.Forms.Label()
        Me.gbHospital = New System.Windows.Forms.GroupBox()
        Me.btnFindHospital = New System.Windows.Forms.Button()
        Me.txtFindHospital = New System.Windows.Forms.TextBox()
        Me.lblFindHospital = New System.Windows.Forms.Label()
        Me.tabHospital = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tblHospitalLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHName = New System.Windows.Forms.Label()
        Me.lblHAddress1 = New System.Windows.Forms.Label()
        Me.lblHAddress2 = New System.Windows.Forms.Label()
        Me.txtHospitalPhone1 = New System.Windows.Forms.TextBox()
        Me.lblHPhone1 = New System.Windows.Forms.Label()
        Me.txtHospitalPhone2 = New System.Windows.Forms.TextBox()
        Me.lblHPhone2 = New System.Windows.Forms.Label()
        Me.txtHospitalAddress1 = New System.Windows.Forms.TextBox()
        Me.txtHospitalAddress2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRequiredCountry = New System.Windows.Forms.Label()
        Me.txtHospitalName = New System.Windows.Forms.TextBox()
        Me.lblHCountry = New System.Windows.Forms.Label()
        Me.lblHState = New System.Windows.Forms.Label()
        Me.lblHCity = New System.Windows.Forms.Label()
        Me.pnlHCountry = New System.Windows.Forms.Panel()
        Me.btnHAddCountry = New System.Windows.Forms.Button()
        Me.comboHositalCountry = New System.Windows.Forms.ComboBox()
        Me.pnlHState = New System.Windows.Forms.Panel()
        Me.btnAddHState = New System.Windows.Forms.Button()
        Me.comboHositalState = New System.Windows.Forms.ComboBox()
        Me.pnlHCity = New System.Windows.Forms.Panel()
        Me.btnAddHCity = New System.Windows.Forms.Button()
        Me.comboHositalCity = New System.Windows.Forms.ComboBox()
        Me.lblRequiredState = New System.Windows.Forms.Label()
        Me.lblRequiredCity = New System.Windows.Forms.Label()
        Me.pnlHospitalButton = New System.Windows.Forms.Panel()
        Me.btnHospitalClose = New System.Windows.Forms.Button()
        Me.btnHospitalClear = New System.Windows.Forms.Button()
        Me.btnHospitalDelete = New System.Windows.Forms.Button()
        Me.btnHospitalSave = New System.Windows.Forms.Button()
        Me.tblHospitalHeader.SuspendLayout()
        Me.pnlServiceHeader.SuspendLayout()
        Me.gbHospital.SuspendLayout()
        Me.tabHospital.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.tblHospitalLayout.SuspendLayout()
        Me.pnlHCountry.SuspendLayout()
        Me.pnlHState.SuspendLayout()
        Me.pnlHCity.SuspendLayout()
        Me.pnlHospitalButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblHospitalHeader
        '
        Me.tblHospitalHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tblHospitalHeader.ColumnCount = 1
        Me.tblHospitalHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHospitalHeader.Controls.Add(Me.pnlServiceHeader, 0, 0)
        Me.tblHospitalHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHospitalHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHospitalHeader.Name = "tblHospitalHeader"
        Me.tblHospitalHeader.RowCount = 1
        Me.tblHospitalHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHospitalHeader.Size = New System.Drawing.Size(441, 40)
        Me.tblHospitalHeader.TabIndex = 0
        '
        'pnlServiceHeader
        '
        Me.pnlServiceHeader.Controls.Add(Me.lblHospitalMode)
        Me.pnlServiceHeader.Controls.Add(Me.lblHospitalHeader)
        Me.pnlServiceHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlServiceHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlServiceHeader.Name = "pnlServiceHeader"
        Me.pnlServiceHeader.Size = New System.Drawing.Size(435, 34)
        Me.pnlServiceHeader.TabIndex = 0
        '
        'lblHospitalMode
        '
        Me.lblHospitalMode.AutoSize = True
        Me.lblHospitalMode.BackColor = System.Drawing.Color.Maroon
        Me.lblHospitalMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHospitalMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHospitalMode.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblHospitalMode.Location = New System.Drawing.Point(346, 10)
        Me.lblHospitalMode.Name = "lblHospitalMode"
        Me.lblHospitalMode.Size = New System.Drawing.Size(76, 19)
        Me.lblHospitalMode.TabIndex = 1
        Me.lblHospitalMode.Text = "New Mode"
        '
        'lblHospitalHeader
        '
        Me.lblHospitalHeader.AutoSize = True
        Me.lblHospitalHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHospitalHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblHospitalHeader.Location = New System.Drawing.Point(15, 10)
        Me.lblHospitalHeader.Name = "lblHospitalHeader"
        Me.lblHospitalHeader.Size = New System.Drawing.Size(67, 17)
        Me.lblHospitalHeader.TabIndex = 0
        Me.lblHospitalHeader.Text = "Hospital"
        '
        'gbHospital
        '
        Me.gbHospital.BackColor = System.Drawing.Color.Transparent
        Me.gbHospital.Controls.Add(Me.btnFindHospital)
        Me.gbHospital.Controls.Add(Me.txtFindHospital)
        Me.gbHospital.Controls.Add(Me.lblFindHospital)
        Me.gbHospital.Location = New System.Drawing.Point(12, 50)
        Me.gbHospital.Name = "gbHospital"
        Me.gbHospital.Size = New System.Drawing.Size(413, 52)
        Me.gbHospital.TabIndex = 1
        Me.gbHospital.TabStop = False
        Me.gbHospital.Text = "Search"
        '
        'btnFindHospital
        '
        Me.btnFindHospital.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnFindHospital.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindHospital.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindHospital.ForeColor = System.Drawing.Color.White
        Me.btnFindHospital.Location = New System.Drawing.Point(356, 20)
        Me.btnFindHospital.Name = "btnFindHospital"
        Me.btnFindHospital.Size = New System.Drawing.Size(30, 20)
        Me.btnFindHospital.TabIndex = 2
        Me.btnFindHospital.Text = "F2"
        Me.btnFindHospital.UseVisualStyleBackColor = True
        '
        'txtFindHospital
        '
        Me.txtFindHospital.Location = New System.Drawing.Point(92, 20)
        Me.txtFindHospital.Name = "txtFindHospital"
        Me.txtFindHospital.Size = New System.Drawing.Size(258, 20)
        Me.txtFindHospital.TabIndex = 1
        '
        'lblFindHospital
        '
        Me.lblFindHospital.AutoSize = True
        Me.lblFindHospital.Location = New System.Drawing.Point(6, 19)
        Me.lblFindHospital.Name = "lblFindHospital"
        Me.lblFindHospital.Size = New System.Drawing.Size(35, 13)
        Me.lblFindHospital.TabIndex = 0
        Me.lblFindHospital.Text = "Name"
        '
        'tabHospital
        '
        Me.tabHospital.Controls.Add(Me.TabPage2)
        Me.tabHospital.Location = New System.Drawing.Point(12, 105)
        Me.tabHospital.Name = "tabHospital"
        Me.tabHospital.SelectedIndex = 0
        Me.tabHospital.Size = New System.Drawing.Size(417, 318)
        Me.tabHospital.TabIndex = 15
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.tblHospitalLayout)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(409, 292)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Hospital"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tblHospitalLayout
        '
        Me.tblHospitalLayout.ColumnCount = 3
        Me.tblHospitalLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblHospitalLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.tblHospitalLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tblHospitalLayout.Controls.Add(Me.Label2, 2, 1)
        Me.tblHospitalLayout.Controls.Add(Me.lblHName, 0, 0)
        Me.tblHospitalLayout.Controls.Add(Me.lblHAddress1, 0, 1)
        Me.tblHospitalLayout.Controls.Add(Me.lblHAddress2, 0, 2)
        Me.tblHospitalLayout.Controls.Add(Me.txtHospitalPhone1, 1, 3)
        Me.tblHospitalLayout.Controls.Add(Me.lblHPhone1, 0, 3)
        Me.tblHospitalLayout.Controls.Add(Me.txtHospitalPhone2, 1, 4)
        Me.tblHospitalLayout.Controls.Add(Me.lblHPhone2, 0, 4)
        Me.tblHospitalLayout.Controls.Add(Me.txtHospitalAddress1, 1, 1)
        Me.tblHospitalLayout.Controls.Add(Me.txtHospitalAddress2, 1, 2)
        Me.tblHospitalLayout.Controls.Add(Me.Label1, 2, 0)
        Me.tblHospitalLayout.Controls.Add(Me.lblRequiredCountry, 2, 5)
        Me.tblHospitalLayout.Controls.Add(Me.txtHospitalName, 1, 0)
        Me.tblHospitalLayout.Controls.Add(Me.lblHCountry, 0, 5)
        Me.tblHospitalLayout.Controls.Add(Me.lblHState, 0, 6)
        Me.tblHospitalLayout.Controls.Add(Me.lblHCity, 0, 7)
        Me.tblHospitalLayout.Controls.Add(Me.pnlHCountry, 1, 5)
        Me.tblHospitalLayout.Controls.Add(Me.pnlHState, 1, 6)
        Me.tblHospitalLayout.Controls.Add(Me.pnlHCity, 1, 7)
        Me.tblHospitalLayout.Controls.Add(Me.lblRequiredState, 2, 6)
        Me.tblHospitalLayout.Controls.Add(Me.lblRequiredCity, 2, 7)
        Me.tblHospitalLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblHospitalLayout.Location = New System.Drawing.Point(3, 3)
        Me.tblHospitalLayout.Name = "tblHospitalLayout"
        Me.tblHospitalLayout.RowCount = 8
        Me.tblHospitalLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblHospitalLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblHospitalLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblHospitalLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblHospitalLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblHospitalLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblHospitalLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblHospitalLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblHospitalLayout.Size = New System.Drawing.Size(403, 286)
        Me.tblHospitalLayout.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(384, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 57)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "*"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHName
        '
        Me.lblHName.AutoSize = True
        Me.lblHName.Location = New System.Drawing.Point(3, 0)
        Me.lblHName.Name = "lblHName"
        Me.lblHName.Size = New System.Drawing.Size(35, 13)
        Me.lblHName.TabIndex = 0
        Me.lblHName.Text = "Name"
        '
        'lblHAddress1
        '
        Me.lblHAddress1.AutoSize = True
        Me.lblHAddress1.Location = New System.Drawing.Point(3, 28)
        Me.lblHAddress1.Name = "lblHAddress1"
        Me.lblHAddress1.Size = New System.Drawing.Size(51, 13)
        Me.lblHAddress1.TabIndex = 2
        Me.lblHAddress1.Text = "Address1"
        '
        'lblHAddress2
        '
        Me.lblHAddress2.AutoSize = True
        Me.lblHAddress2.Location = New System.Drawing.Point(3, 85)
        Me.lblHAddress2.Name = "lblHAddress2"
        Me.lblHAddress2.Size = New System.Drawing.Size(51, 13)
        Me.lblHAddress2.TabIndex = 4
        Me.lblHAddress2.Text = "Address2"
        '
        'txtHospitalPhone1
        '
        Me.txtHospitalPhone1.Location = New System.Drawing.Point(85, 147)
        Me.txtHospitalPhone1.Margin = New System.Windows.Forms.Padding(5)
        Me.txtHospitalPhone1.MaxLength = 12
        Me.txtHospitalPhone1.Name = "txtHospitalPhone1"
        Me.txtHospitalPhone1.Size = New System.Drawing.Size(292, 20)
        Me.txtHospitalPhone1.TabIndex = 7
        '
        'lblHPhone1
        '
        Me.lblHPhone1.AutoSize = True
        Me.lblHPhone1.Location = New System.Drawing.Point(3, 142)
        Me.lblHPhone1.Name = "lblHPhone1"
        Me.lblHPhone1.Size = New System.Drawing.Size(44, 13)
        Me.lblHPhone1.TabIndex = 6
        Me.lblHPhone1.Text = "Phone1"
        '
        'txtHospitalPhone2
        '
        Me.txtHospitalPhone2.Location = New System.Drawing.Point(85, 175)
        Me.txtHospitalPhone2.Margin = New System.Windows.Forms.Padding(5)
        Me.txtHospitalPhone2.MaxLength = 12
        Me.txtHospitalPhone2.Name = "txtHospitalPhone2"
        Me.txtHospitalPhone2.Size = New System.Drawing.Size(292, 20)
        Me.txtHospitalPhone2.TabIndex = 9
        '
        'lblHPhone2
        '
        Me.lblHPhone2.AutoSize = True
        Me.lblHPhone2.Location = New System.Drawing.Point(3, 170)
        Me.lblHPhone2.Name = "lblHPhone2"
        Me.lblHPhone2.Size = New System.Drawing.Size(44, 13)
        Me.lblHPhone2.TabIndex = 8
        Me.lblHPhone2.Text = "Phone2"
        '
        'txtHospitalAddress1
        '
        Me.txtHospitalAddress1.Location = New System.Drawing.Point(85, 33)
        Me.txtHospitalAddress1.Margin = New System.Windows.Forms.Padding(5)
        Me.txtHospitalAddress1.Multiline = True
        Me.txtHospitalAddress1.Name = "txtHospitalAddress1"
        Me.txtHospitalAddress1.Size = New System.Drawing.Size(292, 41)
        Me.txtHospitalAddress1.TabIndex = 3
        '
        'txtHospitalAddress2
        '
        Me.txtHospitalAddress2.Location = New System.Drawing.Point(85, 90)
        Me.txtHospitalAddress2.Margin = New System.Windows.Forms.Padding(5)
        Me.txtHospitalAddress2.Multiline = True
        Me.txtHospitalAddress2.Name = "txtHospitalAddress2"
        Me.txtHospitalAddress2.Size = New System.Drawing.Size(292, 41)
        Me.txtHospitalAddress2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(384, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRequiredCountry
        '
        Me.lblRequiredCountry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRequiredCountry.ForeColor = System.Drawing.Color.Red
        Me.lblRequiredCountry.Location = New System.Drawing.Point(384, 198)
        Me.lblRequiredCountry.Margin = New System.Windows.Forms.Padding(2, 0, 3, 0)
        Me.lblRequiredCountry.Name = "lblRequiredCountry"
        Me.lblRequiredCountry.Size = New System.Drawing.Size(10, 28)
        Me.lblRequiredCountry.TabIndex = 15
        Me.lblRequiredCountry.Text = "*"
        Me.lblRequiredCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHospitalName
        '
        Me.txtHospitalName.Location = New System.Drawing.Point(85, 5)
        Me.txtHospitalName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtHospitalName.Name = "txtHospitalName"
        Me.txtHospitalName.Size = New System.Drawing.Size(292, 20)
        Me.txtHospitalName.TabIndex = 1
        '
        'lblHCountry
        '
        Me.lblHCountry.AutoSize = True
        Me.lblHCountry.Location = New System.Drawing.Point(3, 198)
        Me.lblHCountry.Name = "lblHCountry"
        Me.lblHCountry.Size = New System.Drawing.Size(43, 13)
        Me.lblHCountry.TabIndex = 16
        Me.lblHCountry.Text = "Country"
        '
        'lblHState
        '
        Me.lblHState.AutoSize = True
        Me.lblHState.Location = New System.Drawing.Point(3, 226)
        Me.lblHState.Name = "lblHState"
        Me.lblHState.Size = New System.Drawing.Size(32, 13)
        Me.lblHState.TabIndex = 17
        Me.lblHState.Text = "State"
        '
        'lblHCity
        '
        Me.lblHCity.AutoSize = True
        Me.lblHCity.Location = New System.Drawing.Point(3, 254)
        Me.lblHCity.Name = "lblHCity"
        Me.lblHCity.Size = New System.Drawing.Size(24, 13)
        Me.lblHCity.TabIndex = 18
        Me.lblHCity.Text = "City"
        '
        'pnlHCountry
        '
        Me.pnlHCountry.Controls.Add(Me.btnHAddCountry)
        Me.pnlHCountry.Controls.Add(Me.comboHositalCountry)
        Me.pnlHCountry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHCountry.Location = New System.Drawing.Point(83, 201)
        Me.pnlHCountry.Name = "pnlHCountry"
        Me.pnlHCountry.Size = New System.Drawing.Size(296, 22)
        Me.pnlHCountry.TabIndex = 19
        '
        'btnHAddCountry
        '
        Me.btnHAddCountry.BackgroundImage = Global.ProLab.My.Resources.Resources.add
        Me.btnHAddCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHAddCountry.Location = New System.Drawing.Point(273, 2)
        Me.btnHAddCountry.Name = "btnHAddCountry"
        Me.btnHAddCountry.Size = New System.Drawing.Size(21, 21)
        Me.btnHAddCountry.TabIndex = 1
        Me.btnHAddCountry.UseVisualStyleBackColor = True
        Me.btnHAddCountry.Visible = False
        '
        'comboHositalCountry
        '
        Me.comboHositalCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboHositalCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboHositalCountry.FormattingEnabled = True
        Me.comboHositalCountry.Location = New System.Drawing.Point(3, 0)
        Me.comboHositalCountry.Name = "comboHositalCountry"
        Me.comboHositalCountry.Size = New System.Drawing.Size(257, 21)
        Me.comboHositalCountry.TabIndex = 0
        '
        'pnlHState
        '
        Me.pnlHState.Controls.Add(Me.btnAddHState)
        Me.pnlHState.Controls.Add(Me.comboHositalState)
        Me.pnlHState.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHState.Location = New System.Drawing.Point(83, 229)
        Me.pnlHState.Name = "pnlHState"
        Me.pnlHState.Size = New System.Drawing.Size(296, 22)
        Me.pnlHState.TabIndex = 20
        '
        'btnAddHState
        '
        Me.btnAddHState.BackgroundImage = Global.ProLab.My.Resources.Resources.add
        Me.btnAddHState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddHState.Location = New System.Drawing.Point(273, 1)
        Me.btnAddHState.Name = "btnAddHState"
        Me.btnAddHState.Size = New System.Drawing.Size(21, 21)
        Me.btnAddHState.TabIndex = 1
        Me.btnAddHState.UseVisualStyleBackColor = True
        Me.btnAddHState.Visible = False
        '
        'comboHositalState
        '
        Me.comboHositalState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboHositalState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboHositalState.FormattingEnabled = True
        Me.comboHositalState.Location = New System.Drawing.Point(4, 1)
        Me.comboHositalState.Name = "comboHositalState"
        Me.comboHositalState.Size = New System.Drawing.Size(257, 21)
        Me.comboHositalState.TabIndex = 0
        '
        'pnlHCity
        '
        Me.pnlHCity.Controls.Add(Me.btnAddHCity)
        Me.pnlHCity.Controls.Add(Me.comboHositalCity)
        Me.pnlHCity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHCity.Location = New System.Drawing.Point(83, 257)
        Me.pnlHCity.Name = "pnlHCity"
        Me.pnlHCity.Size = New System.Drawing.Size(296, 26)
        Me.pnlHCity.TabIndex = 21
        '
        'btnAddHCity
        '
        Me.btnAddHCity.BackgroundImage = Global.ProLab.My.Resources.Resources.add
        Me.btnAddHCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddHCity.Location = New System.Drawing.Point(272, 3)
        Me.btnAddHCity.Name = "btnAddHCity"
        Me.btnAddHCity.Size = New System.Drawing.Size(21, 21)
        Me.btnAddHCity.TabIndex = 1
        Me.btnAddHCity.UseVisualStyleBackColor = True
        Me.btnAddHCity.Visible = False
        '
        'comboHositalCity
        '
        Me.comboHositalCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboHositalCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboHositalCity.FormattingEnabled = True
        Me.comboHositalCity.Location = New System.Drawing.Point(3, 3)
        Me.comboHositalCity.Name = "comboHositalCity"
        Me.comboHositalCity.Size = New System.Drawing.Size(257, 21)
        Me.comboHositalCity.TabIndex = 0
        '
        'lblRequiredState
        '
        Me.lblRequiredState.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRequiredState.AutoSize = True
        Me.lblRequiredState.ForeColor = System.Drawing.Color.Red
        Me.lblRequiredState.Location = New System.Drawing.Point(384, 226)
        Me.lblRequiredState.Margin = New System.Windows.Forms.Padding(2, 0, 3, 0)
        Me.lblRequiredState.Name = "lblRequiredState"
        Me.lblRequiredState.Size = New System.Drawing.Size(11, 28)
        Me.lblRequiredState.TabIndex = 22
        Me.lblRequiredState.Text = "*"
        Me.lblRequiredState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRequiredCity
        '
        Me.lblRequiredCity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRequiredCity.AutoSize = True
        Me.lblRequiredCity.ForeColor = System.Drawing.Color.Red
        Me.lblRequiredCity.Location = New System.Drawing.Point(384, 254)
        Me.lblRequiredCity.Margin = New System.Windows.Forms.Padding(2, 0, 3, 0)
        Me.lblRequiredCity.Name = "lblRequiredCity"
        Me.lblRequiredCity.Size = New System.Drawing.Size(11, 32)
        Me.lblRequiredCity.TabIndex = 23
        Me.lblRequiredCity.Text = "*"
        Me.lblRequiredCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlHospitalButton
        '
        Me.pnlHospitalButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.pnlHospitalButton.Controls.Add(Me.btnHospitalClose)
        Me.pnlHospitalButton.Controls.Add(Me.btnHospitalClear)
        Me.pnlHospitalButton.Controls.Add(Me.btnHospitalDelete)
        Me.pnlHospitalButton.Controls.Add(Me.btnHospitalSave)
        Me.pnlHospitalButton.Location = New System.Drawing.Point(194, 426)
        Me.pnlHospitalButton.Name = "pnlHospitalButton"
        Me.pnlHospitalButton.Size = New System.Drawing.Size(231, 35)
        Me.pnlHospitalButton.TabIndex = 16
        '
        'btnHospitalClose
        '
        Me.btnHospitalClose.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnHospitalClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHospitalClose.ForeColor = System.Drawing.Color.White
        Me.btnHospitalClose.Location = New System.Drawing.Point(171, 3)
        Me.btnHospitalClose.Name = "btnHospitalClose"
        Me.btnHospitalClose.Size = New System.Drawing.Size(56, 30)
        Me.btnHospitalClose.TabIndex = 3
        Me.btnHospitalClose.Text = "&Close"
        Me.btnHospitalClose.UseVisualStyleBackColor = True
        '
        'btnHospitalClear
        '
        Me.btnHospitalClear.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnHospitalClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHospitalClear.ForeColor = System.Drawing.Color.White
        Me.btnHospitalClear.Location = New System.Drawing.Point(115, 3)
        Me.btnHospitalClear.Name = "btnHospitalClear"
        Me.btnHospitalClear.Size = New System.Drawing.Size(56, 30)
        Me.btnHospitalClear.TabIndex = 2
        Me.btnHospitalClear.Text = "C&lear"
        Me.btnHospitalClear.UseVisualStyleBackColor = True
        '
        'btnHospitalDelete
        '
        Me.btnHospitalDelete.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnHospitalDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHospitalDelete.ForeColor = System.Drawing.Color.White
        Me.btnHospitalDelete.Location = New System.Drawing.Point(59, 3)
        Me.btnHospitalDelete.Name = "btnHospitalDelete"
        Me.btnHospitalDelete.Size = New System.Drawing.Size(56, 30)
        Me.btnHospitalDelete.TabIndex = 1
        Me.btnHospitalDelete.Text = "&Delete"
        Me.btnHospitalDelete.UseVisualStyleBackColor = True
        '
        'btnHospitalSave
        '
        Me.btnHospitalSave.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnHospitalSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHospitalSave.ForeColor = System.Drawing.Color.White
        Me.btnHospitalSave.Location = New System.Drawing.Point(3, 3)
        Me.btnHospitalSave.Name = "btnHospitalSave"
        Me.btnHospitalSave.Size = New System.Drawing.Size(56, 30)
        Me.btnHospitalSave.TabIndex = 0
        Me.btnHospitalSave.Text = "&Save"
        Me.btnHospitalSave.UseVisualStyleBackColor = True
        '
        'HospitalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(441, 473)
        Me.Controls.Add(Me.pnlHospitalButton)
        Me.Controls.Add(Me.tabHospital)
        Me.Controls.Add(Me.gbHospital)
        Me.Controls.Add(Me.tblHospitalHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HospitalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hospital"
        Me.tblHospitalHeader.ResumeLayout(False)
        Me.pnlServiceHeader.ResumeLayout(False)
        Me.pnlServiceHeader.PerformLayout()
        Me.gbHospital.ResumeLayout(False)
        Me.gbHospital.PerformLayout()
        Me.tabHospital.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.tblHospitalLayout.ResumeLayout(False)
        Me.tblHospitalLayout.PerformLayout()
        Me.pnlHCountry.ResumeLayout(False)
        Me.pnlHState.ResumeLayout(False)
        Me.pnlHCity.ResumeLayout(False)
        Me.pnlHospitalButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblHospitalHeader As TableLayoutPanel
    Friend WithEvents pnlServiceHeader As Panel
    Friend WithEvents lblHospitalHeader As Label
    Friend WithEvents lblHospitalMode As Label
    Friend WithEvents gbHospital As GroupBox
    Friend WithEvents lblFindHospital As Label
    Friend WithEvents txtFindHospital As TextBox
    Friend WithEvents btnFindHospital As Button
    Friend WithEvents tabHospital As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tblHospitalLayout As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHName As Label
    Friend WithEvents lblHAddress1 As Label
    Friend WithEvents lblHAddress2 As Label
    Friend WithEvents txtHospitalPhone1 As TextBox
    Friend WithEvents lblHPhone1 As Label
    Friend WithEvents txtHospitalPhone2 As TextBox
    Friend WithEvents lblHPhone2 As Label
    Friend WithEvents txtHospitalAddress1 As TextBox
    Friend WithEvents txtHospitalAddress2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRequiredCountry As Label
    Friend WithEvents txtHospitalName As TextBox
    Friend WithEvents lblHCountry As Label
    Friend WithEvents lblHState As Label
    Friend WithEvents lblHCity As Label
    Friend WithEvents pnlHCountry As Panel
    Friend WithEvents comboHositalCountry As ComboBox
    Friend WithEvents btnHAddCountry As Button
    Friend WithEvents pnlHState As Panel
    Friend WithEvents comboHositalState As ComboBox
    Friend WithEvents btnAddHState As Button
    Friend WithEvents pnlHCity As Panel
    Friend WithEvents comboHositalCity As ComboBox
    Friend WithEvents btnAddHCity As Button
    Friend WithEvents pnlHospitalButton As Panel
    Friend WithEvents btnHospitalSave As Button
    Friend WithEvents btnHospitalDelete As Button
    Friend WithEvents btnHospitalClear As Button
    Friend WithEvents btnHospitalClose As Button
    Friend WithEvents lblRequiredState As Label
    Friend WithEvents lblRequiredCity As Label
End Class
