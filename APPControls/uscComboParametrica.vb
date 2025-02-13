Public Class uscComboParametrica
    Public Event _SelectedIndexChanged()
    Public Enum LetraTipo
        Ninguno = 0
        Mayuscula = 1
        Minuscula = 2
        Propio = 3
    End Enum
    'dddd 13/01/2024
#Region "Eventos"
    Public Event _Click_Agregar()
    Public Event _Click_Eliminar()
    Public Event _Click_Buscar()
    Public Event _KeyDown_Suprimir()
    Public Event _KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
#End Region
#Region "Propiedades"
    Private strTodoMensaje As String = ""
    Private intCodigoPadre As Integer = -1
    Private bolTodos As Boolean = False
    Private intCodigoHijo As Integer = -1
    Private intParametro2 As Integer = -1
    Public Property SelectedIndex() As Integer
        Get
            Return Me.ComboBox1.SelectedIndex
        End Get
        Set(ByVal value As Integer)
            Me.ComboBox1.SelectedIndex = value
        End Set
    End Property
    Public Property ListaIdsParaExcluir() As List(Of Integer) = Nothing
    Public ReadOnly Property ItemsCount() As Integer
        Get
            Return Me.ComboBox1.Items.Count
        End Get
    End Property
    Public Property SelectedValue() As Integer
        Get
            Try
                Return Me.ComboBox1.SelectedValue
            Catch ex As Exception
                Return -1
            End Try
        End Get
        Set(ByVal value As Integer)
            Me.ComboBox1.SelectedValue = value
        End Set
    End Property
    Public ReadOnly Property SelectedText() As String
        Get
            Try
                Return Me.ComboBox1.SelectedText
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property
    Public Shadows ReadOnly Property Text() As String
        Get
            Try
                Return Me.ComboBox1.Text
            Catch ex As Exception
                Return -1
            End Try
        End Get
    End Property
    Public Property CodigoPadre() As Integer
        Get
            Return intCodigoPadre
        End Get
        Set(ByVal value As Integer)
            intCodigoPadre = value
        End Set
    End Property
    Public Property Parametro1() As Integer
        Get
            Return intCodigoHijo
        End Get
        Set(ByVal value As Integer)
            intCodigoHijo = value
        End Set
    End Property
    Public Property Parametro2() As Integer
        Get
            Return intParametro2
        End Get
        Set(ByVal value As Integer)
            intParametro2 = value
        End Set
    End Property
    Public Property _Todos() As Boolean
        Get
            Return Me.bolTodos
        End Get
        Set(ByVal value As Boolean)
            Me.bolTodos = value
        End Set
    End Property
    Public Property _NoIndica() As Boolean
        Get
            Return Me.bolTodos
        End Get
        Set(ByVal value As Boolean)
            Me.bolTodos = value
        End Set
    End Property
    Public Property _TodosMensaje() As String
        Get
            Return strTodoMensaje.Trim
        End Get
        Set(ByVal value As String)
            strTodoMensaje = value
        End Set
    End Property
#End Region
#Region "Propiedades_UserControl"
    Private blnDropDownWidthAuto As Boolean
    Private intNombreLenght As Integer = 0
    Public Property DropDownWidth() As Integer
        Get
            Return Me.ComboBox1.DropDownWidth
        End Get
        Set(ByVal value As Integer)
            Me.ComboBox1.DropDownWidth = value
        End Set
    End Property
    Public Property DropDownWidthAuto() As Boolean
        Get
            Return blnDropDownWidthAuto
        End Get
        Set(ByVal value As Boolean)
            blnDropDownWidthAuto = value
        End Set
    End Property
    Public Property DisplayTipoLetra() As LetraTipo = LetraTipo.Ninguno

    Public Property ComboTipo() As Short = Type.Combo.ComboTipo.Ninguno

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
    Public Property _TipoTexto As Type.Combo.enmTipoTexto = Type.Combo.enmTipoTexto.Ninguno
    Public Property ModuloTratamiento As Boolean = False
    Public Property verToolTipItemSeleccionado As Boolean = False
#End Region
#Region "Combo"
    Private blnCombo As Boolean = False
    Public ValorMensaje As String = ""
    Private Sub Combo()
        Dim lst As Entity.General.ParametricaCol

        blnCombo = False
        Dim objBss As New Bussines.General.Parametrica

        Dim strMensajeTodos As String = ""

        If Me._TodosMensaje.Length > 0 Then
            strMensajeTodos = Me._TodosMensaje
        Else
            If _Todos = True Then
                strMensajeTodos = "[Todos]"
            ElseIf _NoIndica = True Then
                strMensajeTodos = "[No Indica]"
            End If
        End If

        lst = objBss.Listar(Me.ComboTipo, Me.CodigoPadre, Me.Parametro1, Me.Parametro2, _Todos, strMensajeTodos, Me.ModuloTratamiento)

        '---- eliminar los elementos que se deben excluir ------------
        If Not ListaIdsParaExcluir Is Nothing Then
            For Each elemento As Integer In ListaIdsParaExcluir
                For i As Integer = 0 To lst.Count - 1
                    If lst.parametrica(i).Codigo = elemento Then
                        lst.RemoveAt(i)
                        Exit For
                    End If
                Next
            Next
        End If
        If ValorMensaje = "NEU" Then
            Dim lstAux As New Entity.General.ParametricaCol
            For Each obj As Entity.General.Parametrica In lst
                Select Case obj.Codigo
                    Case 1, 115, 129, 184
                    Case Else
                        lstAux.Add(obj)
                End Select
            Next
            lst = lstAux
        End If

        If ValorMensaje = "OTR" Then
            Dim lstAux As New Entity.General.ParametricaCol
            For Each obj As Entity.General.Parametrica In lst
                Select Case obj.Codigo
                    Case 1, 115, 122, 129, 128, 3, 130, 2
                    Case Else
                        lstAux.Add(obj)
                End Select
            Next
            lst = lstAux
        End If
        '---------------------------------------

        With Me.ComboBox1

            objBss.TipoTexto = Me._TipoTexto
            .DataSource = lst

            .ValueMember = "Codigo"
            .DisplayMember = Legolas.Components.Cadena.ProperCase("Nombre").ToUpper

            If Me.DropDownWidthAuto = True Then
                Dim intValue As Integer = Me.Width + ((objBss.NombreLength * 12) * 0.3)
                .DropDownWidth = intValue
            End If

        End With
        blnCombo = True

    End Sub

    Public Sub Combo(TipoLicencia As Integer, Optional ByVal TipoDocumento As Integer = -1)
        Dim ValorMensaje As String = ""
        blnCombo = False


        Dim strMensajeTodos As String = ""

        If Me._TodosMensaje.Length > 0 Then
            strMensajeTodos = Me._TodosMensaje
        Else
            If _Todos = True Then
                strMensajeTodos = "[Todos]"
            ElseIf _NoIndica = True Then
                strMensajeTodos = "[No Indica]"
            End If
        End If

        Dim objBss As New Bussines.General.Parametrica

        With Me.ComboBox1
            Dim objColAux As New Entity.General.ParametricaCol
            Dim objCol As New Entity.General.ParametricaCol
            objBss.TipoTexto = Me._TipoTexto
            objColAux = objBss.Listar(Me.ComboTipo, Me.CodigoPadre, Me.Parametro1, Me.Parametro2, _Todos, strMensajeTodos, Me.ModuloTratamiento)

            If TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Conmutacion_Pena Then
                For Each obj As Entity.General.Parametrica In objColAux
                    Select Case obj.Codigo
                        Case 1, 16  '/*Autorida judicial,director EP, Presidencia de la Republica*/
                            objCol.Add(obj)
                    End Select
                Next
            ElseIf TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                For Each obj As Entity.General.Parametrica In objColAux
                    Select Case obj.Codigo
                        Case 1, 6, 8, 16, 20 '/*Autorida judicial,director EP, Presidencia de la Republica,Foro militar*/
                            objCol.Add(obj)
                    End Select
                Next
            ElseIf Me.ComboTipo = Type.Combo.Tratamiento.Trabajo.TallerAsistencia.tra_tal_asistencia_justificacion_mae Then
                For Each obj As Entity.General.Parametrica In objColAux
                    Select Case obj.Codigo
                        Case 1
                        Case Else
                            objCol.Add(obj)
                    End Select
                Next
            End If
            .DataSource = objCol
            .ValueMember = "Codigo"
            .DisplayMember = "Nombre"

            If Me.DropDownWidthAuto = True Then
                Dim intValue As Integer = Me.Width + ((objBss.NombreLength * 12) * 0.3)
                .DropDownWidth = intValue
            End If

        End With
        blnCombo = True

    End Sub
#End Region
#Region "Otros"
    Public Sub _LoadUsc(intTipoComo As Short, Optional blnModuloTratamiento As Boolean = False, Optional strMensaje As String = "")

        Me.ComboTipo = intTipoComo
        Me.ModuloTratamiento = blnModuloTratamiento
        Me.ValorMensaje = strMensaje
        Combo()
    End Sub
    Public Sub LoadUsc()

        Combo()

    End Sub
    'prueba

#End Region

    Private Sub ComboBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown

        If e.KeyCode = Keys.Delete Then
            Me.SelectedValue = -1
            RaiseEvent _KeyDown_Suprimir()

        End If

        If Me.pnlBusqueda.Visible = True Then
            If e.KeyCode = Keys.F3 Then
                RaiseEvent _Click_Buscar()
            End If
        End If

        RaiseEvent _KeyDown(sender, e)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        If blnCombo = True Then
            RaiseEvent _SelectedIndexChanged()
        End If

    End Sub

    Private Sub uscComboParametrica_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Height = 22
        Me.pnlEliminar.Visible = False
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click

        RaiseEvent _Click_Buscar()

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        RaiseEvent _Click_Agregar()

    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

        Me.SelectedValue = -1
        RaiseEvent _Click_Eliminar()

    End Sub

    Private Sub ComboBox1_MouseHover(sender As Object, e As EventArgs) Handles ComboBox1.MouseHover

        If verToolTipItemSeleccionado = True Then
            ToolTip1.ShowAlways = True
            ToolTip1.IsBalloon = True
            ToolTip1.SetToolTip(Me.ComboBox1, Me.Text)
        End If

    End Sub
    Public Sub ComboBoxConfiguracion()
        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDown
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDown Then
            e.Handled = True
        End If
    End Sub
End Class
