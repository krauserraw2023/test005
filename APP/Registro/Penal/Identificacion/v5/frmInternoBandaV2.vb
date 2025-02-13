Imports Type.Enumeracion.Licencia

Namespace Registro.Identificacion
    Public Class frmInternoBandaV2
        Private objBss As Bussines.Registro.InternoBanda = Nothing
        Public objEntCol As New Entity.Registro.InternoBandaCol
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property _NroIngresoID() As Integer = -1
        Public Property _NroIngresoInpeID As Integer = -1
        Private Property BandaTipoID() As Integer = -1
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
        Private Property Observacion() As String
            Get
                Return Me.txtobservacion.Text
            End Get
            Set(ByVal value As String)
                Me.txtobservacion.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Otros"
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
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
                .CodigoPadre = 1 'mostrar solo bandas
                Me.BandaTipoID = 1
            End With
            Me.cbbBanda.LoadUsc()
        End Sub

#End Region
#Region "Listar"
        Private Sub Listar()

            If Me.Codigo < 1 Then Exit Sub

            objBss = New Bussines.Registro.InternoBanda
            Dim objEntol As New Entity.Registro.InternoBandaCol
            Dim objEnt As New Entity.Registro.InternoBanda

            objEnt.Codigo = Me.Codigo

            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objEnt = objBss.Listar_LM(Me.Codigo)
            Else
                objEnt.IngresoID = Me._NroIngresoID
                objEnt = objBss.Listar2(objEnt).InternoBanda(0)
            End If

            With objEnt
                Me.Codigo = .Codigo
                Me.InternoID = .InternoID
                Me._NroIngresoInpeID = .IngresoInpeID
                Me._NroIngresoID = .IngresoID
                Me.BandaID = .BandaID
                Me.Observacion = .Observacion
            End With

            Me.UscAuditUser1.LoadAudit(Me.Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.reg_mov_internobanda)

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True
            'tipo de banda
            If Me.TipoLicencia = enmTipoLicencia.Carceleta Or _
                Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or _
                Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                If Me._NroIngresoInpeID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar número de ingreso, no se ha enviado el parametro")
                    blnValue = False
                    'Me.cbbNroIngresos.Focus()
                    Return blnValue
                End If
            Else
                If Me._NroIngresoID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar número de ingreso, no se ha enviado el parametro")
                    blnValue = False
                    'Me.cbbNroIngresos.Focus()
                    Return blnValue
                End If
            End If


            'banda y/o organizacion
            If Me.BandaID < 1 Then
                MessageBox.Show("Seleccione el nombre de la banda", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.cbbBanda.Focus()
                Return blnValue
            End If

            'valida que el interno no este registrado con el mismo tipo
            Dim Val As Boolean = False
            If Me.TipoLicencia <> enmTipoLicencia.Carceleta And Me.TipoLicencia <> enmTipoLicencia.PenalLimaMetropolitana Then
                If objEntCol.Count > 0 Then
                    For Each ent As Entity.Registro.InternoBanda In objEntCol
                        If Me.Codigo < 1 Then
                            If Me._NroIngresoID = ent.IngresoID And ent.BandaID = Me.BandaID Then
                                Val = True
                                Exit For
                            End If
                        Else
                            If Me._NroIngresoID = ent.IngresoID And Me.Codigo <> ent.Codigo And (ent.BandaID = Me.BandaID) Then
                                Val = True
                                Exit For
                            End If
                        End If
                    Next
                End If
            End If

            If Val = True Then
                blnValue = False
                MessageBox.Show("El nombre de la Banda ya esta registrado", _
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbbBanda.Focus()
            End If

            Return blnValue
        End Function

        Private Sub AGrabar()
            objBss = New Bussines.Registro.InternoBanda
            Dim entInt As Entity.Registro.Interno
            If Validar() = False Then Exit Sub

            objBss = New Bussines.Registro.InternoBanda
            Dim objEnt As New Entity.Registro.InternoBanda
            If Me.Codigo > 0 Then
                If Me.TipoLicencia = enmTipoLicencia.Carceleta Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                    objEnt = objBss.Listar_LM(Me.Codigo)
                Else
                    Dim objEntBandas As New Entity.Registro.InternoBanda
                    objEntBandas.Codigo = Me.Codigo
                    objEntBandas.IngresoID = Me._NroIngresoID
                    objEnt = objBss.Listar2(objEntBandas).InternoBanda(0)
                End If
            End If

            If Me.TipoLicencia = enmTipoLicencia.Carceleta Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                entInt = (New Bussines.Registro.Interno).Listar_LM(Me.InternoID)
            Else
                'Dim objEntFiltro As New 
                entInt = (New Bussines.Registro.Interno).Listar_v5(Me.InternoID) 'cargar datos del interno
            End If


            With objEnt
                .BandaNombre = cbbBanda.Text
                .ApePatInterno = entInt.ApellidoPaterno
                .ApeMatInterno = entInt.ApellidoMaterno
                .NombresInterno = entInt.Nombres
                .InternoID = Me.InternoID
                .IngresoID = Me._NroIngresoID
                .IngresoInpeID = Me._NroIngresoInpeID
                .BandaID = Me.BandaID
                .Observacion = Me.Observacion
                .RegioID = Me._RegionID
                .PenalID = Me._PenalID
                .Estado = 1 '--ACTIVO
                .InternoApeNombres = objEnt.ApePatInterno & " " & objEnt.ApeMatInterno & ", " & objEnt.NombresInterno
            End With

            Dim intValue As Integer = -1

            If Me.TipoLicencia = enmTipoLicencia.Carceleta Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                objEnt.IngresoID = -1
                intValue = objBss.Grabar_LM(objEnt)
            Else
                intValue = objBss.Grabar2(objEnt)
            End If


            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Sub
#End Region

#Region "Otros"

        Private Sub ValoresxDefault()

            ComboBanda()

            Listar()

        End Sub

#End Region

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
        Private Sub cbbBandaTipo__ValueChanged()
            ComboBanda()
        End Sub

        Private Sub txtobservacion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtobservacion.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

    End Class
End Namespace


