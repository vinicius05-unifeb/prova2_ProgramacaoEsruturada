using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova2_ProgramaçãoEstruturada
{
    public partial class frmMenus : Form
    {
        public frmMenus()
        {
            InitializeComponent();
        }

        private void toolStrip_Abrir_cadastroCliente_Click(object sender, EventArgs e)
        {
            frmCadastro_de_clientes cadastro_De_Clientes = new frmCadastro_de_clientes();
            cadastro_De_Clientes.Show();
            this.Close();
        }

        private void toolStrip_Abrir_cadastroProdutos_Click(object sender, EventArgs e)
        {
            frmCadastro_de_produtos cadastro_De_Produtos = new frmCadastro_de_produtos();
            cadastro_De_Produtos.Show();
            this.Close();
        }

        private void toolStrip_Abrir_cadastroPedidos_Click(object sender, EventArgs e)
        {
            frmCadastro_de_pedidos cadastro_De_pedidos = new frmCadastro_de_pedidos();
            cadastro_De_pedidos.Show();
            this.Close();
        }

        private void toolStrip_Abrir_cadastroUsuarios_Click(object sender, EventArgs e)
        {
            frmCadastro_de_usuários cadastro_De_usuarios = new frmCadastro_de_usuários();
            cadastro_De_usuarios.Show();
            this.Close();
        }
    }
}
