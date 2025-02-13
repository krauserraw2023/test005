Namespace Visita.Huella


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmCapturapopup
        Inherits Legolas.APPUIComponents.FormPopup

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.pbEstadoAma = New System.Windows.Forms.PictureBox()
            Me.pbEstadoAzul = New System.Windows.Forms.PictureBox()
            Me.pbEstadoVerde = New System.Windows.Forms.PictureBox()
            Me.pbEstadoHuellaDer = New System.Windows.Forms.PictureBox()
            Me.pbHuellaDerecha = New System.Windows.Forms.PictureBox()
            Me.pbEstadoHuellaIzq = New System.Windows.Forms.PictureBox()
            Me.pbHuellaIzquierda = New System.Windows.Forms.PictureBox()
            Me.pnlLeyendaColor = New System.Windows.Forms.Panel()
            Me.pnlAmarillo = New System.Windows.Forms.Panel()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.pnlAzul = New System.Windows.Forms.Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.pnlVerde = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnCapturarHueIzq = New System.Windows.Forms.Button()
            Me.btnCapturarHueDer = New System.Windows.Forms.Button()
            Me.pnlLeyenda = New System.Windows.Forms.Panel()
            Me.pnlBarra = New System.Windows.Forms.Panel()
            Me.pnlBotones = New System.Windows.Forms.Panel()
            Me.rdbIzqNormal = New System.Windows.Forms.RadioButton()
            Me.rdbIzqAmputado = New System.Windows.Forms.RadioButton()
            Me.rdbIzqObs = New System.Windows.Forms.RadioButton()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.rdbDerAmputado = New System.Windows.Forms.RadioButton()
            Me.rdbDerObs = New System.Windows.Forms.RadioButton()
            Me.rdbDerNormal = New System.Windows.Forms.RadioButton()
            Me.lblTituloManoIzq = New System.Windows.Forms.Label()
            Me.lblTituloManoDer = New System.Windows.Forms.Label()
            Me.pnlObsIzq = New System.Windows.Forms.Panel()
            Me.txtObsIzq = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.pnlObsDer = New System.Windows.Forms.Panel()
            Me.txtObsDer = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.pnlDedosIzq = New System.Windows.Forms.Panel()
            Me.rdbPulgarIzq = New System.Windows.Forms.RadioButton()
            Me.rdbIndiceIzq = New System.Windows.Forms.RadioButton()
            Me.pnlDedosDer = New System.Windows.Forms.Panel()
            Me.rdbPulgarDer = New System.Windows.Forms.RadioButton()
            Me.rdbIndiceDer = New System.Windows.Forms.RadioButton()
            Me.gbxFormChildContainer.SuspendLayout()
            CType(Me.pbEstadoAma, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbEstadoAzul, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbEstadoVerde, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbEstadoHuellaDer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbHuellaDerecha, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbEstadoHuellaIzq, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbHuellaIzquierda, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlLeyendaColor.SuspendLayout()
            Me.pnlAmarillo.SuspendLayout()
            Me.pnlAzul.SuspendLayout()
            Me.pnlVerde.SuspendLayout()
            Me.pnlLeyenda.SuspendLayout()
            Me.pnlBarra.SuspendLayout()
            Me.pnlBotones.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlObsIzq.SuspendLayout()
            Me.pnlObsDer.SuspendLayout()
            Me.pnlDedosIzq.SuspendLayout()
            Me.pnlDedosDer.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.pnlDedosDer)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlDedosIzq)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlObsDer)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlObsIzq)
            Me.gbxFormChildContainer.Controls.Add(Me.lblTituloManoDer)
            Me.gbxFormChildContainer.Controls.Add(Me.lblTituloManoIzq)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlBarra)
            Me.gbxFormChildContainer.Controls.Add(Me.btnCapturarHueDer)
            Me.gbxFormChildContainer.Controls.Add(Me.pbEstadoHuellaIzq)
            Me.gbxFormChildContainer.Controls.Add(Me.btnCapturarHueIzq)
            Me.gbxFormChildContainer.Controls.Add(Me.pbEstadoHuellaDer)
            Me.gbxFormChildContainer.Controls.Add(Me.pbHuellaIzquierda)
            Me.gbxFormChildContainer.Controls.Add(Me.pbHuellaDerecha)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(704, 467)
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(0, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(485, 13)
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "Indice de calidad de Huella:"
            '
            'pbEstadoAma
            '
            Me.pbEstadoAma.BackColor = System.Drawing.Color.Transparent
            Me.pbEstadoAma.Dock = System.Windows.Forms.DockStyle.Left
            Me.pbEstadoAma.Image = Global.APPControls.My.Resources.Resources.estado_amarillo
            Me.pbEstadoAma.Location = New System.Drawing.Point(0, 0)
            Me.pbEstadoAma.Name = "pbEstadoAma"
            Me.pbEstadoAma.Size = New System.Drawing.Size(24, 39)
            Me.pbEstadoAma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbEstadoAma.TabIndex = 15
            Me.pbEstadoAma.TabStop = False
            '
            'pbEstadoAzul
            '
            Me.pbEstadoAzul.BackColor = System.Drawing.Color.Transparent
            Me.pbEstadoAzul.Dock = System.Windows.Forms.DockStyle.Left
            Me.pbEstadoAzul.Image = Global.APPControls.My.Resources.Resources.estado_azul
            Me.pbEstadoAzul.Location = New System.Drawing.Point(0, 0)
            Me.pbEstadoAzul.Name = "pbEstadoAzul"
            Me.pbEstadoAzul.Size = New System.Drawing.Size(24, 39)
            Me.pbEstadoAzul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbEstadoAzul.TabIndex = 14
            Me.pbEstadoAzul.TabStop = False
            '
            'pbEstadoVerde
            '
            Me.pbEstadoVerde.BackColor = System.Drawing.Color.Transparent
            Me.pbEstadoVerde.Dock = System.Windows.Forms.DockStyle.Left
            Me.pbEstadoVerde.Image = Global.APPControls.My.Resources.Resources.estado_verde
            Me.pbEstadoVerde.Location = New System.Drawing.Point(0, 0)
            Me.pbEstadoVerde.Name = "pbEstadoVerde"
            Me.pbEstadoVerde.Size = New System.Drawing.Size(24, 39)
            Me.pbEstadoVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbEstadoVerde.TabIndex = 13
            Me.pbEstadoVerde.TabStop = False
            '
            'pbEstadoHuellaDer
            '
            Me.pbEstadoHuellaDer.BackColor = System.Drawing.Color.White
            Me.pbEstadoHuellaDer.Image = Global.APPControls.My.Resources.Resources.estado_verde
            Me.pbEstadoHuellaDer.Location = New System.Drawing.Point(635, 10)
            Me.pbEstadoHuellaDer.Name = "pbEstadoHuellaDer"
            Me.pbEstadoHuellaDer.Size = New System.Drawing.Size(43, 43)
            Me.pbEstadoHuellaDer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbEstadoHuellaDer.TabIndex = 10
            Me.pbEstadoHuellaDer.TabStop = False
            '
            'pbHuellaDerecha
            '
            Me.pbHuellaDerecha.BackColor = System.Drawing.Color.White
            Me.pbHuellaDerecha.Image = Global.APPControls.My.Resources.Resources.mano_derecha
            Me.pbHuellaDerecha.Location = New System.Drawing.Point(360, 10)
            Me.pbHuellaDerecha.Name = "pbHuellaDerecha"
            Me.pbHuellaDerecha.Size = New System.Drawing.Size(319, 331)
            Me.pbHuellaDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbHuellaDerecha.TabIndex = 4
            Me.pbHuellaDerecha.TabStop = False
            '
            'pbEstadoHuellaIzq
            '
            Me.pbEstadoHuellaIzq.BackColor = System.Drawing.Color.White
            Me.pbEstadoHuellaIzq.Image = Global.APPControls.My.Resources.Resources.estado_verde
            Me.pbEstadoHuellaIzq.Location = New System.Drawing.Point(287, 10)
            Me.pbEstadoHuellaIzq.Name = "pbEstadoHuellaIzq"
            Me.pbEstadoHuellaIzq.Size = New System.Drawing.Size(43, 43)
            Me.pbEstadoHuellaIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbEstadoHuellaIzq.TabIndex = 2
            Me.pbEstadoHuellaIzq.TabStop = False
            '
            'pbHuellaIzquierda
            '
            Me.pbHuellaIzquierda.BackColor = System.Drawing.Color.White
            Me.pbHuellaIzquierda.Image = Global.APPControls.My.Resources.Resources.mano_izquierda
            Me.pbHuellaIzquierda.Location = New System.Drawing.Point(12, 10)
            Me.pbHuellaIzquierda.Name = "pbHuellaIzquierda"
            Me.pbHuellaIzquierda.Size = New System.Drawing.Size(319, 331)
            Me.pbHuellaIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbHuellaIzquierda.TabIndex = 0
            Me.pbHuellaIzquierda.TabStop = False
            '
            'pnlLeyendaColor
            '
            Me.pnlLeyendaColor.BackColor = System.Drawing.Color.Transparent
            Me.pnlLeyendaColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.pnlLeyendaColor.Controls.Add(Me.pnlAmarillo)
            Me.pnlLeyendaColor.Controls.Add(Me.pnlAzul)
            Me.pnlLeyendaColor.Controls.Add(Me.pnlVerde)
            Me.pnlLeyendaColor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlLeyendaColor.Location = New System.Drawing.Point(0, 13)
            Me.pnlLeyendaColor.Name = "pnlLeyendaColor"
            Me.pnlLeyendaColor.Size = New System.Drawing.Size(485, 39)
            Me.pnlLeyendaColor.TabIndex = 16
            '
            'pnlAmarillo
            '
            Me.pnlAmarillo.Controls.Add(Me.Label4)
            Me.pnlAmarillo.Controls.Add(Me.pbEstadoAma)
            Me.pnlAmarillo.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlAmarillo.Location = New System.Drawing.Point(242, 0)
            Me.pnlAmarillo.Name = "pnlAmarillo"
            Me.pnlAmarillo.Size = New System.Drawing.Size(133, 39)
            Me.pnlAmarillo.TabIndex = 2
            '
            'Label4
            '
            Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label4.Location = New System.Drawing.Point(24, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(109, 39)
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "(3) Baja Media"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlAzul
            '
            Me.pnlAzul.Controls.Add(Me.Label3)
            Me.pnlAzul.Controls.Add(Me.pbEstadoAzul)
            Me.pnlAzul.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlAzul.Location = New System.Drawing.Point(109, 0)
            Me.pnlAzul.Name = "pnlAzul"
            Me.pnlAzul.Size = New System.Drawing.Size(133, 39)
            Me.pnlAzul.TabIndex = 1
            '
            'Label3
            '
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label3.Location = New System.Drawing.Point(24, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(109, 39)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "(2) Calidad Media"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlVerde
            '
            Me.pnlVerde.Controls.Add(Me.Label2)
            Me.pnlVerde.Controls.Add(Me.pbEstadoVerde)
            Me.pnlVerde.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlVerde.Location = New System.Drawing.Point(0, 0)
            Me.pnlVerde.Name = "pnlVerde"
            Me.pnlVerde.Size = New System.Drawing.Size(109, 39)
            Me.pnlVerde.TabIndex = 0
            '
            'Label2
            '
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label2.Location = New System.Drawing.Point(24, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(85, 39)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "(1) Calidad Alta "
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.APPControls.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(3, 6)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(101, 42)
            Me.btnAceptar.TabIndex = 2
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.APPControls.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(110, 6)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(101, 42)
            Me.btnCancel.TabIndex = 3
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCapturarHueIzq
            '
            Me.btnCapturarHueIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCapturarHueIzq.Image = Global.APPControls.My.Resources.Resources.capturar
            Me.btnCapturarHueIzq.Location = New System.Drawing.Point(223, 357)
            Me.btnCapturarHueIzq.Name = "btnCapturarHueIzq"
            Me.btnCapturarHueIzq.Size = New System.Drawing.Size(108, 36)
            Me.btnCapturarHueIzq.TabIndex = 17
            '
            'btnCapturarHueDer
            '
            Me.btnCapturarHueDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCapturarHueDer.Image = Global.APPControls.My.Resources.Resources.capturar
            Me.btnCapturarHueDer.Location = New System.Drawing.Point(571, 357)
            Me.btnCapturarHueDer.Name = "btnCapturarHueDer"
            Me.btnCapturarHueDer.Size = New System.Drawing.Size(108, 36)
            Me.btnCapturarHueDer.TabIndex = 18
            '
            'pnlLeyenda
            '
            Me.pnlLeyenda.Controls.Add(Me.pnlLeyendaColor)
            Me.pnlLeyenda.Controls.Add(Me.Label1)
            Me.pnlLeyenda.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlLeyenda.Location = New System.Drawing.Point(0, 0)
            Me.pnlLeyenda.Name = "pnlLeyenda"
            Me.pnlLeyenda.Size = New System.Drawing.Size(485, 52)
            Me.pnlLeyenda.TabIndex = 21
            '
            'pnlBarra
            '
            Me.pnlBarra.Controls.Add(Me.pnlLeyenda)
            Me.pnlBarra.Controls.Add(Me.pnlBotones)
            Me.pnlBarra.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlBarra.Location = New System.Drawing.Point(0, 415)
            Me.pnlBarra.Name = "pnlBarra"
            Me.pnlBarra.Size = New System.Drawing.Size(704, 52)
            Me.pnlBarra.TabIndex = 22
            '
            'pnlBotones
            '
            Me.pnlBotones.Controls.Add(Me.btnAceptar)
            Me.pnlBotones.Controls.Add(Me.btnCancel)
            Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlBotones.Location = New System.Drawing.Point(485, 0)
            Me.pnlBotones.Name = "pnlBotones"
            Me.pnlBotones.Size = New System.Drawing.Size(219, 52)
            Me.pnlBotones.TabIndex = 22
            '
            'rdbIzqNormal
            '
            Me.rdbIzqNormal.AutoSize = True
            Me.rdbIzqNormal.Checked = True
            Me.rdbIzqNormal.Location = New System.Drawing.Point(5, 3)
            Me.rdbIzqNormal.Name = "rdbIzqNormal"
            Me.rdbIzqNormal.Size = New System.Drawing.Size(58, 17)
            Me.rdbIzqNormal.TabIndex = 23
            Me.rdbIzqNormal.TabStop = True
            Me.rdbIzqNormal.Text = "Normal"
            Me.rdbIzqNormal.UseVisualStyleBackColor = True
            '
            'rdbIzqAmputado
            '
            Me.rdbIzqAmputado.AutoSize = True
            Me.rdbIzqAmputado.Location = New System.Drawing.Point(5, 23)
            Me.rdbIzqAmputado.Name = "rdbIzqAmputado"
            Me.rdbIzqAmputado.Size = New System.Drawing.Size(73, 17)
            Me.rdbIzqAmputado.TabIndex = 24
            Me.rdbIzqAmputado.Text = "Amputado"
            Me.rdbIzqAmputado.UseVisualStyleBackColor = True
            '
            'rdbIzqObs
            '
            Me.rdbIzqObs.AutoSize = True
            Me.rdbIzqObs.Location = New System.Drawing.Point(5, 43)
            Me.rdbIzqObs.Name = "rdbIzqObs"
            Me.rdbIzqObs.Size = New System.Drawing.Size(77, 17)
            Me.rdbIzqObs.TabIndex = 25
            Me.rdbIzqObs.Text = "Observado"
            Me.rdbIzqObs.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.rdbIzqAmputado)
            Me.Panel1.Controls.Add(Me.rdbIzqObs)
            Me.Panel1.Controls.Add(Me.rdbIzqNormal)
            Me.Panel1.Location = New System.Drawing.Point(12, 341)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(97, 67)
            Me.Panel1.TabIndex = 26
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.rdbDerAmputado)
            Me.Panel2.Controls.Add(Me.rdbDerObs)
            Me.Panel2.Controls.Add(Me.rdbDerNormal)
            Me.Panel2.Location = New System.Drawing.Point(360, 341)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(105, 67)
            Me.Panel2.TabIndex = 27
            '
            'rdbDerAmputado
            '
            Me.rdbDerAmputado.AutoSize = True
            Me.rdbDerAmputado.Location = New System.Drawing.Point(5, 23)
            Me.rdbDerAmputado.Name = "rdbDerAmputado"
            Me.rdbDerAmputado.Size = New System.Drawing.Size(73, 17)
            Me.rdbDerAmputado.TabIndex = 24
            Me.rdbDerAmputado.Text = "Amputado"
            Me.rdbDerAmputado.UseVisualStyleBackColor = True
            '
            'rdbDerObs
            '
            Me.rdbDerObs.AutoSize = True
            Me.rdbDerObs.Location = New System.Drawing.Point(5, 43)
            Me.rdbDerObs.Name = "rdbDerObs"
            Me.rdbDerObs.Size = New System.Drawing.Size(77, 17)
            Me.rdbDerObs.TabIndex = 25
            Me.rdbDerObs.Text = "Observado"
            Me.rdbDerObs.UseVisualStyleBackColor = True
            '
            'rdbDerNormal
            '
            Me.rdbDerNormal.AutoSize = True
            Me.rdbDerNormal.Checked = True
            Me.rdbDerNormal.Location = New System.Drawing.Point(5, 3)
            Me.rdbDerNormal.Name = "rdbDerNormal"
            Me.rdbDerNormal.Size = New System.Drawing.Size(58, 17)
            Me.rdbDerNormal.TabIndex = 23
            Me.rdbDerNormal.TabStop = True
            Me.rdbDerNormal.Text = "Normal"
            Me.rdbDerNormal.UseVisualStyleBackColor = True
            '
            'lblTituloManoIzq
            '
            Me.lblTituloManoIzq.AutoSize = True
            Me.lblTituloManoIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTituloManoIzq.Location = New System.Drawing.Point(13, 312)
            Me.lblTituloManoIzq.Name = "lblTituloManoIzq"
            Me.lblTituloManoIzq.Size = New System.Drawing.Size(174, 25)
            Me.lblTituloManoIzq.TabIndex = 28
            Me.lblTituloManoIzq.Text = "Mano Izquierda"
            '
            'lblTituloManoDer
            '
            Me.lblTituloManoDer.AutoSize = True
            Me.lblTituloManoDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTituloManoDer.Location = New System.Drawing.Point(510, 312)
            Me.lblTituloManoDer.Name = "lblTituloManoDer"
            Me.lblTituloManoDer.Size = New System.Drawing.Size(165, 25)
            Me.lblTituloManoDer.TabIndex = 29
            Me.lblTituloManoDer.Text = "Mano Derecha"
            '
            'pnlObsIzq
            '
            Me.pnlObsIzq.Controls.Add(Me.txtObsIzq)
            Me.pnlObsIzq.Controls.Add(Me.Label7)
            Me.pnlObsIzq.Location = New System.Drawing.Point(12, 11)
            Me.pnlObsIzq.Name = "pnlObsIzq"
            Me.pnlObsIzq.Size = New System.Drawing.Size(318, 302)
            Me.pnlObsIzq.TabIndex = 30
            '
            'txtObsIzq
            '
            Me.txtObsIzq.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObsIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObsIzq.Location = New System.Drawing.Point(0, 20)
            Me.txtObsIzq.MaxLength = 500
            Me.txtObsIzq.Multiline = True
            Me.txtObsIzq.Name = "txtObsIzq"
            Me.txtObsIzq.Size = New System.Drawing.Size(318, 282)
            Me.txtObsIzq.TabIndex = 0
            '
            'Label7
            '
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label7.Location = New System.Drawing.Point(0, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(318, 20)
            Me.Label7.TabIndex = 1
            Me.Label7.Text = "Obervacion:"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlObsDer
            '
            Me.pnlObsDer.Controls.Add(Me.txtObsDer)
            Me.pnlObsDer.Controls.Add(Me.Label8)
            Me.pnlObsDer.Location = New System.Drawing.Point(361, 11)
            Me.pnlObsDer.Name = "pnlObsDer"
            Me.pnlObsDer.Size = New System.Drawing.Size(318, 302)
            Me.pnlObsDer.TabIndex = 31
            '
            'txtObsDer
            '
            Me.txtObsDer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObsDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObsDer.Location = New System.Drawing.Point(0, 20)
            Me.txtObsDer.MaxLength = 500
            Me.txtObsDer.Multiline = True
            Me.txtObsDer.Name = "txtObsDer"
            Me.txtObsDer.Size = New System.Drawing.Size(318, 282)
            Me.txtObsDer.TabIndex = 0
            '
            'Label8
            '
            Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label8.Location = New System.Drawing.Point(0, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(318, 20)
            Me.Label8.TabIndex = 1
            Me.Label8.Text = "Obervacion:"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlDedosIzq
            '
            Me.pnlDedosIzq.Controls.Add(Me.rdbPulgarIzq)
            Me.pnlDedosIzq.Controls.Add(Me.rdbIndiceIzq)
            Me.pnlDedosIzq.Location = New System.Drawing.Point(110, 341)
            Me.pnlDedosIzq.Name = "pnlDedosIzq"
            Me.pnlDedosIzq.Size = New System.Drawing.Size(66, 67)
            Me.pnlDedosIzq.TabIndex = 32
            '
            'rdbPulgarIzq
            '
            Me.rdbPulgarIzq.AutoSize = True
            Me.rdbPulgarIzq.Enabled = False
            Me.rdbPulgarIzq.Location = New System.Drawing.Point(5, 23)
            Me.rdbPulgarIzq.Name = "rdbPulgarIzq"
            Me.rdbPulgarIzq.Size = New System.Drawing.Size(55, 17)
            Me.rdbPulgarIzq.TabIndex = 24
            Me.rdbPulgarIzq.Text = "Pulgar"
            Me.rdbPulgarIzq.UseVisualStyleBackColor = True
            '
            'rdbIndiceIzq
            '
            Me.rdbIndiceIzq.AutoSize = True
            Me.rdbIndiceIzq.Checked = True
            Me.rdbIndiceIzq.Location = New System.Drawing.Point(5, 3)
            Me.rdbIndiceIzq.Name = "rdbIndiceIzq"
            Me.rdbIndiceIzq.Size = New System.Drawing.Size(54, 17)
            Me.rdbIndiceIzq.TabIndex = 23
            Me.rdbIndiceIzq.TabStop = True
            Me.rdbIndiceIzq.Text = "Indice"
            Me.rdbIndiceIzq.UseVisualStyleBackColor = True
            '
            'pnlDedosDer
            '
            Me.pnlDedosDer.Controls.Add(Me.rdbPulgarDer)
            Me.pnlDedosDer.Controls.Add(Me.rdbIndiceDer)
            Me.pnlDedosDer.Location = New System.Drawing.Point(466, 341)
            Me.pnlDedosDer.Name = "pnlDedosDer"
            Me.pnlDedosDer.Size = New System.Drawing.Size(66, 67)
            Me.pnlDedosDer.TabIndex = 33
            '
            'rdbPulgarDer
            '
            Me.rdbPulgarDer.AutoSize = True
            Me.rdbPulgarDer.Enabled = False
            Me.rdbPulgarDer.Location = New System.Drawing.Point(5, 23)
            Me.rdbPulgarDer.Name = "rdbPulgarDer"
            Me.rdbPulgarDer.Size = New System.Drawing.Size(55, 17)
            Me.rdbPulgarDer.TabIndex = 24
            Me.rdbPulgarDer.Text = "Pulgar"
            Me.rdbPulgarDer.UseVisualStyleBackColor = True
            '
            'rdbIndiceDer
            '
            Me.rdbIndiceDer.AutoSize = True
            Me.rdbIndiceDer.Checked = True
            Me.rdbIndiceDer.Location = New System.Drawing.Point(5, 3)
            Me.rdbIndiceDer.Name = "rdbIndiceDer"
            Me.rdbIndiceDer.Size = New System.Drawing.Size(54, 17)
            Me.rdbIndiceDer.TabIndex = 23
            Me.rdbIndiceDer.TabStop = True
            Me.rdbIndiceDer.Text = "Indice"
            Me.rdbIndiceDer.UseVisualStyleBackColor = True
            '
            'frmCapturapopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(704, 467)
            Me.Name = "frmCapturapopup"
            Me.Text = "Proceso de captura de Huella Digital"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.gbxFormChildContainer.PerformLayout()
            CType(Me.pbEstadoAma, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbEstadoAzul, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbEstadoVerde, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbEstadoHuellaDer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbHuellaDerecha, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbEstadoHuellaIzq, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbHuellaIzquierda, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlLeyendaColor.ResumeLayout(False)
            Me.pnlAmarillo.ResumeLayout(False)
            Me.pnlAzul.ResumeLayout(False)
            Me.pnlVerde.ResumeLayout(False)
            Me.pnlLeyenda.ResumeLayout(False)
            Me.pnlBarra.ResumeLayout(False)
            Me.pnlBotones.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.pnlObsIzq.ResumeLayout(False)
            Me.pnlObsIzq.PerformLayout()
            Me.pnlObsDer.ResumeLayout(False)
            Me.pnlObsDer.PerformLayout()
            Me.pnlDedosIzq.ResumeLayout(False)
            Me.pnlDedosIzq.PerformLayout()
            Me.pnlDedosDer.ResumeLayout(False)
            Me.pnlDedosDer.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pbHuellaIzquierda As System.Windows.Forms.PictureBox
        Friend WithEvents pbEstadoHuellaIzq As System.Windows.Forms.PictureBox
        Friend WithEvents pbHuellaDerecha As System.Windows.Forms.PictureBox
        Friend WithEvents pbEstadoHuellaDer As System.Windows.Forms.PictureBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents pbEstadoVerde As System.Windows.Forms.PictureBox
        Friend WithEvents pbEstadoAzul As System.Windows.Forms.PictureBox
        Friend WithEvents pbEstadoAma As System.Windows.Forms.PictureBox
        Friend WithEvents pnlLeyendaColor As System.Windows.Forms.Panel
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents pnlVerde As System.Windows.Forms.Panel
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnCapturarHueIzq As System.Windows.Forms.Button
        Friend WithEvents btnCapturarHueDer As System.Windows.Forms.Button
        Friend WithEvents pnlAmarillo As System.Windows.Forms.Panel
        Friend WithEvents pnlAzul As System.Windows.Forms.Panel
        Friend WithEvents pnlBarra As System.Windows.Forms.Panel
        Friend WithEvents pnlLeyenda As System.Windows.Forms.Panel
        Friend WithEvents pnlBotones As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents rdbDerAmputado As System.Windows.Forms.RadioButton
        Friend WithEvents rdbDerObs As System.Windows.Forms.RadioButton
        Friend WithEvents rdbDerNormal As System.Windows.Forms.RadioButton
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents rdbIzqAmputado As System.Windows.Forms.RadioButton
        Friend WithEvents rdbIzqObs As System.Windows.Forms.RadioButton
        Friend WithEvents rdbIzqNormal As System.Windows.Forms.RadioButton
        Friend WithEvents lblTituloManoDer As System.Windows.Forms.Label
        Friend WithEvents lblTituloManoIzq As System.Windows.Forms.Label
        Friend WithEvents pnlObsIzq As System.Windows.Forms.Panel
        Friend WithEvents txtObsIzq As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents pnlObsDer As System.Windows.Forms.Panel
        Friend WithEvents txtObsDer As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents pnlDedosDer As System.Windows.Forms.Panel
        Friend WithEvents rdbPulgarDer As System.Windows.Forms.RadioButton
        Friend WithEvents rdbIndiceDer As System.Windows.Forms.RadioButton
        Friend WithEvents pnlDedosIzq As System.Windows.Forms.Panel
        Friend WithEvents rdbPulgarIzq As System.Windows.Forms.RadioButton
        Friend WithEvents rdbIndiceIzq As System.Windows.Forms.RadioButton
    End Class

End Namespace