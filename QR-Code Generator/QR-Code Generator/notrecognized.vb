Public Class notrecognized
    Public notrecognized_Mask As Integer = 0
    Public notrecognized_ErrorCorrection As Integer = 0
    Public notrecognized_textstring As String = ""
    Public notrecognized_Version As Integer = 0
    Public notrecognized_Rand As Integer = 0
    Public notrecognized_TileSize As Integer = 0

    Private Sub notrecognized_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If notrecognized_Mask <> -1 Then
            ' Me.pct_qrcode.Image = QRCode_StartNew(notrecognized_Version, notrecognized_TileSize, notrecognized_ErrorCorrection, notrecognized_textstring, notrecognized_Rand, 1)
        Else
            'Me.pct_qrcode.Image = QRCode_StartNew(notrecognized_Version, notrecognized_TileSize, notrecognized_ErrorCorrection, notrecognized_textstring, notrecognized_Rand)
            notrecognized_Mask = 0
        End If
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
        'Me.pct_qrcode.Image = QRCode_StartNew(notrecognized_Version, notrecognized_TileSize, notrecognized_ErrorCorrection, notrecognized_textstring, notrecognized_Rand, notrecognized_Mask)
    End Sub

    Private Sub btn_recognized_Click(sender As Object, e As EventArgs) Handles btn_recognized.Click
        main.pct_qrcode.Image = Me.pct_qrcode.Image
        main.Show()
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

    End Sub

    Private Sub notrecognized_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        main.Show()
    End Sub
End Class