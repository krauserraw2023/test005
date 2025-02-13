
Imports System.Windows.Forms
Namespace Registro.Reniec
    Public Class frmDetalleValidacionPoput
        Private objBss As Bussines.Registro.NombreAsociado = Nothing
        Public objEntRnc As New Entity.Registro.InternoReniec
#Region "Propiedades"
        Public Property _InternoID As Integer = -1
        Public Property _TipoDocumento As Integer = -1
        Public Property _NumeroDocumento As String = ""
        Public Property _Estado As Integer = -1

        Private Property FechaValidacion As Date
        Private Property ListaInternoData As String = ""
        Private Property ListaReniecdata As String = ""
        Private Property NombreAsociadoVal_ID() As Integer = -1
        Private Property NombreAsociadoVal_Nom() As String = ""
#End Region
#Region "Propiedades_Grilla"

        Public Property _NroIngresoID() As Integer = -1


#End Region
#Region "Propiedades_Return"
        Private intTipoValidacionReniec As Short = -1
        Public Property _TipoValidacionReniec As Short
            Get
                Return intTipoValidacionReniec
            End Get
            Set(value As Short)
                intTipoValidacionReniec = value
            End Set
        End Property
#End Region
#Region "Listar"

#End Region
#Region "Accion"



        Private Sub ComboNumIngreso()
            Dim objBssIng As New Bussines.Registro.Ingreso
            Dim objEntCol2 As New Entity.Registro.IngresoCol

            Dim objEnt As New Entity.Registro.Ingreso
            objEnt.InternoID = Me._InternoID

            objEntCol2 = objBssIng.ListarNroIngreso(Me._InternoID, -1)
            'Me.cbbNroIngresos.DataSource = objEntCol2
            'Me.cbbNroIngresos.DisplayMember = "IngresoNro"
            'Me.cbbNroIngresos.ValueMember = "Codigo"

            'ListarResoluciones()
            'pnlNuevoReniec.Visible = True
        End Sub

#End Region

        Private Sub frmDetalleValidacion_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            With objEntRnc
                 Dim strNombreAsociadoVal As String = ""
                If objEntRnc.NombreAsociadoVal_ID > 0 Then
                    Me.NombreAsociadoVal_ID = objEntRnc.NombreAsociadoVal_ID
                    Me.NombreAsociadoVal_Nom = objEntRnc.NombreAsociadoVal_Nom
                    strNombreAsociadoVal = "  (" & Me.NombreAsociadoVal_Nom & ")"
                    txtTipodeverificacion.Size = New Size(305, 20)
                Else
                    strNombreAsociadoVal = ""
                    txtTipodeverificacion.Size = New Size(168, 20)
                End If
                Dim strComparacion As String = ""
                Select Case Me.objEntRnc.ComparacionID
                    Case Type.Enumeracion.Reniec.EnmTipoValidacion.DNI
                        strComparacion = "DNI"
                    Case Type.Enumeracion.Reniec.EnmTipoValidacion.DatosPrincipales
                        strComparacion = "NOMBRE PRINCIPAL"
                    Case Type.Enumeracion.Reniec.EnmTipoValidacion.NombreAsociado
                        strComparacion = "NOMBRE ASOCIADO"
                    Case Type.Enumeracion.Reniec.EnmTipoValidacion.Ninguna
                        strComparacion = "NINGUNO"
                End Select
                txtTipodeverificacion.Text = strComparacion & strNombreAsociadoVal
                txtEstado.Text = IIf(Me.objEntRnc.TipoBusquedaID = 1, "VALIDADO", IIf(Me.objEntRnc.TipoBusquedaID = "2", "OBSERVADO", "NO ENCONTRADO"))
                Me.FechaValidacion = Legolas.Components.FechaHora.FechaDate(objEntRnc.FechaValidacion, True)
                txtFechavalidacion.Text = objEntRnc.FechaHoraPM()
                Me.txtObservacion.Text = objEntRnc.Observaciones
                If .InternoSisData <> "" Then
                    Me.ListaInternoData = .InternoSisData
                    Me.ListaReniecdata = .ReniecData  ' Datos del Interno en Reniec
                    Dim strListaRnc As String = Me.ListaReniecdata
                    Dim strRegistroRnc() As String = strListaRnc.Split("|")
                    If Me.objEntRnc.TipoBusquedaID = 3 Then
                    Else
                        Me.txtRestriccion.Text = IIf(strRegistroRnc(16) = "    ", "NINGUNA", Trim(strRegistroRnc(16)))
                        If strRegistroRnc.Length = 17 Then
                            Me.txtFechainscripcion.Text = ""
                            Me.txtFechaexpedicion.Text = ""
                        Else
                            Me.txtFechainscripcion.Text = Trim(strRegistroRnc(17))
                            Me.txtFechaexpedicion.Text = Trim(strRegistroRnc(18))
                        End If
                    End If
                    UscAuditUser1.LoadAudit(objEntRnc.CodigoHistorial, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoReniec)
                End If
            End With
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()

        End Sub
    End Class

End Namespace