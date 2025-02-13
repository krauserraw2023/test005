
Namespace Tratamiento.TallerAsistencia
    Public Class InternoAsistencia
        Inherits Legolas.LEntity.Globall.Persona

#Region "Propiedades"

        Public Property Codigo As Integer = -1
        '------------------------------
        Private strNacimientoOtros As String = ""
        Private strDomicilio As String = ""
        Private strEstado As String = ""
        Private strOcupacionNombre As String = ""
        Private strNivelAcademicoNombre As String = ""
        Private strProfesionNombre As String = ""
        Private strComunidadAndinaNombre As String = ""
        Private strObs As String = ""
        Public Property SedeRowId As Integer = -1
        '-----------------------------
        Public Property FlagTransferenciaSede As Integer = 0
        Public Property InternoID() As Integer = -1
        Public Property Contador() As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property IngresoID() As Integer = -1
        Public Property ExpedienteID() As Integer = -1
        Public Property NombreClaveInterno As String = ""
        Public Property CodigoUnicoInternoId As Integer = -1
        Public Property CodigoUnicoInterno As String = ""
        Public Property CodigoPadre() As Integer = -1
        Public Property CodigoRP() As String = ""
        Public Property ApellidosNombres() As String = ""
        Public Property NombrePadre() As String = ""
        Public Property NombreMadre() As String = ""
        Public Property Tipo As Boolean = False

        Public Property EstadoID() As Integer = -1
        Public Property FechaInscripcion() As Long = 0
        Public Property CodigoTaller() As Integer = -1
        Public Property TallerNombre() As String = ""
        Public Property ActividadNombre() As String = 0
        Public Property TipoActividadNombre() As String = 0
        Public Property InternoHuellaID() As Integer = -1
        Public Property TipoCapturaDerID() As Integer = -1
        Public Property TipoCapturaIzqID() As Integer = -1
        Public ReadOnly Property EstadoNombre() As String
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
        Public ReadOnly Property TipoNumeroDocumento() As String
            Get
                Dim value As String = ""

                If Me.TipoDocumentoID > 0 Then
                    value = Me.TipoDocumentoNombre
                End If
                If Me.NumeroDocumento.Length > 0 Then
                    If value.Length > 0 Then
                        value = value & " - " & Me.NumeroDocumento
                    Else
                        value = Me.NumeroDocumento
                    End If
                End If

                Return value.ToUpper
            End Get
        End Property
        Public Property Observacion As String = ""
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
        Public Property FechaFinBusqueda As Long = 0
        Public Property Anio As Integer = -1
        Public Property Mes As Integer = -1

        Public Property IngresoSistemaPen As Long = 0
        Public Property Eliminado As Integer = 0
        Public Property NumeroDocumentoAux As String = ""
        Public Property Idioma() As String = ""

        '------- agregados 2017
        Public Property GeneroId As Integer = -1
        Public Property IdiomaNativoId As Integer = -1


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
        Public Property MotivoRetiroID() As Integer = -1
        Public Property MotivoJustificacionID() As Integer = -1
        Public Property MotivoJustificacionNombre() As String = ""

        Public Property EstadoJustificacion() As Integer = -1
        Public Property Documento As String = ""

        Public Property FechaInicialRetiro As Long = 0
        Public Property FechaFinalRetiro As Long = 0
        Public Property MotivoIngresoNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strTipoIngreso)
            End Get
            Set(ByVal value As String)
                strTipoIngreso = value
            End Set
        End Property
        Public Property MotivoTrasladoID() As Integer = -1


        Public Property Fecha() As Long = 0
        Public Property FechaDocumento() As Long = 0
        Public Property HoraEntrada() As String = ""
        Public Property HoraSalida() As String = ""
        Public Property Tiempo() As Integer = 0
        Public ReadOnly Property FechaDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.Fecha)
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
        Public ReadOnly Property Permanencia() As String
            Get
                Dim Valor As String = ""
                If Me.MotivoJustificacionID = 7 Or (Me.MotivoJustificacionID > 0 And Me.EstadoJustificacion = 0) Then

                    Me.HoraEntrada = "--"
                    Me.HoraSalida = "--"
                    Valor = "00 h 00 min"

                ElseIf Me.HoraSalida.Length = 0 Or Me.HoraSalida = "00:00:00" Then
                    Valor = "No registra salida"
                Else
                    If Me.HoraEntrada.Length = 3 Then
                        Valor = "---"
                    ElseIf Me.HoraEntrada.Length > 3 Then
                        Dim f1 As DateTime = Me.HoraEntrada
                        Dim f2 As DateTime = Me.HoraSalida
                        Valor = DateDiff(DateInterval.Minute, f1, f2)
                        Dim horas As Integer = Valor / 60
                        Dim minutos As Integer = Valor Mod 60
                        Valor = IIf(horas < 10, "0" & horas, horas) & " h " & IIf(minutos < 10, "0" & minutos, minutos) & " min"
                    End If
                End If
                Return Valor
            End Get
        End Property


        Public Property FechaIngreso() As Long = 0
        Public ReadOnly Property FechaIngresoString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaIngreso)
            End Get
        End Property
        Public ReadOnly Property FechaInscripcionString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaInscripcion)
            End Get
        End Property

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
        Public Property IngresoFechaDesde As Long = 0
        Public Property IngresoFechaHasta As Long = 0
        Public Property IDInternoString As String = ""
#End Region
    End Class
#Region "InternoCol"
    Public Class InternoAsistenciaCol
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
        Public Function Add(ByVal value As InternoAsistencia) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As InternoAsistencia) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As InternoAsistencia) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As InternoAsistencia)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As InternoAsistencia
            Get
                Return DirectCast(List(index), InternoAsistencia)
            End Get
            Set(ByVal value As InternoAsistencia)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As InternoAsistencia)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As InternoAsistencia
            Return MyBase.MemberwiseClone
        End Function
        Public Function toList() As List(Of InternoAsistencia)
            Dim a As New List(Of InternoAsistencia)
            For Each i As InternoAsistencia In InnerList
                a.Add(i)
            Next
            Return a
        End Function
    End Class
#End Region
End Namespace
