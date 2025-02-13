Public Class uscAuditUser
    Public Sub LoadAudit(NomUsuarioCre As String, FechCrea As Long, NomUsuarioActualiza As String, FechActualiza As Long)
        lblCreadoPor.Text = NomUsuarioCre
        lblFechCrea.Text = Legolas.Components.FechaHora.FechaDate(FechCrea, True)
        lblEditadoPor.Text = NomUsuarioActualiza
        lblFechEdicion.Text = Legolas.Components.FechaHora.FechaDate(FechActualiza, True)
    End Sub
    Public Sub LoadAudit(IdRegistro As Integer, TipoTabla As Type.Enumeracion.TipoTabla.EnumTipTabla)
        If IdRegistro < 0 Then
            lblCreadoPor.Text = ""
            lblEditadoPor.Text = ""
            lblFechCrea.Text = ""
            lblFechEdicion.Text = ""
            Exit Sub
        End If
        Dim objBssInt As New Bussines.Globall.AuditUser
        Dim objEntInt As Entity.Globall.AuditUser = Nothing
        objEntInt = objBssInt.Listar(IdRegistro, TipoTabla)
        If objEntInt IsNot Nothing Then
            lblCreadoPor.Text = objEntInt.UsuarioCrea
            If Legolas.Components.FechaHora.FechaAnio(objEntInt.FechaCreacion) < 1900 Then
                lblFechCrea.Text = ""
            Else
                lblFechCrea.Text = Legolas.Components.FechaHora.FechaDate(objEntInt.FechaCreacion, True)
            End If
            'lblFechCrea.Text = Legolas.Components.FechaHora.FechaDate(objEntInt.FechaCreacion, True)
            lblEditadoPor.Text = objEntInt.UsuarioActualiza
            'lblFechEdicion.Text = Legolas.Components.FechaHora.FechaDate(objEntInt.FechaActualiza, True)
            If Legolas.Components.FechaHora.FechaAnio(objEntInt.FechaActualiza) < 1900 Then
                'lblFechEdicion.Text = Legolas.Components.FechaHora.FechaDate(0, True)
                lblFechEdicion.Text = ""
            Else
                lblFechEdicion.Text = Legolas.Components.FechaHora.FechaDate(objEntInt.FechaActualiza, True)
            End If
        End If
    End Sub
End Class
