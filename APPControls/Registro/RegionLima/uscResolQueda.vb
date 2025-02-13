Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia

Namespace Registro.RegionLima
    Public Class uscResolQueda
        Public objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Public objEntNACol As New Entity.Registro.Documento.NombresAsociadosCol
        Private objEntNACol2 As New Entity.Registro.NombreAsociadoCol
        Public objEntNACol_Com As Entity.Registro.NombreAsociadoCol = Nothing
        Private objEntNACol_cop As New Entity.Registro.Documento.NombresAsociadosCol
        Private objEntNA As Entity.Registro.NombreAsociado = Nothing
        Private objBssNA As Bussines.Registro.NombreAsociado = Nothing
        Private Property blnEliminar As Boolean = False
        Private blnHabilitar As Boolean = False


#Region "Eventos"
        Public Event _Click_EnabledExpedientes(OpcionAclaratoria As Integer)
        Public Event _Click_ValidarNombreAsociado()
        Public Event _Click_VerFormulario()
        Public Event _Click_VerLibertades()
#End Region
#Region "Propiedades_Parametricas"
        Public Property _Codigo As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _blnNuevo() As Boolean = False
        Public Property _CodDocJud As Integer = -1
        Public Property _Lista_NombresAsociados() As Entity.Registro.Documento.NombresAsociadosCol
            Get
                Return objEntNACol
            End Get
            Set(value As Entity.Registro.Documento.NombresAsociadosCol)
                objEntNACol = value
            End Set
        End Property
        Public Property _Lista_NombresAsociados2() As Entity.Registro.NombreAsociadoCol
            Get
                Return objEntNACol2
            End Get
            Set(value As Entity.Registro.NombreAsociadoCol)
                objEntNACol2 = value
            End Set
        End Property

        Public Property _TipoAclaratoriaSeleccionado As Integer = -1
        Public Property _TipoAclaratoria As Integer = -1
        Public Property _TipoAclaratoriaCon As Boolean = False
        Public Property _DocSubTipoID As Integer = -1
        Public Property ValorRef As Boolean = False
        Public Property _PermisoEliminar() As Boolean = False
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia
        Private ReadOnly Property FlagTransferSede As Integer
            Get
                Dim v As Integer = 0
                If _TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                    v = 1
                End If
                Return v
            End Get
        End Property
#End Region
#Region "Propiedades"
        Public Property _DocumentoTipo() As Integer = -1
        Private Property DocumentoNumero() As String
            Get
                Return txtNumDocumento.Text.Trim
            End Get
            Set(value As String)
                txtNumDocumento.Text = value
            End Set
        End Property

        Private Property DocumentoFecha() As Long
            Get
                Return dtpDocJudFecha.ValueLong
            End Get
            Set(value As Long)
                dtpDocJudFecha.ValueLong = value
            End Set
        End Property
        Private Property Observacion() As String
            Get
                Return txtObsLib.Text
            End Get
            Set(value As String)
                txtObsLib.Text = value
            End Set
        End Property
        Private Property NumLibro As String
            Get
                Return txtLibro.Text
            End Get
            Set(value As String)
                txtLibro.Text = value
            End Set
        End Property
        Private Property NumFolio As String
            Get
                Return txtFolio.Text
            End Get
            Set(value As String)
                txtFolio.Text = value
            End Set
        End Property
        Private Property PenalOrigenId As Integer = -1
        Private Property PenalDestinoid As Integer = -1
        Private Property PenalOtroOrigenNom As String = ""
        Private Property PenalDestinoOtroNom As String

        Private Property MovimientoMotivoId As Integer = -1

        Private Property SituacionJuridicaId As Integer = -1
        Public Property ApellidoPaternoNA As String = ""
        Public Property ApellidoMaternoNA As String = ""
        Public Property NombresNA As String = ""
        'Private Property DocumentoLibertadId() As Integer = -1
        Public Property DocumentoLibertadId() As Integer
            Get
                Return cbbLibertad.SelectedValue
            End Get
            Set(value As Integer)
                cbbLibertad.SelectedValue = value
            End Set
        End Property
#End Region
#Region "propiedades_grilla"
        Private ReadOnly Property GrillaNombresAsociadoId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    'With Me.dgwNomAsoc
                    '    intValue = .SelectedRows(0).Cells("col_id").Value
                    'End With
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaApePaterno() As String
            Get
                Dim intValue As String = ""
                Try
                    'With Me.dgwNomAsoc
                    '    intValue = .SelectedRows(0).Cells("col_ape_pat").Value
                    'End With
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaApematerno() As String
            Get
                Dim intValue As String = ""
                Try
                    'With Me.dgwNomAsoc
                    '    intValue = .SelectedRows(0).Cells("col_ape_mat").Value
                    'End With
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaNombres() As String
            Get
                Dim intValue As String = ""
                Try
                    'With Me.dgwNomAsoc
                    '    intValue = .SelectedRows(0).Cells("col_nom").Value
                    'End With
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaRegistroNomAsoc() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    'With Me.dgwNomAsoc
                    '    intValue = .Rows.Count
                    'End With
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaPosic() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    'With Me.dgwNomAsoc
                    '    intValue = .SelectedRows(0).Index
                    'End With
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return intValue
            End Get
        End Property
#End Region

#Region "Combo"
        Dim objenmParametrica As Type.Combo.ComboTipo = Type.Combo.ComboTipo.Ninguno
        Private Sub CargarDocumentoLibertad()
            Dim obj As New Entity.Registro.DocumentoJudicial
            obj.InternoId = Me._InternoID
            obj.IngresoInpeId = Me._InternoIngresoInpeId
            obj.DocumentoTipo = 6 'Libertad

            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbLibertad
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objBss.Combo_Documentos_LM(obj, Type.Combo.enmTipoTexto.Mayuscula, True, "Seleccionar")
            End With
        End Sub

#End Region
#Region "Listar"
        Dim intContadorPrin As Integer = 0

        Private Sub Listar()
            dtpDocJudFecha.Focus()
            If Me._Codigo < 1 Then
                Exit Sub
            End If
            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt.Codigo = Me._Codigo
            objEnt = objBss.Listar_v2(objEnt)
            With objEnt
                Me._Codigo = .Codigo
                Me._DocumentoTipo = .DocumentoTipo
                Me.DocumentoNumero = .DocumentoNumero
                Me.DocumentoFecha = .DocumentoFecha
                Me.Observacion = .Observacion
                Me.SituacionJuridicaId = .SituacionJuridicaId
                Me.NumFolio = .NumFolio
                Me.NumLibro = .NumLibro
                Me._DocSubTipoID = .DocumentoSubTipoId
                Me.DocumentoLibertadId = .QuedaId
            End With
        End Sub

#End Region
#Region "Accion"
        Public Function Validar() As Boolean
            Dim blnValue As Boolean = False

            '/*Nunero de la resolucion*/
            If Me.DocumentoNumero = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese número del documento de referencia")
                txtNumDocumento.Select()
                Return blnValue
            End If

            '/*fecha de documento*/
            If Me.DocumentoFecha < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento Judicial")
                Me.dtpDocJudFecha.Focus()
                Return blnValue
            End If
            '/*comparacion de fechas*/

            If Me._TipoLicencia <> enmTipoLicencia.RegionLimaMetropolitana Then
                If Me._PenalID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametros Penal, no fue enviado al Objeto")
                    Return blnValue
                End If
            End If

            If Me._RegionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametros RegionId, no fue enviado al Objeto")
                Return blnValue
            End If
            If (Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana) Then

                If Me._InternoIngresoInpeId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parámetro InternoIngresoInpeId del interno no fueron enviados al Objeto")
                    Return blnValue
                End If

                If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                    If Me._InternoIngresoId < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Parámetro InternoIngresoId del interno no fueron enviados al Objeto")
                        Return blnValue
                    End If
                End If
            Else
                If Not (Me._TipoLicencia = enmTipoLicencia.Carceleta _
               Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
               Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana) Then
                    If Me._InternoIngresoId < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Código del interno no fueron enviados al Objeto")
                        Return blnValue
                    End If
                End If
            End If

            If Me._DocSubTipoID > 1 Then
                Dim Conta As Integer = 0
                For Each ob As Entity.Registro.Documento.NombresAsociados In _Lista_NombresAsociados
                    If ob.NAPrincipal = 1 Then
                        Conta = Conta + 1
                    End If
                Next
                If Conta > 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno solo puede tener un nombre principal")
                    'Me.btnEditarNomAsoc.Focus()
                    Return blnValue
                End If
            End If
            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt = New Entity.Registro.DocumentoJudicial
            objEnt.DocumentoNumero = Me.DocumentoNumero
            objEnt.DocumentoTipo = Me._DocumentoTipo
            objEnt.InternoIngresoId = Me._InternoIngresoId
            objEnt.IngresoInpeId = Me._InternoIngresoInpeId

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                If Me.DocumentoLibertadId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar el documento de libertad a referenciar.")
                    cbbLibertad.Focus()
                    Return blnValue
                End If
            Else
                If Me._Codigo < 1 And objBss.CuentaDocumentoTipo(objEnt) > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El tipo y numero de documento ya existe")
                    txtNumDocumento.Focus()
                    Return blnValue
                End If
            End If


            Return True
        End Function
        Public Function AGrabar(Optional objDoc As Entity.Registro.DocumentoJudicial = Nothing) As Integer
            Dim Value As Integer = -1
            If Validar() = True Then
                objEnt = New Entity.Registro.DocumentoJudicial
                objBss = New Bussines.Registro.DocumentoJudicial

                With objEnt

                    .Codigo = Me._Codigo
                    .DocumentoTipo = Me._DocumentoTipo
                    .DocumentoNumero = Me.DocumentoNumero
                    .DocumentoFechaRecepcion = Me.DocumentoFecha
                    .DocumentoFecha = Me.DocumentoFecha
                    .TipoAutoridadJudicial = -1


                    .DistritoJudicial = -1
                    .SalaJuzgado = -1
                    .JuezNombre = ""
                    .SecretarioNombre = ""
                    .AutoridadOtroNombre = ""
                    .AutoridadOtroCargo = ""
                    .NumFolio = Me.NumFolio
                    .NumLibro = Me.NumLibro
                    .InternoId = Me._InternoID
                    .InternoIngresoId = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .SituacionJuridicaId = Me.SituacionJuridicaId
                    .Observacion = Me.Observacion
                    .Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal
                    If Me._DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Detencion Then
                        .ProlonDetencionFechFin = objDoc.ProlonDetencionFechFin
                        .ProlonDetencionFechIni = objDoc.ProlonDetencionFechIni
                        .ProlonDetencionTipoUnidad = objDoc.ProlonDetencionTipoUnidad
                        .ProlonDetencionValor = objDoc.ProlonDetencionValor
                    End If
                    .QuedaId = Me.DocumentoLibertadId
                    '.DocumentoSubTipoId = Me._Codigo
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                End With

                If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                    Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                    Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                    Value = objBss.Grabar_LM(objEnt)
                Else
                    Value = objBss.Grabar2(objEnt)
                End If
            End If

            Return Value

        End Function
        Public Function AGrabarEnt() As Entity.Registro.DocumentoJudicial

            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial

            With objEnt
                .Codigo = Me._Codigo
                .DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes
                .DocumentoNumero = Me.DocumentoNumero
                .DocumentoFechaRecepcion = Me.DocumentoFecha
                .DocumentoFecha = Me.DocumentoFecha
                .TipoAutoridadJudicial = -1

                .DistritoJudicial = -1
                .SalaJuzgado = -1
                .JuezNombre = ""
                .SecretarioNombre = ""
                .AutoridadOtroNombre = ""
                .AutoridadOtroCargo = ""

                .NumFolio = Me.NumFolio
                .NumLibro = Me.NumLibro
                .InternoId = Me._InternoID
                .InternoIngresoId = Me._InternoIngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
                .SituacionJuridicaId = Me.SituacionJuridicaId
                .Observacion = Me.Observacion
                .Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal
                .FlagTransferenciaSede = Me.FlagTransferSede
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
            End With

            Dim value As Integer = -1
            objBss = New Bussines.Registro.DocumentoJudicial
            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                value = objBss.Grabar_LM(objEnt)
            Else
                value = objBss.Grabar2(objEnt)
            End If


            objEnt.Codigo = value
            Return objEnt

        End Function

        Private Function CopiarPropiedades(objEntHis As Entity.Registro.InternoHistorico, ObjEntInt As Entity.Registro.Interno) As Entity.Registro.InternoHistorico
            With ObjEntInt
                '/*datos generales*/
                objEntHis.CodigoRP = .CodigoRP
                objEntHis.Libro = .Libro
                objEntHis.Folio = .Folio
                objEntHis.ApellidoPaterno = .ApellidoPaterno
                objEntHis.ApellidoMaterno = .ApellidoMaterno
                objEntHis.Nombres = .Nombres

            End With
            '/*********************/
            Return objEntHis
        End Function
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            CargarDocumentoLibertad()
            Listar()

        End Sub
        Public Sub _LoadUsc()
            If _Codigo = -1 Then
                Me._blnNuevo = True
            Else
                Me._blnNuevo = False
            End If
            ValoresxDefault()
        End Sub

#End Region
#Region "eventos_controles_formulario"
        Private Sub cbbTipoAutJud__SelectedIndexChanged()

        End Sub

        Private Sub cbbTipoAclaratoria__SelectedIndexChanged()
            Select Case Me._DocSubTipoID
                Case 1 'expediente
                    'dgwNomAsoc.Enabled = False
                    Me.blnHabilitar = False
                    RaiseEvent _Click_EnabledExpedientes(Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Aclaratoria_de_Expediente) 'solo expediente
                    'dgwNomAsoc.DataSource = Nothing
                Case 2 'nombres
                    'dgwNomAsoc.Enabled = True
                    Me.blnHabilitar = True
                    RaiseEvent _Click_EnabledExpedientes(Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Aclaratoria_de_Nombre) 'solo nombres
                    'ListarNombreAsociadoBD(_InternoID)
                Case 3 'exp-nombres
                    'dgwNomAsoc.Enabled = True
                    Me.blnHabilitar = True
                    RaiseEvent _Click_EnabledExpedientes(Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Aclaratoria_de_ExpedienteNombres) 'todos
                    'ListarNombreAsociadoBD(_InternoID)
            End Select
        End Sub
        Public Sub ActualizarDocumentoLibertadId(ResolucionID As Integer, ResolucionNom As String)

            Me.DocumentoLibertadId = ResolucionID
            '  txtDocumentoLibertad.Text = ResolucionNom

        End Sub

        Public Property ValorEli As Boolean = False
        Public Property ValorVal As Boolean = False

#End Region


        Private Sub dtpDocJudFecha__ValueChanged() Handles dtpDocJudFecha._ValueChanged
            With dtpDocJudFecha
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub



        Private Sub dtpDocJudFecha_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtpDocJudFecha.Validating
            With dtpDocJudFecha
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub pbDocumentoLibertad_Click(sender As Object, e As EventArgs)
            RaiseEvent _Click_VerLibertades()
        End Sub

        Private Sub uscResolQueda_Load(sender As Object, e As EventArgs) Handles Me.Load

        End Sub
    End Class
End Namespace
