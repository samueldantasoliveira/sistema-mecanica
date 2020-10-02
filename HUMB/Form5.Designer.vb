<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.dg_dados = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_salvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo = New System.Windows.Forms.ToolStripComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_data = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cor = New System.Windows.Forms.TextBox()
        Me.txt_descrição = New System.Windows.Forms.TextBox()
        Me.txt_valor = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_outros = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_servico = New System.Windows.Forms.ComboBox()
        Me.txt_cliente = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_placa = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serviço = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preço = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Placa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.N = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dg_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_dados
        '
        Me.dg_dados.AllowUserToAddRows = False
        Me.dg_dados.AllowUserToDeleteRows = False
        Me.dg_dados.AllowUserToResizeColumns = False
        Me.dg_dados.AllowUserToResizeRows = False
        Me.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CPF, Me.Serviço, Me.Preço, Me.Placa, Me.DATA, Me.txt_status, Me.Excluir, Me.N})
        Me.dg_dados.Location = New System.Drawing.Point(0, 0)
        Me.dg_dados.Name = "dg_dados"
        Me.dg_dados.ReadOnly = True
        Me.dg_dados.Size = New System.Drawing.Size(620, 210)
        Me.dg_dados.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_salvar, Me.ToolStripLabel1, Me.txt_busca, Me.ToolStripLabel2, Me.cmb_tipo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(848, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_salvar
        '
        Me.btn_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_salvar.Image = CType(resources.GetObject("btn_salvar.Image"), System.Drawing.Image)
        Me.btn_salvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(23, 22)
        Me.btn_salvar.Text = "ToolStripButton1"
        Me.btn_salvar.ToolTipText = "GRAVAR"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(167, 22)
        Me.ToolStripLabel1.Text = "Digite um parâmetro de busca"
        '
        'txt_busca
        '
        Me.txt_busca.BackColor = System.Drawing.Color.RoyalBlue
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripLabel2.Text = "Selecione um tipo"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.Items.AddRange(New Object() {"CPF", "placa"})
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(121, 25)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl1.Location = New System.Drawing.Point(12, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(621, 231)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_data)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txt_cor)
        Me.TabPage1.Controls.Add(Me.txt_descrição)
        Me.TabPage1.Controls.Add(Me.txt_valor)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txt_outros)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.cmb_servico)
        Me.TabPage1.Controls.Add(Me.txt_cliente)
        Me.TabPage1.Controls.Add(Me.txt_cpf)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_placa)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_nome)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(613, 205)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Adicionar Serviço"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_data
        '
        Me.txt_data.Location = New System.Drawing.Point(409, 69)
        Me.txt_data.Mask = "00/00/0000"
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(100, 20)
        Me.txt_data.TabIndex = 37
        Me.txt_data.ValidatingType = GetType(Date)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(406, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Data"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Marca"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(276, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Cor"
        '
        'txt_cor
        '
        Me.txt_cor.Location = New System.Drawing.Point(279, 112)
        Me.txt_cor.Name = "txt_cor"
        Me.txt_cor.Size = New System.Drawing.Size(100, 20)
        Me.txt_cor.TabIndex = 3
        '
        'txt_descrição
        '
        Me.txt_descrição.Location = New System.Drawing.Point(12, 112)
        Me.txt_descrição.Name = "txt_descrição"
        Me.txt_descrição.Size = New System.Drawing.Size(223, 20)
        Me.txt_descrição.TabIndex = 2
        '
        'txt_valor
        '
        Me.txt_valor.Enabled = False
        Me.txt_valor.Location = New System.Drawing.Point(489, 163)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(100, 20)
        Me.txt_valor.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(486, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Valor em R$"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(167, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Outros:"
        '
        'txt_outros
        '
        Me.txt_outros.Enabled = False
        Me.txt_outros.Location = New System.Drawing.Point(170, 163)
        Me.txt_outros.Name = "txt_outros"
        Me.txt_outros.Size = New System.Drawing.Size(100, 20)
        Me.txt_outros.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Serviço"
        '
        'cmb_servico
        '
        Me.cmb_servico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_servico.FormattingEnabled = True
        Me.cmb_servico.Items.AddRange(New Object() {"Revisão", "Troca de óleo", "Outros"})
        Me.cmb_servico.Location = New System.Drawing.Point(26, 163)
        Me.cmb_servico.Name = "cmb_servico"
        Me.cmb_servico.Size = New System.Drawing.Size(121, 21)
        Me.cmb_servico.TabIndex = 24
        '
        'txt_cliente
        '
        Me.txt_cliente.AutoSize = True
        Me.txt_cliente.Location = New System.Drawing.Point(276, 27)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(0, 13)
        Me.txt_cliente.TabIndex = 23
        '
        'txt_cpf
        '
        Me.txt_cpf.AutoSize = True
        Me.txt_cpf.Location = New System.Drawing.Point(45, 24)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(0, 13)
        Me.txt_cpf.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(182, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nome do Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Placa"
        '
        'txt_placa
        '
        Me.txt_placa.Location = New System.Drawing.Point(279, 69)
        Me.txt_placa.Mask = "LLL-0000"
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(100, 20)
        Me.txt_placa.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "CPF:"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(12, 69)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(223, 20)
        Me.txt_nome.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do carro"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dg_dados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(613, 205)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gerenciar Serviços"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(686, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(668, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 45)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "RELATÓRIO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF"
        Me.CPF.Name = "CPF"
        Me.CPF.ReadOnly = True
        '
        'Serviço
        '
        Me.Serviço.HeaderText = "SERVIÇO"
        Me.Serviço.Name = "Serviço"
        Me.Serviço.ReadOnly = True
        '
        'Preço
        '
        Me.Preço.HeaderText = "PREÇO"
        Me.Preço.Name = "Preço"
        Me.Preço.ReadOnly = True
        '
        'Placa
        '
        Me.Placa.HeaderText = "PLACA"
        Me.Placa.Name = "Placa"
        Me.Placa.ReadOnly = True
        Me.Placa.Width = 70
        '
        'DATA
        '
        Me.DATA.HeaderText = "DATA"
        Me.DATA.Name = "DATA"
        Me.DATA.ReadOnly = True
        '
        'txt_status
        '
        Me.txt_status.HeaderText = "STATUS"
        Me.txt_status.Name = "txt_status"
        Me.txt_status.ReadOnly = True
        Me.txt_status.Width = 70
        '
        'Excluir
        '
        Me.Excluir.HeaderText = ""
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Excluir.Name = "Excluir"
        Me.Excluir.ReadOnly = True
        Me.Excluir.Width = 30
        '
        'N
        '
        Me.N.HeaderText = "ID"
        Me.N.Name = "N"
        Me.N.ReadOnly = True
        Me.N.Visible = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(848, 290)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SERVIÇOS"
        CType(Me.dg_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dg_dados As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_salvar As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_tipo As ToolStripComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_placa As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cpf As Label
    Friend WithEvents txt_cliente As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_outros As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_servico As ComboBox
    Friend WithEvents txt_valor As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cor As TextBox
    Friend WithEvents txt_descrição As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_data As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents Serviço As DataGridViewTextBoxColumn
    Friend WithEvents Preço As DataGridViewTextBoxColumn
    Friend WithEvents Placa As DataGridViewTextBoxColumn
    Friend WithEvents DATA As DataGridViewTextBoxColumn
    Friend WithEvents txt_status As DataGridViewTextBoxColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
    Friend WithEvents N As DataGridViewTextBoxColumn
End Class
