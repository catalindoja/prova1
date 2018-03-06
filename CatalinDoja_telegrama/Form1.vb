Imports System.IO

Public Class Form1
    Dim texto As String
    Dim separador As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tabs, comes, punt i coma i finalment espai. com separador
        'streamreader peek split
		'
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Espai" Then


            Dim paraules As String() = texto.Split(New Char() {" "c})

            ' Use For Each loop over words and display them.
            Dim paraula As String = ""
            For Each paraula In paraules
                paraula = " " + paraula
                TextBox2.Text = paraula
            Next


        ElseIf ComboBox1.Text = "Coma" Then
            separador = ","

        ElseIf ComboBox1.Text = "Punt i coma" Then
            separador = ";"

        ElseIf ComboBox1.Text = "Tabulador" Then
            separador = vbTab

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ruta = Abrir()
        If ruta <> "" Then
            Dim sr As New StreamReader(ruta, True)
            texto = sr.ReadToEnd()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
