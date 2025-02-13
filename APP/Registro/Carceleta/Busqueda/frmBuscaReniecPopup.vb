Option Explicit On
Imports System.IO
Imports Entity

Namespace Registro.Main.Carceleta
    Public Class frmBuscaReniecPopup
        Public Enum enmAccion
            NINGUNO = 0
            NUEVO_INTERNO_DESDE_RENIEC = 1
            NUEVO_INTERNO_SIN_RENIEC = 2
        End Enum

        Public Property _tipoAccion As enmAccion = enmAccion.NINGUNO
        Public Property _IdInterno As Integer = -1

        Private Property strUbiNacDep As String = ""
        Private Property strUbiNacProp As String = ""
        Private Property strUbiNacDist As String = ""
        Private Property strUbiDirDep As String = ""
        Private Property strUbiDirProp As String = ""
        Private Property strUbiDirDist As String = ""

        Public Property _RegionId As Integer = -1
        Public Property _PenalId As Integer = -1
#Region "Accion"
        Private Sub Limpiar()
            Panel4.Visible = False
            txtNumDoc.Text = ""
            txtApePat.Text = ""
            txtApeMat.Text = ""
            txtNom.Text = ""
        End Sub


        Private Sub LimpiarCamposRNC()
            lblFechaInscripcion.Text = "-"
            lblFechaemision.Text = "-"
            txtDni.Text = "-"
            txtDigitoVeri.Text = "-"
            txtPrimerApellido.Text = "-"
            txtSegundoApellido.Text = "-"
            txtApellidoCasada.Text = "-"
            txtPrenombres.Text = "-"
            txtFechaNac.Text = "-"
            txtUbigeoNacimiento.Text = "-"
            txtUbigeo.Text = "-"
            txtUbigeoDireccion.Text = "-"
            txtEstadoCivil.Text = "-"
            txtPadre.Text = "-"
            txtMadre.Text = "-"
            txtGradoInstruccion.Text = "-"
            txtRestriccion.Text = "-"
            txtTalla.Text = "-"
            picFoto.Image = Nothing
            gradInsRNCId.Text = -1
        End Sub

        Private Sub BuscarPorDNI(dni As String)
            Dim bss As New Bussines.Globall.Reniec
            Dim rpt As APPWebService.ws_reniec_sede.DTO_ResultOfNumeroDocumento
            rpt = bss.WS_ReniecxDNI_Resultado(dni)
            If rpt.Error_Cod < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Codigo error: " & rpt.Error_Cod & ", Mensaje: " & rpt.Error_Mensaje)
                Exit Sub
            End If
            If rpt.Error_Cod = 5114 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(rpt.Error_Mensaje & " o no existe.")
                Exit Sub
            End If
            If rpt.Error_Cod = 5111 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(rpt.Error_Mensaje)
                Exit Sub
            End If
            If rpt.Error_Cod = 0 Then
                Me.Cursor = Cursors.WaitCursor
                Dim p As New APPWebService.ws_reniec_sede.NumeroDocumento
                p = rpt.Resultado
                With p
                    lblFechaInscripcion.Text = .FechaInscripcion
                    lblFechaemision.Text = .FechaExpedicion
                    txtDni.Text = .NumeroDNI
                    txtDigitoVeri.Text = .DigitoVerificacion
                    txtPrimerApellido.Text = .ApellidoPaterno.Trim
                    txtSegundoApellido.Text = .ApellidoMaterno.Trim
                    txtApellidoCasada.Text = .ApellidoCasada.Trim
                    txtPrenombres.Text = .Nombres.Trim
                    txtFechaNac.Text = .FechaNacimiento
                    txtSexo.Text = IIf(.Sexo = 1, "MAS", "FEM")

                    Me.strUbiNacDep = .CodigoUbigeoDepartamentoNacimiento
                    Me.strUbiNacProp = .CodigoUbigeoProvinciaNacimiento
                    Me.strUbiNacDist = .CodigoUbigeoDistritoNacimiento

                    Me.strUbiDirDep = .CodigoUbigeoDepartamentoDomicilio
                    Me.strUbiDirProp = .CodigoUbigeoProvinciaDomicilio
                    Me.strUbiDirDist = .CodigoUbigeoDistritoDomicilio

                    txtUbigeoNacimiento.Text = .DepartamentoNacimiento.Trim & "/" & .ProvinciaNacimiento.Trim & "/" & .DistritoNacimiento.Trim
                    txtUbigeo.Text = .DepartamentoDomicilio.Trim & "/" & .ProvinciaDomicilio.Trim & "/" & .DistritoDomicilio.Trim
                    txtUbigeoDireccion.Text = Trim(.PrefijoDireccion) & " " & Trim(.Direccion) & " " & Trim(.NumeroDireccion) _
                          & " " & Trim(.BlockChalet) & " " & Trim(.Interior) & " " & Trim(.Urbanizacion) _
                         & " " & Trim(.Etapa) & " " & Trim(.Manzana) & " " & Trim(.Lote) _
                         & " " & Trim(.PrefijoBlockChalet) & " " & Trim(.PrefijoDepartamentoInterior) & " " & Trim(.PrefijoUrbanizacion)
                    txtEstadoCivil.Text = NombreEstadoCivilRNC(.EstadoCivil)
                    txtPadre.Text = .NombrePadre.Trim
                    txtMadre.Text = .NombreMadre.Trim
                    txtTalla.Text = .Estatura
                    gradInsRNCId.Text = .CodigoGradoInstruccion
                    txtGradoInstruccion.Text = (New Bussines.Globall.GradoInstruccion).ListarNombreGradoReniec(.CodigoGradoInstruccion)
                    txtRestriccion.Text = IIf(.Restriccion = "  ", "NINGUNA", Trim(.Restriccion))
                    Try
                        Dim ms As MemoryStream = New MemoryStream(.FotoByte)
                        picFoto.Image = Image.FromStream(ms)
                    Catch ex As Exception
                        picFoto.Image = Nothing
                    End Try
                End With
                Me.Cursor = Cursors.Default
            End If
        End Sub

        Private Sub BuscarReniec()
            LimpiarCamposRNC()
            Panel4.Visible = False

            Dim bss As New Bussines.Globall.Reniec

            Dim rpt2 As APPWebService.ws_reniec_sede.DTO_ResultOfApellidosyNombres
            If rbDNI.Checked = True Then
                If txtNumDoc.Text.Trim.Length <> 8 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La cantidad de digitos del número de documento de identidad es incorrecta, por favor verifique.")
                    Exit Sub
                End If
                Panel4.Visible = False
                BuscarPorDNI(txtNumDoc.Text)
            Else
                If txtApePat.Text.Trim.Length = 0 Or txtApeMat.Text.Trim.Length = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Es necesario ingresar el primer apellido y el segundo apellido.")
                    Exit Sub
                End If
                rpt2 = bss.WS_ReniecxApellidos_Resultado(txtApePat.Text, txtApeMat.Text, txtNom.Text)
                If rpt2 Is Nothing Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ocurrió un error interno al conectarse con el servicio de la RENIEC.")
                    Exit Sub
                End If
                If rpt2.Error_Cod < 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Código error: " & rpt2.Error_Cod & ", Mensaje: " & rpt2.Error_Mensaje)
                    Exit Sub
                End If
                If rpt2.Error_Cod = 5102 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Demasiadas coincidencias, intente ingresando algún dato adicional")
                    Exit Sub
                End If
                If rpt2.Error_Cod = 5200 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ningún registro encontrado.")
                    Exit Sub
                End If
            End If

            If rbNombres.Checked = True Then
                Me.Cursor = Cursors.WaitCursor
                If rpt2.Error_Cod = 0 Then
                    Dim l As New APPWebService.ws_reniec_sede.ApellidosyNombres
                    l = rpt2.Resultado

                    If l.Coincidencia.Length <= 1 Then
                        BuscarPorDNI(l.Coincidencia(0).NumeroDNI)
                        Panel4.Visible = False
                    Else
                        Panel4.Visible = True
                        '---------- mostrar en lista ----------
                        With dgwGrillaListaReniec
                            .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                            .AllowUserToResizeRows = False
                            .AutoGenerateColumns = False
                            .RowCount = l.Coincidencia.Length
                            For i As Integer = 0 To l.Coincidencia.Length - 1
                                .Item("col_num", i).Value = i + 1
                                .Item("col_num_dni", i).Value = l.Coincidencia(i).NumeroDNI
                                .Item("col_dig_ver", i).Value = l.Coincidencia(i).CaracterVerificacion
                                .Item(3, i).Value = l.Coincidencia(i).ApellidoPaterno
                                .Item(4, i).Value = l.Coincidencia(i).ApellidoMaterno
                                .Item(5, i).Value = l.Coincidencia(i).PreNombres
                                .Item(6, i).Value = l.Coincidencia(i).Datos
                            Next
                        End With
                    End If
                End If
                Me.Cursor = Cursors.Default
            End If
        End Sub
        Private Async Sub BuscarReniecAPI()
            LimpiarCamposRNC()
            Panel4.Visible = False
            Me.Cursor = Cursors.WaitCursor
            Dim bss As New Bussines.ReniecConsulta
            Dim ListaRENIEC As New List(Of ResultReniec)

            If rbDNI.Checked = True Then
                If txtNumDoc.Text.Trim.Length <> 8 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La cantidad de digitos del número de documento de identidad es incorrecta, por favor verifique.")
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
                Panel4.Visible = False
                ListaRENIEC = Await bss.ConsultarReniec(1, txtNumDoc.Text, "", "", "", Me.Name)

                If ListaRENIEC IsNot Nothing Then
                    For Each registroReniec As ResultReniec In ListaRENIEC
                        If (registroReniec.codigoError <> "") Then
                            If (registroReniec.codigoError < 0) Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ocurrió un error interno al conectarse con el servicio de la RENIEC. " + registroReniec.mensajeError)
                                Me.Cursor = Cursors.Default
                                Exit Sub
                            End If
                        End If

                        ' Crear y añadir un nuevo objeto AutoridadModel
                        lblFechaInscripcion.Text = registroReniec.fechaInscripcion
                        lblFechaemision.Text = registroReniec.fechaExpedicion
                        txtDni.Text = registroReniec.numeroDNI
                        txtDigitoVeri.Text = registroReniec.digitoVerificacion
                        txtPrimerApellido.Text = registroReniec.apellidoPaterno.Trim
                        txtSegundoApellido.Text = registroReniec.apellidoMaterno.Trim
                        txtApellidoCasada.Text = registroReniec.apellidoCasada.Trim
                        txtPrenombres.Text = registroReniec.nombres.Trim
                        txtFechaNac.Text = registroReniec.fechaNacimiento
                        txtSexo.Text = IIf(registroReniec.sexo = 1, "MAS", "FEM")

                        Me.strUbiNacDep = registroReniec.codigoUbigeoDepartamentoNacimiento
                        Me.strUbiNacProp = registroReniec.codigoUbigeoProvinciaNacimiento
                        Me.strUbiNacDist = registroReniec.codigoUbigeoDistritoNacimiento

                        Me.strUbiDirDep = registroReniec.codigoUbigeoDepartamentoDomicilio
                        Me.strUbiDirProp = registroReniec.codigoUbigeoProvinciaDomicilio
                        Me.strUbiDirDist = registroReniec.codigoUbigeoDistritoDomicilio

                        txtUbigeoNacimiento.Text = registroReniec.departamentoNacimiento.Trim & "/" & registroReniec.provinciaNacimiento.Trim & "/" & registroReniec.distritoNacimiento.Trim
                        txtUbigeo.Text = registroReniec.departamentoDomicilio.Trim & "/" & registroReniec.provinciaDomicilio.Trim & "/" & registroReniec.distritoDomicilio.Trim
                        txtUbigeoDireccion.Text = Trim(registroReniec.prefijoDireccion) & " " & Trim(registroReniec.direccion) & " " & Trim(registroReniec.numeroDireccion) _
                                  & " " & Trim(registroReniec.blockChalet) & " " & Trim(registroReniec.interior) & " " & Trim(registroReniec.urbanizacion) _
                                 & " " & Trim(registroReniec.etapa) & " " & Trim(registroReniec.manzana) & " " & Trim(registroReniec.lote) _
                                 & " " & Trim(registroReniec.prefijoBlockChalet) & " " & Trim(registroReniec.prefijoDepartamentoInterior) & " " & Trim(registroReniec.prefijoUrbanizacion)
                        txtEstadoCivil.Text = NombreEstadoCivilRNC(registroReniec.estadoCivil)
                        txtPadre.Text = registroReniec.nombrePadre.Trim
                        txtMadre.Text = registroReniec.nombreMadre.Trim
                        txtTalla.Text = registroReniec.estatura
                        gradInsRNCId.Text = registroReniec.codigoGradoInstruccion
                        txtGradoInstruccion.Text = (New Bussines.Globall.GradoInstruccion).ListarNombreGradoReniec(registroReniec.codigoGradoInstruccion)
                        txtRestriccion.Text = IIf(registroReniec.restriccion = "  ", "NINGUNA", Trim(registroReniec.restriccion))
                        Try
                            ' Decodificar la cadena base64 a un arreglo de bytes
                            Dim imageBytes As Byte() = Convert.FromBase64String(registroReniec.fotoByte)

                            ' Crear un MemoryStream a partir del arreglo de bytes
                            Dim ms As New MemoryStream(imageBytes)

                            ' Asignar la imagen al PictureBox
                            picFoto.Image = Image.FromStream(ms)
                        Catch ex As Exception
                            ' En caso de error, asignar Nothing a la imagen
                            Me.Cursor = Cursors.Default
                            picFoto.Image = Nothing
                        End Try
                    Next
                    Me.Cursor = Cursors.Default
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ocurrió un error interno al conectarse con el servicio de la RENIEC.")
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

            Else
                If txtApePat.Text.Trim.Length = 0 Or txtApeMat.Text.Trim.Length = 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Es necesario ingresar el primer apellido y el segundo apellido.")
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
                ListaRENIEC = Await bss.ConsultarReniec(2, "", txtNom.Text, txtApePat.Text, txtApeMat.Text, Me.Name)

                If ListaRENIEC Is Nothing Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ocurrió un error interno al conectarse con el servicio de la RENIEC.")
                    Me.Cursor = Cursors.Default
                    Exit Sub
                Else
                    If ListaRENIEC.Count = 1 Then
                        For Each registroReniec As ResultReniec In ListaRENIEC
                            If (registroReniec.codigoError <> "") Then
                                If (registroReniec.codigoError < 0) Then
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ocurrió un error interno al conectarse con el servicio de la RENIEC. " + registroReniec.mensajeError)
                                    Me.Cursor = Cursors.Default
                                    Exit Sub
                                End If
                            End If
                            ' Crear y añadir un nuevo objeto AutoridadModel
                            lblFechaInscripcion.Text = registroReniec.fechaInscripcion
                            lblFechaemision.Text = registroReniec.fechaExpedicion
                            txtDni.Text = registroReniec.numeroDNI
                            txtDigitoVeri.Text = registroReniec.digitoVerificacion
                            txtPrimerApellido.Text = registroReniec.apellidoPaterno.Trim
                            txtSegundoApellido.Text = registroReniec.apellidoMaterno.Trim
                            txtApellidoCasada.Text = registroReniec.apellidoCasada.Trim
                            txtPrenombres.Text = registroReniec.nombres.Trim
                            txtFechaNac.Text = registroReniec.fechaNacimiento
                            txtSexo.Text = IIf(registroReniec.sexo = 1, "MAS", "FEM")

                            Me.strUbiNacDep = registroReniec.codigoUbigeoDepartamentoNacimiento
                            Me.strUbiNacProp = registroReniec.codigoUbigeoProvinciaNacimiento
                            Me.strUbiNacDist = registroReniec.codigoUbigeoDistritoNacimiento

                            Me.strUbiDirDep = registroReniec.codigoUbigeoDepartamentoDomicilio
                            Me.strUbiDirProp = registroReniec.codigoUbigeoProvinciaDomicilio
                            Me.strUbiDirDist = registroReniec.codigoUbigeoDistritoDomicilio

                            txtUbigeoNacimiento.Text = registroReniec.departamentoNacimiento.Trim & "/" & registroReniec.provinciaNacimiento.Trim & "/" & registroReniec.distritoNacimiento.Trim
                            txtUbigeo.Text = registroReniec.departamentoDomicilio.Trim & "/" & registroReniec.provinciaDomicilio.Trim & "/" & registroReniec.distritoDomicilio.Trim
                            txtUbigeoDireccion.Text = Trim(registroReniec.prefijoDireccion) & " " & Trim(registroReniec.direccion) & " " & Trim(registroReniec.numeroDireccion) _
                                      & " " & Trim(registroReniec.blockChalet) & " " & Trim(registroReniec.interior) & " " & Trim(registroReniec.urbanizacion) _
                                     & " " & Trim(registroReniec.etapa) & " " & Trim(registroReniec.manzana) & " " & Trim(registroReniec.lote) _
                                     & " " & Trim(registroReniec.prefijoBlockChalet) & " " & Trim(registroReniec.prefijoDepartamentoInterior) & " " & Trim(registroReniec.prefijoUrbanizacion)
                            txtEstadoCivil.Text = NombreEstadoCivilRNC(registroReniec.estadoCivil)
                            txtPadre.Text = registroReniec.nombrePadre.Trim
                            txtMadre.Text = registroReniec.nombreMadre.Trim
                            txtTalla.Text = registroReniec.estatura
                            gradInsRNCId.Text = registroReniec.codigoGradoInstruccion
                            txtGradoInstruccion.Text = (New Bussines.Globall.GradoInstruccion).ListarNombreGradoReniec(registroReniec.codigoGradoInstruccion)
                            txtRestriccion.Text = IIf(registroReniec.restriccion = "  ", "NINGUNA", Trim(registroReniec.restriccion))
                            Try
                                ' Decodificar la cadena base64 a un arreglo de bytes
                                Dim imageBytes As Byte() = Convert.FromBase64String(registroReniec.fotoByte)

                                ' Crear un MemoryStream a partir del arreglo de bytes
                                Dim ms As New MemoryStream(imageBytes)

                                ' Asignar la imagen al PictureBox
                                picFoto.Image = Image.FromStream(ms)
                            Catch ex As Exception
                                ' En caso de error, asignar Nothing a la imagen
                                Me.Cursor = Cursors.Default
                                picFoto.Image = Nothing
                            End Try
                        Next
                    Else
                        Panel4.Visible = True
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
                        Me.Cursor = Cursors.Default
                    End If
                End If
            End If
        End Sub
        Private Async Function BuscarPorDNI_APIAsync(ByVal DNI As String) As Threading.Tasks.Task
            Try
                LimpiarCamposRNC()
                Panel4.Visible = False
                Me.Cursor = Cursors.WaitCursor
                Dim bss As New Bussines.ReniecConsulta
                Dim ListaRENIEC As New List(Of ResultReniec)
                Panel4.Visible = False
                ListaRENIEC = Await bss.ConsultarReniec(1, DNI, "", "", "", Me.Name)

                If ListaRENIEC IsNot Nothing Then
                    For Each registroReniec As ResultReniec In ListaRENIEC
                        If (registroReniec.codigoError <> "") Then
                            If (registroReniec.codigoError < 0) Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ocurrió un error interno al conectarse con el servicio de la RENIEC. " + registroReniec.mensajeError)
                                Me.Cursor = Cursors.Default
                                Exit Function
                            End If
                        End If
                        ' Crear y añadir un nuevo objeto AutoridadModel
                        lblFechaInscripcion.Text = registroReniec.fechaInscripcion
                        lblFechaemision.Text = registroReniec.fechaExpedicion
                        txtDni.Text = registroReniec.numeroDNI
                        txtDigitoVeri.Text = registroReniec.digitoVerificacion
                        txtPrimerApellido.Text = registroReniec.apellidoPaterno.Trim
                        txtSegundoApellido.Text = registroReniec.apellidoMaterno.Trim
                        txtApellidoCasada.Text = registroReniec.apellidoCasada.Trim
                        txtPrenombres.Text = registroReniec.nombres.Trim
                        txtFechaNac.Text = registroReniec.fechaNacimiento
                        txtSexo.Text = IIf(registroReniec.sexo = 1, "MAS", "FEM")

                        Me.strUbiNacDep = registroReniec.codigoUbigeoDepartamentoNacimiento
                        Me.strUbiNacProp = registroReniec.codigoUbigeoProvinciaNacimiento
                        Me.strUbiNacDist = registroReniec.codigoUbigeoDistritoNacimiento

                        Me.strUbiDirDep = registroReniec.codigoUbigeoDepartamentoDomicilio
                        Me.strUbiDirProp = registroReniec.codigoUbigeoProvinciaDomicilio
                        Me.strUbiDirDist = registroReniec.codigoUbigeoDistritoDomicilio

                        txtUbigeoNacimiento.Text = registroReniec.departamentoNacimiento.Trim & "/" & registroReniec.provinciaNacimiento.Trim & "/" & registroReniec.distritoNacimiento.Trim
                        txtUbigeo.Text = registroReniec.departamentoDomicilio.Trim & "/" & registroReniec.provinciaDomicilio.Trim & "/" & registroReniec.distritoDomicilio.Trim
                        txtUbigeoDireccion.Text = Trim(registroReniec.prefijoDireccion) & " " & Trim(registroReniec.direccion) & " " & Trim(registroReniec.numeroDireccion) _
                                  & " " & Trim(registroReniec.blockChalet) & " " & Trim(registroReniec.interior) & " " & Trim(registroReniec.urbanizacion) _
                                 & " " & Trim(registroReniec.etapa) & " " & Trim(registroReniec.manzana) & " " & Trim(registroReniec.lote) _
                                 & " " & Trim(registroReniec.prefijoBlockChalet) & " " & Trim(registroReniec.prefijoDepartamentoInterior) & " " & Trim(registroReniec.prefijoUrbanizacion)
                        txtEstadoCivil.Text = NombreEstadoCivilRNC(registroReniec.estadoCivil)
                        txtPadre.Text = registroReniec.nombrePadre.Trim
                        txtMadre.Text = registroReniec.nombreMadre.Trim
                        txtTalla.Text = registroReniec.estatura
                        gradInsRNCId.Text = registroReniec.codigoGradoInstruccion
                        txtGradoInstruccion.Text = (New Bussines.Globall.GradoInstruccion).ListarNombreGradoReniec(registroReniec.codigoGradoInstruccion)
                        txtRestriccion.Text = IIf(registroReniec.restriccion = "  ", "NINGUNA", Trim(registroReniec.restriccion))
                        Try
                            ' Decodificar la cadena base64 a un arreglo de bytes
                            Dim imageBytes As Byte() = Convert.FromBase64String(registroReniec.fotoByte)

                            ' Crear un MemoryStream a partir del arreglo de bytes
                            Dim ms As New MemoryStream(imageBytes)

                            ' Asignar la imagen al PictureBox
                            picFoto.Image = Image.FromStream(ms)
                        Catch ex As Exception
                            ' En caso de error, asignar Nothing a la imagen
                            picFoto.Image = Nothing
                        End Try
                    Next
                    Me.Cursor = Cursors.Default
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ocurrió un error interno al conectarse con el servicio de la RENIEC.")
                End If
            Catch ex As Exception
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ocurrió un error interno al conectarse con el servicio de la RENIEC." + ex.Message)
            End Try

        End Function
        Private Sub RegistrarNuevoInternoDesdeReniec()
            Dim obEntInternoOrigen As New Entity.Registro.Interno
            With obEntInternoOrigen
                .ApellidoPaterno = txtPrimerApellido.Text
                .ApellidoMaterno = txtSegundoApellido.Text
                .Nombres = txtPrenombres.Text
                .SexoID = If(txtSexo.Text = "MAS", 1, 2)
                .FechaNacimiento = CDate(txtFechaNac.Text).ToFileTime
                '.NacimientoPaisID = tbl.Rows(0).Item("ubg_pai_id") ' Me.Pais
                '.NacimientoUbigeoID = tbl.Rows(0).Item("ubg_id_nac") 'Me.UbigeoNacimiento
                .NacionalidadID = 141 'peruana

                .TipoDocumentoID = 10 'dni
                .NacimientoPaisID = 85 'peru

                .NumeroDocumento = txtDni.Text
                .IdiomaNativoId = 15 'español
                .Obs_DNI = ""
                '.DomicilioUbigeoID = tbl.Rows(0).Item("ubg_id_dir") ' Me.UbigeoDomicilio
                .Domicilio = txtUbigeoDireccion.Text.Trim
                .EstadoCivilID = EstadoCivilId(txtEstadoCivil.Text)
                .NivelAcademicoID = (New Bussines.Globall.GradoInstruccion).ListarIdGradoGradoInstruccion(gradInsRNCId.Text)
                .EstadoID = 0
                .RegionID = Me._RegionId  'region lima
                .PenalID = Me._PenalId  'carceleta lima
                .EstadoEspecificoID = 1 'recluido
                .EstadoRncID = 1
                .VersionRegistro = "V6_LM"
            End With

            'buscar por DNI en la base de datos en caso el usuario no haya buscado por DNI.
            Dim entCol As New Entity.Registro.InternoCol
            entCol = (New Bussines.Registro.Interno).ListarDuplicadosXNumDoc_LM(10, obEntInternoOrigen.NumeroDocumento)

            If entCol.Count > 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ya existe un interno registrado con el DNI " & obEntInternoOrigen.NumeroDocumento & ", CódigoRP: " & entCol(0).CodigoRP & " Nombres: " & entCol(0).ApellidosyNombres)
                Exit Sub
            End If
            If Me._PenalId <> 35 Then
                entCol = (New Bussines.Registro.Interno).ListarDuplicadosXNumDoc(10, obEntInternoOrigen.NumeroDocumento)
                If entCol.Count > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ya existe un interno registrado con el DNI " & obEntInternoOrigen.NumeroDocumento & ", CódigoRP: " & entCol(0).CodigoRP & " Nombres: " & entCol(0).ApellidosyNombres)
                    Exit Sub
                End If
            End If

            Dim id As Integer = -1
            Dim outSMS As String = ""

            If (Me._PenalId <> 35) Then
                id = (New Bussines.Registro.Interno).GrabarProvincia(obEntInternoOrigen)
            Else
                id = (New Bussines.Registro.Interno).Grabar_Carceleta(obEntInternoOrigen, outSMS)
            End If


            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(outSMS)
                Exit Sub
            End If
            Me._tipoAccion = enmAccion.NUEVO_INTERNO_DESDE_RENIEC
            Me._IdInterno = id

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub
#End Region

#Region "Otros"
        Private Function EstadoCivilId(nomEstCivRNC As String) As String
            Dim id As Integer = -1
            Select Case nomEstCivRNC
                Case "SOLTERO"
                    id = 1
                Case "CASADO"
                    id = 2
                Case "VIUDO"
                    id = 4
                Case "DIVORCIADO"
                    id = 5
            End Select
            Return id
        End Function

        Private Function NombreEstadoCivilRNC(EstadoCivID As Integer) As String
            Dim strNombre As String = ""
            ' valores         -1= no se parecen,0=iguales
            Select Case EstadoCivID
                Case 1
                    strNombre = "SOLTERO"
                Case 2
                    strNombre = "CASADO"

                Case 3
                    strNombre = "VIUDO"

                Case 4
                    strNombre = "DIVORCIADO"
            End Select
            Return strNombre
        End Function
#End Region

        Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
            'BuscarReniec()
            BuscarReniecAPI()
        End Sub

        Private Sub rbDNI_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbDNI.CheckedChanged
            txtNumDoc.Enabled = True
            txtNumDoc.BackColor = Color.FromArgb(255, 255, 128)

            txtApePat.Enabled = False
            txtApeMat.Enabled = False
            txtNom.Enabled = False

            txtApePat.BackColor = Color.WhiteSmoke
            txtApeMat.BackColor = Color.WhiteSmoke
            txtNom.BackColor = Color.WhiteSmoke

            Limpiar()
            LimpiarCamposRNC()
        End Sub

        Private Sub rbNombres_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbNombres.CheckedChanged
            txtNumDoc.Enabled = False
            txtNumDoc.BackColor = Color.WhiteSmoke

            txtApePat.Enabled = True
            txtApeMat.Enabled = True
            txtNom.Enabled = True

            txtApePat.BackColor = Color.FromArgb(255, 255, 128)
            txtApeMat.BackColor = Color.FromArgb(255, 255, 128)
            txtNom.BackColor = Color.FromArgb(255, 255, 128)
        End Sub

        Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
            Limpiar()
            LimpiarCamposRNC()
        End Sub

        Private Async Sub btnDetalleRnc_Click(sender As System.Object, e As System.EventArgs) Handles btnDetalleRnc.Click
            If dgwGrillaListaReniec.Rows.Count = 0 Then Exit Sub

            Dim dni As String = ""
            dni = dgwGrillaListaReniec.Item("col_num_dni", dgwGrillaListaReniec.CurrentRow.Index).Value
            'BuscarPorDNI(dni)
            Await BuscarPorDNI_APIAsync(dni)
        End Sub

        Private Sub txtNumDoc_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumDoc.KeyPress
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            If Panel4.Visible = True Then
                If txtDni.Text.Trim.Length < 3 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Dentro de la lista izquierda seleccione un registro y luego presione sobre el botón [Ver detalle].")
                    Exit Sub
                End If
            Else
                If txtDni.Text.Trim.Length < 3 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los datos necesario y búsque presionando el botón [Buscar].")
                    Exit Sub
                End If
            End If
            
            If MsgBox("Se va registrar como nuevo interno a la persona con DNI: " & txtDni.Text & _
                      ", Nombres: " & txtPrimerApellido.Text & " " & txtSegundoApellido.Text & ", " & _
                      txtPrenombres.Text & ", Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                RegistrarNuevoInternoDesdeReniec()
            Else
                Exit Sub
            End If
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            If MsgBox("Se va a cancelar toda la operación de registro, Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            Else
                DialogResult = Windows.Forms.DialogResult.None
            End If
        End Sub

        Private Sub btnRegNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnRegNuevo.Click
            If MsgBox("Se va a omitir la validación con la RENIEC para registrar manualmente toda la información del interno... " & _
                      "Desea omitir RENIEC y continuar con el ingreso manual?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                Me._tipoAccion = enmAccion.NUEVO_INTERNO_SIN_RENIEC
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                Exit Sub
            End If
        End Sub
    End Class
End Namespace