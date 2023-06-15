'Programmed By : Mimay, John Rave N.
Public Class CALC

    'Variables who hold num1 
    Dim number1 As Double = 0
    'Display
    Private Sub CALC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display.Text = ""
        num1.Text = ""
        arith.Text = ""

        If (display.Text) = "" Then
            CE.Enabled = False
        Else
            CE.Enabled = True
        End If
    End Sub

    Private Sub display_TextChanged(sender As Object, e As EventArgs) Handles display.TextChanged

        'Convert displayText into String
        If (CStr(display.Text).Contains(".")) Then
            deci.Enabled = False
        Else
            deci.Enabled = True
        End If

        If (display.Text) = "" Then
            CE.Enabled = False
        Else
            CE.Enabled = True
        End If
    End Sub

    'Numbers
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        display.AppendText(Button1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        display.AppendText(Button2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        display.AppendText(Button3.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        display.AppendText(Button4.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        display.AppendText(Button5.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        display.AppendText(Button6.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        display.AppendText(Button7.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        display.AppendText(Button8.Text)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        display.AppendText(Button9.Text)
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        display.AppendText(Button0.Text)
    End Sub

    Private Sub deci_Click(sender As Object, e As EventArgs) Handles deci.Click
        display.AppendText(deci.Text)
    End Sub


    'Arithmetic Operators
    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        number1 = Val(display.Text)
        num1.Text = number1
        arith.Text = add.Text
        display.Text = ""
    End Sub

    Private Sub subs_Click(sender As Object, e As EventArgs) Handles subs.Click
        number1 = Val(display.Text)
        num1.Text = number1
        arith.Text = subs.Text
        display.Text = ""
    End Sub

    Private Sub multi_Click(sender As Object, e As EventArgs) Handles multi.Click
        number1 = Val(display.Text)
        num1.Text = number1
        arith.Text = multi.Text
        display.Text = ""
    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        number1 = Val(display.Text)
        num1.Text = number1
        arith.Text = div.Text
        display.Text = ""
    End Sub
    'Nega
    Private Sub nega_Click(sender As Object, e As EventArgs) Handles nega.Click
        If (display.Text) = "" Then
            display.Text = "-"
        Else
            display.Text = display.Text + "-"
        End If
    End Sub

    'Equal 
    Private Sub equal_Click(sender As Object, e As EventArgs) Handles equal.Click
        If (arith.Text) = "+" Then
            display.Text = number1 + Val(display.Text)
            num1.Text = ""
            arith.Text = ""
        ElseIf (arith.Text) = "-" Then
            display.Text = number1 - Val(display.Text)
            num1.Text = ""
            arith.Text = ""
        ElseIf (arith.Text) = "x" Then
            display.Text = number1 * Val(display.Text)
            num1.Text = ""
            arith.Text = ""
        ElseIf (arith.Text) = "÷" Then
            display.Text = number1 / Val(display.Text)
            num1.Text = ""
            arith.Text = ""
        End If

        'Buttons
        nega.Enabled = False
        CE.Enabled = False

        'Landi
        landi.Text = "The moon is beautiful isn't it"
    End Sub

    'DEL
    Private Sub Del_Click(sender As Object, e As EventArgs) Handles Del.Click
        number1 = 0
        display.Text = ""
        num1.Text = ""
        arith.Text = ""
        nega.Enabled = True
        landi.Text = ""
    End Sub

    Private Sub CE_Click(sender As Object, e As EventArgs) Handles CE.Click
        display.Text = display.Text.Remove(display.Text.Length - 1)
    End Sub


End Class







