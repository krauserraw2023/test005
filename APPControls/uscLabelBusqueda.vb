Public Class uscLabelBusqueda
#Region "Eventos"
    Public Event _Click_Agregar()
    Public Event _Click_Eliminar()
    Public Event _Click_Buscar()
    Public Event _KeyDown_Suprimir()
#End Region
#Region "Propiedades"
    Private intIDCodigo As Integer = -1
    Public Property _Codigo() As Integer
        Get
            Return intIDCodigo
        End Get
        Set(value As Integer)
            intIDCodigo = value
            If value < 1 Then
                Me._Value = "[SELECCIONE]"
            End If
        End Set
    End Property
    Public Property _Value() As String
        Get
            Return Me.txtNombre.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtNombre.Text = value
        End Set
    End Property
#End Region
#Region "Propiedades_Usc"
    Public Property _Visible_Add() As Boolean
        Get
            Return Me.pnlAdd.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.pnlAdd.Visible = value
        End Set
    End Property
    Public Property _Visible_Buscar() As Boolean
        Get
            Return Me.pnlBusqueda.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.pnlBusqueda.Visible = value
        End Set
    End Property
    Public Property _Visible_Eliminar() As Boolean
        Get
            Return Me.pnlEliminar.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.pnlEliminar.Visible = value
        End Set
    End Property
#End Region
#Region "Funciones"
    Public Sub _FocusBuscar()
        Me.btnBuscar.Focus()
    End Sub
#End Region
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        RaiseEvent _Click_Buscar()

    End Sub

    Private Sub uscLabelBusqueda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me._Visible_Add = False

    End Sub

    Private Sub uscBusquedaVisitante_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Height = 21
    End Sub

    Private Sub txtVisitante_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown

        If e.KeyCode = Keys.Delete = True Then

            Me._Codigo = -1
            Me._Value = "[SELECCIONE]"
            RaiseEvent _KeyDown_Suprimir()

        End If

        If Me.pnlBusqueda.Visible = True Then
            If e.KeyCode = Keys.F3 Then
                RaiseEvent _Click_Buscar()
            End If
        End If
        
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        RaiseEvent _Click_Agregar()

    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

        Me._Codigo = -1
        Me._Value = "[SELECCIONE]"

        RaiseEvent _Click_Eliminar()

    End Sub

    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub
End Class

