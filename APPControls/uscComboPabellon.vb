Public Class uscComboPabellon

#Region "Propiedades_Par"
    Public Property _RegionID() As Integer = -1
    Public Property _PenalID() As Integer = -1
#End Region
#Region "Propiedades"
    Public ReadOnly Property _Text() As String
        Get
            Return Me.ComboBox1.Text
        End Get
    End Property

    Public Property _SelectedValue() As Integer
        Get
            Return Me.ComboBox1.SelectedValue
        End Get
        Set(ByVal value As Integer)
            Me.ComboBox1.SelectedValue = value
        End Set
    End Property
#End Region
#Region "Propiedades_Publicas"
    Public Property _Ninguno() As Boolean = False
    Public Property _Todos() As Boolean = False
#End Region
#Region "Combo"
    Private Sub Combo()

        If Me._RegionID < 1 Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "El parametro _RegionID, no ha sido enviado")
            Exit Sub
        End If

        If Me._PenalID < 1 Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "El parametro _PenalID, no ha sido enviado")
            Exit Sub
        End If

        Dim objEntCol As New Entity.Mantenimiento.General.PabellonCol
        Dim objBss As New Bussines.Mantenimiento.General.Pabellon

        Dim objEntFiltro As New Entity.Mantenimiento.General.Pabellon
        With objEntFiltro
            .RegionID = Me._RegionID
            .PenalID = Me._PenalID
        End With

        Dim strMensaje As String = ""

        If Me._Todos = True Then
            strMensaje = "[Todos]"
        End If

        If Me._Ninguno = True Then
            strMensaje = "[Ninguno]"
            _Todos = True
        End If

        objEntCol = objBss.Listar(objEntFiltro, _Todos, strMensaje)

        With Me.ComboBox1
            .DataSource = objEntCol
            .ValueMember = "Codigo"
            .DisplayMember = "Nombre"
        End With

    End Sub
#End Region
#Region "Otros"

    Public Sub _LoadUsc()
        Combo()
    End Sub

#End Region
    Private Sub uscComboPabellon_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Height = 22

    End Sub

    Private Sub uscComboPabellon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
