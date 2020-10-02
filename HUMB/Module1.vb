Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public god As Boolean
    Public jesus, status, cliente, id, sql, diretorio, resp, aux, aux2, aux3 As String
    Public conexao = Application.StartupPath & "\BANCO\CONTAS.mdb"
    Public cont, contador_id As Long
    Public Data_hoje As DateTime = DateTime.Now

    Sub conecta_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.jet.OLEDB.4.0;Data Source=" & conexao)
            contador_id = 0
        Catch ex As Exception
            MsgBox("ERRO ao Conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try
    End Sub
    Sub carrega_dados_grid()
        Try
            With Form2.dg_dados
                sql = "select * from CONTAS" 'Ordem alfabética de registros
                rs = db.Execute(sql)
                cont = 1 'Controle de linhas
                .Rows.Clear() 'Limpar linhas do dg_dados
                Do While rs.EOF = False 'Enquanto existir registros faça
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value)
                    'Alimentar colunas do dg_dados, Nothing significa icones nas colunas
                    rs.MoveNext() 'Mover para a próxima linha da tabela
                    cont = cont + 1 'Contar números de linhas
                Loop
            End With

        Catch ex As Exception
            MsgBox("Erro ao Processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try




    End Sub
    Sub carrega_dados_clientes()
        Try
            With Form3.dg_dados
                sql = "select * from CLIENTES" 'Ordem alfabética de registros
                rs = db.Execute(sql)
                .Rows.Clear() 'Limpar linhas do dg_dados
                Do While rs.EOF = False 'Enquanto existir registros faça
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                    'Alimentar colunas do dg_dados, Nothing significa icones nas colunas
                    rs.MoveNext() 'Mover para a próxima linha da tabela
                    cont = cont + 1 'Contar números de linhas
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao Carregar dados dos clientes")
        End Try









    End Sub

    Sub carrega_dados_serviços()
        With Form5.dg_dados
            sql = "select * from Serviços" 'Ordem alfabética de registros
            rs = db.Execute(sql)
            .Rows.Clear() 'Limpar linhas do dg_dados
            Do While rs.EOF = False 'Enquanto existir registros faça
                .Rows.Add(rs.Fields(8).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(1).Value, rs.Fields(9).Value, rs.Fields(6).Value, Nothing, rs.Fields(0).Value)
                'Alimentar colunas do dg_dados, Nothing significa icones nas colunas
                rs.MoveNext() 'Mover para a próxima linha da tabela
                cont = cont + 1 'Contar números de linhas
            Loop

        End With
    End Sub
    Sub carrega_dados_mecanico()
        With Form4.dg_dados

            sql = "select * from Serviços" 'Ordem alfabética de registros
            rs = db.Execute(sql)

            rs.MoveFirst()
            .Rows.Clear() 'Limpar linhas do dg_dados

            Do While rs.EOF = False 'Enquanto existir registros faça
                If rs.Fields(6).Value = "TRUE" Then
                    god = True
                Else
                    god = False
                End If
                .Rows.Add(rs.Fields(0).Value, rs.Fields(8).Value, rs.Fields(3).Value, rs.Fields(1).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(9).Value, god)

                'Alimentar colunas do dg_dados, Nothing significa icones nas colunas
                rs.MoveNext() 'Mover para a próxima linha da tabela
                cont = cont + 1 'Contar números de linhas
            Loop

        End With
    End Sub
End Module
