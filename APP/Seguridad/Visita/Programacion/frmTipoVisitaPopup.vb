Namespace Visita.Programacion

    Public Class frmTipoVisitaPopup
#Region "Propiedades_Parametricas"
        Public Property _RegionID() As Short = -1
        Public Property _PenalID() As Short = -1
#End Region
#Region "Propiedades_Publicas"
        Public ReadOnly Property _TipoVisitaID() As Integer
            Get
                Return Me.GrillaCodigo
            End Get
        End Property
        Public ReadOnly Property _TipoVisitaNombre() As String
            Get
                Return Me.GrillaNombre
            End Get
        End Property
        Public ReadOnly Property _TipoRegimenID() As Short
            Get
                Return Me.RegimenTipoID
            End Get
        End Property
        Public ReadOnly Property _RegimenVisitaNombre() As String
            Get
                Return Me.cbbTipoVisita.Text.ToUpper
            End Get
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim Value As Integer = -1
                Try
                    With Me.dgwGrilla
                        Value = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return Value
            End Get
        End Property
        Private ReadOnly Property GrillaNombre() As String
            Get
                Dim Value As String = ""
                Try
                    With Me.dgwGrilla
                        Value = .SelectedRows(0).Cells("col_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return Value
            End Get
        End Property
#End Region
#Region "Propiedades"
        Private Property RegimenTipoID() As Short
            Get
                Return Me.cbbTipoVisita.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbTipoVisita.SelectedValue = value
            End Set
        End Property
        Private Property Config_RegimenTipoID As Short = -1
        Private Property Config_RegimenTipo As String = ""
#End Region
#Region "Combo"
        Private Sub ComboTipoVisita()

            Dim intValorxDefecto_RegimenTipo As Short = -1
            Dim blnComboEnabled As Boolean = False

            Select Case Me.Config_RegimenTipoID
                Case 1 'ordinario
                    blnComboEnabled = False
                    intValorxDefecto_RegimenTipo = 1
                Case 2 'regimen cerrado
                    blnComboEnabled = False
                    intValorxDefecto_RegimenTipo = 2
                Case 3 'regimen ordinario/regimen cerrado especial
                    blnComboEnabled = True
                    intValorxDefecto_RegimenTipo = 2
            End Select

            With Me.cbbTipoVisita
                .Parametro1 = 1 'tipo 1 activado
                .Parametro2 = 1 'tipo 2, activado
                ._Todos = False
                ._LoadUsc(Type.Combo.ComboTipo.VIS_RegimenVisita)
            End With

            Me.RegimenTipoID = intValorxDefecto_RegimenTipo 'reg. especial
            Me.grbRegimenVisita.Enabled = blnComboEnabled

        End Sub
#End Region
#Region "Listar"
        Private Sub Buscar()

            Dim objBss As New Bussines.Visita.Tipo
            Dim objEntCol As New Entity.Visita.Tipos

            Select Case Me.RegimenTipoID
                Case 1 'ordinario
                    objEntCol = objBss.ListarRegimenOrdinario
                Case 2 'especial
                    objEntCol = objBss.ListarRegimenEspecial
            End Select

            With Me.dgwGrilla
                .AutoGenerateColumns = False
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor

                .DataSource = objEntCol
            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub AOK()

            If Me._TipoVisitaID > 0 Then
                Me.DialogResult = vbOK
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            RegimenTipo_Permisos()
            ComboTipoVisita()

        End Sub

#End Region
#Region "Permisos/Accesos"
        Private Sub RegimenTipo_Permisos()

            Dim objBss As New Bussines.Visita.Config
            Dim objEnt As New Entity.Visita.Config

            Dim objEntFiltro As New Entity.Visita.Config

            With objEntFiltro
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .Estado = 1 'alta
            End With

            objEnt = objBss.ListarConfigActual(objEntFiltro)

            If Not objEnt Is Nothing Then
                With objEnt
                    Me.Config_RegimenTipoID = .RegimenTipoID
                    Me.Config_RegimenTipo = .RegimenTipoNombre
                End With
            Else
                Me.Config_RegimenTipoID = 1
                Me.Config_RegimenTipo = "Regimen Ordinario"
            End If

        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            AOK()
        End Sub

        Private Sub frmTipoVisitaPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmTipoVisitaPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Buscar()

        End Sub

        Private Sub cbbTipoVisita__SelectedIndexChanged() Handles cbbTipoVisita._SelectedIndexChanged

            Buscar()

        End Sub
    End Class
End Namespace