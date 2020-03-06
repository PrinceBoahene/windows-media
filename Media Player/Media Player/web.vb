Public Class web

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'open URL
        'WebBrowser1.Navigate(ComboBox1.Text)
        WebBrowser1.Navigate("https://register.kpoly.edu.gh/")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.GoForward()
    End Sub

   
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.Refresh()
    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs)
        ComboBox1.Text = WebBrowser1.Url.ToString()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        WebBrowser2.Document.GetElementById("partid").SetAttribute("value", TextBox1.Text)
        WebBrowser2.Document.GetElementById("pass").SetAttribute("value", TextBox2.Text)
        WebBrowser2.Document.GetElementById("login").InvokeMember("click")

    End Sub

End Class

