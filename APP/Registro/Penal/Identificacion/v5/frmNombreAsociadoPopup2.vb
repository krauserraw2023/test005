Option Explicit On
Imports System.Linq
Imports System.Windows.Forms
Namespace Registro.Identificacion
    Public Class frmNombreAsociadoPopup2

        Private objBssDoc As Bussines.Registro.Documento.NombresAsociados = Nothing
        Public objEntDoc As Entity.Registro.Documento.NombresAsociados = Nothing

        Private objBss As Bussines.Registro.NombreAsociado = Nothing
        Public objEnt As Entity.Registro.NombreAsociado = Nothing
        Public objEntDocumen As New Entity.Registro.Documento.NombresAsociados
        Public objEntDocumenCol As New Entity.Registro.Documento.NombresAsociadosCol
        Public objEntDocumenCol2 As New Entity.Registro.Documento.NombresAsociadosCol
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
        Public Property _TipoResolucion As Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ninguno

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
        Private Property Estado() As Integer = 1
        Private Property PrincipalCopi() As Integer
        Public Property ApellidoPaternoCopi() As String
        Public Property ApellidoMaternoCopi() As String
        Public Property NombresCopi() As String
        Public _TipoFormulario As Integer = -1
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Private ReadOnly Property FlagTransferSede As Integer
            Get
                Dim v As Integer = 0
                If _TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                    v = 1
                End If
                Return v
            End Get
        End Property
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
        Public Property _RadioEnablet As Boolean = False
        Public Property _Nuevobln As Boolean = False
        Public Property _ReferenciaEnablet As Boolean = False
        Public Property _Documentos_sin_mov As Boolean = False
#End Region
#Region "Listar"
        Public _TipoFormu As Boolean = False
        Public _TipoAcion As Integer = -1
        Public Sub ListarData()
            If Me.InternoID < 1 Then
                Exit Sub
            End If
            With objEntDocumen
                If Me._TipoFormu = False Then
                    If Me._Nuevobln = True Then
                        Me.Principal = .NAPrincipal
                        Me.ApellidoPaterno = .NAPaterno
                        Me.ApellidoMaterno = .NAMaterno
                        Me.Nombres = .NANombres
                        Me.Estado = .NAEstado
                    Else
                        If Me._TipoFormu = False Then
                            Select Case .NAEstado
                                Case -1, 0
                                    Me.Principal = .NAPrincipal
                                    Me.ApellidoPaterno = .NAPaterno
                                    Me.ApellidoMaterno = .NAMaterno
                                    Me.Nombres = .NANombres
                                    Me.Estado = .NAEstado
                                    If .NAEstado = 0 Then
                                        .ValorRef = True
                                        Me._RadioEnablet = True
                                    End If
                                Case 1, 2
                                    Me.Principal = .NAPrincipal2
                                    Me.ApellidoPaterno = .NAPaterno2
                                    Me.ApellidoMaterno = .NAMaterno2
                                    Me.Nombres = .NANombres2
                                    Me.Estado = .NAEstado
                            End Select
                        Else
                            Me.Principal = .NAPrincipal
                            Me.ApellidoPaterno = .NAPaterno
                            Me.ApellidoMaterno = .NAMaterno
                            Me.Nombres = .NANombres
                            Me.Estado = .NAEstado
                        End If
                    End If
                Else
                    Me.Principal = .NAPrincipal
                    Me.ApellidoPaterno = .NAPaterno
                    Me.ApellidoMaterno = .NAMaterno
                    Me.Nombres = .NANombres
                    Me.Estado = .NAEstado
                End If
                Me.PrincipalCopi = Me.Principal
                Me.ApellidoPaternoCopi = Me.ApellidoPaterno
                Me.ApellidoMaternoCopi = Me.ApellidoMaterno
                Me.NombresCopi = Me.Nombres

                Me.DocumentoJudicialID = .DocumentoJudicialID
                Me.InternoID = .InternoID
                Me._PenalID = Me._PenalID
                Me._RegionID = Me._RegionID
                If Me._TipoResolucion <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ampliacion_Autoapertorio Then
                    'If objEntDocumen.DocumentoJudicialID <> "1122993" Then
                    If ValidarExpedienteReferenciado(7) = False Then
                        Me._ReferenciaEnablet = True
                        InhabilitarControles()
                        Exit Sub
                    End If
                End If
                If .ValorRef = True Then
                    InhabilitarControles()
                End If
                If Me._RadioEnablet = True Then
                    InhabilitarControles()
                End If
                Me.UscAuditUser1.LoadAudit(objEntDocumen.InternoNombreAsociadoID, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoNombreAsociado)
            End With
        End Sub
        Public Function ValidarExpedienteReferenciado(Condicion As String) As Boolean
            If Me._DocumentoJudicialID > 0 Then
                Dim strMensaje As String = ""
                Dim intValorpadre As Integer = 0
                objBssExpedientePad = New Bussines.Registro.InternoExpedientePadre
                Select Case Condicion
                    Case 1
                        strMensaje = "no se puede agregar expedientes"
                    Case 2
                        strMensaje = "no se puede agregar delitos"
                    Case 3
                        strMensaje = "no se puede agregar agraviados"
                    Case 4
                        strMensaje = "No se puede modificar el documento porque forma parte del expediente"
                    Case 7
                        strMensaje = " [Operación cancelada]"
                End Select

                For Each objEntExpediente As Entity.Registro.Expediente In objEntExpedienteTempoCol
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    If objEntExpediente.Codigo > 0 Then
                        objEntExpPadre.InternoExpedienteId = objEntExpediente.Codigo
                        Dim blnValor As Boolean = objBssExpedientePad.ValidarExpediente(objEntExpPadre)
                        If blnValor = False Then
                            intValorpadre = intValorpadre + 1
                        End If
                    End If
                Next


                If intValorpadre > 0 Then
                    'Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado," & strMensaje)
                    Return False
                End If
            End If
            Return True
        End Function
        Private Sub InhabilitarControles()
            txtApePaterno.ReadOnly = True
            txtApeMaterno.ReadOnly = True
            txtNombre.ReadOnly = True
            gbTiponombre.Enabled = False
        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            '/*primer apellido*/
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

            'apellidos 
            If Me.ApellidoPaterno.Trim.Substring(0, 1) = "." And Me.ApellidoMaterno.Trim.Substring(0, 1) = "." Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Apellidos no validos, debe ingresar por lo menos un apellido!")
                Me.txtApePaterno.Focus()
                Return False
            End If

            'validar puntos del primer apellido
            Dim intContarPriApe As Integer = (From c In Me.ApellidoPaterno Where c = "." Select c).Count()
            If intContarPriApe > 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Primer Apellido tiene mas un caracter especial permitido")
                Return False
            End If

            'validar puntos del segundo apellido
            Dim intContarSegApe As Integer = (From c In Me.ApellidoMaterno Where c = "." Select c).Count()
            If intContarSegApe > 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Segundo Apellido tiene mas un caracter especial permitido")
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

            Dim blnNombre As Boolean = False
            Dim blnNombre2 As Boolean = False
            Dim blnNombreBD As Boolean = False
            Dim blnNombreAcla As Boolean = False

            objEnt = New Entity.Registro.NombreAsociado
            objBss = New Bussines.Registro.NombreAsociado
            objEnt.ApellidoPaterno = Me.ApellidoPaterno
            objEnt.ApellidoMaterno = Me.ApellidoMaterno
            objEnt.Nombres = Me.Nombres
            objEnt.InternoID = Me.InternoID
            objEnt.IngresoID = Me.IngresoID
            objEnt.IngresoInpeID = Me._IngresoInpeID
            If Me._TipoAcion = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aclarado Then
                If Me.DocumentoJudicialID < 1 Then
                    If objEntDoc.NAEstado = -1 Then
                        If Me.Principal = Me.PrincipalCopi And Me.ApellidoPaterno = Me.ApellidoPaternoCopi And
                           Me.ApellidoMaterno = Me.ApellidoMaternoCopi And Me.Nombres = Me.NombresCopi Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                    "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                    "no ha sido modificado.")
                            Return False
                        End If

                        For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
                            If objEnt.NAPaterno = Me.ApellidoPaternoCopi And objEnt.NAMaterno = Me.ApellidoMaternoCopi And objEnt.NANombres = Me.NombresCopi Then
                            Else
                                If objEnt.NAPaterno = Me.ApellidoPaterno And objEnt.NAMaterno = Me.ApellidoMaterno And objEnt.NANombres = Me.Nombres Then
                                    blnNombreBD = True
                                    Exit For
                                End If
                            End If
                        Next
                        If blnNombreBD = True Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                    "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                    "se encuentra en la Lista de Nombres Asociados.")
                            Return False
                        End If
                        For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
                            If objEnt.NAPaterno2 = Me.ApellidoPaternoCopi And objEnt.NAMaterno2 = Me.ApellidoMaternoCopi And
                                objEnt.NANombres2 = Me.NombresCopi Then
                            Else
                                If objEnt.NAPaterno2 = Me.ApellidoPaterno And objEnt.NAMaterno2 = Me.ApellidoMaterno And
                              objEnt.NANombres2 = Me.Nombres Then
                                    blnNombreAcla = True
                                    Exit For
                                End If
                            End If
                        Next
                        If blnNombreAcla = True Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                    "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                    "se encuentra en la Lista de Nombres Aclarados.")
                            Return False
                        End If
                    ElseIf objEntDoc.NAEstado = 1 Then
                        If objEntDoc.NAPrincipal = Me.Principal And objEntDoc.NAPaterno = Me.ApellidoPaterno And
                       objEntDoc.NAMaterno = Me.ApellidoMaterno And objEntDoc.NANombres = Me.Nombres Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                    "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                    "no ha sido modificado.")
                            Return False
                        End If

                        If Not (objEntDocumenCol2 Is Nothing) Then
                            For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
                                If objEnt.NAPaterno = objEntDoc.NAPaterno And objEnt.NAMaterno = objEntDoc.NAMaterno And
                                   objEnt.NANombres = objEntDoc.NANombres Then
                                Else
                                    If objEnt.NAPaterno = Me.ApellidoPaterno And objEnt.NAMaterno = Me.ApellidoMaterno And
                                    objEnt.NANombres = Me.Nombres Then
                                        blnNombreBD = True
                                        Exit For
                                    End If
                                End If

                            Next
                            If blnNombreBD = True Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                        "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                        "se encuentra en la Lista de Nombres Asociados.")
                                Return False
                            End If
                            For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
                                If objEnt.NAPaterno2 = Me.ApellidoPaternoCopi And objEnt.NAMaterno2 = Me.ApellidoMaternoCopi And
                                    objEnt.NANombres2 = Me.NombresCopi Then
                                Else
                                    If objEnt.NAPaterno2 = Me.ApellidoPaterno And objEnt.NAMaterno2 = Me.ApellidoMaterno And
                                  objEnt.NANombres2 = Me.Nombres Then
                                        blnNombreAcla = True
                                        Exit For
                                    End If
                                End If
                            Next
                            If blnNombreAcla = True Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                        "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                        "se encuentra en la Lista de Nombres Aclarados.")
                                Return False
                            End If
                        End If
                    ElseIf objEntDoc.NAEstado = 2 Then

                        If Not (objEntDocumenCol2 Is Nothing) Then
                            For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
                                If objEnt.NAPaterno = objEntDoc.NAPaterno And objEnt.NAMaterno = objEntDoc.NAMaterno And
                                   objEnt.NANombres = objEntDoc.NANombres Then
                                Else
                                    If objEnt.NAPaterno = Me.ApellidoPaterno And objEnt.NAMaterno = Me.ApellidoMaterno And
                                    objEnt.NANombres = Me.Nombres Then
                                        blnNombreBD = True
                                        Exit For
                                    End If
                                End If

                            Next
                            If blnNombreBD = True Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                        "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                        "se encuentra en la Lista de Nombres Asociados.")
                                Return False
                            End If
                            For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
                                If objEnt.NAPaterno2 = Me.ApellidoPaternoCopi And objEnt.NAMaterno2 = Me.ApellidoMaternoCopi And
                                    objEnt.NANombres2 = Me.NombresCopi Then
                                Else
                                    If objEnt.NAPaterno2 = Me.ApellidoPaterno And objEnt.NAMaterno2 = Me.ApellidoMaterno And
                                  objEnt.NANombres2 = Me.Nombres Then
                                        blnNombreAcla = True
                                        Exit For
                                    End If
                                End If
                            Next
                            If blnNombreAcla = True Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                        "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                        "se encuentra en la Lista de Nombres Aclarados.")
                                Return False
                            End If
                        End If
                    End If

                Else
                    If objEntDoc.NAEstado = -1 Then

                        If Me.Principal = Me.PrincipalCopi And Me.ApellidoPaterno = Me.ApellidoPaternoCopi And
                           Me.ApellidoMaterno = Me.ApellidoMaternoCopi And Me.Nombres = Me.NombresCopi Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                    "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                    "no ha sido modificado.")
                            Return False
                        End If

                        For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
                            If objEnt.NAPaterno = Me.ApellidoPaternoCopi And objEnt.NAMaterno = Me.ApellidoMaternoCopi And objEnt.NANombres = Me.NombresCopi Then
                            Else
                                If objEnt.NAPaterno = Me.ApellidoPaterno And objEnt.NAMaterno = Me.ApellidoMaterno And objEnt.NANombres = Me.Nombres Then
                                    blnNombreBD = True
                                    Exit For
                                End If
                            End If
                        Next
                        If blnNombreBD = True Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                    "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                    "se encuentra en la Lista de Nombres Asociados.")
                            Return False
                        End If
                        For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
                            If objEnt.NAPaterno2 = Me.ApellidoPaternoCopi And objEnt.NAMaterno2 = Me.ApellidoMaternoCopi And
                                objEnt.NANombres2 = Me.NombresCopi Then
                            Else
                                If objEnt.NAPaterno2 = Me.ApellidoPaterno And objEnt.NAMaterno2 = Me.ApellidoMaterno And
                              objEnt.NANombres2 = Me.Nombres Then
                                    blnNombreAcla = True
                                    Exit For
                                End If
                            End If
                        Next
                        If blnNombreAcla = True Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                    "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                    "se encuentra en la Lista de Nombres Aclarados.")
                            Return False
                        End If


                    Else
                        If objEntDoc.NAPrincipal = Me.Principal And objEntDoc.NAPaterno = Me.ApellidoPaterno And
                      objEntDoc.NAMaterno = Me.ApellidoMaterno And objEntDoc.NANombres = Me.Nombres Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                    "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                    "no ha sido modificado.")
                            Return False
                        End If
                        If Not (objEntDocumenCol2 Is Nothing) Then
                            For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
                                If objEnt.NAPaterno = Me.ApellidoPaternoCopi And objEnt.NAMaterno = Me.ApellidoMaternoCopi And
                                    objEnt.NANombres = Me.NombresCopi Then
                                Else

                                    If objEnt.NAPaterno = Me.ApellidoPaterno And objEnt.NAMaterno = Me.ApellidoMaterno And
                                   objEnt.NANombres = Me.Nombres Then
                                        blnNombreBD = True
                                        Exit For
                                    End If
                                End If
                            Next
                            If blnNombreBD = True Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                        "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                        "se encuentra en la Lista de Nombres Asociados.")
                                Return False
                            End If
                            For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
                                If objEnt.NAPaterno2 = Me.ApellidoPaternoCopi And objEnt.NAMaterno2 = Me.ApellidoMaternoCopi And
                                    objEnt.NANombres2 = Me.NombresCopi Then
                                Else
                                    If objEnt.NAPaterno2 = Me.ApellidoPaterno And objEnt.NAMaterno2 = Me.ApellidoMaterno And
                                        objEnt.NANombres2 = Me.Nombres Then
                                        blnNombreAcla = True
                                        Exit For
                                    End If
                                End If
                            Next
                            If blnNombreAcla = True Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                        "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                        "se encuentra en la Lista de Nombres Aclarados.")
                                Return False
                            End If
                        End If
                    End If

                End If
                '''''''''

                If Me.ApellidoPaterno <> Me.ApellidoPaternoCopi Or Me.ApellidoMaterno <> Me.ApellidoMaternoCopi _
                    Or Me.Nombres <> Me.NombresCopi Then
                    objEnt.Codigo = Me.Codigo
                    If Me._PenalLM = True Then
                        Dim NroIngreso As Integer = objBss.ValidarNombre_LM(objEnt)
                        If NroIngreso > 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                          "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                          "ha sido registrado en el ingreso Nro. " & NroIngreso)
                            Return False
                        End If
                    Else
                        Dim NroIngreso As Integer = objBss.ValidarNombre2(objEnt)
                        If NroIngreso > 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                          "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                          "ha sido registrado en el ingreso Nro. " & NroIngreso)
                            Return False
                        End If
                    End If

                End If

            ElseIf Me._TipoAcion = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aniadido Then
                If Not (objEntDocumenCol2 Is Nothing) Then
                    For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
                        If Me.ApellidoPaterno = objEnt.NAPaterno And Me.ApellidoMaterno = objEnt.NAMaterno And
                            Me.Nombres = objEnt.NANombres Then
                            blnNombreBD = True
                            Exit For
                        End If
                    Next
                    If blnNombreBD = True Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                "se encuentra en la Lista de Nombres Asociados.")
                        Return False
                    End If
                    For Each objEnt As Entity.Registro.Documento.NombresAsociados In objEntDocumenCol2
                        If objEnt.NAPaterno2 = Me.ApellidoPaterno And objEnt.NAMaterno2 = Me.ApellidoMaterno And
                            objEnt.NANombres2 = Me.Nombres Then
                            blnNombreAcla = True
                            Exit For
                        End If
                    Next
                    If blnNombreAcla = True Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                "se encuentra en la Lista de Nombres Aclarados.")
                        Return False
                    End If
                End If
                objEnt.Codigo = Me.Codigo
                If Me._PenalLM = True Then
                    Dim NroIngreso As Integer = objBss.ValidarNombre_LM(objEnt)
                    If NroIngreso > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                      "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                      "ha sido registrado en el ingreso Nro. " & NroIngreso)
                        Return False
                    End If
                Else
                    Dim NroIngreso As Integer = objBss.ValidarNombre2(objEnt)
                    If NroIngreso > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nombre asociado." + Chr(13) +
                                                                                      "[" & Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres & "]" + Chr(13) +
                                                                                      "ha sido registrado en el ingreso Nro. " & NroIngreso)
                        Return False
                    End If
                End If

            End If


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
                    If objBss.ValidarNombre(objEnt) = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El nombre ingresado, ya esta registrado como nombre asociado del interno.")
                        Me.txtApePaterno.Focus()
                    Else
                        blnValor = True
                    End If
                End If
            End If
            Return blnValor
        End Function
        Private Sub AGrabarModificar()

            If Validar() = False Then
                Exit Sub
            End If

            Dim intValue As Integer = -1

            objBss = New Bussines.Registro.NombreAsociado
            objEntDoc = New Entity.Registro.Documento.NombresAsociados


            objEntDoc.InternoID = Me.InternoID
            objEntDoc.NANombres = Me.Nombres
            objEntDoc.NAPaterno = Me.ApellidoPaterno
            objEntDoc.NAMaterno = Me.ApellidoMaterno
            objEntDoc.NAEstado = Me.Estado
            objEntDoc.NAPrincipal = Me.Principal

            objEnt = New Entity.Registro.NombreAsociado

            'If Me.DocumentoJudicialID > -1 Then
            '    If objEntDoc.Codigo = -1 Then
            With objEnt
                .Codigo = Me.Codigo
                .InternoID = Me.InternoID
                .Principal = Me.Principal
                .ApellidoPaterno = Me.ApellidoPaterno
                .ApellidoMaterno = Me.ApellidoMaterno
                .Nombres = Me.Nombres
                .Estado = Me.Estado
                .DocumentoJudicialID = Me.DocumentoJudicialID
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            'intValue = objBss.GrabarNA2(objEnt)

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub
        Private Sub AGrabarNuevo()
            If Validar() = False Then
                Exit Sub
            End If
            objEnt = New Entity.Registro.NombreAsociado
            objEnt.Codigo = -1
            objEnt.ApellidoPaterno = Me.ApellidoPaterno
            objEnt.ApellidoMaterno = Me.ApellidoMaterno
            objEnt.Nombres = Me.Nombres
            objEnt.Principal = Me.Principal
            objEnt.Estado = Me.Estado
            objEntDocumen = New Entity.Registro.Documento.NombresAsociados
            objEntDocumen.Codigo = -1
            objEntDocumen.NAPaterno = Me.ApellidoPaterno
            objEntDocumen.NAMaterno = Me.ApellidoMaterno
            objEntDocumen.NANombres = Me.Nombres
            objEntDocumen.NAPrincipal = Me.Principal
            objEntDocumen.NAEstado = Me.Estado
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub
        Private Sub GrabarCarceleta()
            If Validar2() = True Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                    objEnt = New Entity.Registro.NombreAsociado
                    With objEnt
                        'objEnt.FlagTransferenciaSede = Me.FlagTransferSede
                        objEnt.Codigo = -1
                        objEnt.ApellidoPaterno = Me.ApellidoPaterno
                        objEnt.ApellidoMaterno = Me.ApellidoMaterno
                        objEnt.Nombres = Me.Nombres
                        objEnt.Principal = Me.Principal
                        objEnt.Estado = Me.Estado
                        .InternoID = Me.InternoID
                        If Me._PenalLM = True Then
                            .IngresoID = -1
                            .IngresoInpeID = Me._IngresoInpeID
                        Else
                            .IngresoID = Me.IngresoID
                            .IngresoInpeID = -1
                        End If
                        .RegionID = Me._RegionID
                        .PenalID = Me._PenalID
                    End With
                    objBss = New Bussines.Registro.NombreAsociado

                    If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                        objBss.GrabarNA_Car(objEnt)
                    ElseIf Me._PenalLM = True Then
                        objBss.GrabarNA2_LM(objEnt)
                    Else
                        objBss.GrabarNA2(objEnt)
                    End If
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If
        End Sub
#End Region
#Region "usuarios_Permisos"
        Private Sub UsuarioPermisos()
            Me.btnAceptar.Visible = Me._FormEscritura

            Dim blnSalir As Boolean = False
            Dim blnGrabar As Boolean = False

            Select Case Me._TipoFormulario
                Case Type.Formulario.Registro.UserControl.ListadoExpediente
                    InhabilitarControles()
                    blnSalir = True
                Case Type.Formulario.Registro.UserControl.Resoluciones
                    blnGrabar = True
            End Select

            Me.pnlSalir.Visible = blnSalir
            Me.Panel4.Visible = blnGrabar

        End Sub
#End Region
#Region "Otros"
        Public Sub _VisibleRadioButonNombresAsociados()
            'gbTiponombre.Enabled = True
        End Sub
#End Region

        Private Sub frmNombreAsociadoPopup2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Me._Documentos_sin_mov = True Then
                'rdbPrincipal.Enabled = False
                'rdbAsociado.Enabled = False
            End If
        End Sub
        Private Sub frmNombreAsociadoPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            UsuarioPermisos()
            ' ListarData()
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
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                'Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                GrabarCarceleta()
            Else
                If Me._RadioEnablet = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                     "El nombre asociado solo es de visualización, operación cancelada.")
                    Exit Sub
                End If
                If Me._ReferenciaEnablet = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado, [Operación cancelada]")
                    Exit Sub
                End If
                If Me._RadioEnablet = False Then
                    AGrabarNuevo()
                Else
                    AGrabarModificar()
                End If
            End If
        End Sub
    End Class
End Namespace