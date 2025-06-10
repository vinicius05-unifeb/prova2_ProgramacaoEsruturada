namespace prova2_ProgramaçãoEstruturada
{
    partial class frmCadastro_de_produtos
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
            txtNomeDoProduto = new TextBox();
            txtPreço = new TextBox();
            txtDescrição = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvProdutos = new DataGridView();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnMenu = new Button();
            txtCodigo_produto = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtNomeDoProduto
            // 
            txtNomeDoProduto.Location = new Point(23, 44);
            txtNomeDoProduto.Name = "txtNomeDoProduto";
            txtNomeDoProduto.Size = new Size(211, 27);
            txtNomeDoProduto.TabIndex = 0;
            // 
            // txtPreço
            // 
            txtPreço.Location = new Point(23, 177);
            txtPreço.Name = "txtPreço";
            txtPreço.Size = new Size(211, 27);
            txtPreço.TabIndex = 1;
            // 
            // txtDescrição
            // 
            txtDescrição.Location = new Point(23, 251);
            txtDescrição.Name = "txtDescrição";
            txtDescrição.Size = new Size(211, 27);
            txtDescrição.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 3;
            label1.Text = "Nome do produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 154);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 228);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 5;
            label3.Text = "Descrição";
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(256, 21);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersWidth = 51;
            dgvProdutos.Size = new Size(523, 417);
            dgvProdutos.TabIndex = 6;
            dgvProdutos.CellDoubleClick += dgvProdutos_CellDoubleClick;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(20, 310);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(137, 310);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(69, 365);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(118, 29);
            btnMenu.TabIndex = 9;
            btnMenu.Text = "Voltar ao menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // txtCodigo_produto
            // 
            txtCodigo_produto.Location = new Point(23, 108);
            txtCodigo_produto.Name = "txtCodigo_produto";
            txtCodigo_produto.Size = new Size(208, 27);
            txtCodigo_produto.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 85);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 11;
            label4.Text = "Código do produto";
            // 
            // frmCadastro_de_produtos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtCodigo_produto);
            Controls.Add(btnMenu);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(dgvProdutos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescrição);
            Controls.Add(txtPreço);
            Controls.Add(txtNomeDoProduto);
            Name = "frmCadastro_de_produtos";
            Text = "frmCadastro_de_produtos";
            Load += frmCadastro_de_produtos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeDoProduto;
        private TextBox txtPreço;
        private TextBox txtDescrição;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvProdutos;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnMenu;
        private TextBox txtCodigo_produto;
        private Label label4;
    }
}