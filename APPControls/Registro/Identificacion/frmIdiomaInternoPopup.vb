Imports Type.Enumeracion.Licencia

Namespace Registro.Identificacion
    Public Class frmIdiomaInternoPopup
#Region "Propiedades publicas"
        Public Property _Codigo As Integer = -1
        Public Property _InternoId As Integer = -1
        Public Property _RegionId As Integer = -1
        Public Property _PenalId As Integer = -1
        Public Property _IngresoId As Integer = -1
        Public Property _IngresoNroLetra As String = ""
        Public Property TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Public Property _InternoIngresoInpeId() As Integer = -1
#End Region
#Region "propiedades privadas"
        Private Property Idioma() As Integer
            Get
                Try
                    Dim id As Integer = -1
                    id = Me.cboIdiomaPrincipal.SelectedValue

                    If Me.cboIdiomaPrincipal.Text = "" Then id = -1

                    Return id
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cboIdiomaPrincipal.SelectedValue = value
            End Set
        End Property

        Private Property NivelDominioIdioma As Type.Enumeracion.enmDominioIdioma
            Get
                Dim std As Type.Enumeracion.enmDominioIdioma = Type.Enumeracion.enmDominioIdioma.Ninguno
                If rdbBasico.Checked = True Then std = Type.Enumeracion.enmDominioIdioma.Basico
                If rdbIntermedio.Checked = True Then std = Type.Enumeracion.enmDominioIdioma.Intermedio
                If rdbAvanzado.Checked = True Then std = Type.Enumeracion.enmDominioIdioma.Avanzado
                Return std
            End Get
            Set(value As Type.Enumeracion.enmDominioIdioma)
                Select Case value
                    Case Type.Enumeracion.enmDominioIdioma.Ninguno

                    Case Type.Enumeracion.enmDominioIdioma.Basico
                        rdbBasico.Checked = True
                    Case Type.Enumeracion.enmDominioIdioma.Intermedio
                        rdbIntermedio.Checked = True
                    Case Type.Enumeracion.enmDominioIdioma.Avanzado
                        rdbAvanzado.Checked = True
                End Select
            End Set
        End Property

        Private ReadOnly Property NivelDominioIdiomaStr As String
            Get
                Dim std As String = ""
                If rdbBasico.Checked = True Then std = "BASICO"
                If rdbIntermedio.Checked = True Then std = "INTERMEDIO"
                If rdbAvanzado.Checked = True Then std = "AVANZADO"
                Return std
            End Get
        End Property
#End Region
#Region "Listar"
        Private Sub listar()
            If Me._Codigo = -1 Then Exit Sub

            Dim ent As Entity.Registro.InternoIdioma
            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                ent = (New Bussines.Registro.InternoIdioma).Listar_LM(Me._Codigo)

                Dim entIngInp As Entity.Registro.IngresoInpe
                entIngInp = (New Bussines.Registro.IngresoInpe).Listar(ent.IngresoInpeId)
                lblNroIngreso.Text = entIngInp.IngresoNroLetra

            Else
                ent = (New Bussines.Registro.InternoIdioma).Listar(Me._Codigo)
            End If

            With ent
                Me.Idioma = .IdiomaId
                Me.NivelDominioIdioma = ent.NivelDominioId
                Me._PenalId = .PenalId
                Me._RegionId = .RegionId
                Me._IngresoId = .IngresoId
                Me._InternoIngresoInpeId = .IngresoInpeId
            End With
        End Sub
#End Region
#Region "accion"
        Private Sub ValoresxDefault()
            If Me._Codigo = -1 Then
                lblNroIngreso.Text = Me._IngresoNroLetra
            Else
                lblNroIngreso.Text = ""
            End If
            Me.cboIdiomaPrincipal.LoadUsc()
            Me.Idioma = -1
            listar()
        End Sub

        Private Function Validar() As Boolean
            If cboIdiomaPrincipal.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione idioma.")
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
                If Me._InternoId <= 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Valor Id del interno no válido, por favor, comuniquese con soporte de la sede central.")
                    Return False
                End If
            End If
            If Me._PenalId < 0 Then
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

            Dim ent As New Entity.Registro.InternoIdioma

            With ent
                .InternoId = Me._InternoId
                .Codigo = Me._Codigo
                .PenalId = Me._PenalId
                .RegionId = Me._RegionId
                .IdiomaId = Me.Idioma
                .NivelDominioId = Me.NivelDominioIdioma
                .IngresoId = Me._IngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
                .InternoId = Me._InternoId
            End With

            Dim id As Integer = -1
            Dim outSms As String = ""
            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                ent.IngresoId = -1
                id = (New Bussines.Registro.InternoIdioma).Grabar_LM(ent, outSms, False)
            Else
                id = (New Bussines.Registro.InternoIdioma).Grabar(ent, outSms)
            End If

            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Error, " & vbCrLf & outSms)
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
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

        Private Sub frmIdiomaInternoPopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            ValoresxDefault()
            Usuario_Permiso()
        End Sub

    End Class
End Namespace