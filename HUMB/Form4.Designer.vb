<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.dg_dados = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Placa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serviço = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preço = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb_status = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dg_dados, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dg_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.CPF, Me.Carro, Me.Placa, Me.Serviço, Me.Preço, Me.Data, Me.cb_status})
        Me.dg_dados.Location = New System.Drawing.Point(12, 95)
        Me.dg_dados.Name = "dg_dados"
        Me.dg_dados.ReadOnly = True
        Me.dg_dados.Size = New System.Drawing.Size(714, 278)
        Me.dg_dados.TabIndex = 2
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF"
        Me.CPF.Name = "CPF"
        Me.CPF.ReadOnly = True
        '
        'Carro
        '
        Me.Carro.HeaderText = "Carro"
        Me.Carro.Name = "Carro"
        Me.Carro.ReadOnly = True
        '
        'Placa
        '
        Me.Placa.HeaderText = "Placa"
        Me.Placa.Name = "Placa"
        Me.Placa.ReadOnly = True
        Me.Placa.Width = 70
        '
        'Serviço
        '
        Me.Serviço.HeaderText = "Serviço"
        Me.Serviço.Name = "Serviço"
        Me.Serviço.ReadOnly = True
        '
        'Preço
        '
        Me.Preço.HeaderText = "Preço"
        Me.Preço.Name = "Preço"
        Me.Preço.ReadOnly = True
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        '
        'cb_status
        '
        Me.cb_status.HeaderText = "Status"
        Me.cb_status.Name = "cb_status"
        Me.cb_status.ReadOnly = True
        Me.cb_status.TrueValue = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(298, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(744, 391)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dg_dados)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MECÂNICO"
        CType(Me.dg_dados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dg_dados As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents Carro As DataGridViewTextBoxColumn
    Friend WithEvents Placa As DataGridViewTextBoxColumn
    Friend WithEvents Serviço As DataGridViewTextBoxColumn
    Friend WithEvents Preço As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents cb_status As DataGridViewCheckBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
