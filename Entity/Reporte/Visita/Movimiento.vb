Namespace Reporte.Visita
    Public Class Movimiento
#Region "Propiedades"
        Private strDocumentoTipoNombre As String = ""
        Private strNumeroDocumento As String = ""
        Private intSexo As Integer = -1
        Private strVisitanteApePaterno As String = ""
        Private strVisitanteApeMaterno As String = ""
        Private strVisitanteNombres As String = ""
        Private strParentescoNombre As String = ""
        Private strInternoApePaterno As String = ""
        Private strInternoApeMaterno As String = ""
        Private strInternoNombres As String = ""
        Private strTipoVisitaNombre As String = ""
        Private strHoraIngreso As String = ""
        Private strHoraSalida As String = ""
        Private lngFechaNacimiento As Long = 0
        Private lngFechaHoy As Long = 0
        Private lngFechaMov As Long = 0
        Public Property TipoDocumentoNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strDocumentoTipoNombre)
            End Get
            Set(ByVal value As String)
                strDocumentoTipoNombre = value
            End Set
        End Property
        Public Property NumeroDocumento() As String
            Get
                Return strNumeroDocumento
            End Get
            Set(ByVal value As String)
                strNumeroDocumento = value
            End Set
        End Property
        Public Property Sexo() As Integer
            Get
                Return intSexo
            End Get
            Set(ByVal value As Integer)
                intSexo = value
            End Set
        End Property
        Public ReadOnly Property SexoNombreCorto() As String
            Get
                Dim strValue As String = ""

                Select Case Me.Sexo
                    Case 1
                        strValue = "M"
                    Case 2
                        strValue = "F"
                End Select
                Return strValue
            End Get

        End Property
        Public Property VisitanteApePaterno() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strVisitanteApePaterno)
            End Get
            Set(ByVal value As String)
                strVisitanteApePaterno = value
            End Set
        End Property
        Public Property VisitanteApeMaterno() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strVisitanteApeMaterno)
            End Get
            Set(ByVal value As String)
                strVisitanteApeMaterno = value
            End Set
        End Property
        Public Property VisitanteNombres() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strVisitanteNombres)
            End Get
            Set(ByVal value As String)
                strVisitanteNombres = value
            End Set
        End Property
        Public Property FechaNacimiento() As Long
            Get
                Return lngFechaNacimiento
            End Get
            Set(ByVal value As Long)
                lngFechaNacimiento = value
            End Set
        End Property
        Public ReadOnly Property VisitanteApeNom() As String
            Get
                Dim strValue As String = ""

                strValue = Me.VisitanteApePaterno & " " & Me.VisitanteApeMaterno & ", " & Me.VisitanteNombres
                Return Legolas.Components.Cadena.ProperCase(strValue)

            End Get
        End Property
        Public Property VisitaApellidosyNombres() As String

        Public ReadOnly Property VisitanteApeNomEdad() As String
            Get
                Dim strValue As String = ""
                Dim strEdadMenor As String = ""

                If Me.Edad < 18 Then
                    strEdadMenor = " (" & Me.Edad & ")"
                End If

                strValue = Me.VisitanteApeNom & strEdadMenor
                Return strValue

            End Get
        End Property
        Public Property FechaHoy() As Long
            Get
                Return lngFechaHoy
            End Get
            Set(ByVal value As Long)
                lngFechaHoy = value
            End Set
        End Property
        Public ReadOnly Property Edad() As Integer
            Get
                Return Legolas.Components.FechaHora.FechaCalcularAnio(Me.FechaNacimiento, FechaHoy)
            End Get
        End Property
        Public Property ParentescoNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strParentescoNombre)
            End Get
            Set(ByVal value As String)
                strParentescoNombre = value
            End Set
        End Property
        Public Property InternoApePaterno() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strInternoApePaterno)
            End Get
            Set(ByVal value As String)
                strInternoApePaterno = value
            End Set
        End Property
        Public Property InternoApeMaterno() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strInternoApeMaterno)
            End Get
            Set(ByVal value As String)
                strInternoApeMaterno = value
            End Set
        End Property
        Public Property InternoNombres() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strInternoNombres)
            End Get
            Set(ByVal value As String)
                strInternoNombres = value
            End Set
        End Property
        Public ReadOnly Property InternoApeNom() As String
            Get
                Dim strValue As String = ""

                strValue = Me.InternoApePaterno & " " & Me.InternoApeMaterno & ", " & Me.InternoNombres
                Return Legolas.Components.Cadena.ProperCase(strValue)

            End Get
        End Property
        Public Property InternoApellidosyNombres() As String

        Public Property TipoVisitaNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strTipoVisitaNombre)
            End Get
            Set(ByVal value As String)
                strTipoVisitaNombre = value
            End Set
        End Property
        Public Property FechaMov() As Long
            Get
                Return lngFechaMov
            End Get
            Set(ByVal value As Long)
                lngFechaMov = value
            End Set
        End Property
        Public ReadOnly Property FechaMovString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaMov)
            End Get
        End Property
        Public Property HoraIngreso() As String
            Get
                Return strHoraIngreso
            End Get
            Set(ByVal value As String)
                strHoraIngreso = value
            End Set
        End Property
        Public Property HoraSalida() As String
            Get
                Return strHoraSalida
            End Get
            Set(ByVal value As String)
                strHoraSalida = value
            End Set
        End Property
#End Region
    End Class
#Region "MovimientoCol"
    Public Class MovimientoCol
        Inherits System.Collections.CollectionBase
        Private _enmSortDirection As SortDirection
        Public Sub New()
            _enmSortDirection = SortDirection.Asc
        End Sub
        Public Sub Sort(ByVal sortExpression As String, ByVal sortDirection As SortDirection)
            InnerList.Sort(New Comparer(sortExpression, sortDirection))
        End Sub
        Public Sub Sort(ByVal sortExpression As String)
            InnerList.Sort(New Comparer(sortExpression, _enmSortDirection))
            If _enmSortDirection = SortDirection.Asc Then
                _enmSortDirection = SortDirection.Desc
            Else
                _enmSortDirection = SortDirection.Asc
            End If
        End Sub
        Public Function Add(ByVal obj As Movimiento) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Movimiento(ByVal Index As Integer) As Movimiento
            Get
                Return CType(MyBase.List(Index), Movimiento)
            End Get
        End Property
        Public Function CloneCol() As Movimiento
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

