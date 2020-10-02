Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()



        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        sql = "Select * from CONTAS"
        rs = db.Execute(sql)
        While Not rs.EOF

            If rs.Fields(0).Value = (txt_usuario.Text.ToUpper()) And rs.Fields(1).Value = (txt_senha.Text.ToUpper()) Then
                If rs.Fields(2).Value = "ADMINISTRADOR" Then
                    Me.Hide()
                    Form2.Show()
                    MsgBox("ADMINISTRADOR LOGADO")
                    Exit Sub
                ElseIf rs.Fields(2).Value = "ATENDENTE" Then
                    Me.Hide()
                    Form3.Show()
                    MsgBox("ATENDENTE LOGADO")
                    Exit Sub
                ElseIf rs.Fields(2).Value = "MECÂNICO" Then
                    Me.Hide()
                    Form4.Show()
                    MsgBox("MECÂNICO LOGADO")
                    Exit Sub
                End If
            End If
            rs.MoveNext()
        End While
        MsgBox("USUARIO OU SENHA INVALIDOS")
        txt_usuario.Text = ""
        txt_senha.Text = ""
        txt_usuario.Focus()
        rs.MoveFirst()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()


        'Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        End
    End Sub

    Private Sub txt_senha_TextChanged(sender As Object, e As EventArgs) Handles txt_senha.TextChanged

    End Sub
End Class
