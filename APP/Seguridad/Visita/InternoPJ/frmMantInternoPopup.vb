Namespace Visita.InternoPJ
    Public Class frmMantInternoPopup
        Private objBss As Bussines.Visita.InternoPJ = Nothing
        Private objent As Entity.Visita.InternoPJ = Nothing
        Private objEntCol As Entity.Visita.InternoPJCol = Nothing

        Private frmLoad As Load.frmLoad = Nothing
#Region "Propiedades_Parametricas"
        Private lngFechaVisita As Long = 0
        Public Property _IDInternoPJ As Integer = -1
        Public Property _IDPenal() As Integer
            Get
                Return Me.UscRegionPenalLabel1._Penalid
            End Get
            Set(ByVal value As Integer)
                Me.UscRegionPenalLabel1._Penalid = value
            End Set
        End Property
        Public Property _PenalNombre() As String
            Get
                Return Me.UscRegionPenalLabel1._PenalNombre
            End Get
            Set(ByVal value As String)
                Me.UscRegionPenalLabel1._PenalNombre = value
            End Set
        End Property
        Public Property _IDRegion() As Integer
            Get
                Return Me.UscRegionPenalLabel1._RegionId
            End Get
            Set(ByVal value As Integer)
                Me.UscRegionPenalLabel1._RegionId = value
            End Set
        End Property
        Public Property _RegionNombre() As String
            Get
                Return Me.UscRegionPenalLabel1._RegionNombre
            End Get
            Set(ByVal value As String)
                Me.UscRegionPenalLabel1._RegionNombre = value
            End Set
        End Property
        Private idDocumentoControl As Integer = -1
#End Region
#Region "Propiedades_Grilla"
        Private intNumeroReg As Integer = -1
        Private Property NumeroReg() As Integer
            Get
                Return intNumeroReg
            End Get
            Set(ByVal value As Integer)
                intNumeroReg = value
                'ListarNumeroReg()
            End Set
        End Property
        Private ReadOnly Property GrillaIDInternoPJ() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    'With Me.dgwGrilla
                    '    intValue = .SelectedRows(0).Cells("col_id").Value
                    'End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

#End Region

#Region "Propiedades_Return"
        Public ReadOnly Property _GrillaIDInternoPJ() As Integer
            Get
                Return Me.GrillaIDInternoPJ
            End Get
        End Property
        Public Property _TipoForm() As Integer = 0
#End Region
#Region "Propiedades_Buscar"
        Private Property IDTipoDocumento() As Integer
            Get
                Return Me.cbbTipoDoc.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
            End Set
        End Property
        Private Property NumeroDocumento() As String
            Get
                Return Me.txtNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNumDoc.Text = value
            End Set
        End Property
        Private Property PrimerApellido() As String
            Get
                Return Me.txtApePat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApePat.Text = value
            End Set
        End Property
        Private Property SegundoApellido() As String
            Get
                Return Me.txtApeMat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApeMat.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
        Private Property Sexo() As Integer
            Get
                Return Me.cbbSexo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbSexo.SelectedValue = value
            End Set
        End Property
        Private Property FechaNacimiento() As Long
            Get
                Return Me.dtpFechaNac.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaNac.ValueLong = value
            End Set
        End Property
        Private Property TipoDocumento() As Integer
            Get
                Return Me.cbbTipoDoc.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
            End Set
        End Property
        Private Property IDPabellonID() As Integer
            Get
                Return Me.cbbPabellon._SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbPabellon._SelectedValue = value
            End Set
        End Property
        Private Property IDNacionalidad() As Integer
            Get
                Return Me.cbbNacionalidad.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbNacionalidad.SelectedValue = value
            End Set
        End Property
        Private Property FechaIngreso() As Long
            Get
                Return Me.dtpFechaIng.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaIng.ValueLong = value
            End Set
        End Property
      
        Private Property EstadoID() As Integer
            Get
                Dim _int As Integer = -1
                If chk_estado.Checked = True Then
                    _int = 1
                Else
                    _int = 0
                End If
                Return _int
            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case 1
                        chk_estado.Checked = True
                    Case 0
                        chk_estado.Checked = False
                End Select
            End Set

        End Property
        Private Property Obs() As String
            Get
                Return Me.txtobservacion.Text
            End Get
            Set(ByVal value As String)
                Me.txtobservacion.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Load"
        Private intIDTipoDocumento As String = ""
        Private strLoadNumDoc As String = ""
        Private strLoadApe As String = ""
        Private strLoadNombres As String = ""
        Private intLoadEstado As Integer = -1
        Private intLoadRegion As Integer = -1
        Private intLoadPenal As Integer = -1
#End Region
#Region "Propiedades_Otros"

        'Private intTipoForm As Integer = 0

        'Public Property _TipoForm() As Integer
        '    Get
        '        Return intTipoForm
        '    End Get
        '    Set(ByVal value As Integer)
        '        intTipoForm = value
        '    End Set
        'End Property

        Public Property _VisibleRegionPenal() As Boolean
            Get
                Return Me.gbRegionPenal.Visible
            End Get
            Set(value As Boolean)
                Me.gbRegionPenal.Visible = value
            End Set
        End Property

#End Region
#Region "Functions"
       
#End Region

#Region "Combo"

        Private Sub Combo()

            Me.cbbSexo._LoadUsc(Type.Combo.ComboTipo.Sexo)

            Me.cbbTipoDoc._LoadUsc(Type.Combo.ComboTipo.TipoDoc)
            Me.IDTipoDocumento = Type.Enumeracion.enmTipoDocumento.DNI   'dni

            Me.cbbNacionalidad._LoadUsc(Type.Combo.ComboTipo.Nacionalidad)
            Me.cbbNacionalidad.SelectedValue = 141
        End Sub
        Private Sub ComboPabellon()

            With Me.cbbPabellon
                ._RegionID = Me._IDRegion
                ._PenalID = Me._IDPenal
                ._Ninguno = True
                ._LoadUsc()
            End With

        End Sub
#End Region
#Region "Listar"
       
       
        Private Sub Listar()

            objBss = New Bussines.Visita.InternoPJ
            objent = New Entity.Visita.InternoPJ
            objEntCol = New Entity.Visita.InternoPJCol


            objent = objBss.Listar(Me._IDInternoPJ)
            Dim objEntFiltro As New Entity.Visita.InternoPJ
            With objent

                Me.PrimerApellido = .PrimerApellido
                Me.SegundoApellido = .SegundoApellido
                Me.Nombres = .PreNombres
                Me.Sexo = .Sexo
                Me.FechaNacimiento = .FechaNacimiento
                Me.IDTipoDocumento = .IDTipoDocumento
                Me.NumeroDocumento = .NumeroDocumento
                Me.IDPabellonID = .IDPabellon
                Me.IDNacionalidad = .IDNacionalidad
                Me.Obs = .Observacion
                Me.FechaIngreso = .FechaIngreso
                Me.EstadoID = .Estado
                Me._IDRegion = .IDRegion
                Me._IDPenal = .IDPenal
            End With
            Me.txtApePat.Focus()
        End Sub
#End Region

#Region "Accion"

        Private Sub AOk()

            'If Me.dgwGrilla.RowCount > 0 Then
            '    Me.DialogResult = Windows.Forms.DialogResult.OK
            'End If

        End Sub
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True

            '/*Primer apellido*/
            If Me.PrimerApellido.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el primer apellido")
                Me.txtApePat.Focus()
                blnValue = False
                Return blnValue
            End If

            '/*segundo apellido*/
            If Me.SegundoApellido.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el segundo apellido")
                Me.txtApeMat.Focus()
                blnValue = False
                Return blnValue
            End If

            '/*nombres*/
            If Me.Nombres.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los prenombres")
                Me.txtNom.Focus()
                blnValue = False
                Return blnValue
            End If

            '/*fecha nacimiento*/
            If Me.chkOmitirFecha.Checked = False Then

                If Me.FechaNacimiento < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha de nacimiento")
                    Me.dtpFechaNac.Focus()
                    blnValue = False
                    Return blnValue
                End If

                '/*fecha nacimiento>18 */
                'If Me.FechaNacimiento > 0 Then
                '    Dim dteFechaNac As Date = Me.dtpFechaNac.Value
                '    Dim dteFechaMay18 As Date = DateAdd(DateInterval.Year, -18, _
                '                                         Legolas.Configuration.Aplication.FechayHora.FechaDate)

                '    If dteFechaNac <= dteFechaMay18 Then
                '        Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de nacimiento, debe ser menor los 18 años")
                '        Me.dtpFechaNac.Focus()
                '        blnValue = False
                '        Return blnValue
                '    End If
                'End If
            Else
                Me.FechaNacimiento = 0
            End If

            '/*sexo*/
            If Me.Sexo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el sexo")
                Me.cbbSexo.Focus()
                blnValue = False
                Return blnValue
            End If
            If Me.TipoDocumento = Type.Enumeracion.enmTipoDocumento.DNI Then
                If (Me.NumeroDocumento).Length < 8 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nº de DNI es incorrecto")
                    Me.txtNumDoc.Focus()
                    blnValue = False
                    Return blnValue
                End If
            End If
            '/*nacionalidad*/
            If Me.IDNacionalidad < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione la nacionalidad")
                Me.cbbNacionalidad.Focus()
                blnValue = False
                Return blnValue
            End If

            Return blnValue

        End Function
      
#End Region
#Region "Form"

#End Region
#Region "Otros"
        Private Sub ALimpiar()

            Me.IDTipoDocumento = -1
            Me.NumeroDocumento = ""
            Me.PrimerApellido = ""
            Me.SegundoApellido = ""
            Me.Nombres = ""
            Me.txtApePat.Focus()

        End Sub
        Private Sub ValoresxDefault()
         
            Combo()
            ComboPabellon()
            gbRegionPenal.Visible = False
            chk_estado.Enabled = False
            If Me._IDPenal < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Falta enviar la Propiedad _PenalID")
                Exit Sub
            End If
           
        End Sub
        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            Dim value As Integer = -1

            objBss = New Bussines.Visita.InternoPJ

            Me.PrimerApellido = Legolas.Components.Cadena.LimpiarEspacios(Me.PrimerApellido)
            Me.SegundoApellido = Legolas.Components.Cadena.LimpiarEspacios(Me.SegundoApellido)
            Me.Nombres = Legolas.Components.Cadena.LimpiarEspacios(Me.Nombres)

            objent = New Entity.Visita.InternoPJ

            With objent
                .Codigo = Me._IDInternoPJ
                .IDTipoDocumento = Me.IDTipoDocumento
                .NumeroDocumento = Me.NumeroDocumento
                .PrimerApellido = Me.PrimerApellido
                .SegundoApellido = Me.SegundoApellido
                .PreNombres = Me.Nombres
                .Sexo = Me.Sexo
                .FechaNacimiento = Me.FechaNacimiento
                .IDNacionalidad = Me.IDNacionalidad
                .IDPabellon = Me.IDPabellonID
                .Estado = Me.EstadoID
                .Observacion = Me.Obs
                .FechaIngreso = Me.FechaIngreso
                .IDRegion = Me._IDRegion
                .IDPenal = Me._IDPenal
            End With

            value = objBss.Grabar(objent)

            Me._IDInternoPJ = value

            If Me._IDInternoPJ > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
#End Region
     

       

        Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

            'frmLoad.Dispose()
            Dim result As Boolean = False
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                Me.Timer1.Stop()
                frmLoad.Close()
                result = e.Result
                ' procesa el resultado del metodo ping        
            End If

        End Sub



        Private Sub dgwGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

            Try
                'With Me.dgwGrilla
                '    If e.RowIndex = -1 Then
                '        .Cursor = Cursors.WaitCursor
                '        objEntCol.Sort(.Columns(e.ColumnIndex).DataPropertyName)
                '        .Refresh()
                '        .Cursor = Cursors.Default
                '    End If
                'End With
            Catch ex As Exception

            End Try

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

            'If Me.dgwGrilla.RowCount > 0 And e.RowIndex <> -1 Then
            '    btnAceptar_Click(sender, e)
            'End If


        End Sub

        Private Sub frmMantInternoPopup_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        End Sub

        Private Sub frmInternoPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            If Me._IDInternoPJ > 0 Then
                Listar()
            End If

        End Sub

        Private Sub frmInternoPopup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ValoresxDefault()

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            Me.Close()

        End Sub

        Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            ALimpiar()

        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            'If Me.dgwGrilla.RowCount < 1 Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Busque y seleccione el interno")
            '    Exit Sub
            'End If

            'With Me.dgwGrilla
            AOk()
            'End With

        End Sub

        Private Sub btnOtro_Click(sender As System.Object, e As System.EventArgs)

            Me._TipoForm = 1
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End Sub

       
        Private Sub btnGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabar.Click
            AGrabar()
        End Sub

       
        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub chkOmitirFecha_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOmitirFecha.CheckedChanged

        End Sub

        Private Sub chkOmitirFecha_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles chkOmitirFecha.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub txtNumDoc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumDoc.KeyPress
            Select Case Me.TipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.DNI
                    txtNumDoc.MaxLength = 8
                    txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
                Case Else
                    txtNumDoc.MaxLength = 20
                    Select Case Me.TipoDocumento
                        Case Type.Enumeracion.enmTipoDocumento.LM
                            txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
                        Case Else
                            txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
                    End Select
            End Select
        End Sub

        Private Sub cbbTipoDoc__SelectedIndexChanged() Handles cbbTipoDoc._SelectedIndexChanged
            If Me.TipoDocumento <> idDocumentoControl Then
                idDocumentoControl = Me.TipoDocumento
                Me.txtNumDoc.Text = ""
                Me.txtNumDoc.Focus()
            End If
        End Sub

        Private Sub txtNumDoc_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumDoc.TextChanged
            If Me.TipoDocumento = Type.Enumeracion.enmTipoDocumento.DNI Or Me.TipoDocumento = Type.Enumeracion.enmTipoDocumento.LM Then
                Select Case Me.NumeroDocumento
                    Case "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "V", "W", "X", "Y", "Z"
                        Me.NumeroDocumento = ""
                End Select
            End If
        End Sub
    End Class
End Namespace


