Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoRasgo
        Private Shared strNameProcedure As String = "UP_INT_InternoRasgo"
#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, _
        ByVal Codigo As Integer, ByVal InternoID As Integer) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ras_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                        

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intValue = .Parameters("@variable_out").Value
                            Return intValue
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, EntRas As Entity.Registro.InternoRasgo) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_ras_id", SqlDbType.Int)).Value = EntRas.Codigo
                    .Parameters.Add(New SqlParameter("@int_ras_raz", SqlDbType.Int)).Value = EntRas.Raza
                    .Parameters.Add(New SqlParameter("@int_ras_cab_for", SqlDbType.Int)).Value = EntRas.CabelloForma
                    .Parameters.Add(New SqlParameter("@int_ras_cab_col", SqlDbType.Int)).Value = EntRas.CabelloColor
                    .Parameters.Add(New SqlParameter("@int_ras_cal", SqlDbType.Int)).Value = EntRas.Calvicie
                    .Parameters.Add(New SqlParameter("@int_ras_men", SqlDbType.Int)).Value = EntRas.Menton
                    .Parameters.Add(New SqlParameter("@int_ras_fre", SqlDbType.Int)).Value = EntRas.Frente
                    .Parameters.Add(New SqlParameter("@int_ras_car_for", SqlDbType.Int)).Value = EntRas.CaraForma
                    .Parameters.Add(New SqlParameter("@int_ras_lin_ins", SqlDbType.Int)).Value = EntRas.LineaInsercion
                    .Parameters.Add(New SqlParameter("@int_ras_for_ojo", SqlDbType.Int)).Value = EntRas.FormaOjo
                    .Parameters.Add(New SqlParameter("@int_ras_iri", SqlDbType.Int)).Value = EntRas.Iris
                    .Parameters.Add(New SqlParameter("@int_ras_cej", SqlDbType.Int)).Value = EntRas.Cejas
                    .Parameters.Add(New SqlParameter("@int_ras_ano_ojo", SqlDbType.Int)).Value = EntRas.AnomaliaOjo
                    .Parameters.Add(New SqlParameter("@int_ras_ore", SqlDbType.Int)).Value = EntRas.Oreja
                    .Parameters.Add(New SqlParameter("@int_ras_nar_for", SqlDbType.Int)).Value = EntRas.NarizForma
                    .Parameters.Add(New SqlParameter("@int_ras_tip_nar", SqlDbType.Int)).Value = EntRas.TipoNariz
                    .Parameters.Add(New SqlParameter("@int_ras_boc", SqlDbType.Int)).Value = EntRas.Boca
                    .Parameters.Add(New SqlParameter("@int_ras_lab", SqlDbType.Int)).Value = EntRas.Labio
                    .Parameters.Add(New SqlParameter("@int_ras_tip_lab", SqlDbType.Int)).Value = EntRas.TipoLabio
                    .Parameters.Add(New SqlParameter("@int_ras_tro", SqlDbType.Int)).Value = EntRas.Tronco
                    .Parameters.Add(New SqlParameter("@int_ras_com", SqlDbType.Int)).Value = EntRas.Complexion
                    .Parameters.Add(New SqlParameter("@int_ras_tal", SqlDbType.Real)).Value = EntRas.Talla
                    .Parameters.Add(New SqlParameter("@int_ras_pes", SqlDbType.Real)).Value = EntRas.Peso
                    .Parameters.Add(New SqlParameter("@int_ras_obs", SqlDbType.VarChar, 500)).Value = EntRas.Obs
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntRas.InternoId
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntRas.InternoIngresoId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, EntRas As Entity.Registro.InternoRasgo) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_ras_id", SqlDbType.Int)).Value = EntRas.Codigo
                    .Parameters.Add(New SqlParameter("@int_ras_raz", SqlDbType.Int)).Value = EntRas.Raza
                    .Parameters.Add(New SqlParameter("@int_ras_cab_for", SqlDbType.Int)).Value = EntRas.CabelloForma
                    .Parameters.Add(New SqlParameter("@int_ras_cab_col", SqlDbType.Int)).Value = EntRas.CabelloColor
                    .Parameters.Add(New SqlParameter("@int_ras_cal", SqlDbType.Int)).Value = EntRas.Calvicie
                    .Parameters.Add(New SqlParameter("@int_ras_men", SqlDbType.Int)).Value = EntRas.Menton
                    .Parameters.Add(New SqlParameter("@int_ras_fre", SqlDbType.Int)).Value = EntRas.Frente
                    .Parameters.Add(New SqlParameter("@int_ras_car_for", SqlDbType.Int)).Value = EntRas.CaraForma
                    .Parameters.Add(New SqlParameter("@int_ras_lin_ins", SqlDbType.Int)).Value = EntRas.LineaInsercion
                    .Parameters.Add(New SqlParameter("@int_ras_for_ojo", SqlDbType.Int)).Value = EntRas.FormaOjo
                    .Parameters.Add(New SqlParameter("@int_ras_iri", SqlDbType.Int)).Value = EntRas.Iris
                    .Parameters.Add(New SqlParameter("@int_ras_cej", SqlDbType.Int)).Value = EntRas.Cejas
                    .Parameters.Add(New SqlParameter("@int_ras_ano_ojo", SqlDbType.Int)).Value = EntRas.AnomaliaOjo
                    .Parameters.Add(New SqlParameter("@int_ras_ore", SqlDbType.Int)).Value = EntRas.Oreja
                    .Parameters.Add(New SqlParameter("@int_ras_nar_for", SqlDbType.Int)).Value = EntRas.NarizForma
                    .Parameters.Add(New SqlParameter("@int_ras_tip_nar", SqlDbType.Int)).Value = EntRas.TipoNariz
                    .Parameters.Add(New SqlParameter("@int_ras_boc", SqlDbType.Int)).Value = EntRas.Boca
                    .Parameters.Add(New SqlParameter("@int_ras_lab", SqlDbType.Int)).Value = EntRas.Labio
                    .Parameters.Add(New SqlParameter("@int_ras_tip_lab", SqlDbType.Int)).Value = EntRas.TipoLabio
                    .Parameters.Add(New SqlParameter("@int_ras_tro", SqlDbType.Int)).Value = EntRas.Tronco
                    .Parameters.Add(New SqlParameter("@int_ras_com", SqlDbType.Int)).Value = EntRas.Complexion
                    .Parameters.Add(New SqlParameter("@int_ras_tal", SqlDbType.Real)).Value = EntRas.Talla
                    .Parameters.Add(New SqlParameter("@int_ras_pes", SqlDbType.Real)).Value = EntRas.Peso
                    .Parameters.Add(New SqlParameter("@int_ras_obs", SqlDbType.VarChar, 500)).Value = EntRas.Obs
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntRas.InternoId
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntRas.InternoIngresoId
                    .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = EntRas.SedeRowId
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = EntRas.IngresoInpeId

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
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
        ) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_ras_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@int_ras_raz", SqlDbType.Int)).Value = Raza
                    .Parameters.Add(New SqlParameter("@int_ras_cab_for", SqlDbType.Int)).Value = CabelloForma
                    .Parameters.Add(New SqlParameter("@int_ras_cab_col", SqlDbType.Int)).Value = CabelloColor
                    .Parameters.Add(New SqlParameter("@int_ras_cal", SqlDbType.Int)).Value = Calvicie
                    .Parameters.Add(New SqlParameter("@int_ras_men", SqlDbType.Int)).Value = Menton
                    .Parameters.Add(New SqlParameter("@int_ras_fre", SqlDbType.Int)).Value = Frente
                    .Parameters.Add(New SqlParameter("@int_ras_car_for", SqlDbType.Int)).Value = CaraForma
                    .Parameters.Add(New SqlParameter("@int_ras_lin_ins", SqlDbType.Int)).Value = LineaInsercion
                    .Parameters.Add(New SqlParameter("@int_ras_for_ojo", SqlDbType.Int)).Value = FormaOjo
                    .Parameters.Add(New SqlParameter("@int_ras_iri", SqlDbType.Int)).Value = Iris
                    .Parameters.Add(New SqlParameter("@int_ras_cej", SqlDbType.Int)).Value = Cejas
                    .Parameters.Add(New SqlParameter("@int_ras_ano_ojo", SqlDbType.Int)).Value = AnomaliaOjo
                    .Parameters.Add(New SqlParameter("@int_ras_ore", SqlDbType.Int)).Value = Oreja
                    .Parameters.Add(New SqlParameter("@int_ras_nar_for", SqlDbType.Int)).Value = NarizForma
                    .Parameters.Add(New SqlParameter("@int_ras_tip_nar", SqlDbType.Int)).Value = TipoNariz
                    .Parameters.Add(New SqlParameter("@int_ras_boc", SqlDbType.Int)).Value = Boca
                    .Parameters.Add(New SqlParameter("@int_ras_lab", SqlDbType.Int)).Value = Labio
                    .Parameters.Add(New SqlParameter("@int_ras_tip_lab", SqlDbType.Int)).Value = TipoLabio
                    .Parameters.Add(New SqlParameter("@int_ras_tro", SqlDbType.Int)).Value = Tronco
                    .Parameters.Add(New SqlParameter("@int_ras_com", SqlDbType.Int)).Value = Complexion
                    .Parameters.Add(New SqlParameter("@int_ras_tal", SqlDbType.Real)).Value = Talla
                    .Parameters.Add(New SqlParameter("@int_ras_pes", SqlDbType.Real)).Value = Peso
                    .Parameters.Add(New SqlParameter("@int_ras_obs", SqlDbType.VarChar, 500)).Value = Obs
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

#End Region

#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
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
        ByVal Obs As String, _
        IDRegion As Integer, IDPenal As Integer, ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ras_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@int_ras_raz", SqlDbType.Int)).Value = Raza
                            .Parameters.Add(New SqlParameter("@int_ras_cab_for", SqlDbType.Int)).Value = CabelloForma
                            .Parameters.Add(New SqlParameter("@int_ras_cab_col", SqlDbType.Int)).Value = CabelloColor
                            .Parameters.Add(New SqlParameter("@int_ras_cal", SqlDbType.Int)).Value = Calvicie
                            .Parameters.Add(New SqlParameter("@int_ras_men", SqlDbType.Int)).Value = Menton
                            .Parameters.Add(New SqlParameter("@int_ras_fre", SqlDbType.Int)).Value = Frente
                            .Parameters.Add(New SqlParameter("@int_ras_car_for", SqlDbType.Int)).Value = CaraForma
                            .Parameters.Add(New SqlParameter("@int_ras_lin_ins", SqlDbType.Int)).Value = LineaInsercion
                            .Parameters.Add(New SqlParameter("@int_ras_for_ojo", SqlDbType.Int)).Value = FormaOjo
                            .Parameters.Add(New SqlParameter("@int_ras_iri", SqlDbType.Int)).Value = Iris
                            .Parameters.Add(New SqlParameter("@int_ras_cej", SqlDbType.Int)).Value = Cejas
                            .Parameters.Add(New SqlParameter("@int_ras_ano_ojo", SqlDbType.Int)).Value = AnomaliaOjo
                            .Parameters.Add(New SqlParameter("@int_ras_ore", SqlDbType.Int)).Value = Oreja
                            .Parameters.Add(New SqlParameter("@int_ras_nar_for", SqlDbType.Int)).Value = NarizForma
                            .Parameters.Add(New SqlParameter("@int_ras_tip_nar", SqlDbType.Int)).Value = TipoNariz
                            .Parameters.Add(New SqlParameter("@int_ras_boc", SqlDbType.Int)).Value = Boca
                            .Parameters.Add(New SqlParameter("@int_ras_lab", SqlDbType.Int)).Value = Labio
                            .Parameters.Add(New SqlParameter("@int_ras_tip_lab", SqlDbType.Int)).Value = TipoLabio
                            .Parameters.Add(New SqlParameter("@int_ras_tro", SqlDbType.Int)).Value = Tronco
                            .Parameters.Add(New SqlParameter("@int_ras_com", SqlDbType.Int)).Value = Complexion
                            .Parameters.Add(New SqlParameter("@int_ras_tal", SqlDbType.Real)).Value = Talla
                            .Parameters.Add(New SqlParameter("@int_ras_pes", SqlDbType.Real)).Value = Peso
                            .Parameters.Add(New SqlParameter("@int_ras_obs", SqlDbType.VarChar, 500)).Value = Obs

                            .Parameters.Add(New SqlParameter("@region", SqlDbType.Int)).Value = IDRegion
                            .Parameters.Add(New SqlParameter("@penal", SqlDbType.Int)).Value = IDPenal

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function

        Public Shared Function Grabar2(ByVal accion As String, ByVal opcion As String, ent As Entity.Registro.InternoRasgo) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ras_id", SqlDbType.Int)).Value = ent.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = ent.InternoId
                            .Parameters.Add(New SqlParameter("@int_ras_raz", SqlDbType.Int)).Value = ent.Raza
                            .Parameters.Add(New SqlParameter("@int_ras_cab_for", SqlDbType.Int)).Value = ent.CabelloForma
                            .Parameters.Add(New SqlParameter("@int_ras_cab_col", SqlDbType.Int)).Value = ent.CabelloColor
                            .Parameters.Add(New SqlParameter("@int_ras_cal", SqlDbType.Int)).Value = ent.Calvicie
                            .Parameters.Add(New SqlParameter("@int_ras_men", SqlDbType.Int)).Value = ent.Menton
                            .Parameters.Add(New SqlParameter("@int_ras_fre", SqlDbType.Int)).Value = ent.Frente
                            .Parameters.Add(New SqlParameter("@int_ras_car_for", SqlDbType.Int)).Value = ent.CaraForma
                            .Parameters.Add(New SqlParameter("@int_ras_lin_ins", SqlDbType.Int)).Value = ent.LineaInsercion
                            .Parameters.Add(New SqlParameter("@int_ras_for_ojo", SqlDbType.Int)).Value = ent.FormaOjo
                            .Parameters.Add(New SqlParameter("@int_ras_iri", SqlDbType.Int)).Value = ent.Iris
                            .Parameters.Add(New SqlParameter("@int_ras_cej", SqlDbType.Int)).Value = ent.Cejas
                            .Parameters.Add(New SqlParameter("@int_ras_ano_ojo", SqlDbType.Int)).Value = ent.AnomaliaOjo
                            .Parameters.Add(New SqlParameter("@int_ras_ore", SqlDbType.Int)).Value = ent.Oreja
                            .Parameters.Add(New SqlParameter("@int_ras_nar_for", SqlDbType.Int)).Value = ent.NarizForma
                            .Parameters.Add(New SqlParameter("@int_ras_tip_nar", SqlDbType.Int)).Value = ent.TipoNariz
                            .Parameters.Add(New SqlParameter("@int_ras_boc", SqlDbType.Int)).Value = ent.Boca
                            .Parameters.Add(New SqlParameter("@int_ras_lab", SqlDbType.Int)).Value = ent.Labio
                            .Parameters.Add(New SqlParameter("@int_ras_tip_lab", SqlDbType.Int)).Value = ent.TipoLabio
                            .Parameters.Add(New SqlParameter("@int_ras_tro", SqlDbType.Int)).Value = ent.Tronco
                            .Parameters.Add(New SqlParameter("@int_ras_com", SqlDbType.Int)).Value = ent.Complexion
                            .Parameters.Add(New SqlParameter("@int_ras_tal", SqlDbType.Real)).Value = ent.Talla
                            .Parameters.Add(New SqlParameter("@int_ras_pes", SqlDbType.Real)).Value = ent.Peso
                            .Parameters.Add(New SqlParameter("@int_ras_obs", SqlDbType.VarChar, 500)).Value = ent.Obs
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = ent.InternoIngresoId

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function


        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, ent As Entity.Registro.InternoRasgo) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ras_id", SqlDbType.Int)).Value = ent.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = ent.InternoId
                            .Parameters.Add(New SqlParameter("@int_ras_raz", SqlDbType.Int)).Value = ent.Raza
                            .Parameters.Add(New SqlParameter("@int_ras_cab_for", SqlDbType.Int)).Value = ent.CabelloForma
                            .Parameters.Add(New SqlParameter("@int_ras_cab_col", SqlDbType.Int)).Value = ent.CabelloColor
                            .Parameters.Add(New SqlParameter("@int_ras_cal", SqlDbType.Int)).Value = ent.Calvicie
                            .Parameters.Add(New SqlParameter("@int_ras_men", SqlDbType.Int)).Value = ent.Menton
                            .Parameters.Add(New SqlParameter("@int_ras_fre", SqlDbType.Int)).Value = ent.Frente
                            .Parameters.Add(New SqlParameter("@int_ras_car_for", SqlDbType.Int)).Value = ent.CaraForma
                            .Parameters.Add(New SqlParameter("@int_ras_lin_ins", SqlDbType.Int)).Value = ent.LineaInsercion
                            .Parameters.Add(New SqlParameter("@int_ras_for_ojo", SqlDbType.Int)).Value = ent.FormaOjo
                            .Parameters.Add(New SqlParameter("@int_ras_iri", SqlDbType.Int)).Value = ent.Iris
                            .Parameters.Add(New SqlParameter("@int_ras_cej", SqlDbType.Int)).Value = ent.Cejas
                            .Parameters.Add(New SqlParameter("@int_ras_ano_ojo", SqlDbType.Int)).Value = ent.AnomaliaOjo
                            .Parameters.Add(New SqlParameter("@int_ras_ore", SqlDbType.Int)).Value = ent.Oreja
                            .Parameters.Add(New SqlParameter("@int_ras_nar_for", SqlDbType.Int)).Value = ent.NarizForma
                            .Parameters.Add(New SqlParameter("@int_ras_tip_nar", SqlDbType.Int)).Value = ent.TipoNariz
                            .Parameters.Add(New SqlParameter("@int_ras_boc", SqlDbType.Int)).Value = ent.Boca
                            .Parameters.Add(New SqlParameter("@int_ras_lab", SqlDbType.Int)).Value = ent.Labio
                            .Parameters.Add(New SqlParameter("@int_ras_tip_lab", SqlDbType.Int)).Value = ent.TipoLabio
                            .Parameters.Add(New SqlParameter("@int_ras_tro", SqlDbType.Int)).Value = ent.Tronco
                            .Parameters.Add(New SqlParameter("@int_ras_com", SqlDbType.Int)).Value = ent.Complexion
                            .Parameters.Add(New SqlParameter("@int_ras_tal", SqlDbType.Real)).Value = ent.Talla
                            .Parameters.Add(New SqlParameter("@int_ras_pes", SqlDbType.Real)).Value = ent.Peso
                            .Parameters.Add(New SqlParameter("@int_ras_obs", SqlDbType.VarChar, 500)).Value = ent.Obs
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = ent.InternoIngresoId
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = ent.SedeRowId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = ent.IngresoInpeId

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
#End Region
        
#Region "Eliminar"
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ras_id", SqlDbType.Int)).Value = Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
#End Region

    End Class
End Namespace