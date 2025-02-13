Namespace Registro.Reporte


    Public Class frmReporteSiscrico
        Dim objBssInst As New Bussines.Sistema.Instalacion
#Region "propiedades"
        Private Property _RegionID() As Integer
            Get
                Return cbbRegion.SelectedValue
            End Get
            Set(value As Integer)
                cbbRegion.SelectedValue = value
            End Set
        End Property

        Private Property _PenalID() As Integer
            Get
                Return cbbPenal.SelectedValue
            End Get
            Set(value As Integer)
                cbbPenal.SelectedValue = value
            End Set
        End Property

        Private Property _TipoBandaId As Integer
            Get
                Return cbbTipoCrimOrg.SelectedValue
            End Get
            Set(value As Integer)
                cbbTipoCrimOrg.SelectedValue = value
            End Set
        End Property
        Private Property _TipoIntegranteOrgCrim() As Integer
            Get
                Return cbbTipoIntegrante.SelectedValue
            End Get
            Set(value As Integer)
                cbbTipoIntegrante.SelectedValue = value
            End Set
        End Property

#End Region
#Region "combo"
        Private Sub CarcarComboTipoIntegranteOrgCrim()
            With Me.cbbTipoIntegrante
                ._Todos = False
                .LoadUsc()
            End With
        End Sub
        Private Sub CargarComboTipoBanda()
            With Me.cbbBandaTipo
                ._Todos = True
                .LoadUsc()
                .SelectedValue = 2
            End With

            With Me.cbbTipoCrimOrg
                ._Todos = True
                .LoadUsc()
                .SelectedValue = 2
            End With

        End Sub

        Private Sub cargarComboRegion()

            Dim blnTodos As Boolean = False

            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1, 2
                    blnTodos = False
                Case 3
                    blnTodos = True
            End Select

            With Me.cbbRegion
                ._Todos = blnTodos
                .ComboTipo = Type.Combo.ComboTipo.RegionUsuario
                .Parametro1 = Legolas.Configuration.Usuario.Codigo
                .Parametro2 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With

        End Sub

        Private Sub cargarComboPenal()

            Dim blnTodos As Boolean = False

            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1
                    blnTodos = False
                Case 2, 3
                    blnTodos = True
            End Select

            With Me.cbbPenal
                ._Todos = blnTodos
                .ComboTipo = Type.Combo.ComboTipo.PenalUsuario
                .CodigoPadre = Me._RegionID
                .Parametro1 = Legolas.Configuration.Usuario.Codigo
                .Parametro2 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With

        End Sub
#End Region
#Region "otros"
        Private Sub ValoresxDefault()
            CargarComboTipoBanda()
            cargarComboRegion()
            cargarComboPenal()
            CarcarComboTipoIntegranteOrgCrim()
        End Sub
        Private Function getTipoSede() As Integer
            Return objBssInst.Listar(Configuracion.Licencia.Codigo).Tipo
            '1=penal
            '2=region
            '3=sede central
        End Function
        Private Sub muestraReporte()
            If rbPorBanda.Checked = True And cbbBandaTipo.SelectedValue = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione tipo de grupo criminal")
                Exit Sub
            End If
            Dim frm As New APPReporte.Registro.Siscrico.frmReporte
            With frm
                ._FormImpresion = Me._FormImpresion
                .RegionID = Me.cbbRegion.SelectedValue
                .PenalID = Me.cbbPenal.SelectedValue
                .TipoBandaId = Me._TipoBandaId
                If rbPorBanda.Checked = True Then
                    ._TipoReporte = Type.Reporte.Registro.rptGruposCrimenOrganizado
                    .TipoBandaId = Me.cbbBandaTipo.SelectedValue
                End If

                If rbIntBandAgrup.Checked = True Then 'integrantes por organiza crim ESPECIFICO
                    If Trim(txtBandaId.Text) = "" Or txtBandaId.Text = "[SELECCIONE]" Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Cargar los datos del grupo criminal")
                        Exit Sub
                    End If
                    .BandaId = Val(txtBandaId.Tag)
                    .NombreOrgCriminal = IIf(Trim(txtBandaId.Text) = "", "", " - " & txtBandaId.Text)
                    If rbIntegOrgCrim.Checked = True Then
                        If cbbRegion.Text = "[Todos]" Or cbbPenal.Text = "[Todos]" Then
                            If cbbRegion.Text = "[Todos]" And MsgBox("Tenga en cuenta que al filtrar por todas las regiones el proceso podria tardarse en completar la operación, desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
                                Exit Sub
                            End If
                            ._TipoReporte = Type.Reporte.Registro.rptIntPorGrupCrimOrg_X_Sede
                        Else
                            ._TipoReporte = Type.Reporte.Registro.rptIntPorGrupCrimOrg_X_Penal
                        End If
                    Else 'ficha de indentificacion

                        If (cbbRegion.Text = "[Todos]" Or cbbPenal.Text = "[Todos]") Then
                            If MsgBox("Tenga en cuenta que al filtrar por todas las regiones el proceso podria tardarse en completar la operación, desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
                                Exit Sub
                            End If
                        End If
                        ' Dim objBssIntBanda As New Bussines.Registro.InternoBanda
                        Dim objEntColIntBand As New Entity.Registro.InternoOrgCriminalCol
                        Dim objIntBand As New Entity.Registro.InternoOrgCriminal

                        objIntBand.BandaTipoID = Me._TipoBandaId
                        objIntBand.RegioID = Me._RegionID
                        objIntBand.PenalID = Me._PenalID
                        objIntBand.BandaID = Val(txtBandaId.Tag)
                        objEntColIntBand = (New Bussines.Registro.InternoOrgCriminal).ListarInternosConSiscrico(objIntBand)

                        Dim strIdInt As String = ""
                        For Each obj As Entity.Registro.InternoOrgCriminal In objEntColIntBand
                            strIdInt = obj.InternoID & "," & strIdInt
                        Next
                        If strIdInt.Length > 0 Then
                            strIdInt = Mid(strIdInt, 1, Len(strIdInt) - 1)
                            Me.Cursor = Cursors.WaitCursor

                            Dim frmFich As New APPReporte.Registro.Siscrico.frmReporteFichInterno(strIdInt)
                            Me.Cursor = Cursors.Default
                            frmFich._FormImpresion = Me._FormImpresion
                            frmFich.ShowDialog()
                        End If

                        Exit Sub
                    End If
                End If
                If rbIntBandComplet.Checked = True Then 'lista general de integrantes por organizacion crim
                    .BandaId = -1
                    If rbDetalle.Checked = True Then
                        If cbbRegion.Text = "[Todos]" Or cbbPenal.Text = "[Todos]" Then
                            If cbbRegion.Text = "[Todos]" And MsgBox("Tenga en cuenta que al filtrar por todas las regiones el proceso podria tardarse en completar la operación, desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
                                Exit Sub
                            End If
                            ._TipoReporte = Type.Reporte.Registro.rptIntPorGrupCrimOrg_X_Sede
                        Else
                            ._TipoReporte = Type.Reporte.Registro.rptIntPorGrupCrimOrg_X_Penal
                        End If
                    Else
                        ._TipoReporte = Type.Reporte.Registro.rptIntPorGrupCrimOrg_Resumen
                    End If
                End If
                If rbCabPorGrupCrim.Checked = True Then
                    ._TipoReporte = Type.Reporte.Registro.rptCabecillasGrupCrim
                    .BandaId = -1
                    .RegionID = Me._RegionID
                    .PenalID = Me._PenalID
                    .TipoIntegranteOrgCrim = Me._TipoIntegranteOrgCrim
                    .TipoBandaId = Me._TipoBandaId
                End If
                .ShowDialog()
            End With
        End Sub

        Private Sub cargarGrupoCriminal()
            Dim f As New Registro.Siscrico.frmBusquedaBanda
            f._RegionIdSel = cbbRegion.SelectedValue
            f._PenalIdSel = cbbPenal.SelectedValue
            f._InabilitarComboBanTip = True
            f._FiltrarTipoBandaPor = cbbTipoCrimOrg.SelectedValue
            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtBandaId.Text = f._BandaNomSel
                txtBandTipNom.Text = f._BandaTipNomSel
                txtBandaId.Tag = f._BandaIdSel
            End If
        End Sub
#End Region
        Private Sub frmReporteSiscrico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            ValoresxDefault()
        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged
            cargarComboPenal()
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
            muestraReporte()
        End Sub

        Private Sub rbIntBandAgrup_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbIntBandAgrup.CheckedChanged
            If rbIntBandAgrup.Checked = True Then
                pnlIntXGrup.Enabled = True
                Panel4.Enabled = False
                ' cbbTipoCrimOrg.Enabled = True
                cbbRegion.Enabled = True
                cbbPenal.Enabled = True
                gbIntXOrgCrimGen.Enabled = False
                cbbTipoIntegrante.Enabled = False
                GroupBox2.Enabled = True
                'cbbTipoCrimOrg.Enabled = True
            End If
        End Sub

        Private Sub rbPorBanda_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbPorBanda.CheckedChanged
            If rbPorBanda.Checked = True Then
                Panel4.Enabled = True
                pnlIntXGrup.Enabled = False
                txtBandTipNom.Text = ""
                GroupBox2.Enabled = False
                txtBandaId.Text = "[SELECCIONE]"
                'cbbTipoCrimOrg.Enabled = False
                cbbRegion.Enabled = False
                cbbTipoIntegrante.Enabled = False
                cbbPenal.Enabled = False
                gbIntXOrgCrimGen.Enabled = False
            End If
        End Sub

        Private Sub rbIntBandComplet_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbIntBandComplet.CheckedChanged
            If rbIntBandComplet.Checked = True Then
                pnlIntXGrup.Enabled = False
                txtBandTipNom.Text = ""
                txtBandaId.Text = "[SELECCIONE]"
                GroupBox2.Enabled = False
                'cbbTipoCrimOrg.Enabled = True
                Panel4.Enabled = False
                cbbRegion.Enabled = True
                cbbPenal.Enabled = True
                gbIntXOrgCrimGen.Enabled = True
                cbbTipoIntegrante.Enabled = False
                'cbbTipoCrimOrg.Enabled = True
            End If
        End Sub

        Private Sub btnCargarGrupCrim_Click(sender As System.Object, e As System.EventArgs) Handles btnCargarGrupCrim.Click
            cargarGrupoCriminal()
        End Sub

        Private Sub rbCabPorGrupCrim_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbCabPorGrupCrim.CheckedChanged
            If rbCabPorGrupCrim.Checked = True Then
                txtBandTipNom.Text = ""
                txtBandaId.Text = "[SELECCIONE]"
                GroupBox2.Enabled = False
                'cbbTipoCrimOrg.Enabled = True
                Panel4.Enabled = False
                pnlIntXGrup.Enabled = False
                cbbRegion.Enabled = True
                cbbPenal.Enabled = True
                gbIntXOrgCrimGen.Enabled = False
                cbbTipoIntegrante.Enabled = True
                'cbbTipoCrimOrg.Enabled = True
            End If
        End Sub



    End Class
End Namespace