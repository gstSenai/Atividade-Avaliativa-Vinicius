using Atividade11_03.Aplicacao.Servicos.Interfaces;
using Atividade11_03.Dominio.Entidades;
using Microsoft.Extensions.DependencyInjection;

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
                MessageBox.Show("Por favor, insira um ID válido.");
                return;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome do produto é obrigatório.");
                return;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            try
            {
                var pizza = new Pizza(id, txtNome.Text, preco);
                _servico.DeletarPizza(pizza);
                MessageBox.Show("Pizza excluída com sucesso!");
                CarregarPizzas();
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
    }
}
