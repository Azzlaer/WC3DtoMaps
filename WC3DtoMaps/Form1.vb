Imports System.IO

Public Class Form1

    Private Sub btndescargas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndescargas.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            txtdescargas.Text = folderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub btnwarcraft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwarcraft.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            txtwarcraft.Text = folderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub btnmover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmover.Click
        If Not String.IsNullOrEmpty(txtdescargas.Text) AndAlso Not String.IsNullOrEmpty(txtwarcraft.Text) Then
            Dim sourcePath As String = txtdescargas.Text
            Dim destinationPath As String = txtwarcraft.Text
            Dim selectedExtensions As New List(Of String)

            If check1w3m.Checked Then
                selectedExtensions.Add(".w3m")
            End If
            If check2w3x.Checked Then
                selectedExtensions.Add(".w3x")
            End If

            If selectedExtensions.Count > 0 Then
                ListBox1.Items.Clear()

                For Each extension In selectedExtensions
                    Dim filesToMove As String() = Directory.GetFiles(sourcePath, "*" & extension)
                    For Each fileToMove In filesToMove
                        Dim fileName As String = Path.GetFileName(fileToMove)
                        Dim destinationFile As String = Path.Combine(destinationPath, fileName)

                        Try
                            File.Move(fileToMove, destinationFile)
                            ListBox1.Items.Add("Movido: " & fileName)

                        Catch ex As Exception
                            ListBox1.Items.Add("Error al mover: " & fileName)
                        End Try
                    Next
                Next

                ListBox1.Items.Add("Archivos totales movidos: " & ListBox1.Items.Count)
                ListBox1.Items.Add("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~")
                ListBox1.Items.Add("Gracias por usar nuestra aplicacion")
                ListBox1.Items.Add("Visitanos en www.LatinBattle.com")
                Process.Start("https://www.LatinBattle.com")
                ListBox1.Items.Add("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~")
            Else
                MsgBox("Seleccione al menos una extensión de archivo para mover.")
            End If
        Else
            MsgBox("Seleccione las carpetas de origen y destino.")
        End If
    End Sub

End Class
