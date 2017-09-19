Public Class MainForm

    Private Circles(2) As CCircle

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Circles(0) = New CCircle(50, 150, 10)
        Circles(1) = New CCircle(250, 50, 30)
        Circles(2) = New CCircle(150, 50, 50)

    End Sub

    Private Sub Display_Paint(sender As Object, e As PaintEventArgs) Handles Display.Paint

        Dim g As Graphics

        g = e.Graphics

        For Each Circle In Circles
            Circle.Draw(g)
        Next

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        For Each Circle In Circles
            Circle.Drop()
        Next

        Display.Refresh()

    End Sub
End Class
