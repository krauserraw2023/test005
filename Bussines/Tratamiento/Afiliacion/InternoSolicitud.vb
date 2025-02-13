Imports System.Data
Imports System.Data.SqlClient
Namespace Tratamiento.Afiliacion
    Public Class InternoSolicitud
        Private objEnt As Entity.Tratamiento.Afiliacion.InternoSolicitud = Nothing
        Private objEntCol As Entity.Tratamiento.Afiliacion.InternoSolicitudCol = Nothing
#Region "Functions"

        Public Shared Function EstadoNombre(ByVal InternoID As Integer) As String

            Dim value As String = ""
            Dim intEstado As Integer = -1
            Dim strEstado As String = ""

            intEstado = Data.Registro.Interno.ListarOutput("lst", "lst_interno_estado", InternoID, _
                                                           "", -1, "", "", "", "", -1, -1)

            Select Case intEstado
                Case 0
                    strEstado = "Inactivo"
                Case 1
                    strEstado = "Activo"
                Case Else
                    strEstado = ""
            End Select

            value = strEstado.ToUpper

            Return value

        End Function
        Public Function ListarResumen(ent As Entity.Tratamiento.Afiliacion.InternoSolicitud) As Entity.Tratamiento.Afiliacion.InternoSolicitudCol

            Dim objCol As Entity.Tratamiento.Afiliacion.InternoSolicitudCol
            Dim objEnt As Entity.Tratamiento.Afiliacion.InternoSolicitud

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Tratamiento.Afiliacion.InternoSolicitud.ListarRes(sqlCon, "lst", "lst_resumen", ent)

            Try
                objCol = New Entity.Tratamiento.Afiliacion.InternoSolicitudCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.Afiliacion.InternoSolicitud
                        With objEnt
                            .RegionID = sqlDr("fk_reg_id").ToString
                            .PenalID = sqlDr("fk_pen_id").ToString
                            .RegionNombre = sqlDr("RegionNom").ToString
                            .PenalNombre = sqlDr("PenalNom").ToString
                            .Cantidad = sqlDr("Cantidad").ToString
                            .TipoMovimientoID = sqlDr("TipoMov").ToString
                          
                        End With
                        objCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Dim s As String = ""
                s = ex.Message
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objCol

        End Function

        Public Shared Function ListarPendientes(ent As Entity.Tratamiento.Afiliacion.InternoSolicitud) As Integer

            Dim value As Integer = 0

            value = Data.Tratamiento.Afiliacion.InternoSolicitud.ListarOutput("lst", "lst_pendientes", ent)

            Return value
        End Function

#End Region
#Region "Validar"
      

        Public Function Validar(ByVal InternoCodigo As String, ByVal RegionID As Integer, ByVal PenalID As Integer) As Boolean

            Dim value As Boolean = True
            Dim intvalue As Integer = 0


            intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_validar_codigo", -1, InternoCodigo, _
                                                          -1, "", "", "", "", _
                                                      RegionID, PenalID)

            If intvalue > 1 Then
                value = False
            End If

            Return value

        End Function
        Public Function ValidarNumeroDocumento(ByVal TipoDocumentoID As Integer, ByVal NumeroDocumento As String, _
        ByVal RegionID As Integer, ByVal PenalID As Integer) As Boolean

            Dim value As Boolean = True
            Dim intvalue As Integer = 0

            intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_val_numero_documento", -1, "", _
                                                          TipoDocumentoID, NumeroDocumento, "", "", "", _
                                                      RegionID, PenalID)

            If intvalue > 0 Then
                value = False
            End If

            Return value

        End Function
        Public Function ValidarNumeroDocumento(objInt As Entity.Registro.Interno) As Boolean

            Dim value As Boolean = True
            Dim intvalue As Integer = 0


            If objInt.Codigo < 1 Then
                intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_val_numero_documento", objInt)
                If intvalue > 0 Then
                    value = False
                End If
            Else
                intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_val_numero_documento_his", objInt)
                If intvalue > 0 Then
                    value = False
                End If
            End If
            Return value

        End Function
        Public Function ValidarApellidosyNombres(ByVal PrimerApellido As String, _
        ByVal SegundoApellido As String, ByVal Nombres As String, _
        ByVal RegionID As Integer, ByVal PenalID As Integer) As Boolean

            Dim value As Boolean = True
            Dim intvalue As Integer = 0

            intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_val_apellidos_nombres", -1, "", _
                                                          -1, "", PrimerApellido, SegundoApellido, Nombres, _
                                                      RegionID, PenalID)

            If intvalue > 0 Then
                value = False
            End If

            Return value

        End Function
        Public Function ValidarApellidosyNombres(objEnt As Entity.Registro.Interno) As Integer

            Dim intvalue As Integer = 0

            intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_val_apellidos_nombres", objEnt)



            Return intvalue

        End Function
        Public Function ValidarApellidosyNombresUpd(objEnt As Entity.Registro.Interno) As Integer

            Dim intvalue As Integer = 0

            intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_val_apellidos_nombresUpd", objEnt)

            Return intvalue

        End Function
#End Region
#Region "Listar"

      
      

        Public Function Listar_Afiliacion(objEntInterno As Entity.Tratamiento.Afiliacion.InternoSolicitud) As  _
            Entity.Tratamiento.Afiliacion.InternoSolicitudCol
            objEntCol = New Entity.Tratamiento.Afiliacion.InternoSolicitudCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Tratamiento.Afiliacion.InternoSolicitud.Listar(sqlCon, "lst", "lst_mant", objEntInterno)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.Afiliacion.InternoSolicitud
                        With objEnt
                            .NumeroSol = 0
                            .InternoID = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString()
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .EstadoRncID = sqlDr("int_est_rnc").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            '/*region y penal*/
                            .RegionID = sqlDr("_regid").ToString
                            .PenalID = sqlDr("_penid").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            '/*otros*/
                            .FechaIngreso = sqlDr("fec_ing").ToString
                            .FechaLibertad = sqlDr("fec_lib").ToString
                            .TipoMovimientoID = sqlDr("TipoMovID").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                        End With
                        objEntCol.Add(objEnt)
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

        Public Function Listar_Solicitud(objEntInterno As Entity.Tratamiento.Afiliacion.InternoSolicitud) As  _
            Entity.Tratamiento.Afiliacion.InternoSolicitudCol
            objEntCol = New Entity.Tratamiento.Afiliacion.InternoSolicitudCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Tratamiento.Afiliacion.InternoSolicitud.Listar(sqlCon, "lst", "lst_mant_sol", objEntInterno)

            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.Afiliacion.InternoSolicitud
                        With objEnt
                            .CodigoSolicitud = sqlDr("pk_n_sol_id").ToString
                            .NumeroSol = sqlDr("n_sol_num_sed").ToString
                            .FechaRegistro = sqlDr("n_sol_fec_reg").ToString
                            .InternoID = sqlDr("fk_int_id").ToString
                            .CodigoRP = sqlDr("c_det_sol_cod_rp").ToString
                            .ApellidoPaterno = sqlDr("c_det_sol_pri_ape").ToString
                            .ApellidoMaterno = sqlDr("c_det_sol_seg_ape").ToString
                            .Nombres = sqlDr("c_det_sol_nom").ToString
                            .SexoID = sqlDr("n_det_sol_sex_id").ToString
                            .FechaNacimiento = sqlDr("n_det_sol_fec_nac").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("c_det_sol_num_doc").ToString
                            .EstadoRncID = sqlDr("c_det_sol_val_rnc").ToString
                            '/*region y penal*/
                            .RegionID = sqlDr("_regid").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("_penid").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            '/*otros*/
                            .FechaIngreso = sqlDr("fec_ing").ToString
                            .FechaLibertad = sqlDr("fec_lib").ToString
                            .EstadoID = sqlDr("n_sol_est_id").ToString
                            .EstadoDetalleID = sqlDr("n_det_sol_est_id").ToString
                            .TipoMovimientoID = sqlDr("TipoMovID").ToString
                            .Anio = sqlDr("n_det_sol_anio").ToString
                            .Mes = sqlDr("n_det_sol_mes").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .FechaEnvio = sqlDr("n_det_sol_fec_env").ToString
                        End With
                        objEntCol.Add(objEnt)
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

        Public Function Listar_sin_Solicitud(objEntInterno As Entity.Tratamiento.Afiliacion.InternoSolicitud) As  _
           Entity.Tratamiento.Afiliacion.InternoSolicitudCol
            objEntCol = New Entity.Tratamiento.Afiliacion.InternoSolicitudCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Tratamiento.Afiliacion.InternoAfiliacion.ListarAfiliacion(sqlCon, "lst", "lst_mant_sol", objEntInterno)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.Afiliacion.InternoSolicitud
                        With objEnt
                            .NumeroSol = sqlDr("n_sol_num_sed").ToString
                            .CodigoRP = sqlDr("c_det_sol_cod_rp").ToString
                            .ApellidoPaterno = sqlDr("c_det_sol_pri_ape").ToString
                            .ApellidoMaterno = sqlDr("c_det_sol_seg_ape").ToString
                            .Nombres = sqlDr("c_det_sol_nom").ToString
                            .SexoID = sqlDr("n_det_sol_sex_id").ToString
                            .FechaNacimiento = sqlDr("b_det_sol_fec_nac").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("c_det_sol_num_doc").ToString
                            .EstadoRncID = sqlDr("c_det_sol_val_rnc").ToString
                            '/*region y penal*/
                            .RegionID = sqlDr("_regid").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("_penid").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            '/*otros*/
                            .FechaIngreso = sqlDr("fec_ing").ToString
                            .FechaLibertad = sqlDr("fec_lib").ToString

                        End With
                        objEntCol.Add(objEnt)
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


#Region "Grabar"
       
        Public Function ActualizarEstadoBaja(ByVal InternoID As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_estado"

            'objEnt = New Entity.Registro.Interno

            With objEnt
                .InternoID = InternoID
            End With

            'intValue = Data.Registro.Interno.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function
     
        Public Function Grabar(objEntInterno As Entity.Registro.Interno) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEntInterno.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"

                If ValidarNumeroDocumento(objEntInterno.TipoDocumentoID, objEntInterno.NumeroDocumento, objEntInterno.RegionID, objEntInterno.PenalID) = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El n�mero de documento que esta ingresando, ya existe en la base de datos")
                    Return intValue
                End If

                If ValidarApellidosyNombres(objEntInterno.ApellidoPaterno, objEntInterno.ApellidoMaterno, objEntInterno.Nombres, objEntInterno.RegionID, objEntInterno.PenalID) = False Then
                    'Legolas.Configuration.Aplication.MessageBox.Exclamation("Los apellidos y nombres que esta ingresando, ya existe en la base de datos")
                    If Windows.Forms.MessageBox.Show("Los apellidos y nombres que esta ingresando ya existe en la base de datos, desea registrar de todas maneras con los nombres duplicados?", _
                                                     "", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        Return intValue
                    End If
                End If
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.Interno.Grabar(strAccion, strOpcion, objEntInterno)

            Return intValue
        End Function

        Public Function Grabar(objEntInterno As Entity.Tratamiento.Afiliacion.InternoSolicitud) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEntInterno.CodigoSolicitud < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"

                'If ValidarNumeroDocumento(objEntInterno.TipoDocumentoID, objEntInterno.NumeroDocumento, objEntInterno.RegionID, objEntInterno.PenalID) = False Then
                '    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                '    "El numero de documento que esta ingresando, ya existe en la base de datos")
                '    Return intValue
                'End If

            Else
                strAccion = "upd"
                strOpcion = "upd_mant"

            End If
            intValue = Data.Tratamiento.Afiliacion.InternoSolicitud.Grabar(strAccion, strOpcion, objEntInterno)


            Return intValue
        End Function
        Public Function GrabarEstadoEnvio(objEntInterno As Entity.Tratamiento.Afiliacion.InternoSolicitud) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            If objEntInterno.Tipo = True Then
                strOpcion = "upd_mant_sol"
            End If

            intValue = Data.Tratamiento.Afiliacion.InternoSolicitud.Grabar(strAccion, strOpcion, objEntInterno)

            Return intValue
        End Function

#End Region

#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.Interno.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo, FlagTransferenciaSede)
            Return intValue

        End Function
        Public Function Eliminar2(ByVal Codigo As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant_v2"
            intValue = Data.Registro.Interno.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo, FlagTransferenciaSede)
            Return intValue

        End Function
#End Region
    End Class
End Namespace
