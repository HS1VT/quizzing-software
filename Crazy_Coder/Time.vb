Public Class Time
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Private Sub Time_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Form1.timeleft > 0 Then
            Form1.timeleft -= 1
            TextBox1.Text = Form1.timeleft

        ElseIf Form1.timeleft = 0 Then
            Timer1.Stop()
            Q1.Close()
            Q2.Close()
            Q3.Close()
            Q4.Close()
            Q5.Close()
            Q6.Close()
            Q7.Close()
            Q8.Close()
            Q9.Close()
            Q10.Close()
            Q11.Close()
            Q12.Close()
            Q13.Close()
            Q14.Close()
            Questions.Close()
            Me.Close()
            Form1.Button3.Visible = True
            Form1.Button1.Enabled = False
            MessageBox.Show("Time Is Up!! Leave The System Immediately!!", "Time Over!!")
            
        End If
    End Sub
End Class