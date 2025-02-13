Namespace Biometria

    Public Class InternoHuellaTratamiento
        Inherits Auditoria.Transaccion

        Public Property Codigo() As Integer = -1
        Public Property IDInterno As Integer = -1

        Public Property NumeroRecaptura As Short = 0
        Public Property FechaCaptura As Long = 0
        Public ReadOnly Property FechaCapturaString As String
            Get
                Dim value As String = ""

                If FechaCaptura > 0 Then
                    value = Legolas.Components.FechaHora.FechaDate(FechaCaptura, True).ToString
                End If

                Return value

            End Get
        End Property
        Public Property EstadoHuella As Short = -1
        Public Property IDUsuarioInactivaHuella As Integer = -1
        Public Property UsuarioInactivaHuella As String = ""
        Public Property FechaInactivaHuella As Long = 0
        Public ReadOnly Property FechaInactivaHuellaString As String
            Get
                Dim value As String = ""

                If FechaInactivaHuella > 0 Then
                    value = Legolas.Components.FechaHora.FechaDate(FechaInactivaHuella, True).ToString
                End If

                Return value

            End Get
        End Property

        Public Property TipoCapturaIzquierdo As Short = -1
        Public Property IDIndiceIzquierdo As Integer = -1
        Public Property CalidadIndiceIzquierdo As Short = 0
        Public Property IDPulgarIzquierdo As Integer = -1
        Public Property CalidadPulgarIzquierdo As Short = 0
        Public Property ObservacionIzquierdo As String = ""

        Public ReadOnly Property TipoDedoIzquierdo As Short
            Get
                Dim value As Type.Enumeracion.Biometria.TipoDedo = Type.Enumeracion.Biometria.TipoDedo.Ninguno

                Select Case TipoCapturaIzquierdo

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal

                        If IDIndiceIzquierdo > 0 Then
                            value = Type.Enumeracion.Biometria.TipoDedo.IndiceIzquierdo
                        End If

                        If IDPulgarIzquierdo > 0 Then
                            value = Type.Enumeracion.Biometria.TipoDedo.PulgarIzquierdo
                        End If

                End Select

                Return value
            End Get
        End Property

        Public ReadOnly Property ManoIzquierda As String
            Get

                Dim value As String = ""

                Select Case TipoCapturaIzquierdo
                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado
                        value = "Amputado"

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal

                        If IDIndiceIzquierdo > 0 Then
                            value = "Indice Izquierdo"
                        End If

                        If IDPulgarIzquierdo > 0 Then
                            value = "Pulgar Izquierdo"
                        End If

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado
                        value = "Observado"
                End Select

                Return value

            End Get
        End Property
        Public ReadOnly Property ManoIzquierdaCalidad As Short
            Get
                Dim value As Short = -1

                Select Case TipoCapturaIzquierdo

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal

                        If IDIndiceIzquierdo > 0 Then
                            value = CalidadIndiceIzquierdo
                        End If

                        If IDPulgarIzquierdo > 0 Then
                            value = CalidadPulgarIzquierdo
                        End If

                End Select

                Return value
            End Get
        End Property

        Public Property TipoCapturaDerecho As Short = -1
        Public Property IDIndiceDerecho As Integer = -1
        Public Property CalidadIndiceDerecho As Short = -1
        Public Property IDPulgarDerecho As Integer = -1
        Public Property CalidadPulgarDerecho As Short = -1
        Public Property ObservacionDerecho As String = ""

        Public Property IDTemplateIndiceIzquierdo As Integer = -1
        Public Property IDTemplateIndiceDerecho As Integer = -1

        Public Property IDTemplatePulgarIzquierdo As Integer = -1
        Public Property IDTemplatePulgarDerecho As Integer = -1

        Public ReadOnly Property TipoDedoDerecho As Short
            Get
                Dim value As Type.Enumeracion.Biometria.TipoDedo = Type.Enumeracion.Biometria.TipoDedo.Ninguno

                Select Case TipoCapturaDerecho

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal

                        If IDIndiceDerecho > 0 Then
                            value = Type.Enumeracion.Biometria.TipoDedo.IndiceDerecho
                        End If

                        If IDPulgarDerecho > 0 Then
                            value = Type.Enumeracion.Biometria.TipoDedo.PulgarDerecho
                        End If

                End Select

                Return value
            End Get
        End Property

        Public ReadOnly Property ManoDerecha As String
            Get

                Dim value As String = ""

                Select Case TipoCapturaDerecho
                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado
                        value = "Amputado"
                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal

                        If IDIndiceDerecho > 0 Then
                            value = "Indice Derecho"
                        End If

                        If IDPulgarDerecho > 0 Then
                            value = "Pulgar Derecho"
                        End If

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado
                        value = "Observado"
                End Select

                Return value

            End Get
        End Property

        Public ReadOnly Property ManoDerechaCalidad As Short
            Get
                Dim value As Short = -1

                Select Case TipoCapturaDerecho

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal

                        If IDIndiceDerecho > 0 Then
                            value = CalidadIndiceDerecho
                        End If

                        If IDPulgarDerecho > 0 Then
                            value = CalidadPulgarDerecho
                        End If

                End Select

                Return value
            End Get
        End Property
        Public Property IDRegion() As Short = -1
        Public Property IDPenal() As Short = -1

#Region "Otros"
        Public Property Item As String = ""
#End Region
#Region "Filtro"
        Public Property FechaInicio As Long = 0
        Public Property FechaFin As Long = 0
#End Region
    End Class

    Public Class InternoHuellaTratamientoCol
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
        Public Function Add(ByVal obj As VisitanteHuella) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public Function Delete(Index As Integer) As Boolean
            Try
                MyBase.List.RemoveAt(Index)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
        Public Function Remove(index As Integer) As Boolean
            Try
                MyBase.List.RemoveAt(index)
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function
        Public ReadOnly Property Item(ByVal Index As Integer) As VisitanteHuella
            Get
                Try
                    Return CType(MyBase.List(Index), VisitanteHuella)
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property
        Public ReadOnly Property VisitanteHuella(ByVal Index As Integer) As VisitanteHuella
            Get
                Try
                    Return CType(MyBase.List(Index), VisitanteHuella)
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property
    End Class

End Namespace