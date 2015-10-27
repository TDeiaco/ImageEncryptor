

Public Class ImageEncryptorForm



    Private MyImage As Bitmap

    'These refer to the distance between embedded pixels\in the X and Y direction

    Private EmbedDistanceX As Integer
    Private EmbedDistanceY As Integer

    'Storage for the original and encrypted images
    Private OriginalImage As Bitmap
    Private EncryptedImage As Bitmap

    Public Sub ShowMyImageFit(fileToDisplay As String, xSize As Integer, _
                           ySize As Integer)
        ' Sets up an image object to be displayed.
        If (MyImage IsNot Nothing) Then
            MyImage.Dispose()
        End If

        ' Stretches the image to fit the pictureBox. 
        OriginalImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        MyImage = New Bitmap(fileToDisplay)
        
    End Sub

    Private Sub ImageEncryptorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OriginalImageUrl.Text = "C:\Users\Taylor\Pictures\Standing By.jpg"

        EncryptedMessageTextBox.Text = "This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is thThis is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!This is the secret message!e secret message!This is "

    End Sub

    Private Sub EmbedMessageButton_Click(sender As Object, e As EventArgs) Handles EmbedMessageButton.Click

        Dim messageText As String = EncryptedMessageTextBox.Text
        Dim MessageIndex As Integer = 0

        Dim c As Color

        Dim y As Integer = 0

        EncryptedImage = OriginalImage.Clone()

        '   For Each b As Char In messageText
        For x As Integer = 0 To (OriginalImage.Size.Width - 1) / 4

            For y = 0 To (OriginalImage.Size.Height - 1) / 4

                'Exit if message is over
                If MessageIndex >= messageText.Count Then
                    Exit For
                End If

                c = OriginalImage.GetPixel(x, y)
                Dim r As Integer = Convert.ToInt16(c.R)
                Dim g As Integer = Convert.ToInt16(c.G)
                Dim blue As Integer = Convert.ToInt16(c.B)

                'Only change the blue value for now, leave red and green the same
                r = Convert.ToInt16(messageText(MessageIndex))

                'Color pixel a bright color to show it's location in the image
                If ShowEncryptedLocationsCheckbox.Checked Then
                    r = 0
                    g = 0
                    blue = 0
                End If

                If (x = 0) And (y = 0) Then
                    EncryptedImage.SetPixel(0, 0, Color.FromArgb(r, g, blue))
                ElseIf (y = 0) Then
                    EncryptedImage.SetPixel((x * 4) - 1, 0, Color.FromArgb(r, g, blue))
                ElseIf (x = 0) Then
                    EncryptedImage.SetPixel(0, (y * 4) - 1, Color.FromArgb(r, g, blue))
                Else
                    EncryptedImage.SetPixel((x * 4) - 1, (y * 4) - 1, Color.FromArgb(r, g, blue))
                End If

                'Increase message index location
                MessageIndex += 1

            Next

            If MessageIndex >= messageText.Count Then
                Exit For
            End If

        Next

        'Next

        EncryptedImagePictureBox.ClientSize = New Size(EncryptedImagePanel.Size)
        EncryptedImagePictureBox.Image = CType(EncryptedImage, Image)
        EncryptedImagePictureBox.Show()

    End Sub

    Private Sub OriginalImageLocationButton_Click(sender As Object, e As EventArgs) Handles OriginalImageLocationButton.Click

    



    End Sub

    Private Sub OriginalImageOpenButton_Click(sender As Object, e As EventArgs) Handles OriginalImageOpenButton.Click

        OriginalImage = New Bitmap(OriginalImageUrl.Text)

        OriginalImagePictureBox.ClientSize = New Size(OriginalImagePanel.Size)
        OriginalImagePictureBox.Image = CType(OriginalImage, Image)
        OriginalImagePictureBox.Show()

    End Sub
End Class
