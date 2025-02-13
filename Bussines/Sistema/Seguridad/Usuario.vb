Imports System
Imports System.Data.SqlClient

Namespace Seguridad
    Public Class Usuario
        'Private objEnt As Legolas.LEntity.Seguridad.Usuario = Nothing
        'Private objEntCol As Legolas.LEntity.Seguridad.UsuarioCol = Nothing

        Public Function RegistraInicioSesion(UsuarioId As Integer, login As String, MacPC As String, ByRef out_sms As String) As Boolean
            Dim v As Boolean = False
            Dim ent As New Entity.Sistema.Seguridad.Session With {
                .UsuarioId = UsuarioId
                }

            Dim col As Entity.Sistema.Seguridad.SessionCol = Data.Sistema.Seguridad.Session.Listar(ent)

            If col.Count = 0 Then
                ent.Codigo = -1
                ent.UsuarioId = UsuarioId
                ent.Login = login
                ent.SesionActivo = True
                ent.MacPC = MacPC

                v = IIf(Data.Sistema.Seguridad.Session.Grabar("ins", "ins_mant", ent) > 0, True, False)
            Else
                ent = col.Session(0)
                Dim dd As TimeSpan = DateTime.Now - DateTime.FromFileTime(ent.FechaHora)

                If ent.SesionActivo = True And ent.MacPC <> MacPC And dd.TotalMinutes < 10 Then
                    v = False
                    out_sms = "Ya tiene una sesión iniciada en otro equipo, se recomienda cerrar la sesión activa para iniciar una nueva."
                Else
                    ent.UsuarioId = UsuarioId
                    ent.Login = login
                    ent.MacPC = MacPC
                    ent.SesionActivo = True
                    v = IIf(Data.Sistema.Seguridad.Session.Grabar("upd", "upd_mant", ent) > 0, True, False)
                End If
            End If

            Return v

        End Function

        Public Function RefrescarSesion(UsuarioId As Integer) As Boolean

            Dim ent As New Entity.Sistema.Seguridad.Session With {
            .UsuarioId = UsuarioId
            }

            Return IIf(Data.Sistema.Seguridad.Session.Grabar("upd", "upd_refrescar_sesion", ent) > 0, True, False)
        End Function

        Public Function RegistraCierreSesion(UsuarioId As Integer) As Boolean
            Dim v As Boolean = False
            Dim ent As New Entity.Sistema.Seguridad.Session With {
                    .UsuarioId = UsuarioId
                }

            Dim col As Entity.Sistema.Seguridad.SessionCol = Data.Sistema.Seguridad.Session.Listar(ent)

            If col.Count = 0 Then
                v = True
            Else
                ent = col.Session(0)

                ent.UsuarioId = UsuarioId
                ent.SesionActivo = False

                v = IIf(Data.Sistema.Seguridad.Session.Grabar("upd", "upd_cerrar_sesion", ent) > 0, True, False)

            End If

            Return v
        End Function
        Public Function RestaurarClaveInicio(strLogin As String) As Integer

            Dim value As Integer = -1

            Dim objEnt As Legolas.LEntity.Seguridad.Usuario = BuscarxLogin(strLogin)

            If objEnt.Codigo > 0 Then value = RestaurarClave(objEnt.Codigo, objEnt.Login.ToUpper)

            Return value

        End Function
        Public Function RestaurarClave(ByVal intIDUsuario As Integer, strLogin As String) As Integer
            Return CambiarClave(intIDUsuario, strLogin, True)
        End Function

        Public Function CambiarClave(ByVal intIDUsuario As Integer, ByVal strClave As String, Optional ReseteoClave As Boolean = False) As Integer

            Return Data.Seguridad.Usuario.Grabar("upd", "upd_clave_cambiar_cifrado", intIDUsuario, ReseteoClave, Legolas.Components.Cifrado.Encriptar(strClave))

        End Function

        Public Function LoginUsuario(ByVal strLogin As String, ByVal strClave As String) As Boolean
            Return IIf(Legolas.Components.Cifrado.Desencriptar(BuscarxLogin(strLogin).Clave) = strClave, True, False)
        End Function

        Private Function Validar(ByVal Login As String, ByVal TrabajadorID As Integer, ByVal ApellidoPaterno As String,
                                 ByVal ApellidoMaterno As String, ByVal TrabajadorNombre As String,
                                 ByVal NumeroDocumento As String) As Boolean

            Dim intCount As Integer = Data.Seguridad.Usuario.ListarOutput("lst", "lst_validar_usuario", -1, Login, TrabajadorID,
                                                           ApellidoPaterno, ApellidoMaterno, TrabajadorNombre, NumeroDocumento)

            Return If(intCount > 0, False, True)

        End Function

        Public Function ListarAccesoPenal(Login As String,
         Apellidos As String, Nombres As String, TipoUsuario As Short, PerfilUsuario As Short, IDRegion As Integer,
         IDPenal As Integer, Estado As Short) As Legolas.LEntity.Seguridad.UsuarioCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Legolas.LEntity.Seguridad.Usuario() With {
                .Login = Login,
                .Apellidos = Apellidos,
                .Nombres = Nombres,
                .Tipo = TipoUsuario,
                .Dependencia = PerfilUsuario,
                .IDRegion = IDRegion,
                .IDPenal = IDPenal,
                .Estado = Estado
                }


            Dim sqlDr As SqlDataReader = Data.Seguridad.Usuario.Listar(sqlCon, "lst", "lst_grilla_acceso_penal", objEntFiltro)

            Dim objEntCol As New Legolas.LEntity.Seguridad.UsuarioCol

            Try
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        Dim objEnt As New Legolas.LEntity.Seguridad.Usuario

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

        Private Function BuscarxLogin(ByVal strLogin As String) As Legolas.LEntity.Seguridad.Usuario

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Seguridad.Usuario.Listar(sqlCon, "lst", "lst_login_cifrado", New Legolas.LEntity.Seguridad.Usuario() With {.Login = strLogin})

            Dim objEnt As Legolas.LEntity.Seguridad.Usuario = Nothing

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

        Public Function Listar(ByVal UsuarioID As Integer) As Entity.Sistema.Seguridad.Usuario

            Dim objEnt As New Entity.Sistema.Seguridad.Usuario
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Legolas.LData.Seguridad.Usuario.Listar(sqlCon,
            "lst", "lst_mant", UsuarioID, "", Nothing, -1, "", "", "", "", "", -1, -1, -1)

            Try
                If sqlDr.HasRows Then
                    objEnt = New Entity.Sistema.Seguridad.Usuario
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("usu_id").ToString
                            .CueUsuario = sqlDr("cue_usu").ToString
                            .CueTrabajador = sqlDr("cue_tra").ToString
                            .IDTrabajador = sqlDr("tra_id").ToString
                            .CueLogin = sqlDr("cue_log").ToString
                            .Login = sqlDr("usu_log").ToString
                            .ClaveNueva = sqlDr("usu_psw_new").ToString
                            .NivelUsuario = sqlDr("usu_tip_usu").ToString
                            .ApellidoPaterno = sqlDr("usu_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("usu_ape_mat").ToString
                            .Nombres = sqlDr("usu_nom").ToString
                            .NumeroDocumento = sqlDr("usu_num_doc").ToString
                            .Perfil = sqlDr("usu_dep_id").ToString
                            .PerfilNombre = sqlDr("usu_ofi_nom").ToString
                            .CargoNombre = sqlDr("usu_cgo_nom").ToString
                            Try
                                .ValidarPorHUella = sqlDr("usu_validar_x_huella").ToString
                            Catch ex As Exception
                                .ValidarPorHUella = False
                            End Try


                            .Correo = sqlDr("c_cor_ins").ToString 'correo institucional
                            .AdminValidarPC = sqlDr("adm_val_pc").ToString
                            .AdminModuloUsuario = sqlDr("adm_mod_usu").ToString
                            .Audit_Eliminado = sqlDr("_flg_eli").ToString

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

        Public Function ListarLogin(strLogin As String, strClave As String) As Entity.Sistema.Seguridad.Usuario

            Dim value As Entity.Sistema.Seguridad.Usuario = Nothing
            Dim objEnt As Legolas.LEntity.Seguridad.Usuario = BuscarxLogin(strLogin)

            If Legolas.Components.Cifrado.Desencriptar(objEnt.Clave) = strClave Then value = Listar(objEnt.Codigo)

            Return value
        End Function

        Public Function ListarGrillaUsuTratamiento(Codigo As Integer, Login As String, Apellidos As String,
         Nombres As String, NumDoc As String, NivelUsuario As Integer, DependenciaPerfil As Integer, Estado As Integer) As Legolas.LEntity.Seguridad.UsuarioCol
            Return ListarGrilla_v1(Codigo, Login, Apellidos, Nombres, NumDoc, NivelUsuario, DependenciaPerfil, Estado, "lst_grilla_usuarios_tratamiento")
        End Function
        Public Function ListarGrillaUsuSeguridad(Codigo As Integer, Login As String, Apellidos As String,
         Nombres As String, NumDoc As String, NivelUsuario As Integer, DependenciaPerfil As Integer, Estado As Integer) As Legolas.LEntity.Seguridad.UsuarioCol
            Return ListarGrilla_v1(Codigo, Login, Apellidos, Nombres, NumDoc, NivelUsuario, DependenciaPerfil, Estado, "lst_grilla_usuarios_seguridad")
        End Function

        Public Function ListarGrilla(Codigo As Integer, Login As String, Apellidos As String,
         Nombres As String, NumDoc As String, NivelUsuario As Integer, DependenciaPerfil As Integer, Estado As Integer) As Legolas.LEntity.Seguridad.UsuarioCol
            Return ListarGrilla_v1(Codigo, Login, Apellidos, Nombres, NumDoc, NivelUsuario, DependenciaPerfil, Estado, "lst_grilla")
        End Function

        Public Function ListarGrilla_v1(Codigo As Integer, Login As String, Apellidos As String,
         Nombres As String, NumDoc As String, NivelUsuario As Integer, DependenciaPerfil As Integer, Estado As Integer, opc As String) As Legolas.LEntity.Seguridad.UsuarioCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Legolas.LData.Seguridad.Usuario.Listar(sqlCon, "lst", opc,
            Codigo, Login, Nothing, -1, "", "", Apellidos, Nombres, NumDoc, NivelUsuario, DependenciaPerfil, Estado)

            Dim objEntCol As New Legolas.LEntity.Seguridad.UsuarioCol

            Try
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        Dim objEnt As New Legolas.LEntity.Seguridad.Usuario

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
                            .Correo = sqlDr("c_cor_ins").ToString
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
        Public Function ListarUsuarioPermisos(IdUsuario As String,
         ModuloId As Short, PerfilUsuario As Short, IDRegion As Integer,
         IDPenal As Integer, Estado As Short) As Entity.Sistema.Seguridad.Usuario

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Entity.Sistema.Seguridad.Usuario With {
                .Codigo = IdUsuario,
                .ModuloId = ModuloId
            }

            Dim sqlDr As SqlDataReader = Data.Seguridad.Usuario.Listar(sqlCon, "lst", "lst_mant_permiso", objEntFiltro)
            Dim objEntUsu As New Entity.Sistema.Seguridad.Usuario
            Try
                If sqlDr.HasRows Then

                    While sqlDr.Read

                        With objEntUsu
                            .Codigo = Integer.Parse(sqlDr("usu_id").ToString)
                            .FormLectura = sqlDr("usu_mod_lec").ToString
                            .FormEscritura = sqlDr("usu_mod_esc").ToString
                            .FormEliminacion = sqlDr("usu_mod_eli").ToString
                            .FormReporte = sqlDr("usu_mod_rep").ToString
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

            Return objEntUsu
        End Function

        Public Function Grabar_v2(ent As Entity.Sistema.Seguridad.Usuario, ClaveCifrada As String) As Integer

            Dim strAc As String = If(ent.Codigo < 1, "ins", "upd")
            Dim strOp As String = If(ent.Codigo < 1, "ins_mant_cifrado", "upd_mant_cifrado")

            Dim intValue As Integer = Data.Seguridad.Usuario.Grabar_v2(strAc, strOp, ent, ClaveCifrada)

            If intValue = -1 Then Legolas.Configuration.Aplication.MessageBox.Exclamation("Los datos que se estan registrando, ya existen para un usuario en el sistema")

            Return intValue

        End Function
        Public Function Grabar(ent As Legolas.LEntity.Seguridad.Usuario, ClaveCifrada As String) As Integer

            Dim strAc As String = If(ent.Codigo < 1, "ins", "upd")
            Dim strOp As String = If(ent.Codigo < 1, "ins_mant_cifrado", "upd_mant_cifrado")

            Dim intValue As Integer = Data.Seguridad.Usuario.Grabar(strAc, strOp, ent, ClaveCifrada)

            If intValue = -1 Then Legolas.Configuration.Aplication.MessageBox.Exclamation("Los datos que se estan registrando, ya existen para un usuario en el sistema")

            Return intValue

        End Function

        Public Function GrabarLocal_v2(ent As Entity.Sistema.Seguridad.Usuario, ClaveCifrada As String) As Integer

            If Validar(ent.Login, ent.TrabajadorID, ent.ApellidoPaterno, ent.ApellidoMaterno, ent.Nombres, ent.NumeroDocumento) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Los datos del usuario a registrar, ya existen")
                Return -1
            End If

            Return Data.Seguridad.Usuario.Grabar_v2("ins", "ins_mant_local", ent, ClaveCifrada)

        End Function

        Public Function GrabarLocal(ent As Legolas.LEntity.Seguridad.Usuario, ClaveCifrada As String) As Integer

            If Validar(ent.Login, ent.TrabajadorID, ent.ApellidoPaterno, ent.ApellidoMaterno, ent.Nombres, ent.NumeroDocumento) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Los datos del usuario a registrar, ya existen")
                Return -1
            End If

            Return Data.Seguridad.Usuario.Grabar("ins", "ins_mant_local", ent, ClaveCifrada)

        End Function

        Public Function ActivarUsuario(intIDUsuario As Integer) As Integer
            Return Data.Seguridad.Usuario.Grabar("upd", "upd_activar_usuario", intIDUsuario, False, "")
        End Function

        Public Function Eliminar(ByVal Codigo As Integer) As Integer
            Return Legolas.LData.Seguridad.Usuario.Eliminar("del", "del_mant", Codigo, Legolas.Configuration.Usuario.Codigo)
        End Function
    End Class

End Namespace