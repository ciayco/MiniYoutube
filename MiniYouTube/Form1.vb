
Public Class Form1
    Dim link As String
    Dim chr As String = "yt-uix-tile-link yt-ui-ellipsis yt-ui-ellipsis-2 yt-uix-sessionlink     spf-link "
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim indirme As Integer

#Region "Browser hazırlama"
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        Dim x As Integer
        If My.Settings.Vs1 = True Then
            x = 10
        ElseIf My.Settings.Vs2 = True Then
            x = 20
        ElseIf My.Settings.Vs3 = True Then
            x = 30
        ElseIf My.Settings.Vs4 = True Then
            x = 40
        Else
            x = 10
        End If

        Dim ec As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("a")

        For Each element As HtmlElement In ec

            If element.GetAttribute("classname") = (chr) Then
                If Not ListBox1.Items.Count = x Then
                    ListBox1.Items.Add(element.GetAttribute("href"))
                    ListBox2.Items.Add(element.InnerText)
                End If
            End If

        Next

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        ListBox1.SelectedIndex = ListBox2.SelectedIndex

    End Sub
#End Region

#Region "Form yüklemeleri"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.Visible = True
        Try
            Dim okuyucu As New IO.StreamReader("C:\MiniYouTube\surum.txt")
            Dim okunan As String = okuyucu.ReadLine
            okuyucu.Close()
            My.Settings.surum = okunan
        Catch ex As Exception
            Dim yazıcı As New IO.StreamWriter("C:\MiniYouTube\surum.txt")
            yazıcı.WriteLine()
        End Try

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is ListBox Then
                Dim r As New Rectangle(-15, 0, ListBox2.Width, ListBox2.Height)
                Dim gp As New System.Drawing.Drawing2D.GraphicsPath()
                Dim d As Integer = 50
                gp.AddArc(r.X, r.Y, d, d, 180, 90)
                gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90)
                gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90)
                gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90)
                ctrl.Region = New Region(gp)
            End If
        Next
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                If ctrl Is Button3 Or ctrl Is Button6 Or ctrl Is Button8 Then

                Else

                    Dim r As New Rectangle(0, 0, ListBox2.Width, ListBox2.Height)
                    Dim gp As New System.Drawing.Drawing2D.GraphicsPath()
                    Dim d As Integer = 50
                    gp.AddArc(r.X, r.Y, d, d, 180, 90)
                    gp.AddArc(r.X + r.Width - d, r.Y, d, d, 200, 90)
                    gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90)
                    gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90)
                    ctrl.Region = New Region(gp)
                End If
            End If
        Next


        Me.Left = My.Settings.Px
        Me.Top = My.Settings.Py
        Me.TopMost = My.Settings.top
        AxShockwaveFlash1.AllowFullScreen = True
        AxShockwaveFlash1.BackgroundColor = "0"
        If My.Settings.Tem2 = True Then
            Form2.Button1.ForeColor = Color.DarkRed
            Form2.Button2.ForeColor = Color.DarkRed
            Form2.Button3.ForeColor = Color.DarkRed
            Form2.Button4.ForeColor = Color.DarkRed
            Form2.Button7.ForeColor = Color.DarkRed
            Form2.Label1.ForeColor = Color.DarkRed
            Form2.Label2.ForeColor = Color.DarkRed
            Form2.Label3.ForeColor = Color.DarkRed
            Form2.Label4.ForeColor = Color.DarkRed
            Form2.Label5.ForeColor = Color.DarkRed
            Form2.Label6.ForeColor = Color.DarkRed
            Form2.Label7.ForeColor = Color.DarkRed
            Form2.Label8.ForeColor = Color.DarkRed
            Form2.Label9.ForeColor = Color.DarkRed

            Form2.Label11.ForeColor = Color.DarkRed
            Form2.Label12.ForeColor = Color.DarkRed
            Form2.Label13.ForeColor = Color.DarkRed
            Form2.Label14.ForeColor = Color.DarkRed
            Form2.Label15.ForeColor = Color.DarkRed
            Form2.CheckBox1.ForeColor = Color.DarkRed
            Form2.CheckBox2.ForeColor = Color.DarkRed
            Form2.CheckBox3.ForeColor = Color.DarkRed
            Form2.CheckBox4.ForeColor = Color.DarkRed
            Form2.CheckBox5.ForeColor = Color.DarkRed
            Form2.CheckBox6.ForeColor = Color.DarkRed
            Form2.TextBox1.ForeColor = Color.DarkRed
            Form2.TextBox2.ForeColor = Color.DarkRed
            Form2.ListBox1.ForeColor = Color.DarkRed
            Button1.ForeColor = Color.DarkRed
            Button2.ForeColor = Color.DarkRed
            Button3.ForeColor = Color.DarkRed
            Button4.ForeColor = Color.DarkRed
            Button5.ForeColor = Color.DarkRed
            Button6.ForeColor = Color.DarkRed
            Button7.ForeColor = Color.DarkRed
            Button8.ForeColor = Color.DarkRed
            CheckBox1.ForeColor = Color.DarkRed
            TextBox1.ForeColor = Color.DarkRed
            ListBox1.ForeColor = Color.DarkRed
            ListBox2.ForeColor = Color.DarkRed
            ListBox3.ForeColor = Color.DarkRed
            ListBox4.ForeColor = Color.DarkRed
        ElseIf My.Settings.Tem3 = True Then
            Form2.Button1.ForeColor = Color.Lime
            Form2.Button2.ForeColor = Color.Lime
            Form2.Button3.ForeColor = Color.Lime
            Form2.Button4.ForeColor = Color.Lime

            Form2.Button7.ForeColor = Color.Lime
            Form2.Label1.ForeColor = Color.Lime
            Form2.Label2.ForeColor = Color.Lime
            Form2.Label3.ForeColor = Color.Lime
            Form2.Label4.ForeColor = Color.Lime
            Form2.Label5.ForeColor = Color.Lime
            Form2.Label6.ForeColor = Color.Lime
            Form2.Label7.ForeColor = Color.Lime
            Form2.Label8.ForeColor = Color.Lime
            Form2.Label9.ForeColor = Color.Lime

            Form2.Label11.ForeColor = Color.Lime
            Form2.Label12.ForeColor = Color.Lime
            Form2.Label13.ForeColor = Color.Lime
            Form2.Label14.ForeColor = Color.Lime
            Form2.Label15.ForeColor = Color.Lime
            Form2.CheckBox1.ForeColor = Color.Lime
            Form2.CheckBox2.ForeColor = Color.Lime
            Form2.CheckBox3.ForeColor = Color.Lime
            Form2.CheckBox4.ForeColor = Color.Lime
            Form2.CheckBox5.ForeColor = Color.Lime
            Form2.CheckBox6.ForeColor = Color.Lime
            Form2.TextBox1.ForeColor = Color.Lime
            Form2.TextBox2.ForeColor = Color.Lime
            Form2.ListBox1.ForeColor = Color.Lime
            Button1.ForeColor = Color.Lime
            Button2.ForeColor = Color.Lime
            Button3.ForeColor = Color.Lime
            Button4.ForeColor = Color.Lime
            Button5.ForeColor = Color.Lime
            Button6.ForeColor = Color.Lime
            Button7.ForeColor = Color.Lime
            Button8.ForeColor = Color.Lime
            CheckBox1.ForeColor = Color.Lime
            TextBox1.ForeColor = Color.Lime
            ListBox1.ForeColor = Color.Lime
            ListBox2.ForeColor = Color.Lime
            ListBox3.ForeColor = Color.Lime
            ListBox4.ForeColor = Color.Lime
        End If


    End Sub
#End Region

#Region "Button olayları"
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

        WebBrowser1.Navigate("http://www.youtube.com/results?filters=video&search_query=" & TextBox1.Text & "&lclk=video")
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ListBox2.Visible = True Then
            'player için link
            link = ListBox1.SelectedItem
            link = link.Replace("watch?v=", "v/")
            AxShockwaveFlash1.Movie = link & "&autoplay=1" & "&loop=1" & "&showsearch=0"

        End If
        If ListBox3.Visible = True Then
            'liste için link
            link = ListBox4.SelectedItem
            link = link.Replace("watch?v=", "v/")
            AxShockwaveFlash1.Movie = link & "&autoplay=1" & "&loop=1" & "&showsearch=0"

        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CheckBox1.Checked = False Then
            CheckBox1.Checked = True
            Button4.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Button5.Visible = False
            Button7.Visible = False
            ListBox2.Visible = False
            TextBox1.Visible = False
            ListBox3.Visible = False

        Else
            CheckBox1.Checked = False
            Button4.Visible = True
            Button1.Visible = True
            Button2.Visible = True
            Button5.Visible = True
            Button7.Visible = True

            ListBox2.Visible = True
            ListBox3.Visible = False
            TextBox1.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        NotifyIcon1.Visible = True
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()

    End Sub

    Private Sub GösterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GösterToolStripMenuItem.Click
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Me.Close()
    End Sub
#End Region

#Region "Türkçe karakter düzeltme"
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If (e.KeyChar = ("ş")) Then

            e.KeyChar = "s"

        End If
        If (e.KeyChar = ("ı")) Then

            e.KeyChar = "i"

        End If
        If (e.KeyChar = ("ö")) Then

            e.KeyChar = "o"

        End If
        If (e.KeyChar = ("ü")) Then

            e.KeyChar = "u"

        End If
        If (e.KeyChar = ("ç")) Then

            e.KeyChar = "c"

        End If
        If (e.KeyChar = ("ğ")) Then

            e.KeyChar = "g"

        End If

    End Sub
#End Region

#Region "Playlist eklemeleri"
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox3.Items.Add(My.Settings.S1a)
        ListBox4.Items.Add(My.Settings.S1)
        ListBox3.Items.Add(My.Settings.S2a)
        ListBox4.Items.Add(My.Settings.S2)
        ListBox3.Items.Add(My.Settings.S3a)
        ListBox4.Items.Add(My.Settings.S3)
        ListBox3.Items.Add(My.Settings.S4a)
        ListBox4.Items.Add(My.Settings.S4)
        ListBox3.Items.Add(My.Settings.S5a)
        ListBox4.Items.Add(My.Settings.S5)
        ListBox3.Items.Add(My.Settings.S6a)
        ListBox4.Items.Add(My.Settings.S6)
        ListBox3.Items.Add(My.Settings.S7a)
        ListBox4.Items.Add(My.Settings.S7)
        ListBox3.Items.Add(My.Settings.S8a)
        ListBox4.Items.Add(My.Settings.S8)
        ListBox3.Items.Add(My.Settings.S9a)
        ListBox4.Items.Add(My.Settings.S9)
        ListBox3.Items.Add(My.Settings.S10a)
        ListBox4.Items.Add(My.Settings.S10)
        If CheckBox1.Checked = True Then
            CheckBox1.Checked = False
            Button4.Visible = True
            Button1.Visible = True
            Button2.Visible = True
            Button5.Visible = True
            Button7.Visible = True

            ListBox2.Visible = False
            ListBox3.Visible = True
            TextBox1.Visible = True
        Else
            CheckBox1.Checked = True
            ListBox2.Visible = False
            ListBox3.Visible = True
        End If

    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ListBox3.Items.Add(ListBox2.SelectedItem())
        ListBox4.Items.Add(ListBox1.SelectedItem())
        If My.Settings.S1 = "" Then
            My.Settings.S1a = ListBox2.SelectedItem()
            My.Settings.S1 = ListBox1.SelectedItem()
            My.Settings.Save()
            Exit Sub
        ElseIf My.Settings.S2 = "" Then
            My.Settings.S2a = ListBox2.SelectedItem()
            My.Settings.S2 = ListBox1.SelectedItem()
            My.Settings.Save()
            Exit Sub
        ElseIf My.Settings.S3 = "" Then
            My.Settings.S3a = ListBox2.SelectedItem()
            My.Settings.S3 = ListBox1.SelectedItem()
            My.Settings.Save()
            Exit Sub
        ElseIf My.Settings.S4 = "" Then
            My.Settings.S4a = ListBox2.SelectedItem()
            My.Settings.S4 = ListBox1.SelectedItem()
            My.Settings.Save()
            Exit Sub
        ElseIf My.Settings.S5 = "" Then
            My.Settings.S5a = ListBox2.SelectedItem()
            My.Settings.S5 = ListBox1.SelectedItem()
            My.Settings.Save()
            Exit Sub
        ElseIf My.Settings.S6 = "" Then
            My.Settings.S6a = ListBox2.SelectedItem()
            My.Settings.S6 = ListBox1.SelectedItem()
            My.Settings.Save()
            Exit Sub
        ElseIf My.Settings.S7 = "" Then
            My.Settings.S7a = ListBox2.SelectedItem()
            My.Settings.S7 = ListBox1.SelectedItem()
            My.Settings.Save()
            Exit Sub
        ElseIf My.Settings.S8 = "" Then
            My.Settings.S8a = ListBox2.SelectedItem()
            My.Settings.S8 = ListBox1.SelectedItem()
            My.Settings.Save()
            Exit Sub
        ElseIf My.Settings.S9 = "" Then
            My.Settings.S9a = ListBox2.SelectedItem()
            My.Settings.S9 = ListBox1.SelectedItem()
            My.Settings.Save()
            Exit Sub
        ElseIf My.Settings.S10 = "" Then
            My.Settings.S10a = ListBox2.SelectedItem()
            My.Settings.S10 = ListBox1.SelectedItem()
            My.Settings.Save()
            Exit Sub
        End If
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        ListBox4.SelectedIndex = ListBox3.SelectedIndex
    End Sub
#End Region

#Region "Taşıma"
    Private Sub Button8_MouseDown(sender As Object, e As MouseEventArgs) Handles Button8.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Button8_MouseMove(sender As Object, e As MouseEventArgs) Handles Button8.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Button8_MouseUp(sender As Object, e As MouseEventArgs) Handles Button8.MouseUp
        drag = False
    End Sub
#End Region

#Region "Sağ tıklama menüsü"

    Private Sub LinkKopyalaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinkKopyalaToolStripMenuItem.Click
        Clipboard.SetText(ListBox1.SelectedItem)
    End Sub

    Private Sub İndirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles İndirToolStripMenuItem.Click
        Form2.Show()
        Form2.TabSayfa.SelectedTab = Form2.TabPage5
        Form2.TextBox3.Text = ListBox1.SelectedItem
    End Sub
#End Region
End Class