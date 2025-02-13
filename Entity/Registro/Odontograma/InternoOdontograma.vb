Namespace Registro.Odontograma
    Public Class InternoOdontograma

        Public Property Codigo() As Integer = -1 'Id del odontograma (Clave primaria)
        Public Property InternoId() As Integer = -1
        'Public Property SedeInternoId As Integer = -1
        Public Property IngresoId() As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property NumeroIngreso As String = ""
        Public Property IngresoNroInpe As String = ""
        Public Property version As Short = 1
        Public Property nombreArchivo() As String = ""
        Public Property Observaciones() As String = ""
        Public Property Especificaciones() As String = ""
        Public Property ArcoDentarioSupId() As Integer = -1 'Arco dentario superior, guarda relación con el Id del arco dentario
        Public Property ArcoDentarioSupNombre() As String = ""
        Public Property ArcoDentarioInfId() As Integer = -1 'Arco dentario inferior, guarda relación con el Id del arco dentario
        Public Property ArcoDentarioInfNombre() As String = ""
        Public Property TamanioDentoMaxilarId() As Integer = -1 'Tamaño dentomaxilar, guarda relación con el Id del tamaño dentomaxilar
        Public Property TamanioDentoMaxilarNombre() As String = ""
        Public Property TamanioDienteId() As Integer = -1 'Tipo de diente, guarda relación con el Id del tipo de diente
        Public Property TamanioDienteNombre() As String = ""
        Public Property DienteTipoId() As Integer = -1 'Tipo de diente, guarda relación con el tipo de diente
        Public Property DienteTipoNombre() As String = ""
        Public Property OclusionTipoId() As Integer = -1 'Tipo de oclusión, guarda relación con tipo de oclusión
        Public Property OclusionTipoNombre() As String = ""
        Public Property RugaPalatinaId() As Integer = -1 'Tipo de ruga palatina
        'Public Property ArchivoDigitalId() As Integer = -1 'Guarda relación con el ID del archivo digital del odontograma
        Public Property RegionId() As Integer = -1
        Public Property PenalId() As Integer = -1
        Public Property FechaRegistro() As Long
        Public ReadOnly Property FechaRegistroDate() As String
            Get
                If Me.FechaRegistro < 1 Then
                    Return ""
                Else
                    Return Legolas.Components.FechaHora.FechaString(Me.FechaRegistro, True)
                End If
            End Get
        End Property
        'Public Property OdontogramaByte() As Byte() = Nothing
        Public Property SedeRowId As Integer = -1
    End Class
End Namespace


