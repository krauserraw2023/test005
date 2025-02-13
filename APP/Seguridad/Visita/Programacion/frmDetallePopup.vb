Namespace Visita.Programacion
    Public Class frmDetallePopup
#Region "Propiedades_Publicas"
        Public Property _Codigo() As Integer = -1
        Public Property _Calendario() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _RegionNombre As String = ""
        Public Property _PenalID() As Integer = -1
        Public Property _PenalNombre As String = ""
        Public Property _RegimenVisitaID() As Integer = -1
        Public Property _TipoVisitaID() As Integer = -1
#End Region
#Region "Listar"
        Private Sub LoadUsc()

            With Me.UscProgramacion21                
                ._Codigo = Me._Codigo
                ._CalendarioID = Me._Calendario
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._RegimenVisitaID = Me._RegimenVisitaID
                ._TipoVisitaID = Me._TipoVisitaID
                ._LoadUsc()
            End With

        End Sub

        Private Sub ListarMant()

            If Me._Codigo < 1 Then
                Exit Sub
            End If

            With Me.UscProgramacion21
                ._Codigo = Me._Codigo
                ._CalendarioID = Me._Calendario
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._RegimenVisitaID = Me._RegimenVisitaID
                ._TipoVisitaID = Me._TipoVisitaID
                ._Listar()                
            End With

        End Sub
#End Region
#Region "Validar"
        Private Function ValidarCalendarioDetUsado(Optional VerMensaje As Boolean = True) As Boolean

            Dim value As Boolean = False

            'si la programacuion extraordinaria ya se uso, ya no se puede agregar mas datos
            Dim objEntFiltro As New Entity.Visita.Programacion.CalendarioDetalle
            With objEntFiltro
                .CalendarioDetalleID = Me.UscProgramacion21._Codigo
            End With

            Dim objBssCalendarioDet As New Bussines.Visita.Programacion.CalendarioDetalle
            value = objBssCalendarioDet._ValidarMovimiento(objEntFiltro)

            If value = False Then

                If VerMensaje = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El registro actual no permite modificar los datos, debido que ya se encuentra en uso en el modulo de visita.")
                End If

            End If

            Return Not (value)

        End Function
#End Region
#Region "Accion"
        Private Function AOK(Optional CerrarForm As Boolean = True) As Boolean

            Dim value As Boolean = False

            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = vbYes Then

                Dim blnOK As Boolean = False

                'se se grabo el detalle
                If Me.UscProgramacion21._AGrabar > 0 Then

                    Select Case Me._TipoVisitaID
                        Case Type.Enumeracion.Visita.TipoVisita.Extraordinario  'extraordinario

                            'Legolas.Configuration.Aplication.MessageBox.Information( _
                            '"A continuacion ingrese los datos de los visitantes autorizados")
                            'FRM_Autorizacion()

                            blnOK = True
                        Case Else

                            blnOK = True
                    End Select

                    If blnOK = True Then
                        Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                        value = True
                        If CerrarForm = True Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If

                    End If

                End If

            End If

            Return value

        End Function
        Private Sub AAnularAutorizacionExtraordinario(IDAutorizacion As Integer)

            If Me.UscProgramacion21._Codigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Grabe el registro, antes de anular la autorizacion")
                Exit Sub
            End If

            If Me.UscProgramacion21._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Primero seleccione el interno(a)")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea anular el registro seleccionado") = Windows.Forms.DialogResult.Yes Then

                Dim intIDAutorizacion As Integer = IDAutorizacion

                'validar si la programacion ha sido usado
                If ValidarCalendarioDetUsado() = True Then
                    Exit Sub
                End If
              
                Dim objBssAutorizacion As New Bussines.Visita.Autorizacion
                objBssAutorizacion.GrabarEstadoInactivo(intIDAutorizacion)
                Me.UscProgramacion21._ListarAutorizacion(Me.UscProgramacion21._InternoID)

            End If

        End Sub
#End Region
#Region "Form"
        Private Sub FRM_InternoBuscar()

            'validar si la programacion ha sido usado
            If ValidarCalendarioDetUsado() = True Then
                Exit Sub
            End If

            Dim frm As New Visita.Interno.frmInternoPopup
            With frm
                ._RegionID = Me._RegionID
                ._RegionNombre = Me._RegionNombre
                ._PenalID = Me._PenalID
                ._PenalNombre = Me._PenalNombre
                ._FechaVisita = Legolas.Configuration.Aplication.FechayHora.FechaLong

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.UscProgramacion21._InternoID = ._GrillaInternoID
                    Me.UscProgramacion21.InternoApellidosyNombres = ._GrillaApellidosyNombres
                End If

            End With
        End Sub
        Private Sub FRM_VisitanteAutorizacionDetalle(IDAutorizacion)

            'validar si la programacion ha sido usado
            Dim blnCalendatioDetUsado As Boolean = ValidarCalendarioDetUsado(False)

            Dim frm As New Visita.Programacion.frmDetalleExtraordinarioPopup
            With frm
                ._Codigo = IDAutorizacion
                ._CalendarioDetUsado = blnCalendatioDetUsado
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscProgramacion21._ListarAutorizacion(Me.UscProgramacion21._InternoID)
                End If

            End With

        End Sub
        Private Sub FRM_VisitanteAutorizacionAgregar()

            Dim blnGrabo As Boolean = False

            If Me.UscProgramacion21._Codigo < 1 Then

                blnGrabo = AOK(False)

                'Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                '"Grabe el registro, antes de realizar la autorizacion")
                'Exit Sub
            Else
                blnGrabo = True
            End If

            If blnGrabo = False Then
                Exit Sub
            End If

            If Me.UscProgramacion21._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Primero seleccione el interno(a)")
                Exit Sub
            End If

            'validar si la programacion ha sido usado
            If ValidarCalendarioDetUsado() = True Then
                Exit Sub
            End If

            Dim frm As New Visita.Autorizacion.frmAutorizacionAddPopup
            With frm
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._InternoID = Me.UscProgramacion21._InternoID
                ._InternoApeNom = Me.UscProgramacion21.InternoApellidosyNombres
                ._Extraordinario = True
                ._CalendarioDetalleID = Me.UscProgramacion21._Codigo
                ._TipoParentesco = Type.Enumeracion.Parentesco.ParentescoGrupo.FamiliaresAbogado  'familiares

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.UscProgramacion21._ListarAutorizacion(Me.UscProgramacion21._InternoID)

                End If

            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub Usuario_Permisos()

            Me.btnAceptar.Visible = Me._FormEscritura

        End Sub
        Private Sub ValoresxDefault()

            Usuario_Permisos()
            LoadUsc()

        End Sub
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

            AOK()

        End Sub

        Private Sub frmDetallePopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmDetallePopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown


            ListarMant()

        End Sub

        Private Sub UscProgramacion21__CellDoubleClick_AutorizacionGrilla(IDAutorizacion As Integer) Handles UscProgramacion21._CellDoubleClick_AutorizacionGrilla

            FRM_VisitanteAutorizacionDetalle(IDAutorizacion)

        End Sub

        Private Sub UscProgramacion21__Click_AddAutorizacion() Handles UscProgramacion21._Click_AddAutorizacion

            FRM_VisitanteAutorizacionAgregar()

        End Sub

        Private Sub UscProgramacion21__Click_AnularAutorizacion(IDAutorizacion As Integer) Handles UscProgramacion21._Click_AnularAutorizacion

            AAnularAutorizacionExtraordinario(IDAutorizacion)

        End Sub


        Private Sub UscProgramacion21__Click_BuscarInterno() Handles UscProgramacion21._Click_BuscarInterno

            FRM_InternoBuscar()

        End Sub

        Private Sub UscProgramacion21_Load(sender As System.Object, e As System.EventArgs) Handles UscProgramacion21.Load

        End Sub
    End Class
End Namespace