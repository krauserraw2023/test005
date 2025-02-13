Imports System.Linq
Imports System.Data.Linq
Imports System.Reflection
Imports DataClass
Imports Newtonsoft.Json
Imports PiezaDental
Imports Legolas.APPUIComponents
Imports Bussines.Registro.Reporte
Imports System.Threading.Tasks
Imports System.Timers
Imports MiOdontograma
Imports APPWebService.ws_pope_sede_monitoreo

Public Class Frmingreso
    Private mostrar As Boolean = False

    Private _NumPiezaIni As Integer = -1
    Private _NumPiezaFin As Integer = -1
    Dim f1 As Integer() = {18, 17, 16, 15, 14, 13, 12, 11, 21, 22, 23, 24, 25, 26, 27, 28}
    Dim f2 As Integer() = {48, 47, 46, 45, 44, 43, 42, 41, 31, 32, 33, 34, 35, 36, 37, 38}
    Dim f1chk As List(Of CheckBox) = New List(Of CheckBox)
    Dim f2chk As List(Of CheckBox) = New List(Of CheckBox)
    Private _item_nts As DataClass.gen_mae_odontograma_nts_items
    'Private _items_det As List(Of int_mov_interno_odontograma_nts_det) = New List(Of int_mov_interno_odontograma_nts_det)
    Private scolor As String
    Private _pk_odontoId As Integer
    Private _db As DataClass.DataContextDataContext
    Private _nts_det As EntitySet(Of int_mov_interno_odontograma_nts_det)
    Private _odonto As int_mov_interno_odontograma_nts
    Private _swregistro As Boolean = False
    Public Property SwRegistro As Boolean
        Get
            SwRegistro = _swregistro
        End Get
        Set(value As Boolean)
            _swregistro = value
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
    Private _frm As frmodontograma
    Public Property OForm As frmodontograma
        Get
            OForm = _frm
        End Get
        Set(value As frmodontograma)
            _frm = value
        End Set
    End Property
    Public Property Nts_det As EntitySet(Of int_mov_interno_odontograma_nts_det)
        Get
            Nts_det = _nts_det
        End Get
        Set(value As EntitySet(Of int_mov_interno_odontograma_nts_det))
            _nts_det = value
        End Set
    End Property
    Public Property db As DataClass.DataContextDataContext
        Get
            db = _db
        End Get
        Set(value As DataClass.DataContextDataContext)
            _db = value
        End Set
    End Property
    Public Property OdontoId As Integer
        Get
            OdontoId = _pk_odontoId
        End Get
        Set(value As Integer)
            _pk_odontoId = value
        End Set
    End Property
    'Public Property Items_det As List(Of int_mov_interno_odontograma_nts_det)
    '    Get
    '        Items_det = _items_det
    '    End Get
    '    Set(value As List(Of int_mov_interno_odontograma_nts_det))
    '        _items_det = value
    '    End Set
    'End Property
    Public Property Item_nts As gen_mae_odontograma_nts_items
        Get
            Item_nts = _item_nts
        End Get
        Set(value As gen_mae_odontograma_nts_items)
            _item_nts = value
        End Set
    End Property

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        SwRegistro = False
        Me.Close()
    End Sub
    Private Sub Carga_array_chk()
        Dim loc As List(Of Object) = (From p In Me.Controls Where TypeOf (p) Is CheckBox Select p).ToList
        Dim lcpb As List(Of Object) = (From n In Me.Controls Where TypeOf (n) Is PictureBox Select n).ToList
        For Each it As CheckBox In loc
            Dim oname = CType(it, CheckBox).Name
            If (From n In lcpb Where CType(n, PictureBox).Name = "Pb" + oname.Substring(oname.Length - 2, 2) Select n).Count > 0 Then
                Dim lpb = (From n In lcpb Where CType(n, PictureBox).Name = "Pb" + oname.Substring(oname.Length - 2, 2) Select n).First
                CType(it, CheckBox).Tag = lpb
            End If
        Next

        f1chk.Add(chk18)
        f1chk.Add(chk17)
        f1chk.Add(chk16)
        f1chk.Add(chk15)
        f1chk.Add(chk14)
        f1chk.Add(chk13)
        f1chk.Add(chk12)
        f1chk.Add(chk11)
        f1chk.Add(chk21)
        f1chk.Add(chk22)
        f1chk.Add(chk23)
        f1chk.Add(chk24)
        f1chk.Add(chk25)
        f1chk.Add(chk26)
        f1chk.Add(chk27)
        f1chk.Add(chk28)

        f2chk.Add(chk48)
        f2chk.Add(chk47)
        f2chk.Add(chk46)
        f2chk.Add(chk45)
        f2chk.Add(chk44)
        f2chk.Add(chk43)
        f2chk.Add(chk42)
        f2chk.Add(chk41)
        f2chk.Add(chk31)
        f2chk.Add(chk32)
        f2chk.Add(chk33)
        f2chk.Add(chk34)
        f2chk.Add(chk35)
        f2chk.Add(chk36)
        f2chk.Add(chk37)
        f2chk.Add(chk38)
    End Sub
    Private Sub Oculta_cbos()
        For Each oControl As Control In Me.Controls
            If TypeOf (oControl) Is ComboBox Then
                If CType(oControl, System.Windows.Forms.ComboBox).Name.ToUpper <> "CBOESTADO" Then
                    CType(oControl, System.Windows.Forms.ComboBox).Visible = False
                End If
            End If
        Next
    End Sub
    Private Sub Pinta_Hallazgos_new()
        Dim f1i1, f1i2, f2i1, f2i2 As Integer
        Dim litems = (From p In Odonto_nts.int_mov_interno_odontograma_nts_det Where p.nts_item = Item_nts.nts_item And p._flg_eli = False Select p).ToList
        For Each ot As int_mov_interno_odontograma_nts_det In litems
            f1i1 = f1chk.FindIndex(Function(f)
                                       Return (f.Name.ToUpper() = "CHK" + ot.odonto_p1.Trim)
                                   End Function)
            f1i2 = f1chk.FindIndex(Function(f)
                                       Return (f.Name.ToUpper() = "CHK" + ot.odonto_p2.Trim)
                                   End Function)

            If f1i1 = -1 And f1i2 = -1 Then
                f2i1 = f2chk.FindIndex(Function(f)
                                           Return (f.Name.ToUpper() = "CHK" + ot.odonto_p1.Trim)
                                       End Function)
                f2i2 = f2chk.FindIndex(Function(f)
                                           Return (f.Name.ToUpper() = "CHK" + ot.odonto_p2.Trim)
                                       End Function)
                If f2i1 = -1 And f2i2 = -1 Then Exit Sub
                If Item_nts.nts_item_aplica = "M" Or Item_nts.nts_item_aplica = "T" Then
                    Dim ochk As CheckBox = f2chk(f2i1)
                    ochk.Checked = True
                    If Not ochk.Tag Is Nothing Then
                        CType(ochk.Tag, PictureBox).BackColor = IIf(ot.nts_item_color = "A", Color.Blue, Color.Red)
                    End If
                    Dim ochk2 As CheckBox = f2chk(f2i2)
                    ochk2.Checked = True
                    If Not ochk2.Tag Is Nothing Then
                        CType(ochk2.Tag, PictureBox).BackColor = IIf(ot.nts_item_color = "A", Color.Blue, Color.Red)
                    End If

                    For i As Integer = f2i1 + 1 To f2i2 - 1
                        Dim ochkp As CheckBox = f2chk(i)
                        ochkp.Enabled = False
                        If Not ochkp.Tag Is Nothing Then
                            CType(ochkp.Tag, PictureBox).BackColor = IIf(ot.nts_item_color = "A", Color.Blue, Color.Red)
                        End If
                    Next
                Else
                    Dim ochk As CheckBox = f2chk(f2i1)
                    ochk.Checked = True
                    If Not ochk.Tag Is Nothing Then
                        CType(ochk.Tag, PictureBox).BackColor = IIf(ot.nts_item_color = "A", Color.Blue, Color.Red)
                    End If
                    Dim ochk2 As CheckBox = f2chk(f2i2)
                    ochk2.Checked = True
                    If Not ochk2.Tag Is Nothing Then
                        CType(ochk2.Tag, PictureBox).BackColor = IIf(ot.nts_item_color = "A", Color.Blue, Color.Red)
                    End If
                End If
            Else
                If Item_nts.nts_item_aplica = "M" Or Item_nts.nts_item_aplica = "T" Then
                    Dim ochk As CheckBox = f1chk(f1i1)
                    ochk.Checked = True
                    If Not ochk.Tag Is Nothing Then
                        CType(ochk.Tag, PictureBox).BackColor = IIf(ot.nts_item_color = "A", Color.Blue, Color.Red)
                    End If

                    Dim ochk2 As CheckBox = f1chk(f1i2)
                    ochk2.Checked = True
                    If Not ochk2.Tag Is Nothing Then
                        CType(ochk2.Tag, PictureBox).BackColor = IIf(ot.nts_item_color = "A", Color.Blue, Color.Red)
                    End If
                    For i As Integer = f1i1 + 1 To f1i2 - 1
                        Dim ochkp As CheckBox = f1chk(i)
                        ochkp.Enabled = False
                        If Not ochkp.Tag Is Nothing Then
                            CType(ochkp.Tag, PictureBox).BackColor = IIf(ot.nts_item_color = "A", Color.Blue, Color.Red)
                        End If
                    Next
                Else
                    Dim ochk As CheckBox = f1chk(f1i1)
                    ochk.Checked = True
                    If Not ochk.Tag Is Nothing Then
                        CType(ochk.Tag, PictureBox).BackColor = IIf(ot.nts_item_color = "A", Color.Blue, Color.Red)
                    End If

                    Dim ochk2 As CheckBox = f1chk(f1i2)
                    ochk2.Checked = True
                    If Not ochk2.Tag Is Nothing Then
                        CType(ochk2.Tag, PictureBox).BackColor = IIf(ot.nts_item_color = "A", Color.Blue, Color.Red)
                    End If
                End If
            End If
        Next

        Exit Sub
        'Dim loc = From p In Me.Controls Where TypeOf (p) Is CheckBox Select p
        'Dim lcbo = From n In Me.Controls Where TypeOf (n) Is ComboBox Select n
        'For Each ot In Me.Items_det
        '    Dim lchk = (From n In loc Where CType(n, CheckBox).Name.Contains(ot.odonto_p1) Select n).First
        '    If Not lchk Is Nothing Then
        '        CType(lchk, CheckBox).Checked = True
        '        If ot.nts_item_tipo.Contains("E") Then
        '            Dim cbo = (From n In lcbo Where CType(n, ComboBox).Name.Contains(ot.odonto_p1) Select n).First
        '            CType(cbo, ComboBox).Items.Clear()
        '            For Each iit In Item_nts.gen_mae_odontograma_nts_items_valores
        '                CType(cbo, ComboBox).Items.Add(iit.nts_valor_abrev)
        '            Next
        '            CType(cbo, ComboBox).SelectedItem = ot.nts_valor_abrev
        '            CType(cbo, ComboBox).Visible = True

        '        End If
        '        If Not CType(lchk, CheckBox).Tag Is Nothing Then
        '            CType(CType(lchk, CheckBox).Tag, PictureBox).BackColor = IIf(ot.nts_item_color = "A", Color.Blue, Color.Red)
        '        End If
        '    End If
        '    If Item_nts.nts_item_aplica = "M" Or Item_nts.nts_item_aplica <> "1" Then
        '        Dim lchk2 = (From n In loc Where CType(n, CheckBox).Name.Contains(ot.odonto_p2) Select n).First
        '        If Not lchk2 Is Nothing Then
        '            CType(lchk2, CheckBox).Checked = True
        '            If Not CType(lchk2, CheckBox).Tag Is Nothing Then
        '                CType(CType(lchk2, CheckBox).Tag, PictureBox).BackColor = IIf(ot.nts_item_color = "A", Color.Blue, Color.Red)
        '            End If
        '        End If
        '    End If

        'Next
    End Sub
    'Private Sub Pinta_Hallazgos()

    '    Dim loc = From p In Me.Controls Where TypeOf (p) Is CheckBox Select p
    '    Dim lcbo = From n In Me.Controls Where TypeOf (n) Is ComboBox Select n
    '    For Each ot In Me.Items_det
    '        Dim lchk = (From n In loc Where CType(n, CheckBox).Name.Contains(ot.odonto_p1) Select n).First
    '        If Not lchk Is Nothing Then
    '            CType(lchk, CheckBox).Checked = True
    '            If ot.nts_item_tipo.Contains("E") Then
    '                Dim cbo = (From n In lcbo Where CType(n, ComboBox).Name.Contains(ot.odonto_p1) Select n).First
    '                CType(cbo, ComboBox).Items.Clear()
    '                For Each iit In Item_nts.gen_mae_odontograma_nts_items_valores
    '                    CType(cbo, ComboBox).Items.Add(iit.nts_valor_abrev)
    '                Next
    '                CType(cbo, ComboBox).SelectedItem = ot.nts_valor_abrev
    '                CType(cbo, ComboBox).Visible = True

    '            End If
    '            If Not CType(lchk, CheckBox).Tag Is Nothing Then
    '                CType(CType(lchk, CheckBox).Tag, PictureBox).BackColor = IIf(ot.nts_item_color = "A", Color.Blue, Color.Red)
    '            End If
    '        End If
    '        If Item_nts.nts_item_aplica = "M" Or Item_nts.nts_item_aplica <> "1" Then
    '            Dim lchk2 = (From n In loc Where CType(n, CheckBox).Name.Contains(ot.odonto_p2) Select n).First
    '            If Not lchk2 Is Nothing Then
    '                CType(lchk2, CheckBox).Checked = True
    '                If Not CType(lchk2, CheckBox).Tag Is Nothing Then
    '                    CType(CType(lchk2, CheckBox).Tag, PictureBox).BackColor = IIf(ot.nts_item_color = "A", Color.Blue, Color.Red)
    '                End If
    '            End If
    '        End If

    '    Next
    'End Sub
    Private Sub Frmingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txthallazgo.Text = Item_nts.nts_item_desc
        Carga_array_chk()
        If Item_nts.nts_item_color = "S" Then
            Lblestado.Visible = True
            cboestado.Visible = True
        Else
            Lblestado.Visible = False
            cboestado.Visible = False
            scolor = Item_nts.nts_item_color
        End If
        cboestado.DropDownStyle = ComboBoxStyle.DropDownList
        cboestado.Items.Add("Bueno")
        cboestado.Items.Add("Malo")
        cboestado.SelectedIndex = 0
        If Item_nts.nts_item_color = "S" Then
            scolor = IIf(CType(cboestado.SelectedItem, String) = "Bueno", "A", "R")
        Else
            scolor = Item_nts.nts_item_color
        End If

        Oculta_cbos()
        muestra_lables()
        Muestra_leyenda()
        Pinta_Hallazgos_new()
        ' Pinta_Hallazgos()

    End Sub
    Private Sub Muestra_leyenda()
        lstleyenda.Items.Clear()
        If Item_nts.nts_item_tipo.Contains("E") Or Item_nts.nts_item_tipo.Contains("I") Then
            For Each ee As gen_mae_odontograma_nts_items_valores In Item_nts.gen_mae_odontograma_nts_items_valores
                lstleyenda.Items.Add(ee.nts_valor_abrev + " - " + ee.nts_valor_desc)
            Next
            PanelLeyenda.Visible = True
        Else
            PanelLeyenda.Visible = False
        End If

    End Sub
    Private Sub muestra_lables()
        For Each ctrl As Control In Me.Controls
            If TypeOf (ctrl) Is Label Then
                Dim valor As String = CType(ctrl, Label).Name
                If CType(ctrl, Label).Name.ToUpper <> "LBLESTADO" Then
                    CType(ctrl, Label).Text = valor.Substring(valor.Length - 2, 2)
                End If

            End If
        Next
    End Sub
    Private Sub Pinta_PiezasD(estado As Boolean, chk As CheckBox)
        If Item_nts.nts_item_aplica = "T" Or Item_nts.nts_item_aplica = "M" Then
            Dim nd1 = f1chk.FindIndex(Function(f)
                                          Return (f.Name.ToUpper() = chk.Name.Trim.ToUpper)
                                      End Function)
            If nd1 = -1 Then
                Dim nd2 = f2chk.FindIndex(Function(f)
                                              Return (f.Name.ToUpper() = chk.Name.Trim.ToUpper)
                                          End Function)
                If nd2 = -1 Then Exit Sub
                Dim nd21 As Integer = 100
                For i As Integer = nd2 - 1 To 0 Step -1
                    If f2chk(i).Checked = True Then
                        nd21 = i
                        Exit For
                    End If
                    'f2chk(i).Checked = estado
                Next
                For m As Integer = nd21 + 1 To nd2 - 1
                    f2chk(m).Enabled = Not estado
                    Dim pb As PictureBox = CType(f2chk(m).Tag, PictureBox)
                    If Not pb Is Nothing Then
                        If estado = True Then
                            'pb.Padding = New Padding(1)
                            'pb.BorderStyle = BorderStyle.FixedSingle
                            pb.BackColor = IIf(scolor = "A", Color.Blue, Color.Red)
                        Else
                            'pb.Padding = Nothing
                            'pb.BorderStyle = BorderStyle.None
                            pb.BackColor = Color.Transparent
                        End If
                    End If
                Next
            Else
                Dim nd11 As Integer = 100
                For i As Integer = nd1 - 1 To 0 Step -1
                    If f1chk(i).Checked = True Then
                        nd11 = i
                        Exit For
                    End If
                Next
                For i As Integer = nd11 + 1 To nd1 - 1
                    f1chk(i).Enabled = Not estado
                    Dim pb As PictureBox = CType(f1chk(i).Tag, PictureBox)
                    If Not pb Is Nothing Then
                        If estado = True Then
                            pb.BackColor = IIf(scolor = "A", Color.Blue, Color.Red)
                        Else
                            pb.BackColor = Color.Transparent
                        End If
                    End If
                Next

            End If

        End If
    End Sub
    Private Sub chk18_CheckedChanged(sender As Object, e As EventArgs) Handles chk18.CheckedChanged, chk17.CheckedChanged, chk16.CheckedChanged, chk15.CheckedChanged, chk14.CheckedChanged, chk13.CheckedChanged, chk12.CheckedChanged, chk11.CheckedChanged, chk21.CheckedChanged, chk22.CheckedChanged, chk23.CheckedChanged, chk24.CheckedChanged, chk25.CheckedChanged, chk26.CheckedChanged, chk27.CheckedChanged, chk28.CheckedChanged, chk48.CheckedChanged, chk47.CheckedChanged, chk46.CheckedChanged, chk45.CheckedChanged, chk44.CheckedChanged, chk43.CheckedChanged, chk42.CheckedChanged, chk41.CheckedChanged, chk31.CheckedChanged, chk32.CheckedChanged, chk33.CheckedChanged, chk34.CheckedChanged, chk35.CheckedChanged, chk36.CheckedChanged, chk37.CheckedChanged, chk38.CheckedChanged

        Dim oname As String = CType(sender, CheckBox).Name
        Dim loc As List(Of Object) = (From p In Me.Controls Where TypeOf (p) Is PictureBox Select p).ToList
        Dim lpb = (From n In loc Where CType(n, PictureBox).Name = "Pb" + oname.Substring(oname.Length - 2, 2) Select n).First
        Dim lcbo As List(Of Object) = (From n In Me.Controls Where TypeOf (n) Is ComboBox Select n).ToList
        Dim cbo = (From m In lcbo Where CType(m, ComboBox).Name.Contains(oname.Substring(oname.Length - 2, 2)) Select m).First
        If CType(sender, CheckBox).Checked Then
            'CType(sender, CheckBox).Tag = lpb
            'CType(lpb, PictureBox).Padding = New Padding(1)
            'CType(lpb, PictureBox).BorderStyle = BorderStyle.FixedSingle
            CType(lpb, PictureBox).BackColor = IIf(scolor = "A", Color.Blue, Color.Red)
            If Item_nts.nts_item_tipo.Contains("E") Or Item_nts.nts_item_tipo.Contains("I") Then
                Dim mcbo As ComboBox = CType(cbo, ComboBox)
                'CType(cbo, ComboBox).Items.Clear()
                mcbo.Items.Clear()
                For Each iit As gen_mae_odontograma_nts_items_valores In Item_nts.gen_mae_odontograma_nts_items_valores
                    CType(cbo, ComboBox).Items.Add(iit.nts_valor_abrev)
                    'CType(cbo, ComboBox).Items.Add(iit.nts_valor_abrev + " - " + iit.nts_valor_desc)
                    'CType(cbo, ComboBox).Items.Add(iit)
                    'mcbo.Items.Add(iit)
                Next

                CType(cbo, ComboBox).SelectedIndex = 0
                CType(cbo, ComboBox).Visible = True
            End If
        Else
            If CType(sender, CheckBox).Enabled Then
                'CType(sender, CheckBox).Tag = lpb
                'CType(lpb, PictureBox).Padding = Nothing
                'CType(lpb, PictureBox).BorderStyle = BorderStyle.None
                CType(lpb, PictureBox).BackColor = Color.Transparent
                CType(cbo, ComboBox).Visible = False
            End If
        End If


        'And CType(p, PictureBox).Name = "Pb" + oname.Substring(oname.Length - 2, 2)
        'MessageBox.Show(CType(lpb, PictureBox).Name)

        'Dim oname As String = CType(sender, CheckBox).Name
        'Dim cboname As String = "cbo" + oname.Substring(oname.Length - 2, 2)
        'Dim cbo As ComboBox = CType(GivemeControl(cboname), ComboBox)
        'If Not cbo Is Nothing Then
        '    cbo.Visible = CType(sender, CheckBox).Checked And mostrar
        'End If

    End Sub
    Private Sub Pinta_PictureBox(pb As PictureBox, scolor As String, g As Graphics)
        'Dim rec As RectangleF = New RectangleF(pb.p)
    End Sub
    Private Function GivemeControl(nameC As String) As Control

        For Each ctrl As Control In Me.Controls
            If TypeOf (ctrl) Is ComboBox Then
                If CType(ctrl, ComboBox).Name = nameC Then
                    Return ctrl

                End If
            End If
        Next
        Return Nothing

    End Function
    Private Function GiveControl(nameC As String) As Control

        Dim t As System.Type = Me.GetType()
        Dim fi As FieldInfo = t.GetField(nameC.ToLower, BindingFlags.NonPublic Or BindingFlags.Public Or BindingFlags.Instance)
        ' comprobar aquí si fi es null, que significa que no existe un control con ese nombre
        Dim c As Control = CType(fi.GetValue(Me), Control)
        'c contiene ahora el control deseado.
        Return c
    End Function

    Private Sub chkf1_CheckedChanged(sender As Object, e As EventArgs) Handles chkf1.CheckedChanged
        'For Each chk In f1chk
        '    chk.Checked = chkf1.Checked
        'Next
        chk18.Checked = CType(sender, CheckBox).Checked
        chk28.Checked = CType(sender, CheckBox).Checked
        Pinta_PiezasD(CType(sender, CheckBox).Checked, chk28)

    End Sub

    Private Sub chkf2_CheckedChanged(sender As Object, e As EventArgs) Handles chkf2.CheckedChanged
        'For Each chk In f2chk
        '    chk.Checked = chkf2.Checked
        'Next
        chk38.Checked = CType(sender, CheckBox).Checked
        chk48.Checked = CType(sender, CheckBox).Checked
        Pinta_PiezasD(CType(sender, CheckBox).Checked, chk38)
    End Sub

    Private Sub Picturebox_MouseMove(sender As Object, e As MouseEventArgs) Handles Pb18.MouseMove, Pb17.MouseMove, Pb16.MouseMove, Pb15.MouseMove, Pb14.MouseMove, Pb13.MouseMove, Pb12.MouseMove, Pb11.MouseMove, Pb21.MouseMove, Pb22.MouseMove, Pb23.MouseMove, Pb24.MouseMove, Pb25.MouseMove, Pb26.MouseMove, Pb27.MouseMove, Pb28.MouseMove, Pb38.MouseMove, Pb37.MouseMove, Pb36.MouseMove, Pb35.MouseMove, Pb34.MouseMove, Pb32.MouseMove, Pb31.MouseMove, Pb41.MouseMove, Pb42.MouseMove, Pb43.MouseMove, Pb44.MouseMove, Pb45.MouseMove, Pb46.MouseMove, Pb47.MouseMove, Pb48.MouseMove

        'If TypeOf (sender) Is PictureBox Then
        '    CType(sender, PictureBox).BackColor = Color.Yellow
        'End If
        'Pb18.BackColor = Color.Yellow
    End Sub
    Private Sub Picturebox_MouseLeave(sender As Object, e As EventArgs) Handles Pb18.MouseLeave, Pb17.MouseLeave, Pb16.MouseLeave, Pb15.MouseLeave, Pb14.MouseLeave, Pb13.MouseLeave, Pb12.MouseLeave, Pb11.MouseLeave, Pb21.MouseLeave, Pb22.MouseLeave, Pb23.MouseLeave, Pb24.MouseLeave, Pb25.MouseLeave, Pb26.MouseLeave, Pb27.MouseLeave, Pb28.MouseLeave, Pb38.MouseLeave, Pb37.MouseLeave, Pb36.MouseLeave, Pb35.MouseLeave, Pb34.MouseLeave, Pb33.MouseLeave, Pb32.MouseLeave, Pb31.MouseLeave, Pb41.MouseLeave, Pb42.MouseLeave, Pb43.MouseLeave, Pb44.MouseLeave, Pb45.MouseLeave, Pb46.MouseLeave, Pb47.MouseLeave, Pb48.MouseLeave
        'If TypeOf (sender) Is PictureBox Then
        '    If CType(sender, PictureBox).BackColor = Color.Yellow Then
        '        CType(sender, PictureBox).BackColor = Color.Transparent
        '    End If

        'End If
        'Pb18.BackColor = Color.Transparent
    End Sub

    Private Sub cboestado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboestado.SelectedIndexChanged
        If CType(cboestado.SelectedItem, String) = "Bueno" Then
            scolor = "A"
        Else
            scolor = "R"
        End If
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        If MessageBox.Show("Esta seguro de agregar los cambios?", "Mensaje a Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then Exit Sub

        Dim nf1 = (From p In f1chk Where p.Checked = True Select p).Count
        Dim nf2 = (From p In f2chk Where p.Checked = True Select p).Count
        If nf1 = 0 And nf2 = 0 Then
            MessageBox.Show("No hay piezas dentales seleccionadas", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim lchkf1 = From n In f1chk Where n.Checked = True Select n
        Dim lchkf2 = From n In f2chk Where n.Checked = True Select n
        Dim lcbo As List(Of Object) = (From n In Me.Controls Where TypeOf (n) Is ComboBox Select n).ToList

        Select Case Item_nts.nts_item_aplica
            Case Is = "T"
                If nf1 > 1 Or nf2 > 1 Then
                    Remover_Item_det()
                End If
                If nf1 > 0 And (f1chk(0).Checked = False Or f1chk(15).Checked = False) Then
                    MessageBox.Show("Debe seleccionar toda la fila Superior o Inferior", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    If nf1 <> 0 Then

                        Dim obj As int_mov_interno_odontograma_nts_det = New int_mov_interno_odontograma_nts_det
                        obj.odonto_id = OdontoId
                        'obj.odonto_det_id = Fnitem()
                        obj.odonto_p1 = "18"
                        obj.odonto_p2 = "28"
                        obj.nts_id = Item_nts.nts_id
                        obj.nts_item = Item_nts.nts_item
                        If Item_nts.nts_item_tipo.Contains("E") Then
                            obj.nts_valor_abrev = CType(cbo18.SelectedItem, String)
                            'Dim xloc As Integer = CType(cbo18.SelectedItem, String).IndexOf("-")
                            'obj.nts_valor_abrev = CType(cbo18.SelectedItem, String).Substring(0, xloc - 1)
                        End If
                        obj.nts_item_color = IIf(Pb18.BackColor = Color.Blue, "A", "R")
                        obj.nts_item_tipo = Item_nts.nts_item_tipo
                        obj.nts_item_pinta = Item_nts.nts_item_pinta
                        obj._usu_cre = Legolas.Configuration.Usuario.Codigo
                        obj._fec_cre = Legolas.Configuration.Aplication.FechayHora.FechaLong
                        obj._usu_mod = Legolas.Configuration.Usuario.Codigo
                        obj._fec_mod = Legolas.Configuration.Aplication.FechayHora.FechaLong
                        If Legolas.LBusiness.Globall.WinApp.LicenciaApp = "1" Then
                            obj._sed_flg_trf = 1
                        Else
                            obj._flg_trf = 1
                        End If
                        obj._flg_eli = False
                        obj._RegId = Odonto_nts._RegId
                        obj._PenId = Odonto_nts._PenId
                        Odonto_nts.int_mov_interno_odontograma_nts_det.Add(obj)
                        'db.int_mov_interno_odontograma_nts_det.InsertOnSubmit(obj)
                        'Items_det.Add(obj)
                        'Nts_det.Add(obj)

                    End If
                End If
                If nf2 > 0 And (f2chk(0).Checked = False Or f2chk(15).Checked = False) Then
                    MessageBox.Show("Debe seleccionar toda la fila Superior o Inferior", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    If nf2 <> 0 Then
                        'Remover_Item_det()
                        Dim obj As int_mov_interno_odontograma_nts_det = New int_mov_interno_odontograma_nts_det
                        obj.odonto_id = OdontoId
                        'obj.odonto_det_id = Fnitem()
                        obj.odonto_p1 = "48"
                        obj.odonto_p2 = "38"
                        obj.nts_id = Item_nts.nts_id
                        obj.nts_item = Item_nts.nts_item
                        If Item_nts.nts_item_tipo.Contains("E") Then
                            obj.nts_valor_abrev = CType(cbo38.SelectedItem, String)
                        End If
                        obj.nts_item_color = IIf(Pb38.BackColor = Color.Blue, "A", "R")
                        obj.nts_item_tipo = Item_nts.nts_item_tipo
                        obj.nts_item_pinta = Item_nts.nts_item_pinta
                        obj._usu_cre = Legolas.Configuration.Usuario.Codigo
                        obj._fec_cre = Legolas.Configuration.Aplication.FechayHora.FechaLong
                        obj._usu_mod = Legolas.Configuration.Usuario.Codigo
                        obj._fec_mod = Legolas.Configuration.Aplication.FechayHora.FechaLong
                        If Legolas.LBusiness.Globall.WinApp.LicenciaApp = "1" Then
                            obj._sed_flg_trf = 1
                        Else
                            obj._flg_trf = 1
                        End If
                        obj._flg_eli = False
                        obj._RegId = Odonto_nts._RegId
                        obj._PenId = Odonto_nts._PenId
                        Odonto_nts.int_mov_interno_odontograma_nts_det.Add(obj)
                        'db.int_mov_interno_odontograma_nts_det.InsertOnSubmit(obj)
                        'Items_det.Add(obj)
                        'Nts_det.Add(obj)
                    End If
                End If
            Case Is = "M"

                If nf1 Mod 2 <> 0 Then
                    MessageBox.Show("Debe seleccionar dos piezas dentales como mínimo en una fila.", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If nf2 Mod 2 <> 0 Then
                    MessageBox.Show("Debe seleccionar dos piezas dentales como mínimo en una fila.", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim obj As int_mov_interno_odontograma_nts_det = New int_mov_interno_odontograma_nts_det
                Dim c As Integer = 0
                Dim xid As Integer = Fnitem()
                Remover_Item_det()
                For Each chk As CheckBox In lchkf1
                    If c Mod 2 = 0 Then
                        obj = New int_mov_interno_odontograma_nts_det
                        obj.odonto_id = OdontoId
                        'obj.odonto_det_id = xid
                        obj.odonto_p1 = chk.Name.Substring(chk.Name.Length - 2, 2)
                        obj.nts_id = Item_nts.nts_id
                        obj.nts_item = Item_nts.nts_item
                        Dim xcbo = (From x In lcbo Where CType(x, ComboBox).Name.ToUpper = "CBO" + chk.Name.Substring(chk.Name.Length - 2, 2) Select x).First
                        If Item_nts.nts_item_tipo.Contains("E") Or Item_nts.nts_item_tipo.Contains("I") Then
                            obj.nts_valor_abrev = CType(xcbo.SelectedItem, String)
                        End If
                        obj.nts_item_color = IIf(CType(chk.Tag, PictureBox).BackColor = Color.Blue, "A", "R")
                        obj.nts_item_tipo = Item_nts.nts_item_tipo
                        obj.nts_item_pinta = Item_nts.nts_item_pinta
                        obj._usu_cre = Legolas.Configuration.Usuario.Codigo
                        obj._fec_cre = Legolas.Configuration.Aplication.FechayHora.FechaLong
                        obj._usu_mod = Legolas.Configuration.Usuario.Codigo
                        obj._fec_mod = Legolas.Configuration.Aplication.FechayHora.FechaLong
                        If Legolas.LBusiness.Globall.WinApp.LicenciaApp = "1" Then
                            obj._sed_flg_trf = 1
                        Else
                            obj._flg_trf = 1
                        End If
                        obj._flg_eli = False
                        obj._RegId = Odonto_nts._RegId
                        obj._PenId = Odonto_nts._PenId
                        xid = xid + 1
                    Else
                        obj.odonto_p2 = chk.Name.Substring(chk.Name.Length - 2, 2)
                        Odonto_nts.int_mov_interno_odontograma_nts_det.Add(obj)
                        'db.int_mov_interno_odontograma_nts_det.InsertOnSubmit(obj)
                    End If
                    c = c + 1
                Next
                c = 0
                For Each chk As CheckBox In lchkf2
                    If c Mod 2 = 0 Then
                        obj = New int_mov_interno_odontograma_nts_det
                        obj.odonto_id = OdontoId
                        ' obj.odonto_det_id = xid
                        obj.odonto_p1 = chk.Name.Substring(chk.Name.Length - 2, 2)
                        obj.nts_id = Item_nts.nts_id
                        obj.nts_item = Item_nts.nts_item
                        Dim xcbo = (From x In lcbo Where CType(x, ComboBox).Name.ToUpper = "CBO" + chk.Name.Substring(chk.Name.Length - 2, 2) Select x).First
                        If Item_nts.nts_item_tipo.Contains("E") Or Item_nts.nts_item_tipo.Contains("I") Then
                            obj.nts_valor_abrev = CType(xcbo.SelectedItem, String)
                        End If
                        obj.nts_item_color = IIf(CType(chk.Tag, PictureBox).BackColor = Color.Blue, "A", "R")
                        obj.nts_item_tipo = Item_nts.nts_item_tipo
                        obj.nts_item_pinta = Item_nts.nts_item_pinta
                        obj._usu_cre = Legolas.Configuration.Usuario.Codigo
                        obj._fec_cre = Legolas.Configuration.Aplication.FechayHora.FechaLong
                        obj._usu_mod = Legolas.Configuration.Usuario.Codigo
                        obj._fec_mod = Legolas.Configuration.Aplication.FechayHora.FechaLong
                        If Legolas.LBusiness.Globall.WinApp.LicenciaApp = "1" Then
                            obj._sed_flg_trf = 1
                        Else
                            obj._flg_trf = 1
                        End If
                        obj._flg_eli = False
                        obj._RegId = Odonto_nts._RegId
                        obj._PenId = Odonto_nts._PenId
                        xid = xid + 1
                    Else
                        obj.odonto_p2 = chk.Name.Substring(chk.Name.Length - 2, 2)
                        Odonto_nts.int_mov_interno_odontograma_nts_det.Add(obj)
                        'db.int_mov_interno_odontograma_nts_det.InsertOnSubmit(obj)
                    End If
                    c = c + 1
                Next

            Case Is = "2"
                If nf1 Mod 2 <> 0 Then
                    MessageBox.Show("Debe seleccionar dos piezas dentales como mínimo en una fila.", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If nf2 Mod 2 <> 0 Then
                    MessageBox.Show("Debe seleccionar dos piezas dentales como mínimo en una fila.", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim obj As int_mov_interno_odontograma_nts_det = New int_mov_interno_odontograma_nts_det
                Dim c As Integer = 0
                Dim xid As Integer = Fnitem()
                Remover_Item_det()
                For Each chk As CheckBox In lchkf1
                    If c Mod 2 = 0 Then
                        obj = New int_mov_interno_odontograma_nts_det
                        obj.odonto_id = OdontoId
                        'obj.odonto_det_id = xid
                        obj.odonto_p1 = chk.Name.Substring(chk.Name.Length - 2, 2)
                        obj.nts_id = Item_nts.nts_id
                        obj.nts_item = Item_nts.nts_item
                        Dim xcbo = (From x In lcbo Where CType(x, ComboBox).Name.ToUpper = "CBO" + chk.Name.Substring(chk.Name.Length - 2, 2) Select x).First
                        If Item_nts.nts_item_tipo.Contains("E") Or Item_nts.nts_item_tipo.Contains("I") Then
                            obj.nts_valor_abrev = CType(xcbo.SelectedItem, String)
                        End If
                        obj.nts_item_color = IIf(CType(chk.Tag, PictureBox).BackColor = Color.Blue, "A", "R")
                        obj.nts_item_tipo = Item_nts.nts_item_tipo
                        obj.nts_item_pinta = Item_nts.nts_item_pinta
                        obj._usu_cre = Legolas.Configuration.Usuario.Codigo
                        obj._fec_cre = Legolas.Configuration.Aplication.FechayHora.FechaLong
                        obj._usu_mod = Legolas.Configuration.Usuario.Codigo
                        obj._fec_mod = Legolas.Configuration.Aplication.FechayHora.FechaLong
                        If Legolas.LBusiness.Globall.WinApp.LicenciaApp = "1" Then
                            obj._sed_flg_trf = 1
                        Else
                            obj._flg_trf = 1
                        End If
                        obj._flg_eli = False
                        obj._RegId = Odonto_nts._RegId
                        obj._PenId = Odonto_nts._PenId
                        xid = xid + 1
                    Else
                        obj.odonto_p2 = chk.Name.Substring(chk.Name.Length - 2, 2)
                        Odonto_nts.int_mov_interno_odontograma_nts_det.Add(obj)
                        'db.int_mov_interno_odontograma_nts_det.InsertOnSubmit(obj)
                    End If
                    c = c + 1
                Next
                c = 0
                For Each chk As CheckBox In lchkf2
                    If c Mod 2 = 0 Then
                        obj = New int_mov_interno_odontograma_nts_det
                        obj.odonto_id = OdontoId
                        'obj.odonto_det_id = xid
                        obj.odonto_p1 = chk.Name.Substring(chk.Name.Length - 2, 2)
                        obj.nts_id = Item_nts.nts_id
                        obj.nts_item = Item_nts.nts_item
                        Dim xcbo = (From x In lcbo Where CType(x, ComboBox).Name.ToUpper = "CBO" + chk.Name.Substring(chk.Name.Length - 2, 2) Select x).First
                        If Item_nts.nts_item_tipo.Contains("E") Or Item_nts.nts_item_tipo.Contains("I") Then
                            obj.nts_valor_abrev = CType(xcbo.SelectedItem, String)
                        End If
                        obj.nts_item_color = IIf(CType(chk.Tag, PictureBox).BackColor = Color.Blue, "A", "R")
                        obj.nts_item_tipo = Item_nts.nts_item_tipo
                        obj.nts_item_pinta = Item_nts.nts_item_pinta
                        obj._usu_cre = Legolas.Configuration.Usuario.Codigo
                        obj._fec_cre = Legolas.Configuration.Aplication.FechayHora.FechaLong
                        obj._usu_mod = Legolas.Configuration.Usuario.Codigo
                        obj._fec_mod = Legolas.Configuration.Aplication.FechayHora.FechaLong
                        If Legolas.LBusiness.Globall.WinApp.LicenciaApp = "1" Then
                            obj._sed_flg_trf = 1
                        Else
                            obj._flg_trf = 1
                        End If
                        obj._flg_eli = False
                        obj._RegId = Odonto_nts._RegId
                        obj._PenId = Odonto_nts._PenId
                        xid = xid + 1
                    Else
                        obj.odonto_p2 = chk.Name.Substring(chk.Name.Length - 2, 2)
                        Odonto_nts.int_mov_interno_odontograma_nts_det.Add(obj)
                        'db.int_mov_interno_odontograma_nts_det.InsertOnSubmit(obj)
                    End If
                    c = c + 1
                Next

            Case Is = "1"
                If (Item_nts.nts_item = 28 Or Item_nts.nts_item = 6) And (chk28.Checked Or chk38.Checked) Then
                    MessageBox.Show("Selección de Pieza Dental 28 o 38 no válida para el hallazgo seleccionado", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim obj As int_mov_interno_odontograma_nts_det = New int_mov_interno_odontograma_nts_det
                Dim c As Integer = 0
                Dim xid As Integer = Fnitem()
                Remover_Item_det()
                For Each chk As CheckBox In lchkf1
                    obj = New int_mov_interno_odontograma_nts_det
                    obj.odonto_id = OdontoId
                    'obj.odonto_det_id = xid
                    obj.odonto_p1 = chk.Name.Substring(chk.Name.Length - 2, 2)
                    If Item_nts.nts_item = 28 Or Item_nts.nts_item = 6 Then
                        Dim xpos As Integer = Array.IndexOf(f1, obj.odonto_p1)
                        If xpos = -1 Then
                            obj.odonto_p2 = obj.odonto_p1
                        Else
                            obj.odonto_p2 = f1(xpos + 1)
                        End If
                    Else
                        obj.odonto_p2 = obj.odonto_p1
                    End If

                    obj.nts_id = Item_nts.nts_id
                    obj.nts_item = Item_nts.nts_item
                    Dim xcbo = (From x In lcbo Where CType(x, ComboBox).Name.ToUpper = "CBO" + chk.Name.Substring(chk.Name.Length - 2, 2) Select x).First
                    If Item_nts.nts_item_tipo.Contains("E") Or Item_nts.nts_item_tipo.Contains("I") Then
                        obj.nts_valor_abrev = CType(xcbo.SelectedItem, String)
                    End If
                    obj.nts_item_color = IIf(CType(chk.Tag, PictureBox).BackColor = Color.Blue, "A", "R")
                    obj.nts_item_tipo = Item_nts.nts_item_tipo
                    obj.nts_item_pinta = Item_nts.nts_item_pinta
                    obj._usu_cre = Legolas.Configuration.Usuario.Codigo
                    obj._fec_cre = Legolas.Configuration.Aplication.FechayHora.FechaLong
                    obj._usu_mod = Legolas.Configuration.Usuario.Codigo
                    obj._fec_mod = Legolas.Configuration.Aplication.FechayHora.FechaLong
                    If Legolas.LBusiness.Globall.WinApp.LicenciaApp = "1" Then
                        obj._sed_flg_trf = 1
                    Else
                        obj._flg_trf = 1
                    End If
                    obj._flg_eli = False
                    obj._RegId = Odonto_nts._RegId
                    obj._PenId = Odonto_nts._PenId
                    xid = xid + 1
                    Odonto_nts.int_mov_interno_odontograma_nts_det.Add(obj)
                Next
                For Each chk As CheckBox In lchkf2
                    obj = New int_mov_interno_odontograma_nts_det
                    obj.odonto_id = OdontoId
                    'obj.odonto_det_id = xid
                    obj.odonto_p1 = chk.Name.Substring(chk.Name.Length - 2, 2)
                    If Item_nts.nts_item = 28 Or Item_nts.nts_item = 6 Then
                        Dim xpos As Integer = Array.IndexOf(f2, obj.odonto_p1)
                        If xpos = -1 Then
                            obj.odonto_p2 = obj.odonto_p1
                        Else
                            obj.odonto_p2 = f2(xpos + 1)
                        End If
                    Else
                        obj.odonto_p2 = obj.odonto_p1
                    End If
                    'obj.odonto_p2 = obj.odonto_p1
                    obj.nts_id = Item_nts.nts_id
                    obj.nts_item = Item_nts.nts_item
                    Dim xcbo = (From x In lcbo Where CType(x, ComboBox).Name.ToUpper = "CBO" + chk.Name.Substring(chk.Name.Length - 2, 2) Select x).First
                    If Item_nts.nts_item_tipo.Contains("E") Or Item_nts.nts_item_tipo.Contains("I") Then
                        obj.nts_valor_abrev = CType(xcbo.SelectedItem, String)
                    End If
                    obj.nts_item_color = IIf(CType(chk.Tag, PictureBox).BackColor = Color.Blue, "A", "R")
                    obj.nts_item_tipo = Item_nts.nts_item_tipo
                    obj.nts_item_pinta = Item_nts.nts_item_pinta
                    obj._usu_cre = Legolas.Configuration.Usuario.Codigo
                    obj._fec_cre = Legolas.Configuration.Aplication.FechayHora.FechaLong
                    obj._usu_mod = Legolas.Configuration.Usuario.Codigo
                    obj._fec_mod = Legolas.Configuration.Aplication.FechayHora.FechaLong
                    If Legolas.LBusiness.Globall.WinApp.LicenciaApp = "1" Then
                        obj._sed_flg_trf = 1
                    Else
                        obj._flg_trf = 1
                    End If
                    obj._flg_eli = False
                    obj._RegId = Odonto_nts._RegId
                    obj._PenId = Odonto_nts._PenId
                    xid = xid + 1
                    Odonto_nts.int_mov_interno_odontograma_nts_det.Add(obj)
                    'db.int_mov_interno_odontograma_nts_det.InsertOnSubmit(obj)
                Next

        End Select
        'OForm.guarda_imagen()
        db.SubmitChanges()
        swregistro = True
        Carga_piezas_seleccionadas()
        Me.Close()
    End Sub
    Private Sub Carga_piezas_seleccionadas()
        If (From c In Odonto_nts.int_mov_interno_odontograma_nts_det Where c.nts_item_pinta = "M" And c.nts_item = Item_nts.nts_item And c._flg_eli = False Select c).Count > 0 Then
            Dim osele = From c In Odonto_nts.int_mov_interno_odontograma_nts_det Where c.nts_item_pinta = "M" And c.nts_item = Item_nts.nts_item And c._flg_eli = False Select c

            For Each y As int_mov_interno_odontograma_nts_det In osele
                lpiezasseleccionadas.Add(y.odonto_p1)
            Next

        End If
    End Sub
    Private Sub Remover_Item_det()
        Dim litems = (From p In Odonto_nts.int_mov_interno_odontograma_nts_det Where p.nts_item = Item_nts.nts_item Select p).ToList

        'For Each ii As int_mov_interno_odontograma_nts_det In litems
        '    'Nts_det.Remove(ii)
        '    'Odonto_nts.int_mov_interno_odontograma_nts_det.Remove(ii)
        '    db.int_mov_interno_odontograma_nts_det.DeleteOnSubmit(ii)
        'Next
        For Each ob As int_mov_interno_odontograma_nts_det In litems
            ob._flg_eli = True
            ob._usu_eli = Legolas.Configuration.Usuario.Codigo
            ob._fec_eli = Legolas.Configuration.Aplication.FechayHora.FechaLong
            If Legolas.LBusiness.Globall.WinApp.LicenciaApp = "1" Then
                ob._sed_flg_trf = 1
            Else
                ob._flg_trf = 1
            End If
            'Nts_det.Remove(ii)
            'Odonto_nts.int_mov_interno_odontograma_nts_det.Remove(ii)
            'db.int_mov_interno_odontograma_nts_det.DeleteOnSubmit(ii)
        Next
        db.SubmitChanges()
        'Items_det.Clear()
        'Dim n As Integer = Items_det.Count
        'For i = 1 To n
        '    Items_det.RemoveAt(0)
        'Next
    End Sub
    Private Sub chk18_Click(sender As Object, e As EventArgs) Handles chk18.Click, chk17.Click, chk16.Click, chk15.Click, chk14.Click, chk13.Click, chk12.Click, chk11.Click, chk28.Click, chk27.Click, chk26.Click, chk25.Click, chk24.Click, chk23.Click, chk22.Click, chk21.Click, chk48.Click, chk47.Click, chk46.Click, chk45.Click, chk44.Click, chk43.Click, chk42.Click, chk41.Click, chk31.Click, chk32.Click, chk33.Click, chk34.Click, chk35.Click, chk36.Click, chk37.Click, chk38.Click
        Pinta_PiezasD(CType(sender, CheckBox).Checked, CType(sender, CheckBox))

    End Sub
    Private Function Fnitem() As Integer
        Dim n As Integer = -1
        If (From p In db.int_mov_interno_odontograma_nts_det Where p.odonto_id = Me.OdontoId
            Order By p.odonto_det_id Descending Select p.odonto_det_id).Count = 0 Then
            n = 1
        Else
            Dim res = (From p In db.int_mov_interno_odontograma_nts_det Where p.odonto_id = Me.OdontoId
                       Order By p.odonto_det_id Descending Select p.odonto_det_id).First
            n = res + 1
        End If

        Return n
    End Function

    Private Sub btnquitar_Click(sender As Object, e As EventArgs) Handles btnquitar.Click
        If MessageBox.Show("Esta seguro de quitar este tipo de hallazgo del Odontograma?", "Mensaje a Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Try
                Dim nf1 = (From p In f1chk Where p.Checked = True Select p).Count
                Dim nf2 = (From p In f2chk Where p.Checked = True Select p).Count
                If Not (nf1 = 0 And nf2 = 0) Then
                    MessageBox.Show("Debe deseleccionar todas las piezas dentales", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Remover_Item_det()
                'OForm.guarda_imagen()
                'db.SubmitChanges()
                MessageBox.Show("El elemento se ha quitado correctamente", "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                swregistro = True
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Mensaje a Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

End Class