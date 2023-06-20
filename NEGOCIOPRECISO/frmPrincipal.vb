Imports System.Xml

Public Class frmPrincipal


    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaTopCliente()
        pnCentral.Focus()
    End Sub

    Private Sub imgSair_Click(sender As Object, e As EventArgs) Handles imgSair.Click
        Application.Exit()
    End Sub

    Private Sub PCarregaTopCliente()

        With dvgTopClientes.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(dvgTopClientes.Font, FontStyle.Bold)
        End With

        With dvgTopClientes
            .Rows.Add(1, "Tiago Barreto", "R$6.500,00", "R23.200,00", "Ativo")
            .Rows.Add(2, "Augsto Farias", "R$2.300,00", "R18.700,00", "Ativo")
            .Rows.Add(3, "Davi Lucas", "R$4.250,00", "R25.000,00", "Ativo")
            .Rows.Add(4, "Daniela Magalhães", "R$1.758,00", "R19.450,12", "Intivo")
            .Rows.Add(5, "Stive Wander", "R$2.600,00", "R21.030,33", "Ativo")
            .BackgroundColor = Color.WhiteSmoke


        End With
    End Sub

    Private Sub PicAjuda_Click(sender As Object, e As EventArgs) Handles PicAjuda.Click
        frmAjuda.ShowDialog()
    End Sub

    Private Sub PicSobre_Click(sender As Object, e As EventArgs) Handles PicSobre.Click
        frmSobre.ShowDialog()
    End Sub

    Private Sub dvgTopClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgTopClientes.CellContentClick

    End Sub

    'Private Sub dvgTopClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgTopClientes.CellFormatting
    'Formata  as linhas do datagridView
    'If dvgTopClientes.Columns(e.ColumnIndex).Name = "status" Then
    'If e.Equals("Ativo") Then
    ' e.ForeColor = Color.Dark
    'End If
    'End If

    'End Sub
End Class
