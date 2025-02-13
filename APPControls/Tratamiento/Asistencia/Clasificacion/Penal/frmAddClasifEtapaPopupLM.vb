Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal
Imports Microsoft.Win32

Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class frmAddClasifEtapaPopupLM
        Public Property TIPO_PROCESO_CLASIF As String = ""

        Public Property _IDInterno As Integer = -1
        Public Property _IDIngresoInpe As Integer = -1
        Public Property _IDIngreso As Integer = -1
        Public Property _IDRegion As Integer = -1
        Public Property _IDPenal As Integer = -1

        Public Property IDInternoPabellon As Integer = -1
        Public ReadOnly Property FechaClasificacionRegimen As Long
            Get
                If rdbRegimenETL.Checked Then
                    Return Me.FechaClasificacionRegimen_ETL
                Else
                    Return Me.FechaClasificacionRegimen_LM
                End If
            End Get
        End Property
        Public ReadOnly Property IDRegimen As Integer
            Get
                If rdbRegimenETL.Checked Then
                    Return Me.IDRegimen_ETL
                Else
                    Return Me.IDRegimen_LM
                End If
            End Get
        End Property
        Public ReadOnly Property IDSituacionJuridica As Integer
            Get
                If rdbRegimenETL.Checked Then
                    Return IDSitucionJuridica_ETL
                Else
                    Return Me.IDSitucionJuridica_LM
                End If
            End Get
        End Property
        Public Property Estado As Integer = 1
        Public Property NumeroClasificacion As Integer = 0


#Region "Carceleta"
        Private Property FechaClasificacionRegimen_LM() As Long
            Get
                Return dtpFechaLM.ValueLong
            End Get
            Set(value As Long)
                dtpFechaLM.ValueLong = value
            End Set
        End Property

        Private Property FechaClasificacionRegimen_ETL() As Long
            Get
                Return dtpFechaRegimen.ValueLong
            End Get
            Set(value As Long)
                dtpFechaRegimen.ValueLong = value
            End Set
        End Property
        Private ReadOnly Property FechaHoraClasificacion_ETAPA As Long
            Get
                Dim value As Long = 0

                If FechaClasificacionRegimen_ETL > 0 Then
                    Dim dteFecha As Date = Me.dtpFechaETAPA.Value & " " & dtpHoraETAPA.Value.ToString("HH:mm") & ":00"
                    value = dteFecha.ToFileTime

                End If

                Return value
            End Get
        End Property
        Private ReadOnly Property FechaHoraClasificacion_ETL As Long
            Get
                Dim value As Long = 0

                If FechaClasificacionRegimen_ETL > 0 Then
                    Dim dteFecha As Date = Me.dtpFechaRegimen.Value & " " & dtpHoraRegimen.Value.ToString("HH:mm") & ":00"
                    value = dteFecha.ToFileTime

                End If

                Return value
            End Get
        End Property
        Private ReadOnly Property FechaHoraClasificacionCadena_ETL As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaHoraClasificacion_ETL, True)
            End Get
        End Property
        Private Property IDSitucionJuridica_ETL() As Short
            Get
                Return Me.cbbSitJuridicaETL.SelectedIndex
            End Get
            Set(value As Short)
                Me.cbbSitJuridicaETL.SelectedIndex = value
            End Set
        End Property
        Private Property IDSitucionJuridica_LM() As Short
            Get
                Return Me.cbbSitJuridicaLM.SelectedIndex
            End Get
            Set(value As Short)
                Me.cbbSitJuridicaLM.SelectedIndex = value
            End Set
        End Property
        Private ReadOnly Property SituacionJuridica_ETL As String
            Get
                Return Me.cbbSitJuridicaETL.Text.ToUpper
            End Get
        End Property
        Private Property IDRegimen_ETL() As Short
            Get
                Return Me.cbbRegimenETL.SelectedIndex
            End Get
            Set(value As Short)
                Me.cbbRegimenETL.SelectedIndex = value
            End Set
        End Property
        Private Property IDRegimen_LM() As Short
            Get
                Return Me.cbbRegimenLM.SelectedIndex
            End Get
            Set(value As Short)
                Me.cbbRegimenLM.SelectedIndex = value
            End Set
        End Property
#End Region


#Region "Combo"

        Private Sub ComboSituacionJuridica_ETL()

            With Me.cbbSitJuridicaETL
                .Items.Clear()
                .Items.Add("[Seleccione]")
                .Items.Add("Procesado")
                .Items.Add("Sentenciado")
            End With
            Me.IDSitucionJuridica_ETL = 0
        End Sub
        Private Sub ComboRegimen_ETL()
            With Me.cbbRegimenETL
                .Items.Clear()
                .Items.Add("[Seleccione]")
                .Items.Add("Regimen Cerrado Ordinario - R.C.O.")
                .Items.Add("Regimen Cerrado Especial - R.C.E.")
            End With

        End Sub
        Private Sub ComboSituacionJuridica_LM()

            With Me.cbbSitJuridicaLM
                .Items.Clear()
                .Items.Add("[Seleccione]")
                .Items.Add("Procesado")
                .Items.Add("Sentenciado")
            End With
            Me.IDSitucionJuridica_LM = 0
        End Sub
        Private Sub ComboRegimen_LM()
            With Me.cbbRegimenLM
                .Items.Clear()
                .Items.Add("[Seleccione]")
                .Items.Add("Regimen Cerrado Ordinario - R.C.O.")
                .Items.Add("Regimen Cerrado Especial - R.C.E.")
            End With

        End Sub
        Private Sub CargarCombo()
            ComboSituacionJuridica_ETL()
            ComboRegimen_ETL()
            ComboSituacionJuridica_LM()
            ComboRegimen_LM()
        End Sub
#End Region

        Private Function ValidarNuevaEtapa()

            Dim value As Boolean = False

            If (New InternoPabellon_BL).fn_ObtenerIDFichaRegimen(Me.IDInternoPabellon) < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha finalizado la clasificación del régimen del interno, verifique")
                Return value
            End If

            If Me.IDRegimen > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro de la clasificación de etapa del interno, ya se encuentra activo")
                Return value
            End If

            Return True

        End Function

        Private Sub loadData()
            Dim objEntInternoPab As New InternoPabellon_BE

            With objEntInternoPab
                .IDInterno = Me._IDInterno
                .IDIngresoInpe = Me._IDIngresoInpe
                .Estado = 1 'activo
            End With

            objEntInternoPab = (New InternoPabellon_BL).ListarClasificacionPendiente(objEntInternoPab)

            If objEntInternoPab IsNot Nothing Then

                Dim dteFecha As Date = Now

                With objEntInternoPab
                    Me.IDInternoPabellon = .Codigo
                    Me.NumeroClasificacion = .NumeroClasificacionEtapa

                    Me.FechaClasificacionRegimen_LM = .FechaClasificacionRegimen
                    dteFecha = Legolas.Components.FechaHora.FechaDate(.FechaClasificacionRegimen, True)
                    dtpHoraLM.Value = dteFecha

                    Me.IDSitucionJuridica_LM = .IDSituacionJuridica
                    Me.IDRegimen_LM = .IDRegimen
                    Me.Estado = .Estado
                End With

                If objEntInternoPab.TipoProcesoClasificacion = "PC" Then
                    rdbClasifRegimenPenal.Checked = True
                    rdbRegimenETL.Enabled = False
                    GroupBox2.Enabled = False
                    GroupBox1.Enabled = False
                    grupLM.Enabled = True
                End If
            End If


        End Sub
        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End Sub


        Private Function GrabarGrupoClasificacionEtapaVacio(tipoProcesoClasificacion As String) As Integer
            Dim value As Integer = -1

            Dim strMensajeOut As String = ""

            Dim objEnt As New InternoPabellon_BE

            With objEnt
                .Codigo = -1
                .IDInterno = Me._IDInterno
                .IDIngresoInpe = Me._IDIngresoInpe
                .IDIngreso = Me._IDIngreso
                .FechaClasificacionRegimen = Me.FechaHoraClasificacion_ETL
                .FechaClasificacionEtapa = Me.FechaHoraClasificacion_ETAPA
                .IDSituacionJuridica = Me.IDSitucionJuridica_ETL
                .IDRegimen = Me.IDRegimen_ETL
                .NumeroClasificacionRegimen = 0
                .IDRegion = Me._IDRegion
                .IDPenal = Me._IDPenal
                .Estado = 1 'activo
                .TipoProcesoClasificacion = tipoProcesoClasificacion
            End With

            Me.IDInternoPabellon = (New InternoPabellon_BL).Grabar(objEnt, strMensajeOut)
            objEnt = (New InternoPabellon_BL).Listar(Me.IDInternoPabellon)

            Me.NumeroClasificacion = objEnt.NumeroClasificacionEtapa

            Return Me.IDInternoPabellon
        End Function

        Private Function isValido() As Boolean
            Dim fecHoy As Long = DateTime.Now.ToFileTime()
            If rdbRegimenETL.Checked Then
                If dtpFechaRegimen.ValueLong = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Ingrese fecha de clasificación a RÉGIMEN.")
                    dtpFechaRegimen.Focus()
                    Return False
                End If
                If dtpFechaRegimen.ValueLong > fecHoy Then
                    Legolas.Configuration.Aplication.MessageBox.Information("La hora de clasificación a régimen no puede ser mayor a la fecha actual.")
                    dtpFechaRegimen.Focus()
                    Return False
                End If
                If dtpFechaETAPA.ValueLong > fecHoy Then
                    Legolas.Configuration.Aplication.MessageBox.Information("La hora de clasificación a etapa no puede ser mayor a la fecha actual.")
                    dtpFechaRegimen.Focus()
                    Return False
                End If

                If dtpHoraRegimen.Value.Hour = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("La hora de clasificación a régimen parece incorrecto.")
                    dtpFechaRegimen.Focus()
                    Return False
                End If
                If dtpHoraETAPA.Value.Hour = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("La hora de clasificación a etapa parece incorrecto.")
                    dtpFechaRegimen.Focus()
                    Return False
                End If

                If dtpFechaETAPA.ValueLong = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Ingrese fecha de clasificación a ETAPA.")
                    dtpFechaETAPA.Focus()
                    Return False
                End If
                If cbbSitJuridicaETL.Text = "[Seleccione]" Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Seleccione situación jurídica.")
                    Return False
                End If
                If cbbRegimenETL.Text = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Seleccione régimen.")
                    Return False
                End If
            Else
                If Me.FechaClasificacionRegimen_LM = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Primero debe clasificar al interno a RÉGIMEN.")
                    Return False
                End If
            End If

            Return True
        End Function

        Private Function Grabar() As Boolean
            Dim value As Integer = -1
            Dim strMensajeOut As String = ""

            If isValido() = False Then Return False

            If rdbClasifRegimenPenal.Checked Then
                If ValidarNuevaEtapa() = False Then
                    Me.DialogResult = DialogResult.Cancel
                    Me.Close()
                    Return False
                End If
                value = (New InternoPabellon_BL()).GrabarRegimen_LM(Me.IDInternoPabellon, Me._IDIngresoInpe, strMensajeOut)
                TIPO_PROCESO_CLASIF = "PC"
            Else ''insertar clasificacion sin REGIMEN
                value = GrabarGrupoClasificacionEtapaVacio("PE") 'proceso de clasificaicon inicial desde ETAPA
                TIPO_PROCESO_CLASIF = "PE"
            End If

            If value < 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Ocurrió un error interno, " & strMensajeOut)
                Return False
            End If

            Legolas.Configuration.Aplication.MessageBox.InformationOperacion()

            If rdbClasifRegimenPenal.Checked Then
                loadData()
            End If

            Return True
        End Function
        Private Sub btnGrabarClasificacion_Click(sender As Object, e As EventArgs) Handles btnGrabarClasificacion.Click
            If Grabar() = False Then Exit Sub

            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub

        Private Sub frmAddClasifEtapaPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CargarCombo()
            loadData()
        End Sub


        Private Sub rdbRegimenETL_Click(sender As Object, e As EventArgs) Handles rdbRegimenETL.Click

            GroupBox2.Enabled = True
            GroupBox1.Enabled = True
            grupLM.Enabled = False
        End Sub

        Private Sub rdbClasifRegimenPenal_Click(sender As Object, e As EventArgs) Handles rdbClasifRegimenPenal.Click
            GroupBox2.Enabled = False
            GroupBox1.Enabled = False
            grupLM.Enabled = True
        End Sub

        Private Sub rdbClasifRegimenPenal_CheckedChanged(sender As Object, e As EventArgs) Handles rdbClasifRegimenPenal.CheckedChanged

        End Sub
    End Class
End Namespace