Namespace Registro.Sentencia
    Public Class frmPeriodoCondena
        Public _EntPeriodoCondena As Entity.Registro.Documento.PeriodoCondenaSentencia
        Public _TemporalNuevo As Boolean = False
        Public _objEntExpedienteTempoCol As New Entity.Registro.ExpedienteCol
        Private blnSwitch As Boolean = False
        Private objEntExpPadre As Entity.Registro.InternoExpedientePadre
        Private objBssExpedientePad As New Bussines.Registro.InternoExpedientePadre
        Private intValorpadre As Integer = 0
#Region "Propiedades_Publicas"
        Public Property _RegionId() As Integer = -1
        Public Property _PenalId() As Integer = -1
#End Region
#Region "Propiedades"
        Private Property FechaIni() As Long = 0
        '    Get
        '        Return dtpFechaIni.ValueLong
        '    End Get
        '    Set(value As Long)
        '        dtpFechaIni.ValueLong = value
        '    End Set
        'End Property
        Private Property FechaFin() As Long
            Get
                Return dtpFechaFin.ValueLong
            End Get
            Set(value As Long)
                dtpFechaFin.ValueLong = value
            End Set
        End Property
#End Region
#Region "Otros"
        Private Function Validar() As Boolean
            If Me.FechaFin = 0 Then
                MessageBox.Show("Ingrese la fecha final de la pena conmutada",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtpFechaFin.Focus()
                Return False
            End If
            'If Me.FechaFin = 0 Then
            '    MessageBox.Show("Ingrese la fecha de final del periodo de condena",
            '     Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Return False
            'End If
            'If Me.FechaIni = 0 Then
            '    MessageBox.Show("Ingrese la fecha inicial del periodo de condena",
            '     Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Return False
            'End If
            'If Me.FechaIni > Me.FechaFin Then
            '    MessageBox.Show("Fecha inconsistente, la fecha de inicio no puede ser mayor que la fecha fin del periodo de condena",
            '     Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '  Return False
            ' End If
            Return True
        End Function
        Private Sub ValoresxDefault()

            If Not _EntPeriodoCondena Is Nothing Then
                ' Me.FechaIni = Me._EntPeriodoCondena.FechaInicio
                Me.FechaFin = Me._EntPeriodoCondena.FechaFin
                Me._RegionId = Me._EntPeriodoCondena.RegionId
                Me._PenalId = Me._EntPeriodoCondena.PenalId

                For Each objEntExpediente As Entity.Registro.Expediente In _objEntExpedienteTempoCol
                    objEntExpPadre = New Entity.Registro.InternoExpedientePadre
                    If objEntExpediente.Codigo > 0 Then
                        objEntExpPadre.InternoExpedienteId = objEntExpediente.Codigo
                        Dim blnValor As Boolean = objBssExpedientePad.ValidarExpediente(objEntExpPadre)
                        If blnValor = False Then
                            intValorpadre = intValorpadre + 1
                        End If
                    End If
                Next

                If intValorpadre > 0 Then
                    ' InhabilitarControles()
                End If
            End If
        End Sub
        Private Sub InhabilitarControles()
            'dtpFechaIni.Enabled = False
            dtpFechaFin.Enabled = False
            btnAceptar.Enabled = False
        End Sub
#End Region
#Region "Accion"
        Private Sub AGrabar()
            If Validar() = False Then Exit Sub

            If Me._EntPeriodoCondena Is Nothing Then
                Me._EntPeriodoCondena = New Entity.Registro.Documento.PeriodoCondenaSentencia
            End If

            With _EntPeriodoCondena
                .FechaFin = Me.FechaFin
                .FechaInicio = Me.FechaIni
                .RegionId = Me._RegionId
                .PenalId = Me._PenalId

            End With
        End Sub
#End Region
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            'If intValorpadre > 0 Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente ha sido referenciado, operacion cancelada")
            '    Exit Sub
            'End If
            If Validar() = False Then Exit Sub
            AGrabar()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub frmPeriodoCondenaSentencia_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            ValoresxDefault()
        End Sub
    End Class
End Namespace
