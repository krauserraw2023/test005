Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class ConfigHuella
        Private objEnt As Entity.Visita.ConfigHuella = Nothing
        Private objEntCol As Entity.Visita.ConfigHuellaCol = Nothing
        
#Region "Validar"
        Public Function ValidarServicioBaja(FechaServicio As Long, IDRegion As Short, IDPenal As Short) As Boolean

            Dim value As Boolean = False
            Dim intCount As Integer = 0

            objEnt = New Entity.Visita.ConfigHuella

            With objEnt
                .Fecha = FechaServicio
                .IDRegion = IDRegion
                .IDPenal = IDPenal
            End With

            intCount = Data.Visita.ConfigHuella.ListarOutput("lst", "lst_validar_servicio_baja", objEnt)

            If intCount > 0 Then
                value = True
            End If

            Return value
        End Function
        Public Function ValidarServicioAlta(Codigo As Integer, IDRegion As Short, IDPenal As Short) As Boolean

            Dim value As Boolean = False
            Dim intCount As Integer = 0

            objEnt = New Entity.Visita.ConfigHuella

            With objEnt
                .Codigo = Codigo
                .IDRegion = IDRegion
                .IDPenal = IDPenal
            End With

            intCount = Data.Visita.ConfigHuella.ListarOutput("lst", "lst_validar_servicio_alta", objEnt)

            If intCount > 0 Then
                value = True
            End If

            Return value
        End Function
#End Region

#Region "Funciones"
        Public Function GetIDConfigHuella(FechaServicio As Long, IDRegion As Short, IDPenal As Short) As Integer

            Dim value As Integer = -1

            objEnt = New Entity.Visita.ConfigHuella

            With objEnt
                .Fecha = FechaServicio
                .IDRegion = IDRegion
                .IDPenal = IDPenal
            End With

            value = Data.Visita.ConfigHuella.ListarOutput("lst", "lst_id_config", objEnt)

            Return value
        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(ByVal objEnt As Entity.Visita.ConfigHuella) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            With objEnt
                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If
            End With
            Value = Data.Visita.ConfigHuella.Grabar(strAccion, strOpcion, objEnt)
            Return Value
        End Function
        Public Function DeshabilitarHuella(ByVal objEnt As Entity.Visita.ConfigHuella) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "ins"
            strOpcion = "ins_mant"

            With objEnt
                .Codigo = -1
                .Estado = 0 'baja
            End With

            Value = Data.Visita.ConfigHuella.Grabar(strAccion, strOpcion, objEnt)

            Return Value
        End Function
        Public Function HabilitarHuella(ByVal objEnt As Entity.Visita.ConfigHuella) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_mant"

            With objEnt                
                .Estado = 1 'alta
            End With

            Value = Data.Visita.ConfigHuella.Grabar(strAccion, strOpcion, objEnt)

            Return Value
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal ObjEnt As Entity.Visita.ConfigHuella) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            Value = Data.Visita.ConfigHuella.Eliminar(strAccion, strOpcion, ObjEnt)
            Return Value
        End Function
#End Region
    End Class
End Namespace