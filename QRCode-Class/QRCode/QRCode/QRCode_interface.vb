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
    ''' Initialize a new QR-Code with user specific values
    ''' </summary>
    ''' <param name="TextString">The Texstring which should be encoded in the QRCode.</param>
    ''' <param name="ErrorCorrection">The Error Correction Level of the QRCode.</param>
    ''' <param name="TileSize">The Size in pixel of a square from the QRCode.</param>
    ''' <param name="BorderSize">The Size in pixel of the border around the QRCode.</param>
    ''' <param name="SettingsForce">Force manual settings</param>
    ''' <param name="VersionForce">The version which should be forced, if force is enabled.</param>
    ''' <param name="MaskForce">The mask which should be forced, if force is enabled.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal TextString As String, ByVal ErrorCorrection As QRCodeErrorCorrectionLevel, ByVal TileSize As Integer, ByVal BorderSize As Integer, _
             Optional ByVal SettingsForce As QRCodeForce = QRCodeForce.NoForce, Optional ByVal VersionForce As QRCodeVersion = QRCodeVersion.VersionAuto, _
             Optional ByVal MaskForce As QRCodeMask = QRCodeMask.MaskAuto)

        If [Enum].IsDefined(GetType(QRCodeErrorCorrectionLevel), ErrorCorrection) Then
            QRCode_ErrorCorrection = ErrorCorrection
        Else
            Throw New Exception("No valid Error Correction set")
        End If

        If QRCode_encode_functions.QRCode_CheckJIS8(TextString) And TextString <> "" And TextString <> Nothing Then
            QRCode_TextString = TextString
        Else
            Throw New Exception("No valid String set. Make sure that it is JIS8 compatible and not empty.")
        End If

        If [Enum].IsDefined(GetType(QRCodeVersion), VersionForce) And VersionForce <> QRCodeVersion.VersionUndefined Then
            QRCode_VersionForce = VersionForce
        Else
            Throw New Exception("No valid Version for forcing set.")
        End If

        If [Enum].IsDefined(GetType(QRCodeMask), MaskForce) And MaskForce <> QRCodeMask.MaskUndefined Then
            QRCode_MaskForce = MaskForce
        Else
            Throw New Exception("No valid Mask for forcing set.")
        End If

        If [Enum].IsDefined(GetType(QRCodeForce), SettingsForce) Then
            QRCode_Force = SettingsForce
        Else
            Throw New Exception("No valid Force set.")
        End If

        If TileSize > 0 And TileSize <> Nothing Then
            QRCode_TileSize = TileSize
        Else
            Throw New Exception("No valid TileSize set.")
        End If

        If BorderSize > 0 And BorderSize <> Nothing Then
            QRCode_RandSize = BorderSize
        Else
            Throw New Exception("No valid BorderSize set.")
        End If
    End Sub

    ''' <summary>
    ''' Initialize a new QR-Code with user specific values
    ''' </summary>
    ''' <param name="TextString">The Texstring which should be encoded in the QRCode.</param>
    ''' <param name="ErrorCorrection">The Error Correction Level of the QRCode.</param>
    ''' <param name="TileSize">The Size in pixel of a square from the QRCode.</param>
    ''' <param name="BorderSize">The Size in pixel of the border around the QRCode.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal TextString As String, ByVal ErrorCorrection As QRCodeErrorCorrectionLevel, ByVal TileSize As Integer, ByVal BorderSize As Integer)

        If [Enum].IsDefined(GetType(QRCodeErrorCorrectionLevel), ErrorCorrection) Then
            QRCode_ErrorCorrection = ErrorCorrection
        Else
            Throw New Exception("No valid Error Correction set")
        End If

        If QRCode_encode_functions.QRCode_CheckJIS8(TextString) And TextString <> "" And TextString <> Nothing Then
            QRCode_TextString = TextString
        Else
            Throw New Exception("No valid String set. Make sure that it is JIS8 compatible and not empty.")
        End If

        If TileSize > 0 And TileSize <> Nothing Then
            QRCode_TileSize = TileSize
        Else
            Throw New Exception("No valid TileSize set.")
        End If

        If BorderSize > 0 And BorderSize <> Nothing Then
            QRCode_RandSize = BorderSize
        Else
            Throw New Exception("No valid BorderSize set.")
        End If

        QRCode_VersionForce = QRCodeVersion.VersionAuto
        QRCode_MaskForce = QRCodeMask.MaskAuto
        QRCode_Force = QRCodeForce.NoForce
    End Sub

    ''' <summary>
    ''' This function creates the QRCode.
    ''' </summary>
    ''' <returns>Returns the QRCode as Bitmap.</returns>
    ''' <remarks></remarks>
    Public Function Generate() As Bitmap
        ' Get the QRVersion
        Dim QRVersion As QRCodeVersion = QRCode_encode_functions.QRCode_GetVersion(QRCode_ErrorCorrection, QRCode_TextString)

        ' Define a Bitmap
        Dim QRCode As Bitmap

        ' Check if force is enabled
        If QRCode_Force = QRCodeForce.ForceOwnSettings Then
            ' Check if the Version is auto
            If QRCode_VersionForce = QRCodeVersion.VersionAuto Then
                ' Generate the QRCode
                QRCode = QRCode_encode_functions.QRCode_StartNew(QRVersion, QRCode_TileSize, QRCode_ErrorCorrection, QRCode_TextString, QRCode_RandSize, QRCode_MaskForce)

                ' Check if the version is equal or bigger than the minimum required version
            ElseIf QRCode_VersionForce >= QRVersion Then
                ' Generate the QRCode
                QRCode = QRCode_encode_functions.QRCode_StartNew(QRCode_VersionForce, QRCode_TileSize, QRCode_ErrorCorrection, QRCode_TextString, QRCode_RandSize, QRCode_MaskForce)

                ' Else no forcing possible
            Else
                Throw New Exception("Force not possible, because the choosen version is too small.")
            End If
        Else
            QRCode = QRCode_encode_functions.QRCode_StartNew(QRVersion, QRCode_TileSize, QRCode_ErrorCorrection, QRCode_TextString, QRCode_RandSize)
        End If

        ' Set the used values
        QRCode_VersionUsed = QRCode_encode_functions.VersionUsed
        QRCode_MaskUsed = QRCode_encode_functions.MaskUsed

        ' Return the QRCode
        Return (QRCode)
    End Function

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Public Properties
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' <summary>
    ''' Gets or sets the TextString
    ''' </summary>
    ''' <value>The new TextString to set</value>
    ''' <returns>The actual TextString</returns>
    ''' <remarks></remarks>
    Public Property TextString As String
        Get
            Return (QRCode_TextString)
        End Get
        Set(value As String)
            If QRCode_encode_functions.QRCode_CheckJIS8(value) And value <> "" And value <> Nothing Then
                QRCode_TextString = value
            Else
                Throw New Exception("No valid String set. Make sure that it is JIS8 compatible and not empty.")
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the ErrorCorrection
    ''' </summary>
    ''' <value>The new ErrorCorrection to set</value>
    ''' <returns>The actual ErrorCorrection</returns>
    ''' <remarks></remarks>
    Public Property ErrorCorrection As QRCodeErrorCorrectionLevel
        Get
            Return (QRCode_ErrorCorrection)
        End Get
        Set(value As QRCodeErrorCorrectionLevel)
            If [Enum].IsDefined(GetType(QRCodeErrorCorrectionLevel), value) Then
                QRCode_ErrorCorrection = value
            Else
                Throw New Exception("No valid Error Correction set")
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the Forced Version
    ''' </summary>
    ''' <value>The new Forced Version to set</value>
    ''' <returns>The actual Forced Version</returns>
    ''' <remarks></remarks>
    Public Property VersionForce As QRCodeVersion
        Get
            Return (QRCode_VersionForce)
        End Get
        Set(value As QRCodeVersion)
            If [Enum].IsDefined(GetType(QRCodeVersion), value) And value <> QRCodeVersion.VersionUndefined Then
                QRCode_VersionForce = value
            Else
                Throw New Exception("No valid Version for forcing set.")
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the Forced Mask
    ''' </summary>
    ''' <value>The new Forced Mask to set</value>
    ''' <returns>The actual Forced Mask</returns>
    ''' <remarks></remarks>
    Public Property MaskForce As QRCodeMask
        Get
            Return (QRCode_MaskForce)
        End Get
        Set(value As QRCodeMask)
            If [Enum].IsDefined(GetType(QRCodeMask), value) And value <> QRCodeMask.MaskUndefined Then
                QRCode_MaskForce = value
            Else
                Throw New Exception("No valid Mask for forcing set.")
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the force of manual settings
    ''' </summary>
    ''' <value>The new force of manual settings to set</value>
    ''' <returns>The actual force of manual settings</returns>
    ''' <remarks></remarks>
    Public Property SettingsForce As QRCodeForce
        Get
            Return (QRCode_Force)
        End Get
        Set(value As QRCodeForce)
            If [Enum].IsDefined(GetType(QRCodeForce), value) Then
                QRCode_Force = value
            Else
                Throw New Exception("No valid Force set.")
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the TileSize
    ''' </summary>
    ''' <value>The new TileSize to set</value>
    ''' <returns>The actual TileSize</returns>
    ''' <remarks></remarks>
    Public Property TileSize As Integer
        Get
            Return (QRCode_TileSize)
        End Get
        Set(value As Integer)
            If value > 0 And value <> Nothing Then
                QRCode_TileSize = value
            Else
                Throw New Exception("No valid TileSize set.")
            End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the BorderSize
    ''' </summary>
    ''' <value>The new BorderSize to set</value>
    ''' <returns>The actual BorderSize</returns>
    ''' <remarks></remarks>
    Public Property BorderSize As Integer
        Get
            Return (QRCode_RandSize)
        End Get
        Set(value As Integer)
            If value > 0 And value <> Nothing Then
                QRCode_RandSize = value
            Else
                Throw New Exception("No valid BorderSize set.")
            End If
        End Set
    End Property

    ''' <summary>
    ''' Reads the used version for the decoding
    ''' </summary>
    ''' <value></value>
    ''' <returns>The used Version for the decoding</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property VersionUsed As QRCodeVersion
        Get
            Return (QRCode_VersionUsed)
        End Get
    End Property

    ''' <summary>
    ''' Reads the used mask for the decoding
    ''' </summary>
    ''' <value></value>
    ''' <returns>The used mask for the decoding</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MaskUsed As QRCodeMask
        Get
            Return (QRCode_MaskUsed)
        End Get
    End Property
End Class
