﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, auxi As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)
        If a > b Then GoTo a_mayor Else GoTo bc_mayor
a_mayor:
        auxi = a
        a = b
        b = auxi
bc_mayor:
        If b > c Then GoTo b_mayor Else GoTo abajo_ciclo1
b_mayor:
        auxi = b
        b = c
        c = auxi
abajo_ciclo1:
        If a > b Then GoTo a_mayor2 Else GoTo bc_mayor2
a_mayor2:
        auxi = a
        a = b
        b = auxi
bc_mayor2:
        If b > c Then GoTo b_mayor2 Else GoTo abajo_ciclo2
b_mayor2:
        auxi = b
        b = c
        c = auxi
abajo_ciclo2:
        TextBox4.Text = a & ", " & b & ", " & c

    End Sub
End Class
