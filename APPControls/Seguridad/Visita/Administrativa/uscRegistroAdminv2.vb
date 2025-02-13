Imports System.IO

Namespace Visita.Administrativa
    Public Class uscRegistroAdminv2
        Private objBssMov As Bussines.Visita.Movimiento = Nothing
        Private objEntTempMovCol As Entity.Visita.MovimientoCol = Nothing
        Private objEntMov As Entity.Visita.Movimiento = Nothing

        '/*propiedades de la tabla configuracion*/
        Public Property _SolicitarAutoRegOrdinario As Boolean = False
        Public Property _HabilitarHuellaDigital As Boolean = False
        Public Property _HabilitarCapHuellaValReniec As Boolean = False
        'reniec
        Public Property _ValidarModuloVisConReniec As Boolean = False
        Public Property _ValidarVisitanteConReniec As Boolean = False
        'migraciones
        Public Property _ValidarVisitanteConMigraciones As Boolean = False
        Public Property _ValidarModuloVisConMigraciones As Boolean = False
        '/**************/

#Region "Eventos"
        Public Event _Click_BuscarVisitante()
#End Region

#Region "Propiedades_Publicas"
        Private intRegionID As Integer = -1
        Private strRegionNombre As String = ""
        Private intPenalID As Integer = -1
        Private strPenalNombre As String = ""
        Private lngFechaVisita As Long = 0
        Public Property _RegionID() As Integer
            Get
                Return intRegionID
            End Get
            Set(ByVal value As Integer)
                intRegionID = value
            End Set
        End Property
        Public Property _RegionNombre() As String
            Get
                Return strRegionNombre
            End Get
            Set(ByVal value As String)
                strRegionNombre = value
            End Set
        End Property
        Public Property _PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
            End Set
        End Property
        Public Property _PenalNombre() As String
            Get
                Return strPenalNombre
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property
        Public Property _FechaVisita() As Long
            Get
                Return lngFechaVisita
            End Get
            Set(ByVal value As Long)
                lngFechaVisita = value
            End Set
        End Property
#End Region
#Region "Propiedades"
        Private strHoraIngreso As String = ""
        Private intParentescoID As Integer = -1
        Private strParentescoNombre As String = ""
        Private ReadOnly Property RegimenVisitaID As Integer
            Get
                Return 4 'administrativo
            End Get
        End Property
        Private ReadOnly Property TipoVisitaID() As Integer
            Get
                Return 2 'ordinario
            End Get
        End Property
        Private ReadOnly Property TipoMenores As Integer
            Get
                Return 1 'menores
            End Get
        End Property
        Private Property HoraIngreso() As String
            Get
                Return strHoraIngreso
            End Get
            Set(ByVal value As String)
                strHoraIngreso = value
            End Set
        End Property
        Private ReadOnly Property FechaSalida() As Long
            Get
                Return 0
            End Get
        End Property
        Private ReadOnly Property HoraSalida() As String
            Get
                Return "00:00:00"
            End Get
        End Property
        Private Property ParentescoID() As Integer
            Get
                Return intParentescoID
            End Get
            Set(ByVal value As Integer)
                intParentescoID = value
            End Set
        End Property
        Private Property ParentescoNombre() As String
            Get
                Return strParentescoNombre
            End Get
            Set(ByVal value As String)
                strParentescoNombre = value
            End Set
        End Property
        Private Property Observacion() As String
            Get
                Return Me.txtObservacion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObservacion.Text = value
            End Set
        End Property

#End Region
#Region "Propiedades_Visitante"
        Private ReadOnly Property VisitanteID() As Integer
            Get
                Return Me.UscVisitante1._VisitanteIDReturn
            End Get
        End Property
        Private ReadOnly Property VisitanteIDTipoDocumento() As Short
            Get
                Return Me.UscVisitante1._IDTipoDocumento
            End Get
        End Property
        Private ReadOnly Property VisitanteTipoDocumentoNombre() As String
            Get
                Return Me.UscVisitante1._TipoDocumentoNombre
            End Get
        End Property
        Private ReadOnly Property VisitanteNumeroDocumento() As String
            Get
                Return Me.UscVisitante1._NumeroDocumento
            End Get
        End Property
        Private ReadOnly Property VisitantePrimerApellido() As String
            Get
                Return Me.UscVisitante1._PrimerApellido
            End Get
        End Property
        Private ReadOnly Property VisitanteSegundoApellido() As String
            Get
                Return Me.UscVisitante1._SegundoApellido
            End Get
        End Property
        Private ReadOnly Property VisitantePreNombres() As String
            Get
                Return Me.UscVisitante1._PreNombres
            End Get
        End Property
        Private ReadOnly Property VisitanteFechaNacimiento As Long
            Get
                Return Me.UscVisitante1._FechaNacimiento
            End Get
        End Property
        Private ReadOnly Property VisitantePase() As String
            Get
                Return Me.UscVisitante1._PaseNumero
            End Get
        End Property
        Private ReadOnly Property VisitanteDatosConcatenados() As String
            Get
                Return Me.UscVisitante1._ConcatenarPropiedadesVisitante
            End Get
        End Property
        Private ReadOnly Property VisitanteValidadoReniec As Short
            Get
                Return Me.UscVisitante1._VisitanteValidadoReniec
            End Get
        End Property
        Private ReadOnly Property VisitanteIngresaPor As Short
            Get
                Return Me.UscVisitante1._VisitanteIngresaPor
            End Get
        End Property
        Private ReadOnly Property VisitanteNumeroRecaptura As Short
            Get
                Return Me.UscVisitante1._VisitanteNumeroRecaptura
            End Get
        End Property
#End Region
#Region "Temporal"
        Private Sub Temporal_Listar()

            With Me.dgwMovi
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = Nothing
                .DataSource = objEntTempMovCol
            End With

        End Sub
        Private Function Temporal_Grabar() As Boolean

            Dim value As Boolean = False

            If ValidarTemporal() = False Then
                Return value
            End If

            Temporal_Grabar(Me.TipoVisitaID, "", Me.VisitanteID, Me.VisitanteIDTipoDocumento, Me.VisitanteTipoDocumentoNombre, Me.VisitanteNumeroDocumento,
                           Me.VisitantePrimerApellido, Me.VisitanteSegundoApellido,
                            Me.VisitantePreNombres, Me.VisitanteFechaNacimiento, Me.VisitanteValidadoReniec, Me.VisitantePase, Me.VisitanteDatosConcatenados,
                            Me.ParentescoID,
                            Me.ParentescoNombre, Me._FechaVisita, Me.HoraIngreso, Me.VisitanteIngresaPor, Me.VisitanteNumeroRecaptura)

            Temporal_Listar()

            value = True
            Return value
        End Function
        Private Sub Temporal_Grabar(ByVal Tipo As Integer, ByVal TipoNombre As String,
        ByVal VisitanteID As Integer, intTipoDocumento As Short, ByVal TipoDocumentoNombre As String, ByVal NumeroDocumento As String,
        ByVal PrimerApellido As String, ByVal SegundoApellido As String, ByVal PreNombres As String,
        FechaNacimiento As Long, intVisitanteValidadoReniec As Short,
        ByVal PaseNumero As String, VisitanteDatosConcatenados As String, ByVal ParentescoID As Integer, ByVal ParentescoNombre As String,
        ByVal FechaIngreso As Long, ByVal HoraIngreso As String, intVisitanteIngresaPor As Short, intVisitanteNumeroRecaptura As Short)

            If objEntTempMovCol.Count > 0 Then
                If objEntTempMovCol.Find_Visitante(objEntTempMovCol, VisitanteID) = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "El visitante que desea agregar ya existe en la lista")
                    Exit Sub
                End If
            End If

            objEntMov = New Entity.Visita.Movimiento

            With objEntMov
                .Codigo = objEntTempMovCol.Count 'count
                .RegimenVisitaID = Me.RegimenVisitaID
                .TipoID = Tipo
                .TipoNombre = TipoNombre
                .VisitaID = VisitanteID
                .VisitanteIDTipoDocumento = intTipoDocumento
                .VisitanteTipoDocumento = TipoDocumentoNombre
                .VisitanteNumeroDocumento = NumeroDocumento
                .VisitanteApePaterno = PrimerApellido
                .VisitanteApeMaterno = SegundoApellido
                .VisitanteNombres = PreNombres
                .VisitanteFechaNacimiento = FechaNacimiento
                .VisitanteValidadoReniec = intVisitanteValidadoReniec
                .PaseNumero = PaseNumero
                .VisitanteDatosConcatenados = VisitanteDatosConcatenados
                .ParentescoID = ParentescoID
                .ParentescoNombre = ParentescoNombre
                .FechaIngreso = FechaIngreso
                .HoraIngreso = HoraIngreso
                .TipoIngresoPor = intVisitanteIngresaPor
                .NumeroRecaptura = intVisitanteNumeroRecaptura
            End With
            objEntTempMovCol.Add(objEntMov)

        End Sub
        Private Sub Temporal_Eliminar()

            If Me.dgwMovi.RowCount > 0 Then
                objEntTempMovCol.Remove(Me.dgwMovi.SelectedRows(0).Index)
                Temporal_Listar()
            End If

        End Sub

#End Region
#Region "Validar"
        Public Function Validar() As Boolean

            Dim value As Boolean = False

            If Me.dgwMovi.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "No se ha registrado ningun visitante")
                Return value
            End If

            value = True

            Return value
        End Function
        Private Function ValidarTemporal() As Boolean

            Dim value As Boolean = False

            'validar visitante mayor
            If Me.UscVisitante1._ValidarMayorEdad = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "El visitante es menor de edad, debe estar acompañado por un adulto")
                Return value
            End If

            'validar datos del visitante
            If Me.UscVisitante1._ValidarVisitante = False Then
                Return value
            End If

            value = True
            Return value

        End Function
#End Region
#Region "Accion"
        Public Function _AGrabar() As Boolean

            Dim value As Boolean = False

            Me.HoraIngreso = Legolas.LBusiness.Globall.DateTime.HoraServer

            If Validar() = True Then

                AActualizarDatosVisitante()
                AGrabarMovimiento()
                value = True

            End If

            Return value

        End Function
        Private Sub AActualizarDatosVisitante()

            For Each obj As Entity.Visita.Movimiento In objEntTempMovCol

                If Me.UscVisitante1._VisitanteIDReturn = obj.VisitaID Then

                    If Me.VisitanteDatosConcatenados <> obj.VisitanteDatosConcatenados Then

                        'hay que actulizar los datos del visitante
                        Me.UscVisitante1._GrabarVisitante()
                        obj.VisitanteApePaterno = Me.UscVisitante1._PrimerApellido
                        obj.VisitanteApeMaterno = Me.UscVisitante1._SegundoApellido
                        obj.VisitanteNombres = Me.UscVisitante1._PreNombres
                    End If

                    Exit For
                End If

            Next

        End Sub
        Private Sub AGrabarMovimiento()

            Dim intValue As Integer = -1
            Dim blnGrabo As Boolean = False

            For Each obj As Entity.Visita.Movimiento In objEntTempMovCol

                objEntMov = New Entity.Visita.Movimiento

                With objEntMov
                    .Codigo = -1
                    .RegionID = Me._RegionID
                    .PenalID = Me._PenalID
                    .MovimientoPadre = 0
                    .PaseNumero = obj.PaseNumero
                    '/*visitante*/
                    .VisitaID = obj.VisitaID
                    .VisitanteApellidosyNombres = obj.VisitanteApellidosyNombresReadonly
                    .VisitanteIDTipoDocumento = obj.VisitanteIDTipoDocumento
                    .VisitanteNumeroDocumento = obj.VisitanteNumeroDocumento
                    .VisitanteFechaNacimiento = obj.VisitanteFechaNacimiento
                    .VisitanteValidadoReniec = obj.VisitanteValidadoReniec
                    .TipoIngresoPor = obj.TipoIngresoPor
                    '/**********/
                    .TipoInterno = -1
                    .InternoID = -1
                    .InternoApellidosyNombres = "[Visita Administrativa]"
                    .ParentescoID = obj.ParentescoID
                    '/*movimiento*/
                    .FechaIngreso = Me._FechaVisita
                    .HoraIngreso = Me.HoraIngreso
                    .FechaSalida = Me.FechaSalida
                    .HoraSalida = Me.HoraSalida
                    '/*otros*/
                    .MenoresTipo = Me.TipoMenores
                    .MenoresCantidad = 0
                    .PabellonID = -1
                    .PabellonNombre = ""
                    .EtapaID = -1
                    .RegimenVisitaID = Me.RegimenVisitaID
                    .TipoID = Me.TipoVisitaID
                    .CalendarioDetalleID = -1
                    .Observacion = Me.Observacion
                End With

                objBssMov = New Bussines.Visita.Movimiento
                intValue = objBssMov.Grabar(objEntMov)

                If intValue > 0 Then
                    blnGrabo = True
                End If

            Next

            If blnGrabo = True Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()

                Limpiar()

            End If

        End Sub
#End Region
#Region "Form"
        Private Sub Form_Parentesco()

            Dim blnOK As Boolean = False

            Dim frm As New Visita.frmParentesco
            With frm
                ._TipoParentesco = Type.Enumeracion.Parentesco.TipoVisita.Administrativa
                If .ShowDialog = DialogResult.OK Then
                    Me.ParentescoID = ._GrillaParentescoID
                    Me.ParentescoNombre = ._GrillaParentescoNombre
                    blnOK = True
                Else
                    'ha cancelado la visita adminsitrativa
                    Me.UscVisitante1._ALimpiarVisitante(True)
                    Me.UscVisitante1._Focus()
                End If

            End With

            If blnOK = True Then
                If Temporal_Grabar() = True Then
                    If Legolas.Configuration.Aplication.MessageBox.Question(
                        "Desea agregar otro visitante") = DialogResult.Yes Then
                        Me.UscVisitante1._ALimpiarVisitante(True)
                        Me.UscVisitante1._Focus()
                    End If

                End If

            End If

        End Sub

#End Region
#Region "Otros"
        Public Sub _ActualizarParametricasRegionPenal()

            With Me.UscVisitante1
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._RegionNombre = Me._RegionNombre
                ._PenalNombre = Me._PenalNombre
                '/*tabla de configuracion*/
                ._SolicitarAutoRegOrdinario = Me._SolicitarAutoRegOrdinario
                ._HabilitarHuellaDigital = Me._HabilitarHuellaDigital
                ._HabilitarCapHuellaValReniec = Me._HabilitarCapHuellaValReniec
                'reniec
                ._ValidarModuloVisConReniec = Me._ValidarModuloVisConReniec
                ._ValidarVisitanteConReniec = Me._ValidarVisitanteConReniec
                'migraciones
                ._ValidarModuloVisConMigraciones = Me._ValidarModuloVisConMigraciones
                ._ValidarVisitanteConMigraciones = Me._ValidarVisitanteConMigraciones
            End With

        End Sub
        Private Sub ALimpiarGrilla()

            'limpiar el datagrid y la coleccion de movimiento
            Me.dgwMovi.DataSource = Nothing
            objEntTempMovCol = Nothing
            objEntTempMovCol = New Entity.Visita.MovimientoCol

        End Sub
        Private Function ValidarPropiedadesParemetricas() As Boolean

            Dim value As Boolean = False

            If Me._RegionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(
                "El parametro [_RegionID], no esta inicializado")
                Return value
            End If

            If Me._PenalID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(
                "El parametro [_PenalID], no esta inicializado")
                Return value
            End If

            If Me._FechaVisita < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(
                "El parametro [_FechaVisita], no esta inicializado")
                Return value
            End If

            value = True

            Return value

        End Function
        Private Sub ValoresxDefault()

            Me.HoraIngreso = Legolas.LBusiness.Globall.DateTime.HoraServer

            If objEntTempMovCol Is Nothing Then
                objEntTempMovCol = New Entity.Visita.MovimientoCol
            End If

            'If objEntTempMovCol.Count < 1 Then

            'End If

        End Sub
        Private Sub LoasUscVisitante()

            With Me.UscVisitante1
                ._RegionID = Me._RegionID
                ._RegionNombre = Me._RegionNombre
                ._PenalID = Me._PenalID
                ._PenalNombre = Me._PenalNombre
                ._FechaVisita = Me._FechaVisita
                ._ValidarFechaNacimiento = True
                ._TipoVisita = Type.Enumeracion.Visita.EnumTipo.Aministrativa
                'tabla de configuracion
                ._SolicitarAutoRegOrdinario = Me._SolicitarAutoRegOrdinario
                ._HabilitarHuellaDigital = Me._HabilitarHuellaDigital
                ._HabilitarCapHuellaValReniec = Me._HabilitarCapHuellaValReniec
                'reniec
                ._ValidarModuloVisConReniec = Me._ValidarModuloVisConReniec
                ._ValidarVisitanteConReniec = Me._ValidarVisitanteConReniec
                'migraciones
                ._ValidarModuloVisConMigraciones = Me._ValidarModuloVisConMigraciones
                ._ValidarVisitanteConMigraciones = Me._ValidarVisitanteConMigraciones
                ._LoadUsc()
            End With

        End Sub
        Public Sub _LoadUsc()

            If ValidarPropiedadesParemetricas() = False Then
                Exit Sub
            End If

            ValoresxDefault()
            LoasUscVisitante()

        End Sub
        Public Sub _Focus()

            Me.UscVisitante1._Focus()

        End Sub
        Private Sub Limpiar()
            Me.UscVisitante1._ALimpiarVisitante(True)
            ALimpiarGrilla()
            Me.Observacion = ""
            Me.UscVisitante1._Focus()
        End Sub
        Public Sub _LimpiarMovimiento()

            'si hay registros que pregunte
            If Me.dgwMovi.RowCount > 0 Then
                If Legolas.Configuration.Aplication.MessageBox.Question( _
                "Los datos ingresados no han sido grabados, desea grabarlos") = DialogResult.Yes Then
                    _AGrabar()
                Else
                    Limpiar()
                End If

            Else
                Limpiar()
            End If

        End Sub
        Private Sub VerImagenTipoDocumento(intIDTipoDocumento As Short)

            Select Case intIDTipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.DNI
                    pbTipoDocumento.Image = My.Resources.dni

                Case Type.Enumeracion.enmTipoDocumento.CE
                    pbTipoDocumento.Image = My.Resources.ce

                Case Type.Enumeracion.enmTipoDocumento.PTP
                    pbTipoDocumento.Image = My.Resources.ptp

                Case Type.Enumeracion.enmTipoDocumento.PAS
                    pbTipoDocumento.Image = My.Resources.pas

                Case Else
                    Me.pbTipoDocumento.Image = Nothing
            End Select

        End Sub
#End Region

        Private Sub UscVisitante1__ListarData() Handles UscVisitante1._Click_ListarData

            Form_Parentesco()

        End Sub

        Private Sub UscVisitante1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UscVisitante1.Load

        End Sub

        Private Sub dgwMovi_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellClick

            '/*iconos*/
            With Me.dgwMovi
                If e.RowIndex = -1 Then Exit Sub
                If .RowCount > 0 Then
                    '/*icono ver*/
                    Select Case e.ColumnIndex
                        Case .Columns("col_eli").Index
                            Temporal_Eliminar()
                    End Select
                End If
            End With

        End Sub

        Private Sub dgwMovi_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMovi.CellContentClick

        End Sub

        Private Sub dgwMovi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwMovi.KeyDown

            If e.KeyCode = Keys.Delete Then
                Temporal_Eliminar()

            End If

        End Sub


        Private Sub UscVisitante1__Click_BuscarVisita() Handles UscVisitante1._Click_BuscarVisita

            RaiseEvent _Click_BuscarVisitante()

        End Sub

        Private Sub UscVisitante1__SelectedIndexChanged_TipoDocumento(intIDTipoDocumento As Short) Handles UscVisitante1._SelectedIndexChanged_TipoDocumento

            VerImagenTipoDocumento(intIDTipoDocumento)

        End Sub
    End Class

End Namespace