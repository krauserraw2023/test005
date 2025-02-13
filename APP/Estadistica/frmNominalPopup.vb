Imports System.Windows.Forms
Namespace Estadistica
    Public Class frmNominalPopup
#Region "Propiedades"
        Public Property _RegionID() As Integer = -1
        Public Property _RegionNombre() As String
            Get
                Return Me.txtRegion.Text
            End Get
            Set(ByVal value As String)
                Me.txtRegion.Text = value
            End Set
        End Property
        Public Property _PenalID() As Integer = -1
        Public Property _PenalNombre() As String
            Get
                Return Me.txtPenal.Text
            End Get
            Set(ByVal value As String)
                Me.txtPenal.Text = value
            End Set
        End Property
        Public Property _PadinID() As Integer = -1
        Public Property _FechaFin As Long = 0
        Public Property _Correlativo() As Integer = 0
        Public Property _Anio As Integer = 0
        Public Property _Mes As Integer = 0
        Public Property _EstadoPadin() As Integer = -1
#End Region
#Region "Propiedades_Buscar"
        Private ReadOnly Property Nacionalidad() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rdbPerua.Checked = True Then
                    intValue = 1
                End If

                If Me.rdbExtran.Checked = True Then
                    intValue = 2
                End If

                Return intValue
            End Get
        End Property
#End Region
#Region "Accion"
        Private Function Validar() As Boolean
            Dim blnValue As Boolean = True

            'penal
            If Me._PenalID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Penal")
                blnValue = False
            End If

            Return blnValue
        End Function
        Private Sub AOK()

            If Validar() = False Then
                Exit Sub
            End If

            Dim frm As New APPReporte.Estadistica.frmReporte
            With frm
                ._pReporteTipo = APPReporte.Estadistica.frmReporte.EnmTipoReporte.rptReporte2
                ._PadinID = Me._PadinID
                ._PenalID = Me._PenalID
                ._Nacionalidad = Me.Nacionalidad
                ._Anio = Me._Anio
                ._Mes = Me._Mes
                ._FechaFin = Me._FechaFin
                ._Correlativo = Me._Correlativo
                ._EstadoPadin = Me._EstadoPadin
                .Show()
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
           
        End Sub
#End Region

        Private Sub frmPenalPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ValoresxDefault()

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            AOK()

        End Sub
    End Class
End Namespace

