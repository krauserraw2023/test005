Namespace Visita

    Public Class frmSancionDetallePopup
#Region "Enum"
        Public Enum enmTipo
            Ninguno = 0
            Visitante = 1
            Interno = 2
        End Enum
#End Region
#Region "Propiedades_Parametricas"
        Private objTipoVista As enmTipo
        Private intCodigo As Integer = -1
        Property _TipoVista() As enmTipo
            Get
                Return objTipoVista
            End Get
            Set(ByVal value As enmTipo)
                objTipoVista = value
            End Set
        End Property
        Property _Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
#End Region
#Region "Propiedades"
        Private Property Mensaje() As String
            Get
                Return Me.lblMensaje.Text
            End Get
            Set(ByVal value As String)
                Me.lblMensaje.Text = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub Listar()

            Select Case Me._TipoVista
                Case enmTipo.Interno
                    Me.Mensaje = "Interno(a) sancionado"
                    ListarInterno()
                Case enmTipo.Visitante
                    Me.Mensaje = "Visitante sancionado"
                    ListarVisitante()
            End Select

        End Sub
        Private Sub ListarVisitante()

            If Me._Codigo < 1 Then
                Exit Sub
            End If

            Dim objBss As New Bussines.Visita.VisitanteSancion
            Dim objEntCol As New Entity.Visita.VisitanteSancionCol

            Dim intCodigo As Integer = objBss.IDUltimaSancionVigente(Me._Codigo, _
                                                                     Legolas.Configuration.Aplication.FechayHora.FechaLong)

            If intCodigo > 0 Then

                objEntCol = objBss.Listar(intCodigo, Me._Codigo, "", "", "", "", _
                0, 0, 0, -1, -1, -1)

                With Me.dgwGrilla
                    '.RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                    .RowsDefaultCellStyle.SelectionBackColor = Color.LightCoral
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False

                    .DataSource = objEntCol
                End With
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "El visitante se encuentra sancionado, pero en este momento no se puede mostrar el detalle")
            End If            

        End Sub
        Private Sub ListarInterno()

            If Me._Codigo < 1 Then
                Exit Sub
            End If

            Dim objBss As New Bussines.Visita.InternoSancion
            Dim objEntCol As New Entity.Visita.InternoSancionCol

            Dim intCodigo As Integer = objBss.IDUltimaSancionVigente(Me._Codigo, _
                                                                     Legolas.Configuration.Aplication.FechayHora.FechaLong)

            objEntCol = objBss.Listar(intCodigo, Me._Codigo, "", "", "", "", _
            0, 0, 0, -1, -1, -1)

            With Me.dgwGrilla
                '.RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionBackColor = Color.LightCoral
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With


        End Sub
#End Region
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub frmSancionDetallePopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Listar()

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub
    End Class
End Namespace