﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_000_User
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_000_User))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpProfile = New System.Windows.Forms.GroupBox()
        Me.txtuserId = New System.Windows.Forms.TextBox()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtVerify = New System.Windows.Forms.TextBox()
        Me.cboGroup = New System.Windows.Forms.ComboBox()
        Me.chkIsActive = New System.Windows.Forms.CheckBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCountSub = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgRights = New System.Windows.Forms.DataGridView()
        Me.colMenuID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFormName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCanAdd = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cntxtrights = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CkeckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UncheckAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.colCanEdit = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colCanDelete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colCanView = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colCanPrint = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colCheckAll = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colUncheckAll = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgList = New System.Windows.Forms.DataGridView()
        Me.colClientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colClientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmpName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpList = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.LabelCount = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpProfile.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRights, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cntxtrights.SuspendLayout()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpList.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpProfile
        '
        Me.grpProfile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProfile.BackColor = System.Drawing.Color.Transparent
        Me.grpProfile.Controls.Add(Me.txtuserId)
        Me.grpProfile.Controls.Add(Me.txtEmpName)
        Me.grpProfile.Controls.Add(Me.txtUsername)
        Me.grpProfile.Controls.Add(Me.txtPassword)
        Me.grpProfile.Controls.Add(Me.txtVerify)
        Me.grpProfile.Controls.Add(Me.cboGroup)
        Me.grpProfile.Controls.Add(Me.chkIsActive)
        Me.grpProfile.Controls.Add(Me.btnBrowse)
        Me.grpProfile.Controls.Add(Me.Panel2)
        Me.grpProfile.Controls.Add(Me.picPhoto)
        Me.grpProfile.Controls.Add(Me.btnRemove)
        Me.grpProfile.Controls.Add(Me.btnAdd)
        Me.grpProfile.Controls.Add(Me.dgRights)
        Me.grpProfile.Controls.Add(Me.Label6)
        Me.grpProfile.Controls.Add(Me.Label5)
        Me.grpProfile.Controls.Add(Me.Label4)
        Me.grpProfile.Controls.Add(Me.Label3)
        Me.grpProfile.Controls.Add(Me.Label2)
        Me.grpProfile.Controls.Add(Me.Label1)
        Me.grpProfile.Location = New System.Drawing.Point(3, 4)
        Me.grpProfile.Name = "grpProfile"
        Me.grpProfile.Size = New System.Drawing.Size(626, 392)
        Me.grpProfile.TabIndex = 3
        Me.grpProfile.TabStop = False
        Me.grpProfile.Text = "Profile:"
        '
        'txtuserId
        '
        Me.txtuserId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtuserId.Location = New System.Drawing.Point(102, 23)
        Me.txtuserId.Name = "txtuserId"
        Me.txtuserId.Size = New System.Drawing.Size(228, 20)
        Me.txtuserId.TabIndex = 85
        '
        'txtEmpName
        '
        Me.txtEmpName.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmpName.Location = New System.Drawing.Point(102, 46)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(228, 20)
        Me.txtEmpName.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(102, 72)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(228, 20)
        Me.txtUsername.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(102, 98)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(228, 20)
        Me.txtPassword.TabIndex = 7
        '
        'txtVerify
        '
        Me.txtVerify.Location = New System.Drawing.Point(102, 124)
        Me.txtVerify.Name = "txtVerify"
        Me.txtVerify.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtVerify.Size = New System.Drawing.Size(228, 20)
        Me.txtVerify.TabIndex = 10
        '
        'cboGroup
        '
        Me.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGroup.FormattingEnabled = True
        Me.cboGroup.Items.AddRange(New Object() {"Admin", "User"})
        Me.cboGroup.Location = New System.Drawing.Point(102, 150)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.Size = New System.Drawing.Size(144, 21)
        Me.cboGroup.TabIndex = 12
        '
        'chkIsActive
        '
        Me.chkIsActive.AutoSize = True
        Me.chkIsActive.Checked = True
        Me.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIsActive.Location = New System.Drawing.Point(275, 154)
        Me.chkIsActive.Name = "chkIsActive"
        Me.chkIsActive.Size = New System.Drawing.Size(56, 17)
        Me.chkIsActive.TabIndex = 13
        Me.chkIsActive.Text = "Active"
        Me.chkIsActive.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Image = CType(resources.GetObject("btnBrowse.Image"), System.Drawing.Image)
        Me.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrowse.Location = New System.Drawing.Point(372, 148)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(129, 22)
        Me.btnBrowse.TabIndex = 84
        Me.btnBrowse.Text = "Browse Photo"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.lblCountSub)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(507, 366)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(113, 22)
        Me.Panel2.TabIndex = 18
        '
        'lblCountSub
        '
        Me.lblCountSub.AutoSize = True
        Me.lblCountSub.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCountSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountSub.Location = New System.Drawing.Point(86, 4)
        Me.lblCountSub.Name = "lblCountSub"
        Me.lblCountSub.Size = New System.Drawing.Size(16, 16)
        Me.lblCountSub.TabIndex = 1
        Me.lblCountSub.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "No. of Records:"
        '
        'picPhoto
        '
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Location = New System.Drawing.Point(372, 21)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(129, 122)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 16
        Me.picPhoto.TabStop = False
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemove.Location = New System.Drawing.Point(91, 367)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(79, 21)
        Me.btnRemove.TabIndex = 15
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(6, 367)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(79, 22)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgRights
        '
        Me.dgRights.AllowUserToAddRows = False
        Me.dgRights.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dgRights.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgRights.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgRights.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgRights.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgRights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRights.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMenuID, Me.colFormName, Me.colCanAdd, Me.colCanEdit, Me.colCanDelete, Me.colCanView, Me.colCanPrint, Me.colCheckAll, Me.colUncheckAll})
        Me.dgRights.Location = New System.Drawing.Point(6, 177)
        Me.dgRights.Name = "dgRights"
        Me.dgRights.RowHeadersVisible = False
        Me.dgRights.RowHeadersWidth = 25
        Me.dgRights.Size = New System.Drawing.Size(614, 188)
        Me.dgRights.TabIndex = 1
        '
        'colMenuID
        '
        Me.colMenuID.DataPropertyName = "MenuID"
        Me.colMenuID.HeaderText = "MenuID"
        Me.colMenuID.Name = "colMenuID"
        Me.colMenuID.ReadOnly = True
        Me.colMenuID.Visible = False
        '
        'colFormName
        '
        Me.colFormName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFormName.DataPropertyName = "FormName"
        Me.colFormName.HeaderText = "Entry/Report"
        Me.colFormName.MinimumWidth = 100
        Me.colFormName.Name = "colFormName"
        Me.colFormName.ReadOnly = True
        '
        'colCanAdd
        '
        Me.colCanAdd.ContextMenuStrip = Me.cntxtrights
        Me.colCanAdd.DataPropertyName = "canAdd"
        Me.colCanAdd.HeaderText = "Add"
        Me.colCanAdd.Name = "colCanAdd"
        Me.colCanAdd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCanAdd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colCanAdd.Width = 50
        '
        'cntxtrights
        '
        Me.cntxtrights.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CkeckToolStripMenuItem, Me.UncheckAllToolStripMenuItem})
        Me.cntxtrights.Name = "cntxtrights"
        Me.cntxtrights.Size = New System.Drawing.Size(138, 48)
        '
        'CkeckToolStripMenuItem
        '
        Me.CkeckToolStripMenuItem.Image = CType(resources.GetObject("CkeckToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CkeckToolStripMenuItem.Name = "CkeckToolStripMenuItem"
        Me.CkeckToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.CkeckToolStripMenuItem.Text = "Check All"
        '
        'UncheckAllToolStripMenuItem
        '
        Me.UncheckAllToolStripMenuItem.Image = CType(resources.GetObject("UncheckAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UncheckAllToolStripMenuItem.Name = "UncheckAllToolStripMenuItem"
        Me.UncheckAllToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.UncheckAllToolStripMenuItem.Text = "Uncheck All"
        '
        'colCanEdit
        '
        Me.colCanEdit.ContextMenuStrip = Me.cntxtrights
        Me.colCanEdit.DataPropertyName = "canEdit"
        Me.colCanEdit.HeaderText = "Edit"
        Me.colCanEdit.Name = "colCanEdit"
        Me.colCanEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCanEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colCanEdit.Width = 50
        '
        'colCanDelete
        '
        Me.colCanDelete.ContextMenuStrip = Me.cntxtrights
        Me.colCanDelete.DataPropertyName = "canDelete"
        Me.colCanDelete.HeaderText = "Delete"
        Me.colCanDelete.Name = "colCanDelete"
        Me.colCanDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCanDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colCanDelete.Width = 50
        '
        'colCanView
        '
        Me.colCanView.ContextMenuStrip = Me.cntxtrights
        Me.colCanView.DataPropertyName = "canPreView"
        Me.colCanView.HeaderText = "View"
        Me.colCanView.Name = "colCanView"
        Me.colCanView.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCanView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colCanView.Width = 50
        '
        'colCanPrint
        '
        Me.colCanPrint.ContextMenuStrip = Me.cntxtrights
        Me.colCanPrint.DataPropertyName = "canPrint"
        Me.colCanPrint.HeaderText = "Print"
        Me.colCanPrint.Name = "colCanPrint"
        Me.colCanPrint.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCanPrint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colCanPrint.Width = 50
        '
        'colCheckAll
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = "Check All"
        Me.colCheckAll.DefaultCellStyle = DataGridViewCellStyle2
        Me.colCheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.colCheckAll.HeaderText = "Grant"
        Me.colCheckAll.Name = "colCheckAll"
        Me.colCheckAll.Width = 80
        '
        'colUncheckAll
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = "Uncheck All"
        Me.colUncheckAll.DefaultCellStyle = DataGridViewCellStyle3
        Me.colUncheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.colUncheckAll.HeaderText = "Deny"
        Me.colUncheckAll.Name = "colUncheckAll"
        Me.colUncheckAll.Width = 80
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Verify"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "User Group"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Employee Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Emp. ID"
        '
        'dgList
        '
        Me.dgList.AllowUserToAddRows = False
        Me.dgList.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue
        Me.dgList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgList.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colClientID, Me.colClientName, Me.colEmpName})
        Me.dgList.Location = New System.Drawing.Point(6, 20)
        Me.dgList.MultiSelect = False
        Me.dgList.Name = "dgList"
        Me.dgList.ReadOnly = True
        Me.dgList.RowHeadersVisible = False
        Me.dgList.RowHeadersWidth = 25
        Me.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgList.Size = New System.Drawing.Size(286, 345)
        Me.dgList.TabIndex = 0
        '
        'colClientID
        '
        Me.colClientID.DataPropertyName = "UserID"
        Me.colClientID.HeaderText = "ID"
        Me.colClientID.Name = "colClientID"
        Me.colClientID.ReadOnly = True
        Me.colClientID.Visible = False
        '
        'colClientName
        '
        Me.colClientName.DataPropertyName = "EmpID"
        Me.colClientName.HeaderText = "Emp. ID"
        Me.colClientName.Name = "colClientName"
        Me.colClientName.ReadOnly = True
        Me.colClientName.Width = 80
        '
        'colEmpName
        '
        Me.colEmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEmpName.DataPropertyName = "EmpName"
        Me.colEmpName.HeaderText = "Employee Name"
        Me.colEmpName.MinimumWidth = 100
        Me.colEmpName.Name = "colEmpName"
        Me.colEmpName.ReadOnly = True
        '
        'grpList
        '
        Me.grpList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpList.BackColor = System.Drawing.Color.Transparent
        Me.grpList.Controls.Add(Me.dgList)
        Me.grpList.Controls.Add(Me.Panel3)
        Me.grpList.Location = New System.Drawing.Point(12, 4)
        Me.grpList.Name = "grpList"
        Me.grpList.Size = New System.Drawing.Size(298, 392)
        Me.grpList.TabIndex = 4
        Me.grpList.TabStop = False
        Me.grpList.Text = "List:"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.lblRecordCount)
        Me.Panel3.Controls.Add(Me.LabelCount)
        Me.Panel3.Location = New System.Drawing.Point(1, 366)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(142, 22)
        Me.Panel3.TabIndex = 0
        '
        'lblRecordCount
        '
        Me.lblRecordCount.AutoSize = True
        Me.lblRecordCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRecordCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordCount.Location = New System.Drawing.Point(86, 4)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(16, 16)
        Me.lblRecordCount.TabIndex = 1
        Me.lblRecordCount.Text = "0"
        '
        'LabelCount
        '
        Me.LabelCount.AutoSize = True
        Me.LabelCount.Location = New System.Drawing.Point(4, 5)
        Me.LabelCount.Name = "LabelCount"
        Me.LabelCount.Size = New System.Drawing.Size(82, 13)
        Me.LabelCount.TabIndex = 1
        Me.LabelCount.Text = "No. of Records:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 42)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpList)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpProfile)
        Me.SplitContainer1.Size = New System.Drawing.Size(948, 398)
        Me.SplitContainer1.SplitterDistance = 315
        Me.SplitContainer1.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EmpID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Emp. ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EmpName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Employee Name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MenuID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MenuID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FormName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Entry/Report"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.picLogo)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(961, 36)
        Me.Panel1.TabIndex = 28
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(115, 36)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 9
        Me.picLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(961, 33)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "User Setup"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frm_000_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 445)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_000_User"
        Me.Text = "User Setup"
        Me.grpProfile.ResumeLayout(False)
        Me.grpProfile.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRights, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cntxtrights.ResumeLayout(False)
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpList.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpProfile As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgList As System.Windows.Forms.DataGridView
    Friend WithEvents grpList As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtVerify As System.Windows.Forms.TextBox
    Friend WithEvents cboGroup As System.Windows.Forms.ComboBox
    Friend WithEvents chkIsActive As System.Windows.Forms.CheckBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgRights As System.Windows.Forms.DataGridView
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents LabelCount As System.Windows.Forms.Label
    Friend WithEvents lblRecordCount As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents colClientID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colClientName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEmpName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblCountSub As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents cntxtrights As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CkeckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UncheckAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtuserId As System.Windows.Forms.TextBox
    Friend WithEvents colMenuID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFormName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCanAdd As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colCanEdit As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colCanDelete As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colCanView As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colCanPrint As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colCheckAll As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colUncheckAll As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
