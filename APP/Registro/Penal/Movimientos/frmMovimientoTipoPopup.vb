Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia

Namespace Registro.Movimientos
    Public Class frmMovimientoTipoPopup
        Private objBssInt As Bussines.Registro.InternoMovimiento = Nothing
#Region "Propiedades Parametricas"
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _RegionID() As Short = -1
        Public Property _PenalID() As Short = -1
        Public Property _NuevoRegistro() As Boolean = False
        Public Property _NroPendientes As Integer = 0
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Public Property _Documentos_sin_mov As Boolean = False
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region
#Region "Propiedades_retorno"
        Public ReadOnly Property _Codigo() As Integer
            Get
                Return Me.GrillaCodigo
            End Get
        End Property
#End Region
#Region "Listar"

        Private Sub Listar()

            If Me._InternoID < 1 Then
                Exit Sub
            End If
            Dim objBss As New Bussines.Mantenimiento.Registro.Movimiento
            Dim objEntCol As New Entity.Mantenimiento.Registro.MovimientoCol

            objEntCol = objBss.ListarMotivoxLicencia(-1, _TipoLicencia)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
            End With

            If Me.dgwGrilla.RowCount > 0 Then
                Me.dgwGrilla.Rows(0).Selected = True
                Me.lblReg.Text = dgwGrilla.RowCount.ToString
            End If
        End Sub
#End Region
#Region "Forms"

        Private Sub FRM_Movimiento()

            Dim objentcol As New Entity.Registro.InternoMovimientoCol
            Dim entMov As New Entity.Registro.InternoMovimiento

            If Me._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de ingresar un Movimiento, grabe los datos del interno")
                Exit Sub
            End If

            objBssInt = New Bussines.Registro.InternoMovimiento
            entMov.MovimientoTipoID = -1 ' Me.GrillaCodigo
            entMov.InternoID = Me._InternoID
            entMov.IngresoID = Me._IngresoID
            entMov.IngresoInpeId = Me._InternoIngresoInpeId
            Dim ContaVal As Integer = 0

            If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objentcol = objBssInt.ListarGrilla_LM(entMov)
            Else
                objentcol = objBssInt.ListarGrilla(entMov)
            End If

            Dim GrupoId As Integer = -1
            Dim MovimientoTipoID As Integer = -1
            Dim strMensaje As String = "El interno no cuenta con un movimiento de ingreso, " + Chr(13) +
                                       "o Traslado de ingreso" + Chr(13) +
                                       "" + Chr(13) +
                                       "para registralo ir a la pestaña " + Chr(13) +
                                       "[Documentos Judiciales y Resoluciones]  ó" + Chr(13) +
                                       "[Movimiento de Ingreso / Egreso]"
            Dim strMensajeMov As String = ""

            Select Case Me.GrillaCodigo
                Case Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento  'internamiento

                    If objBssInt.ValidaMovimientoInterno(entMov) = -1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        Exit Sub
                    Else
                        If Me._TipoLicencia <> enmTipoLicencia.Carceleta Then
                            'If Me._Documentos_sin_mov = False Then
                            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("El internamiento se registra desde la resolucion de ingreso")
                            '    Me.Close()
                            '    Exit Sub
                            'End If
                        End If
                        If objentcol.Count > 0 Then
                            Dim blnValor As Boolean = False
                            For Each obj As Entity.Registro.InternoMovimiento In objentcol
                                If obj.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento Then
                                    blnValor = True
                                End If
                            Next
                            If blnValor = True Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede resgistrar el internamiento, porque existe un movimiento de ingreso activo.")
                                Me.Close()
                                Exit Sub
                            End If
                        End If
                    End If

                    If objentcol.Count > 0 Then
                        GrupoId = objentcol.InternoMovimiento(0).MovimientoGrupoID
                        MovimientoTipoID = objentcol.InternoMovimiento(0).MovimientoTipoID
                    End If

                    If GrupoId = EnumMovGrupo.Ingreso And MovimientoTipoID = EnumMovTipo.Traslado Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede resgistrar el internamiento, porque existe un movimiento de ingreso activo.")
                        Me.Close()
                        Exit Sub
                    End If
                    FRM_Mant_Internamiento()

                Case Type.Enumeracion.Movimiento.EnumMovTipo.Traslado

                    strMensajeMov = "El interno no puede ser [Trasladado],"
                    If objentcol.Count = 0 Then
                        If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or
                             Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                            FRM_Traslado(GrupoId)
                        Else
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                            Exit Sub
                        End If
                    Else
                        GrupoId = objentcol.InternoMovimiento(0).MovimientoGrupoID
                        MovimientoTipoID = objentcol.InternoMovimiento(0).MovimientoTipoID

                        If MovimientoTipoID = EnumMovTipo.Conducciones And GrupoId = EnumMovGrupo.Egreso Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeMov + Chr(13) +
                                                                                    " porque ha sido registrado como [Conducido] a otro lugar.")
                            Exit Sub
                        End If
                        If MovimientoTipoID = EnumMovTipo.Fuga Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeMov + Chr(13) +
                                                                                    " porque esta registrado como fugado")
                            Exit Sub
                        End If
                        If objentcol.InternoMovimiento(0).MovimientoTipoID = EnumMovTipo.Fallecimiento Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno esta registrado como fallecido")
                            Exit Sub
                        End If
                        If objentcol.InternoMovimiento(0).MovimientoTipoID = EnumMovTipo.Libertad Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno esta registrado como excarcelado.")
                            Exit Sub
                        End If

                        FRM_Traslado(GrupoId)
                    End If

                Case Type.Enumeracion.Movimiento.EnumMovTipo.Libertad  'libertad 

                    strMensajeMov = "El interno no puede ser registrado con [Libertad],"

                    If objentcol.Count = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        Exit Sub
                    Else
                        GrupoId = objentcol.InternoMovimiento(0).MovimientoGrupoID
                        MovimientoTipoID = objentcol.InternoMovimiento(0).MovimientoTipoID
                    End If

                    If MovimientoTipoID = EnumMovTipo.Conducciones And GrupoId = EnumMovGrupo.Egreso Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeMov & " porque ha sido [Conducido] a otro lugar.")
                        Exit Sub
                    End If

                    If MovimientoTipoID = EnumMovTipo.Fuga Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeMov & " porque esta registrado como [Fugado].")
                        Exit Sub
                    End If

                    If objentcol.InternoMovimiento(0).MovimientoTipoID = EnumMovTipo.Fallecimiento Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno esta registrado como [Fallecido].")
                        Exit Sub
                    End If

                    If objentcol.InternoMovimiento(0).MovimientoTipoID = EnumMovTipo.Libertad Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno esta registrado como [Excarcelado].")
                        Exit Sub
                    End If

                    Select Case Me._TipoLicencia
                        Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                            FRM_Libertad()
                        Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                            FRM_LibertadPopup()
                    End Select

                Case Type.Enumeracion.Movimiento.EnumMovTipo.Fuga, Type.Enumeracion.Movimiento.EnumMovTipo.Fallecimiento  'fuga
                    If Me.GrillaCodigo = Type.Enumeracion.Movimiento.EnumMovTipo.Fuga Then
                        strMensajeMov = "El interno no puede ser registrado como 'Fugado'."
                    Else
                        strMensajeMov = "El interno no puede ser registrado como 'Fallecido',"
                    End If

                    If objentcol.Count = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        Exit Sub
                    Else
                        GrupoId = objentcol.InternoMovimiento(0).MovimientoGrupoID
                    End If

                    If objBssInt.ValidaMovimientoInterno(entMov) = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        Exit Sub
                    End If

                    If objentcol.InternoMovimiento(0).MovimientoTipoID = EnumMovTipo.Fuga Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno esta registrado como fugado")
                        Exit Sub
                    End If

                    If objentcol.InternoMovimiento(0).MovimientoTipoID = EnumMovTipo.Fallecimiento Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno esta registrado como fallecido")
                        Exit Sub
                    End If
                    FRM_Fuga(Me.GrillaCodigo)

                Case Type.Enumeracion.Movimiento.EnumMovTipo.Conducciones
                    strMensajeMov = "No se puede realizar la conduccion del interno"
                    If objentcol.Count = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        Exit Sub
                    Else
                        GrupoId = objentcol.InternoMovimiento(0).MovimientoGrupoID
                        MovimientoTipoID = objentcol.InternoMovimiento(0).MovimientoTipoID
                    End If

                    ContaVal = objBssInt.ValidaMovimientoInterno(entMov)

                    If ContaVal = -2 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno registra como fallecido")
                        Exit Sub
                    ElseIf ContaVal = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        Exit Sub
                    End If

                    If MovimientoTipoID = EnumMovTipo.Traslado And GrupoId = EnumMovGrupo.Egreso Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeMov & ", porque ha sido trasladado a otro centro.")
                        Exit Sub
                    End If

                    If MovimientoTipoID = EnumMovTipo.Fuga Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeMov & ", porque esta registrado como fugado.")
                        Exit Sub
                    End If

                    If objentcol.InternoMovimiento(0).MovimientoTipoID = EnumMovTipo.Fallecimiento Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno esta registrado como fallecido.")
                        Exit Sub
                    End If

                    If objentcol.InternoMovimiento(0).MovimientoTipoID = EnumMovTipo.Libertad Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno esta registrado como excarcelado.")
                        Exit Sub
                    End If
                    FRM_Conducciones(GrupoId)
                Case Type.Enumeracion.Movimiento.EnumMovTipo.ConduccionClasificacion
                    strMensajeMov = "No se puede realizar la conduccion del interno"
                    If objentcol.Count = 0 Then
                        If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                            FRM_ConduccionClasificacion(GrupoId)
                            Exit Sub
                        Else
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                            Exit Sub
                        End If
                    Else
                        GrupoId = objentcol.InternoMovimiento(0).MovimientoGrupoID
                        MovimientoTipoID = objentcol.InternoMovimiento(0).MovimientoTipoID
                    End If

                    ContaVal = objBssInt.ValidaMovimientoInterno(entMov)

                    If ContaVal = -2 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno registra como fallecido")
                        Exit Sub
                    ElseIf ContaVal = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        Exit Sub
                    End If

                    If MovimientoTipoID = EnumMovTipo.Traslado And GrupoId = EnumMovGrupo.Egreso Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeMov & ", porque ha sido trasladado a otro centro.")
                        Exit Sub
                    End If

                    If MovimientoTipoID = EnumMovTipo.Fuga Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeMov & ", porque esta registrado como fugado.")
                        Exit Sub
                    End If

                    If objentcol.InternoMovimiento(0).MovimientoTipoID = EnumMovTipo.Fallecimiento Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno esta registrado como fallecido.")
                        Exit Sub
                    End If

                    If objentcol.InternoMovimiento(0).MovimientoTipoID = EnumMovTipo.Libertad Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno esta registrado como excarcelado.")
                        Exit Sub
                    End If
                    If GrupoId = EnumMovGrupo.Ingreso And Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La Conducción por Clasificación de tipo EGRESO" + Chr(13) +
                                                                                "no esta habilitado para los penales de Lima Metropolitana")
                        Exit Sub
                    End If
                    FRM_ConduccionClasificacion(GrupoId)
                Case Type.Enumeracion.Movimiento.EnumMovTipo.TrasladoHospitalmental, Type.Enumeracion.Movimiento.EnumMovTipo.RetornodeHospitalmental

                    strMensajeMov = "El interno no puede ser registrado con [Libertad],"

                    If objentcol.Count = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        Exit Sub
                    Else
                        GrupoId = objentcol.InternoMovimiento(0).MovimientoGrupoID
                        MovimientoTipoID = objentcol.InternoMovimiento(0).MovimientoTipoID
                    End If

                    If MovimientoTipoID = EnumMovTipo.Conducciones And GrupoId = EnumMovGrupo.Egreso Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeMov & " porque ha sido [Conducido] a otro lugar.")
                        Exit Sub
                    End If

                    If MovimientoTipoID = EnumMovTipo.Fuga Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeMov & " porque esta registrado como [Fugado].")
                        Exit Sub
                    End If

                    If objentcol.InternoMovimiento(0).MovimientoTipoID = EnumMovTipo.Fallecimiento Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno esta registrado como [Fallecido].")
                        Exit Sub
                    End If

                    If objentcol.InternoMovimiento(0).MovimientoTipoID = EnumMovTipo.Libertad And
                        objentcol.InternoMovimiento(0).EstadoID = Type.Enumeracion.Movimiento.enmEstadoMovimiento.Terminado Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno esta registrado como [Excarcelado].")
                        Exit Sub
                    End If

                    FRM_EgresoTraslado()

            End Select

        End Sub

        Private Sub FRM_Mant_Internamiento()

            If Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                Dim frm As New Registro.Movimientos.Carceleta.frmInternamiento
                With frm
                    ._Codigo = -1
                    ._InternoID = Me._InternoID
                    ._IngresoID = Me._IngresoID
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._MovimientoTipoID = Me.GrillaCodigo
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._blnNuevo = Me._NuevoRegistro
                    ._TipoDocJudicialID = EnumRegDocTipo.Internamiento
                    ._TipoFormMov = 1
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End With
            ElseIf Me._Documentos_sin_mov = True Then
                Dim frm As New Registro.Movimientos.frmMovimientoInternamientoPopup
                With frm
                    ._Codigo = -1
                    ._InternoID = Me._InternoID
                    ._IngresoID = Me._IngresoID
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._MovimientoTipoID = Me.GrillaCodigo
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._blnNuevo = Me._NuevoRegistro
                    ._TipoDocJudicialID = EnumRegDocTipo.Internamiento
                    ._TipoFormMov = 1
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End With
            Else
                Dim frm As New Registro.Movimientos.frmMovimientoInternamientoCarceleta
                With frm
                    ._Codigo = -1
                    ._InternoID = Me._InternoID
                    ._IngresoID = Me._IngresoID
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._MovimientoTipoID = Me.GrillaCodigo
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._blnNuevo = Me._NuevoRegistro
                    ._TipoDocJudicialID = EnumRegDocTipo.Internamiento
                    ._TipoFormMov = 1
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End With
            End If

        End Sub
        Private Sub FRM_Traslado(GrupoID As Integer)

            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or
               Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then

                Dim frm As New Registro.Movimientos.Carceleta.frmMovimientoTrasladoCarceleta
                With frm
                    ._Codigo = -1
                    ._InternoID = Me._InternoID
                    ._IngresoID = Me._IngresoID
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._MovimientoTipoID = Me.GrillaCodigo
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._blnNuevo = Me._NuevoRegistro
                    ._blnBotonCargar = True
                    ._TipoDocJudicialID = EnumRegDocTipo.Traslado
                    ._CondicionGrupo = GrupoID
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End With
            Else
                Dim frm As New Registro.Movimientos.frmMovimientoTraslado
                With frm
                    ._Codigo = -1
                    ._InternoID = Me._InternoID
                    ._IngresoID = Me._IngresoID
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._MovimientoTipoID = Me.GrillaCodigo
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._blnNuevo = Me._NuevoRegistro
                    ._blnBotonCargar = True
                    ._TipoDocJudicialID = EnumRegDocTipo.Traslado
                    ._CondicionGrupo = GrupoID
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End With
            End If
        End Sub
        Private Sub FRM_Conducciones(GrupoID As Integer)
            If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                Dim frm As New Registro.PenalLM.Movimientos.frmMovimientoConducciones
                With frm
                    ._Codigo = -1
                    ._MovID = -1
                    ._InternoID = Me._InternoID
                    ._IngresoID = Me._IngresoID
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._MovimientoTipoID = Me.GrillaCodigo
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._blnNuevo = Me._NuevoRegistro
                    ._CondicionGrupo = GrupoID
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte

                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End With
            Else
                Dim frm As New Registro.Movimientos.frmMovimientoConducciones
                With frm
                    ._Codigo = -1
                    ._MovID = -1
                    ._InternoID = Me._InternoID
                    ._IngresoID = Me._IngresoID
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._MovimientoTipoID = Me.GrillaCodigo
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._blnNuevo = Me._NuevoRegistro
                    ._CondicionGrupo = GrupoID
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End With
            End If
        End Sub
        Private Sub FRM_ConduccionClasificacion(GrupoID As Integer)

            Dim frm As New Registro.Carceleta.Movimientos.frmMovimientoConduccionClasificacion
            With frm
                ._Codigo = -1
                '._MovID = -1
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                '._MovimientoTipoID = Me.GrillaCodigo
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._blnNuevo = Me._NuevoRegistro
                ._CondicionGrupo = GrupoID
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End With

        End Sub
        Private Sub FRM_Libertad()
            Dim frm As New Registro.Movimientos.frmMovimientoLibertad
            With frm

                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._MovimientoTipoID = Me.GrillaCodigo
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._blnNuevo = Me._NuevoRegistro
                ._TipoDocJudicialID = EnumRegDocTipo.Libertad
                ._NroPendientes = Me._NroPendientes
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End With
        End Sub
        Private Sub FRM_LibertadPopup()
            Dim frm As New Registro.PenalLM.Movimientos.frmMovimientoLibertadPLM
            With frm
                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._MovimientoTipoID = Me.GrillaCodigo
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._blnNuevo = Me._NuevoRegistro
                ._TipoDocJudicialID = EnumRegDocTipo.Libertad
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End With
        End Sub

        Private Sub FRM_Fuga(Tipo As Integer)
            Dim frm As New Registro.Movimientos.frmMovimientoFuga
            With frm
                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._MovimientoTipoID = Me.GrillaCodigo
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._blnNuevo = Me._NuevoRegistro
                ._TipoMovimiento = Tipo
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End With
        End Sub
        Private Sub FRM_EgresoTraslado()
            Dim frm As New Registro.Movimientos.frmMovimientoTrasladoHospitalmental
            With frm

                ._Codigo = -1
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._MovimientoTipoID = Me.GrillaCodigo
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._blnNuevo = Me._NuevoRegistro
                '._TipoDocJudicialID = EnumRegDocTipo.e
                ._NroPendientes = Me._NroPendientes
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End With
        End Sub

#End Region
#Region "Otros"
        Private Sub Usuario_Permiso()

            Me.btnOk.Visible = Me._FormEscritura

        End Sub

#End Region

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub
        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            FRM_Movimiento()
        End Sub
        Private Sub frmMovimientoTipoPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Listar()
            Usuario_Permiso()

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            FRM_Movimiento()
        End Sub
    End Class
End Namespace
