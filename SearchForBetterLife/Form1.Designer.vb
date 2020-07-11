<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderName = New System.Windows.Forms.TextBox()
        Me.SelectFolderButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.CustomerName = New System.Windows.Forms.ComboBox()
        Me.ProjectName = New System.Windows.Forms.ComboBox()
        Me.TypeName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FileExtension = New System.Windows.Forms.ComboBox()
        Me.PartNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PartName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(430, 64)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(121, 65)
        Me.SearchButton.TabIndex = 0
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'FolderName
        '
        Me.FolderName.Enabled = False
        Me.FolderName.Location = New System.Drawing.Point(15, 13)
        Me.FolderName.Name = "FolderName"
        Me.FolderName.Size = New System.Drawing.Size(121, 20)
        Me.FolderName.TabIndex = 6
        '
        'SelectFolderButton
        '
        Me.SelectFolderButton.Location = New System.Drawing.Point(146, 13)
        Me.SelectFolderButton.Name = "SelectFolderButton"
        Me.SelectFolderButton.Size = New System.Drawing.Size(122, 23)
        Me.SelectFolderButton.TabIndex = 7
        Me.SelectFolderButton.Text = "Select Folder"
        Me.SelectFolderButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Project"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Extension"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(13, 145)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(691, 171)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.WordWrap = False
        '
        'CustomerName
        '
        Me.CustomerName.FormattingEnabled = True
        Me.CustomerName.Location = New System.Drawing.Point(15, 63)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(121, 21)
        Me.CustomerName.TabIndex = 13
        '
        'ProjectName
        '
        Me.ProjectName.FormattingEnabled = True
        Me.ProjectName.Location = New System.Drawing.Point(146, 63)
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.Size = New System.Drawing.Size(121, 21)
        Me.ProjectName.TabIndex = 14
        '
        'TypeName
        '
        Me.TypeName.FormattingEnabled = True
        Me.TypeName.Location = New System.Drawing.Point(281, 63)
        Me.TypeName.Name = "TypeName"
        Me.TypeName.Size = New System.Drawing.Size(121, 21)
        Me.TypeName.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(278, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Doc Type"
        '
        'FileExtension
        '
        Me.FileExtension.FormattingEnabled = True
        Me.FileExtension.Location = New System.Drawing.Point(281, 108)
        Me.FileExtension.Name = "FileExtension"
        Me.FileExtension.Size = New System.Drawing.Size(121, 21)
        Me.FileExtension.TabIndex = 17
        '
        'PartNumber
        '
        Me.PartNumber.Location = New System.Drawing.Point(13, 108)
        Me.PartNumber.Name = "PartNumber"
        Me.PartNumber.Size = New System.Drawing.Size(123, 20)
        Me.PartNumber.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Part Number"
        '
        'PartName
        '
        Me.PartName.Location = New System.Drawing.Point(146, 107)
        Me.PartName.Name = "PartName"
        Me.PartName.Size = New System.Drawing.Size(121, 20)
        Me.PartName.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(145, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Part Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 328)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PartName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PartNumber)
        Me.Controls.Add(Me.FileExtension)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TypeName)
        Me.Controls.Add(Me.ProjectName)
        Me.Controls.Add(Me.CustomerName)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SelectFolderButton)
        Me.Controls.Add(Me.FolderName)
        Me.Controls.Add(Me.SearchButton)
        Me.MinimumSize = New System.Drawing.Size(550, 343)
        Me.Name = "Form1"
        Me.Text = "Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchButton As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FolderName As TextBox
    Friend WithEvents SelectFolderButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents CustomerName As ComboBox
    Friend WithEvents ProjectName As ComboBox
    Friend WithEvents TypeName As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FileExtension As ComboBox
    Friend WithEvents PartNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PartName As TextBox
    Friend WithEvents Label6 As Label
End Class
