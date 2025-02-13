Imports System.Data
Imports System.Data.SqlClient
Imports Data.Registro.Carceleta.Clasificacion.InternoClasificacion
Namespace Clasificacion.InternoClasificacion
    Public Class InternoAgraviado_BL
        Private objEnt As Entity.Clasificacion.InternoClasificacion.Agraviado = Nothing
        Private objEntCol As Entity.Clasificacion.InternoClasificacion.AgraviadoCol = Nothing
#Region "Listar"

#End Region
#Region "Validar"
        Private Function Validar(objEnt As Entity.Clasificacion.InternoClasificacion.Agraviado) As Boolean
            If objEnt.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Interno [Agraviado]")
                Return False
            End If
            If objEnt.IngresoInpeId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Ingreso [Agraviado]")
                Return False
            End If
            If objEnt.RegionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Region [Agraviado]")
                Return False
            End If
            If objEnt.PenalID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha enviado parametro Penal [Agraviado]")
                Return False
            End If
            Return True
        End Function
#End Region
#Region "Grabar"

        Public Function Grabar(objEnt As Entity.Clasificacion.InternoClasificacion.Agraviado) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            If Validar(objEnt) = True Then
                If objEnt.Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant_v2"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant_v2"
                End If

                intValue = InternoAgraviado_DA.Grabar(strAccion, strOpcion, objEnt)
            Else
                Return -1
            End If

            Return intValue

        End Function
#End Region

    End Class
End Namespace