Namespace Registro
    Public Class InternoReniecModel
        'Inherits Legolas.LEntity.Globall.Persona
#Region "Propiedades"
        Public Property TipoConsulta As Integer
        Public Property ConsultaNumeroDNI As String
        Public Property ConsultaPrimerApellido As String
        Public Property ConsultaSegundoApellido As String
        Public Property ConsultaPreNombres As String
        Public Property Login As String
        Public Property MAC As String
        Public Property IP As String
        Public Property KeySistema As String
        Public Property ClaveSistema As String
        Public Property IDModulo As Integer
        Public Property Modulo As String
        '----------------------------------------------
        Public Property numeroDNI As String
        Public Property digitoVerificacion As String
        Public Property apellidoPaterno As String
        Public Property apellidoMaterno As String
        Public Property apellidoCasada As String
        Public Property nombres As String
        Public Property codigoUbigeoDepartamentoDomicilio As String
        Public Property codigoUbigeoProvinciaDomicilio As String
        Public Property codigoUbigeoDistritoDomicilio As String
        Public Property departamentoDomicilio As String
        Public Property provinciaDomicilio As String
        Public Property distritoDomicilio As String
        Public Property estadoCivil As String
        Public Property codigoGradoInstruccion As String
        Public Property estatura As String
        Public Property sexo As String
        Public Property documentoSustentatorioTipo As String
        Public Property documentoSustentatorioNumero As String
        Public Property codigoUbigeoDepartamentoNacimiento As String
        Public Property codigoUbigeoProvinciaNacimiento As String
        Public Property codigoUbigeoDistritoNacimiento As String
        Public Property departamentoNacimiento As String
        Public Property provinciaNacimiento As String
        Public Property distritoNacimiento As String
        Public Property fechaNacimiento As String
        Public Property nombrePadre As String
        Public Property nombreMadre As String
        Public Property fechaInscripcion As String
        Public Property fechaExpedicion As String
        Public Property constanciaVotacion As String
        Public Property restriccion As String
        Public Property restriccionMensaje As String
        Public Property prefijoDireccion As String
        Public Property direccion As String
        Public Property numeroDireccion As String
        Public Property blockChalet As String
        Public Property interior As String
        Public Property urbanizacion As String
        Public Property etapa As String
        Public Property manzana As String
        Public Property lote As String
        Public Property prefijoBlockChalet As String
        Public Property prefijoDepartamentoInterior As String
        Public Property prefijoUrbanizacion As String
        Public Property fotoByte As String
        Public Property firmaByte As String
        Public Property restriccionRegistroPenitenciario As Boolean
        Public Property restriccionAntecedentesJudiciales As Boolean
        Public Property restriccionTratamientoPenitenciario As Boolean
        Public Property restriccionMedioLibre As Boolean
        Public Property ubigeo As String
        Public Property codigoError As String
        Public Property mensajeError As String
        Public Property coincidencia As List(Of Coincidencia)
        Public Property numeroTotalCoincidencias As String
        '--------------------------------------------------
        'Public ReadOnly Property TipoBusquedaNom() As String
        '    Get
        '        ''Resultado()
        '        Dim valor As String = ""
        '        Select Case TipoBusquedaID
        '            Case Type.Enumeracion.Reniec.EnmTipoResultado.Validado
        '                valor = "VALIDADO"
        '            Case Type.Enumeracion.Reniec.EnmTipoResultado.Observado
        '                valor = "OBSERVADO"
        '            Case Type.Enumeracion.Reniec.EnmTipoResultado.No_Encontrado
        '                valor = "NO ENCONTRADO"
        '            Case Else
        '                valor = ""
        '        End Select
        '        Return valor
        '    End Get
        'End Property
        Public Property ComparacionID() As Integer = -1
        Public ReadOnly Property ComparacionNom() As String
            Get
                ''Tipo de comparacion
                Dim valor As String = ""
                Select Case ComparacionID
                    Case Type.Enumeracion.Reniec.EnmTipoValidacion.DNI
                        valor = "DNI"
                    Case Type.Enumeracion.Reniec.EnmTipoValidacion.DatosPrincipales
                        valor = "NOMBRE PRINCIPAL"
                    Case Type.Enumeracion.Reniec.EnmTipoValidacion.NombreAsociado
                        valor = "NOMBRE ASOCIADO"
                    Case Else
                        valor = ""

                End Select
                Return valor
            End Get
        End Property
        Public Property FotoReniec() As Integer = -1
        Public Property FotoInterno() As Integer = -1

        Public Property InternoSisMetadata() As String = ""
        Public Property InternoSisData() As String = ""
        Public Property NombresAsociados() As String = ""
        Public Property NombresAsociadosID() As String = ""
        Public Property NombresAsociadosNom() As String = ""
        Public Property ReniecMetadata() As String = ""
        Public Property ReniecData() As String = ""
        Public Property Observaciones() As String = ""

        Public Property PthServidor() As String = "" 'ruta servidor de la foto reniec

        Public Property PthServidorFotoInterno() As String = "" 'ruta servidor de la foto del interno
        Public Property NombreFotoInterno() As String = "" 'nombre de la foto del interno dentro de la tabla InternoReniec

        Public Property FechaValidacion As Long = 0
        Public Property RegionID() As Integer = -1
        Public Property RegionNombre() As String = ""
        Public Property PenalNombre() As String = ""
        Public Property PenalID() As Integer = -1
        Public Property FotoTipo() As Integer = -1
        Public Property PFrenteInt As Integer = -1
        Public Property PFrenteRnc As Integer = -1
        Public Property PFrenteName As String = "" 'nombre de la foto reniec
        Public Property CodigoHistorial As Integer = -1



        Public Property NombreAsociadoVal_ID() As Integer = -1
        Public Property NombreAsociadoVal_Nom() As String = ""
        Public ReadOnly Property FechaHoraPM() As String
            Get
                Dim f As Date
                Dim Fecha_ As String
                Dim Hora As String
                Dim Minuto As String
                Fecha_ = Legolas.Components.FechaHora.FechaDate(Me.FechaValidacion, False)
                f = Legolas.Components.FechaHora.FechaDate(Me.FechaValidacion, True)
                Hora = CDate(f).Hour
                Minuto = CDate(f).Minute
                If Hora = 0 Then
                    Hora = "00"
                End If
                If Minuto = 0 Then
                    Minuto = "00"
                End If
                If Len(Hora) = 1 Then
                    Hora = 0 & Hora
                End If
                If Len(Minuto) = 1 Then
                    Minuto = 0 & Minuto
                End If
                Fecha_ = Fecha_ & " " & Hora & ":" & Minuto
                Return Fecha_
            End Get
        End Property

#End Region
    End Class
#Region "InternoValidadoCol"
    'Public Class InternoValidadoCol
    '    Inherits System.Collections.CollectionBase
    '    Private _enmSortDirection As SortDirection
    '    Public Sub New()
    '        _enmSortDirection = SortDirection.Asc
    '    End Sub
    '    Public Sub Sort(ByVal sortExpression As String, ByVal sortDirection As SortDirection)
    '        InnerList.Sort(New Comparer(sortExpression, sortDirection))
    '    End Sub
    '    Public Sub Sort(ByVal sortExpression As String)
    '        InnerList.Sort(New Comparer(sortExpression, _enmSortDirection))
    '        If _enmSortDirection = SortDirection.Asc Then
    '            _enmSortDirection = SortDirection.Desc
    '        Else
    '            _enmSortDirection = SortDirection.Asc
    '        End If

    '    End Sub
    '    Public Function Add(ByVal obj As InternoReniec) As Integer
    '        Return MyBase.List.Add(obj)
    '    End Function
    '    Public ReadOnly Property Historial(ByVal Index As Integer) As InternoReniec
    '        Get
    '            Return CType(MyBase.List(Index), InternoReniec)
    '        End Get
    '    End Property
    'End Class
#End Region
    Public Class Coincidencia
        Public Property numeroDNI As String
        Public Property caracterVerificacion As String
        Public Property tipoFichaRegistral As String
        Public Property apellidoPaterno As String
        Public Property apellidoMaterno As String
        Public Property preNombres As String
        Public Property datos As String
        Public Property imagen As String
        Public Property reservado As String
    End Class
End Namespace

