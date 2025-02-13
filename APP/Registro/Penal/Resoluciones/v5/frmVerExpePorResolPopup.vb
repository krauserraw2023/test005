Namespace Registro.Resoluciones
    Public Class frmVerExpePorResolPopup
        Private InternoIngresoId As Integer = -1
        Private intIntId As Integer = -1
        Private InternoIngresoInpeId As Integer = -1

        Private intTmp_ExpId As Integer = -1 'Captura el id del expe actual y no volver a cargar datos al hacer click sobre el mismo registro en el treeview

        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
#Region "Otros"
        Private Sub SeguimientoExpe(ExpedienteId As Integer)
            Dim parentnode As TreeNode
            Dim childnode As TreeNode

            Dim objEnt As New Entity.Registro.Expediente
            Dim objEntCol As New Entity.Registro.ExpedienteCol
            Dim objIng As Entity.Registro.Ingreso
            'Dim objIngInpe As Entity.Registro.IngresoInpe

            objIng = (New Bussines.Registro.Ingreso).Listar(InternoIngresoId)

            'objIngInpe = (New Bussines.Registro.IngresoInpe).Listar(Me.InternoIngresoInpeId)

            parentnode = New TreeNode("Ingreso N° " & objIng.IngresoNro & "      Fecha: " & objIng.FechaIngresoDate)

            parentnode.ForeColor = Color.DarkBlue

            Dim entObjCol As New Entity.Registro.ExpedienteCol
            objEnt.Codigo = ExpedienteId
            entObjCol = (New Bussines.Registro.Expediente).Listar_v2(objEnt)
            objEnt = entObjCol.Expediente(0)
            childnode = parentnode.Nodes.Add("Exp. N°: " & objEnt.ExpedienteNumero & "      Juzgado/Sala: " & objEnt.SalaJudicialNombre)
            childnode.ForeColor = Color.Brown
            childnode.StateImageIndex = 0

            Dim ListResol As New Entity.Registro.DocumentoJudicialCol
            MuestraResolucion(objEnt.Codigo, ListResol)

            Dim obj As Entity.Registro.DocumentoJudicial
            For i As Integer = ListResol.Count - 1 To 0 Step -1
                obj = ListResol.DocumentoJudicial(i)
                childnode.Nodes.Add("Fecha Recep Doc.: " & obj.DocumentoFechaRecepDate & "    " & obj.DocumentoTipoNombre.PadRight(35, "*") & "       Expe: " + obj.DocumentoNumero & "      Libro: " & obj.NumLibro & " Folio: " & obj.NumFolio)
            Next

            tvExpeHistorico.Nodes.Add(parentnode)
            tvExpeHistorico.ExpandAll()
            intTmp_ExpId = ExpedienteId
        End Sub

        Private Sub MuestraResolucion(IdExp As Integer, ByRef listObjExp As Entity.Registro.DocumentoJudicialCol)

            Dim objPad As Entity.Registro.InternoExpedientePadre
            Dim objPadCol As Entity.Registro.InternoExpedientePadreCol
            Dim ObjEntFiltroExpDocJud As New Entity.Registro.Documento.DocumentoJudicialExpediente
            Dim objDocJudExp As Entity.Registro.Documento.DocumentoJudicialExpedienteCol
            Dim salto As Boolean = False
            Dim tmp_exp_id As Integer = -1

            objPad = New Entity.Registro.InternoExpedientePadre

            Dim tmp_ent As New Entity.Registro.Expediente
            tmp_ent.Codigo = IdExp
            Dim entObjCol As New Entity.Registro.ExpedienteCol
            entObjCol = (New Bussines.Registro.Expediente).Listar_v2(tmp_ent)
            tmp_ent = entObjCol.Expediente(0)
            '-------------------------------------------
            'solo si es avocamiento
            Dim objDoc As New Entity.Registro.DocumentoJudicial
            objDoc.Codigo = tmp_ent.CreaDocJudicialId
            Dim bss_exp_hij As New Bussines.Registro.InternoExpedientePadre
            Dim ent As New Entity.Registro.InternoExpedientePadre
            If (New Bussines.Registro.DocumentoJudicial).Listar(objDoc).DocumentoTipo = 9 Then 'resolucion de avocamiento
                ent.InternoExpedienteId = IdExp
                ent = bss_exp_hij.ListarGrilla(ent).InternoExpedientePadre(0)
                tmp_exp_id = ent.InternoExpedienteRefPadreId

                salto = True
            End If
            '-------------------------------------------

            ObjEntFiltroExpDocJud.IDExpediente = IdExp
            objDocJudExp = (New Bussines.Registro.Expediente).Listar(ObjEntFiltroExpDocJud)

            ObjEntFiltroExpDocJud = objDocJudExp.DocumentoJudicial(0)
            If ObjEntFiltroExpDocJud Is Nothing Then Exit Sub

            Dim entResol As New Entity.Registro.DocumentoJudicial
            entResol.Codigo = ObjEntFiltroExpDocJud.DocJudicialId
            entResol = (New Bussines.Registro.DocumentoJudicial).Listar(entResol)
            listObjExp.Add(entResol)

            If salto Then IdExp = tmp_exp_id

            objPad.InternoExpedienteId = IdExp
            objPadCol = bss_exp_hij.ListarGrilla(objPad)

            If objPadCol Is Nothing Then Exit Sub

            If objPadCol.Count >= 2 Then
                Exit Sub
            Else
                For Each objPadTmp As Entity.Registro.InternoExpedientePadre In objPadCol
                    'llamar funcion recursivamente
                    If objPadTmp.InternoExpedienteRefPadreId = -1 Then Exit For
                    MuestraResolucion(objPadTmp.InternoExpedienteRefPadreId, listObjExp)
                Next
            End If
        End Sub

        Private Sub ListaExpedientes()

            Dim parentnode As TreeNode
            Dim childnode As TreeNode

            Dim objEnt As New Entity.Registro.Expediente
            Dim objEntCol As New Entity.Registro.ExpedienteCol
            Dim objTmp As New Entity.Registro.Expediente

            objTmp.IngresoID = InternoIngresoId
            objTmp.IngresoInpeId = Me.InternoIngresoInpeId

            Select Case Me._TipoLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta
                    objTmp.IngresoID = -1
                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                    objTmp.IngresoID = -1
                Case Else
                    objTmp.IngresoInpeId = -1
            End Select
            


            objTmp.InternoID = intIntId
            objTmp.ExpedienteVisible = 1
            objEntCol = (New Bussines.Registro.Expediente).Listar_LM(objTmp)
            For Each objEnt In objEntCol
                objEnt.DocumentoTipoID = objEnt.DocumentoTipoID
                parentnode = New TreeNode(objEnt.ExpedienteNumero.PadRight(18) & " " & objEnt.AutoridadJudicialNombre.PadRight(30) & objEnt.SalaJudicialNombre.PadRight(70) & " " & objEnt.SituacionJuridicaNombre.PadRight(20) & " " & objEnt.ExpedienteSecretario.PadRight(40))
                parentnode.Name = objEnt.Codigo
                parentnode.ForeColor = Color.DarkBlue
                'parentnode.StateImageIndex = 0
                tvExpe.Nodes.Add(parentnode)

                'listar delitos
                Dim objDel As New Entity.Registro.Delito
                Dim objDelCol As New Entity.Registro.DelitoCol

                objDelCol = (New Bussines.Registro.Delito).Listar(-1, -1, -1, objEnt.Codigo, -1, -1)
                For Each objDel In objDelCol
                    childnode = parentnode.Nodes.Add(UCase(objDel.DelitoGenericoNombre) & " (" & UCase(objDel.DelitoEspecificoNombre) & ")")
                    childnode.Name = objEnt.Codigo
                    childnode.ForeColor = Color.Brown
                    childnode.StateImageIndex = 0
                    Dim objEntColAg As New Entity.Registro.AgraviadoCol
                    Dim objEntAg As New Entity.Registro.Agraviado
                    Dim objEnt_ As New Entity.Registro.Agraviado
                    With objEnt_
                        .Codigo = -1
                        .DelitoID = objDel.Codigo
                        .InternoID = -1
                        .IngresoID = -1
                        .ExpedienteID = -1
                        .TipoSentenciaId = -1
                        .AgraviadoNombre = ""
                    End With
                    objEntColAg = (New Bussines.Registro.InternoAgraviado).Listar(objEnt_)

                    For Each objEntAg In objEntColAg
                        childnode.Nodes.Add(UCase(objEntAg.AgraviadoNombre)).Name = objEnt.Codigo
                    Next
                Next

                If objEnt.DocumentoTipoID = 29 Or objEnt.DocumentoTipoID = 28 Or objEnt.DocumentoTipoID = 20 Or objEnt.DocumentoTipoID = 19 Then
                    Dim nodosList As New List(Of TreeNode)
                    parentnode.Tag = objEnt.DocumentoJudicialID
                    'listar los exp
                    objEnt.DocumentoJudicialID = objEnt.DocumentoJudicialID
                    Dim entDocJudExp As New Entity.Registro.Documento.DocumentoJudicialExpediente
                    Dim entDocJudExpCol As Entity.Registro.Documento.DocumentoJudicialExpedienteCol

                    'Dim bssDocJudExp As New Bussines.Registro.Documento.DocumentoJudicialExpediente
                    Dim bssDocJudExp As New Bussines.Registro.Expediente
                    entDocJudExp.DocJudicialId = objEnt.DocumentoJudicialID

                    entDocJudExpCol = bssDocJudExp.Listar(entDocJudExp)

                    For Each DJexp As Entity.Registro.Documento.DocumentoJudicialExpediente In entDocJudExpCol
                        Dim objExpCol As New Entity.Registro.ExpedienteCol
                        objTmp = New Entity.Registro.Expediente
                        objTmp.Codigo = DJexp.IDExpediente
                        objTmp.InternoID = intIntId
                        objExpCol = (New Bussines.Registro.Expediente).Listar_v2(objTmp)
                        objExpCol = objExpCol
                        For Each exp As Entity.Registro.Expediente In objExpCol
                            childnode = parentnode.Nodes.Add(exp.ExpedienteNumero.PadRight(18) & exp.AutoridadJudicialNombre.PadRight(30) & exp.SalaJudicialNombre.PadRight(70) & " " & exp.SituacionJuridicaNombre.PadRight(20) & " " & exp.ExpedienteSecretario.PadRight(40))
                            childnode.Name = exp.Codigo
                            childnode.ForeColor = Color.Green
                            objDelCol = (New Bussines.Registro.Delito).Listar(-1, -1, -1, exp.Codigo, -1, -1)
                            For Each objDel In objDelCol
                                Dim tn As TreeNode = childnode.Nodes.Add(UCase(objDel.DelitoGenericoNombre) & " (" & UCase(objDel.DelitoEspecificoNombre) & ")")
                                tn.Name = exp.Codigo
                                tn.ForeColor = Color.Brown
                                tn.StateImageIndex = 0

                                Dim nodPadDeltis As New TreeNode(UCase(objDel.DelitoGenericoNombre) & " (" & UCase(objDel.DelitoEspecificoNombre) & ")")
                                nodPadDeltis.Name = objEnt.Codigo
                                nodPadDeltis.ForeColor = Color.Brown
                                nodPadDeltis.StateImageIndex = 0
                                nodPadDeltis.Tag = objEnt.DocumentoJudicialID

                                Dim objEntColAg As New Entity.Registro.AgraviadoCol
                                Dim objEntAg As New Entity.Registro.Agraviado
                                Dim objEnt_ As New Entity.Registro.Agraviado
                                With objEnt_
                                    .Codigo = -1
                                    .DelitoID = objDel.Codigo
                                    .InternoID = -1
                                    .IngresoID = -1
                                    .ExpedienteID = -1
                                    .TipoSentenciaId = -1
                                    .AgraviadoNombre = ""
                                End With
                                objEntColAg = (New Bussines.Registro.InternoAgraviado).Listar(objEnt_)

                                For Each objEntAg In objEntColAg
                                    tn.Nodes.Add(UCase(objEntAg.AgraviadoNombre)).Name = exp.Codigo

                                    Dim tn_agrav As New TreeNode(UCase(objEntAg.AgraviadoNombre))
                                    tn_agrav.Name = objEnt.Codigo
                                    tn_agrav.Tag = objEnt.DocumentoJudicialID
                                    nodPadDeltis.Nodes.Add(tn_agrav)
                                Next
                                nodosList.Add(nodPadDeltis)
                            Next


                        Next

                        'agregar delitos
                    Next
                    For Each n As TreeNode In nodosList
                        parentnode.Nodes.Add(n)
                    Next
                    entDocJudExpCol = entDocJudExpCol

                End If
            Next

        End Sub
#End Region


        Private Sub frmVerExpePorResolPopup_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            Me.Cursor = Cursors.WaitCursor
            ListaExpedientes()
            Me.Cursor = Cursors.Default
        End Sub

        Public Sub New(IdNumIngreso As Integer, IntId As Integer, Optional n_IngresoInpeId As Integer = -1)
            InitializeComponent()
            Me.InternoIngresoInpeId = n_IngresoInpeId
            Me.InternoIngresoId = IdNumIngreso
            Me.intIntId = IntId
        End Sub

        Private Sub SeguimientoExpe_Acumulados(DocJudId As Integer)
            Dim parentnode As TreeNode
            Dim childnode As TreeNode

            Dim objEntDj As New Entity.Registro.DocumentoJudicial
            Dim objEntCol As New Entity.Registro.ExpedienteCol
            Dim objIng As Entity.Registro.Ingreso

            objIng = (New Bussines.Registro.Ingreso).Listar(InternoIngresoId)
            parentnode = New TreeNode("Ingreso N° " & objIng.IngresoNro & "      Fecha: " & objIng.FechaIngresoDate)
            parentnode.ForeColor = Color.DarkBlue

            objEntDj.Codigo = DocJudId
            objEntDj = (New Bussines.Registro.DocumentoJudicial).Listar(objEntDj)
            'objEnt = (New Bussines.Registro.Expediente).Listar(ExpedienteId)

            childnode = parentnode.Nodes.Add("Exp. N°: " & objEntDj.DocumentoNumero & "      Juzgado/Sala: " & objEntDj.SalaJudNombre)
            childnode.ForeColor = Color.Brown
            childnode.StateImageIndex = 0

            'Dim ListResol As New Entity.Registro.DocumentoJudicialCol
            'MuestraResolucion(objEnt.Codigo, ListResol)

            'Dim obj As Entity.Registro.DocumentoJudicial
            'For i As Integer = ListResol.Count - 1 To 0 Step -1
            '    obj = ListResol.DocumentoJudicial(i)
            childnode.Nodes.Add("Fecha Recep Doc.: " & objEntDj.DocumentoFechaRecepDate & "    " & objEntDj.DocumentoTipoNombre.PadRight(35, "*") & "       Expe: " + objEntDj.DocumentoNumero & "      Libro: " & objEntDj.NumLibro & " Folio: " & objEntDj.NumFolio)
            'Next

            tvExpeHistorico.Nodes.Add(parentnode)
            tvExpeHistorico.ExpandAll()
            'intTmp_ExpId = ExpedienteId
            intTmp_ExpId = DocJudId
        End Sub
        Private Sub tvExpe_AfterSelect(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tvExpe.AfterSelect
            Dim node As TreeNode = e.Node
            If (Not (node Is Nothing)) Then
                Dim key As String = node.Name
                If intTmp_ExpId <> Val(node.Name) Then
                    tvExpeHistorico.Nodes.Clear()
                    If String.IsNullOrEmpty(node.Tag) Then
                        SeguimientoExpe(Val(node.Name))
                    Else
                        SeguimientoExpe_Acumulados(Val(node.Tag))
                    End If
                End If
            End If
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub
    End Class
End Namespace