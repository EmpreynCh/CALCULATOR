Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Dim op As String
    Dim num As Double = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNumber.Text = "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If Val(TxtNumber.Text) = 0 Then
            TxtNumber.Text = "1"
        Else
            TxtNumber.Text = TxtNumber.Text + "1"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If Val(TxtNumber.Text) = 0 Then
            TxtNumber.Text = "0"
        Else
            TxtNumber.Text = TxtNumber.Text + "0"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If Val(TxtNumber.Text) = 0 Then
            TxtNumber.Text = "2"
        Else
            TxtNumber.Text = TxtNumber.Text + "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If Val(TxtNumber.Text) = 0 Then
            TxtNumber.Text = "3"
        Else
            TxtNumber.Text = TxtNumber.Text + "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If Val(TxtNumber.Text) = 0 Then
            TxtNumber.Text = "4"
        Else
            TxtNumber.Text = TxtNumber.Text + "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If Val(TxtNumber.Text) = 0 Then
            TxtNumber.Text = "5"
        Else
            TxtNumber.Text = TxtNumber.Text + "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If Val(TxtNumber.Text) = 0 Then
            TxtNumber.Text = "6"
        Else
            TxtNumber.Text = TxtNumber.Text + "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If Val(TxtNumber.Text) = 0 Then
            TxtNumber.Text = "7"
        Else
            TxtNumber.Text = TxtNumber.Text + "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If Val(TxtNumber.Text) = 0 Then
            TxtNumber.Text = "8"
        Else
            TxtNumber.Text = TxtNumber.Text + "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If Val(TxtNumber.Text) = 0 Then
            TxtNumber.Text = "9"
        Else
            TxtNumber.Text = TxtNumber.Text + "9"
        End If
    End Sub

    Private Sub btnPeriod_Click(sender As Object, e As EventArgs) Handles btnPeriod.Click
        If btnPeriod.Enabled = True Then
            TxtNumber.Text = TxtNumber.Text + "."
            btnPeriod.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnEqual.PerformClick()
        op = "add"
        If num = 0 Then
            num = Val(TxtNumber.Text)
        Else
            num = num + Val(TxtNumber.Text)

        End If
        TxtNumber.Text = "0"
        btnPeriod.Enabled = True
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If op = "add" Then
            TxtNumber.Text = num + Val(TxtNumber.Text)
        ElseIf op = "sub" Then
            TxtNumber.Text = num - Val(TxtNumber.Text)
        ElseIf op = "mul" Then
            TxtNumber.Text = num * Val(TxtNumber.Text)
        ElseIf op = "div" Then
            TxtNumber.Text = num / Val(TxtNumber.Text)
        ElseIf op = "mod" Then
            TxtNumber.Text = num Mod Val(TxtNumber.Text)
        ElseIf op = "exp" Then
            TxtNumber.Text = num ^ Val(TxtNumber.Text)
        End If
        op = ""
        num = 0
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        op = "sub"
        If num = 0 Then
            num = Val(TxtNumber.Text)
        Else
            num = num - Val(TxtNumber.Text)

        End If
        TxtNumber.Text = "0"
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        btnEqual.PerformClick()
        op = "mul"
        If num = 0 Then
            num = Val(TxtNumber.Text)
        Else
            num = num * Val(TxtNumber.Text)

        End If
        TxtNumber.Text = "0"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        op = "div"
        If num = 0 Then
            num = Val(TxtNumber.Text)
        Else
            num = num / Val(TxtNumber.Text)
        End If
        TxtNumber.Text = "0"
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtNumber.Text = "0"
        num = 0
        op = ""
        btnPeriod.Enabled = True
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        btnEqual.PerformClick()
        op = "mod"
        If num = 0 Then
            num = Val(TxtNumber.Text)
        Else
            num = num Mod (TxtNumber.Text)
        End If
        TxtNumber.Text = "0"
        btnPeriod.Enabled = True
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        op = "exp"
        If num = 0 Then
            num = Val(TxtNumber.Text)
        Else
            num = num ^ Val(TxtNumber.Text)
        End If
        TxtNumber.Text = "0"
        btnPeriod.Enabled = True
    End Sub

    Private Sub btnErase_Click(sender As Object, e As EventArgs) Handles btnErase.Click

    End Sub
End Class
