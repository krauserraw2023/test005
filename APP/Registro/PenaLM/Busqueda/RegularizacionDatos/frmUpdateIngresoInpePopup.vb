Imports System.ComponentModel
Imports System.Data.SqlClient

Namespace Registro.PenalLM.Busqueda
    Public Class frmUpdateIngresoInpePopup

        Private frmLoad As Load.frmProcesando = Nothing
        Private strSqlQuery As String = ""
#Region "Propiedades_Share"
        Public Property _IDInternoLocal As Integer = -1
        Public Property _IDPenal As Short = -1

#End Region
#Region "Propiedades_Privadas"

        Private Property SedeRowID As Integer
            Get
                Try
                    Return Integer.Parse(Me.txtIDIngresoInpe.Text)
                Catch ex As Exception
                    Return 0
                End Try

            End Get
            Set(value As Integer)
                Me.txtIDIngresoInpe.Text = value.ToString
            End Set
        End Property
        Private Property IDIngresoInpe As Integer
            Get
                Try
                    Return Me.txtIDIngresoInpe.Text
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(value As Integer)
                Me.txtIDIngresoInpe.Text = value
            End Set
        End Property
        Private Property IDIngreso As Integer
            Get
                Try
                    Return Me.txtIDIngreso.Text
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(value As Integer)
                Me.txtIDIngreso.Text = value
            End Set
        End Property
        Private Property NumeroIngreso As Integer
            Get
                Try
                    Return Me.nudNumIngreso.Text
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(value As Integer)
                Me.nudNumIngreso.Text = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub ListarGrilla()

            If Me._IDInternoLocal < 1 Then
                Exit Sub
            End If

            strSqlQuery = "select
	                    _regid,
	                    _penid,
                        int_id,
                        _sed_rowid,
	                    int_cod_rp,
	                    tip_doc_id,
	                    int_doc_num,
	                    int_ape_pat,
	                    int_ape_mat,
	                    int_nom,
	                    int_fec_nac,
	                    nac_id
                    from 
	                    int_interno
                    where
	                    int_id=" & _IDInternoLocal

            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objDataTable As New DataTable

            objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strSqlQuery)

            Me.dgwGrillaPenal.DataSource = objDataTable

        End Sub

        Private Sub ListarGrillaIngresoInpe()

            If Me._IDInternoLocal < 1 Then
                Exit Sub
            End If

            strSqlQuery = "select * from int_mov_interno_ingreso_inpe where fk_int_id=" & _IDInternoLocal

            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objDataTable As New DataTable

            objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strSqlQuery)

            Me.dgwGrillaIngresoInpe.DataSource = objDataTable

        End Sub
        Private Sub ListarGrillaIngreso()

            If Me._IDInternoLocal < 1 Then
                Exit Sub
            End If

            strSqlQuery = "select * from INT_InternoIngreso where int_id=" & _IDInternoLocal

            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objDataTable As New DataTable

            objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strSqlQuery)

            Me.dgwGrillaIngreso.DataSource = objDataTable

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            If Me.IDIngresoInpe < 1 Then
                MessageBox.Show("Debe ingresar el IDIngresoINPE", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            If Me.IDIngreso < 1 Then
                MessageBox.Show("Debe ingresar el IDIngreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            If Me.NumeroIngreso < 1 Then
                MessageBox.Show("Seleccione el numero de ingreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            value = True
            Return value
        End Function

        Private Sub AGrabar()

            Dim strMensajeError As String = ""

            strSqlQuery = "update int_mov_interno_ingreso_inpe set _flg_trf=1, c_num_ing=" & Me.NumeroIngreso &
                                                                           " where fk_int_id=" & Me._IDInternoLocal &
                                                                           " and pk_ing_inp_id=" & Me.IDIngresoInpe

            '1.- ingreso inpe
            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Legolas.Components.SQL.ExecuteBatchNonQuery(sqlcn, strSqlQuery, strMensajeError)

            If strMensajeError.Trim.Length > 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensajeError)
                Exit Sub
            End If

            '2.- ingreso
            strSqlQuery = "update INT_InternoIngreso set _flg_trf=1, int_ing_nro=" & Me.NumeroIngreso &
                                                                         " where int_id=" & Me._IDInternoLocal &
                                                                         " and int_ing_id=" & Me.IDIngreso

            sqlcn = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Legolas.Components.SQL.ExecuteBatchNonQuery(sqlcn, strSqlQuery, strMensajeError)

            If strMensajeError.Trim.Length > 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensajeError)
                Exit Sub
            End If

            Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
            Me.DialogResult = DialogResult.OK

        End Sub

#End Region
        Private Sub frmVinculacionPLMPopup_Shown(sender As Object, e As EventArgs) Handles Me.Shown

            ListarGrilla()
            ListarGrillaIngresoInpe()
            ListarGrillaIngreso()

        End Sub

        Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

            Me.DialogResult = DialogResult.Cancel

        End Sub

        Private Sub dgwGrillaPenal_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwGrillaPenal.CellFormatting

            With Me.dgwGrillaPenal
                Select Case e.ColumnIndex

                    Case .Columns("col_pen_fec_nac").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value, True)
                        Else
                            e.Value = ""
                        End If

                End Select
            End With

        End Sub

        Private Sub btnVincular_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

            If Validar() = False Then
                Exit Sub
            End If

            If MessageBox.Show("Desea actulizar el numero de ingreso", Me.Text,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                AGrabar()
                Me.btnUpdate.Enabled = False
            End If

        End Sub

        Private Sub dgwGrillaIngresoInpe_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrillaIngresoInpe.CellContentClick

        End Sub

        Private Sub dgwGrillaIngresoInpe_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrillaIngresoInpe.CellDoubleClick

            With Me.dgwGrillaIngresoInpe
                Select Case e.ColumnIndex
                    Case .Columns("pk_ing_inp_id").Index

                        Me.IDIngresoInpe = .Item("pk_ing_inp_id", e.RowIndex).Value
                End Select
            End With

        End Sub

        Private Sub dgwGrillaIngreso_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrillaIngreso.CellContentClick

        End Sub

        Private Sub dgwGrillaIngreso_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrillaIngreso.CellDoubleClick

            With Me.dgwGrillaIngreso
                Select Case e.ColumnIndex
                    Case .Columns("int_ing_id").Index

                        Me.IDIngreso = .Item("int_ing_id", e.RowIndex).Value
                End Select
            End With

        End Sub
    End Class
End Namespace
