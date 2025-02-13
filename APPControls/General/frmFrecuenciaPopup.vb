Public Class frmFrecuenciaPopup
    Private intDiasSeleccionados As Short = 4
#Region "Propiedades"
    Private Property Todos As Boolean = False
    Private Property NombreaOmitir As String = ""
#End Region
#Region "Propiedades_Pub"
    Public Property _TipoMensual() As Type.Enumeracion.Visita.ProgramacionMensual
    Public Property _IDString As String = ""
    Public Property _Text As String = ""
#End Region
#Region "Combo"
    Private Sub Combo()

        Dim intAncho As Integer = 0
        Dim intAlto As Integer = 0

        Select Case Me._TipoMensual
            Case Type.Enumeracion.Visita.ProgramacionMensual.Meses
                ComboMes()
                intAncho = 190
                intAlto = 266
                MostrarMes()
            Case Type.Enumeracion.Visita.ProgramacionMensual.Dias
                ComboDias()
                intAncho = 280
                intAlto = 167
                MostrarDias()
            Case Type.Enumeracion.Visita.ProgramacionMensual.El
                ComboEl()
                intAncho = 142
                intAlto = 167
                MostrarEl()
            Case Type.Enumeracion.Visita.ProgramacionMensual.DiaSemana
                ComboDiaSemana()
                intAncho = 190
                intAlto = 200
                MostrarDiaSemana()
        End Select

        Me.Width = intAncho
        Me.Height = intAlto
        Me.Refresh()

    End Sub

    Private Sub ComboMes()

        Me.NombreaOmitir = "Seleccionar todos los meses"

        With Me.chlbMes
            .Items.Clear()
            .Items.Add(Me.NombreaOmitir)
            .Items.Add("Enero")
            .Items.Add("Febrero")
            .Items.Add("Marzo")
            .Items.Add("Abril")
            .Items.Add("Mayo")
            .Items.Add("Junio")
            .Items.Add("Julio")
            .Items.Add("Agosto")
            .Items.Add("Setiembre")
            .Items.Add("Octubre")
            .Items.Add("Noviembre")
            .Items.Add("Diciembre")
            .SelectedIndex = 0
        End With

        Me.Todos = True

    End Sub
    Private Sub ComboDias()

        With Me.chlbMes
            .Items.Clear()
            For i As Integer = 1 To 31
                .Items.Add(i.ToString)
            Next
            .Items.Add("Ultimo")
            .MultiColumn = True
        End With

    End Sub
    Private Sub ComboEl()

        With Me.chlbMes
            .Items.Clear()
            .Items.Add("Primero")
            .Items.Add("Segundo")
            .Items.Add("Tercero")
            .Items.Add("Cuarto")
            .Items.Add("Último")
        End With

    End Sub
    Private Sub ComboDiaSemana()

        Dim strDiaSemana As String = ""
        Me.NombreaOmitir = "Seleccionar todos los dias"

        With Me.chlbMes
            .Items.Clear()
            .Items.Add(Me.NombreaOmitir)
            For i As Integer = 1 To 7
                strDiaSemana = Microsoft.VisualBasic.WeekdayName(i, False, FirstDayOfWeek.Monday)
                strDiaSemana = StrConv(strDiaSemana, VbStrConv.ProperCase)
                .Items.Add(strDiaSemana)
            Next
        End With
        Me.Todos = True
    End Sub
    Private Sub MostrarMes()

        If Me._IDString.Trim.Length > 0 Then

            Dim strCadena As String() = Me._IDString.Split(",")
            Dim intValor As Integer = -1

            For Each int As Integer In strCadena

                intValor = int

                Me.chlbMes.SetItemCheckState(intValor, CheckState.Checked)

            Next

        End If

    End Sub
    Private Sub MostrarDias()

        If Me._IDString.Trim.Length > 0 Then

            Dim strCadena As String() = Me._IDString.Split(",")
            Dim intValor As Integer = -1

            For Each int As Integer In strCadena

                intValor = int - 1

                Me.chlbMes.SetItemCheckState(intValor, CheckState.Checked)

            Next

        End If

    End Sub
    Private Sub MostrarEl()

        If Me._IDString.Trim.Length > 0 Then

            Dim strCadena As String() = Me._IDString.Split(",")
            Dim intValor As Integer = -1

            For Each int As Integer In strCadena

                intValor = int - 1

                Me.chlbMes.SetItemCheckState(intValor, CheckState.Checked)

            Next

        End If

    End Sub
    Private Sub MostrarDiaSemana()

        If Me._IDString.Trim.Length > 0 Then

            Dim strCadena As String() = Me._IDString.Split(",")
            Dim intValor As Integer = -1

            For Each int As Integer In strCadena

                intValor = int

                Me.chlbMes.SetItemCheckState(intValor, CheckState.Checked)

            Next

        End If

    End Sub
#End Region
#Region "Accion"
    Private Function ComboItemsSeleccionados() As Integer

        Dim value As Integer = 0

        'recorre el indice      
        For i As Integer = 0 To chlbMes.Items.Count - 1

            'Dim selectedIndex As Integer = chlbMes.SelectedIndex
            'If (selectedIndex <> -1) Then

            Dim chkstate As CheckState
            chkstate = chlbMes.GetItemCheckState(i)

            If (chkstate = CheckState.Checked) Then

                If Me.Todos = True And i = 0 Then
                    'nada
                Else

                    Select Case Me._TipoMensual

                        Case Type.Enumeracion.Visita.ProgramacionMensual.Meses
                            value = value + 1
                        Case Type.Enumeracion.Visita.ProgramacionMensual.Dias
                            value = value + 1
                        Case Type.Enumeracion.Visita.ProgramacionMensual.El
                            value = value + 1
                        Case Type.Enumeracion.Visita.ProgramacionMensual.DiaSemana
                            value = value + 1
                    End Select

                End If

            End If

        Next

        Return value

    End Function
    Private Function Validar() As Boolean
        Dim value As Boolean = False

        Select Case Me._TipoMensual

            Case Type.Enumeracion.Visita.ProgramacionMensual.Meses

                If ComboItemsSeleccionados() > 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "La configuracion actual, no le permite seleccionar mas de un mes")
                    Return value
                End If

            Case Type.Enumeracion.Visita.ProgramacionMensual.Dias

                If ComboItemsSeleccionados() > intDiasSeleccionados Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "La configuracion actual, no le permite seleccionar mas de " & intDiasSeleccionados & " dias")
                    Return value
                End If
        End Select

        value = True
        Return value
    End Function

    Private Sub AOK()

        If Validar() = False Then
            Exit Sub
        End If

        Dim strID As String = ""
        Dim strNombre As String = ""
        Dim blnSeModifico As Boolean = False
        Dim intValue As Integer = -1
        Dim strValue As String = ""

        'recorrera el contenido del listcheckbox
        For i As Integer = 0 To Me.chlbMes.CheckedItems.Count - 1

            strValue = Me.chlbMes.CheckedItems(i)

            If Me.Todos = True And strValue.ToUpper = Me.NombreaOmitir.ToUpper Then
                'nada
            Else
                strNombre = strNombre & strValue & ","
            End If

        Next

        'recorre el indice      
        For i As Integer = 0 To chlbMes.Items.Count - 1

            'Dim selectedIndex As Integer = chlbMes.SelectedIndex
            'If (selectedIndex <> -1) Then

            Dim chkstate As CheckState
            chkstate = chlbMes.GetItemCheckState(i)

            If (chkstate = CheckState.Checked) Then

                If Me.Todos = True And i = 0 Then
                    'nada
                Else

                    Select Case Me._TipoMensual

                        Case Type.Enumeracion.Visita.ProgramacionMensual.Meses
                            intValue = i
                        Case Type.Enumeracion.Visita.ProgramacionMensual.Dias
                            intValue = i + 1
                        Case Type.Enumeracion.Visita.ProgramacionMensual.El
                            intValue = i + 1
                        Case Type.Enumeracion.Visita.ProgramacionMensual.DiaSemana
                            intValue = i
                    End Select

                    strID = strID & intValue & ","
                    blnSeModifico = True
                End If

            End If

            'End If

        Next

        If blnSeModifico = True Then
            Me._IDString = strID.Substring(0, strID.Length - 1)
            Me._Text = strNombre.Substring(0, strNombre.Length - 1)
        Else
            Me._IDString = ""
            Me._Text = ""
        End If

        Me.DialogResult = vbOK
    End Sub

#End Region
#Region "Otros"
    Private Sub ValoresxDefault()
        Combo()
    End Sub
#End Region
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        AOK()

    End Sub

    Private Sub frmProgramacionPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ValoresxDefault()

    End Sub

    Private Sub chlbMes_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles chlbMes.ItemCheck

        If e.Index = 0 And Me.Todos = True Then

            If e.NewValue = CheckState.Checked Then

                For idx As Integer = 1 To Me.chlbMes.Items.Count - 1
                    Me.chlbMes.SetItemCheckState(idx, CheckState.Checked)
                Next

            ElseIf e.NewValue = CheckState.Unchecked Then

                For idx As Integer = 1 To Me.chlbMes.Items.Count - 1
                    Me.chlbMes.SetItemCheckState(idx, CheckState.Unchecked)
                Next

            End If

        End If

    End Sub

    Private Sub chlbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chlbMes.SelectedIndexChanged

    End Sub
End Class