Namespace Visita.Autorizacion
    Public Class frmAutorizacionMant
        '12-09-2024 e.cu.cco
        Private objBssAutConf As Bussines.Visita.AutorizacionConfiguracion = Nothing
        Private objEntAutConf As Entity.Visita.AutorizacionConfiguracion = Nothing
#Region "Propiedades_Par"
        Public Property _RegionID As Integer = -1
        Public Property _RegionNombre() As String
            Get
                Return Me.UscRegionPenalLabel1._RegionNombre
            End Get
            Set(ByVal value As String)
                Me.UscRegionPenalLabel1._RegionNombre = value
            End Set
        End Property
        Public Property _PenalID As Integer = -1
        Public Property _PenalNombre() As String
            Get
                Return Me.UscRegionPenalLabel1._PenalNombre
            End Get
            Set(ByVal value As String)
                Me.UscRegionPenalLabel1._PenalNombre = value
            End Set
        End Property
        Public Property _InternoID As Integer = -1
        Public Property _InternoApeNom As String
            Get
                Return Me.lblInternoApeNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.lblInternoApeNom.Text = value.ToUpper
            End Set
        End Property
        Public Property _InternoEtapa As String = ""
        Public Property _InternoPabellon As String = ""
#End Region
#Region "Propiedades_Otros"
        Public Property _blnNuevo() As Boolean = False
#End Region
#Region "Listar"
        Private Sub ListarUsc()

            If Me._InternoID < 1 Then
                Exit Sub
            End If

            With Me.UscAutorizacion1
                ._InternoID = Me._InternoID
                ._LoadUsc()

                ListarGrillaCount()
            End With


            If _blnNuevo = True Then
                FRM_AutorizacionNuevo()
            End If

        End Sub
        Private Sub ListarGrillaCount()

            Me.lblCountReg.Text = Me.UscAutorizacion1._GrillaCount & " Reg."

        End Sub
#End Region
#Region "PropiedadesAutorizacion"
        Private Property ConfiguracionCodigo() As Integer = -1
        Private Property ConfiguracionDiaMaximo() As Integer
        Private Property ConfiguracionEnero() As Boolean
        Private Property ConfiguracionFebrero As Boolean
        Private Property ConfiguracionMarzo As Boolean
        Private Property ConfiguracionAbril As Boolean
        Private Property ConfiguracionMayo As Boolean
        Private Property ConfiguracionJunio As Boolean
        Private Property ConfiguracionJulio As Boolean
        Private Property ConfiguracionAgosto As Boolean
        Private Property ConfiguracionSetiembre As Boolean
        Private Property ConfiguracionOctubre As Boolean
        Private Property ConfiguracionNoviembre As Boolean
        Private Property ConfiguracionDiciembre As Boolean
        Private Property ConfiguracionEstado() As Integer = -1
#End Region
#Region "Listar_Autorizacion"
        Private Sub ListarMant_Autorizacion()

            objBssAutConf = New Bussines.Visita.AutorizacionConfiguracion
            objEntAutConf = New Entity.Visita.AutorizacionConfiguracion
            objEntAutConf.RegionID = Me._RegionID
            objEntAutConf.PenalID = Me._PenalID
            objEntAutConf = objBssAutConf.Listar(Me.ConfiguracionCodigo, Me._PenalID, Me._RegionID)

            With objEntAutConf
                Me.ConfiguracionCodigo = .Codigo
                Me.ConfiguracionDiaMaximo = .ConfiguracionDiaMaximo
                Me.ConfiguracionEnero = .ConfiguracionEnero
                Me.ConfiguracionFebrero = .ConfiguracionFebrero
                Me.ConfiguracionMarzo = .ConfiguracionMarzo
                Me.ConfiguracionAbril = .ConfiguracionAbril
                Me.ConfiguracionMayo = .ConfiguracionMayo
                Me.ConfiguracionJunio = .ConfiguracionJunio
                Me.ConfiguracionJulio = .ConfiguracionJulio
                Me.ConfiguracionAgosto = .ConfiguracionAgosto
                Me.ConfiguracionSetiembre = .ConfiguracionSetiembre
                Me.ConfiguracionOctubre = .ConfiguracionOctubre
                Me.ConfiguracionNoviembre = .ConfiguracionNoviembre
                Me.ConfiguracionDiciembre = .ConfiguracionDiciembre
                Me.ConfiguracionEstado = .EstadoID
            End With

        End Sub
#End Region
#Region "Validar Autorizacion"
        Private Function ValidarAutorizacionMesActivo(ByVal mesConsulta As Integer) As Boolean
            Dim value As Boolean = False
            Select Case mesConsulta
                Case 1
                    value = Me.ConfiguracionEnero
                Case 2
                    value = Me.ConfiguracionFebrero
                Case 3
                    value = Me.ConfiguracionMarzo
                Case 4
                    value = Me.ConfiguracionAbril
                Case 5
                    value = Me.ConfiguracionMayo
                Case 6
                    value = Me.ConfiguracionJunio
                Case 7
                    value = Me.ConfiguracionJulio
                Case 8
                    value = Me.ConfiguracionAgosto
                Case 9
                    value = Me.ConfiguracionSetiembre
                Case 10
                    value = Me.ConfiguracionOctubre
                Case 11
                    value = Me.ConfiguracionNoviembre
                Case 12
                    value = Me.ConfiguracionDiciembre
            End Select

            Return value
        End Function
#End Region
#Region "Form"
        Private Sub Form_Reporte()

            Dim frm As New Visita.Autorizacion.frmReportePopup
            With frm
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._InternoID = Me._InternoID
                ._InternoApeNom = Me._InternoApeNom
                ._VisibleBuscar = False
                ._EnabledTipoInterno = False
                .ShowDialog()
            End With

        End Sub
        Private Function FRM_Parentesco() As Type.Enumeracion.Parentesco.ParentescoGrupo

            Dim value As Type.Enumeracion.Parentesco.ParentescoGrupo = Type.Enumeracion.Parentesco.ParentescoGrupo.Ninguno

            Dim frm As New Visita.Autorizacion.frmParentescoPopup
            With frm
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    value = ._Tipo
                End If
            End With
            Return value

        End Function
        Private Sub FRM_AutorizacionNuevo()

            ' se adiciono el control de autorizacion por internos e.cu.cco. 27-08-2024
            Dim objBss As Bussines.Visita.Autorizacion = Nothing
            objBss = New Bussines.Visita.Autorizacion
            Dim objEnt As New Entity.Visita.Autorizacion
            With objEnt
                .Codigo = -1
                .InternoID = Me._InternoID
                .EstadoID = 1 'activo
                .TipoID = Type.Enumeracion.Visita.AutorizacionTipo.Autorizado
            End With
            'Me.ConfiguracionDiaMaximo
            If objBss.ValidarSumaVisitanteAutorizacionActivos(objEnt) >= Me.ConfiguracionDiaMaximo Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Superó el limite de visitantes autorizados, el máximo es de " & ConfiguracionDiaMaximo & " visitantes.")
                Exit Sub
            End If

            ' Validar si el interno es nuevo (no tiene ninguna visita), no valida la restriccion de meses
            If objBss.ValidarSumaVisitaPorInterno(objEnt) > 0 Then
                'validar si la fecha ingresada es segun programacion
                Dim xMes As Integer
                xMes = Legolas.Components.FechaHora.FechaMes(Legolas.LBusiness.Globall.DateTime.FechaServerLong) 'FechaDocumento)

                If ValidarAutorizacionMesActivo(xMes) = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                            "No es posible registrar las autorizaciones porque no está en el mes permitido")
                    Exit Sub
                End If
            Else
                ' no hace nada
            End If

            Dim intTipoParentesco As Type.Enumeracion.Parentesco.ParentescoGrupo = Type.Enumeracion.Parentesco.ParentescoGrupo.Familiares
            intTipoParentesco = FRM_Parentesco()

            If intTipoParentesco > 0 Then
                Dim frm As New Visita.Autorizacion.frmAutorizacionAddPopup
                With frm
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._InternoID = Me._InternoID
                    ._InternoApeNom = Me._InternoApeNom
                    ._TipoParentesco = intTipoParentesco
                    If .ShowDialog() = vbOK Then
                        ListarUsc()
                    End If
                End With
            End If

        End Sub
        Private Sub FRM_AutorizacionAnular()

            Dim frm As New Visita.Autorizacion.frmAutorizacionAnularPopup
            With frm
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._InternoID = Me._InternoID
                ._InternoApeNom = Me._InternoApeNom
                If .ShowDialog() = vbOK Then
                    ListarUsc()
                End If
            End With

        End Sub
        Private Sub FRM_AutorizacionUpdate(ByVal Codigo As Integer)

            Dim frm As New Visita.Autorizacion.frmAutorizacionPopup
            With frm
                ._Codigo = Codigo
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._InternoID = Me._InternoID
                ._InternoApeNom = Me._InternoApeNom
                If .ShowDialog() = vbOK Then
                    ListarUsc()
                End If
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub Usuario_Permisos()

            Me.pnlModificar.Visible = Me._FormEscritura
            Me.UscAutorizacion1._VisibleBotonAdd = Me._FormEscritura

            Me.pnlExportar.Visible = Me._FormReporte

        End Sub
        Private Sub ValoresxDefault()

            Usuario_Permisos()

            Me.lblEtapaNombre.Text = "Etapa : " & Me._InternoEtapa
            Me.lblPabellonNombre.Text = "Pabellon : " & Me._InternoPabellon
            ListarMant_Autorizacion()
        End Sub
#End Region

        Private Sub UscAutorizacion1__CellDoubleClick_Grilla(ByVal Codigo As Integer) Handles UscAutorizacion1._CellDoubleClick_Grilla

            FRM_AutorizacionUpdate(Codigo)

        End Sub
        Private Sub UscAutorizacion1__Click_Agregar() Handles UscAutorizacion1._Click_Agregar

            FRM_AutorizacionNuevo()

        End Sub

        Private Sub btnSalirBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalirBusqueda.Click

            Me.Close()

        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            UscAutorizacion1__Click_Agregar()

        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            UscAutorizacion1__CellDoubleClick_Grilla(Me.UscAutorizacion1._GrillaID)

        End Sub

        Private Sub frmAutorizacionMant_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmAutorizacionMant_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ListarUsc()

        End Sub

        Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click

            FRM_AutorizacionAnular()

        End Sub

        Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

            Me.UscAutorizacion1._ExportarGrilla()

        End Sub

        Private Sub UscAutorizacion1__Click_RadioButton_Estado() Handles UscAutorizacion1._Click_RadioButton_Estado

            ListarGrillaCount()

        End Sub

        Private Sub UscAutorizacion1__Click_RadioButton_Tipo() Handles UscAutorizacion1._Click_RadioButton_Tipo

            ListarGrillaCount()

        End Sub

        Private Sub UscAutorizacion1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UscAutorizacion1.Load

        End Sub

        Private Sub btnReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnReporte.Click

            Form_Reporte()

        End Sub
    End Class
End Namespace