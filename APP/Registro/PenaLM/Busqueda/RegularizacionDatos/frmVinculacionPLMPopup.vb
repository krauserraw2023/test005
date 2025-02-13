Imports System.ComponentModel
Imports System.Data.SqlClient

Namespace Registro.PenalLM.Busqueda
    Public Class frmVinculacionPLMPopup

        Private frmLoad As Load.frmProcesando = Nothing

        Private blnRegistroRegula As Boolean = False
        Private strSqlQuery As String = ""
        Private objEntFiltroRegula As Bussines.Registro.InternoRegularizacion.Interno = Nothing

#Region "Propiedades_Share"
        Public Property _IDInternoLocal As Integer = -1
        Public Property _IDPenal As Short = -1

#End Region
#Region "Propiedades_Privadas"
        Private ReadOnly Property GrillaIDInternoSede As Long
            Get
                Dim value As Long = -1

                For Each fila As DataGridViewRow In Me.dgwGrillaSede.Rows
                    value = fila.Cells("col_sed_int_id").Value
                Next
                Return value
            End Get
        End Property

        Private Property SedeRowID As Integer
            Get
                Try
                    Return Integer.Parse(Me.txtIDInternoSede.Text)
                Catch ex As Exception
                    Return 0
                End Try

            End Get
            Set(value As Integer)
                Me.txtIDInternoSede.Text = value.ToString
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub ListarGrilla()

            If Me._IDInternoLocal < 1 Then
                Exit Sub
            End If

            strSqlQuery = "select
	                    _regid,
	                    _penid,
                        int_id,
                        _sed_rowid,
	                    int_cod_rp,
	                    tip_doc_id,
	                    int_doc_num,
	                    int_ape_pat,
	                    int_ape_mat,
	                    int_nom,
	                    int_fec_nac,
	                    nac_id
                    from 
	                    int_interno
                    where
	                    int_id=" & _IDInternoLocal

            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objDataTable As New DataTable

            objDataTable = Legolas.Components.SQL.Select_DataTable(sqlcn, strSqlQuery)

            Me.dgwGrillaPenal.DataSource = objDataTable

        End Sub

#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            If Me.dgwGrillaSede.Rows.Count <> 1 Then
                MessageBox.Show("Debe buscar un interno de Sede", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            'validar el check de codigo rp            
            If Me.dgwGrillaSede.Item("col_sed_chk_cod_rp", 0).Value = True And
                Me.dgwGrillaPenal.Item("col_pen_chk_cod_rp", 0).Value = True Then
                MessageBox.Show("El campo codigo del interno, no puede ser seleccionado en Sede y Penal al mismo tiempo.", Me.Text,
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            'validar el check de tipo documento            
            If Me.dgwGrillaSede.Item("col_sed_chk_id_tip_doc", 0).Value = True And
                Me.dgwGrillaPenal.Item("col_pen_chk_id_tip_doc", 0).Value = True Then
                MessageBox.Show("El campo id tipo de documento del interno, no puede ser seleccionado en Sede y Penal al mismo tiempo.", Me.Text,
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            'validar el check de numero de documento
            If Me.dgwGrillaSede.Item("col_sed_chk_num_doc", 0).Value = True And
                Me.dgwGrillaPenal.Item("col_pen_chk_num_doc", 0).Value = True Then
                MessageBox.Show("El campo numero de documento del interno, no puede ser seleccionado en Sede y Penal al mismo tiempo.", Me.Text,
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            'validar el check de primer de documento
            If Me.dgwGrillaSede.Item("col_sed_chk_pri_ape", 0).Value = True And
                Me.dgwGrillaPenal.Item("col_pen_chk_pri_ape", 0).Value = True Then
                MessageBox.Show("El campo primer apellido del interno, no puede ser seleccionado en Sede y Penal al mismo tiempo.", Me.Text,
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            'validar el check de segundo apellido
            If Me.dgwGrillaSede.Item("col_sed_chk_seg_ape", 0).Value = True And
                Me.dgwGrillaPenal.Item("col_pen_chk_seg_ape", 0).Value = True Then
                MessageBox.Show("El campo segundo apellido del interno, no puede ser seleccionado en Sede y Penal al mismo tiempo.", Me.Text,
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            'validar el check de nombres
            If Me.dgwGrillaSede.Item("col_sed_chk_nom", 0).Value = True And
                Me.dgwGrillaPenal.Item("col_pen_chk_nom", 0).Value = True Then
                MessageBox.Show("El campo nombre del interno, no puede ser seleccionado en Sede y Penal al mismo tiempo.", Me.Text,
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            'validar el check de fecha de nacimiento
            If Me.dgwGrillaSede.Item("col_sed_chk_fec_nac", 0).Value = True And
                Me.dgwGrillaPenal.Item("col_pen_chk_fec_nac", 0).Value = True Then
                MessageBox.Show("El campo fecha de nacimiento del interno, no puede ser seleccionado en Sede y Penal al mismo tiempo.", Me.Text,
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            'validar el check nacionalidad
            If Me.dgwGrillaSede.Item("col_sed_chk_id_nac", 0).Value = True And
                Me.dgwGrillaPenal.Item("col_pen_chk_id_nac", 0).Value = True Then
                MessageBox.Show("El campo id nacionalidad del interno, no puede ser seleccionado en Sede y Penal al mismo tiempo.", Me.Text,
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
            value = True
            Return value
        End Function
        Private Sub AVerDiferencias()

            Dim objColor As Color = Color.Tomato

            'sede row id
            If Me.dgwGrillaSede.Item("col_sed_sed_row_id", 0).Value <> Me.dgwGrillaPenal.Item("col_pen_sed_row_id", 0).Value Then
                Me.dgwGrillaSede.Rows(0).Cells("col_sed_sed_row_id").Style.BackColor = objColor
                Me.dgwGrillaPenal.Rows(0).Cells("col_pen_sed_row_id").Style.BackColor = objColor
            End If

            'codigo rp
            If Me.dgwGrillaSede.Item("col_sed_cod_rp", 0).Value <> Me.dgwGrillaPenal.Item("col_pen_cod_rp", 0).Value Then
                Me.dgwGrillaSede.Rows(0).Cells("col_sed_cod_rp").Style.BackColor = objColor
                Me.dgwGrillaPenal.Rows(0).Cells("col_pen_cod_rp").Style.BackColor = objColor
            End If

            'id tipo documento
            If Me.dgwGrillaSede.Item("col_sed_id_tip_doc", 0).Value <> Me.dgwGrillaPenal.Item("col_pen_id_tip_doc", 0).Value Then
                Me.dgwGrillaSede.Rows(0).Cells("col_sed_id_tip_doc").Style.BackColor = objColor
                Me.dgwGrillaPenal.Rows(0).Cells("col_pen_id_tip_doc").Style.BackColor = objColor
            End If

            'numero de documento
            If Me.dgwGrillaSede.Item("col_sed_num_doc", 0).Value <> Me.dgwGrillaPenal.Item("col_pen_num_doc", 0).Value Then
                Me.dgwGrillaSede.Rows(0).Cells("col_sed_num_doc").Style.BackColor = objColor
                Me.dgwGrillaPenal.Rows(0).Cells("col_pen_num_doc").Style.BackColor = objColor
            End If

            'primer apellido
            If Me.dgwGrillaSede.Item("col_sed_pri_ape", 0).Value <> Me.dgwGrillaPenal.Item("col_pen_pri_ape", 0).Value Then
                Me.dgwGrillaSede.Rows(0).Cells("col_sed_pri_ape").Style.BackColor = objColor
                Me.dgwGrillaPenal.Rows(0).Cells("col_pen_pri_ape").Style.BackColor = objColor
            End If

            'segundo apellido
            If Me.dgwGrillaSede.Item("col_sed_seg_ape", 0).Value <> Me.dgwGrillaPenal.Item("col_pen_seg_ape", 0).Value Then
                Me.dgwGrillaSede.Rows(0).Cells("col_sed_seg_ape").Style.BackColor = objColor
                Me.dgwGrillaPenal.Rows(0).Cells("col_pen_seg_ape").Style.BackColor = objColor
            End If

            'nombres
            If Me.dgwGrillaSede.Item("col_sed_nom", 0).Value <> Me.dgwGrillaPenal.Item("col_pen_nom", 0).Value Then
                Me.dgwGrillaSede.Rows(0).Cells("col_sed_nom").Style.BackColor = objColor
                Me.dgwGrillaPenal.Rows(0).Cells("col_pen_nom").Style.BackColor = objColor
            End If

            'fecha de nacimiento
            If Me.dgwGrillaSede.Item("col_sed_fec_nac", 0).Value <> Me.dgwGrillaPenal.Item("col_pen_fec_nac", 0).Value Then
                Me.dgwGrillaSede.Rows(0).Cells("col_sed_fec_nac").Style.BackColor = objColor
                Me.dgwGrillaPenal.Rows(0).Cells("col_pen_fec_nac").Style.BackColor = objColor
            End If

            'id nacionalidad
            If Me.dgwGrillaSede.Item("col_sed_id_nac", 0).Value <> Me.dgwGrillaPenal.Item("col_pen_id_nac", 0).Value Then
                Me.dgwGrillaSede.Rows(0).Cells("col_sed_id_nac").Style.BackColor = objColor
                Me.dgwGrillaPenal.Rows(0).Cells("col_pen_id_nac").Style.BackColor = objColor
            End If

            Me.dgwGrillaSede.Refresh()
            Me.dgwGrillaPenal.Refresh()

        End Sub
        Private Sub AVincular()

            Dim strMensajeError As String = ""

            '1.- eliminar registros locales del interno
            EliminarRegistrosLocalesInterno(3, Me._IDPenal, Me._IDInternoLocal, strMensajeError)

            If strMensajeError.Trim.Length > 3 Then
                MessageBox.Show(strMensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            '2.- hacer el update del internos en el penal
            UpdateInternoLocal(strMensajeError)
            If strMensajeError.Trim.Length > 3 Then
                MessageBox.Show(strMensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            '3.-actualizar los datos del interno de sede 
            UpdateInternoSede(strMensajeError)
            If strMensajeError.Trim.Length > 3 Then
                MessageBox.Show(strMensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            '4.- vincular el interno
            If ARegularizarDatosInterno() = True Then

                '5.- recuperar la foto
                RecuperarFoto(strMensajeError)

                If strMensajeError.Trim.Length > 0 Then
                    MessageBox.Show(strMensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Operacion realizada satisfactoriamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                End If

            End If

        End Sub
        Private Sub EliminarRegistrosLocalesInterno(intIDRegion As Short, intIDPenal As Short, intIDInterno As Long,
                                                    ByRef strMensajeOut As String)

            Dim strSql As New System.Text.StringBuilder

            With strSql
                .AppendLine("select 'int_mov_interno_ingreso_inpe' as tabla, * from int_mov_interno_ingreso_inpe where _flg_eli=0 and fk_int_id=@int_id")
                .AppendLine("select 'int_internohistorico' as tabla, * from int_internohistorico where _flg_eli=0 and _penid=@pen_id and int_id=@int_id")
                .AppendLine("select 'INT_InternoIngreso' as tabla, * from INT_InternoIngreso where _flg_eli=0 and _penid=@pen_id and int_id=@int_id")
                .AppendLine("select 'int_mov_interno_grado_ins' as tabla, * from int_mov_interno_grado_ins where _flg_eli=0 and _penid=@pen_id and fk_int_id=@int_id")
                .AppendLine("select 'int_mov_interno_idioma' as tabla, * from int_mov_interno_idioma where _flg_eli=0 and _penid=@pen_id and fk_int_id=@int_id")
                .AppendLine("select 'int_mov_interno_domicilio' as tabla,* from int_mov_interno_domicilio where _flg_eli=0 and _penid=@pen_id and fk_int_id=@int_id")
                .AppendLine("select 'INT_InternoNombreAsociado' as tabla,* from INT_InternoNombreAsociado where _flg_eli=0 and _penid=@pen_id and int_id=@int_id")
                .AppendLine("select 'INT_InternoFoto' as tabla,* from INT_InternoFoto where _flg_eli=0 and _penid=@pen_id and int_id=@int_id")
                .AppendLine("select 'INT_InternoRasgo' as tabla,* from INT_InternoRasgo where _flg_eli=0 and _penid=@pen_id and int_id=@int_id ")
                .AppendLine("select 'INT_InternoSenaParticular' as tabla,* from INT_InternoSenaParticular where _flg_eli=0 and _penid=@pen_id and int_id=@int_id")
                .AppendLine("select 'INT_InternoRENIEC' as tabla,* from INT_InternoRENIEC where _flg_eli=0 and _penid=@pen_id and int_id=@int_id ")
                .AppendLine("select 'INT_InternoReniec_NomAsoc' as tabla,* from INT_InternoReniec_NomAsoc where _flg_eli=0 and _penid=@pen_id and int_id=@int_id")
                .AppendLine("select 'INT_InternoAlias' as tabla,* from INT_InternoAlias where _flg_eli=0 and _penid=@pen_id and int_id=@int_id")
                .AppendLine("select 'reg_mov_internobanda' as tabla,* from reg_mov_internobanda where _flg_eli=0 and _penid=@pen_id and int_id=@int_id")
                .AppendLine("select 'INT_InternoBanda' as tabla,* from INT_InternoBanda where _flg_eli=0 and _penid=@pen_id and int_id=@int_id")
                .AppendLine("select 'INT_InternoFamiliar' as tabla,* from INT_InternoFamiliar where _flg_eli=0 and _penid=@pen_id and int_id=@int_id")
            End With

            Dim objDTS As New DataSet("tablas")

            Try
                Dim sqlAdapter As New SqlDataAdapter

                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strSql.ToString, sqlCon)

                        sqlCon.Open()

                        With sqlCmd
                            .CommandTimeout = 300
                            .CommandType = CommandType.Text
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = intIDPenal
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = intIDInterno

                            sqlAdapter.SelectCommand = sqlCmd
                            sqlAdapter.Fill(objDTS)
                            objDTS.Tables(0).TableName = "int_mov_interno_ingreso_inpe"
                            objDTS.Tables(1).TableName = "int_internohistorico"
                            objDTS.Tables(2).TableName = "INT_InternoIngreso"
                            objDTS.Tables(3).TableName = "int_mov_interno_grado_ins"
                            objDTS.Tables(4).TableName = "int_mov_interno_idioma"
                            objDTS.Tables(5).TableName = "int_mov_interno_domicilio"
                            objDTS.Tables(6).TableName = "INT_InternoNombreAsociado"
                            objDTS.Tables(7).TableName = "INT_InternoFoto"
                            objDTS.Tables(8).TableName = "INT_InternoRasgo"
                            objDTS.Tables(9).TableName = "INT_InternoSenaParticular"
                            objDTS.Tables(10).TableName = "INT_InternoRENIEC"
                            objDTS.Tables(11).TableName = "INT_InternoReniec_NomAsoc"
                            objDTS.Tables(12).TableName = "INT_InternoAlias"
                            objDTS.Tables(13).TableName = "reg_mov_internobanda"
                            objDTS.Tables(14).TableName = "INT_InternoBanda"
                            objDTS.Tables(15).TableName = "INT_InternoFamiliar"
                        End With
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            Dim strNombreTabla As String = ""
            Dim strMensajeError As String = ""
            Dim sqlCone As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            For Each obj As DataTable In objDTS.Tables

                strNombreTabla = obj.TableName.ToUpper
                strSqlQuery = ""
                Dim strCampoCondicion As String = ""
                Dim strCamposModificados As String = ""

                Select Case strNombreTabla.ToUpper
                    Case "int_mov_interno_ingreso_inpe".ToUpper, "int_mov_interno_grado_ins".ToUpper, "int_mov_interno_idioma".ToUpper,
                            "int_mov_interno_domicilio".ToUpper

                        strCampoCondicion = "fk_int_id"
                        strCamposModificados = " set _flg_trf=1,_flg_eli=1,_fec_eli=" & Now.ToFileTime

                    Case "INT_InternoFoto".ToUpper
                        strCampoCondicion = "int_id"
                        strCamposModificados = " set _flg_trf=1,_hostname='RE_VIN_FOTO' ,fk_ing_inp_id=-1"

                    Case Else
                        strCampoCondicion = "int_id"
                        strCamposModificados = " set _flg_trf=1,_flg_eli=1,_fec_eli=" & Now.ToFileTime
                End Select

                For Each fila As DataRow In obj.Rows
                    strSqlQuery = strSqlQuery & "update " & strNombreTabla & strCamposModificados &
                            " where " & strCampoCondicion & "=" & intIDInterno & Chr(13)
                Next

                'si hay registros ejecutar
                If strSqlQuery.Trim.Length > 3 Then
                    Legolas.Components.SQL.ExecuteBatchNonQuery(sqlCone, strSqlQuery, strMensajeError, True)

                    If strMensajeError.Trim.Length > 3 Then
                        Exit For
                    End If

                End If
            Next

        End Sub
        Private Sub UpdateInternoLocal(ByRef strMensajeOut As String)

            Dim strColumnas As New ArrayList

            With dgwGrillaSede

                'codigo rp
                If .Item("col_sed_chk_cod_rp", 0).Value = True Then
                    strColumnas.Add("int_cod_rp='" & .Item("col_sed_cod_rp", 0).Value & "'")
                End If

                'id tipo de documento
                If .Item("col_sed_chk_id_tip_doc", 0).Value = True Then
                    strColumnas.Add("tip_doc_id='" & .Item("col_sed_id_tip_doc", 0).Value & "'")
                End If

                'numero de documento
                If .Item("col_sed_chk_num_doc", 0).Value = True Then
                    strColumnas.Add("int_doc_num='" & .Item("col_sed_num_doc", 0).Value & "'")
                End If

                'primer apellido
                If .Item("col_sed_chk_pri_ape", 0).Value = True Then
                    strColumnas.Add("int_ape_pat='" & .Item("col_sed_pri_ape", 0).Value & "'")
                End If

                'segundo apellido
                If .Item("col_sed_chk_seg_ape", 0).Value = True Then
                    strColumnas.Add("int_ape_mat='" & .Item("col_sed_seg_ape", 0).Value & "'")
                End If

                'nombres
                If .Item("col_sed_chk_nom", 0).Value = True Then
                    strColumnas.Add("int_nom='" & .Item("col_sed_nom", 0).Value & "'")
                End If

                'fecha de nacimiento
                If .Item("col_sed_chk_fec_nac", 0).Value = True Then
                    strColumnas.Add("int_fec_nac='" & .Item("col_sed_fec_nac", 0).Value & "'")
                End If

                'id de nacionalidad
                If .Item("col_sed_chk_id_nac", 0).Value = True Then
                    strColumnas.Add("nac_id='" & .Item("col_sed_id_nac", 0).Value & "'")
                End If

            End With

            Dim strColumnasUpdate As String = " "
            Dim strComa As String = ""
            For Each strCadena As String In strColumnas.ToArray
                strColumnasUpdate = strColumnasUpdate & strCadena & ","
            Next

            strColumnasUpdate = Legolas.Components.Cadena.Left(strColumnasUpdate, strColumnasUpdate.Length - 1)

            If strColumnasUpdate.Trim.Length > 3 Then
                strComa = ", "
            End If

            strSqlQuery = "update int_interno set _flg_trf=1, _sed_rowid=-1, c_ver_Reg='' " & strComa & strColumnasUpdate &
                                                                            " where int_id=" & Me._IDInternoLocal

            Dim sqlcn As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Legolas.Components.SQL.ExecuteBatchNonQuery(sqlcn, strSqlQuery, strMensajeOut)

        End Sub
        Private Sub UpdateInternoSede(ByRef strMensajeOut As String)


            Dim objEnviarUpdate As Boolean = False
            Dim objDTO As New APPWebService.ws_pope_sede_plm_Interno.DTO_Interno

            With dgwGrillaPenal

                'codigo rp
                If .Item("col_pen_chk_cod_rp", 0).Value = True Then
                    objDTO.CodigoRP = .Item("col_pen_cod_rp", 0).Value
                    objEnviarUpdate = True
                End If

                'id tipo de documento
                If .Item("col_pen_chk_id_tip_doc", 0).Value = True Then
                    objDTO.TipoDocumentoID = .Item("col_pen_id_tip_doc", 0).Value
                    objEnviarUpdate = True
                End If

                'numero de documento
                If .Item("col_pen_chk_num_doc", 0).Value = True Then
                    objDTO.NumeroDocumento = .Item("col_pen_num_doc", 0).Value
                    objEnviarUpdate = True
                End If

                'primer apellido
                If .Item("col_pen_chk_pri_ape", 0).Value = True Then
                    objDTO.ApellidoPaterno = .Item("col_pen_pri_ape", 0).Value
                    objEnviarUpdate = True
                End If

                'segundo apellido
                If .Item("col_pen_chk_seg_ape", 0).Value = True Then
                    objDTO.ApellidoMaterno = .Item("col_pen_seg_ape", 0).Value
                    objEnviarUpdate = True
                End If

                'nombres
                If .Item("col_pen_chk_nom", 0).Value = True Then
                    objDTO.Nombres = .Item("col_pen_nom", 0).Value
                    objEnviarUpdate = True
                End If

                'fecha de nacimiento
                If .Item("col_pen_chk_fec_nac", 0).Value = True Then
                    objDTO.FechaNacimiento = .Item("col_pen_fec_nac", 0).Value
                    objEnviarUpdate = True
                End If

                'id de nacionalidad
                If .Item("col_pen_chk_id_nac", 0).Value = True Then
                    objDTO.IDNacionalidad = .Item("col_pen_id_nac", 0).Value
                    objEnviarUpdate = True
                End If

            End With

            If objEnviarUpdate = True Then

                objDTO.IDInternoSede = Me.GrillaIDInternoSede

                Dim objResul As New APPWebService.ws_pope_sede_plm_Interno.DTO_ResultOfInt64
                Dim objws As New APPWebService.ws_pope_sede_plm_Interno.InternoSede
                objws.Url = APPWebService.PathURL.ws_sede_plm_Interno
                objResul = objws.InternoPLM_GrabarDatosBasicos(objDTO)

                If objResul.Resultado < 1 Then
                    strMensajeOut = objResul.Error_Mensaje
                End If

            End If

        End Sub
        Private Function ARegularizarDatosInterno() As Boolean

            Dim value As Boolean = False

            Dim objBssInterno As Bussines.Registro.Interno = Nothing

            If Me._IDInternoLocal > 0 Then

                'si es un dato existente 
                objEntFiltroRegula = New Bussines.Registro.InternoRegularizacion.Interno

                Dim objEnt As New Entity.Registro.Interno

                objBssInterno = New Bussines.Registro.Interno
                objEnt = objBssInterno.Listar_LM(Me._IDInternoLocal)

                With objEntFiltroRegula
                    .IDInterno = Me._IDInternoLocal
                    .IDRow = objEnt.RowID
                    .CodigoRP = objEnt.CodigoRP
                    .IDRegion = objEnt.RegionID
                    .IDPenal = objEnt.PenalID
                    .VersionRegistro = objEnt.VersionRegistro
                    .IDTipoDocumento = objEnt.TipoDocumentoID
                    .NumeroDocumento = objEnt.NumeroDocumento
                    .PrimerApellido = objEnt.ApellidoPaterno
                    .SegundoApellido = objEnt.ApellidoMaterno
                    .Nombres = objEnt.Nombres
                    .FechaNacimiento = objEnt.FechaNacimiento
                    .IDNacionalidad = objEnt.NacionalidadID
                    .InternoEstado = objEnt.EstadoID
                End With

                'abrir un hilo, para realizar la espera del usuario
                Me.SuspendLayout()

                'If Me.BackgroundWorker1.IsBusy Then Exit Sub
                Me.BackgroundWorker1.RunWorkerAsync()

                frmLoad = New Load.frmProcesando
                If frmLoad.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.BackgroundWorker1.CancelAsync()
                    Me.BackgroundWorker1.Dispose()
                End If
                Me.ResumeLayout(True)
                frmLoad.Refresh()

                value = blnRegistroRegula

            Else
                value = True
            End If

            Return value
        End Function
        Private Sub RecuperarFoto(ByRef strMensajeOut As String)

            'listar los registros de fotos, incluida la fecha
            'listar los ingresos inpe

            'recorrer las fotos e incluirlo en el intervalo del ingreso inpe.            

            Dim objDTFotos As New DataTable
            Dim objDTIngresoInpe As New DataTable

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            strSqlQuery = "select * from INT_InternoFoto where _flg_eli=0 and isnull(fk_ing_inp_id,-1)<1 and _penid=" &
                                                        Me._IDPenal & " and int_id=" & Me._IDInternoLocal
            objDTFotos = Legolas.Components.SQL.Select_DataTable(sqlCon, strSqlQuery, strMensajeOut)

            'si hay registros de fotos
            If objDTFotos.Rows.Count > 0 Then

                sqlCon = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                strSqlQuery = "select 
	                        ii.pk_ing_inp_id ,
	                        i.int_ing_id,
	                        ii.n_fec_ing_inp ,
	                        ii.n_fec_mov_ing 	
                        from 
	                        int_mov_interno_ingreso_inpe as ii 
	                        inner join INT_InternoIngreso as i on ii.pk_ing_inp_id =i.fk_ing_inp_id 
		                        and i._flg_eli =0
                        where 
	                        ii._flg_eli=0 
	                        and ii.fk_int_id =" & Me._IDInternoLocal &
                            " order by n_fec_ing_inp asc"

                objDTIngresoInpe = Legolas.Components.SQL.Select_DataTable(sqlCon, strSqlQuery, strMensajeOut)
                strSqlQuery = ""

                For Each fila As DataRow In objDTFotos.Rows

                    Dim lngIDFoto As Long = fila.Item("int_fot_id")
                    Dim lngFechaMod As Long = fila.Item("_fec_cre")
                    Dim dteFecha As Date = Legolas.Components.FechaHora.FechaDate(lngFechaMod)

                    Dim blnPrimeraVez As Boolean = True
                    Dim intIDIngresoInpeOld As Long = -1
                    Dim intIDIngresoOld As Long = -1
                    Dim blnSeEjecuto As Boolean = False

                    For Each fila2 As DataRow In objDTIngresoInpe.Rows

                        Dim lngIDIngresoInpeActual As Long = fila2.Item("pk_ing_inp_id")
                        Dim lngIDIngresoActual As Long = fila2.Item("int_ing_id")
                        Dim lngIngInpeFechaMod As Long = fila2.Item("n_fec_ing_inp")
                        Dim dteIngInpeFecha As Date = Legolas.Components.FechaHora.FechaDate(lngIngInpeFechaMod)

                        If dteFecha < dteIngInpeFecha Then

                            If blnPrimeraVez = True Then
                                intIDIngresoInpeOld = lngIDIngresoInpeActual
                                intIDIngresoOld = lngIDIngresoActual
                            End If

                            'actualizar la foto del interno
                            strSqlQuery = "update int_internofoto set _flg_trf=1,fk_ing_inp_id=" & intIDIngresoInpeOld & ", int_ing_id=" & intIDIngresoOld &
                                            " where int_id=" & Me._IDInternoLocal & " and int_fot_id=" & lngIDFoto

                            sqlCon = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                            Legolas.Components.SQL.ExecuteBatchNonQuery(sqlCon, strSqlQuery, strMensajeOut)
                            blnSeEjecuto = True
                            Exit For

                        Else
                            intIDIngresoInpeOld = lngIDIngresoInpeActual
                            intIDIngresoOld = lngIDIngresoActual
                        End If

                        blnPrimeraVez = False
                    Next

                    'se actualiza con el ultimo registro
                    If blnSeEjecuto = False Then
                        'actualizar la foto del interno, con el ultimo ingreso
                        strSqlQuery = "update int_internofoto set _flg_trf=1,fk_ing_inp_id=" & intIDIngresoInpeOld & ", int_ing_id=" & intIDIngresoOld &
                                    " where int_id=" & Me._IDInternoLocal & " and int_fot_id=" & lngIDFoto

                        sqlCon = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                        Legolas.Components.SQL.ExecuteBatchNonQuery(sqlCon, strSqlQuery, strMensajeOut)
                    End If

                Next

            End If

        End Sub
#End Region
        Private Sub frmVinculacionPLMPopup_Shown(sender As Object, e As EventArgs) Handles Me.Shown

            ListarGrilla()

        End Sub

        Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

            Me.DialogResult = DialogResult.Cancel

        End Sub

        Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

            If Me.SedeRowID < 1 Then
                MessageBox.Show("Ingrese el ID del Interno Sede", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim objWs As New APPWebService.ws_pope_sede_plm_Interno.InternoSede
            objWs.Url = APPWebService.PathURL.ws_sede_plm_Interno

            Dim objResult As New APPWebService.ws_pope_sede_plm_Interno.DTO_ResultOfDataTable
            Dim objDTO As New APPWebService.ws_pope_sede_plm_Interno.DTO_Interno
            objDTO.IDInternoSede = Me.SedeRowID

            objResult = objWs.InternoPLM_SelectRowID(objDTO)
            Me.dgwGrillaSede.DataSource = objResult.Resultado

        End Sub

        Private Sub dgwGrillaPenal_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwGrillaPenal.CellFormatting

            With Me.dgwGrillaPenal
                Select Case e.ColumnIndex

                    Case .Columns("col_pen_fec_nac").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value, True)
                        Else
                            e.Value = ""
                        End If

                End Select
            End With

        End Sub

        Private Sub dgwGrillaSede_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwGrillaSede.CellFormatting

            With Me.dgwGrillaSede
                Select Case e.ColumnIndex

                    Case .Columns("col_sed_fec_nac").Index

                        If IsNumeric(e.Value) And e.Value > 1 Then
                            e.Value = Legolas.Components.FechaHora.FechaDate(e.Value, True)
                        Else
                            e.Value = ""
                        End If

                End Select
            End With

        End Sub

        Private Sub btnVerDiferencias_Click(sender As Object, e As EventArgs) Handles btnVerDiferencias.Click

            AVerDiferencias()

            Me.btnVerDiferencias.Enabled = False
            Me.btnVincular.Enabled = True

        End Sub

        Private Sub btnVincular_Click(sender As Object, e As EventArgs) Handles btnVincular.Click

            If Validar() = False Then
                Exit Sub
            End If

            If Me.GrillaIDInternoSede < 1 Then
                MessageBox.Show("El interno Sede debe tener su codigo  _SedeRowID, verifique", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If MessageBox.Show("Desea vincular el interno con el registro de Sede", Me.Text,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                AVincular()
                Me.btnVincular.Enabled = False
            End If

        End Sub

        Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

            Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

            If Me.BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True
            Else

                Dim strMensajeOut As String = ""
                Dim objBss As New Bussines.Registro.InternoRegularizacion(APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno)
                e.Result = objBss.RegularizarDatosInterno(True, objEntFiltroRegula, strMensajeOut)

                'Dim strMensajeOut As String = ""
                'Dim objBss As New Bussines.Registro.InternoRegularizacion
                'value = objBss.RegularizarDatosInterno(objEntFiltro, strMensajeOut)             

                If e.Result = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeOut)
                End If

                blnRegistroRegula = e.Result

            End If

        End Sub

        Private Sub BackgroundWorker1_Disposed(sender As Object, e As EventArgs) Handles BackgroundWorker1.Disposed

            If Me.BackgroundWorker1.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario cancelo el proceso de busqueda")
                Me.BackgroundWorker1 = Nothing
                Me.Close()
            End If

        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

            Dim result As Boolean = False
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoad.Close()
                result = e.Result
            End If

        End Sub
        '        RE_VIN_FOTO

        'interno (business)
        'irecepcioninternotraslado (tranferencia) businnes

        'marcelo huaman luisa yolanda
    End Class
End Namespace
