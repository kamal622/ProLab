<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientForm))
        Me.tblPatientHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPatientMode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tblPictorbox = New System.Windows.Forms.TableLayoutPanel()
        Me.picPatients = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.gbPatientSearchArea = New System.Windows.Forms.GroupBox()
        Me.btnPatientSearch = New System.Windows.Forms.Button()
        Me.txtPatientSearchByMobile = New System.Windows.Forms.TextBox()
        Me.lblPatientSearchById = New System.Windows.Forms.Label()
        Me.tblPatientForm = New System.Windows.Forms.TableLayoutPanel()
        Me.tabPatients = New System.Windows.Forms.TabControl()
        Me.TabPagePatient = New System.Windows.Forms.TabPage()
        Me.tblPatientInformationLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPatFName = New System.Windows.Forms.Label()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.lblPatAddress1 = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.pnlDOB = New System.Windows.Forms.Panel()
        Me.txtPatAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.dtPatDOB = New System.Windows.Forms.DateTimePicker()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.txtPatFName = New System.Windows.Forms.TextBox()
        Me.txtPatAddress1 = New System.Windows.Forms.TextBox()
        Me.pnlCountry = New System.Windows.Forms.Panel()
        Me.btnAddCountry = New System.Windows.Forms.Button()
        Me.comboPatCountry = New System.Windows.Forms.ComboBox()
        Me.pnlCity = New System.Windows.Forms.Panel()
        Me.btnAddCity = New System.Windows.Forms.Button()
        Me.comboPatCity = New System.Windows.Forms.ComboBox()
        Me.txtPatMobile = New System.Windows.Forms.TextBox()
        Me.txtPatEmail = New System.Windows.Forms.TextBox()
        Me.txtPatLName = New System.Windows.Forms.TextBox()
        Me.txtPatAddress2 = New System.Windows.Forms.TextBox()
        Me.txtPatZipcode = New System.Windows.Forms.TextBox()
        Me.txtPatLandLine = New System.Windows.Forms.TextBox()
        Me.txtPatOccupation = New System.Windows.Forms.TextBox()
        Me.lblPatLName = New System.Windows.Forms.Label()
        Me.lblPatAddress2 = New System.Windows.Forms.Label()
        Me.pnlState = New System.Windows.Forms.Panel()
        Me.btnAddState = New System.Windows.Forms.Button()
        Me.comboPatState = New System.Windows.Forms.ComboBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblLandline = New System.Windows.Forms.Label()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.pnlGender = New System.Windows.Forms.Panel()
        Me.rbtnFemale = New System.Windows.Forms.RadioButton()
        Me.rbtnMale = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlPatientbtn = New System.Windows.Forms.Panel()
        Me.btnPatClose = New System.Windows.Forms.Button()
        Me.btnPatClear = New System.Windows.Forms.Button()
        Me.btnPatDelete = New System.Windows.Forms.Button()
        Me.btnPatSave = New System.Windows.Forms.Button()
        Me.tblPatientHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tblPictorbox.SuspendLayout()
        CType(Me.picPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.gbPatientSearchArea.SuspendLayout()
        Me.tblPatientForm.SuspendLayout()
        Me.tabPatients.SuspendLayout()
        Me.TabPagePatient.SuspendLayout()
        Me.tblPatientInformationLayout.SuspendLayout()
        Me.pnlDOB.SuspendLayout()
        Me.pnlCountry.SuspendLayout()
        Me.pnlCity.SuspendLayout()
        Me.pnlState.SuspendLayout()
        Me.pnlGender.SuspendLayout()
        Me.pnlPatientbtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblPatientHeader
        '
        Me.tblPatientHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tblPatientHeader.ColumnCount = 1
        Me.tblPatientHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPatientHeader.Controls.Add(Me.Panel1, 0, 0)
        Me.tblPatientHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblPatientHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblPatientHeader.Name = "tblPatientHeader"
        Me.tblPatientHeader.RowCount = 1
        Me.tblPatientHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPatientHeader.Size = New System.Drawing.Size(797, 40)
        Me.tblPatientHeader.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblPatientMode)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(791, 34)
        Me.Panel1.TabIndex = 0
        '
        'lblPatientMode
        '
        Me.lblPatientMode.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPatientMode.AutoSize = True
        Me.lblPatientMode.BackColor = System.Drawing.Color.Maroon
        Me.lblPatientMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPatientMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientMode.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPatientMode.Location = New System.Drawing.Point(690, 6)
        Me.lblPatientMode.Name = "lblPatientMode"
        Me.lblPatientMode.Size = New System.Drawing.Size(76, 19)
        Me.lblPatientMode.TabIndex = 4
        Me.lblPatientMode.Text = "New Mode"
        Me.lblPatientMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient Information"
        '
        'tblPictorbox
        '
        Me.tblPictorbox.BackColor = System.Drawing.Color.Transparent
        Me.tblPictorbox.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.tblPictorbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tblPictorbox.ColumnCount = 1
        Me.tblPictorbox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPictorbox.Controls.Add(Me.picPatients, 0, 0)
        Me.tblPictorbox.Dock = System.Windows.Forms.DockStyle.Left
        Me.tblPictorbox.Location = New System.Drawing.Point(0, 40)
        Me.tblPictorbox.Name = "tblPictorbox"
        Me.tblPictorbox.RowCount = 1
        Me.tblPictorbox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPictorbox.Size = New System.Drawing.Size(155, 408)
        Me.tblPictorbox.TabIndex = 1
        '
        'picPatients
        '
        Me.picPatients.BackColor = System.Drawing.Color.Transparent
        Me.picPatients.BackgroundImage = CType(resources.GetObject("picPatients.BackgroundImage"), System.Drawing.Image)
        Me.picPatients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picPatients.Location = New System.Drawing.Point(3, 3)
        Me.picPatients.Name = "picPatients"
        Me.picPatients.Size = New System.Drawing.Size(149, 402)
        Me.picPatients.TabIndex = 0
        Me.picPatients.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.gbPatientSearchArea, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(155, 40)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(642, 65)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'gbPatientSearchArea
        '
        Me.gbPatientSearchArea.BackColor = System.Drawing.Color.Transparent
        Me.gbPatientSearchArea.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.gbPatientSearchArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbPatientSearchArea.Controls.Add(Me.btnPatientSearch)
        Me.gbPatientSearchArea.Controls.Add(Me.txtPatientSearchByMobile)
        Me.gbPatientSearchArea.Controls.Add(Me.lblPatientSearchById)
        Me.gbPatientSearchArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbPatientSearchArea.Location = New System.Drawing.Point(5, 5)
        Me.gbPatientSearchArea.Margin = New System.Windows.Forms.Padding(5)
        Me.gbPatientSearchArea.Name = "gbPatientSearchArea"
        Me.gbPatientSearchArea.Padding = New System.Windows.Forms.Padding(0)
        Me.gbPatientSearchArea.Size = New System.Drawing.Size(632, 55)
        Me.gbPatientSearchArea.TabIndex = 0
        Me.gbPatientSearchArea.TabStop = False
        Me.gbPatientSearchArea.Text = "Search"
        '
        'btnPatientSearch
        '
        Me.btnPatientSearch.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnPatientSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPatientSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatientSearch.ForeColor = System.Drawing.Color.White
        Me.btnPatientSearch.Location = New System.Drawing.Point(294, 20)
        Me.btnPatientSearch.Name = "btnPatientSearch"
        Me.btnPatientSearch.Size = New System.Drawing.Size(29, 20)
        Me.btnPatientSearch.TabIndex = 3
        Me.btnPatientSearch.Text = "F2"
        Me.btnPatientSearch.UseVisualStyleBackColor = True
        '
        'txtPatientSearchByMobile
        '
        Me.txtPatientSearchByMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientSearchByMobile.Location = New System.Drawing.Point(93, 20)
        Me.txtPatientSearchByMobile.MaxLength = 12
        Me.txtPatientSearchByMobile.Name = "txtPatientSearchByMobile"
        Me.txtPatientSearchByMobile.Size = New System.Drawing.Size(195, 20)
        Me.txtPatientSearchByMobile.TabIndex = 2
        '
        'lblPatientSearchById
        '
        Me.lblPatientSearchById.AutoSize = True
        Me.lblPatientSearchById.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientSearchById.Location = New System.Drawing.Point(2, 20)
        Me.lblPatientSearchById.Name = "lblPatientSearchById"
        Me.lblPatientSearchById.Size = New System.Drawing.Size(88, 13)
        Me.lblPatientSearchById.TabIndex = 1
        Me.lblPatientSearchById.Text = "Patient MobileNo"
        '
        'tblPatientForm
        '
        Me.tblPatientForm.BackgroundImage = CType(resources.GetObject("tblPatientForm.BackgroundImage"), System.Drawing.Image)
        Me.tblPatientForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tblPatientForm.ColumnCount = 1
        Me.tblPatientForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPatientForm.Controls.Add(Me.tabPatients, 0, 0)
        Me.tblPatientForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblPatientForm.Location = New System.Drawing.Point(155, 105)
        Me.tblPatientForm.Name = "tblPatientForm"
        Me.tblPatientForm.RowCount = 1
        Me.tblPatientForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblPatientForm.Size = New System.Drawing.Size(642, 296)
        Me.tblPatientForm.TabIndex = 3
        '
        'tabPatients
        '
        Me.tabPatients.Controls.Add(Me.TabPagePatient)
        Me.tabPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPatients.Location = New System.Drawing.Point(3, 3)
        Me.tabPatients.Name = "tabPatients"
        Me.tabPatients.SelectedIndex = 0
        Me.tabPatients.Size = New System.Drawing.Size(636, 290)
        Me.tabPatients.TabIndex = 0
        '
        'TabPagePatient
        '
        Me.TabPagePatient.BackgroundImage = CType(resources.GetObject("TabPagePatient.BackgroundImage"), System.Drawing.Image)
        Me.TabPagePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPagePatient.Controls.Add(Me.tblPatientInformationLayout)
        Me.TabPagePatient.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePatient.Name = "TabPagePatient"
        Me.TabPagePatient.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePatient.Size = New System.Drawing.Size(628, 264)
        Me.TabPagePatient.TabIndex = 0
        Me.TabPagePatient.Text = "Personal Information"
        Me.TabPagePatient.UseVisualStyleBackColor = True
        '
        'tblPatientInformationLayout
        '
        Me.tblPatientInformationLayout.ColumnCount = 6
        Me.tblPatientInformationLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.62768!))
        Me.tblPatientInformationLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.13387!))
        Me.tblPatientInformationLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.997453!))
        Me.tblPatientInformationLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.62768!))
        Me.tblPatientInformationLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.61588!))
        Me.tblPatientInformationLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.997453!))
        Me.tblPatientInformationLayout.Controls.Add(Me.Label9, 2, 1)
        Me.tblPatientInformationLayout.Controls.Add(Me.lblPatFName, 0, 0)
        Me.tblPatientInformationLayout.Controls.Add(Me.lblDob, 0, 6)
        Me.tblPatientInformationLayout.Controls.Add(Me.lblPatAddress1, 0, 1)
        Me.tblPatientInformationLayout.Controls.Add(Me.lblCountry, 0, 2)
        Me.tblPatientInformationLayout.Controls.Add(Me.lblCity, 0, 3)
        Me.tblPatientInformationLayout.Controls.Add(Me.pnlDOB, 1, 6)
        Me.tblPatientInformationLayout.Controls.Add(Me.lblEmail, 0, 5)
        Me.tblPatientInformationLayout.Controls.Add(Me.lblMobile, 0, 4)
        Me.tblPatientInformationLayout.Controls.Add(Me.txtPatFName, 1, 0)
        Me.tblPatientInformationLayout.Controls.Add(Me.txtPatAddress1, 1, 1)
        Me.tblPatientInformationLayout.Controls.Add(Me.pnlCountry, 1, 2)
        Me.tblPatientInformationLayout.Controls.Add(Me.pnlCity, 1, 3)
        Me.tblPatientInformationLayout.Controls.Add(Me.txtPatMobile, 1, 4)
        Me.tblPatientInformationLayout.Controls.Add(Me.txtPatEmail, 1, 5)
        Me.tblPatientInformationLayout.Controls.Add(Me.txtPatLName, 4, 0)
        Me.tblPatientInformationLayout.Controls.Add(Me.txtPatAddress2, 4, 1)
        Me.tblPatientInformationLayout.Controls.Add(Me.txtPatZipcode, 4, 3)
        Me.tblPatientInformationLayout.Controls.Add(Me.txtPatLandLine, 4, 4)
        Me.tblPatientInformationLayout.Controls.Add(Me.txtPatOccupation, 4, 5)
        Me.tblPatientInformationLayout.Controls.Add(Me.lblPatLName, 3, 0)
        Me.tblPatientInformationLayout.Controls.Add(Me.lblPatAddress2, 3, 1)
        Me.tblPatientInformationLayout.Controls.Add(Me.pnlState, 4, 2)
        Me.tblPatientInformationLayout.Controls.Add(Me.lblState, 3, 2)
        Me.tblPatientInformationLayout.Controls.Add(Me.lblLandline, 3, 4)
        Me.tblPatientInformationLayout.Controls.Add(Me.lblOccupation, 3, 5)
        Me.tblPatientInformationLayout.Controls.Add(Me.pnlGender, 4, 6)
        Me.tblPatientInformationLayout.Controls.Add(Me.Label4, 2, 3)
        Me.tblPatientInformationLayout.Controls.Add(Me.Label7, 5, 2)
        Me.tblPatientInformationLayout.Controls.Add(Me.Label8, 5, 0)
        Me.tblPatientInformationLayout.Controls.Add(Me.Label2, 2, 0)
        Me.tblPatientInformationLayout.Controls.Add(Me.Label3, 2, 2)
        Me.tblPatientInformationLayout.Controls.Add(Me.lblZipCode, 3, 3)
        Me.tblPatientInformationLayout.Controls.Add(Me.Label5, 3, 6)
        Me.tblPatientInformationLayout.Controls.Add(Me.Label6, 5, 6)
        Me.tblPatientInformationLayout.Controls.Add(Me.Label11, 2, 6)
        Me.tblPatientInformationLayout.Controls.Add(Me.Label10, 2, 4)
        Me.tblPatientInformationLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblPatientInformationLayout.Location = New System.Drawing.Point(3, 3)
        Me.tblPatientInformationLayout.Name = "tblPatientInformationLayout"
        Me.tblPatientInformationLayout.RowCount = 7
        Me.tblPatientInformationLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82117!))
        Me.tblPatientInformationLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07811!))
        Me.tblPatientInformationLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82117!))
        Me.tblPatientInformationLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82117!))
        Me.tblPatientInformationLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82117!))
        Me.tblPatientInformationLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82117!))
        Me.tblPatientInformationLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.81604!))
        Me.tblPatientInformationLayout.Size = New System.Drawing.Size(622, 258)
        Me.tblPatientInformationLayout.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(286, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 59)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "*"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPatFName
        '
        Me.lblPatFName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPatFName.Location = New System.Drawing.Point(3, 0)
        Me.lblPatFName.Name = "lblPatFName"
        Me.lblPatFName.Padding = New System.Windows.Forms.Padding(5)
        Me.lblPatFName.Size = New System.Drawing.Size(78, 33)
        Me.lblPatFName.TabIndex = 2
        Me.lblPatFName.Text = "First Name"
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Location = New System.Drawing.Point(3, 224)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Padding = New System.Windows.Forms.Padding(5)
        Me.lblDob.Size = New System.Drawing.Size(40, 23)
        Me.lblDob.TabIndex = 18
        Me.lblDob.Text = "DOB"
        '
        'lblPatAddress1
        '
        Me.lblPatAddress1.AutoSize = True
        Me.lblPatAddress1.Location = New System.Drawing.Point(3, 33)
        Me.lblPatAddress1.Name = "lblPatAddress1"
        Me.lblPatAddress1.Padding = New System.Windows.Forms.Padding(5)
        Me.lblPatAddress1.Size = New System.Drawing.Size(61, 23)
        Me.lblPatAddress1.TabIndex = 7
        Me.lblPatAddress1.Text = "Address1"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(3, 92)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Padding = New System.Windows.Forms.Padding(5)
        Me.lblCountry.Size = New System.Drawing.Size(53, 23)
        Me.lblCountry.TabIndex = 10
        Me.lblCountry.Text = "Country"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(3, 125)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Padding = New System.Windows.Forms.Padding(5)
        Me.lblCity.Size = New System.Drawing.Size(34, 23)
        Me.lblCity.TabIndex = 12
        Me.lblCity.Text = "City"
        '
        'pnlDOB
        '
        Me.pnlDOB.Controls.Add(Me.txtPatAge)
        Me.pnlDOB.Controls.Add(Me.lblAge)
        Me.pnlDOB.Controls.Add(Me.dtPatDOB)
        Me.pnlDOB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDOB.Location = New System.Drawing.Point(87, 227)
        Me.pnlDOB.Name = "pnlDOB"
        Me.pnlDOB.Size = New System.Drawing.Size(193, 28)
        Me.pnlDOB.TabIndex = 32
        '
        'txtPatAge
        '
        Me.txtPatAge.Location = New System.Drawing.Point(146, 4)
        Me.txtPatAge.Name = "txtPatAge"
        Me.txtPatAge.Size = New System.Drawing.Size(45, 20)
        Me.txtPatAge.TabIndex = 2
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(120, 7)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 1
        Me.lblAge.Text = "Age"
        '
        'dtPatDOB
        '
        Me.dtPatDOB.CustomFormat = "dd-MM-yyyy"
        Me.dtPatDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPatDOB.Location = New System.Drawing.Point(2, 3)
        Me.dtPatDOB.Name = "dtPatDOB"
        Me.dtPatDOB.Size = New System.Drawing.Size(112, 20)
        Me.dtPatDOB.TabIndex = 0
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(3, 191)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Padding = New System.Windows.Forms.Padding(5)
        Me.lblEmail.Size = New System.Drawing.Size(42, 23)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "Email"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(3, 158)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Padding = New System.Windows.Forms.Padding(5)
        Me.lblMobile.Size = New System.Drawing.Size(48, 23)
        Me.lblMobile.TabIndex = 14
        Me.lblMobile.Text = "Mobile"
        '
        'txtPatFName
        '
        Me.txtPatFName.Location = New System.Drawing.Point(89, 5)
        Me.txtPatFName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPatFName.Name = "txtPatFName"
        Me.txtPatFName.Size = New System.Drawing.Size(189, 20)
        Me.txtPatFName.TabIndex = 20
        '
        'txtPatAddress1
        '
        Me.txtPatAddress1.Location = New System.Drawing.Point(89, 38)
        Me.txtPatAddress1.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPatAddress1.Multiline = True
        Me.txtPatAddress1.Name = "txtPatAddress1"
        Me.txtPatAddress1.Size = New System.Drawing.Size(189, 49)
        Me.txtPatAddress1.TabIndex = 22
        '
        'pnlCountry
        '
        Me.pnlCountry.Controls.Add(Me.btnAddCountry)
        Me.pnlCountry.Controls.Add(Me.comboPatCountry)
        Me.pnlCountry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCountry.Location = New System.Drawing.Point(87, 95)
        Me.pnlCountry.Name = "pnlCountry"
        Me.pnlCountry.Size = New System.Drawing.Size(193, 27)
        Me.pnlCountry.TabIndex = 24
        '
        'btnAddCountry
        '
        Me.btnAddCountry.BackgroundImage = Global.ProLab.My.Resources.Resources.add
        Me.btnAddCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddCountry.Location = New System.Drawing.Point(170, 4)
        Me.btnAddCountry.Name = "btnAddCountry"
        Me.btnAddCountry.Size = New System.Drawing.Size(21, 21)
        Me.btnAddCountry.TabIndex = 1
        Me.btnAddCountry.UseVisualStyleBackColor = True
        Me.btnAddCountry.Visible = False
        '
        'comboPatCountry
        '
        Me.comboPatCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboPatCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboPatCountry.FormattingEnabled = True
        Me.comboPatCountry.Location = New System.Drawing.Point(2, 4)
        Me.comboPatCountry.Margin = New System.Windows.Forms.Padding(5)
        Me.comboPatCountry.Name = "comboPatCountry"
        Me.comboPatCountry.Size = New System.Drawing.Size(163, 21)
        Me.comboPatCountry.TabIndex = 0
        '
        'pnlCity
        '
        Me.pnlCity.Controls.Add(Me.btnAddCity)
        Me.pnlCity.Controls.Add(Me.comboPatCity)
        Me.pnlCity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCity.Location = New System.Drawing.Point(87, 128)
        Me.pnlCity.Name = "pnlCity"
        Me.pnlCity.Size = New System.Drawing.Size(193, 27)
        Me.pnlCity.TabIndex = 26
        '
        'btnAddCity
        '
        Me.btnAddCity.BackgroundImage = Global.ProLab.My.Resources.Resources.add
        Me.btnAddCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddCity.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddCity.Location = New System.Drawing.Point(170, 2)
        Me.btnAddCity.Name = "btnAddCity"
        Me.btnAddCity.Size = New System.Drawing.Size(21, 21)
        Me.btnAddCity.TabIndex = 1
        Me.btnAddCity.UseVisualStyleBackColor = True
        Me.btnAddCity.Visible = False
        '
        'comboPatCity
        '
        Me.comboPatCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboPatCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboPatCity.FormattingEnabled = True
        Me.comboPatCity.Location = New System.Drawing.Point(2, 2)
        Me.comboPatCity.Margin = New System.Windows.Forms.Padding(5)
        Me.comboPatCity.Name = "comboPatCity"
        Me.comboPatCity.Size = New System.Drawing.Size(163, 21)
        Me.comboPatCity.TabIndex = 0
        '
        'txtPatMobile
        '
        Me.txtPatMobile.Location = New System.Drawing.Point(89, 163)
        Me.txtPatMobile.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPatMobile.MaxLength = 12
        Me.txtPatMobile.Name = "txtPatMobile"
        Me.txtPatMobile.Size = New System.Drawing.Size(189, 20)
        Me.txtPatMobile.TabIndex = 28
        '
        'txtPatEmail
        '
        Me.txtPatEmail.Location = New System.Drawing.Point(89, 196)
        Me.txtPatEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPatEmail.MaxLength = 50
        Me.txtPatEmail.Name = "txtPatEmail"
        Me.txtPatEmail.Size = New System.Drawing.Size(189, 20)
        Me.txtPatEmail.TabIndex = 30
        '
        'txtPatLName
        '
        Me.txtPatLName.Location = New System.Drawing.Point(396, 5)
        Me.txtPatLName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPatLName.Name = "txtPatLName"
        Me.txtPatLName.Size = New System.Drawing.Size(192, 20)
        Me.txtPatLName.TabIndex = 21
        '
        'txtPatAddress2
        '
        Me.txtPatAddress2.Location = New System.Drawing.Point(396, 38)
        Me.txtPatAddress2.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPatAddress2.Multiline = True
        Me.txtPatAddress2.Name = "txtPatAddress2"
        Me.txtPatAddress2.Size = New System.Drawing.Size(192, 49)
        Me.txtPatAddress2.TabIndex = 23
        '
        'txtPatZipcode
        '
        Me.txtPatZipcode.Location = New System.Drawing.Point(396, 130)
        Me.txtPatZipcode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPatZipcode.MaxLength = 6
        Me.txtPatZipcode.Name = "txtPatZipcode"
        Me.txtPatZipcode.Size = New System.Drawing.Size(192, 20)
        Me.txtPatZipcode.TabIndex = 27
        '
        'txtPatLandLine
        '
        Me.txtPatLandLine.Location = New System.Drawing.Point(396, 163)
        Me.txtPatLandLine.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPatLandLine.MaxLength = 10
        Me.txtPatLandLine.Name = "txtPatLandLine"
        Me.txtPatLandLine.Size = New System.Drawing.Size(192, 20)
        Me.txtPatLandLine.TabIndex = 29
        '
        'txtPatOccupation
        '
        Me.txtPatOccupation.Location = New System.Drawing.Point(396, 196)
        Me.txtPatOccupation.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPatOccupation.MaxLength = 30
        Me.txtPatOccupation.Name = "txtPatOccupation"
        Me.txtPatOccupation.Size = New System.Drawing.Size(192, 20)
        Me.txtPatOccupation.TabIndex = 31
        '
        'lblPatLName
        '
        Me.lblPatLName.AutoSize = True
        Me.lblPatLName.Location = New System.Drawing.Point(310, 0)
        Me.lblPatLName.Name = "lblPatLName"
        Me.lblPatLName.Padding = New System.Windows.Forms.Padding(5)
        Me.lblPatLName.Size = New System.Drawing.Size(68, 23)
        Me.lblPatLName.TabIndex = 8
        Me.lblPatLName.Text = "Last Name"
        '
        'lblPatAddress2
        '
        Me.lblPatAddress2.AutoSize = True
        Me.lblPatAddress2.Location = New System.Drawing.Point(310, 33)
        Me.lblPatAddress2.Name = "lblPatAddress2"
        Me.lblPatAddress2.Padding = New System.Windows.Forms.Padding(5)
        Me.lblPatAddress2.Size = New System.Drawing.Size(61, 23)
        Me.lblPatAddress2.TabIndex = 9
        Me.lblPatAddress2.Text = "Address2"
        '
        'pnlState
        '
        Me.pnlState.Controls.Add(Me.btnAddState)
        Me.pnlState.Controls.Add(Me.comboPatState)
        Me.pnlState.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlState.Location = New System.Drawing.Point(394, 95)
        Me.pnlState.Name = "pnlState"
        Me.pnlState.Size = New System.Drawing.Size(196, 27)
        Me.pnlState.TabIndex = 25
        '
        'btnAddState
        '
        Me.btnAddState.BackgroundImage = Global.ProLab.My.Resources.Resources.add
        Me.btnAddState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddState.Location = New System.Drawing.Point(173, 2)
        Me.btnAddState.Name = "btnAddState"
        Me.btnAddState.Size = New System.Drawing.Size(21, 21)
        Me.btnAddState.TabIndex = 1
        Me.btnAddState.UseVisualStyleBackColor = True
        Me.btnAddState.Visible = False
        '
        'comboPatState
        '
        Me.comboPatState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboPatState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboPatState.FormattingEnabled = True
        Me.comboPatState.Location = New System.Drawing.Point(4, 3)
        Me.comboPatState.Name = "comboPatState"
        Me.comboPatState.Size = New System.Drawing.Size(163, 21)
        Me.comboPatState.TabIndex = 0
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(310, 92)
        Me.lblState.Name = "lblState"
        Me.lblState.Padding = New System.Windows.Forms.Padding(5)
        Me.lblState.Size = New System.Drawing.Size(42, 23)
        Me.lblState.TabIndex = 11
        Me.lblState.Text = "State"
        '
        'lblLandline
        '
        Me.lblLandline.AutoSize = True
        Me.lblLandline.Location = New System.Drawing.Point(310, 158)
        Me.lblLandline.Name = "lblLandline"
        Me.lblLandline.Padding = New System.Windows.Forms.Padding(5)
        Me.lblLandline.Size = New System.Drawing.Size(61, 23)
        Me.lblLandline.TabIndex = 15
        Me.lblLandline.Text = "LandLine"
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Location = New System.Drawing.Point(310, 191)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Padding = New System.Windows.Forms.Padding(5)
        Me.lblOccupation.Size = New System.Drawing.Size(72, 23)
        Me.lblOccupation.TabIndex = 17
        Me.lblOccupation.Text = "Occupation"
        '
        'pnlGender
        '
        Me.pnlGender.Controls.Add(Me.rbtnFemale)
        Me.pnlGender.Controls.Add(Me.rbtnMale)
        Me.pnlGender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGender.Location = New System.Drawing.Point(394, 227)
        Me.pnlGender.Name = "pnlGender"
        Me.pnlGender.Size = New System.Drawing.Size(196, 28)
        Me.pnlGender.TabIndex = 33
        '
        'rbtnFemale
        '
        Me.rbtnFemale.AutoSize = True
        Me.rbtnFemale.Location = New System.Drawing.Point(108, 3)
        Me.rbtnFemale.Name = "rbtnFemale"
        Me.rbtnFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbtnFemale.TabIndex = 1
        Me.rbtnFemale.TabStop = True
        Me.rbtnFemale.Text = "Female"
        Me.rbtnFemale.UseVisualStyleBackColor = True
        '
        'rbtnMale
        '
        Me.rbtnMale.AutoSize = True
        Me.rbtnMale.Location = New System.Drawing.Point(2, 4)
        Me.rbtnMale.Name = "rbtnMale"
        Me.rbtnMale.Size = New System.Drawing.Size(48, 17)
        Me.rbtnMale.TabIndex = 0
        Me.rbtnMale.TabStop = True
        Me.rbtnMale.Text = "Male"
        Me.rbtnMale.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(286, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 33)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "*"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(596, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 33)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "*"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(596, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 33)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "*"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(286, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(9, 33)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "*"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(286, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 33)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "*"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Location = New System.Drawing.Point(310, 125)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Padding = New System.Windows.Forms.Padding(5)
        Me.lblZipCode.Size = New System.Drawing.Size(57, 23)
        Me.lblZipCode.TabIndex = 13
        Me.lblZipCode.Text = "ZipCode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(310, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5)
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Occupation"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(596, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 33)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "*"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(286, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(9, 33)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "*"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(286, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(9, 33)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "*"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlPatientbtn
        '
        Me.pnlPatientbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.pnlPatientbtn.Controls.Add(Me.btnPatClose)
        Me.pnlPatientbtn.Controls.Add(Me.btnPatClear)
        Me.pnlPatientbtn.Controls.Add(Me.btnPatDelete)
        Me.pnlPatientbtn.Controls.Add(Me.btnPatSave)
        Me.pnlPatientbtn.Location = New System.Drawing.Point(559, 407)
        Me.pnlPatientbtn.Name = "pnlPatientbtn"
        Me.pnlPatientbtn.Size = New System.Drawing.Size(231, 35)
        Me.pnlPatientbtn.TabIndex = 4
        '
        'btnPatClose
        '
        Me.btnPatClose.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnPatClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatClose.ForeColor = System.Drawing.Color.White
        Me.btnPatClose.Location = New System.Drawing.Point(171, 3)
        Me.btnPatClose.Name = "btnPatClose"
        Me.btnPatClose.Size = New System.Drawing.Size(56, 30)
        Me.btnPatClose.TabIndex = 3
        Me.btnPatClose.Text = "&Close"
        Me.btnPatClose.UseVisualStyleBackColor = True
        '
        'btnPatClear
        '
        Me.btnPatClear.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnPatClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatClear.ForeColor = System.Drawing.Color.White
        Me.btnPatClear.Location = New System.Drawing.Point(115, 3)
        Me.btnPatClear.Name = "btnPatClear"
        Me.btnPatClear.Size = New System.Drawing.Size(56, 30)
        Me.btnPatClear.TabIndex = 2
        Me.btnPatClear.Text = "C&lear"
        Me.btnPatClear.UseVisualStyleBackColor = True
        '
        'btnPatDelete
        '
        Me.btnPatDelete.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnPatDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatDelete.ForeColor = System.Drawing.Color.White
        Me.btnPatDelete.Location = New System.Drawing.Point(59, 3)
        Me.btnPatDelete.Name = "btnPatDelete"
        Me.btnPatDelete.Size = New System.Drawing.Size(56, 30)
        Me.btnPatDelete.TabIndex = 1
        Me.btnPatDelete.Text = "&Delete"
        Me.btnPatDelete.UseVisualStyleBackColor = True
        '
        'btnPatSave
        '
        Me.btnPatSave.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnPatSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatSave.ForeColor = System.Drawing.Color.White
        Me.btnPatSave.Location = New System.Drawing.Point(3, 3)
        Me.btnPatSave.Name = "btnPatSave"
        Me.btnPatSave.Size = New System.Drawing.Size(56, 30)
        Me.btnPatSave.TabIndex = 0
        Me.btnPatSave.Text = "&Save"
        Me.btnPatSave.UseVisualStyleBackColor = True
        '
        'PatientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(797, 448)
        Me.Controls.Add(Me.pnlPatientbtn)
        Me.Controls.Add(Me.tblPatientForm)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.tblPictorbox)
        Me.Controls.Add(Me.tblPatientHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PatientForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Information"
        Me.tblPatientHeader.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tblPictorbox.ResumeLayout(False)
        CType(Me.picPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.gbPatientSearchArea.ResumeLayout(False)
        Me.gbPatientSearchArea.PerformLayout()
        Me.tblPatientForm.ResumeLayout(False)
        Me.tabPatients.ResumeLayout(False)
        Me.TabPagePatient.ResumeLayout(False)
        Me.tblPatientInformationLayout.ResumeLayout(False)
        Me.tblPatientInformationLayout.PerformLayout()
        Me.pnlDOB.ResumeLayout(False)
        Me.pnlDOB.PerformLayout()
        Me.pnlCountry.ResumeLayout(False)
        Me.pnlCity.ResumeLayout(False)
        Me.pnlState.ResumeLayout(False)
        Me.pnlGender.ResumeLayout(False)
        Me.pnlGender.PerformLayout()
        Me.pnlPatientbtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblPatientHeader As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tblPictorbox As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents tblPatientForm As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPatientMode As Label
    Friend WithEvents tabPatients As TabControl
    Friend WithEvents TabPagePatient As TabPage
    Friend WithEvents tblPatientInformationLayout As TableLayoutPanel
    Friend WithEvents lblPatAddress1 As Label
    Friend WithEvents lblPatLName As Label
    Friend WithEvents lblPatAddress2 As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblZipCode As Label
    Friend WithEvents lblMobile As Label
    Friend WithEvents lblLandline As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblOccupation As Label
    Friend WithEvents lblDob As Label
    Friend WithEvents txtPatAddress2 As TextBox
    Friend WithEvents txtPatAddress1 As TextBox
    Friend WithEvents txtPatLName As TextBox
    Friend WithEvents pnlCountry As Panel
    Friend WithEvents comboPatCountry As ComboBox
    Friend WithEvents btnAddCountry As Button
    Friend WithEvents pnlState As Panel
    Friend WithEvents comboPatState As ComboBox
    Friend WithEvents btnAddState As Button
    Friend WithEvents pnlCity As Panel
    Friend WithEvents comboPatCity As ComboBox
    Friend WithEvents btnAddCity As Button
    Friend WithEvents txtPatZipcode As TextBox
    Friend WithEvents txtPatMobile As TextBox
    Friend WithEvents txtPatLandLine As TextBox
    Friend WithEvents txtPatEmail As TextBox
    Friend WithEvents txtPatOccupation As TextBox
    Friend WithEvents pnlDOB As Panel
    Friend WithEvents dtPatDOB As DateTimePicker
    Friend WithEvents lblAge As Label
    Friend WithEvents txtPatAge As TextBox
    Friend WithEvents pnlGender As Panel
    Friend WithEvents rbtnMale As RadioButton
    Friend WithEvents rbtnFemale As RadioButton
    Friend WithEvents pnlPatientbtn As Panel
    Friend WithEvents btnPatSave As Button
    Friend WithEvents btnPatClose As Button
    Friend WithEvents btnPatClear As Button
    Friend WithEvents btnPatDelete As Button
    Friend WithEvents picPatients As PictureBox
    Friend WithEvents txtPatFName As TextBox
    Friend WithEvents lblPatFName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents gbPatientSearchArea As GroupBox
    Friend WithEvents btnPatientSearch As Button
    Friend WithEvents txtPatientSearchByMobile As TextBox
    Friend WithEvents lblPatientSearchById As Label
End Class
