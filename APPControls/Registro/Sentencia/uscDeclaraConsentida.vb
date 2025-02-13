Public Class uscDeclaraConsentida
    Public blnConsentida As Boolean = False

#Region "Eventos"
    Public Event _Click_FechaRecepcion()
#End Region
#Region "Propiedades"
    Public Property NumeroResolucion() As String
        Get
            Return txtNumeroResolucion.Text
        End Get
        Set(ByVal value As String)
            txtNumeroResolucion.Text = value
        End Set
    End Property

    Public Property FechaResolucion() As Long
        Get
            Return dtpFechaResolucion.ValueLong
        End Get
        Set(ByVal value As Long)
            dtpFechaResolucion.ValueLong = value
        End Set
    End Property
    Public Property FechaRecepcionResolucion() As Long
        Get
            Return dtpFechaRecepResolucion.ValueLong
        End Get
        Set(ByVal value As Long)
            dtpFechaRecepResolucion.ValueLong = value
        End Set
    End Property
    Public Property DeclaraConsentida() As Boolean
        Get
            Dim Valor As Boolean = False
            If Me.rbtSiConsentida.Checked = True Then
                Valor = True
            End If
            Return Me.rbtSiConsentida.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.rbtSiConsentida.Checked = value
        End Set
    End Property
    Public ReadOnly Property SituacionJuridicaId As Integer
        Get
            Dim Valor As Integer = 1
            If Me.rbtSiConsentida.Checked = True Then
                Valor = 2
            End If
            Return Valor
        End Get
    End Property
#End Region
#Region "Funciones"
    Public Sub _Load(obj As Entity.Registro.DocumentoJudicial, ExpRef As Integer)
        With obj
            If obj Is Nothing Then Exit Sub
            If .Codigo = -1 Then Exit Sub
            Me.rbtSiConsentida.Checked = .SentenciaConsentida
            Me.rbtNoConsentida.Checked = Not (.SentenciaConsentida)
            Me.NumeroResolucion = .DocumentoNumeroTraslado
            Me.FechaResolucion = .FechaResolucion
            Me.FechaRecepcionResolucion = .FechaRecepcionResolucion
            If Me.NumeroResolucion.Length = 0 Then Me.ckbResolucion.Checked = True
            If Me.FechaResolucion = 0 Then Me.ckbFecResolucion.Checked = True
            If Me.FechaRecepcionResolucion = 0 Then Me.ckbFecRecepcion.Checked = True
        End With
        If ExpRef > 0 Then

            Me.rbtSiConsentida.Enabled = IIf(ExpRef > 0, False, True)
            Me.rbtNoConsentida.Enabled = IIf(ExpRef > 0, False, True)
        End If
    End Sub
#End Region
    Private Sub rbtSiConsentida_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSiConsentida.CheckedChanged
        If rbtSiConsentida.Checked = True Then
            pnlResolucionConsentida.Visible = True
            txtNumeroResolucion.Text = ""
            txtNumeroResolucion.Focus()
            dtpFechaResolucion.ValueLong = 0
            dtpFechaRecepResolucion.ValueLong = 0
            ckbResolucion.Checked = False
            ckbFecResolucion.Checked = False
            ckbFecRecepcion.Checked = False
            blnConsentida = True
            RaiseEvent _Click_FechaRecepcion()
        Else
            pnlResolucionConsentida.Visible = False
            blnConsentida = False
        End If
    End Sub
    Public Function Validar(strMensaje As String) As Boolean
        Dim blnValor As Boolean = True

        If rbtSiConsentida.Checked = False And rbtNoConsentida.Checked = False Then
            If strMensaje.Length = 0 Then
                strMensaje = "Falta seleccionar si la sentencia se encuentra consentida o no."
            Else
                strMensaje = strMensaje + Chr(13) + " " + Chr(13) +
                "Falta seleccionar si la sentencia se encuentra consentida o no."
            End If
            Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
            blnValor = False
        End If
        If rbtSiConsentida.Checked = True Then
            If Me.ckbResolucion.Checked = False Then
                If Me.txtNumeroResolucion.Text.Length < 1 Then
                    strMensaje = IIf(strMensaje.Length = 0, "", strMensaje + Chr(13) + " " + Chr(13)) +
                        "Ingresar el número de resolución que declara consetida la sentencia."
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                    txtNumeroResolucion.Focus()
                    Return False
                End If
            End If
            If Me.ckbFecResolucion.Checked = False Then
                If Me.dtpFechaResolucion.ValueLong = 0 Then
                    strMensaje = IIf(strMensaje.Length = 0, "", strMensaje + Chr(13) + " " + Chr(13)) +
                       "Ingresar la fecha del documento que declara consentida la sentencia."
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                    dtpFechaResolucion.Focus()
                    Return False
                End If
                If Me.dtpFechaRecepResolucion.ValueLong > 0 Then
                    If Me.dtpFechaResolucion.ValueLong > Me.dtpFechaRecepResolucion.ValueLong Then
                        strMensaje = IIf(strMensaje.Length = 0, "", strMensaje + Chr(13) + " " + Chr(13)) +
                       "La fecha de la Resolucion que declara consentida la sentencia, no puede ser mayor que la fecha de recepcion."
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        dtpFechaResolucion.Focus()
                        Return False
                    End If
                End If
            End If
            If Me.ckbFecRecepcion.Checked = False Then
                If Me.dtpFechaRecepResolucion.ValueLong = 0 Then
                    strMensaje = IIf(strMensaje.Length = 0, "", strMensaje + Chr(13) + " " + Chr(13)) +
                        "Ingresar la fecha de recepción del documento que declara consentida la sentencia."
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                    dtpFechaRecepResolucion.Focus()
                    Return False
                End If
            End If
        End If
        Return blnValor
    End Function

    Private Sub ckbResolucion_CheckedChanged(sender As Object, e As EventArgs) Handles ckbResolucion.CheckedChanged
        If ckbResolucion.Checked = True Then
            txtNumeroResolucion.Text = ""
            txtNumeroResolucion.Enabled = False
        Else
            txtNumeroResolucion.Enabled = True
        End If
    End Sub

    Private Sub ckbFecResolucion_CheckedChanged(sender As Object, e As EventArgs) Handles ckbFecResolucion.CheckedChanged
        If ckbFecResolucion.Checked = True Then
            dtpFechaResolucion.Enabled = False
        Else
            dtpFechaResolucion.Enabled = True
        End If
    End Sub

    Private Sub ckbFecRecepcion_CheckedChanged(sender As Object, e As EventArgs) Handles ckbFecRecepcion.CheckedChanged
        If ckbFecRecepcion.Checked = True Then
            dtpFechaRecepResolucion.Enabled = False
        Else
            dtpFechaRecepResolucion.Enabled = True
        End If
    End Sub

    Private Sub dtpFechaResolucion__ValueChanged() Handles dtpFechaResolucion._ValueChanged
        With dtpFechaResolucion
            Dim Valor As String = .Value
            If IsDate(Valor) Then
                If .Value > Now() Then
                    .Value = Nothing
                    .Focus()
                End If
            End If
        End With
    End Sub

    Private Sub dtpFechaRecepResolucion__ValueChanged() Handles dtpFechaRecepResolucion._ValueChanged
        With dtpFechaRecepResolucion
            Dim Valor As String = .Value
            If IsDate(Valor) Then
                If .Value > Now() Then
                    .Value = Nothing
                    .Focus()
                End If
            End If
        End With
    End Sub
End Class
