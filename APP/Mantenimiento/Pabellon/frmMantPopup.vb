Namespace Mantenimiento.Pabellon
    Public Class frmMantPopup
        Public _frmLectura As Boolean = False
        Public _frmEscritura As Boolean = False
        Public _frmReporte As Boolean = False
        Public _frmImpresion As Boolean = False
        Public _frmEliminar As Boolean = False

        Private objBss As Bussines.Mantenimiento.General.Pabellon = Nothing
        Private objEnt As Entity.Mantenimiento.General.Pabellon = Nothing
#Region "Propiedades_Publicas"
        Public Property _Codigo() As Integer
        Public Property _RegionID As Integer = -1
        Public Property _PenalID As Integer = -1
#End Region
#Region "Propiedades"
        Private Property Nombre() As String
            Get
                Return Me.txtNombre.Text.Trim
            End Get
            Set(value As String)
                Me.txtNombre.Text = value
            End Set
        End Property
        Private Property NombreCorto() As String
            Get
                Return Me.txtNombreCorto.Text.Trim
            End Get
            Set(value As String)
                Me.txtNombreCorto.Text = value
            End Set
        End Property
        Private Property Observacion() As String
            Get
                Return Me.txtObs.Text.Trim
            End Get
            Set(value As String)
                Me.txtObs.Text = value
            End Set
        End Property
        Private Property Estado() As Short = 1 'activo
#End Region
#Region "Listar"
        Private Sub ListarMant()

            If Me._Codigo < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Mantenimiento.General.Pabellon
            objEnt = New Entity.Mantenimiento.General.Pabellon

            objEnt = objBss.Listar(Me._Codigo)

            With Me.objEnt
                Me._RegionID = .RegionID
                Me._PenalID = .PenalID
                Me.Nombre = .Nombre
                Me.NombreCorto = .NombreCorto
                Me.Observacion = .Obs
                Me.Estado = .Estado
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            If Me.Nombre.Trim.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Ingrese el nombre del Pabellon")
                Me.txtNombre.Focus()
                Return value
            End If

            If Me.NombreCorto.Trim.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Ingrese el nombre corto del Pabellon")
                Me.txtNombreCorto.Focus()
                Return value
            End If

            value = True
            Return value

        End Function
        Private Sub AOK()

            If Validar() = False Then
                Exit Sub
            End If

            Dim value As Integer = -1
            objBss = New Bussines.Mantenimiento.General.Pabellon
            objEnt = New Entity.Mantenimiento.General.Pabellon

            With objEnt
                .Codigo = Me._Codigo
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .Nombre = Me.Nombre
                .NombreCorto = Me.NombreCorto
                .Obs = Me.Observacion
                .Estado = Me.Estado
            End With

            value = objBss.Grabar(objEnt)

            If value > 0 Then

                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            Usuario_Permisos()

        End Sub
        Private Sub Usuario_Permisos()

            Me.btnOK.Visible = Me._FormEscritura

        End Sub
#End Region
        Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click

            AOK()

        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub frmMantPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmMantPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            ListarMant()

        End Sub
    End Class
End Namespace