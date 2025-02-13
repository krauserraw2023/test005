Public Class frmConfigAmputadoDeca
    Public Property _izq_men_amputado As Boolean
        Get
            Return chk_izq_men.CheckState
        End Get
        Set(value As Boolean)
            chk_izq_men.Checked = value
        End Set
    End Property

    Public Property _izq_anu_amputado As Boolean
        Get
            Return chk_izq_anu.CheckState
        End Get
        Set(value As Boolean)
            chk_izq_anu.Checked = value
        End Set
    End Property

    Public Property _izq_med_amputado As Boolean
        Get
            Return chk_izq_med.CheckState
        End Get
        Set(value As Boolean)
            chk_izq_med.Checked = value
        End Set
    End Property

    Public Property _izq_ind_amputado As Boolean
        Get
            Return chk_izq_ind.CheckState
        End Get
        Set(value As Boolean)
            chk_izq_ind.Checked = value
        End Set
    End Property

    Public Property _izq_pul_amputado As Boolean
        Get
            Return chk_izq_pul.CheckState
        End Get
        Set(value As Boolean)
            chk_izq_pul.Checked = value
        End Set
    End Property

    Public Property _der_men_amputado As Boolean
        Get
            Return chk_der_men.CheckState
        End Get
        Set(value As Boolean)
            chk_der_men.Checked = value
        End Set
    End Property

    Public Property _der_anu_amputado As Boolean
        Get
            Return chk_der_anu.CheckState
        End Get
        Set(value As Boolean)
            chk_der_anu.Checked = value
        End Set
    End Property

    Public Property _der_med_amputado As Boolean
        Get
            Return chk_der_med.CheckState
        End Get
        Set(value As Boolean)
            chk_der_med.Checked = value
        End Set
    End Property

    Public Property _der_ind_amputado As Boolean
        Get
            Return chk_der_ind.CheckState
        End Get
        Set(value As Boolean)
            chk_der_ind.Checked = value
        End Set
    End Property

    Public Property _der_pul_amputado As Boolean
        Get
            Return chk_der_pul.CheckState
        End Get
        Set(value As Boolean)
            chk_der_pul.Checked = value
        End Set
    End Property

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        'izq_men_amputado = chk_izq_men.CheckState
        'izq_anu_amputado = chk_izq_anu.CheckState
        'izq_med_amputado = chk_izq_med.CheckState
        'izq_ind_amputado = chk_izq_ind.CheckState
        'izq_pul_amputado = chk_izq_pul.CheckState

        'der_men_amputado = chk_der_men.CheckState
        'der_anu_amputado = chk_der_anu.CheckState
        'der_med_amputado = chk_der_med.CheckState
        'der_ind_amputado = chk_der_ind.CheckState
        'der_pul_amputado = chk_der_pul.CheckState
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub chkManIzqAmputada_Click(sender As Object, e As System.EventArgs) Handles chkManIzqAmputada.Click
        If chkManIzqAmputada.Checked Then
            chk_izq_men.Checked = True
            chk_izq_anu.Checked = True
            chk_izq_med.Checked = True
            chk_izq_ind.Checked = True
            chk_izq_pul.Checked = True
        Else
            chk_izq_men.Checked = False
            chk_izq_anu.Checked = False
            chk_izq_med.Checked = False
            chk_izq_ind.Checked = False
            chk_izq_pul.Checked = False
        End If
    End Sub

    Private Sub chkManDerAmputada_Click(sender As Object, e As System.EventArgs) Handles chkManDerAmputada.Click
        If chkManDerAmputada.Checked Then
            chk_der_men.Checked = True
            chk_der_anu.Checked = True
            chk_der_med.Checked = True
            chk_der_ind.Checked = True
            chk_der_pul.Checked = True
        Else
            chk_der_men.Checked = False
            chk_der_anu.Checked = False
            chk_der_med.Checked = False
            chk_der_ind.Checked = False
            chk_der_pul.Checked = False
        End If
        
    End Sub
End Class