Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles
Imports System.ComponentModel
Namespace Registro

    Public Class frmNombreAsociadoDetalle
        'Dim WithEvents CheckBoxHeaderCell As DataGridViewCheckBoxHeaderCell

        Private objBss As Bussines.Registro.NombreAsociado = Nothing
        Public objEnt2 As Entity.Registro.NombreAsociado = Nothing
        Public objEnt As Entity.Registro.NombreAsociado = Nothing
        Private objCol As Entity.Registro.NombreAsociadoCol = Nothing
        Public EntNACol As Entity.Registro.NombreAsociadoCol = Nothing
        Public EntNACol_Com As Entity.Registro.Documento.NombresAsociadosCol = Nothing
#Region "Propiedades"
        Public Property _InternoID As Integer = -1
        Private intInternoID As Integer = -1
        Public Property InternoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
            End Set
        End Property
        Public Property _InternoApeNom() As String
            Get
                Return Me.lblInterno.Text.Trim.ToUpper
            End Get
            Set(ByVal value As String)
                Me.lblInterno.Text = value.ToUpper
            End Set
        End Property
        Public Property _RegistroNuevo As Boolean = False
#End Region

        Private Sub frmNombreAsociadoDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ListarData()
            With dgwNombreAsoc
                .Columns("col_ape_pat").ReadOnly = True
                .Columns("col_ape_mat").ReadOnly = True
                .Columns("col_nom").ReadOnly = True
                .Columns("col_prin").ReadOnly = True
            End With
        End Sub

#Region "Listar"
        Private Sub ListarData()

            If Me.InternoID < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Registro.NombreAsociado
            objCol = New Entity.Registro.NombreAsociadoCol

            Dim objEnt As New Entity.Registro.NombreAsociado
            objEnt.InternoID = Me.InternoID

            objCol = objBss.Listar(objEnt)
            'objCol = objBss.Listar(-1, Me.InternoID, "", "", "", -1)

            Me.dgwNombreAsoc.AutoGenerateColumns = False
            Me.dgwNombreAsoc.DataSource = objCol
            lblNroExpedientes.Text = "Nro de nombres : " & objCol.Count & " Reg."
            'If objCol.Count = 0 Then
            '    Me._RegistroNuevo = True
            '    Me.DialogResult = Windows.Forms.DialogResult.OK
            '    Me.Close()
            'End If
        End Sub
#End Region

        Private Sub dgwNombreAsoc_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwNombreAsoc.CellContentClick

        End Sub

        Private Sub dgwNombreAsoc_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwNombreAsoc.CellDoubleClick
            'dgwNombreAsoc.SelectedRows(0).Cells("col_sel").Value = True
            'If ValidarGrilla() = True Then
            '    CargarDatos()
            '    Me.DialogResult = Windows.Forms.DialogResult.OK
            '    Me.Close()
            'End If
        End Sub

        Private Sub lblInterno_Click(sender As System.Object, e As System.EventArgs) Handles lblInterno.Click

        End Sub

        Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs)
            Me._RegistroNuevo = True
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub
        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs)
            If ValidarGrilla() = True Then
                CargarDatos()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub
        Public EntNACol2 As Entity.Registro.Documento.NombresAsociadosCol
        Public objEnt_ As Entity.Registro.Documento.NombresAsociados
        Private Sub CargarDatos()
            'objBss = New Bussines.Registro.NombreAsociado
            EntNACol2 = New Entity.Registro.Documento.NombresAsociadosCol
            Dim intPos As Integer = -1
            For i As Integer = 0 To dgwNombreAsoc.RowCount - 1
                objEnt_ = New Entity.Registro.Documento.NombresAsociados
                With dgwNombreAsoc
                    If dgwNombreAsoc.Item("col_sel", i).Value = True Then
                        intPos = i
                        objEnt_.Codigo = .Rows(intPos).Cells("col_nom_aso_id").Value
                        objEnt_.DocumentoNomAsociadoId = .Rows(intPos).Cells("col_doc_nom_aso_id").Value
                        objEnt_.InternoNombreAsociadoID = .Rows(intPos).Cells("col_nom_aso_id").Value
                        objEnt_.DocumentoJudicialID = .Rows(intPos).Cells("col_doc_jud_id").Value
                        objEnt_.NAPaterno = .Rows(intPos).Cells("col_ape_pat").Value
                        objEnt_.NAMaterno = .Rows(intPos).Cells("col_ape_mat").Value
                        objEnt_.NANombres = .Rows(intPos).Cells("col_nom").Value
                        objEnt_.NAEstado = .Rows(intPos).Cells("col_est").Value
                        objEnt_.NAPrincipal = .Rows(intPos).Cells("col_prin").Value
                        objEnt_.InternoID = .Rows(intPos).Cells("col_int_id").Value
                        EntNACol2.Add(objEnt_)
                    End If
                End With
            Next
            'Me.DialogResult = Windows.Forms.DialogResult.OK
        End Sub
        Private Function ValidarGrilla() As Boolean
            Dim intFalse As Integer = 0
            Dim intFalse2 As Integer = 0
            Dim strMensaje As String = ""
            For i As Integer = 0 To dgwNombreAsoc.RowCount - 1
                If dgwNombreAsoc.Item("col_sel", i).Value = True Then
                    'EntNACol.Add()
                    intFalse = intFalse + 1
                    Exit For
                End If
            Next
            'For j As Integer = 0 To dgwNombreAsoc.RowCount - 1
            '    For Each EntNA_Com As Entity.Registro.Documento.NombresAsociados In EntNACol_Com
            '        If dgwNombreAsoc.Rows(j).Cells("col_sel").Value = True Then
            '            If dgwNombreAsoc.Rows(j).Cells("col_nom_aso_id").Value = EntNA_Com.InternoNombreAsociadoID Then
            '                strMensaje = EntNA_Com.ApellidosyNombres
            '                intFalse2 = 1
            '                Exit For
            '                Exit For
            '            End If
            '        End If
            '    Next
            'Next
            'Dim intFalse3 As Integer = 0
            'For k As Integer = 0 To dgwNombreAsoc.RowCount - 1
            '    If dgwNombreAsoc.Rows(k).Cells("col_prin").Value = True Then
            '        intFalse3 = intFalse3 + 1
            '    End If
            'Next
            If intFalse = 0 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Seleccionar por lo menos un nombre asociado")
                Return False
            End If
            If intFalse2 > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El nombre asociado :" & strMensaje & " , ya se encuentra en la lista")
                Return False
            End If
            'If intFalse3 > 0 Then

            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("El nombre asociado :" & strMensaje & " , ya se encuentra en la lista")
            '    Return False
            'End If
            Return True
        End Function

        Private Sub ckbSeleccion_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbSeleccion.CheckedChanged
            With dgwNombreAsoc
                If dgwNombreAsoc.Rows.Count > 0 Then
                    Dim Valor As Boolean = ckbSeleccion.Checked
                    If ckbSeleccion.Checked = Valor Then
                        For i As Integer = 0 To dgwNombreAsoc.Rows.Count - 1
                            .Rows(i).Cells("col_sel").Value = Valor
                        Next
                    End If
                End If
            End With
        End Sub
    End Class
End Namespace