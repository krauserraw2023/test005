Imports APPControlHuellaVisita.Type.Enumeracion
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms


Public Class uscThumbFinger
#Region "eventos"
    Public Event _SelectDedo_Click()
    Public Event _DobleClick(sender As uscThumbFinger)
#End Region
#Region "propiedades publicas"
    Public Property _Codigo As Integer = -1 'id del template

    Private img As Byte() = Nothing
    Private enmEstDedo As Type.Enumeracion.EstadoDedo = EstadoDedo.Disponible
    Private intIndCal As Integer = -1
    Private _TipDedo As Type.Enumeracion.TipoDedo = TipoDedo.Ninguno
    Public Property _TipoDedo As Type.Enumeracion.TipoDedo
        Get
            Return _TipDedo

        End Get
        Set(value As Type.Enumeracion.TipoDedo)
            _TipDedo = value
            lblDedo.Text = Me.NombreCortoDedo()
        End Set
    End Property

    Public Property _TipoDispostivo As Short = -1
    Public Property _Observacion() As String = ""
    Public Property _TipoDocIdentidad As Integer = -1
    Public Property _NumeroDocIdentidad As String = ""

    Public Property _ImagenHuellaByte() As Byte()
        Get
            Return img
        End Get
        Set(value As Byte())
            img = value
            If Not img Is Nothing Then
                Dim m As New System.IO.MemoryStream(img)
                pbVisor.Image = Image.FromStream(m)

                If Me._TipoDispostivo = Type.Enumeracion.enumTipoDispositivo.Croschmat Then
                    pbVisor.Image.RotateFlip(RotateFlipType.Rotate180FlipY) 'jmr, codigo para cambiar el reflejo de la huella, debe ser condicionado con el tipo de dispositivo tipo 4
                End If

            ElseIf Me._EstadoDedo = Type.Enumeracion.EstadoDedo.Amputado Then
                pbVisor.Image = My.Resources.dedo_ampuado
                img = Nothing
            ElseIf Me._EstadoDedo = Type.Enumeracion.EstadoDedo.NoDisponible Then
                pbVisor.Image = My.Resources.huella_x
                img = Nothing
            ElseIf img Is Nothing Then
                pbVisor.Image = Nothing
            End If
        End Set
    End Property
    Public Property _AnchoImgPixel() As Integer = 0
    Public Property _LargoImgPixel() As Integer = 0
    Public Property _Wsq() As Byte() = Nothing
    Public Property _TemplateANSI() As Byte() = Nothing
    Public Property _TemplateISO() As Byte() = Nothing
    ''' <summary>
    ''' Retorna la imagen asociada como un objeto Image
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property _Imagen() As Image
        Get
            Return pbVisor.Image
        End Get
    End Property
    Public Property _EstadoDedo() As Type.Enumeracion.EstadoDedo ' Integer
        Get
            Return enmEstDedo
        End Get
        Set(value As Type.Enumeracion.EstadoDedo)
            enmEstDedo = value
            Select Case enmEstDedo
                Case Type.Enumeracion.EstadoDedo.Disponible 'no es necesario
                    pbVisor.Image = Nothing 'pendientehnrb   _ImagenHuella
                    lblDedo.Text = Me._NombreCortoDedo
                Case Type.Enumeracion.EstadoDedo.Amputado
                    lblDedo.Text = Me._NombreCortoDedo & " (" & Me._EstadoDedoString & ")"
                    pbVisor.Image = My.Resources.dedo_ampuado
                Case Type.Enumeracion.EstadoDedo.NoDisponible
                    lblDedo.Text = Me._NombreCortoDedo & " (" & Me._EstadoDedoString & ")"
                    pbVisor.Image = My.Resources.huella_x
            End Select
        End Set
    End Property
    Public Property _IndiceCalidad() As Integer
        Get
            Return intIndCal
        End Get
        Set(value As Integer)
            intIndCal = value
            'If value > 0 Then
            Select Case value
                Case Is > 3
                    lblDedo.Image = My.Resources.Circle_Invalido16x16
                Case 1 'alta calidad
                    lblDedo.Image = My.Resources.Circle_Green16x16
                Case 2 'calidad media
                    lblDedo.Image = My.Resources.Circle_Red16x16 '._1420838563_Circle_Blue
                Case 3 'calidad baja
                    lblDedo.Image = My.Resources.Circle_Yellow16x16
                Case Else
                    lblDedo.Image = Nothing
            End Select
            'End If
        End Set
    End Property

    Public ReadOnly Property _IndiceCalidadString() As String
        Get
            Dim str As String = ""
            Select Case Me._IndiceCalidad
                Case 1
                    str = "(1) CALIDAD ALTA"
                Case 2
                    str = "(2) CALIDAD MEDIA"
                Case 3
                    str = "(3) CALIDAD BAJA"
                Case Else
                    str = ""
            End Select

            Return str
        End Get
    End Property
    Public ReadOnly Property _EstadoDedoString() As String
        Get
            Dim str As String = ""
            Select Case _EstadoDedo
                Case EstadoDedo.Disponible
                    str = "DISPONIBLE"
                Case EstadoDedo.NoDisponible
                    str = "NO DISPONIBLE"
                Case EstadoDedo.Amputado
                    str = "AMPUTADO"
                Case Else
                    str = ""
            End Select
            Return str
        End Get
    End Property
    Public ReadOnly Property _NombreCortoDedo() As String
        Get
            Return NombreCortoDedo()
        End Get
    End Property
    Public ReadOnly Property _NombreLargoDedo() As String
        Get
            Return NombreDedoDetalle()
        End Get
    End Property
    Public Property _VisiblechkHuellaNoDisponible As Boolean
        Get
            Return chkHuellaNoDisponible.Visible
        End Get
        Set(value As Boolean)
            chkHuellaNoDisponible.Visible = value
        End Set
    End Property
    Public ReadOnly Property _PosicionDedo() As Integer
        Get
            Return _TipoDedo.GetHashCode
        End Get
    End Property

#End Region

#Region "OTROS"
    Public Sub _MostrarHuellaFalsa()
        pbVisor.Image = My.Resources.huella_digital
    End Sub

    Public Sub LimpiarHuella()
        Me._TemplateANSI = Nothing
        Me._Observacion = ""
        Me._IndiceCalidad = -1
        Me._EstadoDedo = EstadoDedo.Disponible
        '            Me._HayImagenHuella = False
        Me._ImagenHuellaByte = Nothing
        Me._Wsq = Nothing
        Me.chkHuellaNoDisponible.Checked = False
        Me.chkHuellaNoDisponible.Visible = False
    End Sub

    Private Function NombreDedoDetalle() As String

        Dim value As String = ""

        Select Case Me._TipoDedo
            Case TipoDedo.PulgarDerecho
                value = "Mano Derecha / Dedo Pulgar"
            Case TipoDedo.IndiceDerecho
                value = "Mano Derecha / Dedo Indice"
            Case TipoDedo.MedioDerecho
                value = "Mano Derecha / Dedo Medio"
            Case TipoDedo.AnularDerecho
                value = "Mano Derecha / Dedo Anular"
            Case TipoDedo.MeniqueDerecho
                value = "Mano Derecha / Dedo Meñique"
            Case TipoDedo.PulgarIzquierdo
                value = "Mano Izquierdo / Dedo Pulgar"
            Case TipoDedo.IndiceIzquierdo
                value = "Mano Izquierdo / Dedo Indice"
            Case TipoDedo.MedioIzquierdo
                value = "Mano Izquierdo / Dedo Medio"
            Case TipoDedo.AnularIzquierdo
                value = "Mano Izquierdo / Dedo Anular"
            Case TipoDedo.MeniqueIzquierdo
                value = "Mano Izquierdo / Dedo Meñique"
        End Select

        Return value

    End Function
    'Private Function NombreDedo() As String

    '    Dim value As String = ""

    '    Select Case Me._TipoDedo
    '        Case Type.Enumeracion.Biometria.TipoDedo.PulgarDerecho
    '            value = "Pulgar Derecho"
    '        Case Type.Enumeracion.Biometria.TipoDedo.IndiceDerecho
    '            value = "Indice Derecho"
    '        Case Type.Enumeracion.Biometria.TipoDedo.MedioDerecho
    '            value = "Medio Derecho"
    '        Case Type.Enumeracion.Biometria.TipoDedo.AnularDerecho
    '            value = "Anular Derecho"
    '        Case Type.Enumeracion.Biometria.TipoDedo.MeniqueDerecho
    '            value = "Meñique Derecho"
    '        Case Type.Enumeracion.Biometria.TipoDedo.PulgarIzquierdo
    '            value = "Pulgar Izquierdo"
    '        Case Type.Enumeracion.Biometria.TipoDedo.IndiceIzquierdo
    '            value = "Indice Izquierdo"
    '        Case Type.Enumeracion.Biometria.TipoDedo.MedioIzquierdo
    '            value = "Medio Izquierdo"
    '        Case Type.Enumeracion.Biometria.TipoDedo.AnularIzquierdo
    '            value = "Anular Izquierdo"
    '        Case Type.Enumeracion.Biometria.TipoDedo.MeniqueIzquierdo
    '            value = "Meñique Izquierdo"
    '    End Select

    '    Return value

    'End Function
    Private Function NombreCortoDedo() As String

        Dim value As String = ""

        Select Case Me._TipoDedo
            Case TipoDedo.PulgarDerecho
                value = "Pulgar"
            Case TipoDedo.IndiceDerecho
                value = "Indice"
            Case TipoDedo.MedioDerecho
                value = "Medio"
            Case TipoDedo.AnularDerecho
                value = "Anular"
            Case TipoDedo.MeniqueDerecho
                value = "Meñique"
            Case TipoDedo.PulgarIzquierdo
                value = "Pulgar"
            Case TipoDedo.IndiceIzquierdo
                value = "Indice"
            Case TipoDedo.MedioIzquierdo
                value = "Medio"
            Case TipoDedo.AnularIzquierdo
                value = "Anular"
            Case TipoDedo.MeniqueIzquierdo
                value = "Meñique"
        End Select

        Return value

    End Function
    Private focoActivo As Boolean = False
    Public Property _Foco() As Boolean
        Get
            Return focoActivo
        End Get
        Set(value As Boolean)
            focoActivo = value
            If value = True Then
                Me.BackColor = Color.Orange
                lblDedo.BackColor = Color.Orange
                lblDedo.Font = New System.Drawing.Font(lblDedo.Font, FontStyle.Bold)
                lblDedo.ForeColor = Color.Brown
            Else
                Me.BackColor = Color.DarkGray
                lblDedo.BackColor = Color.FromArgb(225, 225, 225)
                lblDedo.Font = New System.Drawing.Font(lblDedo.Font, FontStyle.Regular)
                lblDedo.ForeColor = Color.Black
            End If
        End Set
    End Property
    Public Property _FocoError() As Boolean
        Get
            Return focoActivo
        End Get
        Set(value As Boolean)
            focoActivo = value
            If value = True Then
                Me.BackColor = Color.Red
                lblDedo.BackColor = Color.FromArgb(255, 192, 192)
                lblDedo.Font = New System.Drawing.Font(lblDedo.Font, FontStyle.Bold)
                lblDedo.ForeColor = Color.Black
            Else
                Me.BackColor = Color.DarkGray
                lblDedo.BackColor = Color.Gainsboro
                lblDedo.Font = New System.Drawing.Font(lblDedo.Font, FontStyle.Regular)
                lblDedo.ForeColor = Color.Black
            End If
        End Set
    End Property
    Public Property _FocoEnceder() As Boolean
        Get
            Return focoActivo
        End Get
        Set(value As Boolean)
            focoActivo = value
            If value = True Then
                Me.BackColor = Color.Green
                lblDedo.BackColor = Color.FromArgb(180, 233, 197)
                lblDedo.Font = New System.Drawing.Font(lblDedo.Font, FontStyle.Bold)
                lblDedo.ForeColor = Color.Black
            Else
                Me.BackColor = Color.DarkGray
                lblDedo.BackColor = Color.Gainsboro
                lblDedo.Font = New System.Drawing.Font(lblDedo.Font, FontStyle.Regular)
                lblDedo.ForeColor = Color.Black
            End If
        End Set
    End Property
#End Region
    Private Sub pbVisor_Click(sender As System.Object, e As System.EventArgs) Handles pbVisor.Click
        RaiseEvent _SelectDedo_Click()
    End Sub

    Private Sub lblDedo_Click(sender As System.Object, e As System.EventArgs) Handles lblDedo.Click
        'RaiseEvent _SelectDedo_Click()
    End Sub

    Private Sub chkHuellaNoDisponible_Click(sender As Object, e As System.EventArgs) Handles chkHuellaNoDisponible.Click
        If chkHuellaNoDisponible.CheckState = CheckState.Checked Then
            Me._EstadoDedo = EstadoDedo.NoDisponible
        Else
            If img Is Nothing Then
                Me._EstadoDedo = EstadoDedo.Disponible
            Else
                Me.enmEstDedo = EstadoDedo.Disponible
                Dim m As New System.IO.MemoryStream(img)
                pbVisor.Image = Image.FromStream(m)
                lblDedo.Text = Me._NombreCortoDedo
            End If

        End If
    End Sub

    Private Sub pbVisor_DoubleClick(sender As System.Object, e As System.EventArgs) Handles pbVisor.DoubleClick
        RaiseEvent _DobleClick(Me)
    End Sub

    Private Sub btnObs_Click(sender As System.Object, e As System.EventArgs) Handles btnObs.Click
        Dim f As New frmObservacion
        f._Observacion = Me._Observacion
        'f._DedoEsAmputado = If(Me._EstadoDedo = Biometria.EstadoDedo.Amputado, True, False)
        'f._HuellaEsObservada = If(Me._EstadoDedo = Biometria.EstadoDedo.No_disponible, True, False)

        If f.ShowDialog = DialogResult.OK Then
            Me._Observacion = f._Observacion
            'If Me._EstadoDedo <> Biometria.EstadoDedo.Amputado Then
            '    If f._HuellaEsObservada = True Then
            '        Me._EstadoDedo = Biometria.EstadoDedo.No_disponible 'huella observada
            '    Else
            '        Me._EstadoDedo = Biometria.EstadoDedo.Disponible
            '    End If
            'End If
        End If
    End Sub

    Private Sub mnuDowBMP_Click(sender As Object, e As EventArgs) Handles mnuDowBMP.Click
        If Me._ImagenHuellaByte Is Nothing Then
            MsgBox("No es posible descargar la huella.")
            Exit Sub
        End If

        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "Imagen huella (*.bmp)|*.bmp"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            System.IO.File.WriteAllBytes(saveFileDialog1.FileName, Me._ImagenHuellaByte)
        End If

    End Sub

    Private Sub mnuDownANSI_Click(sender As Object, e As EventArgs) Handles mnuDownANSI.Click
        If Me._ImagenHuellaByte Is Nothing Then
            MsgBox("No es posible descargar el template ANSI.")
            Exit Sub
        End If

        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "Template ANSI (*.ansi)|*.ansi"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            System.IO.File.WriteAllBytes(saveFileDialog1.FileName, Me._TemplateANSI)
        End If
    End Sub

    Private Sub mnuDownWsq_Click(sender As Object, e As EventArgs) Handles mnuDownWsq.Click
        If Me._ImagenHuellaByte Is Nothing Then
            MsgBox("No es posible descargar el archivo WSQ.")
            Exit Sub
        End If

        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "Huella formato WSQ (*.wsq)|*.wsq"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            System.IO.File.WriteAllBytes(saveFileDialog1.FileName, Me._Wsq)
        End If
    End Sub
End Class
