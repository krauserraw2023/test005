Imports System.Linq

Namespace Sistema.Seguridad.Usuario
    Public Class frmMotivo
#Region "Propiedades_Parametricas"
        Public Property _InternoID As Integer = -1
        Public Property _LicenciaID As Integer = -1
        Public Property Motivo As String = ""
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
                    objdocCol = bssDoc.Listar_DocumentosJudiciales_LM(objDoc)
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

        End Sub
#End Region


#Region "Otros"
        Private Sub ValoresxDefault()
            _ListarLibrosFolios()
        End Sub

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
            If Me.txtMotivo.Text.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar motivo de la inhabiltacion" + Chr(13) +
                                                                          "con un minimo de 3 caracteres.")
            Else
                Me.Motivo = txtMotivo.Text.Trim
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub

#End Region


        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

    End Class
End Namespace
