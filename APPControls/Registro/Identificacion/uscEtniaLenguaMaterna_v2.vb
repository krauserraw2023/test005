Namespace Registro.Identificacion
    Public Class uscEtniaLenguaMaterna_v2
        Private modoEdicion As Boolean = False
        Private objBss As Bussines.Registro.InternoDatosComplementarios = Nothing
#Region "Propiedades"
        Private Property idDatosComplementario As Integer = -1
        Private Property seConsideraEtnico As Short
            Get
                Dim value As Short = -1

                If Me.rdbNo.Checked = True Then
                    value = 0
                End If

                If Me.rdbSi.Checked = True Then
                    value = 1
                End If

                If Me.rdbNoIndica.Checked = True Then
                    value = 2
                End If
                Return value
            End Get
            Set(value As Short)
                Select Case value
                    Case 0
                        Me.rdbNo.Checked = True
                    Case 1
                        Me.rdbSi.Checked = True
                    Case 2
                        Me.rdbNoIndica.Checked = True
                End Select
            End Set
        End Property
        Private Property idGrupoEtnica() As Integer
            Get
                Try
                    Return Me.cbbGrupoEtnica.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(value As Integer)
                Me.cbbGrupoEtnica.SelectedValue = value
            End Set

        End Property
        Private Property idPuebloEtnica() As Integer
            Get
                Try
                    Return Me.cbbPuebloEtnica.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(value As Integer)
                Me.cbbPuebloEtnica.SelectedValue = value
            End Set

        End Property
        Private Property puebloEtnicaOtro() As String
            Get
                Try
                    Return Me.txtpuebloEtnicaOtro.Text
                Catch ex As Exception
                    Return ""
                End Try
            End Get
            Set(value As String)
                Me.txtpuebloEtnicaOtro.Text = value
            End Set
        End Property
        Private Property idGrupoLenguaMaterna() As Integer
            Get
                Try
                    Return Me.cbbGrupoLenguaMaterna.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(value As Integer)
                Me.cbbGrupoLenguaMaterna.SelectedValue = value
            End Set
        End Property
        Private Property selectIdLenguaMaternaIdioma() As Integer
            Get
                Try
                    Return Me.cbbLenguaMaternaIdioma.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(value As Integer)
                Me.cbbLenguaMaternaIdioma.SelectedValue = value
            End Set
        End Property

        Private Property idLenguaMaterna() As Integer = -1
        Private Property idIdioma As Integer = -1
        Private Property idInterno As Integer = -1
        Private Property idRegion As Short = -1
        Private Property idPenal As Short = -1
#End Region
#Region "Combo"
        Private cargoComboGrupoPuebloEtnica As Boolean = False
        Private cargoComboGrupoLenguaMaterna As Boolean = False
        Private Sub comboGrupoPuebloEtnica()

            Me.cbbGrupoEtnica.ComboTipo = 90 '[reg_pbe_mae_grupo_pueblo]
            Me.cbbGrupoEtnica.LoadUsc()
            Me.cbbGrupoEtnica.SelectedValue = -1
            cargoComboGrupoPuebloEtnica = True
        End Sub
        Private Sub comboPuebloEtnica()

            Me.cbbPuebloEtnica.Visible = False
            Me.puebloEtnicaOtro = ""
            Me.txtpuebloEtnicaOtro.Visible = False
            Me.txtpuebloEtnicaOtro.Enabled = False

            Select Case Me.idGrupoEtnica

                Case 3 'INDÍGENA U ORIGINARIO DE LA AMAZONÍA
                    'Me.txtpuebloEtnicaOtro.Visible = False
                    Me.cbbPuebloEtnica.Visible = True
                    Me.cbbPuebloEtnica.Parametro1 = 2

                Case 4 'PERTENECIENTE O PARTE DE OTRO PUEBLO INDÍGENA U ORIGINARIO
                    'Me.txtpuebloEtnicaOtro.Visible = False
                    Me.cbbPuebloEtnica.Visible = True
                    Me.cbbPuebloEtnica.Parametro1 = 1

                Case 5 'NEGRO, MORENO, ZAMBO, MULATO O AFRODESCENDIENTE
                    Me.puebloEtnicaOtro = "AFRODESCENDIENTE"
                    Me.cbbPuebloEtnica.Parametro1 = 3
                    'Me.cbbPuebloEtnica.Visible = False

                    Me.txtpuebloEtnicaOtro.Visible = True
                    'Me.txtpuebloEtnicaOtro.Enabled = False
                Case 8 'OTRO
                    Me.cbbPuebloEtnica.Parametro1 = 3
                    'Me.cbbPuebloEtnica.Visible = False
                    Me.txtpuebloEtnicaOtro.Visible = True
                    Me.txtpuebloEtnicaOtro.Enabled = True
                    Me.txtpuebloEtnicaOtro.Text = ""
                    Me.txtpuebloEtnicaOtro.Focus()

                Case Else

                    Me.cbbPuebloEtnica.Parametro1 = 3
                    'Me.cbbPuebloEtnica.Visible = False

                    Me.txtpuebloEtnicaOtro.Visible = True
                    'Me.txtpuebloEtnicaOtro.Enabled = False

                    'Select Case idGrupoEtnica
                    '    Case 1
                    '        Me.PertenenciaEtnicaDetalleId = 40
                    '        txtpuebloEtnicaOtro.Text = ""
                    '    Case 2
                    '        Me.PertenenciaEtnicaDetalleId = 2
                    '        txtpuebloEtnicaOtro.Text = ""
                    '    Case 5
                    '        Me.PertenenciaEtnicaDetalleId = -1
                    '        txtpuebloEtnicaOtro.Text = "AFRODESCENDIENTE"
                    '    Case 6
                    '        Me.PertenenciaEtnicaDetalleId = -1
                    '        txtpuebloEtnicaOtro.Text = ""
                    '    Case 7
                    '        Me.PertenenciaEtnicaDetalleId = -1
                    '        txtpuebloEtnicaOtro.Text = ""
                    'End Select

            End Select

            Me.cbbPuebloEtnica.ComboTipo = 91 '[reg_pbe_mae_pueblo]
            Me.cbbPuebloEtnica.LoadUsc()
            Me.cbbPuebloEtnica.SelectedValue = -1

        End Sub
        Private Sub comboGrupoLenguaMaterna()

            Me.cbbGrupoLenguaMaterna.ComboTipo = 92 'reg_pbe_mae_grupo_lengua_materna
            Me.cbbGrupoLenguaMaterna.LoadUsc()
            Me.cbbGrupoLenguaMaterna.SelectedValue = -1
            cargoComboGrupoLenguaMaterna = True

        End Sub
        Private Sub ComboLenguaMaternaIdioma()

            Select Case Me.idGrupoLenguaMaterna
                Case 9 'lengua materna
                    Me.cbbLenguaMaternaIdioma.Enabled = True
                    Me.cbbLenguaMaternaIdioma.Parametro1 = -1

                Case 12 'idioma
                    Me.cbbLenguaMaternaIdioma.Enabled = True
                    Me.cbbLenguaMaternaIdioma.Parametro1 = 1

                Case Else
                    Me.cbbLenguaMaternaIdioma.Parametro1 = 2
                    Me.cbbLenguaMaternaIdioma.Enabled = False
            End Select

            Me.cbbLenguaMaternaIdioma.ComboTipo = 93 'reg_pbe_mae_lengua_materna
            Me.cbbLenguaMaternaIdioma.LoadUsc()
            Me.cbbLenguaMaternaIdioma.SelectedValue = -1

        End Sub
#End Region
#Region "Listar"
        Private cargoDatos As Boolean = False
        Private Sub listarDatosComplementarios(idInterno As Integer)

            Dim bss As New Bussines.Registro.InternoDatosComplementarios
            Dim obj As New Entity.Registro.InternoDatosComplementarios
            obj = bss.Listar(-1, idInterno)

            If obj.Codigo > 0 Then
                'cargar combo 
                'comboGrupoPuebloEtnica()

                With obj
                    Me.idDatosComplementario = .Codigo
                    Me.seConsideraEtnico = .pertenecePueblo
                    habilitarPertenenciaEtnica()

                    Me.idGrupoEtnica = .IDGrupoPueblo
                    Me.idPuebloEtnica = .IDPueblo
                    Me.puebloEtnicaOtro = obj.OtroPueblo

                    Me.idGrupoLenguaMaterna = .IDGrupoLenguaMaterna
                    'Me.idLenguaMaternaIdioma = .IDLenguaMaterna

                    Select Case .IDGrupoLenguaMaterna
                        Case 9 'lengua materna
                            Me.selectIdLenguaMaternaIdioma = .IDLenguaMaterna

                        Case 12 'idioma
                            Me.selectIdLenguaMaternaIdioma = .IDIdioma

                        Case Else
                            Me.selectIdLenguaMaternaIdioma = -1
                    End Select

                End With

            End If

        End Sub

#End Region
#Region "Accion"
        Private Function validarDatos(idInterno As Integer, idRegion As Short, idPenal As Short) As Boolean

            Dim value As Boolean = False

            If idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha ingresado el codigo del interno")
                Return value
            End If

            If idRegion < 1 Or idPenal < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha ingresado el codigo de la region/penal")
                Return value
            End If

            If Me.seConsideraEtnico < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("seleccione pertenencia etnica del interno")
                Return value
            End If

            'si pertenece a una poblacion etnica
            If Me.seConsideraEtnico = 1 Then
                If Me.idGrupoEtnica < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("seleccione Grupo etnico del interno")
                    Me.cbbGrupoEtnica.Focus()
                    Return value
                End If

                If Me.cbbPuebloEtnica.Visible = True Then
                    If Me.idPuebloEtnica < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("seleccione pueblo etnico del interno")
                        Me.cbbPuebloEtnica.Focus()
                        Return value
                    End If
                End If

                If Me.txtpuebloEtnicaOtro.Visible = True And Me.txtpuebloEtnicaOtro.Enabled = True Then
                    If Me.puebloEtnicaOtro.Length < 2 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese pueblo etnico del interno")
                        Me.txtpuebloEtnicaOtro.Focus()
                        Return value
                    End If
                End If

            End If

            If Me.idGrupoLenguaMaterna < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("seleccione grupo de lengua materna del interno")
                Me.cbbGrupoLenguaMaterna.Focus()
                Return value
            End If

            If cbbLenguaMaternaIdioma.Enabled = True Then
                If Me.selectIdLenguaMaternaIdioma < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("seleccione lengua materna/idioma del interno")
                    Me.cbbLenguaMaternaIdioma.Focus()
                    Return value
                End If
            End If

            value = True
            Return value
        End Function
        Private Sub grabar()

            Dim Value As Integer = -1

            If validarDatos(Me.idInterno, Me.idRegion, Me.idPenal) = False Then
                Exit Sub
            End If

            objBss = New Bussines.Registro.InternoDatosComplementarios
            Dim objEnt As New Entity.Registro.InternoDatosComplementarios

            objEnt.Codigo = Me.idDatosComplementario
            objEnt.IDInterno = Me.idInterno
            objEnt.pertenecePueblo = Me.seConsideraEtnico
            objEnt.IDGrupoPueblo = Me.idGrupoEtnica
            objEnt.IDPueblo = Me.idPuebloEtnica
            objEnt.OtroPueblo = Me.puebloEtnicaOtro
            objEnt.IDGrupoLenguaMaterna = Me.idGrupoLenguaMaterna
            objEnt.IDLenguaMaterna = Me.idLenguaMaterna
            objEnt.IDIdioma = Me.idIdioma
            objEnt.idRegion = Me.idRegion
            objEnt.idPenal = Me.idPenal

            Value = objBss.Grabar(objEnt)

            If Value > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                enabledUsc(False)
            End If

        End Sub
        Private Sub eliminar()

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar() = Windows.Forms.DialogResult.Yes Then

                objBss = New Bussines.Registro.InternoDatosComplementarios
                Dim Value As Integer = -1

                listarDatosComplementarios(Me.idInterno)

                Value = objBss.Eliminar(Me.idDatosComplementario)

                If Value > 0 Then
                    listarDatosComplementarios(Me.idInterno)
                    limpiar
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                End If

            End If

        End Sub
#End Region

#Region "Otros"

        Private Sub habilitarPertenenciaEtnica()

            Me.pnlPertenenciaEtnica.Enabled = False
            Dim habilitar As Boolean = False

            If Me.seConsideraEtnico = 1 Then
                habilitar = True
                Me.cbbGrupoEtnica.Focus()
            Else
                If cargoDatos = True Then
                    Me.idGrupoEtnica = -1
                    Me.idPuebloEtnica = -1
                    Me.puebloEtnicaOtro = ""
                End If
            End If

            Me.pnlPertenenciaEtnica.Enabled = habilitar

        End Sub
        Private Sub enabledUsc(habilitar As Boolean)

            Me.grbPuebloEtnica.Enabled = habilitar

            If Me.seConsideraEtnico = 1 Then
                Me.pnlPertenenciaEtnica.Enabled = True
            Else
                Me.pnlPertenenciaEtnica.Enabled = False
            End If

            Me.grbLenguaMaterna.Enabled = habilitar
            modoEdicion = habilitar

        End Sub
        Private Sub limpiar()

            Me.rdbSi.Checked = False
            Me.rdbNo.Checked = False
            Me.rdbNoIndica.Checked = False
            'poblacion etnica
            Me.idGrupoEtnica = -1
            Me.idPuebloEtnica = -1
            Me.puebloEtnicaOtro = ""
            'idioma
            Me.idGrupoLenguaMaterna = -1
            selectIdLenguaMaternaIdioma = -1

        End Sub
#End Region
        Public Sub _load(idInterno As Integer, idRegion As Short, idPenal As Short)


            Me.idInterno = idInterno
            Me.idRegion = idRegion
            Me.idPenal = idPenal

            If Me._idInterno < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("No se ha enviado el parametro [_idInterno]")
                Exit Sub
            End If

            comboGrupoPuebloEtnica()
            comboGrupoLenguaMaterna()

            listarDatosComplementarios(Me.idInterno)
            cargoDatos = True

            enabledUsc(False)
            Me.btnGrabar.Enabled = False

        End Sub
        Private Sub cbbPertenenciaEtnica__SelectedIndexChanged() Handles cbbGrupoEtnica._SelectedIndexChanged

            If cargoComboGrupoPuebloEtnica = True Then
                comboPuebloEtnica()
            End If

        End Sub

        Private Sub cbbLenguaMaterna__SelectedIndexChanged() Handles cbbGrupoLenguaMaterna._SelectedIndexChanged

            If cargoComboGrupoLenguaMaterna = True Then
                ComboLenguaMaternaIdioma()
            End If

        End Sub

        Private Sub cbbLenguaMaternaAuxiliar__SelectedIndexChanged() Handles cbbLenguaMaternaIdioma._SelectedIndexChanged

            If cbbGrupoLenguaMaterna.SelectedValue = -1 Then Exit Sub

            Select Case idGrupoLenguaMaterna

                Case 1 'QUECHUA
                    Me.idIdioma = -1
                    Me.idLenguaMaterna = 34

                Case 2 'AIMARA
                    Me.idIdioma = -1
                    Me.idLenguaMaterna = 2

                Case 3 'ASHANINKA
                    Me.idIdioma = -1
                    Me.idLenguaMaterna = 5

                Case 4 'AWAJÚN/AGUARUNA
                    Me.idIdioma = -1
                    Me.idLenguaMaterna = 7

                Case 5 'SHIPIBO - KONIBO
                    Me.idIdioma = -1
                    Me.idLenguaMaterna = 39

                Case 6 'MATSIGENKA / MACHIGUENGA
                    Me.idIdioma = -1
                    Me.idLenguaMaterna = 38

                Case 7 'MATSIGENKA / MACHIGUENGA
                    Me.idIdioma = -1
                    Me.idLenguaMaterna = 26

                Case 8 'ACHUAR
                    Me.idIdioma = -1
                    Me.idLenguaMaterna = 1

                Case 9 'lengua materna
                    If Me.selectIdLenguaMaternaIdioma > 0 Then
                        Me.idIdioma = -1
                        Me.idLenguaMaterna = Me.selectIdLenguaMaternaIdioma
                    End If

                Case 10  'Castellano
                    Me.idIdioma = 15
                    Me.idLenguaMaterna = -1

                Case 11 'Portuguez
                    Me.idIdioma = 39
                    Me.idLenguaMaterna = -1

                Case 12 'idioma
                    If Me.selectIdLenguaMaternaIdioma > 0 Then
                        Me.idLenguaMaterna = -1
                        Me.idIdioma = Me.selectIdLenguaMaternaIdioma
                    End If

                Case Else
                    Me.idLenguaMaterna = -1
                    Me.idIdioma = -1

            End Select
        End Sub

        Private Sub rdbSi_Click(sender As Object, e As EventArgs) Handles rdbSi.Click,
            rdbNo.Click, rdbNoIndica.Click

            If modoEdicion = True Then
                habilitarPertenenciaEtnica()
            End If

        End Sub

        Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar() = DialogResult.Yes Then
                grabar()
                Me.btnGrabar.Enabled = False
            Else
                enabledUsc(False)
                listarDatosComplementarios(Me.idInterno)
            End If

        End Sub

        Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

            enabledUsc(True)
            Me.btnGrabar.Enabled = True

        End Sub

        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

            Eliminar()

        End Sub
    End Class
End Namespace
