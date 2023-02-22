Public Class Form1
    Structure Produit
        Dim ref As Integer
        Dim de As String
        Dim d As String
        Dim c As String
        Dim pdv As Double
        Dim dv As Date
        Dim q As Integer
        Dim r As Integer
    End Structure
    Public t(100) As Produit
    Public i As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If i = 100 Then
            MessageBox.Show("impossible d'ajouter un produit")
        Else
            With t(i)
                .ref = TextBox1.Text
                .de = TextBox2.Text
                .d = TextBox3.Text
                .c = TextBox4.Text
                .pdv = TextBox5.Text
                .dv = TextBox6.Text
                .q = TextBox7.Text
                .r = TextBox8.Text
            End With
            i = i + 1
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As Integer
        Dim b As Integer = 0
        Dim p As Integer = 0
        a = InputBox("entrez la reference du produit")
        While p < i And b = 0
            If t(p).ref = a Then
                TextBox1.Text = a
                TextBox2.Text = t(p).de
                TextBox3.Text = t(p).d
                TextBox4.Text = t(p).c
                TextBox5.Text = t(p).pdv
                TextBox6.Text = t(p).dv
                TextBox7.Text = t(p).q
                TextBox8.Text = t(p).r
                b = 1
            End If
            p = p + 1
        End While
        If b = 0 Then
            MessageBox.Show("le produit n'existe pas")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ca As Double = 0
        Dim c As Integer
        For c = 0 To i - 1
            ca = ca + t(c).pdv * t(c).q
        Next c
        MessageBox.Show("le chiffre d'affaire du produit : " & ca)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub
    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MsgBox("Voulez vous quitter", MsgBoxStyle.YesNo, "Quitter") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
