Public Class Form1
    '1H30 DE CODAGE
    ' FAZCODE 2019
    Shared random As New Random()


    '1 = Pierre
    '2 = Feuille
    '3 = Ciseaux

    'Pierre
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim ChoixBot As String

        'Le bot choissit son nombre 
        ChoixBot = Convert.ToString(random.Next(1, 4))

        Select Case ChoixBot
            Case "1"
                Label4.Text = Egalité()
            Case "2"
                Label4.Text = Perdu()
                Label2.Text = Label2.Text + 1
            Case "3"
                Label4.Text = Gagné()
                Label1.Text = Label1.Text + 1
        End Select

        Call Gagnant()

    End Sub

    'Feuille
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim ChoixBot As String

        'Le bot choissit son nombre 
        ChoixBot = Convert.ToString(random.Next(1, 4))

        Select Case ChoixBot
            Case "2"
                Label4.Text = Egalité()
            Case "3"
                Label4.Text = Perdu()
                Label2.Text = Label2.Text + 1
            Case "1"
                Label4.Text = Gagné()
                Label1.Text = Label1.Text + 1
        End Select

        Call Gagnant()
    End Sub

    'Ciseaux
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim ChoixBot As String

        'Le bot choissit son nombre 
        ChoixBot = Convert.ToString(random.Next(1, 4))

        Select Case ChoixBot
            Case "3"
                Label4.Text = Egalité()
            Case "1"
                Label4.Text = Perdu()
                Label2.Text = Label2.Text + 1
            Case "2"
                Label4.Text = Gagné()
                Label1.Text = Label1.Text + 1
        End Select

        Call Gagnant()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MsgBox(Gagné())
    End Sub



    Function Gagné()
        Dim char1Array As String() = New String() {"Ta gagné", "Bien joué", "Nice", "Gagné.", "CHAMPION !"}
        Return char1Array(random.Next(0, 5))
    End Function

    Function Perdu()
        Dim char1Array As String() = New String() {"Perdu tes nul :/", "Nonnnnn", "Ettt non.", "Perdu."}
        Return char1Array(random.Next(0, 4))
    End Function

    Function Egalité()
        Dim char1Array As String() = New String() {"Egalité", "Match nul", "Exéco"}
        Return char1Array(random.Next(0, 3))
    End Function


    Sub Gagnant()
        If Label2.Text = "3" Then
            MsgBox("Le robot a gagné !")
            Label1.Text = "0"
            Label2.Text = "0"
            Label4.Text = "Message"
        End If
        If Label1.Text = "3" Then
            MsgBox("Ta gagné !")
            Label1.Text = "0"
            Label2.Text = "0"
            Label4.Text = "Message"
        End If
    End Sub
End Class
