
Imports System.Windows.Forms
Namespace Registro.Reniec
    Public Class frmDetalleNombresAsociadosPoput

        Private objBss As Bussines.Registro.NombreAsociado = Nothing
        Public objEntRnc As New Entity.Registro.InternoReniec
#Region "Propiedades"
        Public Property _InternoID As Integer = -1
        Public Property _TipoDocumento As Integer = -1
        Public Property _NumeroDocumento As String = ""
        Public Property _Estado As Integer = -1

        Private Property FechaValidacion As Date
        Private Property ListaInternoData As String = ""
        Private Property ListaReniecdata As String = ""
        Private Property NombreAsociadoVal_ID() As Integer = -1
        Private Property NombreAsociadoVal_Nom() As String = ""
        Public Property _objEntCol As New Entity.Registro.NombreAsociadoCol
#End Region
#Region "Propiedades_Grilla"







        Public Property _NroIngresoID() As Integer = -1


#End Region
#Region "Propiedades_Return"
        Private intTipoValidacionReniec As Short = -1
        Public Property _TipoValidacionReniec As Short
            Get
                Return intTipoValidacionReniec
            End Get
            Set(value As Short)
                intTipoValidacionReniec = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub Listar()
         
            With dgwGrillaNombresAsociados
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = _objEntCol
                '.RowCount = 1
                For i As Integer = 0 To _objEntCol.Count - 1
                    .Item(0, i).Value = i + 1
                Next
            End With
     
        End Sub
#End Region
#Region "Accion"



        Private Sub ComboNumIngreso()
            Dim objBssIng As New Bussines.Registro.Ingreso
            Dim objEntCol2 As New Entity.Registro.IngresoCol

            Dim objEnt As New Entity.Registro.Ingreso
            objEnt.InternoID = Me._InternoID

            objEntCol2 = objBssIng.ListarNroIngreso(Me._InternoID, -1)
            'Me.cbbNroIngresos.DataSource = objEntCol2
            'Me.cbbNroIngresos.DisplayMember = "IngresoNro"
            'Me.cbbNroIngresos.ValueMember = "Codigo"

            'ListarResoluciones()
            'pnlNuevoReniec.Visible = True
        End Sub

#End Region

        Private Sub frmDetalleNombresAsociadosPoput_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Listar()
        End Sub

       

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub
    End Class

End Namespace