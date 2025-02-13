Imports System.Windows.Forms
Imports Type.Enumeracion.Licencia

Namespace Registro.Expediente.v5
    Public Class frmAgraviadoPopup3
        Public objEnt As Entity.Registro.Agraviado = Nothing
        Public Property _objEntAgraviado() As New Entity.Registro.Agraviado
        Public Property _objEntAgraviadoCol As New Entity.Registro.AgraviadoCol
        Private blnSwitch As Boolean = False
        Public Property _TipoDocumento As Integer = -1
        Public Property _ExpedienteIDAux As Integer = 0
#Region "Propiedades"

        Public _ObjAgraviado As Entity.Registro.Agraviado
        Private blnNuevoRegistro As Boolean = False
        Public Property _Codigo() As Integer = -1
        Public Property _AgraviadoNombre() As String
            Get
                Return Me.txtNombres.Text.Trim
            End Get
            Set(ByVal value As String)
                txtNombres.Text = value
            End Set
        End Property

        Private Property NuevoRegistro() As Boolean
            Get
                Return blnNuevoRegistro
            End Get
            Set(ByVal value As Boolean)
                blnNuevoRegistro = value
            End Set
        End Property

        Public Property _Observacion() As String
            Get
                Return Me.txtObservacion.Text
            End Get
            Set(ByVal value As String)
                Me.txtObservacion.Text = value
            End Set
        End Property
        Public Property InternoID As Integer = -1
        Private Property ExpedienteID As Integer = -1
#End Region
#Region "Propiedades_Publicas"
        Public Property ResolucionNuevo As Boolean = False
        Public Property Agraviado() As Entity.Registro.Agraviado
            Get
                Return objEnt
            End Get
            Set(value As Entity.Registro.Agraviado)
                objEnt = value
            End Set
        End Property
        Public Property _TipoFormulario() As Type.Formulario.Registro.UserControl = Type.Formulario.Registro.UserControl.Resoluciones
        Public Property _NuevoGrabar As Boolean = False
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
#End Region
#Region "Listar"
        Private Sub ListarData()

            With _objEntAgraviado
                Me._Codigo = .Codigo
                Me._AgraviadoNombre = .AgraviadoNombre
                Me._Observacion = .Observacion
                Me.InternoID = .InternoID
                Me.ExpedienteID = .ExpedienteID
            End With
            If Me._NuevoGrabar = False Then
                Dim EntExp As New Entity.Registro.InternoExpedientePadre
                EntExp.Codigo = IIf(Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento, _objEntAgraviado.ExpedienteID, Me._ExpedienteID)
                EntExp.InternoID = Me._InternoID
                If EntExp.Codigo > 0 Then
                    Dim EntColPad As New Entity.Registro.InternoExpedientePadreCol
                    Dim objBssPad As Bussines.Registro.InternoExpedientePadre
                    objBssPad = New Bussines.Registro.InternoExpedientePadre
                    EntColPad = objBssPad.ListarGrilla(EntExp)
                    If Me._Codigo > 0 Then
                        For Each EntCodi As Entity.Registro.InternoExpedientePadre In EntColPad
                            If EntExp.Codigo = EntCodi.InternoExpedienteRefPadreId Then
                                blnSwitch = True
                                Exit For
                            End If
                        Next
                    End If
                End If

            End If
            If blnSwitch = True Then
                InhabilitarControles()
            End If
        End Sub
#End Region
#Region "Accion"
        Private Sub InhabilitarControles()
            txtNombres.ReadOnly = True
            txtObservacion.ReadOnly = True
            btnOK.Enabled = False
        End Sub
        Private Function Validar() As Boolean
            Dim blnValue As Boolean = True
            If blnSwitch = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente ha sido referenciado, operacion cancelada")
                Exit Function
            End If
            If Me._AgraviadoNombre = "" Or Me._AgraviadoNombre.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese nombre del agraviado")
                Me.txtNombres.Focus()
                Return False
            End If
            If Not _objEntAgraviadoCol Is Nothing Then
                If _objEntAgraviadoCol.Count > 0 Then
                    If Me._objEntAgraviadoCol.Item(0).CreaDocJudicialId < 1 Then

                        For Each obj As Entity.Registro.Agraviado In _objEntAgraviadoCol
                            If Me._NuevoGrabar = True Then
                                If obj.AgraviadoNombre = Me._AgraviadoNombre Then
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El agraviado ya existe en la lista, no podra ser agregado")
                                    txtNombres.Focus()
                                    blnValue = False
                                    Return blnValue
                                End If
                            Else
                                If obj.AgraviadoNombre <> _objEntAgraviado.AgraviadoNombre Then
                                    If obj.AgraviadoNombre = Me._AgraviadoNombre Then
                                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El agraviado ya existe en la lista, no podra ser modificado.")
                                        txtNombres.Focus()
                                        Return False
                                    End If
                                End If
                            End If
                        Next
                    Else
                        For Each obj As Entity.Registro.Agraviado In _objEntAgraviadoCol
                            If Me._NuevoGrabar = True Then
                                If obj.AgraviadoNombre = Me._AgraviadoNombre Then
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El agraviado ya existe en la lista, no podra ser agregado")
                                    txtNombres.Focus()
                                    Return False
                                End If
                            Else
                                If obj.AgraviadoNombre <> _objEntAgraviado.AgraviadoNombre Then
                                    If obj.AgraviadoNombre = Me._AgraviadoNombre Then
                                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El agraviado ya existe en la lista, no pueder modificado.")
                                        txtNombres.Focus()
                                        Return False
                                    End If
                                End If
                            End If

                        Next
                    End If
                End If
            End If
            Return blnValue
        End Function

        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            Dim intValue As Integer = -1
            If Me._ResolucionNuevo = True Then
                _objEntAgraviado = New Entity.Registro.Agraviado
                With _objEntAgraviado
                    .Codigo = Me._Codigo
                    .AgraviadoNombre = Me._AgraviadoNombre
                    .Observacion = Me._Observacion
                End With
                intValue = 0
            Else
                If _objEntAgraviado Is Nothing Then
                Else
                    With _objEntAgraviado
                        .Codigo = Me._Codigo
                        .AgraviadoNombre = Me._AgraviadoNombre
                        .Observacion = Me._Observacion
                    End With
                End If
                intValue = IIf(Me._Codigo = -1, 0, Me._Codigo)

            End If

            If intValue > -1 Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub
#End Region
#Region "Otros"
        Private Sub Usuario_Permiso()

            Dim blnSalir As Boolean = False
            Dim blnGrabar As Boolean = False

            Select Case Me._TipoFormulario
                Case Type.Formulario.Registro.UserControl.ListadoExpediente
                    InhabilitarControles()
                    blnSalir = True
                Case Type.Formulario.Registro.UserControl.Resoluciones
                    blnGrabar = True
            End Select

            Me.pnlSalir.Visible = blnSalir
            Me.pnlGrabarDatos.Visible = blnGrabar
            Me.btnOK.Visible = Me._FormEscritura

        End Sub
        Private Sub ValoresxDefault()

            Usuario_Permiso()

        End Sub
#End Region

        Private Sub frmAgraviadoPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ValoresxDefault()
        End Sub

        Private Sub frmAgraviadoPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown

            ListarData()
            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoAgraviado)

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

            AGrabar()

        End Sub

        Private Sub txtobservacion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub txtNombres_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub
    End Class
End Namespace
