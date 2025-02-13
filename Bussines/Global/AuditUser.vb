Imports System.Data
Imports System.Data.SqlClient
Namespace Globall
    Public Class AuditUser
        Public Function Listar(IdRegistro As Integer, TipoTabla As Type.Enumeracion.TipoTabla.EnumTipTabla) As Entity.Globall.AuditUser
            Return (New Data.Globall.AuditUser).Listar(IdRegistro, TipoTabla, "lst", "lst_audit_user")
        End Function
    End Class

End Namespace

