Public Class uscProgramacionOrdinario
#Region "Propiedades_Publicas"
    Public Property _FamiliarConsanguidadGrado() As Integer
        Get
            Return Me.FamiliarConsanguidadGrado
        End Get
        Set(ByVal value As Integer)
            Me.FamiliarConsanguidadGrado = value
        End Set
    End Property
    Public Property _FamiliarAfinidadGrado() As Integer
        Get
            Return Me.FamiliarAfinidadGrado
        End Get
        Set(ByVal value As Integer)
            Me.FamiliarAfinidadGrado = value
        End Set
    End Property
    Public Property _HoraMinutoInicio() As Integer
        Get
            Dim value As Integer = 0

            value = (Me.InicioHora * 60) + Me.InicioMinuto
            Return value
        End Get
        Set(ByVal value As Integer)

            Dim intHora As Integer = 0
            Dim intMinuto As Integer = 0

            intHora = value \ 60
            intMinuto = ((value / 60) - intHora) * 60

            Me.InicioHora = intHora
            Me.InicioMinuto = intMinuto

        End Set
    End Property
    Public Property _HoraMinutoFin() As Integer
        Get
            Dim value As Integer = 0

            value = (Me.FinHora * 60) + Me.FinMinuto
            Return value
        End Get
        Set(ByVal value As Integer)

            Dim intHora As Integer = 0
            Dim intMinuto As Integer = 0

            intHora = value \ 60
            intMinuto = ((value / 60) - intHora) * 60

            Me.FinHora = intHora
            Me.FinMinuto = intMinuto

        End Set
    End Property    
#End Region
#Region "Propiedades_LimiteVisita/Parentesco"
    Public Property _LimiteVisita() As Boolean
        Get
            Return Me.chkHabilitarlimite.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkHabilitarlimite.Checked = value
            HabilitarPanelParentesco()
        End Set
    End Property
    Public Property _LimiteVisitaCantidad As Integer
        Get
            Return Me.nudLimiteVisitantes.Value
        End Get
        Set(ByVal value As Integer)
            Me.nudLimiteVisitantes.Value = value
        End Set
    End Property
    Public Property _FamiliarConsaguidad() As Boolean
        Get
            Return Me.chkFamiliarConsanguidad.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkFamiliarConsanguidad.Checked = value
            HabilitarFamiliarConsanguidad()
        End Set
    End Property
    Public Property _FamiliarConsanguidadCantidad() As Integer
        Get
            Return Me.nupFamiliarConsanguidadCantidad.Value
        End Get
        Set(ByVal value As Integer)
            Me.nupFamiliarConsanguidadCantidad.Value = value
        End Set
    End Property
    Private Property FamiliarConsanguidadGrado() As Integer
        Get
            Return Me.cbbGradoConsanguidad.SelectedIndex
        End Get
        Set(ByVal value As Integer)
            Me.cbbGradoConsanguidad.SelectedIndex = value
        End Set
    End Property
    Public Property _FamiliarAfinidad() As Boolean
        Get
            Return Me.chkFamiliarAfinidad.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkFamiliarAfinidad.Checked = value
            HabilitarFamiliarAfinidad()
        End Set
    End Property
    Public Property _FamiliarAfinidadCantidad() As Integer
        Get
            Return Me.nupFamiliarAfinidadCantidad.Value
        End Get
        Set(ByVal value As Integer)
            Me.nupFamiliarAfinidadCantidad.Value = value
        End Set
    End Property
    Private Property FamiliarAfinidadGrado() As Integer
        Get
            Return Me.cbbGradoAfinidad.SelectedIndex
        End Get
        Set(ByVal value As Integer)
            Me.cbbGradoAfinidad.SelectedIndex = value
        End Set
    End Property
    Public Property _IncluyeConyugueConcubina() As Boolean
        Get
            Return Me.chkIncluyeConyugue.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkIncluyeConyugue.Checked = value
        End Set
    End Property
    Public Property _IncluyeAmigos() As Boolean
        Get
            Return Me.chkIncluyeAmigos.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkIncluyeAmigos.Checked = value
        End Set
    End Property
    Public Property _IncluyeAbogados() As Boolean
        Get
            Return Me.chkIncluyeAbogado.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkIncluyeAbogado.Checked = value
        End Set
    End Property
    Public Property _RegistradoPreviamente() As Boolean
        Get
            Return Me.chkRegistradoPreviamente.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkRegistradoPreviamente.Checked = value
        End Set
    End Property
    Public Property _HabilitarRangoEdades() As Boolean
        Get
            Return Me.chkHabRangoEdades.Checked
        End Get
        Set(value As Boolean)
            Me.chkHabRangoEdades.Checked = value
            HabilitarEdad()
        End Set
    End Property
    Public Property _EdadIni() As Short
        Get
            Return Me.cbbEdadIni.SelectedIndex
        End Get
        Set(value As Short)
            Me.cbbEdadIni.SelectedIndex = value
        End Set
    End Property
    Public Property _EdadFin() As Short
        Get
            Return Me.cbbEdadFin.SelectedIndex
        End Get
        Set(value As Short)
            Me.cbbEdadFin.SelectedIndex = value
        End Set
    End Property
#End Region
#Region "Propiedades_Tiempo/Duracion"
    Private Property TipoHora() As Integer
        Get
            Dim value As Integer = -1

            If Me.rdbDefinirHora.Checked = True Then
                value = 1
            End If
            Return value

        End Get
        Set(ByVal value As Integer)

            Select Case value
                Case 1
                    Me.rdbDefinirHora.Checked = True
                Case Else
                    Me.rdbTodoelDia.Checked = True
            End Select
        End Set
    End Property
    Private Property InicioHora() As Integer
        Get
            Return Me.nudInicioHora.Value
        End Get
        Set(ByVal value As Integer)
            Me.nudInicioHora.Value = value
        End Set
    End Property
    Private Property InicioMinuto() As Integer
        Get
            Return Me.nudInicioMinuto.Value
        End Get
        Set(ByVal value As Integer)
            Me.nudInicioMinuto.Value = value
        End Set
    End Property
    Private Property FinHora() As Integer
        Get
            Return Me.nudFinHora.Value
        End Get
        Set(ByVal value As Integer)
            Me.nudFinHora.Value = value
        End Set
    End Property
    Private Property FinMinuto() As Integer
        Get
            Return Me.nudFinMinuto.Value
        End Get
        Set(ByVal value As Integer)
            Me.nudFinMinuto.Value = value
        End Set
    End Property
    Public Property _Duracion() As Integer
        Get
            Try
                Return Integer.Parse(Me.txtDuracion.Text.Trim)
            Catch ex As Exception
                Return 0
            End Try
        End Get
        Set(ByVal value As Integer)
            Me.txtDuracion.Text = value.ToString
        End Set
    End Property

#End Region
#Region "Combo"
    Private Sub ComboParentesco()

        With Me.cbbGradoConsanguidad
            .Items.Clear()
            .Items.Add("")
            .Items.Add("1er Grado")
            .Items.Add("2do Grado")
            .Items.Add("3er Grado")
            .Items.Add("4to Grado")
            .Items.Add("5to Grado")
        End With

        With Me.cbbGradoAfinidad
            .Items.Clear()
            .Items.Add("")
            .Items.Add("1er Grado")
            .Items.Add("2do Grado")
            .Items.Add("3er Grado")
            .Items.Add("4to Grado")
            .Items.Add("5to Grado")
        End With

        With Me.cbbEdadIni
            .Items.Clear()
            For i As Byte = 0 To 17
                .Items.Add(i.ToString)
            Next

        End With

        With Me.cbbEdadFin
            For i As Byte = 0 To 17
                .Items.Add(i.ToString)
            Next
        End With

    End Sub
#End Region
#Region "Habilitar"
    Private Sub HabilitarPanelParentesco()

        Me.pnlParentesco.Enabled = Me.chkHabilitarlimite.Checked
        Me.nudLimiteVisitantes.Enabled = Me.chkHabilitarlimite.Checked

        If Me.chkHabilitarlimite.Checked = False Then

            Me._LimiteVisitaCantidad = 0

            Me.chkFamiliarConsanguidad.Checked = False
            Me.chkFamiliarAfinidad.Checked = False

            HabilitarFamiliarConsanguidad()
            HabilitarFamiliarAfinidad()

            Me._IncluyeConyugueConcubina = False
            Me._IncluyeAmigos = False
            'Me._RegistradoPreviamente = False

        End If

    End Sub
    Private Sub HabilitarFamiliarConsanguidad()

        Me.pnlFamiliaresConsanguidad.Enabled = Me.chkFamiliarConsanguidad.Checked

        If Me.chkFamiliarConsanguidad.Checked = False Then
            Me._FamiliarConsanguidadCantidad = 0
            Me.FamiliarConsanguidadGrado = -1
        End If

    End Sub
    Private Sub HabilitarFamiliarAfinidad()

        Me.pnlFamiliarAfinidad.Enabled = Me.chkFamiliarAfinidad.Checked

        If Me.chkFamiliarAfinidad.Checked = False Then
            Me._FamiliarAfinidadCantidad = 0
            Me.FamiliarAfinidadGrado = -1
        End If

    End Sub

    Private Sub HabilitarEdad()

        Me.pnlEdad.Enabled = Me.chkHabRangoEdades.Checked

        If Me.chkHabRangoEdades.Checked = False Then
            Me.cbbEdadIni.SelectedIndex = -1
            Me.cbbEdadFin.SelectedIndex = -1
        Else
            Me.cbbEdadIni.SelectedIndex = 0
            Me.cbbEdadFin.SelectedIndex = Me.cbbEdadFin.Items.Count - 1
        End If

    End Sub
#End Region
#Region "Otros"
    Private Function Validar() As Boolean

        Dim value As Boolean = False

        'grado de consanguidad
        If Me._FamiliarConsaguidad = True Then
            If Me.FamiliarConsanguidadGrado < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Seleccione el grado de consanguidad")
                Return value
            End If
        End If

        'grado de afinidad
        If Me._FamiliarAfinidad = True Then
            If Me.FamiliarAfinidadGrado < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Seleccione el grado de afinidad")
                Return value
            End If
        End If

        'limite de visitantes
        If Me._LimiteVisitaCantidad > 0 Then

            If (Me._FamiliarConsanguidadCantidad + Me._FamiliarAfinidadCantidad) > Me._LimiteVisitaCantidad Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "La cantidad de visitas de consanguidad/afinidad, no debe exceder el maximo permitido")
                Me.nupFamiliarConsanguidadCantidad.Focus()
                Return value
            End If

        End If

        'hora inicio
        If Me._HoraMinutoFin < Me._HoraMinutoInicio Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
            "La hora fin es mayor a la hora de inicio")
            Return value
        End If

        'rango de edad
        If Me._HabilitarRangoEdades = True Then
            If Me._EdadFin < Me._EdadIni Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "La edad [Fin], no puede ser menor a la edad [Incio]")
                Return value
            End If
        End If
        
        value = True
        Return value

    End Function
    Public Function _Validar() As Boolean
        Return Validar()
    End Function
    Private Sub HabilitarHora()

        Dim blnEstado As Boolean = False

        Select Case Me.TipoHora
            Case 1 'definir hora
                blnEstado = True

            Case Else
                blnEstado = False
                Me.InicioHora = 8
                Me.InicioMinuto = 0
                Me.FinHora = 17
                Me.FinMinuto = 0
        End Select

        Me.pnlHoraInicio.Enabled = blnEstado
        Me.pnlHoraFin.Enabled = blnEstado

    End Sub
    Public Sub _LoadUsc()

        ValoresxDefaul()

    End Sub
    Private Sub ValoresxDefaul()

        ComboParentesco()

        Me.nudLimiteVisitantes.Enabled = Me.chkHabilitarlimite.Checked
        Me.pnlParentesco.Enabled = False
        Me.pnlFamiliaresConsanguidad.Enabled = False
        Me.pnlFamiliarAfinidad.Enabled = False

        '/*edad*/
        Me.cbbEdadIni.SelectedIndex = -1
        Me.cbbEdadFin.SelectedIndex = -1

    End Sub
    Public Sub _CalcularDuracion()

        If Me._HoraMinutoInicio > 0 And Me._HoraMinutoFin > 0 Then
            Me._Duracion = Me._HoraMinutoFin - Me._HoraMinutoInicio
        End If

    End Sub
    Public Sub _VisiblePanelIncluye(ByVal Conyugue As Boolean, Amigo As Boolean, Abogado As Boolean)

        Me.pnlConyugue.Visible = Conyugue
        Me.pnlAmigos.Visible = Amigo
        Me.pnlAbogado.Visible = Abogado

    End Sub
    Public Sub _EnabledPanelIncluye(ByVal Conyugue As Boolean, Amigo As Boolean, Abogado As Boolean)

        Me.pnlConyugue.Enabled = Conyugue
        Me.pnlAmigos.Enabled = Amigo
        Me.pnlAbogado.Enabled = Abogado

    End Sub
    Public Sub _CheckPanelIncluye(ByVal Conyugue As Boolean, Amigo As Boolean, Abogado As Boolean)

        Me._IncluyeConyugueConcubina = Conyugue
        Me._IncluyeAmigos = Amigo
        Me._IncluyeAbogados = Abogado

    End Sub

    Public Sub _VisiblePanelParentesco(ByVal Value As Boolean)

        Me.pnlParentesco.Visible = Value
    End Sub
#End Region

    Private Sub rdbTodoelDia_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles rdbTodoelDia.Click, _
        rdbDefinirHora.Click

        HabilitarHora()

    End Sub

    Private Sub chkHabilitarlimite_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkHabilitarlimite.Click

        HabilitarPanelParentesco()

    End Sub

    Private Sub chkFamiliarConsanguidad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFamiliarConsanguidad.Click

        HabilitarFamiliarConsanguidad()

    End Sub

    Private Sub chkFamiliarAfinidad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFamiliarAfinidad.Click

        HabilitarFamiliarAfinidad()

    End Sub

    Private Sub chkHabRangoEdades_Click(sender As Object, e As System.EventArgs) Handles chkHabRangoEdades.Click

        HabilitarEdad()

    End Sub
End Class
