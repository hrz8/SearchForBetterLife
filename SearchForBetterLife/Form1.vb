Option Strict On
Imports System.IO

Public Class Form1
	Private programPath As String

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		programPath = My.Application.Info.DirectoryPath
		CustomerName.Items.AddRange(File.ReadAllLines(programPath & "\customers.txt"))
		ProjectName.Items.AddRange(File.ReadAllLines(programPath & "\projects.txt"))
		TypeName.Items.AddRange(File.ReadAllLines(programPath & "\types.txt"))
		FileExtension.Items.AddRange(File.ReadAllLines(programPath & "\extensions.txt"))
		'init data grid
		Dim fileName As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
		fileName.DataPropertyName = "File Name"
		fileName.Name = "File Name"
		DataGridView1.Columns.Add(fileName)
		Dim loc As DataGridViewLinkColumn = New DataGridViewLinkColumn()
		loc.DataPropertyName = "Location"
		loc.Name = "Location"
		DataGridView1.Columns.Add(loc)
		Dim crt As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
		crt.DataPropertyName = "Created At"
		crt.Name = "Created At"
		DataGridView1.Columns.Add(crt)
		Dim upd As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
		upd.DataPropertyName = "Updated At"
		upd.Name = "Updated At"
		DataGridView1.Columns.Add(upd)
	End Sub

	Private Function GetTheFiles() As Integer
		Dim i As Integer = 0
		Dim varFileExt As String = If(FileExtension.Text Is "", "*", FileExtension.SelectedItem.ToString)
		For Each dirItemTemp In Directory.EnumerateFiles(FolderName.Text, "*." & varFileExt, SearchOption.AllDirectories) _
				.Where(Function(file) file.IndexOf(If(ProjectName.SelectedItem Is Nothing, "", ProjectName.SelectedItem.ToString), 0, StringComparison.CurrentCultureIgnoreCase) > -1 _
									  And file.IndexOf(If(CustomerName.SelectedItem Is Nothing, "", CustomerName.SelectedItem.ToString), 0, StringComparison.CurrentCultureIgnoreCase) > -1 _
									  And file.IndexOf(If(TypeName.SelectedItem Is Nothing, "", TypeName.SelectedItem.ToString), 0, StringComparison.CurrentCultureIgnoreCase) > -1 _
									  And file.IndexOf(PartNumber.Text, 0, StringComparison.CurrentCultureIgnoreCase) > -1 _
									  And file.IndexOf(PartName.Text, 0, StringComparison.CurrentCultureIgnoreCase) > -1) _
				.ToList()
			Dim dirItem As String = dirItemTemp.Replace("\", "/")
			Dim catchedFileName As String = dirItem.Substring(dirItem.LastIndexOf("/") + 1)
			Dim itemInfo As New FileInfo(dirItem)
			Dim createdAt As String = itemInfo.CreationTime.ToString("dd/MM/yyyy hh:mm:ss")
			Dim updatedAt As String = itemInfo.LastWriteTime.ToString("dd/MM/yyyy hh:mm:ss")
			DataGridView1.Rows.Add(catchedFileName, "file://" & dirItem, createdAt, updatedAt)
			i += 1
		Next
		Return i
	End Function

	Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
		If FolderName.Text IsNot "" Then
			SearchButton.Enabled = False
			DataGridView1.Rows.Clear()
			SearchButton.Text = "Searching..."
			Try
				Dim total As Integer = GetTheFiles()
				SearchButton.Text = "Search"
				If total = 0 Then
					MsgBox("not found")
				Else
					MsgBox("found " & total & " item(s)")
				End If
			Catch err As UnauthorizedAccessException
				SearchButton.Text = "Search"
				MsgBox(err.Message)
			End Try
			SearchButton.Enabled = True
		Else
			MsgBox("select path")
		End If
	End Sub

	Private Sub SelectFolderButton_Click(sender As Object, e As EventArgs) Handles SelectFolderButton.Click
		If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
			FolderName.Text = FolderBrowserDialog1.SelectedPath
		End If
	End Sub


	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
		If e.ColumnIndex = 1 Then
			Process.Start(New Uri(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString(), True).AbsolutePath)
		End If
	End Sub
End Class
