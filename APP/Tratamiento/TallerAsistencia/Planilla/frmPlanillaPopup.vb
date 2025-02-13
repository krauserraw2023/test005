
Imports System.Linq

Namespace Tratamiento.TallerAsistencia.Planilla
    Public Class frmPlanillaPopup

        Private objBss As Bussines.Tratamiento.TallerAsistencia.PlanillaCabecera = Nothing

#Region "Propiedades"

        Public Property _PlanillaID() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Private Property IDTaller() As Integer
            Get
                Dim value As Integer = -1
                Return Me.cbbTalleres.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTalleres.SelectedValue = value
            End Set
        End Property
        Private Property Anio() As Integer
            Get
                Return Me.cbbAnio.Value
            End Get
            Set(ByVal value As Integer)
                Me.cbbAnio.Value = value
            End Set
        End Property
        Private Property Mes() As Integer
            Get
                Return Me.cbbMes.Value
            End Get
            Set(ByVal value As Integer)
                Me.cbbMes.Value = value
            End Set
        End Property
        Private Property EstadoID() As Short = 1 ' activo        
        Private Property FechaProceso() As Long = 0
        Private Property Observacion() As String
            Get
                Return Me.txtObs.Text.Trim()
            End Get
            Set(ByVal value As String)
                Me.txtObs.Text = value
            End Set
        End Property

#End Region

#Region "Combo"
        Private Sub ComboAnioMes()
            Dim intAnio As Integer = Legolas.Configuration.Aplication.FechayHora.FechaAnio
            With Me.cbbAnio
                .AnioInicio = 2018
                .AnioFin = intAnio
                .LoadUsc()
            End With

            With Me.cbbMes
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboTalleres()
            With Me.cbbTalleres
                .CodigoPadre = Me._PenalID
                ._LoadUsc(Type.Combo.Tratamiento.Trabajo.TallerAsistencia.Talleres, True)
            End With
        End Sub

#End Region
#Region "Listar"
        Private Sub Listar()

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean
            Dim value As Boolean = False
            If Me.Anio > Now.Year Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El año no puede ser mayor al actual")
                Me.cbbAnio.Focus()
                Return value
            End If

            If Me.Anio < Now.Year Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El año no puede ser menor al actual")
                Me.cbbAnio.Focus()
                Return value
            End If

            If Me.Anio < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el año para la planilla")
                Me.cbbAnio.Focus()
                Return value
            End If

            If Me.Mes < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el mes para la planilla")
                Me.cbbMes.Focus()
                Return value
            End If

            If Me.Mes > 0 And Me.Mes > Now().Date.Month Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede generar la planilla de meses posteriores")
                Me.cbbMes.Focus()
                Return value
            End If

            value = True

            Return value

        End Function

        Private Sub AGrabar()

            If Me.IDTaller < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar un Taller o Actividad Laboral")
                cbbTalleres.Focus()
                Exit Sub
            End If

            Dim strMensaje As String = "Esta seguro de realizar la operación"
            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) <> Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If

            objBss = New Bussines.Tratamiento.TallerAsistencia.PlanillaCabecera
            Dim obj As Entity.Tratamiento.TallerAsistencia.PlanillaCabecera
            If Validar() = True Then

                obj = New Entity.Tratamiento.TallerAsistencia.PlanillaCabecera
                Dim dteFechaInicio As Date = Legolas.Components.FechaHora.FechaDateConcatenar(Me.Anio, Me.Mes, 1)

                With obj
                    .Codigo = -1
                    .IDRegion = Me._RegionID
                    .IDPenal = Me._PenalID
                    .IDTaller = Me.IDTaller
                    .Anio = Me.Anio
                    .Mes = Me.Mes
                    .FechaProceso = Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong
                    .FechaInicio = Legolas.Components.FechaHora.FechaPrimerDiaMes(dteFechaInicio.ToFileTime)
                    .FechaFin = Legolas.Components.FechaHora.FechaUltimoDiaMes(.FechaInicio)
                    .Estado = Me.EstadoID
                    .Observacion = Me.Observacion
                End With

                Me._PlanillaID = objBss.Grabar(obj)

                If Me._PlanillaID > 0 Then
                    'Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe una Planilla del Taller " & cbbTalleres.Text + Chr(13) +
                                                                            "en el periodo " & Me.cbbMes.MesString & "/" & Me.Anio)
                End If
            End If
        End Sub


#End Region

#Region "Usuarios/Permisos/Accesos"

        Private Sub UsuariosPermisos()

            Me.pnlGrabar.Visible = Me._FormEscritura

            If Me._PlanillaID > 0 Then
                Me.pnlGrabar.Visible = False
            End If

        End Sub
#End Region

#Region "Otros"
        Private Sub ValoresxDefault()

            ComboAnioMes()
            ComboTalleres()

            Me.Anio = Legolas.Configuration.Aplication.FechayHora.FechaAnio
            Me.Mes = Legolas.Configuration.Aplication.FechayHora.FechaMes

            Me.txtFechaprocesamiento.Text = Legolas.Components.FechaHora.FechaDate(Legolas.LBusiness.Globall.DateTime.FechaServerLong, True)
            UsuariosPermisos()

        End Sub
#End Region
        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click

            AGrabar()

        End Sub

        Private Sub frmPadinPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

    End Class
End Namespace