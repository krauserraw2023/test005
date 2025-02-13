Namespace Tratamiento.TallerAsistencia
    Public Class frmCalendario
        Private objBss As Bussines.Tratamiento.TallerAsistencia.InternoAsistencia = Nothing
        'movimiento
        Private objBssMov As Bussines.Visita.Movimiento = Nothing
        Private objEntColMov As Entity.Visita.MovimientoCol = Nothing
#Region "Enum"
        Public Enum enmTipoSalida
            Ninguno = 0
            Salida = 1
            SalidaNumeroDocumento = 2
        End Enum
#End Region
#Region "Propiedades"
        Public Property _Codigo() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property _FechaAsistencia() As String
            Get
                Return Me.txtFecha.Text
            End Get
            Set(ByVal value As String)
                Me.txtFecha.Text = value
            End Set
        End Property
        Public Property _HoraEntrada() As String
        Public Property _HoraIngreso() As Integer
            Get
                Return Me.nudInicioHora.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudInicioHora.Value = value
            End Set
        End Property
        Public Property _MinutoIngreso() As Integer
            Get
                Return Me.nudInicioMinuto.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudInicioMinuto.Value = value
            End Set
        End Property


        Public Property _HoraSalida() As Integer
            Get
                Return Me.nudFinHora.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudFinHora.Value = value
            End Set
        End Property

        Public Property _MinutoSalida() As Integer
            Get
                Return Me.nudFinMinuto.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudFinMinuto.Value = value
            End Set
        End Property

        Private ReadOnly Property HoraMinutosSalida As String
            Get
                Dim val As String = ""
                val = IIf(Me._HoraSalida > 9, Me._HoraSalida, "0" & Me._HoraSalida) & ":" & IIf(Me._MinutoSalida > 9, Me._MinutoSalida, "0" & Me._MinutoSalida) & ":" & "00"
                Return val
            End Get
        End Property

#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaFecha() As String
            Get
                Dim strValue As String = ""
                Try
                    'With Me.dgwGrilla
                    '    strValue = Legolas.Configuration.Aplication.FechayHora.FechaLong
                    'End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
#End Region



#Region "Propiedades_Otros"
        Private Property Observacion() As String
            Get
                Return Me.txtObservacion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObservacion.Text = value
            End Set
        End Property
        Private ReadOnly Property IDUsuarioAutorizaSalida As Integer
            Get
                Return Legolas.Configuration.Usuario.Codigo
            End Get
        End Property
#End Region
#Region "Validar"

        Private Property pnlHora As Object

        Private Function ValidarBusqueda() As Boolean
            Dim objCol As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim obj As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
            objBss = New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia
            Dim value As Boolean = True

            Return value
        End Function
#End Region

#Region "Accion"
        Private Function Validar() As Boolean
            Dim value As Boolean = True
            If nudInicioHora.Value = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar la hora de entrada")
                nudInicioHora.Focus()
                Return False
            End If
            If nudFinHora.Value = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar la hora de salida")
                nudFinHora.Focus()
                Return False
            End If
            If nudInicioHora.Value > nudFinHora.Value Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La hora entrada no puede ser mayor que la hora salida")
                nudFinHora.Focus()
                Return False
            End If
            If nudInicioHora.Value = nudFinHora.Value Then
                If nudInicioMinuto.Value >= nudFinMinuto.Value Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La hora entrada no puede ser mayor o igual que la hora salida")
                    nudFinHora.Focus()
                    Return False
                End If
            End If
            If Me.txtObservacion.Text.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar motivo de la justificación")
                txtObservacion.Focus()
                Return False
            End If
            Return value
        End Function
        Private Sub AOk()
            If Validar() = False Then
                Exit Sub
            End If

            Dim intValue As Integer = -1
            Dim objbss As New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia
            Dim obj As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
            With obj
                obj.Codigo = Me._Codigo
                obj.InternoID = Me.InternoID
                obj.HoraEntrada = Me._HoraEntrada
                obj.HoraSalida = Me.HoraMinutosSalida
                obj.Observacion = Me.Observacion
            End With
            intValue = objbss.Grabar(obj, "")

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub
#End Region

#Region "Otros"
        Private Sub LimpiarGH()

            Me._HoraIngreso = 8
            Me._HoraSalida = 8

        End Sub
        Private Sub CargarData()


        End Sub


        Private Sub ValoresxDefault()

            Me.Timer1.Enabled = True
            'Me.HoraSalida = Legolas.LBusiness.Globall.DateTime.HoraServer

            'Me.gbrBuscarNumDoc.Visible = False



            'centrar form
            'leer el id del interno
            Dim intIDCodigoInterno As Integer = -1



            If intIDCodigoInterno < 1 Then
                Legolas.Configuration.Aplication.CentrarForm(Me)
            End If


        End Sub
        Private Sub Limpiar()

            'Me.NumeroDocumento = ""
            'Me.TipoDocumento = ""
            'Me.ApellidoPaterno = ""
            'Me.ApellidoMaterno = ""
            'Me.Nombres = ""
            'Me.Nacionalidad = ""
            'Me.Sexo = ""


        End Sub

#End Region

        Private Sub frmSalidaPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub




        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AOk()

        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub pnlOK_GotFocus(sender As Object, e As System.EventArgs) Handles pnlOK.GotFocus

            Me.btnOk.Focus()

        End Sub


    End Class

End Namespace
