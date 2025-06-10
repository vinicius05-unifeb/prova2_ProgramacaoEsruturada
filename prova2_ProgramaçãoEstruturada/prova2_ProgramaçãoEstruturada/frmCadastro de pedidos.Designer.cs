namespace prova2_ProgramaçãoEstruturada
{
    partial class frmCadastro_de_pedidos
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
            txtCPFdoCliente = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblNomeCliente = new Label();
            SuspendLayout();
            // 
            // txtCPFdoCliente
            // 
            txtCPFdoCliente.Location = new Point(72, 82);
            txtCPFdoCliente.Name = "txtCPFdoCliente";
            txtCPFdoCliente.Size = new Size(163, 27);
            txtCPFdoCliente.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(73, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(72, 261);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 27);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 54);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 3;
            label1.Text = "CPF do cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 159);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 236);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "Quantidade";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(69, 112);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(123, 20);
            lblNomeCliente.TabIndex = 6;
            lblNomeCliente.Text = "Nome do cliente:";
            // 
            // frmCadastro_de_pedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNomeCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(txtCPFdoCliente);
            Name = "frmCadastro_de_pedidos";
            Text = "frmCadastro_de_pedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCPFdoCliente;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblNomeCliente;
    }
}