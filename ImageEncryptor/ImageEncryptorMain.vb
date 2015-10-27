

Public Class ImageEncryptorForm


    Private encrypt As ImgEncryptor

    Private MyImage As Bitmap

    'These refer to the distance between embedded pixels\in the X and Y direction

    Private EmbedDistanceX As Integer
    Private EmbedDistanceY As Integer

    'Storage for the original and encrypted images
    Private OriginalImage As Bitmap
    Private EmbeddedImage As Bitmap

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

        encrypt = New ImgEncryptor()

        OriginalImageUrl.Text = "C:\Users\Taylor\Pictures\Standing By.jpg"

        EncryptedMessageTextBox.Text = "This is the secret message!"
    End Sub

    Private Sub EmbedMessageButton_Click(sender As Object, e As EventArgs) Handles EmbedMessageButton.Click

        EmbeddedImage = encrypt.EncryptImage(EncryptedMessageTextBox.Text, OriginalImage, OriginalImagePictureBox, ShowEncryptedLocationsCheckbox.Checked)


        EncryptedImagePictureBox.ClientSize = New Size(EncryptedImagePanel.Size)
        EncryptedImagePictureBox.Image = CType(EmbeddedImage, Image)
        EncryptedImagePictureBox.Show()

    End Sub

    Private Sub OriginalImageOpenButton_Click(sender As Object, e As EventArgs) Handles OriginalImageOpenButton.Click

        OriginalImage = New Bitmap(OriginalImageUrl.Text)

        OriginalImagePictureBox.ClientSize = New Size(OriginalImagePanel.Size)
        OriginalImagePictureBox.Image = CType(OriginalImage, Image)
        OriginalImagePictureBox.Show()

    End Sub

    Private Sub OriginalImageLocationButton_Click(sender As Object, e As EventArgs) Handles OriginalImageLocationButton.Click

        Dim message As String = encrypt.DecryptImage(EmbeddedImage)

        MessageBox.Show(message)

    End Sub
End Class
