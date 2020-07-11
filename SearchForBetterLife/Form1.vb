Option Strict On
Imports System.IO

Public Class Form1
	Private resultPath As New List(Of String)

	Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
		Try
			For Each dirItemTemp In Directory.GetFileSystemEntries(FolderName.Text, "*." & FileExtension.Text, SearchOption.AllDirectories) _
					.Where(Function(file) file.IndexOf(ProjectName.Text, 0, StringComparison.CurrentCultureIgnoreCase) > -1 _
										  AndAlso file.IndexOf(CustomerName.Text, 0, StringComparison.CurrentCultureIgnoreCase) > -1) _
					.ToList()
				Dim dirItem As String = dirItemTemp.Replace("\", "/")
				resultPath.Add("file://" & dirItem)
				RichTextBox1.AppendText("""file://" & dirItem & """" & vbNewLine & vbNewLine)
				RichTextBox1.SelectionStart = Len(RichTextBox1.Text)
				RichTextBox1.ScrollToCaret()
				RichTextBox1.Select()
			Next
		Catch err As UnauthorizedAccessException
			MsgBox(err)
		End Try
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
