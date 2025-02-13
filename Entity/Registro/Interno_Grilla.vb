Namespace Registro
    Public Class Interno_Grilla

#Region "Propiedades_Interno"
        Public Property IDInterno As Integer = -1
        Public Property IDInternoString As String = ""
        Public Property InternoCodigoRP As String = ""
        Public Property PrimerApellido As String = ""
        Public Property SegundoApellido As String = ""
        Public Property Apellidos As String = ""
        Public Property PreNombres As String = ""
        Public Property InternoAlias As String = ""
        Public Property IDSexo As Short = -1
        Public Property NacionalidadExtranjero As Short = -1
        Public Property IDNacionalidad As Short = -1
        Public Property IDInternoEstado As Short = -1
        Public Property InternoNumeroDocumento As String = ""
        Public Property IDRegion As Short = -1
        Public Property IDPenal As Short = -1
        Public Property IDPenalString As String = ""
        Public Property IDTipoDocIdentidad As Integer = -1
        Public Property NombreClave As String = ""
        Public Property CodigoUnicoInterno As String = ""
        Public Property TrasladadoDeCarceleta As Integer = -1 'si el interno es trasladado o no
        Public Property IDAfiliacion As Short = -1

        Public Property NCola As Long = -1

        Public Property TipoFecha As Short = -1
        Public Property FechaIngresoIni As Long = 0
        Public Property FechaIngresoFin As Long = 0
        Public Property EstadoAfiliacionID As Short = 1

        Public Property EstadoInternoCarceletaId As Integer = -1 'activo o inactivo del interno para carceleta (considera estado del interno y el estado de traslado)
        'Public Property EstadoInternoId As Integer = -1 'estado del interno
        Public Property SetRowID As Integer = -1
#End Region
#Region "Propiedades_Nombres_Asociados"
        Public Property NombreAsociadoPrincipal As Short = -1
        Public Property NombreAsociadoEstado As Short = -1
#End Region
#Region "Propiedades_Ingreso"
        Public Property IDSituacionJuridica As Short = -1
#End Region
#Region "Propiedades_Delito"
        Public Property IDDelitoGenerico As Integer = -1
        Public Property IDDelitoEspecifico As Integer = -1
#End Region
#Region "Propiedades_Movimiento"
        Public Property IDGrupoMovimiento As Short = -1
        Public Property IDTipoMovimiento As Short = -1
        Public Property IDMotivoMovimiento As Short = -1
        Public Property IDMovimientoEstado As Short = -1
#End Region
#Region "Propiedades_Clasificacion"
        Public Property TipoClasificacion As Short = -1
        Public Property IDRegionClasif As Short
        Public Property IDPenalClasif As Short
#End Region
#Region "Propiedades_Antecedentes"
        Public Property _TipoAntecedenteId As Short = -1
#End Region
        Public Class NombresAsociadosCol
            Inherits Entity.Registro.NombreAsociadoCol
        End Class
        Public Class NombresAsociados
            Inherits Entity.Registro.NombreAsociado
        End Class
        Public Class InternoIngresoCol
            Inherits Entity.Registro.IngresoCol

        End Class
        Public Class InternoIngreso
            Inherits Entity.Registro.Ingreso

        End Class
        Public Class InternoDelitoCol
            Inherits Registro.DelitoCol
        End Class
        Public Class InternoDelito
            Inherits Registro.Delito
        End Class

        Public Class FiltroAlias
            Public Property IDInterno As Integer = -1
            Public Property Nombre As String = ""
        End Class

        Public Class FiltroSituacionJuridica
            Public Property IDInterno As Integer = -1
            Public Property IDSitucionJuridica As String = ""
        End Class
        Public Class FiltroDelito
            Public Property IDInterno As Integer = -1
            Public Property IDDelitoGenerico As Integer = -1
            Public Property IDDelitoEspecifico As Integer = -1
        End Class
    End Class

End Namespace
