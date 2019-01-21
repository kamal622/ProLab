<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DoctorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorForm))
        Me.tblDoctorHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlDoctorHeader = New System.Windows.Forms.Panel()
        Me.lblDoctorMode = New System.Windows.Forms.Label()
        Me.lblDoctorHeader = New System.Windows.Forms.Label()
        Me.gbHospitalSearch = New System.Windows.Forms.GroupBox()
        Me.btnFindDoctor = New System.Windows.Forms.Button()
        Me.txtFIndDoctor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlDoctorbtn = New System.Windows.Forms.Panel()
        Me.btnDoctorClose = New System.Windows.Forms.Button()
        Me.btnDoctorClear = New System.Windows.Forms.Button()
        Me.btnDoctorDelete = New System.Windows.Forms.Button()
        Me.btnDoctorSave = New System.Windows.Forms.Button()
        Me.TabPageDoctor = New System.Windows.Forms.TabPage()
        Me.tblDoctorLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDRLName = New System.Windows.Forms.Label()
        Me.txtDoctorFname = New System.Windows.Forms.TextBox()
        Me.lblDoctorLName = New System.Windows.Forms.Label()
        Me.txtDoctorLName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDRFname = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.pnlDoctorHospital = New System.Windows.Forms.Panel()
        Me.btnAddHospital = New System.Windows.Forms.Button()
        Me.comboDoctroHospital = New System.Windows.Forms.ComboBox()
        Me.tabDoctor = New System.Windows.Forms.TabControl()
        Me.tblDoctorHeader.SuspendLayout()
        Me.pnlDoctorHeader.SuspendLayout()
        Me.gbHospitalSearch.SuspendLayout()
        Me.pnlDoctorbtn.SuspendLayout()
        Me.TabPageDoctor.SuspendLayout()
        Me.tblDoctorLayout.SuspendLayout()
        Me.pnlDoctorHospital.SuspendLayout()
        Me.tabDoctor.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblDoctorHeader
        '
        Me.tblDoctorHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tblDoctorHeader.ColumnCount = 1
        Me.tblDoctorHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDoctorHeader.Controls.Add(Me.pnlDoctorHeader, 0, 0)
        Me.tblDoctorHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblDoctorHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblDoctorHeader.Name = "tblDoctorHeader"
        Me.tblDoctorHeader.RowCount = 1
        Me.tblDoctorHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblDoctorHeader.Size = New System.Drawing.Size(413, 40)
        Me.tblDoctorHeader.TabIndex = 0
        '
        'pnlDoctorHeader
        '
        Me.pnlDoctorHeader.Controls.Add(Me.lblDoctorMode)
        Me.pnlDoctorHeader.Controls.Add(Me.lblDoctorHeader)
        Me.pnlDoctorHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDoctorHeader.Location = New System.Drawing.Point(3, 3)
        Me.pnlDoctorHeader.Name = "pnlDoctorHeader"
        Me.pnlDoctorHeader.Size = New System.Drawing.Size(407, 34)
        Me.pnlDoctorHeader.TabIndex = 0
        '
        'lblDoctorMode
        '
        Me.lblDoctorMode.AutoSize = True
        Me.lblDoctorMode.BackColor = System.Drawing.Color.Maroon
        Me.lblDoctorMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDoctorMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoctorMode.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDoctorMode.Location = New System.Drawing.Point(311, 9)
        Me.lblDoctorMode.Name = "lblDoctorMode"
        Me.lblDoctorMode.Size = New System.Drawing.Size(80, 19)
        Me.lblDoctorMode.TabIndex = 1
        Me.lblDoctorMode.Text = "New  Mode"
        '
        'lblDoctorHeader
        '
        Me.lblDoctorHeader.AutoSize = True
        Me.lblDoctorHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoctorHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDoctorHeader.Location = New System.Drawing.Point(8, 9)
        Me.lblDoctorHeader.Name = "lblDoctorHeader"
        Me.lblDoctorHeader.Size = New System.Drawing.Size(56, 17)
        Me.lblDoctorHeader.TabIndex = 0
        Me.lblDoctorHeader.Text = "Doctor"
        '
        'gbHospitalSearch
        '
        Me.gbHospitalSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbHospitalSearch.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.gbHospitalSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbHospitalSearch.Controls.Add(Me.btnFindDoctor)
        Me.gbHospitalSearch.Controls.Add(Me.txtFIndDoctor)
        Me.gbHospitalSearch.Controls.Add(Me.Label2)
        Me.gbHospitalSearch.Location = New System.Drawing.Point(10, 53)
        Me.gbHospitalSearch.Name = "gbHospitalSearch"
        Me.gbHospitalSearch.Size = New System.Drawing.Size(396, 62)
        Me.gbHospitalSearch.TabIndex = 1
        Me.gbHospitalSearch.TabStop = False
        Me.gbHospitalSearch.Text = "Search"
        '
        'btnFindDoctor
        '
        Me.btnFindDoctor.BackColor = System.Drawing.Color.Transparent
        Me.btnFindDoctor.BackgroundImage = Global.ProLab.My.Resources.Resources.F2_Button
        Me.btnFindDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFindDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindDoctor.ForeColor = System.Drawing.Color.White
        Me.btnFindDoctor.Location = New System.Drawing.Point(356, 31)
        Me.btnFindDoctor.Name = "btnFindDoctor"
        Me.btnFindDoctor.Size = New System.Drawing.Size(29, 20)
        Me.btnFindDoctor.TabIndex = 2
        Me.btnFindDoctor.Text = "F2"
        Me.btnFindDoctor.UseVisualStyleBackColor = False
        '
        'txtFIndDoctor
        '
        Me.txtFIndDoctor.Location = New System.Drawing.Point(88, 31)
        Me.txtFIndDoctor.Name = "txtFIndDoctor"
        Me.txtFIndDoctor.Size = New System.Drawing.Size(262, 20)
        Me.txtFIndDoctor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(4, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'pnlDoctorbtn
        '
        Me.pnlDoctorbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.pnlDoctorbtn.Controls.Add(Me.btnDoctorClose)
        Me.pnlDoctorbtn.Controls.Add(Me.btnDoctorClear)
        Me.pnlDoctorbtn.Controls.Add(Me.btnDoctorDelete)
        Me.pnlDoctorbtn.Controls.Add(Me.btnDoctorSave)
        Me.pnlDoctorbtn.Location = New System.Drawing.Point(171, 267)
        Me.pnlDoctorbtn.Name = "pnlDoctorbtn"
        Me.pnlDoctorbtn.Size = New System.Drawing.Size(231, 35)
        Me.pnlDoctorbtn.TabIndex = 5
        '
        'btnDoctorClose
        '
        Me.btnDoctorClose.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnDoctorClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctorClose.ForeColor = System.Drawing.Color.White
        Me.btnDoctorClose.Location = New System.Drawing.Point(171, 3)
        Me.btnDoctorClose.Name = "btnDoctorClose"
        Me.btnDoctorClose.Size = New System.Drawing.Size(56, 30)
        Me.btnDoctorClose.TabIndex = 3
        Me.btnDoctorClose.Text = "&Close"
        Me.btnDoctorClose.UseVisualStyleBackColor = True
        '
        'btnDoctorClear
        '
        Me.btnDoctorClear.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnDoctorClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctorClear.ForeColor = System.Drawing.Color.White
        Me.btnDoctorClear.Location = New System.Drawing.Point(115, 3)
        Me.btnDoctorClear.Name = "btnDoctorClear"
        Me.btnDoctorClear.Size = New System.Drawing.Size(56, 30)
        Me.btnDoctorClear.TabIndex = 2
        Me.btnDoctorClear.Text = "C&lear"
        Me.btnDoctorClear.UseVisualStyleBackColor = True
        '
        'btnDoctorDelete
        '
        Me.btnDoctorDelete.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnDoctorDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctorDelete.ForeColor = System.Drawing.Color.White
        Me.btnDoctorDelete.Location = New System.Drawing.Point(59, 3)
        Me.btnDoctorDelete.Name = "btnDoctorDelete"
        Me.btnDoctorDelete.Size = New System.Drawing.Size(56, 30)
        Me.btnDoctorDelete.TabIndex = 1
        Me.btnDoctorDelete.Text = "&Delete"
        Me.btnDoctorDelete.UseVisualStyleBackColor = True
        '
        'btnDoctorSave
        '
        Me.btnDoctorSave.BackgroundImage = Global.ProLab.My.Resources.Resources.Button_Bkg
        Me.btnDoctorSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctorSave.ForeColor = System.Drawing.Color.White
        Me.btnDoctorSave.Location = New System.Drawing.Point(3, 3)
        Me.btnDoctorSave.Name = "btnDoctorSave"
        Me.btnDoctorSave.Size = New System.Drawing.Size(56, 30)
        Me.btnDoctorSave.TabIndex = 0
        Me.btnDoctorSave.Text = "&Save"
        Me.btnDoctorSave.UseVisualStyleBackColor = True
        '
        'TabPageDoctor
        '
        Me.TabPageDoctor.BackColor = System.Drawing.Color.Transparent
        Me.TabPageDoctor.BackgroundImage = CType(resources.GetObject("TabPageDoctor.BackgroundImage"), System.Drawing.Image)
        Me.TabPageDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPageDoctor.Controls.Add(Me.tblDoctorLayout)
        Me.TabPageDoctor.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDoctor.Name = "TabPageDoctor"
        Me.TabPageDoctor.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDoctor.Size = New System.Drawing.Size(388, 118)
        Me.TabPageDoctor.TabIndex = 0
        Me.TabPageDoctor.Text = "Doctor"
        '
        'tblDoctorLayout
        '
        Me.tblDoctorLayout.ColumnCount = 3
        Me.tblDoctorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblDoctorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.34555!))
        Me.tblDoctorLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.759162!))
        Me.tblDoctorLayout.Controls.Add(Me.lblDRLName, 2, 1)
        Me.tblDoctorLayout.Controls.Add(Me.txtDoctorFname, 1, 0)
        Me.tblDoctorLayout.Controls.Add(Me.lblDoctorLName, 0, 1)
        Me.tblDoctorLayout.Controls.Add(Me.txtDoctorLName, 1, 1)
        Me.tblDoctorLayout.Controls.Add(Me.Label1, 0, 2)
        Me.tblDoctorLayout.Controls.Add(Me.lblDRFname, 2, 0)
        Me.tblDoctorLayout.Controls.Add(Me.lblFirstName, 0, 0)
        Me.tblDoctorLayout.Controls.Add(Me.pnlDoctorHospital, 1, 2)
        Me.tblDoctorLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDoctorLayout.Location = New System.Drawing.Point(3, 3)
        Me.tblDoctorLayout.Name = "tblDoctorLayout"
        Me.tblDoctorLayout.RowCount = 3
        Me.tblDoctorLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblDoctorLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblDoctorLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblDoctorLayout.Size = New System.Drawing.Size(382, 112)
        Me.tblDoctorLayout.TabIndex = 2
        '
        'lblDRLName
        '
        Me.lblDRLName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDRLName.ForeColor = System.Drawing.Color.Red
        Me.lblDRLName.Location = New System.Drawing.Point(362, 37)
        Me.lblDRLName.Name = "lblDRLName"
        Me.lblDRLName.Size = New System.Drawing.Size(10, 37)
        Me.lblDRLName.TabIndex = 7
        Me.lblDRLName.Text = "*"
        Me.lblDRLName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDoctorFname
        '
        Me.txtDoctorFname.Location = New System.Drawing.Point(81, 5)
        Me.txtDoctorFname.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDoctorFname.Name = "txtDoctorFname"
        Me.txtDoctorFname.Size = New System.Drawing.Size(273, 20)
        Me.txtDoctorFname.TabIndex = 1
        '
        'lblDoctorLName
        '
        Me.lblDoctorLName.Location = New System.Drawing.Point(5, 42)
        Me.lblDoctorLName.Margin = New System.Windows.Forms.Padding(5)
        Me.lblDoctorLName.Name = "lblDoctorLName"
        Me.lblDoctorLName.Size = New System.Drawing.Size(58, 13)
        Me.lblDoctorLName.TabIndex = 2
        Me.lblDoctorLName.Text = "Last Name"
        '
        'txtDoctorLName
        '
        Me.txtDoctorLName.Location = New System.Drawing.Point(81, 42)
        Me.txtDoctorLName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDoctorLName.Name = "txtDoctorLName"
        Me.txtDoctorLName.Size = New System.Drawing.Size(273, 20)
        Me.txtDoctorLName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hospital"
        '
        'lblDRFname
        '
        Me.lblDRFname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDRFname.ForeColor = System.Drawing.Color.Red
        Me.lblDRFname.Location = New System.Drawing.Point(362, 0)
        Me.lblDRFname.Name = "lblDRFname"
        Me.lblDRFname.Size = New System.Drawing.Size(10, 37)
        Me.lblDRFname.TabIndex = 6
        Me.lblDRFname.Text = "*"
        Me.lblDRFname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(5, 5)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(5)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name"
        '
        'pnlDoctorHospital
        '
        Me.pnlDoctorHospital.Controls.Add(Me.btnAddHospital)
        Me.pnlDoctorHospital.Controls.Add(Me.comboDoctroHospital)
        Me.pnlDoctorHospital.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDoctorHospital.Location = New System.Drawing.Point(79, 77)
        Me.pnlDoctorHospital.Name = "pnlDoctorHospital"
        Me.pnlDoctorHospital.Size = New System.Drawing.Size(277, 32)
        Me.pnlDoctorHospital.TabIndex = 9
        '
        'btnAddHospital
        '
        Me.btnAddHospital.BackgroundImage = Global.ProLab.My.Resources.Resources.add
        Me.btnAddHospital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddHospital.Location = New System.Drawing.Point(253, 5)
        Me.btnAddHospital.Name = "btnAddHospital"
        Me.btnAddHospital.Size = New System.Drawing.Size(21, 21)
        Me.btnAddHospital.TabIndex = 6
        Me.btnAddHospital.UseVisualStyleBackColor = True
        '
        'comboDoctroHospital
        '
        Me.comboDoctroHospital.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboDoctroHospital.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboDoctroHospital.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboDoctroHospital.FormattingEnabled = True
        Me.comboDoctroHospital.Location = New System.Drawing.Point(2, 5)
        Me.comboDoctroHospital.Margin = New System.Windows.Forms.Padding(5)
        Me.comboDoctroHospital.Name = "comboDoctroHospital"
        Me.comboDoctroHospital.Size = New System.Drawing.Size(244, 21)
        Me.comboDoctroHospital.TabIndex = 5
        '
        'tabDoctor
        '
        Me.tabDoctor.Controls.Add(Me.TabPageDoctor)
        Me.tabDoctor.Location = New System.Drawing.Point(10, 121)
        Me.tabDoctor.Name = "tabDoctor"
        Me.tabDoctor.SelectedIndex = 0
        Me.tabDoctor.Size = New System.Drawing.Size(396, 144)
        Me.tabDoctor.TabIndex = 4
        '
        'DoctorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProLab.My.Resources.Resources.LeftGradiant
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(413, 308)
        Me.Controls.Add(Me.pnlDoctorbtn)
        Me.Controls.Add(Me.tabDoctor)
        Me.Controls.Add(Me.gbHospitalSearch)
        Me.Controls.Add(Me.tblDoctorHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DoctorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor"
        Me.tblDoctorHeader.ResumeLayout(False)
        Me.pnlDoctorHeader.ResumeLayout(False)
        Me.pnlDoctorHeader.PerformLayout()
        Me.gbHospitalSearch.ResumeLayout(False)
        Me.gbHospitalSearch.PerformLayout()
        Me.pnlDoctorbtn.ResumeLayout(False)
        Me.TabPageDoctor.ResumeLayout(False)
        Me.tblDoctorLayout.ResumeLayout(False)
        Me.tblDoctorLayout.PerformLayout()
        Me.pnlDoctorHospital.ResumeLayout(False)
        Me.tabDoctor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblDoctorHeader As TableLayoutPanel
    Friend WithEvents pnlDoctorHeader As Panel
    Friend WithEvents lblDoctorHeader As Label
    Friend WithEvents lblDoctorMode As Label
    Friend WithEvents gbHospitalSearch As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFIndDoctor As TextBox
    Friend WithEvents btnFindDoctor As Button
    Friend WithEvents pnlDoctorbtn As Panel
    Friend WithEvents btnDoctorSave As Button
    Friend WithEvents btnDoctorClose As Button
    Friend WithEvents btnDoctorClear As Button
    Friend WithEvents btnDoctorDelete As Button
    Friend WithEvents TabPageDoctor As TabPage
    Friend WithEvents tblDoctorLayout As TableLayoutPanel
    Friend WithEvents lblDRLName As Label
    Friend WithEvents txtDoctorFname As TextBox
    Friend WithEvents lblDoctorLName As Label
    Friend WithEvents txtDoctorLName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDRFname As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents pnlDoctorHospital As Panel
    Friend WithEvents btnAddHospital As Button
    Friend WithEvents comboDoctroHospital As ComboBox
    Friend WithEvents tabDoctor As TabControl
End Class
