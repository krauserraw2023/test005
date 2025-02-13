Imports Ionic.Zip
Imports System.IO
Imports Type.Enumeracion.Licencia

Namespace Registro.Odontograma
    Public Class frmOdontogramaPopup
#Region "Propiedades"
        Private Property codigo As Integer = -1
        Private Property pathFileJson As String = ""
        Private Property Observaciones() As String
            Get
                Return txtObs.Text
            End Get
            Set(value As String)
                txtObs.Text = value
            End Set
        End Property
        Private Property Especificaciones() As String
            Get
                Return txtEspecific.Text
            End Get
            Set(value As String)
                txtEspecific.Text = value
            End Set
        End Property
#End Region
#Region "propiedades publicas"
        Public Property _archivoByteJson As Byte() = Nothing
        Public ReadOnly Property _getObservacion As String
            Get
                Return Me.Observaciones
            End Get
        End Property
        Public ReadOnly Property _getEspecificacion As String
            Get
                Return Me.Especificaciones
            End Get
        End Property

#End Region
        Public Sub New(codigo As Integer, pathFileJson As String, obs As String, espe As String)

            ' Esta llamada es exigida por el diseñador.
            InitializeComponent()
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            Me.pathFileJson = pathFileJson
            Me.codigo = codigo

            ' Me.UscOdontograma1._uscLoad()
        End Sub
#Region "Listar"
        Private Sub listarAuditoria()

            Me.UscAuditUser1.LoadAudit(Me.codigo, Type.Enumeracion.Auditoria.EnumTipTabla.int_mov_interno_odontograma)

        End Sub
#End Region
#Region "Otros"

        Private Sub PermisosUsuario()
            Me.pnlGrabarDatos.Visible = Me._FormEscritura
        End Sub
#End Region
        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            btnSalir_Click(Nothing, Nothing)
        End Sub

        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click

            ' Me._archivoByteJson = Me.UscOdontograma1._uscGrabar()

            If Me._archivoByteJson IsNot Nothing AndAlso _archivoByteJson.Length > 3 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End Sub

        Private Sub frmOdontogramaPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            PermisosUsuario()
            listarAuditoria()

            'Me.UscOdontograma1._uscLoad()
            'If pathFileJson.Length > 5 Then
            '    Me.UscOdontograma1._leerJson(pathFileJson, False)
            'End If

        End Sub

    End Class
End Namespace