Imports System.Linq

Namespace Registro.Main.Antecedentes
    Public Class frmBuscaInternoPopup

        Public Property _InternoId As Integer = -1
        Public Property _ApellidosNombres As String = ""
        Public Property _PenalId As Integer = -1

        Public Property _CodRp As String = ""
        Public Property _ApePat As String = ""
        Public Property _ApeMat As String = ""
        Public Property _Nombres As String = ""
        Public Property _TipoAntecedenteId As Integer = -1
        Public Sub New()
            InitializeComponent()
        End Sub
        Private intCol As New Entity.Registro.InternoCol
        Private frmLoad As Load.frmLoad = Nothing
#Region "Grilla"
        Private ReadOnly Property GrillaInternoID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwInternos
                        value = .SelectedRows(0).Cells("col_int_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Private ReadOnly Property GrillaCodigoRP() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwInternos
                        value = .SelectedRows(0).Cells("col_cod").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Private ReadOnly Property GrillaApePaterno() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwInternos
                        value = .SelectedRows(0).Cells("col_ape_pat").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Private ReadOnly Property GrillaApeMaterno() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwInternos
                        value = .SelectedRows(0).Cells("col_ape_mat").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Private ReadOnly Property NombresCompletoInterno As String
            Get
                Return Me.GrillaApePaterno & " " & Me.GrillaApeMaterno & ", " & Me.GrillaNombres
            End Get
        End Property

        Private ReadOnly Property GrillaNombres() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwInternos
                        value = .SelectedRows(0).Cells("col_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_PanelFotografia"
        Private Property PerfilFotografia() As Integer
            Get
                Dim value As Integer = -1

                If Me.rdbPI.Checked = True Then value = 1
                If Me.rdbPF.Checked = True Then value = 2
                If Me.rdbPD.Checked = True Then value = 3

                Return value
            End Get
            Set(ByVal value As Integer)

                Select Case value
                    Case 1
                        Me.rdbPI.Checked = True
                    Case 2
                        Me.rdbPF.Checked = True
                    Case 3
                        Me.rdbPD.Checked = True
                    Case Else
                        Me.rdbPI.Checked = False
                        Me.rdbPF.Checked = False
                        Me.rdbPD.Checked = False
                End Select
            End Set
        End Property
        Private Property PerfilActual As Integer
#End Region
#Region "accion"
        Private Function Listar() As Boolean

            Dim objEntFiltro As New Entity.Registro.Interno_Grilla

            With objEntFiltro
                .InternoCodigoRP = txtCodInterno.Text.Trim
                .PrimerApellido = txtApePat.Text.Trim
                .SegundoApellido = txtApeMat.Text.Trim
                .PreNombres = txtNombres.Text.Trim
                .IDPenal = Me._PenalId
                .IDRegion = 3 'solo lima metropolitana
                ._TipoAntecedenteId = Me._TipoAntecedenteId
            End With

            intCol = (New Bussines.Registro.Interno_Grilla.RegionLima).ListarInternoBusquedaAntecedente(objEntFiltro, False)

        End Function

        Private Sub buscar()
            If txtCodInterno.Text.Trim = "" And txtApeMat.Text.Trim = "" And txtApePat.Text.Trim = "" And txtNombres.Text.Trim = "" Then Exit Sub

            Me.SuspendLayout()
            Me.Timer1.Start()
            frmLoad = New Load.frmLoad
            If frmLoad.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.Timer1.Stop()
                Me.BackgroundWorker1.CancelAsync()
                Me.BackgroundWorker1.Dispose()
            End If
            Me.ResumeLayout(True)
            frmLoad.Refresh()

            With dgwInternos
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = intCol
            End With

            If dgwInternos.Rows.Count > 0 Then
                dgwInternos.Rows(0).Selected = True
                dgwInternos.Select()
            Else
                lblCodInterno.Text = ""
                lblInternoSel.Text = ""
            End If

            If dgwInternos.Rows.Count = 0 Then Legolas.Configuration.Aplication.MessageBox.Information("No se encontró ningún registro.")

            lblTotalFila.Text = "Total filas encontradas: " & dgwInternos.Rows.Count
        End Sub
#End Region
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
            Me._InternoId = Me.GrillaInternoID
            Me._ApellidosNombres = Me.NombresCompletoInterno

            Me._CodRp = Me.GrillaCodigoRP
            Me._ApePat = Me.GrillaApePaterno
            Me._ApeMat = Me.GrillaApeMaterno
            Me._Nombres = Me.GrillaNombres
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
            buscar()
        End Sub

        Private Sub txtApePat_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtApePat.KeyDown, txtApeMat.KeyDown, txtNombres.KeyDown
            If e.KeyCode = Keys.Enter Then
                btnBuscar_Click(Nothing, Nothing)
                If dgwInternos.Rows.Count > 0 Then
                    dgwInternos.Rows(0).Selected = True
                    dgwInternos.Select()
                End If
            End If
        End Sub

        Private Sub dgwInternos_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwInternos.CellDoubleClick
            btnOk_Click(Nothing, Nothing)
        End Sub

        Private Sub ShowFotografia()

            If Me.UscFotografia_2v1._CheckImagen = False Or Me.GrillaInternoID < 1 Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If
            'Dim blnDemo As Boolean = Me.UscFotografia2._HasImagen

            If Me.UscFotografia_2v1._HasImagen = True And PerfilFotografia = PerfilActual Then
                'nada
            Else
                Dim objBssFoto As New Bussines.Registro.InternoFoto
                Dim objEnt As New Entity.Registro.InternoFoto
                Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente2(Me.GrillaInternoID)
                Dim strRutServer As String = ""
                Dim intImagen As Integer = -1
                Dim intNombreImagen As String = ""

                objBssFoto = New Bussines.Registro.InternoFoto
                objEnt = objBssFoto.ListarGrilla(intCodigo)

                If objEnt.Codigo > 0 Then
                    With objEnt
                        Select Case Me.PerfilFotografia
                            Case 1 'izquierdo
                                PerfilActual = 1
                                intImagen = .PIzquierdoID
                                intNombreImagen = .PIzquierdoName
                                strRutServer = .PIzquierdoServerPath
                            Case 2 'frente
                                PerfilActual = 2
                                intImagen = .PFrenteID
                                intNombreImagen = .PFrenteName
                                strRutServer = .PFrenteServerPath
                            Case 3 'derecho
                                PerfilActual = 3
                                intImagen = .PDerechoID
                                intNombreImagen = .PDerechoName
                                strRutServer = .PDerechoServerPath
                        End Select
                    End With
                    Me.UscFotografia_2v1._ShowFotoInterno(intImagen)
                Else
                    Me.UscFotografia_2v1._Limpiar()
                End If
            End If
        End Sub

        Private Sub UscFotografia_2v1__CheckClick() Handles UscFotografia_2v1._CheckClick
            ShowFotografia() ' 
        End Sub

        Private Sub rdbPF_Click(sender As Object, e As System.EventArgs) Handles rdbPF.Click, rdbPD.Click, rdbPI.Click
            ShowFotografia()
        End Sub

        Private Sub dgwInternos_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwInternos.RowEnter
            If dgwInternos.Rows.Count = 0 Then Exit Sub
            lblCodInterno.Text = Me.GrillaCodigoRP
            lblInternoSel.Text = Me.NombresCompletoInterno
        End Sub

        Private Sub dgwInternos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgwInternos.KeyDown
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                btnOk_Click(Nothing, Nothing)
            End If
        End Sub

        Private Sub frmBuscaInternoPopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            txtApePat.Select()
        End Sub

        Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
            If Me.BackgroundWorker1.IsBusy Then Exit Sub
            
            Me.BackgroundWorker1.RunWorkerAsync()
        End Sub

        Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
            e.Result = listar()
        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
            Dim result As Boolean = False
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                Me.Timer1.Stop()
                frmLoad.Close()
                result = e.Result
            End If
        End Sub
    End Class
End Namespace