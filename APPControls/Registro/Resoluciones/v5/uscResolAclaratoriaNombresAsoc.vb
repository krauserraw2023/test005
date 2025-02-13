Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.SubTipoDocJudicial

Public Class uscResolAclaratoriaNombresAsoc
    'ddddd
    Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
    Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
    Public objEntNACol As New Entity.Registro.Documento.NombresAsociadosCol
    Private objEntNACol2 As New Entity.Registro.NombreAsociadoCol
    Public objEntNACol_Com As Entity.Registro.NombreAsociadoCol = Nothing
    Private objEntNACol_cop As New Entity.Registro.Documento.NombresAsociadosCol
    Private objEntNA As Entity.Registro.NombreAsociado = Nothing
    Private objBssNA As Bussines.Registro.NombreAsociado = Nothing
    Private Property blnEliminar As Boolean = False
    Private blnHabilitar As Boolean = False
    Public Property _DocumentoJudicialID As Integer = -1
    Private objBssExpedientePad As Bussines.Registro.InternoExpedientePadre
    Public objEntExpedienteTempoCol As Entity.Registro.ExpedienteCol = Nothing
    Private objEntExpPadre As Entity.Registro.InternoExpedientePadre = Nothing
    Public Property _ReferenciaEnablet As Boolean = False

#Region "Eventos"
    Public Event _Click_BtnAgregarNombreAsociado(EntNomAso As Entity.Registro.Documento.NombresAsociados, EntNomAsoCol As Entity.Registro.Documento.NombresAsociadosCol, Accion As Integer)
    Public Event _Click_BtnEditarNombreAsociado(EntNomAso As Entity.Registro.Documento.NombresAsociados, EntNomAsoCol As Entity.Registro.Documento.NombresAsociadosCol, Accion As Integer)
    Public Event _Click_EnabledExpedientes(OpcionAclaratoria As Integer)
    Public Event _Click_EliminarNombreAsociado()
    Public Event _Click_ValidarNombreAsociado()
    Public Event _Click_ConsultarExpedienteReferenciado()
#End Region
#Region "Propiedades_Parametricas"
    Public Property _Codigo As Integer = -1
    Public Property _RegionID() As Integer = -1
    Public Property _PenalID() As Integer = -1
    Public Property _InternoIngresoId() As Integer = -1
    Public Property _InternoIngresoInpeId As Integer = -1
    Public Property _InternoNAIngresoId() As Integer = -1
    Public Property _InternoNAIngresoInpeId() As Integer = -1
    Public Property _InternoID() As Integer = -1
    Private Property _blnNuevo() As Boolean = False
    Public Property _CodDocJud As Integer = -1
    Public Property _DocumentoTipoId As Integer = -1
    Public Property _DocumentoSubTipoId As Integer = -1
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
    Public ReadOnly Property _ObjNombreAsociadoSelect() As Entity.Registro.Documento.NombresAsociados
        Get
            If dgwNomAsoc.Rows.Count < 1 Then Return Nothing
            Return objEntNACol.NombresAsociados(dgwNomAsoc.CurrentCell.RowIndex)
        End Get
    End Property

    Public Property _TipoAclaratoria As Integer = -1
    Public Property _TipoAclaratoriaCon As Boolean = False
    Public Property _ValorReferencia As Boolean = False
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
    Private Property DocumentoTipo() As Integer = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria


    Private Property PenalOrigenId As Integer = -1
    Private Property PenalDestinoid As Integer = -1
    Private Property PenalOtroOrigenNom As String = ""
    Private Property PenalDestinoOtroNom As String
    Private Property FechaMovimiento As Long = 0
    Private Property MovimientoMotivoId As Integer = -1

    Private Property SituacionJuridicaId As Integer = -1
    Public Property ApellidoPaternoNA As String = ""
    Public Property ApellidoMaternoNA As String = ""
    Public Property NombresNA As String = ""

#End Region
#Region "propiedades_grilla"
    Private ReadOnly Property GrillaNombresAsociadoId() As Integer
        Get
            Dim intValue As Integer = -1
            Try
                With Me.dgwNomAsoc
                    intValue = .SelectedRows(0).Cells("col_id").Value
                End With
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
                With Me.dgwNomAsoc
                    intValue = .SelectedRows(0).Cells("col_ape_pat").Value
                End With
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
                With Me.dgwNomAsoc
                    intValue = .SelectedRows(0).Cells("col_ape_mat").Value
                End With
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
                With Me.dgwNomAsoc
                    intValue = .SelectedRows(0).Cells("col_nom").Value
                End With
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
                With Me.dgwNomAsoc
                    intValue = .Rows.Count
                End With
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
                With Me.dgwNomAsoc
                    intValue = .SelectedRows(0).Index
                End With
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
            End Try
            Return intValue
        End Get
    End Property
    Public ReadOnly Property GrillaAccion() As Integer
        Get
            Dim intValue As Integer = -1
            Try
                With Me.dgwNomAsoc
                    intValue = .SelectedRows(0).Cells("col_accion").Value
                End With
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
            End Try
            Return intValue
        End Get
    End Property
#End Region

#Region "Combo"



#End Region
#Region "Listar"
    Dim intContadorPrin As Integer = 0
    Private objEntNACol_copi As New Entity.Registro.Documento.NombresAsociadosCol

    Private Sub ListarNombreAsociado(DocJudicialId As Integer, InternoId As Integer, IngresoId As Integer)
        'ver1xx
        Dim objBss As New Bussines.Registro.Documento.NombresAsociados
        Dim objEnt As New Entity.Registro.Documento.NombresAsociados
        objEnt.InternoID = InternoId
        objEnt.IngresoID = IngresoId
        objEnt.DocumentoJudicialID = DocJudicialId
        objEntNACol = objBss.Listar_v2(objEnt)
        With Me.dgwNomAsoc
            .DataSource = ""
            .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            .AllowUserToResizeRows = False
            .AutoGenerateColumns = False
            If objEntNACol Is Nothing Or objEntNACol.Count = 0 Then
                .DataSource = Nothing
            Else
                .DataSource = IIf(objEntNACol Is Nothing, Nothing, objEntNACol)
            End If

        End With
        Me.grbNombreAso.Text = "Nombres Asociados " & objEntNACol.Count & " Reg."
        If Me.dgwNomAsoc.RowCount > 0 Then
            Me.dgwNomAsoc.Rows(0).Selected = True
        End If
    End Sub
    Private Sub ListarNombreAsociado_LM(DocJudicialId As Integer, InternoId As Integer, IngresoId As Integer, IngresoInpeId As Integer)
        'ver1xx
        Dim objBss As New Bussines.Registro.Documento.NombresAsociados
        Dim objEnt As New Entity.Registro.Documento.NombresAsociados
        objEnt.InternoID = InternoId
        objEnt.IngresoID = IngresoId
        objEnt.IngresoInpeId = IngresoInpeId
        objEnt.DocumentoJudicialID = DocJudicialId
        objEntNACol = objBss.ListarGrilla_LM(objEnt)
        With Me.dgwNomAsoc
            .DataSource = ""
            .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            .AllowUserToResizeRows = False
            .AutoGenerateColumns = False
            If objEntNACol Is Nothing Or objEntNACol.Count = 0 Then
                .DataSource = Nothing
            Else
                .DataSource = IIf(objEntNACol Is Nothing, Nothing, objEntNACol)
            End If

        End With
        Me.grbNombreAso.Text = "Nombres Asociados " & objEntNACol.Count & " Reg."
        If Me.dgwNomAsoc.RowCount > 0 Then
            Me.dgwNomAsoc.Rows(0).Selected = True
        End If
    End Sub

    Public Function NombresAsociadosNegativo_LM() As Integer
        Dim valor As Integer = -1
        For Each ent As Entity.Registro.Documento.NombresAsociados In objEntNACol
            If ent.IngresoInpeId < 1 Then
                valor = ent.IngresoInpeId
                Exit For
            Else
                valor = ent.IngresoInpeId
            End If
        Next
        Return valor
    End Function
    Public Function NombresAsociadosNegativo() As Integer
        Dim valor As Integer = -1
        For Each ent As Entity.Registro.Documento.NombresAsociados In objEntNACol
            If ent.IngresoID < 1 Then
                valor = ent.IngresoID
                Exit For
            Else
                valor = ent.IngresoID
            End If
        Next
        Return valor
    End Function

    Public Sub AgregarNombresAsociados(ObjEnt_NA As Entity.Registro.Documento.NombresAsociados)
        Dim objBss As New Bussines.Registro.Documento.NombresAsociados
        If ObjEnt_NA.NAPrincipal = 1 Then
            For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntNACol
                If objEnt.NAPrincipal = 1 Then
                    If objEnt.NAPaterno2 = "" And objEnt.NAMaterno2 = "" And objEnt.NANombres2 = "" And objEnt.NAEstado = -1 Then
                        objEnt.NAEstado = 1
                        objEnt.NAPaterno2 = objEnt.NAPaterno
                        objEnt.NAMaterno2 = objEnt.NAMaterno
                        objEnt.NANombres2 = objEnt.NANombres
                    End If
                    objEnt.NAPrincipal2 = 0
                Else
                    objEnt.NAPrincipal2 = 0
                End If
                'If objEnt.NAPrincipal = 2 Then
                '    If objEnt.NAPaterno2 = "" And objEnt.NAMaterno2 = "" And objEnt.NANombres2 = "" And objEnt.NAEstado = -1 Then
                '        objEnt.NAEstado = 1
                '        objEnt.NAPaterno2 = objEnt.NAPaterno
                '        objEnt.NAMaterno2 = objEnt.NAMaterno
                '        objEnt.NANombres2 = objEnt.NANombres
                '    End If
                '    objEnt.NAPrincipal2 = 0
                'End If
            Next
        End If
        ObjEnt_NA.NAPrincipal2 = ObjEnt_NA.NAPrincipal
        ObjEnt_NA.NAPaterno2 = ObjEnt_NA.NAPaterno
        ObjEnt_NA.NAPaterno = ""
        ObjEnt_NA.NAMaterno2 = ObjEnt_NA.NAMaterno
        ObjEnt_NA.NAMaterno = ""
        ObjEnt_NA.NANombres2 = ObjEnt_NA.NANombres
        ObjEnt_NA.NANombres = ""
        ObjEnt_NA.NAEstado2 = 1
        ObjEnt_NA.NAEstado = 2
        objEntNACol.Add(ObjEnt_NA)
        With Me.dgwNomAsoc
            .DataSource = ""
            .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            .AllowUserToResizeRows = False
            .AutoGenerateColumns = False
            .DataSource = objEntNACol
        End With
        Me.grbNombreAso.Text = "Nombres Asociados " & objEntNACol.Count & " Reg."
        If Me.dgwNomAsoc.RowCount > 0 Then
            Me.dgwNomAsoc.Rows(0).Selected = True
        End If
    End Sub
    Public Sub EditarNombresAsociados(ObjEnt_NA As Entity.Registro.Documento.NombresAsociados)
        'revisar 12082015
        With objEntNACol
            If ObjEnt_NA.NAPrincipal = 1 Then
                Dim objEntNACol_2 As New Entity.Registro.Documento.NombresAsociadosCol
                For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntNACol

                    If objEnt.NAPrincipal = 1 And objEnt.NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Ninguno Then
                        If objEnt.NAPaterno2 = "" And objEnt.NAMaterno2 = "" And objEnt.NANombres2 = "" Then
                            objEnt.NAEstado = 1
                            objEnt.NAPaterno2 = objEnt.NAPaterno
                            objEnt.NAMaterno2 = objEnt.NAMaterno
                            objEnt.NANombres2 = objEnt.NANombres
                        End If
                        objEnt.NAPrincipal2 = 0
                    ElseIf objEnt.NAPrincipal = 1 And objEnt.NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aclarado Then
                        objEnt.NAPrincipal2 = 0
                    ElseIf objEnt.NAPrincipal2 = 1 And objEnt.NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aclarado Then
                        objEnt.NAPrincipal2 = 0
                    ElseIf objEnt.NAPrincipal2 = 1 And objEnt.NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aniadido Then
                        objEnt.NAPrincipal2 = 0
                    ElseIf objEnt.NAEstado <> Type.Enumeracion.SubTipoDocJudicial.enumAccion.Anulado And _
                           objEnt.NAPrincipal2 = 0 Then
                    ElseIf objEnt.NAPrincipal2 = 1 And objEnt.NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aclarado Then

                    End If
                Next
            End If
            If Me._blnNuevo = True Then
                If ObjEnt_NA.NAEstado = -1 Or ObjEnt_NA.NAEstado = 1 Then
                    .NombresAsociados(Me.GrillaPosic).NAPaterno2 = ObjEnt_NA.NAPaterno
                    .NombresAsociados(Me.GrillaPosic).NAMaterno2 = ObjEnt_NA.NAMaterno
                    .NombresAsociados(Me.GrillaPosic).NANombres2 = ObjEnt_NA.NANombres
                    .NombresAsociados(Me.GrillaPosic).NAPrincipal2 = ObjEnt_NA.NAPrincipal
                    .NombresAsociados(Me.GrillaPosic).NAEstado = 1
                ElseIf ObjEnt_NA.NAEstado = 2 Then
                    .NombresAsociados(Me.GrillaPosic).NAPaterno2 = ObjEnt_NA.NAPaterno
                    .NombresAsociados(Me.GrillaPosic).NAMaterno2 = ObjEnt_NA.NAMaterno
                    .NombresAsociados(Me.GrillaPosic).NANombres2 = ObjEnt_NA.NANombres
                    .NombresAsociados(Me.GrillaPosic).NAPrincipal2 = ObjEnt_NA.NAPrincipal
                    .NombresAsociados(Me.GrillaPosic).NAEstado = 2
                End If
            Else
                If ObjEnt_NA.NAEstado = -1 Then
                    .NombresAsociados(Me.GrillaPosic).NAPaterno2 = ObjEnt_NA.NAPaterno
                    .NombresAsociados(Me.GrillaPosic).NAMaterno2 = ObjEnt_NA.NAMaterno
                    .NombresAsociados(Me.GrillaPosic).NANombres2 = ObjEnt_NA.NANombres
                    .NombresAsociados(Me.GrillaPosic).NAPrincipal2 = ObjEnt_NA.NAPrincipal
                    .NombresAsociados(Me.GrillaPosic).NAEstado2 = 1
                    .NombresAsociados(Me.GrillaPosic).NAEstado = 1
                ElseIf ObjEnt_NA.NAEstado = 1 Then
                    .NombresAsociados(Me.GrillaPosic).NAPaterno2 = ObjEnt_NA.NAPaterno
                    .NombresAsociados(Me.GrillaPosic).NAMaterno2 = ObjEnt_NA.NAMaterno
                    .NombresAsociados(Me.GrillaPosic).NANombres2 = ObjEnt_NA.NANombres
                    .NombresAsociados(Me.GrillaPosic).NAPrincipal2 = ObjEnt_NA.NAPrincipal
                    .NombresAsociados(Me.GrillaPosic).NAEstado = 1
                ElseIf ObjEnt_NA.NAEstado = 2 Then
                    .NombresAsociados(Me.GrillaPosic).NAPaterno2 = ObjEnt_NA.NAPaterno
                    .NombresAsociados(Me.GrillaPosic).NAMaterno2 = ObjEnt_NA.NAMaterno
                    .NombresAsociados(Me.GrillaPosic).NANombres2 = ObjEnt_NA.NANombres
                    .NombresAsociados(Me.GrillaPosic).NAPrincipal2 = ObjEnt_NA.NAPrincipal
                    .NombresAsociados(Me.GrillaPosic).NAEstado = 2

                End If
            End If


            dgwNomAsoc.Refresh()
        End With
    End Sub

    Public Sub ListarNombreAsociadoBD_LM(DocJudId As Integer, InternoId As Integer, IngresoId As Integer, IngresoInpeId As Integer)
        ListarNombreAsociado_LM(DocJudId, InternoId, IngresoId, IngresoInpeId)
    End Sub
    Public Sub ListarNombreAsociadoBD(DocJudId As Integer, InternoId As Integer, IngresoId As Integer)
        ListarNombreAsociado(DocJudId, InternoId, IngresoId)
    End Sub
#End Region
#Region "Accion"

    Public Function Validar(Subtipo As Integer) As Boolean
        If Subtipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Aclaratoria_de_Expediente Then
            Return True
        Else
            If dgwNomAsoc.RowCount > 0 Then
                Dim Valor As Integer = 0
                Dim ValNombres As String = ""
                Dim ValPrinAcla As Integer = 0
                Dim ValAnul As Integer = 0
                For Each obj As Entity.Registro.Documento.NombresAsociados In objEntNACol
                    If obj.NAEstado = -1 Then
                        Valor = Valor + 1
                    End If
                Next
                For Each obj As Entity.Registro.Documento.NombresAsociados In objEntNACol
                    If (obj.NAPrincipal = 1 And obj.NAEstado = 1 And obj.NAPrincipal2 = 0) Then
                        For Each obj2 As Entity.Registro.Documento.NombresAsociados In objEntNACol
                            If obj2.NAPrincipal2 = 1 Then
                                ValPrinAcla = ValPrinAcla + 1
                            End If
                        Next
                        If ValPrinAcla = 0 Then
                            ValPrinAcla = -100
                            Exit For
                        End If
                    End If
                    If (obj.NAPrincipal = 1 And obj.NAEstado = 0) Then
                        For Each obj2 As Entity.Registro.Documento.NombresAsociados In objEntNACol
                            If obj2.NAPrincipal2 = 1 And obj2.NAEstado <> 0 Then
                                ValAnul = ValAnul + 1
                            End If
                        Next
                        If ValAnul = 0 Then
                            ValPrinAcla = -100
                            Exit For
                        End If
                    End If
                    If (obj.NAEstado = 1) Then
                        If UCase(obj.ApellidosyNombres).Trim = UCase(obj.ApellidosyNombres2).Trim Then
                            ValNombres = obj.NAPaterno & " " & obj.NAMaterno & " " & obj.NANombres
                        End If
                    End If
                Next
                If Valor = dgwNomAsoc.RowCount And Subtipo > -1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe realizar una accion en los [Nombres asociados]")
                    btnAgregarNomAsoc.Focus()
                    Return False
                End If
                If Valor = dgwNomAsoc.RowCount And Subtipo = -1 Then
                    Return True
                End If
                If ValPrinAcla = -100 Or ValAnul = -100 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe existir un nombre principal en la lista [Nombres asociados aclarados]")
                    dgwNomAsoc.Focus()
                    Return False
                End If
                If ValPrinAcla = -100 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe existir un nombre principal en la lista [Nombres asociados aclarados]")
                    dgwNomAsoc.Focus()
                    Return False
                End If
                If ValNombres <> "" Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El [Nombre asociado]" + Chr(13) +
                                                                            ValNombres + Chr(13) +
                                                                            " no ha sido modificado.")
                    dgwNomAsoc.Focus()
                    Return False
                End If
                ValidarData()
                Return True
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Agregar un [Nombre asociado], lista vacia operación cancelada.")
                dgwNomAsoc.Focus()
                Return False
            End If
        End If
    End Function
    Public Sub ValidarData()
        Dim blnValor As Boolean = False
        For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntNACol
            If (objEnt.NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aniadido Or objEnt.NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aclarado) And objEnt.NAPrincipal2 = 1 Then
                blnValor = True
                Exit For
            End If
        Next
        If blnValor = True Then
            For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntNACol
                If objEnt.NAPrincipal = 1 And objEnt.NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Ninguno Then
                    objEnt.NAPaterno2 = objEnt.NAPaterno
                    objEnt.NAMaterno2 = objEnt.NAMaterno
                    objEnt.NANombres2 = objEnt.NANombres
                    objEnt.NAPrincipal2 = 0
                    objEnt.NAEstado = 1
                    Exit For
                End If
            Next
        End If
    End Sub

    Public Sub AgrabarNombresasociados_LM(DocJudicialID As Integer, Nuevo As Boolean)
        Me._InternoNAIngresoInpeId = NombresAsociadosNegativo_LM()
        Dim CodigoPrincipalNA As Integer = -1

        Dim bssInt As New Bussines.Registro.Interno
        Dim objInt As New Entity.Registro.Interno
        Dim blnCondicion As Boolean = False
        Dim intValue As Integer = -1
        Dim bssIntHist As New Bussines.Registro.InternoHistorico
        Dim IntHistorico As New Entity.Registro.InternoHistorico
        'IntHistorico.FlagTransferenciaSede = Me.FlagTransferSede
        IntHistorico.InternoID = Me._InternoID
        Dim intIngresoInpeMayor As Integer = bssIntHist.Validar_IngresoInpeID(IntHistorico)

        For Each ob As Entity.Registro.Documento.NombresAsociados In _Lista_NombresAsociados
            ob.FlagTransferenciaSede = Me.FlagTransferSede
            Dim objEntDoc As New Entity.Registro.Documento.NombresAsociados
            With objEntDoc
                .FlagTransferenciaSede = Me.FlagTransferSede
                .DocumentoNomAsociadoId = ob.Codigo
                .InternoNombreAsociadoID = ob.InternoNombreAsociadoID
                .InternoID = Me._InternoID
                .IngresoID = Me._InternoIngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
                .NAPrincipal = ob.NAPrincipal
                .NAPaterno = ob.NAPaterno
                .NAMaterno = ob.NAMaterno
                .NANombres = ob.NANombres
                .NAPrincipal2 = ob.NAPrincipal2
                .NAPaterno2 = ob.NAPaterno2
                .NAMaterno2 = ob.NAMaterno2
                .NANombres2 = ob.NANombres2
                .NAEstado = ob.NAEstado
                .DocumentoJudicialID = DocJudicialID
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With
            Dim objEnt As New Entity.Registro.NombreAsociado
            'With objEnt
            '    objEnt.Codigo = ob.Codigo 'DocumentoNomAsociadoId
            '    /* datos nombre asociado */
            objEnt.FlagTransferenciaSede = Me.FlagTransferSede
            objEnt.DocumentoNomAsociadoId = ob.Codigo 'reg_doc_IntNombreAsociado
            objEnt.Codigo = ob.InternoNombreAsociadoID 'nom_aso_id
            objEnt.InternoID = Me._InternoID
            objEnt.IngresoID = Me._InternoIngresoId
            objEnt.IngresoInpeID = Me._InternoIngresoInpeId
            objEnt.Principal = ob.NAPrincipal2
            objEnt.ApellidoPaterno = ob.NAPaterno2
            objEnt.ApellidoMaterno = ob.NAMaterno2
            objEnt.Nombres = ob.NANombres2
            objEnt.DocumentoJudicialID = DocJudicialID
            objEnt.RegionID = Me._RegionID
            objEnt.PenalID = Me._PenalID

            Dim bssDocNomAsoc As New Bussines.Registro.Documento.NombresAsociados
            Dim intCodigoNA As Integer = -1
            objBssNA = New Bussines.Registro.NombreAsociado

            Dim objNA As New Entity.Registro.NombreAsociado
            objEnt.DocumentoJudicialID_NA = ob.Codigo

            objInt = bssInt.Listar_v5(Me._InternoID)
            blnCondicion = False
            'objInt.FlagTransferenciaSede = Me.FlagTransferSede
            objNA.ApellidoPaterno = objInt.ApellidoPaterno
            objNA.ApellidoMaterno = objInt.ApellidoMaterno
            objNA.Nombres = objInt.Nombres
            objNA.InternoID = objInt.Codigo
            blnCondicion = objBssNA.ValidarNombre_LM(objNA)
            objEnt.Estado = 1

            Select Case objEntDoc.NAEstado
                Case Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aniadido
                    If Nuevo = True Then
                        objEnt.Codigo = -1
                    End If
                Case Type.Enumeracion.SubTipoDocJudicial.enumAccion.Anulado
                    objEnt.Estado = 0
                Case Type.Enumeracion.SubTipoDocJudicial.enumAccion.Ninguno
                    objEnt.Principal = ob.NAPrincipal
                    objEnt.ApellidoPaterno = ob.NAPaterno
                    objEnt.ApellidoMaterno = ob.NAMaterno
                    objEnt.Nombres = ob.NANombres
            End Select
            If Me._InternoNAIngresoInpeId < 1 And objEnt.Codigo > 1 And objEnt.IngresoInpeID < 1 Then
                Me._InternoNAIngresoInpeId = objBssNA.GrabarIngreso_LM(objEnt.Codigo, objEnt.IngresoInpeID, Me.FlagTransferSede)
            End If
            'objEnt.FlagTransferenciaSede = Me.FlagTransferSede
            intCodigoNA = objBssNA.GrabarNA2_LM(objEnt)
            '-------------------------------------------
            If intCodigoNA > 0 Then
                If objEntDoc.NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aniadido Then
                    objEntDoc.NAPrincipal = -1
                End If
                If Nuevo = True Then
                    objEntDoc.InternoNombreAsociadoID = intCodigoNA
                    objEntDoc.Codigo = -1
                Else
                    objEntDoc.DocumentoJudicialID = DocJudicialID
                    objEntDoc.InternoNombreAsociadoID = intCodigoNA
                    objEntDoc.Codigo = objEntDoc.DocumentoNomAsociadoId
                    objEntDoc.InternoID = objEntDoc.InternoID
                    objEntDoc.IngresoID = objEntDoc.IngresoID
                    objEntDoc.IngresoInpeId = objEntDoc.IngresoInpeId
                End If
                'objEntDoc.FlagTransferenciaSede = Me.FlagTransferSede
                bssDocNomAsoc.Grabar_v2_LM(objEntDoc)
                If objEntDoc.NAPrincipal2 = 1 Then
                    Dim objEnt2 As New Entity.Registro.NombreAsociado
                    If Nuevo = True Then
                        If objEntDoc.NAEstado = enumAccion.Aclarado And objEntDoc.NAPrincipal = 1 And objEntDoc.NAPrincipal2 = 1 And blnCondicion = True Then
                            If Me._InternoIngresoInpeId = intIngresoInpeMayor Then
                                'objEnt2.FlagTransferenciaSede = Me.FlagTransferSede
                                objEnt2.ApellidoPaterno = objInt.ApellidoPaterno
                                objEnt2.ApellidoMaterno = objInt.ApellidoMaterno
                                objEnt2.Nombres = objInt.Nombres
                                objEnt2.Principal = 0
                                objEnt2.InternoID = Me._InternoID
                                objEnt2.IngresoID = Me._InternoIngresoId
                                objEnt2.IngresoInpeID = Me._InternoIngresoInpeId
                                objEnt2.Estado = ob.NAEstado
                                objEnt2.DocumentoJudicialID = DocJudicialID
                                objEnt2.RegionID = Me._RegionID
                                objEnt2.PenalID = Me._PenalID
                                objBssNA.GrabarNA2_LM(objEnt2)
                            End If
                        End If
                    End If
                    CodigoPrincipalNA = intCodigoNA
                    Dim Valor As Integer = -1
                    Dim objBssInt As New Bussines.Registro.Interno
                    objEnt.Principal = 1
                    objBssNA = New Bussines.Registro.NombreAsociado
                    objEnt.NuevoNA = intCodigoNA
                    objEnt.InternoID = Me._InternoID

                    '        '----------------swsws
                    If Me._InternoIngresoInpeId = intIngresoInpeMayor Then
                        objInt = New Entity.Registro.Interno
                        'objInt.FlagTransferenciaSede = Me.FlagTransferSede
                        objInt.Codigo = Me._InternoID
                        objInt.IngresoID = Me._InternoIngresoId
                        objInt.IngresoInpeId = Me._InternoIngresoInpeId
                        objInt.ApellidoPaterno = objEntDoc.NAPaterno2
                        objInt.ApellidoMaterno = objEntDoc.NAMaterno2
                        objInt.Nombres = objEntDoc.NANombres2
                        objInt.DocJudIDAux = objEntDoc.DocumentoJudicialID
                        objInt.DocJudTipAux = Me._DocumentoTipoId
                        objInt.FlagTransferenciaSede = Me.FlagTransferSede
                        objBssInt.GrabarApellidosyNombres_LM(objInt)

                        IntHistorico.InternoID = Me._InternoID
                        IntHistorico.IngresoID = Me._InternoIngresoId
                        IntHistorico.IngresoInpeId = Me._InternoIngresoInpeId
                        IntHistorico.ApellidoPaterno = objEntDoc.NAPaterno2
                        IntHistorico.ApellidoMaterno = objEntDoc.NAMaterno2
                        IntHistorico.Nombres = objEntDoc.NANombres2
                        IntHistorico.DocJudIDAux = objEntDoc.DocumentoJudicialID
                        IntHistorico.FlagTransferenciaSede = Me.FlagTransferSede
                        bssIntHist.ActualizarInternoHistorico_LM(IntHistorico)
                    Else
                        Dim intAclaratoriaSup As Integer = bssDocNomAsoc.ValidarDocumentoAclarados_LM(Me._InternoID, Me._InternoIngresoInpeId)
                        If intAclaratoriaSup = 0 Then
                            objInt = New Entity.Registro.Interno
                            objInt.FlagTransferenciaSede = Me.FlagTransferSede
                            objInt.Codigo = Me._InternoID
                            objInt.IngresoID = Me._InternoIngresoId
                            objInt.IngresoInpeId = Me._InternoIngresoInpeId
                            objInt.ApellidoPaterno = objEntDoc.NAPaterno2
                            objInt.ApellidoMaterno = objEntDoc.NAMaterno2
                            objInt.Nombres = objEntDoc.NANombres2
                            objInt.DocJudIDAux = objEntDoc.DocumentoJudicialID
                            objBssInt.GrabarApellidosyNombres_LM(objInt)

                            IntHistorico.InternoID = Me._InternoID
                            IntHistorico.IngresoID = Me._InternoIngresoId
                            IntHistorico.IngresoInpeId = Me._InternoIngresoInpeId
                            IntHistorico.ApellidoPaterno = objEntDoc.NAPaterno2
                            IntHistorico.ApellidoMaterno = objEntDoc.NAMaterno2
                            IntHistorico.Nombres = objEntDoc.NANombres2
                            IntHistorico.DocJudIDAux = objEntDoc.DocumentoJudicialID
                            IntHistorico.FlagTransferenciaSede = Me.FlagTransferSede
                            bssIntHist.ActualizarInternoHistorico_LM(IntHistorico)
                        Else
                            IntHistorico.InternoID = Me._InternoID
                            IntHistorico.IngresoID = Me._InternoIngresoId
                            IntHistorico.IngresoInpeId = Me._InternoIngresoInpeId
                            IntHistorico.ApellidoPaterno = objEntDoc.NAPaterno2
                            IntHistorico.ApellidoMaterno = objEntDoc.NAMaterno2
                            IntHistorico.Nombres = objEntDoc.NANombres2
                            IntHistorico.DocJudIDAux = objEntDoc.DocumentoJudicialID
                            IntHistorico.FlagTransferenciaSede = Me.FlagTransferSede
                            bssIntHist.ActualizarInternoHistoricoxDocumento_LM(IntHistorico)
                        End If

                    End If
                End If
            End If
        Next

        IntHistorico.IngresoID = Me._InternoIngresoId
        IntHistorico.IngresoInpeId = Me._InternoIngresoInpeId
        Dim DocJudicialMayor As Integer = bssIntHist.Validar_DocumentoID_LM(IntHistorico)
        Dim bssDocNA As New Bussines.Registro.Documento.NombresAsociados
        If DocJudicialMayor > 0 Then
            bssDocNA.ActualizarUltimoNA_LM(-1, Me._InternoID, Me._InternoIngresoInpeId, DocJudicialMayor, Nothing, Me.FlagTransferSede)
        End If

    End Sub
    Public Sub AgrabarNombresasociados(DocJudicialID As Integer, Nuevo As Boolean)
        Me._InternoNAIngresoId = NombresAsociadosNegativo()
        Dim CodigoPrincipalNA As Integer = -1

        Dim bssInt As New Bussines.Registro.Interno
        Dim objInt As New Entity.Registro.Interno
        Dim blnCondicion As Boolean = False
        Dim intValue As Integer = -1
        Dim bssIntHist As New Bussines.Registro.InternoHistorico
        Dim IntHistorico As New Entity.Registro.InternoHistorico
        'IntHistorico.FlagTransferenciaSede = Me.FlagTransferSede
        IntHistorico.InternoID = Me._InternoID
        Dim intIngresoMayor As Integer = bssIntHist.Validar_IngresoID(IntHistorico)

        For Each ob As Entity.Registro.Documento.NombresAsociados In _Lista_NombresAsociados
            'ob.FlagTransferenciaSede = Me.FlagTransferSede
            Dim objEntDoc As New Entity.Registro.Documento.NombresAsociados
            With objEntDoc
                '.FlagTransferenciaSede = Me.FlagTransferSede
                .DocumentoNomAsociadoId = ob.Codigo
                .InternoNombreAsociadoID = ob.InternoNombreAsociadoID
                .InternoID = Me._InternoID
                .IngresoID = Me._InternoIngresoId
                .NAPrincipal = ob.NAPrincipal
                .NAPaterno = ob.NAPaterno
                .NAMaterno = ob.NAMaterno
                .NANombres = ob.NANombres
                .NAPrincipal2 = ob.NAPrincipal2
                .NAPaterno2 = ob.NAPaterno2
                .NAMaterno2 = ob.NAMaterno2
                .NANombres2 = ob.NANombres2
                .NAEstado = ob.NAEstado
                .DocumentoJudicialID = DocJudicialID
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With
            Dim objEnt As New Entity.Registro.NombreAsociado
            'With objEnt
            '    objEnt.Codigo = ob.Codigo 'DocumentoNomAsociadoId
            '    /* datos nombre asociado */
            'objEnt.FlagTransferenciaSede = Me.FlagTransferSede
            objEnt.DocumentoNomAsociadoId = ob.Codigo 'reg_doc_IntNombreAsociado
            objEnt.Codigo = ob.InternoNombreAsociadoID 'nom_aso_id
            objEnt.InternoID = Me._InternoID
            objEnt.IngresoID = Me._InternoIngresoId
            objEnt.Principal = ob.NAPrincipal2
            objEnt.ApellidoPaterno = ob.NAPaterno2
            objEnt.ApellidoMaterno = ob.NAMaterno2
            objEnt.Nombres = ob.NANombres2
            objEnt.DocumentoJudicialID = DocJudicialID
            objEnt.RegionID = Me._RegionID
            objEnt.PenalID = Me._PenalID

            Dim bssDocNomAsoc As New Bussines.Registro.Documento.NombresAsociados
            Dim intCodigoNA As Integer = -1
            objBssNA = New Bussines.Registro.NombreAsociado

            Dim objNA As New Entity.Registro.NombreAsociado
            objEnt.DocumentoJudicialID_NA = ob.Codigo

            objInt = bssInt.Listar_v5(Me._InternoID)
            blnCondicion = False
            'objInt.FlagTransferenciaSede = Me.FlagTransferSede
            objNA.ApellidoPaterno = objInt.ApellidoPaterno
            objNA.ApellidoMaterno = objInt.ApellidoMaterno
            objNA.Nombres = objInt.Nombres
            objNA.InternoID = objInt.Codigo
            blnCondicion = objBssNA.ValidarNombre(objNA)
            objEnt.Estado = 1

            Select Case objEntDoc.NAEstado
                Case Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aniadido
                    If Nuevo = True Then
                        objEnt.Codigo = -1
                    End If
                    'Case Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aclarado
                Case Type.Enumeracion.SubTipoDocJudicial.enumAccion.Anulado
                    objEnt.Estado = 0
                Case Type.Enumeracion.SubTipoDocJudicial.enumAccion.Ninguno
                    objEnt.Principal = ob.NAPrincipal
                    objEnt.ApellidoPaterno = ob.NAPaterno
                    objEnt.ApellidoMaterno = ob.NAMaterno
                    objEnt.Nombres = ob.NANombres
            End Select
            If Me._InternoNAIngresoId < 1 And objEnt.Codigo > 1 And objEnt.IngresoID < 1 Then
                Me._InternoNAIngresoId = objBssNA.GrabarIngreso(objEnt.Codigo, objEnt.IngresoID, Me.FlagTransferSede)
            End If
            'objEnt.FlagTransferenciaSede = Me.FlagTransferSede
            intCodigoNA = objBssNA.GrabarNA2(objEnt)
            '-------------------------------------------
            If intCodigoNA > 0 Then
                If objEntDoc.NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aniadido Then
                    objEntDoc.NAPrincipal = -1
                End If
                If Nuevo = True Then

                    objEntDoc.InternoNombreAsociadoID = intCodigoNA
                    objEntDoc.Codigo = -1

                Else
                    objEntDoc.DocumentoJudicialID = DocJudicialID
                    objEntDoc.InternoNombreAsociadoID = intCodigoNA
                    objEntDoc.Codigo = objEntDoc.DocumentoNomAsociadoId
                    objEntDoc.InternoID = objEntDoc.InternoID
                    objEntDoc.IngresoID = objEntDoc.IngresoID
                    objEntDoc.IngresoInpeId = objEntDoc.IngresoInpeId
                End If
                'objEntDoc.FlagTransferenciaSede = Me.FlagTransferSede
                bssDocNomAsoc.Grabar_v2(objEntDoc)
                If objEntDoc.NAPrincipal2 = 1 Then


                    Dim objEnt2 As New Entity.Registro.NombreAsociado

                    If Nuevo = True Then

                        If objEntDoc.NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aclarado And objEntDoc.NAPrincipal = 1 And objEntDoc.NAPrincipal2 = 1 And blnCondicion = True Then
                            If Me._InternoIngresoId = intIngresoMayor Then
                                'objEnt2.FlagTransferenciaSede = Me.FlagTransferSede
                                objEnt2.ApellidoPaterno = objInt.ApellidoPaterno
                                objEnt2.ApellidoMaterno = objInt.ApellidoMaterno
                                objEnt2.Nombres = objInt.Nombres
                                objEnt2.Principal = 0
                                objEnt2.InternoID = Me._InternoID
                                objEnt2.IngresoID = Me._InternoIngresoId
                                objEnt2.Estado = ob.NAEstado
                                objEnt2.DocumentoJudicialID = DocJudicialID
                                objEnt2.RegionID = Me._RegionID
                                objEnt2.PenalID = Me._PenalID
                                objBssNA.GrabarNA2(objEnt2)
                            End If
                        End If
                    End If
                    CodigoPrincipalNA = intCodigoNA
                    Dim Valor As Integer = -1
                    Dim objBssInt As New Bussines.Registro.Interno
                    objEnt.Principal = 1
                    objBssNA = New Bussines.Registro.NombreAsociado
                    objEnt.NuevoNA = intCodigoNA
                    objEnt.InternoID = Me._InternoID

                    '        '----------------swsws
                    If Me._InternoIngresoId = intIngresoMayor Then
                        objInt = New Entity.Registro.Interno
                        'objInt.FlagTransferenciaSede = Me.FlagTransferSede
                        objInt.Codigo = Me._InternoID
                        objInt.IngresoID = Me._InternoIngresoId
                        objInt.ApellidoPaterno = objEntDoc.NAPaterno2
                        objInt.ApellidoMaterno = objEntDoc.NAMaterno2
                        objInt.Nombres = objEntDoc.NANombres2
                        objInt.DocJudIDAux = objEntDoc.DocumentoJudicialID
                        objInt.DocJudTipAux = Me._DocumentoTipoId
                        objBssInt.GrabarApellidosyNombres(objInt)

                        IntHistorico.InternoID = Me._InternoID
                        IntHistorico.IngresoID = Me._InternoIngresoId
                        IntHistorico.ApellidoPaterno = objEntDoc.NAPaterno2
                        IntHistorico.ApellidoMaterno = objEntDoc.NAMaterno2
                        IntHistorico.Nombres = objEntDoc.NANombres2
                        IntHistorico.DocJudIDAux = objEntDoc.DocumentoJudicialID
                        'IntHistorico.DocJudTipAux = Me._DocumentoTipoId
                        bssIntHist.ActualizarInternoHistorico(Me._InternoID, Me._InternoIngresoId, IntHistorico)
                    Else
                        Dim intAclaratoriaSup As Integer = bssDocNomAsoc.ValidarDocumentoAclarados(Me._InternoID, Me._InternoIngresoId)
                        If intAclaratoriaSup = 0 Then
                            objInt = New Entity.Registro.Interno
                            ' objInt.FlagTransferenciaSede = Me.FlagTransferSede
                            objInt.Codigo = Me._InternoID
                            objInt.IngresoID = Me._InternoIngresoId
                            objInt.ApellidoPaterno = objEntDoc.NAPaterno2
                            objInt.ApellidoMaterno = objEntDoc.NAMaterno2
                            objInt.Nombres = objEntDoc.NANombres2
                            objInt.DocJudIDAux = objEntDoc.DocumentoJudicialID
                            objBssInt.GrabarApellidosyNombres(objInt)

                            IntHistorico.InternoID = Me._InternoID
                            IntHistorico.IngresoID = Me._InternoIngresoId
                            IntHistorico.ApellidoPaterno = objEntDoc.NAPaterno2
                            IntHistorico.ApellidoMaterno = objEntDoc.NAMaterno2
                            IntHistorico.Nombres = objEntDoc.NANombres2
                            IntHistorico.DocJudIDAux = objEntDoc.DocumentoJudicialID
                            'IntHistorico.DocJudTipAux = Me._DocumentoTipoId
                            bssIntHist.ActualizarInternoHistorico(Me._InternoID, Me._InternoIngresoId, IntHistorico)
                        Else
                            IntHistorico.InternoID = Me._InternoID
                            IntHistorico.IngresoID = Me._InternoIngresoId
                            IntHistorico.ApellidoPaterno = objEntDoc.NAPaterno2
                            IntHistorico.ApellidoMaterno = objEntDoc.NAMaterno2
                            IntHistorico.Nombres = objEntDoc.NANombres2
                            IntHistorico.DocJudIDAux = objEntDoc.DocumentoJudicialID
                            'IntHistorico.DocJudTipAux = Me._DocumentoTipoId
                            bssIntHist.ActualizarInternoHistoricoxDocumento(Me._InternoID, Me._InternoIngresoId, IntHistorico)
                        End If

                    End If
                End If
            End If
        Next

        IntHistorico.IngresoID = Me._InternoIngresoId
        Dim DocJudicialMayor As Integer = bssIntHist.Validar_DocumentoID(IntHistorico)
        Dim bssDocNA As New Bussines.Registro.Documento.NombresAsociados
        If DocJudicialMayor > 0 Then
            bssDocNA.ActualizarUltimoNA(-1, Me._InternoID, Me._InternoIngresoId, DocJudicialMayor, Nothing, Me.FlagTransferSede)
        End If

    End Sub

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

    Public Sub GrabarNombreAsociadoTemporal(obj As Entity.Registro.Documento.NombresAsociados, Nuevo As Boolean)
        If Me._Codigo = -1 Then 'si doc. judicial/resolucion es nuevo 
            If Nuevo = True Then
                If obj.NAPrincipal = 1 Then
                    For Each x As Entity.Registro.Documento.NombresAsociados In objEntNACol
                        x.NAPrincipal = 0 'setear a nombres asociados todos los demas
                    Next
                End If
                objEntNACol.Add(obj)
            End If

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                ListarNombreAsociado_LM(-1, Me._InternoID, Me._InternoIngresoId, Me._InternoIngresoInpeId)
            Else
                ListarNombreAsociado(-1, Me._InternoID, Me._InternoIngresoId)
            End If
        Else
            MsgBox("Operación no permitida", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Function EliminarNombreAsociado() As Integer
        If dgwNomAsoc.Rows.Count < 1 Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation("No existen datos a eliminar")
            Exit Function
        End If
        If ValorEli = True Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation("El nombre asociado no puede ser eliminado porque pertenece a un expediente referenciado")
            Exit Function
        End If


        If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar() = DialogResult.Yes Then
            If Me._Codigo > 0 Then
                If dgwNomAsoc.SelectedRows(0).Cells("col_codigo").Value > 0 Then
                    blnEliminar = True
                    Dim EntDocNA As New Entity.Registro.Documento.NombresAsociados
                    EntDocNA.Codigo = dgwNomAsoc.SelectedRows(0).Cells("col_codigo").Value
                    EntDocNA.InternoNombreAsociadoID = dgwNomAsoc.SelectedRows(0).Cells("col_int_nom_aso_id").Value
                    objEntNACol_cop.Add(EntDocNA)
                End If
            End If
            objEntNACol.RemoveAt(dgwNomAsoc.SelectedRows(0).Index)
            'ListarNombreAsociado(_Codigo, Me._InternoID)
            With Me.dgwNomAsoc
                .DataSource = ""
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = IIf(objEntNACol Is Nothing, Nothing, objEntNACol)
            End With
            If Me.dgwNomAsoc.RowCount > 0 Then
                Me.dgwNomAsoc.Rows(0).Selected = True
            End If
        End If
    End Function


#End Region
#Region "Otros"
    Private Sub ValoresxDefault()
        If Me._DocumentoSubTipoId = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Aclaratoria_de_Expediente Then
            Exit Sub
        End If

        If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
            btnAgregarNomAsoc.Enabled = False
            btnAulNomAsociado.Visible = False
            btnDelNomAsociado.Visible = False
        End If

        If _blnNuevo = True Then
            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                ListarNombreAsociadoBD_LM(Me._Codigo, Me._InternoID, Me._InternoIngresoId, _InternoIngresoInpeId)
            Else
                ListarNombreAsociadoBD(Me._Codigo, Me._InternoID, Me._InternoIngresoId)
            End If
        Else
            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                ListarNombreAsociado_LM(Me._Codigo, Me._InternoID, Me._InternoIngresoId, Me._InternoIngresoInpeId)
            Else
                ListarNombreAsociado(Me._Codigo, Me._InternoID, Me._InternoIngresoId)
            End If

        End If
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


    Private Sub btnEditarNomAsoc_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarNomAsoc.Click
        Me._ValorAniadir = False
        If dgwNomAsoc.Rows.Count < 1 Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation("No existen datos a modificar")
            Exit Sub
        End If
        RaiseEvent _Click_BtnEditarNombreAsociado(objEntNACol.NombresAsociados(Me.GrillaPosic), Nothing, Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aclarado)
    End Sub
    Public _ValorAniadir As Boolean = False
    Private Sub btnAgregarNomAsoc_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarNomAsoc.Click

        _ValorAniadir = True
        If objEntNACol Is Nothing Or (objEntNACol.Count = 0) Then
            RaiseEvent _Click_BtnAgregarNombreAsociado(Nothing, Nothing, Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aniadido)
        Else
            RaiseEvent _Click_BtnAgregarNombreAsociado(objEntNACol.NombresAsociados(Me.GrillaPosic), objEntNACol, Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aniadido)
        End If

    End Sub

    Public Function ValidarExpedienteReferenciado(Condicion As String) As Boolean
        If Me._DocumentoJudicialID > 0 Then
            Dim strMensaje As String = ""
            Dim intValorpadre As Integer = 0
            objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
            Select Case Condicion
                Case 1
                    strMensaje = "no se puede agregar expedientes"
                Case 2
                    strMensaje = "no se puede agregar delitos"
                Case 3
                    strMensaje = "no se puede agregar agraviados"
                Case 4
                    strMensaje = "No se puede modificar el documento porque forma parte del expediente"
                Case 7
                    strMensaje = " [Operación cancelada]"
            End Select

            For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteTempoCol
                objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                If objEntExpediente.Codigo > 0 Then
                    objEntExpPadre.InternoExpedienteId = objEntExpediente.Codigo
                    Dim blnValor As Boolean = objBssExpedientePad.ValidarExpediente(objEntExpPadre)
                    If blnValor = False Then
                        intValorpadre = intValorpadre + 1
                    End If
                End If
            Next


            If intValorpadre > 0 Then
                'Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado," & strMensaje)
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub dgwNomAsoc_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwNomAsoc.CellDoubleClick
        Dim columnIndex As Integer = e.ColumnIndex
        ' Obtenemos el nombre de la columna
        ' correspondiente a la celda
        Dim columnName As String = dgwNomAsoc.Columns.Item(columnIndex).Name
        If columnName = "col_est_id" Then
        Else
            If btnEditarNomAsoc.Enabled = True And btnEditarNomAsoc.Visible = True Then
                btnEditarNomAsoc_Click(Nothing, Nothing)
            End If
        End If
    End Sub
    Public Property ValorEli As Boolean = False
    Public Property ValorVal As Boolean = False
    Private Sub btnDelNomAsociado_Click(sender As System.Object, e As System.EventArgs) Handles btnDelNomAsociado.Click
        If Me._DocumentoJudicialID > 0 And Me._DocumentoSubTipoId > 1 Then
            RaiseEvent _Click_ConsultarExpedienteReferenciado()
            If Me._ValorReferencia = True Then
                Exit Sub
            End If
        End If
        If objEntNACol.NombresAsociados(Me.GrillaPosic).NAEstadoOri > -1 Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede eliminar la acción del nombre asociado, porque ya ha sido registrado")
            btnAgregarNomAsoc.Focus()
            Exit Sub
        End If
        If objEntNACol.NombresAsociados(Me.GrillaPosic).NAEstado = -1 Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe ninguna accion para eliminar")
            btnAgregarNomAsoc.Focus()
            Exit Sub
        End If
        If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = DialogResult.Yes Then
            If objEntNACol.NombresAsociados(Me.GrillaPosic).NAEstado = 2 Then
                objEntNACol.RemoveAt(Me.GrillaPosic)
                With Me.dgwNomAsoc
                    .DataSource = ""
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False
                    .DataSource = IIf(objEntNACol Is Nothing, Nothing, objEntNACol)
                End With
                Me.grbNombreAso.Text = "Nombres Asociados " & objEntNACol.Count & " Reg."
            Else
                With objEntNACol
                    .NombresAsociados(Me.GrillaPosic).NAEstado = -1
                    .NombresAsociados(Me.GrillaPosic).NAPrincipal2 = -1
                    .NombresAsociados(Me.GrillaPosic).NAPaterno2 = ""
                    .NombresAsociados(Me.GrillaPosic).NAMaterno2 = ""
                    .NombresAsociados(Me.GrillaPosic).NANombres2 = ""
                    .NombresAsociados(Me.GrillaPosic).ValorRef = False
                End With
                dgwNomAsoc.Refresh()
            End If
        End If
    End Sub

#End Region

    Private Sub dgwNomAsoc_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwNomAsoc.CellValueChanged
        If e.ColumnIndex = -1 Or e.RowIndex = -1 Then Exit Sub

        If dgwNomAsoc.Columns(e.ColumnIndex).Name = "col_est_id" Then
            For i As Integer = 0 To objEntNACol.Count - 1
                'If entNA.i = dgwNomAsoc.Item("col_est", e.RowIndex).Value Then
                If dgwNomAsoc.Item("col_est_id", i).Value = "Activo" Then
                    objEntNACol.NombresAsociados(i).NAEstado = 1
                    objEntNACol.NombresAsociados(i).NAEstadoNom = "Activo"
                Else
                    objEntNACol.NombresAsociados(i).NAEstado = 0
                    objEntNACol.NombresAsociados(i).NAEstadoNom = "Anulado"
                End If
                'End If
            Next
        End If
    End Sub
    Private Sub btnAulNomAsociado_Click(sender As System.Object, e As System.EventArgs) Handles btnAulNomAsociado.Click
        If Me._DocumentoJudicialID > 0 And Me._DocumentoSubTipoId > 1 Then
            RaiseEvent _Click_ConsultarExpedienteReferenciado()
            If Me._ValorReferencia = True Then
                Exit Sub
            End If
        End If
        If dgwNomAsoc.SelectedRows(0).Cells("col_accion").Value = "NINGUNO" Then
            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("Esta seguro de [Anular] el nombre asociado") = DialogResult.Yes Then
                With objEntNACol
                    .NombresAsociados(Me.GrillaPosic).NAPrincipal2 = IIf(dgwNomAsoc.SelectedRows(0).Cells("col_nom_prin").Value = True, 1, 0)
                    .NombresAsociados(Me.GrillaPosic).NAPaterno2 = dgwNomAsoc.SelectedRows(0).Cells("col_ape_pat").Value
                    .NombresAsociados(Me.GrillaPosic).NAMaterno2 = dgwNomAsoc.SelectedRows(0).Cells("col_ape_mat").Value
                    .NombresAsociados(Me.GrillaPosic).NANombres2 = dgwNomAsoc.SelectedRows(0).Cells("col_nom").Value
                    .NombresAsociados(Me.GrillaPosic).NAEstado2 = 0
                    .NombresAsociados(Me.GrillaPosic).NAEstado = 0
                    dgwNomAsoc.Refresh()
                End With
            End If
        Else
            Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede [Anular] el nombre asociado, ya posee una acción")
            Me.btnAgregarNomAsoc.Focus()
        End If
    End Sub

    Private Sub uscResolAclaratoriaNombresAsoc_Load(sender As Object, e As EventArgs) Handles Me.Load

        'deshabilitar controles de mantenimiento
        Select Case Me._TipoLicencia
            Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                Me.grbBotMantNomAsoc.Visible = False
        End Select

    End Sub
End Class
