Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtvMatriz.ColumnCount = 7
        dtvMatriz.Rows.Add(7)
        dtvVector.ColumnCount = 5
        dtvVector.Rows.Add()
        dtvNuevaMatriz.ColumnCount = 4
        dtvNuevaMatriz.Rows.Add(3)
        For i = 0 To 6
            dtvMatriz.Columns(i).Width = 40
        Next
        For i = 0 To 4
            dtvVector.Columns(i).Width = 40
        Next
        For i = 0 To 3
            dtvNuevaMatriz.Columns(i).Width = 40
        Next
    End Sub

    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim matriz(7, 7), vector(5), nuevaMatriz(3, 4) As Integer
        lblMatriz.Text = "La matriz original es:"
        For f = 0 To 6
            For c = 0 To 6
                matriz(f, c) = Rnd() * 100
                dtvMatriz.Item(c, f).Value = matriz(f, c)
            Next
        Next
        lblVector.Text = "El vector generado es:"
        For f = 0 To 4
            vector(f) = matriz(f + 1, f + 2)
            dtvVector.Item(f, 0).Value = vector(f)
        Next
        lblNuevaMatriz.Text = "La nueva matriz generada es:"
        For f = 0 To 2
            For c = 0 To 3
                nuevaMatriz(f, c) = matriz(f + 3, c + 2)
                dtvNuevaMatriz.Item(c, f).Value = nuevaMatriz(f, c)
            Next
        Next
    End Sub
End Class
