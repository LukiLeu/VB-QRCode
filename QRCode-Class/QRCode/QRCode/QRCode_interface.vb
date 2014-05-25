Option Explicit On

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Class Encode
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Class QRCode_encode

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Public Typdefinitions
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Enum QRCodeForce
        NoForce = False
        ForceOwnSettings = True
    End Enum

    Public Enum QRCodeMask
        Mask0 = 0
        Mask1 = 1
        Mask2 = 2
        Mask3 = 3
        Mask4 = 4
        Mask5 = 5
        Mask6 = 6
        Mask7 = 7
        MaskAuto = 8
        MaskUndefined = -1
    End Enum

    Public Enum QRCodeVersion
        VersionAuto = 0
        Version1 = 1
        Version2 = 2
        Version3 = 3
        Version4 = 4
        Version5 = 5
        Version6 = 6
        Version7 = 7
        Version8 = 8
        Version9 = 9
        Version10 = 10
        Version11 = 11
        Version12 = 12
        Version13 = 13
        Version14 = 14
        Version15 = 15
        Version16 = 16
        Version17 = 17
        Version18 = 18
        Version19 = 19
        Version20 = 20
        Version21 = 21
        Version22 = 22
        Version23 = 23
        Version24 = 24
        Version25 = 25
        Version26 = 26
        Version27 = 27
        Version28 = 28
        Version29 = 29
        Version30 = 30
        Version31 = 31
        Version32 = 32
        Version33 = 33
        Version34 = 34
        Version35 = 35
        Version36 = 36
        Version37 = 37
        Version38 = 38
        Version39 = 39
        Version40 = 40
        VersionUndefined = -1
    End Enum

    Public Enum QRCodeErrorCorrectionLevel
        L = 0
        M = 1
        Q = 2
        H = 3
        Percent7 = 0
        Percent15 = 1
        Percent25 = 2
        Percent30 = 3
    End Enum

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Private Variables Definition
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private QRCode_ErrorCorrection As QRCodeErrorCorrectionLevel = QRCodeErrorCorrectionLevel.L
    Private QRCode_TextString As String = ""
    Private QRCode_VersionUsed As QRCodeVersion = QRCodeVersion.VersionUndefined
    Private QRCode_MaskUsed As QRCodeMask = QRCodeMask.MaskUndefined
    Private QRCode_TileSize As Integer = -1
    Private QRCode_RandSize As Integer = -1
    Private QRCode_VersionForce As QRCodeVersion = QRCodeVersion.VersionAuto
    Private QRCode_MaskForce As QRCodeMask = QRCodeMask.MaskAuto
    Private QRCode_Force As QRCodeForce = QRCodeForce.NoForce

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Functions Definition
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    ''' <summary>
    ''' Empty Constructor
    ''' </summary>
    ''' <remarks>Call this constructor to define an empty QR-Code Object, all settings have to be set manually.</remarks>
    Sub New()
        QRCode_ErrorCorrection = QRCodeErrorCorrectionLevel.L
        QRCode_TextString = ""
        QRCode_VersionUsed = QRCodeVersion.VersionUndefined
        QRCode_MaskUsed = QRCodeMask.MaskUndefined
        QRCode_TileSize = -1
        QRCode_RandSize = -1
        QRCode_VersionForce = QRCodeVersion.VersionAuto
        QRCode_MaskForce = QRCodeMask.MaskAuto
        QRCode_Force = QRCodeForce.NoForce
    End Sub


End Class
