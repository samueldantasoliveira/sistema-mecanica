Public Class Form3
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub dg_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_dados.CellContentClick
        With dg_dados
            If .CurrentRow.Cells(5).Selected = True Then
                id = .CurrentRow.Cells(0).Value
                cliente = .CurrentRow.Cells(1).Value + " " + .CurrentRow.Cells(2).Value
                Form5.Show()
                Me.Hide()


            End If
            If .CurrentRow.Cells(7).Selected = True Then
                aux = .CurrentRow.Cells(0).Value

                resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                             "O CLIENTE DE CPF " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete * from CLIENTES where CPF='" & aux & "'"
                    rs = db.Execute(sql)
                    carrega_dados_clientes()
                End If

            End If

            If .CurrentRow.Cells(6).Selected = True Then
                aux = .CurrentRow.Cells(0).Value
                sql = "select * from CLIENTES where CPF='" & aux & "'"
                rs = db.Execute(sql)

                id = rs.Fields(0).Value
                TabControl1.SelectTab(0)
                txt_cpf.Text = rs.Fields(0).Value
                txt_nome.Text = rs.Fields(1).Value
                txt_sobrenome.Text = rs.Fields(2).Value
                txt_fixo.Text = rs.Fields(3).Value
                txt_celular.Text = rs.Fields(4).Value



            End If




        End With
    End Sub

    Private Sub txt_fixo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try


            While rs.EOF = False
                rs.MoveNext()
                id = id + 1

            End While

            If txt_cpf.Text = "" Or txt_nome.Text = "" Or txt_sobrenome.Text = "" Or txt_fixo.Text = "" Or txt_celular.Text = "" Then
                MsgBox("Preencha os campos corretamente")
            Else
                sql = "insert into CLIENTES (CPF, Primeiro_nome, sobrenome, fixo, Celular) values ('" & txt_cpf.Text & "'," &
                                                          "'" & txt_nome.Text & "', " &
                                                          "'" & txt_sobrenome.Text & "', " &
                                                          "'" & txt_fixo.Text & "', " &
                                                          "'" & txt_celular.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                carrega_dados_clientes()
                txt_cpf.Clear()
                txt_nome.Clear()
                txt_sobrenome.Clear()
                txt_fixo.Clear()
                txt_celular.Clear()
                txt_cpf.Focus()


            End If

        Catch ex As Exception
            MsgBox("Erro ao gravar dados")
        End Try




    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carrega_dados_clientes()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_editar.Click


        sql = "update CLIENTES set Primeiro_nome='" & txt_nome.Text & "', sobrenome='" & txt_sobrenome.Text & "', fixo='" & txt_fixo.Text & "', Celular='" & txt_celular.Text & "'where CPF='" & id & "'"

        rs = db.Execute(UCase(sql))
        MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        carrega_dados_clientes()


    End Sub

    Private Sub txt_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_nome.TextChanged

    End Sub

    Private Sub txt_sobrenome_TextChanged(sender As Object, e As EventArgs) Handles txt_sobrenome.TextChanged

    End Sub

    Private Sub txt_fixo_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_fixo.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_celular.MaskInputRejected

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_cpf.MaskInputRejected

    End Sub

    Private Sub txt_cpf_lostFocus()

    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            sql = "select * from CLIENTES where CPF='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_nome.Text = rs.Fields(1).Value
                txt_sobrenome.Text = rs.Fields(2).Value
                txt_fixo.Text = rs.Fields(3).Value
                txt_celular.Text = rs.Fields(4).Value
            Else
                txt_nome.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar !!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()

    End Sub

    Private Sub txt_busca_Click(sender As Object, e As EventArgs) Handles txt_busca.Click




    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            With dg_dados
                sql = "select * from CLIENTES where " & cmb_tipo.Text & " like '" & txt_busca.Text & "%' order by Primeiro_nome asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("ERRO ao Consultar")
        End Try


    End Sub

    Private Sub txt_cpf_GotFocus(sender As Object, e As EventArgs) Handles txt_cpf.GotFocus
        txt_nome.Text = ""
        txt_sobrenome.Text = ""
        txt_cpf.Text = ""
        txt_fixo.Text = ""
        txt_celular.Text = ""

    End Sub
End Class