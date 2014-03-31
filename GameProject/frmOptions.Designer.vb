<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.grpDifficulty = New System.Windows.Forms.GroupBox()
        Me.radImpossible = New System.Windows.Forms.RadioButton()
        Me.radHard = New System.Windows.Forms.RadioButton()
        Me.radEasy = New System.Windows.Forms.RadioButton()
        Me.lblDifficultyLabel = New System.Windows.Forms.Label()
        Me.btnSaveOptions = New System.Windows.Forms.Button()
        Me.btnResetOptions = New System.Windows.Forms.Button()
        Me.lblControlsLabel = New System.Windows.Forms.Label()
        Me.grpControls = New System.Windows.Forms.GroupBox()
        Me.radArrows = New System.Windows.Forms.RadioButton()
        Me.radWASD = New System.Windows.Forms.RadioButton()
        Me.radMouse = New System.Windows.Forms.RadioButton()
        Me.btnResetGame = New System.Windows.Forms.Button()
        Me.btnResetBall = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.grpDifficulty.SuspendLayout()
        Me.grpControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDifficulty
        '
        Me.grpDifficulty.Controls.Add(Me.radImpossible)
        Me.grpDifficulty.Controls.Add(Me.radHard)
        Me.grpDifficulty.Controls.Add(Me.radEasy)
        Me.grpDifficulty.Location = New System.Drawing.Point(12, 26)
        Me.grpDifficulty.Name = "grpDifficulty"
        Me.grpDifficulty.Size = New System.Drawing.Size(95, 81)
        Me.grpDifficulty.TabIndex = 1
        Me.grpDifficulty.TabStop = False
        Me.grpDifficulty.Text = "GroupBox1"
        '
        'radImpossible
        '
        Me.radImpossible.AutoSize = True
        Me.radImpossible.Enabled = False
        Me.radImpossible.ForeColor = System.Drawing.Color.White
        Me.radImpossible.Location = New System.Drawing.Point(6, 55)
        Me.radImpossible.Name = "radImpossible"
        Me.radImpossible.Size = New System.Drawing.Size(74, 17)
        Me.radImpossible.TabIndex = 3
        Me.radImpossible.TabStop = True
        Me.radImpossible.Text = "Impossible"
        Me.radImpossible.UseVisualStyleBackColor = True
        '
        'radHard
        '
        Me.radHard.AutoSize = True
        Me.radHard.Enabled = False
        Me.radHard.ForeColor = System.Drawing.Color.White
        Me.radHard.Location = New System.Drawing.Point(6, 32)
        Me.radHard.Name = "radHard"
        Me.radHard.Size = New System.Drawing.Size(48, 17)
        Me.radHard.TabIndex = 2
        Me.radHard.TabStop = True
        Me.radHard.Text = "Hard"
        Me.radHard.UseVisualStyleBackColor = True
        '
        'radEasy
        '
        Me.radEasy.AutoSize = True
        Me.radEasy.ForeColor = System.Drawing.Color.White
        Me.radEasy.Location = New System.Drawing.Point(6, 9)
        Me.radEasy.Name = "radEasy"
        Me.radEasy.Size = New System.Drawing.Size(48, 17)
        Me.radEasy.TabIndex = 0
        Me.radEasy.TabStop = True
        Me.radEasy.Text = "Easy"
        Me.radEasy.UseVisualStyleBackColor = True
        '
        'lblDifficultyLabel
        '
        Me.lblDifficultyLabel.AutoSize = True
        Me.lblDifficultyLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblDifficultyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficultyLabel.ForeColor = System.Drawing.Color.White
        Me.lblDifficultyLabel.Location = New System.Drawing.Point(9, 7)
        Me.lblDifficultyLabel.Name = "lblDifficultyLabel"
        Me.lblDifficultyLabel.Size = New System.Drawing.Size(57, 16)
        Me.lblDifficultyLabel.TabIndex = 0
        Me.lblDifficultyLabel.Text = "Difficulty"
        '
        'btnSaveOptions
        '
        Me.btnSaveOptions.BackColor = System.Drawing.Color.White
        Me.btnSaveOptions.ForeColor = System.Drawing.Color.Black
        Me.btnSaveOptions.Location = New System.Drawing.Point(147, 16)
        Me.btnSaveOptions.Name = "btnSaveOptions"
        Me.btnSaveOptions.Size = New System.Drawing.Size(85, 23)
        Me.btnSaveOptions.TabIndex = 2
        Me.btnSaveOptions.Text = "Save Options"
        Me.btnSaveOptions.UseVisualStyleBackColor = False
        '
        'btnResetOptions
        '
        Me.btnResetOptions.BackColor = System.Drawing.Color.White
        Me.btnResetOptions.ForeColor = System.Drawing.Color.Black
        Me.btnResetOptions.Location = New System.Drawing.Point(147, 45)
        Me.btnResetOptions.Name = "btnResetOptions"
        Me.btnResetOptions.Size = New System.Drawing.Size(85, 23)
        Me.btnResetOptions.TabIndex = 3
        Me.btnResetOptions.Text = "Reset Options"
        Me.btnResetOptions.UseVisualStyleBackColor = False
        '
        'lblControlsLabel
        '
        Me.lblControlsLabel.AutoSize = True
        Me.lblControlsLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblControlsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControlsLabel.ForeColor = System.Drawing.Color.White
        Me.lblControlsLabel.Location = New System.Drawing.Point(9, 113)
        Me.lblControlsLabel.Name = "lblControlsLabel"
        Me.lblControlsLabel.Size = New System.Drawing.Size(57, 16)
        Me.lblControlsLabel.TabIndex = 4
        Me.lblControlsLabel.Text = "Controls"
        '
        'grpControls
        '
        Me.grpControls.Controls.Add(Me.radArrows)
        Me.grpControls.Controls.Add(Me.radWASD)
        Me.grpControls.Controls.Add(Me.radMouse)
        Me.grpControls.Location = New System.Drawing.Point(12, 132)
        Me.grpControls.Name = "grpControls"
        Me.grpControls.Size = New System.Drawing.Size(95, 81)
        Me.grpControls.TabIndex = 5
        Me.grpControls.TabStop = False
        Me.grpControls.Text = "GroupBox1"
        '
        'radArrows
        '
        Me.radArrows.AutoSize = True
        Me.radArrows.ForeColor = System.Drawing.Color.White
        Me.radArrows.Location = New System.Drawing.Point(6, 55)
        Me.radArrows.Name = "radArrows"
        Me.radArrows.Size = New System.Drawing.Size(78, 17)
        Me.radArrows.TabIndex = 2
        Me.radArrows.TabStop = True
        Me.radArrows.Text = "Arrow Keys"
        Me.radArrows.UseVisualStyleBackColor = True
        '
        'radWASD
        '
        Me.radWASD.AutoSize = True
        Me.radWASD.ForeColor = System.Drawing.Color.White
        Me.radWASD.Location = New System.Drawing.Point(6, 32)
        Me.radWASD.Name = "radWASD"
        Me.radWASD.Size = New System.Drawing.Size(58, 17)
        Me.radWASD.TabIndex = 1
        Me.radWASD.TabStop = True
        Me.radWASD.Text = "WASD"
        Me.radWASD.UseVisualStyleBackColor = True
        '
        'radMouse
        '
        Me.radMouse.AutoSize = True
        Me.radMouse.ForeColor = System.Drawing.Color.White
        Me.radMouse.Location = New System.Drawing.Point(6, 9)
        Me.radMouse.Name = "radMouse"
        Me.radMouse.Size = New System.Drawing.Size(57, 17)
        Me.radMouse.TabIndex = 0
        Me.radMouse.TabStop = True
        Me.radMouse.Text = "Mouse"
        Me.radMouse.UseVisualStyleBackColor = True
        '
        'btnResetGame
        '
        Me.btnResetGame.BackColor = System.Drawing.Color.White
        Me.btnResetGame.ForeColor = System.Drawing.Color.Black
        Me.btnResetGame.Location = New System.Drawing.Point(147, 103)
        Me.btnResetGame.Name = "btnResetGame"
        Me.btnResetGame.Size = New System.Drawing.Size(85, 23)
        Me.btnResetGame.TabIndex = 6
        Me.btnResetGame.Text = "Reset Game"
        Me.btnResetGame.UseVisualStyleBackColor = False
        '
        'btnResetBall
        '
        Me.btnResetBall.BackColor = System.Drawing.Color.White
        Me.btnResetBall.ForeColor = System.Drawing.Color.Black
        Me.btnResetBall.Location = New System.Drawing.Point(147, 74)
        Me.btnResetBall.Name = "btnResetBall"
        Me.btnResetBall.Size = New System.Drawing.Size(85, 23)
        Me.btnResetBall.TabIndex = 7
        Me.btnResetBall.Text = "Reset Ball"
        Me.btnResetBall.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.White
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.ForeColor = System.Drawing.Color.Black
        Me.btnQuit.Location = New System.Drawing.Point(147, 190)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(85, 23)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "Quit Game"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(244, 224)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnResetBall)
        Me.Controls.Add(Me.btnResetGame)
        Me.Controls.Add(Me.lblControlsLabel)
        Me.Controls.Add(Me.grpControls)
        Me.Controls.Add(Me.btnResetOptions)
        Me.Controls.Add(Me.btnSaveOptions)
        Me.Controls.Add(Me.lblDifficultyLabel)
        Me.Controls.Add(Me.grpDifficulty)
        Me.Name = "frmOptions"
        Me.Text = "Options"
        Me.grpDifficulty.ResumeLayout(False)
        Me.grpDifficulty.PerformLayout()
        Me.grpControls.ResumeLayout(False)
        Me.grpControls.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpDifficulty As System.Windows.Forms.GroupBox
    Friend WithEvents radImpossible As System.Windows.Forms.RadioButton
    Friend WithEvents radHard As System.Windows.Forms.RadioButton
    Friend WithEvents radEasy As System.Windows.Forms.RadioButton
    Friend WithEvents lblDifficultyLabel As System.Windows.Forms.Label
    Friend WithEvents btnSaveOptions As System.Windows.Forms.Button
    Friend WithEvents btnResetOptions As System.Windows.Forms.Button
    Friend WithEvents lblControlsLabel As System.Windows.Forms.Label
    Friend WithEvents grpControls As System.Windows.Forms.GroupBox
    Friend WithEvents radArrows As System.Windows.Forms.RadioButton
    Friend WithEvents radWASD As System.Windows.Forms.RadioButton
    Friend WithEvents radMouse As System.Windows.Forms.RadioButton
    Friend WithEvents btnResetGame As System.Windows.Forms.Button
    Friend WithEvents btnResetBall As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
End Class
