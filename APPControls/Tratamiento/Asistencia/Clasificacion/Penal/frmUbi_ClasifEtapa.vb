Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal

Namespace Tratamiento.Asistencia.Clasificacion.Penal

    Public Class frmUbi_ClasifEtapa
        Private objEnt As InternoPabellon_BE = Nothing

        Private blnClickGrilla As Boolean = False
#Region "Eventos"
        Public Event _Grilla_CellEnter(intCodigo As Integer, TipoTablaAudit As Type.Enumeracion.Auditoria.EnumTipTabla)
        Public Event _Reporte_Click(intIDFichaFinalEtapa As Integer)
#End Region
#Region "Enum"
        Private Enum EnmEstado As Short
            Pendiente = 1
            Finalizado = 2
        End Enum
#End Region
#Region "Propiedades_Publicas"
        'Public Property _IDInternoPabellon As Integer = -1
        Public Property InternoPenalFichaId As Integer = -1
        'Public Property _IDInterno As Integer = -1
        'Public Property _InternoApeNom As String = ""
        'Public Property _IDIngresoInpe As Integer = -1
        'Public Property _IDIngreso As Integer = -1
        Public Property _InternoEstado As Short = -1
        'Public Property _IDRegion As Short = -1
        'Public Property _IDPenal As Short = -1
#End Region
#Region "Propiedades_UserControl"
        Public Property _uscPerfilUsuario As Type.Enumeracion.Usuario.EnumDependencia
        Public Property _uscEscritura As Boolean = False
        Public Property _uscEliminar() As Boolean = False
        Public Property _uscReporte() As Boolean = False
#End Region
#Region "Propiedades_Privadas"
        'Private Property PisoId As Integer = -1
        Private Property AleroId As Integer = -1
        Private Property Codigo As Integer = -1

        Private Property NumeroClasificacion As String
            Get
                Return Me.txtNumClasificacion.Text
            End Get
            Set(value As String)
                Me.txtNumClasificacion.Text = value
            End Set
        End Property

        Private Property SituacionJuridica As String
            Get
                Return Me.lblSituacionJuridica.Text
            End Get
            Set(value As String)
                Me.lblSituacionJuridica.Text = value
            End Set
        End Property
        Private Property FechaClasificacion As String
            Get
                Return Me.lblFechaClasificacion.Text
            End Get
            Set(value As String)
                Me.lblFechaClasificacion.Text = value
            End Set
        End Property
        Private Property Regimen As String
            Get
                Return Me.lblRegimen.Text
            End Get
            Set(value As String)
                Me.lblRegimen.Text = value
            End Set
        End Property
        Private Property Etapa As String
            Get
                Return Me.lblEtapa.Text
            End Get
            Set(value As String)
                Me.lblEtapa.Text = value
            End Set
        End Property
        Private Property Estado As String
            Get
                Return Me.lblEstado.Text
            End Get
            Set(value As String)
                Me.lblEstado.Text = value
            End Set
        End Property
        Public Property IDPabellon As Integer = -1
        Private Property Pabellon As String
            Get
                Return Me.lblPabellon.Text.ToUpper
            End Get
            Set(value As String)
                Me.lblPabellon.Text = value.ToUpper
            End Set
        End Property
        Private Property Piso As String
            Get
                Return Me.txtPiso.Text
            End Get
            Set(value As String)
                Me.txtPiso.Text = value
            End Set
        End Property
        Private Property Ambiente As String
            Get
                Return Me.txtAmbiente.Text
            End Get
            Set(value As String)
                Me.txtAmbiente.Text = value
            End Set
        End Property

        Private Property Cama As String
            Get
                Return Me.txtCama.Text
            End Get
            Set(value As String)
                Me.txtCama.Text = value
            End Set
        End Property
        Private Property Observacion As String
            Get
                Return Me.txtObs.Text
            End Get
            Set(value As String)
                Me.txtObs.Text = value
            End Set
        End Property
#End Region
#Region "Listar"
        Public Sub _ListarUsc()

            MostrarControlesFicha()
            ListarGrilla()

        End Sub
        Private Sub ListarGrilla()

            'If Me._IDInterno < 1 Then Exit Sub

            'Dim objEntFiltro As New InternoPabellon_BE With {
            '        .IDInterno = Me._IDInterno,
            '        .IDIngreso = Me._IDIngreso,
            '        .IDIngresoInpe = Me._IDIngresoInpe,
            '        .IDRegion = Me._IDRegion,
            '        .IDPenal = Me._IDPenal
            '    }
            Dim objEntFiltro As New InternoPabellon_BE With {
                    .IDFichaEtapa = Me.InternoPenalFichaId
                }

            Dim lst As List(Of InternoPabellon_BE)
            lst = (New InternoPabellon_BL).ListarGrilla(objEntFiltro)

            If lst.Count = 0 Then Exit Sub

            Dim ent As InternoPabellon_BE = lst.Item(0)

            With ent
                Me.Codigo = .Codigo
                Me.NumeroClasificacion = .NumeroClasificacionRegimen
                Me.SituacionJuridica = .SituacionJuridicaNombre
                Me.FechaClasificacion = .FechaClasificacionRegimenCadena
                Me.Regimen = .RegimenNombre
                Me.Etapa = .EtapaNombre
                Me.Estado = .EstadoNombre
                Me.IDPabellon = .IDPabellon
                Me.Pabellon = .PabellonNombre
                Me.Piso = .Piso
                Me.Ambiente = .Ambiente
                Me.txtAlero.Text = .Ala
                Me.Cama = .Cama
                Me.Observacion = .Observacion
                Me.Ambiente = .Ambiente
                Me.AleroId = .AlaId
            End With

            If ent.Estado = 2 Then
                btnFinalizar.Enabled = False
                btnGrabarClasificacion.Enabled = False
            End If
        End Sub


        Private Sub btnNuevo_Click(sender As Object, e As EventArgs)
            ANuevo()
        End Sub
#End Region
#Region "Validar"
        Private Function ValidarDatosInterno() As Boolean

            'If Me._IDInterno = -1 Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Para completar la acción, guardar los datos básicos del interno.")
            '    Return False
            'End If

            'If Me._IDIngreso < 1 Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe ningún Ingreso activo, ir a la etiqueta [N° Ingreso] y registrar.")
            '    Return False
            'End If

            If Me._InternoEstado = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El estado del interno se encuentra inactivo.")
                Return False
            End If

            Return True
        End Function
        'Private Function ValidarNuevaUbicacion()

        '    If ValidarDatosInterno() = False Then Return False

        '    'validar la etapa del interno            
        '    'If (New InternoPabellon_BL).fn_ObtenerIDFichaEtapa(Me.GrillaCodigo) < 1 Then
        '    '    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha finalizado la clasificacion de la etapa del interno, verifique")
        '    '    Return False
        '    'End If

        '    'If Me.GrillaIDEtapa > 0 Then
        '    '    Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro de ubicacion del interno, ya se encuentra activo")
        '    '    Return False
        '    'End If

        '    'Return True

        'End Function
        Private Function ValidarDatosPabellon()

            If Me.lblEstado.Text = "FINALIZADO" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro no se puede grabar, porque ya se encuentra finalizado")
                Return False
            End If

            If Me.IDPabellon < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione pabellon")
                Return False
            End If

            Return True
        End Function
#End Region
#Region "Accion"
        Private Sub ANuevo()

            'If ValidarNuevaUbicacion() = False Then Exit Sub

            'Dim strMensaje As String = "Desea habilitar la ubicacion del interno: " & Me._InternoApeNom.ToUpper

            'If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = DialogResult.Yes Then

            '    Dim strMensajeOut As String = ""

            '    Dim value As Integer = (New InternoPabellon_BL).GrabarEtapa(Me.GrillaCodigo, strMensajeOut)

            '    If value > 0 Then
            '        Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
            '        ListarGrilla()

            '        Limpiar()
            '    End If

            'End If
        End Sub

        Private Function AGrabar() As Integer
            Dim id As Integer = -1
            If ValidarDatosPabellon() = False Then Return -1

            objEnt = New InternoPabellon_BE

            With objEnt
                .Codigo = Me.Codigo
                .AlaId = Me.AleroId
                .Ambiente = txtAmbiente.Text.Trim().ToUpper()
                .Cama = Me.Cama.Trim().ToUpper()
                .Observacion = Me.Observacion.Trim()
            End With

            Dim strMensaje As String = ""

            id = (New InternoPabellon_BL).GrabarPabellon(objEnt, strMensaje)



            Return id
        End Function

        Private Sub AFinalizar()

            'validar el estado de la ficha
            If Me.lblEstado.Text = "FINALIZADO" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El registro actual, ya se encuentra en el estado finalizado")
                Exit Sub
            End If

            Dim strMensaje As String = "Confirma finalizar el registro seleccionado?, luego de finalizar ya no podrá modificar."

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = DialogResult.Yes Then

                Dim strMensajeOut As String = ""
                Dim value As Integer = (New InternoPabellon_BL).GrabarEstado(Me.Codigo, EnmEstado.Finalizado, strMensajeOut)
                If value > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                    ListarGrilla()
                End If
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub MostrarControlesFicha()
            Exit Sub
            Dim blnEscritura As Boolean = False
            If Me._uscEscritura = True Then
                Select Case Me._uscPerfilUsuario
                        'nada
                    Case Type.Enumeracion.Usuario.EnumDependencia.TratamientoPenitenciario,
                           Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion

                        blnEscritura = True
                End Select
            End If

            Me.gbDatosFicha.Enabled = False

            If Me._uscPerfilUsuario = Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion Then
                btnFinalizar.Enabled = False
                btnGrabarClasificacion.Enabled = False
            End If
        End Sub
        Private Sub Limpiar()

            Me.IDPabellon = -1
            Me.Pabellon = ""
            Me.Piso = ""
            Me.Ambiente = ""
            Me.Cama = ""
            Me.Observacion = ""

        End Sub
#End Region

        Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
            If AGrabar() <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo grabar, por favor intentelo nuevamente.")
                Exit Sub
            End If
            AFinalizar()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub



        Private Sub btnAlero_Click(sender As Object, e As EventArgs) Handles btnAlero.Click
            Dim f As New frmSelectAleroPopup
            f._PabellonId = Me.IDPabellon
            f._PabellonNombre = lblPabellon.Text
            If f.ShowDialog = DialogResult.OK Then
                Me.Piso = f._PisoNom
                Me.txtAlero.Text = f._AleroNom
                Me.AleroId = f._AleroId
            End If
        End Sub

        Private Sub frmUbi_ClasifEtapa_Load(sender As Object, e As EventArgs) Handles Me.Load
            Me._ListarUsc()
        End Sub

        Private Sub btnGrabarClasificacion_Click(sender As Object, e As EventArgs) Handles btnGrabarClasificacion.Click

            If AGrabar() > 0 Then
                Me.gbDatosFicha.Enabled = False
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
            End If
        End Sub

    End Class


End Namespace