Namespace Estadistica

    Public Class frmExportDetPadin
        Private Property LstPadin As Dictionary(Of Integer, Integer)

        Private objBss As Bussines.Estadistica.PadinDetalle = Nothing

        Private objEntColActivos_tmp As New Entity.Estadistica.PadinDetalleCol
        Private objEntColIngresos_Tmp As New Entity.Estadistica.PadinDetalleCol
        Private objEntColEgresos_tmp As New Entity.Estadistica.PadinDetalleCol
        Private objEntColPadin_tmp As New Entity.Estadistica.PadinDetalleCol
        Private objEntLista_tmp As New List(Of Entity.Estadistica.PadinDetalleCol)

        Private objEntColPadinTotal As New Entity.Estadistica.PadinDetalleCol

        Public Property _GrillaPadin As Legolas.APPUIComponents.myDatagridView
        Public Enum enmTipoExportacion As Short
            Ninguna = 0
            Ingreso = 1
            Egreso = 2
            Padin = 3
        End Enum
#Region "Listas"
        Private Sub ListarPoblacionActiva(PadinId As Integer)
            Dim objEntFiltro As New Entity.Estadistica.PadinDetalle
            With objEntFiltro
                .PadinID = PadinId
                '.RegionID = Me._RegionID
                '.PenalID = Me._PenalID
                .PadinDetalleVisible = 1
                .PadinTipoMovimiento = -1
            End With
            objEntColActivos_tmp = objBss.ListarPoblacionActiva(objEntFiltro)
        End Sub

        Private Sub ListarIngresos(PadinId As Integer)
            objEntColIngresos_Tmp = New Entity.Estadistica.PadinDetalleCol
            objEntColEgresos_tmp = New Entity.Estadistica.PadinDetalleCol

            Dim objFiltro As New Entity.Estadistica.PadinDetalle
            With objFiltro
                .PadinID = PadinId
            End With
            objEntLista_tmp = objBss.ListarIngresoEgreso(objFiltro)

            objEntColIngresos_Tmp = objEntLista_tmp.Item(0)
            objEntColEgresos_tmp = objEntLista_tmp.Item(1)
        End Sub

        Private Sub ListarPadin()
            'Paso 01  Agregar todos los registor de ingreso  al padin
            For Each obj As Entity.Estadistica.PadinDetalle In objEntColIngresos_Tmp
                objEntColPadin_tmp.Add(obj) 'insertando filas  a padin
            Next

            'Paso 02 , recorrer todos los egreso y comparar si el egreso pertenece a un ingreso 
            Dim objEntColAux As New Entity.Estadistica.PadinDetalleCol
            For Each obj As Entity.Estadistica.PadinDetalle In objEntColEgresos_tmp

                Dim blnEncontro As Boolean = False
                For Each obj2 As Entity.Estadistica.PadinDetalle In objEntColPadin_tmp
                    If obj.InternoID = obj2.InternoID Then
                        If obj.IngresoID = obj2.IngresoID And obj.FechaIngresoPenal = obj2.FechaIngresoPenal Then
                            obj2.EgresoFecha = obj.EgresoFecha
                            obj2.EgresoTipoID = obj.EgresoTipoID
                            obj2.EgresoTipo = obj.EgresoTipo
                            obj2.EgresoTipoMotivo = obj.EgresoTipoMotivo
                            obj2.EgresoDocumentoLibertad = obj.EgresoDocumentoLibertad
                            obj2.EgresoDocumento = obj.EgresoDocumento
                            obj2.EgresoDistritoJudicial = obj.EgresoDistritoJudicial
                            obj2.EgresoSalaJuzgado = obj.EgresoSalaJuzgado
                            obj2.EgresoJuez = obj.EgresoJuez
                            obj2.EgresoSecretario = obj.EgresoSecretario
                            obj2.EgresoDestino = obj.EgresoDestino
                            obj2.InternoEstadoID = 0
                            obj.InternoColorEgreso = Color.PaleGreen
                            blnEncontro = True
                            Exit For
                        End If
                    End If
                Next

                If blnEncontro = False Then
                    obj.InternoEstadoID = 0
                    objEntColAux.Add(obj)
                End If
            Next

            For Each obj As Entity.Estadistica.PadinDetalle In objEntColAux
                objEntColPadin_tmp.Add(obj) 'insertando filas  a padin
            Next

            'Paso 03 , recorrer los registros de la poblacion activa y comparar con ingreso y egresos

            'sacar copia del coleccion de poblacion activa 
            Dim objEntColTempPoblacionActiva As New Entity.Estadistica.PadinDetalleCol
            Dim objEntTempPoblacionActiva As Entity.Estadistica.PadinDetalle

            For Each obj As Entity.Estadistica.PadinDetalle In objEntColActivos_tmp
                objEntTempPoblacionActiva = New Entity.Estadistica.PadinDetalle
                objEntTempPoblacionActiva = obj.CloneCol
                objEntColTempPoblacionActiva.Add(objEntTempPoblacionActiva)
            Next


            Dim objEntColTotAux As New Entity.Estadistica.PadinDetalleCol

            For Each obj As Entity.Estadistica.PadinDetalle In objEntColTempPoblacionActiva
                Dim blnEncontro As Boolean = False
                For Each obj2 As Entity.Estadistica.PadinDetalle In objEntColPadin_tmp
                    If obj.InternoID = obj2.InternoID Then blnEncontro = True : Exit For
                Next
                If blnEncontro = False Then objEntColTotAux.Add(obj) 'insertando filas  a padin
            Next

            For Each obj As Entity.Estadistica.PadinDetalle In objEntColTotAux
                objEntColPadin_tmp.Add(obj)
            Next

            'Ponemos color para la segunda grilla padin ordenado
            Dim InternoID As Integer = -1
            For Each obj As Entity.Estadistica.PadinDetalle In objEntColPadin_tmp

                Dim intConta As Integer = 0
                InternoID = obj.InternoID

                For Each obj2 As Entity.Estadistica.PadinDetalle In objEntColPadin_tmp
                    If InternoID = obj2.InternoID And obj2.InternoCondicionColor = -1 Then
                        obj2.InternoColorPadin = obj.InternoColor
                        obj2.InternoCondicionColor = 1
                        intConta += 1
                    End If
                Next

                If intConta > 1 And obj.InternoColor = Color.White Then
                    obj.InternoColorPadin = objBss.ObtenerColor()
                    For Each obj2 As Entity.Estadistica.PadinDetalle In objEntColPadin_tmp
                        If obj.InternoID = obj2.InternoID Then obj2.InternoColorPadin = obj.InternoColorPadin
                    Next
                End If
            Next

            objEntColPadin_tmp = objBss.ListarObservacionPadin(objEntColPadin_tmp)

            For Each obj As Entity.Estadistica.PadinDetalle In objEntColPadin_tmp
                objEntColPadinTotal.Add(obj)
            Next
        End Sub

        Private Sub ListarPadin_v6(idCodigoPadin As Integer)

            Dim objEntColActivos As New Entity.Estadistica.PadinDetalleCol
            Dim objEntGrillaCol As Entity.Estadistica.PadinDetalleCol
            Dim blnCargoDataPadin As Boolean = False
            Dim objEntColPadin As New Entity.Estadistica.PadinDetalleCol

            Dim objEntFiltro As New Entity.Estadistica.PadinDetalle
            If objEntColActivos.Count = 0 Then

                objEntGrillaCol = New Entity.Estadistica.PadinDetalleCol
                objBss = New Bussines.Estadistica.PadinDetalle

                With objEntFiltro
                    .PadinID = idCodigoPadin
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

            'agregar los registros al acumulador de padines multiples
            For Each obj As Entity.Estadistica.PadinDetalle In objEntColPadin
                objEntColPadinTotal.Add(obj)
            Next

        End Sub

        Private Sub ListarPadinIngresos_v6(idCodigoPadin As Integer)

            objBss = New Bussines.Estadistica.PadinDetalle

            Dim objEntColIngresos As New Entity.Estadistica.PadinDetalleCol

            Dim objFiltro As New Entity.Estadistica.PadinDetalle
            With objFiltro
                .PadinID = idCodigoPadin
            End With

            objEntColIngresos = objBss.ListarIngresoEgreso(objFiltro).Item(0) 'ingresos

            'agregar los registros al acumulador de padines multiples
            For Each obj As Entity.Estadistica.PadinDetalle In objEntColIngresos
                objEntColPadinTotal.Add(obj)
            Next

        End Sub

        Private Sub ListarPadinEgresos_v6(idCodigoPadin As Integer)

            objBss = New Bussines.Estadistica.PadinDetalle
            Dim objEntColEgresos As New Entity.Estadistica.PadinDetalleCol

            Dim objFiltro As New Entity.Estadistica.PadinDetalle
            With objFiltro
                .PadinID = idCodigoPadin
            End With

            objEntColEgresos = objBss.ListarIngresoEgreso(objFiltro).Item(1) 'egresos

            'agregar los registros al acumulador de padines multiples
            For Each obj As Entity.Estadistica.PadinDetalle In objEntColEgresos
                objEntColPadinTotal.Add(obj)
            Next

        End Sub
#End Region

        Public Sub New(tipoExportacion As enmTipoExportacion, LstPadin As Dictionary(Of Integer, Integer))

            Dim intTipoVersion As Integer = 0
            InitializeComponent()
            objBss = New Bussines.Estadistica.PadinDetalle
            Me.LstPadin = LstPadin

            For Each id As KeyValuePair(Of Integer, Integer) In Me.LstPadin
                Select Case id.Value

                    Case Is < 2 'version 4.5
                        Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
                        objEntCol = objBss.Listar(-1, id.Key, -1, -1, -1, "", "")
                        For Each obj As Entity.Estadistica.PadinDetalle In objEntCol
                            objEntColPadinTotal.Add(obj)
                        Next

                    Case 2 'version 4.6
                        objEntColActivos_tmp = New Entity.Estadistica.PadinDetalleCol
                        objEntColIngresos_Tmp = New Entity.Estadistica.PadinDetalleCol
                        objEntColEgresos_tmp = New Entity.Estadistica.PadinDetalleCol
                        objEntColPadin_tmp = New Entity.Estadistica.PadinDetalleCol
                        objEntLista_tmp = New List(Of Entity.Estadistica.PadinDetalleCol)
                        ListarPoblacionActiva(id.Key)
                        ListarIngresos(id.Key)
                        ListarPadin()

                    Case 5 'version 5

                        objEntColActivos_tmp = New Entity.Estadistica.PadinDetalleCol
                        objEntColIngresos_Tmp = New Entity.Estadistica.PadinDetalleCol
                        objEntColEgresos_tmp = New Entity.Estadistica.PadinDetalleCol
                        objEntColPadin_tmp = New Entity.Estadistica.PadinDetalleCol
                        objEntLista_tmp = New List(Of Entity.Estadistica.PadinDetalleCol)
                        ListarPoblacionActiva(id.Key)
                        ListarIngresos(id.Key)
                        ListarPadin()
                        intTipoVersion = 5

                    Case 6 'version  6

                        Select Case tipoExportacion
                            Case enmTipoExportacion.Ingreso
                                ListarPadinIngresos_v6(id.Key)

                            Case enmTipoExportacion.Egreso
                                ListarPadinEgresos_v6(id.Key)

                            Case enmTipoExportacion.Padin
                                ListarPadin_v6(id.Key)
                        End Select

                        intTipoVersion = 6

                End Select
            Next

            'padin, version 5
            Me.col_fec_cor_v5.Tag = "fecha"
            Me.col_fec_ing_sis_pen_v5.Tag = "fecha"
            Me.col_fec_ing_pen_v5.Tag = "fecha"
            Me.col_fec_nac_v5.Tag = "fecha"
            Me.col_fec_ini_v5.Tag = "fecha"
            Me.col_fec_fin_v5.Tag = "fecha"
            Me.col_fec_egr_v5.Tag = "fecha"
            Me.col_fec_sent_v5.Tag = "fecha"

            'padin, version 6
            Me.col_fec_cor.Tag = "fecha"
            Me.col_img_obs_reg.Visible = False
            Me.col_fec_ing_sis_pen.Tag = "fecha"
            Me.col_fec_ing_pen.Tag = "fecha"
            Me.col_fec_nac.Tag = "fecha"
            Me.col_obs.Visible = False

            'ingresos, version 6
            Me.col_fec_cor_pad_ing.Tag = "fecha"
            Me.col_ing_fec_isp.Tag = "fecha"
            Me.col_ing_ult_pen.Tag = "fecha"
            Me.col_ing_fec_nac.Tag = "fecha"

            'egresos, version 6
            Me.col_fec_cor_pad_egr.Tag = "fecha"
            Me.col_ing_isp.Tag = "fecha"
            Me.col_ult_ing_pen.Tag = "fecha"
            Me.col_fec_nac_egr.Tag = "fecha"
            Me.col_dgw_egr_fec_egr.Tag = "fecha"


            Select Case intTipoVersion
                Case 5

                    With Me.dgwGrillav5
                        .AllowUserToResizeRows = False
                        .AutoGenerateColumns = False
                        .DataSource = objEntColPadinTotal
                        .CurrentCell = Nothing
                    End With
                    Me._GrillaPadin = dgwGrillav5

                Case 6

                    'For i As Integer = 0 To dgwGrillav6.ColumnCount - 1
                    '    dgwGrillav6.Columns.Item(i).Visible = True
                    'Next

                    Select Case tipoExportacion
                        Case enmTipoExportacion.Ingreso

                            With Me.dgwGrillaIngresos
                                .AllowUserToResizeRows = False
                                .AutoGenerateColumns = False
                                .DataSource = objEntColPadinTotal
                                .CurrentCell = Nothing
                            End With
                            Me._GrillaPadin = Me.dgwGrillaIngresos

                        Case enmTipoExportacion.Egreso

                            With Me.dgwGrillaEgresos
                                .AllowUserToResizeRows = False
                                .AutoGenerateColumns = False
                                .DataSource = objEntColPadinTotal
                                .CurrentCell = Nothing
                            End With
                            Me._GrillaPadin = Me.dgwGrillaEgresos

                        Case enmTipoExportacion.Padin

                            With Me.dgwGrillav6
                                .AllowUserToResizeRows = False
                                .AutoGenerateColumns = False
                                .DataSource = objEntColPadinTotal
                                .CurrentCell = Nothing
                            End With
                            Me._GrillaPadin = dgwGrillav6
                    End Select

            End Select

        End Sub
    End Class
End Namespace