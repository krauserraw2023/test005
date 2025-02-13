Public Class usrCheckSemanaDia

    Public Sub _SeleccionarTodos()
        _seleccionar(-1)
    End Sub

    Public Sub _SeleccionarNada()
        _seleccionar(0)
    End Sub

    Public Sub _TresEstados()

        Me.chk_lunes.ThreeState = True
        Me.chk_martes.Checked = True
        Me.chk_miercoles.Checked = True
        Me.chk_jueves.Checked = True
        Me.chk_viernes.Checked = True
        Me.chk_sabado.Checked = True
        Me.chk_domingo.Checked = True


    End Sub

    Public Sub _seleccionar(ByVal vindex As Integer)

        Me.chk_domingo.Checked = False
        Me.chk_martes.Checked = False
        Me.chk_miercoles.Checked = False
        Me.chk_jueves.Checked = False
        Me.chk_viernes.Checked = False
        Me.chk_sabado.Checked = False
        Me.chk_domingo.Checked = False

        Select Case vindex
            Case -1
                Me.chk_lunes.Checked = True
                Me.chk_martes.Checked = True
                Me.chk_miercoles.Checked = True
                Me.chk_jueves.Checked = True
                Me.chk_viernes.Checked = True
                Me.chk_sabado.Checked = True
                Me.chk_domingo.Checked = True
            Case 0
                Me.chk_domingo.Checked = True
            Case 1
                Me.chk_lunes.Checked = True
            Case 2
                Me.chk_martes.Checked = True
            Case 3
                Me.chk_miercoles.Checked = True
            Case 4
                Me.chk_jueves.Checked = True
            Case 5
                Me.chk_viernes.Checked = True
            Case 6
                Me.chk_sabado.Checked = True
            Case 7
                Me.chk_domingo.Checked = True
        End Select


    End Sub

    Public Property _lunes() As Integer
        Get
            Return Me.chk_lunes.Checked
        End Get
        Set(ByVal value As Integer)
            Me.chk_lunes.Checked = value
        End Set
    End Property
    Public Property _martes() As Integer
        Get
            Return Me.chk_martes.Checked
        End Get
        Set(ByVal value As Integer)
            Me.chk_martes.Checked = value
        End Set
    End Property
    Public Property _miercoles() As Integer
        Get
            Return Me.chk_miercoles.Checked
        End Get
        Set(ByVal value As Integer)
            Me.chk_miercoles.Checked = value
        End Set
    End Property
    Public Property _jueves() As Integer
        Get
            Return Me.chk_jueves.Checked
        End Get
        Set(ByVal value As Integer)
            Me.chk_jueves.Checked = value
        End Set
    End Property
    Public Property _viernes() As Integer
        Get
            Return Me.chk_viernes.Checked
        End Get
        Set(ByVal value As Integer)
            Me.chk_viernes.Checked = value
        End Set
    End Property
    Public Property _sabado() As Integer
        Get
            Return Me.chk_sabado.Checked
        End Get
        Set(ByVal value As Integer)
            Me.chk_sabado.Checked = value
        End Set
    End Property
    Public Property _domingo() As Integer
        Get
            Return Me.chk_domingo.Checked
        End Get
        Set(ByVal value As Integer)
            Me.chk_domingo.Checked = value
        End Set
    End Property

    Public Function _ValueDia(ByVal vdia As Integer) As Integer
        Dim _int As Integer = -1

        Select Case vdia
            Case 0
                _int = _domingo
            Case 1
                _int = _lunes
            Case 2
                _int = _martes
            Case 3
                _int = _miercoles
            Case 4
                _int = _jueves
            Case 5
                _int = _viernes
            Case 6
                _int = _sabado
            Case 7
                _int = _domingo
        End Select

        Return _int

    End Function

End Class
