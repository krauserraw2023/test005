Imports System.Linq
Imports System.Data.linq
Imports DataClass
Imports System.IO
Imports Bussines.Seguridad.Penal
Imports Entity.Seguridad.Penal
Imports System.Security.Policy


Public Class uscOdotoNew

    Private _intid As Integer = -1
    Private _codinterno As String = ""
    Private _nomInterno As String = ""
    Private _codingreso As Integer = 1
    Private _cododonto As Integer = -1
    Private swnuevo As Boolean = False

    Public Property CodOdontograma As Integer
        Get
            CodOdontograma = _cododonto
        End Get
        Set(value As Integer)
            _cododonto = value
        End Set
    End Property
    Public Property CodIngreso As Integer
        Get
            CodIngreso = _codingreso
        End Get
        Set(value As Integer)
            _codingreso = value
        End Set
    End Property
    Private _codingresoInpe As Integer
    Public Property CodIngresoInpe As Integer
        Get
            CodIngresoInpe = _codingresoInpe
        End Get
        Set(value As Integer)
            _codingresoInpe = value
        End Set
    End Property
    Public Property NomInterno As String
        Get
            NomInterno = _nomInterno
        End Get
        Set(value As String)
            _nomInterno = value
        End Set
    End Property
    Public Property CodInterno As String
        Get
            CodInterno = _codinterno
        End Get
        Set(value As String)
            _codinterno = value
        End Set
    End Property
    Private Property _regid As Integer = -1
    Public Property RegionId As Integer
        Get
            RegionId = _regid
        End Get
        Set(value As Integer)
            _regid = value
        End Set
    End Property
    Private Property _penalid As Integer = -1
    Public Property PenalId As Integer
        Get
            PenalId = _penalid
        End Get
        Set(value As Integer)
            _penalid = value
        End Set
    End Property
    Public Property InternoId As Integer
        Get
            InternoId = _intid
        End Get
        Set(value As Integer)
            _intid = value
        End Set
    End Property
    Private Property _sololec As Boolean = False
    Public Property SoloLectura As Boolean
        Get
            SoloLectura = _sololec
        End Get
        Set(value As Boolean)
            _sololec = value
        End Set
    End Property

    Private _odonto_nts As DataClass.int_mov_interno_odontograma_nts
    Public Property Odonto_nts As DataClass.int_mov_interno_odontograma_nts
        Get
            Odonto_nts = _odonto_nts
        End Get
        Set(value As DataClass.int_mov_interno_odontograma_nts)
            _odonto_nts = value
        End Set
    End Property
    Public Sub carga_datos()
        Try
            If Odonto_nts Is Nothing Then
                pboxodonto.Image = My.Resources.Odontovacio
                Exit Sub
            End If

            If Odonto_nts.odonto_imagen Is Nothing Then
                pboxodonto.Image = My.Resources.Odontovacio
            Else
                pboxodonto.Image = byteArrayToImage(Odonto_nts.odonto_imagen.ToArray)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.btnaddodontograma.Visible = Not SoloLectura
    End Sub

    Public Function byteArrayToImage(byteArrayIn As Byte()) As System.Drawing.Image

        Dim ms As MemoryStream = New MemoryStream(byteArrayIn)
        Dim returnImage As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
        Return returnImage
    End Function

    Private Sub uscOdotoNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga_datos()

    End Sub
    Public Sub carga_lista()
        lstlista.Items.Clear()
        lstlista.View = View.Details
        btnaddodontograma.Visible = Not Me.SoloLectura
        Dim lobj As New List(Of int_mov_interno_odontograma_nts)
        Using DB As New DataContextDataContext(Legolas.Configuration.Data.ConexionIni)
            If (From p In DB.int_mov_interno_odontograma_nts Where p.fk_int_id = Me.InternoId Where p._flg_eli = False Select p).Count > 0 Then

                lobj = (From p In DB.int_mov_interno_odontograma_nts Where p.fk_int_id = Me.InternoId Where p._flg_eli = False Order By p.odonto_fecha Descending, p.pk_odonto_id Descending Select p).ToList

                For Each odep As int_mov_interno_odontograma_nts In lobj
                    Dim ind As Integer = 0
                    Dim oitem As ListViewItem = New ListViewItem(odep.pk_odonto_id.ToString, ind)
                    oitem.SubItems.Add(odep.odonto_fecha.ToString("dd/MM/yyyy"))
                    oitem.Tag = odep
                    oitem.Name = odep.pk_odonto_id.ToString
                    lstlista.Items.Add(oitem)
                Next
            Else
                Dim oit As ListViewItem = New ListViewItem("<<No hay Elementos Disponibles>>")
                oit.ForeColor = Color.Gray
                lstlista.Items.Add(oit)
                Exit Sub
            End If

        End Using

    End Sub
    Private Sub seleccionar_odontograma()
        If lstlista.SelectedItems.Count > 0 Then
            Dim oit As ListViewItem = lstlista.SelectedItems(0)
            Dim obj As int_mov_interno_odontograma_nts = CType(oit.Tag, int_mov_interno_odontograma_nts)
                Odonto_nts = obj
            carga_datos()
        End If
    End Sub
    Private Sub btnaddodontograma_Click(sender As Object, e As EventArgs) Handles btnaddodontograma.Click
        Dim oform As frmodontograma = New frmodontograma
        oform.CodInterno = Me.CodInterno
        oform.NomInterno = Me.NomInterno
        oform.InternoId = Me.InternoId
        oform.CodIngreso = Me.CodIngreso
        oform.CodIngresoInpe = Me.CodIngresoInpe
        oform.PenalId = PenalId
        oform.RegionId = RegionId
        oform.ShowDialog()
        obtiene_datos()
        carga_datos()
        carga_lista()
    End Sub
    Private Sub obtiene_datos()
        Dim obj As New int_mov_interno_odontograma_nts
        Using DB As New DataContextDataContext(Legolas.Configuration.Data.ConexionIni)
            If (From p In DB.int_mov_interno_odontograma_nts Where p.fk_int_id = Me.InternoId Where p._flg_eli = False Select p).Count > 0 Then

                obj = (From p In DB.int_mov_interno_odontograma_nts Where p.fk_int_id = Me.InternoId Where p._flg_eli = False Order By p.odonto_fecha Descending, p.pk_odonto_id Descending Select p).First
                Me.Odonto_nts = obj
            Else
                Me.Odonto_nts = New int_mov_interno_odontograma_nts

            End If

        End Using
    End Sub

    Private Sub lstlista_DoubleClick(sender As Object, e As EventArgs) Handles lstlista.DoubleClick
        seleccionar_odontograma()
    End Sub
End Class
