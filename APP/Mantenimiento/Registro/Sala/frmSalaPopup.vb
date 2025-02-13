Namespace Mantenimiento.Registro.Sala
    Public Class frmSalaPopup
        Private objBss As Bussines.Mantenimiento.SalaJuzgado = Nothing
#Region "Propiedades"
        Private intCodigo As Integer = 0
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Private Property IDDistritoJudicial() As Integer
            Get
                Return Me.cbbDistritoJud.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbDistritoJud.SelectedValue = value
            End Set
        End Property
        Private Property DistritoJudicialCodigo() As String
            Get
                Return Me.txtCodDisJud.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtCodDisJud.Text = value
            End Set
        End Property
        Private Property SalaCodigo() As String
            Get
                Return Me.txtCodSala.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtCodSala.Text = value
            End Set
        End Property
        Private Property SalaNombre() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
        Private Property SalaNombreCorto() As String
            Get
                Return Me.txtNomCorto.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNomCorto.Text = value
            End Set
        End Property
        Private Property Estado() As Short
            Get
                Dim value As Short = -1

                If Me.rbHistorico.Checked = True Then
                    value = 0
                End If

                If Me.rbVigente.Checked = True Then
                    value = 1
                End If

                If Me.rbInactivo.Checked = True Then
                    value = 100
                End If

                Return value

            End Get
            Set(ByVal value As Short)

                If value = 0 Then
                    Me.rbHistorico.Checked = True
                End If

                If value = 1 Then
                    Me.rbVigente.Checked = True
                End If

                If value = 100 Then
                    Me.rbInactivo.Checked = True
                End If

            End Set
        End Property
        Private Property JurisdiccionId
            Get
                Dim v As Integer = -1
                If rdbOtros.Checked = True Then v = -1
                If rdbLima.Checked = True Then v = 1
                If rdbCallao.Checked = True Then v = 2
                Return v
            End Get
            Set(value)
                If value = -1 Then rdbOtros.Checked = True
                If value = 1 Then rdbLima.Checked = True
                If value = 2 Then rdbCallao.Checked = True
            End Set
        End Property
#End Region
#Region "Combo"
        Private blnComboDisJud As Boolean = False
        Private Sub Combo()

            With Me.cbbDistritoJud
                .LoadUsc()
            End With
            Me.IDDistritoJudicial = -1
            blnComboDisJud = True
        End Sub
#End Region
#Region "Listar"
        Private Sub Listar()

            If Me.Codigo < 1 Then
                Exit Sub
            End If

            Dim objEnt As New Entity.Mantenimiento.SalaJuzgado
            objBss = New Bussines.Mantenimiento.SalaJuzgado

            objEnt = objBss.Listar(Me.Codigo)

            With objEnt
                Me.IDDistritoJudicial = .DistritoJudID
                Me.DistritoJudicialCodigo = .DistritoJudCodigo
                Me.SalaCodigo = .SalaCodigo
                Me.SalaNombre = .Nombre
                Me.SalaNombreCorto = .NombreCorto
                Me.Estado = .Estado
                Me.JurisdiccionId = .JurisdiccionId
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True

            'distrito judicial
            If Me.IDDistritoJudicial < 1 Then
                MessageBox.Show("Seleccione el distrito judicial",
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbDistritoJud.Focus()
                blnValue = False
                Return blnValue
            End If

            'sala
            If Me.SalaNombre.Trim.Length < 3 Then
                MessageBox.Show("Ingrese el nombre de la sala",
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtNom.Focus()
                blnValue = False
                Return blnValue
            End If

            Return blnValue
        End Function
        Private Sub AOK()

            If Validar() = False Then
                Exit Sub
            End If

            objBss = New Bussines.Mantenimiento.SalaJuzgado

            Dim intValue As Integer = -1
            Dim ent As New Entity.Mantenimiento.SalaJuzgado
            With ent
                .Codigo = Me.Codigo
                .DistritoJudID = Me.IDDistritoJudicial
                .DistritoJudCodigo = Me.DistritoJudicialCodigo
                .SalaCodigo = Me.SalaCodigo
                .Nombre = Me.SalaNombre
                .Estado = Me.Estado
                .NombreCorto = Me.SalaNombreCorto
                .JurisdiccionId = Me.JurisdiccionId
            End With

            Dim outSms As String = ""
            intValue = objBss.Grabar(ent, outSms)

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                Legolas.Configuration.Aplication.MessageBox.MensajeError(outSms)
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub PermisosLicencia()

            Select Case Configuracion.Licencia.Codigo
                Case 1 'sede central
                    Me.btnOK.Visible = Me._FormEscritura
                Case Else
                    Me.btnOK.Visible = False
            End Select
        End Sub
        Private Sub ValoresxDefault()
            PermisosLicencia()
            Combo()
        End Sub
#End Region
        Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

            Me.Cursor = Cursors.WaitCursor
            AOK()
            Me.Cursor = Cursors.Default
        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub frmSalaPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ValoresxDefault()
            Listar()

        End Sub

        Private Sub cbbDistritoJud__SelectedIndexChanged() Handles cbbDistritoJud._SelectedIndexChanged

            If blnComboDisJud = True Then
                Dim objBss As New Bussines.Mantenimiento.AutoridadJudicial

                If Me.IDDistritoJudicial > 0 Then
                    Me.DistritoJudicialCodigo = objBss.getCodigo(Me.IDDistritoJudicial)
                End If
            End If

        End Sub

    End Class

End Namespace
