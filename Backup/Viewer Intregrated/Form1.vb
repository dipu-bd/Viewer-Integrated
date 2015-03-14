Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load other settings
        Me.WindowState = My.Settings.lastWindowState
        If Me.WindowState = FormWindowState.Normal Then
            Me.Size = My.Settings.lastSize
            Me.Location = My.Settings.lastLocation
        End If
        Me.TabControl1.SelectedTab = Me.TabControl1.TabPages(My.Settings.lastTab)
        'add char viewer
        Dim chview As New CharViewer
        chview.Dock = DockStyle.Fill
        TabPage1.Controls.Add(chview)
        'add font viewer
        Dim fview As New FontViewer
        fview.Dock = DockStyle.Fill
        TabPage2.Controls.Add(fview)
        'add color chooser
        Dim clrchs As New ColorChooser
        clrchs.Dock = DockStyle.Fill
        TabPage3.Controls.Add(clrchs)
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'save settings
        My.Settings.lastWindowState = Me.WindowState
        If Me.WindowState = FormWindowState.Normal Then
            My.Settings.lastSize = Me.Size
            My.Settings.lastLocation = Me.Location
        End If
        My.Settings.lastTab = Me.TabControl1.SelectedIndex
    End Sub
End Class
