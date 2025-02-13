Namespace Registro.Expediente
    Public Class frmDatosInimputablesPopup

#Region "Propiedades_Publicas"
        Public Property _idTipoLicencia As Short = -1
        Public Property _idTipoDocumentoJudicial As Type.Enumeracion.DocumentoJudicial.enmTipoDocumento = Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Ninguno
        Public Property _blnReferenciado As Boolean = False
        Public Property _idTipoImimputable As Short = -1
        Public Property _idCentroSaludMental As Short = -1
#End Region
#Region "Propiedades_Retorno"
        Public Property _getIdInimputable As Type.Enumeracion.Movimiento.EnumMovMotivo = Type.Enumeracion.Movimiento.EnumMovMotivo.Ninguno
        Public Property _getNombreTipoInimputable As String = "NO PERTENECE"
        Public Property _getIdCentroSaludMental As Integer = -1
        Public Property _getCentroSaludMentalNombre As String = ""

#End Region
#Region "Propiedades"
        Private Property idInimputable As Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente
            Get
                Dim value As Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente = Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.NoPertenece

                If Me.rbInimputable.Checked = True Then
                    value = Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable
                    Me._getNombreTipoInimputable = Me.rbInimputable.Text
                End If

                If Me.rbPosibleInim.Checked = True Then
                    value = Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.PosibleInimputable
                    Me._getNombreTipoInimputable = Me.rbPosibleInim.Text
                End If

                If Me.rbNoPertenece.Checked = True Then
                    value = Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.NoPertenece
                    Me._getNombreTipoInimputable = Me.rbNoPertenece.Text
                End If

                Return value

            End Get
            Set(value As Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente)
                Select Case value
                    Case Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable
                        Me.rbInimputable.Checked = True

                    Case Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.PosibleInimputable
                        Me.rbPosibleInim.Checked = True

                    Case Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.NoPertenece
                        Me.rbNoPertenece.Checked = True
                End Select

            End Set

        End Property
        Private Property idCentroSalud As Integer
            Get
                Return Me.cbbEstablecimientomental.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbEstablecimientomental.SelectedValue = value
            End Set
        End Property
#End Region
#Region "Combo"
        Private Sub ComboEstablecimeintomental()

            With Me.cbbEstablecimientomental
                ._Todos = True
                ._TodosMensaje = "[Seleccionar Establecimiento mental]"
                .ComboTipo = Type.Combo.ComboTipo.Establecimientomental
                .DropDownWidthAuto = True
                .LoadUsc()

                If Me._idTipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso Then
                    .Enabled = Not (_blnReferenciado)

                    If Me._idTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                        .Enabled = False
                    End If

                End If

            End With
        End Sub
#End Region
#Region "Otros"
        Private Sub habilitarCentroSalud()

            If idInimputable < 1 Then
                Me.idCentroSalud = -1
                Me.cbbEstablecimientomental.Enabled = False
            Else
                Me.cbbEstablecimientomental.Enabled = True
            End If

        End Sub
#End Region

        Private Sub frmListaEstablecimientosInimputables_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            ComboEstablecimeintomental()

            Me.gbInimputable.Enabled = False

            Select Case Me._idTipoDocumentoJudicial
                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Ingreso

                    Me.lblTitulo.Text = "Establecimiento de salud mental donde debería cumplir la medida *"
                    Me.rbInimputable.Checked = True

                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Sentencia,
                     Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.EjecutoriaSuprema,
                     Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.EjecutoriaSuperior,
                     Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.SentenciaConsentida,
                     Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Resolucion

                    Me.rbInimputable.Checked = True
                    Me._idTipoImimputable = Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable

                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Libertad

                    Me.gbInimputable.Enabled = True

                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.OrdenTrasladoHospital,
                        Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.RetornoTrasladoHospital

                    Me.gbInimputable.Enabled = True
                    Me.rbNoPertenece.Enabled = False
            End Select

            If Me._idTipoImimputable > -1 Then
                Me.idInimputable = Me._idTipoImimputable
            End If

            If Me._idCentroSaludMental > 0 Then
                Me.idCentroSalud = Me._idCentroSaludMental
            End If

            habilitarCentroSalud()

        End Sub

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

            If Me.idInimputable > 0 Then
                If Me.idCentroSalud < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el centro de salud mental")
                    Me.cbbEstablecimientomental.Focus()
                    Exit Sub
                End If
            End If

            Me._getIdInimputable = Me.idInimputable
            Me._getIdCentroSaludMental = Me.idCentroSalud
            Me._getCentroSaludMentalNombre = Me.cbbEstablecimientomental.Text

            DialogResult = DialogResult.OK

        End Sub

        Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

            DialogResult = DialogResult.Cancel

        End Sub

        Private Sub rbNoPertenece_Click(sender As Object, e As EventArgs) Handles rbNoPertenece.Click, rbPosibleInim.Click, rbInimputable.Click

            habilitarCentroSalud()

        End Sub
    End Class
End Namespace
