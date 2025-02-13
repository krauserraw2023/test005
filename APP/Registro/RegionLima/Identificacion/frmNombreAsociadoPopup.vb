Imports System.Windows.Forms
Namespace Registro.RegionLima.Identificacion
    Public Class frmNombreAsociadoPopup

        Private objBssDoc As Bussines.Registro.Documento.NombresAsociados = Nothing
        Public objEntDoc As Entity.Registro.Documento.NombresAsociados = Nothing

        Private objBss As Bussines.Registro.NombreAsociado = Nothing
        Public objEnt As Entity.Registro.NombreAsociado = Nothing
        Public objEntNomAsoc As New Entity.Registro.NombreAsociado
        'Public objEntDocumen As New Entity.Registro.Documento.NombresAsociados
        'Public objEntDocumenCol As New Entity.Registro.Documento.NombresAsociadosCol
        'Public objEntDocumenCol2 As New Entity.Registro.Documento.NombresAsociadosCol
        Public objEntExpedienteTempoCol As Entity.Registro.ExpedienteCol = Nothing
        Private objEntExpPadre As Entity.Registro.InternoExpedientePadre = Nothing
        Private objBssExpedientePad As Bussines.Registro.InternoExpedientePadre = Nothing

#Region "Propiedades"

        Public Property _PenalLM As Boolean = False
        Public Property _IngresoInpeID() As Integer = -1

        Public Property DocumentoJudicialID() As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property IngresoID() As Integer = -1
        Private Property Principal() As Integer
            Get
                Dim value As Integer = -1

                If Me.rdbPrincipal.Checked = True Then
                    value = 1
                End If

                If Me.rdbAsociado.Checked = True Then
                    value = 0
                End If

                Return value

            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case 1
                        Me.rdbPrincipal.Checked = True
                    Case 0
                        Me.rdbAsociado.Checked = True
                    Case Else
                        Me.rdbPrincipal.Checked = False
                        Me.rdbAsociado.Checked = False
                End Select
            End Set
        End Property
        Private Property ApellidoPaterno() As String
            Get
                Return Legolas.Components.Cadena.LimpiarEspacios(Me.txtApePaterno.Text.Trim)
            End Get
            Set(ByVal value As String)
                Me.txtApePaterno.Text = value
            End Set
        End Property
        Private Property ApellidoMaterno() As String
            Get
                Return Legolas.Components.Cadena.LimpiarEspacios(Me.txtApeMaterno.Text.Trim)
            End Get
            Set(ByVal value As String)
                Me.txtApeMaterno.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Legolas.Components.Cadena.LimpiarEspacios(Me.txtNombre.Text.Trim)
            End Get
            Set(ByVal value As String)
                Me.txtNombre.Text = value
            End Set
        End Property

        Public Property DocumentoReferencia() As String
            Get
                Return txtDocRef.Text
            End Get
            Set(value As String)
                txtDocRef.Text = value
            End Set
        End Property
        Public Property Motivo() As String
            Get
                Return txtMotivo.Text
            End Get
            Set(value As String)
                txtMotivo.Text = value
            End Set
        End Property

        Private Property Estado() As Integer = 1
        Private Property PrincipalCopi() As Integer
        Public Property ApellidoPaternoCopi() As String
        Public Property ApellidoMaternoCopi() As String
        Public Property NombresCopi() As String
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Private Property RegistroBloqueado As Boolean = False
#End Region
#Region "Propiedades_Par"
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Public Property _RegionID() As Integer
            Get
                Return intRegionID
            End Get
            Set(ByVal value As Integer)
                intRegionID = value
            End Set
        End Property
        Public Property _PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
            End Set
        End Property
        'Public Property _RadioEnablet As Boolean = False
        Public Property _Nuevobln As Boolean = False
        'Public Property _ReferenciaEnablet As Boolean = False
        'Public Property _Documentos_sin_mov As Boolean = False
#End Region
#Region "Listar"
        Public Property _TipoFormu As Boolean = False
        Public Property _TipoAcion As Integer = -1
        Public Sub ListarData()
            If Me.InternoID < 1 Then
                Exit Sub
            End If
            With objEntNomAsoc
                'If Me._TipoFormu = False Then
                '    If Me._Nuevobln = True Then 
                Me.Principal = .Principal
                Me.ApellidoPaterno = .ApellidoPaterno
                Me.ApellidoMaterno = .ApellidoMaterno
                Me.Nombres = .Nombres
                Me.Estado = .Estado
                Me.DocumentoReferencia = .DocumentoReferencia
                Me.Motivo = .Observacion
                '    Else
                '        If Me._TipoFormu = False Then
                '            Select Case .Estado
                '                'Case -1, 0
                '                    'Me.Principal = .NAPrincipal
                '                    'Me.ApellidoPaterno = .NAPaterno
                '                    'Me.ApellidoMaterno = .NAMaterno
                '                    'Me.Nombres = .NANombres
                '                    'Me.Estado = .NAEstado
                '                    'If .NAEstado = 0 Then
                '                    '    .ValorRef = True
                '                    '    Me._RadioEnablet = True
                '                    'End If
                '                Case 1, 2
                '                    Me.Principal = .NAPrincipal2
                '                    Me.ApellidoPaterno = .NAPaterno2
                '                    Me.ApellidoMaterno = .NAMaterno2
                '                    Me.Nombres = .NANombres2
                '                    Me.Estado = .NAEstado
                '            End Select
                '        Else
                '            Me.Principal = .NAPrincipal
                '            Me.ApellidoPaterno = .NAPaterno
                '            Me.ApellidoMaterno = .NAMaterno
                '            Me.Nombres = .NANombres
                '            Me.Estado = .NAEstado
                '        End If
                '    End If
                'Else
                '    Me.Principal = .NAPrincipal
                '    Me.ApellidoPaterno = .NAPaterno
                '    Me.ApellidoMaterno = .NAMaterno
                '    Me.Nombres = .NANombres
                '    Me.Estado = .NAEstado
                'End If
                Me.PrincipalCopi = Me.Principal
                Me.ApellidoPaternoCopi = Me.ApellidoPaterno
                Me.ApellidoMaternoCopi = Me.ApellidoMaterno
                Me.NombresCopi = Me.Nombres

                'Me.DocumentoJudicialID = .DocumentoJudicialID
                Me.InternoID = .InternoID
                Me._PenalID = Me._PenalID
                Me._RegionID = Me._RegionID

                'If ValidarExpedienteReferenciado(7) = False Then
                '    Me._ReferenciaEnablet = True
                '    InhabilitarControles()
                '    Exit Sub
                'End If
                'If .ValorRef = True Then
                '    InhabilitarControles()
                'End If
                'If Me._RadioEnablet = True Then
                '    InhabilitarControles()
                'End If
                Me.UscAuditUser1.LoadAudit(objEntNomAsoc.Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoNombreAsociado)
            End With

            Dim entRegNA As New Entity.Registro.Documento.NombresAsociados
            Dim entRegNACol As New Entity.Registro.Documento.NombresAsociadosCol
            entRegNA.InternoNombreAsociadoID = Codigo
            entRegNACol = (New Bussines.Registro.Documento.NombresAsociados).ListarLM(entRegNA)

            If entRegNACol.Count > 0 Then 'NombreAsociado creado por documento
                RegistroBloqueado = True
            End If
        End Sub
        'Public Function ValidarExpedienteReferenciado(Condicion As String) As Boolean
        '    If Me._DocumentoJudicialID > 0 Then
        '        Dim strMensaje As String = ""
        '        Dim intValorpadre As Integer = 0
        '        objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
        '        Select Case Condicion
        '            Case 1
        '                strMensaje = "no se puede agregar expedientes"
        '            Case 2
        '                strMensaje = "no se puede agregar delitos"
        '            Case 3
        '                strMensaje = "no se puede agregar agraviados"
        '            Case 4
        '                strMensaje = "No se puede modificar el documento porque forma parte del expediente"
        '            Case 7
        '                strMensaje = " [Operación cancelada]"
        '        End Select

        '        For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteTempoCol
        '            objEntExpPadre = New Entity.Registro.InternoExpedientePadre
        '            If objEntExpediente.Codigo > 0 Then
        '                objEntExpPadre.InternoExpedienteId = objEntExpediente.Codigo
        '                Dim blnValor As Boolean = objBssExpedientePad.ValidarExpediente(objEntExpPadre)
        '                If blnValor = False Then
        '                    intValorpadre = intValorpadre + 1
        '                End If
        '            End If
        '        Next


        '        If intValorpadre > 0 Then
        '            'Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado," & strMensaje)
        '            Return False
        '        End If
        '    End If
        '    Return True
        'End Function
        Private Sub InhabilitarControles()
            txtApePaterno.ReadOnly = True
            txtApeMaterno.ReadOnly = True
            txtNombre.ReadOnly = True
            txtDocRef.ReadOnly = True
            txtMotivo.ReadOnly = True
            gbTiponombre.Enabled = False
        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean
            '/*Primer apellido*/
            If Me.ApellidoPaterno.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el Primer Apellido del Interno")
                Me.txtApePaterno.Focus()
                Return False
            End If
            '/*segundo apellido*/
            If Me.ApellidoMaterno.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el Segundo Apellido del Interno")
                Me.txtApeMaterno.Focus()
                Return False
            End If
            '/*nombres*/
            If Me.Nombres.Trim.Length < 2 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el nombre asociado del Interno")
                Me.txtNombre.Focus()
                Return False
            End If
            If Me.Principal < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el tipo de nombre asociado")
                Return False
            End If
            'Dim blnNombre As Boolean = False
            'Dim blnNombre2 As Boolean = False
            'Dim blnNombreBD As Boolean = False
            'Dim blnNombreAcla As Boolean = False

            'objEnt = New Entity.Registro.NombreAsociado
            'objBss = New Bussines.Registro.NombreAsociado
            'objEnt.ApellidoPaterno = Me.ApellidoPaterno
            'objEnt.ApellidoMaterno = Me.ApellidoMaterno
            'objEnt.Nombres = Me.Nombres
            'objEnt.InternoID = Me.InternoID
            'objEnt.IngresoID = Me.IngresoID
            'objEnt.IngresoInpeID = Me._IngresoInpeID
            'If Me._TipoAcion = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aclarado Then
            '    If Me.DocumentoJudicialID < 1 Then
            '        If objEntDoc.NAEstado = -1 Then
            '            If Me.Principal = Me.PrincipalCopi And Me.ApellidoPaterno = Me.ApellidoPaternoCopi And
            '               Me.ApellidoMaterno = Me.ApellidoMaternoCopi And Me.Nombres = Me.NombresCopi Then
            '                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                        "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                        "no ha sido modificado.")
            '                Return False
            '            End If

            '            For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
            '                If objEnt.NAPaterno = Me.ApellidoPaternoCopi And objEnt.NAMaterno = Me.ApellidoMaternoCopi And objEnt.NANombres = Me.NombresCopi Then
            '                Else
            '                    If objEnt.NAPaterno = Me.ApellidoPaterno And objEnt.NAMaterno = Me.ApellidoMaterno And objEnt.NANombres = Me.Nombres Then
            '                        blnNombreBD = True
            '                        Exit For
            '                    End If
            '                End If
            '            Next
            '            If blnNombreBD = True Then
            '                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                        "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                        "se encuentra en la Lista de Nombres Asociados.")
            '                Return False
            '            End If
            '            For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
            '                If objEnt.NAPaterno2 = Me.ApellidoPaternoCopi And objEnt.NAMaterno2 = Me.ApellidoMaternoCopi And
            '                    objEnt.NANombres2 = Me.NombresCopi Then
            '                Else
            '                    If objEnt.NAPaterno2 = Me.ApellidoPaterno And objEnt.NAMaterno2 = Me.ApellidoMaterno And
            '                  objEnt.NANombres2 = Me.Nombres Then
            '                        blnNombreAcla = True
            '                        Exit For
            '                    End If
            '                End If
            '            Next
            '            If blnNombreAcla = True Then
            '                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                        "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                        "se encuentra en la Lista de Nombres Aclarados.")
            '                Return False
            '            End If
            '        ElseIf objEntDoc.NAEstado = 1 Then
            '            If objEntDoc.NAPrincipal = Me.Principal And objEntDoc.NAPaterno = Me.ApellidoPaterno And
            '           objEntDoc.NAMaterno = Me.ApellidoMaterno And objEntDoc.NANombres = Me.Nombres Then
            '                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                        "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                        "no ha sido modificado.")
            '                Return False
            '            End If

            '            If Not (objEntDocumenCol2 Is Nothing) Then
            '                For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
            '                    If objEnt.NAPaterno = objEntDoc.NAPaterno And objEnt.NAMaterno = objEntDoc.NAMaterno And
            '                       objEnt.NANombres = objEntDoc.NANombres Then
            '                    Else
            '                        If objEnt.NAPaterno = Me.ApellidoPaterno And objEnt.NAMaterno = Me.ApellidoMaterno And
            '                        objEnt.NANombres = Me.Nombres Then
            '                            blnNombreBD = True
            '                            Exit For
            '                        End If
            '                    End If

            '                Next
            '                If blnNombreBD = True Then
            '                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                            "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                            "se encuentra en la Lista de Nombres Asociados.")
            '                    Return False
            '                End If
            '                For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
            '                    If objEnt.NAPaterno2 = Me.ApellidoPaternoCopi And objEnt.NAMaterno2 = Me.ApellidoMaternoCopi And
            '                        objEnt.NANombres2 = Me.NombresCopi Then
            '                    Else
            '                        If objEnt.NAPaterno2 = Me.ApellidoPaterno And objEnt.NAMaterno2 = Me.ApellidoMaterno And
            '                      objEnt.NANombres2 = Me.Nombres Then
            '                            blnNombreAcla = True
            '                            Exit For
            '                        End If
            '                    End If
            '                Next
            '                If blnNombreAcla = True Then
            '                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                            "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                            "se encuentra en la Lista de Nombres Aclarados.")
            '                    Return False
            '                End If
            '            End If
            '        ElseIf objEntDoc.NAEstado = 2 Then

            '            If Not (objEntDocumenCol2 Is Nothing) Then
            '                For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
            '                    If objEnt.NAPaterno = objEntDoc.NAPaterno And objEnt.NAMaterno = objEntDoc.NAMaterno And
            '                       objEnt.NANombres = objEntDoc.NANombres Then
            '                    Else
            '                        If objEnt.NAPaterno = Me.ApellidoPaterno And objEnt.NAMaterno = Me.ApellidoMaterno And
            '                        objEnt.NANombres = Me.Nombres Then
            '                            blnNombreBD = True
            '                            Exit For
            '                        End If
            '                    End If

            '                Next
            '                If blnNombreBD = True Then
            '                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                            "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                            "se encuentra en la Lista de Nombres Asociados.")
            '                    Return False
            '                End If
            '                For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
            '                    If objEnt.NAPaterno2 = Me.ApellidoPaternoCopi And objEnt.NAMaterno2 = Me.ApellidoMaternoCopi And
            '                        objEnt.NANombres2 = Me.NombresCopi Then
            '                    Else
            '                        If objEnt.NAPaterno2 = Me.ApellidoPaterno And objEnt.NAMaterno2 = Me.ApellidoMaterno And
            '                      objEnt.NANombres2 = Me.Nombres Then
            '                            blnNombreAcla = True
            '                            Exit For
            '                        End If
            '                    End If
            '                Next
            '                If blnNombreAcla = True Then
            '                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                            "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                            "se encuentra en la Lista de Nombres Aclarados.")
            '                    Return False
            '                End If
            '            End If
            '        End If

            '    Else
            '        If objEntDoc.NAEstado = -1 Then

            '            If Me.Principal = Me.PrincipalCopi And Me.ApellidoPaterno = Me.ApellidoPaternoCopi And
            '               Me.ApellidoMaterno = Me.ApellidoMaternoCopi And Me.Nombres = Me.NombresCopi Then
            '                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                        "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                        "no ha sido modificado.")
            '                Return False
            '            End If

            '            For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
            '                If objEnt.NAPaterno = Me.ApellidoPaternoCopi And objEnt.NAMaterno = Me.ApellidoMaternoCopi And objEnt.NANombres = Me.NombresCopi Then
            '                Else
            '                    If objEnt.NAPaterno = Me.ApellidoPaterno And objEnt.NAMaterno = Me.ApellidoMaterno And objEnt.NANombres = Me.Nombres Then
            '                        blnNombreBD = True
            '                        Exit For
            '                    End If
            '                End If
            '            Next
            '            If blnNombreBD = True Then
            '                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                        "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                        "se encuentra en la Lista de Nombres Asociados.")
            '                Return False
            '            End If
            '            For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
            '                If objEnt.NAPaterno2 = Me.ApellidoPaternoCopi And objEnt.NAMaterno2 = Me.ApellidoMaternoCopi And
            '                    objEnt.NANombres2 = Me.NombresCopi Then
            '                Else
            '                    If objEnt.NAPaterno2 = Me.ApellidoPaterno And objEnt.NAMaterno2 = Me.ApellidoMaterno And
            '                  objEnt.NANombres2 = Me.Nombres Then
            '                        blnNombreAcla = True
            '                        Exit For
            '                    End If
            '                End If
            '            Next
            '            If blnNombreAcla = True Then
            '                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                        "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                        "se encuentra en la Lista de Nombres Aclarados.")
            '                Return False
            '            End If


            '        Else
            '            If objEntDoc.NAPrincipal = Me.Principal And objEntDoc.NAPaterno = Me.ApellidoPaterno And
            '          objEntDoc.NAMaterno = Me.ApellidoMaterno And objEntDoc.NANombres = Me.Nombres Then
            '                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                        "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                        "no ha sido modificado.")
            '                Return False
            '            End If
            '            If Not (objEntDocumenCol2 Is Nothing) Then
            '                For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
            '                    If objEnt.NAPaterno = Me.ApellidoPaternoCopi And objEnt.NAMaterno = Me.ApellidoMaternoCopi And
            '                        objEnt.NANombres = Me.NombresCopi Then
            '                    Else

            '                        If objEnt.NAPaterno = Me.ApellidoPaterno And objEnt.NAMaterno = Me.ApellidoMaterno And
            '                       objEnt.NANombres = Me.Nombres Then
            '                            blnNombreBD = True
            '                            Exit For
            '                        End If
            '                    End If
            '                Next
            '                If blnNombreBD = True Then
            '                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                            "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                            "se encuentra en la Lista de Nombres Asociados.")
            '                    Return False
            '                End If
            '                For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
            '                    If objEnt.NAPaterno2 = Me.ApellidoPaternoCopi And objEnt.NAMaterno2 = Me.ApellidoMaternoCopi And
            '                        objEnt.NANombres2 = Me.NombresCopi Then
            '                    Else
            '                        If objEnt.NAPaterno2 = Me.ApellidoPaterno And objEnt.NAMaterno2 = Me.ApellidoMaterno And
            '                            objEnt.NANombres2 = Me.Nombres Then
            '                            blnNombreAcla = True
            '                            Exit For
            '                        End If
            '                    End If
            '                Next
            '                If blnNombreAcla = True Then
            '                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                            "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                            "se encuentra en la Lista de Nombres Aclarados.")
            '                    Return False
            '                End If
            '            End If
            '        End If

            '    End If
            '    '''''''''

            '    If Me.ApellidoPaterno <> Me.ApellidoPaternoCopi Or Me.ApellidoMaterno <> Me.ApellidoMaternoCopi _
            '        Or Me.Nombres <> Me.NombresCopi Then
            '        objEnt.Codigo = Me.Codigo
            '        If Me._PenalLM = True Then
            '            Dim NroIngreso As Integer = objBss.ValidarNombre_LM(objEnt)
            '            If NroIngreso > 0 Then
            '                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                              "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                              "ha sido registrado en el ingreso Nro. " & NroIngreso)
            '                Return False
            '            End If
            '        Else
            '            Dim NroIngreso As Integer = objBss.ValidarNombre2(objEnt)
            '            If NroIngreso > 0 Then
            '                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                              "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                              "ha sido registrado en el ingreso Nro. " & NroIngreso)
            '                Return False
            '            End If
            '        End If

            '    End If

            'ElseIf Me._TipoAcion = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aniadido Then
            '    If Not (objEntDocumenCol2 Is Nothing) Then
            '        For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
            '            If Me.ApellidoPaterno = objEnt.NAPaterno And Me.ApellidoMaterno = objEnt.NAMaterno And
            '                Me.Nombres = objEnt.NANombres Then
            '                blnNombreBD = True
            '                Exit For
            '            End If
            '        Next
            '        If blnNombreBD = True Then
            '            Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                    "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                    "se encuentra en la Lista de Nombres Asociados.")
            '            Return False
            '        End If
            '        For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
            '            If objEnt.NAPaterno2 = Me.ApellidoPaterno And objEnt.NAMaterno2 = Me.ApellidoMaterno And
            '                objEnt.NANombres2 = Me.Nombres Then
            '                blnNombreAcla = True
            '                Exit For
            '            End If
            '        Next
            '        If blnNombreAcla = True Then
            '            Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                    "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                    "se encuentra en la Lista de Nombres Aclarados.")
            '            Return False
            '        End If
            '    End If
            '    objEnt.Codigo = Me.Codigo
            '    If Me._PenalLM = True Then
            '        Dim NroIngreso As Integer = objBss.ValidarNombre_LM(objEnt)
            '        If NroIngreso > 0 Then
            '            Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                          "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                          "ha sido registrado en el ingreso Nro. " & NroIngreso)
            '            Return False
            '        End If
            '    Else
            '        Dim NroIngreso As Integer = objBss.ValidarNombre2(objEnt)
            '        If NroIngreso > 0 Then
            '            Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
            '                                                                          "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
            '                                                                          "ha sido registrado en el ingreso Nro. " & NroIngreso)
            '            Return False
            '        End If
            '    End If

            'End If


            Return True
        End Function
        Private Function Validar2() As Boolean

            Dim blnValor As Boolean = False
            If Me.ApellidoPaterno.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el Primer Apellido del Interno")
                Me.txtApePaterno.Focus()
            ElseIf Me.ApellidoMaterno.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el Segundo Apellido del Interno")
                Me.txtApeMaterno.Focus()
            ElseIf Me.Nombres.Trim.Length < 2 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el nombre asociado del Interno")
                Me.txtNombre.Focus()
            Else
                objEnt = New Entity.Registro.NombreAsociado
                objBss = New Bussines.Registro.NombreAsociado
                objEnt.ApellidoPaterno = Me.ApellidoPaterno
                objEnt.ApellidoMaterno = Me.ApellidoMaterno
                objEnt.Nombres = Me.Nombres
                objEnt.InternoID = Me.InternoID

                If Me.ApellidoPaterno = ApellidoPaternoCopi And Me.ApellidoMaterno = ApellidoMaternoCopi And Me.Nombres = Me.NombresCopi Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El nombre ingresado, ya esta registrado como nombre principal del interno.")
                    Me.txtApePaterno.Focus()
                Else
                    If Me.Codigo = -1 Then 'si es nuevo
                        If objBss.ValidarNombre(objEnt) = False Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El nombre ingresado, ya esta registrado como nombre asociado del interno.")
                            Me.txtApePaterno.Focus()
                        Else
                            blnValor = True
                        End If
                    Else 'si es editar
                        Dim objEntCol As New Entity.Registro.NombreAsociadoCol
                        objEntCol = objBss.Listar_LM(objEnt)
                        If objEntCol.Count > 1 Then 'hay mas de uno
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El nombre ingresado, ya esta registrado como nombre asociado del interno.")
                            Me.txtApePaterno.Focus()
                        ElseIf objEntCol.Count = 1 Then
                            objEnt = objEntCol.NombreAsociado(0)
                            If objEnt.Codigo <> Me.Codigo Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("El nombre ingresado, ya esta registrado como nombre asociado del interno.")
                                Me.txtApePaterno.Focus()
                            Else
                                blnValor = True
                            End If
                        Else
                            blnValor = True
                        End If
                    End If
                End If
            End If
            Return blnValor
        End Function

        Private Sub AGrabar_v2()
            If Validar2() = True Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                    objEnt = New Entity.Registro.NombreAsociado
                    With objEnt
                        .FlagTransferenciaSede = 1
                        .Codigo = Me.Codigo
                        .ApellidoPaterno = Me.ApellidoPaterno
                        .ApellidoMaterno = Me.ApellidoMaterno
                        .Nombres = Me.Nombres
                        .Principal = Me.Principal
                        .Estado = Me.Estado
                        .InternoID = Me.InternoID
                        .IngresoID = Me.IngresoID
                        .IngresoInpeID = Me._IngresoInpeID
                        .RegionID = Me._RegionID
                        .PenalID = Me._PenalID
                        .DocumentoReferencia = Me.DocumentoReferencia
                        .Observacion = Me.Motivo
                    End With
                    objBss = New Bussines.Registro.NombreAsociado

                    objBss.GrabarSinDoc_ORL(objEnt)

                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If
        End Sub
#End Region
#Region "usuarios_Permisos"
        Private Sub UsuarioPermisos()

            Dim blnGrabar As Boolean = False
            If Me.RegistroBloqueado Then
                InhabilitarControles()
            Else
                blnGrabar = True
            End If

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.pnlSalir.Visible = True
            Me.Panel4.Visible = blnGrabar

        End Sub
#End Region
#Region "Otros"
        Public Sub _VisibleRadioButonNombresAsociados()
            'gbTiponombre.Enabled = True
        End Sub
#End Region

        Private Sub frmNombreAsociadoPopup2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            'If Me._Documentos_sin_mov = True Then
            '    'rdbPrincipal.Enabled = False
            '    'rdbAsociado.Enabled = False
            'End If
        End Sub
        Private Sub frmNombreAsociadoPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            UsuarioPermisos()
            'ListarData()
            txtApePaterno.Focus()
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub
        Public Sub New(ByRef objEntNomAsoc As Entity.Registro.Documento.NombresAsociados)
            InitializeComponent()
            objEntDoc = objEntNomAsoc
        End Sub

        Private Sub rdbAsociado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbAsociado.CheckedChanged

        End Sub



        Private Sub rdbPrincipal_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles rdbPrincipal.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub rdbAsociado_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles rdbAsociado.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            'If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
            'Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
            AGrabar_v2()
            'Else
            'If Me._RadioEnablet = True Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation(
            '     "El nombre asociado solo es de visualización, operación cancelada.")
            '    Exit Sub
            'End If
            'If Me._ReferenciaEnablet = True Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado, [Operación cancelada]")
            '    Exit Sub
            'End If
            'If Me._RadioEnablet = False Then
            '    AGrabar2()
            '    'Else
            '    '    AGrabar()
            'End If
            'End If
        End Sub
    End Class
End Namespace