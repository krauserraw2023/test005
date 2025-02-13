Imports APPControlHuellaVisita.Business
Imports System.Data.SqlClient

Public Class AfisDemo
    Dim bss As SysBiometria
    Private c_cnBD As String = ""

    Public Sub New(_CN_DB_POPE As String)
        Me.c_cnBD = _CN_DB_POPE
    End Sub

#Region "Grabar_Huella"
    ''' <summary>
    ''' Metodo que permite grabar la huella.
    ''' </summary>
    ''' <param name="TipoDoc">Tipo de documento de identidad</param>
    ''' <param name="numDocIdent">Número de documento de indentidad</param>
    ''' <param name="tipoDedo">Tipo de dedo</param>
    ''' <param name="TemplateSuprema">Template de tipo propietario (Suprema)</param>
    ''' <param name="TemplateAnsi">Template ansi</param>
    ''' <param name="wsq">Wsq de la huella</param>
    ''' <param name="IndiceCalidadImg">Indice de calidad de la huella capturada</param>
    ''' <param name="estadoDedo">Estado del dedo</param>
    ''' <param name="Observacion">Observaciones</param>
    ''' <param name="regionId">Id de la region</param>
    ''' <param name="penalId">Id del penal</param>
    ''' <param name="IdUsuario">Id del usuario</param>
    ''' <param name="out_sms">Mensaje de error</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GrabarHuella(enmDispositivo As Type.Enumeracion.enumTipoDispositivo, intTipoDoc As Integer, strNumDoc As String, TipoDedo As Type.Enumeracion.TipoDedo,
                                 bytTemplateSuprema As Byte(), bytTemplateAnsi As Byte(), _
                                 bytwsq As Byte(), enmIndiceCalidadImg As Type.Enumeracion.IndiceCalidadHuella, intEstadoDedo As Type.Enumeracion.EstadoDedo,
                                 strObs As String, _
                                 intRegionId As Integer, intPenalId As Integer, intIdUsuario As Integer, ByRef strOutSms As String) As Integer
        'graba en la bd de huella local (visita)
        If Me.c_cnBD = "" Then
            strOutSms = "No es posible establecer conexión con la base de datos de las huellas."
            Return -1
        End If

        Dim bssHuella As New Business.Bss_HuellaTemplate(Me.c_cnBD)

        Dim tmp As New Entity.Ent_HuellaTemplate
        tmp.DocTipoId = intTipoDoc
        tmp.TipoDedoId = TipoDedo
        tmp.DispBiometricoId = enmDispositivo
        tmp.NumDocumento = strNumDoc
        tmp.TemplatePropietario = bytTemplateSuprema
        tmp.TemplateANSI = bytTemplateAnsi
        tmp.NombrePC = ""
        tmp.MacPC = ""
        tmp.RegSincronizadoSede = 1
        tmp.IndiceCalidadImg = enmIndiceCalidadImg
        tmp.EstadoDedo = intEstadoDedo
        tmp.Observacion = strObs
        tmp.RegionId = intRegionId
        tmp.PenalId = intPenalId

        Dim entWsq As New Entity.Ent_HuellaWSQ
        entWsq.WSQFile = bytwsq
        entWsq.HuellaTemplateId = -1
        entWsq.RegionId = intRegionId
        entWsq.PenalId = intPenalId

        Dim id As Integer = -1

        id = bssHuella.Grabar(tmp, entWsq, intIdUsuario, strOutSms)

        Return id
    End Function

    Public Function GrabarHuella(TipoDoc As Integer, numDocIdent As String, codigoRp As String, ApePat As String, ApeMat As String, Nombres As String, _
                                 tipoDedo As Type.Enumeracion.TipoDedo, TemplateSuprema As Byte(), TemplateAnsi As Byte(), _
                                wsq As Byte(), IndiceCalidadImg As Type.Enumeracion.IndiceCalidadHuella, estadoDedo As Type.Enumeracion.EstadoDedo, Observacion As String, _
                                regionId As Integer, penalId As Integer, IdUsuario As Integer, ByRef out_sms As String) As Integer
        If Me.c_cnBD = "" Then

            out_sms = "No es posible establecer conexión con la base de datos de las huellas."
            Return -1
        End If

        Dim bssHuella As New Business.Bss_HuellaTemplate(Me.c_cnBD)

        Dim tmp As New Entity.Ent_HuellaTemplate
        tmp.DocTipoId = TipoDoc
        tmp.TipoDedoId = tipoDedo
        tmp.DispBiometricoId = 1
        tmp.NumDocumento = numDocIdent
        tmp.CodigoRP = codigoRp
        tmp.ApellidoPaterno = ApePat
        tmp.ApellidoMaterno = ApeMat
        tmp.Nombres = Nombres
        tmp.TemplatePropietario = TemplateSuprema
        tmp.TemplateANSI = TemplateAnsi
        tmp.NombrePC = ""
        tmp.MacPC = ""
        tmp.RegSincronizadoSede = 1
        tmp.IndiceCalidadImg = IndiceCalidadImg
        tmp.EstadoDedo = estadoDedo
        tmp.Observacion = Observacion
        tmp.RegionId = regionId
        tmp.PenalId = penalId


        Dim entWsq As New Entity.Ent_HuellaWSQ
        entWsq.WSQFile = wsq
        entWsq.HuellaTemplateId = -1
        entWsq.RegionId = regionId
        entWsq.PenalId = penalId

        Dim id As Integer = -1

        id = bssHuella.Grabar(tmp, entWsq, IdUsuario, out_sms)

        Return id
    End Function

    Public Function GrabarHuellaTratamiento(enmDispositivo As Type.Enumeracion.enumTipoDispositivo, TipoDoc As Integer, numDocIdent As String, codigoRp As String, ApePat As String, ApeMat As String, Nombres As String, _
                               tipoCaptura As Integer, tipoDedo As Type.Enumeracion.TipoDedo, TemplateSuprema As Byte(), TemplateAnsi As Byte(), _
                               wsq As Byte(), IndiceCalidadImg As Type.Enumeracion.IndiceCalidadHuella, estadoDedo As Type.Enumeracion.EstadoDedo, Observacion As String, _
                               regionId As Integer, penalId As Integer, IdUsuario As Integer, ByRef out_sms As String) As Integer

        'graba en la bd de huella local (tratamiento)
        If Me.c_cnBD = "" Then

            out_sms = "No es posible establecer conexión con la base de datos de las huellas."
            Return -1
        End If

        Dim bssHuella As New Business.Bss_HuellaTemplate(Me.c_cnBD)

        Dim tmp As New Entity.Ent_HuellaTemplate
        tmp.DocTipoId = TipoDoc
        tmp.TipoDedoId = tipoDedo
        tmp.DispBiometricoId = enmDispositivo
        tmp.NumDocumento = numDocIdent
        tmp.CodigoRP = codigoRp
        tmp.ApellidoPaterno = ApePat
        tmp.ApellidoMaterno = ApeMat
        tmp.Nombres = Nombres
        tmp.TipoCaptura = tipoCaptura
        tmp.TemplatePropietario = TemplateSuprema
        tmp.TemplateANSI = TemplateAnsi
        tmp.NombrePC = ""
        tmp.MacPC = ""
        tmp.RegSincronizadoSede = 1
        tmp.IndiceCalidadImg = IndiceCalidadImg
        tmp.EstadoDedo = estadoDedo
        tmp.Observacion = Observacion
        tmp.RegionId = regionId
        tmp.PenalId = penalId

        Dim entWsq As New Entity.Ent_HuellaWSQ
        entWsq.WSQFile = wsq
        entWsq.HuellaTemplateId = -1
        entWsq.RegionId = regionId
        entWsq.PenalId = penalId

        Dim id As Integer = -1

        id = bssHuella.GrabarTratamiento(tmp, entWsq, IdUsuario, out_sms)

        Return id
    End Function


#End Region

#Region "Dispositivo"
    ''' <summary>
    ''' Método de verificación de huella dactilar.
    ''' </summary>
    ''' <param name="TipoDoc">Tipo de documento de identidad</param>
    ''' <param name="NumDoc">Número de documento de identidad</param>
    ''' <param name="TipoTmpl">Tipo de template para la verificación</param>
    ''' <param name="Tmpl">Template en array de bits</param>
    ''' <param name="TipoDedo">Tipo de dedo</param>
    ''' <param name="ratioAceptacion"></param>
    ''' <param name="outListIdRptaTemplate">Resultado ids del match</param>
    ''' <param name="outSMS">Mensaje de error</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Function VerificarHuella(TipoDoc As Integer, NumDoc As String, TipoTmpl As Type.Enumeracion.TipoPlantilla, _
                                    Tmpl As Byte(), TipoDedo As Type.Enumeracion.TipoDedo, ratioAceptacion As Type.Enumeracion.enumRSE_NivelSeguridad, _
                                   ByRef outListIdRptaTemplate As List(Of Integer), ByRef outSMS As String) As Integer

        Dim value As Integer = -1

        If Me.c_cnBD = "" Then
            outSMS = "No es posible establecer conexión con la base de datos de las huellas."
            Return value
        End If

        If bss Is Nothing Then
            bss = New SysBiometria(Me.c_cnBD)
        End If

        value = bss.VerificarHuella(TipoDoc, NumDoc, Tmpl, TipoDedo, TipoTmpl, ratioAceptacion, outListIdRptaTemplate, outSMS)

        Return value

    End Function

    ''' <summary>
    ''' Identificación biometrica por tipo de plantilla (propietaria) suprema.
    ''' </summary>
    ''' <param name="Tmpl_suprema">Plantilla de tipo propietario (Suprema)</param>
    ''' <param name="TipoDedo">Tipo de dedo el cual se va a identificar</param>
    ''' <param name="filtrarPorTipoDedo">Flag para filtrar por tipo de dedo</param>
    ''' <param name="ratioAceptacion">Nivel de seguridad o Ratio de falsa aceptación</param>
    ''' <param name="outListIdRptaTemplate">Lista de id del template para el match</param>
    ''' <param name="out_sms">Mensaje de respuesta</param>
    ''' <returns>0=OK, -1=Error</returns>
    ''' <remarks></remarks>
    Public Function Identificar(Tmpl_suprema As Byte(), TipoDedo As Type.Enumeracion.TipoDedo, _
                                blnFiltrarxTipoDedo As Boolean, ratioAceptacion As Type.Enumeracion.enumRSE_NivelSeguridad, _
                                ByRef outListIdRptaTemplate As List(Of Integer), ByRef outSms As String) As Integer
        If Me.c_cnBD = "" Then
            outSms = "No es posible establecer conexión con la base de datos de las huellas."
            Return -1
        End If

        If bss Is Nothing Then
            bss = New SysBiometria(Me.c_cnBD)
        End If

        Return bss.Identificar(Tmpl_suprema, TipoDedo, blnFiltrarxTipoDedo, outListIdRptaTemplate, ratioAceptacion, outSms)

    End Function

    Public Function Identificar(bytTempSuprema As Byte(), TipoDedo As Type.Enumeracion.TipoDedo, _
                               blnFiltrarxTipoDedo As Boolean, enmRatioAceptacion As Type.Enumeracion.enumRSE_NivelSeguridad, _
                               ByRef lstOutListIdRptaTemplate As List(Of Integer), lstBuscarTmplIds As List(Of Integer), ByRef strOutSms As String) As Integer

        If Me.c_cnBD = "" Then
            strOutSms = "No es posible establecer conexión con la base de datos de las huellas."
            Return -1
        End If

        If bss Is Nothing Then
            bss = New SysBiometria(Me.c_cnBD)
        End If

        Return bss.Identificar(bytTempSuprema, Type.Enumeracion.TipoPlantilla.Suprema, TipoDedo, blnFiltrarxTipoDedo, lstOutListIdRptaTemplate, enmRatioAceptacion,
                               lstBuscarTmplIds, strOutSms)

    End Function

    Public Function VerificarHuella(enmTipoDispositivo As Type.Enumeracion.enumTipoDispositivo, intIDTipoDoc As Integer, strNumDoc As String,
                                    TipoDedo As Type.Enumeracion.TipoDedo,
                                    enmTipoPlantilla As Type.Enumeracion.TipoPlantilla, _
                                    bytTemplate As Byte(),
                                   ByRef lstOutListIDRptaTemplate As List(Of Integer), ByRef strOutSMS As String) As Short

        'jmr-23.11.2017
        'compatibles con el realscang1 y futronicfs10

        Dim value As Short = -1

        If Me.c_cnBD = "" Then
            strOutSMS = "No es posible establecer conexión con la base de datos de las huellas."
            Return value
        End If

        If bss Is Nothing Then
            bss = New SysBiometria(Me.c_cnBD)
        End If

        Select Case enmTipoDispositivo

            Case Type.Enumeracion.enumTipoDispositivo.RealScanG1

                value = bss.VerificarHuella(intIDTipoDoc, strNumDoc, bytTemplate, TipoDedo, enmTipoPlantilla,
                                            Type.Enumeracion.enumRSE_NivelSeguridad.RSE_SECURITY_1_TO_100000,
                                            lstOutListIDRptaTemplate, strOutSMS)

            Case Type.Enumeracion.enumTipoDispositivo.FutronicFS10

                value = bss.VerificarHuellaFS10(intIDTipoDoc, strNumDoc, bytTemplate, TipoDedo, enmTipoPlantilla,
                                                Type.Enumeracion.enumfMatchScore.MATCH_SCORE_VERY_HIGH,
                                         lstOutListIDRptaTemplate, strOutSMS)

        End Select

        Return value

    End Function

    Public Function Identificar(enmTipoDispositivo As Type.Enumeracion.enumTipoDispositivo,
                                TipoDedo As Type.Enumeracion.TipoDedo, _
                                enmTipoPlantilla As Type.Enumeracion.TipoPlantilla,
                                btyTemplate As Byte(), _
                               blnFiltrarxTipoDedo As Boolean, _
                               ByRef lstOutListIdRptaTemplate As List(Of Integer), lstBuscarTmplIds As List(Of Integer), ByRef strOutSms As String) As Short

        'jmr-23.11.2017
        'compatibles con el realscang1 y futronicfs10

        Dim value As Short = -1

        If Me.c_cnBD = "" Then
            strOutSms = "No es posible establecer conexión con la base de datos de las huellas."
            Return value
        End If

        If bss Is Nothing Then
            bss = New SysBiometria(Me.c_cnBD)
        End If

        Select Case enmTipoDispositivo

            Case Type.Enumeracion.enumTipoDispositivo.RealScanG1

                value = bss.Identificar(btyTemplate, enmTipoPlantilla, TipoDedo, blnFiltrarxTipoDedo, lstOutListIdRptaTemplate,
                                        Type.Enumeracion.enumRSE_NivelSeguridad.RSE_SECURITY_1_TO_100000,
                                        lstBuscarTmplIds, strOutSms)

            Case Type.Enumeracion.enumTipoDispositivo.FutronicFS10

                value = bss.IdentificarFS10(btyTemplate, TipoDedo, blnFiltrarxTipoDedo,
                                            Type.Enumeracion.enumfMatchScore.MATCH_SCORE_VERY_HIGH,
                                            lstOutListIdRptaTemplate, lstBuscarTmplIds, strOutSms)

        End Select

        Return value

    End Function

#End Region

End Class
