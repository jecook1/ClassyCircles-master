Public Class CCircle

    ' This is called CCircle the extra C indicates that it is a Class definition

    ' It contains the properties (variables) and methods (subroutines)
    ' that are needed in each Circle

    Private XPosition As Integer
    Private YPosition As Integer
    Private Diameter As Integer

    Public Sub New(X As Integer, Y As Integer, D As Integer)

        XPosition = X
        YPosition = Y
        Diameter = D

    End Sub

    Public Sub Draw(g As Graphics)

        Dim Pen As New Pen(Color.Blue, 2)

        g.DrawEllipse(Pen, XPosition, YPosition, Diameter, Diameter)

    End Sub

    Public Sub Drop()

        YPosition += Diameter \ 10

    End Sub

End Class
