Imports System.Data
Imports System.Data.SqlClient
Namespace Globall
    Public Class Parentesco
        Private objEnt As Entity.Globall.Parentesco = Nothing
        Private objEntCol As Entity.Globall.ParentescoCol = Nothing
#Region "Functions"
        Public Shared Function Return_TipoParentesco(ByVal ParentecoID As Integer) As Integer

            Dim value As Integer = -1

            Dim objEntFiltro As New Entity.Globall.Parentesco
            With objEntFiltro
                .Codigo = ParentecoID
            End With

            value = Data.Globall.Parentesco.ListarOutput("lst", "lst_parentesco_tipo", objEntFiltro)
            Return value

        End Function
        Public Shared Function Return_GradoParentesco(ByVal ParentecoID As Integer) As Integer

            Dim value As Integer = -1

            Dim objEntFiltro As New Entity.Globall.Parentesco
            With objEntFiltro
                .Codigo = ParentecoID
            End With

            value = Data.Globall.Parentesco.ListarOutput("lst", "lst_parentesco_grado", objEntFiltro)
            Return value

            Return value

        End Function
#End Region
#Region "combo"
        Public Function Combo(ByVal Todos As Boolean, _
        Optional ByVal ComboMensaje As String = "") As Entity.Globall.ParentescoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            objEnt = New Entity.Globall.Parentesco
            objEnt.Opcion1 = 1
            objEnt.Opcion2 = -1

            Dim sqlDr As SqlDataReader = Data.Globall.Parentesco.Listar(sqlCon, "lst", "lst_grilla", objEnt)

            Try
                objEntCol = New Entity.Globall.ParentescoCol

                If Todos = True Then

                    Dim strTodos As String = "[Todos]"
                    If ComboMensaje.Trim.Length > 3 Then
                        strTodos = ComboMensaje
                    End If

                    objEnt = New Entity.Globall.Parentesco
                    objEnt.Codigo = -1
                    objEnt.Nombre = strTodos
                    objEntCol.Add(objEnt)
                End If

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Globall.Parentesco
                        With objEnt
                            .Codigo = sqlDr("par_id").ToString
                            .Nombre = sqlDr("par_nom").ToString
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
        Public Function ComboTipo1SinAbogado(ByVal Todos As Boolean, _
        Optional ByVal ComboMensaje As String = "") As Entity.Globall.ParentescoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            objEnt = New Entity.Globall.Parentesco
            objEnt.Opcion1 = 1
            objEnt.Opcion2 = -1

            Dim sqlDr As SqlDataReader = Data.Globall.Parentesco.Listar(sqlCon, "lst", "lst_grilla", objEnt)

            Try
                objEntCol = New Entity.Globall.ParentescoCol

                If Todos = True Then

                    Dim strTodos As String = "[Todos]"
                    If ComboMensaje.Trim.Length > 3 Then
                        strTodos = ComboMensaje
                    End If

                    objEnt = New Entity.Globall.Parentesco
                    objEnt.Codigo = -1
                    objEnt.Nombre = strTodos
                    objEntCol.Add(objEnt)
                End If

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Globall.Parentesco
                        With objEnt
                            .Codigo = sqlDr("par_id").ToString
                            .Nombre = sqlDr("par_nom").ToString
                        End With

                        If objEnt.Codigo <> 18 Then
                            objEntCol.Add(objEnt)
                        End If

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
        Public Function ComboTipo1SoloAbogado(ByVal Todos As Boolean, _
        Optional ByVal ComboMensaje As String = "") As Entity.Globall.ParentescoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            objEnt = New Entity.Globall.Parentesco
            objEnt.Opcion1 = -1
            objEnt.Opcion2 = -1

            Dim sqlDr As SqlDataReader = Data.Globall.Parentesco.Listar(sqlCon, "lst", "lst_grilla", objEnt)

            Try
                objEntCol = New Entity.Globall.ParentescoCol

                If Todos = True Then

                    Dim strTodos As String = "[Todos]"
                    If ComboMensaje.Trim.Length > 3 Then
                        strTodos = ComboMensaje
                    End If

                    objEnt = New Entity.Globall.Parentesco
                    objEnt.Codigo = -1
                    objEnt.Nombre = strTodos
                    objEntCol.Add(objEnt)
                End If

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Globall.Parentesco
                        With objEnt
                            .Codigo = sqlDr("par_id").ToString
                            .Nombre = sqlDr("par_nom").ToString
                        End With

                        If objEnt.Codigo = 18 Then
                            objEntCol.Add(objEnt)
                        End If

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
        
        Public Function Listar(ByVal objFiltro As Entity.Globall.Parentesco) As Entity.Globall.ParentescoCol


            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Globall.Parentesco.Listar(sqlCon, "lst", "lst_grilla", objFiltro)

            Try
                objEntCol = New Entity.Globall.ParentescoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Globall.Parentesco
                        With objEnt
                            .Codigo = sqlDr("par_id").ToString
                            .Nombre = sqlDr("par_nom").ToString
                            .Orden = sqlDr("par_pri").ToString
                            .Tipo = sqlDr("par_tip").ToString
                            .Grado = sqlDr("par_grd").ToString
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
        Public Function ListarFiltroMenoresEdad(ByVal objEntParentescoCol As Entity.Globall.ParentescoCol) As Entity.Globall.ParentescoCol

            objEntCol = New Entity.Globall.ParentescoCol

            For Each obj As Entity.Globall.Parentesco In objEntParentescoCol

                Select Case obj.Codigo
                    Case Type.Enumeracion.Parentesco.ParentescoID.Observado, _
                        Type.Enumeracion.Parentesco.ParentescoID.TutorHijosMenores, _
                        Type.Enumeracion.Parentesco.ParentescoID.Bisabuel0, _
                        Type.Enumeracion.Parentesco.ParentescoID.Abuel0Conyuge, _
                        Type.Enumeracion.Parentesco.ParentescoID.Padre, _
                        Type.Enumeracion.Parentesco.ParentescoID.Madre, _
                        Type.Enumeracion.Parentesco.ParentescoID.Abuel0, _
                        Type.Enumeracion.Parentesco.ParentescoID.Suegr0, _
                        Type.Enumeracion.Parentesco.ParentescoID.Abogado
                        'para el tipo de menores de edad, estos parentescos no pasan
                    Case Else

                        objEntCol.Add(obj)

                End Select

            Next

            Return objEntCol

        End Function
#End Region
        
    End Class
End Namespace