Namespace Registro.Reniec
    Public Class uscValidacionReniecV2
#Region "Eventos"
        Public Event _DoubleClick_CargarDetalle(objEntRnc As Entity.Registro.InternoReniec)
        Public Event _DoubleClick_CargarDetalleNomAso(objEntRnc As Entity.Registro.NombreAsociadoCol)
#End Region
#Region "Propiedades"
        Private intInternoID As Integer = -1
        Public Property _InternoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
                ListarDatos()
            End Set
        End Property
        Public Property _CondicionBusqueda As Integer = -1
        Public Property _VarHistorico As Integer = -1
        Public Property _Contador() As Integer = -1
        Public Property _NombreImagen As String = ""
        Private intFotoId As Integer = -1
        Public Property _NumeroImagen As Integer
            Get
                Return intFotoId
            End Get
            Set(value As Integer)
                intFotoId = value
            End Set
        End Property
        Public Property _ListaCabeceraInterno As String = ""
        Public Property _ListaDataInterno As String = ""
        Public Property _NombresAsociados As String = ""
        Public Property _NombresAsociadosID As String = ""
        Public Property _NombresAsociadosData As String = ""
        Public Property _TipoLicencia As Integer = -1
#End Region
#Region "Propiedades_Reniec"
        Public Property ListaRnc As String = ""
        Public Property ListaRncMatriz As String()        
        Public Property TipoValidacion As Integer = -1
#End Region
#Region "Listar"
        Private Sub ListarDatos()
            If Me._InternoID < 1 Then
                Exit Sub
            End If
            UscValidacionDatosInternoV21._TipoLicencia = Me._TipoLicencia
            If Me._Contador < 1 Then
                UscValidacionDatosInternoV21._Version = True
                UscValidacionDatosInternoV21._Contador = Me._Contador
                UscValidacionDatosInternoV21._VarHistorico = Me._VarHistorico
                UscValidacionDatosInternoV21._InternoID = Me._InternoID

                UscValidacionDatosReniecV21._Version = True
                UscValidacionDatosReniecV21._VarHistorico = -1
                UscValidacionDatosReniecV21._Contador = Me._Contador
                UscValidacionDatosReniecV21._InternoID = Me._InternoID
            Else
                If Me._VarHistorico = -1 Then
                    'Validaciondatosinterno = al registro actual del sistema 
                    UscValidacionDatosInternoV21._Version = True
                    UscValidacionDatosInternoV21._Contador = Me._Contador
                    UscValidacionDatosInternoV21._VarHistorico = -1
                    UscValidacionDatosInternoV21._InternoID = Me._InternoID

                    ' ''Validaciondatosreniec = Limpiar el usc
                    UscValidacionDatosReniecV21._Version = True
                    UscValidacionDatosReniecV21._Contador = Me._Contador
                    UscValidacionDatosReniecV21._VarHistorico = -1
                    UscValidacionDatosReniecV21._InternoID = Me._InternoID
                Else
                    UscValidacionDatosReniecV21._Version = True
                    UscValidacionDatosReniecV21._Contador = Me._Contador
                    UscValidacionDatosReniecV21._VarHistorico = Me._VarHistorico
                    UscValidacionDatosReniecV21._InternoID = Me._InternoID
                End If
            End If
        End Sub
        Private Sub ListarCadenaInterno()
            Me._ListaCabeceraInterno = UscValidacionDatosInternoV21._ListaInternoCabecera
            Me._ListaDataInterno = UscValidacionDatosInternoV21._ListaInternoData
            Me._NombresAsociados = UscValidacionDatosInternoV21._NombresAsociados
            Me._NombresAsociadosID = UscValidacionDatosInternoV21._NombresAsociadosID
            Me._NombresAsociadosData = UscValidacionDatosInternoV21._NombresAsociadosLista
        End Sub
        Dim objBssInternoRnc As Bussines.Registro.InternoReniec
        Public Sub ListarInternoValidado(intInternoID)
            Dim Limpiar As Integer = -1
            Dim CodigoInterno As Integer = intInternoID
            objBssInternoRnc = New Bussines.Registro.InternoReniec
            Dim EntInternoRnc As New Entity.Registro.InternoReniec
            EntInternoRnc.InternoID = intInternoID

            Dim ListaValidados As Integer = objBssInternoRnc.InternoValidado(EntInternoRnc)

            Me._Contador = ListaValidados
            Me._VarHistorico = Limpiar
            Me._InternoID = CodigoInterno
        End Sub
        Public Sub Listar_ReniecHistorico(intInternoID)

            objBssInternoRnc = New Bussines.Registro.InternoReniec
            Dim EntInternoRnc As New Entity.Registro.InternoReniec
            EntInternoRnc.InternoID = intInternoID
            Dim ListaValidados As Integer = objBssInternoRnc.InternoValidado(EntInternoRnc)

            If ListaValidados > 0 Then
                Me._Contador = ListaValidados
                Me._VarHistorico = 0
                Me._InternoID = intInternoID
            Else
                'Legolas.Configuration.Aplication.MessageBox.Information("El Interno no posee Registros Historicos")
            End If

        End Sub
      
#End Region
        Private Sub uscValidacionReniecV2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            UscValidacionDatosInternoV21._Version = True
        End Sub

        Private Sub uscValidacionReniec_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles MyBase.Scroll
            Me.VerticalScroll.Visible = True
        End Sub
        Private Sub UscValidacionDatosInterno1__DatosImagen(NumImagen As System.Int32, NomImagen As System.String)
            Me._NumeroImagen = NumImagen
            Me._NombreImagen = NomImagen
        End Sub
        Private Sub UscValidacionDatosInterno1__ListaCadenaInterno()
            ListarCadenaInterno()
        End Sub

        Private Sub UscValidacionDatosReniec1__SelectedIndexChanged_ValidacionID(Busca As System.Int32, Cod_ultimo As System.Int32, CodInterno As System.Int32)
            If Busca > 0 Then
                'UscValidacionDatosInterno1._CondicionBusqueda = Busca
                UscValidacionDatosInternoV21._Contador = Busca
                UscValidacionDatosInternoV21._VarHistorico = Cod_ultimo
                UscValidacionDatosInternoV21._InternoID = CodInterno

            End If
        End Sub

        Private Sub UscValidacionDatosReniecV21__SelectedIndexChanged_ValidacionID(Busca As System.Int32, Cod_ultimo As System.Int32, CodInterno As System.Int32) Handles UscValidacionDatosReniecV21._SelectedIndexChanged_ValidacionID
            If Busca > 0 Then
                'UscValidacionDatosInterno1._CondicionBusqueda = Busca
                UscValidacionDatosInternoV21._Contador = Busca
                UscValidacionDatosInternoV21._VarHistorico = Cod_ultimo
                UscValidacionDatosInternoV21._InternoID = CodInterno

            End If
        End Sub

        Private Sub UscValidacionDatosReniecV21__Click_CargarUltimaInformacionInterno(Busca As System.Int32, Cod_ultimo As System.Int32) Handles UscValidacionDatosReniecV21._Click_CargarUltimaInformacionInterno
            ListarCadenaInterno()
        End Sub

        Private Sub UscValidacionDatosReniecV21__DoubleClick_CargarDetalle(objEntRnc As Entity.Registro.InternoReniec) Handles UscValidacionDatosReniecV21._DoubleClick_CargarDetalle
            RaiseEvent _DoubleClick_CargarDetalle(objEntRnc)
        End Sub

        Private Sub UscValidacionDatosInternoV21__DobleClickGrilla(objEntCol As Entity.Registro.NombreAsociadoCol) Handles UscValidacionDatosInternoV21._DobleClickGrilla
            RaiseEvent _DoubleClick_CargarDetalleNomAso(objEntCol)
        End Sub

        Private Sub UscValidacionDatosInternoV21__Click_DatosImagen(NumImagen As System.Int32, NomImagen As System.String) Handles UscValidacionDatosInternoV21._Click_DatosImagen
            Me._NumeroImagen = NumImagen
            Me._NombreImagen = NomImagen
        End Sub


        Private Sub UscValidacionDatosInternoV21__Click_ListaCadenaInterno() Handles UscValidacionDatosInternoV21._Click_ListaCadenaInterno
            ListarCadenaInterno()
        End Sub
    End Class

End Namespace

