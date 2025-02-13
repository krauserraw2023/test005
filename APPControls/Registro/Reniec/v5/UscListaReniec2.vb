Imports System.Threading.Tasks
Imports System.Web.Services.Protocols
Imports Entity
Imports Newtonsoft.Json.Linq

Namespace Registro.Reniec
    Public Class uscListaReniec2
#Region "Eventos"
        Public Event _Click_Cancelar()
        Public Event _ClicK_EnviarDNI(NumeroDNI As String)
        Public Event _DoubleClick_EnviarDNI(NumeroDNI As String, Comparacion As Integer)
#End Region
#Region "Propiedades"
        Private objPersonaNombres As New APPWebService.ws_reniec_sede.ApellidosyNombres
#End Region
#Region "Propiedades_Publicas"
        Public Property _InternoID As Integer = -1
        Public Property _ApellidoPaterno As String = ""
        Public Property _ApellidoMaterno As String = ""
        Public Property _Nombres As String = ""
        Public Property _NombreAsociadoValID As Integer = -1
        Private intComparacion As Integer = -1
        Public strMensaje As String = ""
        Public strCodigo As String = ""
        Public strCabecera As String = ""
        Public Property _Comparacion() As Integer
            Get
                Return intComparacion
            End Get
            Set(ByVal value As Integer)
                intComparacion = value

            End Set
        End Property
        Public ReadOnly Property _GrillaNumeroDNI() As String
            Get
                Dim intValue As String = ""

                With Me.dgwGrillaListaReniec
                    If .Rows.Count > 0 Then
                        intValue = .SelectedRows(0).Cells("col_num_dni").Value
                    End If
                End With

                Return intValue
            End Get
        End Property
#End Region
#Region "Listar"
        Private Sub ListarGrilla()
            If Me._InternoID < 1 Then
                Exit Sub
            End If
            If Me._Comparacion > 0 Then

                Dim Contador As Integer = objPersonaNombres.Coincidencia.Length
                If Contador > 0 Then
                    With dgwGrillaListaReniec
                        .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                        .AllowUserToResizeRows = False
                        .AutoGenerateColumns = False
                        .RowCount = objPersonaNombres.Coincidencia.Length
                        For i As Integer = 0 To objPersonaNombres.Coincidencia.Length - 1
                            .Item("col_num", i).Value = i + 1
                            .Item("col_num_dni", i).Value = objPersonaNombres.Coincidencia(i).NumeroDNI
                            .Item("col_dig_ver", i).Value = objPersonaNombres.Coincidencia(i).CaracterVerificacion
                            .Item(3, i).Value = objPersonaNombres.Coincidencia(i).ApellidoPaterno
                            .Item(4, i).Value = objPersonaNombres.Coincidencia(i).ApellidoMaterno
                            .Item(5, i).Value = objPersonaNombres.Coincidencia(i).PreNombres
                            .Item(6, i).Value = objPersonaNombres.Coincidencia(i).Datos
                        Next
                    End With
                End If
            End If
            Me.Visible = True
        End Sub
        Private Function BuscarConexionReniec() As Boolean

            Dim blnValor As Boolean = False

            'nombre principal            
            If Me._ApellidoPaterno = "" And Me._ApellidoMaterno = "" And Me._Nombres = "" Then
                Return blnValor
            End If

            strCabecera = "Validación de Verificacion con RENIEC"

            If Legolas.Components.PC.IsOnline = True Then

                Try

                    Dim objBss As New Bussines.Globall.Reniec
                    Dim objPersonaNombresCabecera As New APPWebService.ws_reniec_sede.DTO_ResultOfApellidosyNombres
                    objPersonaNombresCabecera = objBss.WS_ReniecxApellidos_Resultado(Me._ApellidoPaterno, Me._ApellidoMaterno, Me._Nombres)

                    If objPersonaNombresCabecera.Error_Cod = 0 Then
                        objPersonaNombres = objPersonaNombresCabecera.Resultado
                        ListarGrilla()
                        blnValor = True
                    Else
                        Select Case strMensaje.Trim
                            Case "No se puede conectar al servidor MQ-Reniec"
                                strMensaje = "En estos momentos no se puede conectar al Servidor Reniec por favor intentelo mas tarde"
                            Case Else
                                strMensaje = objPersonaNombresCabecera.Error_Mensaje
                        End Select

                    End If

                Catch ex As Exception

                    Me.Cursor = Cursors.Default

                    strCodigo = "-1"
                    strMensaje = "Se ha detectado problemas con el servicio de verificacion RENIEC"
                    strMensaje = strMensaje & Chr(13) & ex.Message.ToString

                End Try

            End If

            Me.Cursor = Cursors.Default
            Return blnValor

        End Function
        Public Function _Load() As Boolean
            Dim blnValor As Boolean = False
            blnValor = BuscarConexionReniec()
            Return blnValor
        End Function
        '-------------Implementacion jhonathan  26112024
        Public Async Function _LoadAsync() As Task(Of Boolean)
            Dim blnValor As Boolean = False
            blnValor = Await BuscarConexionReniecAPI_Async()
            Return blnValor
        End Function
        Private Async Function BuscarConexionReniecAPI_Async() As Task(Of Boolean)
            Dim blnValor As Boolean = False

            'nombre principal            
            If Me._ApellidoPaterno = "" And Me._ApellidoMaterno = "" And Me._Nombres = "" Then
                Return blnValor
            End If

            strCabecera = "Validación de Verificacion con RENIEC"

            If Legolas.Components.PC.IsOnline = True Then

                Try

                    Dim bss As New Bussines.ReniecConsulta
                    Dim ListaRENIEC As New List(Of ResultReniec)

                    ListaRENIEC = Await bss.ConsultarReniec(2, "", Me._Nombres, Me._ApellidoPaterno, Me._ApellidoMaterno, Me.Name)
                    If ListaRENIEC IsNot Nothing Then
                        For Each registroReniec As ResultReniec In ListaRENIEC
                            If (registroReniec.codigoError <> "") Then
                                If (registroReniec.codigoError < 0) Then
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Respuesta de la RENIEC. " + registroReniec.mensajeError)
                                    Me.Cursor = Cursors.Default
                                    strCodigo = "-1"
                                    strMensaje = registroReniec.mensajeError
                                    blnValor = False
                                    Return blnValor
                                    Exit Function
                                End If
                            End If
                        Next

                        ListarGrillaAPI(ListaRENIEC)
                        blnValor = True
                    End If

                Catch ex As Exception

                    Me.Cursor = Cursors.Default

                    strCodigo = "-1"
                    strMensaje = "Se ha detectado problemas con el servicio de verificacion RENIEC"
                    strMensaje = strMensaje & Chr(13) & ex.Message.ToString

                End Try

            End If

            Me.Cursor = Cursors.Default
            Return blnValor

        End Function
        Private Sub ListarGrillaAPI(ByVal ListaRENIEC As List(Of ResultReniec))
            If Me._InternoID < 1 Then
                Exit Sub
            End If
            If Me._Comparacion > 0 Then

                For Each registroReniec As ResultReniec In ListaRENIEC
                    If (registroReniec.codigoError <> "") Then
                        If (registroReniec.codigoError < 0) Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Ocurrió un error interno al conectarse con el servicio de la RENIEC. " + registroReniec.mensajeError)
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        End If
                    End If
                Next
                With dgwGrillaListaReniec
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False
                    .RowCount = ListaRENIEC.Count
                    For i As Integer = 0 To ListaRENIEC.Count - 1
                        .Item("col_num", i).Value = i + 1
                        .Item("col_num_dni", i).Value = ListaRENIEC(i).numeroDNI
                        .Item("col_dig_ver", i).Value = ListaRENIEC(i).digitoVerificacion
                        .Item(3, i).Value = ListaRENIEC(i).apellidoPaterno
                        .Item(4, i).Value = ListaRENIEC(i).apellidoMaterno
                        .Item(5, i).Value = ListaRENIEC(i).nombres
                        .Item(6, i).Value = ListaRENIEC(i).Datos
                    Next
                End With
            End If
            Me.Visible = True
        End Sub
#End Region
#Region "Accion"
        Private Sub SeleccionarDNI()

            Me.Cursor = Cursors.WaitCursor
            With dgwGrillaListaReniec
                If .RowCount > 0 Then
                    If .SelectedRows(0).Cells(5).Value = "S" Then
                        If .CurrentRow.Selected = False Then
                            Legolas.Configuration.Aplication.MessageBox.MensajeError("Selecionar un N° de DNI")
                        ElseIf dgwGrillaListaReniec.Rows.Count < 1 Then
                            Legolas.Configuration.Aplication.MessageBox.MensajeError("La Lista se encuentra vacia")
                        Else
                            Dim CopiaDni As String = ""
                            If dgwGrillaListaReniec.Rows.Count > 0 Then
                                CopiaDni = dgwGrillaListaReniec.SelectedRows(0).Cells(0).Value
                                RaiseEvent _ClicK_EnviarDNI(CopiaDni)
                            End If
                        End If
                    Else
                        Legolas.Configuration.Aplication.MessageBox.Exclamation _
                            ("No se puede visualizar la Informacion de esta persona " & _
                              "porque se encuentra restringido por la RENIEC", "SERVIDOR RENIEC")

                    End If
                End If
            End With
            Me.Cursor = Cursors.Default
        End Sub
        Public Sub CargarNombrePrincipal()
            With dgwGrillaListaReniec
                If .SelectedRows(0).Cells("col_mostrar").Value = "S" Then
                    If .CurrentRow.Selected = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Selecionar un N° de DNI")
                    ElseIf dgwGrillaListaReniec.Rows.Count < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La Lista se encuentra vacia")
                    Else
                        Dim CopiaDni As String = ""
                        With dgwGrillaListaReniec
                            If .Rows.Count > 0 Then

                                RaiseEvent _DoubleClick_EnviarDNI(Me._GrillaNumeroDNI, Me._Comparacion)

                            End If
                        End With
                    End If
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede visualizar " & _
                        "la Informacion de esta persona, se encuentra restringido por la RENIEC", "Validación de Identidad con RENIEC")
                End If
            End With
        End Sub
#End Region

        Public Sub dgwGrillaListaReniec_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaListaReniec.CellDoubleClick
            With dgwGrillaListaReniec
                If .RowCount > 0 And e.RowIndex <> -1 Then
                    Me.Cursor = Cursors.WaitCursor
                    CargarNombrePrincipal()
                    Me.Cursor = Cursors.Default
                End If
            End With

        End Sub

        Private Sub dgwGrillaListaReniec_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrillaListaReniec.CellContentClick

        End Sub

        Private Sub dgwGrillaListaReniec_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrillaListaReniec.CellContentDoubleClick

        End Sub
    End Class
End Namespace

