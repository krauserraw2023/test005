
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Namespace Tratamiento.TallerAsistencia
    Public Class MarcacionAsistenciaEquipo
        ''' <summary>
        ''' Importar marcaciones desde la tabla t_lg201810 del biometrico hacia la tabla intermedia tra_int_marcacionasistencia_mov
        ''' </summary>
        ''' <param name="outSms"></param>
        ''' <returns></returns>
        Public Function ImportMarcacionDesdeBdBiometricoATmp(ByRef outSms As String) As Boolean
            Dim tmpDT As DateTime
            Dim maxFecHorMarca As DateTime
            Dim strFecHorMax As String = ""
            Dim tbl As DataTable
            Dim SqlTmp As String = ""
            Dim anio As Integer = 0
            Dim numMes As Integer = 0
            Dim mySql As String = ""

            If TestConexionMariaBD(outSms) = False Then
                Return False
            End If

            Try
                SqlTmp = "select top 1 fec_hor_marca from tra_Int_MarcacionAsistencia_mov order by fec_hor_marca desc"
                tbl = Data.Tratamiento.TallerAsistencia.MarcacionAsistenciaEquipo.ListarDataTable(SqlTmp, outSms)
            Catch ex As Exception
                Return False
            End Try

            Try
                tmpDT = tbl.Rows(0).Item("fec_hor_marca")
                maxFecHorMarca = tmpDT.AddMinutes(-10) 'Para incluir marcaciones de dispositivos con hora no sincronizada (margen 10 minutos).
            Catch ex As Exception
                maxFecHorMarca = New Date(2015, 1, 1) 'Para traer todos los registros
            End Try

            strFecHorMax = maxFecHorMarca.Year & "-" & maxFecHorMarca.Month.ToString().PadLeft(2, "0") & "-" & maxFecHorMarca.Day.ToString().PadLeft(2, "0") & " " & maxFecHorMarca.Hour.ToString().PadLeft(2, "0") & ":" & maxFecHorMarca.Minute.ToString().PadLeft(2, "0") & ":" & maxFecHorMarca.Second.ToString().PadLeft(2, "0")

            Dim tblMarcaMDB As DataTable

            If maxFecHorMarca.Year = 2015 Then

                For i As Integer = maxFecHorMarca.Year To Now.Year
                    For m As Integer = 1 To 12
                        Try
                            GetTableMariaDB("select * from biostar2_ac.t_lg" & i & m.ToString().PadLeft(2, "0") & " limit 1", "")
                        Catch ex As Exception
                            Continue For
                        End Try

                        mySql = "Select mr.EVTLGUID, mr.USRID kf_int_id,mr.USRGRUID kf_tal_id, 
	                                tall.NM nom_tall, u.NM ape_nom_int,
	                                DATE(FROM_UNIXTIME(mr.DEVDT)) fec_mar_asi,TIME(FROM_UNIXTIME(mr.DEVDT)) hor_mar_asi, 
	                                mr.DEVUID dis_bio_id,disp.NM nom_dis_bio, FROM_UNIXTIME(mr.DEVDT) fec_tran_mar, 
	                                mr.evt evento_id,FROM_UNIXTIME(mr.DEVDT) fec_hor_marca  
                                FROM biostar2_ac.t_lg" & i & m.ToString().PadLeft(2, "0") & " mr
                                inner join biostar2_ac.t_usrgr tall on tall.USRGRUID = mr.USRGRUID
                                inner join biostar2_ac.t_usr u on u.USRID= mr.USRID
                                inner join biostar2_ac.t_dev disp on disp.DEVID = mr.DEVUID
                                where (mr.evt = 4867 or mr.evt = 4102) and FROM_UNIXTIME(mr.DEVDT) > cast( '" & strFecHorMax & "' as datetime)"

                        tblMarcaMDB = GetTableMariaDB(mySql, outSms)

                        If InsertarMarcacion(tblMarcaMDB, outSms) = False Then
                            Return False
                        End If
                    Next
                Next

            Else

                For nAnio As Integer = maxFecHorMarca.Year To Now.Year
                    For nMes As Integer = 1 To 12
                        Dim sqlTab As String = ""

                        Try
                            sqlTab = "select * FROM biostar2_ac.t_lg" & nAnio & nMes.ToString().PadLeft(2, "0") & " limit 1"
                            GetTableMariaDB(sqlTab, "")
                        Catch ex As Exception
                            Continue For
                        End Try

                        mySql = "Select mr.EVTLGUID, mr.USRID kf_int_id,mr.USRGRUID kf_tal_id, 
	                                tall.NM nom_tall, u.NM ape_nom_int,
	                                DATE(FROM_UNIXTIME(mr.DEVDT)) fec_mar_asi,TIME(FROM_UNIXTIME(mr.DEVDT)) hor_mar_asi, 
	                                mr.DEVUID dis_bio_id,disp.NM nom_dis_bio, FROM_UNIXTIME(mr.DEVDT) fec_tran_mar, 
	                                mr.evt evento_id,FROM_UNIXTIME(mr.DEVDT) fec_hor_marca
                                FROM biostar2_ac.t_lg" & nAnio & nMes.ToString().PadLeft(2, "0") & " mr 
                                inner join biostar2_ac.t_usrgr tall on tall.USRGRUID = mr.USRGRUID
                                inner join biostar2_ac.t_usr u on u.USRID= mr.USRID
                                inner join biostar2_ac.t_dev disp on disp.DEVID = mr.DEVUID
                                where (mr.evt = 4867 or mr.evt = 4102) and FROM_UNIXTIME(mr.DEVDT) > cast( '" & strFecHorMax & "' as datetime)"

                        tblMarcaMDB = GetTableMariaDB(mySql, outSms)

                        If Not tblMarcaMDB Is Nothing AndAlso tblMarcaMDB.Rows.Count > 0 Then
                            If InsertarMarcacion(tblMarcaMDB, outSms) = False Then
                                Return False
                            End If
                        End If
                    Next
                Next

            End If

            Return True
        End Function
        Public Function ImportarMarcacionDesdeTmp(RegId As Integer, penId As Integer, ByRef outSms As String) As Boolean
            Dim dt As DataTable
            Dim tblIntFechas As DataTable 'internos por fecha

            dt = Data.Tratamiento.TallerAsistencia.MarcacionAsistenciaEquipo.Listar(RegId, penId)

            tblIntFechas = dt.DefaultView.ToTable(True, "fec_mar_asi", "kf_int_id") 'seleccionar las fechas

            ''verificar si existe taller sin vicular.
            'For Each f As DataRow In dt.Rows 'COMENTADO HASTA LA PROXIMA VERSION
            '    If f.Item("pk_tra_tal_id") = -1 Then
            '        Legolas.Configuration.Aplication.MessageBox.Exclamation("Operación cancelada, falta vincular el Id=" & f.Item("kf_tal_id") & " " & f.Item("nom_tall").ToString.ToUpper & " del taller de equipo biométrico con la tabla maestra de talleres.")
            '        Return False
            '    End If
            'Next

            For Each f As DataRow In tblIntFechas.Rows

                Dim marcaciones() As DataRow 'por fecha de marcacion e interno, 

                marcaciones = dt.Select("fec_mar_asi='" & f.Item("fec_mar_asi") & "' and kf_int_id=" & f.Item("kf_int_id"))

                If marcaciones.Length = 0 Then Continue For

                Dim ent As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                Dim entCol As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
                ent.InternoID = f.Item("kf_int_id")
                ent.Fecha = CDate(f.Item("fec_mar_asi")).ToFileTime
                entCol = (New InternoAsistencia).ListarIngreso(ent)

                If entCol.Count > 0 Then
                    ent = entCol.Item(0)
                    Dim _val As TimeSpan
                    _val = HoraMaxima(marcaciones)
                    If ent.HoraEntrada <> _val.ToString Then
                        ent.HoraSalida = _val.ToString
                    End If
                Else
                    If marcaciones.Length = 1 Then 'una sola marcacion
                        ent.HoraEntrada = HoraMinima(marcaciones).ToString
                    Else
                        ent.HoraEntrada = HoraMinima(marcaciones).ToString
                        ent.HoraSalida = HoraMaxima(marcaciones).ToString
                    End If
                End If

                ent.CodigoTaller = marcaciones(0).Item("pk_tra_tal_id")
                ent.EstadoID = 1
                ent.PenalID = penId
                ent.RegionID = RegId

                Dim id As Integer = -1

                Try
                    id = (New InternoAsistencia).Grabar(ent, "")
                Catch ex As Exception
                    outSms = ex.Message
                    id = -1
                End Try

                If id = -1 Then Return False

            Next

            '------- setear los registros de marcaciones del biometrico
            For Each f As DataRow In dt.Rows
                Dim sql As String = ""
                Dim idTmp As Integer = -1

                sql = "update tra_Int_MarcacionAsistencia_mov set b_reg_exp=1 where pk_mar_asi_id = " & f.Item("pk_mar_asi_id")
                idTmp = Data.Tratamiento.TallerAsistencia.MarcacionAsistenciaEquipo.EjecutarSentenciaSQL(sql)

            Next

            Return True
        End Function

        'Public Function ImportarMarcacionDesdeEquipo(RegId As Integer, penId As Integer) As Boolean
        '    Dim dt As DataTable
        '    Dim tblIntFechas As DataTable 'internos por fecha

        '    dt = Data.Tratamiento.TallerAsistencia.MarcacionAsistenciaEquipo.Listar()

        '    tblIntFechas = dt.DefaultView.ToTable(True, "fec_mar_asi", "kf_int_id") 'seleccionar las fechas

        '    ''verificar si existe taller sin vicular.
        '    For Each f As DataRow In dt.Rows
        '        If f.Item("pk_tra_tal_id") = -1 Then
        '            Legolas.Configuration.Aplication.MessageBox.Exclamation("Operación cancelada, falta vincular el Id=" & f.Item("kf_tal_id") & " " & f.Item("nom_tall").ToString.ToUpper & " del taller de equipo biométrico con la tabla maestra de talleres.")
        '            Return False
        '        End If
        '    Next

        '    For Each f As DataRow In tblIntFechas.Rows

        '        Dim horaIngreso As TimeSpan = Nothing
        '        Dim horaSalida As TimeSpan = Nothing
        '        Dim marcaciones() As DataRow 'por fecha de marcacion e interno, 

        '        marcaciones = dt.Select("fec_mar_asi='" & f.Item("fec_mar_asi") & "' and kf_int_id=" & f.Item("kf_int_id"))

        '        If marcaciones.Length = 0 Then Continue For

        '        If marcaciones.Length = 1 Then 'una sola marcacion
        '            horaIngreso = marcaciones(0).Item("hor_mar_asi")
        '            horaSalida = horaIngreso
        '        Else
        '            horaIngreso = HoraMinima(marcaciones)
        '            horaSalida = HoraMaxima(marcaciones)
        '        End If

        '        Dim ent As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
        '        Dim entCol As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
        '        ent.InternoID = f.Item("kf_int_id")
        '        ent.Fecha = CDate(f.Item("fec_mar_asi")).ToFileTime
        '        entCol = (New InternoAsistencia).ListarIngreso(ent)

        '        If entCol.Count > 0 Then
        '            ent = entCol.Item(0)

        '            If ent.HoraEntrada.Length > 0 Then
        '                ent.HoraSalida = If(horaSalida = Nothing, "", horaSalida.ToString)
        '            Else
        '                ent.HoraEntrada = horaIngreso.ToString
        '                ent.HoraSalida = If(horaSalida = Nothing, "", horaSalida.ToString)
        '            End If
        '        Else
        '            ent.HoraEntrada = horaIngreso.ToString
        '            ent.HoraSalida = If(horaSalida = Nothing, "", horaSalida.ToString)
        '        End If

        '        ent.CodigoTaller = marcaciones(0).Item("pk_tra_tal_id") 'f.Item("pk_tra_tal_id")
        '        ent.EstadoID = 1
        '        ent.PenalID = penId
        '        ent.RegionID = regId

        '        Dim id As Integer = -1
        '        Dim sms As String = ""

        '        Try
        '            id = (New InternoAsistencia).Grabar(ent)
        '        Catch ex As Exception
        '            sms = ex.Message
        '        End Try

        '        If id = -1 Then
        '            Legolas.Configuration.Aplication.MessageBox.Exclamation("Ocurrio un error en la importación de marcaciones, " & sms)
        '        End If
        '    Next

        '    Return True
        'End Function

        Private Function HoraMaxima(marcaciones() As DataRow) As TimeSpan
            Dim tm As TimeSpan
            tm = marcaciones(0).Item("hor_mar_asi")
            For i As Integer = 0 To marcaciones.Length - 1
                If marcaciones(i).Item("hor_mar_asi") > tm Then
                    tm = marcaciones(i).Item("hor_mar_asi")
                End If
            Next
            Return tm
        End Function
        Private Function HoraMinima(marcaciones() As DataRow) As TimeSpan
            Dim tm As TimeSpan
            tm = marcaciones(0).Item("hor_mar_asi")
            For i As Integer = 0 To marcaciones.Length - 1
                If marcaciones(i).Item("hor_mar_asi") < tm Then
                    tm = marcaciones(i).Item("hor_mar_asi")
                End If
            Next
            Return tm
        End Function

#Region "Acciones"
        Private Function InsertarMarcacion(dt As DataTable, ByRef outSms As String) As Boolean
            Try
                Dim tmpId As Integer = -1

                For Each f As DataRow In dt.Rows
                    Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                        Using sqlCmd As SqlCommand = New SqlCommand("usp_marca_taller", sqlCon)
                            With sqlCmd
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add("@id_marcacion_disp", SqlDbType.Int).Value = f.Item("EVTLGUID")
                                .Parameters.Add("@kf_int_id", SqlDbType.Int).Value = f.Item("kf_int_id")
                                .Parameters.Add("@kf_tal_id", SqlDbType.Int).Value = f.Item("kf_tal_id")
                                .Parameters.Add("@nom_tall", SqlDbType.VarChar, 150).Value = f.Item("nom_tall")
                                .Parameters.Add("@ape_nom_int", SqlDbType.VarChar, 150).Value = f.Item("ape_nom_int")
                                .Parameters.Add("@fec_mar_asi", SqlDbType.Date).Value = f.Item("fec_mar_asi")
                                .Parameters.Add("@hor_mar_asi", SqlDbType.VarChar, 100).Value = Convert.ToDateTime(f.Item("hor_mar_asi").hours & ":" & f.Item("hor_mar_asi").minutes & ":" & f.Item("hor_mar_asi").seconds).ToString("HH:mm:ss")
                                .Parameters.Add("@dis_bio_id", SqlDbType.Int).Value = f.Item("dis_bio_id")
                                .Parameters.Add("@nom_dis_bio", SqlDbType.VarChar, 150).Value = f.Item("nom_dis_bio")
                                .Parameters.Add("@fec_tran_mar", SqlDbType.DateTime).Value = f.Item("fec_tran_mar")
                                .Parameters.Add("@fec_hor_marca", SqlDbType.DateTime).Value = f.Item("fec_hor_marca")
                                sqlCon.Open()

                                tmpId = .ExecuteNonQuery()

                                If tmpId = -1 Then
                                    tmpId = tmpId
                                End If

                            End With
                        End Using
                    End Using
                Next

            Catch ex As Exception
                outSms = ex.Message
                Return False
            End Try

            Return True
        End Function

        Private Function TestConexionMariaBD(ByRef outSms As String) As Boolean
            Dim v As Boolean = True

            Dim dtTabla As DataTable = Nothing
            Dim sqlCon As MySqlConnection = New MySqlConnection(Legolas.LBusiness.Globall.WinApp.ListarString("tra_tall_cn_bd_biostar", -1))
            Try
                sqlCon.Open()
            Catch ex As Exception
                outSms = ex.Message
                v = False
            Finally
                sqlCon.Close()
            End Try
            Return v
        End Function

        Private Function GetTableMariaDB(sql As String, ByRef outSms As String) As DataTable
            Dim dtTabla As DataTable = Nothing
            Dim sqlReader As MySqlDataReader = Nothing
            Dim sqlCon As MySqlConnection = New MySqlConnection(Legolas.LBusiness.Globall.WinApp.ListarString("tra_tall_cn_bd_biostar", -1))
            Dim sqlCmd As MySqlCommand = New MySqlCommand(sql, sqlCon)

            Try
                sqlCon.Open()
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
                dtTabla = Nothing
                dtTabla = New DataTable
                dtTabla.Load(sqlReader)
            Catch ex As Exception
                dtTabla = Nothing
                outSms = ex.Message
            Finally
                sqlCon.Close()
                sqlCmd.Dispose()
                sqlReader.Dispose()
                sqlReader.Close()
                sqlReader = Nothing
            End Try

            Return dtTabla
        End Function
#End Region
    End Class
End Namespace
