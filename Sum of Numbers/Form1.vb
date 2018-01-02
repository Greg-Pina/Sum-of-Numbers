' **********************************************
' Greg Pina
' IT 101-401
' Assignment 15 - Sum of Numbers
' 11/11/17
' **********************************************

Option Strict On

Public Class frmNumbers

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'Here we get some variables to help with function

        Dim intNumber As Integer
        Dim intSum As Integer
        Dim intCounter As Integer

        'This creates the string to hold the numbers
        Dim strNumber As String

        Try

            'This brings up the prompt
            strNumber = InputBox("Enter a positive integer value.", "Input Needed", "10")



            'Here we check the entered input
            If strNumber <> String.Empty Then
                intNumber = CInt(strNumber)
            End If

            If intNumber < 0 Then
                MessageBox.Show("Negative numbers are not accepted.")
                Exit Sub
            End If

            If IsNumeric(intNumber) = True Then
                intNumber = CInt(strNumber)
            Else
                MessageBox.Show("Quantity amount must be numeric.")

            End If

            'Sum the numbers
            For intCounter = 1 To intNumber
                intSum += intCounter
            Next

            'Final Message Box
            MessageBox.Show("The sum of numbers 1 through " & intNumber & " is " & intSum, "Sum of Numbers", MessageBoxButtons.OK)

            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' clears any data previously entered


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the program
        Close()

    End Sub

    Private Sub frmNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
