Imports System.Windows.Forms
Imports Type.Enumeracion.Licencia

Namespace Registro.Identificacion.v5
    Public Class frmFamiliarPopupV2

        Private objBss As Bussines.Registro.Familiar = Nothing
        Private objEnt As Entity.Registro.Familiar = Nothing
#Region "Propiedades"

        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property TipoFamiliar() As Integer
            Get
                Try
                    Return Me.cbbTipoFamilia.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try

            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoFamilia.SelectedValue = value
            End Set
        End Property
        Public Property TipoFamiliarAux() As Integer = -1

        Public Property TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno

        Private Property ApellidoPaterno() As String
            Get
                Return Me.txtApePaterno.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApePaterno.Text = value
            End Set
        End Property
        Private Property ApellidoMaterno() As String
            Get
                Return Me.txtApeMaterno.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApeMaterno.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Me.txtNombre.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNombre.Text = value
            End Set
        End Property
        Private Property Sexo() As Integer
            Get
                Return Me.cbbsexo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbsexo.SelectedValue = value
            End Set
        End Property

        Public Property FechaNacimiento() As Long
            Get
                Return Me.dtpFechaNac.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaNac.ValueLong = value
            End Set
        End Property
        Public Property Fallecido() As Boolean
            Get
                Return Me.chkVive.Checked

            End Get
            Set(ByVal value As Boolean)
                Me.chkVive.Checked = value
            End Set
        End Property
        Public Property HijoRecluido() As Boolean
            Get
                'Return Me.chkHijoRec.Checked()
                Return Me.rbtSi.Checked()
            End Get
            Set(ByVal value As Boolean)
                Me.rbtSi.Checked = value
            End Set
        End Property
        Public Property _NroIngresoID() As Integer = -1
        Public Property _NroIngreso() As Integer = 0
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        'Public Property _PenalLM As Boolean = False
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public _objEntColFam As New Entity.Registro.FamiliarCol
        Public Property _NuevoFam As Boolean = False
#End Region
#Region "Combo"
        Private Sub ComboTipoFamiliar()

            With Me.cbbTipoFamilia
                .Parametro1 = 1 'familia
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboSexo()

            Me.cbbsexo.LoadUsc()

        End Sub
#End Region
#Region "Listar"
        Private Sub ListarData()

            If Me.Codigo < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Registro.Familiar
            objEnt = New Entity.Registro.Familiar
            objEnt.Codigo = Me.Codigo

            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objEnt = objBss.Listar_LM(objEnt, "").Familiar(0)
            Else
                objEnt = objBss.Listar2(objEnt)
            End If

            With objEnt
                Me._NroIngreso = .IngresoNro
                Me.TipoFamiliar = .FamiliarTipoID
                Me.TipoFamiliarAux = .FamiliarTipoID
                Me.ApellidoPaterno = .ApellidoPaterno
                Me.ApellidoMaterno = .ApellidoMaterno
                Me.Nombres = .Nombres
                Me.Sexo = .Sexo
                Me.FechaNacimiento = .FechaNacimiento
                Me.Fallecido = Not .Vive
                Me.HijoRecluido = .HijoReclucido
                Me.UscAuditUser1.LoadAudit(Me.Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoFamiliares)
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean
            Dim blnValue As Boolean = False

            '/*Ingreso
            If Not (Me.TipoLicencia = enmTipoLicencia.Carceleta _
                    Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                    Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) And Me._NroIngresoID < 1 Then
                If Me.Codigo < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar N° de ingreso, no se ha enviado el parametro")
                Else

                    Dim objBss As New Bussines.Registro.Ingreso
                    Dim objEntCol As New Entity.Registro.IngresoCol
                    objEntCol = objBss.Listar(-1, Me.InternoID, -1, -1, -1, 0, -1, -1, "", 0, -1, 0, "")
                    If objEntCol.Count = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no posee ningun ingreso, registrar un ingreso")
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
            '/*parentesco
            If Me.TipoFamiliar < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
               "Seleccione el tipo de parentesco")
                Me.cbbTipoFamilia.Focus()
                Return blnValue
            End If
            If Me.TipoFamiliar > 0 Then
                Dim PadreID As Integer = 0
                Dim MadreID As Integer = 0
                If _objEntColFam.Count > 0 Then
                    For Each ent As Entity.Registro.Familiar In _objEntColFam
                        If ent.FamiliarTipoID = 1 Then
                            PadreID = PadreID + 1
                        End If
                        If ent.FamiliarTipoID = 2 Then
                            MadreID = MadreID + 1
                        End If
                    Next
                End If


                If _NuevoFam = True Then
                    If Me.TipoFamiliar = Type.Enumeracion.Parentesco.ParentescoID.Padre And PadreID > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                         "El padre del interno ya ha sido registrado")
                        Me.cbbTipoFamilia.Focus()
                        Return blnValue
                    End If
                    If Me.TipoFamiliar = Type.Enumeracion.Parentesco.ParentescoID.Madre And MadreID > 0 And TipoFamiliar = 2 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La madre del interno ya ha sido registrado")
                        Me.cbbTipoFamilia.Focus()
                        Return blnValue
                    End If
                Else
                    If Me.TipoFamiliarAux <> 1 And Me.TipoFamiliar = 1 And PadreID > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "El padre del interno ya ha sido registrado")
                        Me.cbbTipoFamilia.Focus()
                        Return blnValue
                    End If
                    If Me.TipoFamiliarAux <> 2 And Me.TipoFamiliar = 2 And MadreID > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "La Madre del interno ya ha sido registrado")
                        Me.cbbTipoFamilia.Focus()
                        Return blnValue
                    End If
                End If
                If Me.TipoFamiliar = Type.Enumeracion.Parentesco.ParentescoID.Padre And Me.Sexo = 2 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El sexo del padre no puede ser femenino")
                    Me.cbbsexo.Focus()
                    Return blnValue
                End If
                If Me.TipoFamiliar = Type.Enumeracion.Parentesco.ParentescoID.Madre And Me.Sexo = 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El sexo de la madre no puede ser masculino")
                    Me.cbbsexo.Focus()
                    Return blnValue
                End If
                If Me.TipoFamiliar = Type.Enumeracion.Parentesco.ParentescoID.Yerno And Me.Sexo = 2 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El sexo del Yerno no puede ser femenino")
                    Me.cbbsexo.Focus()
                    Return blnValue
                End If
                If Me.TipoFamiliar = Type.Enumeracion.Parentesco.ParentescoID.Nuera And Me.Sexo = 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El sexo de la Nuera no puede ser masculino")
                    Me.cbbsexo.Focus()
                    Return blnValue
                End If
            End If
            '/*nombres*/
            If Me.Nombres.Length < 1 Or Me.Nombres = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
               "Ingrese los nombres del familiar")
                Me.txtNombre.Focus()
                Return blnValue
            End If

            'fecha nacimiento
            If Me.chkOmitirFecha.Checked = False Then
                If Me.FechaNacimiento < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                   "Ingrese la fecha de nacimiento")
                    Me.dtpFechaNac.Focus()
                    Return blnValue
                End If
            End If

            blnValue = True

            Return blnValue

        End Function
        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            Dim intValue As Integer = -1
            objBss = New Bussines.Registro.Familiar

            Dim EntFam As New Entity.Registro.Familiar
            With EntFam
                If Me.Codigo < 1 Then
                    Me.Codigo = -1
                End If
                .Codigo = Me.Codigo
                .InternoID = Me.InternoID
                .FamiliarTipoID = Me.TipoFamiliar
                .ApellidoPaterno = Me.ApellidoPaterno
                .ApellidoMaterno = Me.ApellidoMaterno
                .Nombres = Me.Nombres
                .Sexo = Me.Sexo
                .FechaNacimiento = Me.FechaNacimiento
                .Vive = Not Me.Fallecido
                .HijoReclucido = Me.HijoRecluido
                .IngresoInpeID = Me._InternoIngresoInpeId
                .IngresoID = Me._NroIngresoID
                Select Case Me.TipoLicencia
                    Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana
                        .IngresoID = -1
                    Case Else
                        .IngresoInpeID = -1
                End Select

                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                intValue = objBss.Grabar_LM(EntFam)
            Else
                intValue = objBss.Grabar2(EntFam)
            End If

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub Usuario_Permiso()

            Me.btnOk.Visible = Me._FormEscritura

        End Sub
        Private Sub ValoresxDefault()

            ComboTipoFamiliar()
            ComboSexo()
            Me.chkHijoRec.Visible = False
            Me.chkOmitirFecha.Visible = False
            Me.lblAlbergado.Visible = False
            Me.gbAlbergado.Visible = False
            Me.chkOmitirFecha.Checked = True

        End Sub
#End Region
        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AGrabar()

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub frmFamiliarPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
            'Usuario_Permiso()
        End Sub

        Private Sub frmFamiliarPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ListarData()
            Usuario_Permiso()

        End Sub

        Private Sub cbbTipoFamilia__ValueChanged() Handles cbbTipoFamilia._SelectedIndexChanged

            If Me.TipoFamiliar = 4 Then 'hijo
                lblAlbergado.Visible = True
                gbAlbergado.Visible = True
                'lblFechanac.Visible = True
                'dtpFechaNac.Visible = True
                chkOmitirFecha.Visible = True
                chkOmitirFecha.Checked = False
            Else
                Select Case Me.TipoFamiliar
                    Case 1, 2 'padre,madre
                        'cbbsexo.Enabled = False
                        cbbsexo.SelectedValue = Me.TipoFamiliar
                    Case Else
                        cbbsexo.Enabled = True
                        cbbsexo.SelectedValue = 1
                End Select
                lblAlbergado.Visible = False
                gbAlbergado.Visible = False
                chkOmitirFecha.Visible = False
                chkOmitirFecha.Checked = True
            End If

        End Sub

        Private Sub chkVive_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles chkVive.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub chkOmitirFecha_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOmitirFecha.CheckedChanged
            If cbbTipoFamilia.SelectedValue = 4 Then
                If chkOmitirFecha.Checked = True Then
                    dtpFechaNac.ValueLong = 0
                Else
                End If
            End If

        End Sub

        Private Sub chkOmitirFecha_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles chkOmitirFecha.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub chkHijoRec_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles chkHijoRec.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub txtApePaterno_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub txtApeMaterno_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub txtNombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub
    End Class
End Namespace