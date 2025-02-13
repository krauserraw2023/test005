Namespace Registro.Main.Antecedentes
    Public Class frmDetalleAJPopup
        Public Property _setDataSource
            Get
                Return DataGridView2.DataSource
            End Get
            Set(value)
                With DataGridView2
                    .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    .AutoGenerateColumns = False
                    .DataSource = value
                End With
            End Set
        End Property

        Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub
    End Class
End Namespace