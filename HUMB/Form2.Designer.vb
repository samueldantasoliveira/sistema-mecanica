﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.dg_dados = New System.Windows.Forms.DataGridView()
        Me.USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SENHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CARGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXCLUIR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CONTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTASDataSet = New HUMB.CONTASDataSet()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dg_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.CONTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_dados
        '
        Me.dg_dados.AllowUserToAddRows = False
        Me.dg_dados.AllowUserToDeleteRows = False
        Me.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.USUARIO, Me.SENHA, Me.CARGO, Me.EXCLUIR})
        Me.dg_dados.Location = New System.Drawing.Point(-2, 3)
        Me.dg_dados.Name = "dg_dados"
        Me.dg_dados.ReadOnly = True
        Me.dg_dados.Size = New System.Drawing.Size(445, 147)
        Me.dg_dados.TabIndex = 0
        '
        'USUARIO
        '
        Me.USUARIO.HeaderText = "USUARIO"
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.ReadOnly = True
        '
        'SENHA
        '
        Me.SENHA.HeaderText = "SENHA"
        Me.SENHA.Name = "SENHA"
        Me.SENHA.ReadOnly = True
        '
        'CARGO
        '
        Me.CARGO.HeaderText = "CARGO"
        Me.CARGO.Name = "CARGO"
        Me.CARGO.ReadOnly = True
        '
        'EXCLUIR
        '
        Me.EXCLUIR.HeaderText = "EXCLUIR"
        Me.EXCLUIR.Image = CType(resources.GetObject("EXCLUIR.Image"), System.Drawing.Image)
        Me.EXCLUIR.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.EXCLUIR.Name = "EXCLUIR"
        Me.EXCLUIR.ReadOnly = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(448, 180)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.txt_senha)
        Me.TabPage1.Controls.Add(Me.Txt_usuario)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(440, 154)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Criar Contas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(219, 102)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "SAIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "CRIAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ADMINISTRADOR", "ATENDENTE", "MECÂNICO"})
        Me.ComboBox1.Location = New System.Drawing.Point(253, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(60, 52)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_senha.Size = New System.Drawing.Size(117, 20)
        Me.txt_senha.TabIndex = 3
        '
        'Txt_usuario
        '
        Me.Txt_usuario.Location = New System.Drawing.Point(60, 23)
        Me.Txt_usuario.Name = "Txt_usuario"
        Me.Txt_usuario.Size = New System.Drawing.Size(117, 20)
        Me.Txt_usuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dg_dados)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(440, 154)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Excluir Contas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CONTASBindingSource
        '
        Me.CONTASBindingSource.DataMember = "CONTAS"
        Me.CONTASBindingSource.DataSource = Me.CONTASDataSet
        '
        'CONTASDataSet
        '
        Me.CONTASDataSet.DataSetName = "CONTASDataSet1"
        Me.CONTASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(503, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(649, 206)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMINISTRADOR"
        CType(Me.dg_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.CONTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dg_dados As DataGridView
    Friend WithEvents CONTASDataSet As CONTASDataSet
    Friend WithEvents CONTASBindingSource As BindingSource
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Txt_usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents USUARIO As DataGridViewTextBoxColumn
    Friend WithEvents SENHA As DataGridViewTextBoxColumn
    Friend WithEvents CARGO As DataGridViewTextBoxColumn
    Friend WithEvents EXCLUIR As DataGridViewImageColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
