Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim n As DateTime = DateTime.Now

        ProgressBarHour.Value = n.Hour
        ProgressBarMin.Value = n.Minute
        ProgressBarSec.Value = n.Second

        LabelHour.Text = String.Format("{0:D2}時", n.Hour)
        LabelMin.Text = String.Format("{0:D2}分", n.Minute)
        LabelSec.Text = String.Format("{0:D2}秒", n.Second)
    End Sub
End Class
