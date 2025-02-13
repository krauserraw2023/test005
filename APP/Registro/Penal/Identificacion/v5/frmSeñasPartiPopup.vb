Imports Type.Enumeracion.Licencia
Imports Legolas.Configuration

Namespace Registro.Identificacion
    Public Class frmSeñasPartiPopup
        Private objBss As Bussines.Registro.InternoSenaParticular = Nothing
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _InternoIngresoNro() As Integer = -1
        Public Property TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
        'Public Property _PenalLM As Boolean = False

        Private Property Naturaleza() As Integer
            Get
                Return Me.cbbNaturaleza.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbNaturaleza.SelectedValue = value
            End Set
        End Property
        Private Property Forma() As Integer
            Get
                Return Me.cbbForma.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbForma.SelectedValue = value
            End Set
        End Property
        Private Property Ubicacion() As Integer
            Get
                Return Me.cbbUbicacion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbUbicacion.SelectedValue = value
            End Set
        End Property
        Private Property Posicion() As Integer
            Get
                Return Me.cbbPosicion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbPosicion.SelectedValue = value
            End Set
        End Property
        Private Property Cantidad() As Integer
            Get
                Return NumericUpDown1.Value
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then
                    value = 1
                Else
                    Me.NumericUpDown1.Value = value
                End If

            End Set
        End Property
        Private Property Obs() As String
            Get
                Return Me.txtObs.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObs.Text = value
            End Set
        End Property
#End Region
#Region "Combo"
        Private Sub Combo()

            'naturaleza
            With Me.cbbNaturaleza
                .ComboTipo = Type.Combo.ComboTipo.SenaParticular
                .Parametro1 = Legolas.LType.Persona.SenaParticular.Naturaleza
                .LoadUsc()
            End With

            'forma
            With Me.cbbForma
                .ComboTipo = Type.Combo.ComboTipo.SenaParticular
                .Parametro1 = Legolas.LType.Persona.SenaParticular.Forma
                .LoadUsc()
            End With

            'ubicacion
            With Me.cbbUbicacion
                .ComboTipo = Type.Combo.ComboTipo.SenaParticular
                .Parametro1 = Legolas.LType.Persona.SenaParticular.Ubicacion
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboPosicion()

            With Me.cbbPosicion
                .ComboTipo = Type.Combo.ComboTipo.SenaParticular
                .Parametro1 = Legolas.LType.Persona.SenaParticular.Posicion
                .CodigoPadre = Me.Ubicacion
                .LoadUsc()
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub ListarData()

            If Me.Codigo < 1 Then
                lblNumIngreso.Text = Me._InternoIngresoNro
                Exit Sub
            End If

            Dim objEnt As New Entity.Registro.InternoSenaParticular
            objBss = New Bussines.Registro.InternoSenaParticular

            Select Case Me.TipoLicencia
                Case enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.Carceleta
                    objEnt = objBss.Listar_LM(Me.Codigo)
                Case Else
                    objEnt = objBss.Listar(Me.Codigo)
            End Select

            With objEnt
                Me.Naturaleza = .NaturalezaID
                Me.Forma = .FormaID
                Me.Ubicacion = .UbicacionID
                Me.Posicion = .PosicionID
                Me.Cantidad = .Cantidad
                Me.Obs = .Obs
                Me._InternoIngresoId = .InternoIngresoId
            End With
            lblNumIngreso.Text = Me._InternoIngresoNro
        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True

            'interno id
            If Me._InternoID < 1 Then
                MessageBox.Show("Seleccione el interno antes de grabar", _
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                'Return blnValue
            End If

            'naturaleza
            If Me.Naturaleza < 1 Then
                MessageBox.Show("Seleccione naturaleza", _
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbNaturaleza.Focus()
                blnValue = False
                'Return blnValue
            End If

            'forma
            If Me.Forma < 1 Then
                MessageBox.Show("Seleccione forma", _
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbForma.Focus()
                blnValue = False
                'Return blnValue
            End If

            'ubicacion
            If Me.Ubicacion < 1 Then
                MessageBox.Show("Seleccione ubicacion", _
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbUbicacion.Focus()
                blnValue = False
                'Return blnValue
            End If

            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then

                If Me._InternoIngresoInpeId < 1 And Me.Codigo < 1 Then
                    Aplication.MessageBox.Exclamation("Seleccionar N° de ingreso, no se ha enviado el parametro")
                End If

            Else
                If Me._InternoIngresoId < 1 Then
                    If Me.Codigo < 1 Then
                        Aplication.MessageBox.Exclamation("Seleccionar N° de ingreso, no se ha enviado el parametro")
                    Else
                        Dim objBss As New Bussines.Registro.Ingreso
                        Dim objEntCol As New Entity.Registro.IngresoCol
                        objEntCol = objBss.Listar(-1, Me._InternoID, -1, -1, -1, 0, -1, -1, "", 0, -1, 0, "")
                        If objEntCol.Count = 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no posee ningun ingreso, registrar un ingreso")
                            Me.Close()
                        Else
                            Dim frm As New Registro.Identificacion.v5.frmSeleccionarIngresoPopup
                            frm.InternoID = Me._InternoID
                            frm._FormEscritura = Me._FormEscritura
                            frm._FormLectura = Me._FormLectura
                            frm._objEntCol = objEntCol
                            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                Me._InternoIngresoId = frm.intIngresoNuevo
                                Return blnValue
                            Else
                                Exit Function
                            End If
                        End If
                    End If
                    Return blnValue
                End If
            End If
            Return blnValue

        End Function

        Private Sub AGrabar()
            If Validar() = False Then Exit Sub

            Dim intValue As Integer = -1

            objBss = New Bussines.Registro.InternoSenaParticular

            Dim entSenPart As New Entity.Registro.InternoSenaParticular
            With entSenPart
                .Codigo = Me.Codigo
                .InternoID = Me._InternoID
                .NaturalezaID = Me.Naturaleza
                .FormaID = Me.Forma
                .UbicacionID = Me.Ubicacion
                .PosicionID = Me.Posicion
                .Cantidad = Me.Cantidad
                .Obs = Me.Obs
                .InternoIngresoId = Me._InternoIngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
            End With

            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                entSenPart.InternoIngresoId = -1 'en lima metropolitana no es necesario
                intValue = objBss.Grabar_LM(entSenPart)
            Else
                intValue = objBss.Grabar(entSenPart)
            End If

            If intValue > 0 Then
                Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Sub
#End Region
#Region "Otros"
#Region "Usuario_Permiso"
        Private Sub Usuario_Permiso()
            Me.btnAceptar.Visible = Me._FormEscritura
        End Sub
#End Region
        Private Sub Mostrar_Auditoria()
            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoSenaParticular)
        End Sub

        Private Sub ValoresxDefault()
            Combo()
            ComboPosicion()
        End Sub
#End Region
#Region "Evento_Formulario"
        Private Sub cbbUbicacion__ValueChanged() Handles cbbUbicacion._SelectedIndexChanged
            ComboPosicion()
        End Sub

        Private Sub frmSeñasPartiPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub frmSeñasPartiPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            Usuario_Permiso()
            ListarData()
            Mostrar_Auditoria()
        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            AGrabar()
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub
#End Region

    End Class
End Namespace
