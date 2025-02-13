Namespace Result
    Public Class CalidadHuella
        Public Property ErrorCodigo As String = ""
        Public ReadOnly Property HayError As Boolean
            Get
                Dim value As Boolean = True
                Select Case Me.ErrorCodigo
                    Case -1

                    Case "0", "316"
                        value = False
                    Case Else

                End Select
                Return value
            End Get
        End Property
        Public Property ErrorMensaje As String = ""
        Public Property CodigoHuellaDerecha As String = ""
        Public Property DescripcionHuellaDerecha As String = ""
        Public Property CodigoHuellaIzquierda As String = ""
        Public Property DescripcionHuellaIzquierda As String = ""
        Public ReadOnly Property TipoDedoDerecho As Type.Enumeracion.Biometria.TipoDedo
            Get
                Dim value As Type.Enumeracion.Biometria.TipoDedo = Type.Enumeracion.Biometria.TipoDedo.Ninguno

                Select Case Me.CodigoHuellaDerecha
                    Case "01"
                        value = Type.Enumeracion.Biometria.TipoDedo.PulgarDerecho
                    Case "02"
                        value = Type.Enumeracion.Biometria.TipoDedo.IndiceDerecho
                    Case "03"
                        value = Type.Enumeracion.Biometria.TipoDedo.MedioDerecho
                    Case "04"
                        value = Type.Enumeracion.Biometria.TipoDedo.AnularDerecho
                    Case "05"
                        value = Type.Enumeracion.Biometria.TipoDedo.MeniqueDerecho
                End Select

                Return value

            End Get
        End Property
        Public ReadOnly Property TipoDedoIzquierdo As Type.Enumeracion.Biometria.TipoDedo
            Get
                Dim value As Type.Enumeracion.Biometria.TipoDedo = Type.Enumeracion.Biometria.TipoDedo.Ninguno

                Select Case Me.CodigoHuellaIzquierda
                    Case "06"
                        value = Type.Enumeracion.Biometria.TipoDedo.PulgarIzquierdo
                    Case "07"
                        value = Type.Enumeracion.Biometria.TipoDedo.IndiceIzquierdo
                    Case "08"
                        value = Type.Enumeracion.Biometria.TipoDedo.MedioIzquierdo
                    Case "09"
                        value = Type.Enumeracion.Biometria.TipoDedo.AnularIzquierdo
                    Case "10"
                        value = Type.Enumeracion.Biometria.TipoDedo.MeniqueIzquierdo
                End Select

                Return value

            End Get
        End Property
    End Class
End Namespace
