<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPong
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picPlayerPaddle = New System.Windows.Forms.PictureBox()
        Me.picCompPaddle = New System.Windows.Forms.PictureBox()
        Me.picLine = New System.Windows.Forms.PictureBox()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.lblCompScore = New System.Windows.Forms.Label()
        Me.picBall = New System.Windows.Forms.PictureBox()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.lblPForPauseLabel = New System.Windows.Forms.Label()
        Me.picAchievement = New System.Windows.Forms.PictureBox()
        Me.lblAchievementName = New System.Windows.Forms.Label()
        CType(Me.picPlayerPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCompPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAchievement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayerPaddle
        '
        Me.picPlayerPaddle.BackColor = System.Drawing.Color.White
        Me.picPlayerPaddle.Location = New System.Drawing.Point(10, 216)
        Me.picPlayerPaddle.Name = "picPlayerPaddle"
        Me.picPlayerPaddle.Size = New System.Drawing.Size(10, 40)
        Me.picPlayerPaddle.TabIndex = 0
        Me.picPlayerPaddle.TabStop = False
        '
        'picCompPaddle
        '
        Me.picCompPaddle.BackColor = System.Drawing.Color.White
        Me.picCompPaddle.Location = New System.Drawing.Point(570, 216)
        Me.picCompPaddle.Name = "picCompPaddle"
        Me.picCompPaddle.Size = New System.Drawing.Size(10, 40)
        Me.picCompPaddle.TabIndex = 1
        Me.picCompPaddle.TabStop = False
        '
        'picLine
        '
        Me.picLine.BackColor = System.Drawing.Color.White
        Me.picLine.Location = New System.Drawing.Point(294, 12)
        Me.picLine.Name = "picLine"
        Me.picLine.Size = New System.Drawing.Size(5, 450)
        Me.picLine.TabIndex = 2
        Me.picLine.TabStop = False
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.AutoSize = True
        Me.lblPlayerScore.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerScore.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerScore.ForeColor = System.Drawing.Color.White
        Me.lblPlayerScore.Location = New System.Drawing.Point(108, 19)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(74, 77)
        Me.lblPlayerScore.TabIndex = 3
        Me.lblPlayerScore.Text = "0"
        '
        'lblCompScore
        '
        Me.lblCompScore.AutoSize = True
        Me.lblCompScore.BackColor = System.Drawing.Color.Transparent
        Me.lblCompScore.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompScore.ForeColor = System.Drawing.Color.White
        Me.lblCompScore.Location = New System.Drawing.Point(414, 19)
        Me.lblCompScore.Name = "lblCompScore"
        Me.lblCompScore.Size = New System.Drawing.Size(74, 77)
        Me.lblCompScore.TabIndex = 4
        Me.lblCompScore.Text = "0"
        '
        'picBall
        '
        Me.picBall.BackColor = System.Drawing.Color.White
        Me.picBall.Location = New System.Drawing.Point(289, 228)
        Me.picBall.Name = "picBall"
        Me.picBall.Size = New System.Drawing.Size(10, 10)
        Me.picBall.TabIndex = 5
        Me.picBall.TabStop = False
        '
        'tmrGame
        '
        Me.tmrGame.Enabled = True
        '
        'lblPForPauseLabel
        '
        Me.lblPForPauseLabel.AutoSize = True
        Me.lblPForPauseLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblPForPauseLabel.ForeColor = System.Drawing.Color.White
        Me.lblPForPauseLabel.Location = New System.Drawing.Point(12, 451)
        Me.lblPForPauseLabel.Name = "lblPForPauseLabel"
        Me.lblPForPauseLabel.Size = New System.Drawing.Size(140, 13)
        Me.lblPForPauseLabel.TabIndex = 6
        Me.lblPForPauseLabel.Text = "Press ESC - Pause/ Options"
        '
        'picAchievement
        '
        Me.picAchievement.BackColor = System.Drawing.Color.Transparent
        Me.picAchievement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picAchievement.Location = New System.Drawing.Point(397, 411)
        Me.picAchievement.Name = "picAchievement"
        Me.picAchievement.Size = New System.Drawing.Size(183, 50)
        Me.picAchievement.TabIndex = 7
        Me.picAchievement.TabStop = False
        '
        'lblAchievementName
        '
        Me.lblAchievementName.AutoSize = True
        Me.lblAchievementName.BackColor = System.Drawing.Color.Transparent
        Me.lblAchievementName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAchievementName.ForeColor = System.Drawing.Color.White
        Me.lblAchievementName.Location = New System.Drawing.Point(408, 428)
        Me.lblAchievementName.Name = "lblAchievementName"
        Me.lblAchievementName.Size = New System.Drawing.Size(101, 20)
        Me.lblAchievementName.TabIndex = 9
        Me.lblAchievementName.Text = "Achievement"
        '
        'frmPong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(592, 473)
        Me.Controls.Add(Me.lblAchievementName)
        Me.Controls.Add(Me.picAchievement)
        Me.Controls.Add(Me.lblPForPauseLabel)
        Me.Controls.Add(Me.picBall)
        Me.Controls.Add(Me.lblCompScore)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.picLine)
        Me.Controls.Add(Me.picCompPaddle)
        Me.Controls.Add(Me.picPlayerPaddle)
        Me.Name = "frmPong"
        Me.Text = "Pong"
        CType(Me.picPlayerPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCompPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAchievement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPlayerPaddle As System.Windows.Forms.PictureBox
    Friend WithEvents picCompPaddle As System.Windows.Forms.PictureBox
    Friend WithEvents picLine As System.Windows.Forms.PictureBox
    Friend WithEvents lblPlayerScore As System.Windows.Forms.Label
    Friend WithEvents lblCompScore As System.Windows.Forms.Label
    Friend WithEvents picBall As System.Windows.Forms.PictureBox
    Friend WithEvents tmrGame As System.Windows.Forms.Timer
    Friend WithEvents lblPForPauseLabel As System.Windows.Forms.Label
    Friend WithEvents picAchievement As System.Windows.Forms.PictureBox
    Friend WithEvents lblAchievementName As System.Windows.Forms.Label

End Class
