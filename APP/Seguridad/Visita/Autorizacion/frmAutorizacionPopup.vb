Namespace Visita.Autorizacion
    Public Class frmAutorizacionPopup
        Private objBss As Bussines.Visita.Autorizacion = Nothing
        Private objEnt As Entity.Visita.Autorizacion = Nothing
#Region "Propiedades_Par"
        Public Property _Codigo As Integer = -1
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
#End Region
#Region "Propiedades"
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
        Private Property Documento() As String
            Get
                Return Me.txtDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDoc.Text = value
            End Set
        End Property
        Private Property FechaDocumento() As Long
            Get
                Return Me.dtpFechaDoc.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaDoc.ValueLong = value
            End Set
        End Property
        Private Property Observacion() As String
            Get
                Return Me.txtObs.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObs.Text = value
            End Set
        End Property
        Private Property EstadoID() As Integer = -1
        Private Property TipoID() As Integer = -1
#End Region
#Region "Combo"
        Private Sub ComboParentesco(ParentescoTipoID As Short)

            Dim objBss As New Bussines.Globall.Parentesco
            Dim objEntCol As New Entity.Globall.ParentescoCol

            Select Case ParentescoTipoID
                Case 18 'solo abogado
                    objEntCol = objBss.ComboTipo1SoloAbogado(False)
                Case Else 'familiares
                    objEntCol = objBss.ComboTipo1SinAbogado(False)
            End Select

            With Me.cbbParentesco
                .DataSource = objEntCol
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub Listar()

            If Me._Codigo < 1 Then
                Exit Sub
            End If

            objEnt = New Entity.Visita.Autorizacion
            objBss = New Bussines.Visita.Autorizacion

            objEnt = objBss.Listar(Me._Codigo)

            With objEnt

                Me.VisitanteID = .VisitanteID
                Me.VisitanteApeNom = .VisitanteApellidosyNombres

                ComboParentesco(.ParentescoID)

                Me.ParentescoID = .ParentescoID
                Me.Documento = .Documento
                Me.FechaDocumento = .Fecha
                Me.Observacion = .Observacion
                Me.TipoID = .TipoID
                Me.EstadoID = .EstadoID
            End With



        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

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

            'estado inactivo
            If Me.EstadoID = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "No se puede modificar el registro, porque se encuentra en un estado Inactivo")                
                Return value
            End If

            'validar el id del visitante
            If Me.VisitanteID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "No ha ingresado los datos del visitante")
                Return value
            End If
            value = True
            Return value

        End Function
        Private Sub AOK()

            If Validar() = False Then
                Exit Sub
            End If

            Dim value As Integer = -1
            objBss = New Bussines.Visita.Autorizacion

            Dim objEnt As New Entity.Visita.Autorizacion

            With objEnt
                .Codigo = Me._Codigo
                .InternoID = Me._InternoID
                .InternoApeNom = Me._InternoApeNom
                .VisitanteID = Me.VisitanteID
                .VisitanteApeNom = Me.VisitanteApeNom
                .ParentescoID = Me.ParentescoID
                .TipoID = Me.TipoID
                .Documento = Me.Documento
                .Fecha = Me.FechaDocumento
                .Observacion = Me.Observacion
                .EstadoID = Me.EstadoID
            End With

            value = objBss.Grabar(objEnt)

            If value > 0 Then
                Me.DialogResult = DialogResult.OK
            End If

        End Sub
#End Region
#Region "Form"
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
#End Region
#Region "Otros"

        Private Sub ValoresxDefault()

            ComboParentesco(-1)
            Me.UscLabelBusqueda1._visible_Add = True

        End Sub

#End Region
        Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

            AOK()

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub UscLabelBusqueda1__Buscar_Click() Handles UscLabelBusqueda1._Click_Buscar

            FRM_BuscarVisitante()

        End Sub

        Private Sub UscLabelBusqueda1__Click_Agregar() Handles UscLabelBusqueda1._Click_Agregar

            FRM_Visitante()

        End Sub

        Private Sub UscLabelBusqueda1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UscLabelBusqueda1.Load

        End Sub

        Private Sub frmAutorizacionPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmAutorizacionPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Listar()

        End Sub
    End Class

End Namespace