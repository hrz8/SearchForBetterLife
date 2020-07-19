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
        Me.components = New System.ComponentModel.Container()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.FolderName = New System.Windows.Forms.TextBox()
        Me.SelectFolderButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CustomerName = New System.Windows.Forms.ComboBox()
        Me.ProjectName = New System.Windows.Forms.ComboBox()
        Me.TypeName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FileExtension = New System.Windows.Forms.ComboBox()
        Me.PartNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PartName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomersDataRTB = New System.Windows.Forms.RichTextBox()
        Me.SaveCustomer = New System.Windows.Forms.Button()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.SaveProject = New System.Windows.Forms.Button()
        Me.ProjectsDataRTB = New System.Windows.Forms.RichTextBox()
        Me.DocTypeDataRTB = New System.Windows.Forms.RichTextBox()
        Me.ExtensionDataRTB = New System.Windows.Forms.RichTextBox()
        Me.SaveDocType = New System.Windows.Forms.Button()
        Me.SaveExtension = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(422, 64)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(121, 65)
        Me.SearchButton.TabIndex = 8
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'FolderName
        '
        Me.FolderName.Enabled = False
        Me.FolderName.Location = New System.Drawing.Point(15, 13)
        Me.FolderName.Name = "FolderName"
        Me.FolderName.Size = New System.Drawing.Size(121, 20)
        Me.FolderName.TabIndex = 0
        '
        'SelectFolderButton
        '
        Me.SelectFolderButton.Location = New System.Drawing.Point(146, 13)
        Me.SelectFolderButton.Name = "SelectFolderButton"
        Me.SelectFolderButton.Size = New System.Drawing.Size(122, 23)
        Me.SelectFolderButton.TabIndex = 1
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
        'CustomerName
        '
        Me.CustomerName.FormattingEnabled = True
        Me.CustomerName.Location = New System.Drawing.Point(15, 63)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(121, 21)
        Me.CustomerName.TabIndex = 2
        '
        'ProjectName
        '
        Me.ProjectName.FormattingEnabled = True
        Me.ProjectName.Location = New System.Drawing.Point(146, 63)
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.Size = New System.Drawing.Size(121, 21)
        Me.ProjectName.TabIndex = 3
        '
        'TypeName
        '
        Me.TypeName.FormattingEnabled = True
        Me.TypeName.Location = New System.Drawing.Point(281, 63)
        Me.TypeName.Name = "TypeName"
        Me.TypeName.Size = New System.Drawing.Size(121, 21)
        Me.TypeName.TabIndex = 4
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
        Me.FileExtension.TabIndex = 7
        '
        'PartNumber
        '
        Me.PartNumber.Location = New System.Drawing.Point(15, 108)
        Me.PartNumber.Name = "PartNumber"
        Me.PartNumber.Size = New System.Drawing.Size(121, 20)
        Me.PartNumber.TabIndex = 5
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
        Me.PartName.TabIndex = 6
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
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 154)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(528, 141)
        Me.DataGridView1.TabIndex = 9
        '
        'CustomersDataRTB
        '
        Me.CustomersDataRTB.Location = New System.Drawing.Point(15, 310)
        Me.CustomersDataRTB.Name = "CustomersDataRTB"
        Me.CustomersDataRTB.Size = New System.Drawing.Size(121, 96)
        Me.CustomersDataRTB.TabIndex = 22
        Me.CustomersDataRTB.Text = ""
        '
        'SaveCustomer
        '
        Me.SaveCustomer.Location = New System.Drawing.Point(15, 412)
        Me.SaveCustomer.Name = "SaveCustomer"
        Me.SaveCustomer.Size = New System.Drawing.Size(121, 23)
        Me.SaveCustomer.TabIndex = 23
        Me.SaveCustomer.Text = "Save Customers"
        Me.SaveCustomer.UseVisualStyleBackColor = True
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(468, 10)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(75, 23)
        Me.Refresh.TabIndex = 24
        Me.Refresh.Text = "Refresh"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'SaveProject
        '
        Me.SaveProject.Location = New System.Drawing.Point(151, 413)
        Me.SaveProject.Name = "SaveProject"
        Me.SaveProject.Size = New System.Drawing.Size(121, 23)
        Me.SaveProject.TabIndex = 25
        Me.SaveProject.Text = "Save Projects"
        Me.SaveProject.UseVisualStyleBackColor = True
        '
        'ProjectsDataRTB
        '
        Me.ProjectsDataRTB.Location = New System.Drawing.Point(152, 310)
        Me.ProjectsDataRTB.Name = "ProjectsDataRTB"
        Me.ProjectsDataRTB.Size = New System.Drawing.Size(121, 96)
        Me.ProjectsDataRTB.TabIndex = 26
        Me.ProjectsDataRTB.Text = ""
        '
        'DocTypeDataRTB
        '
        Me.DocTypeDataRTB.Location = New System.Drawing.Point(289, 310)
        Me.DocTypeDataRTB.Name = "DocTypeDataRTB"
        Me.DocTypeDataRTB.Size = New System.Drawing.Size(121, 96)
        Me.DocTypeDataRTB.TabIndex = 27
        Me.DocTypeDataRTB.Text = ""
        '
        'ExtensionDataRTB
        '
        Me.ExtensionDataRTB.Location = New System.Drawing.Point(422, 310)
        Me.ExtensionDataRTB.Name = "ExtensionDataRTB"
        Me.ExtensionDataRTB.Size = New System.Drawing.Size(121, 96)
        Me.ExtensionDataRTB.TabIndex = 28
        Me.ExtensionDataRTB.Text = ""
        '
        'SaveDocType
        '
        Me.SaveDocType.Location = New System.Drawing.Point(289, 411)
        Me.SaveDocType.Name = "SaveDocType"
        Me.SaveDocType.Size = New System.Drawing.Size(121, 23)
        Me.SaveDocType.TabIndex = 29
        Me.SaveDocType.Text = "Save Doc Type"
        Me.SaveDocType.UseVisualStyleBackColor = True
        '
        'SaveExtension
        '
        Me.SaveExtension.Location = New System.Drawing.Point(422, 411)
        Me.SaveExtension.Name = "SaveExtension"
        Me.SaveExtension.Size = New System.Drawing.Size(121, 23)
        Me.SaveExtension.TabIndex = 30
        Me.SaveExtension.Text = "Save Extension"
        Me.SaveExtension.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 451)
        Me.Controls.Add(Me.SaveExtension)
        Me.Controls.Add(Me.SaveDocType)
        Me.Controls.Add(Me.ExtensionDataRTB)
        Me.Controls.Add(Me.DocTypeDataRTB)
        Me.Controls.Add(Me.ProjectsDataRTB)
        Me.Controls.Add(Me.SaveProject)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.SaveCustomer)
        Me.Controls.Add(Me.CustomersDataRTB)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PartName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PartNumber)
        Me.Controls.Add(Me.FileExtension)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TypeName)
        Me.Controls.Add(Me.ProjectName)
        Me.Controls.Add(Me.CustomerName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SelectFolderButton)
        Me.Controls.Add(Me.FolderName)
        Me.Controls.Add(Me.SearchButton)
        Me.MinimumSize = New System.Drawing.Size(571, 392)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchButton As Button
    Friend WithEvents FolderName As TextBox
    Friend WithEvents SelectFolderButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CustomerName As ComboBox
    Friend WithEvents ProjectName As ComboBox
    Friend WithEvents TypeName As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FileExtension As ComboBox
    Friend WithEvents PartNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PartName As TextBox
    Friend WithEvents Label6 As Label
    Private WithEvents Timer1 As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CustomersDataRTB As RichTextBox
    Friend WithEvents SaveCustomer As Button
    Friend WithEvents Refresh As Button
    Friend WithEvents SaveProject As Button
    Friend WithEvents ProjectsDataRTB As RichTextBox
    Friend WithEvents DocTypeDataRTB As RichTextBox
    Friend WithEvents ExtensionDataRTB As RichTextBox
    Friend WithEvents SaveDocType As Button
    Friend WithEvents SaveExtension As Button
End Class
