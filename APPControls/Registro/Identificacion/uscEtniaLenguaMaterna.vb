Namespace Registro.Identificacion
    Public Class uscEtniaLenguaMaterna

#Region "Variables"
        Public Property DatosComplementariosId() As Integer = -1
        Public Property PertenenciaEtnicaDetalleId() As Integer = -1
        Public Property LenguaMaternaDetalleId() As Integer = -1
#End Region

        Public blnComboComAnd As Boolean = False

        Private Sub Combo()
            Me.cbbPertenenciaEtnica.LoadUsc()
            Me.cbbPertenenciaEtnica.SelectedValue = -1
            Me.cbbLenguaMaterna.LoadUsc()
            Me.cbbLenguaMaterna.SelectedValue = -1

            blnComboComAnd = True
        End Sub
        Public ReadOnly Property PerteneciaGrupoEtnicaId() As Integer
            Get
                Try
                    Return Me.cbbPertenenciaEtnica.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property PertenenciaEtnicaId() As Integer
            Get
                Try
                    Return Me.cbbPerteneciaEtnicaOtros.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property PertenenciaEtnica() As String
            Get
                Try
                    Return Me.txtPertenenciaEtnica.Text
                Catch ex As Exception
                    Return ""
                End Try
            End Get
        End Property
        Public ReadOnly Property LenguaMaternaGrupoId() As Integer
            Get
                Try
                    Return Me.cbbLenguaMaterna.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property

        Public Property LenguaMaternaId() As Integer = -1

        Public Property IdiomaId() As Integer = -1

        Public Sub EnabledControles(Valor As Boolean, Optional bln As Boolean = False)
            Me.cbbPertenenciaEtnica.Enabled = Not (Valor)
            Me.cbbPerteneciaEtnicaOtros.Enabled = Not (Valor)
            Me.cbbLenguaMaterna.Enabled = Not (Valor)
            Me.cbbLenguaMaternaAuxiliar.Enabled = Not (Valor)
            Me.txtPertenenciaEtnica.Enabled = Not (Valor)
            If cbbPertenenciaEtnica.SelectedValue <> 5 And txtPertenenciaEtnica.Enabled = True Then
                txtPertenenciaEtnica.Enabled = False
            End If
            Select Case cbbLenguaMaterna.SelectedValue
                Case 9, 12
                Case Else
                    cbbLenguaMaternaAuxiliar.Enabled = False
            End Select
        End Sub
        Private Sub ComboPerteneciaEtnicaAuxiliar()
            If Me.cbbPertenenciaEtnica.SelectedValue = 3 Then
                txtPertenenciaEtnica.Visible = False
                cbbPerteneciaEtnicaOtros.Visible = True
                ' txtPertenenciaEtnica .Enabled =false
                Me.cbbPerteneciaEtnicaOtros.Parametro1 = 2
            ElseIf Me.cbbPertenenciaEtnica.SelectedValue = 4 Then
                txtPertenenciaEtnica.Visible = False
                cbbPerteneciaEtnicaOtros.Visible = True
                Me.cbbPerteneciaEtnicaOtros.Parametro1 = 1
            ElseIf Me.cbbPertenenciaEtnica.SelectedValue = 8 Then
                Me.cbbPerteneciaEtnicaOtros.Parametro1 = 3
                Me.cbbPerteneciaEtnicaOtros.Visible = False
                Me.txtPertenenciaEtnica.Visible = True
                Me.txtPertenenciaEtnica.Enabled = True
                Me.txtPertenenciaEtnica.Text = ""
                Me.txtPertenenciaEtnica.Focus()
            Else
                Me.cbbPerteneciaEtnicaOtros.Parametro1 = 3
                Me.cbbPerteneciaEtnicaOtros.Visible = False
                Me.txtPertenenciaEtnica.Visible = True
                Me.txtPertenenciaEtnica.Enabled = False
                Select Case cbbPertenenciaEtnica.SelectedValue
                    Case 1
                        Me.PertenenciaEtnicaDetalleId = 40
                        txtPertenenciaEtnica.Text = ""
                    Case 2
                        Me.PertenenciaEtnicaDetalleId = 2
                        txtPertenenciaEtnica.Text = ""
                    Case 5
                        Me.PertenenciaEtnicaDetalleId = -1
                        txtPertenenciaEtnica.Text = "AFRODESCENDIENTE"
                    Case 6
                        Me.PertenenciaEtnicaDetalleId = -1
                        txtPertenenciaEtnica.Text = ""
                    Case 7
                        Me.PertenenciaEtnicaDetalleId = -1
                        txtPertenenciaEtnica.Text = ""
                End Select
            End If
            Me.cbbPerteneciaEtnicaOtros.LoadUsc()
            Me.cbbPerteneciaEtnicaOtros.SelectedValue = -1
        End Sub

        Private Sub ComboLenguaMaternaAuxiliar()
            If Me.cbbLenguaMaterna.SelectedValue = 9 Then
                Me.cbbLenguaMaternaAuxiliar.Enabled = True
                Me.cbbLenguaMaternaAuxiliar.Parametro1 = -1
            ElseIf Me.cbbLenguaMaterna.SelectedValue = 12 Then
                Me.cbbLenguaMaternaAuxiliar.Enabled = True
                Me.cbbLenguaMaternaAuxiliar.Parametro1 = 1
            Else
                Me.cbbLenguaMaternaAuxiliar.Parametro1 = 2
                Me.cbbLenguaMaternaAuxiliar.Enabled = False
            End If
            cbbLenguaMaternaAuxiliar.LoadUsc()
            cbbLenguaMaternaAuxiliar.SelectedValue = -1
        End Sub

#Region "Grabar"
        Public Function Grabar(InternoId As Integer, Objeto As Entity.Registro.Interno) As Integer
            Dim Value As Integer = -1
            Dim bss As New Bussines.Registro.InternoDatosComplementarios
            Dim Obj As New Entity.Registro.InternoDatosComplementarios

            Obj.Codigo = Me.DatosComplementariosId
            Obj.IDInterno = InternoId
            Obj.IDGrupoPueblo = cbbPertenenciaEtnica.SelectedValue
            Obj.IDPueblo = Me.PertenenciaEtnicaDetalleId
            Obj.OtroPueblo = Me.txtPertenenciaEtnica.Text
            Obj.IDGrupoLenguaMaterna = Me.cbbLenguaMaterna.SelectedValue
            Obj.IDLenguaMaterna = Me.LenguaMaternaDetalleId
            Obj.IDIdioma = Me.IdiomaId
            Value = bss.Grabar(Obj)

            Return Value

        End Function
#End Region
#Region "Listar"
        Public Sub Listar(InternoId As Integer)
            Dim bss As New Bussines.Registro.InternoDatosComplementarios
            Dim obj As New Entity.Registro.InternoDatosComplementarios
            obj = bss.Listar(-1, InternoId)
            With obj
                Me.DatosComplementariosId = .Codigo
                cbbPertenenciaEtnica.SelectedValue = .IDGrupoPueblo
                cbbPerteneciaEtnicaOtros.SelectedValue = .IDPueblo
                txtPertenenciaEtnica.Text = obj.OtroPueblo
                cbbLenguaMaterna.SelectedValue = .IDGrupoLenguaMaterna
                cbbLenguaMaternaAuxiliar.SelectedValue = .IDLenguaMaterna
                If .IDGrupoLenguaMaterna = 12 Then
                    cbbLenguaMaternaAuxiliar.SelectedValue = .IDIdioma
                ElseIf .IDGrupoLenguaMaterna = 9 Then
                    cbbLenguaMaternaAuxiliar.SelectedValue = .IDLenguaMaterna
                Else
                    cbbLenguaMaternaAuxiliar.SelectedValue = -1
                End If
            End With
        End Sub
        Public Sub Listar(obj As Entity.Registro.InternoHistorico)
            With obj
                Me.DatosComplementariosId = -1
                cbbPertenenciaEtnica.SelectedValue = .IDGrupoPueblo
                cbbPerteneciaEtnicaOtros.SelectedValue = .IDPueblo
                txtPertenenciaEtnica.Text = .OtroPueblo
                cbbLenguaMaterna.SelectedValue = .IDGrupoLenguaMaterna
                If .IDGrupoLenguaMaterna = 12 Then
                    cbbLenguaMaternaAuxiliar.SelectedValue = .IDIdioma
                ElseIf .IDGrupoLenguaMaterna = 9 Then
                    cbbLenguaMaternaAuxiliar.SelectedValue = .IDLenguaMaterna
                End If
            End With
        End Sub
#End Region
        Public Sub _Load()
            Combo()
        End Sub
        Private Sub cbbPertenenciaEtnica__SelectedIndexChanged() Handles cbbPertenenciaEtnica._SelectedIndexChanged
            ComboPerteneciaEtnicaAuxiliar()
        End Sub

        Private Sub cbbLenguaMaterna__SelectedIndexChanged() Handles cbbLenguaMaterna._SelectedIndexChanged
            ComboLenguaMaternaAuxiliar()
        End Sub

        Private Sub cbbPerteneciaEtnicaOtros__SelectedIndexChanged() Handles cbbPerteneciaEtnicaOtros._SelectedIndexChanged
            If cbbPerteneciaEtnicaOtros.SelectedValue > 0 Then
                Me.PertenenciaEtnicaDetalleId = cbbPerteneciaEtnicaOtros.SelectedValue
                Me.txtPertenenciaEtnica.Text = cbbPerteneciaEtnicaOtros.Text
            End If
        End Sub

        Private Sub cbbLenguaMaternaAuxiliar__SelectedIndexChanged() Handles cbbLenguaMaternaAuxiliar._SelectedIndexChanged
            If cbbLenguaMaterna.SelectedValue = -1 Then Exit Sub

            Select Case cbbLenguaMaterna.SelectedValue
                Case 9
                    If Me.cbbLenguaMaternaAuxiliar.SelectedValue > 0 Then
                        Me.IdiomaId = -1
                        Me.LenguaMaternaDetalleId = Me.cbbLenguaMaternaAuxiliar.SelectedValue
                    End If
                Case 10  'Castellano
                    Me.IdiomaId = 15
                    Me.LenguaMaternaDetalleId = -1
                Case 11 'Portuguez
                    Me.IdiomaId = 39
                    Me.LenguaMaternaDetalleId = -1
                Case 12
                    If Me.cbbLenguaMaternaAuxiliar.SelectedValue > 0 Then
                        Me.LenguaMaternaDetalleId = -1
                        Me.IdiomaId = Me.cbbLenguaMaternaAuxiliar.SelectedValue
                    End If
                Case Else
                    Me.IdiomaId = -1
                    Select Case cbbLenguaMaterna.SelectedValue
                        Case 1
                            Me.LenguaMaternaDetalleId = 34
                        Case 2
                            Me.LenguaMaternaDetalleId = 2
                        Case 3
                            Me.LenguaMaternaDetalleId = 5
                        Case 4
                            Me.LenguaMaternaDetalleId = 7
                        Case 5
                            Me.LenguaMaternaDetalleId = 39
                        Case 6
                            Me.LenguaMaternaDetalleId = 38
                        Case 7
                            Me.LenguaMaternaDetalleId = 26
                        Case 8
                            Me.LenguaMaternaDetalleId = 1
                    End Select
            End Select
        End Sub

        Private Sub cbbPertenenciaEtnica_Load(sender As Object, e As EventArgs) Handles cbbPertenenciaEtnica.Load

        End Sub
    End Class
End Namespace
