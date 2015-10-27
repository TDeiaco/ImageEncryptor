<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageEncryptorForm
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
        Me.MainWindowTablePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.EncryptedImageFooterPanel = New System.Windows.Forms.Panel()
        Me.EncryptedImageSaveLocation = New System.Windows.Forms.Label()
        Me.EncrypedImageSaveLocationBrowseButton = New System.Windows.Forms.Button()
        Me.EncryptedImageUrl = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShowEncryptedLocationsCheckbox = New System.Windows.Forms.CheckBox()
        Me.OriginalImagePanel = New System.Windows.Forms.Panel()
        Me.OriginalImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.EncryptedImagePanel = New System.Windows.Forms.Panel()
        Me.EncryptedImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.ToolbarPanel = New System.Windows.Forms.Panel()
        Me.EncryptedMessageTextBox = New System.Windows.Forms.TextBox()
        Me.EmbedMessageButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OriginalImageOpenButton = New System.Windows.Forms.Button()
        Me.OriginalImageLocationLabel = New System.Windows.Forms.Label()
        Me.OriginalImageLocationButton = New System.Windows.Forms.Button()
        Me.OriginalImageUrl = New System.Windows.Forms.TextBox()
        Me.MainWindowTablePanel.SuspendLayout()
        Me.EncryptedImageFooterPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.OriginalImagePanel.SuspendLayout()
        CType(Me.OriginalImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EncryptedImagePanel.SuspendLayout()
        CType(Me.EncryptedImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolbarPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainWindowTablePanel
        '
        Me.MainWindowTablePanel.BackColor = System.Drawing.Color.Silver
        Me.MainWindowTablePanel.ColumnCount = 3
        Me.MainWindowTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.17368!))
        Me.MainWindowTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.28648!))
        Me.MainWindowTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.62936!))
        Me.MainWindowTablePanel.Controls.Add(Me.EncryptedImageFooterPanel, 1, 1)
        Me.MainWindowTablePanel.Controls.Add(Me.Panel1, 0, 1)
        Me.MainWindowTablePanel.Controls.Add(Me.OriginalImagePanel, 2, 0)
        Me.MainWindowTablePanel.Controls.Add(Me.EncryptedImagePanel, 1, 0)
        Me.MainWindowTablePanel.Controls.Add(Me.ToolbarPanel, 0, 0)
        Me.MainWindowTablePanel.Controls.Add(Me.Panel2, 2, 1)
        Me.MainWindowTablePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainWindowTablePanel.Location = New System.Drawing.Point(0, 0)
        Me.MainWindowTablePanel.Margin = New System.Windows.Forms.Padding(10)
        Me.MainWindowTablePanel.Name = "MainWindowTablePanel"
        Me.MainWindowTablePanel.RowCount = 2
        Me.MainWindowTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.50728!))
        Me.MainWindowTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.49272!))
        Me.MainWindowTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MainWindowTablePanel.Size = New System.Drawing.Size(1117, 481)
        Me.MainWindowTablePanel.TabIndex = 0
        '
        'EncryptedImageFooterPanel
        '
        Me.EncryptedImageFooterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EncryptedImageFooterPanel.Controls.Add(Me.EncryptedImageSaveLocation)
        Me.EncryptedImageFooterPanel.Controls.Add(Me.EncrypedImageSaveLocationBrowseButton)
        Me.EncryptedImageFooterPanel.Controls.Add(Me.EncryptedImageUrl)
        Me.EncryptedImageFooterPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EncryptedImageFooterPanel.Location = New System.Drawing.Point(202, 368)
        Me.EncryptedImageFooterPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.EncryptedImageFooterPanel.Name = "EncryptedImageFooterPanel"
        Me.EncryptedImageFooterPanel.Size = New System.Drawing.Size(449, 113)
        Me.EncryptedImageFooterPanel.TabIndex = 4
        '
        'EncryptedImageSaveLocation
        '
        Me.EncryptedImageSaveLocation.AutoSize = True
        Me.EncryptedImageSaveLocation.Location = New System.Drawing.Point(10, 10)
        Me.EncryptedImageSaveLocation.Margin = New System.Windows.Forms.Padding(10)
        Me.EncryptedImageSaveLocation.Name = "EncryptedImageSaveLocation"
        Me.EncryptedImageSaveLocation.Size = New System.Drawing.Size(159, 13)
        Me.EncryptedImageSaveLocation.TabIndex = 2
        Me.EncryptedImageSaveLocation.Text = "Encrypted Image Save Location"
        '
        'EncrypedImageSaveLocationBrowseButton
        '
        Me.EncrypedImageSaveLocationBrowseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EncrypedImageSaveLocationBrowseButton.Location = New System.Drawing.Point(364, 63)
        Me.EncrypedImageSaveLocationBrowseButton.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.EncrypedImageSaveLocationBrowseButton.Name = "EncrypedImageSaveLocationBrowseButton"
        Me.EncrypedImageSaveLocationBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.EncrypedImageSaveLocationBrowseButton.TabIndex = 1
        Me.EncrypedImageSaveLocationBrowseButton.Text = "Browse"
        Me.EncrypedImageSaveLocationBrowseButton.UseVisualStyleBackColor = True
        '
        'EncryptedImageUrl
        '
        Me.EncryptedImageUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EncryptedImageUrl.Location = New System.Drawing.Point(10, 33)
        Me.EncryptedImageUrl.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.EncryptedImageUrl.Name = "EncryptedImageUrl"
        Me.EncryptedImageUrl.Size = New System.Drawing.Size(429, 20)
        Me.EncryptedImageUrl.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ShowEncryptedLocationsCheckbox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 368)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 113)
        Me.Panel1.TabIndex = 3
        '
        'ShowEncryptedLocationsCheckbox
        '
        Me.ShowEncryptedLocationsCheckbox.AutoSize = True
        Me.ShowEncryptedLocationsCheckbox.Location = New System.Drawing.Point(12, 10)
        Me.ShowEncryptedLocationsCheckbox.Name = "ShowEncryptedLocationsCheckbox"
        Me.ShowEncryptedLocationsCheckbox.Size = New System.Drawing.Size(153, 17)
        Me.ShowEncryptedLocationsCheckbox.TabIndex = 0
        Me.ShowEncryptedLocationsCheckbox.Text = "Show Encrypted Locations"
        Me.ShowEncryptedLocationsCheckbox.UseVisualStyleBackColor = True
        '
        'OriginalImagePanel
        '
        Me.OriginalImagePanel.Controls.Add(Me.OriginalImagePictureBox)
        Me.OriginalImagePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OriginalImagePanel.Location = New System.Drawing.Point(651, 0)
        Me.OriginalImagePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.OriginalImagePanel.Name = "OriginalImagePanel"
        Me.OriginalImagePanel.Size = New System.Drawing.Size(466, 368)
        Me.OriginalImagePanel.TabIndex = 2
        '
        'OriginalImagePictureBox
        '
        Me.OriginalImagePictureBox.BackColor = System.Drawing.Color.Silver
        Me.OriginalImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OriginalImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OriginalImagePictureBox.Location = New System.Drawing.Point(0, 0)
        Me.OriginalImagePictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.OriginalImagePictureBox.Name = "OriginalImagePictureBox"
        Me.OriginalImagePictureBox.Size = New System.Drawing.Size(466, 368)
        Me.OriginalImagePictureBox.TabIndex = 0
        Me.OriginalImagePictureBox.TabStop = False
        '
        'EncryptedImagePanel
        '
        Me.EncryptedImagePanel.Controls.Add(Me.EncryptedImagePictureBox)
        Me.EncryptedImagePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EncryptedImagePanel.Location = New System.Drawing.Point(202, 0)
        Me.EncryptedImagePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.EncryptedImagePanel.Name = "EncryptedImagePanel"
        Me.EncryptedImagePanel.Size = New System.Drawing.Size(449, 368)
        Me.EncryptedImagePanel.TabIndex = 1
        '
        'EncryptedImagePictureBox
        '
        Me.EncryptedImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EncryptedImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EncryptedImagePictureBox.Location = New System.Drawing.Point(0, 0)
        Me.EncryptedImagePictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.EncryptedImagePictureBox.Name = "EncryptedImagePictureBox"
        Me.EncryptedImagePictureBox.Size = New System.Drawing.Size(449, 368)
        Me.EncryptedImagePictureBox.TabIndex = 0
        Me.EncryptedImagePictureBox.TabStop = False
        '
        'ToolbarPanel
        '
        Me.ToolbarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolbarPanel.Controls.Add(Me.EncryptedMessageTextBox)
        Me.ToolbarPanel.Controls.Add(Me.EmbedMessageButton)
        Me.ToolbarPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolbarPanel.Location = New System.Drawing.Point(0, 0)
        Me.ToolbarPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolbarPanel.Name = "ToolbarPanel"
        Me.ToolbarPanel.Size = New System.Drawing.Size(202, 368)
        Me.ToolbarPanel.TabIndex = 0
        '
        'EncryptedMessageTextBox
        '
        Me.EncryptedMessageTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EncryptedMessageTextBox.Location = New System.Drawing.Point(11, 40)
        Me.EncryptedMessageTextBox.Margin = New System.Windows.Forms.Padding(10)
        Me.EncryptedMessageTextBox.Multiline = True
        Me.EncryptedMessageTextBox.Name = "EncryptedMessageTextBox"
        Me.EncryptedMessageTextBox.Size = New System.Drawing.Size(179, 317)
        Me.EncryptedMessageTextBox.TabIndex = 1
        '
        'EmbedMessageButton
        '
        Me.EmbedMessageButton.Location = New System.Drawing.Point(12, 12)
        Me.EmbedMessageButton.Name = "EmbedMessageButton"
        Me.EmbedMessageButton.Size = New System.Drawing.Size(75, 23)
        Me.EmbedMessageButton.TabIndex = 0
        Me.EmbedMessageButton.Text = "Embed "
        Me.EmbedMessageButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.OriginalImageOpenButton)
        Me.Panel2.Controls.Add(Me.OriginalImageLocationLabel)
        Me.Panel2.Controls.Add(Me.OriginalImageLocationButton)
        Me.Panel2.Controls.Add(Me.OriginalImageUrl)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(651, 368)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(466, 113)
        Me.Panel2.TabIndex = 5
        '
        'OriginalImageOpenButton
        '
        Me.OriginalImageOpenButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OriginalImageOpenButton.Location = New System.Drawing.Point(277, 63)
        Me.OriginalImageOpenButton.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.OriginalImageOpenButton.Name = "OriginalImageOpenButton"
        Me.OriginalImageOpenButton.Size = New System.Drawing.Size(75, 23)
        Me.OriginalImageOpenButton.TabIndex = 6
        Me.OriginalImageOpenButton.Text = "Open"
        Me.OriginalImageOpenButton.UseVisualStyleBackColor = True
        '
        'OriginalImageLocationLabel
        '
        Me.OriginalImageLocationLabel.AutoSize = True
        Me.OriginalImageLocationLabel.Location = New System.Drawing.Point(15, 10)
        Me.OriginalImageLocationLabel.Margin = New System.Windows.Forms.Padding(10)
        Me.OriginalImageLocationLabel.Name = "OriginalImageLocationLabel"
        Me.OriginalImageLocationLabel.Size = New System.Drawing.Size(118, 13)
        Me.OriginalImageLocationLabel.TabIndex = 5
        Me.OriginalImageLocationLabel.Text = "Original Image Location"
        '
        'OriginalImageLocationButton
        '
        Me.OriginalImageLocationButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OriginalImageLocationButton.Location = New System.Drawing.Point(372, 63)
        Me.OriginalImageLocationButton.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.OriginalImageLocationButton.Name = "OriginalImageLocationButton"
        Me.OriginalImageLocationButton.Size = New System.Drawing.Size(75, 23)
        Me.OriginalImageLocationButton.TabIndex = 4
        Me.OriginalImageLocationButton.Text = "Browse"
        Me.OriginalImageLocationButton.UseVisualStyleBackColor = True
        '
        'OriginalImageUrl
        '
        Me.OriginalImageUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OriginalImageUrl.Location = New System.Drawing.Point(18, 33)
        Me.OriginalImageUrl.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.OriginalImageUrl.Name = "OriginalImageUrl"
        Me.OriginalImageUrl.Size = New System.Drawing.Size(429, 20)
        Me.OriginalImageUrl.TabIndex = 3
        '
        'ImageEncryptorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 481)
        Me.Controls.Add(Me.MainWindowTablePanel)
        Me.Name = "ImageEncryptorForm"
        Me.Text = "Image Encryptor"
        Me.MainWindowTablePanel.ResumeLayout(False)
        Me.EncryptedImageFooterPanel.ResumeLayout(False)
        Me.EncryptedImageFooterPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.OriginalImagePanel.ResumeLayout(False)
        CType(Me.OriginalImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EncryptedImagePanel.ResumeLayout(False)
        CType(Me.EncryptedImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolbarPanel.ResumeLayout(False)
        Me.ToolbarPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainWindowTablePanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OriginalImagePanel As System.Windows.Forms.Panel
    Friend WithEvents ToolbarPanel As System.Windows.Forms.Panel
    Friend WithEvents OriginalImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents EncryptedImageFooterPanel As System.Windows.Forms.Panel
    Friend WithEvents EncrypedImageSaveLocationBrowseButton As System.Windows.Forms.Button
    Friend WithEvents EncryptedImageUrl As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EncryptedImagePanel As System.Windows.Forms.Panel
    Friend WithEvents EncryptedMessageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmbedMessageButton As System.Windows.Forms.Button
    Friend WithEvents EncryptedImageSaveLocation As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents OriginalImageLocationLabel As System.Windows.Forms.Label
    Friend WithEvents OriginalImageLocationButton As System.Windows.Forms.Button
    Friend WithEvents OriginalImageUrl As System.Windows.Forms.TextBox
    Friend WithEvents OriginalImageOpenButton As System.Windows.Forms.Button
    Friend WithEvents EncryptedImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ShowEncryptedLocationsCheckbox As System.Windows.Forms.CheckBox

End Class
