Imports System.Data
Imports System.Data.SqlClient
Imports Bussines.Globall.UtilAccesoBD
Namespace Tratamiento.TallerAsistencia
    Public Class AsistenciaGrupo
        Private objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia = Nothing
        Private objEntCol As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol = Nothing
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
        Public Function Listar(objEntInterno As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As Entity.Tratamiento.TallerAsistencia.InternoAsistencia

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoAsistencia.Listar(sqlCon, "lst", "lst_mant", objEntInterno)

            objEnt = New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = Isnulll(sqlDr("int_id"), -1).ToString
                            .CodigoRP = Isnulll(sqlDr("int_cod_rp"), "").ToString
                            .ApellidoPaterno = Isnulll(sqlDr("int_ape_pat"), "").ToString
                            .ApellidoMaterno = Isnulll(sqlDr("int_ape_mat"), "").ToString
                            .Nombres = Isnulll(sqlDr("int_nom"), "").ToString
                            .SexoID = Isnulll(sqlDr("sex_id"), -1).ToString
                            .FechaNacimiento = Isnulll(sqlDr("int_fec_nac"), -1).ToString
                            .NacionalidadID = Isnulll(sqlDr("nac_id"), -1).ToString
                            .NacionalidadNombre = Isnulll(sqlDr("nac_nom"), "").ToString
                            .TipoDocumentoID = Isnulll(sqlDr("tip_doc_id"), -1).ToString
                            .TipoDocumentoNombre = Isnulll(sqlDr("tip_doc_nom"), "").ToString
                            .NumeroDocumento = Isnulll(sqlDr("int_doc_num"), "").ToString
                            .EstadoCivilID = Isnulll(sqlDr("est_civ_id"), -1).ToString
                            .EstadoCivilNombre = Isnulll(sqlDr("est_civ_nom"), -1).ToString
                            .NombrePadre = Isnulll(sqlDr("aut_fam_pad"), "").ToString
                            .NombreMadre = Isnulll(sqlDr("aut_fam_mad"), "").ToString
                            .EstadoRncID = Isnulll(sqlDr("int_est_rnc"), -1).ToString
                            .EstadoID = Isnulll(sqlDr("int_est_id"), -1).ToString
                            '/*Ubigeo nac - region y penal*/
                            .NacimientoPaisNombre = sqlDr("nac_pai_nom").ToString
                            .NacimientoDepartamentoNombre = sqlDr("nac_dep_nom").ToString
                            .NacimientoProvinciaNombre = sqlDr("nac_pro_nom").ToString
                            .NacimientoDistritoNombre = sqlDr("nac_dis_nom").ToString
                            .RegionID = Isnulll(sqlDr("reg_id"), -1).ToString
                            .RegionNombre = Isnulll(sqlDr("reg_nom"), "").ToString
                            .PenalID = Isnulll(sqlDr("pen_id"), -1).ToString
                            .PenalNombre = Isnulll(sqlDr("pen_nom"), "").ToString
                            '/*Otros*/
                            .FechaIngreso = Isnulll(sqlDr("int_ing_fec"), 0).ToString
                            .InternoHuellaID = Isnulll(sqlDr("pk_int_hue_id"), -1).ToString
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
            Return objEnt
        End Function
        Public Function ListarIngreso(objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            objEntCol = New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoAsistencia.Listar(sqlCon, "lst", "lst_mant_ing", objEnt)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                        With objEnt

                            .Codigo = sqlDr("pk_tal_asi_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .Fecha = sqlDr("n_tal_asi_fec").ToString
                            .HoraEntrada = sqlDr("c_tal_asi_hor_ent").ToString
                            .HoraSalida = sqlDr("c_tal_asi_hor_sal").ToString
                        End With
                        'objEntCol.Add(objEnt)
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
        Public Function ListarAsistencia(objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            objEntCol = New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim Contador As Integer = 0
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoAsistencia.Listar(sqlCon, "lst", "lst_mant_asi", objEnt)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                        Contador += 1
                        With objEnt
                            .Contador = Contador
                            .InternoID = sqlDr("int_id").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .TipoDocumentoNombre = sqlDr("doc_tip_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .Fecha = sqlDr("n_tal_asi_fec").ToString
                            .HoraEntrada = sqlDr("c_tal_asi_hor_ent").ToString
                            .HoraSalida = sqlDr("c_tal_asi_hor_sal").ToString
                        End With
                        'objEntCol.Add(objEnt)
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
        Public Function ListarTaller(objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            objEntCol = New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim Contador As Integer = 0
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoAsistencia.Listar(sqlCon, "lst", "lst_mant_tal", objEnt)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                        Contador += 1
                        With objEnt
                            .Contador = Contador

                            .InternoID = Isnulll(sqlDr("int_id"), -1).ToString
                            .CodigoPadre = Isnulll(sqlDr("int_pdr"), "").ToString
                            .CodigoRP = Isnulll(sqlDr("int_cod_rp"), "").ToString
                            .ApellidoPaterno = Isnulll(sqlDr("int_ape_pat"), "").ToString
                            .ApellidoMaterno = Isnulll(sqlDr("int_ape_mat"), "").ToString
                            .Nombres = Isnulll(sqlDr("int_nom"), "").ToString
                            .TipoDocumentoID = Isnulll(sqlDr("tip_doc_id"), -1).ToString
                            .TipoDocumentoNombre = Isnulll(sqlDr("tip_doc_nom"), "").ToString
                            .NumeroDocumento = Isnulll(sqlDr("int_doc_num"), "").ToString
                            .FechaNacimiento = Isnulll(sqlDr("int_fec_nac"), 0).ToString
                            .EstadoCivilID = Isnulll(sqlDr("est_civ_id"), -1).ToString
                            .EstadoCivilNombre = Isnulll(sqlDr("est_civ_nom"), -1).ToString
                            .EstadoID = Isnulll(sqlDr("int_est_id"), -1).ToString
                            .EstadoRncID = Isnulll(sqlDr("int_est_rnc"), -1).ToString
                            .NacionalidadNombre = Isnulll(sqlDr("nac_nom"), "").ToString
                            .NombrePadre = Isnulll(sqlDr("aut_fam_pad"), "").ToString
                            .NombreMadre = Isnulll(sqlDr("aut_fam_mad"), "").ToString
                            '/*fotos*/
                            .FotoPerfilIzquierdo = sqlDr("int_fot_per_izq").ToString
                            .FotoPerfilFrente = sqlDr("int_fot_per_fre").ToString
                            .FotoPerfilDerecho = sqlDr("int_fot_per_der").ToString
                            '.Fecha = sqlDr("n_tal_asi_fec").ToString
                            '.HoraEntrada = sqlDr("c_tal_asi_hor_ent").ToString
                            '.HoraSalida = sqlDr("c_tal_asi_hor_sal").ToString
                        End With
                        'objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
            End Try

            Dim objEntNA As Entity.Registro.InternoCol = Nothing
            Dim objEntColReturn As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            'llenar nombres asociados
            'objEntColReturn = LlenarNombresAsociados(objEntCol, objEnt.RegionID, objEnt.PenalID)

            ''filtrar por fecha de ingreso del interno, del ultimo internamiento
            'If objEntFiltro.FechaIngresoIni > 0 Or objEntFiltro.FechaIngresoFin > 0 Then

            '    objEntNA = New Entity.Registro.InternoCol
            '    objEntNA = objEntColReturn

            '    objEntColReturn = FiltrarPorFechaIngreso(objEntNA, objEntFiltro.FechaIngresoIni, _
            '                                            objEntFiltro.FechaIngresoFin, _
            '                                            objEntFiltro.IDRegion, objEntFiltro.IDPenal)
            'End If

            ''filtrar por delito generico y especifico
            'If objEntFiltro.IDDelitoGenerico > 0 Or objEntFiltro.IDDelitoEspecifico > 0 Then

            '    objEntNA = New Entity.Registro.InternoCol
            '    objEntNA = objEntColReturn

            '    objEntColReturn = FiltrarPorDelitos(objEntNA, objEntFiltro.IDDelitoGenerico, _
            '                                            objEntFiltro.IDDelitoEspecifico, _
            '                                            objEntFiltro.IDRegion, objEntFiltro.IDPenal)
            'End If

            ''filtrar por situacion juridica del ultimo internamiento
            'If objEntFiltro.IDSituacionJuridica > 0 Then

            '    objEntNA = New Entity.Registro.InternoCol
            '    objEntNA = objEntColReturn

            '    objEntColReturn = FiltrarPorSituacionJuridica_v5(objEntNA, _
            '                                            objEntFiltro.IDSituacionJuridica, _
            '                                            objEntFiltro.IDRegion, objEntFiltro.IDPenal)
            'End If




            Return objEntCol
        End Function
        'Private Function LlenarNombresAsociados(ByVal objEntListaInternoCol As Entity.Registro.InternoCol, ByVal RegionID As Integer, _
        'ByVal PenalID As Integer) As Entity.Registro.InternoCol

        'recorre los id de los internos filtrados
        'IDInternoString = ""
        'For Each interno As Entity.Registro.Interno In objEntListaInternoCol
        '    IDInternoString = IDInternoString & interno.Codigo & ","
        'Next
        'If IDInternoString.Length > 0 Then
        '    IDInternoString = IDInternoString.Substring(0, IDInternoString.Length - 1)
        'End If

        ''buscar en la bd los nombres asociados del filtrado
        'objEntFiltro = New Entity.Registro.Interno_Grilla

        'With objEntFiltro
        '    .IDInternoString = IDInternoString
        '    .NombreAsociadoPrincipal = 0 'solo asociados
        '    .NombreAsociadoEstado = 1 'estado activos
        '    .IDRegion = RegionID
        '    .IDPenal = PenalID
        'End With
        ''/********************************************************/

        ''coleccion de nombres asociados
        'Dim objEntColNA As New Entity.Registro.Interno_Grilla.NombresAsociadosCol
        'objEntColNA = Listar_NombresAsociados(objEntFiltro)

        'Dim objEntAll As Entity.Registro.Interno
        'Dim value As New Entity.Registro.InternoCol

        'For Each objEnt As Entity.Registro.Interno In objEntListaInternoCol

        '    objEntAll = New Entity.Registro.Interno
        '    With objEntAll
        '        .Codigo = objEnt.Codigo
        '        .CodigoRP = objEnt.CodigoRP
        '        .IngresoID = objEnt.IngresoID
        '        .CodigoPadre = 0
        '        .ApellidoPaterno = objEnt.ApellidoPaterno
        '        .ApellidoMaterno = objEnt.ApellidoMaterno
        '        .Nombres = objEnt.Nombres
        '        .SexoID = objEnt.SexoID
        '        .TipoDocumentoNombre = objEnt.TipoDocumentoNombre
        '        .NumeroDocumento = objEnt.NumeroDocumento
        '        .FechaNacimiento = objEnt.FechaNacimiento
        '        .NacionalidadNombre = objEnt.NacionalidadNombre
        '        '/*alias*/
        '        .InternoAlias = objEnt.InternoAlias
        '        '/*otros*/
        '        .PabellonNombre = objEnt.PabellonNombre
        '        .RegionID = objEnt.RegionID
        '        .RegionNombre = objEnt.RegionNombre
        '        .PenalID = objEnt.PenalID
        '        .PenalNombre = objEnt.PenalNombre
        '        '/*estado*/
        '        .EstadoID = objEnt.EstadoID
        '        .SituacionJuridicaId = objEnt.SituacionJuridicaId
        '        'fotos
        '        .FotoPerfilIzquierdo = objEnt.FotoPerfilIzquierdo
        '        .FotoPerfilFrente = objEnt.FotoPerfilFrente
        '        .FotoPerfilDerecho = objEnt.FotoPerfilDerecho
        '        .DMP = objEnt.DMP
        '        .SMP = objEnt.SMP
        '        .SituacionJuridicaId = objEnt.SituacionJuridicaId
        '        .SituacionJuridicaNom = objEnt.SituacionJuridicaNom
        '        .EstadoRncID = objEnt.EstadoRncID
        '        .EstadoEspecificoID = objEnt.EstadoEspecificoID
        '        .FechaIngreso = objEnt.FechaIngreso
        '    End With

        '    value.Add(objEntAll)

        '    For Each objEntNA As Entity.Registro.Interno_Grilla.NombresAsociados In objEntColNA
        '        If objEnt.Codigo = objEntNA.InternoID Then
        '            objEntAll = New Entity.Registro.Interno
        '            With objEntAll
        '                .CodigoPadre = 1
        '                .Codigo = objEntNA.InternoID
        '                .ApellidoPaterno = objEntNA.ApellidoPaterno
        '                .ApellidoMaterno = objEntNA.ApellidoMaterno
        '                .Nombres = objEntNA.Nombres
        '            End With
        '            value.Add(objEntAll)
        '        End If
        '    Next
        'Next
        'Return value
        'End Function
#End Region
#Region "Listar_Huella"
        Public Function BuscarHuella(IDTemplate As Integer, IDRegion As Short, IDPenal As Short) As Integer

            Dim value As Integer = -1

            If IDTemplate < 1 Then
                Return value
            End If

            Dim strMensajeError As String = ""
            Dim intIDHuella As Integer = -1

            '1.- buscar en la tabla huella digital
            'Dim objBssHueDig As New Bussines.Biometria.HuellaDigital
            'Dim objEntFiltroHueDig As New Entity.Biometria.HuellaDigital

            'With objEntFiltroHueDig
            '    .IDTemplateHuella = IDTemplate
            '    .IDRegion = IDRegion
            '    .IDPenal = IDPenal
            'End With

            'intIDHuella = objBssHueDig.BuscarIDHuella(objEntFiltroHueDig, strMensajeError)

            '2.- buscar en la tabla visitante huella
            'If intIDHuella > 0 Then

            Dim objBssHueVis As New Bussines.Biometria.InternoHuellaTratamiento
            Dim objEntFiltroHueVis As New Entity.Biometria.InternoHuellaTratamiento

            With objEntFiltroHueVis
                .IDIndiceIzquierdo = intIDHuella
                .IDIndiceDerecho = intIDHuella
                .IDPulgarIzquierdo = intIDHuella
                .IDPulgarDerecho = intIDHuella
                .IDRegion = IDRegion
                .IDPenal = IDPenal
            End With

            value = objBssHueVis.BuscarIDInterno(objEntFiltroHueVis, strMensajeError)

            'End If

            Return value

        End Function
#End Region

#Region "Grabar"

        Public Function Grabar(objEnt As Entity.Tratamiento.TallerAsistencia.AsistenciaGrupo) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"

            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Tratamiento.TallerAsistencia.AsistenciaGrupo.Grabar(strAccion, strOpcion, objEnt)

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
