Public Class ImgEncryptor

    Private EscapeCharacter As Integer = 255

    Public Function DecryptImage(EncryptedImage As Bitmap) As String



        Dim ExctractedMessage As String = ""

        Dim MessageIndex As Integer = 0

        Dim c As Color

        Dim y As Integer = 0

        Dim endCharCount = 0

        '   For Each b As Char In Text
        For x As Integer = 0 To (EncryptedImage.Size.Width - 1) / 4

            For y = 0 To (EncryptedImage.Size.Height - 1) / 4

                Dim gx As Integer
                Dim gy As Integer

                If (x = 0) And (y = 0) Then
                    gx = 0
                    gy = 0
                ElseIf (y = 0) Then
                    gx = (x * 4) - 1
                    gy = 0
                ElseIf (x = 0) Then
                    gx = 0
                    gy = (y * 4) - 1
                Else
                    gx = (x * 4) - 1
                    gy = (y * 4) - 1
                End If

                c = EncryptedImage.GetPixel(gx, gy)

                If (c.R = EscapeCharacter) Then
                    endCharCount += 1 'Increment
                    If (endCharCount = 4) Then
                        Exit For
                    End If
                Else
                    endCharCount = 0 'Reset
                End If

                ExctractedMessage += Convert.ToChar(c.R)

            Next

            If (endCharCount = 4) Then
                Exit For
            End If

        Next

        DecryptImage = ExctractedMessage

    End Function

    Public Function EncryptImage(Text As String, OriginalImage As Bitmap, PictureBox As PictureBox, ShowLocations As Boolean
                                 ) As Bitmap

        Dim EncryptedImage As Bitmap
        Dim MessageIndex As Integer = 0

        Dim c As Color

        Dim y As Integer = 0
        Dim x As Integer = 0

        Dim r As Integer = 0
        Dim g As Integer = 0
        Dim b As Integer = 0

        EncryptedImage = OriginalImage.Clone()

        '   For Each b As Char In Text
        For x = 0 To (OriginalImage.Size.Width - 1) / 4

            For y = 0 To (OriginalImage.Size.Height - 1) / 4

                'Exit if message is over
                If MessageIndex >= Text.Count Then
                    Exit For
                End If

                c = OriginalImage.GetPixel(y, x)
                r = Convert.ToInt16(c.R)
                g = Convert.ToInt16(c.G)
                b = Convert.ToInt16(c.B)

                'Only change the blue value for now, leave red and green the same
                r = Convert.ToInt16(Text(MessageIndex))

                'Color pixel a bright color to show it's location in the OriginalImage
                If ShowLocations Then
                    r = 0
                    g = 0
                    b = 0
                End If

                If (x = 0) And (y = 0) Then
                    EncryptedImage.SetPixel(0, 0, Color.FromArgb(r, g, b))
                ElseIf (y = 0) Then
                    EncryptedImage.SetPixel((x * 4) - 1, 0, Color.FromArgb(r, g, b))
                ElseIf (x = 0) Then
                    EncryptedImage.SetPixel(0, (y * 4) - 1, Color.FromArgb(r, g, b))
                Else
                    EncryptedImage.SetPixel((x * 4) - 1, (y * 4) - 1, Color.FromArgb(r, g, b))
                End If

                'Increase message index location
                MessageIndex += 1

            Next

            If MessageIndex >= Text.Count Then
                Exit For
            End If

        Next

        'Print message end sequence
        c = OriginalImage.GetPixel(y + 4, x)
        r = Convert.ToInt16(c.R)
        g = Convert.ToInt16(c.G)
        b = Convert.ToInt16(c.B)
        EncryptedImage.SetPixel(0, 0, Color.FromArgb(EscapeCharacter, g, b))

        c = OriginalImage.GetPixel(y + 8, x)
        r = Convert.ToInt16(c.R)
        g = Convert.ToInt16(c.G)
        b = Convert.ToInt16(c.B)
        EncryptedImage.SetPixel(0, 0, Color.FromArgb(EscapeCharacter, g, b))

        c = OriginalImage.GetPixel(y + 12, x)
        r = Convert.ToInt16(c.R)
        g = Convert.ToInt16(c.G)
        b = Convert.ToInt16(c.B)
        EncryptedImage.SetPixel(0, 0, Color.FromArgb(EscapeCharacter, g, b))

        c = OriginalImage.GetPixel(y + 16, x)
        r = Convert.ToInt16(c.R)
        g = Convert.ToInt16(c.G)
        b = Convert.ToInt16(c.B)
        EncryptedImage.SetPixel(0, 0, Color.FromArgb(255, g, b))

        EncryptImage = EncryptedImage

    End Function

End Class

