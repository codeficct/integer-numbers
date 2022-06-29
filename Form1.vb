Public Class Form1
    Dim messageError As String = "Please enter a valid number"
    Public Function EvenAndOdd(num As Integer) As Boolean
        Return num Mod 2 = 0
    End Function
    ' Check if is prime number
    Public Function isPrime(ByVal number As Integer) As Boolean
        Dim square As Double = Math.Sqrt(number)
        Dim index As Integer
        Dim result As Boolean
        For index = 2 To square
            If number Mod index = 0 Then
                result = False
            End If
        Next
        result = number > 1
        Return result
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

    Public Function Factorial(number As Double) As Double
        Dim result As Double
        Dim index As Integer
        If number <> 0 Then
            result = 1
            For index = Math.Abs(number) To 1 Step -1
                result *= index
            Next
            If number < 0 Then
                result = -result
            End If
        Else
            result = 1
        End If
        Return result
    End Function

    Public Function AccessNumber(number As Integer, Digits As Integer) As Integer
        Dim sum, digit, divider As Integer
        Select Case Digits
            Case 1
                divider = 10
            Case 2
                divider = 100
            Case 3
                divider = 1000
            Case 4
                divider = 10000
        End Select
        While number > 0
            digit = number Mod divider
            sum += digit
            number \= divider
        End While
        Return sum
    End Function

    Public Function ReverseNumber(number As Integer) As Integer
        Dim result, digit As Integer
        result = 0
        While number > 0
            digit = number Mod 10
            result = result * 10 + digit
            number \= 10
        End While
        Return result
    End Function
    Public Function CheckMatch(number As Integer) As Boolean
        Return ReverseNumber(number) = number
    End Function

    Public Function OnlyEvenOrOdd(number As Integer, isEven As Boolean) As Integer
        Dim digit, result As Integer
        While number > 0
            digit = number Mod 10
            If EvenAndOdd(digit) And isEven Then
                result = result * 10 + digit
            ElseIf Not EvenAndOdd(digit) And Not isEven Then
                result = result * 10 + digit
            End If
            number \= 10
        End While
        Return ReverseNumber(result)
    End Function

    ' todo: Fix function for convert binary to decimal
    'Public Function BinaryToDecimal(binary As Integer) As Integer
    'End Function

    Public Function SearchDigit(number As Integer, search As Integer) As Boolean
        Dim digit As Integer
        Dim result As Boolean = False
        While number > 0
            digit = number Mod 10
            number \= 10
            If digit = search Then
                result = True
            End If
        End While
        Return result
    End Function

    Public Function FindIntersection(number As Integer, number2 As Integer) As Integer
        Dim digit, result As Integer
        result = 0
        While number > 0
            digit = number Mod 10
            If SearchDigit(number2, digit) Then
                result = result * 10 + digit
            End If
            number \= 10
        End While
        Return ReverseNumber(result)
    End Function

    Public Function VerifyIsExistPrime(number As Integer) As Boolean
        Dim digit As Integer
        Dim result As Boolean = False
        While (number > 0) And (result = False)
            digit = number Mod 10
            number /= 10
            If isPrime(digit) Then
                result = True
            End If
        End While
        Return result
    End Function

    Public Function VerifyIfEqualPrimeNumbers(number As Integer) As Boolean
        Dim b As Boolean = True
        Dim digit, otherDigit As Byte
        digit = number Mod 10
        number \= 10
        While (number > 0) And (b = True)
            otherDigit = number Mod 10
            number \= 10
            If Not otherDigit = digit Then
                b = False
            End If
        End While
        Return b
    End Function

    Private Sub PrimeNumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrimeNumbersToolStripMenuItem.Click
        Try
            Result.Text = isPrime(TextBox1.Text)
        Catch ex As Exception
            MsgBox(messageError)
        End Try
    End Sub

    Private Sub AccesNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccesNumberToolStripMenuItem.Click
        Try
            Result.Text = AccessNumber(TextBox1.Text, 1)
        Catch ex As Exception
            MsgBox(messageError)
        End Try
    End Sub

    Private Sub Sum2DigitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Sum2DigitToolStripMenuItem.Click
        Try
            Result.Text = AccessNumber(TextBox1.Text, 2)
        Catch ex As Exception
            MsgBox(messageError)
        End Try
    End Sub

    Private Sub Sum3DigitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Sum3DigitsToolStripMenuItem.Click
        Try
            Result.Text = AccessNumber(TextBox1.Text, 3)
        Catch ex As Exception
            MsgBox(messageError)
        End Try
    End Sub

    Private Sub Sum4DigitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Sum4DigitsToolStripMenuItem.Click
        Try
            Result.Text = AccessNumber(TextBox1.Text, 4)
        Catch ex As Exception
            MsgBox(messageError)
        End Try
    End Sub

    Private Sub ReverseNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReverseNumberToolStripMenuItem.Click
        Try
            Result.Text = CheckMatch(TextBox1.Text)
        Catch ex As Exception
            MsgBox(messageError)
        End Try
    End Sub

    Private Sub OnlyEvenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlyEvenToolStripMenuItem.Click
        Try
            Result.Text = OnlyEvenOrOdd(TextBox1.Text, true)
        Catch ex As Exception
            MsgBox(messageError)
        End Try
    End Sub

    Private Sub OnlyDoddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlyDoddToolStripMenuItem.Click
        Try
            Result.Text = OnlyEvenOrOdd(TextBox1.Text, False)
        Catch ex As Exception
            MsgBox(messageError)
        End Try
    End Sub

    Private Sub BinaryToDecimalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinaryToDecimalToolStripMenuItem.Click
        Try
            'Result.Text = BinaryToDecimal(TextBox1.Text)
        Catch ex As Exception
            MsgBox(messageError)
        End Try
    End Sub
    Private Sub SearchNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchNumberToolStripMenuItem.Click
        Try
            Result.Text = SearchDigit(TextBox1.Text, TextBox2.Text)
        Catch ex As Exception
            MsgBox(messageError)
        End Try
    End Sub

    Private Sub FindIntersectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindIntersectionToolStripMenuItem.Click
        Try
            Result.Text = FindIntersection(TextBox1.Text, TextBox2.Text)
        Catch ex As Exception
            MsgBox(messageError)
        End Try
    End Sub

    Private Sub VerifyIfIsExistANumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerifyIfIsExistANumberToolStripMenuItem.Click
        Try
            Result.Text = VerifyIsExistPrime(TextBox1.Text)
        Catch ex As Exception
            MsgBox(messageError)
        End Try
    End Sub

    Private Sub VerifyIfEqualPrimeNumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerifyIfEqualPrimeNumbersToolStripMenuItem.Click
        Try
            Result.Text = VerifyIfEqualPrimeNumbers(TextBox1.Text)
        Catch ex As Exception
            MsgBox(messageError)
        End Try
    End Sub
End Class
