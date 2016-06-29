' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Dim intFirst, intSecond, intThird As Integer

    Function GetColorValue(strColor As String) As Integer
        Select Case strColor
            Case "black"
                Return 0
            Case "brown"
                Return 1
            Case "red"
                Return 2
            Case "orange"
                Return 3
            Case "yellow"
                Return 4
            Case "green"
                Return 5
            Case "blue"
                Return 6
            Case "violet", "purple"
                Return 7
            Case "grey", "gray"
                Return 8
            Case "white"
                Return 9
            Case Else
                Return -1
        End Select
    End Function

    Private Sub RecalculateValue()
        lblResult.Text = ((intFirst * 10) + (intSecond * 1)) * intThird
    End Sub

    Private Sub txtFirst_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtFirst.TextChanged
        intFirst = GetColorValue(txtFirst.Text)
        RecalculateValue()
    End Sub

    Private Sub txtSecond_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtSecond.TextChanged
        intSecond = GetColorValue(txtSecond.Text)
        RecalculateValue()
    End Sub

    Private Sub txtThird_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtThird.TextChanged
        intThird = GetColorValue(txtThird.Text)
        intThird = 10 ^ (intThird)
        RecalculateValue()
    End Sub
End Class
