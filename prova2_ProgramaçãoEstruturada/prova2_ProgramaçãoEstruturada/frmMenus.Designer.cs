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
            cadastroDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDePedidosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem1 = new ToolStripMenuItem();
            abrirToolStripMenuItem2 = new ToolStripMenuItem();
            abrirToolStripMenuItem3 = new ToolStripMenuItem();
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
            cadastrToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem });
            cadastrToolStripMenuItem.Name = "cadastrToolStripMenuItem";
            cadastrToolStripMenuItem.Size = new Size(157, 24);
            cadastrToolStripMenuItem.Text = "Cadastro de clientes";
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            cadastroDeProdutosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem1 });
            cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            cadastroDeProdutosToolStripMenuItem.Size = new Size(167, 24);
            cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de produtos";
            // 
            // cadastroDePedidosToolStripMenuItem
            // 
            cadastroDePedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem2 });
            cadastroDePedidosToolStripMenuItem.Name = "cadastroDePedidosToolStripMenuItem";
            cadastroDePedidosToolStripMenuItem.Size = new Size(161, 24);
            cadastroDePedidosToolStripMenuItem.Text = "Cadastro de pedidos";
            // 
            // cadastroDeUsuáriosToolStripMenuItem
            // 
            cadastroDeUsuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem3 });
            cadastroDeUsuáriosToolStripMenuItem.Name = "cadastroDeUsuáriosToolStripMenuItem";
            cadastroDeUsuáriosToolStripMenuItem.Size = new Size(161, 24);
            cadastroDeUsuáriosToolStripMenuItem.Text = "Cadastro de usuários";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(224, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // abrirToolStripMenuItem1
            // 
            abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            abrirToolStripMenuItem1.Size = new Size(224, 26);
            abrirToolStripMenuItem1.Text = "Abrir";
            // 
            // abrirToolStripMenuItem2
            // 
            abrirToolStripMenuItem2.Name = "abrirToolStripMenuItem2";
            abrirToolStripMenuItem2.Size = new Size(224, 26);
            abrirToolStripMenuItem2.Text = "Abrir";
            // 
            // abrirToolStripMenuItem3
            // 
            abrirToolStripMenuItem3.Name = "abrirToolStripMenuItem3";
            abrirToolStripMenuItem3.Size = new Size(224, 26);
            abrirToolStripMenuItem3.Text = "Abrir";
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
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem1;
        private ToolStripMenuItem cadastroDePedidosToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem2;
        private ToolStripMenuItem cadastroDeUsuáriosToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem3;
    }
}