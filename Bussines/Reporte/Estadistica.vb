Imports System.Data
Imports System.Data.SqlClient
Namespace Reporte
    Public Class Estadistica
        Private objEnt As Entity.Reporte.Estadistica.Formato1 = Nothing
        Private objEntCol As Entity.Reporte.Estadistica.Formato1Col = Nothing
#Region "Reporte"
        Public Function FormatoF1(ByVal PadinID As Integer, ByVal PenalID As Integer,
                                  ByVal FechaIni As Long, ByVal FechaFin As Long, intVersionReporte As Short) As Entity.Reporte.Estadistica.Formato1Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.General.Penal.Listar(sqlCon, "lst", "lst_reporte",
            PenalID, "", "", -1, -1, "")

            objEntCol = New Entity.Reporte.Estadistica.Formato1Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Estadistica.Formato1

                        With objEnt
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .Departamento = sqlDr("pen_dep").ToString
                            .Provincia = sqlDr("pen_pro").ToString
                            .Distrito = sqlDr("pen_dis").ToString
                            .Domicilio = sqlDr("pen_dom").ToString
                            .Telefono = sqlDr("pen_tel").ToString

                            '/*cuadro 001*/
                            .Cuadro001 = ListarCuadro1(PadinID, PenalID)
                            If intVersionReporte = 3 Then
                                .Cuadro002A = ListarCuadro2A(PadinID, PenalID, 3)
                            Else
                                '/*cuadro 002-A*/                      
                                .Cuadro002A = ListarCuadro2A(PadinID, PenalID, 1)
                                '/*cuadro 002-B*/                            
                                .Cuadro002B = ListarCuadro2B(PadinID, PenalID, 2)
                            End If
                            '/*cuadro 003, edad*/                            
                            .Cuadro003 = ListarCuadro3(PadinID, PenalID, FechaIni, FechaFin)

                            '/*cuadro 004, nivel de instruccion*/                            
                            .Cuadro004 = ListarCuadro4(PadinID, PenalID)

                            '/*cuadro 005, ocupacion*/                            
                            .Cuadro005 = ListarCuadro5(PadinID, PenalID)

                            '/*cuadro 006, estado civil*/                            
                            .Cuadro006 = ListarCuadro6(PadinID, PenalID)

                            '/*cuadro 007, tiempo de reclusion*/     
                            .Cuadro007 = ListarCuadro7(PadinID, PenalID, FechaIni, FechaFin)

                            '/*cuadro 008, tiempo de sentencia*/       
                            .Cuadro008 = ListarCuadro8(PadinID, PenalID)

                            '/*cuadro 009, comunidades campesionas*/   
                            .Cuadro009 = ListarCuadro9(PadinID, PenalID)

                            '/*cuadro 010, comunidades campesionas*/   
                            .Cuadro010 = ListarCuadro10(PadinID, PenalID)

                            '/*cuadro 011, cantidad de ingresos*/   
                            .Cuadro011 = ListarCuadro11(PadinID, PenalID)

                            '/*cuadro 012, ingresos por tipo de delito generico*/   
                            .Cuadro012 = ListarCuadro12(PadinID, PenalID, FechaIni, FechaFin)

                            '/*cuadro 013, egresos por tipo de libertades y otros*/   
                            .Cuadro013 = ListarCuadro13(PadinID, PenalID, FechaIni, FechaFin, intVersionReporte)

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
        Public Function FormatoF1_2(ByVal PadinID As Integer, ByVal PenalID As Integer, _
                                  ByVal FechaIni As Long, ByVal FechaFin As Long) As Entity.Reporte.Estadistica.Formato1Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.General.Penal.Listar(sqlCon, "lst", "lst_reporte", _
            PenalID, "", "", -1, -1, "")

            objEntCol = New Entity.Reporte.Estadistica.Formato1Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Estadistica.Formato1

                        With objEnt
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .Departamento = sqlDr("pen_dep").ToString
                            .Provincia = sqlDr("pen_pro").ToString
                            .Distrito = sqlDr("pen_dis").ToString
                            .Domicilio = sqlDr("pen_dom").ToString
                            .Telefono = sqlDr("pen_tel").ToString

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
        Public Function Reporte2(ByVal PadinID As Integer, ByVal PenalID As Integer, ByVal Nacionalidad As Integer) As Entity.Reporte.Estadistica.Reporte02Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon, _
            "lst", "lst_reporte_nominal", PadinID, PenalID, -1, Nacionalidad, -1, -1, -1, -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.Estadistica.Reporte02Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Dim objEnt As New Entity.Reporte.Estadistica.Reporte02

                        With objEnt
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .Sexo = sqlDr("sex_nom").ToString
                            .Nacionalidad = sqlDr("nac_nom").ToString
                            .DelitoEspecificoNombre = sqlDr("del_esp_nom").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .FechaIngreso = sqlDr("fec_ing").ToString
                            .SentenciaAnio = sqlDr("sen_anio").ToString
                            .SentenciaMes = sqlDr("sen_mes").ToString
                            .SentenciaDia = sqlDr("sen_dia").ToString
                            .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                            .SalaJudicialNombre = sqlDr("sal_juz_nom").ToString
                            .NumeroExpediente = sqlDr("num_exp").ToString
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
        Public Function Reporte3(ByVal PadinID As Integer, ByVal PenalID As Integer, _
                                 ByVal Fecha As Long) As Entity.Reporte.Estadistica.Reporte03Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon, _
            "lst", "lst_rpt_ninios_albergados", PadinID, PenalID, -1, -1, -1, -1, -1, -1, -1, Fecha, 0)

            Dim objEntCol As New Entity.Reporte.Estadistica.Reporte03Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Dim objEnt As New Entity.Reporte.Estadistica.Reporte03

                        With objEnt
                            'penal
                            .PenalNombre = sqlDr("pen_nom").ToString
                            'familiar niños <3
                            .FamiliarApellidoPaterno = sqlDr("fam_ape_pat").ToString
                            .FamiliarApellidoMaterno = sqlDr("fam_ape_mat").ToString
                            .FamiliarNombres = sqlDr("fam_nom").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .Sexo = sqlDr("sex_nom").ToString
                            'interno madres
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .FechaIngreso = sqlDr("fec_ing").ToString
                            .SentenciaAnio = sqlDr("sen_anio").ToString
                            .SentenciaMes = sqlDr("sen_mes").ToString
                            .SentenciaDia = sqlDr("sen_dia").ToString
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
#End Region
#Region "ReporteF1"
        Public Function ListarCuadro1(ByVal PadinID As Integer, ByVal PenalID As Integer) As Entity.Reporte.Estadistica.F1.Cuadro001Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon, _
            "lst", "cuadro01", PadinID, PenalID, -1, -1, -1, -1, -1, -1, -1, 0, 0)

            Dim objEnt As Entity.Reporte.Estadistica.F1.Cuadro001 = Nothing
            Dim objEntCol As Entity.Reporte.Estadistica.F1.Cuadro001Col = Nothing

            objEntCol = New Entity.Reporte.Estadistica.F1.Cuadro001Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Estadistica.F1.Cuadro001

                        With objEnt
                            .TotalGeneralProcesadoH = sqlDr("pro_hom").ToString
                            .TotalGeneralProcesadoM = sqlDr("pro_muj").ToString
                            .TotalGeneralSentenciadoH = sqlDr("sen_hom").ToString
                            .TotalGeneralSentenciadoM = sqlDr("sen_muj").ToString
                            .TotalGeneralMixtoH = sqlDr("mix_hom").ToString
                            .TotalGeneralMixtoM = sqlDr("mix_muj").ToString

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
        Public Function ListarCuadro2A(ByVal PadinID As Integer, ByVal PenalID As Integer, _
                                       ByVal Cuadro As Integer) As Entity.Reporte.Estadistica.F1.Cuadro002ACol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon, _
            "lst", "cuadro02", PadinID, PenalID, Cuadro, -1, -1, -1, -1, -1, -1, 0, 0)

            Dim objEnt As Entity.Reporte.Estadistica.F1.Cuadro002A = Nothing
            Dim objEntCol As Entity.Reporte.Estadistica.F1.Cuadro002ACol = Nothing

            objEntCol = New Entity.Reporte.Estadistica.F1.Cuadro002ACol

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Estadistica.F1.Cuadro002A
                        With objEnt
                            .DelitoGenerico = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("del_esp_nom").ToString
                            .ProcesadoHom = sqlDr("pro_hom").ToString
                            .ProcesadoMuj = sqlDr("pro_muj").ToString
                            .SentenciadoHom = sqlDr("sen_hom").ToString
                            .SentenciadoMuj = sqlDr("sen_muj").ToString
                            .MixtoHom = sqlDr("mix_hom").ToString
                            .MixtoMuj = sqlDr("mix_muj").ToString
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
        Public Function ListarCuadro2B(ByVal PadinID As Integer, ByVal PenalID As Integer, _
                                       ByVal Cuadro As Integer) As Entity.Reporte.Estadistica.F1.Cuadro002BCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon, _
            "lst", "cuadro02", PadinID, PenalID, Cuadro, -1, -1, -1, -1, -1, -1, 0, 0)

            Dim objEntB As Entity.Reporte.Estadistica.F1.Cuadro002B = Nothing
            Dim objEntBCol As Entity.Reporte.Estadistica.F1.Cuadro002BCol = Nothing

            objEntBCol = New Entity.Reporte.Estadistica.F1.Cuadro002BCol

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEntB = New Entity.Reporte.Estadistica.F1.Cuadro002B
                        With objEntB
                            .DelitoGenerico = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("del_esp_nom").ToString
                            .ProcesadoHom = sqlDr("pro_hom").ToString
                            .ProcesadoMuj = sqlDr("pro_muj").ToString
                            .SentenciadoHom = sqlDr("sen_hom").ToString
                            .SentenciadoMuj = sqlDr("sen_muj").ToString
                            .MixtoHom = sqlDr("mix_hom").ToString
                            .MixtoMuj = sqlDr("mix_muj").ToString
                        End With
                        objEntBCol.Add(objEntB)
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

            Return objEntBCol

        End Function
        Public Function ListarCuadro3(ByVal PadinID As Integer, ByVal PenalID As Integer, ByVal FechaIni As Long, ByVal FechaFin As Long) As Entity.Reporte.Estadistica.F1.Cuadro003Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon, _
            "lst", "cuadro03", PadinID, PenalID, -1, -1, -1, -1, -1, -1, -1, FechaIni, FechaFin)

            Dim objEnt As Entity.Reporte.Estadistica.F1.Cuadro003 = Nothing
            Dim objEntCol As Entity.Reporte.Estadistica.F1.Cuadro003Col = Nothing

            objEntCol = New Entity.Reporte.Estadistica.F1.Cuadro003Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Estadistica.F1.Cuadro003
                        With objEnt
                            .EdadString = sqlDr("eda_nom").ToString
                            .TotalProcesadoH = sqlDr("pro_hom").ToString
                            .TotalProcesadoM = sqlDr("pro_muj").ToString
                            .TotalSentenciadoH = sqlDr("sen_hom").ToString
                            .TotalSentenciadoM = sqlDr("sen_muj").ToString
                            .TotalMixtoH = sqlDr("mix_hom").ToString
                            .TotalMixtoM = sqlDr("mix_muj").ToString
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
        Public Function ListarCuadro4(ByVal PadinID As Integer, ByVal PenalID As Integer) As Entity.Reporte.Estadistica.F1.Cuadro004Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon, _
            "lst", "cuadro04", PadinID, PenalID, -1, -1, -1, -1, -1, -1, -1, 0, 0)

            Dim objEnt As Entity.Reporte.Estadistica.F1.Cuadro004 = Nothing
            Dim objEntCol As Entity.Reporte.Estadistica.F1.Cuadro004Col = Nothing

            objEntCol = New Entity.Reporte.Estadistica.F1.Cuadro004Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Estadistica.F1.Cuadro004

                        With objEnt
                            .Instruccion = sqlDr("aca_niv_nom").ToString
                            .ProcesadoHom = sqlDr("pro_hom").ToString
                            .ProcesadoMuj = sqlDr("pro_muj").ToString
                            .SentenciaHom = sqlDr("sen_hom").ToString
                            .SentenciaMuj = sqlDr("sen_muj").ToString
                            .MixtoHom = sqlDr("mix_hom").ToString
                            .MixtoMuj = sqlDr("mix_muj").ToString
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
        Public Function ListarCuadro5(ByVal PadinID As Integer, ByVal PenalID As Integer) As Entity.Reporte.Estadistica.F1.Cuadro005Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon, _
            "lst", "cuadro05", PadinID, PenalID, -1, -1, -1, -1, -1, -1, -1, 0, 0)

            Dim objEnt As Entity.Reporte.Estadistica.F1.Cuadro005 = Nothing
            Dim objEntCol As Entity.Reporte.Estadistica.F1.Cuadro005Col = Nothing

            objEntCol = New Entity.Reporte.Estadistica.F1.Cuadro005Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Estadistica.F1.Cuadro005

                        With objEnt
                            .TipoOcupacionID = sqlDr("ocu_tip_id").ToString
                            .TipoOcupacion = sqlDr("ocu_tip_nom").ToString
                            .GrupoOcupacion = sqlDr("ocu_grp_nom").ToString
                            .Ocupacion = ""
                            .Hombres = sqlDr("tot_hom").ToString
                            .Mujeres = sqlDr("tot_muj").ToString
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
        Public Function ListarCuadro6(ByVal PadinID As Integer, ByVal PenalID As Integer) As Entity.Reporte.Estadistica.F1.Cuadro006Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon, _
            "lst", "cuadro06", PadinID, PenalID, -1, -1, -1, -1, -1, -1, -1, 0, 0)

            Dim objEnt As Entity.Reporte.Estadistica.F1.Cuadro006 = Nothing
            Dim objEntCol As Entity.Reporte.Estadistica.F1.Cuadro006Col = Nothing

            objEntCol = New Entity.Reporte.Estadistica.F1.Cuadro006Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Estadistica.F1.Cuadro006

                        With objEnt
                            .EstadoCivil = sqlDr("est_civ_nom").ToString
                            .ProcesadosHom = sqlDr("pro_hom").ToString
                            .ProcesadosMuj = sqlDr("pro_muj").ToString
                            .SetenciadoHom = sqlDr("sen_hom").ToString
                            .SetenciadoMuj = sqlDr("sent_muj").ToString
                            .MixtoHom = sqlDr("mix_hom").ToString
                            .MixtoMuj = sqlDr("mix_muj").ToString
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
        Public Function ListarCuadro7(ByVal PadinID As Integer, ByVal PenalID As Integer, ByVal FechaIni As Long, ByVal FechaFin As Long) As Entity.Reporte.Estadistica.F1.Cuadro007Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon, _
            "lst", "cuadro07", PadinID, PenalID, -1, -1, -1, -1, -1, -1, -1, FechaIni, FechaFin)

            Dim objEnt As Entity.Reporte.Estadistica.F1.Cuadro007 = Nothing
            Dim objEntCol As Entity.Reporte.Estadistica.F1.Cuadro007Col = Nothing

            objEntCol = New Entity.Reporte.Estadistica.F1.Cuadro007Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Estadistica.F1.Cuadro007

                        With objEnt
                            .TiempoReclucion = sqlDr("tie_rec_nom").ToString
                            .ProcesadosHom = sqlDr("pro_hom").ToString
                            .ProcesadosMuj = sqlDr("pro_muj").ToString
                            .SetenciadoHom = sqlDr("sen_hom").ToString
                            .SetenciadoMuj = sqlDr("sent_muj").ToString
                            .MixtoHom = sqlDr("mix_hom").ToString
                            .MixtoMuj = sqlDr("mix_muj").ToString
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
        Public Function ListarCuadro8(ByVal PadinID As Integer, ByVal PenalID As Integer) As Entity.Reporte.Estadistica.F1.Cuadro008Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon, _
            "lst", "cuadro08", PadinID, PenalID, -1, -1, -1, -1, -1, -1, -1, 0, 0)

            Dim objEnt As Entity.Reporte.Estadistica.F1.Cuadro008 = Nothing
            Dim objEntCol As Entity.Reporte.Estadistica.F1.Cuadro008Col = Nothing

            objEntCol = New Entity.Reporte.Estadistica.F1.Cuadro008Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Estadistica.F1.Cuadro008

                        With objEnt
                            .TiempoSentencia = sqlDr("tie_sen").ToString
                            .SetenciadoHom = sqlDr("sen_hom").ToString
                            .SetenciadoMuj = sqlDr("sent_muj").ToString
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
        Public Function ListarCuadro9(ByVal PadinID As Integer, ByVal PenalID As Integer) As Entity.Reporte.Estadistica.F1.Cuadro009Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon, _
            "lst", "cuadro09", PadinID, PenalID, -1, -1, -1, -1, -1, -1, -1, 0, 0)

            Dim objEnt As Entity.Reporte.Estadistica.F1.Cuadro009 = Nothing
            Dim objEntCol As Entity.Reporte.Estadistica.F1.Cuadro009Col = Nothing

            objEntCol = New Entity.Reporte.Estadistica.F1.Cuadro009Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Estadistica.F1.Cuadro009

                        With objEnt
                            .TipoComunidad = sqlDr("par_nom").ToString
                            .ProcesadosHom = sqlDr("pro_hom").ToString
                            .ProcesadosMuj = sqlDr("pro_muj").ToString
                            .SetenciadoHom = sqlDr("sen_hom").ToString
                            .SetenciadoMuj = sqlDr("sent_muj").ToString
                            .MixtoHom = sqlDr("mix_hom").ToString
                            .MixtoMuj = sqlDr("mix_muj").ToString
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
        Public Function ListarCuadro10(ByVal PadinID As Integer, ByVal PenalID As Integer) As Entity.Reporte.Estadistica.F1.Cuadro010Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon, _
            "lst", "cuadro10", PadinID, PenalID, -1, -1, -1, -1, -1, -1, -1, 0, 0)

            Dim objEnt As Entity.Reporte.Estadistica.F1.Cuadro010 = Nothing
            Dim objEntCol As Entity.Reporte.Estadistica.F1.Cuadro010Col = Nothing

            objEntCol = New Entity.Reporte.Estadistica.F1.Cuadro010Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Estadistica.F1.Cuadro010

                        With objEnt
                            .Nombre = sqlDr("dis_nom").ToString
                            .ProcesadosHom = sqlDr("pro_hom").ToString
                            .ProcesadosMuj = sqlDr("pro_muj").ToString
                            .SetenciadoHom = sqlDr("sen_hom").ToString
                            .SetenciadoMuj = sqlDr("sent_muj").ToString
                            .MixtoHom = sqlDr("mix_hom").ToString
                            .MixtoMuj = sqlDr("mix_muj").ToString
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
        Public Function ListarCuadro11(ByVal PadinID As Integer, ByVal PenalID As Integer) As Entity.Reporte.Estadistica.F1.Cuadro011Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon, _
            "lst", "cuadro11", PadinID, PenalID, -1, -1, -1, -1, -1, -1, -1, 0, 0)

            Dim objEnt As Entity.Reporte.Estadistica.F1.Cuadro011 = Nothing
            Dim objEntCol As Entity.Reporte.Estadistica.F1.Cuadro011Col = Nothing

            objEntCol = New Entity.Reporte.Estadistica.F1.Cuadro011Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Estadistica.F1.Cuadro011
                        With objEnt
                            .Ingreso1 = sqlDr("ing_01").ToString
                            .Ingreso2 = sqlDr("ing_02").ToString
                            .Ingreso3 = sqlDr("ing_03").ToString
                            .Ingreso4 = sqlDr("ing_04").ToString
                            .Ingreso5 = sqlDr("ing_05").ToString
                            .Ingreso6 = sqlDr("ing_06").ToString
                            .Ingreso7 = sqlDr("ing_07").ToString
                            .Ingreso8 = sqlDr("ing_08").ToString
                            .Ingreso9 = sqlDr("ing_09").ToString
                            .Ingreso10 = sqlDr("ing_10").ToString
                            .Ingreso11 = sqlDr("ing_11").ToString
                            .Ingreso12 = sqlDr("ing_12").ToString
                            .Ingreso13 = sqlDr("ing_13").ToString
                            .Ingreso14 = sqlDr("ing_14").ToString
                            .Ingreso15 = sqlDr("ing_15").ToString
                            .Ingreso16 = sqlDr("ing_16").ToString
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
        Public Function ListarCuadro12(ByVal PadinID As Integer, ByVal PenalID As Integer, _
                                       ByVal FechaIni As Long, ByVal FechaFin As Long) As Entity.Reporte.Estadistica.F1.Cuadro012Col


            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon, _
            "lst", "cuadro12", PadinID, PenalID, -1, -1, -1, -1, -1, -1, -1, FechaIni, FechaFin)

            Dim objEnt As Entity.Reporte.Estadistica.F1.Cuadro012 = Nothing
            Dim objEntCol As Entity.Reporte.Estadistica.F1.Cuadro012Col = Nothing

            objEntCol = New Entity.Reporte.Estadistica.F1.Cuadro012Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Estadistica.F1.Cuadro012
                        With objEnt
                            .Nombre = sqlDr("nom").ToString
                            .Hombres = sqlDr("hom").ToString
                            .Mujeres = sqlDr("muj").ToString
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
        Public Function ListarCuadro13(ByVal PadinID As Integer, ByVal PenalID As Integer,
                                       ByVal FechaIni As Long, ByVal FechaFin As Long, intVersionReporte As Short) As Entity.Reporte.Estadistica.F1.Cuadro013Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Estadistica.Listar(sqlCon,
            "lst", "cuadro13", PadinID, PenalID, intVersionReporte, -1, -1, -1, -1, -1, -1, FechaIni, FechaFin)

            Dim objEnt As Entity.Reporte.Estadistica.F1.Cuadro013 = Nothing
            Dim objEntCol As Entity.Reporte.Estadistica.F1.Cuadro013Col = Nothing

            objEntCol = New Entity.Reporte.Estadistica.F1.Cuadro013Col

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Estadistica.F1.Cuadro013
                        With objEnt
                            .Nombre = sqlDr("nom").ToString
                            .NombreDetalle = sqlDr("c_nom_det").ToString
                            .Hombres = sqlDr("hom").ToString
                            .Mujeres = sqlDr("muj").ToString
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
#End Region
    End Class
End Namespace
