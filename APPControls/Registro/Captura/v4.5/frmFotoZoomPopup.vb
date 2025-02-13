Imports System.IO

Namespace Registro
    Public Class frmFotoZoomPopup
#Region "Propiedades"
        Private strFileName As String = ""
        Private imgImagen As System.Drawing.Image        
        Public Property _pImagen() As System.Drawing.Image
            Get
                Return imgImagen
            End Get
            Set(ByVal value As System.Drawing.Image)
                imgImagen = value
            End Set
        End Property
#End Region
#Region "Otros"
        Private Sub ValoresXDefault()
            ListarImagen()
        End Sub
        Private Sub ListarImagen()

            If Me._pImagen Is Nothing Then
                Me.ptbZoom.Image = My.Resources.sin_foto
            Else

                Dim intAncho As Integer = 0
                Dim intAlto As Integer = 0

                intAncho = Me._pImagen.Width
                intAlto = Me._pImagen.Height

                Me.lblSize.Text = "Ancho: " & intAncho & " por Alto : " & intAlto

                If intAncho > My.Computer.Screen.WorkingArea.Width Then
                    intAncho = My.Computer.Screen.WorkingArea.Width
                End If

                If intAlto > My.Computer.Screen.WorkingArea.Height Then
                    intAlto = My.Computer.Screen.WorkingArea.Height
                End If

                Me.Width = intAncho
                Me.Height = intAlto

                Me.ptbZoom.Image = Me._pImagen
            End If

        End Sub
#End Region
        
        Private Sub frmFotoZoomPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            ValoresXDefault()
        End Sub

        Private Sub frmFotoZoomPopup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace