Public Class usrCalendario

    Public Event _evtAdd(ByVal vfecha As DateTime)
    Public Event _evtEditDia(ByVal vcodigo As Integer)
    Public Event _evtEditGrupo(ByVal vcodigo As Integer)

    Public Event _evtLoadParameter()

    Private _intmes As Integer = Now.Month
    Private _intanio As Integer = Now.Year
    Private _intpenal As Integer = -1
    Private _intregion As Integer = -1
    Private _intsexo As Integer = -1
    Private _intMenores As Integer = -1

    Public Property _RegionId() As Integer
        Get
            Return _intregion
        End Get
        Set(ByVal value As Integer)
            _intregion = value
        End Set
    End Property
    Public Property _PenalId() As Integer
        Get
            Return _intpenal
        End Get
        Set(ByVal value As Integer)
            _intpenal = value
        End Set
    End Property
    Public Property _Sexo() As Integer
        Get
            Return _intsexo
        End Get
        Set(ByVal value As Integer)
            _intsexo = value
        End Set
    End Property
    Public Property _Menores() As Integer
        Get
            Return _intMenores
        End Get
        Set(ByVal value As Integer)
            _intMenores = value
        End Set
    End Property
    


    Public Property _mes() As Integer
        Get
            Return _intmes
        End Get
        Set(ByVal value As Integer)
            _intmes = value
        End Set
    End Property
    Public Property _Anio() As Integer
        Get
            Return _intanio
        End Get
        Set(ByVal value As Integer)
            _intanio = value
        End Set
    End Property

    Public Sub _AddRegistro(ByVal vfecha As DateTime, ByVal vcodigoPadre As Integer, ByVal vcodigodetalle As Integer, ByVal vtexto As String)

        Dim i As Integer = 0
        Dim j As Integer = 0
        For j = 0 To Me.table.RowCount
            For i = 0 To Me.table.ColumnCount

                Dim c As Control = Me.table.GetControlFromPosition(i, j)
                If c IsNot Nothing Then
                    If c.GetType.ToString = "APPControls.usrCalendarioDia" Then

                        Dim _day As usrCalendarioDia
                        _day = CType(c, usrCalendarioDia)

                        If _day._Fecha = vfecha Then

                            _day._AddItem(vcodigoPadre, vcodigodetalle, vtexto)

                        End If

                    End If
                End If

                ' Dim _day As New usrCalendarioDia


            Next
        Next




    End Sub
    Public Sub LoadParameter()
        LoadParameter(_Anio, _mes)

    End Sub

    Public Sub LoadParameter(ByVal Anio As Integer, ByVal mes As Integer)
        _Anio = Anio
        _mes = mes
        If mes > 12 Then
            mes = 1
            Anio = Anio + 1
        End If

        If mes < 1 Then
            mes = 12
            Anio = Anio - 1
        End If


        _mes = mes
        _Anio = Anio

        Dim diasxmes As Integer = -1
        diasxmes = System.DateTime.DaysInMonth(Anio, mes)
        Dim dia_primero As New DateTime(Anio, mes, 1)

        Dim dia_primero_semana As Integer = dia_primero.DayOfWeek.GetHashCode

        If dia_primero_semana = 0 Then
            dia_primero_semana = 7
        End If
        'para que lunes sea 0 
        dia_primero_semana = dia_primero_semana - 1

        Dim diacalendario As New DateTime(Anio, mes, 1)
        diacalendario = diacalendario.AddDays(-dia_primero_semana)



        Dim i As Integer = 0
        Dim j As Integer = 0
        For j = 0 To Me.table.RowCount
            For i = 0 To Me.table.ColumnCount

                Dim c As Control = Me.table.GetControlFromPosition(i, j)
                If c IsNot Nothing Then
                    If c.GetType.ToString = "APPControls.usrCalendarioDia" Then

                        Dim _day As usrCalendarioDia
                        _day = CType(c, usrCalendarioDia)

                        ' _day._Dia = diacalendario.day
                        _day._Fecha = diacalendario

                        If diacalendario.Month <> mes Then
                            _day._Fondo = Color.Peru
                        Else
                            _day._Fondo = Color.Aquamarine
                        End If
                        _day._limpiar()
                        diacalendario = diacalendario.AddDays(1)

                    End If
                End If

                ' Dim _day As New usrCalendarioDia


            Next
        Next

        Me.lblMes.Text = Microsoft.VisualBasic.MonthName(mes) + " " + Anio.ToString

        RaiseEvent _evtLoadParameter()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        _mes = _mes - 1
        LoadParameter()
    End Sub

  



    Private Sub btnanioanterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanioanterior.Click
        _anio = _anio - 1
        LoadParameter()

    End Sub

    Private Sub btnAniosiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAniosiguiente.Click
        _anio = _anio + 1
        LoadParameter()
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        _mes = _mes + 1
        LoadParameter()
    End Sub


    Public ReadOnly Property _Desde() As DateTime
        Get
            Return _FechaPosition(0, 1)

        End Get
    End Property

    Public ReadOnly Property _Hasta() As DateTime
        Get
            Return _FechaPosition(Me.table.RowCount - 1, Me.table.ColumnCount - 1)

        End Get
    End Property

    Public Function _FechaPosition(ByVal x As Integer, ByVal y As Integer) As Date

        Dim _date As DateTime
        Dim c As Control = Me.table.GetControlFromPosition(x, y)
        If c IsNot Nothing Then
            If c.GetType.ToString = "APPControls.usrCalendarioDia" Then
                Dim _day As usrCalendarioDia
                _day = CType(c, usrCalendarioDia)
                _date = _day._Fecha
            End If
        End If

        Return _date
    End Function

    Private Sub usrDia__evtAdd(ByVal vfecha As System.DateTime) Handles usrdia06._evtAdd, usrdia05._evtAdd, usrDia00._evtAdd, UsrCalendarioDia9._evtAdd, UsrCalendarioDia8._evtAdd, UsrCalendarioDia7._evtAdd, UsrCalendarioDia6._evtAdd, UsrCalendarioDia5._evtAdd, UsrCalendarioDia4._evtAdd, UsrCalendarioDia35._evtAdd, UsrCalendarioDia34._evtAdd, UsrCalendarioDia33._evtAdd, UsrCalendarioDia32._evtAdd, UsrCalendarioDia31._evtAdd, UsrCalendarioDia30._evtAdd, UsrCalendarioDia3._evtAdd, UsrCalendarioDia29._evtAdd, UsrCalendarioDia28._evtAdd, UsrCalendarioDia27._evtAdd, UsrCalendarioDia26._evtAdd, UsrCalendarioDia25._evtAdd, UsrCalendarioDia24._evtAdd, UsrCalendarioDia23._evtAdd, UsrCalendarioDia22._evtAdd, UsrCalendarioDia21._evtAdd, UsrCalendarioDia20._evtAdd, UsrCalendarioDia2._evtAdd, UsrCalendarioDia19._evtAdd, UsrCalendarioDia18._evtAdd, UsrCalendarioDia17._evtAdd, UsrCalendarioDia16._evtAdd, UsrCalendarioDia15._evtAdd, UsrCalendarioDia14._evtAdd, UsrCalendarioDia13._evtAdd, UsrCalendarioDia12._evtAdd, UsrCalendarioDia11._evtAdd, UsrCalendarioDia10._evtAdd, UsrCalendarioDia1._evtAdd, usr04._evtAdd, usr03._evtAdd, usr02._evtAdd, usr01._evtAdd
        RaiseEvent _evtAdd(vfecha)
    End Sub

    Private Sub usrDia__evtEditDia(ByVal vcodigo As Integer) Handles usrdia06._evtEditDia, usrdia05._evtEditDia, usrDia00._evtEditDia, UsrCalendarioDia9._evtEditDia, UsrCalendarioDia8._evtEditDia, UsrCalendarioDia7._evtEditDia, UsrCalendarioDia6._evtEditDia, UsrCalendarioDia5._evtEditDia, UsrCalendarioDia4._evtEditDia, UsrCalendarioDia35._evtEditDia, UsrCalendarioDia34._evtEditDia, UsrCalendarioDia33._evtEditDia, UsrCalendarioDia32._evtEditDia, UsrCalendarioDia31._evtEditDia, UsrCalendarioDia30._evtEditDia, UsrCalendarioDia3._evtEditDia, UsrCalendarioDia29._evtEditDia, UsrCalendarioDia28._evtEditDia, UsrCalendarioDia27._evtEditDia, UsrCalendarioDia26._evtEditDia, UsrCalendarioDia25._evtEditDia, UsrCalendarioDia24._evtEditDia, UsrCalendarioDia23._evtEditDia, UsrCalendarioDia22._evtEditDia, UsrCalendarioDia21._evtEditDia, UsrCalendarioDia20._evtEditDia, UsrCalendarioDia2._evtEditDia, UsrCalendarioDia19._evtEditDia, UsrCalendarioDia18._evtEditDia, UsrCalendarioDia17._evtEditDia, UsrCalendarioDia16._evtEditDia, UsrCalendarioDia15._evtEditDia, UsrCalendarioDia14._evtEditDia, UsrCalendarioDia13._evtEditDia, UsrCalendarioDia12._evtEditDia, UsrCalendarioDia11._evtEditDia, UsrCalendarioDia10._evtEditDia, UsrCalendarioDia1._evtEditDia, usr04._evtEditDia, usr03._evtEditDia, usr02._evtEditDia, usr01._evtEditDia
        RaiseEvent _evtEditDia(vcodigo)
    End Sub

    Private Sub usrDia__esvtEditGrupo(ByVal vcodigo As Integer) Handles usrdia06._evtEditGrupo, usrdia05._evtEditGrupo, usrDia00._evtEditGrupo, UsrCalendarioDia9._evtEditGrupo, UsrCalendarioDia8._evtEditGrupo, UsrCalendarioDia7._evtEditGrupo, UsrCalendarioDia6._evtEditGrupo, UsrCalendarioDia5._evtEditGrupo, UsrCalendarioDia4._evtEditGrupo, UsrCalendarioDia35._evtEditGrupo, UsrCalendarioDia34._evtEditGrupo, UsrCalendarioDia33._evtEditGrupo, UsrCalendarioDia32._evtEditGrupo, UsrCalendarioDia31._evtEditGrupo, UsrCalendarioDia30._evtEditGrupo, UsrCalendarioDia3._evtEditGrupo, UsrCalendarioDia29._evtEditGrupo, UsrCalendarioDia28._evtEditGrupo, UsrCalendarioDia27._evtEditGrupo, UsrCalendarioDia26._evtEditGrupo, UsrCalendarioDia25._evtEditGrupo, UsrCalendarioDia24._evtEditGrupo, UsrCalendarioDia23._evtEditGrupo, UsrCalendarioDia22._evtEditGrupo, UsrCalendarioDia21._evtEditGrupo, UsrCalendarioDia20._evtEditGrupo, UsrCalendarioDia2._evtEditGrupo, UsrCalendarioDia19._evtEditGrupo, UsrCalendarioDia18._evtEditGrupo, UsrCalendarioDia17._evtEditGrupo, UsrCalendarioDia16._evtEditGrupo, UsrCalendarioDia15._evtEditGrupo, UsrCalendarioDia14._evtEditGrupo, UsrCalendarioDia13._evtEditGrupo, UsrCalendarioDia12._evtEditGrupo, UsrCalendarioDia11._evtEditGrupo, UsrCalendarioDia10._evtEditGrupo, UsrCalendarioDia1._evtEditGrupo, usr04._evtEditGrupo, usr03._evtEditGrupo, usr02._evtEditGrupo, usr01._evtEditGrupo
        RaiseEvent _evtEditGrupo(vcodigo)
    End Sub


End Class
