Namespace Registro.Main.Antecedentes
    Public Class frmTipoCertAntecedente
#Region "Enum"
        Public Enum enumTipoCombo
            Usuario = 0
            Licencia = 1
        End Enum
#End Region

#Region "Propiedades"
        Public Property _TipoAntecedente() As Integer
            Get
                Dim id As Integer = -1

                Select Case cbbTipoCertificadoAJ.Text
                    Case "CERTIFICADO NEGATIVO"
                        id = 1
                    Case "NO REGISTRA PROC. PENDIENTE"
                        id = 2
                    Case "CERTIFICADO POSITIVO"
                        id = 3
                    Case Else
                        id = 0
                End Select
                Return id
            End Get
            Set(value As Integer)
                cbbTipoCertificadoAJ.SelectedIndex = value
            End Set
        End Property
#End Region

#Region "Propiedades_Publicas"
        Public Property _TipoCombo() As enumTipoCombo = enumTipoCombo.Usuario
#End Region
#Region "Propiedades_Busqueda"
        Private intRegion As Integer = -1
        Private intPenal As Integer = -1
        Public Property BRegion() As Integer
            Get
                Return intRegion
            End Get
            Set(ByVal value As Integer)
                intRegion = value
            End Set
        End Property
        Public Property BPenal() As Integer
            Get
                Return intPenal
            End Get
            Set(ByVal value As Integer)
                intPenal = value
            End Set
        End Property
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            If Me._TipoAntecedente <= 0 Then
                MessageBox.Show("Seleccione tipo de certificado", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbTipoCertificadoAJ.Focus()
                Return False
            End If

            Return True

        End Function

        Private Sub AOK()

            If Me.Validar = False Then
                Exit Sub
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            Me._TipoAntecedente = 0
            cbbTipoCertificadoAJ.Focus()
        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AOK()
        End Sub

        Private Sub frmPenalPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            ValoresxDefault()
        End Sub


        Private Sub frmTipoCertAntecedente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then Me.Close()
        End Sub
    End Class
End Namespace