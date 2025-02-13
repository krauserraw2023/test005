Namespace Mantenimiento.Banda
    Public Class frmMantBandaPopup
        Private objBss As Bussines.Registro.Banda = Nothing
        Private objEnt As Entity.Registro.Banda = Nothing

        Dim strCadConcatInicial As String = ""
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
        Private Property _BandaTipoId() As Integer
            Get
                Return Me.cbbBandaTipo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbBandaTipo.SelectedValue = value
            End Set
        End Property
        Private Property _BandaNombre() As String
            Get
                Return Me.txtNombre.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNombre.Text = value
            End Set
        End Property
        Private Property _BandaDescripcion() As String
            Get
                Return Me.txtDescripcion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDescripcion.Text = value
            End Set
        End Property
        'Public Property _PenalId() As Integer
        '    Get
        '        Return cbbPenal.SelectedValue
        '    End Get
        '    Set(value As Integer)
        '        cbbPenal.SelectedValue = value
        '    End Set
        'End Property
        'Public Property _RegionId() As Integer
        '    Get
        '        Return cbbRegion.SelectedValue
        '    End Get
        '    Set(value As Integer)
        '        cbbRegion.SelectedValue = value
        '    End Set
        'End Property
        Public Property _PenalNombre() As String = ""
        Public Property _RegionNombre() As String = ""
#End Region
#Region "Combo"
        Private Sub Combo()
            With Me.cbbBandaTipo
                .LoadUsc()
            End With
        End Sub

#End Region
#Region "Listar"
        Private Sub Listar()
            Dim objEnt As New Entity.Registro.Banda
            objBss = New Bussines.Registro.Banda

            If Me.Codigo < 1 Then 'nueva banda
                'Me._RegionId = -1
                'Me._PenalId = -1
                Me._BandaTipoId = -1
            Else 'editar
                objBss = New Bussines.Registro.Banda
                objEnt = New Entity.Registro.Banda
                objEnt = objBss.Listar(Me.Codigo)

                'Me._RegionId = objEnt.BandaRegionId
                'Me._PenalId = objEnt.BandaPenalId
                Me._BandaTipoId = objEnt.BandaTipoID
                Me._BandaNombre = objEnt.BandaNombre
                Me._BandaDescripcion = objEnt.BandaDescripcion
            End If

            If Me.Codigo < 1 Then
                Exit Sub
            End If
        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean
            Dim blnValue As Boolean = True

            'organización criminal
            If Me._BandaTipoId < 1 Then
                MessageBox.Show("Seleccione el Tipo de Banda", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbBandaTipo.Focus()
                blnValue = False
                Return blnValue
            End If

            'nombre de la banda
            If Me._BandaNombre.Length < 1 Or Me._BandaNombre = "" Then
                MessageBox.Show("Ingrese el nombre de la Banda", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtDescripcion.Focus()
                blnValue = False
                Return blnValue
            End If

            'If Me._RegionId < 1 Then
            '    MessageBox.Show("Seleccione la región", _
            '     Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.cbbRegion.Focus()
            '    blnValue = False
            '    Return blnValue
            'End If

            'If Me._PenalId < 1 Then
            '    MessageBox.Show("Seleccione el penal", _
            '     Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.cbbPenal.Focus()
            '    blnValue = False
            '    Return blnValue
            'End If
            Return blnValue
        End Function
        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            objBss = New Bussines.Registro.Banda
            objEnt = New Entity.Registro.Banda

            Dim intValue As Integer = -1
            Dim strOutSms As String = ""

            If Me.Codigo > 0 Then objEnt = objBss.Listar(Me.Codigo)

            objEnt.BandaTipoID = Me._BandaTipoId
            objEnt.BandaNombre = Me._BandaNombre
            objEnt.BandaDescripcion = Me._BandaDescripcion
            intValue = objBss.Grabar(objEnt, strOutSms)

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                Legolas.Configuration.Aplication.MessageBox.MensajeError(strOutSms)
            End If
        End Sub

#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            Combo()
        End Sub
        Private Sub UsuarioPermisos()
            Me.btnAceptar.Visible = Me._FormEscritura
        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            If strCadConcatInicial <> cbbBandaTipo.Text & txtNombre.Text & txtDescripcion.Text Then
                If Legolas.Configuration.Aplication.MessageBox.Question("Desea guardar los cambios efectuados?") = Windows.Forms.DialogResult.Yes Then
                    AGrabar()
                End If
            End If
            Me.Close()

        End Sub
        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            AGrabar()
        End Sub

        Private Sub frmMantBandaPopup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            ValoresxDefault()
            Listar()
            UsuarioPermisos()

            strCadConcatInicial = cbbBandaTipo.Text & txtNombre.Text & txtDescripcion.Text
        End Sub

        Private Sub frmMantBandaPopup_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Keys.Escape Then
                btnCancel.PerformClick()
            End If
        End Sub
    End Class

End Namespace
