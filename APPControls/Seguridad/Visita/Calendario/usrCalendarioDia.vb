Public Class usrCalendarioDia
    Dim _fecFecha As DateTime = Now
    Private _intCodigo As Integer = -1

    Public Event _evtAdd(ByVal vfecha As DateTime)
    Public Event _evtEditDia(ByVal vcodigo As Integer)
    Public Event _evtEditGrupo(ByVal vcodigo As Integer)


    Public Property _Codigo() As Integer
        Get
            Return _intCodigo
        End Get
        Set(ByVal value As Integer)
            _intCodigo = value
        End Set
    End Property
    Public Property _Fecha() As Date
        Get
            Return _fecFecha
        End Get
        Set(ByVal value As Date)
            _fecFecha = value
            _Dia = _fecFecha.Day
        End Set
    End Property

    Public Property _Dia() As Integer
        Get
            Return Me.lbldia.Text
        End Get
        Set(ByVal value As Integer)
            Me.lbldia.Text = value

        End Set
    End Property

    Public Sub _limpiar()

        Me.lst_visita.Items.Clear()

    End Sub

    Public Sub _AddItem(ByVal vcodigopadre As Integer, ByVal vcodigodetalle As Integer, ByVal vtexto As String)


        lst_visita.View = View.Details
        lst_visita.Columns(1).Width = 0
        lst_visita.Columns(2).Width = 0
        lst_visita.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None)


        Dim item As ListViewItem
        Dim _Stritems() As String
        ReDim _Stritems(3)
        _Stritems(0) = vtexto
        _Stritems(1) = vcodigopadre
        _Stritems(2) = vcodigodetalle

        item = New ListViewItem(_Stritems)

        lst_visita.Items.Add(item)


        '  Me.lst_visita.Items.Add(vtexto)

    End Sub

    Public Property _Fondo() As System.Drawing.Color
        Get
            Return Me.pn_titulo.BackColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            'Me.pn_titulo.BackColor = value
            Me.BackColor = value
        End Set
    End Property



    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Me.lst_visita.Items.Add(Now.ToFileTime

        RaiseEvent _evtAdd(Me._Fecha)


    End Sub

    Private Sub DiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiaToolStripMenuItem.Click
        RaiseEvent _evtEditDia(Me.lst_visita.SelectedItems(0).SubItems(2).Text)

    End Sub

    Private Sub lst_visita_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lst_visita.MouseDown

        Dim p As Point
        Dim lvi As ListViewItem
        Me.menu.Enabled = True
        p = New Point(e.X, e.Y)

        lvi = New ListViewItem()

        If e.Button = Windows.Forms.MouseButtons.Right Then

            lvi = Me.lst_visita.GetItemAt(p.X, p.Y)

            If lvi Is Nothing Then
                Me.menu.Visible = False
            Else
                Me.menu.Show(MousePosition.X, MousePosition.Y)
            End If
        End If


    End Sub

    Private Sub GrupoDeVisitaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoDeVisitaToolStripMenuItem.Click
        RaiseEvent _evtEditGrupo(Me.lst_visita.SelectedItems(0).SubItems(1).Text)
    End Sub
End Class
