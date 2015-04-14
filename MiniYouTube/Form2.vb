Public Class Form2

#Region "Form yüklemeleri"


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label13.Text = My.Settings.surum
        CheckBox1.Checked = My.Settings.Vs1
        CheckBox2.Checked = My.Settings.Vs2
        CheckBox3.Checked = My.Settings.Vs3
        CheckBox4.Checked = My.Settings.Vs4
        CheckBox5.Checked = My.Settings.yor
        CheckBox6.Checked = My.Settings.top
        ListBox1.Items.Add(My.Settings.S1a)
        ListBox1.Items.Add(My.Settings.S2a)
        ListBox1.Items.Add(My.Settings.S3a)
        ListBox1.Items.Add(My.Settings.S4a)
        ListBox1.Items.Add(My.Settings.S5a)
        ListBox1.Items.Add(My.Settings.S6a)
        ListBox1.Items.Add(My.Settings.S7a)
        ListBox1.Items.Add(My.Settings.S8a)
        ListBox1.Items.Add(My.Settings.S9a)
        ListBox1.Items.Add(My.Settings.S10a)

    End Sub
#End Region
   
#Region "Liste"


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If My.Settings.S1a = ListBox1.SelectedItem() Then
            My.Settings.S1a = ""
            My.Settings.S1 = ""
            ListBox1.SelectedItem() = ""
            My.Settings.Save()

        ElseIf My.Settings.S2a = ListBox1.SelectedItem() Then
            My.Settings.S2a = ""
            My.Settings.S2 = ""
            ListBox1.SelectedItem() = ""
            My.Settings.Save()

        ElseIf My.Settings.S3a = ListBox1.SelectedItem() Then
            My.Settings.S3a = ""
            My.Settings.S3 = ""
            ListBox1.SelectedItem() = ""
            My.Settings.Save()

        ElseIf My.Settings.S4a = ListBox1.SelectedItem() Then
            My.Settings.S4a = ""
            My.Settings.S4 = ""
            ListBox1.SelectedItem() = ""
            My.Settings.Save()

        ElseIf My.Settings.S5a = ListBox1.SelectedItem() Then
            My.Settings.S5a = ""
            My.Settings.S5 = ""
            ListBox1.SelectedItem() = ""
            My.Settings.Save()

        ElseIf My.Settings.S6a = ListBox1.SelectedItem() Then
            My.Settings.S6a = ""
            My.Settings.S6 = ""
            ListBox1.SelectedItem() = ""
            My.Settings.Save()

        ElseIf My.Settings.S7a = ListBox1.SelectedItem() Then
            My.Settings.S7a = ""
            My.Settings.S7 = ""
            ListBox1.SelectedItem() = ""
            My.Settings.Save()

        ElseIf My.Settings.S8a = ListBox1.SelectedItem() Then
            My.Settings.S8a = ""
            My.Settings.S8 = ""
            ListBox1.SelectedItem() = ""
            My.Settings.Save()

        ElseIf My.Settings.S9a = ListBox1.SelectedItem() Then
            My.Settings.S9a = ""
            My.Settings.S9 = ""
            ListBox1.SelectedItem() = ""
            My.Settings.Save()

        ElseIf My.Settings.S10a = ListBox1.SelectedItem() Then
            My.Settings.S10a = ""
            My.Settings.S10 = ""
            ListBox1.SelectedItem() = ""
            My.Settings.Save()

        End If
        ListBox1.Items.Clear()
        ListBox1.Items.Add(My.Settings.S1a)
        ListBox1.Items.Add(My.Settings.S2a)
        ListBox1.Items.Add(My.Settings.S3a)
        ListBox1.Items.Add(My.Settings.S4a)
        ListBox1.Items.Add(My.Settings.S5a)
        ListBox1.Items.Add(My.Settings.S6a)
        ListBox1.Items.Add(My.Settings.S7a)
        ListBox1.Items.Add(My.Settings.S8a)
        ListBox1.Items.Add(My.Settings.S9a)
        ListBox1.Items.Add(My.Settings.S10a)
    End Sub
    Dim url As String
    Dim isim As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        url = InputBox("Video linkini girin", "Link")
        isim = InputBox("Video adını girin", "Ad")
        
        If My.Settings.S1 = "" Then
            My.Settings.S1a = isim
            My.Settings.S1 = url
            My.Settings.Save()

        ElseIf My.Settings.S2 = "" Then
            My.Settings.S2a = isim
            My.Settings.S2 = url
            My.Settings.Save()

        ElseIf My.Settings.S3 = "" Then
            My.Settings.S3a = isim
            My.Settings.S3 = url
            My.Settings.Save()

        ElseIf My.Settings.S4 = "" Then
            My.Settings.S4a = isim
            My.Settings.S4 = url
            My.Settings.Save()

        ElseIf My.Settings.S5 = "" Then
            My.Settings.S5a = isim
            My.Settings.S5 = url
            My.Settings.Save()

        ElseIf My.Settings.S6 = "" Then
            My.Settings.S6a = isim
            My.Settings.S6 = url
            My.Settings.Save()

        ElseIf My.Settings.S7 = "" Then
            My.Settings.S7a = isim
            My.Settings.S7 = url
            My.Settings.Save()

        ElseIf My.Settings.S8 = "" Then
            My.Settings.S8a = isim
            My.Settings.S8 = url
            My.Settings.Save()

        ElseIf My.Settings.S9 = "" Then
            My.Settings.S9a = isim
            My.Settings.S9 = url
            My.Settings.Save()

        ElseIf My.Settings.S10 = "" Then
            My.Settings.S10a = isim
            My.Settings.S10 = url
            My.Settings.Save()

        End If
        ListBox1.Items.Clear()
        ListBox1.Items.Add(My.Settings.S1a)
        ListBox1.Items.Add(My.Settings.S2a)
        ListBox1.Items.Add(My.Settings.S3a)
        ListBox1.Items.Add(My.Settings.S4a)
        ListBox1.Items.Add(My.Settings.S5a)
        ListBox1.Items.Add(My.Settings.S6a)
        ListBox1.Items.Add(My.Settings.S7a)
        ListBox1.Items.Add(My.Settings.S8a)
        ListBox1.Items.Add(My.Settings.S9a)
        ListBox1.Items.Add(My.Settings.S10a)
    End Sub

#End Region

#Region "Ayarlar"
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        My.Settings.Vs1 = CheckBox1.CheckState
        My.Settings.Save()
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        My.Settings.Vs2 = CheckBox2.CheckState
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        My.Settings.Vs3 = CheckBox3.CheckState
        If CheckBox3.Checked = True Then
            CheckBox2.Checked = False
            CheckBox1.Checked = False
            CheckBox4.Checked = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        My.Settings.Vs4 = CheckBox4.CheckState
        If CheckBox4.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox1.Checked = False
        End If
        My.Settings.Save()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = Form1.Left
        TextBox2.Text = Form1.Top
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        MiniYouTube.Form1.Left -= 30
        TextBox1.Text = Form1.Left
        TextBox2.Text = Form1.Top
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        MiniYouTube.Form1.Left += 30
        TextBox1.Text = Form1.Left
        TextBox2.Text = Form1.Top
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        MiniYouTube.Form1.Top += 25
        TextBox1.Text = Form1.Left
        TextBox2.Text = Form1.Top
    End Sub
    Dim x As Integer
    Dim y As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        x = TextBox1.Text
        MiniYouTube.Form1.Left = x
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        y = TextBox2.Text
        MiniYouTube.Form1.Top = y
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        My.Settings.Px = x
        My.Settings.Py = y
        My.Settings.Save()
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            MiniYouTube.Form1.TopMost = True
            My.Settings.top = True
        Else
            MiniYouTube.Form1.TopMost = False
            My.Settings.top = False
        End If
    End Sub


#End Region

#Region "Renk kodları"
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Tema1" Then
            My.Settings.Tem1 = True
            My.Settings.Tem2 = False
            My.Settings.Tem3 = False
            My.Settings.Save()
            Button1.ForeColor = Color.CornflowerBlue
            Button2.ForeColor = Color.CornflowerBlue
            Button3.ForeColor = Color.CornflowerBlue
            Button4.ForeColor = Color.CornflowerBlue

            Button6.ForeColor = Color.CornflowerBlue
            Button7.ForeColor = Color.CornflowerBlue
            Button8.ForeColor = Color.CornflowerBlue
            Label1.ForeColor = Color.CornflowerBlue
            Label2.ForeColor = Color.CornflowerBlue
            Label3.ForeColor = Color.CornflowerBlue
            Label4.ForeColor = Color.CornflowerBlue
            Label5.ForeColor = Color.CornflowerBlue
            Label6.ForeColor = Color.CornflowerBlue
            Label7.ForeColor = Color.CornflowerBlue
            Label8.ForeColor = Color.CornflowerBlue
            Label9.ForeColor = Color.CornflowerBlue

            Label11.ForeColor = Color.CornflowerBlue
            Label12.ForeColor = Color.CornflowerBlue
            Label13.ForeColor = Color.CornflowerBlue
            Label14.ForeColor = Color.CornflowerBlue
            Label15.ForeColor = Color.CornflowerBlue
            CheckBox1.ForeColor = Color.CornflowerBlue
            CheckBox2.ForeColor = Color.CornflowerBlue
            CheckBox3.ForeColor = Color.CornflowerBlue
            CheckBox4.ForeColor = Color.CornflowerBlue
            CheckBox5.ForeColor = Color.CornflowerBlue
            CheckBox6.ForeColor = Color.CornflowerBlue
            TextBox1.ForeColor = Color.CornflowerBlue
            TextBox2.ForeColor = Color.CornflowerBlue
            TextBox3.ForeColor = Color.CornflowerBlue
            ListBox1.ForeColor = Color.CornflowerBlue
            Form1.Button1.ForeColor = Color.CornflowerBlue
            Form1.Button2.ForeColor = Color.CornflowerBlue
            Form1.Button3.ForeColor = Color.CornflowerBlue
            Form1.Button4.ForeColor = Color.CornflowerBlue
            Form1.Button5.ForeColor = Color.CornflowerBlue
            Form1.Button6.ForeColor = Color.CornflowerBlue
            Form1.Button7.ForeColor = Color.CornflowerBlue
            Form1.Button8.ForeColor = Color.CornflowerBlue
            Form1.CheckBox1.ForeColor = Color.CornflowerBlue
            Form1.TextBox1.ForeColor = Color.CornflowerBlue
            Form1.ListBox1.ForeColor = Color.CornflowerBlue
            Form1.ListBox2.ForeColor = Color.CornflowerBlue
            Form1.ListBox3.ForeColor = Color.CornflowerBlue
            Form1.ListBox4.ForeColor = Color.CornflowerBlue
        ElseIf ComboBox1.SelectedItem = "Tema2" Then
            My.Settings.Tem1 = False
            My.Settings.Tem2 = True
            My.Settings.Tem3 = False
            My.Settings.Save()
            Button1.ForeColor = Color.DarkRed
            Button2.ForeColor = Color.DarkRed
            Button3.ForeColor = Color.DarkRed
            Button4.ForeColor = Color.DarkRed

            Button6.ForeColor = Color.DarkRed
            Button7.ForeColor = Color.DarkRed
            Button8.ForeColor = Color.DarkRed
            Label1.ForeColor = Color.DarkRed
            Label2.ForeColor = Color.DarkRed
            Label3.ForeColor = Color.DarkRed
            Label4.ForeColor = Color.DarkRed
            Label5.ForeColor = Color.DarkRed
            Label6.ForeColor = Color.DarkRed
            Label7.ForeColor = Color.DarkRed
            Label8.ForeColor = Color.DarkRed
            Label9.ForeColor = Color.DarkRed

            Label11.ForeColor = Color.DarkRed
            Label12.ForeColor = Color.DarkRed
            Label13.ForeColor = Color.DarkRed
            Label14.ForeColor = Color.DarkRed
            Label15.ForeColor = Color.DarkRed
            CheckBox1.ForeColor = Color.DarkRed
            CheckBox2.ForeColor = Color.DarkRed
            CheckBox3.ForeColor = Color.DarkRed
            CheckBox4.ForeColor = Color.DarkRed
            CheckBox5.ForeColor = Color.DarkRed
            CheckBox6.ForeColor = Color.DarkRed
            TextBox1.ForeColor = Color.DarkRed
            TextBox2.ForeColor = Color.DarkRed
            TextBox3.ForeColor = Color.DarkRed
            ListBox1.ForeColor = Color.DarkRed
            Form1.Button1.ForeColor = Color.DarkRed
            Form1.Button2.ForeColor = Color.DarkRed
            Form1.Button3.ForeColor = Color.DarkRed
            Form1.Button4.ForeColor = Color.DarkRed
            Form1.Button5.ForeColor = Color.DarkRed
            Form1.Button6.ForeColor = Color.DarkRed
            Form1.Button7.ForeColor = Color.DarkRed
            Form1.Button8.ForeColor = Color.DarkRed
            Form1.CheckBox1.ForeColor = Color.DarkRed
            Form1.TextBox1.ForeColor = Color.DarkRed
            Form1.ListBox1.ForeColor = Color.DarkRed
            Form1.ListBox2.ForeColor = Color.DarkRed
            Form1.ListBox3.ForeColor = Color.DarkRed
            Form1.ListBox4.ForeColor = Color.DarkRed

        ElseIf ComboBox1.SelectedItem = "Tema3" Then
            My.Settings.Tem1 = False
            My.Settings.Tem2 = False
            My.Settings.Tem3 = True
            My.Settings.Save()
            Button1.ForeColor = Color.Lime
            Button2.ForeColor = Color.Lime
            Button3.ForeColor = Color.Lime
            Button4.ForeColor = Color.Lime

            Button6.ForeColor = Color.Lime
            Button7.ForeColor = Color.Lime
            Button8.ForeColor = Color.Lime
            Label1.ForeColor = Color.Lime
            Label2.ForeColor = Color.Lime
            Label3.ForeColor = Color.Lime
            Label4.ForeColor = Color.Lime
            Label5.ForeColor = Color.Lime
            Label6.ForeColor = Color.Lime
            Label7.ForeColor = Color.Lime
            Label8.ForeColor = Color.Lime
            Label9.ForeColor = Color.Lime

            Label11.ForeColor = Color.Lime
            Label12.ForeColor = Color.Lime
            Label13.ForeColor = Color.Lime
            Label14.ForeColor = Color.Lime
            Label15.ForeColor = Color.Lime
            CheckBox1.ForeColor = Color.Lime
            CheckBox2.ForeColor = Color.Lime
            CheckBox3.ForeColor = Color.Lime
            CheckBox4.ForeColor = Color.Lime
            CheckBox5.ForeColor = Color.Lime
            CheckBox6.ForeColor = Color.Lime
            TextBox1.ForeColor = Color.Lime
            TextBox2.ForeColor = Color.Lime
            TextBox3.ForeColor = Color.Lime
            ListBox1.ForeColor = Color.Lime
            Form1.Button1.ForeColor = Color.Lime
            Form1.Button2.ForeColor = Color.Lime
            Form1.Button3.ForeColor = Color.Lime
            Form1.Button4.ForeColor = Color.Lime
            Form1.Button5.ForeColor = Color.Lime
            Form1.Button6.ForeColor = Color.Lime
            Form1.Button7.ForeColor = Color.Lime
            Form1.Button8.ForeColor = Color.Lime
            Form1.CheckBox1.ForeColor = Color.Lime
            Form1.TextBox1.ForeColor = Color.Lime
            Form1.ListBox1.ForeColor = Color.Lime
            Form1.ListBox2.ForeColor = Color.Lime
            Form1.ListBox3.ForeColor = Color.Lime
            Form1.ListBox4.ForeColor = Color.Lime
        ElseIf ComboBox1.SelectedItem = "Tema4" Then

        ElseIf ComboBox1.SelectedItem = "Tema5" Then

        End If


    End Sub
#End Region

#Region "Tema"
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub


#End Region

#Region "Güncelleme"
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            My.Computer.FileSystem.DeleteFile("C:\MiniYouTube\surum.txt", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
            Dim client As New System.Net.WebClient
            client.DownloadFile("https://www.dropbox.com/s/z8jzieikg4rx8ny/surum.txt?dl=1", "C:\MiniYouTube\surum.txt")
            Dim okuyucu As New IO.StreamReader("C:\MiniYouTube\surum.txt")
            Dim okunan As String = okuyucu.ReadLine
            okuyucu.Close()
            If okunan <> My.Settings.surum Then
                MsgBox("Güncelleme mevcut program indirilip yeniden başlatılacak")
                Process.Start("C:\MiniYouTube\guncelleme.exe")

            Else
                MsgBox("Program Güncel")
            End If
        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "İndirme"
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim indirmelink As HtmlElement = WebBrowser1.Document.GetElementById("dl_link")
        Dim link As HtmlElementCollection = indirmelink.GetElementsByTagName("a")
        If indirmelink.InnerText = "Download" Then
            Dim url As String = link(0).GetAttribute("href")
        End If
        WebBrowser1.Navigate(url)
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser1.Document.GetElementById("submit").InvokeMember("click")
        MsgBox("Mp3 e dönüştürüldü")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        WebBrowser1.Document.GetElementById("youtube-url").SetAttribute("value", TextBox3.Text)

    End Sub
#End Region

    
    
End Class