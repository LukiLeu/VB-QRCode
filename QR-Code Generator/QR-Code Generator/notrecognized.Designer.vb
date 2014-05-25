<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notrecognized
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
        Me.btn_recognized = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_notrecognized = New System.Windows.Forms.Button()
        CType(Me.pct_qrcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pct_qrcode
        '
        Me.pct_qrcode.BackColor = System.Drawing.Color.White
        Me.pct_qrcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct_qrcode.Location = New System.Drawing.Point(12, 12)
        Me.pct_qrcode.Name = "pct_qrcode"
        Me.pct_qrcode.Size = New System.Drawing.Size(400, 400)
        Me.pct_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_qrcode.TabIndex = 1
        Me.pct_qrcode.TabStop = False
        '
        'btn_recognized
        '
        Me.btn_recognized.BackColor = System.Drawing.Color.OliveDrab
        Me.btn_recognized.Location = New System.Drawing.Point(12, 418)
        Me.btn_recognized.Name = "btn_recognized"
        Me.btn_recognized.Size = New System.Drawing.Size(136, 64)
        Me.btn_recognized.TabIndex = 3
        Me.btn_recognized.Text = "QR-Code wurde erkannt"
        Me.btn_recognized.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(154, 418)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(116, 64)
        Me.btn_save.TabIndex = 4
        Me.btn_save.Text = "QR-Code speichern"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_notrecognized
        '
        Me.btn_notrecognized.BackColor = System.Drawing.Color.IndianRed
        Me.btn_notrecognized.Location = New System.Drawing.Point(276, 418)
        Me.btn_notrecognized.Name = "btn_notrecognized"
        Me.btn_notrecognized.Size = New System.Drawing.Size(136, 64)
        Me.btn_notrecognized.TabIndex = 5
        Me.btn_notrecognized.Text = "QR-Code wurde nicht erkannt"
        Me.btn_notrecognized.UseVisualStyleBackColor = False
        '
        'notrecognized
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 492)
        Me.Controls.Add(Me.btn_notrecognized)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_recognized)
        Me.Controls.Add(Me.pct_qrcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "notrecognized"
        Me.Text = "QR-Code"
        CType(Me.pct_qrcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pct_qrcode As System.Windows.Forms.PictureBox
    Friend WithEvents btn_recognized As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_notrecognized As System.Windows.Forms.Button
End Class
