Public Class frmOptions

    'Resets Options
    Private Sub btnResetOptions_Click(sender As System.Object, e As System.EventArgs) Handles btnResetOptions.Click
        radEasy.Checked = True
        radMouse.Checked = True
    End Sub

    'Saves Options And Closes Options
    Private Sub btnSaveOptions_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveOptions.Click
        If radEasy.Checked Then
            frmPong.strDifficulty = "easy"
        ElseIf radHard.Checked Then
            frmPong.strDifficulty = "hard"
        ElseIf radImpossible.Checked Then
            frmPong.strDifficulty = "impossible"
        End If

        If radMouse.Checked Then
            frmPong.strControls = "mouse"
        ElseIf radWASD.Checked Then
            frmPong.strControls = "wasd"
        ElseIf radArrows.Checked Then
            frmPong.strControls = "arrows"
        End If

        Close()
    End Sub

    'Displays Correct Options When Options Loads
    Private Sub frmOptions_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If frmPong.strControls = "mouse" Then
            radMouse.Checked = True
        ElseIf frmPong.strControls = "wasd" Then
            radWASD.Checked = True
        ElseIf frmPong.strControls = "arrows" Then
            radArrows.Checked = True
        End If

        If frmPong.strDifficulty = "easy" Then
            radEasy.Checked = True
        ElseIf frmPong.strDifficulty = "hard" Then
            radHard.Checked = True
        ElseIf frmPong.strDifficulty = "impossible" Then
            radImpossible.Checked = True
        End If

        If frmPong.getAchievementStatus("hard") = True Then
            radHard.Enabled = True
        End If

        If frmPong.getAchievementStatus("impossible") = True Then
            radImpossible.Enabled = True
        End If
    End Sub

    'Closes Form When Out Of Focus
    Private Sub frmOptions_LostFocus(sender As Object, e As System.EventArgs) Handles Me.LostFocus
        Close()
    End Sub

    'Quits Game
    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        Dim intResponse As Integer = MsgBox("Are you sure you wish to quit?", vbYesNo + vbQuestion, "Quit")

        If intResponse = vbYes Then
            Close()
            frmPong.Close()
        End If
    End Sub

    'Resets Ball
    Private Sub btnResetBall_Click(sender As System.Object, e As System.EventArgs) Handles btnResetBall.Click
        frmPong.setBallPath()
    End Sub

    'Resets Game
    Private Sub btnResetGame_Click(sender As System.Object, e As System.EventArgs) Handles btnResetGame.Click
        frmPong.setBallPath()
        frmPong.resetScores()
    End Sub
End Class