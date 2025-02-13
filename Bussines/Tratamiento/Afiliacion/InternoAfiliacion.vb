Imports System.Data
Imports System.Data.SqlClient
Namespace Tratamiento.Afiliacion
    Public Class InternoAfiliacion
        Private objEnt As Entity.Tratamiento.Afiliacion.InternoSolicitud = Nothing
        Private objEntCol As Entity.Tratamiento.Afiliacion.InternoSolicitudCol = Nothing
        Private obj_Ent As Entity.Registro.Interno = Nothing
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
       

        

#End Region
#Region "Validar"
        Private Function ValidarNombreClaveInterno(objEntInterno As Entity.Registro.Interno, ByRef outSms As String) As Boolean
            If objEntInterno.NombreClaveInterno.Trim.Length <= 2 Then Return True

            Dim list As New Entity.Registro.InternoCol
            Dim ent As New Entity.Registro.Interno
            ent.NombreClaveInterno = objEntInterno.NombreClaveInterno
            ent.PenalID = objEntInterno.PenalID
            ent.RegionID = objEntInterno.RegionID
            'list = Listar_LM(ent)

            If list Is Nothing Then Return True

            If list.Count > 0 Then
                If objEntInterno.Codigo > -1 AndAlso objEntInterno.Codigo = list.Item(0).Codigo Then 'si es modificar
                    Return True
                End If

                outSms = "La clave " & objEntInterno.NombreClaveInterno & " ya se encuentra registrada." & vbCrLf & _
                "Cod. Unico:" & objEntInterno.CodigoUnicoInterno & vbCrLf & _
                "CodRp:" & objEntInterno.CodigoRP & vbCrLf & _
                "Nombre Clave:" & objEntInterno.NombreClaveInterno & vbCrLf & _
                "Nombres:" & objEntInterno.Nombres & ", " & objEntInterno.ApellidoPaterno & " " & objEntInterno.ApellidoMaterno & vbCrLf & _
                "NúmDoc:" & objEntInterno.NumeroDocumento & vbCrLf & _
                "Fecha Nac.:" & objEntInterno.FechaNacimientoString
                Return False
            End If
            Return True
        End Function

        Private Function ValidarCodigoUnico(objEntInterno As Entity.Registro.Interno, ByRef outSms As String) As Boolean

            If objEntInterno.CodigoUnicoInterno.Trim.Length <= 2 Then Return True

            Dim list As New Entity.Registro.InternoCol
            Dim ent As New Entity.Registro.Interno
            ent.CodigoUnicoInterno = objEntInterno.CodigoUnicoInterno
            ent.PenalID = objEntInterno.PenalID
            ent.RegionID = objEntInterno.RegionID

            'list = Listar_LM(ent)

            If list Is Nothing Then Return True

            If list.Count > 0 Then
                If objEntInterno.Codigo > -1 AndAlso objEntInterno.Codigo = list.Item(0).Codigo Then 'si es modificar
                    Return True
                End If

                outSms = "El código único " & objEntInterno.CodigoUnicoInterno & " ya se encuentra registrada." & vbCrLf & _
                "CodRp:" & objEntInterno.CodigoRP & vbCrLf & _
                "Nombre Clave:" & objEntInterno.NombreClaveInterno & vbCrLf & _
                "Nombres:" & objEntInterno.Nombres & ", " & objEntInterno.ApellidoPaterno & " " & objEntInterno.ApellidoMaterno & vbCrLf & _
                "NúmDoc:" & objEntInterno.NumeroDocumento & vbCrLf & _
                "Fecha Nac.:" & objEntInterno.FechaNacimientoString
                Return False
            End If
            Return True
        End Function
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

        
        Public Function ListarSIS(objEntInterno As Entity.Registro.Interno) As Entity.Registro.Interno

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Tratamiento.Afiliacion.InternoAfiliacion.Listar(sqlCon, "lst", "lst_mant_sis", objEntInterno)

            obj_Ent = New Entity.Registro.Interno
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With obj_Ent
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .Libro = sqlDr("int_lib").ToString
                            .Folio = sqlDr("int_fol").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacimientoPaisID = sqlDr("ubg_pai_id").ToString
                            .NacimientoUbigeoID = sqlDr("ubg_id_nac").ToString
                            .NacimientoOtros = sqlDr("ubg_nac_otro").ToString
                            .NacionalidadID = sqlDr("nac_id").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .DomicilioUbigeoID = sqlDr("ubg_id_dir").ToString
                            .Domicilio = sqlDr("int_dir_nom").ToString
                            .EstadoCivilID = sqlDr("est_civ_id").ToString
                            .EstadoCivilNombre = sqlDr("est_civ_nom").ToString
                            .NacimientoPaisNombre = sqlDr("nac_pai_nom").ToString
                            .NacimientoDepartamentoNombre = sqlDr("nac_dep_nom").ToString
                            .NacimientoProvinciaNombre = sqlDr("nac_pro_nom").ToString
                            .NacimientoDistritoNombre = sqlDr("nac_dis_nom").ToString

                            .EstadoID = sqlDr("int_est_id").ToString
                            .Discapacidad = sqlDr("int_dis_id").ToString
                            .ComunidadAndinaID = sqlDr("int_com_id").ToString
                            .ComunidadAndinaEspID = sqlDr("int_com_esp_id").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            '/*region y penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            '/*otros*/
                            .SituacionJuridicaNom = sqlDr("sit_jur_nom").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .Obs = sqlDr("int_obs").ToString
                            .Obs_DNI = sqlDr("int_obs_dni").ToString
                            .PabellonID = sqlDr("pab_id").ToString
                            .IngresoSistemaPen = sqlDr("int_fec_isp").ToString
                            .EstadoRncID = sqlDr("int_est_rnc").ToString
                            .FechaIngreso = sqlDr("fecha_ing").ToString
                            .FechaLibertad = sqlDr("fecha_lib").ToString
                            .CodigoAfiliacion = sqlDr("pk_afi_id").ToString
                            .EstadoAfiliacionID = sqlDr("n_afi_est_id").ToString
                            .FechaAfiliacion = sqlDr("n_afi_fec_afi").ToString
                            .Padre = sqlDr("aut_fam_pad").ToString
                            .Madre = sqlDr("aut_fam_mad").ToString
                            .NacionalidadNombre = sqlDr("nac_nom").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
            End Try
            Return obj_Ent
        End Function
      

        Public Function Listar_Afiliacion(objEntInterno As Entity.Tratamiento.Afiliacion.InternoSolicitud) As  _
            Entity.Tratamiento.Afiliacion.InternoSolicitudCol
            objEntCol = New Entity.Tratamiento.Afiliacion.InternoSolicitudCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Tratamiento.Afiliacion.InternoAfiliacion.ListarAfiliacion(sqlCon, "lst", "lst_mant", objEntInterno)

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
                            '.IngresoSistemaPen = sqlDr("int_fec_isp").ToString
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
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El número de documento que esta ingresando, ya existe en la base de datos")
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

        Public Function Grabar(objEntInterno As Entity.Tratamiento.Afiliacion.InternoAfiliacion) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEntInterno.CodigoAfiliacion < 1 Then
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
            intValue = Data.Tratamiento.Afiliacion.InternoAfiliacion.Grabar(strAccion, strOpcion, objEntInterno)


            Return intValue
        End Function

        Public Function GrabarEstadoEnvio(objEntInterno As Entity.Tratamiento.Afiliacion.InternoAfiliacion) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            If objEntInterno.Tipo = True Then
                strOpcion = "upd_mant_sol"
            Else
                strOpcion = "upd_mant_sol_det"
            End If

            intValue = Data.Tratamiento.Afiliacion.InternoAfiliacion.Grabar(strAccion, strOpcion, objEntInterno)

            Return intValue
        End Function

        Public Function GrabarApellidosyNombres(objInterno As Entity.Registro.Interno) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_ape_nom2"

            intValue = Data.Registro.Interno.Grabar2(strAccion, strOpcion, objInterno)

            Return intValue

        End Function

        Public Function GrabarApellidosyNombres_LM(objInterno As Entity.Registro.Interno) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_ape_nom2_LM"

            intValue = Data.Registro.Interno.Grabar_LM(strAccion, strOpcion, objInterno)

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
