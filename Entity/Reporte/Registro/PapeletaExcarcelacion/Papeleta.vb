Namespace Reporte.PapeletaExcarcelacion
    Public Class Papeleta
#Region "Propiedades"
        Private strCodigoRP As String = ""
        Private strApellidoPrimero As String = ""
        Private strApellidoSegundo As String = ""
        Private strPreNombres As String = ""
        Private strPenalNombre As String = ""
        Private strPathInternoWeb As String = ""
        Private strFotoPerfilCentral As String = ""
        Public Property CodigoRP() As String
            Get
                Return strCodigoRP
            End Get
            Set(ByVal value As String)
                strCodigoRP = value
            End Set
        End Property
        Public Property ApellidoPrimero() As String
            Get
                Return strApellidoPrimero
            End Get
            Set(ByVal value As String)
                strApellidoPrimero = value
            End Set
        End Property
        Public Property ApellidoSegundo() As String
            Get
                Return strApellidoSegundo
            End Get
            Set(ByVal value As String)
                strApellidoSegundo = value
            End Set
        End Property
        Public Property PreNombres() As String
            Get
                Return strPreNombres
            End Get
            Set(ByVal value As String)
                strPreNombres = value
            End Set
        End Property
        Public ReadOnly Property ApellidosyPreNombres() As String
            Get
                Dim value As String = ""
                value = Me.ApellidoPrimero & " " & Me.ApellidoSegundo & ", " & Me.PreNombres
                Return value.ToUpper
            End Get
        End Property
        Public Property PenalNombre() As String
            Get
                Return strPenalNombre.ToUpper
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property
        'Public Property PathInternoWeb() As String
        '    Get
        '        Return strPathInternoWeb
        '    End Get
        '    Set(ByVal value As String)
        '        strPathInternoWeb = value
        '    End Set
        'End Property
        Public Property FotoPerfilCentral() As String
            Get
                Return strFotoPerfilCentral
            End Get
            Set(ByVal value As String)
                strFotoPerfilCentral = value
            End Set
        End Property
        'Public ReadOnly Property PathInternoFoto() As String
        '    Get
        '        Dim value As String = ""
        '        value = Me.PathInternoWeb & "/" & Me.FotoPerfilCentral
        '        Return value
        '    End Get
        'End Property
        Public ReadOnly Property FotoPC() As Byte()
            Get

                Dim value As Byte() = Nothing
                Dim strFotoNameExtension As String = Me.FotoPerfilCentral.Trim

                If strFotoNameExtension.Trim = "" Then
                    value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.sin_foto)
                Else
                    'si hay foto
                    'Dim objWS As New APPWebService.ws_foto.PopeLocal
                    'objWS.Url = APPWebService.PathURL.FotoLocal

                    'value = objWS.LeerImageJpg(strFotoNameExtension, 1) 'interno

                    'If value Is Nothing = True Then
                    '    value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.sin_foto)
                    'End If

                End If

                Return value

            End Get
        End Property
#Region "Ingreso"
        Private strPenalProcedencia As String = ""
        Private lngFechaIngreso As Long = 0
        Private strExpedienteSalaJuzgado As String = ""
        Private strExpedienteNumero As String = ""
        Private lngInternoIngresoID As Long = 0
        Private lngInternoExpedienteID As Long = 0
        Public Property InternoIngresoID() As Long
            Get
                Return lngInternoIngresoID
            End Get
            Set(ByVal value As Long)
                lngInternoIngresoID = value
            End Set
        End Property
        Public Property InternoExpedienteID() As Long
            Get
                Return lngInternoExpedienteID
            End Get
            Set(ByVal value As Long)
                lngInternoExpedienteID = value
            End Set
        End Property
        Public Property PenalProcedencia() As String
            Get
                Return strPenalProcedencia.ToUpper
            End Get
            Set(ByVal value As String)
                strPenalProcedencia = value
            End Set
        End Property
        Public Property FechaIngreso() As Long
            Get
                Return lngFechaIngreso
            End Get
            Set(ByVal value As Long)
                lngFechaIngreso = value
            End Set
        End Property
        Public ReadOnly Property FechaIngresoString() As String
            Get
                Return Legolas.Components.FechaHora.FechaText(Me.FechaIngreso, Legolas.Components.FechaHora.enmFechaLong.enmdma)
            End Get

        End Property
        Public Property ExpedienteSalaJuzgado() As String
            Get
                Return strExpedienteSalaJuzgado.ToUpper
            End Get
            Set(ByVal value As String)
                strExpedienteSalaJuzgado = value
            End Set
        End Property
        Public Property ExpedienteNumero() As String
            Get
                Return strExpedienteNumero.ToUpper
            End Get
            Set(ByVal value As String)
                strExpedienteNumero = value
            End Set
        End Property
#End Region
#Region "Egreso"
        Private lngFechaEgreso As Long = 0
        Private strLibertadSalaJuzgado As String = ""
        Private strLibertadNumeroDocumento As String = ""
        Private strLibertadSecretario As String = ""
        Private strDelito As String = ""
        Private intLibertadTipoID As Integer = -1
        Private strLibertadTipo As String = ""
        Private strDireccion As String = ""
        Public Property FechaEgreso() As Long
            Get
                Return lngFechaEgreso
            End Get
            Set(ByVal value As Long)
                lngFechaEgreso = value
            End Set
        End Property
        Public ReadOnly Property FechaEgresoString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaEgreso)
            End Get
        End Property
        Public Property LibertadSalaJuzgado() As String
            Get
                Return strLibertadSalaJuzgado.ToUpper
            End Get
            Set(ByVal value As String)
                strLibertadSalaJuzgado = value
            End Set
        End Property
        Public Property LibertadNumeroDocumento() As String
            Get
                Return strLibertadNumeroDocumento.ToUpper
            End Get
            Set(ByVal value As String)
                strLibertadNumeroDocumento = value
            End Set
        End Property
        Public Property LibertadSecretario() As String
            Get
                Return strLibertadSecretario.ToUpper
            End Get
            Set(ByVal value As String)
                strLibertadSecretario = value
            End Set
        End Property
        Public Property Delito() As String
            Get
                Return strDelito.ToUpper
            End Get
            Set(ByVal value As String)
                strDelito = value
            End Set
        End Property
        Public Property LibertadTipoID() As Integer
            Get
                Return intLibertadTipoID
            End Get
            Set(ByVal value As Integer)
                intLibertadTipoID = value
            End Set
        End Property
        Public Property LibertadTipo() As String
            Get
                Return strLibertadTipo.ToUpper
            End Get
            Set(ByVal value As String)
                strLibertadTipo = value
            End Set
        End Property
        Public Property Direccion() As String
            Get
                Return strDireccion.ToUpper
            End Get
            Set(ByVal value As String)
                strDireccion = value
            End Set
        End Property
#End Region
#End Region
    End Class
#Region "PapeletaCol"
    Public Class PapeletaCol
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
        Public Function Add(ByVal obj As Papeleta) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Papeleta(ByVal Index As Integer) As Papeleta
            Get
                Return CType(MyBase.List(Index), Papeleta)
            End Get
        End Property
    End Class
#End Region
End Namespace