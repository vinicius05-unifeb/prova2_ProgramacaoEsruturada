namespace prova2_ProgramaçãoEstruturada
{
    partial class frmMenus
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
            menuStrip1 = new MenuStrip();
            cadastrToolStripMenuItem = new ToolStripMenuItem();
            toolStrip_Abrir_cadastroCliente = new ToolStripMenuItem();
            cadastroDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            toolStrip_Abrir_cadastroProdutos = new ToolStripMenuItem();
            cadastroDePedidosToolStripMenuItem = new ToolStripMenuItem();
            toolStrip_Abrir_cadastroPedidos = new ToolStripMenuItem();
            cadastroDeUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            toolStrip_Abrir_cadastroUsuarios = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrToolStripMenuItem, cadastroDeProdutosToolStripMenuItem, cadastroDePedidosToolStripMenuItem, cadastroDeUsuáriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(719, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrToolStripMenuItem
            // 
            cadastrToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStrip_Abrir_cadastroCliente });
            cadastrToolStripMenuItem.Name = "cadastrToolStripMenuItem";
            cadastrToolStripMenuItem.Size = new Size(157, 24);
            cadastrToolStripMenuItem.Text = "Cadastro de clientes";
            // 
            // toolStrip_Abrir_cadastroCliente
            // 
            toolStrip_Abrir_cadastroCliente.Name = "toolStrip_Abrir_cadastroCliente";
            toolStrip_Abrir_cadastroCliente.Size = new Size(125, 26);
            toolStrip_Abrir_cadastroCliente.Text = "Abrir";
            toolStrip_Abrir_cadastroCliente.Click += toolStrip_Abrir_cadastroCliente_Click;
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            cadastroDeProdutosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStrip_Abrir_cadastroProdutos });
            cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            cadastroDeProdutosToolStripMenuItem.Size = new Size(167, 24);
            cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de produtos";
            // 
            // toolStrip_Abrir_cadastroProdutos
            // 
            toolStrip_Abrir_cadastroProdutos.Name = "toolStrip_Abrir_cadastroProdutos";
            toolStrip_Abrir_cadastroProdutos.Size = new Size(125, 26);
            toolStrip_Abrir_cadastroProdutos.Text = "Abrir";
            toolStrip_Abrir_cadastroProdutos.Click += toolStrip_Abrir_cadastroProdutos_Click;
            // 
            // cadastroDePedidosToolStripMenuItem
            // 
            cadastroDePedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStrip_Abrir_cadastroPedidos });
            cadastroDePedidosToolStripMenuItem.Name = "cadastroDePedidosToolStripMenuItem";
            cadastroDePedidosToolStripMenuItem.Size = new Size(161, 24);
            cadastroDePedidosToolStripMenuItem.Text = "Cadastro de pedidos";
            // 
            // toolStrip_Abrir_cadastroPedidos
            // 
            toolStrip_Abrir_cadastroPedidos.Name = "toolStrip_Abrir_cadastroPedidos";
            toolStrip_Abrir_cadastroPedidos.Size = new Size(224, 26);
            toolStrip_Abrir_cadastroPedidos.Text = "Abrir";
            toolStrip_Abrir_cadastroPedidos.Click += toolStrip_Abrir_cadastroPedidos_Click;
            // 
            // cadastroDeUsuáriosToolStripMenuItem
            // 
            cadastroDeUsuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStrip_Abrir_cadastroUsuarios });
            cadastroDeUsuáriosToolStripMenuItem.Name = "cadastroDeUsuáriosToolStripMenuItem";
            cadastroDeUsuáriosToolStripMenuItem.Size = new Size(161, 24);
            cadastroDeUsuáriosToolStripMenuItem.Text = "Cadastro de usuários";
            // 
            // toolStrip_Abrir_cadastroUsuarios
            // 
            toolStrip_Abrir_cadastroUsuarios.Name = "toolStrip_Abrir_cadastroUsuarios";
            toolStrip_Abrir_cadastroUsuarios.Size = new Size(224, 26);
            toolStrip_Abrir_cadastroUsuarios.Text = "Abrir";
            toolStrip_Abrir_cadastroUsuarios.Click += toolStrip_Abrir_cadastroUsuarios_Click;
            // 
            // frmMenus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 269);
            Controls.Add(menuStrip1);
            Name = "frmMenus";
            Text = "frmMenus";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrToolStripMenuItem;
        private ToolStripMenuItem toolStrip_Abrir_cadastroCliente;
        private ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private ToolStripMenuItem toolStrip_Abrir_cadastroProdutos;
        private ToolStripMenuItem cadastroDePedidosToolStripMenuItem;
        private ToolStripMenuItem toolStrip_Abrir_cadastroPedidos;
        private ToolStripMenuItem cadastroDeUsuáriosToolStripMenuItem;
        private ToolStripMenuItem toolStrip_Abrir_cadastroUsuarios;
    }
}