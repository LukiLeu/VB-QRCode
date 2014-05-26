<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pct_qrcode = New System.Windows.Forms.PictureBox()
        Me.btn_generate = New System.Windows.Forms.Button()
        Me.btn_recognized = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_recognizedfalse = New System.Windows.Forms.Button()
        Me.lbl_Text = New System.Windows.Forms.Label()
        Me.txt_Data = New System.Windows.Forms.TextBox()
        Me.lbl_ErrorCorrectionLevel = New System.Windows.Forms.Label()
        Me.cbb_ErrorCorrectionLevel = New System.Windows.Forms.ComboBox()
        Me.lbl_Border = New System.Windows.Forms.Label()
        Me.num_Border = New System.Windows.Forms.NumericUpDown()
        Me.lbl_Tile = New System.Windows.Forms.Label()
        Me.num_Tile = New System.Windows.Forms.NumericUpDown()
        CType(Me.pct_qrcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_Border, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_Tile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pct_qrcode
        '
        Me.pct_qrcode.BackColor = System.Drawing.Color.White
        Me.pct_qrcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pct_qrcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct_qrcode.Location = New System.Drawing.Point(12, 12)
        Me.pct_qrcode.Name = "pct_qrcode"
        Me.pct_qrcode.Size = New System.Drawing.Size(400, 400)
        Me.pct_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_qrcode.TabIndex = 0
        Me.pct_qrcode.TabStop = False
        '
        'btn_generate
        '
        Me.btn_generate.Location = New System.Drawing.Point(434, 418)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(464, 64)
        Me.btn_generate.TabIndex = 1
        Me.btn_generate.Text = "QR-Code erstellen"
        Me.btn_generate.UseVisualStyleBackColor = True
        '
        'btn_recognized
        '
        Me.btn_recognized.Enabled = False
        Me.btn_recognized.Location = New System.Drawing.Point(12, 418)
        Me.btn_recognized.Name = "btn_recognized"
        Me.btn_recognized.Size = New System.Drawing.Size(133, 64)
        Me.btn_recognized.TabIndex = 2
        Me.btn_recognized.Text = "QR-Code wurde nicht erkannt"
        Me.btn_recognized.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Enabled = False
        Me.btn_save.Location = New System.Drawing.Point(291, 418)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(121, 64)
        Me.btn_save.TabIndex = 3
        Me.btn_save.Text = "QR-Code speichern"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_recognizedfalse
        '
        Me.btn_recognizedfalse.Enabled = False
        Me.btn_recognizedfalse.Location = New System.Drawing.Point(151, 418)
        Me.btn_recognizedfalse.Name = "btn_recognizedfalse"
        Me.btn_recognizedfalse.Size = New System.Drawing.Size(134, 64)
        Me.btn_recognizedfalse.TabIndex = 4
        Me.btn_recognizedfalse.Text = "QR-Code wurde nicht korrekt erkannt"
        Me.btn_recognizedfalse.UseVisualStyleBackColor = True
        '
        'lbl_Text
        '
        Me.lbl_Text.AutoSize = True
        Me.lbl_Text.Location = New System.Drawing.Point(432, 12)
        Me.lbl_Text.Name = "lbl_Text"
        Me.lbl_Text.Size = New System.Drawing.Size(189, 13)
        Me.lbl_Text.TabIndex = 5
        Me.lbl_Text.Text = "In den QR-Code einzubettende Daten:"
        '
        'txt_Data
        '
        Me.txt_Data.Location = New System.Drawing.Point(434, 35)
        Me.txt_Data.Multiline = True
        Me.txt_Data.Name = "txt_Data"
        Me.txt_Data.Size = New System.Drawing.Size(463, 275)
        Me.txt_Data.TabIndex = 6
        '
        'lbl_ErrorCorrectionLevel
        '
        Me.lbl_ErrorCorrectionLevel.AutoSize = True
        Me.lbl_ErrorCorrectionLevel.Location = New System.Drawing.Point(431, 325)
        Me.lbl_ErrorCorrectionLevel.Name = "lbl_ErrorCorrectionLevel"
        Me.lbl_ErrorCorrectionLevel.Size = New System.Drawing.Size(112, 13)
        Me.lbl_ErrorCorrectionLevel.TabIndex = 7
        Me.lbl_ErrorCorrectionLevel.Text = "Error Correction Level:"
        '
        'cbb_ErrorCorrectionLevel
        '
        Me.cbb_ErrorCorrectionLevel.FormattingEnabled = True
        Me.cbb_ErrorCorrectionLevel.Items.AddRange(New Object() {"L (7 Prozent wiederherstellbar)", "M (15 Prozent wiederherstellbar)", "Q (25 Prozent wiederherstellbar)", "H (30 Prozent wiederherstellbar)"})
        Me.cbb_ErrorCorrectionLevel.Location = New System.Drawing.Point(434, 341)
        Me.cbb_ErrorCorrectionLevel.Name = "cbb_ErrorCorrectionLevel"
        Me.cbb_ErrorCorrectionLevel.Size = New System.Drawing.Size(462, 21)
        Me.cbb_ErrorCorrectionLevel.TabIndex = 8
        '
        'lbl_Border
        '
        Me.lbl_Border.AutoSize = True
        Me.lbl_Border.Location = New System.Drawing.Point(433, 375)
        Me.lbl_Border.Name = "lbl_Border"
        Me.lbl_Border.Size = New System.Drawing.Size(160, 13)
        Me.lbl_Border.TabIndex = 9
        Me.lbl_Border.Text = "Randabstand (in QRCode-Pixel):"
        '
        'num_Border
        '
        Me.num_Border.Location = New System.Drawing.Point(436, 392)
        Me.num_Border.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_Border.Name = "num_Border"
        Me.num_Border.Size = New System.Drawing.Size(120, 20)
        Me.num_Border.TabIndex = 10
        Me.num_Border.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lbl_Tile
        '
        Me.lbl_Tile.AutoSize = True
        Me.lbl_Tile.Location = New System.Drawing.Point(655, 375)
        Me.lbl_Tile.Name = "lbl_Tile"
        Me.lbl_Tile.Size = New System.Drawing.Size(149, 13)
        Me.lbl_Tile.TabIndex = 11
        Me.lbl_Tile.Text = "Pixelgrösse QRCode (in Pixel):"
        '
        'num_Tile
        '
        Me.num_Tile.Location = New System.Drawing.Point(658, 392)
        Me.num_Tile.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_Tile.Name = "num_Tile"
        Me.num_Tile.Size = New System.Drawing.Size(120, 20)
        Me.num_Tile.TabIndex = 12
        Me.num_Tile.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 488)
        Me.Controls.Add(Me.num_Tile)
        Me.Controls.Add(Me.lbl_Tile)
        Me.Controls.Add(Me.num_Border)
        Me.Controls.Add(Me.lbl_Border)
        Me.Controls.Add(Me.cbb_ErrorCorrectionLevel)
        Me.Controls.Add(Me.lbl_ErrorCorrectionLevel)
        Me.Controls.Add(Me.txt_Data)
        Me.Controls.Add(Me.lbl_Text)
        Me.Controls.Add(Me.btn_recognizedfalse)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_recognized)
        Me.Controls.Add(Me.btn_generate)
        Me.Controls.Add(Me.pct_qrcode)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.Text = "QR-Code Generator"
        CType(Me.pct_qrcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_Border, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_Tile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pct_qrcode As System.Windows.Forms.PictureBox
    Friend WithEvents btn_generate As System.Windows.Forms.Button
    Friend WithEvents btn_recognized As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_recognizedfalse As System.Windows.Forms.Button
    Friend WithEvents lbl_Text As System.Windows.Forms.Label
    Friend WithEvents txt_Data As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ErrorCorrectionLevel As System.Windows.Forms.Label
    Friend WithEvents cbb_ErrorCorrectionLevel As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Border As System.Windows.Forms.Label
    Friend WithEvents num_Border As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_Tile As System.Windows.Forms.Label
    Friend WithEvents num_Tile As System.Windows.Forms.NumericUpDown

End Class
