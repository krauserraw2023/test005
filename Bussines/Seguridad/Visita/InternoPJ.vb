Imports System.Data
Imports System.Data.SqlClient
Namespace Visita

    Public Class InternoPJ

        Private objEnt As Entity.Visita.InternoPJ = Nothing
        Private objEntCol As Entity.Visita.InternoPJCol = Nothing
#Region "Validar"
        Private Function ValidarNumeroDocumento(ByVal objEnt As Entity.Visita.InternoPJ) As Boolean

            'validar por numero y tipo documento
            Dim value As Integer = -1

            value = Data.Visita.InternoPJ.ListarOutput("lst", "lst_validar_numero_documento", objEnt)

            Return Not (value > 0)

        End Function
        Private Function TieneMovimiento(intIDVisitante As Integer, intIDRegion As Short, intIDPenal As Short) As Boolean

            'validar si el internopj tiene algun movimiento
            Dim value As Boolean = False

            objEnt = New Entity.Visita.InternoPJ
            With objEnt
                .Codigo = intIDVisitante
                .IDRegion = intIDRegion
                .IDPenal = intIDPenal
            End With

            Dim intNumReg As Integer = 0

            intNumReg = Data.Visita.InternoPJ.ListarOutput("lst", "val_tiene_movimientoPJ", objEnt)

            If intNumReg > 0 Then
                value = True
            End If

            Return value

        End Function
#End Region
#Region "Funciones"
        Public Function InactivarInterno(ByVal InternoID As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_inactivar_interno"

            objEnt = New Entity.Visita.InternoPJ
            With objEnt
                .Codigo = InternoID
            End With

            intValue = Data.Visita.InternoPJ.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function
#End Region
#Region "Listar"
        Public Function Listar(ByVal intCodigo As Integer) As Entity.Visita.InternoPJ

            Dim objEntFiltro As New Entity.Visita.InternoPJ
            With objEntFiltro
                .Codigo = intCodigo
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.InternoPJ.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)

            objEnt = New Entity.Visita.InternoPJ
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("pk_int_pj").ToString
                            .PrimerApellido = sqlDr("c_int_pj_pri_ape").ToString
                            .SegundoApellido = sqlDr("c_int_pj_seg_ape").ToString
                            .PreNombres = sqlDr("c_int_pj_pre_nom").ToString
                            .Sexo = sqlDr("n_int_pj_sex").ToString
                            .FechaNacimiento = sqlDr("n_int_pj_fec_nac").ToString
                            .IDTipoDocumento = sqlDr("kf_tip_doc_id").ToString
                            .TipoDocumento = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("c_int_pj_num_doc").ToString
                            .IDNacionalidad = sqlDr("kf_nac_id").ToString
                            .Nacionalidad = sqlDr("nac_nom").ToString
                            .IDPabellon = sqlDr("kf_pab_id").ToString
                            .Pabellon = sqlDr("pab_nom").ToString
                            .FechaIngreso = sqlDr("n_int_pj_fec_ing").ToString
                            .FechaEgreso = sqlDr("n_int_pj_fec_egr").ToString
                            .Estado = sqlDr("n_int_pj_est").ToString
                            .Observacion = sqlDr("c_int_pj_obs").ToString
                            '/*penal/region*/
                            .IDRegion = sqlDr("reg_id").ToString
                            .IDPenal = sqlDr("pen_id").ToString
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

        Public Function ListarGrilla(ByVal objEntFiltro As Entity.Visita.InternoPJ) As Entity.Visita.InternoPJCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.InternoPJ.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)

            objEntCol = New Entity.Visita.InternoPJCol

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.InternoPJ
                        With objEnt
                            .Codigo = sqlDr("pk_int_pj").ToString
                            .PrimerApellido = sqlDr("c_int_pj_pri_ape").ToString
                            .SegundoApellido = sqlDr("c_int_pj_seg_ape").ToString
                            .PreNombres = sqlDr("c_int_pj_pre_nom").ToString
                            .Sexo = sqlDr("n_int_pj_sex").ToString
                            .IDTipoDocumento = sqlDr("kf_tip_doc_id").ToString
                            .TipoDocumento = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("c_int_pj_num_doc").ToString
                            .IDNacionalidad = sqlDr("kf_nac_id").ToString
                            .Nacionalidad = sqlDr("nac_nom").ToString
                            .IDPabellon = sqlDr("kf_pab_id").ToString
                            .Pabellon = sqlDr("pab_nom").ToString
                            .FechaIngreso = sqlDr("n_int_pj_fec_ing").ToString
                            .FechaEgreso = sqlDr("n_int_pj_fec_egr").ToString
                            .Estado = sqlDr("n_int_pj_est").ToString
                            .Observacion = sqlDr("c_int_pj_obs").ToString
                            '/*penal/region*/
                            .IDRegion = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .IDPenal = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
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

        Public Function Grabar(ByVal objEnt As Entity.Visita.InternoPJ) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If ValidarNumeroDocumento(objEnt) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El numero de documento ya existe en la base de datos")
                Return intValue
            End If

            With objEnt
                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If

            End With

            intValue = Data.Visita.InternoPJ.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function

#End Region
#Region "Eliminar"

        Public Function Eliminar(ByVal intIDVisitante As Integer, intIDRegion As Short, intIDPenal As Short) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant"

            'validar si el interno tiene movimientos
            If TieneMovimiento(intIDVisitante, intIDRegion, intIDPenal) = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El Interno PJ actual no se puede eliminar, debido que tiene registros de movimientos en el modulo de visita")
                Return value
            End If

            value = Data.Visita.InternoPJ.Eliminar(strAccion, strOpcion, intIDVisitante, _
                                                      Legolas.Configuration.Usuario.Codigo)
            Return value
        End Function
#End Region

    End Class

End Namespace