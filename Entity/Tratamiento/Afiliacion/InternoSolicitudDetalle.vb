Imports System.Linq
Imports System.Data.Linq
Imports System.Xml.Linq
Namespace Tratamiento.Afiliacion
    Public Class InternoSolicitudDetalle
        Inherits Legolas.LEntity.Globall.Persona
#Region "Propiedades"
        '-------------Solicitud--------
        Public Property NumeroSol As Integer = -1
        '------------------------------
        Private strNacimientoOtros As String = ""
        Private strDomicilio As String = ""
        Private strEstado As String = ""
        Private strOcupacionNombre As String = ""
        Private strNivelAcademicoNombre As String = ""
        Private strProfesionNombre As String = ""
        Private strComunidadAndinaNombre As String = ""
        Private strObs As String = ""
        Private blnDMP As Boolean
        Private blnSMP As Boolean
        Public Property SedeRowId As Integer = -1
        '-----------------------------
        Public Property FlagTransferenciaSede As Integer = 0
        Public Property InternoID() As Integer = -1
        Public Property CodigoAfiliacion() As Integer = -1
        Public Property CodigoSolicitud() As Integer = -1
        Public Property CodigoDetSolicitud() As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property IngresoID() As Integer = -1
        Public Property ExpedienteID() As Integer = -1
        Public Property NombreClaveInterno As String = ""
        Public Property CodigoUnicoInternoId As Integer = -1
        Public Property CodigoUnicoInterno As String = ""
        Public Property DocumentoTrasladoID As String = ""
        Public Property SentenciaID() As Integer = -1
        Public Property DelitoID() As Integer = -1
        Public Property CodigoRP() As String = ""
        Public Property CodigoPadre() As Integer = -1
        Public Property Libro() As String = ""
        Public Property Folio() As String = ""
        Public Property NacimientoUbigeoID() As Integer = -1
        Public Property NacimientoOtros() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strNacimientoOtros)
            End Get
            Set(ByVal value As String)
                strNacimientoOtros = value
            End Set
        End Property
        Public Property DomicilioUbigeoID() As Integer = -1
        Public Property Domicilio() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strDomicilio)
            End Get
            Set(ByVal value As String)
                strDomicilio = value
            End Set
        End Property
        Public Property NivelAcademicoID() As Integer = -1
        Public Property NivelAcademicoNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strNivelAcademicoNombre)
            End Get
            Set(ByVal value As String)
                strNivelAcademicoNombre = value
            End Set
        End Property
        Public Property NumeroHijos() As Integer = 0
        Public Property HijosMenores() As Integer = 0
        Public Property ProfesionID() As Integer = -1
        Public Property ProfesionNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strProfesionNombre)
            End Get
            Set(ByVal value As String)
                strProfesionNombre = value
            End Set
        End Property
        Public Property Tipo As Boolean = False

        Public Property EstadoID() As Integer = -1
        Public Property EstadoDetalleID() As Integer = -1
        Public ReadOnly Property EstadoNombreReadonly() As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoID
                    Case 0
                        value = "Inactivo"
                    Case 1
                        value = "Activo"
                End Select

                Return value.ToUpper
            End Get
        End Property
        Public ReadOnly Property EstadoDetalleNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoDetalleID
                    Case 1
                        value = "PENDIENTE"
                    Case 2
                        value = "ENVIADO"
                    Case 3
                        value = "ATENDIDO"
                End Select

                Return value.ToUpper
            End Get
        End Property
        Public ReadOnly Property EstadoSolicitudNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoID
                    Case 1
                        value = "PENDIENTE"
                    Case 2
                        value = "ENVIADO"
                    Case 3
                        value = "ATENDIDO"
                End Select

                Return value
            End Get
        End Property
        Public ReadOnly Property ObservacionRegistro As String
            Get
                Dim Value As String = "NO"
                If Me.ApellidoPaterno.Length > 0 And Me.ApellidoMaterno.Length > 0 And Me.Nombres.Length > 0 And _
                   Me.TipoDocumentoID = 10 And NumeroDocumento.Length = 8 And Me.FechaNacimiento > 0 And Me.SexoID > -1 Then
                    Value = ""
                End If
                Return Value
            End Get
        End Property
        Public ReadOnly Property ObservacionRegistroImg() As System.Drawing.Bitmap
            Get
                If ObservacionRegistro.Trim = "" Then
                    Return My.Resources.check_box_black
                Else
                    Return My.Resources.warning_32x32
                End If
            End Get
        End Property
        Public Property Email() As String = ""
        Public Property EstadoRncID As Integer = -1

        Public ReadOnly Property EstadoRnc As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoRncID
                    Case 1
                        value = "VAL" 'validado
                    Case 2
                        value = "OBS" 'observado
                    Case 3
                        value = "NEC" 'no encontrado
                End Select
                Return value
            End Get
        End Property
        Public Property EstadoEspecificoID As Integer = -1
        'Public Property EstadoEspecificoNombre As Integer = -1
        Public ReadOnly Property EstadoEspecificoNombre As String
            Get
                Dim value As String = ""
                If Me.CodigoRP = "" Then
                    value = ""
                Else
                    Select Case Me.EstadoEspecificoID
                        Case 1
                            value = "RECLUIDO"
                        Case 2
                            value = "FUGA"
                        Case 3
                            value = "FALLECIDO"
                        Case 4
                            value = "EN CONDUCCION"
                        Case 5
                            value = "CON LIBERTAD"
                        Case 6
                            value = "EN TRASLADO"
                        Case 7
                            value = "Pendiente de Egreso"
                        Case 0, -1
                            value = "NO REGISTRA"
                        Case Else
                            value = ""
                    End Select
                End If
                Return value
            End Get
        End Property
        Public Property TipoPoblacion As String = "43"
        Public Property FechaInicioBusqueda As Long = 0
        Public Property FechaBusqueda As Long = 0
        Public Property Anio As Integer = -1
        Public Property Mes As Integer = -1

        Public Property IngresoSistemaPen As Long = 0
        Public Property Eliminado As Integer = 0
        Public Property NumeroDocumentoAux As String = ""
        Public Property Idioma() As String = ""

        '------- agregados 2017
        Public Property GeneroId As Integer = -1
        Public Property IdiomaNativoId As Integer = -1


        Public ReadOnly Property TipoDocumentoEnv As Integer
            Get
                Dim value As Integer = -1
                If Me.CodigoRP = "" Then
                    value = ""
                Else
                    Select Case Me.TipoDocumentoID
                        Case 10
                            value = 1
                        Case Else
                            value = Me.TipoDocumentoID
                    End Select
                End If
                Return value
            End Get
        End Property
#Region "Ubicacion"
        Private strPenalNombre As String = ""
        Public Property RegionID() As Integer = -1
        Public Property RegionNombre() As String = ""
        Public Property RegionCodigo() As String = ""
        Public Property PenalID() As Integer = -1
        Public Property PenalCodigo() As String = ""
        Public Property PenalNombre() As String
            Get
                Return strPenalNombre.ToUpper
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property
        Public Property RegionRegistroID() As Integer = -1
        Public Property PenalRegistroID() As Integer = -1
        Public Property Cantidad() As Integer = 0
        Public Property Ingresos() As Integer = 0
        Public Property Egresos() As Integer = 0
        Public Property Traslados() As Integer = 0
#End Region
#End Region

#Region "Propiedades_Ubigeo"
        Public Property Departamento() As String = ""
        Public Property Provincia() As String = ""
        Public Property Distrito() As String = ""
        Public ReadOnly Property Ubigeo() As String
            Get
                Dim strValue As String = ""

                strValue = Me.Departamento & "/" & Me.Provincia & "/" & Me.Distrito
                Return Legolas.Components.Cadena.ProperCase(strValue)
            End Get
        End Property
        Public Property Nac_Departamento As String = ""
        Public Property Nac_Provincia As String = ""
        Public Property Nac_Distrito As String = ""
#End Region

#Region "Propiedades_Ingreso"
        Private intIngresoNumero As Integer = -1
        Private strTipoIngreso As String = ""
        Public Property IngresoNumero() As Integer
            Get
                Return intIngresoNumero
            End Get
            Set(ByVal value As Integer)
                intIngresoNumero = value
            End Set
        End Property
        Public Property IngresoAux() As Integer = -1
        Public Property SituacionJuridicaId() As Integer = -1
        Public Property SituacionJuridicaNom() As String = ""
        Public ReadOnly Property SituacionJuridicaReadonly() As String
            Get
                Dim value As String = ""

                Select Case Me.SituacionJuridicaId
                    Case 1
                        value = "PROC."
                    Case 2
                        value = "SENT."
                    Case 3
                        value = "SENT./PROC."
                    Case Else
                        value = ""
                End Select

                Return value

            End Get
        End Property

        Public Property MotivoIngresoID() As Integer = -1
        Public Property MotivoIngresoNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strTipoIngreso)
            End Get
            Set(ByVal value As String)
                strTipoIngreso = value
            End Set
        End Property
        Public Property MotivoTrasladoID() As Integer = -1
        Public Property MotivoTrasladoNombre() As String = ""

        Public Property FechaRegistro() As Long = 0
        Public Property FechaEnvio() As Long = 0
        Public Property FechaIngreso() As Long = 0
        Public ReadOnly Property FechaIngresoDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaIngreso)
            End Get
        End Property
        Public ReadOnly Property FechaNacimientoStr() As String
            Get
                Dim value As String = ""
                If Me.FechaNacimiento > 0 Then
                    Dim fecha As Date = Legolas.Components.FechaHora.FechaString(Me.FechaNacimiento)
                    value = fecha.ToString("yyyyMMdd")
                End If
                Return value
            End Get
        End Property
        Public Property NumeroDocumentoIngreso() As String = ""
        Public Property PenalOrigenNombre() As String = ""
#End Region
#Region "Propiedades_Libertad"
        Private strDistritoJudicialNombre As String = ""
        Private strJuzgadoNombre As String = ""
        Private strDocumentoSalida As String = ""
        Private strTipoLibertad As String = ""
        Private strSalaSentencia As String = ""
        Public Property LibertadDistritoJudicialNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strDistritoJudicialNombre)
            End Get
            Set(ByVal value As String)
                strDistritoJudicialNombre = value
            End Set
        End Property
        Public Property LibertadJuzgadoNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strJuzgadoNombre)
            End Get
            Set(ByVal value As String)
                strJuzgadoNombre = value
            End Set
        End Property
        Public Property DocumentoLibertad() As String = ""
        Public Property DocumentoExpedienteLibertad() As String = ""
        Public Property TipoLibertad() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strTipoLibertad)
            End Get
            Set(ByVal value As String)
                strTipoLibertad = value
            End Set
        End Property
        Public Property FechaLibertad() As Long = 0
        Public ReadOnly Property FechaLibertadString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaLibertad)
            End Get
        End Property

        Public Property EgresoTipoID() As Integer = -1
        Public Property EgresoTipo() As String = ""
        Public Property EgresoTipoMotivoID As Integer = -1
        Public Property EgresoTipoMotivo As String = ""

        Public Property TipoMovimientoID() As Integer = -1

        Public ReadOnly Property TipoMovimientoNom() As String
            Get
                Dim Value As Integer = -1
                Dim Nombre As String = ""

                If TipoMovimientoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad Then
                    Value = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                    Nombre = "LIBERTAD"
                ElseIf TipoMovimientoID = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento Then
                    Value = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
                    Nombre = "INGRESO"
                ElseIf TipoMovimientoID = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado Then
                    Value = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado
                    Nombre = "TRASLADO"
                End If
                Return Nombre
            End Get
        End Property

        Public ReadOnly Property TipoOperacion() As String
            Get
                Dim Value As String = ""
                Select Case Me.TipoMovimientoID
                    Case Type.Enumeracion.Movimiento.EnumMovTipo.Libertad, Type.Enumeracion.Movimiento.EnumMovTipo.Fallecimiento
                        Value = "B"
                    Case Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
                        Value = "A"
                    Case Type.Enumeracion.Movimiento.EnumMovTipo.Traslado
                        Value = "T"
                End Select
                Return Value
            End Get
        End Property

#End Region
#Region "Propiedades_Foto"
        Private intFotoPerfilIzquierdo As Integer = 0
        Private intFotoPerfilFrente As Integer = 0
        Private intFotoPerfilDerecho As Integer = 0
        Public Property FotoPerfilIzquierdo() As Integer = -1
        Public ReadOnly Property FotoPI() As Boolean
            Get
                Dim value As Boolean = False

                If Me.FotoPerfilIzquierdo > 0 Then
                    value = True
                End If

                Return value
            End Get
        End Property
        Public ReadOnly Property FotoIconoPI() As System.Drawing.Image
            Get
                Dim value As System.Drawing.Image = My.Resources.check_box_black

                Select Case Me.CodigoPadre
                    Case 0

                        If Me.FotoPerfilIzquierdo > 0 Then
                            value = My.Resources.check_box_green
                        Else
                            value = My.Resources.check_box_green2
                        End If

                    Case 1
                        value = My.Resources.check_box_black
                End Select

                Return value
            End Get
        End Property
        Public Property FotoPerfilFrente() As Integer = -1
        Public ReadOnly Property FotoPF() As Boolean
            Get
                Dim value As Boolean = False

                If Me.FotoPerfilFrente > 0 Then
                    value = True
                End If

                Return value
            End Get
        End Property
        Public ReadOnly Property FotoIconoPF() As System.Drawing.Image
            Get

                Dim value As System.Drawing.Image = My.Resources.check_box_black

                Select Case Me.CodigoPadre
                    Case 0
                        If Me.FotoPerfilFrente > 0 Then
                            value = My.Resources.check_box_green
                        Else
                            value = My.Resources.check_box_green2
                        End If
                    Case 1
                        value = My.Resources.check_box_black
                End Select

                Return value
            End Get
        End Property
        Public Property FotoPerfilDerecho() As Integer = -1
        Public ReadOnly Property FotoPD() As Boolean
            Get
                Dim value As Boolean = False

                If Me.FotoPerfilDerecho > 0 Then
                    value = True
                End If

                Return value
            End Get
        End Property
        Public ReadOnly Property FotoIconoPD() As System.Drawing.Image
            Get
                Dim value As System.Drawing.Image = My.Resources.check_box_black

                Select Case Me.CodigoPadre

                    Case 0
                        If Me.FotoPerfilDerecho > 0 Then
                            value = My.Resources.check_box_green
                        Else
                            value = My.Resources.check_box_green2
                        End If
                    Case 1
                        value = My.Resources.check_box_black
                End Select

                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Visita"
        Public Property VisitaSancion() As Boolean = False
        Public ReadOnly Property VisitaSancionStr() As String
            Get
                Dim _str As String = ""
                If VisitaSancion = True Then
                    _str = "Sancionado"
                End If
                Return _str
            End Get
        End Property

#End Region
#Region "Propiedades_Filtro"
        Public Property NacionalidadExtranjero As Integer = -1
        Public Property DelitoGenericoID As Integer = -1
        Public Property DelitoEspecificoID As Integer = -1
        Public Property IngresoFechaDesde As Long = 0
        Public Property IngresoFechaHasta As Long = 0
        Public Property PenalMultiple As String = ""
        Public Property IDInternoString As String = ""
#End Region

    End Class
#Region "InternoCol"
    Public Class InternoSolicitudDetalleCol
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
        Public Function Add(ByVal value As InternoSolicitud) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As InternoSolicitud) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As InternoSolicitud) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As InternoSolicitud)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As InternoSolicitud
            Get
                Return DirectCast(List(index), InternoSolicitud)
            End Get
            Set(ByVal value As InternoSolicitud)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As InternoSolicitud)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As InternoSolicitud
            Return MyBase.MemberwiseClone
        End Function
        Public Function toList() As List(Of InternoSolicitud)
            Dim a As New List(Of InternoSolicitud)
            For Each i As InternoSolicitud In InnerList
                a.Add(i)
            Next
            Return a
        End Function
    End Class
#End Region
End Namespace
