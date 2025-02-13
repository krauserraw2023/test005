Imports System.IO
Namespace Seguridad.Modulo
    Public Class frmBuscar
        Private objEnt As Legolas.LEntity.Seguridad.Modulo = Nothing
        Private objBss As Legolas.LBusiness.Seguridad.Modulo = Nothing
#Region "Instancia"
        'Variable Shared que contiene la única instancia del formulario.
        Private Shared ChildInstance As Seguridad.Modulo.frmBuscar = Nothing
        'controla que sólo exista una instancia del formulario.
        Public Shared Function Instance() As Seguridad.Modulo.frmBuscar
            If ChildInstance Is Nothing OrElse ChildInstance.IsDisposed = True Then
                ChildInstance = New Seguridad.Modulo.frmBuscar
            End If
            ChildInstance.BringToFront()
            Return ChildInstance
        End Function
#End Region
#Region "TreeNode"
        Public Class TreeNode
            Inherits System.Windows.Forms.TreeNode
            Private _intCodigo As Integer = -1
            Private _intCodigoPadre As Integer = -1
#Region "Propiedades"
            Public Property Codigo() As Integer
                Get
                    Return _intCodigo
                End Get
                Set(ByVal value As Integer)
                    _intCodigo = value
                End Set
            End Property
            Public Property CodigoPadre() As Integer
                Get
                    Return _intCodigoPadre
                End Get
                Set(ByVal value As Integer)
                    _intCodigoPadre = value
                End Set
            End Property
#End Region
        End Class
#End Region
#Region "Propiedades"
        Private intCodigo As Integer = -1        
        Private intModuloCodigoPadre As Integer = 0
        Private Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Private Property ModuloNivel() As Integer
            Get
                Return Me.nudNivel.Value
            End Get
            Set(ByVal value As Integer)

                If value < 0 Then
                    value = 0
                End If

                Me.nudNivel.Value = value
            End Set
        End Property
        Private Property CodigoPadre() As Integer
            Get
                Return intModuloCodigoPadre
            End Get
            Set(ByVal value As Integer)
                intModuloCodigoPadre = value
            End Set
        End Property
        Private Property RutaIcono() As String
            Get
                Return Me.txtRuta.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtRuta.Text = value
            End Set
        End Property
        Private Property Nombre() As String
            Get
                Return Me.txtTitulo.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtTitulo.Text = value
            End Set
        End Property
        Private Property Objeto() As String
            Get
                Return Me.txtObjeto.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObjeto.Text = value
            End Set
        End Property
        Private Property Icono() As Byte()
            Get
                Try
                    Dim bmp As Bitmap = Me.PictureBox1.Image

                    Dim ms As MemoryStream = New MemoryStream()
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png)

                    Dim bmpBytes() As Byte = ms.GetBuffer()
                    bmp.Dispose()
                    ms.Close()

                    Return bmpBytes
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
            Set(ByVal value As Byte())

                If IsNothing(value) = False Then
                    If value.Length > 0 Then
                        Dim ms As New MemoryStream(value)
                        PictureBox1.Image = Image.FromStream(ms)
                    Else
                        PictureBox1.Image = My.Resources.windows
                        'PictureBox1.Image = Nothing
                    End If
                Else
                    PictureBox1.Image = My.Resources.windows
                    'PictureBox1.Image = Nothing
                End If

            End Set
        End Property
        Private Property NumOrden() As Integer
            Get
                Dim intValue As Integer

                If IsNumeric(Me.txtOrden.Text) Then
                    intValue = Integer.Parse(Me.txtOrden.Text)
                Else
                    intValue = 999
                End If
                Return intValue
            End Get
            Set(ByVal value As Integer)
                Me.txtOrden.Text = value.ToString
            End Set
        End Property
        Public Property Activo() As Boolean
            Get
                Return Me.chkActivo.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkActivo.Checked = value
            End Set
        End Property
        Public Property HasSubModulo() As Boolean
            Get
                Return Me.chkSubmodulo.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkSubmodulo.Checked = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub Listar()

            If Me.Codigo < 1 Then
                Exit Sub
            End If

            objEnt = New Legolas.LEntity.Seguridad.Modulo
            objBss = New Legolas.LBusiness.Seguridad.Modulo

            objEnt = objBss.Listar(Me.Codigo)

            With objEnt
                'Me.Codigo = .Codigo '
                Me.ModuloNivel = .Nivel
                Me.CodigoPadre = .CodigoPadre '
                Me.Nombre = .Nombre '
                Me.Objeto = .Objecto '
                Me.Icono = .Icono '
                Me.NumOrden = .Orden '  
                Me.Activo = .Activo
                Me.HasSubModulo = .HasSeccion
            End With

            'Me.PictureBox1.Refresh()

        End Sub
        Private Sub Buscar()
            Me.tvwModulo.Nodes.Clear()
            CargarNodo(0, Nothing, True)
        End Sub
#End Region
#Region "Accion"
        Private Sub AMantenimiento(ByVal Nuevo As Boolean)

            Dim frm As New Seguridad.Modulo.frmMantPopup
            With frm
                If Nuevo = True Then
                    .Codigo = -1
                    .CodigoPadre = Me.Codigo
                Else
                    .Codigo = Me.Codigo
                End If

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Buscar()
                End If
            End With

            'Dim strMensaje As String = ""
            'strMensaje = "Desea agregar un modulo de tipo principal"

            'If MessageBox.Show(strMensaje,  Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
            'MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            '    ALimpiar()
            '    Me.Mensaje = "Ingrese los datos del modulo a crear"

            'End If
        End Sub
        Private Sub AEliminar()

            'objBss = New Legolas.LBusiness.Seguridad.Modulo
            'Dim intCodigo As Integer = -1

            'intCodigo = objBss.e(Me.Codigo, Me.ModuloNivel, Me.HasSubModulo, Me.CodigoPadre,
            'Me.RutaIcono, Me.Nombre,
            'Me.Objeto, Me.Icono, Me.NumOrden, Me.Activo)

            'If intCodigo > 0 Then

            '    Me.DialogResult = Windows.Forms.DialogResult.OK
            '    Me.Close()
            'End If


        End Sub
#End Region
#Region "Nodo"
        Private Sub CargarNodo(ByVal codigoPadre As Integer, ByVal nodoPadre As TreeNode, ByVal recursivo As Boolean)
            Dim bssModulo As New Legolas.LBusiness.Seguridad.Modulo
            Dim entModulos As Legolas.LEntity.Seguridad.ModuloCol = bssModulo.Listar(-1, codigoPadre, String.Empty)

            If Not entModulos Is Nothing Then
                For Each entModulo As Legolas.LEntity.Seguridad.Modulo In entModulos
                    Dim nodoHijo As New TreeNode

                    nodoHijo.Codigo = entModulo.Codigo
                    nodoHijo.CodigoPadre = entModulo.CodigoPadre
                    nodoHijo.Text = entModulo.Nombre

                    If nodoPadre Is Nothing Then
                        tvwModulo.Nodes.Add(nodoHijo)
                    Else
                        nodoPadre.Nodes.Add(nodoHijo)
                    End If

                    'If recursivo Then
                    CargarNodo(entModulo.Codigo, nodoHijo, False)
                    'End If
                Next
            End If
        End Sub
#End Region
#Region "Otros"
        Private Sub ALimpiar()
            Me.Codigo = -1
            Me.ModuloNivel = 0
            Me.CodigoPadre = 0
            Me.Nombre = ""
            Me.Objeto = ""
            Me.RutaIcono = ""
            Me.NumOrden = 0
        End Sub
#End Region
        Private Sub frmMant_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            Me.WindowState = FormWindowState.Maximized

        End Sub

        Private Sub tvwModulo_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvwModulo.AfterSelect

            Dim nodo As TreeNode = CType(tvwModulo.SelectedNode, TreeNode)
            Me.Codigo = nodo.Codigo

            Listar()

        End Sub

        Private Sub tvwModulo_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles tvwModulo.BeforeExpand

            Dim nodo As TreeNode = CType(tvwModulo.SelectedNode, TreeNode)

            If Not IsNothing(nodo) = True Then
                If Not nodo.IsExpanded Then
                    nodo.Nodes.Clear()
                    CargarNodo(nodo.Codigo, nodo, True)

                End If

            End If

        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
            AMantenimiento(True)
        End Sub

        Private Sub frmBuscar_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Buscar()

        End Sub

        Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
            AMantenimiento(False)
        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

            AEliminar

        End Sub
    End Class
End Namespace
