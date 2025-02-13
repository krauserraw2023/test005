Public Class PathURL

    Public Shared Property WSPopeLocal As String = Legolas.LBusiness.Globall.WinApp.ListarString("ws_foto", -1)
    Public Shared Property ws_reniec_mq_sede As String = Legolas.LBusiness.Globall.WinApp.ListarString("ws_reniec_local", -1)

    Public Shared Property WSPopeSedeUsuario As String = Legolas.LBusiness.Globall.WinApp.ListarString("ws_popesede_usuario", -1)
    Public Shared Property ws_pope_sede_TablaMaestra As String = Legolas.LBusiness.Globall.WinApp.ListarString("ws_popesede_tab_mae", -1)
    Public Shared Property ws_pope_sede_TablaMaestra_config As String = Legolas.LBusiness.Globall.WinApp.ListarString("ws_popesede_tab_cnf", -1)

    Public Shared Property WSPopeSedeCentral As String = Legolas.LBusiness.Globall.WinApp.ListarString("ws_foto_sede_central", -1)
    Public Shared Property Monitoreo As String = Legolas.LBusiness.Globall.WinApp.ListarString("ws_monitoreo", -1)

    Public Shared Property ws_sede_plm_carceleta = Legolas.LBusiness.Globall.WinApp.ListarString("ws_sede_plm_carceleta", -1)
    Public Shared Property ws_sede_plm_Interno = Legolas.LBusiness.Globall.WinApp.ListarString("ws_sede_plm_Interno", -1)

    Public Shared Property ws_sede_sanciones = Legolas.LBusiness.Globall.WinApp.ListarString("ws_sede_sanciones", -1)
    Public Shared Property ws_pope_sede_uploadfile = Legolas.LBusiness.Globall.WinApp.ListarString("ws_transferencia_foto_global", -1)

    '/*web services sede - hardcode*/
    Public Shared Property WSSipgaSedeUsuario As String = "http://ws.inpe.gob.pe/SIPGA/sede/Usuario.asmx"
    Public Shared Property wsVisorDocumentosDigitalizados As String = Legolas.LBusiness.Globall.WinApp.ListarString("ws_serv_doc_digital_old", -1)

    '*************/*nuevos*/******************
    '/*padin*/
    Public Shared Property ws_sede_padin As String = "http://wsdev.inpe.gob.pe/POPE/Sede/padin.asmx"

    Public Shared ReadOnly Property ws_trat_taller_asist As String
        Get
            Return Legolas.LBusiness.Globall.WinApp.ListarString("ws_pope_ep_trat_asist_tall", -1)
        End Get
    End Property

End Class
