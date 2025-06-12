using System.Windows.Forms;

namespace prova2_ProgramaçãoEstruturada
{
    public partial class frmLogin : Form
    {
        private string linkCsv = "C:/Users/Vinicius/source/repos/prova2_ProgramacaoEsruturada/prova2_ProgramaçãoEstruturada/prova2_ProgramaçãoEstruturada/usuarios.csv";
        private void Login()
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();
            var linhas = File.ReadAllLines(linkCsv).ToList();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos ou insira as crendenciais existentes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (linhas.Skip(1).Any(l => l.Split(',')[0] == usuario && linhas.Skip(1).Any(l => l.Split(',')[1] == senha)))
            {
                MessageBox.Show("Login Válido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMenus menus = new frmMenus();
                menus.Show();
            }

            else if (usuario == "ADMIN" && senha == "123" || File.Exists(linkCsv))
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
