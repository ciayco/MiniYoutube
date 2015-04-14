Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim client As New System.Net.WebClient
            ProgressBar1.Value = 25

            Dim processes As Process() = Process.GetProcessesByName("MiniYouTube")
            For Each process As Process In processes
                process.Kill()
            Next

            ProgressBar1.Value = 50


            client.DownloadFile("https://www.dropbox.com/s/z2qog0sasy4yb8s/MiniYouTube.exe?dl=1", "C:\MiniYouTube\MiniYouTube.exe")
            ProgressBar1.Value = 100

            Process.Start("C:\MiniYouTube\MiniYouTube.exe")
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class
