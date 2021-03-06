﻿Option Strict On
Imports System.IO
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports System.Threading
Imports FastDirectory

Public Class Form1
    Private programPath As String
    Private total As Integer
    Private dir As DirectoryInfo
    Private t As New Thread(AddressOf ThreadQ)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
        StopButton.Enabled = False

        'FolderName.Text = "\\wsl$\Ubuntu-18.04\home\hirzi\repos"
        programPath = My.Application.Info.DirectoryPath
        CustomerName.Items.AddRange(File.ReadAllLines(programPath & "\customers.txt"))
        ProjectName.Items.AddRange(File.ReadAllLines(programPath & "\projects.txt"))
        TypeName.Items.AddRange(File.ReadAllLines(programPath & "\types.txt"))
        FileExtension.Items.AddRange(File.ReadAllLines(programPath & "\extensions.txt"))
        'txt data
        CustomersDataRTB.Text = File.ReadAllText(programPath & "\customers.txt")
        ProjectsDataRTB.Text = File.ReadAllText(programPath & "\projects.txt")
        DocTypeDataRTB.Text = File.ReadAllText(programPath & "\types.txt")
        ExtensionDataRTB.Text = File.ReadAllText(programPath & "\extensions.txt")
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

    Private Sub GetTheFiles(dirIn As DirectoryInfo)
        Dim varFileExt As String = If(FileExtension.Text Is "", "*", FileExtension.SelectedItem.ToString())
        Dim projName As String = If(ProjectName.SelectedItem Is Nothing, "", ProjectName.SelectedItem.ToString())
        Dim custName As String = If(CustomerName.SelectedItem Is Nothing, "", CustomerName.SelectedItem.ToString())
        Dim typName As String = If(TypeName.SelectedItem Is Nothing, "", TypeName.SelectedItem.ToString)
        Dim pattern As String = "(?=.*" & projName & ")(?=.*" & custName & ")(?=.*" & typName & ")(?=.*" & PartNumber.Text & ")(?=.*" & PartName.Text & ").*." & varFileExt

        For Each dirItem In FastDirectoryEnumerator.EnumerateFiles(dirIn.FullName, "*." & varFileExt).AsParallel() _
                .Where(Function(path) Regex.IsMatch(path.Path, pattern, RegexOptions.IgnoreCase)) _
                .ToList()
            Dim itemInfo As New FileInfo(dirItem.Path)
            DataGridView1.Rows.Add(
                itemInfo.Name,
                itemInfo.DirectoryName,
                itemInfo.CreationTime.ToString("dd/MM/yyyy hh:mm:ss"),
                itemInfo.LastWriteTime.ToString("dd/MM/yyyy hh:mm:ss")
            )
            total += 1
        Next

        For Each d In dirIn.EnumerateDirectories("*" & projName & "*").AsParallel()
            GetTheFiles(d)
        Next
    End Sub

    Private Sub ThreadQ()
        dir = New DirectoryInfo(FolderName.Text)
        total = 0
        SearchButton.Enabled = False
        StopButton.Enabled = True
        DataGridView1.Rows.Clear()
        SearchButton.Text = "Searching..."
        GetTheFiles(dir)
        SearchButton.Text = "Search"
        SearchButton.Enabled = True
        StopButton.Enabled = False
        If total = 0 Then
            MsgBox("not found")
        Else
            MsgBox("found " & total & " item(s)")
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If FolderName.Text IsNot "" Then
            Try
                t = Nothing
                t = New Thread(AddressOf ThreadQ)
                t.IsBackground = True
                t.Start()
            Catch err As UnauthorizedAccessException
                SearchButton.Enabled = True
                SearchButton.Text = "Search"
                MsgBox(err.Message)
            End Try
        Else
            MsgBox("select path")
        End If
    End Sub

    Private Sub SelectFolderButton_Click(sender As Object, e As EventArgs) Handles SelectFolderButton.Click
        Dim objFolderDialog As New FolderBrowserDialog()
        FolderName.Text = GetNetworkFolders(objFolderDialog)
    End Sub

    Public Shared Function GetNetworkFolders(ByVal oFolderBrowserDialog As FolderBrowserDialog) As String
        Dim type As Type = oFolderBrowserDialog.[GetType]
        Dim fieldInfo As FieldInfo = type.GetField("rootFolder", BindingFlags.NonPublic Or BindingFlags.Instance)
        'fieldInfo.SetValue(oFolderBrowserDialog, DirectCast(1, Environment.SpecialFolder))
        If oFolderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Return oFolderBrowserDialog.SelectedPath
        End If
        Return ""
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 1 Then
            Dim loc As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            Process.Start(loc)
        End If
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        CustomerName.Items.Clear()
        CustomerName.Items.AddRange(File.ReadAllLines(programPath & "\customers.txt"))
        ProjectName.Items.Clear()
        ProjectName.Items.AddRange(File.ReadAllLines(programPath & "\projects.txt"))
        TypeName.Items.Clear()
        TypeName.Items.AddRange(File.ReadAllLines(programPath & "\types.txt"))
        FileExtension.Items.Clear()
        FileExtension.Items.AddRange(File.ReadAllLines(programPath & "\extensions.txt"))
    End Sub

    Private Sub SaveCustomer_Click(sender As Object, e As EventArgs) Handles SaveCustomer.Click
        File.WriteAllText(programPath & "/customers.txt", CustomersDataRTB.Text)
        MsgBox("customer updated!")
    End Sub

    Private Sub SaveProject_Click(sender As Object, e As EventArgs) Handles SaveProject.Click
        File.WriteAllText(programPath & "/projects.txt", ProjectsDataRTB.Text)
        MsgBox("project updated!")
    End Sub

    Private Sub SaveDocType_Click(sender As Object, e As EventArgs) Handles SaveDocType.Click
        File.WriteAllText(programPath & "/types.txt", DocTypeDataRTB.Text)
        MsgBox("doc type updated!")
    End Sub

    Private Sub SaveExtension_Click(sender As Object, e As EventArgs) Handles SaveExtension.Click
        File.WriteAllText(programPath & "/extensions.txt", ExtensionDataRTB.Text)
        MsgBox("extension updated!")
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        t.Abort()
        SearchButton.Text = "Search"
        SearchButton.Enabled = True
        StopButton.Enabled = False
    End Sub
End Class
