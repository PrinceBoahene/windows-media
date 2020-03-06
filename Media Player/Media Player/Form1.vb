Public Class Form1

    Private Sub AxWindowsMediaPlayer1_ClickEvent(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_ClickEvent) Handles AxWindowsMediaPlayer1.ClickEvent
        If (AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying) Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
        Else
            AxWindowsMediaPlayer1.Ctlcontrols.play()

        End If
    End Sub

  
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.InitialDirectory = "C:\Users\Nana Kay Prince(CEO)\Desktop"
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub CustomizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomizeToolStripMenuItem.Click
        AxWindowsMediaPlayer1.uiMode = "full"
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        AxWindowsMediaPlayer1.uiMode = "none"
    End Sub

    Private Sub Label1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.MouseHover
        Label1.BackColor = Color.Red
        Label1.ForeColor = Color.AntiqueWhite
    End Sub

    Private Sub Label1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Gray
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()

    End Sub

  

    Private Sub WebToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebToolStripMenuItem.Click
        web.Show()
    End Sub
End Class
