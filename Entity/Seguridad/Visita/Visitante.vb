Namespace Visita
    Public Class Visitante
        Inherits Globall.Persona

#Region "Propiedades"
        Public Property Codigo() As Integer=-1       
        Public Property VisitanteApellidosyNombres As String = ""    
        Public Property Observacion() As String = ""
        Public Property Institucion As String = ""
        Public ReadOnly Property MenorEdad() As Boolean
            Get
                Dim _menor As Boolean = False
                If Edad < 18 Then
                    _menor = True
                End If

                Return _menor
            End Get
        End Property
        Public Property PenalID() As short =-1        
        Public Property PenalNombre() As String=""            
        Public Property RegionID() As Short = -1
        Public Property RegionNombre() As String = ""        
#Region "Propiedades_Otros"
        Public Property IDUsuarioCapturaFoto As Integer = -1
        Public Property IDUsuarioCapturaHuella() As Integer = -1
        Public Property VisitanteValidoReniec As Short = -1
        Public ReadOnly Property ValidadoReniecReadonly As String
            Get

                Dim value As String = ""
                If VisitanteValidoReniec = 1 Then
                    value = "SI"
                Else
                    value = "NO"
                End If

                Return value

            End Get
        End Property

        Public Property VisitanteTieneHuella As Short = 0
        
        Public ReadOnly Property VisitanteTieneHuellaReadonly As String
            Get

                Dim value As String = ""
                If VisitanteTieneHuella = 1 Then
                    value = "SI"
                Else
                    value = "NO"
                End If

                Return value

            End Get
        End Property

        Public Property IDUsuarioValidacionReniec() As Integer = -1
        Public Property FechaValidacionReniec() As Long = 0
#End Region
#Region "Propiedades_Huella"
        Public Property HuellaTipoCapturaIzquierdo As Short = -1
        Public Property HuellaIDIndiceIzquierdo As Integer = -1
        Public Property HuellaCalidadIndiceIzquierdo As Short = -1
        Public Property HuellaIDPulgarIzquierdo As Integer = -1
        Public Property HuellaCalidadPulgarIzquierdo As Short = -1
        Public Property HuellaObservacionIzquierdo As String = ""

        Public ReadOnly Property ManoIzquierda As String
            Get

                Dim value As String = ""

                Select Case HuellaTipoCapturaIzquierdo
                    Case 0
                        value = "Amputado"
                    Case 1

                        If HuellaIDIndiceIzquierdo > 0 Then
                            value = "Indice Izquierdo"                            
                        End If

                        If HuellaIDPulgarIzquierdo > 0 Then
                            value = "Pulgar Izquierdo"
                        End If

                    Case 2
                        value = "Observado"
                End Select                

                Return value

            End Get
        End Property

        Public Property HuellaTipoCapturaDerecho As Short = -1
        Public Property HuellaIDIndiceDerecho As Integer = -1
        Public Property HuellaCalidadIndiceDerecho As Short = -1
        Public Property HuellaIDPulgarDerecho As Integer = -1
        Public Property HuellaCalidadPulgarDerecho As Short = -1
        Public Property HuellaObservacionDerecho As String = ""

        Public ReadOnly Property ManoDerecha As String
            Get

                Dim value As String = ""

                Select Case HuellaTipoCapturaDerecho
                    Case 0
                        value = "Amputado"
                    Case 1

                        If HuellaIDIndiceDerecho > 0 Then
                            value = "Indice Derecho"
                        End If

                        If HuellaIDPulgarDerecho > 0 Then
                            value = "Pulgar Derecho"
                        End If

                    Case 2
                        value = "Observado"
                End Select

                Return value

            End Get
        End Property
#End Region
#Region "Auditoria"
        Public Property IDUsuarioCreacion As Integer = -1
        Public Property FechaCreacion As Long = 0
        Public Property IDUsuarioModificacion As Integer = -1
        Public Property FechaModificacion As Long = 0
        Public Property IDUsuarioEliminacion As Integer = -1
        Public Property FechaEliminacion As Long = 0
        Public Property Eliminado As Boolean = 0
#End Region
#End Region
    End Class
#Region "VisitanteCol"
    Public Class VisitanteCol
        Inherits System.Collections.CollectionBase
        Private _enmSortDirection As SortDirection
        Public Sub New()
            _enmSortDirection = SortDirection.Asc
        End Sub
        Public Sub Sort(ByVal sortExpression As String, ByVal sortDirection As SortDirection)
            InnerList.Sort(New Comparer(sortExpression, SortDirection))
        End Sub
        Public Sub Sort(ByVal sortExpression As String)
            InnerList.Sort(New Comparer(sortExpression, _enmSortDirection))
            If _enmSortDirection = SortDirection.Asc Then
                _enmSortDirection = SortDirection.Desc
            Else
                _enmSortDirection = SortDirection.Asc
            End If
        End Sub
        Public Function Add(ByVal obj As Visitante) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Visitante(ByVal Index As Integer) As Visitante
            Get
                Return CType(MyBase.List(Index), Visitante)
            End Get
        End Property
        Public Function CloneCol() As Visitante
            Return MyBase.MemberwiseClone
        End Function
        Public Sub Remove(ByVal index As Integer)
            If index <= Count - 1 OrElse index >= 0 Then
                Me.List.RemoveAt(index)
                'Me.List.Remove(index)
            End If
        End Sub

  



    End Class
#End Region
End Namespace