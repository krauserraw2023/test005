Imports System.Windows.Forms
Namespace Registro.Reniec
    Public Class frmReniecLineaV2
#Region "Propiedades_Publicas"
        Public Property _VisibleBotonAtras As Boolean = False
        Public Property _TipoValidacion As Integer = -1
        Public Property _InternoID As Integer = -1
        Public Property _NumeroDNI As String = ""
        Public Property _ApellidoPaterno As String = ""
        Public Property _ApellidoMaterno As String = ""
        Public Property _Nombres As String = ""
        Public Property _NombreAsociadoValID As Integer = -1
        Private m_Comparacion As Integer = -1
        Public Property _Comparacion As Integer
            Get
                Return m_Comparacion
            End Get
            Set(value As Integer)
                m_Comparacion = value
                If _Comparacion = 1 Then
                    UsrInternoReniecLineaV31._NumeroDni = Me._NumeroDNI
                    UsrInternoReniecLineaV31._TipoComparacion = Me._Comparacion
                    UsrInternoReniecLineaV31.Visible = True
                Else
                    UscListaReniec31.Visible = True
                End If
            End Set
        End Property
#End Region
#Region "Otros"

        Private Sub AGrabar()
            If UsrInternoReniecLineaV31.Visible = True Then
                If UsrInternoReniecLineaV31.Grabar() = True Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            ElseIf UscListaReniec31.Visible = True Then
                Me.Cursor = Cursors.WaitCursor
                UscListaReniec31.CargarNombrePrincipal()
                Me.Cursor = Cursors.Default
            End If
        End Sub
#End Region

        Private Sub UscListaReniec1__CerrarFormulario()
            Me.Close()
        End Sub


        Public Async Function _Load() As Threading.Tasks.Task(Of Boolean)

            Dim blnValor As Boolean = False

            If Me._Comparacion > 1 Then
                UscListaReniec31.Visible = True
                UsrInternoReniecLineaV31.Visible = False
                btnRegresar.Visible = False
                lblLeyenda.Visible = True

                UscListaReniec31._InternoID = Me._InternoID
                UscListaReniec31._ApellidoPaterno = Me._ApellidoPaterno
                UscListaReniec31._ApellidoMaterno = Me._ApellidoMaterno
                UscListaReniec31._Nombres = Me._Nombres
                UscListaReniec31._Comparacion = Me._Comparacion
                UsrInternoReniecLineaV31._NombreAsociadoValID = Me._NombreAsociadoValID
                ' blnValor = UscListaReniec31._Load()
                blnValor = Await UscListaReniec31._LoadAsync()
            Else
                UscListaReniec31.Visible = False
                UsrInternoReniecLineaV31.Visible = True
                btnRegresar.Visible = False
                lblLeyenda.Visible = False
                UsrInternoReniecLineaV31._TipoComparacion = Me._Comparacion
                UsrInternoReniecLineaV31._InternoID = Me._InternoID
                UsrInternoReniecLineaV31._NumeroDni = Me._NumeroDNI
                blnValor = Await UsrInternoReniecLineaV31._Load
            End If
            Return blnValor

        End Function

        Private Sub btnRegresar_Click(sender As System.Object, e As System.EventArgs) Handles btnRegresar.Click
            Me.UscListaReniec31.Visible = True
            Me.UsrInternoReniecLineaV31.Visible = False
            Me.UsrInternoReniecLineaV31._NumeroDniAux = UscListaReniec31._GrillaNumeroDNI
            Me.UsrInternoReniecLineaV31.RegresarFormulario()
            Me.btnRegresar.Visible = False
            Me.lblLeyenda.Visible = True
        End Sub

        Private Sub btnOk2_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
            AGrabar()
        End Sub

        Private Sub UscListaReniec31__Click_Cancelar()
            Me.Close()
        End Sub

       

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Sub

        Private Sub frmReniecLineaV2_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            'Me.Refresh()
            'Me.Cursor = Cursors.WaitCursor
            'Dim intValor As Boolean = _Load()
            'Me.Cursor = Cursors.Default
            'If intValor = False Then
            '    Me.Close()
            'End If
        End Sub


        Private Async Sub UscListaReniec31__DoubleClick_EnviarDNI(NumeroDNI As System.String, Comparacion As System.Int32) Handles UscListaReniec31._DoubleClick_EnviarDNI
            UsrInternoReniecLineaV31._NumeroDni = NumeroDNI
            UsrInternoReniecLineaV31._TipoComparacion = Comparacion
            Dim Valida As Boolean = Await UsrInternoReniecLineaV31._Load()
            If Valida = True Then
                UsrInternoReniecLineaV31.Visible = True
                UscListaReniec31.Visible = False
                btnRegresar.Visible = True
                lblLeyenda.Visible = False
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation(UsrInternoReniecLineaV31.strMensaje, UscListaReniec31.strCabecera)
            End If
        End Sub

        Private Sub frmReniecLineaV2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace