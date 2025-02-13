Imports System.Linq
Imports System.Runtime.Remoting.Contexts
Imports DataClass
Public Class FrmFindOdontograma
    Private _activos As Boolean = False
    Public Property Activos() As Boolean
        Get
            Return _activos
        End Get
        Set(ByVal value As Boolean)
            _activos = value
        End Set
    End Property
    Private _int As Integer = -1
    Public Property CodInterno As Integer
        Get
            Return _int
        End Get
        Set(ByVal value As Integer)
            _int = value
        End Set
    End Property

    Private Sub FrmFindAdministrados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Carga_datos_listview()
    End Sub
    Public Overrides Sub Carga_datos_form()
        MyBase.Carga_datos_form()
        Me.Criterios.Add("ID")
        Me.Condiciones.Add("1")
        Me.Criterios.Add("Todos")
        Me.Condiciones.Add("2")
        cbocriterio.DataSource = Me.Criterios
        cbocriterio.SelectedIndex = 1
    End Sub
    Public Overrides Sub Carga_datos_listview()
        MyBase.Carga_datos_listview()
        Dim odatos As DataClass.DataContextDataContext = New DataClass.DataContextDataContext(Legolas.Configuration.Data.ConexionIni)
        Dim opt As String = Me.Condiciones(cbocriterio.SelectedIndex)
        Dim ofercho As IQueryable(Of int_mov_interno_odontograma_nts)
        opt = "2"
        If Me.Activos = False Then
            Select Case opt
                Case Is = "1"
                    Dim ohc As String = ("00000000" + txtfind.Text.Trim)
                    ohc = ohc.Substring(ohc.Length - 3, 3)
                    ofercho = From p In odatos.int_mov_interno_odontograma_nts Where p.fk_int_id = CodInterno And p.pk_odonto_id = ohc And p._flg_eli = False Select p

                Case Is = "2"
                    ofercho = From p In odatos.int_mov_interno_odontograma_nts Where p.fk_int_id = CodInterno And p._flg_eli = False Order By p.odonto_fecha Descending, p.pk_odonto_id Descending Select p
                    'Case Is = "3"
                    '    ofercho = From p In odatos.ContextDatos.Administrados Where p.AdmNruc = txtfind.Text Select p
            End Select
        Else
            'Select Case opt
            '    Case Is = "1"
            '        Dim ohc As String = ("000000" + txtfind.Text.Trim)
            '        ohc = ohc.Substring(ohc.Length - 3, 3)
            '        ofercho = From p In odatos.ContextDatos.Mercados Where p.MercadoId = ohc And p.MercadoAct = Me.Activos Select p

            '    Case Is = "2"
            '        ofercho = From p In odatos.ContextDatos.Mercados Where p.MercadoDes Like "*" + txtfind.Text + "*" And p.MercadoAct = Me.Activos Select p
            '        'Case Is = "3"
            '        '    ofercho = From p In odatos.ContextDatos.Administrados Where p.AdmNruc = txtfind.Text And p.AdmAct = Me.Activos Select p
            'End Select
        End If



        For Each ochofer As int_mov_interno_odontograma_nts In ofercho
            Dim oitem As ListViewItem = New ListViewItem(ochofer.pk_odonto_id.ToString, 41)
            oitem.SubItems.Add(ochofer.odonto_fecha.ToString("dd/MM/yyyy"))
            oitem.Tag = ochofer
            lstviewseleccion.Items.Add(oitem)
        Next



    End Sub
    Public Overrides Sub Devuelve_valor()
        MyBase.Devuelve_valor()
        If lstviewseleccion.SelectedItems.Count > 0 Then
            Me.Valorretorno = lstviewseleccion.SelectedItems(0).Tag
        End If
    End Sub
End Class
