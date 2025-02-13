Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.TipoDocJudicial

Namespace Registro
    Public Class frmListaDelitosHistoricos

#Region "Propiedades_Parametricas"
        Private objEntCol As New Entity.Estadistica.PadinDelitoCol
        Private objSenCol As New Entity.Estadistica.PadinDelitoCol
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
        Public Property _RegionID As Integer = -1
        Public Property _PenalID As Integer = -1
        Public Property _InternoID As Integer = -1
        Public Property _InternoIngresoID As Integer = -1
        Public Property _IngresoInpeID As Integer = -1
        Public Property _SituacionJuridicaId As Integer = 1
        Private objBss As New Bussines.Estadistica.PadinDelito
#End Region
#Region "Listar"

        Private Sub ListarDelitos()
            Dim obj As New Entity.Estadistica.PadinDelito

            obj.TipoSituacionJuridica = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado
            obj.InternoId = Me._InternoID
            obj.IngresoId = Me._InternoIngresoID
            obj.IngresoInpeId = Me._IngresoInpeID
            objEntCol = objBss.Listar(obj)

            With Me.dgwAgraviado
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
            End With
        End Sub
        Private Sub ListarDelitosSentencia()
            Dim obj As New Entity.Estadistica.PadinDelito

            obj.TipoSituacionJuridica = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado
            obj.InternoID = Me._InternoID
            objSenCol = objBss.Listar(obj)

            With Me.dgwSentencias
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objSenCol
            End With
        End Sub

        Private Sub frmListaDelitosHistoricos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ListarDelitos()
            ListarDelitosSentencia()
        End Sub
#End Region


    End Class
End Namespace