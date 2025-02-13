Namespace Registro.Identificacion.v5
    Public Class frmSeleccionarIngresoPopup
        Private objEntCol As Object = Nothing
#Region "Propiedades"

        Private intInternoID As Integer = -1
        Public Property InternoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
            End Set
        End Property

        Private intTrasladoTipoID As Integer = -1
        Public Property TrasladoTipoID() As Integer
            Get
                Return intTrasladoTipoID
            End Get
            Set(ByVal value As Integer)
                intTrasladoTipoID = value
            End Set
        End Property

        Private intRegionID As Integer = -1
        Public Property RegionID() As Integer
            Get
                Return intRegionID
            End Get
            Set(ByVal value As Integer)
                intRegionID = value
            End Set
        End Property

        Private intPenalID As Integer = -1
        Public Property PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
            End Set
        End Property

#End Region

#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_ing_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property

#End Region

#Region "Propiedades_Otros"
        Private blnTrasladoIngreso As Boolean = False

        Public Property VisibleGrabar() As Boolean
            Get
                Return Me.btnOk.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.btnOk.Visible = value
            End Set
        End Property
        Public Property _TrasladoIngreso() As Boolean
            Get
                Return blnTrasladoIngreso
            End Get
            Set(ByVal value As Boolean)
                blnTrasladoIngreso = value
            End Set
        End Property

        Private blnCambiaIngreso As Boolean = False
        Public Property _CambiaIngreso() As Boolean
            Get
                Return blnCambiaIngreso
            End Get
            Set(value As Boolean)
                blnCambiaIngreso = value
            End Set
        End Property

#End Region

#Region "Propiedades_retorno"
        Public ReadOnly Property _Codigo() As Integer
            Get
                Return Me.GrillaCodigo
            End Get
        End Property
#End Region

#Region "Listar"
        Public _objEntCol As New Entity.Registro.IngresoCol
        Private Sub ListarIngreso()
            If Me.InternoID < 1 Then
                Exit Sub
            End If
            Dim objBss As New Bussines.Registro.Ingreso
            '_objEntCol = objBss.Listar(-1, Me.InternoID, -1, -1, -1, 0, -1, -1, "", 0, -1, 0, "")
            If _objEntCol.Count = 0 Then
                Me.Close()
            End If
            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = _objEntCol
            End With
            If Me.dgwGrilla.RowCount > 0 Then
                Me.dgwGrilla.Rows(0).Selected = True
            End If
            lblReg.Text = _objEntCol.Count & " Reg."
        End Sub
#End Region
#Region "LicenciaPermiso"
        Private Sub UsuarioPermiso()

            Me.btnOk.Visible = Me._FormEscritura

        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub
        Public intIngresoNuevo As Integer = -1
        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            If _CambiaIngreso Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
             
                intIngresoNuevo = dgwGrilla.SelectedRows(0).Cells("col_ing_id").Value
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
                'End If
            End If

        End Sub

        Private Sub frmIngreso_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            ListarIngreso()
            UsuarioPermiso()
        End Sub

        Private Sub MantTraslado(ByVal Nuevo As Boolean, Optional ByVal TrasladoIngreso As Boolean = True)

            If Me.InternoID < 1 Then
                MessageBox.Show("Antes de ingresar un Traslado, grabe los datos del interno", _
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, _
                MessageBoxIcon.Exclamation)
                Exit Sub
            End If

        
        End Sub

        Private Sub dgwGrilla_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting

            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_fec_isp").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value)
                        Else
                            e.Value = ""
                        End If

                End Select
            End With

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub
    End Class
End Namespace
