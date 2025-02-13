Imports Type.Enumeracion.Licencia
Imports Legolas.Configuration

Namespace Registro.Identificacion
    Public Class frmRasgosPartiPopup
        Private objBss As Bussines.Registro.InternoRasgo = Nothing
#Region "Propiedades publicas"
        Public Property Codigo() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _NroIngreso() As Integer = 0
        Public Property TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno        
#End Region
#Region "Propiedades_Rasgos"
        Private Property Rasgo_Raza() As Integer
            Get
                Return Me.cbbRaza.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRaza.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_CabelloForma() As Integer
            Get
                Return Me.cbbCabelloFor.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbCabelloFor.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_CabelloColor() As Integer
            Get
                Return Me.cbbCabelloColor.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbCabelloColor.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_Calvicie() As Integer
            Get
                Return Me.cbbCalvicie.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbCalvicie.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_Menton() As Integer
            Get
                Return Me.cbbMenton.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMenton.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_Frente() As Integer
            Get
                Return Me.cbbFrente.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbFrente.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_CaraForma() As Integer
            Get
                Return Me.cbbCaraFor.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbCaraFor.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_LineaInsercion() As Integer
            Get
                Return Me.cbbLineaIns.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbLineaIns.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_FormaOjo() As Integer
            Get
                Return Me.cbbFormaOjo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbFormaOjo.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_Iris() As Integer
            Get
                Return Me.cbbIris.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbIris.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_Ceja() As Integer
            Get
                Return Me.cbbCeja.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbCeja.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_AnomaliaOjos() As Integer
            Get
                Return Me.cbbAnomaliaOjo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbAnomaliaOjo.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_OrejaDerecha() As Integer
            Get
                Return Me.cbbOrejaDer.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbOrejaDer.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_NarizForma() As Integer
            Get
                Return Me.cbbNarizFor.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbNarizFor.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_TipoNariz() As Integer
            Get
                Return Me.cbbTipoNar.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoNar.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_Boca() As Integer
            Get
                Return Me.cbbBoca.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbBoca.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_Labios() As Integer
            Get
                Return Me.cbbLabios.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbLabios.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_TipoLabios() As Integer
            Get
                Return Me.cbbTipoLabio.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoLabio.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_Tronco() As Integer
            Get
                Return Me.cbbTronco.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTronco.SelectedValue = value
            End Set
        End Property
        Private Property Rasgo_Complexion() As Integer
            Get
                Return Me.cbbComplexion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbComplexion.SelectedValue = value
            End Set
        End Property
        Private Property Talla() As Single
            Get
                Dim intValue As Single = 0

                If IsNumeric(Me.txtTalla.Text) = True Then
                    intValue = Single.Parse(Me.txtTalla.Text)
                End If

                Return intValue
            End Get
            Set(ByVal value As Single)
                Me.txtTalla.Text = value.ToString
            End Set
        End Property
        Private Property Peso() As Single
            Get

                Dim intValue As Single = 0

                If IsNumeric(Me.txtPeso.Text) = True Then
                    intValue = Single.Parse(Me.txtPeso.Text)
                End If

                Return intValue
            End Get
            Set(ByVal value As Single)
                Me.txtPeso.Text = value.ToString
            End Set
        End Property
        Private Property Obs() As String
            Get
                Return Me.txtObs.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObs.Text = value
            End Set
        End Property
#End Region
#Region "Combo"
        Private Sub ComboRasgo()

            'raza
            With Me.cbbRaza
                .CodigoPadre = Legolas.LType.Persona.Razgo.Raza
                .LoadUsc()
            End With

            'cabello forma
            With Me.cbbCabelloFor
                .CodigoPadre = Legolas.LType.Persona.Razgo.CabelloForma
                .LoadUsc()
            End With

            'cabello color
            With Me.cbbCabelloColor
                .CodigoPadre = Legolas.LType.Persona.Razgo.CabelloColor
                .LoadUsc()
            End With

            'calvicie
            With Me.cbbCalvicie
                .CodigoPadre = Legolas.LType.Persona.Razgo.Calvicie
                .LoadUsc()
            End With

            'menton
            With Me.cbbMenton
                .CodigoPadre = Legolas.LType.Persona.Razgo.Menton
                .LoadUsc()
            End With

            'frente
            With Me.cbbFrente
                .CodigoPadre = Legolas.LType.Persona.Razgo.Frente
                .LoadUsc()
            End With

            'cara forma
            With Me.cbbCaraFor
                .CodigoPadre = Legolas.LType.Persona.Razgo.CaraForma
                .LoadUsc()
            End With

            'linea insercion
            With Me.cbbLineaIns
                .CodigoPadre = Legolas.LType.Persona.Razgo.LineaInsercion
                .LoadUsc()
            End With

            'forma ojo
            With Me.cbbFormaOjo
                .CodigoPadre = Legolas.LType.Persona.Razgo.FormaOjos
                .LoadUsc()
            End With

            'iris
            With Me.cbbIris
                .CodigoPadre = Legolas.LType.Persona.Razgo.Iris
                .LoadUsc()
            End With

            'ceja
            With Me.cbbCeja
                .CodigoPadre = Legolas.LType.Persona.Razgo.Cejas
                .LoadUsc()
            End With

            'anomalia ojo
            With Me.cbbAnomaliaOjo
                .CodigoPadre = Legolas.LType.Persona.Razgo.AnomaliaOjos
                .LoadUsc()
            End With

            'oreja derecha
            With Me.cbbOrejaDer
                .CodigoPadre = Legolas.LType.Persona.Razgo.OrejaDerecha
                .LoadUsc()
            End With

            'nariz forma
            With Me.cbbNarizFor
                .CodigoPadre = Legolas.LType.Persona.Razgo.NarizForma
                .LoadUsc()
            End With

            'tipo nariz 
            With Me.cbbTipoNar
                .CodigoPadre = Legolas.LType.Persona.Razgo.TipoNariz
                .LoadUsc()
            End With

            'boca
            With Me.cbbBoca
                .CodigoPadre = Legolas.LType.Persona.Razgo.Boca
                .LoadUsc()
            End With

            'labios
            With Me.cbbLabios
                .CodigoPadre = Legolas.LType.Persona.Razgo.Labios
                .LoadUsc()
            End With

            'tipo labios
            With Me.cbbTipoLabio
                .CodigoPadre = Legolas.LType.Persona.Razgo.TipoLabios
                .LoadUsc()
            End With

            'tronco
            With Me.cbbTronco
                .CodigoPadre = Legolas.LType.Persona.Razgo.Tronco
                .LoadUsc()
            End With

            'complexion
            With Me.cbbComplexion
                .CodigoPadre = Legolas.LType.Persona.Razgo.Complexion
                .LoadUsc()
            End With

        End Sub
#End Region
#Region "Listar"

        Private Sub ListarData()

            Dim objEnt As New Entity.Registro.InternoRasgo
            objBss = New Bussines.Registro.InternoRasgo

            If Me.Codigo < 1 Then
                Exit Sub
            End If

            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana
                    objEnt = objBss.Listar_LM(Me.Codigo)
                Case Else
                    objEnt = objBss.Listar2(Me.Codigo)
            End Select
         
            With objEnt
                Me.Codigo = .Codigo
                Me.Rasgo_Raza = .Raza
                Me.Rasgo_CabelloForma = .CabelloForma
                Me.Rasgo_CabelloColor = .CabelloColor
                Me.Rasgo_Calvicie = .Calvicie
                Me.Rasgo_Menton = .Menton
                Me.Rasgo_Frente = .Frente
                Me.Rasgo_CaraForma = .CaraForma
                Me.Rasgo_LineaInsercion = .LineaInsercion
                Me.Rasgo_FormaOjo = .FormaOjo
                Me.Rasgo_Iris = .Iris
                Me.Rasgo_Ceja = .Cejas
                Me.Rasgo_AnomaliaOjos = .AnomaliaOjo
                Me.Rasgo_OrejaDerecha = .Oreja
                Me.Rasgo_NarizForma = .NarizForma
                Me.Rasgo_TipoNariz = .TipoNariz
                Me.Rasgo_Boca = .Boca
                Me.Rasgo_Labios = .Labio
                Me.Rasgo_TipoLabios = .TipoLabio
                Me.Rasgo_Tronco = .Tronco
                Me.Rasgo_Complexion = .Complexion
                Me.Talla = .Talla
                Me.Peso = .Peso
                Me.Obs = .Obs
                Me._InternoIngresoId = .InternoIngresoId
                Me._InternoIngresoInpeId = .IngresoInpeId
            End With
            lblNumIngreso.Text = Me._NroIngreso
        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True

            If Me._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el interno antes de grabar")
                blnValue = False

            End If

            If Me.TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                If Me._InternoIngresoInpeId < 1 And Me.Codigo < 1 Then
                    Aplication.MessageBox.Exclamation("Seleccionar N° de ingreso, no se ha enviado el parámetro")
                End If
            Else
                If Me._InternoIngresoId < 1 Then
                    If Me.Codigo < 1 Then
                        Aplication.MessageBox.Exclamation("Seleccionar N° de ingreso, no se ha enviado el parámetro")
                    Else
                        Dim objBss As New Bussines.Registro.Ingreso
                        Dim objEntCol As New Entity.Registro.IngresoCol
                        objEntCol = objBss.Listar(-1, Me._InternoID, -1, -1, -1, 0, -1, -1, "", 0, -1, 0, "")
                        If objEntCol.Count = 0 Then
                            Aplication.MessageBox.Exclamation("El interno no posee ningún ingreso, registrar un ingreso")
                            Me.Close()
                        Else
                            Dim frm As New Registro.Identificacion.v5.frmSeleccionarIngresoPopup
                            frm.InternoID = Me._InternoID
                            frm._FormEscritura = Me._FormEscritura
                            frm._FormLectura = Me._FormLectura
                            frm._objEntCol = objEntCol
                            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                Me._InternoIngresoId = frm.intIngresoNuevo
                                Return blnValue
                            Else
                                Exit Function
                            End If
                        End If
                    End If
                    Return blnValue
                End If
            End If

            Return blnValue

        End Function
        Private Function AGrabarRasgo() As Boolean
            objBss = New Bussines.Registro.InternoRasgo
            If Validar() = False Then Return False

            Dim ent As New Entity.Registro.InternoRasgo

            With ent
                .Codigo = Me.Codigo
                .InternoId = Me._InternoID
                .Raza = Me.Rasgo_Raza
                .CabelloForma = Me.Rasgo_CabelloForma
                .CabelloColor = Me.Rasgo_CabelloColor
                .Calvicie = Me.Rasgo_Calvicie
                .Menton = Me.Rasgo_Menton
                .Frente = Me.Rasgo_Frente
                .CaraForma = Me.Rasgo_CaraForma
                .LineaInsercion = Me.Rasgo_LineaInsercion
                .FormaOjo = Me.Rasgo_FormaOjo
                .Iris = Me.Rasgo_Iris
                .Cejas = Me.Rasgo_Ceja
                .AnomaliaOjo = Me.Rasgo_AnomaliaOjos
                .Oreja = Me.Rasgo_OrejaDerecha
                .NarizForma = Me.Rasgo_NarizForma
                .TipoNariz = Me.Rasgo_TipoNariz
                .Boca = Me.Rasgo_Boca
                .Labio = Me.Rasgo_Labios
                .TipoLabio = Me.Rasgo_TipoLabios
                .Tronco = Me.Rasgo_Tronco
                .Complexion = Me.Rasgo_Complexion
                .Talla = Me.Talla
                .Peso = Me.Peso
                .Obs = Me.Obs
                .InternoIngresoId = Me._InternoIngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
            End With

            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana

                    ent.InternoIngresoId = -1
                    Me.Codigo = objBss.Grabar_LM(ent)

                Case Else
                    ent.IngresoInpeId = -1
                    Me.Codigo = objBss.Grabar2(ent)
            End Select

            Return Me.Codigo > 0
        End Function
#End Region
#Region "Pemrmisos_Usuarios"
        Private Sub Usuario_Permiso()
            Me.btnAceptar.Visible = Me._FormEscritura
        End Sub
#End Region
#Region "Otros"
        Private Sub Mostrar_Auditoria()
            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoRasgo)
        End Sub

        Private Sub LimpiarRasgo()
            Me.Rasgo_Raza = -1
            Me.Rasgo_CabelloForma = -1
            Me.Rasgo_CabelloColor = -1
            Me.Rasgo_Calvicie = -1
            Me.Rasgo_Menton = -1
            Me.Rasgo_Frente = -1
            Me.Rasgo_CaraForma = -1
            Me.Rasgo_LineaInsercion = -1
            Me.Rasgo_FormaOjo = -1
            Me.Rasgo_Iris = -1
            Me.Rasgo_Ceja = -1
            Me.Rasgo_AnomaliaOjos = -1
            Me.Rasgo_OrejaDerecha = -1
            Me.Rasgo_NarizForma = -1
            Me.Rasgo_TipoNariz = -1
            Me.Rasgo_Boca = -1
            Me.Rasgo_Labios = -1
            Me.Rasgo_TipoLabios = -1
            Me.Rasgo_Tronco = -1
            Me.Rasgo_Complexion = -1
            Me.Talla = 0
            Me.Peso = 0
            Me.Obs = ""
        End Sub

        Private Sub ValoresxDefault()
            ComboRasgo()
            LimpiarRasgo()
        End Sub
#End Region
#Region "Evento_Formulario"
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs)
            Me.Close()
        End Sub

        Private Sub frmRasgosPartiPopup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            ValoresxDefault()
            Usuario_Permiso()
            Mostrar_Auditoria()
        End Sub

        Private Sub frmRasgosPartiPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            ListarData()
        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            If AGrabarRasgo() Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub

        Private Sub btnCancel_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub
#End Region
    End Class
End Namespace