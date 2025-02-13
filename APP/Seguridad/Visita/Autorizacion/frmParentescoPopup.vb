Namespace Visita.Autorizacion
    Public Class frmParentescoPopup
#Region "Propiedades_Return"
        Public ReadOnly Property _Tipo() As Type.Enumeracion.Parentesco.ParentescoGrupo
            Get
                Return Me.Tipo
            End Get
        End Property
#End Region
#Region "Propiedades"
        Private ReadOnly Property Tipo() As Type.Enumeracion.Parentesco.ParentescoGrupo
            Get

                Dim value As Type.Enumeracion.Parentesco.ParentescoGrupo = Type.Enumeracion.Parentesco.ParentescoGrupo.Familiares

                If Me.rdbOpcion1.Checked = True Then
                    value = Type.Enumeracion.Parentesco.ParentescoGrupo.Abogado
                End If

                If Me.rdbOpcion2.Checked = True Then
                    value = Type.Enumeracion.Parentesco.ParentescoGrupo.Familiares
                End If

                Return value

            End Get
        End Property
#End Region
#Region "Accion"

        Private Sub AOK()

            If Me.Tipo > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub

#End Region
#Region "Otros"
        Private Sub ValoresxDefault()



        End Sub
#End Region
        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AOK()

        End Sub

        Private Sub frmReportePopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub
    End Class
End Namespace