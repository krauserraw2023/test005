Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class Movimiento
        Private Shared strNameProcedure As String = "UP_VIS_Movimiento"
#Region "Listar"

        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal VisitanteID As Integer, ByVal NumeroPase As String, _
        ByVal InternoID As Integer, _
        ByVal FechaIngreso As Long, _
        ByVal FechaSalida As Long, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@mov_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = VisitanteID
                            .Parameters.Add(New SqlParameter("@pas_num", SqlDbType.VarChar, 10)).Value = NumeroPase
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@mov_fec_ing", SqlDbType.BigInt)).Value = FechaIngreso
                            .Parameters.Add(New SqlParameter("@mov_fec_sal", SqlDbType.BigInt)).Value = FechaSalida

                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID

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
        Public Shared Function ListarOutput(ByVal accion As String, _
        ByVal opcion As String, ByVal objEntFiltro As Entity.Visita.Movimiento) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@mov_id", SqlDbType.Int)).Value = objEntFiltro.Codigo
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEntFiltro.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEntFiltro.PenalID
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = objEntFiltro.VisitaID
                            .Parameters.Add(New SqlParameter("@pas_num", SqlDbType.VarChar, 10)).Value = objEntFiltro.PaseNumero
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEntFiltro.InternoID
                            .Parameters.Add(New SqlParameter("@mov_fec_ing", SqlDbType.BigInt)).Value = objEntFiltro.FechaIngreso
                            .Parameters.Add(New SqlParameter("@mov_fec_sal", SqlDbType.BigInt)).Value = objEntFiltro.FechaSalida
                            .Parameters.Add(New SqlParameter("@par_id", SqlDbType.SmallInt)).Value = objEntFiltro.ParentescoID
                            .Parameters.Add(New SqlParameter("@par_tip", SqlDbType.SmallInt)).Value = objEntFiltro.ParentescoTipo
                            .Parameters.Add(New SqlParameter("@reg_vis_id", SqlDbType.SmallInt)).Value = objEntFiltro.RegimenVisitaID
                            .Parameters.Add(New SqlParameter("@tip_id", SqlDbType.SmallInt)).Value = objEntFiltro.TipoID

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

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
        ByVal opcion As String, ByVal objEntFiltro As Entity.Visita.Movimiento) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 540
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@mov_id", SqlDbType.Int)).Value = objEntFiltro.Codigo
                    .Parameters.Add(New SqlParameter("@mov_prn_id", SqlDbType.Int)).Value = objEntFiltro.MovimientoPadre
                    '/*visita*/
                    .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = objEntFiltro.VisitaID
                    .Parameters.Add(New SqlParameter("@vis_doc_num", SqlDbType.VarChar, 10)).Value = objEntFiltro.VisitanteNumeroDocumento
                    .Parameters.Add(New SqlParameter("@vis_ape_pat", SqlDbType.VarChar, 50)).Value = objEntFiltro.VisitanteApePaterno
                    .Parameters.Add(New SqlParameter("@vis_ape_mat", SqlDbType.VarChar, 50)).Value = objEntFiltro.VisitanteApeMaterno
                    .Parameters.Add(New SqlParameter("@vis_nom", SqlDbType.VarChar, 50)).Value = objEntFiltro.VisitanteNombres
                    .Parameters.Add(New SqlParameter("@mov_vis_ape_nom", SqlDbType.VarChar, 200)).Value = objEntFiltro.VisitanteApellidosyNombres
                    '/*interno*/
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEntFiltro.InternoID
                    .Parameters.Add(New SqlParameter("@kf_int_id_pj", SqlDbType.Int)).Value = objEntFiltro.IDInternoPJ
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 10)).Value = objEntFiltro.InternoCodigo
                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 10)).Value = objEntFiltro.InternoNumeroDocumento
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 50)).Value = objEntFiltro.InternoApePaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 50)).Value = objEntFiltro.InternoApeMaterno
                    .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 200)).Value = objEntFiltro.InternoApellidos
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 50)).Value = objEntFiltro.InternoNombres
                    .Parameters.Add(New SqlParameter("@mov_int_ape_nom", SqlDbType.VarChar, 200)).Value = objEntFiltro.InternoApellidosyNombres
                    '/*movimiento                    
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = objEntFiltro.FechaInicio
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = objEntFiltro.FechaFin
                    .Parameters.Add(New SqlParameter("@mov_vis_men_cnt", SqlDbType.Int)).Value = objEntFiltro.MenoresCantidad
                    .Parameters.Add(New SqlParameter("@mov_vis_men_tip", SqlDbType.Int)).Value = objEntFiltro.MenoresTipo
                    .Parameters.Add(New SqlParameter("@est_mov", SqlDbType.Int)).Value = objEntFiltro.EstadoID
                    .Parameters.Add(New SqlParameter("@reg_vis_id", SqlDbType.SmallInt)).Value = objEntFiltro.RegimenVisitaID
                    .Parameters.Add(New SqlParameter("@tip_id", SqlDbType.Int)).Value = objEntFiltro.TipoID
                    .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = objEntFiltro.ParentescoID
                    .Parameters.Add(New SqlParameter("@pas_num", SqlDbType.VarChar, 10)).Value = objEntFiltro.PaseNumero

                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEntFiltro.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEntFiltro.PenalID

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
      ByVal opcion As String, ByVal Codigo As Integer, _
      ByVal MovimientoPadres As Integer, _
      ByVal VisitaID As Integer, _
      ByVal VisitaNumDoc As String, ByVal VisitaPaterno As String, _
      ByVal VisitaMaterno As String, ByVal VisitaNombres As String, ByVal VisitaApeNom As String, _
      ByVal InternoID As Integer, ByVal InternoCodigo As String, _
      ByVal InternoNumDoc As String, ByVal InternoPaterno As String, ByVal InternoMaterno As String, _
      ByVal InternoApellidos As String, ByVal InternoNombres As String, ByVal InternoApeNom As String, _
      ByVal FechaInicio As Long, ByVal FechaFin As Long, _
      ByVal EstadoMovimiento As Integer, _
      ByVal TipoVisita As Integer, _
      ByVal MotivoID As Integer, _
      ByVal ParentescoID As Integer, _
      ByVal PaseNumero As String, _
      ByVal MenoresCantidad As Integer, _
      ByVal MenoresTipo As Integer, _
      ByVal PuntoControlID As Integer, _
      ByVal RegionID As Integer, ByVal PenalID As Integer) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@mov_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@mov_prn_id", SqlDbType.Int)).Value = MovimientoPadres
                    '/*visita*/
                    .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = VisitaID
                    .Parameters.Add(New SqlParameter("@vis_doc_num", SqlDbType.VarChar, 10)).Value = VisitaNumDoc
                    .Parameters.Add(New SqlParameter("@vis_ape_pat", SqlDbType.VarChar, 50)).Value = VisitaPaterno
                    .Parameters.Add(New SqlParameter("@vis_ape_mat", SqlDbType.VarChar, 50)).Value = VisitaMaterno
                    .Parameters.Add(New SqlParameter("@vis_nom", SqlDbType.VarChar, 50)).Value = VisitaNombres
                    .Parameters.Add(New SqlParameter("@mov_vis_ape_nom", SqlDbType.VarChar, 200)).Value = VisitaApeNom
                    '/*interno*/
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 10)).Value = InternoCodigo
                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 10)).Value = InternoNumDoc
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 50)).Value = InternoPaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 50)).Value = InternoMaterno
                    .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 200)).Value = InternoApellidos
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 50)).Value = InternoNombres
                    .Parameters.Add(New SqlParameter("@mov_int_ape_nom", SqlDbType.VarChar, 200)).Value = InternoApeNom
                    '/*movimiento
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = FechaInicio
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = FechaFin
                    .Parameters.Add(New SqlParameter("@mov_vis_men_cnt", SqlDbType.Int)).Value = MenoresCantidad
                    .Parameters.Add(New SqlParameter("@mov_vis_men_tip", SqlDbType.Int)).Value = MenoresTipo
                    .Parameters.Add(New SqlParameter("@est_mov", SqlDbType.Int)).Value = EstadoMovimiento
                    .Parameters.Add(New SqlParameter("@tip_id", SqlDbType.Int)).Value = TipoVisita
                    '.Parameters.Add(New SqlParameter("@mot_id", SqlDbType.Int)).Value = MotivoID
                    .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = ParentescoID
                    .Parameters.Add(New SqlParameter("@pas_num", SqlDbType.VarChar, 10)).Value = PaseNumero

                    '.Parameters.Add(New SqlParameter("@pto_id", SqlDbType.Int)).Value = PuntoControlID
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID

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
        ByVal MovimientoPadre As Integer, _
        ByVal PermisoID As Integer, _
        ByVal VisitaID As Integer, ByVal VisitaApeNom As String, _
        ByVal InternoID As Integer, ByVal InternoApeNom As String, _
        ByVal FechaIngreso As Long, _
        ByVal HoraIngreso As String, _
        ByVal FechaSalida As Long, _
        ByVal HoraSalida As String, _
        ByVal EstadoId As Integer, _
        ByVal MenoresCantidad As Integer, _
        ByVal MenoresTipo As Integer, _
        ByVal PabellonID As Integer, ByVal Pabellon As String, _
        ByVal TipoID As Integer, _
        ByVal MotivoID As Integer, _
        ByVal ParentezcoID As Integer, _
        ByVal REgionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal CalendarioDetalleID As Integer, _
        ByVal PaseNumero As String, _
        ByVal PuntoControlID As Integer, _
        ByVal Observacion As String, ByVal Usuario As Integer) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@mov_id", SqlDbType.Int)).Value = Codigo
                            '.Parameters.Add(New SqlParameter("@per_id", SqlDbType.Int)).Value = PermisoID
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = VisitaID
                            .Parameters.Add(New SqlParameter("@mov_vis_ape_nom", SqlDbType.VarChar, 200)).Value = VisitaApeNom
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@mov_int_ape_nom", SqlDbType.VarChar, 200)).Value = InternoApeNom
                            .Parameters.Add(New SqlParameter("@mov_prn_id", SqlDbType.Int)).Value = MovimientoPadre
                            .Parameters.Add(New SqlParameter("@mov_fec_ing", SqlDbType.BigInt)).Value = FechaIngreso
                            .Parameters.Add(New SqlParameter("@mov_hor_ing", SqlDbType.VarChar, 10)).Value = HoraIngreso
                            .Parameters.Add(New SqlParameter("@mov_fec_sal", SqlDbType.BigInt)).Value = FechaSalida
                            .Parameters.Add(New SqlParameter("@mov_hor_sal", SqlDbType.VarChar, 10)).Value = HoraSalida
                            '.Parameters.Add(New SqlParameter("@mov_est_id", SqlDbType.Int)).Value = EstadoId
                            .Parameters.Add(New SqlParameter("@mov_vis_men_cnt", SqlDbType.Int)).Value = MenoresCantidad
                            .Parameters.Add(New SqlParameter("@mov_vis_men_tip", SqlDbType.Int)).Value = MenoresTipo
                            .Parameters.Add(New SqlParameter("@pab_id", SqlDbType.Int)).Value = PabellonID
                            .Parameters.Add(New SqlParameter("@pab_nom", SqlDbType.VarChar, 200)).Value = Pabellon

                            .Parameters.Add(New SqlParameter("@tip_id", SqlDbType.Int)).Value = TipoID

                            '.Parameters.Add(New SqlParameter("@mot_id", SqlDbType.Int)).Value = MotivoID
                            .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = ParentezcoID

                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = REgionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                            .Parameters.Add(New SqlParameter("@cal_det_id", SqlDbType.Int)).Value = CalendarioDetalleID
                            .Parameters.Add(New SqlParameter("@pas_num", SqlDbType.VarChar, 10)).Value = PaseNumero
                            '.Parameters.Add(New SqlParameter("@pto_id", SqlDbType.Int)).Value = PuntoControlID
                            .Parameters.Add(New SqlParameter("@mov_obs", SqlDbType.VarChar, 500)).Value = Observacion

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

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, _
                                      ByVal objEnt As Entity.Visita.Movimiento) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@mov_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                            .Parameters.Add(New SqlParameter("@mov_prn_id", SqlDbType.Int)).Value = objEnt.MovimientoPadre
                            .Parameters.Add(New SqlParameter("@pas_num", SqlDbType.VarChar, 10)).Value = objEnt.PaseNumero
                            '/*visita*/
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = objEnt.VisitaID
                            .Parameters.Add(New SqlParameter("@mov_vis_ape_nom", SqlDbType.VarChar, 200)).Value = objEnt.VisitanteApellidosyNombres
                            .Parameters.Add(New SqlParameter("@f_tip_doc_id_vis", SqlDbType.SmallInt)).Value = objEnt.VisitanteIDTipoDocumento
                            .Parameters.Add(New SqlParameter("@c_mov_vis_num_doc", SqlDbType.VarChar, 50)).Value = objEnt.VisitanteNumeroDocumento
                            .Parameters.Add(New SqlParameter("@n_mov_fec_nac_vis", SqlDbType.BigInt)).Value = objEnt.VisitanteFechaNacimiento
                            '/*interno*/
                            .Parameters.Add(New SqlParameter("@n_mov_tip_int", SqlDbType.SmallInt)).Value = objEnt.TipoInterno
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@kf_int_id_pj", SqlDbType.Int)).Value = objEnt.IDInternoPJ
                            .Parameters.Add(New SqlParameter("@mov_int_ape_nom", SqlDbType.VarChar, 200)).Value = objEnt.InternoApellidosyNombres
                            .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = objEnt.ParentescoID
                            '/************/
                            .Parameters.Add(New SqlParameter("@mov_fec_ing", SqlDbType.BigInt)).Value = objEnt.FechaIngreso
                            .Parameters.Add(New SqlParameter("@mov_hor_ing", SqlDbType.VarChar, 10)).Value = objEnt.HoraIngreso
                            .Parameters.Add(New SqlParameter("@mov_hor_ver", SqlDbType.VarChar, 10)).Value = objEnt.HoraVerificacion
                            .Parameters.Add(New SqlParameter("@mov_fec_sal", SqlDbType.BigInt)).Value = objEnt.FechaSalida
                            .Parameters.Add(New SqlParameter("@mov_hor_sal", SqlDbType.VarChar, 10)).Value = objEnt.HoraSalida
                            .Parameters.Add(New SqlParameter("@mov_vis_men_tip", SqlDbType.Int)).Value = objEnt.MenoresTipo
                            .Parameters.Add(New SqlParameter("@mov_vis_men_cnt", SqlDbType.Int)).Value = objEnt.MenoresCantidad
                            .Parameters.Add(New SqlParameter("@pab_id", SqlDbType.Int)).Value = objEnt.PabellonID
                            .Parameters.Add(New SqlParameter("@pab_nom", SqlDbType.VarChar, 200)).Value = objEnt.PabellonNombre
                            .Parameters.Add(New SqlParameter("@reg_vis_id", SqlDbType.SmallInt)).Value = objEnt.RegimenVisitaID
                            .Parameters.Add(New SqlParameter("@tip_id", SqlDbType.SmallInt)).Value = objEnt.TipoID
                            .Parameters.Add(New SqlParameter("@etp_id", SqlDbType.SmallInt)).Value = objEnt.EtapaID
                            .Parameters.Add(New SqlParameter("@cal_det_id", SqlDbType.Int)).Value = objEnt.CalendarioDetalleID
                            .Parameters.Add(New SqlParameter("@mov_obs", SqlDbType.VarChar, 500)).Value = objEnt.Observacion

                            .Parameters.Add(New SqlParameter("@n_mov_tip_ing_por", SqlDbType.SmallInt)).Value = objEnt.TipoIngresoPor
                            .Parameters.Add(New SqlParameter("@n_mov_num_rec_hue", SqlDbType.SmallInt)).Value = objEnt.NumeroRecaptura
                            .Parameters.Add(New SqlParameter("@n_mov_vis_val_rnc", SqlDbType.SmallInt)).Value = objEnt.VisitanteValidadoReniec

                            .Parameters.Add(New SqlParameter("@f_usu_id_aut_sal", SqlDbType.Int)).Value = objEnt.IDUsuarioAutorizaSalida
                            .Parameters.Add(New SqlParameter("@c_mov_obs_sal", SqlDbType.VarChar, 500)).Value = objEnt.ObservacionSalida
                            .Parameters.Add(New SqlParameter("@n_mov_tip_sal_por", SqlDbType.SmallInt)).Value = objEnt.TipoSalidaPor
                            .Parameters.Add(New SqlParameter("@f_usu_id_aut_sal_hue", SqlDbType.Int)).Value = objEnt.IDUsuarioAutorizaSalidaSinHuella

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = objEnt.Audit_UsuarioID
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

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@mov_id", SqlDbType.Int)).Value = Codigo

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

    End Class
End Namespace