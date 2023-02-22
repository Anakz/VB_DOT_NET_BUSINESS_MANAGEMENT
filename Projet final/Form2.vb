Public Class Form2

    Private Sub Afficher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Afficher.Click
        Dim j As Integer = 0
        Dim p As Integer = 0
        ListBox1.Items.Clear()
        For j = 0 To Form1.i - 1
            If TextBox1.Text = Form1.t(j).c Then
                ListBox1.Items.Add("=============================")
                ListBox1.Items.Add("produit :" & j + 1)
                ListBox1.Items.Add("Réf:" & Form1.t(j).ref)
                ListBox1.Items.Add("Désignation:" & Form1.t(j).de)
                ListBox1.Items.Add("Description:" & Form1.t(j).d)
                ListBox1.Items.Add("Catégorie:" & Form1.t(j).c)
                ListBox1.Items.Add("Prix de vente:" & Form1.t(j).pdv)
                ListBox1.Items.Add("Date de vente:" & Form1.t(j).dv)
                ListBox1.Items.Add("Quantité:" & Form1.t(j).q)
                ListBox1.Items.Add("Remise:" & Form1.t(j).r)
                p = 1
            End If
        Next j
        If j = Form1.i And p = 0 Then
            MsgBox("Cette catégorie n'existe pas")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
        TextBox1.Text = ""
        ListBox1.Items.Clear()
    End Sub
End Class