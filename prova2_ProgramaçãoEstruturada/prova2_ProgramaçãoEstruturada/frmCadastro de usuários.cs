using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace prova2_ProgramaçãoEstruturada
{
    public partial class frmCadastro_de_usuários : Form
    {
        private string linkCsv = "C:/Users/Vinicius/source/repos/prova2_ProgramacaoEsruturada/prova2_ProgramaçãoEstruturada/prova2_ProgramaçãoEstruturada/usuarios.csv";
        private int edicao = -1;
        public frmCadastro_de_usuários()
        {
            InicializarCsv();
            InitializeComponent();
        }
        private void Adicionar()
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();
            string nome = txtNome_Usuario.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Preencha Corretamente todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var linhas = File.ReadAllLines(linkCsv).ToList();

            if (edicao == -1)
            {
                if (linhas.Skip(1).Any(l => l.Split(',')[2] == nome))
                {
                    MessageBox.Show("Usuário já cadastrado", "Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                linhas.Add($"{usuario},{senha},{nome}");
            }
            else
            {
                linhas[edicao + 1] = $"{usuario},{senha},{nome}";
                edicao = -1;
            }
            File.WriteAllLines(linkCsv, linhas);
            MessageBox.Show("Dados do cliente foram salvos.", "Dados salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtUsuario.Clear();
            txtSenha.Clear();
            txtNome_Usuario.Clear();

            LoadCsv_in_DGVusuarios();
        }
        private void LoadCsv_in_DGVusuarios()
        {
            try
            {
                DataTable tabela_usuarios = new DataTable();
                string[] linhas = File.ReadAllLines(linkCsv);

                if (linhas.Length > 0)
                {
                    string[] colunas = linhas[0].Split(',');

                    foreach (string coluna in colunas)
                        tabela_usuarios.Columns.Add(coluna);

                    for (int i = 1; i < linhas.Length; i++)
                    {
                        string[] dados_usuario = linhas[i].Split(',');
                        tabela_usuarios.Rows.Add(dados_usuario);
                    }
                }
                dgvUsuarios.DataSource = tabela_usuarios;
            }
            catch (Exception excep)
            {
                MessageBox.Show($"Erro ao carregar  os dados do cliente: {excep.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InicializarCsv()
        {
            if (!File.Exists(linkCsv))
            {
                using (StreamWriter sw = new StreamWriter(linkCsv))
                {
                    sw.WriteLine("Usuário,Senha,Nome do usuário");
                }
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Adicionar();
        }

        private void frmCadastro_de_usuários_Load(object sender, EventArgs e)
        {
            LoadCsv_in_DGVusuarios();
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSenha.Text = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNome_Usuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();

                edicao = e.RowIndex;
                btnAdicionar.Text = "Editar";
                LoadCsv_in_DGVusuarios();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int rowIndex = dgvUsuarios.SelectedRows[0].Index;
            var linhas = File.ReadAllLines(linkCsv).ToList();

            linhas.RemoveAt(rowIndex + 1);
            File.WriteAllLines(linkCsv, linhas);
            MessageBox.Show("Usuário excluído.", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadCsv_in_DGVusuarios();
        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            frmMenus menus = new frmMenus();
            menus.Show();
            this.Close();
        }
    }
}
