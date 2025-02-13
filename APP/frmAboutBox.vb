Public NotInheritable Class frmAboutBox
    Dim objDatatable As New DataTable
    Private Sub frmAboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ApplicationTitle As String

        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Me.Text = String.Format("Acerca de {0}", My.Application.Info.Description)
        
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Versión de Compilado: {0} ", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.LabelCompanyName2.Text = My.Application.Info.CompanyName

    End Sub
#Region "Otros"
    Private Sub GrillaCrear()

        ' Creamos una nueva columna        
        Dim dcNombre As New DataColumn("Nombre")
        Dim dcVersion As New DataColumn("Version")
        ' Añadimos la columna al objeto DataTable        
        objDatatable.Columns.Add(dcNombre)
        objDatatable.Columns.Add(dcVersion)

    End Sub
    Private Sub GrillaAdd(Nombre As String, Version As String)

        ' Creamos una nueva fila        
        Dim objFila As DataRow = objDatatable.NewRow

        objFila.Item("Nombre") = Nombre
        objFila.Item("Version") = Version
        objDatatable.Rows.Add(objFila)

        With dgwGrilla
            .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
            .DataSource = objDatatable
        End With


    End Sub

    Private Sub ListarVersion()

        GrillaCrear()
        GrillaAdd("Sistema Integral Penitenciario - SIP-POPE", "2016")
        GrillaAdd("Sistema Integral Penitenciario - SIP-Visitas", "2016")
        GrillaAdd("Sistema Integral Penitenciario - SIP", "2019")
        GrillaAdd("********************************************************", "******")
        GrillaAdd("Mondalgo Rodriguez, C. Jose", "")
        GrillaAdd("Escobar Ucrus, John", "")
        GrillaAdd("Rosario Bautista, Hugo", "")
        GrillaAdd("Cuba Ccoyllo, Edwin", "2022")
        GrillaAdd("Canqui Anquise, Richard", "2013")
        GrillaAdd("Paredes Giraldo, Amilcar", "2012")

    End Sub
#End Region


    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
       
    End Sub

    Private Sub LabelProductName_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub frmAboutBox_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

        ListarVersion()

    End Sub
End Class
