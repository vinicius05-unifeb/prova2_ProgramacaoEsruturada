namespace prova2_ProgramaçãoEstruturada
{
    partial class frmCadastro_de_usuários
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
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dgvUsuarios = new DataGridView();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnMenus = new Button();
            txtNome_Usuario = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 86);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(195, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 163);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(195, 27);
            txtSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 2;
            label1.Text = "Crie ou altere um usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 140);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 3;
            label2.Text = "Crie ou altere uma senha";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(230, 12);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(417, 426);
            dgvUsuarios.TabIndex = 4;
            dgvUsuarios.CellDoubleClick += dgvUsuarios_CellDoubleClick;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(11, 291);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(111, 291);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnMenus
            // 
            btnMenus.Location = new Point(50, 342);
            btnMenus.Name = "btnMenus";
            btnMenus.Size = new Size(120, 29);
            btnMenus.TabIndex = 7;
            btnMenus.Text = "Voltar ao menu";
            btnMenus.UseVisualStyleBackColor = true;
            btnMenus.Click += btnMenus_Click;
            // 
            // txtNome_Usuario
            // 
            txtNome_Usuario.Location = new Point(11, 231);
            txtNome_Usuario.Name = "txtNome_Usuario";
            txtNome_Usuario.Size = new Size(193, 27);
            txtNome_Usuario.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 208);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 9;
            label3.Text = "Nome do usuário";
            // 
            // frmCadastro_de_usuários
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 450);
            Controls.Add(label3);
            Controls.Add(txtNome_Usuario);
            Controls.Add(btnMenus);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(dgvUsuarios);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Name = "frmCadastro_de_usuários";
            Text = "frmCadastro_de_usuários";
            Load += frmCadastro_de_usuários_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private DataGridView dgvUsuarios;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnMenus;
        private TextBox txtNome_Usuario;
        private Label label3;
    }
}