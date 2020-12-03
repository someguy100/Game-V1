<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ninjastar = New System.Windows.Forms.PictureBox()
        Me.ninja = New System.Windows.Forms.PictureBox()
        Me.Badguy = New System.Windows.Forms.PictureBox()
        Me.score_label = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ninjastar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ninja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Badguy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'ninjastar
        '
        Me.ninjastar.BackColor = System.Drawing.Color.Transparent
        Me.ninjastar.Image = Global.GameV1.My.Resources.Resources.ninjastar1
        Me.ninjastar.Location = New System.Drawing.Point(666, 222)
        Me.ninjastar.Name = "ninjastar"
        Me.ninjastar.Size = New System.Drawing.Size(66, 62)
        Me.ninjastar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ninjastar.TabIndex = 4
        Me.ninjastar.TabStop = False
        Me.ninjastar.Visible = False
        '
        'ninja
        '
        Me.ninja.BackColor = System.Drawing.Color.Transparent
        Me.ninja.Image = Global.GameV1.My.Resources.Resources.ninjasword1
        Me.ninja.Location = New System.Drawing.Point(633, 320)
        Me.ninja.Name = "ninja"
        Me.ninja.Size = New System.Drawing.Size(224, 179)
        Me.ninja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ninja.TabIndex = 2
        Me.ninja.TabStop = False
        '
        'Badguy
        '
        Me.Badguy.BackColor = System.Drawing.Color.Transparent
        Me.Badguy.Image = Global.GameV1.My.Resources.Resources.bad_guy_rat3
        Me.Badguy.Location = New System.Drawing.Point(178, 189)
        Me.Badguy.Name = "Badguy"
        Me.Badguy.Size = New System.Drawing.Size(116, 150)
        Me.Badguy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Badguy.TabIndex = 1
        Me.Badguy.TabStop = False
        '
        'score_label
        '
        Me.score_label.AutoSize = True
        Me.score_label.Location = New System.Drawing.Point(35, 29)
        Me.score_label.Name = "score_label"
        Me.score_label.Size = New System.Drawing.Size(39, 13)
        Me.score_label.TabIndex = 5
        Me.score_label.Text = "Label1"
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(783, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GameV1.My.Resources.Resources.floating_islands___animated_version_1
        Me.ClientSize = New System.Drawing.Size(902, 662)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.score_label)
        Me.Controls.Add(Me.ninjastar)
        Me.Controls.Add(Me.ninja)
        Me.Controls.Add(Me.Badguy)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ninjastar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ninja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Badguy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Badguy As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ninja As PictureBox
    Friend WithEvents ninjastar As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents score_label As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label1 As Label
End Class
