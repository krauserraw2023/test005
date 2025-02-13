Namespace Mantenimiento.Busqueda
    Public Class frmDelitoPopup
        Private objBss As Bussines.Mantenimiento.General.Delito = Nothing
        Private objEntCol As Entity.Mantenimiento.General.DelitoCol = Nothing

        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno

#Region "Propiedades"
        
        Private Property IDDelitoTipo() As Integer
            Get
                Return Me.cbbTipo.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbTipo.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property TipoBusqueda As Short
            Get
                Dim value As Short = -1

                If Me.rdbDescripcion.Checked = True Then
                    value = 1
                End If

                If Me.rdbArticulo.Checked = True Then
                    value = 2
                End If
                Return value
            End Get
            
        End Property
        Private ReadOnly Property DelitoEspecifico() As String
            Get
                Dim value As String = ""

                If TipoBusqueda = 1 Then
                    value = Me.txtBuscar.Text
                End If

                Return value

            End Get
        End Property
        Private ReadOnly Property Articulo() As String
            Get
                Dim value As String = ""

                If Me.TipoBusqueda = 2 Then
                    value = Me.txtBuscar.Text
                End If

                Return value
            End Get
            
        End Property
#End Region
#Region "Propiedades_Grilla"

        Public ReadOnly Property GrillaDelitoTitulo() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_tit_del").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property GrillaDelitoGenericoID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_del_gen_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property GrillaDelitoGenericoNombre() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_del_gen_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property GrillaDelitoEspecificoID() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_del_esp_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property GrillaDelitoEspecificoNombre() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_del_esp_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property GrillaDelitoEstado() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_del_est").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property GrillaDelitoEstadoNombre() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_esp_est_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property GrillaDelitoArticuloNombre() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_del_art_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property GrillaDelitoCapituloNumero() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_cap_num").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Public ReadOnly Property GrillaDelitoCapituloNombre() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_cap_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        Public ReadOnly Property GrillaDelitoCapitulo() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_cap").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property



        Public ReadOnly Property GrillaDelitoSeccionNumero() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_del_sec_num").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        'Public ReadOnly Property GrillaDelitoSeccionNombre() As String
        '    Get
        '        Dim value As String = ""
        '        Try
        '            With Me.dgwGrilla
        '                value = .SelectedRows(0).Cells("col_del_sec_nom").Value
        '            End With
        '        Catch ex As Exception

        '        End Try
        '        Return value
        '    End Get
        'End Property
        Public ReadOnly Property GrillaDelitoSeccion() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_sec").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property


        Public ReadOnly Property GrillaDelitoParCod() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_par_cod").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

        'Public ReadOnly Property _GrillaDelitoTitulo() As String
        '    Get
        '        Return GrillaDelitoTitulo
        '    End Get
        'End Property
        'Public ReadOnly Property _GrillaDelitoGenericoID() As Integer
        '    Get
        '        Return GrillaDelitoGenericoID
        '    End Get
        'End Property
        'Public ReadOnly Property _GrillaDelitoGenericoNombre() As String
        '    Get
        '        Return GrillaDelitoGenericoNombre
        '    End Get
        'End Property
        'Public ReadOnly Property _GrillaDelitoEspecificoID() As Integer
        '    Get
        '        Return GrillaDelitoEspecificoID
        '    End Get
        'End Property
        'Public ReadOnly Property _GrillaDelitoEspecificoNombre() As String
        '    Get
        '        Return GrillaDelitoEspecificoNombre
        '    End Get
        'End Property
        'Public ReadOnly Property _GrillaDelitoEstado() As Integer
        '    Get
        '        Return GrillaDelitoEstado
        '    End Get
        'End Property
        'Public ReadOnly Property _GrillaDelitoArticuloNombre() As String
        '    Get
        '        Return GrillaDelitoArticuloNombre
        '    End Get
        'End Property
        'Public ReadOnly Property _GrillaDelitoCapituloNumero() As String
        '    Get
        '        Return GrillaDelitoCapituloNumero
        '    End Get
        'End Property
        'Public ReadOnly Property _GrillaDelitoCapituloNombre() As String
        '    Get

        '        Return GrillaDelitoCapituloNombre
        '    End Get
        'End Property
        'Public ReadOnly Property _GrillaDelitoSeccionNumero() As String
        '    Get
        '        Return GrillaDelitoSeccionNumero
        '    End Get
        'End Property
        'Public ReadOnly Property _GrillaDelitoSeccionNombre() As String
        '    Get
        '        Return GrillaDelitoSeccionNombre
        '    End Get
        'End Property
#End Region
#Region "Combo"
        Private blnComboDelito As Boolean = False
        Private Sub ComboDelitoTipo()
            objBss = New Bussines.Mantenimiento.General.Delito
            'delito generico
            With Me.cbbTipo
                .DataSource = objBss.Combo_DelitoTipo(Type.Combo.enmTipoTexto.Mayuscula, True)
                .DisplayMember = "DelitoTipoNombre"
                .ValueMember = "DelitoTipoID"
            End With
            Me.IDDelitoTipo = -1 'TODOS
            blnComboDelito = True
        End Sub
#End Region
#Region "Listar"
        Private Sub Buscar()

            Dim objEntDelFiltro As New Entity.Mantenimiento.General.Delito

            With objEntDelFiltro
                .DelitoTipoID = Me.IDDelitoTipo
                .DelitoEspecificoNombre = Me.DelitoEspecifico
                .DelitoArticulo = Me.Articulo
            End With

            objEntCol = New Entity.Mantenimiento.General.DelitoCol
            objBss = New Bussines.Mantenimiento.General.Delito

            objEntCol = objBss.Listar_BusquedaGrilla(objEntDelFiltro)

            With Me.dgwGrilla
                .AutoGenerateColumns = False
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .DataSource = objEntCol

                Me.lblReg.Text = .RowCount & " Reg."

            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub HabilitarBusqueda()

            Me.txtBuscar.Text = ""
            Me.txtBuscar.Focus()

        End Sub
#End Region
        Private Sub tsbBuscar_Click(sender As System.Object, e As System.EventArgs) Handles tsbBuscar.Click

            Buscar()

        End Sub
        Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
            ''''''J.E.U .... el frm dialogo debe preguntar pot "YES"
            Dim blnValor As Boolean = False
            If Me.GrillaDelitoEstado = 2 Then 'derogado
                If Legolas.Configuration.Aplication.MessageBox.Question("El delito " & GrillaDelitoEspecificoNombre & " esta derogado, desea agregarlo de todas maneras.") = DialogResult.Yes Then
                Else
                    Exit Sub
                End If
            End If
            If Me.GrillaDelitoEspecificoID > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub txtDelitoGenerico_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles _
 _
            txtBuscar.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
                Me.txtBuscar.SelectAll()
                Me.txtBuscar.Focus()
            End If

        End Sub

        Private Sub frmDelitoPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            ComboDelitoTipo()

        End Sub

        Private Sub frmBuscarDelitoPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                rdbArticulo.Checked = True
            Else
                rdbDescripcion.Checked = True
            End If
            Me.txtBuscar.Focus()
        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            If dgwGrilla.Rows.Count < 1 Then
                Exit Sub
            End If

            btnOK_Click(Nothing, Nothing)

        End Sub

        Private Sub cbbTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbTipo.SelectedIndexChanged

            If blnComboDelito = True Then
                Buscar()
            End If

        End Sub


        Private Sub rdbDescripcion_Click(sender As Object, e As System.EventArgs) Handles rdbDescripcion.Click, rdbArticulo.Click

            HabilitarBusqueda()

        End Sub

        Private Sub dgwGrilla_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgwGrilla.CellPainting
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub
            If dgwGrilla.Columns(e.ColumnIndex).Name = "col_esp_est_nom" Then
                If dgwGrilla.Item("col_esp_est_nom", e.RowIndex).Value = "Derogado" Then
                    ''e.CellStyle.BackColor = Color.Red
                    dgwGrilla.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Salmon
                End If
            End If
        End Sub
    End Class
End Namespace
