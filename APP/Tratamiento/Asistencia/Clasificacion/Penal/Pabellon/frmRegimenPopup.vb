Namespace Tratamiento.Asistencia.Clasificacion.Penal.Pabellon
    Public Class frmRegimenPopup
        Private blnComboRegimen As Boolean = False
#Region "Propieades_Retorno"
        Public Property getIDRegimen As Short = -1
        Public Property getIDEtapa As Short = -1
#End Region
#Region "Propiedades_Privadas"
        Private Property IDRegimen() As Short
            Get
                Return Me.cbbRegimen.SelectedIndex
            End Get
            Set(value As Short)
                Me.cbbRegimen.SelectedIndex = value
            End Set
        End Property
        Private Property IDEtapa() As Short
            Get
                Return Me.cbbEtapa.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbEtapa.SelectedValue = value
            End Set
        End Property
#End Region

#Region "Combo"
        Private Sub ComboRegimen()
            blnComboRegimen = False
            With Me.cbbRegimen
                .Items.Clear()
                .Items.Add("[Seleccione]")
                .Items.Add("Regimen Cerrado Ordinario - R.C.O.")
                .Items.Add("Regimen Cerrado Especial - R.C.E.")
            End With
            Me.IDRegimen = 0
            blnComboRegimen = True
        End Sub
        Private Sub ComboEtapa(intIDRegimen As Short)

            Dim objDT As New DataTable("Regimen")
            objDT.Columns.Add("Codigo", GetType(Integer))
            objDT.Columns.Add("Nombre", GetType(String))

            Select Case intIDRegimen
                Case 1 'ordinario
                    objDT.Rows.Add(New Object() {1, "MINIMA SEGURIDAD"})
                    objDT.Rows.Add(New Object() {2, "MEDIANA SEGURIDAD"})
                    objDT.Rows.Add(New Object() {3, "MAXIMA SEGURIDAD"})

                Case 2
                    objDT.Rows.Add(New Object() {4, "A"})
                    objDT.Rows.Add(New Object() {5, "B"})
                    objDT.Rows.Add(New Object() {6, "C"})
            End Select

            objDT.AcceptChanges()

            With Me.cbbEtapa
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objDT
            End With

        End Sub
#End Region

        Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click

            If Me.IDRegimen < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione regimen")
                Me.cbbRegimen.Focus()
                Exit Sub
            End If

            If Me.IDEtapa < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione etapa")
                Me.cbbEtapa.Focus()
                Exit Sub
            End If

            Me.getIDRegimen = Me.IDRegimen
            Me.getIDEtapa = Me.IDEtapa

            Me.DialogResult = DialogResult.OK

        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub frmMantPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            ComboRegimen()

        End Sub

        Private Sub frmMantPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

        End Sub

        Private Sub cbbRegimen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbRegimen.SelectedIndexChanged

            If Me.blnComboRegimen = True Then
                ComboEtapa(Me.IDRegimen)
            End If

        End Sub
    End Class
End Namespace