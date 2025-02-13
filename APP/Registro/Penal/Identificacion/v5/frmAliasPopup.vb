Imports System.Windows.Forms
Imports Type.Enumeracion.Licencia

Namespace Registro.Identificacion.v5
    Public Class frmAliasPopup
        Private objBss As Bussines.Registro.InternoAlias = Nothing


#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Private Property Nombres() As String
            Get
                Return Me.txtNombres.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNombres.Text = value
            End Set
        End Property
        Public Property _NroIngresoID As Integer = -1
        Public Property _NroIngresoInpeID As Integer = -1
        Public Property _RegionID As Integer = -1
        Public Property _PenalID As Integer = -1
        Public Property TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
        'Public Property _PenalLM As Boolean = False
#End Region
#Region "Listar"
        Private Sub ListarData()

            If Me.Codigo < 1 Then Exit Sub

            objBss = New Bussines.Registro.InternoAlias
            Dim objEnt As New Entity.Registro.InternoAlias
            objEnt.Codigo = Me.Codigo

            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                objEnt = objBss.Listar_LM(Me.Codigo)
            Else
                Dim ent As New Entity.Registro.InternoAlias
                ent.Codigo = Codigo
                ent.IngresoID = Me._NroIngresoID
                objEnt = objBss.Listar2(ent).InternoAlias(0)
            End If

            If objEnt Is Nothing Then
            Else
                With objEnt
                    Me.Nombres = .Nombres
                    Me._PenalID = .PenalID
                    Me._RegionID = .RegionID
                    Me._NroIngresoInpeID = .IngresoInpeId
                    Me._NroIngresoID = .IngresoID
                    Me.InternoID = .InternoID
                    Me.UscAuditUser1.LoadAudit(Me.Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoAlias)
                End With
            End If
        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True
            If Me.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana _
                Or Me.TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then

            Else
                If _NroIngresoID < 1 Then
                    If Me.Codigo < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar N° de ingreso, no se ha enviado el parametro")
                    Else
                        Dim objBss As New Bussines.Registro.Ingreso
                        Dim objEntCol As New Entity.Registro.IngresoCol
                        objEntCol = objBss.Listar(-1, Me.InternoID, -1, -1, -1, 0, -1, -1, "", 0, -1, 0, "")
                        If objEntCol.Count = 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no posee ningún ingreso, registrar un ingreso")
                            Me.Close()
                        Else
                            Dim frm As New Registro.Identificacion.v5.frmSeleccionarIngresoPopup
                            frm.InternoID = Me.InternoID
                            frm._FormEscritura = Me._FormEscritura
                            frm._FormLectura = Me._FormLectura
                            frm._objEntCol = objEntCol
                            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                Me._NroIngresoID = frm.intIngresoNuevo
                                Return blnValue
                            Else
                                Exit Function
                            End If
                        End If
                    End If
                    Return blnValue
                End If
            End If

            If Me.Nombres = "" Or Me.Nombres.Length < 2 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el nombre del alias del Interno")
                Me.txtNombres.Focus()
                blnValue = False
                Return blnValue
            End If
            Return blnValue
        End Function

        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            Dim intValue As Integer = -1
            objBss = New Bussines.Registro.InternoAlias

            Me.Nombres = Legolas.Components.Cadena.LimpiarEspacios(Me.Nombres)
            Dim EntAlias As New Entity.Registro.InternoAlias

            If Me.Codigo > 0 Then
                If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                    Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                   Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then

                    EntAlias = objBss.Listar_LM(Me.Codigo)

                Else
                    Dim ent As New Entity.Registro.InternoAlias
                    ent.Codigo = Codigo
                    ent.IngresoID = Me._NroIngresoID
                    EntAlias = objBss.Listar2(ent).InternoAlias(0)
                End If
            End If


            With EntAlias
                .InternoID = Me.InternoID
                .Nombres = Me.Nombres
                .IngresoInpeId = Me._NroIngresoInpeID
                .IngresoID = Me._NroIngresoID
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID

            End With

            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                    EntAlias.IngresoID = -1
                    intValue = objBss.Grabar_LM(EntAlias)
                Case Else
                    intValue = objBss.Grabar(EntAlias)
            End Select

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub Usuario_Permiso()

            Me.btnOK.Visible = Me._FormEscritura

        End Sub
#End Region
        Private Sub frmAliasPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ListarData()
            Usuario_Permiso()


        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

            AGrabar()

        End Sub

    End Class

End Namespace
