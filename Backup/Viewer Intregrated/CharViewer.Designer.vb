<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharViewer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"All Unicode Chars", "0 to 65535"}, -1, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer)), System.Drawing.Color.Empty, New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.SearchBox = New System.Windows.Forms.ComboBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.EditRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyCharacterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyUnicodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyDecimalCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.EditNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.startCode = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.EndCode = New System.Windows.Forms.Label
        Me.RangeName = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.DeciCode = New System.Windows.Forms.TextBox
        Me.MaxView = New System.Windows.Forms.Label
        Me.HexCode = New System.Windows.Forms.TextBox
        Me.CharName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(771, 466)
        Me.SplitContainer1.SplitterDistance = 171
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.SearchBox, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ListView1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(171, 466)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.SearchBox.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.ForeColor = System.Drawing.Color.Gray
        Me.SearchBox.Location = New System.Drawing.Point(3, 3)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(165, 25)
        Me.SearchBox.TabIndex = 0
        Me.SearchBox.Text = "Search"
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        ListViewItem1.UseItemStyleForSubItems = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListView1.Location = New System.Drawing.Point(3, 33)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(165, 430)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 125
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Range"
        Me.ColumnHeader2.Width = 100
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.ToolStripSeparator2, Me.EditRangeToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(131, 54)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(127, 6)
        '
        'EditRangeToolStripMenuItem
        '
        Me.EditRangeToolStripMenuItem.Name = "EditRangeToolStripMenuItem"
        Me.EditRangeToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.EditRangeToolStripMenuItem.Text = "Edit Range"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ListBox1.ColumnWidth = 35
        Me.ListBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.IntegralHeight = False
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(0, 76)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(596, 365)
        Me.ListBox1.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyCharacterToolStripMenuItem, Me.CopyUnicodeToolStripMenuItem, Me.CopyDecimalCodeToolStripMenuItem, Me.CopyNameToolStripMenuItem, Me.ToolStripSeparator1, Me.EditNameToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(180, 120)
        '
        'CopyCharacterToolStripMenuItem
        '
        Me.CopyCharacterToolStripMenuItem.Name = "CopyCharacterToolStripMenuItem"
        Me.CopyCharacterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyCharacterToolStripMenuItem.ShowShortcutKeys = False
        Me.CopyCharacterToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CopyCharacterToolStripMenuItem.Text = "Copy Character"
        '
        'CopyUnicodeToolStripMenuItem
        '
        Me.CopyUnicodeToolStripMenuItem.Name = "CopyUnicodeToolStripMenuItem"
        Me.CopyUnicodeToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CopyUnicodeToolStripMenuItem.Text = "Copy Unicode"
        '
        'CopyDecimalCodeToolStripMenuItem
        '
        Me.CopyDecimalCodeToolStripMenuItem.Name = "CopyDecimalCodeToolStripMenuItem"
        Me.CopyDecimalCodeToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CopyDecimalCodeToolStripMenuItem.Text = "Copy Decimal Code"
        '
        'CopyNameToolStripMenuItem
        '
        Me.CopyNameToolStripMenuItem.Name = "CopyNameToolStripMenuItem"
        Me.CopyNameToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CopyNameToolStripMenuItem.Text = "Copy Name"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(176, 6)
        '
        'EditNameToolStripMenuItem
        '
        Me.EditNameToolStripMenuItem.Name = "EditNameToolStripMenuItem"
        Me.EditNameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert
        Me.EditNameToolStripMenuItem.ShowShortcutKeys = False
        Me.EditNameToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.EditNameToolStripMenuItem.Text = "Edit Name"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer2.Size = New System.Drawing.Size(596, 76)
        Me.SplitContainer2.SplitterDistance = 319
        Me.SplitContainer2.SplitterWidth = 3
        Me.SplitContainer2.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel2.Controls.Add(Me.RangeName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(319, 76)
        Me.Panel2.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.startCode)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.EndCode)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 45)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(319, 31)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'startCode
        '
        Me.startCode.AutoSize = True
        Me.startCode.BackColor = System.Drawing.Color.Transparent
        Me.startCode.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startCode.ForeColor = System.Drawing.Color.Crimson
        Me.startCode.Location = New System.Drawing.Point(10, 5)
        Me.startCode.Margin = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.startCode.Name = "startCode"
        Me.startCode.Size = New System.Drawing.Size(37, 17)
        Me.startCode.TabIndex = 0
        Me.startCode.Text = "start"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(47, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "to"
        '
        'EndCode
        '
        Me.EndCode.AutoSize = True
        Me.EndCode.BackColor = System.Drawing.Color.Transparent
        Me.EndCode.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndCode.ForeColor = System.Drawing.Color.Crimson
        Me.EndCode.Location = New System.Drawing.Point(67, 5)
        Me.EndCode.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.EndCode.Name = "EndCode"
        Me.EndCode.Size = New System.Drawing.Size(31, 17)
        Me.EndCode.TabIndex = 2
        Me.EndCode.Text = "end"
        '
        'RangeName
        '
        Me.RangeName.Dock = System.Windows.Forms.DockStyle.Top
        Me.RangeName.Font = New System.Drawing.Font("Comic Sans MS", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RangeName.ForeColor = System.Drawing.Color.Navy
        Me.RangeName.Location = New System.Drawing.Point(0, 0)
        Me.RangeName.Margin = New System.Windows.Forms.Padding(5, 0, 3, 0)
        Me.RangeName.Name = "RangeName"
        Me.RangeName.Size = New System.Drawing.Size(319, 45)
        Me.RangeName.TabIndex = 0
        Me.RangeName.Text = "Range Name"
        Me.RangeName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DeciCode)
        Me.Panel1.Controls.Add(Me.MaxView)
        Me.Panel1.Controls.Add(Me.HexCode)
        Me.Panel1.Controls.Add(Me.CharName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(274, 76)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(110, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Decimal :"
        '
        'DeciCode
        '
        Me.DeciCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeciCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DeciCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DeciCode.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DeciCode.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeciCode.ForeColor = System.Drawing.Color.Purple
        Me.DeciCode.Location = New System.Drawing.Point(163, 52)
        Me.DeciCode.Name = "DeciCode"
        Me.DeciCode.ReadOnly = True
        Me.DeciCode.Size = New System.Drawing.Size(105, 17)
        Me.DeciCode.TabIndex = 4
        Me.DeciCode.Text = "Decimal Code"
        '
        'MaxView
        '
        Me.MaxView.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MaxView.Dock = System.Windows.Forms.DockStyle.Left
        Me.MaxView.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.MaxView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaxView.Location = New System.Drawing.Point(0, 0)
        Me.MaxView.Name = "MaxView"
        Me.MaxView.Size = New System.Drawing.Size(92, 76)
        Me.MaxView.TabIndex = 2
        Me.MaxView.Text = "Chr"
        Me.MaxView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HexCode
        '
        Me.HexCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HexCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.HexCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HexCode.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.HexCode.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HexCode.ForeColor = System.Drawing.Color.Purple
        Me.HexCode.Location = New System.Drawing.Point(163, 35)
        Me.HexCode.Name = "HexCode"
        Me.HexCode.ReadOnly = True
        Me.HexCode.Size = New System.Drawing.Size(105, 17)
        Me.HexCode.TabIndex = 3
        Me.HexCode.Text = "Hexa Code"
        '
        'CharName
        '
        Me.CharName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CharName.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CharName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CharName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CharName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharName.ForeColor = System.Drawing.Color.Firebrick
        Me.CharName.Location = New System.Drawing.Point(105, 10)
        Me.CharName.Name = "CharName"
        Me.CharName.ReadOnly = True
        Me.CharName.Size = New System.Drawing.Size(165, 19)
        Me.CharName.TabIndex = 2
        Me.CharName.Text = "[add name]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(107, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Unicode :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 441)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(596, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripLabel1.Text = "External :"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Viewer_Intregrated.My.Resources.Resources.charmap
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(157, 22)
        Me.ToolStripButton1.Text = "Windows Character Map"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Viewer_Intregrated.My.Resources.Resources.font_folder
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripButton2.Text = "Font Folder"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.Viewer_Intregrated.My.Resources.Resources.pcr
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripButton3.Text = "Private Character Editor"
        '
        'CharViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "CharViewer"
        Me.Size = New System.Drawing.Size(771, 466)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents SearchBox As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents RangeName As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents startCode As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EndCode As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CharName As System.Windows.Forms.TextBox
    Friend WithEvents HexCode As System.Windows.Forms.TextBox
    Friend WithEvents DeciCode As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents MaxView As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyCharacterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyUnicodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyDecimalCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditRangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton

End Class
