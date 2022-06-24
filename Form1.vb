Public Class Form1
    ' Check if is prime number
    Public Function isPrime(ByVal number As Integer) As Boolean
        If number > 1 Then
            For i As Integer = 2 To number - 1
                If number Mod i = 0 Then
                    Return False
                End If
            Next
            Return True
        Else
            Return False
        End If
    End Function

    Public Function CheckIfItIsFibonacci(n As Integer) As Boolean
        Dim x, y, z As Integer
        x = -1 : y = 0
        Do While (z = n) Or (z < n)
            z = x + y
            x = y : y = z
        Loop
        Return z
    End Function

    Private Sub PrimeNumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrimeNumbersToolStripMenuItem.Click
        Result.Text = isPrime(TextBox1.Text)
    End Sub
End Class
