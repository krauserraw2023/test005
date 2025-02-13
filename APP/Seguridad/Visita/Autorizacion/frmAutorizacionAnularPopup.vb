Namespace Visita.Autorizacion
    Public Class frmAutorizacionAnularPopup
        Private objBss As Bussines.Visita.Autorizacion = Nothing
        Private objEntCol As Entity.Visita.AutorizacionCol = Nothing

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
        Private Sub Listar()

            objBss = New Bussines.Visita.Autorizacion
            Dim objEntFiltro As New Entity.Visita.Autorizacion

            With objEntFiltro
                .InternoID = Me._InternoID

                If _Extraordinario = True Then
                    .TipoID = Type.Enumeracion.Visita.AutorizacionTipo.Extraordinario
                    .CalendarioDetalleID = Me._CalendarioDetalleID
                Else
                    .TipoID = Type.Enumeracion.Visita.AutorizacionTipo.Autorizado
                End If

                .EstadoID = 1 'activos
            End With

            objEntCol = objBss.Listar(objEntFiltro)

            With Me.dgwGrilla
                .AutoGenerateColumns = False
                .DataSource = objEntCol

                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False

                .DataSource = objEntCol
            End With

            If Me.dgwGrilla.RowCount < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information( _
                    "No se encuentra ningun registro autorizado, activo")
                Me.Close()
            End If

        End Sub
#Region "Accion"
        Private Function ValidarCheck() As Boolean

            Dim intCount As Integer = 0

            For Each obj As Entity.Visita.Autorizacion In objEntCol
                If obj.SeleccionarCheck = True Then
                    intCount = +1
                End If
            Next

            Return intCount > 0

        End Function
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
                Return value
            End If

            'fecha doc
            If Me.FechaDocumento < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Ingrese la fecha del documento")
                Me.dtpFechaDoc.Focus()
                Return value
            End If

            'validar check
            If ValidarCheck() = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Seleccione los visitantes")
                Me.dgwGrilla.Focus()
                Return value
            End If

            Return True

        End Function
        Private Sub AOK()

            If Validar() = False Then
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question(
                "Desea realizar la operacion") <> Windows.Forms.DialogResult.Yes Then

                Exit Sub
            End If

            Dim blnOK As Boolean = False

            objBss = New Bussines.Visita.Autorizacion
            Dim objEnt As New Entity.Visita.Autorizacion

            With objEnt
                '.Codigo = -1
                .InternoID = Me._InternoID
                .InternoApeNom = Me._InternoApeNom
                .Documento = Me.Documento
                .Fecha = Me.FechaDocumento
                .Observacion = Me.Observacion
                .EstadoID = 1 'activo
                .TipoID = Type.Enumeracion.Visita.AutorizacionTipo.Anulacion   'anulacion
            End With

            Dim intCodigo As Integer = -1
            For Each obj As Entity.Visita.Autorizacion In objEntCol

                If obj.SeleccionarCheck = True Then

                    intCodigo = obj.Codigo
                    objEnt.VisitanteID = obj.VisitanteID
                    objEnt.VisitanteApeNom = obj.VisitanteApeNom
                    objEnt.ParentescoID = obj.ParentescoID

                    'validar datos del visitante
                    If objEnt.VisitanteID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha ingresado los datos del visitante")
                        Exit Sub
                    End If

                    objBss.GrabarEstadoInactivo(intCodigo)
                    objBss.GrabarAnulados(objEnt)

                    blnOK = True
                End If
               
            Next

            If blnOK = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

        End Sub
#End Region
        Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

            AOK()

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub


        Private Sub frmAutorizacionAddPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub dgwGrilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub frmAutorizacionAnularPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Listar()

        End Sub
    End Class

End Namespace