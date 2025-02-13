Namespace Visita.Calendario
    Public Class frmCalendario

        Public Property _VisitaTipo() As Integer
            Get
                Return Me.cbbVisitaTipo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbVisitaTipo.SelectedValue = value
            End Set
        End Property


        Public Property _Sexo() As Integer
            Get
                Dim _int As Integer = -1
                If Me.rb_hombre.Checked Then
                    _int = 1

                End If
                If Me.rb_mujer.Checked Then
                    _int = 2
                End If
                Return _int
            End Get


            Set(ByVal value As Integer)

            End Set
        End Property

        Public Property _Menores() As Integer
            Get
                Dim _int As Integer = -1

                If Me.rb_menoresSI.Checked Then
                    _int = 1

                End If

                If Me.rb_menoresNO.Checked Then
                    _int = 0

                End If

                Return _int
            End Get
            Set(ByVal value As Integer)

            End Set
        End Property

        Private Sub frmCalendario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.cbbVisitaTipo.ComboTipo = Type.Combo.ComboTipo.VISTipo
            Me.cbbVisitaTipo._Todos = True
            Me.cbbVisitaTipo.LoadUsc()



            Me.UsrCalendario1.LoadParameter(Now.Year, Now.Month)
        End Sub

        Private Sub UsrCalendario1__evtAdd(ByVal vfecha As Date) Handles UsrCalendario1._evtAdd
            'Dim frmpopup As New Visita.Calendario.frmCalendarioAgregar
            'frmpopup.chkHoy.Checked = True
            'frmpopup.TempoFechaDesde = vfecha.ToFileTime
            'If frmpopup.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '    UsrCalendario1.LoadParameter()
            'End If
        End Sub

        Private Sub UsrCalendario1__evtLoadParameter() Handles UsrCalendario1._evtLoadParameter
            ListarCalendario()
        End Sub

        Public Sub ListarCalendario()


            If Me.UsrCalendario1._Desde > System.DateTime.FromFileTime(0) Then


                Dim _Desde As DateTime = Me.UsrCalendario1._Desde
                Dim _hasta As DateTime = Me.UsrCalendario1._Hasta

                Dim objDetalle As New Bussines.Visita.CalendarioDetalle
                Dim oColDetalle As Entity.Visita.CalendarioDetalleCol

                oColDetalle = objDetalle.Listar("lst_rango", -1, -1, Me._VisitaTipo, _Desde.ToFileTime, -1, -1, -1, _
               _hasta.ToFileTime, -1, -1, -1, -1, -1, _
                Me._Sexo, Me._Menores, -1, -1, -1, -1, -1, -1, -1)


                For Each ent As Entity.Visita.CalendarioDetalle In oColDetalle
                    Me.UsrCalendario1._AddRegistro(System.DateTime.FromFileTime(ent.FechaDesde), ent.CalendarioId, ent.Codigo, ent.TipoStr + "X")
                Next

            End If

        End Sub

        Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
            Me.UsrCalendario1.LoadParameter()
        End Sub

        Private Sub UsrCalendario1__evtEditDia(ByVal vcodigo As System.Int32) Handles UsrCalendario1._evtEditDia

        End Sub

        Private Sub UsrCalendario1__evtEditGrupo(ByVal vcodigo As System.Int32) Handles UsrCalendario1._evtEditGrupo

            'Dim frmpopup As New Visita.Calendario.frmCalendarioAgregar
            'frmpopup.Codigo = vcodigo

            'If frmpopup.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    Me.UsrCalendario1.LoadParameter()
            'End If

        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub
    End Class
End Namespace
