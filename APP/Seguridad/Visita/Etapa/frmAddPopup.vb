Namespace Visita.Etapa
    Public Class frmAddPopup
        Private objBss As Bussines.Visita.InternoEtapa = Nothing
        Private objEntColTemp As List(Of Entity.Visita.InternoEtapa) = Nothing

#Region "Propiedades_Par"
        Public Property _RegionID As Integer
            Get
                Return Me.UscRegionPenalLabel1._RegionId
            End Get
            Set(ByVal value As Integer)
                Me.UscRegionPenalLabel1._RegionId = value
            End Set
        End Property
        Public Property _RegionNombre As String
            Get
                Return Me.UscRegionPenalLabel1._RegionNombre
            End Get
            Set(ByVal value As String)
                Me.UscRegionPenalLabel1._RegionNombre = value
            End Set
        End Property
        Public Property _PenalID As Integer
            Get
                Return Me.UscRegionPenalLabel1._Penalid
            End Get
            Set(ByVal value As Integer)
                Me.UscRegionPenalLabel1._Penalid = value
            End Set
        End Property
        Public Property _PenalNombre As String
            Get
                Return Me.UscRegionPenalLabel1._PenalNombre
            End Get
            Set(ByVal value As String)
                Me.UscRegionPenalLabel1._PenalNombre = value
            End Set
        End Property
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
#Region "Propiedades_Temporal"
        Private Property InternoID() As Integer
            Get
                Return Me.UscLabelBusqueda1._Codigo
            End Get
            Set(ByVal value As Integer)
                Me.UscLabelBusqueda1._Codigo = value
            End Set
        End Property
        Private Property InternoApePaterno() As String = ""            
        Private Property InternoApeMaterno() As String=""            
        Private Property InternoNombres() As String=""            
        Private Property InternoApeNom() As String
            Get
                Return Me.UscLabelBusqueda1._Value
            End Get
            Set(ByVal value As String)
                Me.UscLabelBusqueda1._Value = value
            End Set
        End Property

        Private Property EtapaID() As Integer
            Get
                Return Me.cbbEtapa.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbEtapa.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property Etapa() As String
            Get
                Return Me.cbbEtapa.Text
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub ComboEtapa()

            With Me.cbbEtapa
                .ComboTipo = Type.Combo.ComboTipo.VIS_Etapa
                .LoadUsc()
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
                Return value
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

            objBss = New Bussines.Visita.InternoEtapa
            Dim objEnt As New Entity.Visita.InternoEtapa

            With objEnt
                .Codigo = -1
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .FechaRegistro = Legolas.Configuration.Aplication.FechayHora.FechaLong
                .Documento = Me.Documento
                .DocumentoFecha = Me.FechaDocumento
                .Obs = Me.Observacion
                .Estado = 1 'activo                
            End With

            For Each obj As Entity.Visita.InternoEtapa In objEntColTemp

                objEnt.InternoID = obj.InternoID
                objEnt.InternoApePaterno = obj.InternoApePaterno
                objEnt.InternoApeMaterno = obj.InternoApeMaterno
                objEnt.InternoNombres = obj.InternoNombres

                objEnt.EtapaID = obj.EtapaID

                objBss.Grabar(objEnt)
                blnOK = True
            Next

            If blnOK = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
#End Region
#Region "Form"
        Private Sub FRM_BuscarInterno()

            Dim frm As New Visita.Interno.frmInternoPopup
            With frm
                ._RegionID = Me._RegionID
                ._RegionNombre = Me._RegionNombre
                ._PenalID = Me._PenalID
                ._PenalNombre = Me._PenalNombre
                ._FechaVisita = Legolas.Configuration.Aplication.FechayHora.FechaLong
                ._VisibleBotonHistorial = False

                If .ShowDialog() = DialogResult.OK Then

                    Me.InternoID = ._GrillaInternoID
                    Me.InternoApePaterno = ._GrillaApellidoPaterno
                    Me.InternoApeMaterno = ._GrillaApellidoMaterno
                    Me.InternoApeNom = ._GrillaApellidosyNombres
                    Me.InternoNombres = ._GrillaNombres
                End If

            End With
        End Sub
#End Region
#Region "Temporal"
        Private Function TemporalValidar() As Boolean

            Dim value As Boolean = False

            'visitante 
            If Me.InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Selecione interno")
                Me.UscLabelBusqueda1.Focus()
                Return value
            End If

            'parentesco
            If Me.EtapaID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Selecione etapa")
                Me.cbbEtapa.Focus()
                Return value
            End If

            Return True

        End Function
        Private Sub TemporalAdd()

            If TemporalValidar() = False Then
                Exit Sub
            End If

            Dim objEnt As New Entity.Visita.InternoEtapa

            With objEnt
                .InternoID = Me.InternoID
                .InternoApePaterno = Me.InternoApePaterno
                .InternoApeMaterno = Me.InternoApeMaterno
                .InternoNombres = Me.InternoNombres
                .InternoApeNom = Me.InternoApeNom
                .EtapaID = Me.EtapaID
                .EtapaNombre = Me.Etapa
            End With

            Dim blnGrabo As Boolean = False
            blnGrabo = TemporalGrabar(objEnt)

            If blnGrabo = True Then
                Me.InternoID = -1                
                Me.InternoApePaterno = ""
                Me.InternoApeMaterno = ""
                Me.InternoApeNom = ""
                Me.InternoNombres = ""
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
        Private Function TemporalValidar(ByVal objEnt As Entity.Visita.InternoEtapa) As Boolean

            Dim value As Boolean = False

            If objEntColTemp.Count > 0 Then
                For Each obj As Entity.Visita.InternoEtapa In objEntColTemp
                    If obj.InternoID = objEnt.InternoID Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                            "El interno que desea agregar ya existe en al lista actual")
                        Return value
                    End If

                Next
            End If

            Return True

        End Function
        Private Function TemporalGrabar(ByVal objEnt As Entity.Visita.InternoEtapa) As Boolean

            Dim value As Boolean = False

            If TemporalValidar(objEnt) = False Then
                Return value
            End If

            Dim objEntAdd As New Entity.Visita.InternoEtapa

            With objEntAdd
                .Codigo = objEntColTemp.Count
                .InternoID = objEnt.InternoID
                .InternoApePaterno = objEnt.InternoApePaterno
                .InternoApeMaterno = objEnt.InternoApeMaterno
                .InternoNombres = objEnt.InternoNombres
                .InternoApeNom = objEnt.InternoApeNom
                .EtapaID = objEnt.EtapaID
                .EtapaNombre = objEnt.EtapaNombre
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

            ComboEtapa()
            objEntColTemp = New List(Of Entity.Visita.InternoEtapa)

            Me.UscLabelBusqueda1._Visible_Add = False

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
            Me.UscLabelBusqueda1._Visible_Add = False

        End Sub

        Private Sub UscLabelBusqueda1__Buscar_Click() Handles UscLabelBusqueda1._Click_Buscar

            FRM_BuscarInterno()

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

    End Class

End Namespace