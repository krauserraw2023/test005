Namespace Sistema.Seguridad
    Public Class Usuario
        Inherits Legolas.LEntity.Auditoria.Transaccion

        Public Property Codigo As Integer = -1
        Public Property CueUsuario As Integer = -1
        Public Property Dependencia As Integer = -1
        Public Property Tipo As Integer = -1
        Public Property TrabajadorID As Integer = -1
        Public Property CueTrabajador As Integer = -1
        Public Property IDTrabajador As Integer
        Public Property CueLogin As String = ""
        Public Property Login As String = ""
        Public Property ClaveNueva As Boolean = False
        Public Property NivelUsuario As Short = -1 'licencia
        Public Property ApellidoPaterno As String = ""
        Public Property ApellidoMaterno As String = ""
        Public Property Nombres As String = ""

        Public ReadOnly Property getApellidosyNombres As String
            Get
                Dim value As String = ""
                value = Me.ApellidoPaterno & " " & Me.ApellidoMaterno & ", " & Me.Nombres
                Return value
            End Get
        End Property

        Public Property NumeroDocumento As String = ""
        Public Property Perfil As Short = -1
        Public Property PerfilNombre As String = ""
        Public Property CargoNombre As String = ""
        Public Property Correo As String = ""
        Public Property FechaVerificacion As DateTime = "12/12/1985"

        Public Property AdminValidarPC As Boolean = False
        Public Property AdminModuloUsuario As Boolean = False
        Public Property ValidarPorHUella As Boolean = False
        '/*Permisos*/
        Public Property FormLectura As Boolean = False
        Public Property FormEscritura As Boolean = False
        Public Property FormEliminacion As Boolean = False
        Public Property FormReporte As Boolean = False
        '/*Auxiliares*/'
        Public Property ModuloId As Integer = -1
    End Class

End Namespace
