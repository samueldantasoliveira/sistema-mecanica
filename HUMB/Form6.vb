Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CONTASDataSet3.Serviços' table. You can move, or remove it, as needed.
        Me.ServiçosTableAdapter.Fill(Me.CONTASDataSet.Serviços)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class