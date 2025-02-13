Imports SIPPOPE.Registro.Penal.Busqueda
Imports Type.Enumeracion.Modulo

Namespace Estadistica.v5

    Public Class frmPadinDetalleV2
        Private objBss As Bussines.Estadistica.PadinDetalle = Nothing
        Private objEntColActivos As New Entity.Estadistica.PadinDetalleCol
        Private objEntColIngresos As New Entity.Estadistica.PadinDetalleCol
        Private objEntColEgresos As New Entity.Estadistica.PadinDetalleCol
        Private objEntColPadin As New Entity.Estadistica.PadinDetalleCol
        Private objEntGrillaCol As Entity.Estadistica.PadinDetalleCol
        Private objEntLista As New List(Of Entity.Estadistica.PadinDetalleCol)
#Region "Enum"
        Private Enum enmTipoGrilla As Integer
            PoblacionActica = 1
            Ingresos = 2
            Egresos = 3
            Padin = 4
            'PadinOrdenado = 5
        End Enum
#End Region
#Region "Propiedades_Parametricas"
        Private intLstPadinID As List(Of Integer)
        Private intAnio As Integer = -1
        Private intMes As Integer = -1
        Public Property _IDPadin As Integer = -1
        Public Property _IDRegion As Integer = -1
        Public Property _RegionNombre() As String
            Get
                Return Me.txtRegion.Text
            End Get
            Set(ByVal value As String)
                Me.txtRegion.Text = value.ToUpper
            End Set
        End Property
        Public Property _IDPenal() As Integer = -1

        Public Property _PenalNombre() As String = ""
        Public Property _RegionPenalNombre() As String
            Get
                Return Me.txtRegion.Text
            End Get
            Set(ByVal value As String)
                Me.txtRegion.Text = value.ToUpper
            End Set
        End Property

        Public Property _Anio() As Integer
            Get
                Return intAnio
            End Get
            Set(ByVal value As Integer)
                intAnio = value
            End Set
        End Property
        Public Property _Mes() As Integer
            Get
                Return intMes
            End Get
            Set(ByVal value As Integer)
                intMes = value
            End Set
        End Property
        Public Property _MesNombre() As String = ""
        Public Property _FechaInicio As Long = 0
        Public Property _FechaFin As Long = 0
        Public Property _FechaCorte As Long = 0
        Public Property _FechaProcesamiento As Long = 0
        Public Property _Correlativo As Integer = 0
        Public Property _Version As Integer = -1
        Public Property _VersionReporte As Integer = -1
        Public Property _EstadoNombre As String = ""
        Public ReadOnly Property _FechaFinString() As String
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me._FechaFin, True)
            End Get
        End Property
        Public ReadOnly Property _FechaProcesamientoString() As String
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me._FechaProcesamiento, True)
            End Get
        End Property
        Public Property _PadinEstadoColor As System.Drawing.Color
#End Region
#Region "Propiedades_Busqueda"
        Private Property CodigoInterno() As String
            Get
                Return Me.txtCodInterno.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtCodInterno.Text = value
            End Set
        End Property
        Private Property ApellidosyNombresyAsociados() As String
            Get
                Return Me.txtApeNombres.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApeNombres.Text = value
            End Set
        End Property
        Private ReadOnly Property SituacionJuridica() As Integer
            Get
                Dim intValor As Integer = -1
                If cbbSitJuridica.SelectedIndex > 0 Then
                    intValor = cbbSitJuridica.SelectedIndex
                End If
                Return intValor
            End Get
        End Property
        Private Property VerObservados As Boolean
            Get
                Return Me.chkRegistrosObservados.Checked
            End Get
            Set(value As Boolean)
                Me.chkRegistrosObservados.Checked = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaIDInterno(TipoGrilla As enmTipoGrilla) As Integer
            Get
                Dim value As Integer = -1

                Try

                    Select Case TipoGrilla

                        Case enmTipoGrilla.PoblacionActica

                            'With Me.dgwGrillaPoblacionActiva
                            '    value = .SelectedRows(0).Cells("col_act_int_id").Value
                            'End With

                        Case enmTipoGrilla.Ingresos

                            With Me.dgwGrillaIngresos
                                value = .SelectedRows(0).Cells("col_ing_int_id").Value
                            End With

                        Case enmTipoGrilla.Egresos

                            With Me.dgwGrillaEgresos
                                value = .SelectedRows(0).Cells("col_egr_int_id").Value
                            End With

                        Case enmTipoGrilla.Padin ', enmTipoGrilla.PadinOrdenado

                            'If Me.chkPadinOrdenado.Checked = True Then
                            With Me.dgwGrilla
                                value = .SelectedRows(0).Cells("col_pad_int_id").Value
                            End With
                            'Else
                            '    With Me.dgwGrillaPadin
                            '        value = .SelectedRows(0).Cells("col_pad_int_id1").Value
                            '    End With
                            'End If

                    End Select

                Catch ex As Exception

                End Try

                Return value

            End Get
        End Property

        Private ReadOnly Property GrillaObservacion(TipoGrilla As enmTipoGrilla) As String
            Get
                Dim value As String = ""
                Try
                    Select Case TipoGrilla
                        Case enmTipoGrilla.PoblacionActica

                            'With Me.dgwGrillaPoblacionActiva
                            '    value = .SelectedRows(0).Cells("col_obs_regLA").Value
                            'End With

                        Case enmTipoGrilla.Ingresos

                            With Me.dgwGrillaIngresos
                                value = .SelectedRows(0).Cells("col_obs_regLI").Value
                            End With

                        Case enmTipoGrilla.Egresos

                            With Me.dgwGrillaEgresos
                                value = .SelectedRows(0).Cells("col_obs_regLE").Value
                            End With

                        Case enmTipoGrilla.Padin

                            With Me.dgwGrilla
                                value = .SelectedRows(0).Cells("col_obs_reg").Value
                            End With

                    End Select

                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Combo"
        Private blnComboSitJur As Boolean = False
        Private Sub ComboSituacionJuridica()
            blnComboSitJur = False
            cbbSitJuridica.Items.Add("[TODOS]")
            cbbSitJuridica.Items.Add("PROCESADO")
            cbbSitJuridica.Items.Add("SENTENCIADO")
            cbbSitJuridica.Items.Add("PROC - SENT")
            cbbSitJuridica.SelectedIndex = 0
            blnComboSitJur = True
        End Sub
#End Region
#Region "Listar"
        Private Sub Listar()
            Me.Cursor = Cursors.WaitCursor
            Me.Refresh()
            Me.SuspendLayout()

            ListarPadin_v2()
            ListarEgresos()
            ListarIngresos()

            'CountObsActivos = ContarObservados(objEntColActivos)
            CountObsIngresos = ContarObservados(objEntColIngresos)
            CountObsEgresos = ContarObservados(objEntColEgresos)
            CountObsPadin = ContarObservados(objEntColPadin)

            'contar los internos agrupados
            CountIngresosInternosAgrup = ContarInternosAgrupados(objEntColIngresos)
            CountEgresosInternosAgrup = ContarInternosAgrupados(objEntColEgresos)
            CountPadinInternosAgrup = ContarInternosAgrupados(objEntColPadin)

            'contar situacion jurididca
            ContarSituacionJuridica()

            GrillaPintarIngresosNuevos()

            ContadoresGrilla(enmTipoGrilla.Ingresos)

            Me.Cursor = Cursors.Default
            Me.ResumeLayout()

        End Sub
        Private Sub ListarPoblacionActiva()

            If objEntColActivos.Count = 0 Then

                objEntGrillaCol = New Entity.Estadistica.PadinDetalleCol
                objBss = New Bussines.Estadistica.PadinDetalle
                Dim objEntFiltro As New Entity.Estadistica.PadinDetalle
                With objEntFiltro
                    .PadinID = Me._IDPadin
                    .RegionID = Me._IDRegion
                    .PenalID = Me._IDPenal
                    .PadinDetalleVisible = 1
                    .PadinTipoMovimiento = -1
                End With

                objEntColActivos = objBss.ListarPoblacionActiva_v2(objEntFiltro)

            End If

            objEntGrillaCol = ListarFiltro(objEntColActivos)

            'With Me.dgwGrillaPoblacionActiva
            '    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            '    .AllowUserToResizeRows = False
            '    .AutoGenerateColumns = False
            '    .DataSource = objEntGrillaCol
            '    .CurrentCell = Nothing
            '    .RowsDefaultCellStyle.BackColor = Color.White
            '    Me.lblFiltro.Text = "Reg. filtrados : " & .RowCount
            'End With

        End Sub

        Private Sub ListarIngresos()
            objBss = New Bussines.Estadistica.PadinDetalle
            If objEntLista.Count = 0 Then
                objEntColIngresos = New Entity.Estadistica.PadinDetalleCol
                objEntColEgresos = New Entity.Estadistica.PadinDetalleCol

                Dim objFiltro As New Entity.Estadistica.PadinDetalle
                With objFiltro
                    .PadinID = Me._IDPadin
                End With
                objEntLista = objBss.ListarIngresoEgreso(objFiltro)

                objEntColIngresos = objEntLista.Item(0)
                objEntColEgresos = objEntLista.Item(1)

            End If
            objEntColIngresos = objBss.ListarObservacionPadin(objEntColIngresos)
            objEntGrillaCol = New Entity.Estadistica.PadinDetalleCol
            objEntGrillaCol = ListarFiltro(objEntColIngresos)

            With Me.dgwGrillaIngresos
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntGrillaCol
                .CurrentCell = Nothing
                Me.lblFiltro.Text = "Reg. filtrados : " & .RowCount
            End With
        End Sub

        Private Sub ListarEgresos()

            If objEntLista.Count = 0 Then
                objEntColIngresos = New Entity.Estadistica.PadinDetalleCol
                objEntColEgresos = New Entity.Estadistica.PadinDetalleCol

                Dim objFiltro As New Entity.Estadistica.PadinDetalle
                With objFiltro
                    .PadinID = Me._IDPadin
                End With
                objEntLista = objBss.ListarIngresoEgreso(objFiltro)

                objEntColIngresos = objEntLista.Item(0)
                objEntColEgresos = objEntLista.Item(1)

            End If
            objEntColEgresos = objBss.ListarObservacionPadin(objEntColEgresos)
            objEntGrillaCol = New Entity.Estadistica.PadinDetalleCol

            objEntGrillaCol = ListarFiltro(objEntColEgresos)

            With Me.dgwGrillaEgresos
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntGrillaCol
                .CurrentCell = Nothing
                Me.lblFiltro.Text = "Reg. filtrados : " & .RowCount
            End With

        End Sub
        Private blnCargoDataPadin As Boolean = False

        Private Sub ListarPadin_v2()

            Dim objEntFiltro As New Entity.Estadistica.PadinDetalle
            If objEntColActivos.Count = 0 Then

                objEntGrillaCol = New Entity.Estadistica.PadinDetalleCol
                objBss = New Bussines.Estadistica.PadinDetalle

                With objEntFiltro
                    .PadinID = Me._IDPadin
                    .RegionID = Me._IDRegion
                    .PenalID = Me._IDPenal
                    .PadinDetalleVisible = 1
                    .PadinTipoMovimiento = -1
                End With

                objEntColActivos = objBss.ListarPoblacionActiva_v2(objEntFiltro)

            End If

            If blnCargoDataPadin = False Then

                'Paso 03 , recorrer los registros de la poblacion activa y comparar con ingreso y egresos

                'sacar copia del coleccion de poblacion activa 
                Dim objEntColTempPoblacionActiva As New Entity.Estadistica.PadinDetalleCol
                Dim objEntTempPoblacionActiva As Entity.Estadistica.PadinDetalle

                For Each obj As Entity.Estadistica.PadinDetalle In objEntColActivos

                    objEntTempPoblacionActiva = New Entity.Estadistica.PadinDetalle
                    objEntTempPoblacionActiva = obj.CloneCol
                    objEntColTempPoblacionActiva.Add(objEntTempPoblacionActiva)
                Next

                Dim objEntColTotAux As New Entity.Estadistica.PadinDetalleCol

                For Each obj As Entity.Estadistica.PadinDetalle In objEntColTempPoblacionActiva

                    Dim blnEncontro As Boolean = False

                    For Each obj2 As Entity.Estadistica.PadinDetalle In objEntColPadin
                        If obj.InternoID = obj2.InternoID Then
                            blnEncontro = True
                            Exit For
                        End If
                    Next

                    If blnEncontro = False Then
                        objEntColTotAux.Add(obj) 'insertando filas  a padin
                    End If
                Next

                For Each obj As Entity.Estadistica.PadinDetalle In objEntColTotAux
                    objEntColPadin.Add(obj)
                Next

                'Ponemos color para la segunda grilla padin ordenado
                Dim InternoID As Integer = -1
                For Each obj As Entity.Estadistica.PadinDetalle In objEntColPadin

                    Dim intConta As Integer = 0
                    InternoID = obj.InternoID

                    For Each obj2 As Entity.Estadistica.PadinDetalle In objEntColPadin
                        If InternoID = obj2.InternoID And obj2.InternoCondicionColor = -1 Then
                            obj2.InternoColorPadin = obj.InternoColor
                            obj2.InternoCondicionColor = 1
                            intConta += 1
                        End If
                    Next

                    If intConta > 1 And obj.InternoColor = Color.White Then
                        obj.InternoColorPadin = objBss.ObtenerColor()
                        For Each obj2 As Entity.Estadistica.PadinDetalle In objEntColPadin
                            If obj.InternoID = obj2.InternoID Then
                                obj2.InternoColorPadin = obj.InternoColorPadin
                            End If
                        Next
                    End If
                Next

                objEntGrillaCol = New Entity.Estadistica.PadinDetalleCol

                objEntColPadin = objBss.ListarObservacionPadin(objEntColPadin)

                blnCargoDataPadin = True

            End If

            objEntGrillaCol = ListarFiltro(objEntColPadin) 'filtarr x los campos del padin detalle

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntGrillaCol
                .CurrentCell = Nothing
                Me.lblFiltro.Text = "Reg. filtrados : " & .RowCount
            End With

        End Sub

        Private Function ListarFiltro(objEntCol As Entity.Estadistica.PadinDetalleCol) As Entity.Estadistica.PadinDetalleCol

            Dim Value As New Entity.Estadistica.PadinDetalleCol
            If Me.CodigoInterno.Length < 1 And Me.ApellidosyNombresyAsociados.Length < 1 And Me.SituacionJuridica = -1 And VerObservados = False Then
                Return objEntCol
            End If
            For Each obj As Entity.Estadistica.PadinDetalle In objEntCol
                'Filtra por codigo de interno
                If obj.EgresoFecha > 0 Then
                    obj.InternoEstadoID = 0
                End If
                If (Me.CodigoInterno = obj.InternoCodigo) Or Me.CodigoInterno.Length < 1 Then
                    If (obj.InternoApellidosyNombresAsociados.Contains(Me.ApellidosyNombresyAsociados.ToUpper) = True Or Me.ApellidosyNombresyAsociados.Length < 1) And
                    (Me.SituacionJuridica = obj.IngresoSituacionJuridicaID Or Me.SituacionJuridica = -1) Then

                        If Me.VerObservados = True Then
                            If obj.ObservacionRegistro.Length > 1 Then
                                Value.Add(obj)
                            End If
                        Else
                            Value.Add(obj)
                        End If

                    End If

                End If

            Next

            Return Value
        End Function

        Private intListaCruce As Integer = 0
#End Region
#Region "Grilla_Contadores"
        Private Property CountInternoNuevos As Integer = 0

        Private Property CountObsActivos As Integer = 0
        Private Property CountObsIngresos As Integer = 0
        Private Property CountObsEgresos As Integer = 0
        Private Property CountObsPadin As Integer = 0

        Private Property CountIngresosInternosAgrup As Integer = 0
        Private Property CountEgresosInternosAgrup As Integer = 0
        Private Property CountPadinInternosAgrup As Integer = 0

        Private ListaDetalleAct As New List(Of Integer)
        Private ListaDetalleIng As New List(Of Integer)
        Private ListaDetalleEgr As New List(Of Integer)
        Private ListaDetallePad As New List(Of Integer)

        Private Function ContarInternosAgrupados(objEntCol As Entity.Estadistica.PadinDetalleCol) As Integer

            Dim value As Integer = 0
            Dim intIDinterno As Integer = -1

            For Each ent As Entity.Estadistica.PadinDetalle In objEntCol
                If ent.InternoID <> intIDinterno Then
                    intIDinterno = ent.InternoID
                    value += 1
                End If
            Next

            Return value

        End Function
        Private Function ContarObservados(objEntCol As Entity.Estadistica.PadinDetalleCol) As Integer

            Dim value As Integer = 0
            For Each obj As Entity.Estadistica.PadinDetalle In objEntCol
                If obj.ObservacionRegistro <> "" Then
                    value += 1
                End If
            Next

            Return value

        End Function
        Private Function ContarSituacionJuridica(objEntCol As Entity.Estadistica.PadinDetalleCol, Sexo As String,
                                                 SituacionJuridica As Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica) As Integer

            Dim value As Integer = 0

            For Each ent As Entity.Estadistica.PadinDetalle In objEntCol

                If ent.InternoSexo = Sexo Then

                    If SituacionJuridica = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Ninguno Then
                        value += 1
                    Else
                        If ent.IngresoSituacionJuridicaID = SituacionJuridica Then
                            value += 1
                        End If
                    End If

                End If

            Next

            Return value

        End Function
        Private Sub ContarSituacionJuridica()

            Dim intContador As Integer = 0

            With dgwSituacionJuridica
                .RowCount = 1

                .Rows(0).Cells(0).Style.BackColor = Color.FromArgb(0, 255, 255)
                .Rows(0).Cells(1).Style.BackColor = Color.FromArgb(0, 255, 255)
                .Rows(0).Cells(2).Style.BackColor = Color.FromArgb(0, 255, 255)

                '''''''''''''
                .Rows(0).Cells(3).Style.BackColor = Color.FromArgb(254, 221, 158)
                .Rows(0).Cells(4).Style.BackColor = Color.FromArgb(254, 221, 158)
                .Rows(0).Cells(5).Style.BackColor = Color.FromArgb(254, 221, 158)
                '''''''''''''
                .Rows(0).Cells(6).Style.BackColor = Color.FromArgb(255, 105, 180)
                .Rows(0).Cells(7).Style.BackColor = Color.FromArgb(255, 105, 180)
                .Rows(0).Cells(8).Style.BackColor = Color.FromArgb(255, 105, 180)
                '''''''''''''
                .Rows(0).Cells(9).Style.BackColor = Color.Gold
                .Rows(0).Cells(10).Style.BackColor = Color.Gold
                .Rows(0).Cells(11).Style.BackColor = Color.Gold
                '''''''''''''
                .Rows(0).Cells(12).Style.BackColor = Color.FromArgb(207, 148, 149)
                .Rows(0).Cells(13).Style.BackColor = Color.FromArgb(207, 148, 149)

            End With

            '/*grilla poblacion activo*/
            '/*total general*/
            'ListaDetalleAct.Add(ContarSituacionJuridica(objEntColActivos, "M", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Ninguno))
            'ListaDetalleAct.Add(ContarSituacionJuridica(objEntColActivos, "F", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Ninguno))
            'ListaDetalleAct.Add(ListaDetalleAct.Item(0) + ListaDetalleAct.Item(1))

            '/*grilla ingresos*/
            'total general 
            ListaDetalleIng.Add(ContarSituacionJuridica(objEntColIngresos, "M", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Ninguno))
            ListaDetalleIng.Add(ContarSituacionJuridica(objEntColIngresos, "F", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Ninguno))
            ListaDetalleIng.Add(ListaDetalleIng.Item(0) + ListaDetalleIng.Item(1))
            'total procesados 
            ListaDetalleIng.Add(ContarSituacionJuridica(objEntColIngresos, "M", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado))
            ListaDetalleIng.Add(ContarSituacionJuridica(objEntColIngresos, "F", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado))
            ListaDetalleIng.Add(ListaDetalleIng.Item(3) + ListaDetalleIng.Item(4))
            'total sentenciado
            ListaDetalleIng.Add(ContarSituacionJuridica(objEntColIngresos, "M", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado))
            ListaDetalleIng.Add(ContarSituacionJuridica(objEntColIngresos, "F", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado))
            ListaDetalleIng.Add(ListaDetalleIng.Item(6) + ListaDetalleIng.Item(7))
            'total mixto
            ListaDetalleIng.Add(ContarSituacionJuridica(objEntColIngresos, "M", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado_Sentenciado))
            ListaDetalleIng.Add(ContarSituacionJuridica(objEntColIngresos, "F", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado_Sentenciado))
            ListaDetalleIng.Add(ListaDetalleIng.Item(9) + ListaDetalleIng.Item(10))
            'sin situacion juridica
            ListaDetalleIng.Add(ContarSituacionJuridica(objEntColIngresos, "M", -1))
            ListaDetalleIng.Add(ContarSituacionJuridica(objEntColIngresos, "F", -1))

            '/*grilla egresos*/
            'total general 
            ListaDetalleEgr.Add(ContarSituacionJuridica(objEntColEgresos, "M", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Ninguno))
            ListaDetalleEgr.Add(ContarSituacionJuridica(objEntColEgresos, "F", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Ninguno))
            ListaDetalleEgr.Add(ListaDetalleEgr.Item(0) + ListaDetalleEgr.Item(1))
            'total procesados 
            ListaDetalleEgr.Add(ContarSituacionJuridica(objEntColEgresos, "M", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado))
            ListaDetalleEgr.Add(ContarSituacionJuridica(objEntColEgresos, "F", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado))
            ListaDetalleEgr.Add(ListaDetalleEgr.Item(3) + ListaDetalleEgr.Item(4))
            'total sentenciado
            ListaDetalleEgr.Add(ContarSituacionJuridica(objEntColEgresos, "M", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado))
            ListaDetalleEgr.Add(ContarSituacionJuridica(objEntColEgresos, "F", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado))
            ListaDetalleEgr.Add(ListaDetalleEgr.Item(6) + ListaDetalleEgr.Item(7))
            'total mixto
            ListaDetalleEgr.Add(ContarSituacionJuridica(objEntColEgresos, "M", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado_Sentenciado))
            ListaDetalleEgr.Add(ContarSituacionJuridica(objEntColEgresos, "F", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado_Sentenciado))
            ListaDetalleEgr.Add(ListaDetalleEgr.Item(9) + ListaDetalleEgr.Item(10))
            'sin situacion juridica
            ListaDetalleEgr.Add(ContarSituacionJuridica(objEntColEgresos, "M", -1))
            ListaDetalleEgr.Add(ContarSituacionJuridica(objEntColEgresos, "F", -1))

            '/*grilla padin*/
            'total general 
            ListaDetallePad.Add(ContarSituacionJuridica(objEntColPadin, "M", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Ninguno))
            ListaDetallePad.Add(ContarSituacionJuridica(objEntColPadin, "F", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Ninguno))
            ListaDetallePad.Add(ListaDetallePad.Item(0) + ListaDetallePad.Item(1))
            'total procesados 
            ListaDetallePad.Add(ContarSituacionJuridica(objEntColPadin, "M", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado))
            ListaDetallePad.Add(ContarSituacionJuridica(objEntColPadin, "F", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado))
            ListaDetallePad.Add(ListaDetallePad.Item(3) + ListaDetallePad.Item(4))
            'total sentenciado
            ListaDetallePad.Add(ContarSituacionJuridica(objEntColPadin, "M", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado))
            ListaDetallePad.Add(ContarSituacionJuridica(objEntColPadin, "F", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado))
            ListaDetallePad.Add(ListaDetallePad.Item(6) + ListaDetallePad.Item(7))
            'total mixto
            ListaDetallePad.Add(ContarSituacionJuridica(objEntColPadin, "M", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado_Sentenciado))
            ListaDetallePad.Add(ContarSituacionJuridica(objEntColPadin, "F", Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado_Sentenciado))
            ListaDetallePad.Add(ListaDetallePad.Item(9) + ListaDetallePad.Item(10))
            'sin situacion juridica
            ListaDetallePad.Add(ContarSituacionJuridica(objEntColPadin, "M", -1))
            ListaDetallePad.Add(ContarSituacionJuridica(objEntColPadin, "F", -1))

        End Sub
        Private Sub ContadoresGrillaSitJur(TipoGrilla As enmTipoGrilla)

            Dim intAnchoColumna As Integer = 640
            Dim blnOcultarSitJur As Boolean = True
            Dim blnMostrarSinSitJur As Boolean = False


            With dgwSituacionJuridica

                Select Case TipoGrilla
                    'Case enmTipoGrilla.PoblacionActica

                    '    .Item("col_totalH", 0).Value = ListaDetalleAct(0)
                    '    .Item("col_totalM", 0).Value = ListaDetalleAct(1)
                    '    .Item("col_total", 0).Value = ListaDetalleAct(2)

                    '    intAnchoColumna = 135
                    '    blnOcultarSitJur = False
                    Case enmTipoGrilla.Ingresos

                        .Item("col_totalH", 0).Value = ListaDetalleIng(0)
                        .Item("col_totalM", 0).Value = ListaDetalleIng(1)
                        .Item("col_total", 0).Value = ListaDetalleIng(2)

                        .Item("col_totalPH", 0).Value = ListaDetalleIng(3)
                        .Item("col_totalPM", 0).Value = ListaDetalleIng(4)
                        .Item("col_totalP", 0).Value = ListaDetalleIng(5)

                        .Item("col_totalSH", 0).Value = ListaDetalleIng(6)
                        .Item("col_totalSM", 0).Value = ListaDetalleIng(7)
                        .Item("col_totalS", 0).Value = ListaDetalleIng(8)

                        .Item("col_totalSPH", 0).Value = ListaDetalleIng(9)
                        .Item("col_totalSPM", 0).Value = ListaDetalleIng(10)
                        .Item("col_totalSP", 0).Value = ListaDetalleIng(11)

                        .Item("col_hom_sin_sit_jur", 0).Value = ListaDetalleIng(12)
                        .Item("col_muj_sin_sit_jur", 0).Value = ListaDetalleIng(13)

                        If ListaDetalleIng(12) > 0 Or ListaDetalleIng(13) > 0 Then
                            blnMostrarSinSitJur = True
                        Else
                            intAnchoColumna = intAnchoColumna - (45 * 2)
                        End If

                    Case enmTipoGrilla.Egresos

                        .Item("col_totalH", 0).Value = ListaDetalleEgr(0)
                        .Item("col_totalM", 0).Value = ListaDetalleEgr(1)
                        .Item("col_total", 0).Value = ListaDetalleEgr(2)

                        .Item("col_totalPH", 0).Value = ListaDetalleEgr(3)
                        .Item("col_totalPM", 0).Value = ListaDetalleEgr(4)
                        .Item("col_totalP", 0).Value = ListaDetalleEgr(5)

                        .Item("col_totalSH", 0).Value = ListaDetalleEgr(6)
                        .Item("col_totalSM", 0).Value = ListaDetalleEgr(7)
                        .Item("col_totalS", 0).Value = ListaDetalleEgr(8)

                        .Item("col_totalSP", 0).Value = ListaDetalleEgr(9)
                        .Item("col_totalSPH", 0).Value = ListaDetalleEgr(10)
                        .Item("col_totalSPM", 0).Value = ListaDetalleEgr(11)

                        .Item("col_hom_sin_sit_jur", 0).Value = ListaDetalleEgr(12)
                        .Item("col_muj_sin_sit_jur", 0).Value = ListaDetalleEgr(13)

                        If ListaDetalleEgr(12) > 0 Or ListaDetalleEgr(13) > 0 Then
                            blnMostrarSinSitJur = True
                        Else
                            intAnchoColumna = intAnchoColumna - (45 * 2)
                        End If

                    Case enmTipoGrilla.Padin ', enmTipoGrilla.PadinOrdenado

                        .Item("col_totalH", 0).Value = ListaDetallePad(0)
                        .Item("col_totalM", 0).Value = ListaDetallePad(1)
                        .Item("col_total", 0).Value = ListaDetallePad(2)

                        .Item("col_totalPH", 0).Value = ListaDetallePad(3)
                        .Item("col_totalPM", 0).Value = ListaDetallePad(4)
                        .Item("col_totalP", 0).Value = ListaDetallePad(5)

                        .Item("col_totalSH", 0).Value = ListaDetallePad(6)
                        .Item("col_totalSM", 0).Value = ListaDetallePad(7)
                        .Item("col_totalS", 0).Value = ListaDetallePad(8)

                        .Item("col_totalSPH", 0).Value = ListaDetallePad(9)
                        .Item("col_totalSPM", 0).Value = ListaDetallePad(10)
                        .Item("col_totalSP", 0).Value = ListaDetallePad(11)

                        .Item("col_hom_sin_sit_jur", 0).Value = ListaDetallePad(12)
                        .Item("col_muj_sin_sit_jur", 0).Value = ListaDetallePad(13)


                        If ListaDetallePad(12) > 0 Or ListaDetallePad(13) > 0 Then
                            blnMostrarSinSitJur = True
                        Else
                            intAnchoColumna = intAnchoColumna - (45 * 2)
                        End If

                End Select

            End With

            Me.pnlSituacionJurid.Size = New Size(intAnchoColumna, 65)

            For Each columna As DataGridViewColumn In dgwSituacionJuridica.Columns

                Select Case columna.Index
                    Case 0, 1, 2
                        columna.Visible = True
                    Case 9, 10, 11
                        If Me._VersionReporte = 3 Then
                            columna.Visible = False
                        Else
                            columna.Visible = True
                        End If
                    Case 12, 13
                        columna.Visible = blnMostrarSinSitJur
                    Case Else
                        columna.Visible = blnOcultarSitJur
                End Select

            Next

            For Each columna As DataGridViewColumn In dgvDetallecabecera.Columns

                Select Case columna.Index
                    Case 0
                        columna.Visible = True
                    Case 3 'mixto
                        If Me._VersionReporte = 3 Then
                            columna.Visible = False
                        Else
                            columna.Visible = True
                        End If
                    Case 4
                        columna.Visible = blnMostrarSinSitJur
                    Case Else
                        columna.Visible = blnOcultarSitJur
                End Select

            Next

            With dgwSituacionJuridica
                .Refresh()
                .ScrollBars = ScrollBars.None
            End With

            With dgvDetallecabecera
                .Refresh()
                .ScrollBars = ScrollBars.None
            End With

        End Sub
        Private Sub ContadoresGrilla(TipoGrilla As enmTipoGrilla)

            Dim strCount As String = ""

            Select Case TipoGrilla

                Case enmTipoGrilla.Ingresos

                    strCount = "Tot. de internos : " & CountIngresosInternosAgrup & " / "

                Case enmTipoGrilla.Egresos

                    strCount = "Tot. de internos : " & CountEgresosInternosAgrup & " / "

                Case enmTipoGrilla.Padin ', enmTipoGrilla.PadinOrdenado

                    strCount = "Tot. de internos : " & CountPadinInternosAgrup & " / "
            End Select

            Me.lblReg.Text = strCount & "Reg. con obs. Activos : " & CountObsActivos & " / Reg. con obs. Padin : " & IIf(TipoGrilla = enmTipoGrilla.Padin, CountObsPadin, 0)

            ContadoresGrillaSitJur(TipoGrilla)

        End Sub
#End Region
#Region "Otros"
        Private Sub GrillaPintarIngresosNuevos()

            If objEntColActivos.Count = 0 Then Exit Sub
            Dim fecha As Date = "01/" & CDate(objEntColActivos.PadinDetalle(0).FechaCorteString).Month & "/" & objEntColActivos.PadinDetalle(0).Anio

            If CountInternoNuevos = 0 Then
                For Each ent As Entity.Estadistica.PadinDetalle In objEntColActivos

                    If ent.FechaIngresoPenalString.Length > 0 Then
                        If ent.FechaIngresoPenalString >= fecha Then
                            ent.InternoColorActivo = Color.PaleGreen
                            CountInternoNuevos += 1
                        End If
                    End If
                Next

            End If

        End Sub

        Private Sub GrillaFormato()

            'With dgwGrillaPoblacionActiva
            '    .Columns("col_ult_ing_isp").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '    .Columns("col_fec_ult_ing_pen").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            '    .Columns("col_nro_ing").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            '    .Columns("col_sit_jur").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '    .Columns("col_sex").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '    .Columns("col_pad_det_fec_nac").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '    .Columns("col_pad_det_eda").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            '    .Columns("col_img_obs_regLA").Frozen = True
            '    .Columns("col_pad_det_ape_nom").Frozen = True

            '    .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'End With

            With dgwGrillaIngresos
                .Columns("col_sexo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("col_ing_fec_nac").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("col_ing_eda").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("col_ing_fec_isp").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("col_ing_ult_pen").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns("col_ing_nro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns("col_ing_sit_jur").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns("col_img_obs_regLI").Frozen = True
                '.Columns("col_pad_det_ape_nom_ing").Frozen = True

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With


            With Me.dgwGrillaEgresos
                .Columns("col_img_obs_regLE").Frozen = True
                '.Columns("col_pad_det_ape_nom_egr").Frozen = True

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            Me.dgwGrilla.Columns("col_img_obs_reg").Frozen = True
            'Me.dgwGrillaPadin.Columns("col_pad_img_obs_reg").Frozen = True

            With Me.dgwSituacionJuridica
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                .Columns("col_hom_sin_sit_jur").DefaultCellStyle.BackColor = Color.Red
            End With

        End Sub

        Private Sub ValoresxDefault()

            'Me.dgwGrillaPoblacionActiva.VisibleCampos = True
            Me.dgwGrillaIngresos.VisibleCampos = True
            Me.dgwGrillaEgresos.VisibleCampos = True
            Me.dgwGrilla.VisibleCampos = True

            ComboSituacionJuridica()

            GrillaFormato()
            GrillaCampos()

            UsuarioPermisos()

            Me._RegionPenalNombre = Me._RegionNombre & " / " & Me._PenalNombre

            Me.txtCabeceraPadindetalle.Text = "Nº " & Me._Correlativo & " - " & Me._Anio & "  " & Me._MesNombre & " -  FEC. DE CORTE " & Me._FechaFinString & " - FEC. DE PROCESAMIENTO " & Me._FechaProcesamientoString
            Me.txtEstado.Text = Me._EstadoNombre
            Me.txtEstado.BackColor = Me._PadinEstadoColor

        End Sub

        Private Sub GrillaCampos()

            'grilla poblaciona activa
            'Me.col_img_obs_regLA.Tag = "image"
            'Me.col_ult_ing_isp.Tag = "fecha"
            'Me.col_fec_ult_ing_pen.Tag = "fecha"
            'Me.col_pad_det_fec_nac.Tag = "fecha"

            'grilla ingresos            
            Me.col_ing_fec_isp.Tag = "fecha"
            Me.col_ing_ult_pen.Tag = "fecha"
            Me.col_ing_fec_nac.Tag = "fecha"

            'grilla egresos            
            Me.col_ing_isp.Tag = "fecha"
            Me.col_ult_ing_pen.Tag = "fecha"
            Me.col_fec_nac_egr.Tag = "fecha"
            Me.col_dgw_egr_fec_egr.Tag = "fecha"

            'grilla padin 
            Me.col_img_obs_reg.Tag = "image"
            Me.col_fec_ing_sis_pen.Tag = "fecha"
            Me.col_fec_ing_pen.Tag = "fecha"
            ' Me.col_fec_sen.Tag = "fecha"
            Me.col_fec_ini.Tag = "fecha"
            Me.col_fec_fin.Tag = "fecha"
            Me.col_fec_nac.Tag = "fecha"
            'Me.col_fec_egr.Tag = "fecha"
            Me.col_fec_cor.Tag = "fecha"

            Me.col_mes_rec.Tag = "numero"
            Me.col_ing_num.Tag = "numero"
            Me.col_eda.Tag = "numero"
            Me.col_num_hij.Tag = "numero"
        End Sub

        Private Sub UsuarioPermisos()
            Me.pnlReporte.Visible = Me._FormReporte
            Me.pnlExportar.Visible = Me._FormReporte
        End Sub

        Private Function ExportarExcelCampos(dgwControl As DataGridView, Campo1 As String, Campo2 As String) As DataGridView
            Dim GrillaControl As New DataGridView
            Dim col As DataGridViewTextBoxColumn

            For Each i As DataGridViewColumn In dgwControl.Columns
                col = New DataGridViewTextBoxColumn
                col.Name = i.Name
                col.HeaderText = i.HeaderText
                col.DataPropertyName = i.DataPropertyName
                col.Visible = i.Visible
                GrillaControl.Columns.Add(col)
            Next
            For i As Integer = 0 To dgwControl.Rows.Count - 1
                If i > 0 Then GrillaControl.Rows.Add()
            Next
            For i As Integer = 0 To dgwControl.ColumnCount.ToString() - 1
                For j As Integer = 0 To dgwControl.Rows.Count - 1
                    If IsNumeric(dgwControl.Item(i, j).Value) Then
                        If CStr((dgwControl.Item(i, j).Value)).Length > 10 Then
                            GrillaControl.Item(i, j).Value = Format(Legolas.Components.FechaHora.FechaDate(dgwControl.Item(i, j).Value, False), "dd/MM/yyyy")
                        Else
                            GrillaControl.Item(i, j).Value = dgwControl.Item(i, j).Value
                        End If
                    Else
                        GrillaControl.Item(i, j).Value = dgwControl.Item(i, j).Value
                    End If

                Next
            Next
            For i As Integer = 0 To GrillaControl.ColumnCount.ToString() - 1
                If GrillaControl.Columns(i).Name = Campo1 Then
                    GrillaControl.Columns(i).Visible = False
                End If
                If GrillaControl.Columns(i).Name = Campo2 Then
                    GrillaControl.Columns(i).Visible = True
                End If
            Next

            Return GrillaControl
        End Function
#End Region
#Region "FORM"
        Private Sub FRM_ReporteF1()
            Dim frm As New APPReporte.Estadistica.frmReporte
            With frm
                ._pReporteTipo = APPReporte.Estadistica.frmReporte.EnmTipoReporte.rptReporte1
                ._PadinID = Me._IDPadin
                ._PenalID = Me._IDPenal
                ._Anio = Me._Anio
                ._Mes = Me._Mes
                ._FechaInicio = Me._FechaInicio
                ._FechaFin = Me._FechaFin
                '._FechaCorte = Me._FechaCorte
                ._Correlativo = Me._Correlativo
                ._VersionReporte = Me._VersionReporte
                .Show()
            End With
        End Sub

        Private Sub FRM_ReporteCuadro14()
            Dim frm As New Estadistica.frmNominalPopup
            With frm
                ._RegionID = Me._IDRegion
                ._RegionNombre = Me._RegionNombre
                ._PenalID = Me._IDPenal
                ._PenalNombre = Me._PenalNombre
                ._PadinID = Me._IDPadin
                ._Anio = Me._Anio
                ._Mes = Me._Mes
                ._FechaFin = Me._FechaFin
                ._Correlativo = Me._Correlativo
                .ShowDialog()
            End With
        End Sub

        Private Sub FRM_ReporteCuadro15()
            Dim frm As New APPReporte.Estadistica.frmReporte
            With frm
                ._pReporteTipo = APPReporte.Estadistica.frmReporte.EnmTipoReporte.rptReporte3
                ._PadinID = Me._IDPadin
                ._PenalID = Me._IDPenal
                ._Anio = Me._Anio
                ._Mes = Me._Mes
                ._FechaFin = Me._FechaFin
                ._Correlativo = Me._Correlativo
                .Show()
            End With
        End Sub

        Private Sub FRM_MensajePadin(Valor As String)

            If Valor.Trim.Length > 5 Then
                Dim frm As New Estadistica.frmPadinDetalleMensajePopup
                frm.strMensaje = Valor
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    btnDetalleInterno.PerformClick()
                End If
            End If

        End Sub

        Private Function FRM_AbrirModalORL(IDInterno As Long, objEntUsuarioModuloCol As Legolas.LEntity.Seguridad.UsuarioModuloCol, objBss As Legolas.LBusiness.Seguridad.UsuarioModulo, intModulo As Short, usuarioPerfil As Short, nivelUsuario As Short, tipoLicencia As Short) As Boolean
            If nivelUsuario = tipoLicencia Then
                Select Case usuarioPerfil
                    Case Type.Enumeracion.Usuario.EnumDependencia.RegistroAntecedentes,
                             Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario
                        intModulo = 33 'ORL
                        Const orlId As Short = 3
                        Const orlRegion As String = "Region Lima"
                        Const orlDescripcion As String = "ORL"
                        '/*abrir el los permisos del usuario*/
                        objEntUsuarioModuloCol = objBss.Listar(Legolas.Configuration.Usuario.Codigo, -1, intModulo)

                        Dim blnLectura As Boolean = False
                        Dim blnEscritura As Boolean = False
                        Dim blnReporte As Boolean = False
                        Dim blnEliminar As Boolean = False
                        Dim blnImpresion As Boolean = False

                        If objEntUsuarioModuloCol IsNot Nothing Then
                            If objEntUsuarioModuloCol.Count = 1 Then
                                blnLectura = objEntUsuarioModuloCol.Item(0).Lectura
                                blnEscritura = objEntUsuarioModuloCol.Item(0).Escritura
                                blnReporte = objEntUsuarioModuloCol.Item(0).Reporte
                                blnImpresion = objEntUsuarioModuloCol.Item(0).Impresion
                                blnEliminar = objEntUsuarioModuloCol.Item(0).Eliminar
                            End If
                        End If
                        '/*******************************************************************
                        Dim frm As New Registro.RegionLima.Busqueda.frmMant_v2(IDInterno, orlId, Me._IDPenal, orlRegion, orlDescripcion)
                        frm.MdiParent = Me.MdiParent
                        With frm
                            'permisos
                            ._FormLectura = blnLectura
                            ._FormEscritura = blnEscritura
                            ._FormReporte = blnReporte
                            ._FormImpresion = blnImpresion
                            ._FormEliminar = blnEliminar
                            .Show()
                        End With
                End Select
                Return False
            Else
                Return True
            End If
        End Function

        Private Sub FRM_InternoDetalle(IDInterno As Long)

            Dim objEntUsuarioModuloCol As New Legolas.LEntity.Seguridad.UsuarioModuloCol
            Dim objBss As New Legolas.LBusiness.Seguridad.UsuarioModulo

            Dim intPenalTipoLicencia As Short = -1
            Dim intModulo As Short = -1

            Dim objBssPenal As New Bussines.General.Penal
            intPenalTipoLicencia = objBssPenal.fnTipoLicencia(_IDPenal)

            Dim usuarioPerfil As Short = Legolas.Configuration.Usuario.OficinaID
            Dim nivelUsuario As Short = Legolas.Configuration.Usuario.NivelUsuario
            Dim tipoLicencia As Short = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana

            If FRM_AbrirModalORL(IDInterno, objEntUsuarioModuloCol, objBss, intModulo, usuarioPerfil, nivelUsuario, tipoLicencia) = False Then
                Exit Sub
            End If

            Select Case intPenalTipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia,
                     Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaProvincia

                    intModulo = 31 'Registro Penal
                    '/*abrir el los permisos del usuario*/
                    objEntUsuarioModuloCol = objBss.Listar(Legolas.Configuration.Usuario.Codigo, -1, intModulo) 'registro penal

                    Dim blnLectura As Boolean = False
                    Dim blnEscritura As Boolean = False
                    Dim blnReporte As Boolean = False
                    Dim blnEliminar As Boolean = False

                    If objEntUsuarioModuloCol IsNot Nothing Then
                        If objEntUsuarioModuloCol.Count = 1 Then
                            blnLectura = objEntUsuarioModuloCol.Item(0).Lectura
                            blnEscritura = objEntUsuarioModuloCol.Item(0).Escritura
                            blnReporte = objEntUsuarioModuloCol.Item(0).Reporte
                            blnEliminar = objEntUsuarioModuloCol.Item(0).Eliminar
                        End If
                    End If
                    '/*******************************************************************
                    'Dim frm As New Registro.Penal.Busqueda.frmMant_v2
                    Dim frm As New Registro.Penal.Busqueda.frmMant_v2(IDInterno, Me._IDRegion, Me._IDPenal, Me._RegionNombre, Me._PenalNombre)
                    frm.MdiParent = Me.MdiParent
                    With frm
                        .idInterno = IDInterno
                        ._FormLectura = blnLectura
                        ._FormEscritura = blnEscritura
                        ._FormReporte = blnReporte
                        ._FormEliminar = blnEliminar
                        .Show()
                    End With

                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana

                    intModulo = 34 'Registro Penal LM
                    '/*abrir el los permisos del usuario*/
                    objEntUsuarioModuloCol = objBss.Listar(Legolas.Configuration.Usuario.Codigo, -1, intModulo) 'registro penal

                    Dim blnLectura As Boolean = False
                    Dim blnEscritura As Boolean = False
                    Dim blnReporte As Boolean = False
                    Dim blnEliminar As Boolean = False

                    If objEntUsuarioModuloCol IsNot Nothing Then
                        If objEntUsuarioModuloCol.Count = 1 Then
                            blnLectura = objEntUsuarioModuloCol.Item(0).Lectura
                            blnEscritura = objEntUsuarioModuloCol.Item(0).Escritura
                            blnReporte = objEntUsuarioModuloCol.Item(0).Reporte
                            blnEliminar = objEntUsuarioModuloCol.Item(0).Eliminar
                        End If
                    End If
                    '/*******************************************************************
                    Dim frm As New Registro.PenalLM.Busqueda.frmMantenimiento
                    frm.MdiParent = Me.MdiParent
                    With frm
                        ._IDInterno = IDInterno
                        ._FormLectura = blnLectura
                        ._FormEscritura = blnEscritura
                        ._FormReporte = blnReporte
                        ._FormEliminar = blnEliminar
                        .Show()
                    End With

            End Select

        End Sub

#End Region
        Private Sub frmBuscar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

            Select Case TabControl1.SelectedIndex
                Case 0

                    Legolas.Components.ExportarGrillaExcel.Exportar(ExportarExcelCampos(Me.dgwGrillaIngresos, "col_img_obs_regLI", ""))

                Case 1

                    Legolas.Components.ExportarGrillaExcel.Exportar(ExportarExcelCampos(Me.dgwGrillaEgresos, "col_img_obs_regLE", ""))
                Case 2

                    Legolas.Components.ExportarGrillaExcel.Exportar(ExportarExcelCampos(Me.dgwGrilla, "col_img_obs_reg", "col_obs_exc"))
            End Select

        End Sub

        Private Sub frmPadinDetalle_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.TabControl1.SelectedIndex = 0
            Listar()
        End Sub

        Private Sub btnReporteF1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteF1.Click

            FRM_ReporteF1()

        End Sub

        Private Sub btnCuadro14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuadro14.Click

            FRM_ReporteCuadro14()

        End Sub

        Private Sub btnCuadro15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuadro15.Click

            FRM_ReporteCuadro15()

        End Sub

        Private Sub txtCodInterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
            Handles txtCodInterno.KeyPress, txtApeNombres.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                tsp_btnBuscar_Click(Nothing, Nothing)
            End If

        End Sub

        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

            Me.chkRegistrosObservados.Checked = False

            Dim blnVerPadinOrd As Boolean = False
            Dim blnVerObs As Boolean = False

            Dim indice As Integer = Me.TabControl1.SelectedIndex

            Select Case indice

                Case 0 'ingresos

                    ListarIngresos()
                    ContadoresGrilla(enmTipoGrilla.Ingresos)

                Case 1 'egresos

                    ListarEgresos()
                    ContadoresGrilla(enmTipoGrilla.Egresos)

                Case 2 'padin

                    ListarPadin_v2()
                    ContadoresGrilla(enmTipoGrilla.Padin)

                    blnVerPadinOrd = True
                    blnVerObs = True

            End Select

            Me.chkRegistrosObservados.Visible = blnVerObs

            Try
                dgwSituacionJuridica.SelectedRows(0).Selected = False
            Catch ex As Exception

            End Try

        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            With Me.dgwGrilla
                If .Columns(e.ColumnIndex).Name = "col_img_obs_reg" And e.RowIndex = -1 Then Exit Sub
                If e.RowIndex = -1 Then
                    Me.Cursor = Cursors.WaitCursor
                    objEntGrillaCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                    .CurrentCell = Nothing
                    Me.Cursor = Cursors.Default
                    .Refresh()
                End If

                If e.RowIndex >= 0 Then
                    If .Columns(e.ColumnIndex).Name = "col_img_obs_reg" Then
                        FRM_MensajePadin(Me.GrillaObservacion(enmTipoGrilla.Padin))
                    End If
                End If
            End With

        End Sub

        Private Sub dgwGrilla_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter
            Me.dgwGrilla.Rows(e.RowIndex).Cells("col_img_obs_reg").Style.SelectionBackColor = dgwGrilla.Item("col_pad_int_column", e.RowIndex).Value
        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_fec_ing_sis_pen").Index,
                    .Columns("col_fec_ing_pen").Index,'.Columns("col_fec_ini").Index,'.Columns("col_fec_sen").Index,'.Columns("col_fec_fin").Index,
                    .Columns("col_fec_nac").Index,
                    .Columns("col_fec_cor").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                        Else
                            e.Value = ""
                        End If

                End Select
            End With

        End Sub


        Private Sub dgwGrillaPoblacionActiva_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)

            'With Me.dgwGrillaPoblacionActiva
            '    Select Case e.ColumnIndex
            '        Case .Columns("col_pad_det_fec_nac").Index, .Columns("col_ult_ing_isp").Index, .Columns("col_fec_ult_ing_pen").Index
            '            If IsNumeric(e.Value) And e.Value > 1 Then
            '                e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
            '            Else
            '                e.Value = ""
            '            End If
            '    End Select
            'End With

        End Sub

        Private Sub dgwGrillaIngresos_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaIngresos.CellClick
            With Me.dgwGrillaIngresos
                If .Columns(e.ColumnIndex).Name = "col_img_obs_regLI" And e.RowIndex = -1 Then Exit Sub
                If e.RowIndex = -1 Then
                    Me.Cursor = Cursors.WaitCursor
                    objEntGrillaCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                    .CurrentCell = Nothing
                    Me.Cursor = Cursors.Default
                    .Refresh()
                End If

                If e.RowIndex >= 0 Then
                    If .Columns(e.ColumnIndex).Name = "col_img_obs_regLI" Then
                        FRM_MensajePadin(Me.GrillaObservacion(enmTipoGrilla.Ingresos))
                    End If
                End If
            End With
        End Sub

        Private Sub dgwGrillaEgresos_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaEgresos.CellClick

            With Me.dgwGrillaEgresos
                If .Columns(e.ColumnIndex).Name = "col_img_obs_regLE" And e.RowIndex = -1 Then Exit Sub
                If e.RowIndex = -1 Then
                    Me.Cursor = Cursors.WaitCursor
                    objEntGrillaCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                    .CurrentCell = Nothing
                    Me.Cursor = Cursors.Default
                    .Refresh()
                End If

                If e.RowIndex >= 0 Then
                    If .Columns(e.ColumnIndex).Name = "col_img_obs_regLE" Then
                        FRM_MensajePadin(Me.GrillaObservacion(enmTipoGrilla.Egresos))
                    End If
                End If
            End With

        End Sub


        Private Sub txtApeNombres_Validated(sender As Object, e As System.EventArgs) Handles txtApeNombres.Validated
            tsbBuscar.PerformClick()
        End Sub

        Private Sub ckbRegistrosObservados_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkRegistrosObservados.CheckedChanged
            tsp_btnBuscar_Click(Nothing, Nothing)
        End Sub

        Private Sub cbbSitJuridica_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbSitJuridica.SelectedIndexChanged
            If blnComboSitJur = True Then tsp_btnBuscar_Click(Nothing, Nothing)
        End Sub

        Private Sub dgwGrillaIngresos_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgwGrillaIngresos.CellPainting

            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub
            If dgwGrillaIngresos.Columns(e.ColumnIndex).Name = "col_img_obs_regLI" Then
                e.CellStyle.BackColor = dgwGrillaIngresos.Item("col_ing_int_col", e.RowIndex).Value
            End If

        End Sub


        Private Sub dgwGrillaPoblacionActiva_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs)
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub
            'If dgwGrillaPoblacionActiva.Columns(e.ColumnIndex).Name = "col_img_obs_regLA" Then
            '    e.CellStyle.BackColor = dgwGrillaPoblacionActiva.Item("col_act_int_col", e.RowIndex).Value
            'End If

        End Sub

        Private Sub dgwGrillaEgresos_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgwGrillaEgresos.CellPainting
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub
            If dgwGrillaEgresos.Columns(e.ColumnIndex).Name = "col_img_obs_regLE" Then
                e.CellStyle.BackColor = dgwGrillaEgresos.Item("col_egr_int_col", e.RowIndex).Value
            End If

            If dgwGrillaEgresos.Columns(e.ColumnIndex).Name = "col_pad_det_ape_nom_egr" Then
                e.CellStyle.BackColor = dgwGrillaEgresos.Item("col_int_color_egr", e.RowIndex).Value
            End If
        End Sub

        Private Sub dgwGrillaPoblacionActiva_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

            'Me.dgwGrillaPoblacionActiva.Rows(e.RowIndex).Cells(0).Style.SelectionBackColor = dgwGrillaPoblacionActiva.Item("col_act_int_col", e.RowIndex).Value     '= Me.dgwGrillaPoblacionActiva.Rows(e.RowIndex).Cells(0).Style.BackColor

        End Sub

        Private Sub dgwGrillaIngresos_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaIngresos.CellEnter

            Me.dgwGrillaIngresos.Rows(e.RowIndex).Cells(0).Style.SelectionBackColor = dgwGrillaIngresos.Item("col_ing_int_col", e.RowIndex).Value     '= Me.dgwGrillaPoblacionActiva.Rows(e.RowIndex).Cells(0).Style.BackColor

        End Sub

        Private Sub dgwGrillaEgresos_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaEgresos.CellEnter

            Me.dgwGrillaEgresos.Rows(e.RowIndex).Cells("col_img_obs_regLE").Style.SelectionBackColor = dgwGrillaEgresos.Item("col_egr_int_col", e.RowIndex).Value

            If dgwGrillaEgresos.Item("col_int_color_egr", e.RowIndex).Value.ToString = "Color [PaleGreen]" Then
                Me.dgwGrillaEgresos.Rows(e.RowIndex).Cells("col_pad_det_ape_nom_egr").Style.SelectionBackColor = dgwGrillaEgresos.Item("col_int_color_egr", e.RowIndex).Value
            Else
                Me.dgwGrillaEgresos.Rows(e.RowIndex).Cells("col_pad_det_ape_nom_egr").Style.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            End If

        End Sub

        Private Sub dgwGrillaIngresos_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrillaIngresos.CellFormatting
            With Me.dgwGrillaIngresos
                Select Case e.ColumnIndex
                    Case .Columns("col_ing_fec_nac").Index, .Columns("col_ing_fec_isp").Index, .Columns("col_ing_ult_pen").Index
                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                        Else
                            e.Value = ""
                        End If
                End Select
            End With
        End Sub

        Private Sub dgwGrillaEgresos_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrillaEgresos.CellFormatting
            With Me.dgwGrillaEgresos
                Select Case e.ColumnIndex
                    Case .Columns("col_ult_ing_pen").Index, .Columns("col_ing_isp").Index, .Columns("col_fec_nac_egr").Index, .Columns("col_dgw_egr_fec_egr").Index
                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                        Else
                            e.Value = ""
                        End If
                End Select
            End With
        End Sub
        Private Sub dgwGrilla_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgwGrilla.CellPainting
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub
            Try
                If dgwGrilla.Columns(e.ColumnIndex).Name = "col_img_obs_reg" Then
                    e.CellStyle.BackColor = dgwGrilla.Item("col_pad_int_column", e.RowIndex).Value
                End If
            Catch ex As Exception
                Dim S As String
                S = S
            End Try
        End Sub




        Private Sub btnDetalleInterno_Click(sender As System.Object, e As System.EventArgs) Handles btnDetalleInterno.Click

            Dim intIDInterno As Integer = -1

            Dim indice As Integer = Me.TabControl1.SelectedIndex
            Select Case indice
                Case 0 'ingresos
                    intIDInterno = Me.GrillaIDInterno(enmTipoGrilla.Ingresos)
                Case 1 'egresos
                    intIDInterno = Me.GrillaIDInterno(enmTipoGrilla.Egresos)
                Case 2 'padin                    
                    intIDInterno = Me.GrillaIDInterno(enmTipoGrilla.Padin)
            End Select

            If intIDInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el interno")
                Exit Sub
            End If

            FRM_InternoDetalle(intIDInterno)

        End Sub

        Private Sub tsp_btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsp_btnLimpiar.Click

            Me.txtCodInterno.Text = ""
            Me.txtApeNombres.Text = ""
            Me.cbbSitJuridica.SelectedIndex = 0
            Me.chkRegistrosObservados.Checked = False
            tsp_btnBuscar_Click(Nothing, Nothing)
            txtApeNombres.Focus()

        End Sub

        Private Sub tsp_btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsp_btnBuscar.Click

            Select Case Me.TabControl1.SelectedIndex
                Case 0 'ingresos
                    ListarIngresos()
                Case 1 'egresos
                    ListarEgresos()
                Case 2 'padin
                    ListarPadin_v2()
            End Select

        End Sub

        Private Sub dgwGrillaIngresos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrillaIngresos.CellContentClick

        End Sub
    End Class
End Namespace
