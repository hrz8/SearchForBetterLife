Option Strict On
Imports System.IO

Public Class Form1
	Private resultPath As New List(Of String)
	Private programPath As String
	Private sec As Double

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		programPath = My.Application.Info.DirectoryPath
		sec = 0.0
		CustomerName.Items.AddRange(File.ReadAllLines(programPath & "\customers.txt"))
		ProjectName.Items.AddRange(File.ReadAllLines(programPath & "\projects.txt"))
		TypeName.Items.AddRange(File.ReadAllLines(programPath & "\types.txt"))
		FileExtension.Items.AddRange(File.ReadAllLines(programPath & "\extensions.txt"))
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
			resultPath.Add("file://" & dirItem)
			Dim currLen As Integer = Len(RichTextBox1.Text)
			RichTextBox1.SelectionFont = New Font("Microsoft Sans Serif", 12)
			RichTextBox1.SelectionStart = currLen
			Dim catchedFileName As String = dirItem.Substring(dirItem.LastIndexOf("/") + 1)
			RichTextBox1.AppendText(catchedFileName & vbNewLine)
			RichTextBox1.SelectionLength = Len(catchedFileName)
			RichTextBox1.AppendText("""file://" & dirItem & """" & vbNewLine & vbNewLine)
			RichTextBox1.SelectionStart = Len(RichTextBox1.Text)
			RichTextBox1.ScrollToCaret()
			RichTextBox1.Select()
			i += 1
		Next
		Return i
	End Function

	Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
		If FolderName.Text IsNot "" Then
			RichTextBox1.Text = ""
			SearchButton.Enabled = False
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

	Private Sub RichTextBox1_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles RichTextBox1.LinkClicked
		Process.Start(New Uri(e.LinkText, True).AbsolutePath)
	End Sub
End Class
