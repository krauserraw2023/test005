Imports System.Drawing.Drawing2D

Public Class PiezaDental
    Public Enum PartesPiezaDental
        Superior
        Inferior
        Derecha
        Izquierda
        Centro
        Raices
        Etiqueta
        Desconocida
    End Enum
    Public Enum PartesCentro
        C1
        C2
        C3
        C4
        Desconocida
    End Enum
    Public partes(6) As GraphicsPath
    Public partescentropieza(4) As GraphicsPath
    Private colores(6) As Brush
    Private pintable(6) As Boolean
    Private _numpíeza As Integer
    Private _tipohallazgo As String
    Private _orden As Integer
    Private _px As Integer
    Private _py As Integer
    Private _pcx As Integer
    Private _pcy As Integer
    Public Property PX As Integer
        Get
            PX = _px
        End Get
        Set(value As Integer)
            _px = value
        End Set
    End Property
    Public Property PY As Integer
        Get
            PY = _py
        End Get
        Set(value As Integer)
            _py = value
        End Set
    End Property
    Public Property PCX As Integer
        Get
            PCX = _pcx
        End Get
        Set(value As Integer)
            _pcx = value
        End Set
    End Property
    Public Property PCY As Integer
        Get
            PCY = _pcy
        End Get
        Set(value As Integer)
            _pcy = value
        End Set
    End Property
    Public Property NumOrden As Integer
        Get
            NumOrden = _orden
        End Get
        Set(value As Integer)
            _orden = value
        End Set
    End Property
    Public Property NumPieza As Integer
        Get
            NumPieza = _numpíeza
        End Get
        Set(value As Integer)
            _numpíeza = value
        End Set
    End Property
    Public Property TipoHallazgo As Integer
        Get
            TipoHallazgo = _tipohallazgo
        End Get
        Set(value As Integer)
            _tipohallazgo = value
        End Set
    End Property


    Public Sub New(x As Integer, y As Integer, cx As Integer, cy As Integer, lbly As Integer, vinumero As Integer, orden As Integer, tipo As String)
        pintable(0) = True
        pintable(1) = True
        pintable(2) = True
        pintable(3) = True
        pintable(4) = True
        pintable(5) = False
        pintable(6) = False

        NumPieza = vinumero
        NumOrden = orden
        PX = x
        PY = y
        PCX = cx
        PCY = cy
        Dim aas As Integer = -1 * (cy + 3)  ' altura ancho superior
        Dim ads As Integer = -1 * (cy)  ' altura delgado superior
        Dim aai As Integer = cy + 3 ' altura ancho inferior
        Dim adi As Integer = cy   ' altura delgado inferior
        'margenes izq y der ancho
        Dim mda As Integer = -3
        Dim mia As Integer = 3
        'margenes izq y der delgado
        Dim mdd As Integer = -8
        Dim mid As Integer = 8
        Dim pt1 As Point = New Point(x, y)
        Dim pt2 As Point = New Point(x + cx, y)
        Dim pt3 As Point = New Point(x, y + cy)
        Dim pt4 As Point = New Point(x + cx, y + cy)

        Dim pt5 As Point = New Point(x + cx \ 3, y + cy \ 3)
        Dim pt6 As Point = New Point(x + 2 * cx \ 3, y + cy \ 3)
        Dim pt7 As Point = New Point(x + cx \ 3, y + 2 * cy \ 3)
        Dim pt8 As Point = New Point(x + 2 * cx \ 3, y + 2 * cy \ 3)
        ' puntos de divisiones del centro
        Dim pc1 As Point = New Point(x + cx \ 2, y + cy \ 3)
        Dim pc2 As Point = New Point(x + cx \ 2, y + 2 * cy \ 3)
        Dim pc3 As Point = New Point(x + cx \ 3, y + cy \ 2)
        Dim pc4 As Point = New Point(x + 2 * cx \ 3, y + cy \ 2)

        Dim cr1 As RectangleF = New RectangleF(x + cx \ 3, y + cy \ 3, cx / 6, cy / 6)
        Dim cr2 As RectangleF = New RectangleF(x + cx \ 2, y + cy \ 3, cx / 6, cy / 6)
        Dim cr3 As RectangleF = New RectangleF(x + cx \ 3, y + cy \ 2, cx / 6, cy / 6)
        Dim cr4 As RectangleF = New RectangleF(x + cx \ 2, y + cy \ 2, cx / 6, cy / 6)

        Dim xc As Integer = x + cx \ 3
        Dim xy As Integer = y + cy \ 3
        Dim ptc1 As Point = New Point(x + cx \ 3, y + cy \ 3)

        ' ptos triangulo ancho superior
        Dim pttas11 As Point = New Point(x + mia, y)
        Dim pttas12 As Point = New Point(x + Int((cx) / 2), y + ads)
        Dim pttas13 As Point = New Point(x + cx + mda, y)
        ' ptos triangulo delgado superior
        Dim pttds11 As Point = New Point(x + mid, y)
        Dim pttds12 As Point = New Point(x + Int((cx) / 2), y + ads)
        Dim pttds13 As Point = New Point(x + cx + mdd, y)
        '  ptos 2 triangulo delgado superior
        'pt1,pttds21,pttds22,pttds23,pttds24,pt2
        Dim pttds21 As Point = New Point(x + Int(cx / 3), y + ads)
        Dim pttds22 As Point = New Point(x + Int(2 * cx / 3), y)
        Dim pttds23 As Point = New Point(x + Int(cx / 2), y + Int(ads / 2))
        Dim pttds24 As Point = New Point(x + Int(2 * cx / 3), y + ads)

        '  ptos 2 triangulo delgado inferior
        'pt3,pttdi21,pttdi22,pttdi23,pt4
        Dim pttdi21 As Point = New Point(x + Int(cx / 4), y + cy + adi)
        Dim pttdi22 As Point = New Point(x + Int(cx / 2), y + cy)
        Dim pttdi23 As Point = New Point(x + Int(3 * cx / 4), y + cy + adi)
        ' Dim pttdi24 As Point = New Point(x + 2 * Int((cx) / 2), y + adi)

        '  ptos 3 triangulo delgado superior al borde
        'pt1,pttds31,pttds32,pttds33,pttds34,pttds35,pttds36,pttds37,pt2
        Dim pttds31 As Point = New Point(x + Int(cx / 4), y + ads)
        Dim pttds32 As Point = New Point(x + Int(cx / 2), y)
        Dim pttds33 As Point = New Point(x + Int(3 * cx / 8), y + Int(ads / 2))
        Dim pttds34 As Point = New Point(x + Int(cx / 2), y + ads)
        Dim pttds35 As Point = New Point(x + Int(5 * cx / 8), y + Int(ads / 2))
        Dim pttds36 As Point = New Point(x + Int(cx / 2), y)
        Dim pttds37 As Point = New Point(x + Int(3 * cx / 4), y + ads)

        '  ptos 3 triangulo delgado superior con margen
        'ptdsm31,pttdsm31,pttdsm32,pttdsm33,pttdsm34,pttdsm35,pttdsm36,pttdsm37,ptdsm38
        Dim ptdsm31 As Point = New Point(x + mia, y)
        Dim pttdsm31 As Point = New Point(x + mia + Int((cx + mda - mia) / 4), y + ads)
        Dim pttdsm32 As Point = New Point(x + mia + Int((cx + mda - mia) / 2), y)
        Dim pttdsm33 As Point = New Point(x + mia + Int(3 * (cx + mda - mia) / 8), y + Int(ads / 2))
        Dim pttdsm34 As Point = New Point(x + mia + Int((cx + mda - mia) / 2), y + ads)
        Dim pttdsm35 As Point = New Point(x + mia + Int(5 * (cx + mda - mia) / 8), y + Int(ads / 2))
        Dim pttdsm36 As Point = New Point(x + mia + Int((cx + mda - mia) / 2), y)
        Dim pttdsm37 As Point = New Point(x + mia + Int(3 * (cx + mda - mia) / 4), y + ads)
        Dim ptdsm38 As Point = New Point(x + cx + mda, y)


        ' ptos triangulo ancho inferior
        Dim pttai11 As Point = New Point(x + mia, y + cy)
        Dim pttai12 As Point = New Point(x + Int((cx) / 2), y + cy + aai)
        Dim pttai13 As Point = New Point(x + cx + mda, y + cy)
        ' ptos triangulo delgado inferior
        Dim pttdi11 As Point = New Point(x + mid, y + cy)
        Dim pttdi12 As Point = New Point(x + Int((cx) / 2), y + cy + adi)
        Dim pttdi13 As Point = New Point(x + cx + mdd, y + cy)
        ' ptos de la etiqueta
        Dim pte1 As Point = New Point(x, y + lbly)
        Dim pte2 As Point = New Point(x + cx, y + lbly)
        ' Dim pte3 As Point = New Point(x, y + cy + lbly)
        Dim pte3 As Point = New Point(x + cx, y + cy + lbly)
        Dim pte4 As Point = New Point(x, y + cy + lbly)
        '

        partes(PartesPiezaDental.Superior) = New GraphicsPath()
        'partes(PartesPiezaDental.Superior).AddPolygon(New Point() {pt1, pt2, pt6, pt5})
        'partes(PartesPiezaDental.Superior).AddPolygon(New Point() {pt1, pt2, pc4, pc3})
        'partes(PartesPiezaDental.Superior).AddPolygon(New Point() {ptt1, ptt2, ptt3})
        colores(PartesPiezaDental.Superior) = Brushes.White
        '
        partes(PartesPiezaDental.Izquierda) = New GraphicsPath()
        'partes(PartesPiezaDental.Izquierda).AddPolygon(New Point() {pt1, pt3, pt7, pt5})
        'partes(PartesPiezaDental.Izquierda).AddPolygon(New Point() {pt1, pt3, pc3})
        colores(PartesPiezaDental.Izquierda) = Brushes.White
        '
        partes(PartesPiezaDental.Inferior) = New GraphicsPath()
        ' partes(PartesPiezaDental.Inferior).AddPolygon(New Point() {pt3, pt4, pt8, pt7})
        'partes(PartesPiezaDental.Inferior).AddPolygon(New Point() {pt3, pt4, pc4, pc3})
        colores(PartesPiezaDental.Inferior) = Brushes.White

        Dim format1 As StringFormat = New StringFormat(StringFormatFlags.NoClip)
        format1.Alignment = StringAlignment.Center
        Dim fuente As FontFamily = New FontFamily("Arial")
        partes(PartesPiezaDental.Derecha) = New GraphicsPath()
        'partes(PartesPiezaDental.Derecha).AddPolygon(New Point() {pt4, pt2, pt6, pt8})
        'partes(PartesPiezaDental.Derecha).AddPolygon(New Point() {pt4, pt2, pc4})
        colores(PartesPiezaDental.Derecha) = Brushes.White

        partes(PartesPiezaDental.Centro) = New GraphicsPath()

        Dim rec As RectangleF = New RectangleF(pt5.X, pt5.Y, pt6.X - pt5.X, pt7.Y - pt5.Y)
        'Dim rec1 As RectangleF = New RectangleF(pc1.X, pc1.Y, pt6.X - pc1.X, pc2.Y - pc1.Y)
        'Dim rec2 As RectangleF = New RectangleF(pc3.X, pc3.Y, pt8.X - pc3.X, pc4.Y - pc3.Y)
        'partes(PartesPiezaDental.Centro).AddRectangle(New Point() {pt5, pt6, pt8, pt7})



        'partes(PartesPiezaDental.Centro).AddRectangle(cr2)
        'partes(PartesPiezaDental.Centro).AddRectangle(cr3)
        'partes(PartesPiezaDental.Centro).AddRectangle(cr4)
        'Dim div As GraphicsPath = New GraphicsPath()
        'div.AddLine(pc1, pc2)
        'div.AddLine(pc3, pc4)
        'partes(PartesPiezaDental.Centro).AddPath(div, False)
        'partes(PartesPiezaDental.Centro).AddLine(pc3, pc4)
        'partes(PartesPiezaDental.Centro).AddPolygon(New Point() {pt5, pc1, pt6, pc4, pt8, pc2, pt7, pc3})
        colores(PartesPiezaDental.Centro) = Brushes.White


        partes(PartesPiezaDental.Raices) = New GraphicsPath()
        ' Numeros de piezas dentales

        'If tipo = "Inf" Then
        '    partes(PartesPiezaDental.Raices).AddPolygon(New Point() {pttdi11, pttdi12, pttdi13})
        'End If

        Dim tipodiente As String = vinumero.ToString().Trim()
        If tipo = "Sup" Then
            If tipodiente = "18" Or tipodiente = "17" Or tipodiente = "16" Or tipodiente = "26" Or tipodiente = "27" Or tipodiente = "28" Then
                partes(PartesPiezaDental.Raices).AddPolygon(New Point() {pt1, pttds31, pttds32, pttds33, pttds34, pttds35, pttds36, pttds37, pt2})
            ElseIf tipodiente = "55" Or tipodiente = "54" Or tipodiente = "64" Or tipodiente = "65" Then
                partes(PartesPiezaDental.Raices).AddPolygon(New Point() {ptdsm31, pttdsm31, pttdsm32, pttdsm33, pttdsm34, pttdsm35, pttdsm36, pttdsm37, ptdsm38})

            ElseIf tipodiente = "14" Or tipodiente = "24" Then
                partes(PartesPiezaDental.Raices).AddPolygon(New Point() {pt1, pttds21, pttds22, pttds23, pttds24, pt2})
            ElseIf tipodiente = "15" Or tipodiente = "25" Then
                partes(PartesPiezaDental.Raices).AddPolygon(New Point() {pttds11, pttds12, pttds13})
            Else
                partes(PartesPiezaDental.Raices).AddPolygon(New Point() {pttas11, pttas12, pttas13})
            End If
        End If
        If tipo = "Inf" Then
            If tipodiente = "85" Or tipodiente = "84" Or tipodiente = "74" Or tipodiente = "75" Or tipodiente = "27" Or tipodiente = "28" Or tipodiente = "48" Or tipodiente = "47" Or tipodiente = "46" Or tipodiente = "38" Or tipodiente = "37" Or tipodiente = "36" Then
                partes(PartesPiezaDental.Raices).AddPolygon(New Point() {pt3, pttdi21, pttdi22, pttdi23, pt4})
            ElseIf tipodiente = "45" Or tipodiente = "44" Or tipodiente = "34" Or tipodiente = "35" Then
                'partes(PartesPiezaDental.Raices).AddPolygon(New Point() {pt1, pttds31, pttds32, pttds33, pttds34, pttds35, pttds36, pttds37, pt2})
                partes(PartesPiezaDental.Raices).AddPolygon(New Point() {pttdi11, pttdi12, pttdi13})
            Else
                partes(PartesPiezaDental.Raices).AddPolygon(New Point() {pttai11, pttai12, pttai13})
            End If
        End If
        'If tipo = "Sup" Then
        If tipodiente = "18" Or tipodiente = "17" Or tipodiente = "16" Or tipodiente = "28" Or tipodiente = "27" Or tipodiente = "26" Or tipodiente = "55" Or tipodiente = "54" Or tipodiente = "65" Or tipodiente = "64" Or tipodiente = "85" Or tipodiente = "84" Or tipodiente = "74" Or tipodiente = "75" Or tipodiente = "48" Or tipodiente = "47" Or tipodiente = "46" Or tipodiente = "36" Or tipodiente = "37" Or tipodiente = "38" Then
            partes(PartesPiezaDental.Superior).AddPolygon(New Point() {pt1, pt2, pt6, pt5})
            partes(PartesPiezaDental.Izquierda).AddPolygon(New Point() {pt1, pt3, pt7, pt5})
            partes(PartesPiezaDental.Inferior).AddPolygon(New Point() {pt3, pt4, pt8, pt7})
            partes(PartesPiezaDental.Derecha).AddPolygon(New Point() {pt4, pt2, pt6, pt8})

            ' partes(PartesPiezaDental.Centro).AddRectangle(rec)
            partes(PartesPiezaDental.Centro).AddLine(pc1, pc2)
            partes(PartesPiezaDental.Centro).AddLine(pc3, pc4)

        ElseIf tipodiente = "15" Or tipodiente = "14" Or tipodiente = "24" Or tipodiente = "25" Or tipodiente = "45" Or tipodiente = "44" Or tipodiente = "34" Or tipodiente = "35" Then
            partes(PartesPiezaDental.Superior).AddPolygon(New Point() {pt1, pt2, pt6, pt5})
            partes(PartesPiezaDental.Izquierda).AddPolygon(New Point() {pt1, pt3, pt7, pt5})
            partes(PartesPiezaDental.Inferior).AddPolygon(New Point() {pt3, pt4, pt8, pt7})
            partes(PartesPiezaDental.Derecha).AddPolygon(New Point() {pt4, pt2, pt6, pt8})
            ' partes(PartesPiezaDental.Centro).AddRectangle(rec)
            partes(PartesPiezaDental.Centro).AddLine(pc3, pc4)
        Else
            partes(PartesPiezaDental.Superior).AddPolygon(New Point() {pt1, pt2, pc4, pc3})
                partes(PartesPiezaDental.Izquierda).AddPolygon(New Point() {pt1, pt3, pc3})
                partes(PartesPiezaDental.Inferior).AddPolygon(New Point() {pt3, pt4, pc4, pc3})
                partes(PartesPiezaDental.Derecha).AddPolygon(New Point() {pt4, pt2, pc4})
                'partes(PartesPiezaDental.Centro).AddLine(pc3, pc4)
            End If
        'End If

        colores(PartesPiezaDental.Raices) = Brushes.White
        partes(PartesPiezaDental.Etiqueta) = New GraphicsPath()
        partes(PartesPiezaDental.Etiqueta).AddPolygon(New Point() {pte1, pte2, pte3, pte4})
        If tipo = "Sup" Then
            partes(PartesPiezaDental.Etiqueta).AddString(vinumero.ToString(), fuente, FontStyle.Regular, 12, New Point(x + Int(cx / 2), y + cy + lbly + 5), format1)
        Else
            partes(PartesPiezaDental.Etiqueta).AddString(vinumero.ToString(), fuente, FontStyle.Regular, 12, New Point(x + Int(cx / 2), y + lbly - 15), format1)
        End If
        colores(PartesPiezaDental.Etiqueta) = Brushes.White
        'numero = vinumero
    End Sub
    Public Sub Dibuja(g As Graphics)

        For Each p As GraphicsPath In partes
            g.FillPath(colores(Array.IndexOf(partes, p)), p)
            g.DrawPath(Pens.Black, p)
        Next
    End Sub

    Public Function DetectaPartePiezaDental(pt As Point) As PartesPiezaDental
        For Each p As GraphicsPath In partes
            If p.IsVisible(pt) Then
                Return CType(Array.IndexOf(partes, p), PartesPiezaDental)
            End If
        Next
        Return PartesPiezaDental.Desconocida
    End Function
    Public Function DetectaNumPiezaDental(pt As Point) As Integer
        For Each p As GraphicsPath In partes
            If p.IsVisible(pt) Then
                Return NumPieza
            End If
        Next
        Return -1
    End Function
    Public Function DetectaPiezaDentalOrden(pt As Point) As Integer
        For Each p As GraphicsPath In partes
            If p.IsVisible(pt) Then
                Return NumOrden
            End If
        Next
        Return -1
    End Function
    Public Function DetectaPiezaDentalObj(pt As Point) As PiezaDental
        For Each p As GraphicsPath In partes
            If p.IsVisible(pt) Then
                Return Me
            End If
        Next
        Return Nothing
    End Function
    Public Sub ColoreaParte(b As Brush, p As PartesPiezaDental)
        colores(p) = b
    End Sub
    Public Function RectPartePiezaDental(p As PartesPiezaDental) As Rectangle
        Return Rectangle.Truncate(partes(p).GetBounds())
    End Function

    Public Function RectPiezaDental() As Rectangle
        Return New Rectangle(New Point(Me.PX, Me.PY - Me.PCY), New Size(Me.PCX, 2 * Me.PCY))
    End Function

End Class
Public Class ReOdontograma
    Private _codigo As String
    Private _descripcion As String
    Public Property Codigo As String
        Get
            Codigo = _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Descripcion = _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
End Class
'Public Class Punto
'    Private _x As Integer
'    Private _y As Integer
'    Public Sub New()

'    End Sub
'    Public Sub New(px As Integer, py As Integer)
'        X = px
'        Y = py
'    End Sub
'    Public Property X As Integer
'        Get
'            X = _x
'        End Get
'        Set(value As Integer)
'            _x = value
'        End Set
'    End Property
'    Public Property Y As Integer
'        Get
'            Y = _y
'        End Get
'        Set(value As Integer)
'            _y = value
'        End Set
'    End Property
'End Class
Public Class HallasgosManual
    Private _np As Integer
    Private _pcolor As String
    Private _lpaths As New List(Of GraphicsPath)
    Private _item As Integer
    Public Property Npiezam As Integer
        Get
            Npiezam = _np
        End Get
        Set(value As Integer)
            _np = value
        End Set
    End Property

    Public Property Nts_Item As Integer
        Get
            Nts_Item = _item
        End Get
        Set(value As Integer)
            _item = value
        End Set
    End Property

    Public Property Pcolor As String
        Get
            Pcolor = _pcolor
        End Get
        Set(value As String)
            _pcolor = value
        End Set
    End Property

    Public Property LPiezasPath As List(Of GraphicsPath)
        Get
            LPiezasPath = _lpaths
        End Get
        Set(value As List(Of GraphicsPath))
            _lpaths = value
        End Set
    End Property

End Class
