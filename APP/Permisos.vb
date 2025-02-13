Public Class Permisos

    Public Shared Function _FormLecturaRegistro(intIDLicencia As Short, intTipoLicencia As Short, intPerfil As Type.Enumeracion.Usuario.EnumDependencia) As Boolean

        Dim value As Boolean = False

        Select Case intIDLicencia

            Case 1 'sede central
                Select Case intPerfil

                    Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                        Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario,
                        Type.Enumeracion.Usuario.EnumDependencia.DireccionRegistroPenitenciario
                        value = True
                End Select

            Case Else 'provincias

                Select Case intTipoLicencia
                    Case 1 ' penales de provincia
                        Select Case intPerfil
                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                 Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario
                                value = True
                        End Select

                    Case 2 'regiones
                        Select Case intPerfil
                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                 Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario
                                value = True
                        End Select

                    Case 4 'penales de limametropolitana

                End Select

        End Select

        Return value

    End Function

    Public Shared Function _FormEscrituraRegistro(intIDLicencia As Short, intTipoLicencia As Short, intPerfil As Type.Enumeracion.Usuario.EnumDependencia) As Boolean

        Dim value As Boolean = False

        Select Case intIDLicencia

            Case 1 'sede central

            Case Else 'provincias

                Select Case intTipoLicencia
                    Case 1 'penales provincia

                        Select Case intPerfil

                            Case Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario
                                value = True
                        End Select

                    Case 2 'regiones

                    Case 4 'penales lima metropolitana

                End Select

        End Select

        Return value

    End Function

    Public Shared Function _FormEliminarRegistro(intIDLicencia As Short, intTipoLicencia As Short, intPerfil As Type.Enumeracion.Usuario.EnumDependencia) As Boolean

        Dim value As Boolean = False

        Select Case intIDLicencia

            Case 1 'sede central

            Case Else 'provincias

                Select Case intTipoLicencia
                    Case 1 'penales provincia

                        Select Case intPerfil

                            Case Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario
                                value = True
                        End Select

                    Case 2 'regiones

                    Case 4 'penales lima metropolitana

                End Select

        End Select

        Return value

    End Function

    Public Shared Function _FormReporteRegistro(intIDLicencia As Short, intTipoLicencia As Short, intPerfil As Type.Enumeracion.Usuario.EnumDependencia) As Boolean

        Dim value As Boolean = False

        Select Case intIDLicencia

            Case 1 'sede central

                Select Case intPerfil
                    Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                            Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario,
                            Type.Enumeracion.Usuario.EnumDependencia.DireccionRegistroPenitenciario
                        value = True
                End Select

            Case Else 'provincias

                Select Case intTipoLicencia

                    Case 1 'penales provincia

                        Select Case intPerfil
                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                            Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario
                                value = True
                        End Select

                    Case 2 'regiones

                        Select Case intPerfil
                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                            Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario
                                value = True
                        End Select

                    Case 4 'penales lima metropolitana

                End Select

        End Select

        Return value

    End Function

    Public Shared Function _FormPermisosRegistro(IdUsuario As Integer, ModuloId As Integer, intIDLicencia As Integer, intTipoLicencia As Integer, intPerfil As Integer) As Entity.Sistema.Seguridad.Usuario
        Dim obj As New Entity.Sistema.Seguridad.Usuario
        Dim value As Boolean = False

        Select Case intIDLicencia

            Case 1 'sede central

            Case Else 'provincias

                Select Case intTipoLicencia
                    Case 1 'penales provincia

                        Select Case intPerfil

                            Case Type.Enumeracion.Usuario.EnumDependencia.RegistroPenitenciario, Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion
                                obj = (New Bussines.Seguridad.Usuario).ListarUsuarioPermisos(IdUsuario, ModuloId, 1, 1, 1, 1)
                                value = True
                        End Select

                    Case 2 'regiones

                    Case 4 'penales lima metropolitana

                End Select

        End Select
        Return obj
    End Function
    Public Shared Function _FormLecturaTratamiento(intIDLicencia As Short, intTipoLicencia As Short, intPerfil As Type.Enumeracion.Usuario.EnumDependencia) As Boolean

        Dim value As Boolean = False

        Select Case intIDLicencia

            Case 1 'sede central
                Select Case intPerfil

                    Case Type.Enumeracion.Usuario.EnumDependencia.TratamientoPenitenciario,
                       Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                       value = True
                End Select

            Case Else 'provincias

                Select Case intTipoLicencia
                    Case 1 'penales provincia

                        Select Case intPerfil
                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion
                                value = True

                            Case Type.Enumeracion.Usuario.EnumDependencia.TratamientoPenitenciario,
                                       Type.Enumeracion.Usuario.EnumDependencia.Legal,
                                       Type.Enumeracion.Usuario.EnumDependencia.Psicologo,
                                       Type.Enumeracion.Usuario.EnumDependencia.Social,
                                       Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegal,
                                       Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyPsicologo,
                                       Type.Enumeracion.Usuario.EnumDependencia.JefeJTCySocial,
                                       Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegalPsicologoSocial,
                                       Type.Enumeracion.Usuario.EnumDependencia.JefeTratamientoPenitenciario
                                value = True
                        End Select

                    Case 2 'regiones

                    Case 4 'penales lima metropolitana
                        Select Case intPerfil
                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion
                                value = True

                            Case Type.Enumeracion.Usuario.EnumDependencia.TratamientoPenitenciario,
                                       Type.Enumeracion.Usuario.EnumDependencia.Legal,
                                       Type.Enumeracion.Usuario.EnumDependencia.Psicologo,
                                       Type.Enumeracion.Usuario.EnumDependencia.Social,
                                       Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegal,
                                       Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyPsicologo,
                                       Type.Enumeracion.Usuario.EnumDependencia.JefeJTCySocial,
                                       Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegalPsicologoSocial,
                                       Type.Enumeracion.Usuario.EnumDependencia.JefeTratamientoPenitenciario

                                value = True
                        End Select
                    Case 7 'penales lima provincia
                        Select Case intPerfil
                            Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion
                                value = True

                            Case Type.Enumeracion.Usuario.EnumDependencia.TratamientoPenitenciario,
                                       Type.Enumeracion.Usuario.EnumDependencia.Legal,
                                       Type.Enumeracion.Usuario.EnumDependencia.Psicologo,
                                       Type.Enumeracion.Usuario.EnumDependencia.Social,
                                       Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegal,
                                       Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyPsicologo,
                                       Type.Enumeracion.Usuario.EnumDependencia.JefeJTCySocial,
                                       Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegalPsicologoSocial,
                                       Type.Enumeracion.Usuario.EnumDependencia.JefeTratamientoPenitenciario

                                value = True
                        End Select
                End Select
        End Select

        Return value

    End Function

    Public Shared Function _FormEscrituraTratamiento(intIDLicencia As Short, intTipoLicencia As Short, intPerfil As Type.Enumeracion.Usuario.EnumDependencia) As Boolean

        Dim value As Boolean = False

        Select Case intIDLicencia

            Case 1 'sede central

            Case Else 'provincias

                Select Case intTipoLicencia
                    Case 1 'penales provincia

                        Select Case intPerfil

                            Case Type.Enumeracion.Usuario.EnumDependencia.TratamientoPenitenciario,
                                    Type.Enumeracion.Usuario.EnumDependencia.Legal,
                                    Type.Enumeracion.Usuario.EnumDependencia.Psicologo,
                                    Type.Enumeracion.Usuario.EnumDependencia.Social,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegal,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyPsicologo,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCySocial,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegalPsicologoSocial,
                                    Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeTratamientoPenitenciario

                                value = True

                        End Select

                    Case 2 'regiones

                    Case 4 'penales de limametropolitana
                        Select Case intPerfil

                            Case Type.Enumeracion.Usuario.EnumDependencia.TratamientoPenitenciario,
                                    Type.Enumeracion.Usuario.EnumDependencia.Legal,
                                    Type.Enumeracion.Usuario.EnumDependencia.Psicologo,
                                    Type.Enumeracion.Usuario.EnumDependencia.Social,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegal,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyPsicologo,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCySocial,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegalPsicologoSocial,
                                    Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeTratamientoPenitenciario

                                value = True

                        End Select
                    Case 7 'penales lima provincia

                        Select Case intPerfil

                            Case Type.Enumeracion.Usuario.EnumDependencia.TratamientoPenitenciario,
                                    Type.Enumeracion.Usuario.EnumDependencia.Legal,
                                    Type.Enumeracion.Usuario.EnumDependencia.Psicologo,
                                    Type.Enumeracion.Usuario.EnumDependencia.Social,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegal,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyPsicologo,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCySocial,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegalPsicologoSocial,
                                    Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeTratamientoPenitenciario

                                value = True

                        End Select
                End Select

        End Select

        Return value

    End Function

    Public Shared Function _FormReporteTratamiento(intIDLicencia As Short, intTipoLicencia As Short, intPerfil As Type.Enumeracion.Usuario.EnumDependencia) As Boolean

        Dim value As Boolean = False

        Select Case intIDLicencia

            Case 1 'sede central


            Case Else 'provincias

                Select Case intTipoLicencia

                    Case 1 'penales provincia

                        Select Case intPerfil

                            Case Type.Enumeracion.Usuario.EnumDependencia.TratamientoPenitenciario,
                                    Type.Enumeracion.Usuario.EnumDependencia.Legal,
                                    Type.Enumeracion.Usuario.EnumDependencia.Psicologo,
                                    Type.Enumeracion.Usuario.EnumDependencia.Social,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegal,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyPsicologo,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCySocial,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegalPsicologoSocial,
                                    Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                   Type.Enumeracion.Usuario.EnumDependencia.JefeTratamientoPenitenciario

                                value = True

                        End Select

                    Case 2 'regiones


                    Case 4 'penales lima metropolitana
                        Select Case intPerfil

                            Case Type.Enumeracion.Usuario.EnumDependencia.TratamientoPenitenciario,
                                    Type.Enumeracion.Usuario.EnumDependencia.Legal,
                                    Type.Enumeracion.Usuario.EnumDependencia.Psicologo,
                                    Type.Enumeracion.Usuario.EnumDependencia.Social,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegal,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyPsicologo,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCySocial,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegalPsicologoSocial,
                                    Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeTratamientoPenitenciario

                                value = True

                        End Select

                    Case 7 'penales lima provincia
                        Select Case intPerfil

                            Case Type.Enumeracion.Usuario.EnumDependencia.TratamientoPenitenciario,
                                    Type.Enumeracion.Usuario.EnumDependencia.Legal,
                                    Type.Enumeracion.Usuario.EnumDependencia.Psicologo,
                                    Type.Enumeracion.Usuario.EnumDependencia.Social,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegal,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyPsicologo,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCySocial,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeJTCyLegalPsicologoSocial,
                                    Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion,
                                    Type.Enumeracion.Usuario.EnumDependencia.JefeTratamientoPenitenciario

                                value = True

                        End Select

                End Select

        End Select

        Return value

    End Function

End Class
