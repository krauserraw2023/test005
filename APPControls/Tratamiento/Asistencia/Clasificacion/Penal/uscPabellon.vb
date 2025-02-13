Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal

Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class uscPabellon
        Private objEnt As InternoPabellon_BE = Nothing

        Private blnClickGrilla As Boolean = False
#Region "Eventos"
        Public Event _Grilla_CellEnter(intCodigo As Integer, TipoTablaAudit As Type.Enumeracion.Auditoria.EnumTipTabla)
        Public Event _Reporte_Click(intIDFichaFinalEtapa As Integer)
#End Region
#Region "Enum"
        Private Enum EnmEstado As Short
            Pendiente = 1
            Finalizado = 2
        End Enum
#End Region
#Region "Propiedades_Publicas"
        Public Property IDPabellon As Integer = -1
        Public Property _IDInterno As Integer = -1
        Public Property _InternoApeNom As String = ""
        Public Property _IDIngresoInpe As Integer = -1
        Public Property _IDIngreso As Integer = -1
        Public Property _InternoEstado As Short = -1
        Public Property _IDRegion As Short = -1
        Public Property _IDPenal As Short = -1
#End Region
#Region "Propiedades_UserControl"
        Public Property _uscPerfilUsuario As Type.Enumeracion.Usuario.EnumDependencia
        Public Property _uscEscritura As Boolean = False
        Public Property _uscEliminar() As Boolean = False
        Public Property _uscReporte() As Boolean = False
#End Region

#Region "Listar"
        Public Sub _ListarUsc()

            'MostrarControlesFicha()
            'ListarGrilla()

        End Sub

#End Region




    End Class

End Namespace
