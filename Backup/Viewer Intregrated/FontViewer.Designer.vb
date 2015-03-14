<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FontViewer
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
        Dim ListViewItem56 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Original Name", ""}, -1)
        Dim ListViewItem57 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"System Font", ""}, -1)
        Dim ListViewItem58 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"System Name", ""}, -1)
        Dim ListViewItem59 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"GDI Charset", ""}, -1)
        Dim ListViewItem60 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"GDI Vertical Font", ""}, -1)
        Dim ListViewItem61 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Height", ""}, -1)
        Dim ListViewItem62 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Cell Ascent", ""}, -1)
        Dim ListViewItem63 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Cell Descent", ""}, -1)
        Dim ListViewItem64 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"EM Height", ""}, -1)
        Dim ListViewItem65 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Line Spacing", ""}, -1)
        Dim ListViewItem66 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Available Styles", ""}, -1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FontViewer))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.FontNameList = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.SearchBox = New System.Windows.Forms.TextBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.SampleSentenceView = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.WordSelection = New System.Windows.Forms.ListBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.sentenceText = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SenteceViewButton = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.FontName = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.SampleTextView = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.RegularStyle = New System.Windows.Forms.ToolStripButton
        Me.Separator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BoldStyle = New System.Windows.Forms.ToolStripButton
        Me.ItallicStyle = New System.Windows.Forms.ToolStripButton
        Me.UnderlineStyle = New System.Windows.Forms.ToolStripButton
        Me.StrikeoutStyle = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.SplitterButton = New System.Windows.Forms.ToolStripSplitButton
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.BanglaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.Background1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Foreground1 = New System.Windows.Forms.ToolStripButton
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FontNameList)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SearchBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer1.Size = New System.Drawing.Size(774, 443)
        Me.SplitContainer1.SplitterDistance = 212
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 415)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(212, 28)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 22)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Installed Fonts"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(109, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 22)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Load Font File"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FontNameList
        '
        Me.FontNameList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FontNameList.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FontNameList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader2})
        Me.FontNameList.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FontNameList.FullRowSelect = True
        Me.FontNameList.GridLines = True
        Me.FontNameList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.FontNameList.HideSelection = False
        Me.FontNameList.Location = New System.Drawing.Point(3, 33)
        Me.FontNameList.MultiSelect = False
        Me.FontNameList.Name = "FontNameList"
        Me.FontNameList.ShowItemToolTips = True
        Me.FontNameList.Size = New System.Drawing.Size(207, 384)
        Me.FontNameList.TabIndex = 2
        Me.FontNameList.UseCompatibleStateImageBehavior = False
        Me.FontNameList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Font Names"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 100
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.SearchBox.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.ForeColor = System.Drawing.Color.Gray
        Me.SearchBox.Location = New System.Drawing.Point(3, 3)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(207, 26)
        Me.SearchBox.TabIndex = 0
        Me.SearchBox.Text = "Search"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SampleSentenceView)
        Me.SplitContainer2.Panel1.Controls.Add(Me.WordSelection)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer2.Size = New System.Drawing.Size(558, 418)
        Me.SplitContainer2.SplitterDistance = 247
        Me.SplitContainer2.TabIndex = 0
        '
        'SampleSentenceView
        '
        Me.SampleSentenceView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.SampleSentenceView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SampleSentenceView.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SampleSentenceView.GridLines = True
        Me.SampleSentenceView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.SampleSentenceView.HideSelection = False
        Me.SampleSentenceView.Location = New System.Drawing.Point(0, 32)
        Me.SampleSentenceView.MultiSelect = False
        Me.SampleSentenceView.Name = "SampleSentenceView"
        Me.SampleSentenceView.ShowItemToolTips = True
        Me.SampleSentenceView.Size = New System.Drawing.Size(507, 215)
        Me.SampleSentenceView.TabIndex = 2
        Me.SampleSentenceView.TileSize = New System.Drawing.Size(70, 50)
        Me.SampleSentenceView.UseCompatibleStateImageBehavior = False
        Me.SampleSentenceView.View = System.Windows.Forms.View.Details
        '
        'WordSelection
        '
        Me.WordSelection.Dock = System.Windows.Forms.DockStyle.Right
        Me.WordSelection.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WordSelection.FormattingEnabled = True
        Me.WordSelection.IntegralHeight = False
        Me.WordSelection.ItemHeight = 17
        Me.WordSelection.Items.AddRange(New Object() {"A a", "B b", "C c", "D d", "E e", "F f", "G g", "H h", "I i", "J j", "K k", "L l", "M m", "N n", "O o", "P p", "Q q", "R r", "S s", "T t", "U u", "V v", "W w", "X x", "Y y", "Z z"})
        Me.WordSelection.Location = New System.Drawing.Point(507, 32)
        Me.WordSelection.Name = "WordSelection"
        Me.WordSelection.Size = New System.Drawing.Size(51, 215)
        Me.WordSelection.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.sentenceText)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.SenteceViewButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 32)
        Me.Panel1.TabIndex = 0
        '
        'sentenceText
        '
        Me.sentenceText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sentenceText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sentenceText.Location = New System.Drawing.Point(69, 3)
        Me.sentenceText.Name = "sentenceText"
        Me.sentenceText.Size = New System.Drawing.Size(432, 25)
        Me.sentenceText.TabIndex = 0
        Me.sentenceText.Text = "A quick brown fox jumps over the lazy dog."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sentence :"
        '
        'SenteceViewButton
        '
        Me.SenteceViewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SenteceViewButton.Location = New System.Drawing.Point(505, 3)
        Me.SenteceViewButton.Name = "SenteceViewButton"
        Me.SenteceViewButton.Size = New System.Drawing.Size(42, 23)
        Me.SenteceViewButton.TabIndex = 2
        Me.SenteceViewButton.Text = "OK"
        Me.SenteceViewButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(558, 167)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Controls.Add(Me.FontName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(5, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(203, 157)
        Me.Panel2.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem56, ListViewItem57, ListViewItem58, ListViewItem59, ListViewItem60, ListViewItem61, ListViewItem62, ListViewItem63, ListViewItem64, ListViewItem65, ListViewItem66})
        Me.ListView1.Location = New System.Drawing.Point(0, 29)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(203, 128)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Properties"
        Me.ColumnHeader4.Width = 85
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Value"
        Me.ColumnHeader5.Width = 100
        '
        'FontName
        '
        Me.FontName.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FontName.Dock = System.Windows.Forms.DockStyle.Top
        Me.FontName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FontName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FontName.Location = New System.Drawing.Point(0, 0)
        Me.FontName.Name = "FontName"
        Me.FontName.Size = New System.Drawing.Size(203, 29)
        Me.FontName.TabIndex = 0
        Me.FontName.Text = "Font Name"
        Me.FontName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SampleTextView)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(216, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(337, 157)
        Me.Panel3.TabIndex = 1
        '
        'SampleTextView
        '
        Me.SampleTextView.BackColor = System.Drawing.Color.White
        Me.SampleTextView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SampleTextView.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.SampleTextView.ForeColor = System.Drawing.Color.Black
        Me.SampleTextView.HideSelection = False
        Me.SampleTextView.Location = New System.Drawing.Point(0, 26)
        Me.SampleTextView.Multiline = True
        Me.SampleTextView.Name = "SampleTextView"
        Me.SampleTextView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SampleTextView.Size = New System.Drawing.Size(337, 131)
        Me.SampleTextView.TabIndex = 0
        Me.SampleTextView.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "abcdefghijklmnopqrstuvwxyz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0123456789 .+-*/-=\!@#$%" & _
            "^&*()[]{}"":';"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ToolStrip1)
        Me.Panel4.Controls.Add(Me.NumericUpDown1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(337, 26)
        Me.Panel4.TabIndex = 4
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegularStyle, Me.Separator1, Me.BoldStyle, Me.ItallicStyle, Me.UnderlineStyle, Me.StrikeoutStyle, Me.ToolStripSeparator1, Me.SplitterButton, Me.ToolStripSeparator3, Me.Background1, Me.ToolStripSeparator2, Me.Foreground1})
        Me.ToolStrip1.Location = New System.Drawing.Point(50, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(287, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'RegularStyle
        '
        Me.RegularStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RegularStyle.Image = Global.Viewer_Intregrated.My.Resources.Resources.Regular
        Me.RegularStyle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RegularStyle.Name = "RegularStyle"
        Me.RegularStyle.Size = New System.Drawing.Size(23, 22)
        Me.RegularStyle.Text = "Regular"
        '
        'Separator1
        '
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(6, 25)
        '
        'BoldStyle
        '
        Me.BoldStyle.CheckOnClick = True
        Me.BoldStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BoldStyle.Image = Global.Viewer_Intregrated.My.Resources.Resources.Bold
        Me.BoldStyle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BoldStyle.Name = "BoldStyle"
        Me.BoldStyle.Size = New System.Drawing.Size(23, 22)
        Me.BoldStyle.Text = "Bold"
        '
        'ItallicStyle
        '
        Me.ItallicStyle.CheckOnClick = True
        Me.ItallicStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ItallicStyle.Image = Global.Viewer_Intregrated.My.Resources.Resources.Itallic
        Me.ItallicStyle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ItallicStyle.Name = "ItallicStyle"
        Me.ItallicStyle.Size = New System.Drawing.Size(23, 22)
        Me.ItallicStyle.Text = "Itallic"
        '
        'UnderlineStyle
        '
        Me.UnderlineStyle.CheckOnClick = True
        Me.UnderlineStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UnderlineStyle.Image = Global.Viewer_Intregrated.My.Resources.Resources.Underline
        Me.UnderlineStyle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UnderlineStyle.Name = "UnderlineStyle"
        Me.UnderlineStyle.Size = New System.Drawing.Size(23, 22)
        Me.UnderlineStyle.Text = "Underline"
        '
        'StrikeoutStyle
        '
        Me.StrikeoutStyle.CheckOnClick = True
        Me.StrikeoutStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StrikeoutStyle.Image = Global.Viewer_Intregrated.My.Resources.Resources.Strikeout
        Me.StrikeoutStyle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StrikeoutStyle.Name = "StrikeoutStyle"
        Me.StrikeoutStyle.Size = New System.Drawing.Size(23, 22)
        Me.StrikeoutStyle.Text = "Strikeout"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'SplitterButton
        '
        Me.SplitterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SplitterButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.BanglaToolStripMenuItem})
        Me.SplitterButton.Image = CType(resources.GetObject("SplitterButton.Image"), System.Drawing.Image)
        Me.SplitterButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SplitterButton.Name = "SplitterButton"
        Me.SplitterButton.Size = New System.Drawing.Size(62, 22)
        Me.SplitterButton.Text = "Sample"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DefaultToolStripMenuItem.Text = "Default"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem1.Text = "Lorem Ipsum"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem2.Text = "ASCII Characters"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem3.Text = "Greek"
        '
        'BanglaToolStripMenuItem
        '
        Me.BanglaToolStripMenuItem.Name = "BanglaToolStripMenuItem"
        Me.BanglaToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.BanglaToolStripMenuItem.Text = "Bangla"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Background1
        '
        Me.Background1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Background1.Checked = True
        Me.Background1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Background1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Background1.Image = CType(resources.GetObject("Background1.Image"), System.Drawing.Image)
        Me.Background1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Background1.Name = "Background1"
        Me.Background1.Size = New System.Drawing.Size(23, 22)
        Me.Background1.Text = "    "
        Me.Background1.ToolTipText = "Backcolor"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Foreground1
        '
        Me.Foreground1.Checked = True
        Me.Foreground1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Foreground1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Foreground1.Image = CType(resources.GetObject("Foreground1.Image"), System.Drawing.Image)
        Me.Foreground1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Foreground1.Name = "Foreground1"
        Me.Foreground1.Size = New System.Drawing.Size(23, 22)
        Me.Foreground1.Text = "    "
        Me.Foreground1.ToolTipText = "Forecolor"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(0, 0)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(50, 25)
        Me.NumericUpDown1.TabIndex = 4
        Me.NumericUpDown1.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 418)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(558, 25)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel1.Text = "External :"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Viewer_Intregrated.My.Resources.Resources.font_folder
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(92, 22)
        Me.ToolStripButton1.Text = "Fonts Folder"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Viewer_Intregrated.My.Resources.Resources.Blue_Font
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(101, 22)
        Me.ToolStripButton2.Text = "Font Dialogue"
        '
        'FontViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.MinimumSize = New System.Drawing.Size(590, 350)
        Me.Name = "FontViewer"
        Me.Size = New System.Drawing.Size(774, 443)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SearchBox As System.Windows.Forms.TextBox
    Friend WithEvents FontNameList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents WordSelection As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SampleSentenceView As System.Windows.Forms.ListView
    Friend WithEvents SenteceViewButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sentenceText As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents FontName As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents RegularStyle As System.Windows.Forms.ToolStripButton
    Friend WithEvents BoldStyle As System.Windows.Forms.ToolStripButton
    Friend WithEvents ItallicStyle As System.Windows.Forms.ToolStripButton
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents UnderlineStyle As System.Windows.Forms.ToolStripButton
    Friend WithEvents StrikeoutStyle As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitterButton As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents DefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BanglaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Background1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Foreground1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SampleTextView As System.Windows.Forms.TextBox

End Class
