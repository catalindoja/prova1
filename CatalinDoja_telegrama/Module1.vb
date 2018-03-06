Module Module1
    Public ruta As String

    Public Function Abrir() As String
        Form1.OpenFileDialog1.FileName = ""
        Form1.OpenFileDialog1.InitialDirectory = "c:\"
        Form1.OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|all files (*.*)|*.*"
        Form1.OpenFileDialog1.FilterIndex = 2

        Form1.OpenFileDialog1.ShowDialog()
       // System.Text.Encoding.UTF8
        Return Form1.OpenFileDialog1.FileName
    End Function

End Module
