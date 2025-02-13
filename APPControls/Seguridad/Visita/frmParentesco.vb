Namespace Visita
    Public Class frmParentesco
#Region "Propiedades_Par"
        Private objTipoParentesco = Type.Enumeracion.Parentesco.TipoVisita.Familiares
        Public Property _TipoParentesco() As Type.Enumeracion.Parentesco.TipoVisita
            Get
                Return objTipoParentesco
            End Get
            Set(ByVal value As Type.Enumeracion.Parentesco.TipoVisita)
                objTipoParentesco = value
            End Set
        End Property
#End Region
#Region "Propiedades_Return"
        Public Property _InternoNombre() As String
            Get
                Return Me.InternoNombre
            End Get
            Set(ByVal value As String)
                Me.InternoNombre = value
            End Set
        End Property
#End Region
#Region "Propiedades"
        Private Property InternoNombre() As String
            Get
                Return Me.lbl_interno.Text
            End Get
            Set(ByVal value As String)
                Me.lbl_interno.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Public ReadOnly Property _GrillaParentescoID() As Integer
            Get
                Dim Value As Integer = -1
                Try
                    Value = Me.dgwGrilla.SelectedRows(0).Cells(0).Value.ToString
                Catch ex As Exception

                End Try
                Return Value
            End Get
        End Property
        Public ReadOnly Property _GrillaParentescoNombre() As String
            Get
                Dim value As String = ""
                Try
                    value = Me.dgwGrilla.SelectedRows(0).Cells(1).Value.ToString
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Listar"
        Public Sub Listar()

            Dim objEntCol As New Entity.Globall.ParentescoCol
            Dim objBss As New Bussines.Globall.Parentesco
            Dim objEntFiltro As New Entity.Globall.Parentesco

            Dim intOpcion1 As Integer = -1
            Dim intOpcion2 As Integer = -1
            Dim blnFiltrar As Boolean = False

            Select Case Me._TipoParentesco
                Case Type.Enumeracion.Parentesco.TipoVisita.Familiares
                    intOpcion1 = 1

                Case Type.Enumeracion.Parentesco.TipoVisita.Administrativa

                    intOpcion2 = 1
                    Me.col_par_nom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Me.col_grd_nom.Visible = False

                Case Type.Enumeracion.Parentesco.TipoVisita.MenoresEdad
                    intOpcion1 = 1
                    blnFiltrar = True
            End Select

            With objEntFiltro
                .Opcion1 = intOpcion1
                .Opcion2 = intOpcion2
            End With

            objEntCol = objBss.Listar(objEntFiltro)

            If blnFiltrar = True Then
                objEntCol = objBss.ListarFiltroMenoresEdad(objEntCol)
            End If

            With dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AutoGenerateColumns = False
                .DataSource = objEntCol
            End With

        End Sub
#End Region
#Region "Propiedades_Usc"
        Public Property _VisibleGrado() As Boolean
            Get
                Return Me.col_grd_nom.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.col_grd_nom.Visible = value
            End Set
        End Property
        Public Property _VisibleColumnaGrado As Boolean
            Get
                Return Me.col_grd_nom.Visible
            End Get
            Set(value As Boolean)
                Me.col_grd_nom.Visible = value
            End Set
        End Property

#End Region
#Region "Accion"
        Public Sub AOK()

            If Me._GrillaParentescoID > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefaut()

            Select Case Me._TipoParentesco
                Case Type.Enumeracion.Parentesco.TipoVisita.Familiares
                    Me.Text = "Selecione el parentesco"
                Case Type.Enumeracion.Parentesco.TipoVisita.Administrativa
                    Me.lbl_interno.Visible = False
                    Me.Text = "Selecione el tipo de visita"
            End Select
        End Sub
#End Region
        Private Sub frmVisitaParentezco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ValoresxDefaut()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AOK()
        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
            "Ha cancelado el registro de visita")
            Me.Close()

        End Sub

        Private Sub MyDatagridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgwGrilla.KeyDown

            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                AOK()
            End If

        End Sub

        Private Sub MyDatagridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick
            If e.RowIndex >= 0 Then
                AOK()
            End If
        End Sub

        Private Sub frmParentesco_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Listar()
            Me.dgwGrilla.Focus()

        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

    End Class
End Namespace
