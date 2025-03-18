using Atividade11_03.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11_03.Aplicacao.Servicos.Interfaces
{
    public interface IPizzaAppServico
    {
        void CadastrarPizza(string nome, decimal preco);
        void AlterarPizzas(int id, string nome, decimal preco);
        void DeletarPizza(int id);
        List<Pizza> GetPizzas();
        List<Pizza> GetPizzasPorNome(string nome);
    }
}
