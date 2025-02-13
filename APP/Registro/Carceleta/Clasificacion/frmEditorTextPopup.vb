#Region " IMPORTS "
Imports System.Runtime.InteropServices
Imports System.Drawing.Printing
#End Region

Namespace Registro.Carceleta.Clasificacion

    Public Class frmEditorTextPopup


        Private Const RTF_PAGE_BREAK As String = "{\rtf1\page }"

        Private lDialogBox As Form
        Private lDialogBoxObjects As Object()
        Private lUpdatingScreen As Boolean
        Private lFindString As String
        Private lReplaceString As String
        Private lFindCurrentPos As Integer

        Public Property _IdFicha As Integer = -1
        Public Property _VariableIndicador As String = ""
#Region " PROPERTIES "

        'Public Property Font_Heading3() As Font
        'Public Property Font_Heading2() As Font
        'Public Property Font_Heading1() As Font
        Public Property Font_Normal() As Font
        Public Property BulletIntentBy() As Integer
        Public Property IntentBy() As Integer
        Public Property FileName() As String

        Public Property rtfText() As String
            Get
                Return rtbBody.Rtf.Trim
            End Get
            Set(ByVal value As String)
                rtbBody.Rtf = value.Trim
            End Set
        End Property

        Public Property unformattedText() As String
            Get
                Return rtbBody.Text
            End Get
            Set(ByVal value As String)
                rtbBody.Text = value.Trim
            End Set
        End Property

#End Region

#Region " FORMATTING SUBs (toolbar and menu handlers to prevent repeating code) "

        Private Sub ToggleBold()

            Dim cb As Byte
            If rtbBody.ReadOnly Then Return
            With rtbBody.SelectionFont
                cb = CByte(IIf(.Italic, FontStyle.Italic, 0)) Or
                CByte(IIf(.Underline, FontStyle.Underline, 0)) Or
                CByte(IIf(.Strikeout, FontStyle.Strikeout, 0))
                If Not .Bold Then
                    cb = CByte(cb Or FontStyle.Bold)
                End If
                rtbBody.SelectionFont = New Font(rtbBody.SelectionFont, CType(cb, FontStyle))
            End With
            UpdateMenus()
        End Sub

        Private Sub ToggleUnderline()

            Dim cb As Byte
            If rtbBody.ReadOnly Then Return
            With rtbBody.SelectionFont
                cb = CByte(IIf(.Italic, FontStyle.Italic, 0)) Or
                CByte(IIf(.Bold, FontStyle.Bold, 0)) Or
                CByte(IIf(.Strikeout, FontStyle.Strikeout, 0))
                If Not .Underline Then
                    cb = CByte(FontStyle.Underline Or cb)
                End If
                rtbBody.SelectionFont = New Font(rtbBody.SelectionFont, CType(cb, FontStyle))
            End With
            UpdateMenus()
        End Sub

        Private Sub ToggleItalic()

            Dim cb As Byte
            If rtbBody.ReadOnly Then Return
            With rtbBody.SelectionFont
                cb = CByte(IIf(.Underline, FontStyle.Underline, 0)) Or
                CByte(IIf(.Bold, FontStyle.Bold, 0)) Or
                CByte(IIf(.Strikeout, FontStyle.Strikeout, 0))
                If Not .Italic Then
                    cb = CByte(FontStyle.Italic Or cb)
                End If
                rtbBody.SelectionFont = New Font(rtbBody.SelectionFont, CType(cb, FontStyle))
            End With
            UpdateMenus()
        End Sub


#End Region

#Region " TOOLBAR AND MENU 'CLICK' PROCEDURES "
        Private Sub tsbFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFont.Click
            With FontDialog1
                .Font = rtbBody.SelectionFont
                .ShowColor = False
                If .ShowDialog = DialogResult.OK Then
                    rtbBody.SelectionFont = .Font
                    UpdateMenus()
                End If
            End With
        End Sub

        Private Sub TextColorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextColorToolStripMenuItem1.Click
            TextColorToolStripMenuItem_Click(sender, e)
        End Sub

        Private Sub BackgroundColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgroundColorToolStripMenuItem.Click
            TextBackgroundColorToolStripMenuItem_Click(sender, e)
        End Sub

        Private Sub tsbBullets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBullets.Click
            rtbBody.SelectionBullet = Not rtbBody.SelectionBullet
            UpdateMenus()
        End Sub

        Private Sub tsbIndentIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbIndentIn.Click
            With rtbBody
                .SelectionIndent += IntentBy
            End With
        End Sub

        Private Sub tsbIndentOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbIndentOut.Click
            IndentOutToolStripMenuItem_Click(sender, e)
        End Sub

        Private Sub tsbBold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBold.Click
            ToggleBold()
        End Sub

        Private Sub tsbUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbUnderline.Click
            ToggleUnderline()
        End Sub

        Private Sub tsbItalic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbItalic.Click
            ToggleItalic()
        End Sub


        Private Sub ResetIntentionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            With rtbBody
                '
                ' Reset the indents to 0
                '
                .SelectionIndent = 0
                .SelectionHangingIndent = 0
            End With
        End Sub

        Private Sub IndentOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            With rtbBody
                If .SelectionIndent > IntentBy Then
                    .SelectionIndent -= IntentBy
                Else
                    '
                    ' Reset the indentions
                    '
                    ResetIntentionToolStripMenuItem_Click(sender, e)
                End If
            End With
        End Sub

        Private Sub TextColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim clrdlg As New ColorDialog

            With clrdlg
                .Color = rtbBody.SelectionColor
                .AllowFullOpen = True
                .SolidColorOnly = True
                .FullOpen = True
                If .ShowDialog() = DialogResult.OK Then
                    rtbBody.SelectionColor = .Color
                End If
            End With
            clrdlg.Dispose()
            clrdlg = Nothing
            UpdateMenus()
        End Sub

        Private Sub TextBackgroundColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim clrdlg As New ColorDialog

            With clrdlg
                .Color = rtbBody.SelectionBackColor
                .AllowFullOpen = True
                .SolidColorOnly = True
                .FullOpen = True
                If .ShowDialog() = DialogResult.OK Then
                    rtbBody.SelectionBackColor = .Color
                End If
            End With
            clrdlg.Dispose()
            clrdlg = Nothing
            UpdateMenus()
        End Sub

#End Region


        Public Sub New()

            InitializeComponent()

            FileName = ""
            IntentBy = 100
            BulletIntentBy = 10
            lFindString = ""

            tsbBold.Image = ilMenuItems.Images(12)
            tsbItalic.Image = ilMenuItems.Images(13)
            tsbUnderline.Image = ilMenuItems.Images(14)
            tsbBullets.Image = ilMenuItems.Images(19)
            tsbIndentIn.Image = ilMenuItems.Images(20)
            tsbIndentOut.Image = ilMenuItems.Images(21)
            tsbFont.Image = ilMenuItems.Images(8)


            rtbBody.Margin = New System.Windows.Forms.Padding(5)
            rtbBody.ShowSelectionMargin = True

            Font_Normal = New Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point)
            rtbBody.Font = Font_Normal

        End Sub

        Private Sub ucRTFEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            rtbBody.Font = Font_Normal
            rtbBody.SelectionFont = Font_Normal

            UpdateMenus()
        End Sub

        Private Sub rtbBody_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim intFirstChar As Integer = rtbBody.GetCharIndexFromPosition(New Point(0, 0))
            Dim intFirstLine As Integer = rtbBody.GetLineFromCharIndex(intFirstChar)
            Dim intCharCount As Integer =
            (rtbBody.SelectionStart + rtbBody.SelectionLength) - intFirstChar
            Dim strFromStart As String
            Dim intLine As Integer

            Try
                strFromStart = rtbBody.Text.Substring(intFirstChar, intCharCount)
                intLine = strFromStart.Split(CChar(vbLf)).Length
            Catch ex As Exception

            End Try

            UpdateMenus()
        End Sub

        Private Sub UpdateMenus()

            Try
                With rtbBody.SelectionFont
                    tsbBold.Checked = .Bold
                    tsbItalic.Checked = .Italic
                    tsbUnderline.Checked = .Underline
                End With
                With rtbBody
                    tsbBullets.Checked = .SelectionBullet
                    UpdateFontStyle()
                End With
            Catch ex As Exception

            End Try
        End Sub


        Private Sub UpdateFontStyle()

            lUpdatingScreen = True
            tsbTextColor.ForeColor = rtbBody.SelectionColor
            tsbTextColor.BackColor = rtbBody.SelectionBackColor
            lUpdatingScreen = False
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
            If GrabarFicha() = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        End Sub

        Private Function GrabarFicha()
            Dim v As Boolean = True
            Dim intValue As Integer = -1
            Dim objBss As New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL
            Dim ent As New Entity.Clasificacion.InternoClasificacion.InternoFicha
            With ent
                .Codigo = Me._IdFicha
                .Observacion_02_rtf = Me.rtbBody.Rtf
            End With

            intValue = objBss.Grabar_Observacion_rtf(ent)
            If intValue = -1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("No se pudo completar la operación, intentelo nuevamente.")
                v = False
            End If
            Return v
        End Function

        Private Sub frmEditorTextPopup_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            Dim objBss As New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL
            Dim ent As Entity.Clasificacion.InternoClasificacion.InternoFicha
            ent = objBss.Listar_V2(Me._IdFicha)
            If Not ent Is Nothing Then
                Me.rtbBody.Rtf = ent.Observacion_02_rtf
            End If
            'lblVarInd.Text = Me._VariableIndicador
            btnOK.Enabled = Me._FormEscritura
        End Sub
    End Class
End Namespace