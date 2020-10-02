<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_celular = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fixo = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_sobrenome = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dg_dados = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Button3 = New System.Windows.Forms.ToolStripButton()
        Me.btn_editar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo = New System.Windows.Forms.ToolStripComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOBRENOME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIXO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CELULAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adicionar_Serviços = New System.Windows.Forms.DataGridViewImageColumn()
        Me.EDITAR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.EXCLUIR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dg_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(713, 173)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_cpf)
        Me.TabPage1.Controls.Add(Me.txt_celular)
        Me.TabPage1.Controls.Add(Me.txt_fixo)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.txt_sobrenome)
        Me.TabPage1.Controls.Add(Me.txt_nome)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(705, 147)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Adicionar Cliente"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "CPF"
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(72, 21)
        Me.txt_cpf.Mask = "000.000.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(223, 20)
        Me.txt_cpf.TabIndex = 16
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(213, 110)
        Me.txt_celular.Mask = "(00) 0000-0000"
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(82, 20)
        Me.txt_celular.TabIndex = 15
        '
        'txt_fixo
        '
        Me.txt_fixo.Location = New System.Drawing.Point(72, 110)
        Me.txt_fixo.Mask = "(00) 0000-0000"
        Me.txt_fixo.Name = "txt_fixo"
        Me.txt_fixo.Size = New System.Drawing.Size(82, 20)
        Me.txt_fixo.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Celular"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Telefone"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(198, 161)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Sair"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Salvar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_sobrenome
        '
        Me.txt_sobrenome.Location = New System.Drawing.Point(72, 84)
        Me.txt_sobrenome.Name = "txt_sobrenome"
        Me.txt_sobrenome.Size = New System.Drawing.Size(223, 20)
        Me.txt_sobrenome.TabIndex = 3
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(72, 52)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(223, 20)
        Me.txt_nome.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sobrenome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dg_dados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(705, 147)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gerenciar Clientes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dg_dados
        '
        Me.dg_dados.AllowUserToAddRows = False
        Me.dg_dados.AllowUserToDeleteRows = False
        Me.dg_dados.AllowUserToResizeColumns = False
        Me.dg_dados.AllowUserToResizeRows = False
        Me.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CPF, Me.NOME, Me.SOBRENOME, Me.FIXO, Me.CELULAR, Me.Adicionar_Serviços, Me.EDITAR, Me.EXCLUIR})
        Me.dg_dados.Location = New System.Drawing.Point(0, 0)
        Me.dg_dados.Name = "dg_dados"
        Me.dg_dados.ReadOnly = True
        Me.dg_dados.Size = New System.Drawing.Size(703, 147)
        Me.dg_dados.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Button3, Me.btn_editar, Me.ToolStripLabel1, Me.txt_busca, Me.ToolStripLabel2, Me.cmb_tipo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(903, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Button3
        '
        Me.Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(23, 22)
        Me.Button3.Text = "ToolStripButton1"
        Me.Button3.ToolTipText = "GRAVAR"
        '
        'btn_editar
        '
        Me.btn_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_editar.Image = CType(resources.GetObject("btn_editar.Image"), System.Drawing.Image)
        Me.btn_editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(23, 22)
        Me.btn_editar.Text = "ToolStripButton1"
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
        Me.cmb_tipo.Items.AddRange(New Object() {"CPF", "Primeiro_nome"})
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(121, 25)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(751, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF"
        Me.CPF.Name = "CPF"
        Me.CPF.ReadOnly = True
        '
        'NOME
        '
        Me.NOME.HeaderText = "NOME"
        Me.NOME.Name = "NOME"
        Me.NOME.ReadOnly = True
        '
        'SOBRENOME
        '
        Me.SOBRENOME.HeaderText = "SOBRENOME"
        Me.SOBRENOME.Name = "SOBRENOME"
        Me.SOBRENOME.ReadOnly = True
        '
        'FIXO
        '
        Me.FIXO.HeaderText = "FIXO"
        Me.FIXO.Name = "FIXO"
        Me.FIXO.ReadOnly = True
        '
        'CELULAR
        '
        Me.CELULAR.HeaderText = "CELULAR"
        Me.CELULAR.Name = "CELULAR"
        Me.CELULAR.ReadOnly = True
        '
        'Adicionar_Serviços
        '
        Me.Adicionar_Serviços.HeaderText = "ADICIONAR SERVIÇO"
        Me.Adicionar_Serviços.Image = CType(resources.GetObject("Adicionar_Serviços.Image"), System.Drawing.Image)
        Me.Adicionar_Serviços.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Adicionar_Serviços.Name = "Adicionar_Serviços"
        Me.Adicionar_Serviços.ReadOnly = True
        '
        'EDITAR
        '
        Me.EDITAR.HeaderText = ""
        Me.EDITAR.Image = CType(resources.GetObject("EDITAR.Image"), System.Drawing.Image)
        Me.EDITAR.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.EDITAR.Name = "EDITAR"
        Me.EDITAR.ReadOnly = True
        Me.EDITAR.Width = 30
        '
        'EXCLUIR
        '
        Me.EXCLUIR.HeaderText = ""
        Me.EXCLUIR.Image = CType(resources.GetObject("EXCLUIR.Image"), System.Drawing.Image)
        Me.EXCLUIR.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.EXCLUIR.Name = "EXCLUIR"
        Me.EXCLUIR.ReadOnly = True
        Me.EXCLUIR.Width = 30
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(903, 234)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ATENDENTE"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dg_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_sobrenome As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dg_dados As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_celular As MaskedTextBox
    Friend WithEvents txt_fixo As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Button3 As ToolStripButton
    Friend WithEvents btn_editar As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_tipo As ToolStripComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents NOME As DataGridViewTextBoxColumn
    Friend WithEvents SOBRENOME As DataGridViewTextBoxColumn
    Friend WithEvents FIXO As DataGridViewTextBoxColumn
    Friend WithEvents CELULAR As DataGridViewTextBoxColumn
    Friend WithEvents Adicionar_Serviços As DataGridViewImageColumn
    Friend WithEvents EDITAR As DataGridViewImageColumn
    Friend WithEvents EXCLUIR As DataGridViewImageColumn
End Class
