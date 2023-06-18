Public Class Form1


    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaTopCliente()
        pnCentral.Focus()
    End Sub

    Private Sub imgSair_Click(sender As Object, e As EventArgs) Handles imgSair.Click
        Application.Exit()
    End Sub

    Private Sub PCarregaTopCliente()
        With dvgTopClientes
            .Rows.Add(1, "Tiago Barreto", "R$6.500,00", "Ativo")
            .Rows.Add(2, "Augsto Farias", "R$2.300,00", "Ativo")
            .Rows.Add(3, "Lorena Barreto", "R$4.250,00", "Ativo")
            .Rows.Add(4, "Daniela Magalhães", "R$1.758,00", "Intivo")
            .Rows.Add(5, "Stive Wander", "R$2.600,00", "Ativo")
        End With
    End Sub


End Class
