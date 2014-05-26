Imports QRCode.QRCode_encode
Imports QRCode

Public Class notrecognized
    Public notrecognized_Mask As Integer = 0
    Public notrecognized_ErrorCorrection As Integer = 0
    Public notrecognized_textstring As String = ""
    Public notrecognized_Version As Integer = 0
    Public notrecognized_Rand As Integer = 0
    Public notrecognized_TileSize As Integer = 0

    Private Sub notrecognized_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If notrecognized_Mask <> -1 Then
                Dim QR As New QRCode_encode(notrecognized_textstring, notrecognized_ErrorCorrection, notrecognized_TileSize, notrecognized_Rand, QRCodeForce.ForceOwnSettings, notrecognized_Version, 1)
                Me.pct_qrcode.Image = QR.Generate()
            Else
                Dim QR As New QRCode_encode(notrecognized_textstring, notrecognized_ErrorCorrection, notrecognized_TileSize, notrecognized_Rand, QRCodeForce.ForceOwnSettings, notrecognized_Version, 0)
                Me.pct_qrcode.Image = QR.Generate()
                notrecognized_Mask = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub btn_notrecognized_Click(sender As Object, e As EventArgs) Handles btn_notrecognized.Click
        notrecognized_Mask += 1
        If notrecognized_Mask > 7 Then
            notrecognized_Version += 1
            If notrecognized_Mask > 7 And notrecognized_Version > 40 Then
                MsgBox("Es scheint, als funktioniert kein QR-Code mit den von Ihnen gewünschten Daten")
                Exit Sub
            End If
            notrecognized_Mask = 0
        End If
        Try
            Dim QR As New QRCode_encode(notrecognized_textstring, notrecognized_ErrorCorrection, notrecognized_TileSize, notrecognized_Rand, QRCodeForce.ForceOwnSettings, notrecognized_Version, notrecognized_Mask)
            Me.pct_qrcode.Image = QR.Generate()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub btn_recognized_Click(sender As Object, e As EventArgs) Handles btn_recognized.Click
        main.pct_qrcode.Image = Me.pct_qrcode.Image
        main.Show()
        Me.Close()
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

    Private Sub notrecognized_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        main.Show()
    End Sub
End Class