Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoRasgo
        Private objEnt As Entity.Registro.Internorasgo = Nothing
        Private objEntCol As Entity.Registro.InternorasgoCol = Nothing
#Region "Listar"
        Public Function Listar(EntRas As Entity.Registro.InternoRasgo) As Entity.Registro.InternoRasgoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoRasgo.Listar(sqlCon, "lst", "lst_grilla_v5", EntRas)
            Try
                objEntCol = New Entity.Registro.InternoRasgoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoRasgo
                        With objEnt
                            .Codigo = sqlDr("int_ras_id").ToString

                            .Raza = sqlDr("int_ras_raz").ToString
                            .CabelloForma = sqlDr("int_ras_cab_for").ToString
                            .CabelloColor = sqlDr("int_ras_cab_col").ToString
                            .Calvicie = sqlDr("int_ras_cal").ToString
                            .Menton = sqlDr("int_ras_men").ToString
                            .Frente = sqlDr("int_ras_fre").ToString
                            .CaraForma = sqlDr("int_ras_car_for").ToString
                            .LineaInsercion = sqlDr("int_ras_lin_ins").ToString
                            .FormaOjo = sqlDr("int_ras_for_ojo").ToString
                            .Iris = sqlDr("int_ras_iri").ToString
                            .Cejas = sqlDr("int_ras_cej").ToString
                            .AnomaliaOjo = sqlDr("int_ras_ano_ojo").ToString
                            .Oreja = sqlDr("int_ras_ore").ToString
                            .NarizForma = sqlDr("int_ras_nar_for").ToString
                            .TipoNariz = sqlDr("int_ras_tip_nar").ToString
                            .Boca = sqlDr("int_ras_boc").ToString
                            .Labio = sqlDr("int_ras_lab").ToString
                            .TipoLabio = sqlDr("int_ras_tip_lab").ToString
                            .Tronco = sqlDr("int_ras_tro").ToString
                            .Complexion = sqlDr("int_ras_com").ToString

                            .Raza_Nom = sqlDr("int_ras_raz_nom").ToString
                            .CabelloForma_Nom = sqlDr("int_ras_cab_for_nom").ToString
                            .CabelloColor_Nom = sqlDr("int_ras_cab_col_nom").ToString
                            .Calvicie_Nom = sqlDr("int_ras_cal_nom").ToString
                            .Menton_Nom = sqlDr("int_ras_men_nom").ToString
                            .Frente_Nom = sqlDr("int_ras_fre_nom").ToString
                            .CaraForma_Nom = sqlDr("int_ras_car_for_nom").ToString
                            .LineaInsercion_Nom = sqlDr("int_ras_lin_ins_nom").ToString
                            .FormaOjo_Nom = sqlDr("int_ras_for_ojo_nom").ToString
                            .Iris_Nom = sqlDr("int_ras_iri_nom").ToString
                            .Cejas_Nom = sqlDr("int_ras_cej_nom").ToString
                            .AnomaliaOjo_Nom = sqlDr("int_ras_ano_ojo_nom").ToString
                            .Oreja_Nom = sqlDr("int_ras_ore_nom").ToString
                            .NarizForma_Nom = sqlDr("int_ras_nar_for_nom").ToString
                            .TipoNariz_Nom = sqlDr("int_ras_tip_nar_nom").ToString
                            .Boca_Nom = sqlDr("int_ras_boc_nom").ToString
                            .Labio_Nom = sqlDr("int_ras_lab_nom").ToString
                            .TipoLabio_Nom = sqlDr("int_ras_tip_lab_nom").ToString
                            .Tronco_Nom = sqlDr("int_ras_tro_nom").ToString
                            .Complexion_Nom = sqlDr("int_ras_com_nom").ToString

                            .Talla = sqlDr("int_ras_tal").ToString
                            .Peso = sqlDr("int_ras_pes").ToString
                            .Obs = sqlDr("int_ras_obs").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .NumIngreso = IIf(Val(sqlDr("num_ingreso").ToString) = 0, "", sqlDr("num_ingreso").ToString)
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
        '07/01/2015
        Public Function Listar2(ByVal Codigo As Integer) As Entity.Registro.InternoRasgo
            Dim EntRas As New Entity.Registro.InternoRasgo
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            EntRas.Codigo = Codigo
            Dim sqlDr As SqlDataReader = Data.Registro.InternoRasgo.Listar(sqlCon, "lst", "lst_mant_v5", EntRas)
            objEnt = New Entity.Registro.InternoRasgo
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_ras_id").ToString
                            .Raza = sqlDr("int_ras_raz").ToString
                            .CabelloForma = sqlDr("int_ras_cab_for").ToString
                            .CabelloColor = sqlDr("int_ras_cab_col").ToString
                            .Calvicie = sqlDr("int_ras_cal").ToString
                            .Menton = sqlDr("int_ras_men").ToString
                            .Frente = sqlDr("int_ras_fre").ToString
                            .CaraForma = sqlDr("int_ras_car_for").ToString
                            .LineaInsercion = sqlDr("int_ras_lin_ins").ToString
                            .FormaOjo = sqlDr("int_ras_for_ojo").ToString
                            .Iris = sqlDr("int_ras_iri").ToString
                            .Cejas = sqlDr("int_ras_cej").ToString
                            .AnomaliaOjo = sqlDr("int_ras_ano_ojo").ToString
                            .Oreja = sqlDr("int_ras_ore").ToString
                            .NarizForma = sqlDr("int_ras_nar_for").ToString
                            .TipoNariz = sqlDr("int_ras_tip_nar").ToString
                            .Boca = sqlDr("int_ras_boc").ToString
                            .Labio = sqlDr("int_ras_lab").ToString
                            .TipoLabio = sqlDr("int_ras_tip_lab").ToString
                            .Tronco = sqlDr("int_ras_tro").ToString
                            .Complexion = sqlDr("int_ras_com").ToString
                            .Talla = sqlDr("int_ras_tal").ToString
                            .Peso = sqlDr("int_ras_pes").ToString
                            .Obs = sqlDr("int_ras_obs").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
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

        Public Function Listar_LM(Codigo As Integer) As Entity.Registro.InternoRasgo
            If Codigo = -1 Then Return Nothing

            Dim ent As New Entity.Registro.InternoRasgo
            ent.Codigo = Codigo
            Try
                ent = Listar_LM(ent).Entity(0)
            Catch ex As Exception
                ent = Nothing
            End Try
            Return ent
        End Function
        Public Function Listar_LM(EntRas As Entity.Registro.InternoRasgo) As Entity.EntityCol(Of Entity.Registro.InternoRasgo)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoRasgo.Listar_LM(sqlCon, "lst", "lst_grilla_lm", EntRas)
            Dim objEntCol_ As New Entity.EntityCol(Of Entity.Registro.InternoRasgo)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoRasgo
                        With objEnt
                            .Codigo = sqlDr("int_ras_id").ToString
                            .Raza = sqlDr("int_ras_raz").ToString
                            .CabelloForma = sqlDr("int_ras_cab_for").ToString
                            .CabelloColor = sqlDr("int_ras_cab_col").ToString
                            .Calvicie = sqlDr("int_ras_cal").ToString
                            .Menton = sqlDr("int_ras_men").ToString
                            .Frente = sqlDr("int_ras_fre").ToString
                            .CaraForma = sqlDr("int_ras_car_for").ToString
                            .LineaInsercion = sqlDr("int_ras_lin_ins").ToString
                            .FormaOjo = sqlDr("int_ras_for_ojo").ToString
                            .Iris = sqlDr("int_ras_iri").ToString
                            .Cejas = sqlDr("int_ras_cej").ToString
                            .AnomaliaOjo = sqlDr("int_ras_ano_ojo").ToString
                            .Oreja = sqlDr("int_ras_ore").ToString
                            .NarizForma = sqlDr("int_ras_nar_for").ToString
                            .TipoNariz = sqlDr("int_ras_tip_nar").ToString
                            .Boca = sqlDr("int_ras_boc").ToString
                            .Labio = sqlDr("int_ras_lab").ToString
                            .TipoLabio = sqlDr("int_ras_tip_lab").ToString
                            .Tronco = sqlDr("int_ras_tro").ToString
                            .Complexion = sqlDr("int_ras_com").ToString

                            .Raza_Nom = sqlDr("int_ras_raz_nom").ToString
                            .CabelloForma_Nom = sqlDr("int_ras_cab_for_nom").ToString
                            .CabelloColor_Nom = sqlDr("int_ras_cab_col_nom").ToString
                            .Calvicie_Nom = sqlDr("int_ras_cal_nom").ToString
                            .Menton_Nom = sqlDr("int_ras_men_nom").ToString
                            .Frente_Nom = sqlDr("int_ras_fre_nom").ToString
                            .CaraForma_Nom = sqlDr("int_ras_car_for_nom").ToString
                            .LineaInsercion_Nom = sqlDr("int_ras_lin_ins_nom").ToString
                            .FormaOjo_Nom = sqlDr("int_ras_for_ojo_nom").ToString
                            .Iris_Nom = sqlDr("int_ras_iri_nom").ToString
                            .Cejas_Nom = sqlDr("int_ras_cej_nom").ToString
                            .AnomaliaOjo_Nom = sqlDr("int_ras_ano_ojo_nom").ToString
                            .Oreja_Nom = sqlDr("int_ras_ore_nom").ToString
                            .NarizForma_Nom = sqlDr("int_ras_nar_for_nom").ToString
                            .TipoNariz_Nom = sqlDr("int_ras_tip_nar_nom").ToString
                            .Boca_Nom = sqlDr("int_ras_boc_nom").ToString
                            .Labio_Nom = sqlDr("int_ras_lab_nom").ToString
                            .TipoLabio_Nom = sqlDr("int_ras_tip_lab_nom").ToString
                            .Tronco_Nom = sqlDr("int_ras_tro_nom").ToString
                            .Complexion_Nom = sqlDr("int_ras_com_nom").ToString

                            .Talla = sqlDr("int_ras_tal").ToString
                            .Peso = sqlDr("int_ras_pes").ToString
                            .Obs = sqlDr("int_ras_obs").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .NumIngreso = sqlDr("int_ing_nro")
                            .IngresoNroInpe = sqlDr("ing_pen_nro")
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .PenalId = sqlDr("_penid").ToString

                        End With
                        objEntCol_.Add(objEnt)
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
            Return objEntCol_
        End Function

        Public Function ListarUltimoRasgo(InternoId As Integer) As Entity.Registro.InternoRasgo
            '---------------------------------------------------------------
            'retorna el ultimo rasgo del interno, top 1
            '---------------------------------------------------------------
            Dim EntRas As New Entity.Registro.InternoRasgo
            EntRas.InternoId = InternoId
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoRasgo.Listar(sqlCon, "lst", "lst_mant_top", EntRas)
            Try
                objEntCol = New Entity.Registro.InternoRasgoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoRasgo
                        With objEnt
                            .Codigo = sqlDr("int_ras_id").ToString

                            .Raza = sqlDr("int_ras_raz").ToString
                            .CabelloForma = sqlDr("int_ras_cab_for").ToString
                            .CabelloColor = sqlDr("int_ras_cab_col").ToString
                            .Calvicie = sqlDr("int_ras_cal").ToString
                            .Menton = sqlDr("int_ras_men").ToString
                            .Frente = sqlDr("int_ras_fre").ToString
                            .CaraForma = sqlDr("int_ras_car_for").ToString
                            .LineaInsercion = sqlDr("int_ras_lin_ins").ToString
                            .FormaOjo = sqlDr("int_ras_for_ojo").ToString
                            .Iris = sqlDr("int_ras_iri").ToString
                            .Cejas = sqlDr("int_ras_cej").ToString
                            .AnomaliaOjo = sqlDr("int_ras_ano_ojo").ToString
                            .Oreja = sqlDr("int_ras_ore").ToString
                            .NarizForma = sqlDr("int_ras_nar_for").ToString
                            .TipoNariz = sqlDr("int_ras_tip_nar").ToString
                            .Boca = sqlDr("int_ras_boc").ToString
                            .Labio = sqlDr("int_ras_lab").ToString
                            .TipoLabio = sqlDr("int_ras_tip_lab").ToString
                            .Tronco = sqlDr("int_ras_tro").ToString
                            .Complexion = sqlDr("int_ras_com").ToString

                            .Talla = sqlDr("int_ras_tal").ToString
                            .Peso = sqlDr("int_ras_pes").ToString
                            .Obs = sqlDr("int_ras_obs").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            '.NumIngreso = IIf(Val(sqlDr("num_ingreso").ToString) = 0, "", sqlDr("num_ingreso").ToString)
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

        Public Function ListarUltimoRasgo_LM(InternoId As Integer) As Entity.Registro.InternoRasgo
            '---------------------------------------------------------------
            'retorna el ultimo rasgo del interno, top 1
            '---------------------------------------------------------------
            Dim EntRas As New Entity.Registro.InternoRasgo
            EntRas.InternoId = InternoId
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoRasgo.Listar(sqlCon, "lst", "lst_mant_top_lm", EntRas)
            Try
                objEntCol = New Entity.Registro.InternoRasgoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoRasgo
                        With objEnt
                            .Codigo = sqlDr("int_ras_id").ToString

                            .Raza = sqlDr("int_ras_raz").ToString
                            .CabelloForma = sqlDr("int_ras_cab_for").ToString
                            .CabelloColor = sqlDr("int_ras_cab_col").ToString
                            .Calvicie = sqlDr("int_ras_cal").ToString
                            .Menton = sqlDr("int_ras_men").ToString
                            .Frente = sqlDr("int_ras_fre").ToString
                            .CaraForma = sqlDr("int_ras_car_for").ToString
                            .LineaInsercion = sqlDr("int_ras_lin_ins").ToString
                            .FormaOjo = sqlDr("int_ras_for_ojo").ToString
                            .Iris = sqlDr("int_ras_iri").ToString
                            .Cejas = sqlDr("int_ras_cej").ToString
                            .AnomaliaOjo = sqlDr("int_ras_ano_ojo").ToString
                            .Oreja = sqlDr("int_ras_ore").ToString
                            .NarizForma = sqlDr("int_ras_nar_for").ToString
                            .TipoNariz = sqlDr("int_ras_tip_nar").ToString
                            .Boca = sqlDr("int_ras_boc").ToString
                            .Labio = sqlDr("int_ras_lab").ToString
                            .TipoLabio = sqlDr("int_ras_tip_lab").ToString
                            .Tronco = sqlDr("int_ras_tro").ToString
                            .Complexion = sqlDr("int_ras_com").ToString

                            .Talla = sqlDr("int_ras_tal").ToString
                            .Peso = sqlDr("int_ras_pes").ToString
                            .Obs = sqlDr("int_ras_obs").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            '.NumIngreso = IIf(Val(sqlDr("num_ingreso").ToString) = 0, "", sqlDr("num_ingreso").ToString)
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

        Public Function ListarID(ByVal InternoID As Integer) As Integer

            Dim intValue As Integer = -1
            intValue = Data.Registro.InternoRasgo.ListarOutput("lst", "lst_id", -1, InternoID)
            Return intValue

        End Function
        
        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.InternoRasgo

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoRasgo.Listar(sqlCon, "lst", "lst_mant", Codigo, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, "")
            objEnt = New Entity.Registro.InternoRasgo
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_ras_id").ToString
                            .Raza = sqlDr("int_ras_raz").ToString
                            .CabelloForma = sqlDr("int_ras_cab_for").ToString
                            .CabelloColor = sqlDr("int_ras_cab_col").ToString
                            .Calvicie = sqlDr("int_ras_cal").ToString
                            .Menton = sqlDr("int_ras_men").ToString
                            .Frente = sqlDr("int_ras_fre").ToString
                            .CaraForma = sqlDr("int_ras_car_for").ToString
                            .LineaInsercion = sqlDr("int_ras_lin_ins").ToString
                            .FormaOjo = sqlDr("int_ras_for_ojo").ToString
                            .Iris = sqlDr("int_ras_iri").ToString
                            .Cejas = sqlDr("int_ras_cej").ToString
                            .AnomaliaOjo = sqlDr("int_ras_ano_ojo").ToString
                            .Oreja = sqlDr("int_ras_ore").ToString
                            .NarizForma = sqlDr("int_ras_nar_for").ToString
                            .TipoNariz = sqlDr("int_ras_tip_nar").ToString
                            .Boca = sqlDr("int_ras_boc").ToString
                            .Labio = sqlDr("int_ras_lab").ToString
                            .TipoLabio = sqlDr("int_ras_tip_lab").ToString
                            .Tronco = sqlDr("int_ras_tro").ToString
                            .Complexion = sqlDr("int_ras_com").ToString
                            .Talla = sqlDr("int_ras_tal").ToString
                            .Peso = sqlDr("int_ras_pes").ToString
                            .Obs = sqlDr("int_ras_obs").ToString
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
        Public Function Listar(ByVal Codigo As Integer, _
        ByVal Raza As Integer, _
        ByVal CabelloForma As Integer, _
        ByVal CabelloColor As Integer, _
        ByVal Calvicie As Integer, _
        ByVal Menton As Integer, _
        ByVal Frente As Integer, _
        ByVal CaraForma As Integer, _
        ByVal LineaInsercion As Integer, _
        ByVal FormaOjo As Integer, _
        ByVal Iris As Integer, _
        ByVal Cejas As Integer, _
        ByVal AnomaliaOjo As Integer, _
        ByVal Oreja As Integer, _
        ByVal NarizForma As Integer, _
        ByVal TipoNariz As Integer, _
        ByVal Boca As Integer, _
        ByVal Labio As Integer, _
        ByVal TipoLabio As Integer, _
        ByVal Tronco As Integer, _
        ByVal Complexion As Integer, _
        ByVal Talla As Integer, _
        ByVal Peso As Integer, _
        ByVal Obs As String _
        ) As Entity.Registro.InternoRasgoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoRasgo.Listar(sqlCon, "lst", "lst_mant", Codigo, _
            Raza, _
            CabelloForma, _
            CabelloColor, _
            Calvicie, _
            Menton, _
            Frente, _
            CaraForma, _
            LineaInsercion, _
            FormaOjo, _
            Iris, _
            Cejas, _
            AnomaliaOjo, _
            Oreja, _
            NarizForma, _
            TipoNariz, _
            Boca, _
            Labio, _
            TipoLabio, _
            Tronco, _
            Complexion, _
            Talla, _
            Peso, _
            Obs _
            )
            Try
                objEntCol = New Entity.Registro.InternoRasgoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoRasgo
                        With objEnt
                            .Codigo = sqlDr("int_ras_id").ToString
                            .Raza = sqlDr("int_ras_raz").ToString
                            .CabelloForma = sqlDr("int_ras_cab_for").ToString
                            .CabelloColor = sqlDr("int_ras_cab_col").ToString
                            .Calvicie = sqlDr("int_ras_cal").ToString
                            .Menton = sqlDr("int_ras_men").ToString
                            .Frente = sqlDr("int_ras_fre").ToString
                            .CaraForma = sqlDr("int_ras_car_for").ToString
                            .LineaInsercion = sqlDr("int_ras_lin_ins").ToString
                            .FormaOjo = sqlDr("int_ras_for_ojo").ToString
                            .Iris = sqlDr("int_ras_iri").ToString
                            .Cejas = sqlDr("int_ras_cej").ToString
                            .AnomaliaOjo = sqlDr("int_ras_ano_ojo").ToString
                            .Oreja = sqlDr("int_ras_ore").ToString
                            .NarizForma = sqlDr("int_ras_nar_for").ToString
                            .TipoNariz = sqlDr("int_ras_tip_nar").ToString
                            .Boca = sqlDr("int_ras_boc").ToString
                            .Labio = sqlDr("int_ras_lab").ToString
                            .TipoLabio = sqlDr("int_ras_tip_lab").ToString
                            .Tronco = sqlDr("int_ras_tro").ToString
                            .Complexion = sqlDr("int_ras_com").ToString
                            .Talla = sqlDr("int_ras_tal").ToString
                            .Peso = sqlDr("int_ras_pes").ToString
                            .Obs = sqlDr("int_ras_obs").ToString
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
#Region "Grabar"
        'cambiar por entity
        Public Function Grabar2(ent As Entity.Registro.InternoRasgo) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If ent.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant2"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant2"
            End If

            intValue = Data.Registro.InternoRasgo.Grabar2(strAccion, strOpcion, ent)

            Return intValue

        End Function


      
        Public Function Grabar_LM(ent As Entity.Registro.InternoRasgo) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If ent.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_LM"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_LM"
            End If

            intValue = Data.Registro.InternoRasgo.Grabar_LM(strAccion, strOpcion, ent)

            Return intValue

        End Function

        Public Function Grabar(ByVal Codigo As Integer, _
        ByVal InternoID As Integer, ByVal Raza As Integer, _
        ByVal CabelloForma As Integer, _
        ByVal CabelloColor As Integer, _
        ByVal Calvicie As Integer, _
        ByVal Menton As Integer, _
        ByVal Frente As Integer, _
        ByVal CaraForma As Integer, _
        ByVal LineaInsercion As Integer, _
        ByVal FormaOjo As Integer, _
        ByVal Iris As Integer, _
        ByVal Cejas As Integer, _
        ByVal AnomaliaOjo As Integer, _
        ByVal Oreja As Integer, _
        ByVal NarizForma As Integer, _
        ByVal TipoNariz As Integer, _
        ByVal Boca As Integer, _
        ByVal Labio As Integer, _
        ByVal TipoLabio As Integer, _
        ByVal Tronco As Integer, _
        ByVal Complexion As Integer, _
        ByVal Talla As Single, _
        ByVal Peso As Single, _
        ByVal Obs As String, IDRegion As Integer, IDPenal As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.InternoRasgo.Grabar(strAccion, strOpcion, Codigo, _
            InternoID, Raza, _
            CabelloForma, _
            CabelloColor, _
            Calvicie, _
            Menton, _
            Frente, _
            CaraForma, _
            LineaInsercion, _
            FormaOjo, _
            Iris, _
            Cejas, _
            AnomaliaOjo, _
            Oreja, _
            NarizForma, _
            TipoNariz, _
            Boca, _
            Labio, _
            TipoLabio, _
            Tronco, _
            Complexion, _
            Talla, _
            Peso, _
            Obs, _
            IDRegion, _
            IDPenal, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue

        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.InternoRasgo.Eliminar(strAccion, strOpcion, Codigo, Usuario)
            Return intValue
        End Function
#End Region
    End Class
End Namespace