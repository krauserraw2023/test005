Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoFoto
        Private objEnt As Entity.Registro.InternoFoto = Nothing
        Private objEntCol As Entity.Registro.InternoFotoCol = Nothing
        Private objEntRnc As Entity.Registro.InternoReniec = Nothing

#Region "Combo"
        Public Function ComboFecha(ByVal InternoID As Integer, ByVal Todos As Boolean, ByVal NoDeterminado As Boolean, _
        Optional ByVal TituloCombo As String = "") As Entity.Registro.InternoFotoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoFoto.Listar(sqlCon, "lst", "lst_fecha", -1, _
            InternoID, -1, 0)

            Dim strNombre As String = "[Todos]"

            objEntCol = New Entity.Registro.InternoFotoCol
            '/*todos*/
            If Todos = True Then
                objEnt = New Entity.Registro.InternoFoto
                With objEnt
                    .Codigo = -1
                    .Fecha = "[Todos]"
                End With
                objEntCol.Add(objEnt)
            End If

            '/*no determinado*/
            If NoDeterminado = True Then

                If TituloCombo.Length < 1 Then
                    strNombre = "[No Determinado]"
                Else
                    strNombre = TituloCombo
                End If

                objEnt = New Entity.Registro.InternoFoto
                With objEnt
                    .Codigo = -1
                    .Fecha = strNombre
                End With
                objEntCol.Add(objEnt)
            End If

            Try
                objEntCol = New Entity.Registro.InternoFotoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoFoto
                        With objEnt
                            .Codigo = sqlDr("int_fot_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .FotoTipo = sqlDr("int_fot_tip").ToString
                            .Fecha = sqlDr("int_fot_fec").ToString
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
             
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol

        End Function
        
#End Region
#Region "Validar"
        Public Function ValidarFecha(ByVal InternoID As Integer, ByVal Fecha As Long) As Boolean

            Dim blnValue As Boolean = True
            Dim intValue As Integer = -1

            intValue = Data.Registro.InternoFoto.ListarOutput("lst", "lst_validar_fecha", -1, _
            InternoID, -1, Fecha, -1, -1)

            If intValue > 0 Then
                blnValue = False
            End If

            Return blnValue

        End Function

        Public Function ValidarFotoReferenciado(ByVal Codigo As Integer, ByVal Usuario As Integer, ByRef out_msg As String) As Integer

            Dim bssRnc As New Bussines.Registro.InternoReniec
            Dim entRnc As New Entity.Registro.InternoReniec
            entRnc.FotoInterno = Codigo
            Dim accion As String = "lst"
            Dim opcion As String = "lst_fot_val_rnc"
            Dim intValorVal As Integer = Data.Registro.InternoReniec.ListarOutput(accion, opcion, entRnc)

            Return intValorVal

        End Function

        Public Function ValidarFotoReniec(ByVal InternoID As Integer, codigo As Integer) As Integer
            'Pertenece a la version antigua
            Dim intValue As Integer = -1
            intValue = Data.Registro.InternoFoto.ListarOutput("lst", "lst_fot_rnc_val", codigo, InternoID, -1, 0, -1, -1)
            Return intValue
        End Function
#End Region
#Region "Functions"

        Public Function ListarID(ByVal InternoID As Integer, ByVal ImagenTipo As Integer, _
        ByVal Fecha As Long) As Integer

            Dim intValue As Integer = -1

            Select Case ImagenTipo
                Case 1, 2 'ingreso
                    Fecha = -1
            End Select

            intValue = Data.Registro.InternoFoto.ListarOutput("lst", "lst_id", -1, InternoID, ImagenTipo, Fecha, -1, -1)
            Return intValue

        End Function

        Public Shared Function ListarID(ByVal RegionID As Integer, ByVal PenalID As Integer, _
                                        ByVal InternoID As Integer, ByVal Tipo As Integer) As Integer

            Dim value As Integer = -1

            value = Data.Registro.InternoFoto.ListarOutput("lst", "lst_id_condicion", -1, _
                                                           InternoID, Tipo, 0, RegionID, PenalID)

            Return value

        End Function

        Public Function FotoVersionAntigua(ByVal InternoID As Integer, InternoIngresoId As Integer) As Boolean
            'Pertenece a la version antigua
            Dim blnVal As Boolean = False
            Try
                Dim EntIntFot As New Entity.Registro.InternoFoto
                EntIntFot.InternoID = InternoID
                EntIntFot.InternoIngresoId = InternoIngresoId
                Dim intValue As Integer = -1

                intValue = Data.Registro.InternoFoto.ListarOutput("lst", "is_version_antigua_foto", EntIntFot)
                If intValue = 0 Then
                    blnVal = False
                Else
                    blnVal = True
                End If
            Catch ex As Exception
                Return True
            End Try

            Return blnVal

        End Function
        Public Function FotoVersionAntigua_LM(ByVal InternoID As Integer, InternoIngresoId As Integer) As Boolean
            'Pertenece a la version antigua
            Dim blnVal As Boolean = False
            Try
                Dim EntIntFot As New Entity.Registro.InternoFoto
                EntIntFot.InternoID = InternoID
                EntIntFot.InternoIngresoId = InternoIngresoId
                Dim intValue As Integer = -1

                intValue = Data.Registro.InternoFoto.ListarOutput_LM("lst", "is_version_antigua_foto_LM", EntIntFot)
                If intValue = 0 Then
                    blnVal = False
                Else
                    blnVal = True
                End If
            Catch ex As Exception
                Return True
            End Try

            Return blnVal

        End Function

        Public Function ListarIDFotoReciente(ByVal InternoID As Integer) As Integer
            'consulta la tabla foto_interno
            Dim intValue As Integer = -1
            intValue = Data.Registro.InternoFoto.ListarOutput("lst", "lst_id_reciente", -1, InternoID, -1, 0, -1, -1)
            Return intValue

        End Function
        Public Function ListarIDFotoReciente2(ByVal InternoID As Integer) As Integer
            'consulta la tabla foto_interno version5
            Dim intValue As Integer = -1
            intValue = Data.Registro.InternoFoto.ListarOutput("lst", "lst_id_reciente_2", -1, InternoID, -1, 0, -1, -1)
            Return intValue

        End Function

        Public Function ListarIDFotoReciente_LM(ByVal InternoID As Integer) As Integer
            'consulta la tabla foto_interno version lm 
            Dim intValue As Integer = -1
            intValue = Data.Registro.InternoFoto.ListarOutput("lst", "lst_id_reciente_LM", -1, InternoID, -1, 0, -1, -1)
            Return intValue

        End Function

        Public Function listarIDFotoPrincipal(intIDInterno As Integer, intPerfil As Integer,
                                              ByRef strNombreFoto As String, ByRef strPathServer As String) As Integer

            Dim value As Integer = -1
            Dim intIDInternoFoto As Integer = -1

            'If blnVersion5 = True Then
            intIDInternoFoto = ListarIDFotoReciente2(intIDInterno)
            objEnt = Listar_v5(intIDInternoFoto)
            'Else
            '    intIDInternoFoto = ListarIDFotoReciente(intIDInterno)
            '    objEnt = Listar(intIDInternoFoto)
            'End If

            Select Case intPerfil
                Case 1 'perfil izquierdo
                    value = objEnt.PIzquierdoID
                    strNombreFoto = objEnt.PIzquierdoName
                    strPathServer = objEnt.PIzquierdoServerPath

                Case 2 'perfil frontal
                    value = objEnt.PFrenteID
                    strNombreFoto = objEnt.PFrenteName
                    strPathServer = objEnt.PFrenteServerPath

                Case 3 'perfil derecho
                    value = objEnt.PDerechoID
                    strNombreFoto = objEnt.PDerechoName
                    strPathServer = objEnt.PDerechoServerPath

            End Select

            Return value
        End Function
#End Region
#Region "Listar"

        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.InternoFoto

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoFoto.Listar(sqlCon, "lst", "lst_mant", Codigo, -1, -1, 0)
            objEnt = New Entity.Registro.InternoFoto
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_fot_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .FotoTipo = sqlDr("int_fot_tip").ToString

                            .PIzquierdoID = sqlDr("int_fot_per_izq").ToString
                            .PIzquierdoName = sqlDr("per_izq_nom_arc").ToString

                            .PFrenteID = sqlDr("int_fot_per_fre").ToString
                            .PFrenteName = sqlDr("per_fre_nom_arc").ToString

                            .PDerechoID = sqlDr("int_fot_per_der").ToString
                            .PDerechoName = sqlDr("per_der_nom_arc").ToString

                            .Fecha = sqlDr("int_fot_fec").ToString
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
        Public Function Listar_LM(ByVal Codigo As Integer) As Entity.Registro.InternoFoto

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoFoto.Listar(sqlCon, "lst", "lst_mant", Codigo, -1, -1, 0)
            objEnt = New Entity.Registro.InternoFoto
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_fot_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .FotoTipo = sqlDr("int_fot_tip").ToString

                            .PIzquierdoID = sqlDr("int_fot_per_izq").ToString
                            .PIzquierdoName = sqlDr("per_izq_nom_arc").ToString

                            .PFrenteID = sqlDr("int_fot_per_fre").ToString
                            .PFrenteName = sqlDr("per_fre_nom_arc").ToString

                            .PDerechoID = sqlDr("int_fot_per_der").ToString
                            .PDerechoName = sqlDr("per_der_nom_arc").ToString

                            .Fecha = sqlDr("int_fot_fec").ToString
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

        Public Function Listar_v5(ByVal Codigo As Integer) As Entity.Registro.InternoFoto
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoFoto.Listar(sqlCon, "lst", "lst_mant_detalle", Codigo, -1, -1, 0)
            objEnt = New Entity.Registro.InternoFoto
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_fot_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .FotoTipo = sqlDr("int_fot_tip").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .NumIngreso = IIf(Val(sqlDr("int_ing_nro").ToString) = 0, "", sqlDr("int_ing_nro").ToString)

                            .PIzquierdoID = sqlDr("int_fot_per_izq").ToString
                            .PIzquierdoName = sqlDr("per_izq_nom_arc").ToString
                            .PIzquierdoServerPath = sqlDr("per_izq_pth").ToString

                            .PFrenteID = sqlDr("int_fot_per_fre").ToString
                            .PFrenteName = sqlDr("per_fre_nom_arc").ToString
                            .PFrenteServerPath = sqlDr("per_fre_pth").ToString

                            .PDerechoID = sqlDr("int_fot_per_der").ToString
                            .PDerechoName = sqlDr("per_der_nom_arc").ToString
                            .PDerechoServerPath = sqlDr("per_der_pth").ToString

                            .FotoVersionNueva = sqlDr("fot_ver_nue").ToString

                            .Fecha = sqlDr("int_fot_fec").ToString
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

        Public Function ListarGrilla(ByVal Codigo As Integer) As Entity.Registro.InternoFoto
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoFoto.Listar(sqlCon, "lst", "lst_mant_detalle", Codigo, -1, -1, 0)
            objEnt = New Entity.Registro.InternoFoto
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_fot_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .FotoTipo = sqlDr("int_fot_tip").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .NumIngreso = IIf(Val(sqlDr("int_ing_nro").ToString) = 0, "", sqlDr("int_ing_nro").ToString)

                            .PIzquierdoID = sqlDr("int_fot_per_izq").ToString
                            .PIzquierdoName = sqlDr("per_izq_nom_arc").ToString
                            .PIzquierdoServerPath = sqlDr("per_izq_pth").ToString

                            .PFrenteID = sqlDr("int_fot_per_fre").ToString
                            .PFrenteName = sqlDr("per_fre_nom_arc").ToString
                            .PFrenteServerPath = sqlDr("per_fre_pth").ToString

                            .PDerechoID = sqlDr("int_fot_per_der").ToString
                            .PDerechoName = sqlDr("per_der_nom_arc").ToString
                            .PDerechoServerPath = sqlDr("per_der_pth").ToString

                            .FotoVersionNueva = sqlDr("fot_ver_nue").ToString

                            .Fecha = sqlDr("int_fot_fec").ToString
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

        Public Function ListarGrilla_LM(ByVal Codigo As Integer) As Entity.Registro.InternoFoto
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoFoto.Listar(sqlCon, "lst", "lst_mant_detalle_LM", Codigo, -1, -1, 0)
            objEnt = New Entity.Registro.InternoFoto
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_fot_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .FotoTipo = sqlDr("int_fot_tip").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .NumIngreso = IIf(Val(sqlDr("int_ing_nro").ToString) = 0, "", sqlDr("int_ing_nro").ToString)

                            .PIzquierdoID = sqlDr("int_fot_per_izq").ToString
                            .PIzquierdoName = sqlDr("per_izq_nom_arc").ToString
                            .PIzquierdoServerPath = sqlDr("per_izq_pth").ToString

                            .PFrenteID = sqlDr("int_fot_per_fre").ToString
                            .PFrenteName = sqlDr("per_fre_nom_arc").ToString
                            .PFrenteServerPath = sqlDr("per_fre_pth").ToString

                            .PDerechoID = sqlDr("int_fot_per_der").ToString
                            .PDerechoName = sqlDr("per_der_nom_arc").ToString
                            .PDerechoServerPath = sqlDr("per_der_pth").ToString

                            .FotoVersionNueva = sqlDr("fot_ver_nue").ToString

                            .Fecha = sqlDr("int_fot_fec").ToString
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

        Public Function Listar_v2(ent As Entity.Registro.InternoFoto) As Entity.Registro.InternoFotoCol

            ''16/02/15-> hnrb, grilla

            Dim lstIntFot As New Entity.Registro.InternoFotoCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoFoto.Listar(sqlCon, "lst", "lst_mant_basico", ent)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoFoto
                        With objEnt
                            .Codigo = sqlDr("int_fot_id").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .NumIngreso = IIf(Val(sqlDr("int_ing_nro").ToString) = 0, "", sqlDr("int_ing_nro").ToString)
                            .Fecha = sqlDr("int_fot_fec").ToString

                            .PFrenteID = sqlDr("int_fot_per_fre").ToString
                            .PIzquierdoID = sqlDr("int_fot_per_izq").ToString
                            .PDerechoID = sqlDr("int_fot_per_der").ToString
                        End With
                        lstIntFot.Add(objEnt)
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
            Return lstIntFot
        End Function

        Public Function Listar_LM(ent As Entity.Registro.InternoFoto) As Entity.Registro.InternoFotoCol

            ''16/02/15-> hnrb, grilla

            Dim lstIntFot As New Entity.Registro.InternoFotoCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoFoto.Listar_LM(sqlCon, "lst", "lst_mant_basico_LM", ent)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoFoto
                        With objEnt
                            .Codigo = sqlDr("int_fot_id").ToString
                            '.InternoIngresoId = sqlDr("int_ing_id").ToString
                            .IngresoInpeId = sqlDr("fk_ing_inp_id").ToString
                            .NumIngreso = IIf(Val(sqlDr("int_ing_nro").ToString) = 0, "", sqlDr("int_ing_nro").ToString)
                            .Fecha = sqlDr("int_fot_fec").ToString

                            .PFrenteID = sqlDr("int_fot_per_fre").ToString
                            .PIzquierdoID = sqlDr("int_fot_per_izq").ToString
                            .PDerechoID = sqlDr("int_fot_per_der").ToString
                        End With
                        lstIntFot.Add(objEnt)
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
            Return lstIntFot
        End Function

        Public Function ListarFotoReniec(ByVal Codigo As Integer, Tipo As Integer) As Entity.Registro.InternoReniec
            'Pertenece a la version antigua
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoFoto.Listar(sqlCon, "lst", "lst_mant_rnc", Codigo, -1, -1, 0)
            objEntRnc = New Entity.Registro.InternoReniec
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEntRnc
                            .Codigo = sqlDr("int_rnc_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .FotoTipo = Tipo 'sqlDr("int_fot_tip").ToString

                            .PFrenteRnc = sqlDr("int_fot_rnc").ToString
                            .PFrenteName = sqlDr("per_fre_nom_arc").ToString
                            .PthServidor = sqlDr("per_fre_pth").ToString

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
            Return objEntRnc
        End Function

        Public Function ListarInternoReniec_v2(ByVal Codigo As Integer) As Entity.Registro.InternoReniec

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoFoto.Listar(sqlCon, "lst", "lst_mant_rnc_int_v2", Codigo, -1, -1, 0)
            objEntRnc = New Entity.Registro.InternoReniec
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEntRnc
                            .Codigo = sqlDr("int_rnc_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .FotoTipo = 4

                            .PthServidorFotoInterno = sqlDr("per_fre_pth_fot_int").ToString
                            .NombreFotoInterno = sqlDr("per_fre_nom_fot_int").ToString

                            .PFrenteName = sqlDr("per_fre_nom_fot_rnc").ToString
                            .PthServidor = sqlDr("per_fre_pth_fot_rnc").ToString

                            .PFrenteInt = sqlDr("int_fot_int").ToString
                            .PFrenteRnc = sqlDr("int_fot_rnc").ToString

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
            Return objEntRnc
        End Function

        Public Function ObtenerCodigoFOTO_SEDE(ByVal IdFoto As Integer) As Entity.Registro.InternoFoto
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.InternoFoto.Listar(sqlCon, "lst", "Obtener_ID_FOTO_LIMA", IdFoto, -1, -1, 0)
            objEnt = New Entity.Registro.InternoFoto
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .SedeRowId = sqlDr("ID").ToString
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
#End Region
#Region "Grabar"

        Public Function Grabar(ByVal Codigo As Integer, _
        ByVal InternoID As Integer, ByVal RegionID As Integer, ByVal PenalID As Integer, _
        ByVal FotoTipo As Integer, _
        ByVal PerfilIzquierdo As Integer, ByVal PerfilFrente As Integer, ByVal PerfilDerecho As Integer, _
        ByVal Fecha As Long) As Integer

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

            intValue = Data.Registro.InternoFoto.Grabar(strAccion, strOpcion, Codigo, _
            InternoID, RegionID, PenalID, _
            FotoTipo, _
            PerfilIzquierdo, PerfilFrente, PerfilDerecho, _
            Fecha, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue
        End Function

        Public Function Grabar_v2(entIntFot As Entity.Registro.InternoFoto) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            entIntFot.FotoTipo = -1

            If entIntFot.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant2"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant2"
            End If
            If entIntFot.InternoID <= 0 Then
                MsgBox("El Id del Interno no especificado", MsgBoxStyle.Critical)
                Return -1
            End If
            If entIntFot.InternoIngresoId <= 0 Then
                MsgBox("El Id del Ingreso no especificado", MsgBoxStyle.Critical)
                Return -1
            End If
            If entIntFot.PenalId = -1 Then
                MsgBox("Penal no especificado", MsgBoxStyle.Critical)
                Return -1
            End If

            intValue = Data.Registro.InternoFoto.Grabar(strAccion, strOpcion, entIntFot)

            Return intValue
        End Function

        Public Function Grabar_LM(entIntFot As Entity.Registro.InternoFoto) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            entIntFot.FotoTipo = -1

            If entIntFot.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_LM"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant2"
            End If
            If entIntFot.InternoID <= 0 Then
                MsgBox("El Id del Interno no especificado", MsgBoxStyle.Critical)
                Return -1
            End If
            If entIntFot.IngresoInpeId <= 0 Then
                MsgBox("El Id del Ingreso no especificado", MsgBoxStyle.Critical)
                Return -1
            End If
            If entIntFot.PenalId = -1 Then
                MsgBox("Penal no especificado", MsgBoxStyle.Critical)
                Return -1
            End If

            intValue = Data.Registro.InternoFoto.Grabar_LM(strAccion, strOpcion, entIntFot)

            Return intValue
        End Function

        Public Function GrabarFotoPerfil(ByVal Codigo As Integer, _
        ByVal InternoID As Integer, ByVal RegionID As Integer, ByVal PenalID As Integer, _
        ByVal FotoTipo As Integer, _
        ByVal Perfil As Integer, ByVal PerfilIzquierdo As Integer, _
        ByVal PerfilFrente As Integer, ByVal PerfilDerecho As Integer, ByVal Fecha As Long) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else

                Select Case Perfil
                    Case 1
                        strAccion = "upd"
                        strOpcion = "upd_perfil_izquierdo"
                    Case 2
                        strAccion = "upd"
                        strOpcion = "upd_perfil_frente"
                    Case 3
                        strAccion = "upd"
                        strOpcion = "upd_perfil_derecho"
                End Select

            End If

            intValue = Data.Registro.InternoFoto.Grabar(strAccion, strOpcion, Codigo, _
            InternoID, RegionID, PenalID, _
            FotoTipo, _
            PerfilIzquierdo, PerfilFrente, PerfilDerecho, _
            Fecha, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue
        End Function

#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, ByVal Usuario As Integer, ByRef out_msg As String) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
           
                intValue = Data.Registro.InternoFoto.Eliminar(strAccion, strOpcion, Codigo, Usuario, out_msg)
                Return intValue
           
        End Function
#End Region
    End Class
End Namespace