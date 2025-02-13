Imports System
Imports System.Collections

Public Enum SortDirection
    Asc = -1
    Desc = 1
End Enum

Public Class Comparer
    Implements IComparer

    Dim m_SortPropertyName As String
    Dim m_SortDirection As SortDirection

    Public Sub New(ByVal sortPropertyName As String)
        m_SortPropertyName = sortPropertyName
        m_SortDirection = SortDirection.Asc
    End Sub

    Public Sub New(ByVal sortPropertyName As String, ByVal sortDirection As SortDirection)
        m_SortPropertyName = sortPropertyName
        m_SortDirection = sortDirection
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare

        If m_SortPropertyName.Length < 1 Or m_SortPropertyName.Trim = "" Then
            Exit Function
        End If

        Dim valueOfX As Object = x.GetType().GetProperty(m_SortPropertyName).GetValue(x, Nothing)
        Dim valueOfY As Object = y.GetType().GetProperty(m_SortPropertyName).GetValue(y, Nothing)

        Dim comp As IComparable = valueOfY 'as IComparable 

        ' Flip the value from whatever it was to the opposite.
        Return Flip(comp.CompareTo(valueOfX))
    End Function

    Private Function Flip(ByVal i As Integer) As Integer

        Return (i * CType(m_SortDirection, Integer))
    End Function
End Class