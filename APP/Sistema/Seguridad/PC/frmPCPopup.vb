
Namespace Seguridad.PC
    Public Class frmPCPopup
        Private objBss As Legolas.LBusiness.Seguridad.PC = Nothing
        Private objEntCol As Legolas.LEntity.Seguridad.PCCol = Nothing
#Region "Propiedades"
        Private Property HostName() As String
            Get
                Return Me.txtHostName.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtHostName.Text = value
            End Set
        End Property
        Private Property IP() As String
            Get
                Return Me.txtIp.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIp.Text = value
            End Set
        End Property
        Private Property MAC() As String
            Get
                Return Me.txtMac.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtMac.Text = value
            End Set
        End Property
        Private Property SerialHD() As String
            Get
                Return Me.txtSerialHD.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtSerialHD.Text = value
            End Set
        End Property
        Private Property Responsable() As String
            Get
                Return Me.txtResp.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtResp.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Public ReadOnly Property GrillaID() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_pc_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaHostName() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_hos_nam").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Public ReadOnly Property GrillaMAC() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_mac").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
#End Region
#Region "Propiedades_GrillaCount"
        Private intNumeroReg As Integer = 0
        Private Property NumeroReg() As Integer
            Get
                Return intNumeroReg
            End Get
            Set(ByVal value As Integer)
                intNumeroReg = value
                ListarCount()
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub ListarCount()
            Me.lblReg.Text = Me.NumeroReg & " Reg."
        End Sub
        Private Sub Buscar()

            objBss = New Legolas.LBusiness.Seguridad.PC
            objEntCol = New Legolas.LEntity.Seguridad.PCCol

            objEntCol = objBss.Listar(-1, Me.HostName, Me.IP, Me.MAC, Me.SerialHD, Me.Responsable)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.NumeroReg = .RowCount

            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub AOK()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub
#End Region
        Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
            Buscar()
        End Sub

        Private Sub dgwGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            AOK()
        End Sub

        Private Sub txtHostName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
          Handles txtHostName.KeyPress, _
          txtIp.KeyPress, _
          txtMac.KeyPress, _
          txtSerialHD.KeyPress, _
          txtResp.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub dgwGrilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub
    End Class

End Namespace
