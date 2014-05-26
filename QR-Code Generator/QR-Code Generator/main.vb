Imports QRCode.QRCode_encode
Imports QRCode

Public Class main
    Public main_Version As Integer = 0
    Public main_Rand As Integer = 5
    Public main_TileSize As Integer = 10

    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Dim QRError As QRCodeErrorCorrectionLevel = Me.cbb_ErrorCorrectionLevel.SelectedIndex

        ' Try to generate a QRCode
        Try
            Dim QR As New QRCode_encode(Me.txt_Data.Text, Me.cbb_ErrorCorrectionLevel.SelectedIndex, Me.num_Tile.Value, Me.num_Border.Value)
            Me.pct_qrcode.Image = QR.Generate()


            Me.btn_recognized.Enabled = True
            Me.btn_save.Enabled = True
            Me.btn_recognizedfalse.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub btn_recognized_Click(sender As Object, e As EventArgs) Handles btn_recognized.Click
        notrecognized.notrecognized_ErrorCorrection = Me.cbb_ErrorCorrectionLevel.SelectedIndex
        notrecognized.notrecognized_textstring = Me.txt_Data.Text
        notrecognized.notrecognized_Version = main_Version
        notrecognized.notrecognized_Rand = main_Rand
        notrecognized.notrecognized_TileSize = main_TileSize
        notrecognized.notrecognized_Mask = 0
        notrecognized.Show()
        Me.Hide()
    End Sub

    Private Sub btn_recognizedfalse_Click(sender As Object, e As EventArgs) Handles btn_recognizedfalse.Click
        notrecognized.notrecognized_ErrorCorrection = Me.cbb_ErrorCorrectionLevel.SelectedIndex
        notrecognized.notrecognized_textstring = Me.txt_Data.Text
        If main_Version < 40 Then notrecognized.notrecognized_Version = main_Version + 1 Else notrecognized.notrecognized_Version = main_Version
        notrecognized.notrecognized_Rand = main_Rand
        notrecognized.notrecognized_TileSize = main_TileSize
        notrecognized.notrecognized_Mask = -1
        notrecognized.Show()
        Me.Hide()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim d As New SaveFileDialog
        d.CheckFileExists = False
        d.CheckPathExists = True
        d.Title = "Speicherort"
        d.Filter = "Image|*.jpg"

        Dim ergebnis As DialogResult

        ergebnis = d.ShowDialog

        If ergebnis = Windows.Forms.DialogResult.OK Then
            Me.pct_qrcode.Image.Save(d.FileName)
        End If
    End Sub
End Class
