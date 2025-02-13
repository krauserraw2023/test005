Imports Type.Enumeracion
Imports System.Linq

Namespace Estadistica.v5
    Public Class frmPadinPopup

        Private objEnt As Entity.Estadistica.Padin = Nothing
        Private objBss As Bussines.Estadistica.Padin = Nothing
        Public Property _PadinDetalle As Boolean = False
        Private frmLoad As Load.frmLoad = Nothing
        Private ProcesoCompletado As Boolean = False
        Private objBssPadinDetalle As Bussines.Estadistica.PadinDetalle = Nothing
#Region "Propiedades"
        Public Property _IDPadin() As Integer = -1
        Public Property _IDRegion() As Integer = -1
        Public Property _RegionNombre() As String
            Get
                Return Me.txtRegion.Text
            End Get
            Set(ByVal value As String)
                Me.txtRegion.Text = value.ToUpper
            End Set
        End Property
        Public Property _IDPenal() As Integer = -1
        Public Property _PenalNombre() As String
            Get
                Return Me.txtPenal.Text
            End Get
            Set(ByVal value As String)
                Me.txtPenal.Text = value.ToUpper
            End Set
        End Property
        Private Property Numero() As Integer = 0

        Private Property NumeroString() As String
            Get
                Return Me.txtNumero.Text
            End Get
            Set(ByVal value As String)
                Me.txtNumero.Text = value
            End Set
        End Property
        Private Property Anio() As Integer
            Get
                Return Me.cbbAnio.Value
            End Get
            Set(ByVal value As Integer)
                Me.cbbAnio.Value = value
            End Set
        End Property
        Private Property Mes() As Integer
            Get
                Return Me.cbbMes.Value
            End Get
            Set(ByVal value As Integer)
                Me.cbbMes.Value = value
            End Set
        End Property
        Private Property Fecha() As Long = 0
        Private Property FechaProceso() As Long = 0

        Private Property FechaEnvio() As Long = 0

        Private Property EstadoID() As Integer = -1

        Private Property EstadoNombre() As String
            Get
                Return Me.txtEstado.Text
            End Get
            Set(ByVal value As String)
                Me.txtEstado.Text = value
            End Set
        End Property

        Private Property FechaCorte() As Long
            Get
                Return Me.dtpFechaCorte.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaCorte.ValueLong = value
            End Set
        End Property

        Public ReadOnly Property FechaProcesoString() As String
            Get
                Dim value As String = ""

                If Me.FechaProceso < 1 Then
                    value = Now.ToString
                Else
                    value = Legolas.Components.FechaHora.FechaDate(Me.FechaProceso, True)
                End If
                Return value
            End Get
        End Property

        Private Property Observacion() As String
            Get
                Return Me.txtObs.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.txtObs.Text = value
            End Set
        End Property
        Public Property _PadColor As System.Drawing.Color
        Public ReadOnly Property TipoPenal As Short
            Get
                Dim value As Short = -1
                Dim objPenal As New Bussines.General.Penal
                value = objPenal.fnTipoLicencia(Me._IDPenal)
                Return value
            End Get
        End Property

        Public Property VersionReporte As Short = -1
#End Region
#Region "Combo"
        Private Sub Combo()

            Dim intAnio As Integer = Legolas.Configuration.Aplication.FechayHora.FechaAnio

            With Me.cbbAnio
                .AnioInicio = 2013
                .AnioFin = intAnio
                .LoadUsc()
            End With

            With Me.cbbMes
                .LoadUsc()
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub ListarData()

            If Me._IDPadin < 1 Then
                Exit Sub
            End If

            objEnt = New Entity.Estadistica.Padin
            objBss = New Bussines.Estadistica.Padin

            objEnt = objBss.Listar(Me._IDPadin)

            With objEnt
                Me.Numero = .Numero
                Me.NumeroString = .Numero.ToString
                Me.Anio = .Anio
                Me.Mes = .Mes
                Me.Fecha = .Fecha
                Me.FechaProceso = .FechaProceso
                Me.FechaEnvio = .FechaEnvio
                Me.FechaCorte = .FechaCorte
                Me.EstadoID = .Estado
                Me.EstadoNombre = .EstadoNombre
                Me.Observacion = .Observacion
                Me.txtFechaProc.Text = Me.FechaProcesoString
                Me.VersionReporte = .VersionReporte
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False
            If Me.Anio > Now.Year Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El año no puede ser mayor al actual")
                Me.cbbAnio.Focus()
                Return False
            End If
            If Me.Anio < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione año")
                Me.cbbAnio.Focus()
                Return value
            End If

            If Me.Mes < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione mes")
                Me.cbbMes.Focus()
                Return value
            End If

            If Me.FechaCorte < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione fecha de corte")
                Me.cbbMes.Focus()
                Return value
            End If

            value = True

            Return value

        End Function

        Private Function AGrabar(ByVal blnMensaje As Boolean) As Boolean

            If Validar() = False Then
                Exit Function
            End If

            Dim value As Integer = -1

            If Me.Fecha < 1 Then
                Me.Fecha = Legolas.Configuration.Aplication.FechayHora.FechaLong
            End If

            objBss = New Bussines.Estadistica.Padin

            objEnt = New Entity.Estadistica.Padin

            With objEnt
                .Codigo = Me._IDPadin
                .RegionID = Me._IDRegion
                .PenalID = Me._IDPenal
                .Numero = Me.Numero
                .FechaCorte = Me.FechaCorte
                .Anio = Legolas.Components.FechaHora.FechaAnio(.FechaCorte)
                .Mes = Legolas.Components.FechaHora.FechaMes(.FechaCorte)
                .Fecha = Me.Fecha
                .FechaProceso = Me.FechaProceso
                .FechaEnvio = Me.FechaEnvio
                .Observacion = Me.Observacion
                .Estado = Me.EstadoID
                .Version = 6 'version del sistema 
                .VersionReporte = 2 'version del reporte padin
                '.VersionReporte = 3 'version del reporte padin
            End With

            value = objBss.Grabarv5(objEnt)

            Select Case value
                Case Is > 0
                    Me.btnGenerar.Enabled = True
                    Me.pnlEliminar.Enabled = True
                    Me._IDPadin = value
                    If blnMensaje Then
                        'Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                    End If
                    ListarData()
                    Return True
                Case Else
                    Return False
                    Me.Close()
            End Select

        End Function

        Private Function ValidarEliminar() As Boolean

            Dim value As Boolean = False

            If Me._IDPadin < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de eliminar, grabe el registro")
                Return value
            End If

            Select Case Me.EstadoID
                Case 4 'transferida
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                   "No puede realizar ninguna accion, la informacion ha sido transferida")
                    Return value
            End Select

            value = True

            Return value
        End Function

        Private Sub AAnular()

            If ValidarEliminar() = False Then
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question("Confirma anular el registro seleccionado?") = Windows.Forms.DialogResult.Yes Then
                objBss = New Bussines.Estadistica.Padin
                objBss.Anular(Me._IDPadin)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub

        Private Sub AEliminar()
            If ValidarEliminar() = False Then Exit Sub

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = Windows.Forms.DialogResult.Yes Then
                objBss = New Bussines.Estadistica.Padin
                objBss.Eliminar(Me._IDPadin)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub

        Private Function ValidarProceso() As Boolean

            Dim value As Boolean = False

            If Me._IDPadin < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de procesar la informacion, grabe el registro")
                Return value
            End If

            Select Case Me.EstadoID
                Case 2, 3 'procesado/transferida
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                   "No puede realizar ninguna accion, la informacion ha sido procesada o transferido")
                    Return value
            End Select

            value = True

            Return value
        End Function

        Private Sub AProceso()

            Dim intSeg As Integer = 0
            Dim blnOK As Boolean = False

            Dim dteFechaIni As Date = Now
            Dim dteFechaFin As Date = Now


            Me.SuspendLayout()
            Me.Timer1.Start()
            frmLoad = New Load.frmLoad
            frmLoad._PermitirCancelar = False
            If frmLoad.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.Timer1.Stop()
                Me.BackgroundWorker1.CancelAsync()
                Me.BackgroundWorker1.Dispose()
            End If
            Me.ResumeLayout(True)
            frmLoad.Refresh()


            blnOK = ProcesoCompletado

            If blnOK = True Then

                Dim lngFecha As Long = Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong
                Dim intEstado As Integer = 2 'procesado

                objBss = New Bussines.Estadistica.Padin
                objEnt = New Entity.Estadistica.Padin
                With objEnt
                    .Codigo = Me._IDPadin
                    .FechaProceso = lngFecha
                    .Estado = intEstado

                End With

                objBss.GrabarProceso(objEnt)

                'tiempo estimado
                dteFechaFin = Now
                intSeg = DateDiff(DateInterval.Second, dteFechaIni, dteFechaFin)

                Select Case Legolas.Configuration.Usuario.OficinaID
                    Case 1 'osin
                        Legolas.Configuration.Aplication.MessageBox.Information("Tiempo estimado en segundos: " & intSeg.ToString)
                End Select

                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If

            Me.Cursor = Cursors.Default

        End Sub

        Private Function ValidarTransferencia() As Boolean

            Dim value As Boolean = False

            If Me._IDPadin < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de transferir la informacion, grabe el registro")
                Return value
            End If

            If Me.FechaProceso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
               "Antes de transferir la informacion, procese la informacion")
                Exit Function
            End If

            Select Case Me.EstadoID
                Case 4 'transferencia
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                   "No puede realizar ninguna accion, la informacion ha sido transferida a la Sede Central")
                    Return value
            End Select

            value = True
            Return value
        End Function

        Private Sub ATransferir()

            If ValidarTransferencia() = False Then
                Exit Sub
            End If

            Dim strMensaje As String = ""
            strMensaje = "Esta seguro de transferir la informacion del PADIN," + Chr(13) +
                "para su revisión y conformidad por parte de la Región"

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) <> Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If

            If FRM_Transferencia() = True Then

                Dim value As Integer = -1
                'Dim lngFecha As Long = Legolas.Configuration.Aplication.FechayHora.FechaLong
                Dim lngFecha As Long = Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong
                Dim intEstado As Integer = 3 'transferencia

                objBss = New Bussines.Estadistica.Padin

                objEnt = New Entity.Estadistica.Padin
                With objEnt
                    .Codigo = Me._IDPadin
                    .FechaEnvio = lngFecha
                    .Estado = intEstado
                End With

                value = objBss.GrabarTransferencia(objEnt)

                If value > 0 Then
                    Me._IDPadin = value
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If

        End Sub

        Private Sub ATransferirSedeCentral()

            If ValidarTransferencia() = False Then
                Exit Sub
            End If

            Dim strMensaje As String = ""
            strMensaje = "Esta seguro de transferir el PADIN a la Sede Central. " + Chr(13) +
                "Esta Información sera tomada como OFICIAL, por la UNIDAD de ESTADISTICA!!!" + Chr(13) + Chr(13) +
                "Nota: El PADIN, debe haber sido validado por la Región, de NO estar validado, coordine con la Región." + Chr(13) +
                "Si se coordino con la Región y el PADIN presenta inconsistencias, anule y generé uno nuevo," + Chr(13) +
                "y vuelvalo a enviar a la Región, hasta que sea conforme."

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) <> Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If

            If FRM_Transferencia() = True Then

                Dim value As Integer = -1
                'Dim lngFecha As Long = Legolas.Configuration.Aplication.FechayHora.FechaLong
                Dim lngFecha As Long = Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong
                Dim intEstado As Integer = 4 'transferencia sede central

                objBss = New Bussines.Estadistica.Padin

                objEnt = New Entity.Estadistica.Padin
                With objEnt
                    .Codigo = Me._IDPadin
                    .FechaEnvio = lngFecha
                    .Estado = intEstado
                End With

                value = objBss.GrabarTransferencia(objEnt)

                If value > 0 Then
                    Me._IDPadin = value
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If

        End Sub

        Private Sub ValidarControles()

            Dim intMaxPadin As Integer = 0
            Select Case Me.EstadoID
                Case Padin.EnumPadinEstado.Pendiente
                    If Me._IDPadin < 1 Then
                        Me.pnlEliminar.Enabled = False
                    End If
                    Me.pnlTranferRegion.Enabled = False
                    Me.pnlTranferSede.Enabled = False
                    Me.btnPadinDetalle.Enabled = False

                Case Padin.EnumPadinEstado.Procesado

                    Dim blnVerEnviaraSede As Boolean = False
                    Select Case Me.TipoPenal
                        Case 4 'penal lima metropolitana
                            blnVerEnviaraSede = True
                        Case Else 'penal de provincias
                            'nada
                    End Select

                    Me.cbbAnio.Enabled = False
                    Me.cbbMes.Enabled = False
                    Me.dtpFechaCorte.Enabled = False

                    If Me.pnlGrabar.Visible = True Then
                        Me.btnGenerar.Enabled = False
                        Me.pnlTranferSede.Enabled = blnVerEnviaraSede
                    End If

                Case Padin.EnumPadinEstado.EnviadoRegion
                    Me.cbbAnio.Enabled = False
                    Me.cbbMes.Enabled = False
                    Me.dtpFechaCorte.Enabled = False

                    Me.btnEliminar.Text = "&Eliminar"
                    Me.btnEliminar.Image = SIPPOPE.My.Resources.Resources.delete_32

                    If Me.pnlGrabar.Visible = True Then
                        Me.btnEliminar.Enabled = True
                        Me.btnEliminar.Text = "&Anular"
                        Me.btnEliminar.Image = SIPPOPE.My.Resources.Resources.anular2
                        Me.btnGenerar.Enabled = False
                        Me.pnlTranferRegion.Enabled = False

                        intMaxPadin = objBss.ValidarMaximoPadin(Me._IDRegion, Me._IDPenal)
                        If intMaxPadin > Me.Numero Then
                            Me.pnlTranferSede.Enabled = False
                        End If
                    End If

                Case Padin.EnumPadinEstado.Anulado
                    Me.cbbAnio.Enabled = False
                    Me.cbbMes.Enabled = False
                    Me.dtpFechaCorte.Enabled = False

                    If Me.pnlGrabar.Visible = True Then
                        'Me.btnGrabar.Enabled = False
                        Me.pnlEliminar.Enabled = False
                        Me.btnGenerar.Enabled = False
                        Me.pnlTranferRegion.Enabled = False
                        Me.pnlTranferSede.Enabled = False
                    End If

                Case Padin.EnumPadinEstado.EnviadoSCentral
                    Me.cbbAnio.Enabled = False
                    Me.cbbMes.Enabled = False
                    Me.dtpFechaCorte.Enabled = False
                    Me.txtObs.Enabled = False
                    Me.pnlEliminar.Enabled = False
                    If Me.pnlGrabar.Visible = True Then
                        'Me.btnGrabar.Enabled = False
                        Me.pnlEliminar.Enabled = False
                        Me.btnGenerar.Enabled = False
                        Me.pnlTranferRegion.Enabled = False
                        Me.pnlTranferSede.Enabled = False
                    End If

            End Select
        End Sub

        Private Sub FRMPadinDetalle(ByVal LstPadin As List(Of Integer))

            If Me._IDPadin < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione registro")
                Exit Sub
            End If

            Dim frm As New Estadistica.v5.frmPadinDetalle
            'frm.MdiParent = Estadistica.v5.SIPPOPE_Estadistica_v5_frmBuscar.MdiParent
            frm.WindowState = FormWindowState.Maximized

            With frm
                '._LstPadinID = LstPadin  'lista de padines seleccionados
                ._IDPadin = Me._IDPadin
                ._IDRegion = Me._IDRegion
                ._RegionNombre = Me._RegionNombre
                ._IDPenal = Me._IDPenal
                ._PenalNombre = Me._PenalNombre
                ._Anio = Me.Anio
                ._Mes = Me.Mes
                .Show()
            End With
            Me.Close()
        End Sub
#End Region
#Region "Procesar_Padin"
        Private Function AGenerarPadinDetalle(IDPadin As Integer, IDRegion As Integer, IDPenal As Integer, FechaIni As Long, FechaFin As Long,
                                                     FechaProceso As Long) As Boolean

            Dim value As Boolean = False
            Dim strMensajeOut As String = ""

            Select Case Me.TipoPenal
                Case 4 'penal lima metropolitana
                    value = AGenerarPadinDetalle_vPLM_v6(IDPadin, IDRegion, IDPenal, FechaIni, FechaFin, FechaProceso, strMensajeOut)

                Case Else 'penal provincias

                    value = AGenerarPadinDetalle_v6(IDPadin, IDRegion, IDPenal, FechaIni, FechaFin, FechaProceso)

            End Select

            Return value

        End Function

        Private Function AGenerarPadinDetalle_v6(ByVal PadinID As Integer, ByVal RegionID As Integer,
                                           ByVal PenalID As Integer, ByVal FechaIni As Long,
                                           ByVal FechaFin As Long, ByVal FechaProceso As Long) As Boolean

            Dim blnValue As Boolean = False
            Dim lngFechaOperacion As Long = 0
            objBss = New Bussines.Estadistica.Padin
            '/*interno*/
            Dim objBssInterno As New Bussines.Estadistica.PadinDetalle
            Dim objEntColInternoIngreso As New Entity.Estadistica.PadinDetalleCol
            Dim objEntColInternoPadinIngresos As New Entity.Estadistica.PadinDetalleCol
            Dim objEntColInternoEgresos As New Entity.Estadistica.PadinDetalleCol
            Dim objEntColInternoActivo As New Entity.Estadistica.PadinDetalleCol
            Dim objEntColInternoLAaux As New Entity.Estadistica.PadinDetalleCol
            Dim objEntPadin As New Entity.Estadistica.Padin
            With objEntPadin
                .Codigo = PadinID
                .RegionID = Me._IDRegion
                .PenalID = Me._IDPenal
                .Fecha = FechaIni
                .FechaCorte = FechaFin
                .FechaProceso = FechaProceso
            End With
            Try
                ''=============Activos
                objEntColInternoActivo = objBss.ListarPoblacionActivos_tmp_v6(objEntPadin)
                objEntColInternoIngreso = objBss.ListarPoblacionIngresos_tmp_v6(objEntPadin, 1)
                objEntColInternoEgresos = objBss.ListarPoblacionEgresos_tmp_v6(objEntPadin, 2)
                '=============Registrar Detalle padin
                objEntColInternoPadinIngresos = RegistrarDetallePadin_v6(PadinID, RegionID, PenalID, FechaIni, FechaFin, FechaProceso, objEntColInternoIngreso, 0, 1)
                RegistrarDetallePadin_v6(PadinID, RegionID, PenalID, FechaIni, FechaFin, FechaProceso, objEntColInternoEgresos, 0, 2)
                RegistrarDetallePadin_v6(PadinID, RegionID, PenalID, FechaIni, FechaFin, FechaProceso, objEntColInternoActivo, 1, 3)
            Catch ex As Exception
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Error al generar padin: " & ex.Message & " , Comuniquese con soporte de la Sede Central.")

                objBss = New Bussines.Estadistica.Padin
                objBss.Eliminar(Me._IDPadin)

                'BackgroundWorker1.WorkerReportsProgress = True
                BackgroundWorker1.WorkerSupportsCancellation = True
            End Try


            blnValue = True

            Return blnValue

        End Function


        Private Function RegistrarDetallePadin_v6(PadinID As Integer, RegionID As Integer, PenalID As Integer, FechaIni As Long, FechaFin As Long, FechaProceso As Long,
                                                      objEntColInterno As Entity.Estadistica.PadinDetalleCol, PadinVisible As Integer, PadinTipoMov As Integer) As Entity.Estadistica.PadinDetalleCol
            objBssPadinDetalle = New Bussines.Estadistica.PadinDetalle
            Try
                objBssPadinDetalle.DatosComplementarios_v6(PadinID, RegionID, PenalID, FechaIni, FechaFin, PadinVisible, PadinTipoMov, Me.VersionReporte, objEntColInterno)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try


            Return objEntColInterno
        End Function

        Private Function AGenerarPadinDetalle_vPLM_v6(ByVal IDPadin As Integer, ByVal IDRegion As Integer,
                                           ByVal IDPenal As Integer, ByVal lngFechaIni As Long,
                                           ByVal lngFechaFin As Long, ByVal lngFechaProceso As Long, ByRef strMensajeOut As String) As Boolean

            Dim blnValue As Boolean = False
            Dim lngFechaOperacion As Long = 0
            objBss = New Bussines.Estadistica.Padin

            '/*interno*/
            Dim objBssInterno As New Bussines.Estadistica.PadinDetalle
            Dim objEntColInternoIngreso As New Entity.Estadistica.PadinDetalleCol
            Dim objEntColInternoPadinIngresos As New Entity.Estadistica.PadinDetalleCol
            Dim objEntColInternoEgresos As New Entity.Estadistica.PadinDetalleCol
            Dim objEntColInternoActivo As New Entity.Estadistica.PadinDetalleCol
            Dim objEntColInternoLAaux As New Entity.Estadistica.PadinDetalleCol
            Dim objEntPadin As New Entity.Estadistica.Padin

            With objEntPadin
                .Codigo = IDPadin
                .RegionID = Me._IDRegion
                .PenalID = Me._IDPenal
                .Fecha = lngFechaIni
                .FechaCorte = lngFechaFin
                .FechaProceso = lngFechaProceso
            End With

            objEntColInternoIngreso = objBss.ListarPoblacionIngresos_plm_v2(objEntPadin, Type.Enumeracion.Padin.EnumTipoMovimiento.Ingresos)

            objEntColInternoEgresos = objBss.ListarPoblacionEgresos_plm_v2(objEntPadin, Type.Enumeracion.Padin.EnumTipoMovimiento.Egresos)

            objEntColInternoActivo = objBss.ListarPoblacionActivos_plm_v2(objEntPadin)
            '=============insertar los entitys coleccion de ingreso y egreso, a la tabla padin detalle
            '/*Activos*/
            insertDetallePadin_vPLM_v6(IDPadin, IDRegion, IDPenal, lngFechaIni, lngFechaFin, lngFechaProceso, objEntColInternoActivo, 1, 3, strMensajeOut)

            '/*ingresos*/
            objEntColInternoPadinIngresos = insertDetallePadin_vPLM_v6(IDPadin, IDRegion, IDPenal, lngFechaIni, lngFechaFin, lngFechaProceso, objEntColInternoIngreso, 0, 1, strMensajeOut)

            '/*egresos*/
            insertDetallePadin_vPLM_v6(IDPadin, IDRegion, IDPenal, lngFechaIni, lngFechaFin, lngFechaProceso, objEntColInternoEgresos, 0, 2, strMensajeOut)



            'Catch ex As Exception
            '    Legolas.Configuration.Aplication.MessageBox.MensajeError("Error al generar padin: " & ex.Message & " , Comuniquese con la Oficina de Sistemas de Informacion de la Sede Central.")

            '    objBss = New Bussines.Estadistica.Padin
            '    objBss.Eliminar(Me._PadinID)

            '    BackgroundWorker1.WorkerSupportsCancellation = True
            'End Try

            blnValue = True

            Return blnValue

        End Function

        Private Function insertDetallePadin_vPLM_v6(PadinID As Integer, RegionID As Integer, PenalID As Integer, FechaIni As Long,
                                                      FechaFin As Long, FechaProceso As Long, objEntColInterno As Entity.Estadistica.PadinDetalleCol,
                                                   PadinVisible As Integer, PadinTipoMov As Integer, ByRef strMensajeOut As String) As Entity.Estadistica.PadinDetalleCol

            objBssPadinDetalle = New Bussines.Estadistica.PadinDetalle

            objBssPadinDetalle.DatosComplementarios_plm_v6(PadinID, RegionID, PenalID, FechaIni, FechaFin, PadinVisible, PadinTipoMov, Me.VersionReporte,
                                                            objEntColInterno, strMensajeOut)

            'If strMensajeOut.Trim.Length > 0 Then
            '    MessageBox.Show("Se ha encontrado un error al procesar el PADIN." & Chr(13) & strMensajeOut, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If

            Return objEntColInterno
        End Function

#End Region
#Region "Usuarios/Permisos/Accesos"
        Private Function VerificaPermisoEscritura() As Boolean

            Dim objBss As New Bussines.Sistema.InstalacionDetalle
            Dim value As Boolean = False
            Dim intEscritura As Integer
            Dim intLicencia As Integer
            intLicencia = Configuracion.Licencia.Codigo

            intEscritura = objBss.VerificarPermisoEscritura(-1, intLicencia, Me._IDPenal)

            If intEscritura = 1 Then
                value = True
            End If
            Return value

        End Function

        Private Sub UsuariosPermisos()

            Dim blnEscritura As Boolean = Me._FormEscritura
            Dim blnEliminar As Boolean = Me._FormEliminar

            'validar el acceso del usuario, correponde a la licencia de la base de datos
            Dim intTipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Dim objBssLicencia As New Bussines.Sistema.Instalacion
            intTipoLicencia = objBssLicencia.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)

            Dim intOficina As Type.Enumeracion.Usuario.EnumDependencia
            intOficina = Legolas.Configuration.Usuario.OficinaID

            If blnEscritura = True Then

                Select Case intTipoLicencia
                    Case Licencia.enmTipoLicencia.PenalProvincia

                        If intOficina = Usuario.EnumDependencia.RegistroPenitenciario Then
                            'pasa
                        ElseIf intOficina = Usuario.EnumDependencia.SistemasInformacion Then
                            'pasa
                        Else
                            blnEscritura = False
                        End If

                    Case Licencia.enmTipoLicencia.RegionProvincia

                        If intOficina = Usuario.EnumDependencia.RegistroPenitenciario Or
                                intOficina = Usuario.EnumDependencia.SistemasInformacion Then

                            blnEscritura = VerificaPermisoEscritura()

                        Else
                            blnEscritura = False
                        End If

                    Case Licencia.enmTipoLicencia.Sede

                        If intOficina <> Usuario.EnumDependencia.SistemasInformacion Then
                            blnEscritura = False
                        End If

                End Select

            End If


            If blnEliminar = True Then

                Select Case intTipoLicencia
                    Case Licencia.enmTipoLicencia.PenalProvincia

                        If intOficina = Usuario.EnumDependencia.RegistroPenitenciario Then
                            'pasa
                        ElseIf intOficina = Usuario.EnumDependencia.SistemasInformacion Then
                            'pasa
                        Else
                            blnEliminar = False
                        End If

                    Case Licencia.enmTipoLicencia.RegionProvincia

                        If intOficina = Usuario.EnumDependencia.RegistroPenitenciario Or
                                intOficina = Usuario.EnumDependencia.SistemasInformacion Then

                            blnEliminar = VerificaPermisoEscritura()

                        Else
                            blnEliminar = False
                        End If

                    Case Licencia.enmTipoLicencia.Sede

                        If intOficina <> Usuario.EnumDependencia.SistemasInformacion Then
                            blnEliminar = False
                        End If

                End Select

            End If

            Dim blnVerRegion As Boolean = False
            Select Case Me.TipoPenal
                Case 4 'penal lima metropolitana
                    blnVerRegion = False
                Case Else 'penal de provincias
                    blnVerRegion = blnEscritura
            End Select

            Me.pnlGrabar.Visible = blnEscritura
            Me.pnlTranferRegion.Visible = blnVerRegion
            Me.pnlTranferSede.Visible = blnEscritura
            Me.pnlEliminar.Visible = blnEliminar

        End Sub
#End Region
#Region "Otros"
        Private Function FRM_Transferencia() As Boolean

            Dim value As Boolean = False

            value = True

            Return value

        End Function

        Private Sub ValoresxDefault()

            Combo()
            Me.Anio = Legolas.Configuration.Aplication.FechayHora.FechaAnio
            Me.Mes = Legolas.Configuration.Aplication.FechayHora.FechaMes
            Me.cbbMes.Enabled = False
            Me.cbbAnio.Enabled = False
            Me.dtpFechaCorte.ValueLong = Legolas.Configuration.Aplication.FechayHora.FechaLong
            Me.txtFechaProc.Text = Now().Date
            UsuariosPermisos()

        End Sub
#End Region
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
            If Me.Numero > 0 Then
                AGrabar(False)
            Else
                Dim strMensaje As String = ""
                strMensaje = "Esta seguro de realizar la operación"

                If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = Windows.Forms.DialogResult.Yes Then
                    If AGrabar(True) = True Then
                        If ValidarProceso() = False Then
                            Exit Sub
                        End If

                        AProceso()
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Information("No se pudo realizar la generación del Padin, operación cancelada")
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If

            End If
        End Sub

        Private Sub frmPadinPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub frmPadinPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            ListarData()
            ValidarControles()
        End Sub

        Private Sub btnTransferir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnlTranferRegion.Click
            ATransferir()
        End Sub

        Private Sub pnlTranferSede_Click(sender As System.Object, e As System.EventArgs) Handles pnlTranferSede.Click
            ATransferirSedeCentral()
        End Sub

        Private Sub btnPadinDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPadinDetalle.Click
            Me.DialogResult = Windows.Forms.DialogResult.OK
            _PadinDetalle = True
        End Sub

        Private Sub dtpFechaCorte__ValueChanged() Handles dtpFechaCorte._ValueChanged
            If dtpFechaCorte.ValueLong > Legolas.Configuration.Aplication.FechayHora.FechaLong Then
                MessageBox.Show("Fecha de corte no puede ser Mayor a fecha Actual", "INPE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.dtpFechaCorte.ValueLong = Legolas.Configuration.Aplication.FechayHora.FechaLong
                Me.Anio = Legolas.Configuration.Aplication.FechayHora.FechaAnio
                Me.Mes = Legolas.Configuration.Aplication.FechayHora.FechaMes
            ElseIf dtpFechaCorte.ValueAnio < 2010 Then
                MessageBox.Show("El año de la Fecha de corte no puede ser Menor a 2010", "INPE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.dtpFechaCorte.ValueLong = Legolas.Configuration.Aplication.FechayHora.FechaLong
                Me.Anio = Legolas.Configuration.Aplication.FechayHora.FechaAnio
                Me.Mes = Legolas.Configuration.Aplication.FechayHora.FechaMes
            Else
                Me.Anio = dtpFechaCorte.ValueAnio
                Me.Mes = dtpFechaCorte.ValueMes
            End If
        End Sub

        Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
            Dim lngFechaFin As Long = Me.FechaCorte
            Dim dteFecha As Date = Legolas.Components.FechaHora.FechaDate(Me.FechaCorte, True)
            dteFecha = dteFecha & " 23:59:59"
            lngFechaFin = dteFecha.ToFileTime
            Dim fecinipro As DateTime = Now()
            Dim lngFechaIni As Long = Legolas.Components.FechaHora.FechaPrimerDiaMes(Me.FechaCorte)
            Dim lngFechaProceso As Long = Legolas.LBusiness.Globall.DateTime.FechaServerLong
            ProcesoCompletado = AGenerarPadinDetalle(Me._IDPadin, Me._IDRegion, Me._IDPenal, lngFechaIni, lngFechaFin, lngFechaProceso)

            'MessageBox.Show("Tiempo de proceso: " & DateDiff(DateInterval.Second, fecinipro, Now()) & " Seg.")
        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
            Dim result As Boolean = False
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                Me.Timer1.Stop()
                frmLoad.Close()
                result = e.Result
            End If
        End Sub

        Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
            If Me.BackgroundWorker1.IsBusy Then Exit Sub
            Me.BackgroundWorker1.RunWorkerAsync()
        End Sub

        Private Sub btnTransfSedeCentral_Click(sender As Object, e As EventArgs) Handles btnTransfSedeCentral.Click

            ATransferirSedeCentral()

        End Sub

        Private Sub btnTransfRegion_Click(sender As Object, e As EventArgs) Handles btnTransfRegion.Click

            ATransferir()

        End Sub

        Private Sub grbObs_Enter(sender As Object, e As EventArgs) Handles grbObs.Enter

        End Sub

        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

            Select Case Me.EstadoID
                Case Padin.EnumPadinEstado.Anulado
                    Legolas.Configuration.Aplication.MessageBox.Information("El registro ya se encuentra anulado")
                Case Padin.EnumPadinEstado.EnviadoRegion
                    AAnular()
                Case Else
                    AEliminar()
            End Select

        End Sub
    End Class
End Namespace