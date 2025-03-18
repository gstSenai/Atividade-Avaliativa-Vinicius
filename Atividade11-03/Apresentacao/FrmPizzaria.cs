using Atividade11_03.Aplicacao.Servicos.Interfaces;
using Atividade11_03.Dominio.Entidades;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace Atividade11_03
{
    public partial class FrmPizzaria : Form
    {
        private readonly IPizzaAppServico _servico;

        public FrmPizzaria(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _servico = serviceProvider.GetRequiredService<IPizzaAppServico>();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome da Pizza é obrigatório.");
                return;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço Inválido");
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    _servico.CadastrarPizza(txtNome.Text, decimal.Parse(txtPreco.Text));
                    MessageBox.Show("Pizza salvo com sucesso");
                    CarregarPizzas();
                    LimparPizza();
                }
                else
                {
                    _servico.AlterarPizzas(int.Parse(txtId.Text), txtNome.Text, decimal.Parse(txtPreco.Text));
                    MessageBox.Show("Pizza Atualizada com Sucesso");
                    CarregarPizzas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Salvar a Pizza: {ex.Message}");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || !int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Por favor, selecione uma pizza na tabela antes de excluir.");
                return;
            }

            try
            {
                _servico.DeletarPizza(id);
                MessageBox.Show("Pizza excluída com sucesso!");
                CarregarPizzas();
                LimparPizza();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir a pizza: {ex.Message}");
            }
        }

        private void FrmPizzaria_Load(object sender, EventArgs e)
        {
            CarregarPizzas();
        }

        private void CarregarPizzas()
        {
            var pizzas = _servico.GetPizzas();

            dtgPizzaria.DataSource = pizzas;

            dtgPizzaria.Columns["Id"].HeaderText = "ID";
            dtgPizzaria.Columns["Nome"].HeaderText = "NOME";
            dtgPizzaria.Columns["Preco"].HeaderText = "PRECO";
        }

        private void LimparPizza()
        {
            dtgPizzaria.ClearSelection();
            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
        }

        private void dtgPizzaria_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgPizzaria.Rows[e.RowIndex];

                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtPreco.Text = row.Cells["Preco"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || !int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Por favor, selecione uma pizza na tabela antes de editar.");
                return;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome da pizza é obrigatório.");
                return;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            try
            {
                _servico.AlterarPizzas(id, txtNome.Text, preco);
                MessageBox.Show("Pizza alterada com sucesso!");
                CarregarPizzas();
                LimparPizza();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar a pizza: {ex.Message}");
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            List<Pizza> pizzasFiltradas = _servico.GetPizzasPorNome(txtPesquisa.Text);
            dtgPizzaria.DataSource = pizzasFiltradas;
        }
    }
}
