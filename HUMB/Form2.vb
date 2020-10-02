Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CONTASDataSet1.CONTAS' table. You can move, or remove it, as needed.
        carrega_dados_grid()


    End Sub

    Private Sub dg_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_dados.CellContentClick

        With dg_dados
            If .CurrentRow.Cells(3).Selected = True Then
                aux = .CurrentRow.Cells(0).Value
                resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                             "O USUARIO " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete * from CONTAS where USUARIO='" & aux & "'"
                    rs = db.Execute(sql)
                    carrega_dados_grid()
                End If
            Else
                Exit Sub
                End If




            End With



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Txt_usuario.Text = "" Or txt_senha.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Preencha os campos corretamente")
            Else
                sql = "insert into CONTAS values ('" & Txt_usuario.Text & "', " &
                                                                  "'" & txt_senha.Text & "', " &
                                                                  "'" & ComboBox1.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                carrega_dados_grid()
                Txt_usuario.Clear()
                txt_senha.Clear()
                Txt_usuario.Focus()
            End If

        Catch ex As Exception
            MsgBox("Erro ao Gravar !!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class