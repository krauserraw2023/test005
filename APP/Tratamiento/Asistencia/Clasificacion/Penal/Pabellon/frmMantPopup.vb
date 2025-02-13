Imports Bussines.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Mantenimiento.General
Imports Entity.Registro

Namespace Tratamiento.Asistencia.Clasificacion.Penal.Pabellon
    Public Class frmMantPopup
        Public _frmLectura As Boolean = False
        Public _frmEscritura As Boolean = False
        Public _frmReporte As Boolean = False
        Public _frmImpresion As Boolean = False
        Public _frmEliminar As Boolean = False

        Public accionEjecutada As DialogResult = DialogResult.Cancel   'flag para saber si se grabó como nuevo o edicion

        Private objBss As Pabellon_BL = Nothing
        Private objEnt As Pabellon_BE = Nothing

        Private objBssRegimenEtapa As Bussines.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BL = Nothing
        Private objEntRegimenEtapa As Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE = Nothing

#Region "Propiedades_Publicas"
        Public Property _Codigo As Integer = -1
#End Region

#Region "Propiedades_Privadas"
        'Private Property IDRegion As Short = -1
        'Private Property IDPenal As Short = -1
        Private Property Nombre As String
            Get
                Return Me.txtNombre.Text.ToUpper
            End Get
            Set(value As String)
                Me.txtNombre.Text = value.ToUpper
            End Set
        End Property
        Private Property NombreCorto As String
            Get
                Return Me.txtNombreCorto.Text.ToUpper
            End Get
            Set(value As String)
                Me.txtNombreCorto.Text = value.ToUpper
            End Set
        End Property
        Private Property Observacion As String
            Get
                Return Me.txtObs.Text.ToUpper
            End Get
            Set(value As String)
                Me.txtObs.Text = value.ToUpper
            End Set
        End Property
        Private Property Estado As Short = 1 'activo
        Private Property EstadoNombre As String
            Get
                Return Me.txtEstado.Text.ToUpper
            End Get
            Set(value As String)
                Me.txtEstado.Text = value.ToUpper
            End Set
        End Property


        Public Property _PenalTodos As Boolean = True
        Private Property RegionID() As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Private Property PenalID() As Integer
            Get
                Return Me.cbbPenal.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property
#End Region

#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Listar"
        Private blnComboRegion As Boolean = False
        Private blnComboPenal As Boolean = False
        Private Sub ComboRegion()
            blnComboRegion = False

            With Me.cbbRegion
                .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                .Parametro1 = Legolas.LBusiness.Globall.WinApp.LicenciaApp
                .LoadUsc()
            End With

            blnComboRegion = True

        End Sub
        Private Sub ComboPenal()
            blnComboPenal = False

            Dim blnTodos As Boolean = False


            If Legolas.LBusiness.Globall.WinApp.LicenciaApp = 1 And Me._PenalTodos = True Then 'licencia sede central
                blnTodos = True
            End If

            With Me.cbbPenal
                .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                .CodigoPadre = Me.RegionID
                .Parametro1 = Legolas.LBusiness.Globall.WinApp.LicenciaApp
                ._Todos = blnTodos
                .LoadUsc()
            End With


            blnComboPenal = True
        End Sub
        Private Sub ListarData()

            If Me._Codigo < 1 Then
                Me.txtNombre.Focus()
                Exit Sub
            End If

            objBss = New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.Pabellon_BL
            objEnt = New Pabellon_BE

            objEnt = objBss.Listar(Me._Codigo)

            With objEnt
                Me.RegionID = .IDRegion
                Me.PenalID = .IDPenal
                Me.Nombre = .Nombre
                Me.NombreCorto = .NombreCorto
                Me.Observacion = .Observacion
                Me.Estado = .Estado
                Me.EstadoNombre = .EstadoNombre
            End With

            ListarGrilla()

        End Sub
        Private Sub ListarGrilla()

            objBssRegimenEtapa = New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BL
            Dim objEntFiltroRegimenEtapa As New Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE

            With objEntFiltroRegimenEtapa
                .IDPabellon = Me._Codigo
                .IDRegion = Me.RegionID
                .IDPenal = Me.PenalID
            End With

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objBssRegimenEtapa.ListarGrilla(objEntFiltroRegimenEtapa)
            End With

        End Sub
#End Region

#Region "Accion"
        Private Sub ValoresxDefault()

            ComboRegion()
            ComboPenal()

        End Sub
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            'nombres
            If Me.Nombre.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese nombre del pabellón")
                Me.txtNombre.Focus()
                Return value
            End If
            If Me.PenalID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el penal")
                Return value
            End If
            'validar el pabellon por nombre, para evitar datos repetidos'xxx
            objBss = New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.Pabellon_BL
            If objBss.ValidarExisteNombrePabellon(Me.PenalID, Me._Codigo, Me.Nombre) = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El nombre de pabellón ingresado, ya existe en la base de datos")
                Me.txtNombre.Focus()
                Return value
            End If

            value = True
            Return value

        End Function

        Private Sub AGrabar()

            Dim value As Boolean = False

            If Validar() = False Then
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar <> DialogResult.Yes Then
                Exit Sub
            End If

            Dim strMensajeOut As String = ""
            objBss = New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.Pabellon_BL
            objEnt = New Pabellon_BE

            With objEnt
                .Codigo = Me._Codigo
                .IDRegion = Me.RegionID
                .IDPenal = Me.PenalID
                .Nombre = Me.Nombre.Trim.ToUpper
                .NombreCorto = Me.NombreCorto.Trim.ToUpper
                .Observacion = Me.Observacion.Trim
                .Estado = Me.Estado
            End With



            Me._Codigo = objBss.Grabar(objEnt, strMensajeOut)

            If Me._Codigo > 0 Then
                accionEjecutada = DialogResult.OK

                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeOut)
            End If

        End Sub

        Private Sub AGrabarRegimenEtapa(intIDPabelon As Integer, intIDRegimen As Short, intIDEtapa As Short)

            objBssRegimenEtapa = New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BL
            objEntRegimenEtapa = New Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE

            Dim intValue As Integer = -1
            Dim strMensajeOut As String = ""

            With objEntRegimenEtapa
                .Codigo = -1
                .IDPabellon = intIDPabelon
                .IDRegimen = intIDRegimen
                .IDEtapa = intIDEtapa
                .IDRegion = Me.RegionID
                .IDPenal = Me.PenalID
            End With

            intValue = objBssRegimenEtapa.Grabar(objEntRegimenEtapa, strMensajeOut)

            If intValue > 0 Then
                ListarGrilla()
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeOut)
            End If

        End Sub
        Private Sub AEliminarRegimenEtapa()

            If Me.GrillaCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione registro")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea eliminar el registro seleccionado") <> DialogResult.Yes Then
                Exit Sub
            End If

            objBssRegimenEtapa = New Bussines.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BL
            Dim intValue As Integer = -1

            intValue = objBssRegimenEtapa.Eliminar(Me.GrillaCodigo)

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                ListarGrilla()
            End If

        End Sub
#End Region
#Region "Form"
        Private Sub FRM_SeleccionarRegimenEtapa()

            If Me._Codigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Para agregar el régimen/etapa del pabellón. Debe grabar los datos del pabellón")
                Exit Sub
            End If

            Dim frm As New Tratamiento.Asistencia.Clasificacion.Penal.Pabellon.frmRegimenPopup
            With frm
                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    If Legolas.Configuration.Aplication.MessageBox.Question("Desea agregar el régimen/etapa al pabellón") = DialogResult.Yes Then
                        AGrabarRegimenEtapa(Me._Codigo, .getIDRegimen, .getIDEtapa)
                    End If

                End If
            End With

        End Sub
        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged

            If blnComboRegion = True Then
                ComboPenal()
            End If

        End Sub

#End Region
#Region "Permisos"

        Private Sub PermisosUsuario()

            Me.pnlGrabar.Visible = Me._frmEscritura
            Me.pnlAgregar.Visible = Me._frmEscritura
            Me.pnlEliminar.Visible = Me._frmEliminar

        End Sub

        Private Sub frmMantenimiento_Load(sender As Object, e As EventArgs) Handles Me.Load

            PermisosUsuario()

        End Sub

        Private Sub frmMantenimiento_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            ValoresxDefault()
            ListarData()

        End Sub

        Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

            AGrabar()

        End Sub

        Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

            AEliminarRegimenEtapa()

        End Sub

        Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

            FRM_SeleccionarRegimenEtapa()

        End Sub
#End Region
    End Class
End Namespace