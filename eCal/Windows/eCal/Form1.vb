Public Class eCal
    Dim IntVal As Double

    ' LastCmd Cmd
    '1 = addition
    '2 = subtraction
    '3 = multiplication
    '4 = division

    Dim LastCmd As Double

    Private Sub eCal_FirstLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = 0
        IntVal = 0
        LastCmd = 0
        Label1.Text = ""
    End Sub

    Private Sub Num0_Click(sender As Object, e As EventArgs) Handles Num0.Click
        If CDbl(TextBox1.Text) = 0 Then
            TextBox1.Text = ("0")

        Else
            TextBox1.AppendText("0")

        End If
    End Sub

    Private Sub Num1_Click(sender As Object, e As EventArgs) Handles Num1.Click
        If CDbl(TextBox1.Text) = 0 Then
            TextBox1.Text = ("1")

        Else
            TextBox1.AppendText("1")

        End If
    End Sub

    Private Sub Num2_Click(sender As Object, e As EventArgs) Handles Num2.Click
        If CDbl(TextBox1.Text) = 0 Then
            TextBox1.Text = ("2")

        Else
            TextBox1.AppendText("2")

        End If
    End Sub

    Private Sub Num3_Click(sender As Object, e As EventArgs) Handles Num3.Click
        If CDbl(TextBox1.Text) = 0 Then
            TextBox1.Text = ("3")

        Else
            TextBox1.AppendText("3")

        End If
    End Sub

    Private Sub Num4_Click(sender As Object, e As EventArgs) Handles Num4.Click
        If CDbl(TextBox1.Text) = 0 Then
            TextBox1.Text = ("4")

        Else
            TextBox1.AppendText("1")

        End If
    End Sub

    Private Sub Num5_Click(sender As Object, e As EventArgs) Handles Num5.Click
        If CDbl(TextBox1.Text) = 0 Then
            TextBox1.Text = ("5")

        Else
            TextBox1.AppendText("5")

        End If
    End Sub

    Private Sub Num6_Click(sender As Object, e As EventArgs) Handles Num6.Click
        If CDbl(TextBox1.Text) = 0 Then
            TextBox1.Text = ("6")

        Else
            TextBox1.AppendText("6")

        End If
    End Sub

    Private Sub Num7_Click(sender As Object, e As EventArgs) Handles Num7.Click
        If CDbl(TextBox1.Text) = 0 Then
            TextBox1.Text = ("7")

        Else
            TextBox1.AppendText("7")

        End If
    End Sub

    Private Sub Num8_Click(sender As Object, e As EventArgs) Handles Num8.Click
        If CDbl(TextBox1.Text) = 0 Then
            TextBox1.Text = ("8")

        Else
            TextBox1.AppendText("8")

        End If
    End Sub

    Private Sub Num9_Click(sender As Object, e As EventArgs) Handles Num9.Click
        If CDbl(TextBox1.Text) = 0 Then
            TextBox1.Text = ("9")

        Else
            TextBox1.AppendText("9")

        End If
    End Sub

    Private Sub Decimalsign_Click(sender As Object, e As EventArgs) Handles Decimalsign.Click
        TextBox1.AppendText(".")
    End Sub

    Private Sub Addsign_Click(sender As Object, e As EventArgs) Handles Addsign.Click
        If IntVal = 0 Then
            IntVal = CDbl(TextBox1.Text)
        Else
            IntVal = IntVal + CDbl(TextBox1.Text)
        End If
        TextBox1.Text = 0
        Label1.Text = IntVal
        LastCmd = 1
    End Sub

    Private Sub Subtractsign_Click(sender As Object, e As EventArgs) Handles Subtractsign.Click
        If IntVal = 0 Then
            IntVal = CDbl(TextBox1.Text)
        Else
            IntVal = IntVal - CDbl(TextBox1.Text)
        End If
        TextBox1.Text = 0
        Label1.Text = IntVal
        LastCmd = 2
    End Sub

    Private Sub Multiplysign_Click(sender As Object, e As EventArgs) Handles Multiplysign.Click
        If IntVal = 0 Then
            IntVal = CDbl(TextBox1.Text)
        Else
            IntVal = IntVal * CDbl(TextBox1.Text)
        End If
        TextBox1.Text = 0
        Label1.Text = IntVal
        LastCmd = 3
    End Sub

    Private Sub Dividesign_Click(sender As Object, e As EventArgs) Handles Dividesign.Click
        If IntVal = 0 Then
            IntVal = CDbl(TextBox1.Text)
        Else
            IntVal = IntVal / CDbl(TextBox1.Text)
        End If
        TextBox1.Text = 0
        Label1.Text = IntVal
        LastCmd = 4
    End Sub

    Private Sub Sqrtsign_Click(sender As Object, e As EventArgs) Handles Sqrtsign.Click
        TextBox1.Text = Math.Sqrt(CDbl(TextBox1.Text))
    End Sub

    Private Sub Squaresign_Click(sender As Object, e As EventArgs) Handles Squaresign.Click
        TextBox1.Text = CDbl(TextBox1.Text) * CDbl(TextBox1.Text)
    End Sub

    Private Sub Equalsign_Click(sender As Object, e As EventArgs) Handles Equalsign.Click
        If LastCmd = 1 Then
            TextBox1.Text = IntVal + TextBox1.Text
        ElseIf LastCmd = 2 Then
            TextBox1.Text = IntVal - TextBox1.Text
        ElseIf LastCmd = 3 Then
            TextBox1.Text = IntVal * TextBox1.Text
        ElseIf LastCmd = 4 Then
            TextBox1.Text = IntVal / TextBox1.Text
        End If
    End Sub

    Private Sub Allclear_Click(sender As Object, e As EventArgs) Handles Allclear.Click
        TextBox1.Text = 0
        IntVal = 0
        LastCmd = 0
        Label1.Text = ""
    End Sub

    Private Sub Aboutbutton_Click(sender As Object, e As EventArgs) Handles Aboutbutton.Click
        MessageBox.Show("eCal was created by Rishaan Kotian, a 10 year old on GitHub. eCal was made with Visual studio using vb.net. Visit his GitHub eCal page at https://github.com/rishaank/eCal. Visit his eCal website at https://rishaankotian.wixsite.com/home/ecal. Download the README from his GitHub or his website for more information. Give more feedback at https://docs.google.com/forms/d/e/1FAIpQLSfgiyL7RUH8CC_7mPTITcIBk7X_-jNWP258FcexjQ426rDfQA/viewform. eCal was Rishaan's first GUI application. Thanks for using eCal. :)", "About eCal", MessageBoxButtons.OK)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
