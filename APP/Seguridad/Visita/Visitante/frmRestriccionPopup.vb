Namespace Visita.Visitante
    Public Class frmRestriccionPopup
        Private objBss As Bussines.Visita.VisitanteRestriccion = Nothing
        Private objEnt As Entity.Visita.VisitanteRestriccion = Nothing
#Region "Propiedades_Parametricas"        
        Public Property _VisitanteID() As Integer = -1
        Public Property _VisitanteApeNom As String = ""
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1          
#End Region
#Region "Propiedades"        
        Public Property Codigo() As Integer=-1            
        Private Property TipoID() As Integer
            Get
                Return Me.cbbTipo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipo.SelectedValue = value
            End Set
        End Property
        Private Property InternoID() As Integer
            Get
                Return Me.UscLabelBusqueda1._Codigo
            End Get
            Set(value As Integer)
                Me.UscLabelBusqueda1._Codigo = value
            End Set
        End Property
        Private Property InternoApeNom() As String
            Get
                Dim value As String = ""
                If Me.InternoID > 0 Then
                    value = Me.UscLabelBusqueda1._Value
                End If
                Return value
            End Get
            Set(value As String)
                Me.UscLabelBusqueda1._Value = value
            End Set
        End Property
        Private Property Documento() As String
            Get
                Return Me.txtDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDoc.Text = value
            End Set
        End Property
        Private Property Fecha() As Long
            Get
                Return Me.dtpFecha.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFecha.ValueLong = value
            End Set
        End Property
        Private Property FechaInicio() As Long
            Get
                Return Me.dtpFechaIni.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaIni.ValueLong = value
            End Set
        End Property
        Private Property FechaFin() As Long
            Get
                Return Me.dtpFechaFin.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaFin.ValueLong = value
            End Set
        End Property
        Private Property FechaFinIndeterminado() As Boolean
            Get
                Return Me.chkIndeterminado.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkIndeterminado.Checked = value
            End Set
        End Property
        Private Property Estado() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.chkEstado.Checked = True Then
                    intValue = 1
                Else
                    intValue = 0
                End If
                Return intValue
            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case 0
                        Me.chkEstado.Checked = False
                    Case 1
                        Me.chkEstado.Checked = True
                End Select
            End Set
        End Property
        Private Property Obs() As String
            Get
                Return Me.txtObs.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObs.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Otros"
        Public Property _VisibleGrabar() As Boolean = False
#End Region
#Region "Combo"
        Private Sub Combo()

            With Me.cbbTipo
                .ComboTipo = Type.Combo.ComboTipo.VIS_RetriccionTipo
                .LoadUsc()
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub ListarData()

            If Me.Codigo < 1 Then
                Exit Sub
            End If

            objEnt = New Entity.Visita.VisitanteRestriccion
            objBss = New Bussines.Visita.VisitanteRestriccion

            objEnt = objBss.Listar(Me.Codigo)
            With objEnt
                Me.TipoID = .RestriccionTipoID
                Me.InternoID = .InternoID
                Me.InternoApeNom = .InternoApeNom
                Me.Documento = .Documento
                Me.Fecha = .Fecha
                Me.FechaInicio = .FechaInicio
                Me.FechaFin = .FechaFin
                Me.FechaFinIndeterminado = .FechaFinIndeterminado
                HabilitarIndeterminado() 'funcion
                Me.Estado = .EstadoID
                Me.Obs = .Observacion
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            'visitante 
            If Me._VisitanteID < 1 Then
                Return value
            End If

            'tipo sancion
            If Me.TipoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Seleccione el tipo de sancion")
                Me.cbbTipo.Focus()
                Return value
            End If

            'si la restri es 1, porhibicion de visita al interno
            If Me.TipoID = 1 Then
                If Me.InternoID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Seleccione el interno a restringir para el visitante seleccionado")
                    Me.UscLabelBusqueda1.Focus()
                    Return value
                End If
            End If

            'documento
            If Me.Documento.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Ingrese el numero de documento")
                Me.txtDoc.Focus()
                Return value
            End If

            'fecha 
            If Me.Fecha < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Ingrese la fecha de restriccion")
                Me.dtpFecha.Focus()
                Return value
            End If

            'fecha ini
            If Me.FechaInicio < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Ingrese la fecha de inicio")
                Me.dtpFechaIni.Focus()
                Return value
            End If

            'fecha ini
            If Me.FechaFinIndeterminado = False Then
                If Me.FechaFin < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "Ingrese la fecha fin")
                    Me.dtpFechaFin.Focus()
                    Return value
                End If
            End If

            'fecha fin < fecha ini
            If Me.FechaFinIndeterminado = False Then
                If Me.FechaFin < Me.FechaInicio Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "La fecha final, no puede ser menor a la fecha de inicio")
                    Me.dtpFechaFin.Focus()
                    Return value
                End If
            End If

            value = True
            Return value
        End Function
        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            If Me.Codigo > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Los datos ingresados no se pueden modificar")
                Exit Sub
            End If

            objBss = New Bussines.Visita.VisitanteRestriccion
            Dim objEnt As New Entity.Visita.VisitanteRestriccion

            With objEnt
                .Codigo = Me.Codigo
                .VisitanteID = Me._VisitanteID
                .VisitanteApeNom = Me._VisitanteApeNom
                .RestriccionTipoID = Me.TipoID
                .InternoID = Me.InternoID
                .InternoApeNom = Me.InternoApeNom
                .Documento = Me.Documento
                .Fecha = Me.Fecha
                .FechaInicio = Me.FechaInicio
                .FechaFin = Me.FechaFin
                .FechaFinIndeterminado = Me.FechaFinIndeterminado
                .EstadoID = Me.Estado
                .Observacion = Me.Obs
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            Me.Codigo = objBss.Grabar(objEnt)

            If Me.Codigo > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Sub
#End Region
#Region "Form"
        Private Sub FRM_BuscarInterno()

            Dim frm As New Visita.Interno.frmInternoPopup
            With frm
                ._RegionID = Me._RegionID                
                ._PenalID = Me._PenalID
                ._VisibleRegionPenal = False
                ._FechaVisita = Legolas.Configuration.Aplication.FechayHora.FechaLong

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.InternoID = ._GrillaInternoID
                    Me.InternoApeNom = ._GrillaApellidosyNombres
                End If

            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            Me.btnOk.Visible = Me._VisibleGrabar
            Combo()
            Me.UscLabelBusqueda1.Enabled = False

        End Sub
        Private Sub HabilitarIndeterminado()

            If Me.FechaFinIndeterminado = True Then
                Me.FechaFin = 0
            End If

            Me.dtpFechaFin.Enabled = Not Me.FechaFinIndeterminado

        End Sub
        Private Sub HabilitarINterno()

            Me.UscLabelBusqueda1.Enabled = False

            Select Case Me.TipoID
                Case 1 'prohibicion de visita al interno
                    Me.UscLabelBusqueda1.Enabled = True
                    Me.InternoApeNom = "[Seleccione Interno]".ToUpper
                Case Else
                    Me.InternoID = -1
                    Me.InternoApeNom = ""
                    Me.UscLabelBusqueda1.Enabled = False
            End Select

        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AGrabar()

        End Sub


        Private Sub frmSancionPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmSancionPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ListarData()

        End Sub

        Private Sub chkIndeterminado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkIndeterminado.Click

            HabilitarIndeterminado()

        End Sub

        Private Sub UscLabelBusqueda1__Click_Buscar() Handles UscLabelBusqueda1._Click_Buscar

            FRM_BuscarInterno()

        End Sub

        Private Sub UscLabelBusqueda1_Load(sender As System.Object, e As System.EventArgs) Handles UscLabelBusqueda1.Load

        End Sub

        Private Sub cbbTipo__SelectedIndexChanged() Handles cbbTipo._SelectedIndexChanged

            If Me.TipoID > 0 Then
                HabilitarINterno()
            End If

        End Sub

        Private Sub cbbTipo_Load(sender As System.Object, e As System.EventArgs) Handles cbbTipo.Load

        End Sub
    End Class
End Namespace

