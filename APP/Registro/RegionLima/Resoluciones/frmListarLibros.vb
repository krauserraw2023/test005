Imports System.Linq

Namespace Registro.RegionLima.Resoluciones
    Public Class frmListarLibros
#Region "Propiedades_Parametricas"
        Public Property _InternoID As Integer = -1
        Public Property _LicenciaID As Integer = -1
#End Region

#Region "Listar"
        Public Sub _ListarLibrosFolios()
            Dim bssDoc As New Bussines.Registro.DocumentoJudicial
            Dim objDoc As New Entity.Registro.DocumentoJudicial
            Dim objCol As New Entity.Registro.DocumentoJudicialCol

            Dim objdocCol As New Entity.Registro.DocumentoJudicialCol
            With objDoc
                .InternoId = Me._InternoID
                ._RegionID = 3
            End With

            Select Case Me._LicenciaID
                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana,
                     Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana,
                     Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                    'objdocCol = bssDoc.Listar_DocumentosJudiciales_LM(objDoc)
                    objdocCol = bssDoc.ListarDocJud_v2_LM(objDoc)
                Case Else
                    objdocCol = bssDoc.Listar_DocumentosJudiciales(objDoc)
            End Select

            For Each obj As Entity.Registro.DocumentoJudicial In objdocCol
                If obj.NumLibro.Length > 0 Then 'And obj.NumFolio.Length > 0
                    If objCol.Count = 0 Then
                        objCol.Add(obj)
                    Else
                        Dim SW As Boolean = False
                        For Each objL As Entity.Registro.DocumentoJudicial In objCol
                            If obj.NumLibro = objL.NumLibro Then
                                If obj.NumFolio.Length = 0 Then
                                    SW = False
                                    Exit For
                                End If
                                If objL.NumFolio.Length = 0 Then
                                    objL.NumFolio = obj.NumFolio
                                    SW = False
                                    Exit For
                                End If
                                If obj.NumFolio = objL.NumFolio Then
                                    SW = False
                                    Exit For
                                End If
                            Else
                                SW = True
                            End If
                        Next
                        If SW = True Then
                            objCol.Add(obj)
                        End If
                    End If
                End If
            Next

            Dim grilla As Object = From s As Entity.Registro.DocumentoJudicial In objCol
                                   Order By s.NumLibro Ascending, s.NumFolio Ascending
                                   Select s

            With Me.dgwExpediente
                .DataSource = Nothing
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AllowUserToResizeRows = False
                .Refresh()
            End With

            For Each obj As Entity.Registro.DocumentoJudicial In grilla
                Me.dgwExpediente.Rows.Add(obj.NumLibro, obj.NumFolio)
            Next

        End Sub
#End Region


#Region "Otros"
        Private Sub ValoresxDefault()
            _ListarLibrosFolios()
        End Sub

#End Region

        Private Sub frmExpedientePopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

    End Class
End Namespace
