Public Class frmPong

    'Achievement Stuff
    Dim booHard As Boolean = False
    Dim booImpossible As Boolean = False

    'Speed Variables
    Dim intBallSpeed As Integer = 20
    Dim intPlayerSpeed As Integer = 10
    Dim intCompSpeed As Integer = 10

    'Score Variables
    Dim intPlayerScore As Integer = 0
    Dim intCompScore As Integer = 0

    'Options
    Public strDifficulty As String = "hard"
    Public strControls As String = "mouse"

    'Ball Path Setting
    Dim rndNumber As New Random()
    Dim xVelocity As Single
    Dim yVelocity As Single

    Private Sub tmrGame_Tick(sender As System.Object, e As System.EventArgs) Handles tmrGame.Tick
        'Sets Difficulty In-Game
        Select Case strDifficulty
            Case "easy"
                intCompSpeed = 10
            Case "hard"
                intCompSpeed = 20
            Case "impossible"
                intCompSpeed = 30
        End Select

        'Ball Logics
        picBall.Location = New Point(picBall.Location.X + xVelocity, picBall.Location.Y + yVelocity)

        If picBall.Top < 0 Then
            picBall.Location = New Point(picBall.Location.X, 0)
            yVelocity = -yVelocity
        End If

        If picBall.Bottom > Me.Height - picBall.Height - 20 Then
            picBall.Location = New Point(picBall.Location.X, Me.Height - picBall.Height - 30)
            yVelocity = -yVelocity
        End If

        If picBall.Bounds.IntersectsWith(picPlayerPaddle.Bounds) Then
            picBall.Location = New Point(picPlayerPaddle.Right + 1, picBall.Top)
            xVelocity = -xVelocity
        End If

        If picBall.Bounds.IntersectsWith(picCompPaddle.Bounds) Then
            picBall.Location = New Point(picCompPaddle.Left - 1, picBall.Top)
            xVelocity = -xVelocity
        End If

        'CPU Paddle Movement
        If picBall.Location.Y >= 0 And picBall.Location.Y <= Me.Height - (30 + picPlayerPaddle.Height) And picBall.Left >= picLine.Right Then
            Dim intPaddleBallDistance As Integer = (picCompPaddle.Location.Y - picBall.Location.Y)

            If intPaddleBallDistance > 10 Then
                picCompPaddle.Top -= intCompSpeed
            ElseIf 10 > intPaddleBallDistance And intPaddleBallDistance > 0 Then
                picCompPaddle.Top -= 5
            End If

            If intPaddleBallDistance < -10 Then
                picCompPaddle.Top += intCompSpeed
            ElseIf -10 < intPaddleBallDistance And intPaddleBallDistance < 0 Then
                picCompPaddle.Top += 5
            End If
        End If

        'Scoring
        If picBall.Right > Me.Width Then
            setBallPath()
            intPlayerScore += 1
            lblPlayerScore.Text = intPlayerScore

            If intPlayerScore = 10 Then
                booHard = True
            End If

            If intPlayerScore = 20 Then
                booImpossible = True
            End If
        End If

        If picBall.Left < 0 Then
            setBallPath()
            intCompScore += 1
            lblCompScore.Text = intCompScore
        End If
    End Sub

    'Resuming Game
    Private Sub frmPong_GotFocus(sender As Object, e As System.EventArgs) Handles Me.GotFocus
        tmrGame.Enabled = True
    End Sub

    'Show Options
    Private Sub frmPong_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            frmOptions.Show()
        End If
    End Sub

    'Keyboard Movement
    Private Sub frmPong_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If strControls = "wasd" Then
            If e.KeyCode = Keys.W Or e.KeyCode = Keys.D Then
                movePaddle("up")
            ElseIf e.KeyCode = Keys.S Or e.KeyCode = Keys.A Then
                movePaddle("down")
            End If
        ElseIf strControls = "arrows" Then
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Right Then
                movePaddle("up")
            ElseIf e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Then
                movePaddle("down")
            End If
        End If
    End Sub

    'Player Paddle Movement
    Private Sub frmPong_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Not frmOptions.Visible AndAlso strControls = "mouse" Then
            If e.Y > 0 And e.Y < Me.Height - (picPlayerPaddle.Height + 30) Then
                picPlayerPaddle.Top = e.Y
            End If
        End If
    End Sub

    'Resizing The Game
    Private Sub frmPong_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged
        picCompPaddle.Location = New Point(Me.Width - 44, picCompPaddle.Location.Y)
        lblCompScore.Location = New Point(Me.Width - (Me.Width / 4), lblCompScore.Location.Y)
        lblPlayerScore.Location = New Point((Me.Width / 4) - 25, lblPlayerScore.Location.Y)
        picLine.Height = Me.Width
        picLine.Location = New Point((Me.Width / 2), picLine.Location.Y)
        lblPForPauseLabel.Location = New Point(lblPForPauseLabel.Location.X, Me.Height - 75)
    End Sub

    'Pausing Game
    Private Sub frmPong_LostFocus(sender As Object, e As System.EventArgs) Handles Me.LostFocus
        tmrGame.Enabled = False
    End Sub

    'Ball Path Setter
    Private Sub frmPong_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        setBallPath()
    End Sub

    'Method To Move Paddle (Used For Keyboard Controls)
    Private Sub movePaddle(ByVal strDirection As String)
        If strDirection = "up" Then
            If picPlayerPaddle.Top > 0 Then
                picPlayerPaddle.Top -= intPlayerSpeed
            End If
        ElseIf strDirection = "down" Then
            If picPlayerPaddle.Top < Me.Height - (picPlayerPaddle.Height + 30) Then
                picPlayerPaddle.Top += intPlayerSpeed
            End If
        End If
    End Sub

    'Sets Ball Path And Places It In The Middle
    Public Sub setBallPath()
        xVelocity = Math.Cos(rndNumber.Next(5, 10)) * intBallSpeed
        yVelocity = Math.Sin(rndNumber.Next(5, 10)) * intBallSpeed
        picBall.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
    End Sub

    'Reset Scores
    Public Sub resetScores()
        intPlayerScore = 0
        intCompScore = 0
        lblPlayerScore.Text = intPlayerScore
        lblCompScore.Text = intCompScore
    End Sub

    'Gets Achievement Status
    Public Function getAchievementStatus(ByVal strStatus As String)
        Dim booReturn As Boolean

        Select Case strStatus
            Case "hard"
                Return booHard
            Case "Impossible"
                Return booImpossible
        End Select

        Return booReturn
    End Function
End Class