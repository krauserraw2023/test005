Namespace Visita.Visitante
    Public Class uscVistaHuella
        Private objBss As Bussines.Biometria.VisitanteHuella = Nothing
        Private objEnt As Entity.Biometria.VisitanteHuella = Nothing

#Region "Propiedades_Publicas"
        Public Property _IDRegion As Short = -1
        Public Property _IDPenal As Short = -1
        Public Property _IDVisitante As Integer = -1
#End Region
#Region "Propiedades"
        Private Property SelectIDVisitanteHuella As Integer
            Get
                Return Me.cbbHuella.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbHuella.SelectedValue = value
            End Set
        End Property
#End Region
#Region "Combo"
        Dim blnComboCargo As Boolean = False
        Private Sub listarCombo()

            If Me._IDVisitante < 1 Then
                MessageBox.Show("Parametro _IDVisitante, no ingresado")
            End If

            objBss = New Bussines.Biometria.VisitanteHuella

            With cbbHuella
                .DataSource = objBss.Combo(Me._IDVisitante, Me._IDRegion, Me._IDPenal, "")
                .DisplayMember = "Item"
                .ValueMember = "Codigo"

                If .Items.Count > 0 Then
                    .SelectedIndex = 0
                End If
            End With

            blnComboCargo = True
        End Sub

#End Region
#Region "Listar"
        Private Sub listar()

            If Me.SelectIDVisitanteHuella < 1 Then
                Exit Sub
            End If

            objEnt = New Entity.Biometria.VisitanteHuella
            objBss = New Bussines.Biometria.VisitanteHuella

            objEnt = objBss.Listar(SelectIDVisitanteHuella, "")

            With objEnt

                Me.txtUsuario.Text = .Audit_UsuarioCreacion.ToUpper
                Me.lblFecha.Text = .FechaCapturaString

                Me.txtUsuarioInac.Text = .UsuarioInactivaHuella.ToUpper
                Me.lblFechaInac.Text = .FechaInactivaHuellaString

                Me.lblManoIzquierda.Text = .ManoIzquierda
                Me.lblManoDerecha.Text = .ManoDerecha

                'tipo dedo izquierdo
                Select Case .TipoCapturaIzquierdo
                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado
                        Me.txtObsIzq.Visible = False
                        Me.pbManoizquierda.Image = My.Resources.huella_x

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal
                        Me.txtObsIzq.Visible = False
                        Me.pbManoizquierda.Image = My.Resources.huella_digital

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado
                        Me.pbManoizquierda.Image = My.Resources.huella_digital
                        Me.txtObsIzq.Text = .ObservacionIzquierdo

                        Me.txtObsIzq.Visible = True
                End Select

                'tipo dedo derecho
                Select Case .TipoCapturaDerecho
                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado
                        Me.txtObsDer.Visible = False
                        Me.pbManoDerecha.Image = My.Resources.huella_x
                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal
                        Me.txtObsDer.Visible = False
                        Me.pbManoDerecha.Image = My.Resources.huella_digital
                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado
                        Me.pbManoDerecha.Image = My.Resources.huella_digital
                        Me.txtObsDer.Text = .ObservacionDerecho
                        Me.txtObsDer.Visible = True
                End Select

                'Calidad dedo izquierdo
                Select Case .ManoIzquierdaCalidad
                    Case Type.Enumeracion.Biometria.CalidadHuella.MuyAlta

                        Me.pbEstadoManoIzq.Image = My.Resources.estado_verde

                    Case Type.Enumeracion.Biometria.CalidadHuella.Alta
                        Me.pbEstadoManoIzq.Image = My.Resources.estado_azul

                    Case Type.Enumeracion.Biometria.CalidadHuella.Media
                        Me.pbEstadoManoIzq.Image = My.Resources.estado_amarillo

                    Case Else

                End Select

                'Calidad dedo derecho
                Select Case .ManoDerechaCalidad
                    Case Type.Enumeracion.Biometria.CalidadHuella.MuyAlta
                        Me.pbEstadoManoDer.Image = My.Resources.estado_verde

                    Case Type.Enumeracion.Biometria.CalidadHuella.Alta
                        Me.pbEstadoManoDer.Image = My.Resources.estado_azul

                    Case Type.Enumeracion.Biometria.CalidadHuella.Media
                        Me.pbEstadoManoDer.Image = My.Resources.estado_amarillo
                End Select
            End With

        End Sub
#End Region
#Region "Otros"
        Public Sub _ListarUsc()

            listarCombo()
            listar()

            '/*crear las sigueintes columnas de fecha de captura,estado de huella, usuario que inactiva la huella, fecha de inactiva la huella */


        End Sub
#End Region
        Private Sub cbbHuella_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbHuella.SelectedIndexChanged

            If blnComboCargo = True Then
                listar()
            End If
        End Sub
    End Class

End Namespace
