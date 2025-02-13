Namespace Visita.Movimiento
    Public Class frmDetalle
        Private objEntColMov As Entity.Visita.MovimientoCol = Nothing
        Private objBssMov As Bussines.Visita.Movimiento = Nothing
        Private objBssVisitante As Bussines.Visita.Visitante = Nothing
        Private objBssInterno As Bussines.Visita.Interno = Nothing

#Region "Propiedades_Par"
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _MovimientoID() As Long = -1
        Public Property _MovimientoPadreID() As Long = -1

        Public Property _TipoInterno As Short = -1
        Public Property _InternoID As Long = -1
        Public Property _IDInternoPJ As Integer = -1
        Public Property _VisitanteID() As Long = -1
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaFotoVisitante() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwMenores
                        strValue = .SelectedRows(0).Cells("col_vis_fot_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
#End Region
#Region "Propiedades_Visitante"
        Private Property VisitanteTipoDoc() As String
            Get
                Return Me.lblTipoDoc.Text
            End Get
            Set(ByVal value As String)
                Me.lblTipoDoc.Text = value
            End Set
        End Property
        Private Property VisitanteNumDoc() As String
            Get
                Return Me.lblNumDoc.Text
            End Get
            Set(ByVal value As String)
                Me.lblNumDoc.Text = value
            End Set
        End Property
        Private Property VisitanteApePaterno() As String
            Get
                Return Me.lblApePat.Text
            End Get
            Set(ByVal value As String)
                Me.lblApePat.Text = value
            End Set
        End Property
        Private Property VisitanteApeMaterno() As String
            Get
                Return Me.lblApeMat.Text
            End Get
            Set(ByVal value As String)
                Me.lblApeMat.Text = value
            End Set
        End Property
        Private Property VisitanteNombres() As String
            Get
                Return Me.lblNom.Text
            End Get
            Set(ByVal value As String)
                Me.lblNom.Text = value
            End Set
        End Property
        Private Property VisitanteNacionalidad() As String
            Get
                Return Me.lblNac.Text
            End Get
            Set(ByVal value As String)
                Me.lblNac.Text = value
            End Set
        End Property
        Private Property VisitanteSexo() As String
            Get
                Return Me.lblSexo.Text
            End Get
            Set(ByVal value As String)
                Me.lblSexo.Text = value
            End Set
        End Property
        Private Property VisitanteEdad() As String
            Get
                Return Me.lblEdad.Text
            End Get
            Set(ByVal value As String)
                Me.lblEdad.Text = value
            End Set
        End Property
        Private Property VisitanteFoto As String = ""
#End Region
#Region "Propiedades_Interno"

        Private Property InternoTipoDocumento() As String
            Get
                Return Me.txtIntTipoDoc.Text
            End Get
            Set(ByVal value As String)
                Me.txtIntTipoDoc.Text = value
            End Set
        End Property
        Private Property InternoNumeroDoc() As String
            Get
                Return Me.lblIntNumDoc.Text
            End Get
            Set(ByVal value As String)
                Me.lblIntNumDoc.Text = value
            End Set
        End Property
        Private Property InternoApePaterno() As String
            Get
                Return Me.txtIntApePat.Text
            End Get
            Set(ByVal value As String)
                Me.txtIntApePat.Text = value
            End Set
        End Property
        Private Property InternoApeMaterno() As String
            Get
                Return Me.txtIntApeMat.Text
            End Get
            Set(ByVal value As String)
                Me.txtIntApeMat.Text = value
            End Set
        End Property
        Private Property InternoNombres() As String
            Get
                Return Me.txtIntNom.Text
            End Get
            Set(ByVal value As String)
                Me.txtIntNom.Text = value
            End Set
        End Property
        Private Property InternoNacionalidad() As String
            Get
                Return Me.txtIntNacionalidad.Text
            End Get
            Set(ByVal value As String)
                Me.txtIntNacionalidad.Text = value
            End Set
        End Property
        Private Property InternoSexo() As String
            Get
                Return Me.lblIntSexo.Text
            End Get
            Set(ByVal value As String)
                Me.lblIntSexo.Text = value
            End Set
        End Property
        Private Property InternoEdad() As String
            Get
                Return Me.lblIntEdad.Text
            End Get
            Set(ByVal value As String)
                Me.lblIntEdad.Text = value
            End Set
        End Property
#End Region
#Region "Functions"
        Private Sub ImagenFotoVisitante(ByVal FotoNameExtension As String)

            With Me.UscFotografia1
                '._TipoImagen = APPControls.Foto.uscFotografia.DirectotioTipo.Visitante
                ._ShowFotoVisitante(FotoNameExtension)
            End With

        End Sub
        
        Private Sub ImagenFotoVisitanteMenor(ByVal FotoNameExtension As String)

            With Me.UscFotoMenor
                '._TipoImagen = APPControls.Foto.uscFotografia.DirectotioTipo.Visitante
                .SizeMode = PictureBoxSizeMode.Zoom
                ._ShowFotoVisitante(FotoNameExtension)
            End With

        End Sub
#End Region

#Region "Listar"
        Private Sub ListarVisitante()

            If Me._VisitanteID < 1 Then
                Exit Sub
            End If

            Dim objEnt As Entity.Visita.Visitante = Nothing
            objBssVisitante = New Bussines.Visita.Visitante

            objEnt = objBssVisitante.Listar(Me._VisitanteID)

            With objEnt
                Me._VisitanteID = .Codigo
                Me.VisitanteTipoDoc = .TipoDocumentoNombre
                Me.VisitanteNumDoc = .NumeroDocumento
                Me.VisitanteApePaterno = .ApellidoPaterno
                Me.VisitanteApeMaterno = .ApellidoMaterno
                Me.VisitanteNombres = .Nombres
                Me.VisitanteNacionalidad = .NacionalidadNombre
                Me.VisitanteSexo = .SexoNombre
                Me.VisitanteEdad = .Edad.ToString
                Me.VisitanteFoto = .FotoName
            End With

            ImagenFotoVisitante(Me.VisitanteFoto)
            'ListarMovimientoMenores()
        End Sub
        Private Sub ListarInterno()

            'si no existe ningun interno no mostrar nada
            If Me._InternoID < 1 And Me._IDInternoPJ < 1 Then
                Me.grbDatosInterno.Visible = False
                Me.TabControl1.TabPages.RemoveAt(2)
                Exit Sub
            End If

            Select Case Me._TipoInterno
                Case 1 'internos inpe
                    ListarInternoINPE()

                Case 2 'internos pj
                    ListarInternoPJ()
            End Select

        End Sub

        Private Sub ListarInternoINPE()

            If Me._InternoID < 1 Then
                Exit Sub
            End If

            Dim objEnt As New Entity.Visita.Interno
            objBssInterno = New Bussines.Visita.Interno

            objEnt = objBssInterno.Listar(Me._InternoID)

            With objEnt
                Me.InternoTipoDocumento = .TipoDocumentoNombre
                Me.InternoNumeroDoc = .NumeroDocumento
                Me.InternoApePaterno = .ApellidoPaterno
                Me.InternoApeMaterno = .ApellidoMaterno
                Me.InternoNombres = .Nombres.ToUpper
                Me.InternoNacionalidad = .Nacionalidad.ToUpper
                Me.InternoSexo = .SexoNombre.ToUpper
                Me.InternoEdad = .Edad
            End With

            ListarInternoFotoVersion(Me._InternoID)

        End Sub

        Private Sub ListarInternoPJ()

            If Me._IDInternoPJ < 1 Then                
                Exit Sub
            End If

            Dim objEnt As New Entity.Visita.InternoPJ
            Dim objBssInternoPJ As New Bussines.Visita.InternoPJ

            objEnt = objBssInternoPJ.Listar(Me._IDInternoPJ)

            With objEnt
                Me.InternoTipoDocumento = .TipoDocumento
                Me.InternoNumeroDoc = .NumeroDocumento
                Me.InternoApePaterno = .PrimerApellido
                Me.InternoApeMaterno = .SegundoApellido
                Me.InternoNombres = .PreNombres.ToUpper
                Me.InternoNacionalidad = .Nacionalidad.ToUpper
                Me.InternoSexo = .SexoNombreReadonly.ToUpper
                Me.InternoEdad = .Edad
            End With

            Me.UscFotografia_2v1._cargarImagen(My.Resources.logo_pj02)

        End Sub
        Private Sub ListarMovimiento()

            objBssMov = New Bussines.Visita.Movimiento
            objEntColMov = New Entity.Visita.MovimientoCol

            Dim objEntFiltro As New Entity.Visita.Movimiento

            With objEntFiltro
                .Codigo = Me._MovimientoID                
                '.RegionID = Me._RegionID
                '.PenalID = Me._PenalID
            End With

            objEntColMov = objBssMov.ListarGrillaMonitoreo(objEntFiltro)

            With Me.dgwMovi
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntColMov

                If .RowCount > 0 Then
                    .SelectedRows(0).Selected = False
                End If
            End With

            ListarMovimientoMenores()

        End Sub
        Private Sub ListarMovimientoMenores()

            If Me._MovimientoPadreID < 1 Then
                Exit Sub
            End If

            objBssMov = New Bussines.Visita.Movimiento
            objEntColMov = New Entity.Visita.MovimientoCol

            objEntColMov = objBssMov.ListarMovimientoHijos(Me._MovimientoPadreID)

            With Me.dgwMenores
                .RowsDefaultCellStyle.SelectionForeColor = Color.Black
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AutoGenerateColumns = False
                .DataSource = objEntColMov
            End With

        End Sub
        Private Sub ListarHistorialInterno()

            Dim intTipoBusqueda As APPControls.Visita.uscMovimientosVisitas.enmTipo = APPControls.Visita.uscMovimientosVisitas.enmTipo.Ninguno

            Select Case Me._TipoInterno
                Case 1 'internos inpe
                    intTipoBusqueda = APPControls.Visita.uscMovimientosVisitas.enmTipo.Interno

                Case 2 'internos pj
                    intTipoBusqueda = APPControls.Visita.uscMovimientosVisitas.enmTipo.InternoPJ
            End Select

            With Me.UscMovimientosVisitas1
                ._TipoBusqueda = intTipoBusqueda
                ._VisiblePanelFiltro = False
                ._VisiblePanelFiltroAnio = True
                ._InternoID = Me._InternoID
                ._IDInternoPJ = Me._IDInternoPJ
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._VisiblePanelCount = True
                ._VisibleCountVisitante = True
                ._LoadUsc()
            End With

        End Sub
        Private Sub ListarHistorialVisitante()

            With Me.UscMovimientosVisitas2
                ._TipoBusqueda = APPControls.Visita.uscMovimientosVisitas.enmTipo.Visitante
                ._VisiblePanelFiltro = False
                ._VisiblePanelFiltroAnio = True
                ._VisitanteID = Me._VisitanteID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._VisiblePanelCount = True
                ._VisibleCountInterno = True
                ._LoadUsc()
            End With

        End Sub
        Private Sub Listar()

            If Me._MovimientoID < 1 Then
                Exit Sub
            End If

            ListarVisitante()
            ListarInterno()
            ListarMovimiento()

        End Sub
#End Region
#Region "ListarFoto"
        Private Sub ListarInternoFotoVersion(ByVal InternoID As Integer)

            If InternoID < 1 Then
                Exit Sub
            End If

            If Me.UscFotografia_2v1._CheckImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            Me.UscFotografia_2v1._showFotoInternoPrincipal(InternoID, 2)

            If UscFotografia_2v1._HasImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
            End If

        End Sub
        'Private Sub ListarInternoFotov(ByVal InternoID As Integer)

        '    If InternoID < 1 Then
        '        Exit Sub
        '    End If

        '    If Me.UscFotografia2._CheckImagen = False Then
        '        Me.UscFotografia2._Limpiar()
        '        Exit Sub
        '    End If

        '    Dim objBssFoto As New Bussines.Registro.InternoFoto
        '    Dim objEnt As New Entity.Registro.InternoFoto
        '    Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente(InternoID)

        '    Dim intImagen As Integer = -1
        '    Dim intNombreImagen As String = ""

        '    objBssFoto = New Bussines.Registro.InternoFoto
        '    objEnt = objBssFoto.Listar(intCodigo)

        '    If objEnt.Codigo > 0 Then

        '        With objEnt
        '            intImagen = .PFrenteID
        '            intNombreImagen = .PFrenteName
        '        End With

        '        Me.UscFotografia2._ShowFotoInterno(intImagen, intNombreImagen)
        '    Else
        '        Me.UscFotografia2._Limpiar()
        '    End If

        'End Sub
        'Private Sub ListarInternoFotov5(ByVal InternoID As Integer)

        '    If InternoID < 1 Then
        '        Exit Sub
        '    End If

        '    If Me.UscFotografia_2v1._CheckImagen = False Then
        '        Me.UscFotografia_2v1._Limpiar()
        '        Exit Sub
        '    End If

        '    Dim objBssFoto As New Bussines.Registro.InternoFoto
        '    Dim objEnt As New Entity.Registro.InternoFoto
        '    Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente2(InternoID)
        '    Dim intImagen As Integer = -1

        '    objBssFoto = New Bussines.Registro.InternoFoto
        '    objEnt = objBssFoto.ListarGrilla(intCodigo)

        '    If objEnt.Codigo > 0 Then

        '        With objEnt
        '            intImagen = .PFrenteID
        '        End With

        '        Me.UscFotografia_2v1._ShowFotoInterno(intImagen)
        '    Else
        '        Me.UscFotografia_2v1._Limpiar()
        '    End If

        'End Sub
        'Private Sub ListarInternoFotoVersion(ByVal InternoID As Integer)

        '    Dim blnVersion5 As Boolean = Bussines.General.Penal.Version5(Me._PenalID)

        '    If blnVersion5 = True Then
        '        ListarInternoFotov5(InternoID)
        '        Me.UscFotografia_2v1.BringToFront()
        '    Else
        '        ListarInternoFotov(InternoID)
        '        Me.UscFotografia2.BringToFront()

        '    End If

        'End Sub
#End Region
#Region "Form"
        Private Sub FRM_FotoMenor()

            Me.UscFotoMenor._Show_FotoAutoSize()

        End Sub
#End Region
        Private Sub frmDetalle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            Me.WindowState = FormWindowState.Maximized

        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub frmDetalle_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Listar()

        End Sub

        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

            Select Case Me.TabControl1.SelectedIndex
                Case 0 'movimiento
                    ListarMovimiento()
                Case 1 'historial visitante 
                    ListarHistorialVisitante()
                Case 2 'historial interno
                    ListarHistorialInterno()
            End Select

        End Sub

        Private Sub dgwMovi_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellContentClick

        End Sub

        Private Sub dgwMovi_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwMovi.CellFormatting

            With Me.dgwMovi
                Select Case e.ColumnIndex
                    Case .Columns("col_fec_ing").Index, .Columns("col_fec_sal").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                        Else
                            e.Value = ""
                        End If                               
                End Select
            End With

        End Sub

        Private Sub dgwMenores_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMenores.CellClick

            '/*iconos*/
            With Me.dgwMenores
                If e.RowIndex = -1 Then Exit Sub
                If .RowCount > 0 Then
                    '/*icono ver*/
                    Select Case e.ColumnIndex
                        Case .Columns("col_ver_fot").Index
                            FRM_FotoMenor()
                    End Select
                End If
            End With

        End Sub

        Private Sub dgwMenores_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMenores.CellEnter

            If Me.dgwMenores.RowCount > 0 Then
                ImagenFotoVisitanteMenor(Me.GrillaFotoVisitante)
            End If

        End Sub
    End Class

End Namespace
