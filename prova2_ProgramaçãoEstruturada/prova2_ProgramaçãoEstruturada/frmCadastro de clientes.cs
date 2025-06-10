using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;

namespace prova2_ProgramaçãoEstruturada
{
    public partial class frmCadastro_de_clientes : Form
    {
        private string linkCsv = "C:/Users/Vinicius/source/repos/prova2_ProgramacaoEsruturada/prova2_ProgramaçãoEstruturada/prova2_ProgramaçãoEstruturada/clientes.csv";
        private int edicao = -1;
        public frmCadastro_de_clientes()
        {
            InitializeComponent();
            InicializarCsv();
        }
        private void Adicionar()
        {
            string nome = txtNome.Text.Trim();
            string cpf = txtCPF.Text.Trim();
            string email = txtEmail.Text.Trim();
            string endereco = txtEndereço.Text.Trim();
            string telefone = txtTelefone.Text.Trim();
            string whatsapp = txtWhatsapp.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(endereco) || string.IsNullOrWhiteSpace(telefone) || string.IsNullOrWhiteSpace(whatsapp))
            {
                MessageBox.Show("Todos os campos devem estar preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var linhas = File.ReadAllLines(linkCsv).ToList();

            if (edicao == -1)
            {
                if (linhas.Skip(1).Any(l => l.Split(',')[1] == cpf))
                {
                    MessageBox.Show("CPF já cadastrado", "Tente outro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                linhas.Add($"{nome},{cpf},{email},{endereco},{telefone},{whatsapp}");
            }
            else
            {
                linhas[edicao + 1] = $"{nome},{cpf},{email},{endereco},{telefone},{whatsapp}";
                edicao = -1;
            }
            File.WriteAllLines(linkCsv, linhas);
            MessageBox.Show("Dados do cliente foram salvos.", "Dados salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNome.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtEndereço.Clear();
            txtTelefone.Clear();
            txtWhatsapp.Clear();

            Visualizar_Csv_In_DataGrid();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenus menus = new frmMenus();
            menus.Show();
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Adicionar();
        }
        private void Visualizar_Csv_In_DataGrid()
        {
            try
            {
                DataTable tabela_clientes = new DataTable();
                string[] linhas = File.ReadAllLines(linkCsv);

                if (linhas.Length > 0)
                {
                    string[] colunas = linhas[0].Split(',');

                    foreach (string coluna in colunas)
                        tabela_clientes.Columns.Add(coluna);

                    for (int i = 1; i < linhas.Length; i++)
                    {
                        string[] dados_cliente = linhas[i].Split(',');
                        tabela_clientes.Rows.Add(dados_cliente);
                    }
                }
                dgvClientes.DataSource = tabela_clientes;
            }
            catch (Exception excep)
            {
                MessageBox.Show($"Erro ao carregar  os dados do cliente: {excep.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCadastro_de_clientes_Load(object sender, EventArgs e)
        {
            Visualizar_Csv_In_DataGrid();
        }
        private void InicializarCsv()
        {
            if (!File.Exists(linkCsv))
            {
                using (StreamWriter sw = new StreamWriter(linkCsv))
                {
                    sw.WriteLine("Nome,CPF,Email,Endereço,Telefone,Whatsapp");
                }
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNome.Text = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCPF.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtEmail.Text = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEndereço.Text = dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTelefone.Text = dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtWhatsapp.Text = dgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString();

                edicao = e.RowIndex;
                btnAdicionar.Text = "Editar";
                Visualizar_Csv_In_DataGrid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int rowIndex = dgvClientes.SelectedRows[0].Index;
            var linhas = File.ReadAllLines(linkCsv).ToList();

            linhas.RemoveAt(rowIndex + 1); 
            File.WriteAllLines(linkCsv, linhas);
            MessageBox.Show("Registro excluído.", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Visualizar_Csv_In_DataGrid();
        }
    }
}
