Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Xml
Imports Newtonsoft.Json

Namespace Registro.DocumentoDigital
    Public Class uscVisorArchDigital
#Region "Propiedades"
        Public Property _InternoId As Integer = -1
        Public Property _InternoApePaterno As String = ""
        Public Property _InternoApeMaterno As String = ""
        Public Property _InternoNombres As String = ""
        Private Property _InternoApePaternoAux As String = ""
        Private Property _InternoApeMaternoAux As String = ""
        Private Property _InternoNombresAux As String = ""
#End Region

#Region "Accion"
        'Private Sub LoadArchivoDigitalizado()

        '    'If Validar() = False Then
        '    '    Exit Sub
        '    'End If

        'End Sub
#End Region

#Region "Otros "
        Public Sub LoadUsc()
            'LoadArchivoDigitalizado()
            Me._InternoApePaternoAux = Me._InternoApePaterno
            Me._InternoApeMaternoAux = Me._InternoApeMaterno
            Me._InternoNombresAux = Me._InternoNombres

            ViewDocDigitalizado()

        End Sub

        Private Sub ViewDocDigitalizado()

            Dim root_visor As String = APPWebService.PathURL.wsVisorDocumentosDigitalizados
            Dim ruta As String = ""
            Dim tipoDoc As String = ""

            If Me._InternoId < 1 Then Exit Sub

            If rdbKardex.Checked = True Then
                tipoDoc = "LIBRO_KARDEX"
            Else
                tipoDoc = "FICHA_PENOLOGICA"
            End If

            ruta = root_visor & "api/PolyApi/GetLista?key=A2C1NpE*&tipoDoc=" & tipoDoc & "&ape=" & Me._InternoApePaternoAux & " " & Me._InternoApeMaternoAux & "&nom=" & Me._InternoNombresAux

            Dim request As WebRequest = WebRequest.Create(ruta)
            request.Credentials = CredentialCache.DefaultCredentials
            Dim response As WebResponse = request.GetResponse()
            Dim dataStream As Stream = response.GetResponseStream()

            Dim reader As New StreamReader(dataStream)

            Dim responseFromServer As String = reader.ReadToEnd()

            Dim lst As List(Of DocDigitalizado_BE) = JsonConvert.DeserializeObject(Of List(Of Registro.DocumentoDigital.DocDigitalizado_BE))(responseFromServer)
            dgvDocDigitalizado.AutoGenerateColumns = False
            dgvDocDigitalizado.AllowUserToResizeRows = False
            dgvDocDigitalizado.DataSource = lst

            reader.Close()
            response.Close()

        End Sub

        Private Sub dgvDocDigitalizado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocDigitalizado.CellContentClick
            Dim tokId As String = ""
            Dim tipReg As String = ""
            Dim numArch As String = ""
            Dim numGav As String = ""
            Dim numFic As String = ""

            If Me._InternoId < 1 Then
                'Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno.")
                Exit Sub
            End If

            If e.RowIndex = -1 Then Exit Sub

            If dgvDocDigitalizado.Columns(e.ColumnIndex).Name = "col_btn" Then
                tokId = dgvDocDigitalizado.Item("id", e.RowIndex).Value
                tipReg = dgvDocDigitalizado.Item("tip_reg", e.RowIndex).Value
                numArch = dgvDocDigitalizado.Item("col_archivador", e.RowIndex).Value
                numGav = dgvDocDigitalizado.Item("col_gaveta", e.RowIndex).Value
                numFic = dgvDocDigitalizado.Item("col_num_fic", e.RowIndex).Value

                Dim f As New frmDetalleDocImg()
                f.tokId = tokId
                f.tipReg = tipReg
                f.numArch = numArch
                f.numGav = numGav
                f.numFic = numFic
                If f.ShowDialog = DialogResult.OK Then

                End If
            End If

        End Sub


        Private Sub rdbKardex_Click(sender As Object, e As EventArgs) Handles rdbKardex.Click
            ViewDocDigitalizado()
        End Sub

        Private Sub rdbPenologica_Click(sender As Object, e As EventArgs) Handles rdbPenologica.Click
            ViewDocDigitalizado()
        End Sub

        Private Sub dgvDocDigitalizado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocDigitalizado.CellContentDoubleClick
            Dim tokId As String = ""
            Dim tipReg As String = ""
            Dim numArch As String = ""
            Dim numGav As String = ""
            Dim numFic As String = ""

            If Me._InternoId < 1 Then
                'Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de agregar un nuevo registro, grabe los datos basicos del interno.")
                Exit Sub
            End If

            If e.RowIndex = -1 Then Exit Sub


            tokId = dgvDocDigitalizado.Item("id", e.RowIndex).Value
                tipReg = dgvDocDigitalizado.Item("tip_reg", e.RowIndex).Value
                numArch = dgvDocDigitalizado.Item("col_archivador", e.RowIndex).Value
                numGav = dgvDocDigitalizado.Item("col_gaveta", e.RowIndex).Value
                numFic = dgvDocDigitalizado.Item("col_num_fic", e.RowIndex).Value

                Dim f As New frmDetalleDocImg()
                f.tokId = tokId
                f.tipReg = tipReg
                f.numArch = numArch
                f.numGav = numGav
                f.numFic = numFic
                If f.ShowDialog = DialogResult.OK Then

                End If

        End Sub

        Private Sub dgvDocDigitalizado_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocDigitalizado.CellMouseEnter
            If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
                Exit Sub
            End If



            If dgvDocDigitalizado.Columns(e.ColumnIndex).Name = "col_btn" Then
                dgvDocDigitalizado.Cursor = Cursors.Hand
            Else
                dgvDocDigitalizado.Cursor = Cursors.Default
            End If

        End Sub
#End Region



    End Class
End Namespace