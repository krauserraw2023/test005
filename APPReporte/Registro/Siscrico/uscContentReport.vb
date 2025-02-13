

Namespace Registro.Siscrico
    Public Class uscContentReport
        Dim lstRpt As New List(Of uscReporte)
        Dim intPos As Integer = 0
        Dim intTotRpt As Integer = 0

        Public Event Click_CerrarVentanReporte()

        Public Property _CambiarEstadoImpresion() As Boolean
            Get
                Return False
            End Get
            Set(value As Boolean)
                For Each x As uscReporte In lstRpt
                    x._CambiarEstadoImpresion = value
                Next
                mnuPrintCompleta.Enabled = value
            End Set
        End Property

        Public Function CargarReporte(IdInternos As String) As Boolean
            Dim ids As String()
            ids = Split(IdInternos, ",")

            Dim i As Integer = 0
            Dim x As uscReporte

            For Each v As String In ids
                x = New uscReporte()
                x._pInternoID = v
                x.Name = "rpt" & v
                x.Dock = DockStyle.Fill
                x.InicializarReporte()
                x.Visible = False
                lstRpt.Add(x)
                pnContenedor.Controls.Add(lstRpt(i))
                i = i + 1
                intTotRpt = intTotRpt + 1
            Next
            lblTotRep.Text = intTotRpt
            lstRpt(0).Visible = True
            Return True
        End Function

#Region "Accion"
        Private Sub ExportarPDF()
            If MsgBox("Confirma exportar todas las fichas como archivos independientes?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            With Me.SaveFileDialog2
                .FileName = ""
                .Filter = "Solo PDF (*.pdf)|*.pdf"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim strNom As String = ""
                    Dim nomFil As String = Mid(SaveFileDialog2.FileName, 1, SaveFileDialog2.FileName.LastIndexOf("."))
                    For i As Integer = 0 To intTotRpt - 1
                        strNom = nomFil & i & ".pdf"
                        lstRpt.Item(i).ExportarFichaPDF(strNom)
                        strNom = ""
                    Next
                End If

            End With

        End Sub
        Private Sub AvanzaPrimeraPagina()
            lstRpt(intPos).Visible = False
            intPos = 0
            lstRpt(0).Visible = True
            txtNumActRpt.Text = 1
        End Sub
        Private Sub AvanzaSiguientePagina()
            lstRpt(intPos).Visible = False
            intPos = intPos + 1
            If intPos >= intTotRpt Then intPos = intTotRpt - 1
            lstRpt(intPos).Visible = True
            txtNumActRpt.Text = intPos + 1
        End Sub
        Private Sub AvanzaAnteriorPagina()
            lstRpt(intPos).Visible = False
            intPos = intPos - 1
            If intPos < 0 Then intPos = 0
            txtNumActRpt.Text = intPos + 1
            lstRpt(intPos).Visible = True
        End Sub
        Private Sub AvanzaUltimaPagina()
            lstRpt(intPos).Visible = False
            intPos = intTotRpt - 1
            lstRpt(intPos).Visible = True
            txtNumActRpt.Text = intTotRpt
        End Sub
#End Region

        Private Sub cmdUlt_Click(sender As System.Object, e As System.EventArgs) Handles cmdUlt.Click
            AvanzaUltimaPagina()
        End Sub
        Private Sub cmdSig_Click(sender As System.Object, e As System.EventArgs) Handles cmdSig.Click
            AvanzaSiguientePagina()
        End Sub
        Private Sub cmdAnt_Click(sender As System.Object, e As System.EventArgs) Handles cmdAnt.Click
            AvanzaAnteriorPagina()
        End Sub
        Private Sub cmdPrim_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrim.Click
            AvanzaPrimeraPagina()
        End Sub

        Private Sub cmdImprimir_Click(sender As System.Object, e As System.EventArgs)
            If MsgBox("Desea enviar a impresión solo la pagina actual?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If lstRpt.Item(intPos).ImprimirFicha() = True Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Se ha enviado a impresión")
                Else
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Error. No se pudo enviar a impresión")
                End If
            End If
        End Sub

        Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
            RaiseEvent Click_CerrarVentanReporte()
        End Sub

        Private Sub mnuPrintCompleta_Click(sender As System.Object, e As System.EventArgs) Handles mnuPrintCompleta.Click
            If MsgBox("Desea enviar a impresión todas las paginas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim v As Boolean = False
                For i As Integer = 0 To intTotRpt - 1
                    If lstRpt.Item(i).ImprimirFicha() = False Then
                        v = False
                        Exit For
                    End If
                Next
                If v = True Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Se ha enviado a impresión")
                Else
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Error. No se pudo enviar a impresión")
                End If
            End If
        End Sub

        Private Sub mnuExportPDF_Click(sender As System.Object, e As System.EventArgs)
            ExportarPDF()
        End Sub
    End Class

End Namespace