Namespace Tratamiento.TallerAsistencia.Buscar
    Public Class frmBuscarTallerPopud
        Private objBss As Bussines.Tratamiento.TallerAsistencia.TallerMae = Nothing
    
#Region "Propiedades_Grilla"

        Public ReadOnly Property GrillaInternoID() As Integer
            Get
                Dim strValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        strValue = .SelectedRows(0).Cells("col_int_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Public ReadOnly Property GrillaIDTaller() As Integer
            Get
                Return dgwGrilla.SelectedRows(0).Cells("col_id_tal").Value
            End Get
        End Property
        Public ReadOnly Property GrillaNombreTaller() As String
            Get
                Return dgwGrilla.SelectedRows(0).Cells("col_nom_tal").Value
            End Get
        End Property
        Public ReadOnly Property GrillaNombreActividad() As String
            Get
                Return dgwGrilla.SelectedRows(0).Cells("col_nom_act").Value
            End Get
        End Property
        Public ReadOnly Property GrillaNombreTipoActividad() As String
            Get
                Return dgwGrilla.SelectedRows(0).Cells("col_nom_tip_act").Value
            End Get
        End Property
        Public ReadOnly Property _GrillaRespControlLaboral As String
            Get
                Return dgwGrilla.SelectedRows(0).Cells("col_res_con_per").Value
            End Get
        End Property
        Public ReadOnly Property _GrillaRespGestorProduccion As String
            Get
                Return dgwGrilla.SelectedRows(0).Cells("col_nom_ges_pro").Value
            End Get
        End Property
        Public ReadOnly Property _GrillaRespGrupoAccesoRaiz As String
            Get
                Return dgwGrilla.SelectedRows(0).Cells("col_grup_acce_raiz").Value
            End Get
        End Property
        Public ReadOnly Property _GrillaRespGrupoAcceso As String
            Get
                Return dgwGrilla.SelectedRows(0).Cells("col_grup_acce").Value
            End Get
        End Property
        Public ReadOnly Property _GrillaRespGrupoUsuario As String
            Get
                Return dgwGrilla.SelectedRows(0).Cells("col_grup_usu").Value
            End Get
        End Property
#End Region
#Region "Propiedades_Buscar"
        'Public Property _TipoActividad() As Integer
        '    Get
        '        Return cbbTipoActividad.SelectedValue
        '    End Get
        '    Set(ByVal value As Integer)
        '        cbbTipoActividad.SelectedValue = value
        '    End Set
        'End Property
        'Public Property _Actividad() As Integer
        '    Get
        '        Return cbbActividad.SelectedValue
        '    End Get
        '    Set(ByVal value As Integer)
        '        cbbActividad.SelectedValue = value
        '    End Set
        'End Property
        Private Property NombreTaller() As String
            Get
                Return Me.txtNombreTaller.Text
            End Get
            Set(ByVal value As String)
                Me.txtNombreTaller.Text = value
            End Set
        End Property

#End Region
#Region "Combos"
        Private blnCombo As Boolean = False

        'Private Sub Combo()
        '    With Me.cbbTipoActividad
        '        ._Todos = True
        '        .LoadUsc()
        '    End With

        '    With Me.cbbActividad
        '        ._Todos = True
        '        .Parametro1 = Me._TipoActividad
        '        .LoadUsc()
        '    End With
        '    blnCombo = False
        'End Sub
#End Region

#Region "Listar"

        Private Sub BuscarTaller()
                      
            Dim objEntCol As New Entity.Tratamiento.TallerAsistencia.TallerMaeCol
            Dim objEnt As New Entity.Tratamiento.TallerAsistencia.TallerMae
            objBss = New Bussines.Tratamiento.TallerAsistencia.TallerMae

            With objEnt
                .TipoActividadId = -1
                .ActividadId = -1
                .NombreTaller = Me.NombreTaller
            End With

            objEntCol = objBss.Listar(objEnt)
            With Me.dgwGrilla
                If objEntCol.Count > 0 Then
                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False
                    .DataSource = objEntCol
                    For i As Integer = 0 To objEntCol.Count - 1
                        .Item("col_num", i).Value = i + 1
                    Next
                Else
                    .DataSource = Nothing
                End If
                lblregistro.Text = objEntCol.Count & " Reg."
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean
         
            Dim value As Boolean = True

            If dgwGrilla.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione registro")
                value = False
            End If

            Return value
        End Function
        Private Sub AOk()

            If Validar() = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Sub
#End Region

#Region "Otros"
      
        Private Sub ValoresxDefault()

            'Combo()
            btnBuscar.PerformClick()

        End Sub
     
#End Region


        Private Sub frmSalidaPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AOk()

        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click

            BuscarTaller()

        End Sub

        Private Sub pnlOK_GotFocus(sender As Object, e As System.EventArgs) Handles pnlOK.GotFocus

            Me.btnOk.Focus()

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            AOk()
        End Sub

        'Private Sub cbbTipoActividad__SelectedIndexChanged()
        '    With Me.cbbActividad
        '        ._Todos = True
        '        .Parametro1 = Me._TipoActividad
        '        .LoadUsc()
        '    End With
        'End Sub

        Private Sub txtNombreTaller_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreTaller.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                BuscarTaller()
            End If

        End Sub

        Private Sub cbbTipoActividad_Load(sender As System.Object, e As System.EventArgs)

        End Sub
    End Class

End Namespace
