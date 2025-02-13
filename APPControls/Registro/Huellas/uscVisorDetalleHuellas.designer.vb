Namespace Registro.Huellas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscVisorDetalleHuellas
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.pbVistaThumb = New System.Windows.Forms.Panel()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.uscPulgarDerecho = New APPControlHuellaVisita.uscThumbFinger()
            Me.uscIndiceDerecho = New APPControlHuellaVisita.uscThumbFinger()
            Me.uscMeniqueDerecho = New APPControlHuellaVisita.uscThumbFinger()
            Me.uscMedioDerecho = New APPControlHuellaVisita.uscThumbFinger()
            Me.uscAnularDerecho = New APPControlHuellaVisita.uscThumbFinger()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.uscMeniqueIzquierdo = New APPControlHuellaVisita.uscThumbFinger()
            Me.uscAnularIzquierdo = New APPControlHuellaVisita.uscThumbFinger()
            Me.uscMedioIzquierdo = New APPControlHuellaVisita.uscThumbFinger()
            Me.uscIndiceIzquierdo = New APPControlHuellaVisita.uscThumbFinger()
            Me.uscPulgarIzquierdo = New APPControlHuellaVisita.uscThumbFinger()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.pbVistaPreliminHuella = New System.Windows.Forms.Panel()
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            Me.lblCalidadHuella = New System.Windows.Forms.Label()
            Me.lblEstadoDedo = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.lblDedoSel = New System.Windows.Forms.Label()
            Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
            Me.pbVisorHuellaDetalle = New System.Windows.Forms.PictureBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cmdNuevo = New System.Windows.Forms.Button()
            Me.pbVistaThumb.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.TableLayoutPanel3.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.pbVistaPreliminHuella.SuspendLayout()
            Me.pnlDetalle.SuspendLayout()
            Me.tlpMain.SuspendLayout()
            CType(Me.pbVisorHuellaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pbVistaThumb
            '
            Me.pbVistaThumb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.pbVistaThumb.Controls.Add(Me.TableLayoutPanel1)
            Me.pbVistaThumb.Controls.Add(Me.Panel5)
            Me.pbVistaThumb.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pbVistaThumb.Location = New System.Drawing.Point(3, 3)
            Me.pbVistaThumb.Name = "pbVistaThumb"
            Me.pbVistaThumb.Size = New System.Drawing.Size(649, 394)
            Me.pbVistaThumb.TabIndex = 21
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 0)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(649, 352)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'Panel3
            '
            Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.Panel3.Controls.Add(Me.TableLayoutPanel3)
            Me.Panel3.Controls.Add(Me.Label1)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(3, 179)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(643, 170)
            Me.Panel3.TabIndex = 0
            '
            'TableLayoutPanel3
            '
            Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control
            Me.TableLayoutPanel3.ColumnCount = 5
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel3.Controls.Add(Me.uscPulgarDerecho, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.uscIndiceDerecho, 1, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.uscMeniqueDerecho, 4, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.uscMedioDerecho, 2, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.uscAnularDerecho, 3, 0)
            Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 16)
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 2
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel3.Size = New System.Drawing.Size(643, 154)
            Me.TableLayoutPanel3.TabIndex = 19
            '
            'uscPulgarDerecho
            '
            Me.uscPulgarDerecho._AnchoImgPixel = 0
            Me.uscPulgarDerecho._Codigo = -1
            Me.uscPulgarDerecho._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
            Me.uscPulgarDerecho._Foco = False
            Me.uscPulgarDerecho._FocoEnceder = False
            Me.uscPulgarDerecho._FocoError = False
            Me.uscPulgarDerecho._ImagenHuellaByte = Nothing
            Me.uscPulgarDerecho._IndiceCalidad = -1
            Me.uscPulgarDerecho._LargoImgPixel = 0
            Me.uscPulgarDerecho._NumeroDocIdentidad = ""
            Me.uscPulgarDerecho._Observacion = ""
            Me.uscPulgarDerecho._TemplateANSI = Nothing
            Me.uscPulgarDerecho._TemplateISO = Nothing
            Me.uscPulgarDerecho._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.PulgarDerecho
            Me.uscPulgarDerecho._TipoDispostivo = CType(-1, Short)
            Me.uscPulgarDerecho._TipoDocIdentidad = -1
            Me.uscPulgarDerecho._VisiblechkHuellaNoDisponible = False
            Me.uscPulgarDerecho._Wsq = Nothing
            Me.uscPulgarDerecho.BackColor = System.Drawing.Color.DarkGray
            Me.uscPulgarDerecho.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscPulgarDerecho.Location = New System.Drawing.Point(6, 3)
            Me.uscPulgarDerecho.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
            Me.uscPulgarDerecho.Name = "uscPulgarDerecho"
            Me.uscPulgarDerecho.Padding = New System.Windows.Forms.Padding(1)
            Me.uscPulgarDerecho.Size = New System.Drawing.Size(116, 128)
            Me.uscPulgarDerecho.TabIndex = 8
            '
            'uscIndiceDerecho
            '
            Me.uscIndiceDerecho._AnchoImgPixel = 0
            Me.uscIndiceDerecho._Codigo = -1
            Me.uscIndiceDerecho._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
            Me.uscIndiceDerecho._Foco = False
            Me.uscIndiceDerecho._FocoEnceder = False
            Me.uscIndiceDerecho._FocoError = False
            Me.uscIndiceDerecho._ImagenHuellaByte = Nothing
            Me.uscIndiceDerecho._IndiceCalidad = -1
            Me.uscIndiceDerecho._LargoImgPixel = 0
            Me.uscIndiceDerecho._NumeroDocIdentidad = ""
            Me.uscIndiceDerecho._Observacion = ""
            Me.uscIndiceDerecho._TemplateANSI = Nothing
            Me.uscIndiceDerecho._TemplateISO = Nothing
            Me.uscIndiceDerecho._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.IndiceDerecho
            Me.uscIndiceDerecho._TipoDispostivo = CType(-1, Short)
            Me.uscIndiceDerecho._TipoDocIdentidad = -1
            Me.uscIndiceDerecho._VisiblechkHuellaNoDisponible = False
            Me.uscIndiceDerecho._Wsq = Nothing
            Me.uscIndiceDerecho.BackColor = System.Drawing.Color.DarkGray
            Me.uscIndiceDerecho.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscIndiceDerecho.Location = New System.Drawing.Point(134, 3)
            Me.uscIndiceDerecho.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
            Me.uscIndiceDerecho.Name = "uscIndiceDerecho"
            Me.uscIndiceDerecho.Padding = New System.Windows.Forms.Padding(1)
            Me.uscIndiceDerecho.Size = New System.Drawing.Size(116, 128)
            Me.uscIndiceDerecho.TabIndex = 10
            '
            'uscMeniqueDerecho
            '
            Me.uscMeniqueDerecho._AnchoImgPixel = 0
            Me.uscMeniqueDerecho._Codigo = -1
            Me.uscMeniqueDerecho._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
            Me.uscMeniqueDerecho._Foco = False
            Me.uscMeniqueDerecho._FocoEnceder = False
            Me.uscMeniqueDerecho._FocoError = False
            Me.uscMeniqueDerecho._ImagenHuellaByte = Nothing
            Me.uscMeniqueDerecho._IndiceCalidad = -1
            Me.uscMeniqueDerecho._LargoImgPixel = 0
            Me.uscMeniqueDerecho._NumeroDocIdentidad = ""
            Me.uscMeniqueDerecho._Observacion = ""
            Me.uscMeniqueDerecho._TemplateANSI = Nothing
            Me.uscMeniqueDerecho._TemplateISO = Nothing
            Me.uscMeniqueDerecho._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.MeniqueDerecho
            Me.uscMeniqueDerecho._TipoDispostivo = CType(-1, Short)
            Me.uscMeniqueDerecho._TipoDocIdentidad = -1
            Me.uscMeniqueDerecho._VisiblechkHuellaNoDisponible = False
            Me.uscMeniqueDerecho._Wsq = Nothing
            Me.uscMeniqueDerecho.BackColor = System.Drawing.Color.DarkGray
            Me.uscMeniqueDerecho.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscMeniqueDerecho.Location = New System.Drawing.Point(518, 3)
            Me.uscMeniqueDerecho.Margin = New System.Windows.Forms.Padding(6, 3, 0, 3)
            Me.uscMeniqueDerecho.Name = "uscMeniqueDerecho"
            Me.uscMeniqueDerecho.Padding = New System.Windows.Forms.Padding(1)
            Me.uscMeniqueDerecho.Size = New System.Drawing.Size(125, 128)
            Me.uscMeniqueDerecho.TabIndex = 7
            '
            'uscMedioDerecho
            '
            Me.uscMedioDerecho._AnchoImgPixel = 0
            Me.uscMedioDerecho._Codigo = -1
            Me.uscMedioDerecho._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
            Me.uscMedioDerecho._Foco = False
            Me.uscMedioDerecho._FocoEnceder = False
            Me.uscMedioDerecho._FocoError = False
            Me.uscMedioDerecho._ImagenHuellaByte = Nothing
            Me.uscMedioDerecho._IndiceCalidad = -1
            Me.uscMedioDerecho._LargoImgPixel = 0
            Me.uscMedioDerecho._NumeroDocIdentidad = ""
            Me.uscMedioDerecho._Observacion = ""
            Me.uscMedioDerecho._TemplateANSI = Nothing
            Me.uscMedioDerecho._TemplateISO = Nothing
            Me.uscMedioDerecho._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.MedioDerecho
            Me.uscMedioDerecho._TipoDispostivo = CType(-1, Short)
            Me.uscMedioDerecho._TipoDocIdentidad = -1
            Me.uscMedioDerecho._VisiblechkHuellaNoDisponible = False
            Me.uscMedioDerecho._Wsq = Nothing
            Me.uscMedioDerecho.BackColor = System.Drawing.Color.DarkGray
            Me.uscMedioDerecho.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscMedioDerecho.Location = New System.Drawing.Point(262, 3)
            Me.uscMedioDerecho.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
            Me.uscMedioDerecho.Name = "uscMedioDerecho"
            Me.uscMedioDerecho.Padding = New System.Windows.Forms.Padding(1)
            Me.uscMedioDerecho.Size = New System.Drawing.Size(116, 128)
            Me.uscMedioDerecho.TabIndex = 11
            '
            'uscAnularDerecho
            '
            Me.uscAnularDerecho._AnchoImgPixel = 0
            Me.uscAnularDerecho._Codigo = -1
            Me.uscAnularDerecho._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
            Me.uscAnularDerecho._Foco = False
            Me.uscAnularDerecho._FocoEnceder = False
            Me.uscAnularDerecho._FocoError = False
            Me.uscAnularDerecho._ImagenHuellaByte = Nothing
            Me.uscAnularDerecho._IndiceCalidad = -1
            Me.uscAnularDerecho._LargoImgPixel = 0
            Me.uscAnularDerecho._NumeroDocIdentidad = ""
            Me.uscAnularDerecho._Observacion = ""
            Me.uscAnularDerecho._TemplateANSI = Nothing
            Me.uscAnularDerecho._TemplateISO = Nothing
            Me.uscAnularDerecho._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.AnularDerecho
            Me.uscAnularDerecho._TipoDispostivo = CType(-1, Short)
            Me.uscAnularDerecho._TipoDocIdentidad = -1
            Me.uscAnularDerecho._VisiblechkHuellaNoDisponible = False
            Me.uscAnularDerecho._Wsq = Nothing
            Me.uscAnularDerecho.BackColor = System.Drawing.Color.DarkGray
            Me.uscAnularDerecho.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscAnularDerecho.Location = New System.Drawing.Point(390, 3)
            Me.uscAnularDerecho.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
            Me.uscAnularDerecho.Name = "uscAnularDerecho"
            Me.uscAnularDerecho.Padding = New System.Windows.Forms.Padding(1)
            Me.uscAnularDerecho.Size = New System.Drawing.Size(116, 128)
            Me.uscAnularDerecho.TabIndex = 9
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(0, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(643, 16)
            Me.Label1.TabIndex = 15
            Me.Label1.Text = "MANO DERECHA"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel4
            '
            Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Panel4.Controls.Add(Me.TableLayoutPanel2)
            Me.Panel4.Controls.Add(Me.Label2)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel4.Location = New System.Drawing.Point(3, 3)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(643, 170)
            Me.Panel4.TabIndex = 1
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control
            Me.TableLayoutPanel2.ColumnCount = 5
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.uscMeniqueIzquierdo, 0, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.uscAnularIzquierdo, 1, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.uscMedioIzquierdo, 2, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.uscIndiceIzquierdo, 3, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.uscPulgarIzquierdo, 4, 0)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 13)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(643, 157)
            Me.TableLayoutPanel2.TabIndex = 18
            '
            'uscMeniqueIzquierdo
            '
            Me.uscMeniqueIzquierdo._AnchoImgPixel = 0
            Me.uscMeniqueIzquierdo._Codigo = -1
            Me.uscMeniqueIzquierdo._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
            Me.uscMeniqueIzquierdo._Foco = False
            Me.uscMeniqueIzquierdo._FocoEnceder = False
            Me.uscMeniqueIzquierdo._FocoError = False
            Me.uscMeniqueIzquierdo._ImagenHuellaByte = Nothing
            Me.uscMeniqueIzquierdo._IndiceCalidad = -1
            Me.uscMeniqueIzquierdo._LargoImgPixel = 0
            Me.uscMeniqueIzquierdo._NumeroDocIdentidad = ""
            Me.uscMeniqueIzquierdo._Observacion = ""
            Me.uscMeniqueIzquierdo._TemplateANSI = Nothing
            Me.uscMeniqueIzquierdo._TemplateISO = Nothing
            Me.uscMeniqueIzquierdo._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.MeniqueIzquierdo
            Me.uscMeniqueIzquierdo._TipoDispostivo = CType(-1, Short)
            Me.uscMeniqueIzquierdo._TipoDocIdentidad = -1
            Me.uscMeniqueIzquierdo._VisiblechkHuellaNoDisponible = False
            Me.uscMeniqueIzquierdo._Wsq = Nothing
            Me.uscMeniqueIzquierdo.BackColor = System.Drawing.Color.DarkGray
            Me.uscMeniqueIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscMeniqueIzquierdo.Location = New System.Drawing.Point(6, 3)
            Me.uscMeniqueIzquierdo.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
            Me.uscMeniqueIzquierdo.Name = "uscMeniqueIzquierdo"
            Me.uscMeniqueIzquierdo.Padding = New System.Windows.Forms.Padding(1)
            Me.uscMeniqueIzquierdo.Size = New System.Drawing.Size(116, 151)
            Me.uscMeniqueIzquierdo.TabIndex = 3
            '
            'uscAnularIzquierdo
            '
            Me.uscAnularIzquierdo._AnchoImgPixel = 0
            Me.uscAnularIzquierdo._Codigo = -1
            Me.uscAnularIzquierdo._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
            Me.uscAnularIzquierdo._Foco = False
            Me.uscAnularIzquierdo._FocoEnceder = False
            Me.uscAnularIzquierdo._FocoError = False
            Me.uscAnularIzquierdo._ImagenHuellaByte = Nothing
            Me.uscAnularIzquierdo._IndiceCalidad = -1
            Me.uscAnularIzquierdo._LargoImgPixel = 0
            Me.uscAnularIzquierdo._NumeroDocIdentidad = ""
            Me.uscAnularIzquierdo._Observacion = ""
            Me.uscAnularIzquierdo._TemplateANSI = Nothing
            Me.uscAnularIzquierdo._TemplateISO = Nothing
            Me.uscAnularIzquierdo._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.AnularIzquierdo
            Me.uscAnularIzquierdo._TipoDispostivo = CType(-1, Short)
            Me.uscAnularIzquierdo._TipoDocIdentidad = -1
            Me.uscAnularIzquierdo._VisiblechkHuellaNoDisponible = False
            Me.uscAnularIzquierdo._Wsq = Nothing
            Me.uscAnularIzquierdo.BackColor = System.Drawing.Color.DarkGray
            Me.uscAnularIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscAnularIzquierdo.Location = New System.Drawing.Point(134, 3)
            Me.uscAnularIzquierdo.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
            Me.uscAnularIzquierdo.Name = "uscAnularIzquierdo"
            Me.uscAnularIzquierdo.Padding = New System.Windows.Forms.Padding(1)
            Me.uscAnularIzquierdo.Size = New System.Drawing.Size(116, 151)
            Me.uscAnularIzquierdo.TabIndex = 5
            '
            'uscMedioIzquierdo
            '
            Me.uscMedioIzquierdo._AnchoImgPixel = 0
            Me.uscMedioIzquierdo._Codigo = -1
            Me.uscMedioIzquierdo._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
            Me.uscMedioIzquierdo._Foco = False
            Me.uscMedioIzquierdo._FocoEnceder = False
            Me.uscMedioIzquierdo._FocoError = False
            Me.uscMedioIzquierdo._ImagenHuellaByte = Nothing
            Me.uscMedioIzquierdo._IndiceCalidad = -1
            Me.uscMedioIzquierdo._LargoImgPixel = 0
            Me.uscMedioIzquierdo._NumeroDocIdentidad = ""
            Me.uscMedioIzquierdo._Observacion = ""
            Me.uscMedioIzquierdo._TemplateANSI = Nothing
            Me.uscMedioIzquierdo._TemplateISO = Nothing
            Me.uscMedioIzquierdo._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.MedioIzquierdo
            Me.uscMedioIzquierdo._TipoDispostivo = CType(-1, Short)
            Me.uscMedioIzquierdo._TipoDocIdentidad = -1
            Me.uscMedioIzquierdo._VisiblechkHuellaNoDisponible = False
            Me.uscMedioIzquierdo._Wsq = Nothing
            Me.uscMedioIzquierdo.BackColor = System.Drawing.Color.DarkGray
            Me.uscMedioIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscMedioIzquierdo.Location = New System.Drawing.Point(262, 3)
            Me.uscMedioIzquierdo.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
            Me.uscMedioIzquierdo.Name = "uscMedioIzquierdo"
            Me.uscMedioIzquierdo.Padding = New System.Windows.Forms.Padding(1)
            Me.uscMedioIzquierdo.Size = New System.Drawing.Size(116, 151)
            Me.uscMedioIzquierdo.TabIndex = 6
            '
            'uscIndiceIzquierdo
            '
            Me.uscIndiceIzquierdo._AnchoImgPixel = 0
            Me.uscIndiceIzquierdo._Codigo = -1
            Me.uscIndiceIzquierdo._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
            Me.uscIndiceIzquierdo._Foco = False
            Me.uscIndiceIzquierdo._FocoEnceder = False
            Me.uscIndiceIzquierdo._FocoError = False
            Me.uscIndiceIzquierdo._ImagenHuellaByte = Nothing
            Me.uscIndiceIzquierdo._IndiceCalidad = -1
            Me.uscIndiceIzquierdo._LargoImgPixel = 0
            Me.uscIndiceIzquierdo._NumeroDocIdentidad = ""
            Me.uscIndiceIzquierdo._Observacion = ""
            Me.uscIndiceIzquierdo._TemplateANSI = Nothing
            Me.uscIndiceIzquierdo._TemplateISO = Nothing
            Me.uscIndiceIzquierdo._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.IndiceIzquierdo
            Me.uscIndiceIzquierdo._TipoDispostivo = CType(-1, Short)
            Me.uscIndiceIzquierdo._TipoDocIdentidad = -1
            Me.uscIndiceIzquierdo._VisiblechkHuellaNoDisponible = False
            Me.uscIndiceIzquierdo._Wsq = Nothing
            Me.uscIndiceIzquierdo.BackColor = System.Drawing.Color.DarkGray
            Me.uscIndiceIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscIndiceIzquierdo.Location = New System.Drawing.Point(390, 3)
            Me.uscIndiceIzquierdo.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
            Me.uscIndiceIzquierdo.Name = "uscIndiceIzquierdo"
            Me.uscIndiceIzquierdo.Padding = New System.Windows.Forms.Padding(1)
            Me.uscIndiceIzquierdo.Size = New System.Drawing.Size(116, 151)
            Me.uscIndiceIzquierdo.TabIndex = 4
            '
            'uscPulgarIzquierdo
            '
            Me.uscPulgarIzquierdo._AnchoImgPixel = 0
            Me.uscPulgarIzquierdo._Codigo = -1
            Me.uscPulgarIzquierdo._EstadoDedo = APPControlHuellaVisita.Type.Enumeracion.EstadoDedo.Disponible
            Me.uscPulgarIzquierdo._Foco = False
            Me.uscPulgarIzquierdo._FocoEnceder = False
            Me.uscPulgarIzquierdo._FocoError = False
            Me.uscPulgarIzquierdo._ImagenHuellaByte = Nothing
            Me.uscPulgarIzquierdo._IndiceCalidad = -1
            Me.uscPulgarIzquierdo._LargoImgPixel = 0
            Me.uscPulgarIzquierdo._NumeroDocIdentidad = ""
            Me.uscPulgarIzquierdo._Observacion = ""
            Me.uscPulgarIzquierdo._TemplateANSI = Nothing
            Me.uscPulgarIzquierdo._TemplateISO = Nothing
            Me.uscPulgarIzquierdo._TipoDedo = APPControlHuellaVisita.Type.Enumeracion.TipoDedo.PulgarIzquierdo
            Me.uscPulgarIzquierdo._TipoDispostivo = CType(-1, Short)
            Me.uscPulgarIzquierdo._TipoDocIdentidad = -1
            Me.uscPulgarIzquierdo._VisiblechkHuellaNoDisponible = False
            Me.uscPulgarIzquierdo._Wsq = Nothing
            Me.uscPulgarIzquierdo.BackColor = System.Drawing.Color.DarkGray
            Me.uscPulgarIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.uscPulgarIzquierdo.Location = New System.Drawing.Point(518, 3)
            Me.uscPulgarIzquierdo.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
            Me.uscPulgarIzquierdo.Name = "uscPulgarIzquierdo"
            Me.uscPulgarIzquierdo.Padding = New System.Windows.Forms.Padding(1)
            Me.uscPulgarIzquierdo.Size = New System.Drawing.Size(122, 151)
            Me.uscPulgarIzquierdo.TabIndex = 2
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(0, 0)
            Me.Label2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(643, 13)
            Me.Label2.TabIndex = 17
            Me.Label2.Text = "MANO IZQUIERDA"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel5
            '
            Me.Panel5.BackColor = System.Drawing.SystemColors.Control
            Me.Panel5.Controls.Add(Me.Label9)
            Me.Panel5.Controls.Add(Me.Label8)
            Me.Panel5.Controls.Add(Me.Label7)
            Me.Panel5.Controls.Add(Me.Label4)
            Me.Panel5.Controls.Add(Me.cmdNuevo)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel5.Location = New System.Drawing.Point(0, 352)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(649, 42)
            Me.Panel5.TabIndex = 25
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.Color.Black
            Me.Label9.Location = New System.Drawing.Point(6, 5)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(161, 13)
            Me.Label9.TabIndex = 23
            Me.Label9.Text = "Indice de calidad de huella"
            '
            'pbVistaPreliminHuella
            '
            Me.pbVistaPreliminHuella.BackColor = System.Drawing.Color.Gray
            Me.pbVistaPreliminHuella.Controls.Add(Me.pbVisorHuellaDetalle)
            Me.pbVistaPreliminHuella.Controls.Add(Me.pnlDetalle)
            Me.pbVistaPreliminHuella.Controls.Add(Me.Label3)
            Me.pbVistaPreliminHuella.Controls.Add(Me.txtObservacion)
            Me.pbVistaPreliminHuella.Controls.Add(Me.lblDedoSel)
            Me.pbVistaPreliminHuella.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pbVistaPreliminHuella.Location = New System.Drawing.Point(658, 3)
            Me.pbVistaPreliminHuella.Name = "pbVistaPreliminHuella"
            Me.pbVistaPreliminHuella.Padding = New System.Windows.Forms.Padding(1)
            Me.pbVistaPreliminHuella.Size = New System.Drawing.Size(255, 394)
            Me.pbVistaPreliminHuella.TabIndex = 20
            '
            'pnlDetalle
            '
            Me.pnlDetalle.BackColor = System.Drawing.SystemColors.Control
            Me.pnlDetalle.Controls.Add(Me.lblCalidadHuella)
            Me.pnlDetalle.Controls.Add(Me.lblEstadoDedo)
            Me.pnlDetalle.Controls.Add(Me.Label6)
            Me.pnlDetalle.Controls.Add(Me.Label5)
            Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlDetalle.Location = New System.Drawing.Point(1, 303)
            Me.pnlDetalle.Name = "pnlDetalle"
            Me.pnlDetalle.Size = New System.Drawing.Size(253, 43)
            Me.pnlDetalle.TabIndex = 8
            '
            'lblCalidadHuella
            '
            Me.lblCalidadHuella.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCalidadHuella.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblCalidadHuella.Location = New System.Drawing.Point(94, 23)
            Me.lblCalidadHuella.Name = "lblCalidadHuella"
            Me.lblCalidadHuella.Size = New System.Drawing.Size(156, 18)
            Me.lblCalidadHuella.TabIndex = 1
            '
            'lblEstadoDedo
            '
            Me.lblEstadoDedo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblEstadoDedo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblEstadoDedo.Location = New System.Drawing.Point(94, 3)
            Me.lblEstadoDedo.Name = "lblEstadoDedo"
            Me.lblEstadoDedo.Size = New System.Drawing.Size(156, 18)
            Me.lblEstadoDedo.TabIndex = 1
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(3, 23)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(91, 13)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "Indicador calidad:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(3, 3)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(70, 13)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "Estado dedo:"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.SystemColors.Control
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label3.Location = New System.Drawing.Point(1, 346)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(253, 13)
            Me.Label3.TabIndex = 7
            Me.Label3.Text = "Observación:"
            '
            'txtObservacion
            '
            Me.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.txtObservacion.Location = New System.Drawing.Point(1, 359)
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ReadOnly = True
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(253, 34)
            Me.txtObservacion.TabIndex = 6
            '
            'lblDedoSel
            '
            Me.lblDedoSel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lblDedoSel.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblDedoSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDedoSel.Location = New System.Drawing.Point(1, 1)
            Me.lblDedoSel.Name = "lblDedoSel"
            Me.lblDedoSel.Size = New System.Drawing.Size(253, 13)
            Me.lblDedoSel.TabIndex = 4
            Me.lblDedoSel.Text = "Mano Derecha / Dedo Indice"
            Me.lblDedoSel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'tlpMain
            '
            Me.tlpMain.ColumnCount = 2
            Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.50655!))
            Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.49345!))
            Me.tlpMain.Controls.Add(Me.pbVistaPreliminHuella, 1, 0)
            Me.tlpMain.Controls.Add(Me.pbVistaThumb, 0, 0)
            Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tlpMain.Location = New System.Drawing.Point(0, 0)
            Me.tlpMain.Name = "tlpMain"
            Me.tlpMain.RowCount = 1
            Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.tlpMain.Size = New System.Drawing.Size(916, 400)
            Me.tlpMain.TabIndex = 22
            '
            'pbVisorHuellaDetalle
            '
            Me.pbVisorHuellaDetalle.BackColor = System.Drawing.Color.White
            Me.pbVisorHuellaDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.pbVisorHuellaDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pbVisorHuellaDetalle.Location = New System.Drawing.Point(1, 14)
            Me.pbVisorHuellaDetalle.Name = "pbVisorHuellaDetalle"
            Me.pbVisorHuellaDetalle.Size = New System.Drawing.Size(253, 289)
            Me.pbVisorHuellaDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbVisorHuellaDetalle.TabIndex = 5
            Me.pbVisorHuellaDetalle.TabStop = False
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Image = Global.APPControls.My.Resources.Resources.Circle_Yellow16x16
            Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label8.Location = New System.Drawing.Point(219, 23)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(98, 13)
            Me.Label8.TabIndex = 22
            Me.Label8.Text = "      (3) Calidad baja"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Image = Global.APPControls.My.Resources.Resources.Circle_Red16x16
            Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label7.Location = New System.Drawing.Point(107, 23)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(106, 13)
            Me.Label7.TabIndex = 22
            Me.Label7.Text = "      (2) Calidad media"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Image = Global.APPControls.My.Resources.Resources.Circle_Green16x16
            Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label4.Location = New System.Drawing.Point(6, 23)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(95, 13)
            Me.Label4.TabIndex = 22
            Me.Label4.Text = "      (1) Calidad alta"
            '
            'cmdNuevo
            '
            Me.cmdNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmdNuevo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
            Me.cmdNuevo.Image = Global.APPControls.My.Resources.Resources.new_huella_32x32
            Me.cmdNuevo.Location = New System.Drawing.Point(527, 1)
            Me.cmdNuevo.Name = "cmdNuevo"
            Me.cmdNuevo.Size = New System.Drawing.Size(121, 40)
            Me.cmdNuevo.TabIndex = 21
            Me.cmdNuevo.Text = "Nueva captura"
            Me.cmdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.cmdNuevo.UseVisualStyleBackColor = True
            '
            'uscVisorDetalleHuellas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tlpMain)
            Me.Name = "uscVisorDetalleHuellas"
            Me.Size = New System.Drawing.Size(916, 400)
            Me.pbVistaThumb.ResumeLayout(False)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.pbVistaPreliminHuella.ResumeLayout(False)
            Me.pbVistaPreliminHuella.PerformLayout()
            Me.pnlDetalle.ResumeLayout(False)
            Me.pnlDetalle.PerformLayout()
            Me.tlpMain.ResumeLayout(False)
            CType(Me.pbVisorHuellaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pbVistaThumb As System.Windows.Forms.Panel
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents cmdNuevo As System.Windows.Forms.Button
        Friend WithEvents pbVistaPreliminHuella As System.Windows.Forms.Panel
        Friend WithEvents pbVisorHuellaDetalle As System.Windows.Forms.PictureBox
        Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
        Friend WithEvents lblCalidadHuella As System.Windows.Forms.Label
        Friend WithEvents lblEstadoDedo As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents lblDedoSel As System.Windows.Forms.Label
        Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents uscPulgarDerecho As APPControlHuellaVisita.uscThumbFinger
        Friend WithEvents uscIndiceDerecho As APPControlHuellaVisita.uscThumbFinger
        Friend WithEvents uscMeniqueDerecho As APPControlHuellaVisita.uscThumbFinger
        Friend WithEvents uscMedioDerecho As APPControlHuellaVisita.uscThumbFinger
        Friend WithEvents uscAnularDerecho As APPControlHuellaVisita.uscThumbFinger
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents uscMeniqueIzquierdo As APPControlHuellaVisita.uscThumbFinger
        Friend WithEvents uscAnularIzquierdo As APPControlHuellaVisita.uscThumbFinger
        Friend WithEvents uscMedioIzquierdo As APPControlHuellaVisita.uscThumbFinger
        Friend WithEvents uscIndiceIzquierdo As APPControlHuellaVisita.uscThumbFinger
        Friend WithEvents uscPulgarIzquierdo As APPControlHuellaVisita.uscThumbFinger
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label

    End Class
End Namespace