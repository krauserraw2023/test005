Namespace Tratamiento.TallerAsistencia.Horario
    Public Class frmRegularizar
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
#Region "Propiedades_Parametricas"
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1

        Public Property _DiasID() As Integer
            Get
                Return cbbDia.Value
            End Get
            Set(ByVal value As Integer)
                cbbDia.Value = value
            End Set
        End Property
        Public ReadOnly Property _DiasNombre() As String
            Get
                Dim strValue As String = ""
                Try
                    strValue = cbbDia.ValueString
                Catch ex As Exception
                End Try
                Return strValue
            End Get
        End Property
        Public Property _HoraIngreso() As Integer
            Get
                Return Me.nudInicioHora.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudInicioHora.Value = value
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
        Public Property _MinutoIngreso() As Integer
            Get
                Return Me.nudInicioMinuto.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudInicioMinuto.Value = value
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
        Public Property _GH() As Integer
            Get
                Return Me.nudGH.Value
            End Get
            Set(ByVal value As Integer)
                Me.nudGH.Value = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaFotoVisitante() As String
            Get
                Dim strValue As String = ""
                Try
                    'With Me.dgwMenores
                    '    strValue = .SelectedRows(0).Cells("col_vis_fot_nom").Value
                    'End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
        Public ReadOnly Property GrillaInternoID() As Integer
            Get
                Dim strValue As Integer = -1
                Try

                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
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

#Region "Propiedades_Buscar"

#End Region
#Region "Combo"
        Private Sub CargarDias()
            cbbDia._LoadUsc()
        End Sub
#End Region
#Region "Propiedades_Otros"
        'Private Property HoraSalida() As String
        '    Get
        '        Return Me.lblHoraSal.Text.Trim
        '    End Get
        '    Set(ByVal value As String)
        '        Me.lblHoraSal.Text = value
        '    End Set
        'End Property
        Public Property CantidadMenores() As Integer = 0
        Private Property ObsSalida As String = ""
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

            'If Me.BuscarApellidosNombres.Length = 0 And (Me.BuscarNumeroDocumento.Length = 0 Or Me.BuscarNumeroDocumento.Length < 8) Then
            '    If Me.BuscarApellidosNombres.Length = 0 Then
            '        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Apellidos o nombres.")
            '        Me.txtBuscarApellidosNombres.Focus()
            '        Return False
            '    End If
            '    If (Me.BuscarNumeroDocumento.Length = 0 Or Me.BuscarNumeroDocumento.Length < 8) Then
            '        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Apellidos o nombres.")
            '        Me.txtNumeroDocumento.Focus()
            '        Return False
            '    End If
            'End If
            Return value
        End Function
#End Region
#Region "Listar"
        Private Sub ListarData()




            'leer el id del interno
            Dim intIDCodigoInterno As Integer = -1
            Dim blnEsInternoPJ As Boolean = False


            'datos del visitante 
            Dim objEnt As Entity.Visita.Visitante = Nothing

            'objBss = New Bussines.Visita.Visitante
            'objEnt = objBss.Listar(Me._VisitanteID)



            'foto del interno


            'datos del movimiento
            objBssMov = New Bussines.Visita.Movimiento
            Dim objEntMov As New Entity.Visita.Movimiento


            With objEntMov
                Me.CantidadMenores = .MenoresCantidad
                'Me.NumeroPase = .PaseNumero
            End With

            ListarMovimientoMenores()
            'Me.pnlAddObs.Visible = True



        End Sub
        Private Sub ListarMovimientoMenores()

            'Me.gbrMenores.Visible = False

            'objBssMov = New Bussines.Visita.Movimiento
            'objEntColMov = New Entity.Visita.MovimientoCol

            'objEntColMov = objBssMov.ListarMovimientoHijos(Me._MovimientoID)

            'With Me.dgwMenores
            '    .RowsDefaultCellStyle.SelectionForeColor = Color.Black
            '    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
            '    .AutoGenerateColumns = False
            '    .DataSource = objEntColMov
            'End With

            'If Me.dgwMenores.RowCount > 0 And Me.CantidadMenores > 0 Then
            '    Me.gbrMenores.Visible = True
            'End If


        End Sub
        Private Sub BuscarInterno()

            If ValidarBusqueda() = False Then
                Exit Sub
            End If

            Dim blnOK As Boolean = False
            Dim objEntCol As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim objEnt As New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
            objBss = New Bussines.Tratamiento.TallerAsistencia.InternoAsistencia
            With objEnt
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID

            End With
            objEntCol = objBss.ListarTaller(objEnt)

            'If objEntCol.Count > 0 Then

            '    For Each objEnt As Entity.Visita.Visitante In objEntCol
            '        'queda
            '        If objEnt.PenalID = Me._PenalID Then
            '            Me._VisitanteID = objEnt.Codigo
            '            blnOK = True
            '            Exit For
            '        End If
            '    Next
            'End If

            'If blnOK = True Then
            '    blnOK = False

            '    Dim lngFechaIngreso As Long = Legolas.Configuration.Aplication.FechayHora.FechaLong

            '    objBssMov = New Bussines.Visita.Movimiento
            '    objEntColMov = New Entity.Visita.MovimientoCol

            '    objEntColMov = objBssMov.ListarMovimientoFaltaSalida_v2(-1, Me._VisitanteID, lngFechaIngreso, _
            '                     Me._RegionID, Me._PenalID)

            '    If objEntColMov.Count > 0 Then

            '        For Each objEnt As Entity.Visita.Movimiento In objEntColMov
            '            'queda
            '            If objEnt.PenalID = Me._PenalID Then
            '                Me._MovimientoID = objEnt.Codigo
            '                Me.IDMovimientoPadre = objEnt.MovimientoPadre
            '                Me.IDTipoVisita = objEnt.TipoID
            '                Me._HoraIngreso = objEnt.HoraIngreso
            '                Exit For
            '            End If
            '        Next

            '        'pregunto si la visita, es menor de edad
            '        Select Case Me.IDTipoVisita
            '            Case Type.Enumeracion.Visita.TipoVisita.MenorEdad
            '                'si es menor de edad vuelvo a listar el movimiento

            '                objBssMov = New Bussines.Visita.Movimiento
            '                objEntColMov = New Entity.Visita.MovimientoCol

            '                objEntColMov = objBssMov.ListarMovimientoFaltaSalida_v2(Me.IDMovimientoPadre, -1, 0, -1, -1)

            '                If objEntColMov.Count > 0 Then

            '                    For Each objEnt As Entity.Visita.Movimiento In objEntColMov
            '                        'queda
            '                        If objEnt.PenalID = Me._PenalID Then
            '                            Me._MovimientoID = objEnt.Codigo
            '                            Me.IDMovimientoPadre = objEnt.MovimientoPadre
            '                            Me.IDTipoVisita = objEnt.TipoID
            '                            Me._HoraIngreso = objEnt.HoraIngreso
            '                            blnOK = True
            '                            Exit For
            '                        End If
            '                    Next
            '                End If

            '            Case Else
            '                'es adulto
            '                blnOK = True
            '        End Select

            '    End If
            'End If

            'If blnOK = True Then
            '    ListarData()
            '    Me.pnlHora.Visible = True
            '    'Me.pnlAddObs.Visible = True
            '    Me.btnOk.Focus()
            'Else
            '    Limpiar()
            '    Me.txtBuscarApellidosNombres.Text = ""
            '    Me.txtBuscarApellidosNombres.Focus()
            'End If

        End Sub
#End Region
#Region "Accion"
        Private Function ValidarGH() As Boolean
            Dim value As Boolean = True
            If Me._DiasID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar dia")
                value = False
                cbbDia.Focus()
            ElseIf Me._HoraIngreso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar hora de entrada")
                value = False
                nudInicioHora.Focus()
            ElseIf Me._HoraSalida < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar hora de salida")
                value = False
                nudFinHora.Focus()
            ElseIf Me._HoraIngreso >= Me._HoraSalida Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La hora de entrada debe ser menor que hora de salida")
                value = False
                nudInicioHora.Focus()
            ElseIf Me._GH < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar GH")
                value = False
                nudGH.Focus()
            End If
            Return value
        End Function
        Private Function Validar() As Boolean
            Dim value As Boolean = True
            If dgwHorario.Rows.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar horario")
                btnAgregarGH.Focus()
                value = False
            End If
            Return value
        End Function
        Private Sub AOk()

            If Validar() = False Then
                Exit Sub
            End If

            'Dim intValue As Integer = -1
            'Dim objbss As New Bussines.Visita.Movimiento
            'Dim lngFechaSal As Long = Legolas.LBusiness.Globall.DateTime.FechaServerLong
            'Dim intTipoSalidaPor As Short = 1 ' salida x dni

            'intValue = objbss.GrabarSalida_v3(Me._MovimientoID, lngFechaSal, Me.HoraSalida,
            '                                  Me.IDUsuarioAutorizaSalida, Me.ObsSalida, intTipoSalidaPor, Me.IDUsuarioAutorizaSalida)

            'If intValue > 0 Then
            '    Legolas.Configuration.Aplication.MessageBox.InformationGrabar()

            '    Select Case Me._TipoSalida
            '        Case enmTipoSalida.Salida

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

            '        Case enmTipoSalida.SalidaNumeroDocumento
            '            Limpiar()
            '    End Select

            'End If

        End Sub
#End Region
#Region "Form"
        Private Sub Agregar_GrupoHorario()
            If ValidarGH() = False Then
                Exit Sub
            End If
            Dim Num As Integer = 1
            Dim i As Integer = 0
            If dgwHorario.Rows.Count > 0 Then
                i = dgwHorario.Rows.Count
                Num = i + 1
            End If
            With dgwHorario
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                dgwHorario.Rows.Add()
                dgwHorario.Item(0, i).Value = Num
                .Item(1, i).Value = Me._DiasID
                .Item(2, i).Value = Me._DiasNombre
                .Item(3, i).Value = Me._GH
                .Item(4, i).Value = Me._HoraIngreso & ":" & Me._MinutoIngreso
                .Item(5, i).Value = Me._HoraSalida & ":" & Me._MinutoSalida
            End With
            LimpiarGH()
        End Sub
#End Region

#Region "Otros"
        Private Sub LimpiarGH()
            Me._DiasID = 0
            Me._HoraIngreso = 8
            Me._HoraSalida = 8
            Me._GH = 1
        End Sub
        Private Sub CargarData()
            With dgwHorario
                dgwHorario.Rows.Add()
                dgwHorario.Item(0, 0).Value = 1
                '.Item (0,1).Value =frm.
            End With

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

            CargarDias()
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


        Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AOk()

        End Sub


        Private Sub txtBuscarNumDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

            If e.KeyChar = ChrW(Keys.Enter) Then
                BuscarInterno()
                'Me.pnlHora.Focus()
            End If

        End Sub



        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs)

            BuscarInterno()

        End Sub

        Private Sub pnlOK_GotFocus(sender As Object, e As System.EventArgs) Handles pnlOK.GotFocus

            Me.btnOk.Focus()

        End Sub


        Private Sub btnBuscar_GotFocus(sender As Object, e As System.EventArgs)


        End Sub

        Private Sub btnObs_Click(sender As System.Object, e As System.EventArgs)

            Dim frm As New Visita.Movimiento.frmMovSalidaObs
            With frm
                ._Observacion = Me.ObsSalida
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.ObsSalida = ._Observacion
                End If
            End With

        End Sub

        Private Sub UscFotografia_2v1_Load(sender As System.Object, e As System.EventArgs)

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

        End Sub

        Private Sub dgwGrilla_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

        End Sub

        Private Sub txtBuscarApellidosNombres_TextChanged(sender As System.Object, e As System.EventArgs)

        End Sub
        Private Sub btnAgregarGH_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarGH.Click
            Agregar_GrupoHorario()
        End Sub

        Private Sub btnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitar.Click

        End Sub
    End Class

End Namespace
