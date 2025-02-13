Namespace Type
    Public Class Enumeracion
        'Public Enum enmDispositivoBiometricoBD
        '    DESCONOCIDO = 0
        '    SUPREMA_RSG1 = 1
        '    FUTRONIC_DECA_FS60 = 2
        '    FUTRONIC_FS10 = 3
        'End Enum
        Public Enum TipoMano As SByte
            Ninguno = 0
            Izquierda = 1
            Derecha = 2
        End Enum

        Public Enum TipoDedo As SByte
            NoEspecificado = -1
            Ninguno = -1
            MeniqueIzquierdo = 1
            AnularIzquierdo = 2
            MedioIzquierdo = 3
            IndiceIzquierdo = 4
            PulgarIzquierdo = 5

            PulgarDerecho = 6
            IndiceDerecho = 7
            MedioDerecho = 8
            AnularDerecho = 9
            MeniqueDerecho = 10
        End Enum
    
        Public Enum TipoPlantilla As SByte
            NoEspecificado = -1
            Suprema = 0
            ISO19794_2 = 1
            ANSI378 = 2
        End Enum

        Public Enum EstadoDedo As SByte
            NoEspecificado = -1
            Disponible = 0
            NoDisponible = 1
            Amputado = 2
        End Enum
        Public Enum TipoCapturaHuella
            Amputado = 0
            Normal = 1
            Observado = 2
        End Enum
      
        Public Enum IndiceCalidadHuella As SByte
            NoEspecificado = -1
            'Ninguno = 0
            MuyAlta = 1
            Alta = 2
            Media = 3
            Baja = 4
            MuyBaja = 5
        End Enum
     
        Public Enum enumRSE_NivelSeguridad As Integer
            'RSE_SECURITY_1_TO_100 = 1
            'RSE_SECURITY_1_TO_1000 = 2
            RSE_SECURITY_1_TO_10000 = 3
            RSE_SECURITY_1_TO_100000 = 4
            RSE_SECURITY_1_TO_1000000 = 5
            RSE_SECURITY_1_TO_10000000 = 6
            RSE_SECURITY_1_TO_100000000 = 7
        End Enum
        Public Enum enumTipoDispositivo As Short
            Ninguno = 0
            Desconocido = 0
            RealScanG1 = 1
            FutronicFS10 = 2
            Futronic_Deca_FS60 = 3
            Croschmat = 4
            Futronic_Deca_FS64 = 5
            FutronicFS88H = 6
        End Enum
        Public Enum enumfMatchScore As Integer

            MATCH_SCORE_LOW = 37
            MATCH_SCORE_LOW_MEDIUM = 65
            MATCH_SCORE_MEDIUM = 93
            MATCH_SCORE_HIGH_MEDIUM = 121
            MATCH_SCORE_HIGH = 146
            MATCH_SCORE_VERY_HIGH = 189

        End Enum
        Public Enum enumNivelSeguridadFAR As Integer
            MATCH_SCORE_LOW = 1         '37  - 1%
            MATCH_SCORE_LOW_MEDIUM = 2  '65  - 0.1%
            MATCH_SCORE_MEDIUM = 3      '93  - 0.01%
            MATCH_SCORE_HIGH_MEDIUM = 4 '121 - 0.001%
            MATCH_SCORE_HIGH = 5        '146 - 0.0001%
            MATCH_SCORE_VERY_HIGH = 6   '189 - 0.00001%
        End Enum
        

        Public Enum enmTipoCapturaHuella As Short
            NO_ESPECIFICADO = -1
            HUELLA_PLANA = 1
            HUELLA_ROLADA = 2
        End Enum
      
    End Class
End Namespace