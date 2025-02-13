Option Explicit On
Imports System.Data
Imports System.Data.SqlClient
Namespace General
    Public Class Parametrica
        Private objEnt As Entity.General.Parametrica = Nothing
        Private objEntCol As Entity.General.ParametricaCol = Nothing
#Region "Propiedades"
        Private intNombreLength As Integer = 0
        Public ReadOnly Property NombreLength() As Integer
            Get
                Return intNombreLength
            End Get
        End Property
        Public Property TipoTexto As Type.Combo.enmTipoTexto = Type.Combo.enmTipoTexto.Ninguno
#End Region
#Region "Combo"
        Public Function Combo_MovimientoTipo(Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[Todos]") As DataTable
            Dim objDT As New DataTable("Cargo")
            objDT.Columns.Add("Codigo", GetType(Integer))
            objDT.Columns.Add("Nombre", GetType(String))
            If blnAddprimeraFila = True Then
                objDT.Rows.Add(New Object() {-1, strMensaje})
            End If
            objDT.Rows.Add(New Object() {1, "INTERNAMIENTO"})
            objDT.Rows.Add(New Object() {2, "TRASLADO"})
            objDT.AcceptChanges()
            Return objDT
        End Function

        Public Function Combo_MovimientoTipo_ORL(Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[Todos]") As DataTable

            Dim objDT As New DataTable("Cargo")
            objDT.Columns.Add("Codigo", GetType(Integer))
            objDT.Columns.Add("Nombre", GetType(String))

            If blnAddprimeraFila = True Then
                objDT.Rows.Add(New Object() {-1, strMensaje})
            End If
            objDT.Rows.Add(New Object() {1, "INTERNAMIENTO"})
            objDT.Rows.Add(New Object() {2, "TRASLADO"})
            objDT.Rows.Add(New Object() {7, "INGRESO DE DOCUMENTOS SIN INGRESO AL PENAL"})
            objDT.AcceptChanges()

            Return objDT
        End Function

        Public Function ComboMovimientoEstado(Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[Todos]") As DataTable
            Dim objDT As New DataTable("Cargo")
            objDT.Columns.Add("Codigo", GetType(Integer))
            objDT.Columns.Add("Nombre", GetType(String))
            If blnAddprimeraFila = True Then
                objDT.Rows.Add(New Object() {-1, strMensaje})
            End If
            objDT.Rows.Add(New Object() {1, "PENDIENTE"})
            objDT.Rows.Add(New Object() {3, "TERMINADO"})
            objDT.AcceptChanges()
            Return objDT
        End Function
        Public Function ComboMovimientoEstadoOrdenTrasladoSaludMental(Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[Todos]") As DataTable
            Dim objDT As New DataTable("Cargo")
            objDT.Columns.Add("Codigo", GetType(Integer))
            objDT.Columns.Add("Nombre", GetType(String))
            If blnAddprimeraFila = True Then
                objDT.Rows.Add(New Object() {-1, strMensaje})
            End If
            objDT.Rows.Add(New Object() {4, "EN DESARROLLO"})
            objDT.Rows.Add(New Object() {5, "EGRESO TEMPORAL"})
            objDT.Rows.Add(New Object() {6, "EGRESO DEFINITIVO DEL INTERNO"})
            objDT.AcceptChanges()
            Return objDT
        End Function
        Public Function ComboMovimientoEstadoRetornoTrasladoSaludMental(Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[Todos]") As DataTable
            Dim objDT As New DataTable("Cargo")
            objDT.Columns.Add("Codigo", GetType(Integer))
            objDT.Columns.Add("Nombre", GetType(String))
            If blnAddprimeraFila = True Then
                objDT.Rows.Add(New Object() {-1, strMensaje})
            End If
            objDT.Rows.Add(New Object() {2, "EN PROCESO"})
            objDT.Rows.Add(New Object() {3, "TERMINADO"})
            objDT.AcceptChanges()
            Return objDT
        End Function

        Public Function Combo_Regimen(Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[Seleccionar Regimen]") As DataTable
            Dim objDT As New DataTable("Cargo")
            objDT.Columns.Add("Codigo", GetType(Integer))
            objDT.Columns.Add("Nombre", GetType(String))
            If blnAddprimeraFila = False Then
                objDT.Rows.Add(New Object() {-1, strMensaje})
            End If
            objDT.Rows.Add(New Object() {1, "REGIMEN CERRADO ORDINARIO"})
            objDT.Rows.Add(New Object() {2, "REGIMEN CERRADO ESPECIAL"})
            objDT.AcceptChanges()
            Return objDT
        End Function

        Public Function Combo_Numero(Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[Seleccionar Correlativo]") As DataTable
            Dim objDT As New DataTable("Cargo")
            objDT.Columns.Add("Codigo", GetType(Integer))
            objDT.Columns.Add("Nombre", GetType(String))
            If blnAddprimeraFila = False Then
                ' objDT.Rows.Add(New Object() {-1, strMensaje})
            End If
            objDT.Rows.Add(New Object() {1, "08:30"})
            objDT.Rows.Add(New Object() {2, "12:30"})
            objDT.Rows.Add(New Object() {3, "16:30"})
            objDT.AcceptChanges()
            Return objDT
        End Function

        Public Function Combo_MovimientoMotivo(ByVal intIDMovimientoTipo As Integer,
                                               Optional intTipoTexto As Type.Combo.enmTipoTexto = Type.Combo.enmTipoTexto.Ninguno,
                                                Optional blnAddPrimeraFila As Boolean = False,
                                                Optional ByVal strMensaje As String = "") As Entity.General.ParametricaCol

            Dim intTipoCombo As Type.Combo.ComboTipo = Type.Combo.ComboTipo.MovimientoMotivo

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.General.Parametrica.Listar(sqlCon, "lst", "", intTipoCombo, intIDMovimientoTipo)
            Try
                objEntCol = New Entity.General.ParametricaCol

                If blnAddPrimeraFila = True Then
                    Dim _entParam As New Entity.General.Parametrica
                    _entParam.Codigo = -1
                    _entParam.Nombre = strMensaje
                    objEntCol.Add(_entParam)
                End If

                If sqlDr.HasRows Then
                    While sqlDr.Read

                        objEnt = New Entity.General.Parametrica
                            With objEnt

                                .Codigo = sqlDr("par_id").ToString
                                .Nombre = sqlDr("par_nom").ToString

                                Select Case intTipoTexto
                                    Case Type.Combo.enmTipoTexto.Mayuscula
                                        .Nombre = .Nombre.ToUpper

                                    Case Type.Combo.enmTipoTexto.Minuscula
                                        .Nombre = .Nombre.ToLower
                                    Case Type.Combo.enmTipoTexto.Propio
                                        .Nombre = Legolas.Components.Cadena.ProperCase(.Nombre)
                                End Select

                                If intNombreLength < .NombreLength Then
                                    intNombreLength = .NombreLength
                                End If
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

        Public Function Combo_MovimientoMotivo_LM(ByVal intIDMovimientoTipo As Integer,
                                               Optional intTipoTexto As Type.Combo.enmTipoTexto = Type.Combo.enmTipoTexto.Ninguno,
                                                Optional blnAddPrimeraFila As Boolean = False,
                                                Optional ByVal strMensaje As String = "") As Entity.General.ParametricaCol

            Dim intTipoCombo As Type.Combo.ComboTipo = Type.Combo.ComboTipo.MovimientoMotivo

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.General.Parametrica.Listar(sqlCon, "lst", "", intTipoCombo, intIDMovimientoTipo)

            Try
                objEntCol = New Entity.General.ParametricaCol

                If blnAddPrimeraFila = True Then
                    Dim _entParam As New Entity.General.Parametrica
                    _entParam.Codigo = -1
                    _entParam.Nombre = strMensaje
                    objEntCol.Add(_entParam)
                End If

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Select Case sqlDr("par_id").ToString
                            Case Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoTraslado,
                                Type.Enumeracion.Movimiento.EnumMovMotivo.NuevoIngreso

                            Case Else
                                If blnAddPrimeraFila = False And strMensaje = "NUE" Then
                                    If sqlDr("par_id").ToString = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoReincidencia Or
                                       sqlDr("par_id").ToString = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoReiterante Then
                                        Exit Select
                                    End If
                                End If
                                objEnt = New Entity.General.Parametrica
                                    With objEnt
                                        .Codigo = sqlDr("par_id").ToString
                                        .Nombre = sqlDr("par_nom").ToString
                                        Select Case intTipoTexto
                                            Case Type.Combo.enmTipoTexto.Mayuscula
                                                .Nombre = .Nombre.ToUpper

                                            Case Type.Combo.enmTipoTexto.Minuscula
                                                .Nombre = .Nombre.ToLower
                                            Case Type.Combo.enmTipoTexto.Propio
                                                .Nombre = Legolas.Components.Cadena.ProperCase(.Nombre)
                                        End Select

                                        If intNombreLength < .NombreLength Then
                                            intNombreLength = .NombreLength
                                        End If
                                    End With
                                    objEntCol.Add(objEnt)

                        End Select
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
        Public Function Combo_Documentos_LM(objDocJud As Entity.Registro.DocumentoJudicial,
                                               Optional intTipoTexto As Type.Combo.enmTipoTexto = Type.Combo.enmTipoTexto.Ninguno,
                                                Optional blnAddPrimeraFila As Boolean = False,
                                                Optional ByVal strMensaje As String = "") As Entity.General.ParametricaCol



            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoJudicial.Listar2(sqlCon, "lst", "lst_mant_LM", objDocJud)

            Try
                objEntCol = New Entity.General.ParametricaCol

                If blnAddPrimeraFila = True Then
                    Dim _entParam As New Entity.General.Parametrica
                    _entParam.Codigo = -1
                    _entParam.Nombre = strMensaje
                    objEntCol.Add(_entParam)
                End If

                If sqlDr.HasRows Then
                    While sqlDr.Read

                        objEnt = New Entity.General.Parametrica
                        With objEnt
                            .Codigo = sqlDr("doc_jud_id").ToString
                            .Nombre = sqlDr("doc_jud_num").ToString

                            Select Case intTipoTexto
                                Case Type.Combo.enmTipoTexto.Mayuscula
                                    .Nombre = .Nombre.ToUpper

                                Case Type.Combo.enmTipoTexto.Minuscula
                                    .Nombre = .Nombre.ToLower
                                Case Type.Combo.enmTipoTexto.Propio
                                    .Nombre = Legolas.Components.Cadena.ProperCase(.Nombre)
                            End Select

                            If intNombreLength < .NombreLength Then
                                intNombreLength = .NombreLength
                            End If
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
#Region "Listar"

        Public Function Listar(ByVal Tipo As Type.Combo.ComboTipo)

            Return Listar(Tipo, -1, False, "")

        End Function
        Public Function Listar(ByVal Tipo As Type.Combo.ComboTipo, ByVal Padre As Integer)

            Return Listar(Tipo, Padre, False, "")

        End Function
        Public Function Listar(ByVal Tipo As Type.Combo.ComboTipo, ByVal Padre As Integer,
        ByVal Todos As Boolean, ByVal TodosMensaje As String) As Entity.General.ParametricaCol

            Return Listar(Tipo, Padre, -1, -1, False, "")

        End Function

        Public Function Listar(ByVal Tipo As Type.Combo.ComboTipo, ByVal Padre As Integer,
        ByVal Parametrica1 As Integer, ByVal Parametrica2 As Integer, ByVal Todos As Boolean, ByVal ComboMensaje As String, Optional blnModuloTrat As Boolean = False) As Entity.General.ParametricaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader

            If blnModuloTrat = True Then
                sqlDr = Data.General.Parametrica.ListarTratamiento(sqlCon, "lst", Tipo.GetHashCode, Padre, Parametrica1, Parametrica2)
            Else
                sqlDr = Data.General.Parametrica.Listar(sqlCon, "lst", "", Tipo.GetHashCode, Padre, Parametrica1, Parametrica2)
            End If

            Try
                objEntCol = New Entity.General.ParametricaCol
                If Todos = True Then
                    Dim _entParam As New Entity.General.Parametrica
                    _entParam.Codigo = -1
                    _entParam.Nombre = ComboMensaje
                    objEntCol.Add(_entParam)
                End If
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.General.Parametrica
                        With objEnt
                            .Codigo = sqlDr("par_id").ToString
                            .Nombre = sqlDr("par_nom").ToString

                            Select Case TipoTexto
                                Case Type.Combo.enmTipoTexto.Mayuscula
                                    .Nombre = .Nombre.ToUpper

                                Case Type.Combo.enmTipoTexto.Minuscula
                                    .Nombre = .Nombre.ToLower
                                Case Type.Combo.enmTipoTexto.Propio
                                    .Nombre = Legolas.Components.Cadena.ProperCase(.Nombre)
                            End Select

                            If intNombreLength < .NombreLength Then
                                intNombreLength = .NombreLength
                            End If

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
        Public Class ConstanciaReclusion

            Public Function comboDocumento(verSolicitud As Boolean, verMemo As Boolean, verOficio As Boolean,
                                           Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[TODOS]") As DataTable

                Dim objDT As New DataTable("combo")

                objDT.Columns.Add("Codigo", GetType(Integer))
                objDT.Columns.Add("Nombre", GetType(String))

                If blnAddprimeraFila = True Then
                    objDT.Rows.Add(New Object() {-1, strMensaje})
                End If

                If verSolicitud = True Then
                    objDT.Rows.Add(New Object() {1, "SOLICITUD"})
                End If

                If verMemo = True Then
                    objDT.Rows.Add(New Object() {2, "MEMORANDO"})
                End If

                If verOficio = True Then
                    objDT.Rows.Add(New Object() {3, "OFICIO"})
                End If

                objDT.AcceptChanges()
                Return objDT

            End Function

            Public Function comboTipoFecha(Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[TODOS]") As DataTable

                Dim objDT As New DataTable("combo")

                objDT.Columns.Add("Codigo", GetType(Integer))
                objDT.Columns.Add("Nombre", GetType(String))

                If blnAddprimeraFila = True Then
                    objDT.Rows.Add(New Object() {-1, strMensaje})
                End If

                objDT.Rows.Add(New Object() {2, "Fecha Recepción en el EP"})
                objDT.Rows.Add(New Object() {3, "Fecha Recepción en el RP"})

                objDT.AcceptChanges()
                Return objDT

            End Function

            Public Function comboTipoEstado(Optional blnAddprimeraFila As Boolean = False, Optional strMensaje As String = "[TODOS]") As DataTable

                Dim objDT As New DataTable("combo")

                objDT.Columns.Add("Codigo", GetType(Integer))
                objDT.Columns.Add("Nombre", GetType(String))

                If blnAddprimeraFila = True Then
                    objDT.Rows.Add(New Object() {-1, strMensaje})
                End If

                objDT.Rows.Add(New Object() {1, "PENDIENTE"})
                objDT.Rows.Add(New Object() {2, "ATENDIDO"})
                objDT.Rows.Add(New Object() {3, "ANULADO"})

                objDT.AcceptChanges()
                Return objDT

            End Function

        End Class

    End Class
End Namespace