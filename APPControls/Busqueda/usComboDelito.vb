Namespace Busqueda
    Public Class UscComboDelito
#Region "Eventos"
        Public Event _Click_Eliminar()
        Public Event _Click_Buscar()
        Public Event _Click_ObtenerDelito()
#End Region
#Region "Propiedades"
        Public Property _DelitoTitulo As String = ""
        Public Property _DelitoGenericoID() As Integer = -1
        Public Property _DelitoGenericoNombre() As String = ""
        Public Property _DelitoEspecifico_ID() As Integer = -1
        Public ReadOnly Property _DelitoEspecificoID() As Integer
            Get
                Return Me.UscComboParametrica1.SelectedValue
            End Get
        End Property
        Public ReadOnly Property _DelitoEspecificoNombre() As String
            Get
                Return Me.UscComboParametrica1.Text
            End Get
        End Property
        Public Property _DelitoEstado() As Integer = -1
        Public Property _DelitoArticuloNombre() As String = ""
        Public Property _DelitoCapituloNumero() As String = ""
        Public Property _DelitoCapituloNombre() As String = ""
        Public Property _DelitoSeccionNumero() As String = ""
        Public Property _DelitoSeccionNombre() As String = ""
        Public Property _DelitoParCod() As String = ""
        Public Property _CondicionElimina() As Boolean = False
        Public _objEntDelitoCol As New Entity.Registro.DelitoCol
#End Region
#Region "Combo"
        Public Sub ComboListar()

            With Me.UscComboParametrica1
                .ComboTipo = Type.Combo.ComboTipo.DelitoEspecifico
                .CodigoPadre = Me._DelitoGenericoID
                .LoadUsc()
                UscComboParametrica1.SelectedValue = Me._DelitoEspecifico_ID
            End With

        End Sub
        Public Sub _Combo()
            ComboListar()
        End Sub
#End Region
        Public Event _MostrarFormulario()
#Region "Formularios"
        Private Sub FRM_BuscarDelito()

            RaiseEvent _MostrarFormulario()

          
        End Sub
        Private Sub ObtenerDelito()

            Dim bssDel As New Bussines.Mantenimiento.General.Delito            
            Dim objDel As New Entity.Mantenimiento.General.Delito

            If Me._DelitoEspecificoID > 0 Then

                objDel = bssDel.Listar_DelitoEspecifico_v2(Me._DelitoEspecificoID)

                If objDel Is Nothing Then

                Else
                    With objDel
                        Me._DelitoTitulo = .DelitoTitulo
                        Me._DelitoGenericoID = .DelitoGenericoID
                        Me._DelitoGenericoNombre = .DelitoGenericoNombre
                        Me._DelitoEspecifico_ID = .DelitoEspecificoID
                        'Me._DelitoEspecificoNombre =  .DelitoEspecificoNombre
                        Me._DelitoArticuloNombre = .DelitoArticulo
                        Me._DelitoCapituloNumero = .DelitoCapituloNro
                        Me._DelitoCapituloNombre = .DelitoCapituloNombre
                        Me._DelitoSeccionNumero = .DelitoSeccionNumero
                        Me._DelitoSeccionNombre = .DelitoSeccionNombre
                        Me._DelitoEstado = .DelitoEspecificoEstado
                    End With
                End If
            End If
           
        End Sub

#End Region

        Private Sub UscComboDelito_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        End Sub

        Private Sub UscBusquedaDelito_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
            Me.Height = 21
        End Sub


        Private Sub UscComboParametrica1__Click_Buscar() Handles UscComboParametrica1._Click_Buscar

            FRM_BuscarDelito()
            RaiseEvent _Click_Buscar()

        End Sub

        Private Sub UscComboParametrica1__Click_Eliminar() Handles UscComboParametrica1._Click_Eliminar

            RaiseEvent _Click_Eliminar()
            'Me._CondicionElimina = True
        End Sub

        Private Sub UscComboParametrica1__SelectedIndexChanged() Handles UscComboParametrica1._SelectedIndexChanged

            ObtenerDelito()
            RaiseEvent _Click_ObtenerDelito()

        End Sub

     
       
        Private Sub UscComboParametrica1_Load(sender As System.Object, e As System.EventArgs) Handles UscComboParametrica1.Load

        End Sub
    End Class
End Namespace