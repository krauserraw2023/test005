Namespace Busqueda
    Public Class uscComboSala
#Region "Eventos"
        Public Event _Click_Eliminar()
        Public Event _Click_Buscar()
#End Region
#Region "Propiedades"
        Public Property _DistritoJudicialID() As Integer=-1
        Public Property _SalaJuzgadoID_Seleccionado() As Integer = -1
        Public Property _SalaJuzgadoID() As Integer
            Get
                Return Me.UscComboParametrica1.SelectedValue
            End Get
            Set(value As Integer)
                Me.UscComboParametrica1.SelectedValue = value
            End Set
        End Property
        Public ReadOnly Property _SalaNombre() As String
            Get
                Return Me.UscComboParametrica1.Text
            End Get
        End Property
        Public Property _Todos() As Boolean = False
        Public Property _TodosMensaje As String = ""
        Public Property _visibleBuscar() As Boolean
            Get
                Return Me.UscComboParametrica1._Visible_Buscar
            End Get
            Set(ByVal value As Boolean)
                Me.UscComboParametrica1._Visible_Buscar = value
            End Set
        End Property
        Public Property _DropDownWidthAuto As Boolean = False
        Public Sub _ComboConfiguracion()

            Me.UscComboParametrica1.ComboBoxConfiguracion()
        End Sub
#End Region
#Region "Combo"
        Private Sub ComboListar()
            With Me.UscComboParametrica1
                ._Todos = Me._Todos
                ._TodosMensaje = Me._TodosMensaje
                .ComboTipo = Type.Combo.ComboTipo.SalaJusticial
                .CodigoPadre = Me._DistritoJudicialID
                .DropDownWidthAuto = _DropDownWidthAuto
                .verToolTipItemSeleccionado = True
                .LoadUsc()
            End With
        End Sub
        Public Sub _Combo()
            ComboListar()
        End Sub
#End Region
        Private Sub uscBusquedaSala_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize

            Me.Height = 21

        End Sub

        Private Sub UscComboParametrica1__Click_Buscar() Handles UscComboParametrica1._Click_Buscar
            RaiseEvent _Click_Buscar()
        End Sub

        Private Sub UscComboParametrica1__Click_Eliminar() Handles UscComboParametrica1._Click_Eliminar

            RaiseEvent _Click_Eliminar()

        End Sub
    End Class
End Namespace