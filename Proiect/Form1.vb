Public Class Form1
    Dim moveleft As Boolean = True
    Dim moveright As Boolean = False
    Dim valoare As Integer
    Dim nr As Integer = 8
    Dim a = New Integer() {0, 1, 5, 10, 50, 100, 200, 500}
    Dim s As Integer
    Dim x(101) As Integer






    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub IesireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IesireToolStripMenuItem.Click

        ListBox1.Visible = False

        PictureBox1.Visible = False
        Dim answer As MsgBoxResult
        answer = MsgBox("Doriti sa parasiti Aplicatia?", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.Yes Then

            End
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Song, AudioPlayMode.Background)
        Timer1.Start()



    End Sub

    Private Sub InformatiiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformatiiToolStripMenuItem.Click


        PictureBox1.Visible = False
        ListBox1.Visible = False

        MessageBox.Show("Proiect realizat de Bujdei Mihai-Dan,3121A")
    End Sub

    Private Sub BaniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaniToolStripMenuItem.Click
        PictureBox1.Image = My.Resources._50banibun

        PictureBox1.Visible = True

    End Sub

    Private Sub LeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeuToolStripMenuItem.Click
        PictureBox1.Image = My.Resources._1leut
        PictureBox1.Visible = True


    End Sub

    Private Sub LeiToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles LeiToolStripMenuItem4.Click
        PictureBox1.Image = My.Resources._500lei_bun
        PictureBox1.Visible = True

    End Sub

    Private Sub LeiToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles LeiToolStripMenuItem3.Click
        PictureBox1.Image = My.Resources._200lei
        PictureBox1.Visible = True

    End Sub

    Private Sub LeiToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles LeiToolStripMenuItem2.Click
        PictureBox1.Image = My.Resources._100leibun
        PictureBox1.Visible = True
        Timer1.Start()


    End Sub

    Private Sub LeiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LeiToolStripMenuItem1.Click
        PictureBox1.Image = My.Resources._50lei
        PictureBox1.Visible = True

    End Sub

    Private Sub LeiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeiToolStripMenuItem.Click

        PictureBox1.Image = My.Resources._5leuti
        PictureBox1.Visible = True
        ListBox1.Visible = False
        Timer1.Start()



    End Sub

    Private Sub ManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualToolStripMenuItem.Click
        PictureBox1.Visible = False
        ListBox1.Visible = False



    End Sub

    Private Sub ReguliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReguliToolStripMenuItem.Click
        PictureBox1.Visible = False
        ListBox1.Visible = False


        MessageBox.Show("Aceasta aplicatie permite utilizatorilor sa introduca o valoare iar aplicatiia va afisa care este solutia optima pentru a plati aceea suma ")
    End Sub

    Private Sub JocNouToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JocNouToolStripMenuItem.Click
        PictureBox1.Visible = False






        If (valoare = 0) Then
            MessageBox.Show("Eroare.Introduceti o valoare")
        Else
            back(1)


        End If




    End Sub

    Private Sub BancnoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BancnoteToolStripMenuItem.Click
        Timer1.Start()
        ListBox1.Visible = False

        PictureBox1.Visible = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If moveleft = True Then
            PictureBox1.Left -= 20
        End If
        If PictureBox1.Left <= 0 Then
            moveleft = False
            moveright = True
        End If

        If moveright = True Then
            PictureBox1.Left += 20
        End If

        If moveright = True Then
            PictureBox1.Left += 1
        End If
        If PictureBox1.Left >= Me.Height - 60 Then
            moveleft = True
            moveright = False
        End If
    End Sub

    
    Private Sub SetareValoareToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SetareValoareToolStripMenuItem1.Click
       
        valoare = InputBox("Inserare valaore", "Atentie.Inserati tot timpul o valoare ")





    End Sub
    Public Sub tipar(ByVal k As Integer)

        Dim nrr As Integer
        Dim t As Integer = valoare + 10
        ListBox1.Visible = True

        ListBox1.Items.Add("Aveti grija algoritmul calculeaza valoare " & t)
        ListBox1.Items.Add("Solutia " & " Afisare :")
        ListBox1.Items.Add("Numarul de bancnote" & "       " & "De  valoarea")



        For i As Integer = 0 To 7
            ListBox1.Items.Add(x(i) & "                               " & "de            " & a(i) & " lei")


        Next


    End Sub

    Public Sub back(ByVal k As Integer)
        If (s = valoare) Then
            tipar(k - 1)
        Else
            x(k) = -1
            If (k < nr) Then
                While ((x(k) * a(k)) + s < valoare And k < nr)
                    x(k) = x(k) + 1
                    s = s + (x(k) * a(k))
                    back(k + 1)
                    s = s - (x(k) * a(k))

                End While

            End If
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class

