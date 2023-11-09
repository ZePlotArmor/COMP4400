Public Class CardListDisplay
    Private Sub CardListDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'COMP4400DataSet.CardList' table. You can move, or remove it, as needed.
        Me.CardListTableAdapter.Fill(Me.COMP4400DataSet.CardList)

    End Sub

    Private Sub btnDE_Click(sender As Object, e As EventArgs) Handles btnDE.Click
        CardListBindingSource.Filter = "Nation like 'Dragon Empire'"
    End Sub

    Private Sub btnDS_Click(sender As Object, e As EventArgs) Handles btnDS.Click
        CardListBindingSource.Filter = "Nation like 'Dark States'"
    End Sub

    Private Sub btnKS_Click(sender As Object, e As EventArgs) Handles btnKS.Click
        CardListBindingSource.Filter = "Nation like 'Keter Sanctuary'"
    End Sub

    Private Sub btnStoi_Click(sender As Object, e As EventArgs) Handles btnStoi.Click
        CardListBindingSource.Filter = "Nation like 'Stoicheia'"
    End Sub

    Private Sub btnBG_Click(sender As Object, e As EventArgs) Handles btnBG.Click
        CardListBindingSource.Filter = "Nation like 'Brandt Gate'"
    End Sub

    Private Sub btnLM_Click(sender As Object, e As EventArgs) Handles btnLM.Click
        CardListBindingSource.Filter = "Nation like 'Lyrical Monasterio'"
    End Sub

    Private Sub btnG0_Click(sender As Object, e As EventArgs) Handles btnG0.Click
        CardListBindingSource.Filter = "Grade like '0'"
    End Sub

    Private Sub btnG1_Click(sender As Object, e As EventArgs) Handles btnG1.Click
        CardListBindingSource.Filter = "Grade like '1'"
    End Sub

    Private Sub btnG2_Click(sender As Object, e As EventArgs) Handles btnG2.Click
        CardListBindingSource.Filter = "Grade like '2'"
    End Sub

    Private Sub btnG3_Click(sender As Object, e As EventArgs) Handles btnG3.Click
        CardListBindingSource.Filter = "Grade like '3'"
    End Sub

    Private Sub btnG4_Click(sender As Object, e As EventArgs) Handles btnG4.Click
        CardListBindingSource.Filter = "Grade like '4'"
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        CardListBindingSource.RemoveFilter()
    End Sub
End Class
