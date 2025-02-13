Imports System.Data.SqlClient

Namespace Seguridad
    Public Class UsuarioNotificacion
        Private objEnt As Legolas.LEntity.Seguridad.Usuario = Nothing
        Private objEntCol As Legolas.LEntity.Seguridad.UsuarioCol = Nothing
#Region "Funciones"
        Public Function RestaurarClaveInicio(strLogin As String) As Integer

            Dim value As Integer = -1

            objEnt = New Legolas.LEntity.Seguridad.Usuario

            objEnt = BuscarxLogin(strLogin)

            With objEnt
                If .Codigo > 0 Then
                    value = RestaurarClave(.Codigo, .Login.ToUpper)
                End If
            End With

            Return value

        End Function
        Public Function RestaurarClave(ByVal intIDUsuario As Integer, strLogin As String) As Integer

            Dim value As Integer = -1

            value = CambiarClave(intIDUsuario, strLogin, True)

            Return value

        End Function

        Public Function CambiarClave(ByVal intIDUsuario As Integer, ByVal strClave As String, Optional ReseteoClave As Boolean = False) As Integer

            Dim value As Integer = -1
            Dim strClaveCifrada As String = Legolas.Components.Cifrado.Encriptar(strClave)

            'objEnt = New Legolas.LEntity.Seguridad.Usuario
            'With objEnt
            '    .Codigo = intIDUsuario
            '    .ClaveNueva = ReseteoClave
            '    .Audit_UsuarioModificacion = Legolas.Configuration.Usuario.Codigo
            'End With

            value = Data.Seguridad.Usuario.Grabar("upd", "upd_clave_cambiar_cifrado", intIDUsuario, ReseteoClave, strClaveCifrada)

            Return value

        End Function

        Public Function LoginUsuario(ByVal strLogin As String, ByVal strClave As String) As Boolean

            Dim value As Boolean = False

            Dim strClaveCifrada As String = ""

            objEnt = New Legolas.LEntity.Seguridad.Usuario
            objEnt = BuscarxLogin(strLogin)

            With objEnt
                strClaveCifrada = .Clave
            End With

            Dim strClaveDesCifrada As String = Legolas.Components.Cifrado.Desencriptar(strClaveCifrada)

            If strClaveDesCifrada = strClave Then
                value = True
            End If

            Return value

        End Function

#End Region
#Region "Validar"
        Private Function Validar(ByVal Login As String, ByVal TrabajadorID As Integer, ByVal ApellidoPaterno As String,
                                 ByVal ApellidoMaterno As String, ByVal TrabajadorNombre As String,
                                 ByVal NumeroDocumento As String) As Boolean

            Dim value As Boolean = True
            Dim intCount As Integer = 0

            intCount = Data.Seguridad.Usuario.ListarOutput("lst", "lst_validar_usuario", -1, Login, TrabajadorID,
                                                           ApellidoPaterno,
                                                           ApellidoMaterno, TrabajadorNombre, NumeroDocumento)

            If intCount > 0 Then
                value = False
            End If

            Return value

        End Function
#End Region
#Region "Listar"
        Public Function ListarAccesoPenal(ByVal Login As String,
        ByVal Apellidos As String, ByVal Nombres As String, ByVal TipoUsuario As Short, PerfilUsuario As Short, ByVal IDRegion As Integer,
        ByVal IDPenal As Integer, Estado As Short) As Legolas.LEntity.Seguridad.UsuarioCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Legolas.LEntity.Seguridad.Usuario
            With objEntFiltro
                .Login = Login
                .Apellidos = Apellidos
                .Nombres = Nombres
                .Tipo = TipoUsuario
                .Dependencia = PerfilUsuario
                .IDRegion = IDRegion
                .IDPenal = IDPenal
                .Estado = Estado
            End With

            Dim sqlDr As SqlDataReader = Data.Seguridad.Usuario.Listar(sqlCon, "lst", "lst_grilla_acceso_penal", objEntFiltro)

            objEntCol = New Legolas.LEntity.Seguridad.UsuarioCol

            Try
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Legolas.LEntity.Seguridad.Usuario

                        With objEnt
                            .Codigo = Integer.Parse(sqlDr("usu_id").ToString)
                            .TrabajadorID = sqlDr("tra_id").ToString
                            .Login = sqlDr("usu_log").ToString
                            .NivelUsuario = sqlDr("usu_tip_usu").ToString
                            .NivelUsuarioNombre = sqlDr("usu_tip_usu_nom").ToString
                            .ApellidoPaterno = sqlDr("usu_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("usu_ape_mat").ToString
                            .Nombres = sqlDr("usu_nom").ToString
                            .NumeroDocumento = sqlDr("usu_num_doc").ToString
                            .Dependencia = sqlDr("usu_dep_id").ToString
                            .DependenciaNombre = sqlDr("usu_dep_nom").ToString
                            .CargoNombre = sqlDr("usu_cgo_nom").ToString
                            .ClaveNueva = sqlDr("usu_psw_new").ToString
                            .Clave = sqlDr("usu_psw").ToString
                            .Audit_FechaCreacion = sqlDr("fec_cre").ToString
                            .Audit_FechaModificacion = sqlDr("fec_mod").ToString
                            .Activo = sqlDr("usu_act").ToString
                        End With

                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception

                Throw New Exception(ex.ToString)
            End Try

            Return objEntCol
        End Function

        Private Function BuscarxLogin(ByVal strLogin As String) As Legolas.LEntity.Seguridad.Usuario

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Legolas.LEntity.Seguridad.Usuario
            With objEntFiltro
                .Login = strLogin
            End With

            Dim sqlDr As SqlDataReader = Data.Seguridad.Usuario.Listar(sqlCon, "lst", "lst_login_cifrado", objEntFiltro)

            Try
                If sqlDr.HasRows Then
                    objEnt = New Legolas.LEntity.Seguridad.Usuario
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("usu_id").ToString
                            .Login = sqlDr("usu_log").ToString
                            .Clave = sqlDr("usu_psw").ToString
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
            Return objEnt

        End Function

        Public Function Listar(obj As Entity.Sistema.Seguridad.UsuarioNotificacion) As Entity.Sistema.Seguridad.UsuarioNotificacionCol

            Dim objEnt As New Entity.Sistema.Seguridad.UsuarioNotificacion
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objCol As New Entity.Sistema.Seguridad.UsuarioNotificacionCol

            Dim sqlDr As SqlDataReader = Data.Seguridad.UsuarioNotificacion.Listar(sqlCon, "lst", "lst_mant", obj.CodUsuario, obj.Codigo, Nothing, -1)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Sistema.Seguridad.UsuarioNotificacion
                        With objEnt
                            .Codigo = sqlDr("pk_usu_not_id").ToString
                            .CodUsuario = sqlDr("fk_usu_id").ToString
                            .AccionId = sqlDr("usu_not_acc").ToString
                            .Accion = sqlDr("accion").ToString
                            .FechaRegistro = sqlDr("_fec_cre").ToString
                            .FechaInhabilitacion = sqlDr("_fec_mod").ToString
                            .MotivoNombre = sqlDr("MotivoNombre").ToString
                            .EstadoId = sqlDr("usu_not_est_id").ToString
                            .EstadoNombre = sqlDr("Estado").ToString
                            .RegionId = sqlDr("fk_reg_id").ToString
                            .PenalId = sqlDr("fk_pen_id").ToString
                            .RegionNombre = sqlDr("RegionNombre").ToString
                            .PenalNombre = sqlDr("PenalNombre").ToString
                            .Audit_IDUsuarioCreacion = sqlDr("_usu_cre").ToString
                            .UsuarioAuditoriaNombres = sqlDr("UsuarioHabilita").ToString
                            .Audit_UsuarioModificacion = IIf(.AccionId = 1, "", sqlDr("UsuarioInhabilita").ToString)
                            '/*permisos otros*/
                            .Audit_Eliminado = sqlDr("_flg_eli").ToString
                        End With
                        objCol.Add(objEnt)
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
            Return objCol

        End Function


        Public Function ListarGrilla(ByVal Codigo As Integer, ByVal Login As String, ByVal Apellidos As String,
        ByVal Nombres As String,
        ByVal NumDoc As String, NivelUsuario As Integer, DependenciaPerfil As Integer, ByVal Estado As Integer) As Legolas.LEntity.Seguridad.UsuarioCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Legolas.LData.Seguridad.Usuario.Listar(sqlCon, "lst", "lst_grilla",
            Codigo, Login, Nothing, -1, "", "", Apellidos, Nombres, NumDoc, NivelUsuario, DependenciaPerfil, Estado)

            objEntCol = New Legolas.LEntity.Seguridad.UsuarioCol

            Try
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        objEnt = New Legolas.LEntity.Seguridad.Usuario

                        With objEnt
                            .Codigo = Integer.Parse(sqlDr("usu_id").ToString)
                            .Tipo = sqlDr("usu_tip").ToString
                            .TrabajadorID = sqlDr("tra_id").ToString
                            .Login = sqlDr("usu_log").ToString
                            .NivelUsuario = sqlDr("usu_tip_usu").ToString
                            .NivelUsuarioNombre = sqlDr("usu_tip_usu_nom").ToString
                            .ApellidoPaterno = sqlDr("usu_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("usu_ape_mat").ToString
                            .Nombres = sqlDr("usu_nom").ToString
                            .NumeroDocumento = sqlDr("usu_num_doc").ToString
                            .Dependencia = sqlDr("usu_dep_id").ToString
                            .DependenciaNombre = sqlDr("usu_dep_nom").ToString
                            .CargoNombre = sqlDr("usu_cgo_nom").ToString

                            .ClaveNueva = sqlDr("usu_psw_new").ToString
                            .Clave = sqlDr("usu_psw").ToString
                            .Audit_FechaCreacion = sqlDr("fec_cre").ToString
                            .Audit_FechaModificacion = sqlDr("fec_mod").ToString

                            .Activo = sqlDr("usu_act").ToString
                        End With

                        'If DependenciaPerfil > 0 Then

                        '    If objEnt.Dependencia = DependenciaPerfil Then
                        '        objEntCol.Add(objEnt)
                        '    End If

                        'Else
                        objEntCol.Add(objEnt)
                        'End If

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

            Return objEntCol
        End Function

#End Region
#Region "Grabar"

        Public Function Grabar(objEnt As Entity.Sistema.Seguridad.UsuarioNotificacion, ClaveCifrada As String) As Integer

            Dim intValue As Integer = -1
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

                intValue = Data.Seguridad.UsuarioNotificacion.Grabar(strAccion, strOpcion, objEnt, ClaveCifrada)
            End With

            Return intValue

        End Function

        Public Function GrabarLocal(objEnt As Legolas.LEntity.Seguridad.Usuario, ClaveCifrada As String) As Integer

            Dim value As Integer = -1

            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "ins"
            strOpcion = "ins_mant_local"

            If Validar(objEnt.Login, objEnt.TrabajadorID, objEnt.ApellidoPaterno, objEnt.ApellidoMaterno,
                       objEnt.Nombres, objEnt.NumeroDocumento) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Los datos del usuario a registrar, ya existen")
                Return value
            End If

            value = Data.Seguridad.Usuario.Grabar(strAccion, strOpcion, objEnt, ClaveCifrada)

            Return value

        End Function

        Public Function ActivarUsuario(intIDUsuario As Integer) As Integer

            Dim value As Integer = -1

            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_activar_usuario"

            'objEnt = New Legolas.LEntity.Seguridad.Usuario
            'objEnt.Codigo = intIDUsuario

            value = Data.Seguridad.Usuario.Grabar(strAccion, strOpcion, intIDUsuario, False, "")

            Return value

        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer) As Integer

            Dim intValue As Integer = -1

            intValue = Legolas.LData.Seguridad.Usuario.Eliminar("del", "del_mant", Codigo,
            Legolas.Configuration.Usuario.Codigo)
            Return intValue

        End Function
#End Region
    End Class

End Namespace