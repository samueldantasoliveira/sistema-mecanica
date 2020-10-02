Public Class Form5
    Public Property DoCmd As Object

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call carrega_dados_serviços()
        txt_cpf.Text = id
        txt_cliente.Text = cliente


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_cpf_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs)
        Try
            sql = "select * from CLIENTES where CPF='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_cliente.Text = rs.Fields(1).Value + " " + rs.Fields(2).Value
            Else
                MsgBox("CPF NÃO ENCONTRADO")
                txt_cpf.Focus()
                txt_cpf.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar !!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub Form5_MinimumSizeChanged(sender As Object, e As EventArgs) Handles Me.MinimumSizeChanged

    End Sub

    Private Sub Form5_Enter(sender As Object, e As EventArgs) Handles Me.Enter


    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_outros.MaskInputRejected

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_servico.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_servico.SelectedValueChanged
        If cmb_servico.Text = "Outros" Then
            txt_outros.Enabled = True
            txt_valor.Enabled = True
        Else
            txt_outros.Enabled = False
            txt_valor.Enabled = False
            If cmb_servico.Text = "Revisão" Then
                txt_valor.Text = "550,00"
            End If
            If cmb_servico.Text = "Troca de óleo" Then
                txt_valor.Text = "50,00"
            End If
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected_1(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_valor.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_valor.TextChanged

    End Sub

    Private Sub txt_valor_LostFocus(sender As Object, e As EventArgs) Handles txt_valor.LostFocus
        If txt_valor.Text = String.Empty Then
            txt_valor.Text = 0
        End If
        txt_valor.Text = FormatCurrency(txt_valor.Text, 2, TriState.True, TriState.True,
                                    TriState.True).Replace("R$", "").Trim
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        id = 1
        rs.MoveFirst()

        While rs.EOF = False
            rs.MoveNext()
            id = id + 1

        End While


        If cmb_servico.Text = "Outros" Then
            If txt_nome.Text = "" Or txt_descrição.Text = "" Or txt_cliente.Text = "" Or txt_cor.Text = "" Or txt_placa.Text = "" Or txt_outros.Text = "" Or txt_valor.Text = "" Then
                MsgBox("Preencha os campos corretamente")
            Else

                status = "True"
                sql = "insert into Serviços values ('" & id & "'," &
                                                                  "'" & txt_placa.Text & "', " &
                                                                  "'" & txt_cor.Text & "', " &
                                                                  "'" & txt_nome.Text & "', " &
                                                                  "'" & txt_outros.Text & "', " &
                                                                  "'" & txt_valor.Text & "', " &
                                                                  "'" & status & "', " &
                                                                  "'" & txt_descrição.Text & "', " &
                                                                  "'" & txt_cpf.Text & "', " &
                                                                  "'" & txt_data.Text & "')"
                rs = db.Execute(UCase(sql))
                    carrega_dados_serviços()
                    MsgBox("Dados gravados com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)


            End If

        Else
            If txt_nome.Text = "" Or txt_descrição.Text = "" Or txt_cliente.Text = "" Or txt_cor.Text = "" Or txt_placa.Text = "" Or (cmb_servico.Text = "Outros" And txt_outros.Text = "") Or txt_valor.Text = "" Then
                MsgBox("Preencha os campos corretamente")
            Else
                Try
                    status = "True"
                    sql = "insert into Serviços values ('" & id & "'," &
                                                                  "'" & txt_placa.Text & "', " &
                                                                  "'" & txt_cor.Text & "', " &
                                                                  "'" & txt_nome.Text & "', " &
                                                                  "'" & cmb_servico.Text & "', " &
                                                                  "'" & txt_valor.Text & "', " &
                                                                  "'" & status & "', " &
                                                                  "'" & txt_descrição.Text & "', " &
                                                                  "'" & txt_cpf.Text & "', " &
                                                                  "'" & txt_data.Text & "')"
                    rs = db.Execute(UCase(sql))
                    carrega_dados_serviços()
                    MsgBox("Dados gravados com sucesso!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Catch ex As Exception
                    MsgBox("ERRO AO GRAVAR")
                End Try


            End If





        End If


    End Sub

    Private Sub dg_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_dados.CellContentClick
        With dg_dados

            If .CurrentRow.Cells(6).Selected = True Then
                aux = .CurrentRow.Cells(0).Value
                aux2 = .CurrentRow.Cells(1).Value
                aux3 = .CurrentRow.Cells(7).Value


                resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                             "O serviço de " & aux2 & " Do cpf: " & aux & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete * from Serviços where ID='" & aux3 & "'"
                    rs = db.Execute(sql)
                    carrega_dados_serviços()
                End If




            End If
        End With
    End Sub

    Private Sub txt_busca_Click(sender As Object, e As EventArgs) Handles txt_busca.Click

    End Sub

    Private Sub txt_busca_Disposed(sender As Object, e As EventArgs) Handles txt_busca.Disposed

    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            With dg_dados
                sql = "select * from Serviços where " & cmb_tipo.Text & " like '" & txt_busca.Text & "%' order by ID asc"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(8).Value, rs.Fields(5).Value, rs.Fields(4).Value, rs.Fields(1).Value, rs.Fields(7), rs.Fields(9).Value, rs.Fields(6).Value, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("ERRO ao Consultar")
        End Try
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Form6()
        f.TopMost = True
        f.Show()

    End Sub

    Private Sub Form5_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form3.Show()
    End Sub

End Class