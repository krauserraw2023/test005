Public Class Config
    Public Class Licencia
        Public Shared Property LicenciaTipo As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno

    End Class
    Public Class Usuario
        Public Shared NivelUsuario As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Public Shared PerfilUsuario As Type.Enumeracion.Usuario.EnumDependencia = Type.Enumeracion.Usuario.EnumDependencia.Ninguno
    End Class
End Class
