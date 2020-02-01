Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub
    Dim count = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'count -= 1
        'Console.WriteLine(count)
        Select Case count

            Case 0
                ClearColors()
                Button3.BackColor = Color.Red
                Button1.BackColor = Color.Red
                Button4.BackColor = Color.Red
                'Button6.BackColor = Color.Red
                Button5.BackColor = Color.Red
                Button2.BackColor = Color.Red
                Button7.BackColor = Color.Red
            Case 1
                ClearColors()
                Button3.BackColor = Color.Red
                Button5.BackColor = Color.Red
            Case 2
                ClearColors()
                Button3.BackColor = Color.Red
                Button1.BackColor = Color.Red
                Button4.BackColor = Color.Red
                Button6.BackColor = Color.Red
                Button7.BackColor = Color.Red
            Case 3
                ClearColors()
                Button3.BackColor = Color.Red
                Button1.BackColor = Color.Red
                Button5.BackColor = Color.Red
                Button6.BackColor = Color.Red
                Button7.BackColor = Color.Red

            Case 4
                ClearColors()
                Button2.BackColor = Color.Red
                Button3.BackColor = Color.Red
                Button5.BackColor = Color.Red
                Button6.BackColor = Color.Red
                'Button7.BackColor = Color.Red

            Case 5
                ClearColors()
                'Button3.BackColor = Color.Red
                Button1.BackColor = Color.Red
                Button2.BackColor = Color.Red
                Button6.BackColor = Color.Red
                Button7.BackColor = Color.Red
                Button5.BackColor = Color.Red
            Case 6
                ClearColors()
                Button2.BackColor = Color.Red
                Button1.BackColor = Color.Red
                Button4.BackColor = Color.Red
                Button6.BackColor = Color.Red
                Button7.BackColor = Color.Red
                Button5.BackColor = Color.Red

            Case 7
                ClearColors()
                Button3.BackColor = Color.Red
                Button1.BackColor = Color.Red
                Button5.BackColor = Color.Red
                'Button6.BackColor = Color.Red
                'Button7.BackColor = Color.Red

            Case 8
                ClearColors()
                Button3.BackColor = Color.Red
                Button1.BackColor = Color.Red
                Button4.BackColor = Color.Red
                Button6.BackColor = Color.Red
                Button5.BackColor = Color.Red
                Button2.BackColor = Color.Red
                Button7.BackColor = Color.Red
            Case 9
                ClearColors()
                Button3.BackColor = Color.Red
                Button1.BackColor = Color.Red
                Button2.BackColor = Color.Red
                Button6.BackColor = Color.Red
                Button7.BackColor = Color.Red
                Button5.BackColor = Color.Red

            Case Else
        End Select
        Console.WriteLine(count)

        If (count < 10) Then
            count += 1
        Else
            count = 0
        End If

    End Sub

    Private Sub ClearColors()
        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.White
    End Sub
End Class
