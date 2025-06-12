namespace prova2_ProgramaçãoEstruturada
{
    partial class frmCadastro_de_clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtEmail = new TextBox();
            txtEndereço = new TextBox();
            txtTelefone = new TextBox();
            txtWhatsapp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvClientes = new DataGridView();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnMenu = new Button();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(11, 25);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 0;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(156, 25);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(125, 27);
            txtCPF.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(11, 80);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtEndereço
            // 
            txtEndereço.Location = new Point(11, 212);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(125, 27);
            txtEndereço.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(11, 134);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(125, 27);
            txtTelefone.TabIndex = 4;
            // 
            // txtWhatsapp
            // 
            txtWhatsapp.Location = new Point(156, 80);
            txtWhatsapp.Name = "txtWhatsapp";
            txtWhatsapp.Size = new Size(125, 27);
            txtWhatsapp.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 2);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 6;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 2);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 7;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 57);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 189);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 9;
            label4.Text = "CEP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 111);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 10;
            label5.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 57);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 11;
            label6.Text = "Whatsapp";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(342, 12);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(709, 426);
            dgvClientes.TabIndex = 12;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(342, 448);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 13;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(569, 448);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 14;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(442, 448);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(121, 29);
            btnMenu.TabIndex = 15;
            btnMenu.Text = "Voltar ao menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(107, 259);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(125, 27);
            txtLogradouro.TabIndex = 16;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(107, 308);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 17;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(107, 356);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(125, 27);
            txtBairro.TabIndex = 18;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(107, 404);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(125, 27);
            txtCidade.TabIndex = 19;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(107, 450);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(125, 27);
            txtEstado.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 262);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 21;
            label7.Text = "Logradouro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 311);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 22;
            label8.Text = "Número:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(49, 359);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 23;
            label9.Text = "Bairro:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 407);
            label10.Name = "label10";
            label10.Size = new Size(59, 20);
            label10.TabIndex = 24;
            label10.Text = "Cidade:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 453);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 25;
            label11.Text = "Estado:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(142, 212);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(125, 29);
            btnPesquisar.TabIndex = 26;
            btnPesquisar.Text = "Pesquisar CEP";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // frmCadastro_de_clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 489);
            Controls.Add(btnPesquisar);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtEstado);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(btnMenu);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(dgvClientes);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWhatsapp);
            Controls.Add(txtTelefone);
            Controls.Add(txtEndereço);
            Controls.Add(txtEmail);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Name = "frmCadastro_de_clientes";
            Text = "frmCadastro_de_clientes";
            Load += frmCadastro_de_clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtEmail;
        private TextBox txtEndereço;
        private TextBox txtTelefone;
        private TextBox txtWhatsapp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvClientes;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnMenu;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnPesquisar;
    }
}