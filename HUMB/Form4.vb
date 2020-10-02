Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carrega_dados_mecanico()
    End Sub

    Private Sub dg_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_dados.CellContentClick
        With dg_dados
            If .CurrentRow.Cells(7).Selected = True Then
                'sql = "update from Serviços set Status=".currentRow.cell(6).value " where ID=" & .CurrentRow.Cells(0).Value & ")"
                If .CurrentRow.Cells(7).Value = True Then
                    jesus = "FALSE"

                    sql = "update Serviços set Status='" & jesus & "'where ID='" & .CurrentRow.Cells(0).Value & "'"
                    rs = db.Execute(sql)
                    Call carrega_dados_mecanico()


                Else
                    jesus = "TRUE"

                    sql = "update Serviços set Status='" & jesus & "' where ID='" & .CurrentRow.Cells(0).Value & "'"
                    rs = db.Execute(sql)
                    Call carrega_dados_mecanico()

                End If



                MsgBox("Status alterado")


            End If
        End With
    End Sub

    Private Sub Form4_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()

    End Sub
End Class