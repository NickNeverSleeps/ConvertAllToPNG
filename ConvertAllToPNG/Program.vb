Imports System
Imports System.Drawing
Imports System.IO

Module Program
	Sub Main(args As String())
		If (OperatingSystem.IsWindows()) Then
			Dim FileList() As String = Directory.GetFiles(args(0), "??*.png")
			Dim CurrentImage As Image
			Dim i As Integer
			For i = 0 To FileList.Length - 1
				CurrentImage = Image.FromFile(FileList(i))
				'If (CurrentImage.RawFormat.ToString = "jpeg") Then
				CurrentImage.Save(FileList(i) + "_1", ImageFormat.Png)
				CurrentImage.Dispose()
				File.Delete(FileList(i))
				FileSystem.Rename(FileList(i) + "_1", FileList(i))
				'End If
			Next i
		End If
	End Sub
End Module
