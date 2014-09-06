<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBarSec = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBarMin = New System.Windows.Forms.ProgressBar()
        Me.ProgressBarHour = New System.Windows.Forms.ProgressBar()
        Me.LabelHour = New System.Windows.Forms.Label()
        Me.LabelMin = New System.Windows.Forms.Label()
        Me.LabelSec = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBarSec
        '
        Me.ProgressBarSec.Location = New System.Drawing.Point(55, 68)
        Me.ProgressBarSec.Maximum = 60
        Me.ProgressBarSec.Name = "ProgressBarSec"
        Me.ProgressBarSec.Size = New System.Drawing.Size(300, 23)
        Me.ProgressBarSec.TabIndex = 0
        '
        'Timer1
        '
        '
        'ProgressBarMin
        '
        Me.ProgressBarMin.Location = New System.Drawing.Point(55, 38)
        Me.ProgressBarMin.Maximum = 60
        Me.ProgressBarMin.Name = "ProgressBarMin"
        Me.ProgressBarMin.Size = New System.Drawing.Size(300, 23)
        Me.ProgressBarMin.TabIndex = 1
        '
        'ProgressBarHour
        '
        Me.ProgressBarHour.Location = New System.Drawing.Point(55, 9)
        Me.ProgressBarHour.Maximum = 24
        Me.ProgressBarHour.Name = "ProgressBarHour"
        Me.ProgressBarHour.Size = New System.Drawing.Size(120, 23)
        Me.ProgressBarHour.TabIndex = 2
        '
        'LabelHour
        '
        Me.LabelHour.AutoSize = True
        Me.LabelHour.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelHour.Location = New System.Drawing.Point(12, 9)
        Me.LabelHour.Name = "LabelHour"
        Me.LabelHour.Size = New System.Drawing.Size(43, 23)
        Me.LabelHour.TabIndex = 3
        Me.LabelHour.Text = "23時"
        Me.LabelHour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelMin
        '
        Me.LabelMin.AutoSize = True
        Me.LabelMin.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelMin.Location = New System.Drawing.Point(12, 38)
        Me.LabelMin.Name = "LabelMin"
        Me.LabelMin.Size = New System.Drawing.Size(43, 23)
        Me.LabelMin.TabIndex = 4
        Me.LabelMin.Text = "59分"
        Me.LabelMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelSec
        '
        Me.LabelSec.AutoSize = True
        Me.LabelSec.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelSec.Location = New System.Drawing.Point(12, 68)
        Me.LabelSec.Name = "LabelSec"
        Me.LabelSec.Size = New System.Drawing.Size(43, 23)
        Me.LabelSec.TabIndex = 5
        Me.LabelSec.Text = "59秒"
        Me.LabelSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 102)
        Me.Controls.Add(Me.LabelSec)
        Me.Controls.Add(Me.LabelMin)
        Me.Controls.Add(Me.LabelHour)
        Me.Controls.Add(Me.ProgressBarHour)
        Me.Controls.Add(Me.ProgressBarMin)
        Me.Controls.Add(Me.ProgressBarSec)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBarSec As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBarMin As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBarHour As System.Windows.Forms.ProgressBar
    Friend WithEvents LabelHour As System.Windows.Forms.Label
    Friend WithEvents LabelMin As System.Windows.Forms.Label
    Friend WithEvents LabelSec As System.Windows.Forms.Label

End Class
