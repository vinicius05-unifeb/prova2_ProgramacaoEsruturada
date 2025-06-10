using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prova2_ProgramaçãoEstruturada
{
    public partial class frmCadastro_de_produtos : Form
    {
        private string linkCsv = "C:/Users/Vinicius/source/repos/prova2_ProgramacaoEsruturada/prova2_ProgramaçãoEstruturada/prova2_ProgramaçãoEstruturada/produtos.csv";
        private int edicao = -1;
        public frmCadastro_de_produtos()
        {
            InitializeComponent();
            InicializarCsv();
        }
        private void Adicinar()
        {
            string nome_produto = txtNomeDoProduto.Text.Trim();
            string codigo_produto = txtCodigo_produto.Text.Trim();
            string descricao_produto = txtDescrição.Text.Trim();
            string preco_produto = txtPreço.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome_produto) || string.IsNullOrWhiteSpace(preco_produto) || string.IsNullOrWhiteSpace(descricao_produto) || string.IsNullOrWhiteSpace(codigo_produto))
            {
                MessageBox.Show("Todos os campos devem estar preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var linhas = File.ReadAllLines(linkCsv).ToList();

            if (edicao == -1)
            {
                if (linhas.Skip(1).Any(l => l.Split(',')[1] == codigo_produto))
                {
                    MessageBox.Show("Código já cadastrado, tente um novo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                linhas.Add($"{nome_produto},{codigo_produto},{preco_produto},{descricao_produto}");
            }
            else
            {
                linhas[edicao + 1] = $"{nome_produto},{codigo_produto},{preco_produto},{descricao_produto}";
                edicao = -1;
            }
            File.WriteAllLines(linkCsv, linhas);
            MessageBox.Show("Produto salvo com sucesso.", "Produto salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNomeDoProduto.Clear();
            txtCodigo_produto.Clear();
            txtPreço.Clear();
            txtDescrição.Clear();

            Visualizar_Csv_In_DataGrid();
        }
        private void Visualizar_Csv_In_DataGrid()
        {
            try
            {
                DataTable tabela_produtos = new DataTable();
                string[] linhas = File.ReadAllLines(linkCsv);

                if (linhas.Length > 0)
                {
                    string[] colunas = linhas[0].Split(',');

                    foreach (string coluna in colunas)
                        tabela_produtos.Columns.Add(coluna);

                    for (int i = 1; i < linhas.Length; i++)
                    {
                        string[] dados_produto = linhas[i].Split(',');
                        tabela_produtos.Rows.Add(dados_produto);
                    }
                }
                dgvProdutos.DataSource = tabela_produtos;
            }
            catch (Exception excep)
            {
                MessageBox.Show($"Erro ao carregar dados do produo: {excep.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InicializarCsv()
        {
            if (!File.Exists(linkCsv))
            {
                using (StreamWriter sw = new StreamWriter(linkCsv))
                {
                    sw.WriteLine("Nome do produto,Código do produto,Preço do produto,Descrição do produto");
                }
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenus menus = new frmMenus();
            menus.Show();
            this.Close();
        }

        private void frmCadastro_de_produtos_Load(object sender, EventArgs e)
        {
            Visualizar_Csv_In_DataGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Adicinar();
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNomeDoProduto.Text = dgvProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCodigo_produto.Text = dgvProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPreço.Text = dgvProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDescrição.Text = dgvProdutos.Rows[e.RowIndex].Cells[3].Value.ToString();

                edicao = e.RowIndex;
                btnAdicionar.Text = "Editar";
                Visualizar_Csv_In_DataGrid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int rowIndex = dgvProdutos.SelectedRows[0].Index;
            var linhas = File.ReadAllLines(linkCsv).ToList();

             linhas.RemoveAt(rowIndex + 1);
            File.WriteAllLines(linkCsv, linhas);
            MessageBox.Show("Registro excluído.", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Visualizar_Csv_In_DataGrid();
        }
    }
}
