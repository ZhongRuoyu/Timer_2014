<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NumericUpDownMin = New System.Windows.Forms.NumericUpDown()
        Me.minutes = New System.Windows.Forms.Label()
        Me.NumericUpDownSec = New System.Windows.Forms.NumericUpDown()
        Me.seconds = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.buttonStart = New System.Windows.Forms.Button()
        Me.buttonPause = New System.Windows.Forms.Button()
        Me.buttonStop = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownSec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'NumericUpDownMin
        '
        Me.NumericUpDownMin.Font = New System.Drawing.Font("微软雅黑", 16.0!)
        Me.NumericUpDownMin.Location = New System.Drawing.Point(12, 12)
        Me.NumericUpDownMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDownMin.Name = "NumericUpDownMin"
        Me.NumericUpDownMin.Size = New System.Drawing.Size(100, 36)
        Me.NumericUpDownMin.TabIndex = 1
        '
        'minutes
        '
        Me.minutes.AutoSize = True
        Me.minutes.Font = New System.Drawing.Font("微软雅黑", 16.0!)
        Me.minutes.Location = New System.Drawing.Point(118, 14)
        Me.minutes.Name = "minutes"
        Me.minutes.Size = New System.Drawing.Size(35, 30)
        Me.minutes.TabIndex = 0
        Me.minutes.Text = "分"
        '
        'NumericUpDownSec
        '
        Me.NumericUpDownSec.Font = New System.Drawing.Font("微软雅黑", 16.0!)
        Me.NumericUpDownSec.Location = New System.Drawing.Point(181, 12)
        Me.NumericUpDownSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDownSec.Name = "NumericUpDownSec"
        Me.NumericUpDownSec.Size = New System.Drawing.Size(100, 36)
        Me.NumericUpDownSec.TabIndex = 2
        '
        'seconds
        '
        Me.seconds.AutoSize = True
        Me.seconds.Font = New System.Drawing.Font("微软雅黑", 16.0!)
        Me.seconds.Location = New System.Drawing.Point(287, 14)
        Me.seconds.Name = "seconds"
        Me.seconds.Size = New System.Drawing.Size(35, 30)
        Me.seconds.TabIndex = 0
        Me.seconds.Text = "秒"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(194, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 99)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "00"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 239)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(334, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(56, 17)
        Me.ToolStripStatusLabel1.Text = "停止计时"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Maximum = 0
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(256, 16)
        Me.ToolStripProgressBar1.Step = 1
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'buttonStart
        '
        Me.buttonStart.Font = New System.Drawing.Font("微软雅黑", 16.0!)
        Me.buttonStart.Location = New System.Drawing.Point(12, 195)
        Me.buttonStart.Name = "buttonStart"
        Me.buttonStart.Size = New System.Drawing.Size(100, 41)
        Me.buttonStart.TabIndex = 6
        Me.buttonStart.Text = "开始"
        Me.buttonStart.UseVisualStyleBackColor = True
        '
        'buttonPause
        '
        Me.buttonPause.Enabled = False
        Me.buttonPause.Font = New System.Drawing.Font("微软雅黑", 16.0!)
        Me.buttonPause.Location = New System.Drawing.Point(116, 195)
        Me.buttonPause.Name = "buttonPause"
        Me.buttonPause.Size = New System.Drawing.Size(100, 41)
        Me.buttonPause.TabIndex = 6
        Me.buttonPause.Text = "暂停"
        Me.buttonPause.UseVisualStyleBackColor = True
        '
        'buttonStop
        '
        Me.buttonStop.Enabled = False
        Me.buttonStop.Font = New System.Drawing.Font("微软雅黑", 16.0!)
        Me.buttonStop.Location = New System.Drawing.Point(222, 195)
        Me.buttonStop.Name = "buttonStop"
        Me.buttonStop.Size = New System.Drawing.Size(100, 41)
        Me.buttonStop.TabIndex = 6
        Me.buttonStop.Text = "停止"
        Me.buttonStop.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 99)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(146, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 99)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = ":"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 261)
        Me.Controls.Add(Me.buttonStop)
        Me.Controls.Add(Me.buttonPause)
        Me.Controls.Add(Me.buttonStart)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.seconds)
        Me.Controls.Add(Me.minutes)
        Me.Controls.Add(Me.NumericUpDownSec)
        Me.Controls.Add(Me.NumericUpDownMin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Timer"
        CType(Me.NumericUpDownMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownSec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents NumericUpDownMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents minutes As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownSec As System.Windows.Forms.NumericUpDown
    Friend WithEvents seconds As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents buttonStart As System.Windows.Forms.Button
    Friend WithEvents buttonPause As System.Windows.Forms.Button
    Friend WithEvents buttonStop As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar

End Class
