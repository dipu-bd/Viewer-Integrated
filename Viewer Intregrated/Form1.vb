Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
     
End Class
