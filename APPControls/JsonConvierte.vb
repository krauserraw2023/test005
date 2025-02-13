Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Xml.Schema
Imports Microsoft.VisualBasic.Devices
Imports Newtonsoft.Json



Public Class JsonConvierte
    Public Shared Function Jsonserializa(ByVal lpuntos As List(Of Point)) As String
        Dim ss As String = Nothing
        ss = JsonConvert.SerializeObject(lpuntos)
        Return ss
    End Function
    Public Shared Function Jsondeserializa(ByVal cjson As String) As List(Of Point)
        Dim ss As New List(Of Point)
        If Not cjson Is Nothing Then
            ss = JsonConvert.DeserializeObject(Of List(Of Point))(cjson)
        Else
            ss = Nothing
        End If
        ' ss = xx.ToList()
        Return ss
    End Function
End Class
Public Class Punto
    Private _x As Integer
    Private _y As Integer
    Public Sub New()

    End Sub
    Public Sub New(px As Integer, py As Integer)
        X = px
        Y = py
    End Sub
    Public Property X As Integer
        Get
            X = _x
        End Get
        Set(value As Integer)
            _x = value
        End Set
    End Property
    Public Property Y As Integer
        Get
            Y = _y
        End Get
        Set(value As Integer)
            _y = value
        End Set
    End Property
End Class