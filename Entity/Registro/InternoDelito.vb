Option Explicit On
Namespace Registro
    Public Class Delito
        Inherits Auditoria.Transaccion

#Region "Propiedades"
        'prueba 0001
        Public Property SedeRowId As Integer = -1
        Public Property FlagTransferenciaSede As Integer = 0
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia
        Private strDelitoGenericoNombre As String = ""
        Private strDelitoEspecificoNombre As String = ""
        Public Property Codigo() As Integer = -1
        Public Property CodigodelitoPad() As Integer = -1
        Public Property strCodigodelitoPad() As String = ""
        Public Property ExpedienteID() As Integer = -1
        Public Property Expedientenumero() As String = ""
        Public Property IngresoID() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property DelitoGenerico() As Integer = -1
        Public Property DelitoGenericoNombre() As String
            Get
                Return UCase(strDelitoGenericoNombre) 'Legolas.Components.Cadena.ProperCase(strDelitoGenericoNombre)
            End Get
            Set(ByVal value As String)
                strDelitoGenericoNombre = value
            End Set
        End Property
        Public Property DelitoEspecifico() As Integer = -1
        Public Property DelitoEspecificoNombre() As String
            Get
                Return UCase(strDelitoEspecificoNombre) ' Legolas.Components.Cadena.ProperCase(strDelitoEspecificoNombre)
            End Get
            Set(ByVal value As String)
                strDelitoEspecificoNombre = value
            End Set
        End Property
        Public Property DelitoEspecificoEstado() As Integer = 1
        Public Property Observacion() As String = ""
        Public Property DelitoMayorPena() As Boolean = False
        Public Property DelitoSentenciaMayorPena() As Boolean = False
        Public Property Estado() As Integer = Type.Enumeracion.EstadoNulidadRegistro.EnumEstadoNulidadRegistro.Activo
        Public Property VisibleAuxiliar As Boolean = False

        Public Property AgraviadoId() As Integer = -1
        Public Property AgraviadoNombre() As String = ""
        Public Property AgraviadoObservacion() As String = ""
        Public Property AgraviadoPadre() As Integer = -1
        Public Property AgraviadoAnulacion() As Integer = 0
        Public Property TipoSentenciaId As Integer = -1

        Public ReadOnly Property EstadoImage() As System.Drawing.Image
            Get
                Dim objImagen As Drawing.Image = My.Resources.check_box_black

                If Me.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_total Then
                    objImagen = My.Resources.cuadro_rojo
                ElseIf Me.Anulacion = Type.Enumeracion.enmEstadoAnulado.Anulado_parcial Then
                    objImagen = My.Resources.cuadro_naranja
                End If
                Return objImagen
            End Get
        End Property
        Public ReadOnly Property Eliminar() As System.Drawing.Image
            Get
                Dim objImagen As Drawing.Image
                objImagen = My.Resources.delete_32
                Return objImagen
            End Get
        End Property
        Public Property CreaDocJudicialId() As Integer = -1 'documento judicial (resolucion) con la cual se crea el exp.-> 26-06-2014 x hnrb

        Private lstAgraviados As AgraviadoCol = Nothing
        Public Property ListaAgraviados As AgraviadoCol
            Get
                Return lstAgraviados
            End Get
            Set(ByVal value As AgraviadoCol)
                lstAgraviados = value
            End Set
        End Property
        Public Property DelitoTitulo As String = ""
        Public Property DelitoTipoID As Integer = -1

        Public Property DelitoTipoNombre() As String = ""

        Public Property DelitoArticulo As String = ""
        Public Property DelitoCapituloNro As String = ""
        Public Property DelitoCapituloNombre As String = ""
        Public Property DelitoSeccionNumero As String = ""
        Public Property DelitoSeccionNombre As String = ""
        Public Property DelitoItem As Integer = -1
        Public Property ExpedienteItem As Integer = -1
        Public Property DelitoAuxiliar As Boolean = True
        Public Property DocJudID As Integer = -1
        Public Property Auxiliar As Boolean = False
        Public Property Anulacion As Integer = 0
        Public Property DocumentoTipoID As Integer = -1
        Public Property DocumentoTipoPadID As Integer = -1
        Public ReadOnly Property fechacreacionString() As String
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.Audit_FechaCreacion, True)
            End Get
        End Property
        Public ReadOnly Property fechamodificString() As String
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.Audit_FechaModificacion, True)
            End Get
        End Property
#End Region
#Region "Propiedades_Filtro"
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
#End Region

        Public Sub New()
            lstAgraviados = New AgraviadoCol
        End Sub
    End Class
#Region "DelitoCol"
    Public Class DelitoCol
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
        Public Function Add(ByVal obj As Delito) As Integer
            Return MyBase.List.Add(obj)
        End Function
        'Public Function Add(ByVal obj As Delito) As Integer
        '    Return MyBase.List.Add(obj)
        'End Function
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
        Public ReadOnly Property Item(ByVal Index As Integer) As Delito
            Get
                Try
                    Return CType(MyBase.List(Index), Delito)
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property
        Public ReadOnly Property internoDelito(ByVal Index As Integer) As Delito
            Get
                Try
                    Return CType(MyBase.List(Index), Delito)
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property
        Public ReadOnly Property Delito(ByVal Index As Integer) As Delito
            Get
                Try
                    Return CType(MyBase.List(Index), Delito)
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property
    End Class
#End Region
End Namespace
