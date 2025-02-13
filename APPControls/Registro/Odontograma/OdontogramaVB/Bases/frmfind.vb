Imports BussinesCap
Public Class frmfind
    Private _criterios As List(Of String)
    Public Property Criterios() As List(Of String)
        Get
            Return _criterios
        End Get
        Set(ByVal value As List(Of String))
            _criterios = value
        End Set
    End Property
    Private _condiciones As List(Of String)
    Public Property Condiciones() As List(Of String)
        Get
            Return _condiciones
        End Get
        Set(ByVal value As List(Of String))
            _condiciones = value
        End Set
    End Property
    Private _valorretorno As Object
    Public Property Valorretorno() As Object
        Get
            Return _valorretorno
        End Get
        Set(ByVal value As Object)
            _valorretorno = value
        End Set
    End Property

    Private Sub frmfind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _criterios = New List(Of String)
        _condiciones = New List(Of String)
        'Me.Criterios.Add("Codigo")
        'Me.Condiciones.Add("1")
        'Me.Criterios.Add("A. Paterno")
        'Me.Condiciones.Add("2")
        'cbocriterio.DataSource = Me.Criterios
        Carga_datos_form()
    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click
        If lstviewseleccion.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar un elemento", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Me.Close()
    End Sub

    Private Sub cbocriterio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbocriterio.SelectedIndexChanged
        ' txtfind.Text = Me.Condiciones(cbocriterio.SelectedIndex)
    End Sub


    Private Sub txtfind_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfind.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Carga_datos_listview()
        End If
    End Sub
    Public Overridable Sub Carga_datos_listview()
        lstviewseleccion.Items.Clear()
    End Sub
    Public Overridable Sub Carga_datos_form()

    End Sub

    Private Sub lstviewseleccion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstviewseleccion.Click
        Devuelve_valor()
    End Sub
    Public Overridable Sub Devuelve_valor()

    End Sub

    Private Sub cmdsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsalir.Click
        Me.Valorretorno = Nothing
        Me.Close()
    End Sub


    Private Sub lstviewseleccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstviewseleccion.SelectedIndexChanged
        Devuelve_valor()
    End Sub

   
End Class