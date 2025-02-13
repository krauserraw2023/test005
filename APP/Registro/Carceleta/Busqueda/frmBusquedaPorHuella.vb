Imports Type.Enumeracion.Licencia

Namespace Registro.Busqueda
    Public Class frmBusquedaPorHuella

        Public Property _PenalId As Integer = -1
        Public Property _RegionId As Integer = -1
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno

        Public Property _NombrePenal As String = ""
#Region "Form"
        Private Sub FRM_MantCarceleta(verSoloLectura As Boolean, intId As Integer, intEstId As Integer, internoRegionId As Integer, internoPenalId As Integer, intRegNom As String, inPenNom As String)
            Dim frm As New Registro.Main.Carceleta.frmMantenimiento
            frm.MdiParent = Me.MdiParent
            With frm
                ._IDInterno = intId
                .RegionID = internoRegionId
                .PenalID = internoPenalId
                .RegionNombre = intRegNom
                .PenalNombre = inPenNom

                If verSoloLectura = True Then
                    ._FormLectura = True
                    ._FormEscritura = False
                    ._FormReporte = False
                    ._FormImpresion = False
                    ._FormEliminar = False
                Else
                    ._FormLectura = Me._FormLectura
                    ._FormEscritura = Me._FormEscritura
                    ._FormReporte = Me._FormReporte
                    ._FormImpresion = Me._FormImpresion
                    ._FormEliminar = Me._FormEliminar
                End If

                .Show()
            End With
        End Sub

        Private Sub FRM_MantPenalProvincia(verSoloLectura As Boolean, intId As Integer, intEstId As Integer, internoRegionId As Integer, internoPenalId As Integer, intRegNom As String, inPenNom As String)

            Dim frm As New Registro.Penal.Busqueda.frmMant
            frm.MdiParent = Me.MdiParent
            With frm
                .InternoID = intId
                If verSoloLectura = True Then
                    ._FormLectura = True
                    ._FormEscritura = False
                    ._FormReporte = False
                    ._FormEliminar = False
                Else
                    ._FormLectura = Me._FormLectura
                    ._FormEscritura = Me._FormEscritura
                    ._FormReporte = Me._FormReporte
                    ._FormImpresion = Me._FormImpresion
                    ._FormEliminar = Me._FormEliminar
                End If
                .Show()
            End With

        End Sub

        Private Sub FRM_MantPenalLM(verSoloLectura As Boolean, intId As Integer, intEstId As Integer, internoRegionId As Integer, internoPenalId As Integer, intRegNom As String, inPenNom As String)

            Dim frm As New Registro.PenalLM.Busqueda.frmMantenimiento
            frm.MdiParent = Me.MdiParent
            With frm
                ._IDRegion = internoRegionId
                .RegionNombre = intRegNom
                ._IDPenal = internoPenalId
                .PenalNombre = inPenNom
                ._IDInterno = intId

                If verSoloLectura Then
                    ._FormEscritura = False
                    ._FormReporte = False
                    ._FormImpresion = False
                    ._FormEliminar = False
                Else
                    ._FormEscritura = Me._FormEscritura
                    ._FormReporte = Me._FormReporte
                    ._FormImpresion = Me._FormImpresion
                    ._FormEliminar = Me._FormEliminar
                End If
                .Show()
            End With
        End Sub
#End Region

        Private Sub frmBusquedaPorHuella_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            With UscHuellaVerificaInterno1
                ._NombrePenal = Me._NombrePenal
                ._PenalId = Me._PenalId
                ._RegionId = Me._RegionId
                ._TipoLicencia = Me._TipoLicencia
                ._LoadUsc()
            End With
        End Sub

        Private Sub UscHuellaVerificaInterno1__CellDoubleClick_Grilla(intId As System.Int32, intEstId As Integer, internoRegionId As System.Int32, _
                                                                      internoPenalId As System.Int32, intRegNom As String, inPenNom As String) Handles UscHuellaVerificaInterno1._CellDoubleClick_Grilla
            Dim verSoloLectura As Boolean = False
            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta
                    If internoRegionId = 3 Then
                        If internoPenalId = 35 Then 'si el interno es de carceleta
                            verSoloLectura = False
                        Else
                            verSoloLectura = True
                        End If
                        FRM_MantCarceleta(verSoloLectura, intId, intEstId, internoRegionId, internoPenalId, intRegNom, inPenNom)
                    Else
                        FRM_MantPenalProvincia(True, intId, intEstId, internoRegionId, internoPenalId, intRegNom, inPenNom)
                    End If

                Case enmTipoLicencia.PenalLimaMetropolitana
                    If intEstId = 1 Then
                        verSoloLectura = False
                    Else
                        verSoloLectura = True
                    End If
                    FRM_MantPenalLM(verSoloLectura, intId, intEstId, internoRegionId, internoPenalId, intRegNom, inPenNom)

                Case enmTipoLicencia.RegionLimaMetropolitana
                    'no aplica

                Case enmTipoLicencia.RegionProvincia
                    'no aplica

                Case enmTipoLicencia.PenalProvincia
                    FRM_MantPenalProvincia(True, intId, intEstId, internoRegionId, internoPenalId, intRegNom, inPenNom)

                Case Else 'no aplica
                    'If internoRegionId = 3 Then
                    '    MantCarceleta(True, intId, intEstId, internoRegionId, internoPenalId, intRegNom, inPenNom)
                    'Else
                    '    MantPenalProvincia(True, intId, intEstId, internoRegionId, internoPenalId, intRegNom, inPenNom)
                    'End If
            End Select



        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

    End Class
End Namespace