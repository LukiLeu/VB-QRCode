Imports System.Text.RegularExpressions
Imports QRCode.QRCode_encode
Imports QRCode

Public Class main
    Public main_ErrorCorrection As Integer = 0
    Public main_textstring As String = "Hal"
    Public main_Version As Integer = 0
    Public main_Rand As Integer = 5
    Public main_TileSize As Integer = 10

    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Dim QR As New QRCode_encode

        Dim Test As QRCodeForce

        If (Check_JIS8(Me.txt_Data.Text)) Then
            'main_Version = QRCode_GetVersion(main_ErrorCorrection, Me.txt_Data.Text)
            'Me.pct_qrcode.Image = QRCode_StartNew(main_Version, main_TileSize, main_ErrorCorrection, Me.txt_Data.Text, main_Rand)
            Me.pct_qrcode.Image.Save("D:\extracted\" & main_Version.ToString & ".jpg")
            Me.btn_recognized.Enabled = True
            Me.btn_save.Enabled = True
            Me.btn_recognizedfalse.Enabled = True
        Else
            MsgBox("Not JIS8")
        End If
    End Sub

    Public Function Check_JIS8(ByVal TextString As String) As Boolean
        Dim pattern As String = "^[\x00-\x7F]+$"
        Dim reg As New Regex(pattern)
        Return reg.IsMatch(TextString)
    End Function



    Private Sub btn_recognized_Click(sender As Object, e As EventArgs) Handles btn_recognized.Click
        notrecognized.notrecognized_ErrorCorrection = main_ErrorCorrection
        notrecognized.notrecognized_textstring = main_textstring
        notrecognized.notrecognized_Version = main_Version
        notrecognized.notrecognized_Rand = main_Rand
        notrecognized.notrecognized_TileSize = main_TileSize
        notrecognized.notrecognized_Mask = 0
        notrecognized.Show()
        Me.Hide()
    End Sub

    Private Sub btn_recognizedfalse_Click(sender As Object, e As EventArgs) Handles btn_recognizedfalse.Click
        notrecognized.notrecognized_ErrorCorrection = main_ErrorCorrection
        notrecognized.notrecognized_textstring = main_textstring
        notrecognized.notrecognized_Version = main_Version + 1
        notrecognized.notrecognized_Rand = main_Rand
        notrecognized.notrecognized_TileSize = main_TileSize
        notrecognized.notrecognized_Mask = -1
        notrecognized.Show()
        Me.Hide()
    End Sub
End Class
