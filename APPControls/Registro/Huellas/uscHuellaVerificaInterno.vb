Imports Type.Enumeracion.Licencia

Public Class uscHuellaVerificaInterno

    Public Event _CellDoubleClick_Grilla(ByVal InternoId As Integer, intEstId As Integer, internoRegionId As Integer, internoPenalId As Integer, intRegNom As String, intPenNom As String)

#Region "Propiedades_publicas"
    Public Property _PenalId As Integer = -1
    Public Property _RegionId As Integer = -1
    Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
    Public Property _NombrePenal As String = ""
#End Region
#Region "Propiedades_Grilla"
    Private ReadOnly Property GrillaCodigo() As Integer
        Get
            Dim intValue As Integer = -1
            Try
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_int_id").Value
                End With
            Catch ex As Exception

            End Try
            Return intValue
        End Get
    End Property

    Private ReadOnly Property GrillaPenalId() As Integer
        Get
            Dim intValue As Integer = -1
            Try
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_pen_id").Value
                End With
            Catch ex As Exception

            End Try
            Return intValue
        End Get
    End Property

    Private ReadOnly Property GrillaRegionId() As Integer
        Get
            Dim intValue As Integer = -1
            Try
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_reg_id").Value
                End With
            Catch ex As Exception

            End Try
            Return intValue
        End Get
    End Property

    Private ReadOnly Property GrillaPenalNom() As String
        Get
            Dim intValue As Integer = -1
            Try
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_pen").Value
                End With
            Catch ex As Exception

            End Try
            Return intValue
        End Get
    End Property

    Private ReadOnly Property GrillaRegionNom() As String
        Get
            Dim intValue As Integer = -1
            Try
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_reg").Value
                End With
            Catch ex As Exception

            End Try
            Return intValue
        End Get
    End Property

    Private ReadOnly Property GrillaInternoEstadoId() As Integer
        Get
            Dim intValue As Integer = -1
            Try
                With Me.dgwGrilla
                    intValue = .SelectedRows(0).Cells("col_est_id").Value
                End With
            Catch ex As Exception

            End Try
            Return intValue
        End Get
    End Property
#End Region
#Region "Accion"
    Private Function Validar(ByRef sms As String) As Boolean
        If Me.cbbTipoDoc.SelectedValue <= 0 Then
            sms = "Seleccione el tipo de documento de identidad."
            Return False
        End If
        If txtNumDocIdent.Text.Length <> 8 And cbbTipoDoc.SelectedValue = 10 Then
            sms = "Número de documento de identidad no válida, la cantidad de digitos del DNI debe ser 8."
            Return False
        End If
        If IsNumeric(txtNumDocIdent.Text) = False Then
            sms = "Número de documento de identidad no válida, contiene letras."
            Return False
        End If
        If UscCapturaUniDactilar1.getImagenHuellaByte Is Nothing Then
            sms = "Huella no válida, vuelva a capturar la huella."
            Return False
        End If
        If UscCapturaUniDactilar1.getIndiceCalidad <= 0 Or UscCapturaUniDactilar1.getIndiceCalidad > 3 Then
            sms = "Calidad de la huella incorrecta, calidad: " & UscCapturaUniDactilar1.getIndiceCalidad & ", vuelva a capturar la huella"
            Return False
        End If
        If UscCapturaUniDactilar1.getTemplateAnsiByte Is Nothing Then
            sms = "Template de la huella no válida, posiblemente la huella no ha sido capturada correctamente, vuelva a capturar la huella."
            Return False
        End If
        Return True
    End Function

    Private Sub VerificacionBiometrico()
        Dim sms As String = ""
        Dim objBss As New Bussines.Registro.Interno_Grilla

        Dim tmplAnsi_A As Byte() = UscCapturaUniDactilar1.getTemplateAnsiByte
        Dim tmplAnsi_B As Byte() = Nothing

        Dim entList As New Entity.Registro.InternoCol
        Dim entListMatch As New Entity.Registro.InternoCol

        If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
            Dim entInt As New Entity.Registro.Interno_Grilla
            With entInt
                .IDPenal = Me._PenalId
                .IDRegion = Me._RegionId

                If rbNacional.Checked Then
                    .IDPenal = -1
                    .IDRegion = -1
                End If

                If rbRegional.Checked Then
                    .IDPenal = -1
                    .IDRegion = Me._RegionId
                End If

                .IDTipoDocIdentidad = Me.cbbTipoDoc.SelectedValue
                .InternoNumeroDocumento = txtNumDocIdent.Text
            End With

            entList = objBss.ListarInternoBusqueda(entInt, False)
        End If

        'solo para lima provincias VERSION 5
        If Me._TipoLicencia = enmTipoLicencia.PenalProvincia Then
            Dim entIntGri As New Entity.Registro.Interno_Grilla

            With entIntGri
                .IDPenal = Me._PenalId
                .IDRegion = Me._RegionId

                If rbNacional.Checked Then
                    .IDPenal = -1
                    .IDRegion = -1
                End If

                If rbRegional.Checked Then
                    .IDPenal = -1
                    .IDRegion = Me._RegionId
                End If

                .IDTipoDocIdentidad = Me.cbbTipoDoc.SelectedValue
                .InternoNumeroDocumento = txtNumDocIdent.Text
            End With

            entList = (New Bussines.Registro.Interno_Grilla).Listar_v5(entIntGri)
        End If

        If Not entList Is Nothing Then
            Dim bssHue As New Bussines.Biometria.InternoHuella

            For Each obj As Entity.Registro.Interno In entList

                Dim entHue As New Entity.Biometria.InternoHuella
                Dim entList2 As New Entity.Biometria.InternoHuellaCol

                entHue.InternoId = obj.Codigo
                entList2 = bssHue.Listar(entHue, "")

                If Not entList2 Is Nothing AndAlso entList2.Count > 0 Then
                    entHue = entList2.InternoHuella(0)

                    Dim idTmplate As Integer = -1

                    Select Case UscCapturaUniDactilar1.getTipoDedoSel
                        Case 1
                            idTmplate = entHue.HuellaDigMenIzqId
                        Case 2
                            idTmplate = entHue.HuellaDigAnuIzqId
                        Case 3
                            idTmplate = entHue.HuellaDigMedIzqId
                        Case 4
                            idTmplate = entHue.HuellaDigIndIzqId
                        Case 5
                            idTmplate = entHue.HuellaDigPulIzqId
                        Case 6
                            idTmplate = entHue.HuellaDigPulDerId
                        Case 7
                            idTmplate = entHue.HuellaDigIndDerId
                        Case 8
                            idTmplate = entHue.HuellaDigMedDerId
                        Case 9
                            idTmplate = entHue.HuellaDigAnuDerId
                        Case 10
                            idTmplate = entHue.HuellaDigMenDerId
                    End Select

                    Dim entTmpl As APPControlHuellaVisita.Entity.Ent_HuellaTemplate
                    Dim codError As Integer = 0
                    Dim rpta As Integer = 0

                    Try
                        Dim bssSys As New APPControlHuellaVisita.Business.SysBiometria(APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno)

                        sms = ""
                        entTmpl = bssSys.ListarTemplate(idTmplate, sms)
                        tmplAnsi_B = entTmpl.TemplateANSI

                        'Dim tmpFS60 As Byte() = System.IO.File.ReadAllBytes("D:\indice izq FS60 verifi.ansi")
                        'Dim tmpFS10 As Byte() = System.IO.File.ReadAllBytes("D:\indice FS10.ansi")

                        ''score = bssSys.compararTemplateAnsi_futronic(tmplAnsi_A, tmplAnsi_B, codError, sms)

                        rpta = bssSys.compararTemplateAnsi_futronic(tmplAnsi_A, tmplAnsi_B, APPControlHuellaVisita.Type.Enumeracion.enumNivelSeguridadFAR.MATCH_SCORE_HIGH_MEDIUM, sms)
                        Select Case rpta
                            Case 1 'match
                                entListMatch.Add(obj)
                            Case Is < 0
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ocurrió un error interno, " & sms & ", intente nuevamente.")
                            Case Else 'no match

                        End Select

                    Catch ex As Exception
                        Legolas.Configuration.Aplication.MessageBox.MensajeError(ex.ToString)
                        Exit Sub
                    End Try
                End If
            Next

            dgwGrilla.AutoGenerateColumns = False
            dgwGrilla.DataSource = entListMatch

            If entListMatch.Count = 0 Then
                lblResultado.Text = "No se encontraron ninguna coincidencias."
                lblResultado.ForeColor = Color.Brown
            Else
                lblResultado.Text = "Total registros encontrados " & Format(entListMatch.Count, "00")
                lblResultado.ForeColor = Color.Black
            End If

        End If
    End Sub
#End Region
    Public Sub _LoadUsc()
        Try
            Me.cbbTipoDoc.LoadUsc()
            cbbTipoDoc.SelectedIndex = 5
        Catch ex As Exception
        End Try

        If Me._TipoLicencia = enmTipoLicencia.Ninguno Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionProvincia Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation("Tipo de licencia no válida")
            Exit Sub
        End If
        rbPenal.Text = Me._NombrePenal

        If Me._TipoLicencia = enmTipoLicencia.Carceleta Then
            rbNacional.Enabled = True
            rbNacional.Checked = True
            rbPenal.Enabled = False
            rbRegional.Enabled = False
        End If
    End Sub

    Private Sub btnVerificar_Click(sender As System.Object, e As System.EventArgs) Handles btnVerificar.Click
        Dim sms As String = ""
        If Validar(sms) = False Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation(sms)
            Exit Sub
        End If

        VerificacionBiometrico()
    End Sub

    Private Sub dgwInternoMatch_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
        If Me.dgwGrilla.RowCount > 0 Then
            If (Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana And Me.GrillaRegionId = 3) Or
                (Me._TipoLicencia = enmTipoLicencia.PenalProvincia And Me.GrillaRegionId <> 3) Or
                (Me._TipoLicencia = enmTipoLicencia.PenalLimaProvincia And Me.GrillaRegionId = 3) Or
                (Me.GrillaPenalId = 35 And Me._TipoLicencia = enmTipoLicencia.Carceleta) Then
                RaiseEvent _CellDoubleClick_Grilla(Me.GrillaCodigo, Me.GrillaInternoEstadoId, Me.GrillaRegionId, Me.GrillaPenalId, GrillaRegionNom, Me.GrillaPenalNom)
            End If
        End If
    End Sub

    Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

    End Sub
End Class
