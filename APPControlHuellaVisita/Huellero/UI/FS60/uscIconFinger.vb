Imports System.Drawing

Public Class uscIconFinger

    Private Sub uscFingerIcon_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim r As Rectangle = New Rectangle(0, 0, Me.Width + 3, Me.Height + 3)
        Dim objDraw As New System.Drawing.Drawing2D.GraphicsPath
        'objDraw.AddEllipse(0, 0, 50, PictureBox1.Height)

        Dim d As Integer = 20
        objDraw.AddArc(r.X, r.Y, d, d, 180, 90)
        objDraw.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90)
        d = 1
        objDraw.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90)
        objDraw.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90)

        Me.Region = New Region(objDraw)
    End Sub
End Class
