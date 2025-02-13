Namespace Visita.Autorizacion
    Public Class frmAutorizacionAddPopup
        Private objBss As Bussines.Visita.Autorizacion = Nothing
        Private objEntColTemp As List(Of Entity.Visita.Autorizacion) = Nothing
        '12-09-2024 e.cu.cco
        Private objBssAutConf As Bussines.Visita.AutorizacionConfiguracion = Nothing
        Private objEntAutConf As Entity.Visita.AutorizacionConfiguracion = Nothing
#Region "Propiedades_Par"
        Public Property _RegionID As Integer = -1
        Public Property _PenalID As Integer = -1
        Public Property _InternoID As Integer = -1
        Public Property _InternoApeNom As String
            Get
                Return Me.txtIntApeNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIntApeNom.Text = value.ToUpper
            End Set
        End Property
        Public Property _Extraordinario As Boolean = False
        Public Property _CalendarioDetalleID As Long = 0
        Public Property _TipoParentesco As Type.Enumeracion.Parentesco.ParentescoGrupo = Type.Enumeracion.Parentesco.ParentescoGrupo.Familiares
#End Region
#Region "Propiedades"
        Private Property Documento As String
            Get
                Return Me.txtDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDoc.Text = value
            End Set
        End Property
        Private Property FechaDocumento As Long
            Get
                Return Me.dtpFechaDoc.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaDoc.ValueLong = value
            End Set
        End Property
        Private Property Observacion As String
            Get
                Return Me.txtObs.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObs.Text = value
            End Set
        End Property
#End Region
#Region "PropiedadesAutorizacion"
        Private Property ConfiguracionCodigo() As Integer = -1
        Private Property ConfiguracionDiaMaximo() As Integer
        Private Property ConfiguracionEnero() As Boolean
        Private Property ConfiguracionFebrero As Boolean
        Private Property ConfiguracionMarzo As Boolean
        Private Property ConfiguracionAbril As Boolean
        Private Property ConfiguracionMayo As Boolean
        Private Property ConfiguracionJunio As Boolean
        Private Property ConfiguracionJulio As Boolean
        Private Property ConfiguracionAgosto As Boolean
        Private Property ConfiguracionSetiembre As Boolean
        Private Property ConfiguracionOctubre As Boolean
        Private Property ConfiguracionNoviembre As Boolean
        Private Property ConfiguracionDiciembre As Boolean
        Private Property ConfiguracionEstado() As Integer = -1
#End Region
#Region "Listar_Autorizacion"
        Private Sub ListarMant_Autorizacion()

            objBssAutConf = New Bussines.Visita.AutorizacionConfiguracion
            objEntAutConf = New Entity.Visita.AutorizacionConfiguracion
            objEntAutConf.RegionID = Me._RegionID
            objEntAutConf.PenalID = Me._PenalID
            objEntAutConf = objBssAutConf.Listar(Me.ConfiguracionCodigo, Me._PenalID, Me._RegionID)

            With objEntAutConf
                Me.ConfiguracionCodigo = .Codigo
                Me.ConfiguracionDiaMaximo = .ConfiguracionDiaMaximo
                Me.ConfiguracionEnero = .ConfiguracionEnero
                Me.ConfiguracionFebrero = .ConfiguracionFebrero
                Me.ConfiguracionMarzo = .ConfiguracionMarzo
                Me.ConfiguracionAbril = .ConfiguracionAbril
                Me.ConfiguracionMayo = .ConfiguracionMayo
                Me.ConfiguracionJunio = .ConfiguracionJunio
                Me.ConfiguracionJulio = .ConfiguracionJulio
                Me.ConfiguracionAgosto = .ConfiguracionAgosto
                Me.ConfiguracionSetiembre = .ConfiguracionSetiembre
                Me.ConfiguracionOctubre = .ConfiguracionOctubre
                Me.ConfiguracionNoviembre = .ConfiguracionNoviembre
                Me.ConfiguracionDiciembre = .ConfiguracionDiciembre
                Me.ConfiguracionEstado = .EstadoID
            End With

        End Sub
#End Region
#Region "Validar Autorizacion"
        Private Function ValidarAutorizacionMesActivo(ByVal mesConsulta As Integer) As Boolean
            Dim value As Boolean = False
            Select Case mesConsulta
                Case 1
                    value = Me.ConfiguracionEnero
                Case 2
                    value = Me.ConfiguracionFebrero
                Case 3
                    value = Me.ConfiguracionMarzo
                Case 4
                    value = Me.ConfiguracionAbril
                Case 5
                    value = Me.ConfiguracionMayo
                Case 6
                    value = Me.ConfiguracionJunio
                Case 7
                    value = Me.ConfiguracionJulio
                Case 8
                    value = Me.ConfiguracionAgosto
                Case 9
                    value = Me.ConfiguracionSetiembre
                Case 10
                    value = Me.ConfiguracionOctubre
                Case 11
                    value = Me.ConfiguracionNoviembre
                Case 12
                    value = Me.ConfiguracionDiciembre
            End Select

            Return value
        End Function
#End Region
#Region "Propiedades_Temporal"
        Private Property VisitanteID() As Integer
            Get
                Return Me.UscLabelBusqueda1._Codigo
            End Get
            Set(ByVal value As Integer)
                Me.UscLabelBusqueda1._Codigo = value
            End Set
        End Property
        Private Property VisitanteApeNom() As String
            Get
                Return Me.UscLabelBusqueda1._Value
            End Get
            Set(ByVal value As String)
                Me.UscLabelBusqueda1._Value = value
            End Set
        End Property
        Private Property ParentescoID() As Integer
            Get
                Return Me.cbbParentesco.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbParentesco.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property Parentesco() As String
            Get
                Return Me.cbbParentesco.Text
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub ComboParentesco()

            Dim objBss As New Bussines.Globall.Parentesco
            Dim objEntCol As New Entity.Globall.ParentescoCol

            Select Case Me._TipoParentesco
                Case Type.Enumeracion.Parentesco.ParentescoGrupo.Abogado  'solo abogado
                    objEntCol = objBss.ComboTipo1SoloAbogado(False)
                Case Type.Enumeracion.Parentesco.ParentescoGrupo.Familiares  'familiares
                    objEntCol = objBss.ComboTipo1SinAbogado(False)
                Case Type.Enumeracion.Parentesco.ParentescoGrupo.FamiliaresAbogado
                    objEntCol = objBss.Combo(False)
            End Select

            With Me.cbbParentesco
                .DataSource = objEntCol
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            'interno
            If Me._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Ingrese el InternoID")
                Return value
            End If

            'documento
            If Me.Documento.Trim.Length < 4 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Ingrese el numero documento")
                Me.txtDoc.Focus()
                Return Value
            End If

            'fecha doc
            If Me.FechaDocumento < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Ingrese la fecha del documento")
                Me.dtpFechaDoc.Focus()
                Return value
            End If

            'objentcol
            If objEntColTemp.Count < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Ingrese uno o mas visitantes")
                Me.dgwGrilla.Focus()
                Return value
            End If

            Return True

        End Function
        Private Sub AOK()

            If Validar() = False Then
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar() <> Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If

            Dim blnOK As Boolean = False

            objBss = New Bussines.Visita.Autorizacion
            Dim objEnt As New Entity.Visita.Autorizacion

            With objEnt
                .Codigo = -1
                .InternoID = Me._InternoID
                .InternoApeNom = Me._InternoApeNom
                .Documento = Me.Documento
                .Fecha = Me.FechaDocumento
                .Observacion = Me.Observacion
                .EstadoID = 1 'activo

                If _Extraordinario = True Then
                    .TipoID = Type.Enumeracion.Visita.AutorizacionTipo.Extraordinario
                    .CalendarioDetalleID = Me._CalendarioDetalleID
                Else
                    .TipoID = Type.Enumeracion.Visita.AutorizacionTipo.Autorizado
                End If

            End With

            ' Validar si el interno es nuevo (no tiene ninguna visita), no valida la restriccion de meses
            If objBss.ValidarSumaVisitaPorInterno(objEnt) > 0 Then
                'validar si la fecha ingresada es segun programacion
                Dim xMes As Integer
                xMes = Legolas.Components.FechaHora.FechaMes(Legolas.LBusiness.Globall.DateTime.FechaServerLong) 'FechaDocumento)

                If ValidarAutorizacionMesActivo(xMes) = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                            "No es posible registrar las autorizaciones porque no está en el mes permitido")
                    Exit Sub
                End If
            Else
                ' no hace nada
            End If

            ' validacion de un maximo de 10 registros e.cu.cco.
            ' maximo 10 segun resolucion
            If objBss.ValidarSumaVisitanteAutorizacionActivos(objEnt) + objEntColTemp.Count > Me.ConfiguracionDiaMaximo Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Superó el limite de visitantes autorizados, el máximo es de " & Me.ConfiguracionDiaMaximo & " visitantes.")
                Exit Sub
            End If

            For Each obj As Entity.Visita.Autorizacion In objEntColTemp

                objEnt.VisitanteID = obj.VisitanteID
                objEnt.VisitanteApeNom = obj.VisitanteApeNom
                objEnt.ParentescoID = obj.ParentescoID

                'validar datos del visitante
                If objEnt.VisitanteID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha ingresado los datos del visitante")
                    Exit Sub
                End If

                objBss.Grabar(objEnt)
                blnOK = True
            Next

            If blnOK = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
#End Region
#Region "Form"
        Private Sub FRM_BuscarVisitante()

            Dim frm As New Visita.Visitante.frmBuscarPopup
            With frm
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID

                If .ShowDialog() = DialogResult.OK Then
                    Me.VisitanteID = ._GrillaVisitanteID
                    Me.VisitanteApeNom = ._GrillaVisitanteApellidosyNombres
                End If
            End With
        End Sub
        Private Sub FRM_Visitante()

            Dim frm As New Visita.Visitante.frmMantPopup
            With frm
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID

                If .ShowDialog = DialogResult.OK Then
                    Me.VisitanteID = ._Codigo
                    Me.VisitanteApeNom = ._ApellidosyNombres
                End If
            End With

        End Sub

#End Region
#Region "Temporal"
        Private Function TemporalValidar() As Boolean


            Dim value As Boolean = False

            'visitante 
            If Me.VisitanteID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Selecione visitante")
                Me.UscLabelBusqueda1.Focus()
                Return value
            End If

            'parentesco
            If Me.ParentescoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Selecione parentesco")
                Me.cbbParentesco.Focus()
                Return value
            End If

            'solo abogado
            If Me._TipoParentesco = Type.Enumeracion.Parentesco.ParentescoGrupo.Abogado Then
                If Me.objEntColTemp.Count > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "En la opcion abogado solo se puede registrar una por vez")
                    Return value
                End If
            End If

            Return True

        End Function
        Private Sub TemporalAdd()

            If TemporalValidar() = False Then
                Exit Sub
            End If

            Dim objEnt As New Entity.Visita.Autorizacion

            With objEnt
                .InternoID = Me._InternoID
                .VisitanteID = Me.VisitanteID
                .VisitanteApeNom = Me.VisitanteApeNom
                .ParentescoID = Me.ParentescoID
                .Parentesco = Me.Parentesco
            End With

            Dim blnGrabo As Boolean = False
            blnGrabo = TemporalGrabar(objEnt)

            If blnGrabo = True Then
                Me.VisitanteID = -1
                Me.VisitanteApeNom = ""
                Me.ParentescoID = -1
            End If

            TemporalListar()

        End Sub
        Private Sub TemporalListar()

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = Nothing
                .DataSource = objEntColTemp
            End With

        End Sub
        Private Function TemporalValidar(ByVal objEnt As Entity.Visita.Autorizacion) As Boolean

            Dim value As Boolean = False

            If objEntColTemp.Count > 0 Then
                For Each obj As Entity.Visita.Autorizacion In objEntColTemp
                    If obj.VisitanteID = objEnt.VisitanteID Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                            "El visitante que desea agregar ya existe en al lista actual")
                        Return value
                    End If

                Next
            End If

            'validar si el visitante ya esta relacionado con el interno
            Dim objBss As New Bussines.Visita.Autorizacion

            If _Extraordinario = True Then
                objEnt.TipoID = Type.Enumeracion.Visita.AutorizacionTipo.Extraordinario   'autorizado
                objEnt.CalendarioDetalleID = Me._CalendarioDetalleID
            Else
                objEnt.TipoID = Type.Enumeracion.Visita.AutorizacionTipo.Autorizado  'autorizado
            End If

            If objBss.ValidarVerificarVisitante(objEnt) = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "El visitante " & Me.VisitanteApeNom & " que desea agregar ya existe en la lista del interno registrados")
                Return value
            End If

            Return True

        End Function
        Private Function TemporalGrabar(ByVal objEnt As Entity.Visita.Autorizacion) As Boolean

            Dim value As Boolean = False

            If TemporalValidar(objEnt) = False Then
                Return value
            End If

            Dim objEntAdd As New Entity.Visita.Autorizacion

            With objEntAdd
                .Codigo = objEntColTemp.Count
                .VisitanteID = objEnt.VisitanteID
                .VisitanteApeNom = objEnt.VisitanteApeNom
                .ParentescoID = objEnt.ParentescoID
                .Parentesco = objEnt.Parentesco
            End With

            objEntColTemp.Add(objEntAdd)

            Return True

        End Function
        Private Sub TemporalEliminar()

            If Me.dgwGrilla.RowCount > 0 Then
                objEntColTemp.RemoveAt(Me.dgwGrilla.SelectedRows(0).Index)
                TemporalListar()
            End If

        End Sub
#Region "Otros"
        Private Sub ValoresxDefault()

            ComboParentesco()
            objEntColTemp = New List(Of Entity.Visita.Autorizacion)

        End Sub
#End Region
#End Region

        Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

            AOK()

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

            TemporalAdd()

        End Sub

        Private Sub frmAutorizacionAddPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()
            ListarMant_Autorizacion()
            Me.UscLabelBusqueda1._visible_Add = True

        End Sub

        Private Sub UscLabelBusqueda1__Buscar_Click() Handles UscLabelBusqueda1._Click_Buscar

            FRM_BuscarVisitante()

        End Sub

        Private Sub dgwGrilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            '/*iconos*/
            With Me.dgwGrilla
                If e.RowIndex = -1 Then Exit Sub
                If .RowCount > 0 Then
                    '/*icono ver*/
                    Select Case e.ColumnIndex
                        Case .Columns("col_eli").Index
                            TemporalEliminar()
                            TemporalListar()
                    End Select
                End If
            End With

        End Sub

        Private Sub UscLabelBusqueda1__Click_Agregar() Handles UscLabelBusqueda1._Click_Agregar

            FRM_Visitante()

        End Sub

        Private Sub UscLabelBusqueda1_Load(sender As Object, e As EventArgs) Handles UscLabelBusqueda1.Load

        End Sub
    End Class

End Namespace