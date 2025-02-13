Namespace Registro.Carceleta.Clasificacion
    Public Class frmDetalleFicha_V2
#Region "Property"
        Public Property InternoFichaDetalleId() As Integer = -1
        Public Property VariableId() As Integer = -1
        Public Property FichaId() As Integer = -1
        Public Property VariableString() As String = ""
        Public Property IndicadorId() As Integer = -1
        Public Property BloquearRegistro As Boolean = False
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
        Public Property _ValorNoPrevisto() As Integer = -1
        Public Property _ValorPuntaje() As Integer = -1
        Public Property GrupoFichaId As Integer = -1
        Public Property SituacionJuridicaId As Integer = -1

        Public ReadOnly Property ValorIdSeleccionado() As Integer
            Get
                Dim v As Integer = -1
                Try
                    Return webBrowser1.Document.InvokeScript("getValorIdSeleccionado")
                Catch ex As Exception

                End Try
                Return v
            End Get
        End Property
        Public ReadOnly Property ValorNombreSeleccionado() As String
            Get
                Dim v As String = ""
                Try
                    v = webBrowser1.Document.InvokeScript("getValorNombreSeleccionado").ToString().Replace("<b style=""color: brown; background-color: rgb(255, 232, 101);"">", "")
                    v = v.Replace("</b>", "")
                    Return v
                Catch ex As Exception

                End Try
                Return v
            End Get
        End Property
        Public Property _VisibleNoPrevisto As Boolean = True
#End Region

#Region "LISTAR"
        Private Sub ListarValores()
            Dim bssFich As New Bussines.Clasificacion.MaestroIndicador
            Dim entVar As New Entity.Registro.Carceleta.Clasificacion.MaestroIndicador_BE
            Dim entVarCol As New Entity.Registro.Carceleta.Clasificacion.MaestroIndicadorCol_BE
            entVar.VariableID = Me.VariableId
            entVar.FichaId = Me.FichaId

            Dim List As Entity.Registro.Carceleta.Clasificacion.MaestroIndicadorCol_BE = bssFich.Listar(entVar)
            Dim s As New System.Text.StringBuilder

            Dim strSituacionJuridica As String = ""
            Select Case Me.SituacionJuridicaId
                Case 1
                    strSituacionJuridica = "Proc."
                Case 2
                    strSituacionJuridica = "SENT."
            End Select

            s.Append("<!DOCTYPE html>")
            s.Append("<html>")
            s.Append("<head>")
            s.Append("  <meta http-equiv='X-UA-Compatible' content='IE=edge'>")
            s.Append("  <style>")
            s.Append("    #tbl_indicador {")
            s.Append("      border-collapse: collapse;")
            s.Append("      width: 100%;")
            s.Append("    }")
            s.Append("    #tbl_indicador td, #tbl_indicador th {")
            s.Append("      border: 1px solid #ddd;")
            s.Append("      padding: 5px;")
            s.Append("    }")
            s.Append("    #tbl_indicador th {")
            s.Append("      padding-top: 10px;")
            s.Append("      padding-bottom: 10px;")
            s.Append("      text-align: center;")
            s.Append("      background-color: #4CAF50;")
            s.Append("      color: white;")
            s.Append("    }")
            s.Append("    .selected {")
            s.Append("        background-color: #253e96;")
            s.Append("        color: #ffffff;")
            s.Append("    }")
            s.Append("  </style>")
            s.Append("</head>")
            s.Append("<body>")
            s.Append("<div style='overflow-y: auto; height:350px' id='contenedor_tabla'>")
            s.Append("<table id='tbl_indicador'>")
            s.Append("<thead>")
            s.Append("  <tr>")
            s.Append("    <th style='display:none;'></th>")
            s.Append("    <th>Descripción</th>")
            s.Append("    <th width = '10%'>Ptj. " & strSituacionJuridica & "</th>")
            s.Append("  </tr>")
            s.Append("</thead>")
            s.Append("<tbody>")

            Dim ind As Integer = 0
            Dim fila_tabla_cel As Integer = -1

            For Each obj As Entity.Registro.Carceleta.Clasificacion.MaestroIndicador_BE In List
                Dim descrip As String
                ind = ind + 1
                descrip = obj.Descripcion.Replace("EN CASO DE INTERNOS TRASLADADOS:", "<b style='color:brown; background-color:#ffe865'>EN CASO DE INTERNOS TRASLADADOS:</b>")

                If SituacionJuridicaId = 1 Then 'procesado
                    If Me.IndicadorId = obj.Codigo Then
                        fila_tabla_cel = ind
                        s.Append("  <tr onClick='getRowIndex(this)' class='selected'><td style='display:none;'>" & obj.Codigo & "</td><td>" & descrip & "</td><td align = 'right'>" & obj.PuntajeProcesado & "</td></tr>")
                    Else
                        s.Append("  <tr onClick='getRowIndex(this)'><td style='display:none;'>" & obj.Codigo & "</td><td>" & descrip & "</td><td align = 'right'>" & obj.PuntajeProcesado & "</td></tr>")
                    End If

                Else 'sentenciado
                    If Me.IndicadorId = obj.Codigo Then
                        fila_tabla_cel = ind
                        s.Append("  <tr onClick='getRowIndex(this)' class='selected'><td style='display:none;'>" & obj.Codigo & "</td><td>" & descrip & "</td><td align = 'right'>" & obj.PuntajeSentenciado & "</td></tr>")
                    Else
                        s.Append("  <tr onClick='getRowIndex(this)'><td style='display:none;'>" & obj.Codigo & "</td><td>" & descrip & "</td><td align = 'right'>" & obj.PuntajeSentenciado & "</td></tr>")
                    End If

                End If
            Next
            s.Append("</tbody>")
            s.Append("</table>")
            s.Append("</div>")
            s.Append("<br>")
            s.Append("<div style='text-align:right; padding-top:5px;padding-bottom:5px; border:1px solid gray;width:100%'>")
            If Me._ValorNoPrevisto > 0 Then
                s.Append("    <label>Variable no previsto <input type='checkbox' id='chNoPrev' value='first_checkbox' checked onClick='onChangeChk()'></label> ")
                s.Append("    <input type='text' id='txtPtjeNoPrev' name='txtPtjeNoPrev' style='width:50px' value = " & Me._ValorNoPrevisto & ">")
                s.Append("    <input type='text' id='txtPtje' disabled name='txtPtje' style='width:50px; margin-right:5px' value=" & Me._ValorPuntaje & ">")
            Else
                s.Append("    <label>Variable no previsto <input type='checkbox' id='chNoPrev' value='first_checkbox' onClick='onChangeChk()'></label> ")
                s.Append("    <input type='text' id='txtPtjeNoPrev' disabled name='txtPtjeNoPrev' style='width:50px' value = " & Me._ValorNoPrevisto & ">")
                s.Append("    <input type='text' id='txtPtje' readonly name='txtPtje' style='width:50px; margin-right:5px' value=" & Me._ValorPuntaje & ">")
            End If

            s.Append("</div>")
            s.Append("<script>")
            s.Append("	document.oncontextmenu = function() {return false;};")
            s.Append("	var indice=" & fila_tabla_cel & ";")
            s.Append("	var table = document.getElementById('tbl_indicador'),")
            s.Append("		selected = table.getElementsByClassName('selected');")
            s.Append("		table.onclick = highlight;")
            s.Append("    function highlight(e) {")
            s.Append("		if (selected[0]) selected[0].className = '';")
            s.Append("		e.target.parentNode.className = 'selected';")
            s.Append("	}")
            s.Append("	function getRowIndex(fila){")
            s.Append("    	indice = fila.rowIndex;")
            s.Append("        if(document.getElementById('chNoPrev').checked)")
            s.Append("        	document.getElementById('txtPtje').value=0;")
            s.Append("        else")
            s.Append("        	document.getElementById('txtPtje').value = table.rows[indice].cells.item(2).innerHTML;")
            s.Append("    }")
            s.Append("    function poblarTabla(tabla ){")
            s.Append("    	document.getElementById('contenedor_tabla').innerHTML = tabla;")
            s.Append("    }")
            s.Append("    function loadPtje(ptjeNoPrev, ptje){")
            s.Append("    	document.getElementById('txtPtje').value = ptje;")
            s.Append("        document.getElementById('txtPtjeNoPrev').value = ptjeNoPrev;")
            s.Append("    	if(ptjeNoPrev>0){")
            s.Append("        	document.getElementById('txtPtje').disabled = true;")
            s.Append("            document.getElementById('txtPtjeNoPrev').disabled = false;")
            s.Append("        }else{")
            s.Append("        	document.getElementById('txtPtje').disabled = false;")
            s.Append("            document.getElementById('txtPtjeNoPrev').disabled = true;")
            s.Append("        }")
            s.Append("    }")
            s.Append("    function onChangeChk(){")
            s.Append("    	if(document.getElementById('chNoPrev').checked)")
            s.Append("        {")
            s.Append("            if(indice<0){")
            s.Append("              alert('Por favor seleccione un indicador');")
            s.Append("              document.getElementById('chNoPrev').checked = false;")
            s.Append("              return;")
            s.Append("            }")
            s.Append("        	  document.getElementById('txtPtje').disabled = true;")
            s.Append("            document.getElementById('txtPtjeNoPrev').disabled = false;")
            s.Append("            document.getElementById('txtPtje').value=0;")
            s.Append("        }")
            s.Append("         else")
            s.Append("         	{")
            s.Append("            document.getElementById('txtPtje').disabled = false;")
            s.Append("            document.getElementById('txtPtjeNoPrev').disabled = true;")
            s.Append("            document.getElementById('txtPtje').readOnly = true;")
            s.Append("            document.getElementById('txtPtje').value= table.rows[indice].cells.item(2).innerHTML;")
            s.Append("            document.getElementById('txtPtjeNoPrev').value = 0;")
            s.Append("            }")
            s.Append("    }")
            s.Append("    function setTxtPtjeNoPrev(valor){")
            s.Append("    	document.getElementById('txtPtjeNoPrev').value=valor;")
            s.Append("    }    ")
            s.Append("    function setTxtPtje(valor){")
            s.Append("    	document.getElementById('txtPtje').value = valor;")
            s.Append("    }")
            s.Append("    function getTxtPtjeNoPrev(){")
            s.Append("    	return document.getElementById('txtPtjeNoPrev').value;")
            s.Append("    }")
            s.Append("    function getTxtPtje(){")
            s.Append("    	return document.getElementById('txtPtje').value;")
            s.Append("    }")
            s.Append("    function getIndiceSelTabla(){")
            s.Append("    	return indice;")
            s.Append("    }    ")
            s.Append("    function getCheked(){")
            s.Append("    	return document.getElementById('chNoPrev').checked;")
            s.Append("    }    ")
            s.Append("    function getValorIdSeleccionado(){")
            s.Append("    	return table.rows[indice].cells.item(0).innerHTML;")
            s.Append("    }    ")
            s.Append("    function getValorNombreSeleccionado(){")
            s.Append("    	return table.rows[indice].cells.item(1).innerHTML;")
            s.Append("    }")
            s.Append("</script>")
            s.Append("</body>")
            s.Append("</html>")

            webBrowser1.DocumentText = s.ToString()

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            Me.Text = Me.Text & " para la variable " & Me.VariableString.ToUpper

            If Me._FormLectura = True Then btnOK.Visible = False
            If Me.BloquearRegistro = True Then btnOK.Enabled = False
        End Sub
#End Region

        Private Sub frmDelIndicador_v2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            ListarValores()
            ValoresxDefault()
        End Sub

        Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
            If webBrowser1.Document.InvokeScript("getCheked") = True Then

                If Val(webBrowser1.Document.InvokeScript("getTxtPtjeNoPrev")) <= 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el valor del puntaje no previsto.")
                    Exit Sub
                End If

                'evaluar el maximo valor(el valor no previsto no puede superar al max val)
                'Dim maxPtj As Integer = 0
                'Dim strCol As String = "col_ptje"

                'If Me.SituacionJuridicaId = 1 Then strCol = "col_ptje_proc"
                'If Me.SituacionJuridicaId = 2 Then strCol = "col_ptje_sen"

                'For i As Integer = 0 To dgvValores.Rows.Count - 1
                '    If dgvValores.Item(strCol, i).Value > maxPtj Then
                '        maxPtj = dgvValores.Item(strCol, i).Value
                '    End If
                'Next

                'If Val(webBrowser1.Document.InvokeScript("getTxtPtjeNoPrev")) > maxPtj Then
                '    Legolas.Configuration.Aplication.MessageBox.Exclamation("El valor de la variable no prevista no puede ser mayor a " & maxPtj)
                '    Exit Sub
                'End If
            Else
                If Me.GrupoFichaId >= 4 Then
                    If Val(webBrowser1.Document.InvokeScript("getIndiceSelTabla")) <= 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar una fila del indicador.")
                        Exit Sub
                    End If
                Else
                    If Val(webBrowser1.Document.InvokeScript("getTxtPtje")) = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar una fila del indicador.")
                        Exit Sub
                    End If
                End If
            End If

            Me._ValorNoPrevisto = Val(webBrowser1.Document.InvokeScript("getTxtPtjeNoPrev"))
            Me._ValorPuntaje = Val(webBrowser1.Document.InvokeScript("getTxtPtje"))


            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmDetalleFicha_V2_Load(sender As Object, e As EventArgs) Handles Me.Load

            Me.lblNoPreviesto.Visible = Not Me._VisibleNoPrevisto

        End Sub
    End Class
End Namespace
