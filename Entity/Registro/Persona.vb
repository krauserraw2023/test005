Namespace Registro   'Namespace Registro.??????.?????
    Public Class Persona
        Inherits Legolas.LEntity.Globall.Persona
        Public Property Codigo As Integer = -1
        Public Property CUP As String = "" 'codigo unico
        Public Property NacimientoUbigeoID() As Integer = -1
        Public Property NacimientoLugarOtros As String = ""
        Public Property DNIObservacion As String = ""
        Public Property DomicilioDistritoId As Integer = -1
        Public Property NivelAcademicoId As Integer = -1
        Public Property ProfesionId As Integer = -1
        Public Property OcupacionId As Integer = -1
        Public Property DiscapacidadId As Integer = -1
        Public Property ComunidadId As Integer = -1
        Public Property ComunidadEspecificaId As Integer = -1
#Region "Propiedades_Ubigeo"
        Public Property Departamento() As String = ""
        Public Property Provincia() As String = ""
        Public Property Distrito() As String = ""
        Public ReadOnly Property Ubigeo() As String
            Get
                Dim strValue As String = ""

                strValue = Me.Departamento & "/" & Me.Provincia & "/" & Me.Distrito
                Return Legolas.Components.Cadena.ProperCase(strValue)
            End Get
        End Property
#End Region
        Public Property AliasPersona As String = ""
        Public Property Padre As String = ""
        Public Property Madre As String = ""
        Public Property Conyuge As String = ""
        Public Property FotoPerfilIzquierdo As Integer = -1
        Public Property FotoPerfilFrente As Integer = -1
        Public Property FotoPerfilDerecho As Integer = -1
        Public Property ObservacionPersona As String = ""
        Public Property Decadactilar As String = ""
        Public Property EstadoRncID As Integer = -1
        Public ReadOnly Property EstadoRnc As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoRncID
                    Case 1
                        value = "VAL" 'validado
                    Case 2
                        value = "OBS" 'observado
                    Case 3
                        value = "IND" 'indocumentado
                End Select
                Return value
            End Get
        End Property
        Public Property Homonimia As Boolean = False
        Public Property IdiomaNativoId As Integer = -1
        Public Property GeneroId As Integer = -1
        Public Property CentroTrabajo As String = ""
        Public Property ReligionId As Integer = -1
        Public Property FuerzaArmadaId As Integer = -1
        Public Property RangoCodigo As Integer = -1
        Public Property RegionId As Integer = -1
        Public Property PenalId As Integer = -1
    End Class


End Namespace
