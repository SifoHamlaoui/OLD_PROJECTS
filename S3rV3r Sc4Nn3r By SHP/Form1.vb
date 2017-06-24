Imports System.Net
Imports System.Windows.Forms

Public Class Form1

    Private Sub ViButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton1.Click
        Dim hostname As IPHostEntry = Dns.GetHostEntry(TextBox2.Text)
        Dim ip As IPAddress() = hostname.AddressList
        TextBox3.Text = ip(0).ToString
    End Sub

    Private Sub ViButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton2.Click
        Close()
    End Sub

    Private Sub ViButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton3.Click
        MsgBox("CreaTed By Sifo Hamlaoui" & vbNewLine & vbNewLine &
                         "Copyright SHP 2015" & vbNewLine & vbNewLine &
                         "Thank's To : Ghosty , Ds Dz , Dz EVile ," & vbNewLine & vbNewLine &
                         "GénéRal Akli , All The Algerian Hackers" & vbNewLine & vbNewLine &
                         "& All My Friend's")
    End Sub

    Private Sub ViButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton4.Click
        Process.Start("https://goo.gl/JxXlt7")
    End Sub

    Private Sub ViButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton5.Click
        TextBox4.Text = WebBrowser1.Url.ToString()
    End Sub

    Private Sub ViButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton6.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text)
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton7.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "Powered By Vbulletin")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton8.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "Powered By WordPress")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton9.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "?page_id")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton10.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "Powered By Joomla")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton11.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "Welcome to the Frontpage")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton12.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "Powered By WHMCS")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton13.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "Powered By WHMCompleteSolution")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton16.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "Powered By phpBB")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton17.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "Powered By IP.Board")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton18.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "Powered By osCommerce")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton19.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & " /php?cPath")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton20.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "4images")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton21.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "powered by drupal")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton22.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "powered by nirox")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton14.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "powered by clipbucket")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton15.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "powered by mediacreativecente")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton23.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "powered by SMF")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton24.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "/submitticket.php")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton25.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "upload")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton26.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "up")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton27.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "upload.php")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton28.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "up.php")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton29.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "powered by")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton30.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "public_html")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton31.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "syntax")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton32.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "error")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton33.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "mysql")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton34.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "install")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton35.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "install.php")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton36.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "id=")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton37.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "php?*id=*")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton38.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "/index.php?*=")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton39.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "drwxr-xr-x")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton43.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "Hacked By")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton44.Click
        WebBrowser1.Navigate("http://www.zone-h.org/archive/ip=" & TextBox1.Text)
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViTheme1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViTheme1.Click
        WebBrowser1.ScriptErrorsSuppressed = True
    End Sub

    Private Sub ViButton45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton45.Click
        WebBrowser1.Navigate("http://browserspy.dk/webserver.php")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton46.Click
        WebBrowser1.Navigate("http://who.is/whois/" & TextBox1.Text)
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton40.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "Safe mode: OFF [ phpinfo ]")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton41.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "IP :" & " " & TextBox1.Text & " " & "Warning")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton47.Click
        WebBrowser1.Navigate("http://mxtoolbox.com/SuperTool.aspx?action=scan%3a" & TextBox1.Text & "&run=toolpage")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton48.Click
        WebBrowser1.Navigate("http://tracert.com/traceroute?t=" & TextBox1.Text)
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton49.Click
        WebBrowser1.Navigate("http://www.tracert.org/cgi-bin/traceroute/tracert.pl?t=" & TextBox1.Text)
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton50.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub ViButton51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton51.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub ViButton52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton52.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub ViButton53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton53.Click
        Process.Start("http://goo.gl/QixVem")
    End Sub

    Private Sub ViButton54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton54.Click
        Process.Start("http://goo.gl/42YcrK")
    End Sub

    Private Sub ViButton55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton55.Click
        Process.Start("http://goo.gl/Mh7Vvw")
    End Sub

    Private Sub ViButton56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("https://goo.gl/o6WoHa")
    End Sub

    Private Sub ViButton57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton57.Click
        Process.Start("https://goo.gl/mq79rK")
    End Sub

    Private Sub ViButton56_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton56.Click
        Process.Start("https://goo.gl/nLfqIL")
    End Sub

    Private Sub ViButton58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton58.Click
        Process.Start("http://0day.today/")
    End Sub

    Private Sub ViButton59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton59.Click
        Process.Start("https://packetstormsecurity.com/files/tags/exploit/")
    End Sub

    Private Sub ViButton60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton60.Click
        Process.Start("http://goo.gl/exu5BG")
    End Sub

    Private Sub ViButton61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton61.Click
        Process.Start("https://hashcat.net/forum/thread-1236.html")
    End Sub

    Private Sub ViButton63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton63.Click
        Process.Start("https://goo.gl/oOQR4g")
    End Sub

    Private Sub ViButton62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton62.Click
        Process.Start("https://goo.gl/9UTtrd")
    End Sub

    Private Sub ViButton42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViButton42.Click
        WebBrowser1.Navigate("http://www.bing.com/search?q=" & "PHP Wso 2.5  drwxr")
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub ViButton64_Click(sender As Object, e As EventArgs) Handles ViButton64.Click
        WebBrowser1.Navigate("http://iphostinfo.com/cloudflare/" & TextBox5.Text)
        Dim count As Integer = ProgressBar1.Value
        If count = 100 Then
            ProgressBar1.Value = ProgressBar1.Value - 100
        End If
        ProgressBar1.Value = ProgressBar1.Value + 100
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
