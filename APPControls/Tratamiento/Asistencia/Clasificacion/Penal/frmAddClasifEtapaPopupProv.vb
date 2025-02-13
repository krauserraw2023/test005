Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal
Imports Microsoft.Win32

Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class frmAddClasifEtapaPopupProv
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
        Private Property HoraClasificacion_LM() As String
            Get

                Return Me.nudHora._Value
            End Get
            Set(ByVal value As String)
                Me.nudHora._Value = value
            End Set
        End Property
        Private Property MinutoClasificacion_LM() As String
            Get
                Return Me.nudMinutos._Value
            End Get
            Set(ByVal value As String)
                Me.nudMinutos._Value = value
            End Set
        End Property
        Private Property FechaClasificacionRegimen_LM() As Long
            Get
                Return dtpFecha.ValueLong
            End Get
            Set(value As Long)
                dtpFecha.ValueLong = value
            End Set
        End Property

        Private Property FechaClasificacionRegimen_ETL() As Long
            Get
                Return dtpFechaETL.ValueLong
            End Get
            Set(value As Long)
                dtpFechaETL.ValueLong = value
            End Set
        End Property
        Private Property HoraClasificacion_ETL() As String
            Get

                Return Me.nudHoraETL._Value
            End Get
            Set(ByVal value As String)
                Me.nudHoraETL._Value = value
            End Set
        End Property
        Private Property MinutoClasificacion_ETL() As String
            Get
                Return Me.nudMinutosETL._Value
            End Get
            Set(ByVal value As String)
                Me.nudMinutosETL._Value = value
            End Set
        End Property
        Private Property HoraClasificacion_ETAPA() As String
            Get

                Return Me.nudHoraETAPA._Value
            End Get
            Set(ByVal value As String)
                Me.nudHoraETAPA._Value = value
            End Set
        End Property
        Private Property MinutoClasificacion_ETAPA() As String
            Get
                Return Me.nudMinutosETAPA._Value
            End Get
            Set(ByVal value As String)
                Me.nudMinutosETAPA._Value = value
            End Set
        End Property
        Private ReadOnly Property FechaHoraClasificacion_ETAPA As Long
            Get
                Dim value As Long = 0

                If FechaClasificacionRegimen_ETL > 0 Then
                    Dim dteFecha As Date = Me.dtpFechaETAPA.Value & " " & CStr(Me.HoraClasificacion_ETAPA) & ":" & CStr(Me.MinutoClasificacion_ETAPA) & ":00"
                    value = dteFecha.ToFileTime

                End If

                Return value
            End Get
        End Property
        Private ReadOnly Property FechaHoraClasificacion_ETL As Long
            Get
                Dim value As Long = 0

                If FechaClasificacionRegimen_ETL > 0 Then
                    Dim dteFecha As Date = Me.dtpFechaETL.Value & " " & CStr(Me.HoraClasificacion_ETL) & ":" & CStr(Me.MinutoClasificacion_ETL) & ":00"
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
                Return Me.cbbSitJuridica.SelectedIndex
            End Get
            Set(value As Short)
                Me.cbbSitJuridica.SelectedIndex = value
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
                Return Me.cbbRegimen.SelectedIndex
            End Get
            Set(value As Short)
                Me.cbbRegimen.SelectedIndex = value
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

            With Me.cbbSitJuridica
                .Items.Clear()
                .Items.Add("[Seleccione]")
                .Items.Add("Procesado")
                .Items.Add("Sentenciado")
            End With
            Me.IDSitucionJuridica_LM = 0
        End Sub
        Private Sub ComboRegimen_LM()
            With Me.cbbRegimen
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
                .IDIngreso = Me._IDIngreso
                '.IDIngresoInpe = Me._IDIngresoInpe
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
                    Me.HoraClasificacion_LM = Format(dteFecha, "HH")
                    Me.MinutoClasificacion_LM = Format(dteFecha, "mm")

                    Me.IDSitucionJuridica_LM = .IDSituacionJuridica
                    Me.IDRegimen_LM = .IDRegimen
                    Me.Estado = .Estado
                End With

                If objEntInternoPab.TipoProcesoClasificacion = "PC" Then
                    rdbClasifRegimenPenal.Checked = True
                    rdbRegimenETL.Enabled = False
                    grupoETL.Enabled = False
                    grupProv.Enabled = True
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
            Dim v As Boolean = True
            If rdbRegimenETL.Checked Then
                If dtpFechaETL.ValueLong = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Ingrese fecha de clasificación a RÉGIMEN.")
                    dtpFechaETL.Focus()
                    v = False
                End If
                If dtpFechaETAPA.ValueLong = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Ingrese fecha de clasificación a ETAPA.")
                    dtpFechaETAPA.Focus()
                    v = False
                End If
                If cbbSitJuridicaETL.Text = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Seleccione situación jurídica.")
                    v = False
                End If
                If cbbRegimenETL.Text = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Seleccione régimen.")
                    v = False
                End If
            Else
                If Me.FechaClasificacionRegimen_LM = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Primero debe clasificar al interno a RÉGIMEN.")
                    v = False
                End If
            End If

            Return v
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
                value = (New InternoPabellon_BL()).GrabarRegimen_PROV_v2(Me.IDInternoPabellon, Me._IDIngreso, strMensajeOut)
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

        Private Sub rdbClasifPenal_Click(sender As Object, e As EventArgs) Handles rdbRegimenETL.Click
            grupoETL.Enabled = True
            grupProv.Enabled = False
        End Sub

        Private Sub rdbCarceleta_Click(sender As Object, e As EventArgs) Handles rdbClasifRegimenPenal.Click
            grupoETL.Enabled = False
            grupProv.Enabled = True
        End Sub

    End Class
End Namespace