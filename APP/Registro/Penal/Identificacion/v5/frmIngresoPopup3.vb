Imports System.Windows.Forms
Namespace Registro.Identificacion.v5
    Public Class frmIngresoPopup3
        Private objBss As Bussines.Registro.Ingreso = Nothing
        Private objEnt As Entity.Registro.Ingreso = Nothing
        Private objBssHis As Bussines.Registro.InternoHistorico = Nothing
        Private objBssInt As Bussines.Registro.InternoMovimiento = Nothing
        Private objEntCol As New Entity.Registro.IngresoCol
        Public blnNuevosDatos As Boolean = False
        Private blnCargarForm As Boolean = False
#Region "Propiedades_Par"
        Public Property InternoID() As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
        Public Property _PermisoEliminar() As Boolean = False
        Public Property _NuevoClick As Boolean = False
        Public Property _ValidarIngreso As Boolean = False
        Public Property _ValidarIngreso0 As Boolean = False
#End Region

#Region "Propiedades_Ingreso"
        Private Property NumeroIngreso() As Integer
            Get
                Try
                    Return Integer.Parse(Me.NumericUpDown1.Value)
                Catch ex As Exception

                End Try
            End Get
            Set(ByVal value As Integer)
                Try
                    Me.NumericUpDown1.Value = value
                Catch ex As Exception

                End Try

            End Set
        End Property
        Private Property FechaIngresoISP() As Long
            Get
                Return Me.dtpFechaIngresoISP.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaIngresoISP.ValueLong = value
            End Set
        End Property
        Private Property FechaIngreso() As Long
            Get

                Return Me.dtpFechaIng.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaIng.ValueLong = value
            End Set
        End Property
        Private Property Observacion() As String
            Get
                Return Me.txtobservacion.Text
            End Get
            Set(ByVal value As String)
                Me.txtobservacion.Text = value
            End Set
        End Property
        Private Property IngresoAux() As Integer = -1
        Private Property TipoLibertadID() As Integer = -1

        Private Property FechaLibertad() As Long = 0

        Private intGrillaCountIngreso As Integer = 0
        Private Property GrillaCountIngreso() As Integer
            Get
                Return intGrillaCountIngreso
            End Get
            Set(ByVal value As Integer)
                intGrillaCountIngreso = value
                Me.lblRegIngreso.Text = intGrillaCountIngreso.ToString & " Reg."
            End Set
        End Property
        Public ReadOnly Property GrillaDgwFilas() As Integer
            Get
                Dim intValue As Integer = 0
                Try
                    With Me.dgwIngreso
                        intValue = .Rows.Count
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property
        Private ReadOnly Property GrillaIngresoCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwIngreso
                        intValue = .SelectedRows(0).Cells("col_ing_id").Value
                    End With
                Catch ex As Exception

                End Try

                Return intValue
            End Get
        End Property

#End Region

#Region "Propiedades_Otros"
        Public Property Estado() As Boolean = False
#End Region

#Region "Listar"
        Private Sub ListarDataIng()
            'calcular cuantos ingresos tiene activos
            'maximo 2 ingresos activos (actual y 1 historico)

            objBss = New Bussines.Registro.Ingreso
            objEnt = New Entity.Registro.Ingreso

            If Me.GrillaIngresoCodigo < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Registro.Ingreso
            objEnt = New Entity.Registro.Ingreso

            objEnt = objBss.Listar(Me.GrillaIngresoCodigo, Me.InternoID)

            With objEnt
                Me.Codigo = .Codigo
                Me.NumeroIngreso = .IngresoNro
                Me.FechaIngresoISP = .FechaISP
                Me.FechaIngreso = .FechaIngreso
                Me.Observacion = .Observacion
                Me.IngresoAux = .IngresoNro
                Me.TipoLibertadID = .LibertadTipoID
                Me.FechaLibertad = .FechaLibertad
                Me.ckbHistorico.Checked = IIf(.Historico = True, True, False)
                UscAuditUser1.LoadAudit(Me.GrillaIngresoCodigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoIngreso)
                ckbHistorico.Visible = .HistoricoVisible
            End With
            btnGrabar.Text = "Modificar"
            btnGrabar.Image = My.Resources._1277961326_folder_edit
            InhabilitarControl(True)

        End Sub
        Public Sub _LoadUsc()

            ListarGrilla()
        End Sub
        Private Sub ListarGrilla()

            If Me.InternoID < 1 Then
                Exit Sub
            End If

            Dim objBss As New Bussines.Registro.Ingreso
            Dim objEnt As New Entity.Registro.Ingreso
            objEnt.InternoID = Me.InternoID
            objEnt.PenalID = Me.PenalID
            objEntCol = objBss.Listar(objEnt)

            With Me.dgwIngreso
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objEntCol
                Me.GrillaCountIngreso = .RowCount
            End With

        End Sub
#End Region

#Region "Accion"

        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True

            'interno id
            If Me.InternoID < 1 Then
                MessageBox.Show("Seleccione el interno antes de grabar", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Return blnValue
            End If

            '/*numero
            If Me.NumeroIngreso < 1 Then
                MessageBox.Show("El numero de ingreso no puede ser menor a 1", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.NumericUpDown1.Focus()
                Return blnValue
            End If

            '/*numero de ingreso maximo
            If Me.NumeroIngreso > 99 Then
                MessageBox.Show("El numero de ingreso no puede ser mayor a 99", _
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.NumericUpDown1.Focus()
                Return blnValue
            End If

            '/*fecha ingreso
            If Me.FechaIngresoISP < 1 Then
                MessageBox.Show("Ingrese fecha de ingreso al Sistema Penitenciario.", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.dtpFechaIng.Focus()
                Return blnValue
            End If

            'validar el numero de padin
            objBss = New Bussines.Registro.Ingreso
            If objBss.ValidarNumeroIngresoAbierto(Me.InternoID, Me.RegionID, Me.PenalID) > 3 Then
                MessageBox.Show("Solo puede existir 3 ingresos sin libertad como maximo.", _
               Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.dtpFechaIng.Focus()
                Return blnValue
            End If

            For Each fila As DataGridViewRow In Me.dgwIngreso.Rows
                If Me.Codigo <> fila.Cells("col_ing_id").Value Then

                    If Me.NumeroIngreso = fila.Cells("col_ing_nro").Value Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El numero de ingreso ya existe, cambie los datos.")
                        blnValue = False
                        Me.NumericUpDown1.Focus()
                        Return blnValue
                    End If
                End If
            Next

            Return blnValue
        End Function

        Private Sub AGrabar()
            Dim blnCondicion As Boolean = False

            If btnGrabar.Text = "Modificar" Then

                If Me.GrillaIngresoCodigo < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione registro")
                    Exit Sub
                End If

                InhabilitarControl(False)
                btnGrabar.Text = "&Grabar"
                btnGrabar.Image = My.Resources.Drive___USB_32

                btnIngreso.Text = "Cancelar"
                btnIngreso.Image = My.Resources.anular2
                Exit Sub
            End If
            If Validar() = False Then
                Exit Sub
            End If

            If Me.ckbHistorico.Checked = True Then
                Dim IngNromay As Integer = -1
                Dim IngIdmay As Integer = -1
                For Each fila As DataGridViewRow In Me.dgwIngreso.Rows
                    If fila.Cells("col_ing_nro").Value > IngNromay Then
                        IngNromay = fila.Cells("col_ing_nro").Value
                        IngIdmay = fila.Cells("col_ing_id").Value
                    End If
                Next
                If Me.Codigo = IngIdmay Then
                    Dim strMensage As String = "Ha activado el control Ingreso historico [✔], por lo tanto" + Chr(13) +
                                           "el interno pasara a el estado de INACTIVO, desea continuar."
                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensage) = DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If

            Dim objEnt As Entity.Registro.Ingreso
            objBss = New Bussines.Registro.Ingreso
            objEnt = New Entity.Registro.Ingreso
            Dim intValue As Integer = -1

            With objEnt
                If Me.Codigo < 1 Then
                    blnCondicion = True
                End If
                .Codigo = Me.Codigo
                .InternoID = Me.InternoID
                .IngresoNro = Me.NumeroIngreso
                .FechaISP = Me.FechaIngresoISP
                '.MotivoIngresoID = Me.MotivoIngreso
                .MotivoIngresoID = -1
                .FechaIngreso = Me.FechaIngreso
                .PenalNum = -1
                .RegionID = Me.RegionID
                .PenalID = Me.PenalID
                .Observacion = Me.Observacion
                .Estado = Me.Estado
                .IngresoNroAux = Me.IngresoAux
                .LibertadTipoID = Me.TipoLibertadID
                .FechaLibertad = Me.FechaLibertad
                .Historico = IIf(Me.ckbHistorico.Checked = True, 1, 0)
            End With

            Dim intValueHis As Integer = -1            
            ' se incia verificacion para ver si se va a traslado
            '/**********************/
            If Me.InternoID < 1 Then
                Exit Sub
            End If
            Dim objIngCol As New Entity.Registro.IngresoCol
            Dim objEntInt As New Entity.Registro.Interno
            Dim objBssInterno As New Bussines.Registro.Interno
            'Dim objEnt_ As New Entity.Registro.Ingreso
            'objEnt_.InternoID = Me.InternoID

            objEntInt.Codigo = Me.InternoID
            objIngCol = objBss.ListarNroIngreso(Me.InternoID, Me.PenalID)
            Dim objHisInterno As New Entity.Registro.InternoHistorico
            Dim blnVar As Boolean = False

            For Each obj As Entity.Registro.Ingreso In objIngCol
                If Me.NumeroIngreso > obj.IngresoNro Then
                    objBssHis = New Bussines.Registro.InternoHistorico
                    Dim objEntHisInt As New Entity.Registro.InternoHistorico
                    objEntHisInt.InternoID = Me.InternoID
                    objEntHisInt.IngresoID = obj.Codigo
                    objHisInterno = objBssHis.Listar(objEntHisInt)
                    blnVar = True
                    Exit For
                End If
            Next

            Dim objEntHis As New Entity.Registro.InternoHistorico
            If blnVar = True Then
                If objHisInterno Is Nothing Then
                    objEntInt.Codigo = Me.InternoID
                    objEntInt = objBssInterno.Listar_v5(Me.InternoID)
                    objHisInterno = CopiarPropiedades(objEntHis, objEntInt)
                    CopiarPropiedades2(objEntHis, objHisInterno)
                ElseIf objHisInterno.Codigo < 1 Then
                    objEntInt.Codigo = Me.InternoID
                    objEntInt = objBssInterno.Listar_v5(Me.InternoID)
                    objHisInterno = CopiarPropiedades(objEntHis, objEntInt)
                    CopiarPropiedades2(objEntHis, objHisInterno)
                Else
                    CopiarPropiedades2(objEntHis, objHisInterno)
                End If

            Else
                objEntInt = objBssInterno.Listar_v5(Me.InternoID)
                CopiarPropiedades(objEntHis, objEntInt)
            End If

            intValue = objBss.Grabar2(objEnt)

            If intValue > 0 Then
                objBssHis = New Bussines.Registro.InternoHistorico
                objEntHis.IngresoID = intValue
                objEntHis.InternoID = Me.InternoID
                If Me.Codigo < 1 Then intValueHis = objBssHis.GrabarV2(objEntHis)

                '***********************************************************
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                ListarGrilla()
                Me._ValidarIngreso = False
                Me._ValidarIngreso0 = False
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub

        Private Function CopiarPropiedades(objEntHis As Entity.Registro.InternoHistorico, ObjEntInt As Entity.Registro.Interno) As Entity.Registro.InternoHistorico
            With ObjEntInt
                '/*datos generales*/
                objEntHis.CodigoRP = .CodigoRP
                objEntHis.Libro = .Libro
                objEntHis.Folio = .Folio
                objEntHis.ApellidoPaterno = .ApellidoPaterno
                objEntHis.ApellidoMaterno = .ApellidoMaterno
                objEntHis.Nombres = .Nombres
                objEntHis.SexoID = .SexoID
                objEntHis.FechaNacimiento = .FechaNacimiento
                objEntHis.TipoDocumentoID = .TipoDocumentoID

                objEntHis.NumeroDocumento = .NumeroDocumento
                objEntHis.EstadoCivilID = .EstadoCivilID
                objEntHis.NacionalidadID = .NacionalidadID
                objEntHis.Discapacidad = .Discapacidad
                '/*ubigeo nacimiento*/
                objEntHis.NacimientoPaisID = .NacimientoPaisID
                objEntHis.NacimientoUbigeoID = .NacimientoUbigeoID
                objEntHis.NacimientoOtros = .NacimientoOtros
                '/*ubigeo domicilio*/
                objEntHis.DomicilioDepartamentoNombre = .DomicilioDepartamentoNombre
                objEntHis.DomicilioProvinciaNombre = .DomicilioProvinciaNombre
                objEntHis.DomicilioDistritoNombre = .DomicilioDistritoNombre
                objEntHis.DomicilioUbigeoID = .DomicilioUbigeoID
                objEntHis.Domicilio = .Domicilio
                '/*datos academicos*/
                objEntHis.NivelAcademicoID = .NivelAcademicoID
                objEntHis.ProfesionID = .ProfesionID
                objEntHis.OcupacionID = .OcupacionID
                '/*comunidad*/
                objEntHis.ComunidadAndinaID = .ComunidadAndinaID
                objEntHis.ComunidadAndinaEspID = .ComunidadAndinaEspID

                objEntHis.NumeroHijos = .NumeroHijos
                objEntHis.HijosMenores = .HijosMenores
                objEntHis.EstadoID = .EstadoID
                '/*region y penal*/
                objEntHis.RegionID = .RegionID
                objEntHis.RegionNombre = .RegionNombre
                objEntHis.PenalID = .PenalID
                objEntHis.PenalNombre = .PenalNombre
                objEntHis.Obs = .Obs
                objEntHis.Obs_DNI = .Obs_DNI

                objEntHis.PabellonID = .PabellonID
                objEntHis.PabellonNombre = .PabellonNombre
                objEntHis.Decadactilar = .Decadactilar
                objEntHis.Homonimia = .Homonimia

                Dim bss As New Bussines.Registro.InternoDatosComplementarios
                Dim obj As New Entity.Registro.InternoDatosComplementarios
                obj = bss.Listar(-1, ObjEntInt.Codigo)
                If obj.Codigo > 0 Then
                    objEntHis.IDGrupoPueblo = obj.IDGrupoPueblo
                    objEntHis.IDPueblo = obj.IDGrupoPueblo
                    objEntHis.OtroPueblo = obj.OtroPueblo
                    objEntHis.IDGrupoLenguaMaterna = obj.IDGrupoLenguaMaterna
                    objEntHis.IDLenguaMaterna = obj.IDLenguaMaterna
                    objEntHis.IDIdioma = obj.IDIdioma
                End If
            End With
            '/*********************/
            Return objEntHis
        End Function

        Private Function CopiarPropiedades2(objEntHis As Entity.Registro.InternoHistorico, ObjEntInt As Entity.Registro.InternoHistorico) As Entity.Registro.InternoHistorico
            With ObjEntInt
                '/*datos generales*/
                objEntHis.Codigo = -1
                objEntHis.CodigoRP = .CodigoRP
                objEntHis.Libro = .Libro
                objEntHis.Folio = .Folio
                objEntHis.ApellidoPaterno = .ApellidoPaterno
                objEntHis.ApellidoMaterno = .ApellidoMaterno
                objEntHis.Nombres = .Nombres
                objEntHis.SexoID = .SexoID
                objEntHis.FechaNacimiento = .FechaNacimiento
                objEntHis.TipoDocumentoID = .TipoDocumentoID

                objEntHis.NumeroDocumento = .NumeroDocumento
                objEntHis.EstadoCivilID = .EstadoCivilID
                objEntHis.NacionalidadID = .NacionalidadID
                objEntHis.Discapacidad = .Discapacidad
                '/*ubigeo nacimiento*/
                objEntHis.NacimientoPaisID = .NacimientoPaisID
                objEntHis.NacimientoUbigeoID = .NacimientoUbigeoID
                objEntHis.NacimientoOtros = .NacimientoOtros
                '/*ubigeo domicilio*/
                objEntHis.DomicilioDepartamentoNombre = .DomicilioDepartamentoNombre
                objEntHis.DomicilioProvinciaNombre = .DomicilioProvinciaNombre
                objEntHis.DomicilioDistritoNombre = .DomicilioDistritoNombre
                objEntHis.DomicilioUbigeoID = .DomicilioUbigeoID
                objEntHis.Domicilio = .Domicilio
                '/*datos academicos*/
                objEntHis.NivelAcademicoID = .NivelAcademicoID
                objEntHis.ProfesionID = .ProfesionID
                objEntHis.OcupacionID = .OcupacionID
                '/*comunidad*/
                objEntHis.ComunidadAndinaID = .ComunidadAndinaID
                objEntHis.ComunidadAndinaEspID = .ComunidadAndinaEspID

                objEntHis.NumeroHijos = .NumeroHijos
                objEntHis.HijosMenores = .HijosMenores
                objEntHis.EstadoID = .EstadoID
                '/*region y penal*/
                objEntHis.RegionID = .RegionID
                objEntHis.RegionNombre = .RegionNombre
                objEntHis.PenalID = .PenalID
                objEntHis.PenalNombre = .PenalNombre
                objEntHis.Obs = .Obs
                objEntHis.Obs_DNI = .Obs_DNI

                objEntHis.PabellonID = .PabellonID
                objEntHis.PabellonNombre = .PabellonNombre
                objEntHis.Decadactilar = .Decadactilar
                objEntHis.Homonimia = .Homonimia
            End With
            '/*********************/
            Return objEntHis
        End Function

        Public Function AEliminarIngreso() As Integer
            Dim Valor As Integer = -1
            If GrillaDgwFilas = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Seleccionar un ingreso para eliminar")
                Return -1
            End If
            If Me._PermisoEliminar = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "No tiene permiso para realizar esta operacion!")
                Return -1
            Else

                Dim strPregunta As String = "¿Esta Seguro de eliminar el Ingreso? " + Chr(13) +
                "" + Chr(13) +
                "Esta accion eliminará los siguientes datos: " + Chr(13) +
                "1. Identificacion del Interno " + Chr(13) +
                "   (Datos personales, Fotos, Nombres asociados, etc)" + Chr(13) +
                "2. Datos de Lista de Expedientes " + Chr(13) +
                "3. Datos de Documentos judiciales y resoluciones" + Chr(13) +
                "4. Datos de Movimiento de ingreso y egreso." + Chr(13) +
                "" + Chr(13) +
                "Una vez eliminado los datos no podra recuperarlo, desea continuar con la operacion"

                If Legolas.Configuration.Aplication.MessageBox.Question(strPregunta) = DialogResult.Yes Then
                    Dim objBss As New Bussines.Registro.Ingreso
                    Dim entIng As New Entity.Registro.Ingreso
                    entIng.InternoID = Me.InternoID
                    entIng.Codigo = Me.GrillaIngresoCodigo
                    Valor = objBss.Eliminar2(entIng)
                    ListarGrilla()
                    Return Valor
                End If
                Return -1
            End If
        End Function
#End Region

#Region "Otros"
        Private Sub InhabilitarControl(Valor As Boolean)
            NumericUpDown1.Enabled = Not (Valor)
            dtpFechaIngresoISP.Enabled = Not (Valor)
            txtobservacion.ReadOnly = Valor
            ckbHistorico.Enabled = Not (Valor)
        End Sub
        Private Sub Usuario_Permiso()
            Me.btnIngreso.Visible = Me._FormEscritura
            Me.btnGrabar.Visible = Me._FormEscritura
            Me.btnEliminar.Visible = Me._FormEliminar

            Me.pnlGrabar.Visible = Me._FormEscritura
            Me.pnlEliminar.Visible = Me._FormEliminar
        End Sub

        Private Sub ValoresxDefault()

            Me.dtpFechaIng.Enabled = False
            Me._PermisoEliminar = Me._FormEliminar

        End Sub

#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmIngresoPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub frmIngresoPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Usuario_Permiso()
            Me.dgwIngreso.CurrentCell = Nothing
            InhabilitarControl(True)

            btnGrabar.Text = "Modificar"
            btnGrabar.Image = My.Resources._1277961326_folder_edit

            If Me._NuevoClick = True Then
                Me._NuevoClick = False
                Me.btnIngreso.PerformClick()
            End If

            blnCargarForm = True
        End Sub

        Private Sub NumericUpDown1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles NumericUpDown1.KeyPress
            MyBase.OnKeyPress(e)
            Dim c As Char = e.KeyChar
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        'Private Sub dgwIngreso_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwIngreso.CellClick

        '    With Me.dgwIngreso
        '        If e.RowIndex = -1 Then
        '            dgwIngreso.SelectedRows(e.RowIndex).Selected = False
        '            .CurrentCell = Nothing
        '        Else
        '            .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
        '        End If
        '    End With

        'End Sub

        'Private Sub dgwIngreso_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwIngreso.CellContentClick
        '    ListarDataIng()
        'End Sub

        Private Sub dgwIngreso_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwIngreso.CellEnter

            If blnCargarForm = True Then
                ListarDataIng()
            End If

        End Sub

        Private Sub dgwIngreso_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgwIngreso.CellPainting
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub

            If dgwIngreso.Item("col_fec_ing_lng", e.RowIndex).Value > dgwIngreso.Item("col_fec_lib", e.RowIndex).Value And dgwIngreso.Item("col_fec_lib", e.RowIndex).Value > 0 Then
                e.CellStyle.BackColor = Color.LightCoral ' dgwGrilla.Item("col_pad_col", e.RowIndex).Value
            End If

        End Sub

        Private Sub btnGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabar.Click
            AGrabar()
        End Sub
        Private Sub btnIngreso_Click(sender As System.Object, e As System.EventArgs) Handles btnIngreso.Click

            If btnIngreso.Text.Trim = "Nuevo" Then
                Dim objEntCol3 As New Entity.Registro.IngresoCol
                For Each obj As Entity.Registro.Ingreso In objEntCol
                    If obj.IngresoNro = 0 Then
                        Me._ValidarIngreso0 = True
                        Exit For
                    End If
                Next
                For Each obj As Entity.Registro.Ingreso In objEntCol
                    If objEntCol3.Count = 0 Then
                        objEntCol3.Add(obj)
                    Else
                        For Each obj3 As Entity.Registro.Ingreso In objEntCol3
                            If obj.IngresoNro = obj3.IngresoNro Then
                                Me._ValidarIngreso = True
                                Exit For
                                Exit For
                            End If
                        Next
                        objEntCol3.Add(obj)
                    End If
                Next
                If Me._ValidarIngreso0 = True And Me._ValidarIngreso = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Regularizar el Nº de ingreso [0] y duplicados.")
                    Exit Sub
                ElseIf Me._ValidarIngreso0 = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Regularizar el Nº de ingreso [0]")
                    Exit Sub
                ElseIf Me._ValidarIngreso = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Regularizar Nº de ingresos duplicados.")
                    Exit Sub
                End If
                Me.Codigo = -1
                btnGrabar.Text = "&Grabar"
                btnGrabar.Image = My.Resources.Drive___USB_32
                btnIngreso.Text = "Cancelar"
                btnIngreso.Image = My.Resources.anular2
                btnEliminar.Enabled = False
                dgwIngreso.Enabled = False
                blnNuevosDatos = True

                NumericUpDown1.Value = 1
                dtpFechaIng.Value = ""
                dtpFechaIngresoISP.Value = ""
                txtobservacion.Text = ""
                InhabilitarControl(False)
                ckbHistorico.Visible = False
                NumericUpDown1.Focus()
            Else
                btnGrabar.Text = "Modificar"
                btnGrabar.Image = My.Resources._1277961326_folder_edit
                btnIngreso.Text = "Nuevo"
                btnIngreso.Image = My.Resources._1277961158_folder_new
                btnEliminar.Enabled = True
                dgwIngreso.Enabled = True
                blnNuevosDatos = False
                InhabilitarControl(True)
                ListarGrilla()
                Me.dgwIngreso.CurrentCell = Nothing
            End If

        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

            If Me.GrillaIngresoCodigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione registro")
                Exit Sub
            End If

            Dim Valor As Integer = AEliminarIngreso()
            If Valor > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub

        Private Sub dtpFechaIngresoISP__ValueChanged() Handles dtpFechaIngresoISP._ValueChanged
            With dtpFechaIngresoISP
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpFechaIngresoISP_Validated(sender As Object, e As System.EventArgs) Handles dtpFechaIngresoISP.Validated
            With dtpFechaIngresoISP
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpFechaIng__ValueChanged() Handles dtpFechaIng._ValueChanged
            With dtpFechaIng
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpFechaIng_Validated(sender As Object, e As System.EventArgs) Handles dtpFechaIng.Validated
            With dtpFechaIng
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dgwIngreso_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwIngreso.CellContentClick

        End Sub
    End Class
End Namespace