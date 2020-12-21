Public Class Form1
    Dim s As Integer

    Private Sub buttonStart_Click(sender As Object, e As EventArgs) Handles buttonStart.Click
        Start()
    End Sub

    Private Sub Start()
        If NumericUpDownMin.Value <> 0 Or NumericUpDownSec.Value <> 0 Then
            Timer1.Enabled = True
            s = NumericUpDownMin.Value * 60 + NumericUpDownSec.Value
            buttonStart.Enabled = False
            buttonPause.Enabled = True
            buttonStop.Enabled = True
            NumericUpDownMin.Enabled = False
            NumericUpDownSec.Enabled = False
            If NumericUpDownMin.Value >= 10 Then
                Label1.Text = NumericUpDownMin.Value
            Else
                Label1.Text = "0" + NumericUpDownMin.Value.ToString
            End If
            If NumericUpDownSec.Value >= 10 Then
                Label3.Text = NumericUpDownSec.Value
            Else
                Label3.Text = "0" + NumericUpDownSec.Value.ToString
            End If
            ToolStripStatusLabel1.Text = "正在计时"
            ToolStripProgressBar1.Maximum = NumericUpDownMin.Value * 60 + NumericUpDownSec.Value
            ToolStripProgressBar1.Enabled = True
        Else
            MessageBox.Show("请输入时间。", "错误")
        End If
    End Sub

    Private Sub Pause()
        If Timer1.Enabled = True Then
            buttonPause.Text = "继续"
            Timer1.Enabled = False
            ToolStripStatusLabel1.Text = "暂停计时"
        Else
            buttonPause.Text = "暂停"
            Timer1.Enabled = True
            ToolStripStatusLabel1.Text = "正在计时"
        End If
    End Sub

    Private Sub buttonPause_Click(sender As Object, e As EventArgs) Handles buttonPause.Click
        Pause()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label3.Text > 0 Then
            If Label3.Text > 10 Then
                    ToolStripProgressBar1.Value += 1
                Label3.Text -= 1
            Else
                ToolStripProgressBar1.Value += 1
                Label3.Text = "0" + (Label3.Text - 1).ToString
            End If
        ElseIf Label1.Text > 0 Then
        If Label1.Text > 10 Then
            ToolStripProgressBar1.Value += 1
            Label3.Text = 59
            Label1.Text -= 1
        Else
            ToolStripProgressBar1.Value += 1
            Label3.Text = 59
            Label1.Text = "0" + (Label1.Text - 1).ToString
        End If
        Else
        Endtimer()
        MessageBox.Show("时间到。", "结束计时")
        End If
    End Sub

    Private Sub Endtimer()
        Timer1.Enabled = False
        buttonStart.Enabled = True
        buttonPause.Enabled = False
        buttonStop.Enabled = False
        NumericUpDownMin.Enabled = True
        NumericUpDownSec.Enabled = True
        buttonPause.Text = "暂停"
        Label1.Text = "00"
        Label3.Text = "00"
        ToolStripStatusLabel1.Text = "停止计时"
        ToolStripProgressBar1.Maximum = 0
        ToolStripProgressBar1.Enabled = False
    End Sub

    Private Sub buttonStop_Click(sender As Object, e As EventArgs) Handles buttonStop.Click
        Endtimer()
    End Sub
End Class
