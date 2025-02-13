Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoReniec
        Private objEnt As Entity.Registro.Interno = Nothing
        Private objEntVal As Entity.Registro.InternoReniec = Nothing

        Private objEnt_ As Entity.General.Parametrica = Nothing
        Private objEntCol As Entity.General.ParametricaCol = Nothing

#Region "Functions"
        Public Function InternoValidado(ByVal objInterno As Entity.Registro.InternoReniec) As Integer
            Dim value As Integer = -1
            'usar clase entity
            value = Data.Registro.InternoReniec.ListarOutput("lst", "lst_consulta_int_val", objInterno)
            Return value
        End Function
    
        Public Function ValidarFotoReniec(ByVal objInterno As Entity.Registro.InternoReniec) As Integer
            Dim value As Integer = -1
            'usar clase entity
            value = Data.Registro.InternoReniec.ListarOutput("lst", "lst_fot_fro_val_rnc", objInterno)
            Return value
        End Function
#End Region
#Region "Combo"
        Public Function ListarHistorial(codigo As Integer) As Entity.General.ParametricaCol
            Dim Opcion As String = "lst_combo"
            Return ListarHistorial(Opcion, codigo, False, "")

        End Function
        Public Function ListarHistorial(ByVal Tipo As String, ByVal Padre As Integer, _
       ByVal Todos As Boolean, ByVal TodosMensaje As String) As Entity.General.ParametricaCol

            Return ListarHistorial(Tipo, Padre, -1, -1, True, "")

        End Function
        Public Function ListarHistorial(ByVal Tipo As String, ByVal Padre As Integer, _
        ByVal Parametrica1 As Integer, ByVal Parametrica2 As Integer, ByVal Todos As Boolean, _
        ByVal ComboMensaje As String) As Entity.General.ParametricaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEnt As New Entity.Registro.InternoReniec
            'Dim sqlDr As SqlDataReader = Data.General.Parametrica.Listar(sqlCon, "lst", "", Padre, _
            'Tipo.GetHashCode, "", "", Padre, Parametrica1, Parametrica2)
            objEnt.InternoID = Padre
            Dim sqlDr As SqlDataReader = Data.Registro.InternoReniec.Listar(sqlCon, "lst", Tipo, objEnt)

            Try
                objEntCol = New Entity.General.ParametricaCol

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt_ = New Entity.General.Parametrica
                        With objEnt_
                            .Codigo = sqlDr("par_id").ToString
                            .Nombre = "N°  " & sqlDr("par_nom").ToString
                        End With
                        objEntCol.Add(objEnt_)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing

            End Try
            Return objEntCol
        End Function
#End Region
#Region "Listar"
        Public Function ListarUltimaValidacion(ByVal objEnt As Entity.Registro.InternoReniec) As Entity.Registro.InternoReniec

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim opcion As String = "lst_int_val"

            Dim sqlDr As SqlDataReader = Data.Registro.InternoReniec.Listar(sqlCon, "lst", opcion, objEnt)

            Try
                If sqlDr.HasRows Then

                    objEntVal = New Entity.Registro.InternoReniec

                    While sqlDr.Read
                        With objEntVal
                            .Codigo = sqlDr("int_rnc_id").ToString
                            '.CodigoHistorial = sqlDr("int_rnc_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .TipoBusquedaID = sqlDr("int_rnc_tip_id").ToString
                            '.TipoBusquedaNom = sqlDr("int_rnc_tip_nom").ToString
                            .ComparacionID = sqlDr("int_rnc_com_id").ToString
                            '.ComparacionNom = sqlDr("int_rnc_com_nom").ToString
                            .FotoReniec = sqlDr("fot_rnc").ToString
                            .FotoInterno = sqlDr("fot_int").ToString
                            .InternoSisMetadata = sqlDr("int_rnc_sis_med").ToString
                            .InternoSisData = sqlDr("int_rnc_sis_dat").ToString
                            .NombresAsociadosID = sqlDr("int_nom_aso_id").ToString
                            .NombresAsociadosNom = sqlDr("int_nom_aso").ToString
                            .ReniecMetadata = sqlDr("int_rnc_med").ToString
                            .ReniecData = sqlDr("int_rnc_dat").ToString
                            .Observaciones = sqlDr("int_rnc_obs").ToString
                            .PthServidor = sqlDr("arc_dig_pth_ser").ToString
                            .FechaValidacion = sqlDr("_fec_cre").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .NombreAsociadoVal_ID = sqlDr("int_rnc_nom_aso_val_id").ToString
                            .InternoCodRP = sqlDr("int_cod_rp").ToString
                            '.PthServidorFotoInterno = sqlDr("pth_serv_fot_int").ToString
                        End With
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
            Return objEntVal
        End Function
        
        Public Function Listar(objEnt As Entity.Registro.InternoReniec) As Entity.Registro.InternoReniec
            'especificar bien la varavle de entrada
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim opcion As String = "lst_int_val_ID"
            Dim sqlDr As SqlDataReader = Data.Registro.InternoReniec.Listar(sqlCon, "lst", opcion, objEnt)
            objEntVal = New Entity.Registro.InternoReniec
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEntVal
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoHistorial = sqlDr("int_rnc_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .TipoBusquedaID = sqlDr("int_rnc_tip_id").ToString
                            .ComparacionID = sqlDr("int_rnc_com_id").ToString
                            .FotoReniec = sqlDr("fot_rnc").ToString
                            .FotoInterno = sqlDr("fot_int").ToString
                            .InternoSisMetadata = sqlDr("int_rnc_sis_med").ToString
                            .InternoSisData = sqlDr("int_rnc_sis_dat").ToString
                            .NombresAsociadosID = sqlDr("int_nom_aso_id").ToString
                            .NombresAsociadosNom = sqlDr("int_nom_aso").ToString
                            .ReniecMetadata = sqlDr("int_rnc_med").ToString
                            .ReniecData = sqlDr("int_rnc_dat").ToString
                            .Observaciones = sqlDr("int_rnc_obs").ToString
                            .PthServidor = sqlDr("arc_dig_pth_ser").ToString
                            .FechaValidacion = sqlDr("_fec_cre").ToString
                            .NombreAsociadoVal_ID = sqlDr("int_rnc_nom_aso_val_id").ToString
                            .NombreAsociadoVal_Nom = sqlDr("int_rnc_nom_aso_val_nom").ToString
                        End With
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
            Return objEntVal
        End Function

        Public Function Listar2(objEnt As Entity.Registro.InternoReniec) As Entity.Registro.InternoReniec
            'Para la version 2 de reniec J.E.U
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim opcion As String = "lst_int_val_ID2"
            Dim sqlDr As SqlDataReader = Data.Registro.InternoReniec.Listar(sqlCon, "lst", opcion, objEnt)
            objEntVal = New Entity.Registro.InternoReniec
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEntVal
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoHistorial = sqlDr("int_rnc_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .TipoBusquedaID = sqlDr("int_rnc_tip_id").ToString
                            .ComparacionID = sqlDr("int_rnc_com_id").ToString
                            .FotoReniec = sqlDr("fot_rnc").ToString
                            .FotoInterno = sqlDr("fot_int").ToString
                            .InternoSisMetadata = sqlDr("int_rnc_sis_med").ToString
                            .InternoSisData = sqlDr("int_rnc_sis_dat").ToString
                            .NombresAsociadosID = sqlDr("int_nom_aso_id").ToString
                            .NombresAsociadosNom = sqlDr("int_nom_aso").ToString
                            .ReniecMetadata = sqlDr("int_rnc_med").ToString
                            .ReniecData = sqlDr("int_rnc_dat").ToString
                            .Observaciones = sqlDr("int_rnc_obs").ToString
                            .PthServidor = sqlDr("arc_dig_pth_ser").ToString
                            .FechaValidacion = sqlDr("_fec_cre").ToString
                            .NombreAsociadoVal_ID = sqlDr("int_rnc_nom_aso_val_id").ToString
                            .NombreAsociadoVal_Nom = sqlDr("int_rnc_nom_aso_val_nom").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally

                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntVal
        End Function

        Public Function FotoIDRncReciente(ByVal InternoID As Integer, varhis As String) As Integer
            Dim opcion As String
            If varhis < 1 Then
                opcion = "lst_fot_rnc_int_ult"
            Else
                opcion = "lst_fot_rnc_int"
            End If
            Dim intValue As Integer = -1
            intValue = Data.Registro.InternoFoto.ListarOutput("lst", opcion, varhis, InternoID, -1, 0, -1, -1)
            Return intValue

        End Function
        Public Function ListarGeo(objEnt As Entity.Registro.InternoReniec) As Entity.Registro.InternoReniec
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoReniec.Listar(sqlCon, "lst", "lst_int_geo", objEnt)
            objEntVal = New Entity.Registro.InternoReniec
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEntVal
                            .Codigo = sqlDr("int_rnc_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .Latitud = sqlDr("int_rnc_lat").ToString
                            .Longitud = sqlDr("int_rnc_lon").ToString
                            .ReniecData = sqlDr("int_rnc_dat").ToString
                            .FechaValidacion = sqlDr("_fec_cre").ToString
                        End With
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
            Return objEntVal
        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(ByVal objInternoRnc As Entity.Registro.InternoReniec) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objInternoRnc.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If
         
            Value = Data.Registro.InternoReniec.Grabar(strAccion, strOpcion, objInternoRnc)

            Return Value
        End Function
        Public Function Grabar2(ByVal objInterno As Entity.Registro.InternoReniec) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objInterno.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant2"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If
            'If ValidarNombre(objInterno.Codigo, objInterno.TipoBusquedaID, objInterno.ComparacionID) = False Then
            '    MsgBox("El Interno ya esta Validado", 48, Legolas.Configuration.Aplication.MessageBox.MensajeTitulo)
            'Else
            Value = Data.Registro.InternoReniec.Grabar2(strAccion, strOpcion, objInterno)

            Return Value
        End Function
        Public Function GrabarGeo(ByVal objInternoRnc As Entity.Registro.InternoReniec) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objInternoRnc.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_mant_geo"
            End If

            Value = Data.Registro.InternoReniec.Grabar(strAccion, strOpcion, objInternoRnc)

            Return Value
        End Function
        Public Function Grabar2_LM(ByVal objInterno As Entity.Registro.InternoReniec) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objInterno.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant2_LM"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            Value = Data.Registro.InternoReniec.Grabar2_LM(strAccion, strOpcion, objInterno)

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

