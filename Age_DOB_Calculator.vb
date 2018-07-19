Public Class Form1
    Dim datevalue1 As Date
    Dim datevalue2 As Date
    Dim datet As TimeSpan
    Dim diff As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        datevalue1 = Me.DateTimePicker1.Value.ToShortDateString
        datevalue2 = Me.DateTimePicker2.Value.ToShortDateString
        datet = (datevalue2 - datevalue1)
        diff = datet.Days
        Me.Label3.Text = ("Your age is" + Str(Int(diff / 365)) + " Years")
        diff = diff Mod 365
        Me.Label3.Text = Me.Label3.Text + (Str(Int(diff / 30)) + " Months")
        diff = diff Mod 30
        Me.Label3.Text = Me.Label3.Text + (Str(Int(diff)) + " Days")
    End Sub
End Class
