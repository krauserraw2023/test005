Public Class uscFrecuencia
#Region "Propiedades"
    Public Property _FechaInicio() As Long
        Get
            Return Me.dtpFechaInicio.ValueLong
        End Get
        Set(ByVal value As Long)
            Me.dtpFechaInicio.ValueLong = value
        End Set
    End Property
    Public Property _Indeterminado() As Boolean
        Get
            Return Me.chkIndeterminado.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkIndeterminado.Checked = value
        End Set
    End Property
    Public Property _FechaFin() As Long
        Get
            Return Me.dtpFechaFin.ValueLong
        End Get
        Set(ByVal value As Long)
            Me.dtpFechaFin.ValueLong = value
        End Set
    End Property
    Public Property _Anio() As Integer
        Get
            Return Me.Anio
        End Get
        Set(value As Integer)
            Me.Anio = value
        End Set
    End Property
    Private Property Frecuencia() As Integer
        Get
            Dim value As Integer = -1

            If Me.rdbDiariamente.Checked = True Then
                value = 1
            End If

            If Me.rdbSemanalmente.Checked = True Then
                value = 2
            End If

            If Me.rdbMensualmente.Checked = True Then
                value = 3
            End If

            Return value
        End Get
        Set(ByVal value As Integer)

            Select Case value

                Case 1
                    Me.rdbDiariamente.Checked = True
                Case 2
                    Me.rdbSemanalmente.Checked = True
                Case 3
                    Me.rdbMensualmente.Checked = True
            End Select

            SelectHabilitarFrecuencia()

        End Set
    End Property
    Private Property RepetirFrecuencia() As Integer
        Get
            Dim value As Integer = 0

            Select Case Me.Frecuencia
                Case Type.Enumeracion.Visita.Frecuencia.Diario  'diariamente
                    value = Me.nupRepetirDia.Value
                Case Type.Enumeracion.Visita.Frecuencia.Semanal  'semanlemnte
                    value = Me.nupRepetirSemana.Value
                Case Type.Enumeracion.Visita.Frecuencia.Mensual  'mensualmente
                    value = 0
            End Select
            Return value
        End Get
        Set(ByVal value As Integer)

            Select Case Me.Frecuencia
                Case Type.Enumeracion.Visita.Frecuencia.Diario 'diariamente
                    Me.nupRepetirDia.Value = value
                Case Type.Enumeracion.Visita.Frecuencia.Semanal 'semanlemnte
                    Me.nupRepetirSemana.Value = value
                Case Type.Enumeracion.Visita.Frecuencia.Mensual 'mensualmente
                    value = 0
            End Select
        End Set
    End Property
#Region "Dias"
    Public Property _DiaSemanaLunes() As Boolean
        Get
            Return Me.chkLunes.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkLunes.Checked = value
        End Set
    End Property
    Public Property _DiaSemanaMartes() As Boolean
        Get
            Return Me.chkMartes.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkMartes.Checked = value
        End Set
    End Property
    Public Property _DiaSemanaMiercoles() As Boolean
        Get
            Return Me.chkMiercoles.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkMiercoles.Checked = value
        End Set
    End Property
    Public Property _DiaSemanaJueves() As Boolean
        Get
            Return Me.chkJueves.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkJueves.Checked = value
        End Set
    End Property
    Public Property _DiaSemanaViernes() As Boolean
        Get
            Return Me.chkViernes.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkViernes.Checked = value
        End Set
    End Property
    Public Property _DiaSemanaSabado() As Boolean
        Get
            Return Me.chkSabado.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkSabado.Checked = value
        End Set
    End Property
    Public Property _DiaSemanaDomingo() As Boolean
        Get
            Return Me.chkDomingo.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkDomingo.Checked = value
        End Set
    End Property
#End Region
#Region "Meses"
    Private strMensualMesID As String = ""
    Private strMensualDiasID As String = ""
    Private strMensualElID As String = ""
    Private strMensualDiaSemanaID As String = ""
    Private Property Anio() As Integer
        Get
            Return Me.cbbAnio.Value
        End Get
        Set(value As Integer)
            Me.cbbAnio.Value = value
        End Set
    End Property
    Private Property MesesTipo() As Integer
        Get
            Dim value As Integer = -1

            Select Case Me.Frecuencia
                Case Type.Enumeracion.Visita.Frecuencia.Mensual  ' frecuencia de mes

                    If Me.rdbDias.Checked = True Then
                        value = 1
                    End If

                    If Me.rdbEl.Checked = True Then
                        value = 2
                    End If

            End Select

            Return value
        End Get
        Set(ByVal value As Integer)

            Select Case Me.Frecuencia

                Case Type.Enumeracion.Visita.Frecuencia.Mensual 'frecuencia de mes
                    Select Case value
                        Case 1
                            Me.rdbDias.Checked = True
                        Case 2
                            Me.rdbEl.Checked = True
                    End Select
            End Select

        End Set
    End Property
    Public Property _MensualMesID() As String
        Get
            Return strMensualMesID
        End Get
        Set(ByVal value As String)
            strMensualMesID = value
            MostrarNombreMeses()
        End Set
    End Property
    Private Property MensualMes() As String
        Get
            Return Me.txtMes.Text
        End Get
        Set(ByVal value As String)
            Me.txtMes.Text = value
        End Set
    End Property
    Public Property _MensualDiasID() As String
        Get
            Return strMensualDiasID
        End Get
        Set(ByVal value As String)
            strMensualDiasID = value
            MostrarDiasCalendario()
        End Set
    End Property
    Private Property MensualDias() As String
        Get
            Return Me.txtDias.Text
        End Get
        Set(ByVal value As String)
            Me.txtDias.Text = value
        End Set
    End Property
    Public Property _MensualElID() As String
        Get
            Return strMensualElID
        End Get
        Set(ByVal value As String)
            strMensualElID = value
            MostrarEl()
        End Set
    End Property
    Private Property MensualEl() As String
        Get
            Return Me.txtEl.Text
        End Get
        Set(ByVal value As String)
            Me.txtEl.Text = value
        End Set
    End Property
    Public Property _MensualDiaSemanaID() As String
        Get
            Return strMensualDiaSemanaID
        End Get
        Set(ByVal value As String)
            strMensualDiaSemanaID = value
            MostrarNombreDiaSemana()
        End Set
    End Property
    Private Property MensualDiaSemana() As String
        Get
            Return Me.txtDiaSemana.Text
        End Get
        Set(ByVal value As String)
            Me.txtDiaSemana.Text = value
        End Set
    End Property
#End Region
#End Region
#Region "Propiedades_Publicas"
    Public Property _Frecuencia() As Integer
        Get
            Return Me.Frecuencia
        End Get
        Set(ByVal value As Integer)
            Me.Frecuencia = value
        End Set
    End Property
    Public Property _FrecuenciaRepeticion() As Integer
        Get
            Return Me.RepetirFrecuencia
        End Get
        Set(ByVal value As Integer)
            Me.RepetirFrecuencia = value
        End Set
    End Property
    Public Property _MensualMesTipo() As Integer
        Get
            Return Me.MesesTipo
        End Get
        Set(ByVal value As Integer)
            Me.MesesTipo = value
        End Set
    End Property
#End Region
#Region "Combo"
    Private Sub ComboAnio()

        With Me.cbbAnio
            .AnioInicio = 2014
            .AnioFin = Legolas.Configuration.Aplication.FechayHora.FechaAnio + 1
            .LoadUsc()
        End With

    End Sub
#End Region
#Region "Functions"
    Private Function Validar() As Boolean

        Dim value As Boolean = False

        Select Case Me.Frecuencia
            Case 1 'diariamente

                'frecuencia 
                If Me.Frecuencia < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "Ingrese y/o seleccione la frecuencia de dias")
                    Return value
                End If

            Case 2 'semanalmente

                'frecuencia
                If Me.Frecuencia < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "Ingrese y/o seleccione la frecuencia de semanas")
                    Return value
                End If

                'verificar si se ha seleccionado al menos algun dia
                Dim intCount As Integer = 0
                For Each Control As Control In Me.pnlSemanalmente.Controls
                    If Control.GetType.Name.ToUpper = "myCheckBox".ToUpper Then

                        Dim myCheckBox As Legolas.APPUIComponents.myCheckBox
                        myCheckBox = CType(Control, Legolas.APPUIComponents.myCheckBox)
                        If myCheckBox.Checked = True Then
                            intCount += 1
                        End If

                    End If
                Next

                If intCount < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                      "No ha seleccionado ningun dia de la semana")
                    Return value
                End If

            Case 3 'mensualmente

                'año
                If Me.Anio < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                     "Seleccione año")
                    Me.cbbAnio.Focus()
                    Return value
                End If

                'meses
                If Me._MensualMesID.Trim.Length < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Seleccione meses")
                    Return value
                End If

                Select Case Me.MesesTipo
                    Case 1 'dias

                        'dias
                        If Me._MensualDiasID.Trim.Length < 1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                            "Seleccione dias")
                            Return value
                        End If

                    Case 2 'el

                        'el
                        If Me._MensualElID.Trim.Length < 1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                            "Seleccione el")
                            Return value
                        End If

                        'dia semana
                        If Me._MensualDiaSemanaID.Trim.Length < 1 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                            "Seleccione dia semana")
                            Return value
                        End If

                End Select
        End Select

        ListarFechaIniFin()
        value = True

        Return value

    End Function
    Private Sub ListarFechaIniFin()

        Select Case Me.Frecuencia

            Case Type.Enumeracion.Visita.Frecuencia.Diario

                Me._FechaFin = Me._FechaInicio

            Case Type.Enumeracion.Visita.Frecuencia.Mensual

                'hallar fecha inicio
                Dim intMes As Integer = 0
                Dim intDiaFI As Integer = 0
                Dim intDiaFF As Integer = 0
                Dim dteFI As Date = Now
                Dim dteFF As Date = Now

                Dim strMes As String() = Me._MensualMesID.Split(",")
                Dim strNumDia As String() = Me._MensualDiasID.Split(",")
                Dim intNumDiaCount As Short = strNumDia.Length - 1

                intMes = strMes(0)
                intDiaFI = strNumDia(0)
                intDiaFF = strNumDia(intNumDiaCount)

                dteFI = Legolas.Components.FechaHora.FechaDateConcatenar(Me.Anio, intMes, intDiaFI)
                dteFF = Legolas.Components.FechaHora.FechaDateConcatenar(Me.Anio, intMes, intDiaFF)

                Me._FechaInicio = Legolas.Components.FechaHora.FechaLong(dteFI)
                Me._FechaFin = Legolas.Components.FechaHora.FechaLong(dteFF)

        End Select

    End Sub
    Public Function _Validar() As Boolean
        Return Me.Validar
    End Function
    Public Sub _HabilitarDiaElDiaSemana()
        HabilitarDiaElDiaSemana()
    End Sub
    Public Sub _HabilitarIndeterminado()
        HabilitarFechaFin()
    End Sub
#End Region
#Region "Otros"

    Private Sub HabilitarFechaFin()

        If Me._Indeterminado = True Then
            Me.dtpFechaFin.ValueLong = 0
        End If

        Me.dtpFechaFin.Enabled = Not Me._Indeterminado

    End Sub
    Private Sub MostrarNombreMeses()

        If Me._MensualMesID Is Nothing = False Then

            If Me._MensualMesID.Trim.Length > 0 Then

                Dim strCadena As String() = Me._MensualMesID.Split(",")
                Dim strReturn As String = ""
                Dim intMes As Integer = -1

                For Each str As String In strCadena
                    intMes = Integer.Parse(str)
                    strReturn = strReturn & Legolas.Components.Cadena.ProperCase(Legolas.Components.FechaHora.MesNombre(intMes)) & ", "
                Next

                Me.MensualMes = strReturn.Substring(0, Len(strReturn) - 2)
            End If

        End If

    End Sub
    Private Sub MostrarDiasCalendario()

        If Me._MensualDiasID Is Nothing = False Then

            If Me._MensualDiasID.Trim.Length > 0 Then

                Dim strCadena As String() = Me._MensualDiasID.Split(",")
                Dim strReturn As String = ""
                Dim strValor As String = ""

                For Each str As String In strCadena

                    strValor = str
                    If strValor.ToUpper = "32".ToUpper Then
                        strValor = "Ultimo"
                    End If

                    strReturn = strReturn & strValor & ", "
                Next

                Me.MensualDias = strReturn.Substring(0, Len(strReturn) - 2)

            End If

        End If

    End Sub
    Private Sub MostrarEl()

        If Me._MensualElID Is Nothing = False Then

            If Me._MensualElID.Trim.Length > 0 Then

                Dim strCadena As String() = Me._MensualElID.Split(",")
                Dim strReturn As String = ""
                Dim strValor As String = ""

                For Each str As String In strCadena

                    strValor = str

                    Select Case strValor.ToUpper
                        Case 1
                            strValor = "Primero"
                        Case 2
                            strValor = "Segundo"
                        Case 3
                            strValor = "Tercero"
                        Case 4
                            strValor = "Cuarto"
                        Case 5
                            strValor = "Ultimo"
                    End Select
                    'If strValor.ToUpper = "5".ToUpper Then
                    '    strValor = "Ultimo"
                    'End If

                    strReturn = strReturn & strValor & ", "
                Next

                Me.MensualEl = strReturn.Substring(0, Len(strReturn) - 2)

            End If
        End If
    End Sub
    Private Sub MostrarNombreDiaSemana()

        If Me._MensualDiaSemanaID Is Nothing = False Then

            If Me._MensualDiaSemanaID.Trim.Length > 0 Then

                Dim strCadena As String() = Me._MensualDiaSemanaID.Split(",")
                Dim strReturn As String = ""
                Dim intDia As Integer = -1

                For Each str As String In strCadena

                    intDia = str
                    strReturn = strReturn & Legolas.Components.FechaHora.DiaSemanaNombre(intDia) & ", "
                Next

                Me.MensualDiaSemana = strReturn.Substring(0, Len(strReturn) - 2)

            End If
        End If
    End Sub
    Public Sub _LoadUsc()

        ValoresxDefault()
        LoadToolTipText()

    End Sub

    Private Sub ValoresxDefault()

        Me.pnlElDia.Enabled = False
        Me._FechaInicio = Legolas.Configuration.Aplication.FechayHora.FechaLong
        ComboAnio()

    End Sub
    Private Sub HabilitarDiaElDiaSemana()

        Me.pnlDias.Enabled = False
        Me.pnlElDia.Enabled = False

        Select Case Me.MesesTipo
            Case 1 'dias
                Me.pnlDias.Enabled = True

                Me._MensualElID = ""
                Me.MensualEl = ""
                Me._MensualDiaSemanaID = ""
                Me.MensualDiaSemana = ""

            Case 2 'el
                Me.pnlElDia.Enabled = True

                Me._MensualDiasID = ""
                Me.MensualDias = ""
        End Select

    End Sub
    Private Sub SelectHabilitarFrecuencia()

        Me.pnlDiariamente.Visible = False
        Me.pnlSemanalmente.Visible = False
        Me.pnlMensualmente.Visible = False

        LimpiarFrecuenciaDia()
        LimpiarFrecuenciaSemana()
        LimpiarFrecuenciaMes()

        Dim blnFechaInde As Boolean = False
        Dim blnHabilitarFechaInicio As Boolean = False
        Dim blnHabilitarFechaFin As Boolean = False

        Select Case Me.Frecuencia
            Case Type.Enumeracion.Visita.Frecuencia.Diario
                Me.pnlDiariamente.Visible = True
                blnHabilitarFechaInicio = True
            Case Type.Enumeracion.Visita.Frecuencia.Semanal
                Me.pnlSemanalmente.Visible = True
                blnHabilitarFechaInicio = True
                blnHabilitarFechaFin = True
                blnFechaInde = True
            Case Type.Enumeracion.Visita.Frecuencia.Mensual
                Me.pnlMensualmente.Visible = True
                HabilitarDiaElDiaSemana()
        End Select

        Me.chkIndeterminado.Visible = blnFechaInde

        Me.dtpFechaInicio.Enabled = blnHabilitarFechaInicio
        Me.dtpFechaFin.Enabled = blnHabilitarFechaFin

    End Sub
    Public Sub _HabilitarFechaIniFin()

        Dim blnHabilitarFechaInicio As Boolean = False
        Dim blnHabilitarFechaFin As Boolean = False

        Select Case Me.Frecuencia
            Case Type.Enumeracion.Visita.Frecuencia.Diario                
                blnHabilitarFechaInicio = True
            Case Type.Enumeracion.Visita.Frecuencia.Semanal

                blnHabilitarFechaInicio = True

                If Me._Indeterminado = False Then
                    blnHabilitarFechaFin = True
                End If

            Case Type.Enumeracion.Visita.Frecuencia.Mensual
                
        End Select

        Me.dtpFechaInicio.Enabled = blnHabilitarFechaInicio
        Me.dtpFechaFin.Enabled = blnHabilitarFechaFin

    End Sub
    Private Sub LimpiarFrecuenciaDia()

        Me._FrecuenciaRepeticion = 1

    End Sub
    Private Sub LimpiarFrecuenciaSemana()

        For Each Control As Control In Me.pnlSemanalmente.Controls

            If Control.GetType.Name.ToUpper = "myCheckBox".ToUpper Then

                Dim myCheckBox As Legolas.APPUIComponents.myCheckBox
                myCheckBox = CType(Control, Legolas.APPUIComponents.myCheckBox)
                myCheckBox.Checked = False

            End If

        Next
    End Sub
    Private Sub LimpiarFrecuenciaMes()

        Me._MensualMesID = ""
        Me.MensualMes = ""
        Me.MesesTipo = 1 'dias
        Me._MensualDiasID = ""
        Me.MensualDias = ""
        Me._MensualElID = ""
        Me.MensualEl = ""
        Me._MensualDiaSemanaID = ""
        Me.MensualDiaSemana = ""

    End Sub

    Private Sub LoadToolTipText()

        With Me.ToolTip1
            .SetToolTip(Me.txtMes, Me.txtMes.Text)
            .SetToolTip(Me.txtDias, Me.txtDias.Text)
            .SetToolTip(Me.txtEl, Me.txtEl.Text)
            .SetToolTip(Me.txtDiaSemana, Me.txtDiaSemana.Text)
        End With

    End Sub
#End Region
#Region "Form"
    Private Sub FRM_Combo(ByVal Tipo As Type.Enumeracion.Visita.ProgramacionMensual)

        Dim blnOK As Boolean = False
        Dim strID As String = ""
        Dim strText As String = ""

        Select Case Tipo
            Case Type.Enumeracion.Visita.ProgramacionMensual.Meses
                strID = Me._MensualMesID
            Case Type.Enumeracion.Visita.ProgramacionMensual.Dias
                strID = Me._MensualDiasID
            Case Type.Enumeracion.Visita.ProgramacionMensual.El
                strID = Me._MensualElID
            Case Type.Enumeracion.Visita.ProgramacionMensual.DiaSemana
                strID = Me._MensualDiaSemanaID
        End Select

        Dim frm As New frmFrecuenciaPopup
        With frm
            ._IDString = strID
            ._TipoMensual = Tipo
            If .ShowDialog() = DialogResult.OK Then
                strID = ._IDString
                strText = ._Text
                blnOK = True
            End If
        End With

        If blnOK = True Then
            Select Case Tipo
                Case Type.Enumeracion.Visita.ProgramacionMensual.Meses
                    Me._MensualMesID = strID
                    Me.MensualMes = strText
                Case Type.Enumeracion.Visita.ProgramacionMensual.Dias
                    Me._MensualDiasID = strID
                    Me.MensualDias = strText
                Case Type.Enumeracion.Visita.ProgramacionMensual.El
                    Me._MensualElID = strID
                    Me.MensualEl = strText
                Case Type.Enumeracion.Visita.ProgramacionMensual.DiaSemana
                    Me._MensualDiaSemanaID = strID
                    Me.MensualDiaSemana = strText
            End Select
        End If

    End Sub
#End Region

    Private Sub rdbDiariamente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        rdbDiariamente.Click, _
        rdbSemanalmente.Click, _
        rdbMensualmente.Click

        SelectHabilitarFrecuencia()

    End Sub

    Private Sub uscProgramacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.pnlSemanalmente.Visible = False
        Me.pnlMensualmente.Visible = False

    End Sub

    Private Sub btnMeses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMeses.Click

        FRM_Combo(Type.Enumeracion.Visita.ProgramacionMensual.Meses)

    End Sub

    Private Sub btnDias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDias.Click

        FRM_Combo(Type.Enumeracion.Visita.ProgramacionMensual.Dias)

    End Sub

    Private Sub btnEl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEl.Click

        FRM_Combo(Type.Enumeracion.Visita.ProgramacionMensual.El)

    End Sub

    Private Sub btnDiaSemana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiaSemana.Click

        FRM_Combo(Type.Enumeracion.Visita.ProgramacionMensual.DiaSemana)

    End Sub

    Private Sub rdbDias_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        rdbDias.Click, _
        rdbEl.Click

        HabilitarDiaElDiaSemana()

    End Sub

    Private Sub chkIndeterminado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIndeterminado.CheckedChanged

    End Sub

    Private Sub chkIndeterminado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkIndeterminado.Click

        HabilitarFechaFin()

    End Sub

    Private Sub rdbMensualmente_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbMensualmente.CheckedChanged

    End Sub
End Class
