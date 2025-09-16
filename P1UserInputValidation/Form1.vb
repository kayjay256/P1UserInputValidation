Imports System.Reflection.Emit

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim userInput As Integer = Convert.ToInt32(TextBox1.Text)
            If userInput < 0 Then
                Label2.Text = "Age cannot be negative."
            Else
                Label2.Text = "Age: " & userInput.ToString()
            End If
        Catch ex As FormatException
            Label2.Text = "Invalid Input. Please enter a number."
        End Try
    End Sub
End Class
