Namespace Mantenimiento.Busqueda
    Public Class frmSalaPopup
        Private objBss As Bussines.Mantenimiento.SalaJuzgado = Nothing
        Private objEntCol As Entity.Mantenimiento.SalaJuzgadoCol = Nothing

#Region "Propiedades"
        Private Property DistritoJudicialID() As Integer
            Get
                Return Me.cbbDistritoJud.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbDistritoJud.SelectedValue = value
            End Set
        End Property
        Private Property SalaNombre() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaSalaID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaSalaNombre() As String
            Get
                Dim value As String = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_sal_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaDistritoJudicialID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_dis_jud_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property GrillaDistritoJudicialNombre() As String
            Get
                Dim value As String = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_dis_jud_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property grillaEstado() As Short
            Get
                Dim value As Short = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_est").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Grilla_Publicas"
        Public ReadOnly Property _GrillaSalaID() As Integer
            Get
                Return Me.GrillaSalaID
            End Get
        End Property
        Public ReadOnly Property _GrillaSalaNombre() As String
            Get
                Return GrillaSalaNombre
            End Get
        End Property
        Public ReadOnly Property _GrillaDistritoJudicialID() As Integer
            Get
                Return Me.GrillaDistritoJudicialID
            End Get
        End Property
        Public ReadOnly Property _GrillaDistritoJudiciaNombre() As String
            Get
                Return Me.GrillaDistritoJudicialNombre
            End Get
        End Property
        Public ReadOnly Property _GrillaDistritoySalaNombre As String
            Get
                Dim value As String = ""

                value = Me.GrillaDistritoJudicialNombre & " / " & Me.GrillaSalaNombre
                Return value
            End Get
            
        End Property
        Public Property _DistritoJudicialID() As Integer = -1
        Public Property _SalaJudicialID() As Integer = -1

#End Region
#Region "Combo"
        Private Sub Combo()

            With Me.cbbDistritoJud
                ._Todos = True
                .LoadUsc()
            End With
            If Me._DistritoJudicialID > 0 Then
                DistritoJudicialID = Me._DistritoJudicialID
            Else
                Me._DistritoJudicialID = -1
                DistritoJudicialID = -1
            End If
        End Sub
#End Region
#Region "Listar"
        Private Sub VisibleColumnas()

            If Me.DistritoJudicialID > 1 Then
                Me.col_dis_jud_nom.Visible = False
            Else
                Me.col_dis_jud_nom.Visible = True
            End If

        End Sub
        Private Sub Buscar()

            VisibleColumnas()

            objBss = New Bussines.Mantenimiento.SalaJuzgado
            objEntCol = New Entity.Mantenimiento.SalaJuzgadoCol

            objEntCol = objBss.ListarPopup(Me.DistritoJudicialID, Me.SalaNombre)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Color.Black
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
                Me.lblReg.Text = .RowCount & " Reg."
            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub AOK()

            If Me.GrillaSalaID > 0 Then

                'validar el estado del registro
                If Me.grillaEstado = 100 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro seleccionado se encuentra en estado inactivo, seleccione otro registro")
                    Exit Sub
                End If

                Me._DistritoJudicialID = Me.GrillaDistritoJudicialID
                Me._SalaJudicialID = Me.GrillaSalaID
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub

#End Region
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click

            AOK()

        End Sub

        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub

        Private Sub txtCodDisJud_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) _
            Handles _
            txtNom.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub frmSalaPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            Combo()
            dgwGrilla.VisibleCampos = False

        End Sub

        Private Sub frmBusquedaSala_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Me.txtNom.Focus()

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            AOK()

        End Sub
    End Class
End Namespace