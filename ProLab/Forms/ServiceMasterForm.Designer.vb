<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServiceMasterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServiceMasterForm))
        Me.tblServiceHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlServiceHeader = New System.Windows.Forms.Panel()
        Me.lblServiceMode = New System.Windows.Forms.Label()
        Me.lblService = New System.Windows.Forms.Label()
        Me.gpService = New System.Windows.Forms.GroupBox()
        Me.btnFindService = New System.Windows.Forms.Button()
        Me.txtFindService = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabServiceMaster = New System.Windows.Forms.TabControl()
        Me.tabService = New System.Windows.Forms.TabPage()
        Me.tblService = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlServiceCategory = New System.Windows.Forms.Panel()
        Me.btnAddServiceCategory = New System.Windows.Forms.Button()
        Me.ComboServiceCategory = New System.Windows.Forms.ComboBox()
        Me.txtServiceName = New System.Windows.Forms.TextBox()
        Me.txtServiceAmount = New System.Windows.Forms.TextBox()
        Me.txtServiceDescription = New System.Windows.Forms.TextBox()
        Me.pnlRadioBtn = New System.Windows.Forms.Panel()
        Me.rbtnAppointNo = New System.Windows.Forms.RadioButton()
        Me.rbtnAppoitYes = New System.Windows.Forms.RadioButton()
        Me.chkServiceActive = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnServiceClose = New System.Windows.Forms.Button()
        Me.btnServiceClear = New System.Windows.Forms.Button()
        Me.btnServiceDelete = New System.Windows.Forms.Button()
        Me.btnServiceSave = New System.Windows.Forms.Button()
        Me.tblServiceHeader.SuspendLayout()
        Me.pnlServiceHeader.SuspendLayout()
        Me.gpService.SuspendLayout()
        Me.tabServiceMaster.SuspendLayout()
        Me.tabService.SuspendLayout()
        Me.tblService.SuspendLayout()
        Me.pnlServiceCategory.SuspendLayout()
        Me.pnlRadioBtn.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.tblServiceHeader.RowCount = 1
        Me.tblServiceHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblServiceHeader.Size = New System.Drawing.Size(496, 40)
        Me.tblServiceHeader.TabIndex = 0
        '
        'pnlServiceHeader
        '
        Me.pnlServiceHeader.Controls.Add(Me.lblServiceMode)
        Me.pnlServiceHeader.Controls.Add(Me.lblService)
        Me.pnlServiceHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlServiceHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlServiceHeader.Name = "pnlServiceHeader"
        Me.pnlServiceHeader.Size = New System.Drawing.Size(490, 34)
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
        Me.lblService.Size = New System.Drawing.Size(62, 17)
        Me.lblService.TabIndex = 0
        Me.lblService.Text = "Service"
        '
        'gpService
        '
        Me.gpService.BackColor = System.Drawing.Color.Transparent
        Me.gpService.Controls.Add(Me.btnFindService)
        Me.gpService.Controls.Add(Me.txtFindService)
        Me.gpService.Controls.Add(Me.Label2)
        Me.gpService.Location = New System.Drawing.Point(14, 46)
        Me.gpService.Name = "gpService"
        Me.gpService.Size = New System.Drawing.Size(470, 58)
        Me.gpService.TabIndex = 1
        Me.gpService.TabStop = False
        Me.gpService.Text = "Search"
        '
        'btnFindService
        '
        Me.btnFindService.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnFindService.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindService.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindService.ForeColor = System.Drawing.Color.White
        Me.btnFindService.Location = New System.Drawing.Point(435, 24)
        Me.btnFindService.Name = "btnFindService"
        Me.btnFindService.Size = New System.Drawing.Size(29, 20)
        Me.btnFindService.TabIndex = 2
        Me.btnFindService.Text = "F2"
        Me.btnFindService.UseVisualStyleBackColor = True
        '
        'txtFindService
        '
        Me.txtFindService.Location = New System.Drawing.Point(133, 24)
        Me.txtFindService.Name = "txtFindService"
        Me.txtFindService.Size = New System.Drawing.Size(293, 20)
        Me.txtFindService.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'tabServiceMaster
        '
        Me.tabServiceMaster.Controls.Add(Me.tabService)
        Me.tabServiceMaster.Location = New System.Drawing.Point(14, 110)
        Me.tabServiceMaster.Name = "tabServiceMaster"
        Me.tabServiceMaster.SelectedIndex = 0
        Me.tabServiceMaster.Size = New System.Drawing.Size(470, 227)
        Me.tabServiceMaster.TabIndex = 5
        '
        'tabService
        '
        Me.tabService.BackgroundImage = CType(resources.GetObject("tabService.BackgroundImage"), System.Drawing.Image)
        Me.tabService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabService.Controls.Add(Me.tblService)
        Me.tabService.Location = New System.Drawing.Point(4, 22)
        Me.tabService.Name = "tabService"
        Me.tabService.Padding = New System.Windows.Forms.Padding(3)
        Me.tabService.Size = New System.Drawing.Size(462, 201)
        Me.tabService.TabIndex = 1
        Me.tabService.Text = "Service"
        Me.tabService.UseVisualStyleBackColor = True
        '
        'tblService
        '
        Me.tblService.ColumnCount = 3
        Me.tblService.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.59145!))
        Me.tblService.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.93031!))
        Me.tblService.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.478251!))
        Me.tblService.Controls.Add(Me.Label10, 2, 2)
        Me.tblService.Controls.Add(Me.Label9, 2, 1)
        Me.tblService.Controls.Add(Me.Label4, 0, 1)
        Me.tblService.Controls.Add(Me.Label7, 0, 5)
        Me.tblService.Controls.Add(Me.Label5, 0, 2)
        Me.tblService.Controls.Add(Me.Label6, 0, 3)
        Me.tblService.Controls.Add(Me.lblCategory, 2, 0)
        Me.tblService.Controls.Add(Me.Label11, 2, 4)
        Me.tblService.Controls.Add(Me.Label12, 2, 5)
        Me.tblService.Controls.Add(Me.Label3, 0, 0)
        Me.tblService.Controls.Add(Me.Label8, 0, 4)
        Me.tblService.Controls.Add(Me.pnlServiceCategory, 1, 0)
        Me.tblService.Controls.Add(Me.txtServiceName, 1, 1)
        Me.tblService.Controls.Add(Me.txtServiceAmount, 1, 2)
        Me.tblService.Controls.Add(Me.txtServiceDescription, 1, 3)
        Me.tblService.Controls.Add(Me.pnlRadioBtn, 1, 4)
        Me.tblService.Controls.Add(Me.chkServiceActive, 1, 5)
        Me.tblService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblService.Location = New System.Drawing.Point(3, 3)
        Me.tblService.Name = "tblService"
        Me.tblService.RowCount = 6
        Me.tblService.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.12903!))
        Me.tblService.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.12903!))
        Me.tblService.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.12903!))
        Me.tblService.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.35484!))
        Me.tblService.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.12903!))
        Me.tblService.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.12903!))
        Me.tblService.Size = New System.Drawing.Size(456, 195)
        Me.tblService.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(433, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 31)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "*"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(433, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 31)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "*"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Service Name"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(5, 166)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Active"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 67)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(5, 98)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Description"
        '
        'lblCategory
        '
        Me.lblCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCategory.AutoSize = True
        Me.lblCategory.ForeColor = System.Drawing.Color.Red
        Me.lblCategory.Location = New System.Drawing.Point(433, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(11, 31)
        Me.lblCategory.TabIndex = 12
        Me.lblCategory.Text = "*"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(433, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 31)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "*"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(433, 161)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 34)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "*"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Service Category"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(5, 135)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Appoinment Needed"
        '
        'pnlServiceCategory
        '
        Me.pnlServiceCategory.Controls.Add(Me.btnAddServiceCategory)
        Me.pnlServiceCategory.Controls.Add(Me.ComboServiceCategory)
        Me.pnlServiceCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlServiceCategory.Location = New System.Drawing.Point(121, 0)
        Me.pnlServiceCategory.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlServiceCategory.Name = "pnlServiceCategory"
        Me.pnlServiceCategory.Size = New System.Drawing.Size(309, 31)
        Me.pnlServiceCategory.TabIndex = 17
        '
        'btnAddServiceCategory
        '
        Me.btnAddServiceCategory.BackgroundImage = Global.ProLab.My.Resources.Resources.add
        Me.btnAddServiceCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddServiceCategory.Location = New System.Drawing.Point(281, 4)
        Me.btnAddServiceCategory.Name = "btnAddServiceCategory"
        Me.btnAddServiceCategory.Size = New System.Drawing.Size(21, 21)
        Me.btnAddServiceCategory.TabIndex = 1
        Me.btnAddServiceCategory.UseVisualStyleBackColor = True
        '
        'ComboServiceCategory
        '
        Me.ComboServiceCategory.FormattingEnabled = True
        Me.ComboServiceCategory.Location = New System.Drawing.Point(3, 5)
        Me.ComboServiceCategory.Name = "ComboServiceCategory"
        Me.ComboServiceCategory.Size = New System.Drawing.Size(274, 21)
        Me.ComboServiceCategory.TabIndex = 0
        '
        'txtServiceName
        '
        Me.txtServiceName.Location = New System.Drawing.Point(124, 34)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.Size = New System.Drawing.Size(299, 20)
        Me.txtServiceName.TabIndex = 18
        '
        'txtServiceAmount
        '
        Me.txtServiceAmount.Location = New System.Drawing.Point(124, 65)
        Me.txtServiceAmount.Name = "txtServiceAmount"
        Me.txtServiceAmount.Size = New System.Drawing.Size(299, 20)
        Me.txtServiceAmount.TabIndex = 19
        '
        'txtServiceDescription
        '
        Me.txtServiceDescription.Location = New System.Drawing.Point(124, 96)
        Me.txtServiceDescription.Multiline = True
        Me.txtServiceDescription.Name = "txtServiceDescription"
        Me.txtServiceDescription.Size = New System.Drawing.Size(299, 31)
        Me.txtServiceDescription.TabIndex = 20
        '
        'pnlRadioBtn
        '
        Me.pnlRadioBtn.Controls.Add(Me.rbtnAppointNo)
        Me.pnlRadioBtn.Controls.Add(Me.rbtnAppoitYes)
        Me.pnlRadioBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRadioBtn.Location = New System.Drawing.Point(121, 130)
        Me.pnlRadioBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlRadioBtn.Name = "pnlRadioBtn"
        Me.pnlRadioBtn.Size = New System.Drawing.Size(309, 31)
        Me.pnlRadioBtn.TabIndex = 21
        '
        'rbtnAppointNo
        '
        Me.rbtnAppointNo.AutoSize = True
        Me.rbtnAppointNo.Checked = True
        Me.rbtnAppointNo.Location = New System.Drawing.Point(71, 5)
        Me.rbtnAppointNo.Name = "rbtnAppointNo"
        Me.rbtnAppointNo.Size = New System.Drawing.Size(39, 17)
        Me.rbtnAppointNo.TabIndex = 1
        Me.rbtnAppointNo.TabStop = True
        Me.rbtnAppointNo.Text = "No"
        Me.rbtnAppointNo.UseVisualStyleBackColor = True
        '
        'rbtnAppoitYes
        '
        Me.rbtnAppoitYes.AutoSize = True
        Me.rbtnAppoitYes.Location = New System.Drawing.Point(5, 3)
        Me.rbtnAppoitYes.Name = "rbtnAppoitYes"
        Me.rbtnAppoitYes.Size = New System.Drawing.Size(43, 17)
        Me.rbtnAppoitYes.TabIndex = 0
        Me.rbtnAppoitYes.Text = "Yes"
        Me.rbtnAppoitYes.UseVisualStyleBackColor = True
        '
        'chkServiceActive
        '
        Me.chkServiceActive.AutoSize = True
        Me.chkServiceActive.Checked = True
        Me.chkServiceActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkServiceActive.Location = New System.Drawing.Point(124, 164)
        Me.chkServiceActive.Name = "chkServiceActive"
        Me.chkServiceActive.Size = New System.Drawing.Size(15, 14)
        Me.chkServiceActive.TabIndex = 22
        Me.chkServiceActive.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnServiceClose)
        Me.Panel1.Controls.Add(Me.btnServiceClear)
        Me.Panel1.Controls.Add(Me.btnServiceDelete)
        Me.Panel1.Controls.Add(Me.btnServiceSave)
        Me.Panel1.Location = New System.Drawing.Point(251, 344)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 35)
        Me.Panel1.TabIndex = 6
        '
        'btnServiceClose
        '
        Me.btnServiceClose.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnServiceClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceClose.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnServiceClose.Location = New System.Drawing.Point(171, 2)
        Me.btnServiceClose.Name = "btnServiceClose"
        Me.btnServiceClose.Size = New System.Drawing.Size(56, 30)
        Me.btnServiceClose.TabIndex = 3
        Me.btnServiceClose.Text = "&Close"
        Me.btnServiceClose.UseVisualStyleBackColor = True
        '
        'btnServiceClear
        '
        Me.btnServiceClear.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnServiceClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceClear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnServiceClear.Location = New System.Drawing.Point(115, 3)
        Me.btnServiceClear.Name = "btnServiceClear"
        Me.btnServiceClear.Size = New System.Drawing.Size(56, 30)
        Me.btnServiceClear.TabIndex = 2
        Me.btnServiceClear.Text = "C&lear"
        Me.btnServiceClear.UseVisualStyleBackColor = True
        '
        'btnServiceDelete
        '
        Me.btnServiceDelete.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnServiceDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceDelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnServiceDelete.Location = New System.Drawing.Point(59, 3)
        Me.btnServiceDelete.Name = "btnServiceDelete"
        Me.btnServiceDelete.Size = New System.Drawing.Size(56, 30)
        Me.btnServiceDelete.TabIndex = 1
        Me.btnServiceDelete.Text = "&Delete"
        Me.btnServiceDelete.UseVisualStyleBackColor = True
        '
        'btnServiceSave
        '
        Me.btnServiceSave.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnServiceSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceSave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnServiceSave.Location = New System.Drawing.Point(3, 3)
        Me.btnServiceSave.Name = "btnServiceSave"
        Me.btnServiceSave.Size = New System.Drawing.Size(56, 30)
        Me.btnServiceSave.TabIndex = 0
        Me.btnServiceSave.Text = "&Save"
        Me.btnServiceSave.UseVisualStyleBackColor = True
        '
        'ServiceMasterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(496, 393)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tabServiceMaster)
        Me.Controls.Add(Me.gpService)
        Me.Controls.Add(Me.tblServiceHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ServiceMasterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Service"
        Me.tblServiceHeader.ResumeLayout(False)
        Me.pnlServiceHeader.ResumeLayout(False)
        Me.pnlServiceHeader.PerformLayout()
        Me.gpService.ResumeLayout(False)
        Me.gpService.PerformLayout()
        Me.tabServiceMaster.ResumeLayout(False)
        Me.tabService.ResumeLayout(False)
        Me.tblService.ResumeLayout(False)
        Me.tblService.PerformLayout()
        Me.pnlServiceCategory.ResumeLayout(False)
        Me.pnlRadioBtn.ResumeLayout(False)
        Me.pnlRadioBtn.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblServiceHeader As TableLayoutPanel
    Friend WithEvents pnlServiceHeader As Panel
    Friend WithEvents lblService As Label
    Friend WithEvents lblServiceMode As Label
    Friend WithEvents gpService As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFindService As TextBox
    Friend WithEvents btnFindService As Button
    Friend WithEvents tabServiceMaster As TabControl
    Friend WithEvents tabService As TabPage
    Friend WithEvents tblService As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents pnlServiceCategory As Panel
    Friend WithEvents ComboServiceCategory As ComboBox
    Friend WithEvents btnAddServiceCategory As Button
    Friend WithEvents txtServiceName As TextBox
    Friend WithEvents txtServiceAmount As TextBox
    Friend WithEvents txtServiceDescription As TextBox
    Friend WithEvents pnlRadioBtn As Panel
    Friend WithEvents rbtnAppoitYes As RadioButton
    Friend WithEvents rbtnAppointNo As RadioButton
    Friend WithEvents chkServiceActive As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnServiceSave As Button
    Friend WithEvents btnServiceDelete As Button
    Friend WithEvents btnServiceClear As Button
    Friend WithEvents btnServiceClose As Button
End Class
