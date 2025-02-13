Imports System.Windows.Forms
Namespace Registro.Penal.Identificacion.v5
    Public Class frmNombreAsociadoPopup_v2

        Private objBssDoc As Bussines.Registro.Documento.NombresAsociados = Nothing
        Public objEntDoc As Entity.Registro.Documento.NombresAsociados = Nothing

        Private objBss As Bussines.Registro.NombreAsociado = Nothing
        Public objEnt As Entity.Registro.NombreAsociado = Nothing
        Public objEntNombreAsociado As New Entity.Registro.Documento.NombresAsociados
        Public objEntNombreAsociadoCol As New Entity.Registro.Documento.NombresAsociadosCol

#Region "Propiedades"

        Public Property _PenalLM As Boolean = False
        Public Property _IngresoInpeID() As Integer = -1

        Public Property DocumentoJudicialID() As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property IngresoID() As Integer = -1
        Public Property Principal() As Integer
            Get
                Dim value As Integer = -1

                If Me.rdbPrincipal.Checked = True Then
                    value = 1
                End If

                If Me.rdbAsociado.Checked = True Then
                    value = 0
                End If

                Return value

            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case 1
                        Me.rdbPrincipal.Checked = True
                    Case 0
                        Me.rdbAsociado.Checked = True
                    Case Else
                        Me.rdbPrincipal.Checked = False
                        Me.rdbAsociado.Checked = False
                End Select
            End Set
        End Property
        Public Property ApellidoPaterno() As String
            Get
                Return Legolas.Components.Cadena.LimpiarEspacios(Me.txtApePaterno.Text.Trim)
            End Get
            Set(ByVal value As String)
                Me.txtApePaterno.Text = value
            End Set
        End Property
        Public Property ApellidoMaterno() As String
            Get
                Return Legolas.Components.Cadena.LimpiarEspacios(Me.txtApeMaterno.Text.Trim)
            End Get
            Set(ByVal value As String)
                Me.txtApeMaterno.Text = value
            End Set
        End Property
        Public Property Nombres() As String
            Get
                Return Legolas.Components.Cadena.LimpiarEspacios(Me.txtNombre.Text.Trim)
            End Get
            Set(ByVal value As String)
                Me.txtNombre.Text = value
            End Set
        End Property
        Public Property Estado() As Integer = 1
        Private Property PrincipalCopi() As Integer
        Public Property ApellidoPaternoCopi() As String
        Public Property ApellidoMaternoCopi() As String
        Public Property NombresCopi() As String
        Public _TipoFormulario As Integer = -1
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Private ReadOnly Property FlagTransferSede As Integer
            Get
                Dim v As Integer = 0
                If _TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                    v = 1
                End If
                Return v
            End Get
        End Property
        Public Property Accion() As Integer = -1
        Public Property Eliminacion As Boolean = False
#End Region
#Region "Propiedades_Par"
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Public Property _RegionID() As Integer
            Get
                Return intRegionID
            End Get
            Set(ByVal value As Integer)
                intRegionID = value
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
        Public Property _RadioEnablet As Boolean = False
        Public Property _Nuevobln As Boolean = False
        Public Property _ReferenciaEnablet As Boolean = False
        Public Property _Documentos_sin_mov As Boolean = False
#End Region
#Region "Listar"
        Public _TipoFormu As Boolean = False
        Public _TipoAcion As Integer = -1
        Public Sub ListarData()
            Dim DocJudicialId As Integer = -1
            Dim objEntNACol As New Entity.Registro.Documento.NombresAsociadosCol
            Dim objBss As New Bussines.Registro.NombreAsociado
            If Me.InternoID < 1 Then
                Exit Sub
            End If
            Dim objBss1 As New Bussines.Registro.Documento.NombresAsociados
            Dim objEnt As New Entity.Registro.Documento.NombresAsociados
            objEnt.InternoID = InternoID
            objEnt.IngresoID = IngresoID
            objEnt.IngresoInpeId = _IngresoInpeID
            objEnt.DocumentoJudicialID = DocJudicialId
            objEntNACol = objBss1.Listar2_LM(objEnt)
            For Each ent As Entity.Registro.Documento.NombresAsociados In objEntNombreAsociadoCol
                If ent.NAEstado = 2 And ent.Audit_Eliminado = False And ent.DocumentoJudicialID <> Me.DocumentoJudicialID Then
                    objEntNACol.Add(ent)
                ElseIf ent.ValorRef = True Then
                    For Each ob As Entity.Registro.Documento.NombresAsociados In objEntNACol
                        If Not (ob.ApellidosyNombres = ent.ApellidosyNombres2 And ob.NAPrincipal2 = ent.NAPrincipal2) Then
                            objEntNACol.Add(ent)
                            Exit For
                        End If
                    Next
                End If
            Next
            With Me.dgwNomAsoc
                .DataSource = ""
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = IIf(objEntNACol Is Nothing, Nothing, objEntNACol)
                .SelectedRows(0).Selected = False
            End With
            Me.grbNombreAso.Text = "Nombres Asociados " & objEntNACol.Count & " Reg."

            '    Me.UscAuditUser1.LoadAudit(objEntDocumen.InternoNombreAsociadoID, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoNombreAsociado)
        End Sub
        Private Sub InhabilitarControles()
            txtApePaterno.ReadOnly = True
            txtApeMaterno.ReadOnly = True
            txtNombre.ReadOnly = True
            gbTiponombre.Enabled = False
        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean
            '/*primer apellido*/
            If Me.ApellidoPaterno.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el Primer Apellido del Interno")
                Me.txtApePaterno.Focus()
                Return False
            End If
            '/*segundo apellido*/
            If Me.ApellidoMaterno.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el Segundo Apellido del Interno")
                Me.txtApeMaterno.Focus()
                Return False
            End If
            '/*nombres*/
            If Me.Nombres.Trim.Length < 2 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el nombre asociado del Interno")
                Me.txtNombre.Focus()
                Return False
            End If
            If Me.Principal < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el tipo de nombre asociado")
                Return False
            End If
            If Me.Accion = 1 Then

                If Me.dgwNomAsoc.SelectedRows(0).Cells("col_ape_pat").Value = Me.ApellidoPaterno And
                    Me.dgwNomAsoc.SelectedRows(0).Cells("col_ape_mat").Value = Me.ApellidoMaterno And
                    Me.dgwNomAsoc.SelectedRows(0).Cells("col_nom").Value = Me.Nombres And
                     Me.dgwNomAsoc.SelectedRows(0).Cells("col_prin").Value = Me.Principal Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El nombre asociado no ha sido modificado")
                    Return False
                End If
            End If
            Return True
        End Function
        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            Dim intValue As Integer = -1

            objBss = New Bussines.Registro.NombreAsociado
            objEntDoc = New Entity.Registro.Documento.NombresAsociados


            objEntDoc.InternoID = Me.InternoID
            objEntDoc.NANombres = Me.Nombres
            objEntDoc.NAPaterno = Me.ApellidoPaterno
            objEntDoc.NAMaterno = Me.ApellidoMaterno
            objEntDoc.NAEstado = Me.Estado
            objEntDoc.NAPrincipal = Me.Principal

            objEnt = New Entity.Registro.NombreAsociado

            'If Me.DocumentoJudicialID > -1 Then
            '    If objEntDoc.Codigo = -1 Then
            With objEnt
                .Codigo = Me.Codigo
                .InternoID = Me.InternoID
                .Principal = Me.Principal
                .ApellidoPaterno = Me.ApellidoPaterno
                .ApellidoMaterno = Me.ApellidoMaterno
                .Nombres = Me.Nombres
                .Estado = Me.Estado
                .DocumentoJudicialID = Me.DocumentoJudicialID
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            'intValue = objBss.GrabarNA2(objEnt)

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub
        Private Sub CargarNombreAsociado()
            objEntDoc = New Entity.Registro.Documento.NombresAsociados
            With objEntDoc
                If Accion = 1 Then 'aclarado
                    Dim bln As Boolean = False
                    If Me._Nuevobln = True Then
                        For Each ent As Entity.Registro.Documento.NombresAsociados In objEntNombreAsociadoCol
                            If ent.ValorRef = True Then
                                bln = True
                                Exit For
                            End If
                        Next
                    Else
                        For Each ent As Entity.Registro.Documento.NombresAsociados In objEntNombreAsociadoCol
                            If ent.InternoNombreAsociadoID = Me.Codigo And ent.NAEstado = 2 Then
                                bln = True
                                Exit For
                            End If
                        Next
                    End If

                    .InternoNombreAsociadoID = dgwNomAsoc.SelectedRows(0).Cells("col_int_nom_aso_id").Value
                    If bln = False Then
                        .NAEstado = Accion
                        .NAPrincipal = dgwNomAsoc.SelectedRows(0).Cells("col_prin").Value
                        .NAPaterno = dgwNomAsoc.SelectedRows(0).Cells("col_ape_pat").Value
                        .NAMaterno = dgwNomAsoc.SelectedRows(0).Cells("col_ape_mat").Value
                        .NANombres = dgwNomAsoc.SelectedRows(0).Cells("col_nom").Value
                        .NAPrincipal2 = If(rdbPrincipal.Checked = True, 1, 0)
                        .NAPaterno2 = Me.ApellidoPaterno
                        .NAMaterno2 = Me.ApellidoMaterno
                        .NANombres2 = Me.Nombres
                    Else
                        .NAPrincipal = -1
                        .NAPaterno = ""
                        .NAMaterno = ""
                        .NANombres = ""
                        .NAPrincipal2 = If(rdbPrincipal.Checked = True, 1, 0)
                        .NAPaterno2 = Me.ApellidoPaterno
                        .NAMaterno2 = Me.ApellidoMaterno
                        .NANombres2 = Me.Nombres
                        .EstadoAccion = 2
                        Accion = 2
                    End If
                ElseIf Accion = 2 Then 'Añadido
                    .InternoNombreAsociadoID = -1
                    .NAPrincipal2 = If(rdbPrincipal.Checked = True, 1, 0)
                    .NAPaterno2 = Me.ApellidoPaterno
                    .NAMaterno2 = Me.ApellidoMaterno
                    .NANombres2 = Me.Nombres
                    .NAEstado = Accion
                    .ValorRef = True
                    .EstadoAccion = 1
                End If
            End With
        End Sub

#End Region
#Region "usuarios_Permisos"
        Private Sub UsuarioPermisos()
            Me.btnAgregar.Visible = Me._FormEscritura

            btnCancelar.Text = "&Modificar"
            btnCancelar.Image = SIPPOPE.My.Resources._1277961326_folder_edit


            Me.Panel4.Visible = Me._FormEscritura

        End Sub
#End Region
#Region "Otros"
        Public Sub _VisibleRadioButonNombresAsociados()
            'gbTiponombre.Enabled = True
        End Sub
#End Region
        Private Sub frmNombreAsociadoPopup2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            grbNombreAso.Visible = True
            grbNombres.Visible = False
            Panel1.Visible = True
            Panel11.Visible = False
            pnlSalir.Visible = True
            Panel4.Visible = True
            btnAgregar.Visible = True
        End Sub
        Private Sub frmNombreAsociadoPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            UsuarioPermisos()
            ListarData()

        End Sub


        Public Sub New(ByRef objEntNomAsoc As Entity.Registro.Documento.NombresAsociados)
            InitializeComponent()
            objEntDoc = objEntNomAsoc
        End Sub

        Private Sub rdbAsociado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbAsociado.CheckedChanged

        End Sub



        Private Sub rdbPrincipal_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles rdbPrincipal.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub rdbAsociado_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles rdbAsociado.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
            If btnAgregar.Text = "&Agregar" Then
                grbNombres.Visible = True
                grbNombreAso.Visible = False
                Me.Accion = 2
                btnAgregar.Text = "&Grabar"
                btnCancelar.Text = "&Cancelar"
                btnCancelar.Image = SIPPOPE.My.Resources.Resources.anular2
                Me.Text = "AGREGAR NOMBRE ASOCIADO"
                txtApePaterno.Focus()
            ElseIf btnAgregar.Text = "&Grabar" Then
                If Validar() = True Then
                    CargarNombreAsociado()
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If
        End Sub
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            If btnCancelar.Text = "&Cancelar" Then
                If Accion = 1 Then
                    If Me.dgwNomAsoc.SelectedRows.Count = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un Nombre asociado.")
                        Exit Sub
                    End If
                    grbNombres.Visible = True
                    grbNombreAso.Visible = False
                    Me.Codigo = dgwNomAsoc.SelectedRows(0).Cells("col_int_nom_aso_id").Value
                    txtApePaterno.Text = dgwNomAsoc.SelectedRows(0).Cells("col_ape_pat").Value
                    txtApeMaterno.Text = dgwNomAsoc.SelectedRows(0).Cells("col_ape_mat").Value
                    txtNombre.Text = dgwNomAsoc.SelectedRows(0).Cells("col_nom").Value
                    If dgwNomAsoc.SelectedRows(0).Cells("col_nom_prin").Value = True Then
                        rdbPrincipal.Checked = True
                    Else
                        rdbPrincipal.Checked = False
                    End If
                Else Accion = 2
                    txtApePaterno.Text = ""
                    txtApeMaterno.Text = ""
                    txtNombre.Text = ""
                    rdbPrincipal.Checked = False
                End If
            Else
                If Me.dgwNomAsoc.SelectedRows.Count = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un Nombre asociado.")
                    Exit Sub
                End If
                grbNombres.Visible = True
                grbNombreAso.Visible = False
                With Me.dgwNomAsoc
                    Me.Codigo = .SelectedRows(0).Cells("col_int_nom_aso_id").Value
                    If Len(.SelectedRows(0).Cells("col_ape_pat").Value) = 0 Then
                        txtApePaterno.Text = .SelectedRows(0).Cells("col_ape_pat2").Value
                        txtApeMaterno.Text = .SelectedRows(0).Cells("col_ape_mat2").Value
                        txtNombre.Text = .SelectedRows(0).Cells("col_nom2").Value
                        rdbPrincipal.Checked = If(.SelectedRows(0).Cells("col_prin2").Value = True, True, False)
                    Else
                        txtApePaterno.Text = .SelectedRows(0).Cells("col_ape_pat").Value
                        txtApeMaterno.Text = .SelectedRows(0).Cells("col_ape_mat").Value
                        txtNombre.Text = .SelectedRows(0).Cells("col_nom").Value
                        rdbPrincipal.Checked = If(.SelectedRows(0).Cells("col_prin").Value = 1, True, False)
                    End If
                End With
                Accion = 1
                btnAgregar.Text = "&Grabar"
                btnCancelar.Text = "&Cancelar"
                btnCancelar.Image = SIPPOPE.My.Resources.Resources.anular2
                Me.Text = "MODIFICAR NOMBRE ASOCIADO"
            End If
        End Sub
        Private Sub dgwNomAsoc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwNomAsoc.CellContentClick
            With Me.dgwNomAsoc
                If e.RowIndex >= 0 Then
                    If .Columns(e.ColumnIndex).Name = "col_img" Then
                        If (dgwNomAsoc.SelectedRows(0).Cells("col_doc_jud_id").Value = Me.DocumentoJudicialID And dgwNomAsoc.SelectedRows(0).Cells("col_doc_jud_id").Value > 0) Or
                           (dgwNomAsoc.SelectedRows(0).Cells("col_codigo").Value = -1 And Me.DocumentoJudicialID = -1 And Accion > -1) Then
                            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar() = DialogResult.Yes Then
                                For Each ent As Entity.Registro.Documento.NombresAsociados In objEntNombreAsociadoCol
                                    If ent.InternoNombreAsociadoID = dgwNomAsoc.SelectedRows(0).Cells("col_int_nom_aso_id").Value Then
                                        ent.Audit_Eliminado = True
                                        Exit For
                                    End If
                                Next
                                Eliminacion = True
                                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                                Me.Close()
                            End If
                        ElseIf dgwNomAsoc.SelectedRows(0).Cells("col_int_nom_aso_id").Value < 1 And Accion > -1 Then
                            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar() = DialogResult.Yes Then
                                Dim indice As Integer = -1
                                For Each ent As Entity.Registro.Documento.NombresAsociados In objEntNombreAsociadoCol
                                    indice += 1
                                    If ent.NAPaterno2 = dgwNomAsoc.SelectedRows(0).Cells("col_ape_pat2").Value And
                                   ent.NAMaterno2 = dgwNomAsoc.SelectedRows(0).Cells("col_ape_mat2").Value And
                                   ent.NANombres2 = dgwNomAsoc.SelectedRows(0).Cells("col_nom2").Value And
                                   ent.NAPrincipal2 = dgwNomAsoc.SelectedRows(0).Cells("col_prin2").Value Then
                                        objEntNombreAsociadoCol.RemoveAt(indice)
                                        Exit For
                                    End If
                                Next
                                Eliminacion = True
                                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                                Me.Close()
                            End If
                        Else
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Este nombre asociado no puede ser eliminado, porque no ha sido generado por este documento.")
                        End If
                    End If
                End If
            End With
        End Sub
    End Class
End Namespace