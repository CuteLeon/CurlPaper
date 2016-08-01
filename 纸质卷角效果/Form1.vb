Public Class Form1
    Dim BitmapSize As Size = New Size(162, 87)
    Dim StretchX As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Size = New Size(0, 0)
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        StretchX = 0.0
        Do Until StretchX > 1
            PictureBox1.Size = New Size(BitmapSize.Width * StretchX, BitmapSize.Height * StretchX)
            PictureBox1.Left = Me.Width - PictureBox1.Width
            Me.Refresh()
            Threading.Thread.Sleep(30)
            StretchX += 0.05
        Loop
    End Sub
End Class
