Imports System.Drawing.Drawing2D
Public Class Simbolos
    Private _dibuja As Boolean = False
    Public Shared TipoSimbolo As String = ""
    Public Shared gph As GraphicsPath = New GraphicsPath
    'Public Shared lsdental As List(Of PiezaDental) = New List(Of PiezaDental)

    'Public Shared Function AOF(ByVal p1 As PiezaDental, p2 As PiezaDental, color As Brush, UY As Integer) As List(Of Point)

    '    Dim gp As List(Of Point) = New List(Of Point)
    '    Dim ld As Integer = 3
    '    Dim UX As Integer = 1
    '    Dim cx As Integer = -1
    '    Dim cy As Integer = -1

    '    cx = p1.PX + Int(p1.PCX / 2)
    '    cy = p1.PY + UY
    '    'Inicio
    '    ' Cruz
    '    Dim pt1 As Point = New Point(cx - ld, cy)
    '    Dim pt2 As Point = New Point(cx + ld, cy)
    '    Dim pt3 As Point = New Point(cx, cy + ld)
    '    Dim pt4 As Point = New Point(cx, cy - ld)
    '    'rectangulo
    '    Dim pr1 As Point = New Point(cx - Int((ld + 2) / 2), cy - Int((ld + 2) / 2))
    '    Dim pr2 As Point = New Point(cx - Int((ld + 2) / 2) + ld + 2, cy - Int((ld + 2) / 2))
    '    Dim pr3 As Point = New Point(cx - Int((ld + 2) / 2) + ld + 2, cy + Int((ld + 2) / 2))
    '    Dim pr4 As Point = New Point(cx - Int((ld + 2) / 2), cy - Int((ld + 2) / 2) + ld + 2)

    '    gp.Add(pt1)
    '    gp.Add(pt2)
    '    gp.Add(pt3)
    '    gp.Add(pt4)
    '    gp.Add(pr1)
    '    gp.Add(pr2)
    '    gp.Add(pr3)
    '    gp.Add(pr4)

    '    Return gp

    'End Function
    Public Shared Sub DibujaSimbolos(P1 As PiezaDental, P2 As PiezaDental, e As Graphics, TipoSimbolo As Integer, cl As Color)

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
                    fila = -50
                Else
                    fila = 80
                End If
                If P2 Is Nothing Then
                    'SAOR(New Point(P1.PX + Int(P1.PCX / 3), P1.PY + fila), New Point(P1.PX + Int(P1.PCX / 3), P1.PY + fila), e, cl, fila)
                Else
                    'SAOR(New Point(P1.PX + Int(P1.PCX / 3), P1.PY + fila), New Point(P2.PX + Int(P2.PCX / 3), P2.PY + fila), e, cl, fila)
                End If

        End Select

    End Sub

    Private Shared Sub SAOR(p1 As PiezaDental, p2 As PiezaDental, gr As Graphics, cl As Color, fila As Integer)

        Dim ld As Integer = 12
        For n As Integer = p1.NumOrden To p2.NumOrden
            'MessageBox.Show()
        Next
        'Dim rec1 As Rectangle = New Rectangle(p1.X, p1.Y, ld, ld)
        'Dim rec2 As Rectangle = New Rectangle(p2.X, p2.Y, ld, ld)
        ' Cruz izq
        'Dim pci1 As Point = New Point(p1.X + Int(ld / 6), p1.Y + Int(ld / 2))
        'Dim pci2 As Point = New Point(p1.X + 5 * Int(ld / 6), p1.Y + Int(ld / 2))
        'Dim pci3 As Point = New Point(p1.X + Int(ld / 2), p1.Y + Int(ld / 6))
        'Dim pci4 As Point = New Point(p1.X + Int(ld / 2), p1.Y + 5 * Int(ld / 6))
        ' Cruz der
        'Dim pcd1 As Point = New Point(p2.X + Int(ld / 6), p2.Y + Int(ld / 2))
        'Dim pcd2 As Point = New Point(p2.X + 5 * Int(ld / 6), p2.Y + Int(ld / 2))
        'Dim pcd3 As Point = New Point(p2.X + Int(ld / 2), p2.Y + Int(ld / 6))
        'Dim pcd4 As Point = New Point(p2.X + Int(ld / 2), p2.Y + 5 * Int(ld / 6))
        ' Linea de union
        'Dim pli1 As Point = New Point(p1.X + ld, p2.Y + Int(ld / 2))
        'Dim pld2 As Point = New Point(p2.X, p2.Y + Int(ld / 2))

        'Dim pn As Pen = New Pen(cl, 2)
        'gr.DrawRectangle(pn, rec1)
        'gr.DrawLine(pn, pci1, pci2)
        'gr.DrawLine(pn, pci3, pci4)
        'gr.DrawRectangle(pn, rec2)
        'gr.DrawLine(pn, pcd1, pcd2)
        'gr.DrawLine(pn, pcd3, pcd4)
        'gr.DrawLine(pn, pli1, pld2)


    End Sub
    Private Shared Sub SAOF(p1 As Point, p2 As Point, gr As Graphics, cl As Color, fila As Integer)

        Dim ld As Integer = 12
        Dim rec1 As Rectangle = New Rectangle(p1.X, p1.Y, ld, ld)
        Dim rec2 As Rectangle = New Rectangle(p2.X, p2.Y, ld, ld)
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


End Class
