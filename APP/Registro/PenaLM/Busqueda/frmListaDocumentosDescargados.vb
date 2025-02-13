Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.TipoDocJudicial
Imports Type.Enumeracion.Usuario
Namespace Registro
    Public Class frmListaDocumentosDescargados
        Public _MdiParenAux As MDIParent1
        Public PerfilUsuarioId As Integer = -1
        Private objBss As New Bussines.Registro.DocumentosDescarga
#Region "Propiedades_Parametricas"

        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
        Public Property _RegionID As Integer = -1
        Public Property _PenalID As Integer = -1
        Public Property _InternoID As Integer = -1
        Private objEntCol As New Entity.Registro.DocumentoDescargaCol
#End Region
#Region "Listar"

        Private Sub ListarDocumentosDescargados()
            Dim obj As New Entity.Registro.DocumentoDescarga

            obj.InternoId = Me._InternoID
            obj.DocumentoTipo = 1
            objEntCol = objBss.ListarDocumentosDescargados(obj)

            With Me.dgwDocumentosDescargados
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
                lblRegistros.Text = objEntCol.Count & "  Registros"
            End With
        End Sub
        Private Sub ListarDocumentosFallidos()
            Dim obj As New Entity.Registro.DocumentoDescarga
            Dim objCol As New Entity.Registro.DocumentoDescargaCol
            obj.InternoId = Me._InternoID
            obj.DocumentoTipo = 0
            objEntCol = objBss.ListarDocumentosDescargados(obj)
            For Each ob As Entity.Registro.DocumentoDescarga In objEntCol
                If ob.DocumentoFecha > 0 Then
                    objCol.Add(ob)
                End If
            Next

            With Me.dgwDocumentosFallidos
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objCol
                lblRegistros.Text = objCol.Count & "  Registros"
            End With
        End Sub
        Private Sub ListarArchivosFallidos()
            Dim obj As New Entity.Registro.DocumentoDescarga

            obj.InternoId = Me._InternoID
            obj.DocumentoTipo = 0
            objEntCol = objBss.ListarDocumentosDescargados(obj)

            With Me.dgwArchivosTotales
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
                lblRegistros.Text = objEntCol.Count & "  Registros"
            End With
        End Sub

        Private Sub frmListaDelitosHistoricos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If Me.PerfilUsuarioId <> 3 Then
                TabControl1.Controls.Remove(tbpFichaTotal)
            End If
            ListarDocumentosDescargados()
        End Sub

        Private Sub FRM_InternoDetalle()
            Dim intIDInterno As Integer = -1
            If dgwDocumentosDescargados.CurrentRow IsNot Nothing Then
                intIDInterno = dgwDocumentosDescargados.SelectedRows(0).Cells("col_int_id").Value
            Else
                Exit Sub
            End If


            Dim objEntUsuarioModuloCol As New Legolas.LEntity.Seguridad.UsuarioModuloCol
            Dim objBss As New Legolas.LBusiness.Seguridad.UsuarioModulo

            Dim intPenalTipoLicencia As Short = -1
            Dim intModulo As Short = -1

            Dim objBssPenal As New Bussines.General.Penal
            intPenalTipoLicencia = objBssPenal.fnTipoLicencia(40)

            Select Case intPenalTipoLicencia


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
                        ._IDInterno = intIDInterno
                        ._FormLectura = blnLectura
                        ._FormEscritura = blnEscritura
                        ._FormReporte = blnReporte
                        ._FormEliminar = blnEliminar
                        .MdiParent = Me._MdiParenAux ' Me.MdiParent
                        ._blnFormAux = True
                        .Show()
                    End With

            End Select

            Me.Hide()
        End Sub

        Private Sub btnDetalleInterno_Click(sender As Object, e As EventArgs) Handles btnDetalleInterno.Click
            FRM_InternoDetalle()
        End Sub

        Private Sub dgwAgraviado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwDocumentosDescargados.CellDoubleClick
            FRM_InternoDetalle()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub


        Private Sub dgwDocumentosDescargados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwDocumentosDescargados.CellClick
            If e.RowIndex = -1 Then Exit Sub
            If dgwDocumentosDescargados.Columns(e.ColumnIndex).Name = "col_mar_lei" Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("El siguiente documento contiene delitos que" + Chr(13) +
                                                                              "podrian ser seleccionados para DMP y SMP" + Chr(13) +
                                                                              "" + Chr(13) +
                                                                              "Si acepta se registrara como verificado") = DialogResult.Yes Then
                    Dim obj As New Entity.Registro.DocumentoDescarga
                    Dim bss As New Bussines.Registro.DocumentosDescarga
                    obj.Codigo = dgwDocumentosDescargados.SelectedRows(0).Cells("col_des_cod").Value

                    bss.Grabar_Descarga(obj)
                    ListarDocumentosDescargados()
                End If
            End If
        End Sub

        Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
            If TabControl1.SelectedIndex = 0 Then
                btnDetalleInterno.Visible = True
                ListarDocumentosDescargados()
            ElseIf TabControl1.SelectedIndex = 1 Then
                btnDetalleInterno.Visible = False
                ListarDocumentosFallidos()
            Else
                btnDetalleInterno.Visible = False
                ListarArchivosFallidos()
            End If
        End Sub


        Private Sub dgwDocumentosFallidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwDocumentosFallidos.CellClick
            ' dgwDocumentosDescargados_CellContentClick(Nothing, Nothing)
            If e.RowIndex = -1 Then Exit Sub
            If dgwDocumentosFallidos.Columns(e.ColumnIndex).Name = "col_fal_mar_lei" Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("El siguiente archivo contiene datos incorrectos" + Chr(13) +
                                                                              "deteniendo la descarga de la data del interno." + Chr(13) +
                                                                              "" + Chr(13) +
                                                                              "Si acepta se registrara como verificado") = DialogResult.Yes Then
                    Dim obj As New Entity.Registro.DocumentoDescarga
                    Dim bss As New Bussines.Registro.DocumentosDescarga
                    obj.Codigo = dgwDocumentosDescargados.SelectedRows(0).Cells("col_des_cod").Value

                    bss.Grabar_Descarga(obj)
                    ListarDocumentosDescargados()
                End If
            End If
        End Sub

        Private Sub dgwArchivosTotales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwArchivosTotales.CellClick
            If e.RowIndex = -1 Then Exit Sub
            If dgwArchivosTotales.Columns(e.ColumnIndex).Name = "col_mar_lei_arc" Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("El siguiente registro posee archivos por regularizar." + Chr(13) +
                                                                              "" + Chr(13) +
                                                                              "Si acepta se registrara como verificado") = DialogResult.Yes Then
                    Dim obj As New Entity.Registro.DocumentoDescarga
                    Dim bss As New Bussines.Registro.DocumentosDescarga
                    obj.Codigo = dgwArchivosTotales.SelectedRows(0).Cells("col_des_cod_arc").Value

                    bss.Grabar_Descarga(obj)
                    ListarArchivosFallidos()
                End If
            End If
        End Sub

        Private Sub frmListaDocumentosDescargados_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        End Sub

#End Region


    End Class
End Namespace