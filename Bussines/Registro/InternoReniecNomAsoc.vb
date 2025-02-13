Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoReniecNomAsoc                        
        Private objEntValColNA As Entity.Registro.InternoReniecNomAsocCol = Nothing
        Private objEntValNA As Entity.Registro.InternoReniecNomAsoc = Nothing
#Region "Listar"
        Public Function Listar(objEnt As Entity.Registro.InternoReniecNomAsoc) As Entity.Registro.InternoReniecNomAsocCol
            'Para la version 2 de reniec J.E.U
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim opcion As String = "lst_mant"
            Dim sqlDr As SqlDataReader = Data.Registro.InternoReniecNomAsoc.Listar(sqlCon, "lst", opcion, objEnt)
            'objEntValCol = New Entity.Registro.InternoReniecNomAsocCol
            Try
                objEntValColNA = New Entity.Registro.InternoReniecNomAsocCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEntValNA = New Entity.Registro.InternoReniecNomAsoc
                        With objEntValNA
                            .Codigo = sqlDr("rnc_nom_asoc_id").ToString
                            '.IngresoID = sqlDr("int_ing_id").ToString
                            '.InternoID = sqlDr("int_id").ToString
                            .InternoReniecID = sqlDr("fk_int_rnc_id").ToString
                            .ApellidoPaterno = sqlDr("rnc_aso_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("rnc_aso_ape_mat").ToString
                            .Nombres = sqlDr("rnc_aso_nom").ToString
                            .RegionID = sqlDr("_RegId").ToString
                            .PenalID = sqlDr("_PenId").ToString
                        End With
                        objEntValColNA.Add(objEntValNA)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntValColNA
        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(ByVal objInterno As Entity.Registro.InternoReniecNomAsoc) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objInterno.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If
            'If ValidarNombre(objInterno.Codigo, objInterno.TipoBusquedaID, objInterno.ComparacionID) = False Then
            '    MsgBox("El Interno ya esta Validado", 48, Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)
            'Else
            Value = Data.Registro.InternoReniecNomAsoc.Grabar(strAccion, strOpcion, objInterno)
            'End If
            Return Value
        End Function

        Public Function Grabar_LM(ByVal objInterno As Entity.Registro.InternoReniecNomAsoc) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objInterno.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_LM"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            Value = Data.Registro.InternoReniecNomAsoc.Grabar_LM(strAccion, strOpcion, objInterno)

            Return Value
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(Codigo As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            Dim Usuario As Integer = Legolas.Configuration.Usuario.Codigo
            If Codigo > 0 Then
                strAccion = "del"
                strOpcion = "del_mant"
            End If
            intValue = Data.Registro.InternoReniec.Eliminar(strAccion, strOpcion, Codigo, Usuario)
            Return intValue
        End Function
#End Region
    End Class

End Namespace

