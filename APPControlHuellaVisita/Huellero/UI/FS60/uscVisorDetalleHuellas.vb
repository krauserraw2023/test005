Imports System.Windows.Forms

Namespace Registro.Huellas
    Public Class uscVisorDetalleHuellas

        Public Property _InternoId() As Integer

        Private strRutTmp As String = Application.StartupPath & "\tmp\tmp_bmt\"

#Region "Propiedades publicas"
        Dim controlSoloVista As Boolean = False
        Public Property _ControlSoloVista As Boolean
            Get
                Return controlSoloVista
            End Get
            Set(value As Boolean)
                controlSoloVista = value

                'uscMeniqueIzquierdo._VisiblechkHuellaNoDisponible = value
                'uscAnularIzquierdo._VisiblechkHuellaNoDisponible = value
                'uscMedioIzquierdo._VisiblechkHuellaNoDisponible = value
                'uscIndiceIzquierdo._VisiblechkHuellaNoDisponible = value
                'uscPulgarIzquierdo._VisiblechkHuellaNoDisponible = value
                'uscPulgarDerecho._VisiblechkHuellaNoDisponible = value
                'uscIndiceDerecho._VisiblechkHuellaNoDisponible = value
                'uscMedioDerecho._VisiblechkHuellaNoDisponible = value
                'uscAnularDerecho._VisiblechkHuellaNoDisponible = value
                'uscMeniqueDerecho._VisiblechkHuellaNoDisponible = value
            End Set
        End Property

#End Region
#Region "Eventos"
        Public Event _Clik_NuevaCaptura()
#End Region
#Region "otros"
        Private Sub CargarImagenHuella(HuellaDigitalId As Integer, visorHulla As uscThumbFinger)
            'If HuellaDigitalId = -1 Then
            '    visorHulla.Limpiar()
            '    Exit Sub
            'End If

            'Dim bssHuellDig As New Bussines.Biometria.HuellaDigital
            'Dim entHuellDig As New Entity.Biometria.HuellaDigital

            'Dim entWsq As Entity_SolHuellaSede.Biometria.HuellaWSQ = Nothing
            'Dim entTmpl As Entity_SolHuellaSede.Biometria.HuellaTemplate = Nothing

            'entHuellDig = bssHuellDig.Listar(HuellaDigitalId, "")
            'If entHuellDig Is Nothing Then Exit Sub

            'entTmpl = APPHuella.NegocioDEMO.ListarTemplate(entHuellDig.TemplateHuellaId, "")
            'If entTmpl Is Nothing Then Exit Sub

            'visorHulla._Observacion = entTmpl.Observacion
            'visorHulla._IndiceCalidad = entTmpl.IndiceCalidadImg
            'visorHulla._EstadoDedo = entTmpl.EstadoDedo

            'entWsq = APPHuella.NegocioDEMO.HuellaWSQ_X_TemplateCod(entHuellDig.TemplateHuellaId, "")
            'If Not entWsq Is Nothing Then
            '    visorHulla._HayImagenHuella = True
            '    visorHulla._ImagenHuella = APPHuella.NegocioDEMO.ObtenerImagenHuella(strRutTmp, entWsq.WSQFile)
            'Else
            '    visorHulla._HayImagenHuella = True
            '    visorHulla._ImagenHuella = Nothing
            'End If

        End Sub

        Private Sub ListarHuellas()
            If Me._InternoId = -1 Then Exit Sub
            If System.IO.Directory.Exists(strRutTmp) = False Then System.IO.Directory.CreateDirectory(strRutTmp)

            ''---------------listar internoHuella por InternoId
            'Dim bssIntHuell As New Bussines.Biometria.InternoHuella

            'Dim entIntHuellCol As New Entity.Biometria.InternoHuellaCol
            'Dim entIntHuell As New Entity.Biometria.InternoHuella

            'entIntHuell.InternoId = Me._InternoId

            'entIntHuellCol = bssIntHuell.Listar(entIntHuell, "")

            'entIntHuell = entIntHuellCol.InternoHuella(0)

            'CargarImagenHuella(entIntHuell.HuellaDigMenIzqId, uscMeniqueIzquierdo)
            'CargarImagenHuella(entIntHuell.HuellaDigAnuIzqId, uscAnularIzquierdo)
            'CargarImagenHuella(entIntHuell.HuellaDigMedIzqId, uscMedioIzquierdo)
            'CargarImagenHuella(entIntHuell.HuellaDigIndIzqId, uscIndiceIzquierdo)
            'CargarImagenHuella(entIntHuell.HuellaDigPulIzqId, uscPulgarIzquierdo)
            'CargarImagenHuella(entIntHuell.HuellaDigPulDerId, uscPulgarDerecho)
            'CargarImagenHuella(entIntHuell.HuellaDigIndDerId, uscIndiceDerecho)
            'CargarImagenHuella(entIntHuell.HuellaDigMedDerId, uscMedioDerecho)
            'CargarImagenHuella(entIntHuell.HuellaDigAnuDerId, uscAnularDerecho)
            'CargarImagenHuella(entIntHuell.HuellaDigMenDerId, uscMeniqueDerecho)
        End Sub

        Public Sub loadUsc()
            ListarHuellas()
        End Sub
#End Region
        Private Sub QuitarFocoHuellas(huelleroActivo As uscThumbFinger)
            uscMeniqueIzquierdo._Foco = False
            uscAnularIzquierdo._Foco = False
            uscMedioIzquierdo._Foco = False
            uscIndiceIzquierdo._Foco = False
            uscPulgarIzquierdo._Foco = False
            uscPulgarDerecho._Foco = False
            uscIndiceDerecho._Foco = False
            uscMedioDerecho._Foco = False
            uscAnularDerecho._Foco = False
            uscMeniqueDerecho._Foco = False
            huelleroActivo._Foco = True

            lblDedoSel.Text = huelleroActivo._NombreLargoDedo
            pbVisorHuellaDetalle.Image = huelleroActivo._Imagen
            lblEstadoDedo.Text = huelleroActivo._EstadoDedoString
            lblCalidadHuella.Text = huelleroActivo._IndiceCalidadString
            txtObservacion.Text = huelleroActivo._Observacion
        End Sub

        Private Sub uscMeniqueI__SelectDedo_Click() Handles uscMeniqueIzquierdo._SelectDedo_Click
            QuitarFocoHuellas(uscMeniqueIzquierdo)
        End Sub

        Private Sub uscAnularI__SelectDedo_Click() Handles uscAnularIzquierdo._SelectDedo_Click
            QuitarFocoHuellas(uscAnularIzquierdo)
        End Sub

        Private Sub uscMedioI__SelectDedo_Click() Handles uscMedioIzquierdo._SelectDedo_Click
            QuitarFocoHuellas(uscMedioIzquierdo)
        End Sub

        Private Sub uscIndiceI__SelectDedo_Click() Handles uscIndiceIzquierdo._SelectDedo_Click
            QuitarFocoHuellas(uscIndiceIzquierdo)
        End Sub

        Private Sub uscPulgarI__SelectDedo_Click() Handles uscPulgarIzquierdo._SelectDedo_Click
            QuitarFocoHuellas(uscPulgarIzquierdo)
        End Sub

        Private Sub uscPulgarDerecho__SelectDedo_Click() Handles uscPulgarDerecho._SelectDedo_Click
            QuitarFocoHuellas(uscPulgarDerecho)
        End Sub

        Private Sub uscIndiceDerecho__SelectDedo_Click() Handles uscIndiceDerecho._SelectDedo_Click
            QuitarFocoHuellas(uscIndiceDerecho)
        End Sub

        Private Sub uscMedioDerecho__SelectDedo_Click() Handles uscMedioDerecho._SelectDedo_Click
            QuitarFocoHuellas(uscMedioDerecho)
        End Sub

        Private Sub uscAnularDerecho__SelectDedo_Click() Handles uscAnularDerecho._SelectDedo_Click
            QuitarFocoHuellas(uscAnularDerecho)
        End Sub

        Private Sub uscMeniqueDerecho__SelectDedo_Click() Handles uscMeniqueDerecho._SelectDedo_Click
            QuitarFocoHuellas(uscMeniqueDerecho)
        End Sub

        Private Sub cmdNuevo_Click(sender As System.Object, e As System.EventArgs) Handles cmdNuevo.Click
            'Dim x As New APPHuella.frmCaptura
            'x.ShowDialog()
            RaiseEvent _Clik_NuevaCaptura()
        End Sub
    End Class
End Namespace