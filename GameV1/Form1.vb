Public Class Form1
    Dim r As New Random
    Dim score As Integer
    Dim time As Integer

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Badguy.Click

    End Sub
    Sub randmove(p As PictureBox)
        Dim x As Integer
        Dim y As Integer
        x = r.Next(-5, 10)
        y = r.Next(-5, 10)
        MoveTo(p, x, y)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        randmove(Badguy)
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles ninja.Click
        ninja.Location = New Point(ninja.Location.X + 3 = ninja.Location.Y)
        If Collision(ninja, "wall") Then
            MsgBox("out of bounds")
        End If
        If Collision(Badguy, "wall") Then
            MsgBox("out of bounds")
        End If
    End Sub

    Sub follow(p As PictureBox, x As Integer, y As Integer)

    End Sub

    Private Sub Form1_keydown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown


        Select Case e.KeyCode
            Case Keys.R
                ninja.Image.RotateFlip(RotateFlipType.Rotate90FlipX)
                Me.Refresh()

            Case Keys.Up
                MoveTo(ninja, 0, -5)

            Case Keys.Down
                MoveTo(ninja, 0, 5)

            Case Keys.Left
                MoveTo(ninja, 5, 0)

            Case Keys.Right
                MoveTo(ninja, -5, 0)

            Case Keys.Space
                ninjastar.Location = ninja.Location
                ninjastar.Visible = True

        End Select

    End Sub

    Private Sub PictureBox2_Click_2(sender As Object, e As EventArgs)

    End Sub

    Public Sub X()

        Dim bdir As Integer = 6
        If ninjastar.Location.X < 0 Then
            bdir = 5

        End If
        If ninjastar.Location.X > 3000 Then
            bdir = -5
        End If
    End Sub
    Public Sub follow(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > Badguy.Location.X Then
            x = -5
        Else
            x = 5
        End If
        MoveTo(p, x, 0)
        If p.Location.Y < Badguy.Location.Y Then
            y = 5
        Else
            y = -5
        End If
        MoveTo(p, x, y)
    End Sub



    Function Collision(p As PictureBox, t As String, Optional ByRef other As Object = vbNull)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If obj.Visible AndAlso p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
                other = obj
            End If
        Next
        Return col
    End Function

    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)


        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If

        If p.Name = "ninjastar" And Collision(p, "Badguy") Then
            score += 1

        End If


    End Sub

    Private Sub ninjastar_Click(sender As Object, e As EventArgs) Handles ninjastar.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MoveTo(ninjastar, -20, 0)
        ninjastar.Image.RotateFlip(RotateFlipType.Rotate90FlipX)


        score_label.Text = score
        If score = 50 Then
            MsgBox("YOU WIN!")
            Me.BackColor = Color.Green
            Me.Visible = True
        End If


    End Sub

    Sub CreateNew(name As String, pic As PictureBox, location As Point)
        Dim p As New PictureBox
        p.Location = location
        p.Image = pic.Image
        p.BackColor = pic.BackColor
        p.Name = name
        p.Width = pic.Width
        p.Height = pic.Height
        p.SizeMode = PictureBoxSizeMode.StretchImage
        Controls.Add(p)

    End Sub


End Class




