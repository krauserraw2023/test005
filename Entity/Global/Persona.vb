Namespace Globall
    Public Class Persona        
        Inherits Legolas.LEntity.Globall.Persona
#Region "Propiedades"
        Private strFotoName As String = ""
        Private intFotoID As Integer = -1
        Public Property FotoID() As Integer
            Get
                Return intFotoID
            End Get
            Set(ByVal value As Integer)
                intFotoID = value
            End Set
        End Property
        Public Property FotoName() As String
            Get
                Return strFotoName
            End Get
            Set(ByVal value As String)
                strFotoName = value
            End Set
        End Property
#End Region
    End Class
End Namespace