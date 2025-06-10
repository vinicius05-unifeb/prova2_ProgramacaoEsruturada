using System.Windows.Forms;

namespace prova2_ProgramaçãoEstruturada
{
    public partial class frmLogin : Form
    {
        private void Login()
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos ou insira as crendenciais existentes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (usuario == "USUARIO" && senha == "123")
            {
                MessageBox.Show("Login Válido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMenus menus = new frmMenus();
                menus.Show();
            }
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
