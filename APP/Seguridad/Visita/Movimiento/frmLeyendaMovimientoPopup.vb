
Namespace Visita.Movimiento
    Public Class frmLeyendaMovimientoPopup

        Private Sub listarGrilla()


            With dgwIngresaPor
                .Rows.Add("DI", "Documento de Identidad")
                .Rows.Add("CI", "Captura Inicial")
                .Rows.Add("VH", "Verificacion por Huella")
                .Rows.Add("HO", "Huella observada")
                .Rows.Add("R(n)", "Recaptura")
                .Rows.Add("VH-R(n)", "Verificacion de Huellas - Recaptura")
                .Rows.Add("HO-R(n)", "Huella observada - Recaptura")
                .Rows.Add("ND", "No Determinado")
            End With

            With dgwSalePor
                .Rows.Add("MA", "Masivo")
                .Rows.Add("DI", "Documento de Identidad")
                .Rows.Add("VH", "Verificacion por Huella")
                .Rows.Add("ND", "No Determinado")
            End With

        End Sub

        Private Sub frmDesbloquearHuella_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            listarGrilla()

        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub
    End Class

End Namespace
