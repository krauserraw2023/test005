Imports Type.Enumeracion.Licencia

Namespace Registro.Identificacion
    Public Class frmInternoGradoInsPopup

#Region "Propieades publicas"
        Public Property _Codigo As Integer = -1
        Public Property _InternoId As Integer
        Public Property _IngresoId As Integer
        Public Property _RegionId As Integer = -1
        Public Property _IngresoNroLetra As String = String.Empty
        Public Property _penalId As Integer = -1
        'Public Property _PenalLM As Boolean = False
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
#End Region
#Region "Propiedades privadas"
        Private Property GradoInstruccionId() As Integer
            Get
                Try
                    Return Me.cbbGradoInst.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbGradoInst.SelectedValue = value
            End Set
        End Property

        Private Property Observacion As String
            Get
                Return txtObs.Text
            End Get
            Set(value As String)
                txtObs.Text = value
            End Set
        End Property
#End Region

#Region "Listar"
        Private Sub Listar()
            If Me._Codigo = -1 Then Exit Sub

            Dim ent As Entity.Registro.InternoGradoInstruccion
            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                ent = (New Bussines.Registro.InternoGradoInstruccion).Listar_LM(Me._Codigo)

                Dim entIngInp As Entity.Registro.IngresoInpe
                entIngInp = (New Bussines.Registro.IngresoInpe).Listar(ent.IngresoInpeId)
                lblNroIngreso.Text = entIngInp.IngresoNroLetra

            Else
                ent = (New Bussines.Registro.InternoGradoInstruccion).Listar(Me._Codigo)
            End If

            With ent
                Me.GradoInstruccionId = .GradoInstruccionId
                Me.Observacion = ent.Observacion
                Me._penalId = .PenalId
                Me._RegionId = .RegionId
                Me._IngresoId = .IngresoId
            End With
        End Sub
#End Region

#Region "Accion"
        Private Function Validar() As Boolean
            If String.IsNullOrEmpty(cbbGradoInst.Text) Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el grado de instrucción actual del interno.")
                Return False
            End If
            If Me._Codigo = -1 Then
                If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                    Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                    Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    If Me._InternoIngresoInpeId <= 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione número de ingreso.")
                        Return False
                    End If
                Else
                    If Me._IngresoId <= 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione número de ingreso.")
                        Return False
                    End If
                End If

            End If
            If Me._penalId < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Id del penal no especificado.")
                Return False
            End If
            If Me._RegionId < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Id de la región no especificado.")
                Return False
            End If

            Return True
        End Function

        Private Sub AGrabar()

            If Validar() = False Then Exit Sub

            Dim ent As New Entity.Registro.InternoGradoInstruccion

            With ent
                .Codigo = Me._Codigo
                .PenalId = Me._penalId
                .RegionId = Me._RegionId
                .GradoInstruccionId = Me.GradoInstruccionId
                .Observacion = Me.Observacion
                .InternoId = Me._InternoId
                .IngresoId = Me._IngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
            End With

            Dim id As Integer = -1
            Dim outSms As String = String.Empty
            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                ent.IngresoId = -1
                id = (New Bussines.Registro.InternoGradoInstruccion).Grabar_LM(ent, outSms, False)
            Else
                id = (New Bussines.Registro.InternoGradoInstruccion).Grabar(ent, outSms)
            End If

            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Error, " & vbCrLf & outSms)
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub

        Private Sub ValoresxDefault()
            If Me._Codigo = -1 Then
                lblNroIngreso.Text = Me._IngresoNroLetra
            Else
                lblNroIngreso.Text = ""
            End If

            Me.cbbGradoInst.LoadUsc()
            Me.GradoInstruccionId = -1
            Listar()
        End Sub
#End Region
#Region "Otros"
        Private Sub Usuario_Permiso()

            Me.btnOK.Visible = Me._FormEscritura

        End Sub
#End Region
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
            AGrabar()
        End Sub

        Private Sub frmInternoGradoInsPopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            ValoresxDefault()
            Usuario_Permiso()

        End Sub
    End Class
End Namespace