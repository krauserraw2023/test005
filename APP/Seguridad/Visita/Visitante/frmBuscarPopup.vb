Namespace Visita.Visitante
    Public Class frmBuscarPopup
        Private objBss As Bussines.Visita.Visitante = Nothing
        Private objEntCol As Entity.Visita.VisitanteCol = Nothing
#Region "Propiedades_Par"
        Public Property _RegionID() As Integer
        Public Property _PenalID() As Integer
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaVisitanteID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_vis_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaVisitanteApellidosyNombres() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_ape_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Propiedades"
        Private Property TipoDocumentoID() As Integer
            Get
                Return Me.cbbTipoDoc.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
            End Set
        End Property
        Private Property NumeroDocumento() As String
            Get
                Return Me.txtNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNumDoc.Text = value
            End Set
        End Property
        Private Property Apellidos() As String
            Get
                Return Me.txtApe.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApe.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Return"
        Public ReadOnly Property _GrillaVisitanteID() As Integer
            Get
                Return Me.GrillaVisitanteID
            End Get
        End Property
        Public ReadOnly Property _GrillaVisitanteApellidosyNombres() As String
            Get
                Return Me.GrillaVisitanteApellidosyNombres
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub Combo()

            With cbbTipoDoc
                ._Todos = True
                .LoadUsc()
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub Listar()

            objBss = New Bussines.Visita.Visitante
            objEntCol = New Entity.Visita.VisitanteCol

            Dim objEntFiltro As New Entity.Visita.Visitante

            With objEntFiltro
                .TipoDocumentoID = Me.TipoDocumentoID
                .NumeroDocumento = Me.NumeroDocumento                
                .VisitanteApellidosyNombres = Me.Apellidos
                .Nombres = Me.Nombres
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            objEntCol = objBss.ListarGrillaPopup(objEntFiltro)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.lblReg.Text = .RowCount()
            End With
        End Sub
#End Region
#Region "Accion"
        Private Sub AOK()

            If Me.GrillaVisitanteID > 0 Then
                Me.DialogResult = DialogResult.OK
            End If

        End Sub
        Private Sub ALimpiar()
            Me.TipoDocumentoID = 10 'dni
            Me.Apellidos = ""
            Me.Nombres = ""

            Me.txtApe.Focus()
        End Sub

#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            Combo()
            Me.TipoDocumentoID = 10 'dni

        End Sub
#End Region
        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click

            Listar()


        End Sub

        Private Sub tsbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiar.Click

            ALimpiar()

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

            AOK()

        End Sub

        Private Sub frmBuscarPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If Me.dgwGrilla.RowCount > 0 Then
                AOK()
            End If

        End Sub

        Private Sub txtNumDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
            Handles txtNumDoc.KeyPress, _
            txtApe.KeyPress, _
            txtNom.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Listar()
            End If

        End Sub

        Private Sub frmBuscarPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Me.txtApe.Focus()

        End Sub
    End Class
End Namespace
