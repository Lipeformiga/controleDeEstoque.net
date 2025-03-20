using ControleEstoqueApp.Dominio.Entidades;
using ControleEstoqueApp.Infraestrutura.DataBase;
using System.Windows.Forms;

namespace ControleEstoqueApp
{
    public partial class FrmControleDeEstoque : Form
    {
        public FrmControleDeEstoque()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            salvarProduto();

            CarregarProdutos();
        }

        private void FrmControleDeEstoque_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            using var context = new AppDbContext();
            var produtos = context.Produtos.ToList();
            dtgEstoque.DataSource = produtos;
        }

        private void dtgEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgEstoque.Rows[e.RowIndex];

            txtID.Text = row.Cells["Id"].Value.ToString();
            txtNome.Text = row.Cells["Nome"].Value.ToString();
            txtQuantidade.Text = row.Cells["Quantidade"].Value.ToString();
            txtPreco.Text = row.Cells["Preco"].Value.ToString();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            int id = int.Parse(txtID.Text);
            var produto = context.Produtos.Find(id);
            if (produto != null)
            {
                context.Produtos.Remove(produto);
                context.SaveChanges();
                MessageBox.Show("Produto excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Produto não encontrado");
            }
            CarregarProdutos();
            limparDados();
        }

        private void limparDados()
        {
            txtID.Clear();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
        }

        private void salvarProduto()
        {
            using var context = new AppDbContext();
            int id;
            bool idExiste = int.TryParse(txtID.Text, out id) && id > 0;

            var produto = idExiste ? context.Produtos.Find(id) : new Produto();

            if (produto == null)
            {
                MessageBox.Show("Produto não encontrado para atualização.");
                return;
            }

            produto.Nome = txtNome.Text;
            produto.Quantidade = int.Parse(txtQuantidade.Text);
            produto.Preco = decimal.Parse(txtPreco.Text);


            if (!idExiste)
            {
                context.Produtos.Add(produto);
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            else if (idExiste)
            {
                MessageBox.Show("Produto atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Produto não encontrado");
            }

            context.SaveChanges();

        }

       
    }
}