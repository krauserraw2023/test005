Imports System.Data

Namespace Registro.ConsultaReclusion
    Public Class uscInternoDetalle
        Private objBss As Bussines.Registro.ConstanciaReclusion.Tramite = Nothing
        Public Event _Click_Imprimir(idCodigo As Integer, estado As Short)
        Public Event _Click_Nuevo()
        Public Event _Click_Modificar(idTramite As Integer)
        Public Event _CellDoubleClick_Modificar(idTramite As Integer)
#Region "Propiedades"
        Private idLicencia As Short = -1
        Private Property idInterno As Integer = -1
        Private Property idIngresoInpe As Integer = -1
        Private Property idIngreso As Integer = -1
        Private Property idRegion As Short = -1
        Private Property idPenal As Short = -1
        Private Property internoCodigoRP As String = ""
        Private Property internoApeNom As String = ""
        Private Property regionNombre As String = ""
        Private Property penalNombre As String = ""
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property grillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try

                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_codigo").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
        Private ReadOnly Property grillaNumeroTramite() As String
            Get
                Dim value As String = ""
                Try

                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_num_Tram").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property grillaNumeroCR() As String
            Get
                Dim value As String = ""
                Try

                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_num_cr").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
        Private ReadOnly Property grillaEstado() As Short
            Get
                Dim value As Short = -1
                Try

                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_est").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "listar"
        Private Sub listarGrilla()

            Dim objFiltro As New Entity.Registro.ConstanciaReclusion.Tramite
            With objFiltro
                .idRegion = Me.idRegion
                .idPenal = Me.idPenal
                .idInterno = Me.idInterno
                .idIngresoInpe = Me.idIngresoInpe
                .idIngreso = Me.idIngreso
            End With

            Dim lista As New List(Of Entity.Registro.ConstanciaReclusion.Tramite)
            objBss = New Bussines.Registro.ConstanciaReclusion.Tramite

            lista = objBss.listarGrillaInterno(objFiltro)

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = lista
            End With

        End Sub
#End Region
#Region "Validar"
        Private Function validarNuevaConstancia() As Boolean

            Dim value As Boolean = False
            Dim mensaje As String = ""

            objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
            If objBss.validarInternoUltimoIngreso(Me.idInterno, Me.idIngresoInpe, Me.idIngreso, mensaje) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(mensaje)
                Return value
            End If

            If Me.idIngresoInpe > 0 Then

                'validar, la cantidad de expedientes
                Dim cantidadExpe As Integer = 0
                objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                cantidadExpe = objBss.fnCantidadExpedientes(Me.idInterno, Me.idIngresoInpe)

                If cantidadExpe > 0 Then
                    objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                    If objBss.validarExpedienteDmpSmp(Me.idInterno, Me.idIngresoInpe, Me.idIngreso, mensaje) = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(mensaje)
                        Return False
                    End If
                End If

            Else
                'provincia
                'validar dmp y smp
                objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                If objBss.validarExpedienteDmpSmp(Me.idInterno, Me.idIngresoInpe, Me.idIngreso, mensaje) = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(mensaje)
                    Return value
                End If
            End If

            Return True
        End Function
#End Region
#Region "Accion"
        Private Sub eliminar()

            If Me.grillaCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione el registro")
                Exit Sub
            End If

            If Me.grillaEstado = Type.Enumeracion.ConstanciaReclusion.enmEstado.pendiente Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = DialogResult.Yes Then
                    objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                    Dim value As Integer = -1
                    value = objBss.Eliminar(Me.grillaCodigo)

                    If value > 0 Then
                        listarGrilla()
                    End If
                End If
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo se puede eliminar si el registro se encuentra en estado PENDIENTE")
            End If

        End Sub
#End Region
#Region "Formularios"

        Private Sub frmVerImpresiones()

            Dim frm As New Registro.ConstanciaReclusion.frmImpresion(Me.grillaCodigo, Me.grillaNumeroTramite, Me.grillaNumeroCR)
            With frm
                .ShowDialog()
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub permisos()

            Dim tipoLicencia As Short = -1
            Dim bssLicencia As New Bussines.Sistema.Instalacion
            tipoLicencia = bssLicencia.ListarTipo(Me.idLicencia)

            If tipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia Or
                tipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Sede Then
                Me._visibleBotones = False
            End If

        End Sub
        Public Sub _loadUsc(idLicencia As Short, idInterno As Integer, idIngresoInpe As Integer, idIngreso As Integer, idRegion As Short, idPenal As Short,
                            internoCodigoRP As String, internoApeNombres As String, regionNombre As String, penalNombre As String)

            Me.idLicencia = idLicencia
            Me.idInterno = idInterno
            Me.idIngresoInpe = idIngresoInpe
            Me.idIngreso = idIngreso
            Me.idRegion = idRegion
            Me.idPenal = idPenal
            Me.internoCodigoRP = internoCodigoRP
            Me.internoApeNom = internoApeNombres
            Me.regionNombre = regionNombre
            Me.penalNombre = penalNombre

            permisos()
            listarGrilla()

        End Sub

#End Region
#Region "Funciones_Publicas"
        Public Sub _exportar()
            Legolas.Components.ExportarGrillaExcel.Exportar(Me.dgwGrilla)
        End Sub

        Public Sub _buscar()
            listarGrilla()
        End Sub
        Public Property _visibleBotones As Boolean
            Get
                Return Me.pnlBotones.Visible
            End Get
            Set(value As Boolean)
                Me.pnlBotones.Visible = value
            End Set
        End Property
#End Region

        Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

            If validarNuevaConstancia() = False Then
                Exit Sub
            End If

            RaiseEvent _click_Nuevo()

        End Sub

        Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

            If Me.grillaCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione el registro")
                Exit Sub
            End If

            If Me.grillaEstado <> Type.Enumeracion.ConstanciaReclusion.enmEstado.pendiente Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo se puede modificar cuando el registro de tramite se encuentre en el estado [Pendiente].")
                Exit Sub
            End If

            RaiseEvent _click_Modificar(Me.grillaCodigo)

        End Sub

        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
            eliminar()
        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            With Me.dgwGrilla
                Select Case e.ColumnIndex

                    Case .Columns("col_cant_impr").Index

                        frmVerImpresiones()

                    Case Else

                        If Me.grillaCodigo > 0 Then
                            RaiseEvent _CellDoubleClick_Modificar(Me.grillaCodigo)
                        End If

                End Select
            End With
        End Sub

        Private Sub btnImpresion_Click(sender As Object, e As EventArgs) Handles btnImpresion.Click

            If Me.grillaCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione el registro")
                Exit Sub
            End If

            RaiseEvent _click_Imprimir(Me.grillaCodigo, Me.grillaEstado)
            listarGrilla()

        End Sub

    End Class
End Namespace

