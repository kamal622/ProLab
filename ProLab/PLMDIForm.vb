Imports System.Windows.Forms
Imports ProLab.Core.Common
Imports ProLab.Service.Menu
Imports ProLab.Service

Public Class PLMDIForm
    Private menuService As MenuService

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = Global.System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = Global.System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub PLMDIForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub PLMDIForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure wan't to Exit?", Product_Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Exit Sub
            'Else
            '    End
        End If
        e.Cancel = False
    End Sub

    Private Sub ExitMenu_Click(sender As Object, e As EventArgs) Handles ExitMenu.Click
        Me.Close()
    End Sub

    Private Sub AboutMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMenuItem.Click
        With frmAbout
            '.MdiParent = Me
            .ShowDialog()
            'Call Set_Parentform(Me, Usermanagement_Frm)
        End With
    End Sub

    Private Sub PatientRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim patientfrm As New PatientForm
        If Application.OpenForms().OfType(Of PatientForm).Any Then
            'MsgBox("form is already open")
        Else
            patientfrm.MdiParent = Me
            patientfrm.Show()
        End If
    End Sub

    Private Sub CountryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim countryfrm As New CountryForm
        If Application.OpenForms().OfType(Of CountryForm).Any Then
            'MsgBox("form is already open")
        Else
            countryfrm.MdiParent = Me
            countryfrm.Show()
        End If
    End Sub

    Private Sub StateToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim statefrm As New StateForm
        If Application.OpenForms().OfType(Of StateForm).Any Then
            'MsgBox("form is already open")
        Else
            statefrm.MdiParent = Me
            statefrm.Show()
        End If
    End Sub

    Private Sub CityToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim cityfrm As New CityForm
        If Application.OpenForms().OfType(Of CityForm).Any Then
            'MsgBox("form is already open")
        Else
            cityfrm.MdiParent = Me
            cityfrm.Show()
        End If
    End Sub

    Private Sub PLMDIForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuService = New MenuService()
        TreeViewMain.Nodes.Clear()
        Try
            Call GetAllGroupMenu(TreeViewMain, MenuItemProLab)
            Call GetAllChildMenuOptions(TreeViewMain, MenuItemProLab)
            If Me.TreeViewMain.Nodes.Count > 0 Then
                Me.TreeViewMain.ExpandAll()
                Me.TreeViewMain.TopNode = TreeViewMain.Nodes(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TreeViewMain_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewMain.AfterSelect
        Try
            Call TreeViewSelectionEvent(TreeViewMain, Me)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GetAllGroupMenu(ByRef MenuCntrl As TreeView, Optional ByRef parentMenu As ToolStripMenuItem = Nothing)
        menuService = New MenuService()
        Dim tvRoot As TreeNode
        Dim tvNode As TreeNode
        Dim dr As DataTableReader = Nothing
        Dim Childmenu As ToolStripMenuItem = Nothing
        Dim dtbl As Data.ProLabDB.MenuGroupDataTable = Nothing
        Try
            If menuService.GetAllMenuGroup(dtbl) Then
                tvRoot = TreeViewMain.Nodes.Add("MENUS")
                tvRoot.NodeFont = New System.Drawing.Font("Tahoma", 8, System.Drawing.FontStyle.Bold)
                tvRoot.Name = "G" & "- Root"

                dr = dtbl.CreateDataReader
                With dr
                    While dr.Read
                        tvNode = tvRoot.Nodes.Add(dr.Item(0), dr.Item(1))
                        tvNode.ForeColor = System.Drawing.Color.Maroon
                        tvNode.Name = "G" & dr.Item(0).ToString
                        tvNode.NodeFont = New System.Drawing.Font("Tahoma", 8, System.Drawing.FontStyle.Bold)

                        If Not parentMenu Is Nothing Then
                            Childmenu = New ToolStripMenuItem
                            With Childmenu
                                .Name = dr.Item(0).ToString
                                .Text = dr.Item(1).ToString
                            End With
                            With parentMenu
                                .DropDownItems.Add(Childmenu)
                            End With
                        End If
                    End While
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GetAllChildMenuOptions(ByRef MenuCtrl As TreeView, Optional ByRef parentMenu As ToolStripMenuItem = Nothing)
        menuService = New MenuService()
        Dim tvRoot As TreeNode
        Dim tvNode As TreeNode
        Dim dr As DataTableReader = Nothing
        Dim Childmenu As ToolStripMenuItem = Nothing
        Dim Groupmenu As ToolStripMenuItem = Nothing
        Dim dtbl As Data.ProLabDB.MenuMasterDataTable = Nothing
        Try
            If menuService.GetAllChildMenu(dtbl) Then
                dr = dtbl.CreateDataReader
                With MenuCtrl
                    While dr.Read
                        For i = 0 To .Nodes(0).Nodes.Count - 1
                            If .Nodes(0).Nodes(i).Name = "G" & dr.Item("GroupId").ToString Then
                                tvRoot = .Nodes(0).Nodes(i)
                                tvNode = tvRoot.Nodes.Add(dr.Item("Id"), dr.Item("MenuName"))
                                tvNode.ForeColor = System.Drawing.Color.DarkBlue
                                tvNode.Name = "M" & dr.Item("Id").ToString
                                tvNode.Tag = dr.Item("Formname").ToString

                                tvNode.NodeFont = New System.Drawing.Font("Tahoma", 8, System.Drawing.FontStyle.Regular)
                                .Nodes(0).Nodes(i).Expand()
                                Exit For
                            End If
                        Next

                        If Not parentMenu Is Nothing Then
                            For i = 0 To parentMenu.DropDownItems.Count - 1
                                If parentMenu.DropDownItems(i).Name = dr.Item("GroupId").ToString Then
                                    Groupmenu = parentMenu.DropDownItems(i)
                                    Childmenu = New ToolStripMenuItem
                                    With Childmenu
                                        .Name = dr.Item("Id").ToString
                                        .Text = dr.Item("MenuName").ToString
                                        .Tag = dr.Item("Formname").ToString
                                    End With
                                    Groupmenu.DropDownItems.Add(Childmenu)
                                    AddHandler Childmenu.Click, AddressOf ProLabSelectedMenu_Option
                                    Exit For
                                End If
                            Next
                        End If
                    End While
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProLabSelectedMenu_Option(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            menuService = New MenuService()
            Dim selectMenu As ToolStripItem
            selectMenu = sender

            If selectMenu.Tag = "" Then Exit Sub
            Call ShowChildForm(selectMenu.Tag, Me, Convert.ToInt32(selectMenu.Name))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ShowChildForm(ByVal FormName As String, ByRef masterForm As Form, ByVal MenuId As Integer)
        Try
            Dim objForm As Form
            Dim fullTypeName As String
            Dim formInstanceType As Type
            fullTypeName = "ProLab" & "." & FormName.Trim
            formInstanceType = Type.GetType(fullTypeName, True, True)
            objForm = CType(Activator.CreateInstance(formInstanceType), Form)

            For Each ChildForm As Form In masterForm.MdiChildren
                If ChildForm.Name = objForm.Name Then
                    ChildForm.BringToFront()
                    Exit Sub
                End If
            Next

            objForm.MdiParent = Me
            objForm.Tag = MenuId
            objForm.Show()
            objForm.BringToFront()
            objForm.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub TreeViewMain_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeViewMain.NodeMouseClick
    '    TreeViewSelectionEvent(TreeViewMain)
    'End Sub

    Private Sub TreeViewSelectionEvent(ByRef TreeViewMain As TreeView, ByRef masterForm As Form)
        Try
            Dim MenuId As String = ""
            Dim iMenuId As Integer = 0
            Dim MenuFormName As String = ""
            With TreeViewMain
                Try
                    MenuId = .SelectedNode.Name
                    MenuFormName = .SelectedNode.Tag
                    If MenuFormName Is Nothing Then MenuFormName = ""
                    If MenuFormName.Trim = "" Then Exit Sub
                    MenuFormName = IIf(Strings.Left(MenuFormName, 1) = "\", Strings.Right(MenuFormName, Len(MenuFormName) - 1), MenuFormName)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                If MenuId <> "" Then
                    If Strings.Left(MenuId, 1) = "G" Then
                        MenuId = "G"
                    ElseIf Strings.Left(MenuId, 1) = "M" Then
                        MenuId = Strings.Right(MenuId, Len(MenuId) - 1)
                    End If
                Else
                    MenuId = "G"
                End If

                Call ShowChildForm(MenuFormName, masterForm, Convert.ToInt32(MenuId))
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TreeViewMain_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeViewMain.NodeMouseClick
        Dim Original As TreeNode = e.Node
        TreeViewMain.SelectedNode = Nothing
        TreeViewMain.SelectedNode = Original
    End Sub
End Class
