Imports Type.Enumeracion.Licencia

Namespace Registro.Siscrico.Bandas
    Public Class frmInternoBandaPopupV2
        'Private objBss As Bussines.Registro.InternoBanda = Nothing 
        Private objBss As Bussines.Registro.InternoOrgCriminal = Nothing
        Private objEnt As Entity.Registro.InternoOrgCriminal = Nothing
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property InternoIngresoNro() As String = ""
        Public Property InternoID() As Integer = -1
        Private Property InternoIngresoID() As Integer = -1

        Private Property BandaTipoID() As Integer
            Get
                Try
                    Return Me.cbbBandaTipo.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbBandaTipo.SelectedValue = value
            End Set
        End Property
        Private Property BandaID() As Integer
            Get
                Try
                    Return Me.cbbBanda.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try

            End Get
            Set(ByVal value As Integer)
                Me.cbbBanda.SelectedValue = value
            End Set
        End Property
        Private Property BandaMiembroTipoID() As Integer
            Get
                Try
                    Return Me.cbbBandaMiembroTipo.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try

            End Get
            Set(ByVal value As Integer)
                Me.cbbBandaMiembroTipo.SelectedValue = value
            End Set
        End Property
        Private Property DocJudIDCreacion() As Integer = -1
        Private Property DocJudIDAnulacion() As Integer = -1
        Private Property Observacion() As String
            Get
                Return Me.txtobservacion.Text
            End Get
            Set(ByVal value As String)
                Me.txtobservacion.Text = value
            End Set
        End Property
        Public Property _NroIngresoID() As Integer = -1
        Public Property _IngresoInpeID() As Integer = -1
        Public Property TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
#End Region
#Region "Propiedades_Otros"
        ' Public Property _PenalLM As Boolean = False

        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _VisibleGrabar() As Boolean
            Get
                Return Me.btnGrabar.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.btnGrabar.Visible = value
            End Set
        End Property
        Private Sub UsuarioPermisos()
            Me.btnGrabar.Visible = Me._FormEscritura
        End Sub
#End Region
#Region "Combo"

        Private Sub ComboBanda()

            With Me.cbbBanda
                .CodigoPadre = 2 'mostrar solo organizaciones criminales
            End With
            If Me.Codigo < 1 Then
                Me.BandaID = -1
            End If
            Me.cbbBanda.LoadUsc()
        End Sub
        Private Sub ComboBandaTipo()
            Me.cbbBandaTipo.LoadUsc()
            If Me.Codigo < 1 Then
                Me.BandaTipoID = 2
            End If
            ComboBanda()
            cbbBandaTipo.Enabled = False
        End Sub
        Private Sub ComboBandaMiembroTipo()
            Me.cbbBandaMiembroTipo.LoadUsc()
            If Me.Codigo < 1 Then
                Me.BandaMiembroTipoID = -1
            End If
        End Sub
#End Region
#Region "Listar"
        Private Sub Listar()

            If Me.Codigo < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Registro.InternoOrgCriminal
            objEnt = New Entity.Registro.InternoOrgCriminal

            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objEnt = objBss.Listar_LM(Me.Codigo)
            Else
                objEnt = objBss.Listar2(Me.Codigo)
            End If

            With objEnt
                Me._NroIngresoID = objEnt.IngresoID
                Me._IngresoInpeID = objEnt.IngresoInpeID
                Me.Codigo = .Codigo
                Me.InternoID = .InternoID
                Me.BandaTipoID = 2 ' .BandaTipoID
                Me.BandaID = .BandaID
                Me.BandaMiembroTipoID = .BandaMiembroTipoID
                Me.Observacion = .Observacion
            End With

            If objEnt.DocJudicialID_Anula > 0 Then
                tpDocNulidad.Parent = TabControl1
                Me.DocJudIDAnulacion = objEnt.DocJudicialID_Anula
            Else
                tpDocNulidad.Parent = Nothing
            End If

            uscDocJudCrea._DocumentoJudicialID = objEnt.DocJudicialID_Crea
            uscDocJudCrea._ListarDocJudicial()

            uscDocJudAnula._DocumentoJudicialID = objEnt.DocJudicialID_Anula
            uscDocJudAnula._ListarDocJudicial()

            Me.UscAuditUser1.LoadAudit(Me.Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Internobanda)
        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True

            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                If Me._IngresoInpeID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar número de ingreso, no se ha enviado el parametro")
                    blnValue = False
                    Return blnValue
                End If
            Else
                If Me._NroIngresoID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar número de ingreso, no se ha enviado el parametro")
                    blnValue = False
                    Return blnValue
                End If
            End If
            
            If Me.BandaTipoID < 1 Then
                MessageBox.Show("Seleccione un Tipo de Organización", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.cbbBandaTipo.Focus()
                Return blnValue
            End If

            'banda y/o organizacion
            If Me.BandaID < 1 Then
                MessageBox.Show("Seleccione el nombre de una Organización", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.cbbBanda.Focus()
                Return blnValue
            End If

            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                 Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                 Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                Dim entCol As New Entity.Registro.InternoOrgCriminalCol
                objEnt = New Entity.Registro.InternoOrgCriminal
                With objEnt
                    .InternoID = Me.InternoID
                    .IngresoInpeID = Me._IngresoInpeID
                    '.IngresoID = Me._NroIngresoID
                    .BandaTipoID = Me.BandaTipoID
                    .BandaID = Me.BandaID
                    '.BandaMiembroTipoID = Me.BandaMiembroTipoID
                    .Estado = 1 'solo activos
                End With

                entCol = (New Bussines.Registro.InternoOrgCriminal).Listar_LM(objEnt)

                If entCol.Count > 0 And Me.BandaTipoID <> 2 Then 'diferente de [NO INDICA]
                    If Me.Codigo = -1 Then 'nuevo
                        MessageBox.Show("El interno ya se encuentra registrado en el grupo " & cbbBanda.Text, Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Function
                    Else 'modificacion
                        For Each obj As Entity.Registro.InternoOrgCriminal In entCol
                            If obj.Codigo <> Me.Codigo Then
                                MessageBox.Show("El interno ya se encuentra registrado en el grupo " & cbbBanda.Text, Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Function
                            End If
                        Next
                    End If
                End If

            End If

            Return blnValue

        End Function
        Private Sub AGrabar()

            Dim objBssInt As New Bussines.Registro.Interno
            Dim objEntInt As Entity.Registro.Interno

            Dim intValue As Integer = -1
            If Validar() = False Then
                Exit Sub
            End If

            objBss = New Bussines.Registro.InternoOrgCriminal
            objEnt = New Entity.Registro.InternoOrgCriminal


            


            If Me.Codigo > 0 Then 'para edicion
                If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                    Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                    Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    'Dim objEntTmp As New Entity.Registro.InternoOrgCriminal
                    'objEntTmp.Codigo = Me.Codigo
                    objEnt = objBss.Listar_LM(Me.Codigo) '.OrganizacionCriminal(0)
                Else
                    objEnt = objBss.Listar(Me.Codigo)
                End If
            End If

            objEntInt = objBssInt.Listar_v5(Me.InternoID) 'cargar datos del interno

            With objEnt
                .BandaNombre = cbbBanda.Text
                .ApePatInterno = objEntInt.ApellidoPaterno
                .ApeMatInterno = objEntInt.ApellidoMaterno
                .NombresInterno = objEntInt.Nombres
                .InternoID = Me.InternoID
                .IngresoInpeID = Me._IngresoInpeID
                .IngresoID = Me._NroIngresoID
                .BandaTipoID = Me.BandaTipoID
                .BandaID = Me.BandaID
                .BandaMiembroTipoID = Me.BandaMiembroTipoID
                .Observacion = Me.Observacion
                .RegioID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            If Me.Codigo < 1 Then 'nuevo
                With Me.uscDocJudCrea
                    ._TipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Siscrico
                    ._DocumentoJudicialID = -1
                    ._InternoID = Me.InternoID
                    .TipoLicencia = Me.TipoLicencia
                    ._IngresoID = Me._NroIngresoID
                    ._IngresoInpeID = Me._IngresoInpeID
                    ._RegionID = Me._RegionID
                    ._Penal = Me._PenalID
                    ._Version = True
                    Me.DocJudIDCreacion = ._GuardarDocJud()
                End With

                If Me.DocJudIDCreacion > 0 Then
                    objEnt.Codigo = -1
                    objEnt.Estado = 1 '--ACTIVO
                    objEnt.DocJudicialID_Crea = Me.DocJudIDCreacion
                    objEnt.RegioID = Me._RegionID
                    objEnt.PenalID = Me._PenalID

                    If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                        Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                        Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        objEnt.IngresoID = -1
                        intValue = objBss.Grabar_LM(objEnt)
                    Else
                        intValue = objBss.Grabar2(objEnt)
                    End If
                Else
                    Exit Sub
                End If
            Else 'editar
                uscDocJudCrea._InternoID = Me.InternoID
                uscDocJudCrea._IngresoID = Me._NroIngresoID
                uscDocJudCrea._IngresoInpeID = Me._IngresoInpeID
                uscDocJudCrea.TipoLicencia = Me.TipoLicencia
                uscDocJudCrea._DocumentoJudicialID = objEnt.DocJudicialID_Crea
                uscDocJudCrea._RegionID = Me._RegionID
                uscDocJudCrea._Penal = Me._PenalID
                uscDocJudCrea._Version = True
                If uscDocJudCrea._GuardarDocJud() = -1 Then
                    Exit Sub
                End If

                'si el registro se encuentra anulado
                uscDocJudAnula._DocumentoJudicialID = objEnt.DocJudicialID_Anula

                If objEnt.DocJudicialID_Anula > 0 Then
                    uscDocJudAnula._DocumentoJudicialID = objEnt.DocJudicialID_Anula
                    uscDocJudAnula._IngresoInpeID = Me._IngresoInpeID
                    uscDocJudAnula.TipoLicencia = Me.TipoLicencia
                    uscDocJudAnula._InternoID = Me.InternoID
                    uscDocJudAnula._RegionID = Me._RegionID
                    uscDocJudAnula._IngresoID = Me._NroIngresoID
                    uscDocJudAnula._Penal = Me._PenalID
                    uscDocJudAnula._Version = True
                    DocJudIDAnulacion = uscDocJudAnula._GuardarDocJud
                End If
                If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                    Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                    Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    objEnt.IngresoID = -1
                    intValue = objBss.Grabar_LM(objEnt)
                Else
                    intValue = objBss.Grabar2(objEnt)
                End If



            End If

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub
#End Region
#Region "Form"
        Private Function FRMDocumentoJudicial() As Integer

            Dim frm As New Registro.Documento.frmDocJudicial
            With frm
                ._FormText = "Datos del Documento - Justificación Banda y/o Organización"
                '._RegionID = Me._RegionID
                '._PenalID = Me._PenalID
                ._TipoDocumentoJudicial = 1
                ._FormEscritura = Me._FormEscritura
                ._FormLectura = Me._FormLectura
                ._Vesion = True
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.DocJudIDCreacion = ._DocumentoJudicialID
                End If
            End With

            Return Me.DocJudIDCreacion

        End Function
#End Region
#Region "Otros"

        Private Sub ValoresxDefault()
            'ComboNumIngreso()
            ComboBandaTipo()
            ComboBandaMiembroTipo()

            With Me.uscDocJudCrea
                ._TipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Siscrico
                ._RegionID = Me._RegionID
                ._Penal = Me._PenalID
                ._LoadValorxDefault()                
            End With

            Me.uscDocJudAnula._TipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Siscrico
            Me.uscDocJudAnula._RegionID = Me._RegionID
            Me.uscDocJudAnula._Penal = Me._PenalID
            Me.uscDocJudAnula._LoadValorxDefault()
            Listar()
            If Me.Codigo = -1 Then
                tpDocNulidad.Parent = Nothing 'ocultar ficha si es nuevo
            End If
        End Sub

#End Region
#Region "Eventos_Formulario"
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub
        Private Sub btnGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabar.Click
            AGrabar()
        End Sub
        Private Sub frmInternoBandaPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
            UsuarioPermisos()
        End Sub
        Private Sub cbbBandaTipo__ValueChanged() Handles cbbBandaTipo._SelectedIndexChanged
            ComboBanda()
        End Sub
        Private Sub frmInternoBandaPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

        End Sub

#End Region

        Private Sub txtobservacion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtobservacion.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub
    End Class
End Namespace


