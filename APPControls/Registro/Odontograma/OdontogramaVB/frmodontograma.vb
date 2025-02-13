Imports System.Data.Linq
Imports DataClass
Imports Newtonsoft.Json
Imports APPControls.PiezaDental
'Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Net
Imports System.Net.Cache
Imports System.Linq
Imports System.ComponentModel
'Imports iTextSharp.text
'Imports iTextSharp.text.pdf.qrcode
'Imports PiezaDental
Imports System.Drawing.Drawing2D
Imports APPControls.JsonConvierte
Imports APPControls
'Imports System.Text.Json
'Imports System.Text.Json.Serialization
Imports System.Drawing.Imaging
Imports System.Diagnostics.Eventing.Reader

Public Class frmodontograma
    'Dim stringconecction As String = "Data Source=HADES-QA\PREPROD;Initial Catalog=db_inpe_gob_pe_sip_pope_dev;User ID=osi42;Password=12345"
    Dim stringconecction As String = Legolas.Configuration.Data.ConexionIni

    Private piezas As List(Of PiezaDental)
    Dim f1 As Integer() = {18, 17, 16, 15, 14, 13, 12, 11, 21, 22, 23, 24, 25, 26, 27, 28}
    Dim fe1 As String()
    Dim fe4 As String()
    Dim f2 As Integer() = {55, 54, 53, 52, 51, 61, 62, 63, 64, 65}
    Dim f3 As Integer() = {85, 84, 83, 82, 81, 71, 72, 73, 74, 75}
    Dim f4 As Integer() = {48, 47, 46, 45, 44, 43, 42, 41, 31, 32, 33, 34, 35, 36, 37, 38}
    Dim lpiezasmanual As New List(Of HallasgosManual)
    Private _odonto As int_mov_interno_odontograma_nts
    Private _intid As Integer = 100
    Private _codinterno As String = ""
    Private _nomInterno As String = ""
    Private _codingreso As Integer = 1
    Private _cododonto As Integer = -1
    Private swnuevo As Boolean = False

    Dim db As DataClass.DataContextDataContext
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
    Public Property InternoId As Integer
        Get
            InternoId = _intid
        End Get
        Set(value As Integer)
            _intid = value
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
    Private Property _sololec As Boolean = False
    Public Property SoloLectura As Boolean
        Get
            SoloLectura = _sololec
        End Get
        Set(value As Boolean)
            _sololec = value
        End Set
    End Property

    Public Property Odonto_nts As int_mov_interno_odontograma_nts
        Get
            Odonto_nts = _odonto
        End Get
        Set(value As int_mov_interno_odontograma_nts)
            _odonto = value
        End Set
    End Property
    Private Sub frmodontograma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Height = 740
        ' Medidas minimas del formulario
        'CJason()
        DoubleBuffered = True
        dtpfecha.Value = Now
        Me.MinimumSize = New Size(1087, 820)
        Panel1.BackColor = Me.BackColor
        PanelOdonto.BackColor = Color.White
        tbsimprimir.Visible = False
        tsbborrar.Enabled = Not SoloLectura
        tsbeliminar.Enabled = Not SoloLectura
        tsbnuevo.Enabled = Not SoloLectura
        tsbeliminar.Enabled = Not SoloLectura
        tsbmodificar.Enabled = Not SoloLectura
        Carga_entorno()
        'Me.DoubleBuffered = True
        'Me.VerticalScroll.Visible = True
        'Me.VerticalScroll.Enabled = True
        ' Me.AutoScroll = True
    End Sub
    Private Sub Carga_entorno()
        db = New DataContextDataContext(stringconecction)
        Carga_Combos()
        Dibuja_piezas_automatico()
        tstxtinterno.Text = Me.NomInterno
        txttxtcodinterno.Text = Me.CodInterno
        tslfeccrea.Text = ""
        btnadd.Enabled = IIf(CodOdontograma = -1, False, True)

        If (From p In db.int_mov_interno_odontograma_nts Where p.fk_int_id = Me.InternoId And p._flg_eli = False
            Select p).Count = 0 Then
            MessageBox.Show("Odontograma No Encontrado", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Habilita_controles(False)
            tsbmodificar.Enabled = False
            tsbeliminar.Enabled = False
            tbsimprimir.Enabled = False
            tbsgrabar.Enabled = False
            tsbnuevo.Enabled = True

            Exit Sub
        End If

        Me.Odonto_nts = (From p In db.int_mov_interno_odontograma_nts
                         Where p.fk_int_id = Me.InternoId And p._flg_eli = False Order By p.odonto_fecha Descending, p.pk_odonto_id Descending Select p).First
        txtnumodonto.Text = Odonto_nts.pk_odonto_id
        PenalId = Odonto_nts._PenId
        RegionId = Odonto_nts._RegId
        CodIngreso = Odonto_nts.fk_int_ing_id
        CodIngresoInpe = Odonto_nts.fk_ing_inp_id
        CodOdontograma = CType(txtnumodonto.Text, Integer)

        dtpfecha.Value = Odonto_nts.odonto_fecha
        txtespecificaciones.Text = Odonto_nts.odonto_especificaciones
        txtobservaciones.Text = Odonto_nts.odonto_observaciones
        txtnumcespe.Text = txtespecificaciones.Text.Length
        txtnumcobs.Text = txtobservaciones.Text.Length
        'If Odonto_nts._fec_cre > 0 Then
        '    tslfeccrea.Text = Odonto_nts._fec_cre

        Habilita_controles(False)
    End Sub
    Private Sub Habilita_controles(estado As Boolean)
        dtpfecha.Enabled = estado
        txtespecificaciones.ReadOnly = Not estado
        txtobservaciones.ReadOnly = Not estado
        btnadd.Enabled = estado
        cbohallazgos.Enabled = estado
    End Sub
    Private Sub Carga_Combos()
        Dim ores As List(Of gen_mae_odontograma_nts_items) = New List(Of gen_mae_odontograma_nts_items)
        ' Using db As New DataContextDataContext(stringconecction)

        ores = (From p In db.gen_mae_odontograma_nts_items
                Where p.gen_mae_odontograma_nts.nts_activo = True
                Order By p.nts_item_desc
                Select p).ToList
        cbohallazgos.DataSource = ores
        cbohallazgos.DisplayMember = "nts_item_desc"
        cbohallazgos.ValueMember = "nts_item"
        'End Using
    End Sub
    Private Function FPiezaDental(npieza As Integer) As PiezaDental
        Return (From p In piezas Where p.NumPieza = npieza Select p).First
    End Function
    Private Function FPiezaDentalOrd(norden As Integer) As PiezaDental
        Return (From p In piezas Where p.NumOrden = norden Select p).First
    End Function

    Private Sub CJason()
        'Dim p1 As New Punto(100, 120)
        'Dim p2 As New Punto(120, 150)
        'Dim p3 As New Punto(140, 170)
        'Dim p4 As New Punto(160, 190)
        Dim p1 As New Point(100, 120)
        Dim p2 As New Point(120, 150)
        Dim p3 As New Point(140, 170)
        Dim p4 As New Point(160, 190)
        Dim lpuntos As New List(Of Point)
        lpuntos.Add(p1)
        lpuntos.Add(p2)
        lpuntos.Add(p3)
        lpuntos.Add(p4)
        Dim csjason As String = Jsonserializa(lpuntos)

        MessageBox.Show(csjason)
    End Sub
    Private Sub DibujaSimbolos(P1 As PiezaDental, P2 As PiezaDental, e As Graphics, TipoSimbolo As Integer, cl As Color, valor As String)

        Select Case TipoSimbolo
            Case Is = 1
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = -50
                Else
                    fila = 80
                End If
                If P2 Is Nothing Then
                    SAOF(New Point(P1.PX + Int(P1.PCX / 3), P1.PY + fila), New Point(P1.PX + Int(P1.PCX / 3), P1.PY + fila), e, cl, fila)
                Else
                    SAOF(New Point(P1.PX + Int(P1.PCX / 3), P1.PY + fila), New Point(P2.PX + Int(P2.PCX / 3), P2.PY + fila), e, cl, fila)
                End If
            Case Is = 2
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = -40
                Else
                    fila = 410
                End If
                If P2 Is Nothing Then
                    SAOR(P1, P2, e, cl, fila)
                Else
                    SAOR(P1, P2, e, cl, fila)
                End If
            Case 3 To 4
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                SCOR(P1, Nothing, e, cl, fila)
            Case Is = 6
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = -40
                Else
                    fila = 410
                End If
                SDIA(P1, P2, e, cl, fila)
            Case Is = 7
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                SETS(P1, P2, e, cl, fila)
            Case Is = 8
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                SEMU(P1, P2, e, cl, fila)
            Case Is = 11
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = -110
                Else
                    fila = 48
                End If
                SFUS(P1, P2, e, cl, fila)
            Case Is = 12
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = -110
                Else
                    fila = 48
                End If
                SGEM(P1, P2, e, cl, fila)
            Case Is = 13
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = -13
                Else
                    fila = -50
                End If
                SGVE(P1, P2, e, cl, fila, valor)
            Case Is = 20
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = 0
                Else
                    fila = 25
                End If
                SPDA(P1, P2, e, cl, fila)
            Case Is = 21
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = -38
                Else
                    fila = 80
                End If
                SPDC(P1, P2, e, cl, fila)
            Case Is = 25
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = -1
                Else
                    fila = 1
                End If
                SPDU(P1, P2, e, cl, fila)
            Case Is = 26
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = -1
                Else
                    fila = 0
                End If
                SPDX(P1, P2, e, cl, fila)
            Case Is = 27
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = -1
                Else
                    fila = 0
                End If
                SPDI(P1, P2, e, cl, fila)
            Case Is = 28
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = -65
                Else
                    fila = 6
                End If
                SPDS(P1, P2, e, cl, fila)
            Case Is = 29
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = -65
                Else
                    fila = 6
                End If
                SPUL(P1, P2, e, cl, fila)
            Case Is = 31
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = -49
                Else
                    fila = 83
                End If
                SPDP(P1, P2, e, cl, fila)
            Case 32 To 33
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = -49
                Else
                    fila = 80
                End If
                SPRE(P1, P2, e, cl, fila)
            Case Is = 39
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                STCO(P1, P2, e, cl, fila)
            Case Is = 40
                If P1 Is Nothing And P2 Is Nothing Then Exit Sub
                Dim fila As Integer = 0
                If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
                    fila = -49
                Else
                    fila = 83
                End If
                STDE(P1, P2, e, cl, fila)
        End Select

    End Sub
    Private Sub DibujaEtiqueta(P1 As PiezaDental, e As Graphics)
        Dim pza As String = P1.NumPieza
        Dim h As Integer = 0
        Dim fuente As New FontFamily("Arial")
        Dim Font As New System.Drawing.Font(fuente, 12, FontStyle.Regular, GraphicsUnit.Pixel)
        If P1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or P1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
            h = -110
        Else
            h = 110
        End If
        Using db As New DataContextDataContext(stringconecction)

            Dim oet = (From p In db.int_mov_interno_odontograma_nts_det
                       Where p.odonto_id = Me.CodOdontograma And p.nts_item_tipo.Contains("E") And p.odonto_p1 = pza And p._flg_eli = False   'Aca debe ir el nro de Odontograma
                       Order By p.odonto_p1, p.nts_valor_abrev
                       Select p).ToList
            Dim salto As Integer = 0
            Dim ncant As Integer = oet.Count
            If ncant = 1 Then
                salto = 12
            End If
            If ncant = 2 Then
                salto = 6
            End If

            For Each op As int_mov_interno_odontograma_nts_det In oet
                If op.nts_valor_abrev Is Nothing Then Continue For
                Dim sn As Integer = op.nts_valor_abrev.Trim.Length
                Dim npos As Integer = 0
                If sn >= 3 Then
                    npos = Int(P1.PCX / 6)
                ElseIf sn = 2 Then
                    npos = Int(P1.PCX / 4)
                Else
                    npos = Int(P1.PCX / 2.5)
                End If
                e.DrawString(op.nts_valor_abrev, Font, IIf(op.nts_item_color = "A", Brushes.Blue, Brushes.Red), P1.PX + npos, P1.PY + h + salto)
                salto = salto + 12
            Next


        End Using

    End Sub
    Private Sub DibujaLienzos(op As int_mov_interno_odontograma_nts_det, e As Graphics)

        If op Is Nothing Then Exit Sub
        Dim br As Brush = IIf(op.nts_item_color = "A", Brushes.Blue, Brushes.Red)
        Select Case op.nts_item
            Case 16, 35
                If Not op.nts_item_lienzo Is Nothing Then
                    Dim lpuntos As List(Of Point) = Jsondeserializa(op.nts_item_lienzo)
                    For Each lp As Point In lpuntos
                        Dim rec As New RectangleF(lp.X - 5, lp.Y - 5, 10, 10)
                        e.FillEllipse(br, rec)
                    Next
                End If
                If CType(cbohallazgos.SelectedItem, gen_mae_odontograma_nts_items).nts_item = op.nts_item Then
                    'lpiezasseleccionadas.Add(op.odonto_p1)
                End If

            Case 10, 36, 37, 38
                If Not op.nts_item_lienzo Is Nothing Then
                    Dim lpuntos As List(Of Point) = Jsondeserializa(op.nts_item_lienzo)
                    Dim pen As Pen = New Pen(br, 4)
                    'If lpuntos.Count Mod 2 = 1 Then Exit Sub
                    Dim xtot As Integer = IIf(lpuntos.Count Mod 2 = 0, lpuntos.Count - 1, lpuntos.Count - 2)
                    For i As Integer = 0 To xtot Step 2
                        e.DrawLine(pen, lpuntos(i), lpuntos(i + 1))
                    Next
                End If
                If CType(cbohallazgos.SelectedItem, gen_mae_odontograma_nts_items).nts_item = op.nts_item Then
                    'lpiezasseleccionadas.Add(op.odonto_p1)
                End If
        End Select
        'If CType(cbohallazgos.SelectedItem, gen_mae_odontograma_nts_items).nts_item = op.nts_item And (op.nts_item = 16 Or op.nts_item = 16) Then
        '    If Not op.nts_item_lienzo Is Nothing Then
        '        Dim lpuntos As List(Of Point) = Jsondeserializa(op.nts_item_lienzo)
        '        For Each lp As Point In lpuntos
        '            Dim rec As New RectangleF(lp.X - 5, lp.Y - 5, 10, 10)
        '            e.FillEllipse(br, rec)
        '        Next
        '    End If
        '    ' lpiezasseleccionadas.Add(op.odonto_p1)
        'End If
        'If CType(cbohallazgos.SelectedItem, gen_mae_odontograma_nts_items).nts_item = op.nts_item And (op.nts_item = 10 Or op.nts_item = 36 Or op.nts_item = 37 Or op.nts_item = 38) Then
        '    If Not op.nts_item_lienzo Is Nothing Then
        '        Dim lpuntos As List(Of Point) = Jsondeserializa(op.nts_item_lienzo)
        '        Dim pen As Pen = New Pen(br, 4)
        '        'If lpuntos.Count Mod 2 = 1 Then Exit Sub
        '        Dim xtot As Integer = IIf(lpuntos.Count Mod 2 = 0, lpuntos.Count - 1, lpuntos.Count - 2)
        '        For i As Integer = 0 To xtot Step 2
        '            e.DrawLine(pen, lpuntos(i), lpuntos(i + 1))
        '        Next
        '    End If
        '    'lpiezasseleccionadas.Add(op.odonto_p1)
        'End If




    End Sub
    Private Sub Dibuja_piezas_automatico()
        Dim pf1y, pf2y, pf3y, pf4y As Integer
        Dim pf1x, pf2x, pf3x, pf4x As Integer
        Dim pf1ye, pf2ye, pf3ye, pf4ye As Integer
        Dim ld As Integer = 38
        Dim inc As Integer = 40
        Dim inc2 As Integer = 35
        Dim Xinif1 As Integer = 40
        Dim Xinif2 As Integer = 166 + 20
        Dim Xinif3 As Integer = 166 + 20
        Dim Xinif4 As Integer = 40
        Dim Yinif1 As Integer = 180 + 15 - 80
        Dim Yinif2 As Integer = 322 + 15 - 80 + 4 + 4
        Dim Yinif3 As Integer = 365 + 15 - 80 - 4 - 4 + 10
        Dim Yinif4 As Integer = 510 + 15 - 80

        pf1ye = -110
        pf2ye = -97 + 6 + 5
        pf3ye = 95 - 4 - 4
        pf4ye = 110

        piezas = New List(Of PiezaDental)
        Dim dis As Integer = 0
        For i As Integer = 0 To 15
            Dim opieza As PiezaDental = New PiezaDental(Xinif1 + dis, Yinif1, ld, ld, pf1ye, f1(i), i + 1, "Sup")
            piezas.Add(opieza)
            dis = dis + inc
        Next

        dis = 0

        Dim ld2 As Integer = 33
        Dim dis2 As Integer = 0
        For i As Integer = 0 To 9
            Dim opieza As PiezaDental = New PiezaDental(Xinif2 + dis2, Yinif2, ld2, ld2, pf2ye, f2(i), i + 1, "Sup")
            piezas.Add(opieza)
            dis2 = dis2 + inc2
        Next
        dis = 0
        dis2 = 0
        For i As Integer = 0 To 9
            Dim opieza As PiezaDental = New PiezaDental(Xinif3 + dis2, Yinif3, ld2, ld2, pf3ye, f3(i), i + 1, "Inf")
            piezas.Add(opieza)
            dis2 = dis2 + inc2
        Next
        dis = 0
        For i As Integer = 0 To 15
            Dim opieza As PiezaDental = New PiezaDental(Xinif4 + dis, Yinif4, ld, ld, pf4ye, f4(i), i + 1, "Inf")
            piezas.Add(opieza)
            dis = dis + inc
        Next

        Exit Sub


    End Sub
    Private Sub tsbsalir_Click(sender As Object, e As EventArgs) Handles tsbsalir.Click
        Me.Close()
    End Sub

    Private Sub frmodontograma_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'For Each p As PiezaDental In piezas
        '    p.Dibuja(e.Graphics)
        'Next
        'Dim osimb As List(Of int_mov_interno_odontograma_nts_det)
        'Using db As New DataContextDataContext(stringconecction)

        '    osimb = (From p In db.int_mov_interno_odontograma_nts_det
        '             Where p.nts_id = 1 'Aca debe ir el nro de Odontograma
        '             Order By p.odonto_p1, p.odonto_p2
        '             Select p).ToList
        'End Using
        'For Each oitem As int_mov_interno_odontograma_nts_det In osimb
        '    If oitem.nts_item_tipo.Contains("G") Then
        '        DibujaSimbolos(FPiezaDental(oitem.odonto_p1), FPiezaDental(oitem.odonto_p2), e.Graphics, oitem.nts_item, IIf(oitem.nts_item_color = "A", Color.Blue, Color.Red))
        '    End If
        '    If oitem.nts_item_tipo.Contains("E") Then
        '        DibujaEtiqueta(FPiezaDental(oitem.odonto_p1), e.Graphics)
        '    End If

        'Next


    End Sub
    Private Sub SDIA(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)

        Dim d As Integer = Int((p2.PX - p1.PX - p1.PCX) / 2) + 2
        Dim h As Integer = 6
        Dim x1 As Integer = p1.PX + 3 * Int(p1.PCX / 2)
        Dim x2 As Integer = p1.PX + p1.PCX + d
        Dim rec1 As RectangleF = New RectangleF(p1.PX + p1.PCX - 20 - 1, p1.PY - h, 20, 50)
        Dim rec2 As RectangleF = New RectangleF(p1.PX + p1.PCX + 1, p1.PY - h, 20, 50)

        Dim pn As Pen = New Pen(cl, 3)
        gr.DrawArc(pn, rec1, -90, 180)
        gr.DrawArc(pn, rec2, 90, 180)

    End Sub
    Private Sub STCO(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim lpuntos As List(Of Point) = New List(Of Point)
        Dim pn As Pen = New Pen(cl, 3)
        Dim rec As Rectangle = New Rectangle(p1.PX + Int(p1.PCX / 3), p1.PY + Int(p1.PCY / 3), Int(p1.PCX / 3), Int(p1.PCY / 3))
        'gr.DrawRectangle(pn, rec)
        If p1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or p1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2), p1.PY + Int(p1.PCY / 2)), New Point(p1.PX + Int(p1.PCX / 2), p1.PY + Int(p1.PCY / 2) - 46))
        Else
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2), p1.PY + Int(p1.PCY / 2)), New Point(p1.PX + Int(p1.PCX / 2), p1.PY + Int(p1.PCY / 2) + 46))
        End If


    End Sub
    Private Sub SEMU(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim lpuntos As List(Of Point) = New List(Of Point)
        Dim pn As Pen = New Pen(cl, 3)
        Dim rec As System.Drawing.Rectangle = New System.Drawing.Rectangle(p1.PX + Int(p1.PCX / 3), p1.PY + Int(p1.PCY / 3), Int(p1.PCX / 3), Int(p1.PCY / 3))
        gr.DrawRectangle(pn, rec)
        If p1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or p1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2), p1.PY - 25), New Point(p1.PX + Int(p1.PCX / 2), p1.PY + Int(p1.PCY / 3)))
        Else
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2), p1.PY + 2 * Int(p1.PCY / 3) + 33), New Point(p1.PX + Int(p1.PCX / 2), p1.PY + 2 * Int(p1.PCY / 3)))
        End If


    End Sub
    Private Sub SPDS(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim rec1 As RectangleF = New RectangleF(p1.PX + 4 * Int(p1.PCX / 5), p1.PY + p1.PCY + fila, 22, 22)
        'Dim rec2 As RectangleF = New RectangleF(p2.PX - 2, p2.PY + p2.PCY + fila, 35, 25)
        Dim pn As Pen = New Pen(cl, 2)
        gr.DrawEllipse(pn, rec1)
        Dim fuente As FontFamily = New FontFamily("Arial")
        Dim Font As New System.Drawing.Font(
        fuente, 12, FontStyle.Regular, GraphicsUnit.Pixel)
        gr.DrawString("S", Font, Brushes.Blue, p1.PX + 4 * Int(p1.PCX / 5) + 5, p1.PY + p1.PCY + fila + 4)


    End Sub
    Private Sub SFUS(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim rec1 As RectangleF = New RectangleF(p1.PX + Int(p1.PCX / 5), p1.PY + p1.PCY + fila, 35, 25)
        Dim rec2 As RectangleF = New RectangleF(p2.PX - 2, p2.PY + p2.PCY + fila, 35, 25)
        Dim pn As Pen = New Pen(cl, 2)
        gr.DrawEllipse(pn, rec1)
        gr.DrawEllipse(pn, rec2)

    End Sub
    Private Sub SPUL(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim rec1 As RectangleF = New RectangleF(p1.PX + Int(p1.PCX / 3), p1.PY + Int(p1.PCY / 3), Int(p1.PCX / 3) + 2, Int(p1.PCY / 3) + 2)
        'Dim rec2 As RectangleF = New RectangleF(p2.PX - 2, p2.PY + p2.PCY + fila, 35, 25)
        Dim bs As Brush
        If cl = Color.Blue Then
            bs = Brushes.Blue
        Else
            bs = Brushes.Red
        End If
        Dim pn As Pen = New Pen(cl, 2)
        gr.FillRectangle(bs, rec1)
        'gr.DrawEllipse(pn, rec2)

    End Sub
    Private Sub SGEM(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim rec1 As RectangleF = New RectangleF(p1.PX + Int(p1.PCX / 10), p1.PY + p1.PCY + fila, 30, 25)
        'Dim rec2 As RectangleF = New RectangleF(p2.PX - 2, p2.PY + p2.PCY + fila, 35, 25)
        Dim pn As Pen = New Pen(cl, 2)
        gr.DrawEllipse(pn, rec1)
        'gr.DrawEllipse(pn, rec2)

    End Sub
    Private Sub SGVE(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer, sentido As String)
        Dim rec1 As RectangleF = New RectangleF(p1.PX + 2, p1.PY + p1.PCY + fila, 30, 25)
        'Dim rec2 As RectangleF = New RectangleF(p2.PX - 2, p2.PY + p2.PCY + fila, 35, 25)
        Dim pn As Pen = New Pen(cl, 2)
        If p1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or p1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
            'arriba
            If sentido = "D" Then
                gr.DrawArc(pn, rec1, 0, 160)
                gr.DrawLine(pn, New Point(p1.PX + 2 + 16, p1.PY + p1.PCY + 13 + fila + 3), New Point(p1.PX + 30 + 2, p1.PY + p1.PCY + 13 + 3 + fila))
                gr.DrawLine(pn, New Point(p1.PX + 30 + 2, p1.PY + p1.PCY + 13 + fila), New Point(p1.PX + 30 + 2, p1.PY + p1.PCY + 30 + fila))
            Else
                gr.DrawArc(pn, rec1, 0, 160)
                gr.DrawLine(pn, New Point(p1.PX + 2 + 16, p1.PY + p1.PCY + 13 + fila + 3), New Point(p1.PX + 2, p1.PY + p1.PCY + 13 + 3 + fila))
                gr.DrawLine(pn, New Point(p1.PX + 2, p1.PY + p1.PCY + 13 + fila), New Point(p1.PX + 2, p1.PY + p1.PCY + 30 + fila))
            End If
        Else
            'abajo
            If sentido = "D" Then
                gr.DrawArc(pn, rec1, 0, -160)
                gr.DrawLine(pn, New Point(p1.PX + 2, p1.PY - 3), New Point(p1.PX + 2, p1.PY - 3 - 13))
                gr.DrawLine(pn, New Point(p1.PX + 2, p1.PY - 3), New Point(p1.PX + 13, p1.PY - 3))

            Else
                gr.DrawArc(pn, rec1, 0, -160)
                gr.DrawLine(pn, New Point(p1.PX + p1.PCX - 6, p1.PY - 2), New Point(p1.PX + p1.PCX - 5, p1.PY - 13 - 2))
                gr.DrawLine(pn, New Point(p1.PX + p1.PCX - 6, p1.PY - 2), New Point(p1.PX + p1.PCX - 5 - 13, p1.PY - 2))
            End If

        End If
        'gr.DrawArc(pn, rec1, 0, 160)
        'gr.DrawLine(pn, New Point(p1.PX + 2 + 16, p1.PY + p1.PCY + 13 + fila + 3), New Point(p1.PX + 30 + 2, p1.PY + p1.PCY + 13 + 3 + fila))
        'gr.DrawLine(pn, New Point(p1.PX + 30 + 2, p1.PY + p1.PCY + 13 + fila), New Point(p1.PX + 30 + 2, p1.PY + p1.PCY + 30 + fila))
        ''gr.DrawEllipse(pn, rec2)

    End Sub
    Private Sub SPDU(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim d As Integer = 0
        Dim lpuntos As List(Of Point) = New List(Of Point)
        If fila = -1 Then
            lpuntos.Add(New Point(p1.PX + Int(p1.PCX / 3), p1.PY + d + 3 + 2 * Int(p1.PCY / 3)))
            lpuntos.Add(New Point(p1.PX + 2 * Int(p1.PCX / 3), p1.PY + d + 3 + 2 * Int(p1.PCY / 3)))
            lpuntos.Add(New Point(p1.PX + Int(p1.PCX / 3), p1.PY + d + 3 + 1 * Int(p1.PCY / 3)))
            lpuntos.Add(New Point(p1.PX + 2 * Int(p1.PCX / 3), p1.PY + d + 3))
            lpuntos.Add(New Point(p1.PX + Int(p1.PCX / 3), p1.PY + d + 3 - 1 * Int(p1.PCY / 3)))
            lpuntos.Add(New Point(p1.PX + 2 * Int(p1.PCX / 3), p1.PY + d + 3 - 2 * Int(p1.PCY / 3)))
            lpuntos.Add(New Point(p1.PX + Int(p1.PCX / 3), p1.PY + d + 3 - p1.PCY))
        Else
            lpuntos.Add(New Point(p1.PX + 2 * Int(p1.PCX / 3), p1.PY + d + 3 + Int(p1.PCY / 3)))
            lpuntos.Add(New Point(p1.PX + Int(p1.PCX / 3), p1.PY + d + 3 + Int(p1.PCY / 3)))
            lpuntos.Add(New Point(p1.PX + 2 * Int(p1.PCX / 3), p1.PY + d + 3 + 2 * Int(p1.PCY / 3)))
            lpuntos.Add(New Point(p1.PX + Int(p1.PCX / 3), p1.PY + p1.PCY + d + 3))
            lpuntos.Add(New Point(p1.PX + 2 * Int(p1.PCX / 3), p1.PY + d + 3 + 4 * Int(p1.PCY / 3)))
            lpuntos.Add(New Point(p1.PX + Int(p1.PCX / 3), p1.PY + d + 3 + 5 * Int(p1.PCY / 3)))
            lpuntos.Add(New Point(p1.PX + 2 * Int(p1.PCX / 3), p1.PY + d + 3 + 2 * p1.PCY))
        End If

        Dim pn As Pen = New Pen(cl, 3)
        gr.DrawLines(pn, lpuntos.ToArray)

    End Sub
    Private Sub SPDI(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim lpuntos As List(Of Point) = New List(Of Point)

        Dim pn As Pen = New Pen(cl, 3)
        If fila = -1 Then
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2), p1.PY + p1.PCY), New Point(p1.PX + Int(p1.PCX / 2), p1.PY + p1.PCY + Int(p1.PCY / 2)))
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2) - 10, p1.PY + p1.PCY + 10), New Point(p1.PX + Int(p1.PCX / 2), p1.PY + p1.PCY))
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2) + 10, p1.PY + p1.PCY + 10), New Point(p1.PX + Int(p1.PCX / 2), p1.PY + p1.PCY))
            'gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2) + 10, p1.PY - 10), New Point(p1.PX + Int(p1.PCX / 2), p1.PY - Int(p1.PCY / 2)))
        Else
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2), p1.PY - Int(p1.PCY / 2)), New Point(p1.PX + Int(p1.PCX / 2), p1.PY))
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2) - 10, p1.PY - 10), New Point(p1.PX + Int(p1.PCX / 2), p1.PY))
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2) + 10, p1.PY - 10), New Point(p1.PX + Int(p1.PCX / 2), p1.PY))
            'gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2) + 10, p1.PY + p1.PCY + Int(p1.PCY / 2) - 10), New Point(p1.PX + Int(p1.PCX / 2), p1.PY + p1.PCY + Int(p1.PCY / 2)))
        End If



    End Sub
    Private Sub SPDX(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim lpuntos As List(Of Point) = New List(Of Point)

        Dim pn As Pen = New Pen(cl, 3)
        If fila = -1 Then
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2), p1.PY + p1.PCY), New Point(p1.PX + Int(p1.PCX / 2), p1.PY + p1.PCY + Int(p1.PCY / 2)))
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2) - 10, p1.PY + p1.PCY + Int(p1.PCY / 2) - 10), New Point(p1.PX + Int(p1.PCX / 2), p1.PY + p1.PCY + Int(p1.PCY / 2)))
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2) + 10, p1.PY + p1.PCY + Int(p1.PCY / 2) - 10), New Point(p1.PX + Int(p1.PCX / 2), p1.PY + p1.PCY + Int(p1.PCY / 2)))
        Else
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2), p1.PY), New Point(p1.PX + Int(p1.PCX / 2), p1.PY - p1.PCY + Int(p1.PCY / 2)))
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2) - 10, p1.PY - 10), New Point(p1.PX + Int(p1.PCX / 2), p1.PY - Int(p1.PCY / 2)))
            gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2) + 10, p1.PY - 10), New Point(p1.PX + Int(p1.PCX / 2), p1.PY - Int(p1.PCY / 2)))

        End If



    End Sub
    Private Sub SPRE(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim pn As Pen = New Pen(cl, 3)
        gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2), p1.PY + fila), New Point(p2.PX + Int(p2.PCX / 2), p2.PY + fila))
        gr.DrawLine(pn, New Point(p1.PX + Int(p1.PCX / 2), p1.PY + 5 + fila), New Point(p2.PX + Int(p2.PCX / 2), p2.PY + 5 + fila))
    End Sub
    Private Sub SPDP(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim lpuntos As List(Of Point) = New List(Of Point)
        If p1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or p1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
            lpuntos.Add(New Point(p1.PX + Int(p1.PCX / 2), p1.PY + 9 + fila))
            lpuntos.Add(New Point(p1.PX + Int(p1.PCX / 2), p1.PY + fila))
            lpuntos.Add(New Point(p2.PX + Int(p2.PCX / 2), p2.PY + fila))
            lpuntos.Add(New Point(p2.PX + Int(p1.PCX / 2), p2.PY + 9 + fila))
        Else
            lpuntos.Add(New Point(p1.PX + Int(p1.PCX / 2), p1.PY - 9 + fila))
            lpuntos.Add(New Point(p1.PX + Int(p1.PCX / 2), p1.PY + fila))
            lpuntos.Add(New Point(p2.PX + Int(p2.PCX / 2), p2.PY + fila))
            lpuntos.Add(New Point(p2.PX + Int(p1.PCX / 2), p2.PY - 9 + fila))
        End If

        Dim pn As Pen = New Pen(cl, 3)
        gr.DrawLines(pn, lpuntos.ToArray)

    End Sub
    Private Sub SETS(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim lpuntos As List(Of Point) = New List(Of Point)

        Dim pn As Pen = New Pen(cl, 3)
        gr.DrawLine(pn, New Point(p1.PX, p1.PY + Int(p1.PCY / 2)), New Point(p2.PX + p2.PCX, p2.PY + Int(p2.PCY / 2)))

    End Sub
    Private Sub SPDA(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)

        Dim pn As Pen = New Pen(cl, 2)
        gr.DrawLine(pn, New Point(p1.PX, fila + p1.PY - 2 * Int(p1.PCY / 3)), New Point(p1.PX + p1.PCX, fila + p1.PY + p1.PCY))
        gr.DrawLine(pn, New Point(p1.PX, fila + p1.PY + p1.PCY), New Point(p1.PX + p1.PCX, fila + p1.PY - 2 * Int(p1.PCY / 3)))


    End Sub
    Private Sub STDE(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim pn As Pen = New Pen(cl, 2)
        'Dim ppx1 As Integer = p1.PX + Int(p1.PCX / 4)
        'Dim ppy1 As Integer = p1.PY + fila
        'Dim ppx2 As Integer = p2.PX - Int(p1.PCX / 2)
        'Dim ppy2 As Integer = p1.PY + fila
        Dim ppx1 As Integer = p1.PX + Int(p1.PCX / 4)
        Dim ppy1 As Integer = p1.PY + fila
        Dim ppx2 As Integer = p1.PX + Int(p1.PCX / 2)
        Dim ppy2 As Integer = p1.PY + fila
        'Dim rec1 As RectangleF = New RectangleF(ppx1, ppy1, 3 * Int(p1.PCX / 4) + Int(p2.PCX / 2), 35)
        'Dim rec2 As RectangleF = New RectangleF(ppx2, ppy2, Int(p1.PCX / 2) + 3 * Int(p2.PCX / 4), 35)
        Dim rec1 As RectangleF = New RectangleF(ppx1, ppy1, p2.PX + Int(p2.PCX / 2) - (p1.PX + Int(p1.PCX / 4)), 35)
        Dim rec2 As RectangleF = New RectangleF(ppx2, ppy2, p2.PX + Int(p2.PCX / 2) - (p1.PX + Int(p1.PCX / 4)), 35)
        If p1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or p1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
            gr.DrawArc(pn, rec1, 180, 180)
            gr.DrawArc(pn, rec2, 180, 180)
            gr.DrawLine(pn, New PointF(rec1.X + rec1.Width + 3 - 11, rec1.Y + 18), New PointF(rec1.X + rec1.Width, rec1.Y + 18))
            gr.DrawLine(pn, New PointF(rec1.X + rec1.Width + 3, rec1.Y + 18 - 11), New PointF(rec1.X + rec1.Width, rec1.Y + 18))

            gr.DrawLine(pn, New PointF(rec2.X - 2, rec2.Y + 18), New PointF(rec2.X - 2, rec2.Y + 18 - 11))
            gr.DrawLine(pn, New PointF(rec2.X - 2, rec2.Y + 18), New PointF(rec2.X - 2 + 11, rec2.Y + 18))
        Else


        End If



    End Sub
    Private Sub SPDC(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim lpuntos As List(Of Point) = New List(Of Point)
        Dim pn As Pen = New Pen(cl, 2)
        If p1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or p1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
            lpuntos.Add(New Point(p1.PX + Int(p1.PCX / 3), p1.PY + fila))
            lpuntos.Add(New Point(p1.PX + Int(p1.PCX / 2), p1.PY - 15 + fila))
            lpuntos.Add(New Point(p1.PX + 2 * Int(p1.PCX / 3), p1.PY + fila))
        Else
            lpuntos.Add(New Point(p1.PX + Int(p1.PCX / 3), p1.PY + fila))
            lpuntos.Add(New Point(p1.PX + Int(p1.PCX / 2), p1.PY + 15 + fila))
            lpuntos.Add(New Point(p1.PX + 2 * Int(p1.PCX / 3), p1.PY + fila))

        End If

        gr.DrawPolygon(pn, lpuntos.ToArray)

    End Sub
    Private Sub SCOR(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim lpuntos As List(Of Point) = New List(Of Point)

        lpuntos.Add(New Point(p1.PX, p1.PY))
        lpuntos.Add(New Point(p1.PX + p1.PCX, p1.PY))
        lpuntos.Add(New Point(p1.PX + p1.PCX, p1.PY + p1.PCY))
        lpuntos.Add(New Point(p1.PX, p1.PY + p1.PCY))
        lpuntos.Add(New Point(p1.PX, p1.PY))

        Dim pn As Pen = New Pen(cl, 2)
        gr.DrawLines(pn, lpuntos.ToArray)
        'gr.DrawLine(pn, pci1, pci2)
        'gr.DrawLine(pn, pci3, pci4)
        'gr.DrawRectangle(pn, rec2)
        'gr.DrawLine(pn, pcd1, pcd2)
        'gr.DrawLine(pn, pcd3, pcd4)
        'gr.DrawLine(pn, pli1, pld2)

    End Sub
    Private Sub SAOR(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)
        Dim lpuntos As List(Of Point) = New List(Of Point)
        Dim ld As Integer = 0
        If p1.NumPieza.ToString.Trim.Substring(0, 1) = "1" Or p1.NumPieza.ToString.Trim.Substring(0, 1) = "2" Then
            ld = -10
        Else
            ld = 10
        End If

        For n As Integer = p1.NumOrden To p2.NumOrden
            Dim pp As PiezaDental
            pp = FPiezaDentalOrd(n)
            lpuntos.Add(New Point(pp.PX, pp.PY + fila))
            lpuntos.Add(New Point(pp.PX + Int(pp.PCX / 2), pp.PY + fila + ld))
            lpuntos.Add(New Point(pp.PX + pp.PCX, pp.PY + fila))

        Next
        Dim pn As Pen = New Pen(cl, 2)
        gr.DrawLines(pn, lpuntos.ToArray)
        'gr.DrawLine(pn, pci1, pci2)
        'gr.DrawLine(pn, pci3, pci4)
        'gr.DrawRectangle(pn, rec2)
        'gr.DrawLine(pn, pcd1, pcd2)
        'gr.DrawLine(pn, pcd3, pcd4)
        'gr.DrawLine(pn, pli1, pld2)

    End Sub
    Private Sub SAOF(p1 As Point, p2 As Point, gr As Graphics, cl As Color, fila As Integer)

        Dim ld As Integer = 12
        Dim rec1 As System.Drawing.Rectangle = New System.Drawing.Rectangle(p1.X, p1.Y, ld, ld)
        Dim rec2 As System.Drawing.Rectangle = New System.Drawing.Rectangle(p2.X, p2.Y, ld, ld)
        ' Cruz izq
        Dim pci1 As Point = New Point(p1.X + Int(ld / 6), p1.Y + Int(ld / 2))
        Dim pci2 As Point = New Point(p1.X + 5 * Int(ld / 6), p1.Y + Int(ld / 2))
        Dim pci3 As Point = New Point(p1.X + Int(ld / 2), p1.Y + Int(ld / 6))
        Dim pci4 As Point = New Point(p1.X + Int(ld / 2), p1.Y + 5 * Int(ld / 6))
        ' Cruz der
        Dim pcd1 As Point = New Point(p2.X + Int(ld / 6), p2.Y + Int(ld / 2))
        Dim pcd2 As Point = New Point(p2.X + 5 * Int(ld / 6), p2.Y + Int(ld / 2))
        Dim pcd3 As Point = New Point(p2.X + Int(ld / 2), p2.Y + Int(ld / 6))
        Dim pcd4 As Point = New Point(p2.X + Int(ld / 2), p2.Y + 5 * Int(ld / 6))
        ' Linea de union
        Dim pli1 As Point = New Point(p1.X + ld, p2.Y + Int(ld / 2))
        Dim pld2 As Point = New Point(p2.X, p2.Y + Int(ld / 2))

        Dim pn As Pen = New Pen(cl, 2)
        gr.DrawRectangle(pn, rec1)
        gr.DrawLine(pn, pci1, pci2)
        gr.DrawLine(pn, pci3, pci4)
        gr.DrawRectangle(pn, rec2)
        gr.DrawLine(pn, pcd1, pcd2)
        gr.DrawLine(pn, pcd3, pcd4)
        gr.DrawLine(pn, pli1, pld2)


    End Sub

    Private Sub PanelOdonto_Paint(sender As Object, e As PaintEventArgs) Handles PanelOdonto.Paint
        If piezas Is Nothing Then Exit Sub
        For Each p As PiezaDental In piezas
            p.Dibuja(e.Graphics)
        Next
        If Odonto_nts Is Nothing Then Exit Sub
        If (From p In Odonto_nts.int_mov_interno_odontograma_nts_det Where p._flg_eli = False).Count > 0 Then
            Dim osimb = (From p In Odonto_nts.int_mov_interno_odontograma_nts_det Where p._flg_eli = False
                         Order By p.odonto_p1, p.odonto_p2
                         Select p).ToList
            'Dim osimb = (From p In db.int_mov_interno_odontograma_nts_det Where p.pk_odonto_id = Me.CodOdontograma
            '             Order By p.odonto_p1, p.odonto_p2
            '             Select p).ToList
            'For Each oitem As int_mov_interno_odontograma_nts_det In Odonto_nts.int_mov_interno_odontograma_nts_det
            For Each oitem As int_mov_interno_odontograma_nts_det In osimb
                If oitem.nts_item_tipo.Contains("G") Then
                    DibujaSimbolos(FPiezaDental(oitem.odonto_p1), FPiezaDental(oitem.odonto_p2), e.Graphics, oitem.nts_item, IIf(oitem.nts_item_color = "A", Color.Blue, Color.Red), oitem.nts_valor_abrev)
                End If
                If oitem.nts_item_tipo.Contains("E") Then
                    DibujaEtiqueta(FPiezaDental(oitem.odonto_p1), e.Graphics)
                End If
                If oitem.nts_item_pinta = "M" Then
                    DibujaLienzos(oitem, e.Graphics)
                End If

            Next
        End If
        'e.Graphics.DrawPath(System.Drawing.Pens.DarkRed, mousePath)
        'Pinta_Hallazgos_Manuales(e.Graphics)

    End Sub
    Private Sub Pinta_Hallazgos_Manuales(p As Graphics)
        Exit Sub
        If lpiezasmanual.Count > 0 Then
            For Each ob As HallasgosManual In lpiezasmanual
                Dim brocha As Brush = IIf(ob.Pcolor = "A", Brushes.Blue, Brushes.Red)
                If ob.LPiezasPath.Count > 0 Then
                    For Each ii As GraphicsPath In ob.LPiezasPath
                        p.FillPath(brocha, ii)
                    Next
                End If
            Next


        End If

    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        'lpiezasseleccionadas = New List(Of Integer)
        Dim oingreso As Frmingreso = New Frmingreso
        oingreso.Item_nts = CType(cbohallazgos.SelectedItem, gen_mae_odontograma_nts_items)
        'oingreso.Items_det = (From p In Odonto_nts.int_mov_interno_odontograma_nts_det Where p.nts_item = CType(cbohallazgos.SelectedItem, gen_mae_odontograma_nts_items).nts_item Select p).ToList
        oingreso.OForm = Me
        oingreso.OdontoId = CInt(txtnumodonto.Text)
        oingreso.db = Me.db
        oingreso.Odonto_nts = Me.Odonto_nts
        'oingreso.Nts_det = Odonto_nts.int_mov_interno_odontograma_nts_det
        oingreso.ShowDialog()
        If oingreso.SwRegistro Then
            Me.PanelOdonto.Refresh()
            guarda_imagen()
            db.SubmitChanges()
        End If
    End Sub
    Public Function imageToByteArray(ByVal imageIn As System.Drawing.Image) As Byte()
        Dim ms As MemoryStream = New MemoryStream()
        imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
        Return ms.ToArray()
    End Function
    Public Function byteArrayToImage(byteArrayIn As Byte()) As System.Drawing.Image

        Dim ms As MemoryStream = New MemoryStream(byteArrayIn)
        Dim returnImage As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
        Return returnImage
    End Function
    Private Sub tbsgrabar_Click(sender As Object, e As EventArgs) Handles tbsgrabar.Click

        Try
            Odonto_nts.odonto_fecha = dtpfecha.Value
            Odonto_nts.odonto_especificaciones = txtespecificaciones.Text
            Odonto_nts.odonto_observaciones = txtobservaciones.Text
            Odonto_nts._usu_mod = Legolas.Configuration.Usuario.Codigo
            Odonto_nts._fec_mod = Legolas.Configuration.Aplication.FechayHora.FechaLong
            If (From p In Odonto_nts.int_mov_interno_odontograma_nts_det Where p._flg_eli = False).Count > 0 Then
                Dim noeli = From p In Odonto_nts.int_mov_interno_odontograma_nts_det Where p._flg_eli = False
                'For Each ob As int_mov_interno_odontograma_nts_det In Odonto_nts.int_mov_interno_odontograma_nts_det
                For Each ob As int_mov_interno_odontograma_nts_det In noeli
                    If ob.nts_item_pinta = "M" Then
                        If String.IsNullOrEmpty(ob.nts_item_lienzo) Then
                            MessageBox.Show("A la pieza Dental " + ob.odonto_p1 + " le falta dibujar el hallazgo " + Nom_hallazgo(ob.nts_item), "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                Next

            End If
            guarda_imagen()
            ' bm.Save("D:\Odontovacio.png", ImageFormat.Png)
            db.SubmitChanges()
            MessageBox.Show("Los datos se han registrado correctamente", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Habilita_controles(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        PanelOdonto.Cursor = Cursor.Current
    End Sub
    Private Function Nom_hallazgo(id As Integer) As String
        Dim xnom As String = "NO ENCONTRADO"
        If (From p In db.gen_mae_odontograma_nts_items Where p.gen_mae_odontograma_nts.nts_activo = True And p.nts_item = id Select p.nts_item_desc).Count > 0 Then
            xnom = (From p In db.gen_mae_odontograma_nts_items Where p.gen_mae_odontograma_nts.nts_activo = True And p.nts_item = id Select p.nts_item_desc).Single
        End If
        Return xnom
    End Function

    Public Sub guarda_imagen()
        Me.Height = 740
        Dim bm As New Bitmap(722, 598)
        PanelOdonto.DrawToBitmap(bm, PanelOdonto.DisplayRectangle)
        Odonto_nts.odonto_imagen = imageToByteArray(bm)
    End Sub
    Private Function Base64ToImage(base64String As String) As System.Drawing.Image
        ' Convierte tu string 64 a un byte[]
        Dim imagenBytes As Byte() = Convert.FromBase64String(base64String)
        Dim ms As MemoryStream = New MemoryStream(imagenBytes, 0, imagenBytes.Length)
        ' Convierte tu byte[] a imagen 
        ms.Write(imagenBytes, 0, imagenBytes.Length)
        Dim image As System.Drawing.Image = System.Drawing.Image.FromStream(ms, True)
        Return image
    End Function
    Private Sub tbsimprimir_Click(sender As Object, e As EventArgs) Handles tbsimprimir.Click
        'If Not Me.WindowState = FormWindowState.Maximized Then
        '    MessageBox.Show("Debe Maximizar la ventana para poder imprimir.", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If
        'MessageBox.Show(Me.Height)
        'Dim bm As New Bitmap(722, 598)
        'PanelOdonto.DrawToBitmap(bm, PanelOdonto.DisplayRectangle)
        'bm.Save("d:\imagenodonto.png")
        'Exit Sub
        Me.Height = 740
        'Dim xcorr As String = "000000" + txtnumodonto.Text.Trim
        'Crea_Pdf(xcorr.Substring(xcorr.Length - 6, 6))
        Exit Sub
        'Dim gr As Graphics = Me.CreateGraphics
        '' Tamaño de lo que queremos copiar
        '' Dim fSize As Size = New Size(Me.Size.Width - 450, Me.Size.Height - 120)
        'Dim fSize As Size = New Size(PanelOdonto.Width, PanelOdonto.Height - 5)
        '' Creamos el bitmap con el área que vamos a capturar
        '' En este caso, con el tamaño del formulario actual
        'Dim bm As New Bitmap(fSize.Width, fSize.Height, gr)

        'Dim archivog As Byte()
        'Dim archpdfres As Byte() = My.Resources.formato_ondontograma

        'Dim reader As PdfReader = New PdfReader(archpdfres)
        'Dim baos As MemoryStream = New MemoryStream()
        'Dim PdfStamper As PdfStamper = New PdfStamper(reader, baos)
        'Dim bf As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
        'Dim tr As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
        ''For i As Integer = 1 To reader.NumberOfPages
        ''Dim overContent As PdfContentByte = PdfStamper.GetOverContent(i)
        'Dim overContent As PdfContentByte = PdfStamper.GetOverContent(1)

        'overContent.BeginText()
        'overContent.SetFontAndSize(bf, 16)
        'overContent.SetTextMatrix(350, 610)
        'overContent.ShowText(txtnumodonto.Text)
        'overContent.EndText()

        'overContent.BeginText()
        'overContent.SetFontAndSize(bf, 12)
        'overContent.SetTextMatrix(430, 660)
        'overContent.ShowText(dtpfecha.Value.ToString("dd/MM/yyyy"))
        'overContent.EndText()
        ''Next
        ''Dim oimage As Image = Base64ToImage(bm.ToString)
        'Dim gr2 As Graphics = Graphics.FromImage(bm)
        'gr2.CopyFromScreen(10, 105, 0, 0, fSize)
        'Dim image1 As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(bm, System.Drawing.Imaging.ImageFormat.Jpeg)
        'image1.ScalePercent(68.0F)
        ''image1.ScaleToFit(70.0F, 90.0F)
        ''image1.ScaleAbsoluteWidth(fSize.Width)
        ''image1.ScaleAbsoluteHeight(fSize.Height)
        'image1.SetAbsolutePosition(60, 175)
        'overContent.AddImage(image1)
        'Dim parrafo1 As iTextSharp.text.Paragraph = New iTextSharp.text.Paragraph(New iTextSharp.text.Phrase("Especificaciones : " + txtespecificaciones.Text))
        'parrafo1.Alignment = iTextSharp.text.Element.ALIGN_JUSTIFIED
        'overContent.PdfDocument.Add(parrafo1)
        'overContent.BeginText()
        'overContent.SetFontAndSize(bf, 11)
        'overContent.SetTextMatrix(80, 150)
        'overContent.ShowText("Especificaciones : " + txtespecificaciones.Text)
        'overContent.EndText()
        'overContent.BeginText()
        'overContent.SetFontAndSize(bf, 11)
        'overContent.SetTextMatrix(80, 80)
        'overContent.ShowText("Observaciones : " + txtobservaciones.Text)
        'overContent.EndText()
        'PdfStamper.Close()
        'archivog = baos.ToArray()
        'Using file As FileStream = New FileStream("D:\Odonto2.pdf", FileMode.Create, System.IO.FileAccess.Write)
        '    file.Write(archivog, 0, archivog.Length)
        'End Using

    End Sub
    'Private Sub Crea_Pdf(id As String)

    '    Dim pathtemp As String = Path.GetTempPath()
    '    ' Dim archpdfres As Byte() = My.Resources.formato_ondontograma
    '    Dim rutaArchivoPDF As String = pathtemp + id + ".pdf"
    '    Dim parra1 As iTextSharp.text.Paragraph = New iTextSharp.text.Paragraph()
    '    Dim f1 As iTextSharp.text.Font = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.DARK_GRAY)
    '    Try
    '        Using doc As iTextSharp.text.Document = New iTextSharp.text.Document()
    '            If File.Exists(rutaArchivoPDF) Then File.Delete(rutaArchivoPDF)
    '            Dim w As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(rutaArchivoPDF, FileMode.Create))
    '            Dim bf As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
    '            Dim bf2 As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
    '            doc.Open()
    '            doc.NewPage()
    '            Dim over As PdfContentByte = w.DirectContent()
    '            Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(My.Resources.logo_inpe, System.Drawing.Imaging.ImageFormat.Png)
    '            logo.ScalePercent(30.0F)
    '            'logo.SetAbsolutePosition(iTextSharp.text.PageSize.A4.Width, iTextSharp.text.PageSize.A4.Height)
    '            doc.Add(logo)
    '            Dim linea As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(My.Resources.line_inpe, System.Drawing.Imaging.ImageFormat.Png)
    '            linea.ScalePercent(80.0F)
    '            linea.SetAbsolutePosition(200, iTextSharp.text.PageSize.A4.Height - 100)
    '            doc.Add(linea)
    '            over.BeginText()
    '            over.SetFontAndSize(bf, 11)
    '            over.SetTextMatrix(400, iTextSharp.text.PageSize.A4.Height - 80)
    '            over.ShowText("Sistema Integral Penitenciario")
    '            over.EndText()
    '            over.BeginText()
    '            over.SetFontAndSize(bf2, 11)
    '            over.SetTextMatrix(450, iTextSharp.text.PageSize.A4.Height - 130)
    '            over.ShowText("Fecha : " + dtpfecha.Value.ToString("dd/MM/yyyy"))
    '            over.EndText()

    '            over.BeginText()
    '            over.SetFontAndSize(bf, 14)
    '            over.SetTextMatrix(200, iTextSharp.text.PageSize.A4.Height - 180)
    '            over.ShowText("ODONTOGRAMA N° " + id)
    '            over.EndText()
    '            'Dim fecha As iTextSharp.text.Paragraph = New iTextSharp.text.Paragraph("Fecha : " + dtpfecha.Value.ToString("dd/MM/yyyy"))
    '            'fecha.Add(New iTextSharp.text.Phrase(iTextSharp.text.Chunk.NEWLINE))
    '            'Dim titulo As iTextSharp.text.Paragraph = New iTextSharp.text.Paragraph("ODONTOGRAMA N° " + id)
    '            'fecha.Alignment = iTextSharp.text.Element.ALIGN_RIGHT
    '            'titulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER
    '            For i As Integer = 1 To 29
    '                Dim xlinea As New iTextSharp.text.Phrase(iTextSharp.text.Chunk.NEWLINE)
    '                doc.Add(xlinea)
    '            Next

    '            'doc.Add(fecha)
    '            'doc.Add(titulo)

    '            Dim bm As New Bitmap(722, 598)
    '            PanelOdonto.DrawToBitmap(bm, PanelOdonto.DisplayRectangle)

    '            Dim image1 As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(bm, System.Drawing.Imaging.ImageFormat.Jpeg)
    '            image1.ScalePercent(68.0F)
    '            image1.SetAbsolutePosition(60, 230)

    '            doc.Add(image1)

    '            'Dim Col As New ColumnText(over)
    '            'Col.SetSimpleColumn(90, 90, 500, 100)

    '            Dim oespecificacionesT As New Phrase(New iTextSharp.text.Chunk("Especificaciones : ", New iTextSharp.text.Font(bf)))
    '            Dim oespecificacionesC As New iTextSharp.text.Phrase(txtespecificaciones.Text, New iTextSharp.text.Font(bf2))
    '            'oespecificacionesC.Alignment = iTextSharp.text.Element.ALIGN_JUSTIFIED
    '            Dim oespe As New Paragraph()
    '            oespe.IndentationLeft = 55
    '            oespe.IndentationRight = 35
    '            oespe.Alignment = iTextSharp.text.Element.ALIGN_JUSTIFIED
    '            oespe.Add(oespecificacionesT)
    '            oespe.Add(oespecificacionesC)

    '            'oespecificaciones.Add(New iTextSharp.text.Phrase(iTextSharp.text.Chunk.NEWLINE))
    '            'oespecificaciones.Add(New iTextSharp.text.Phrase(iTextSharp.text.Chunk.NEWLINE))
    '            Dim oobser As New iTextSharp.text.Paragraph()
    '            oobser.IndentationLeft = 55
    '            oobser.IndentationRight = 35
    '            oobser.Alignment = iTextSharp.text.Element.ALIGN_JUSTIFIED
    '            'oobser.Alignment = iTextSharp.text.Element.ALIGN_JUSTIFIED
    '            'Col.AddText(oespecificaciones)
    '            ''Col.AddText(oobser)
    '            'Col.Go()
    '            Dim oobseT As New Phrase(New iTextSharp.text.Chunk("Observaciones : ", New iTextSharp.text.Font(bf)))
    '            Dim oobseC As New iTextSharp.text.Phrase(txtobservaciones.Text, New iTextSharp.text.Font(bf2))
    '            oobser.Add(oobseT)
    '            oobser.Add(oobseC)
    '            doc.Add(oespe)
    '            doc.Add(New iTextSharp.text.Phrase(iTextSharp.text.Chunk.NEWLINE))
    '            doc.Add(oobser)

    '        End Using
    '        Process.Start(rutaArchivoPDF)
    '    Catch ex As Exception

    '        MessageBox.Show(ex.Message, "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub



    Private Sub tsbnuevo_Click(sender As Object, e As EventArgs) Handles tsbnuevo.Click
        If MessageBox.Show("Esta seguro de generar un nuevo Odontograma?", "Mensaje a Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then Exit Sub
        'swnuevo = True
        'db = New DataContextDataContext
        Odonto_nts = New int_mov_interno_odontograma_nts
        Odonto_nts.fk_int_id = InternoId
        Odonto_nts.fk_ing_inp_id = CodIngresoInpe
        Odonto_nts.fk_int_ing_id = CodIngreso
        Odonto_nts.odonto_especificaciones = Nothing
        Odonto_nts.odonto_observaciones = Nothing
        Odonto_nts.odonto_fecha = dtpfecha.Value
        Odonto_nts._RegId = Me.RegionId ' Aqui region
        Odonto_nts._PenId = Me.PenalId  ' Aqui Penal
        'Odonto_nts.pk_odonto_id = FOdontoId()
        Odonto_nts.int_mov_interno_odontograma_nts_det = Nothing
        If Legolas.LBusiness.Globall.WinApp.LicenciaApp = "1" Then
            Odonto_nts._sed_flg_trf = 1
        Else
            Odonto_nts._flg_trf = 1
        End If
        Odonto_nts._flg_eli = False
        Odonto_nts._usu_cre = Legolas.Configuration.Usuario.Codigo
        Odonto_nts._fec_cre = Legolas.Configuration.Aplication.FechayHora.FechaLong
        Odonto_nts._usu_mod = Legolas.Configuration.Usuario.Codigo
        Odonto_nts._fec_mod = Legolas.Configuration.Aplication.FechayHora.FechaLong
        CodOdontograma = Odonto_nts.pk_odonto_id
        Try
            db.int_mov_interno_odontograma_nts.InsertOnSubmit(Odonto_nts)
            db.SubmitChanges()
            Carga_entorno()
            PanelOdonto.Refresh()
            ' swnuevo = False
            MessageBox.Show("Odontograma generado correctamente", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Habilita_controles(True)
            tsbmodificar.Enabled = True
            tsbeliminar.Enabled = True
            tbsimprimir.Enabled = True
            tbsgrabar.Enabled = True
            tsbnuevo.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Habilita_controles(False)
            tsbmodificar.Enabled = False
            tsbeliminar.Enabled = False
            tbsimprimir.Enabled = False
            tsbnuevo.Enabled = True
            tbsgrabar.Enabled = False
        End Try

    End Sub
    Private Function FOdontoId() As Integer
        Dim n As Integer = -1
        Dim res = (From p In db.int_mov_interno_odontograma_nts Order By p.pk_odonto_id Descending Select p.pk_odonto_id).First
        n = res + 1
        Return n
    End Function

    Private Sub tsbmodificar_Click(sender As Object, e As EventArgs) Handles tsbmodificar.Click
        Habilita_controles(True)
    End Sub
    Private r As Integer = 3
    Private mousePath As New System.Drawing.Drawing2D.GraphicsPath()
    Dim piezaseleccionada As PiezaDental = Nothing
    Private Sub PanelOdonto_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelOdonto.MouseDown
        If btnadd.Enabled = False Then Exit Sub
        piezaseleccionada = Nothing
        Dim mouseDownLocation As New Point(e.X, e.Y)
        If lpiezasseleccionadas.Count = 0 Then Exit Sub
        For Each p As PiezaDental In piezas
            Dim opieza As PiezaDental = p.DetectaPiezaDentalObj(e.Location)
            If Not opieza Is Nothing Then
                piezaseleccionada = opieza
                Exit For
            End If
        Next
        If piezaseleccionada Is Nothing Then Exit Sub
        If Array.IndexOf(lpiezasseleccionadas.ToArray(), piezaseleccionada.NumPieza) = -1 Then Exit Sub

        Dim objp As int_mov_interno_odontograma_nts_det = (From b In Odonto_nts.int_mov_interno_odontograma_nts_det Where b.odonto_p1 = piezaseleccionada.NumPieza And b.nts_item = CType(cbohallazgos.SelectedItem, gen_mae_odontograma_nts_items).nts_item And b.nts_item_pinta = "M" And b._flg_eli = False Select b).First()

        Select Case e.Button
            Case MouseButtons.Left
                Dim lp As List(Of Point) = IIf(objp.nts_item_lienzo Is Nothing, New List(Of Point), Jsondeserializa(objp.nts_item_lienzo))
                'If Not lp Is Nothing Then
                lp.Add(mouseDownLocation)
                objp.nts_item_lienzo = Jsonserializa(lp)
                'Select Case objp.nts_item
                '    Case 16, 35

                '        'If CType(cbohallazgos.SelectedItem, gen_mae_odontograma_nts_items).nts_item = op.nts_item Then
                '        '    lpiezasseleccionadas.Add(op.odonto_p1)
                '        'End If

                '    Case 10, 36, 37, 38
                '        If lp.Count Mod 2 = 0 Then

                '        End If
                'End Select

            Case MouseButtons.Right
                Dim lp As List(Of Point) = IIf(objp.nts_item_lienzo Is Nothing, New List(Of Point), Jsondeserializa(objp.nts_item_lienzo))

                Select Case objp.nts_item
                    Case 16, 35
                        If lp.Count > 0 Then
                            lp.RemoveAt(lp.Count - 1)
                        End If
                    Case 10, 36, 37, 38
                        If lp.Count > 0 Then
                            lp.RemoveAt(lp.Count - 1)
                        End If
                        If lp.Count > 0 Then
                            lp.RemoveAt(lp.Count - 1)
                        End If
                End Select

                objp.nts_item_lienzo = Jsonserializa(lp)
        End Select
        PanelOdonto.Invalidate()
        ' Invalidate(piezaseleccionada.RectPiezaDental())
        'Invalidate(ppd.RectPartePiezaDental(dec))
        'PanelOdonto.Focus()



    End Sub

    Private Sub PanelOdonto_MouseEnter(sender As Object, e As EventArgs) Handles PanelOdonto.MouseEnter
        Select Case CType(cbohallazgos.SelectedItem, gen_mae_odontograma_nts_items).nts_item
            Case 16, 35
                PanelOdonto.Cursor = Cursors.Cross
            Case 10, 36, 37, 38
                PanelOdonto.Cursor = Cursors.Cross
            Case Else
                PanelOdonto.Cursor = Cursor.Current
        End Select
    End Sub

    Private Sub PanelOdonto_MouseLeave(sender As Object, e As EventArgs) Handles PanelOdonto.MouseLeave
        PanelOdonto.Cursor = Cursor.Current
    End Sub

    Private Sub cbohallazgos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbohallazgos.SelectedIndexChanged
        lpiezasseleccionadas.Clear()
        If Odonto_nts Is Nothing Then Exit Sub
        If (From p In Odonto_nts.int_mov_interno_odontograma_nts_det Where p.nts_item = CType(cbohallazgos.SelectedItem, gen_mae_odontograma_nts_items).nts_item And p.nts_item_pinta = "M" And p._flg_eli = False Select p).Count > 0 Then
            Dim lor = From p In Odonto_nts.int_mov_interno_odontograma_nts_det Where p.nts_item = CType(cbohallazgos.SelectedItem, gen_mae_odontograma_nts_items).nts_item And p.nts_item_pinta = "M" And p._flg_eli = False Select p
            For Each op As int_mov_interno_odontograma_nts_det In lor
                lpiezasseleccionadas.Add(op.odonto_p1)
            Next
        End If
        'PanelOdonto.Focus()
        'PanelOdonto.Invalidate()
    End Sub

    Private Sub tsbeliminar_Click(sender As Object, e As EventArgs) Handles tsbeliminar.Click
        If MessageBox.Show("Esta seguro de eliminar el Odontograma " + CodOdontograma.ToString + "?", "Mensaje a Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbNo Then Exit Sub
        Odonto_nts._flg_eli = True
        Odonto_nts._usu_eli = Legolas.Configuration.Usuario.Codigo
        Odonto_nts._fec_eli = Legolas.Configuration.Aplication.FechayHora.FechaLong
        If Legolas.LBusiness.Globall.WinApp.LicenciaApp = "1" Then
            Odonto_nts._sed_flg_trf = 1
        Else
            Odonto_nts._flg_trf = 1
        End If
        For Each oo As int_mov_interno_odontograma_nts_det In Odonto_nts.int_mov_interno_odontograma_nts_det
            oo._flg_eli = True
            oo._usu_eli = Legolas.Configuration.Usuario.Codigo
            oo._fec_eli = Legolas.Configuration.Aplication.FechayHora.FechaLong
            If Legolas.LBusiness.Globall.WinApp.LicenciaApp = "1" Then
                oo._sed_flg_trf = 1
            Else
                oo._flg_trf = 1
            End If
        Next
        Try
            db.SubmitChanges()
            MessageBox.Show("El Odontograma se eleminó correctamente", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsbborrar.Click
        If MessageBox.Show("Esta seguro de eliminar todos los hallazgos del Odontograma " + CodOdontograma.ToString + "?. Una vez realizada esta operación ya no se podrá revertir. Desea Continuar?", "Mensaje a Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbNo Then Exit Sub
        Dim ntot As Integer = Odonto_nts.int_mov_interno_odontograma_nts_det.Count
        'For Each ob As int_mov_interno_odontograma_nts_det In Odonto_nts.int_mov_interno_odontograma_nts_det
        '    db.int_mov_interno_odontograma_nts_det.DeleteOnSubmit(ob)
        '    'Odonto_nts.int_mov_interno_odontograma_nts_det.RemoveAt(0)
        'Next
        For Each ob As int_mov_interno_odontograma_nts_det In Odonto_nts.int_mov_interno_odontograma_nts_det
            'db.int_mov_interno_odontograma_nts_det.DeleteOnSubmit(ob)
            'Odonto_nts.int_mov_interno_odontograma_nts_det.RemoveAt(0)
            ob._flg_eli = True
            ob._usu_eli = Legolas.Configuration.Usuario.Codigo
            ob._fec_eli = Legolas.Configuration.Aplication.FechayHora.FechaLong
            If Legolas.LBusiness.Globall.WinApp.LicenciaApp = "1" Then
                ob._sed_flg_trf = 1
            Else
                ob._flg_trf = 1
            End If
        Next

        Try
            db.SubmitChanges()
            MessageBox.Show("Los hallazgos se eliminaron con éxito", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PanelOdonto.Focus()
            PanelOdonto.Invalidate()
            guarda_imagen()
            db.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnfind_Click(sender As Object, e As EventArgs) Handles btnfind.Click
        Dim ofind As FrmFindOdontograma = New FrmFindOdontograma
        ofind.CodInterno = Me.InternoId
        ofind.ShowDialog()
        If Not ofind.Valorretorno Is Nothing Then
            Dim oresult As int_mov_interno_odontograma_nts = CType(ofind.Valorretorno, int_mov_interno_odontograma_nts)
            'txtnumodonto.Text = oresult.pk_odonto_id.ToString
            'CodOdontograma = oresult.pk_odonto_id
            txtnumodonto.Text = oresult.pk_odonto_id
            CodOdontograma = oresult.pk_odonto_id

            Me.Odonto_nts = (From p In db.int_mov_interno_odontograma_nts
                             Where p.fk_int_id = Me.InternoId And p.pk_odonto_id = CodOdontograma And p._flg_eli = False Order By p.odonto_fecha Descending Select p).Single

            PenalId = Odonto_nts._PenId
            RegionId = Odonto_nts._RegId
            CodIngreso = Odonto_nts.fk_int_ing_id
            CodIngresoInpe = Odonto_nts.fk_ing_inp_id

            dtpfecha.Value = Odonto_nts.odonto_fecha
            txtespecificaciones.Text = Odonto_nts.odonto_especificaciones
            txtobservaciones.Text = Odonto_nts.odonto_observaciones
            'If Not Odonto_nts.odonto_imagen Is Nothing Then
            '    PictureBox1.Image = byteArrayToImage(Odonto_nts.odonto_imagen.ToArray)
            'End If
            Habilita_controles(False)
            PanelOdonto.Focus()
            PanelOdonto.Invalidate()
            'Carga_entorno()
        End If
    End Sub

    Private Sub txtespecificaciones_TextChanged(sender As Object, e As EventArgs) Handles txtespecificaciones.TextChanged
        txtnumcespe.Text = txtespecificaciones.Text.Length
        If txtnumcespe.Text > 100 Then
            MessageBox.Show("Ha alcanzado el máximo de caracteres permitidos", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtespecificaciones.Text = txtespecificaciones.Text.Substring(0, 100)
            txtespecificaciones.Focus()
        End If

    End Sub

    Private Sub txtobservaciones_TextChanged(sender As Object, e As EventArgs) Handles txtobservaciones.TextChanged
        txtnumcobs.Text = txtobservaciones.Text.Length
        If txtnumcobs.Text > 100 Then
            MessageBox.Show("Ha alcanzado el máximo de caracteres permitidos", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtobservaciones.Text = txtobservaciones.Text.Substring(0, 100)
            txtobservaciones.Focus()
        End If
    End Sub
End Class