using Atividade11_03.Aplicacao.Servicos.Interfaces;
using Atividade11_03.Dominio.Entidades;
using Atividade11_03.Dominio.Servicos.Interfaces;
using Atividade11_03.Infraestrutura.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11_03.Aplicacao.Servicos
{
    internal class PizzaAppServico : IPizzaAppServico
    {
        private readonly IPizzaDominioServico _dominioServico;
        private readonly IPizzaRepositorio _pizzaRepositorio;

        public PizzaAppServico(IPizzaDominioServico dominioServico, IPizzaRepositorio produtoRepositorio)
        {
            _dominioServico = dominioServico;
            _pizzaRepositorio = produtoRepositorio;
        }

        public void CadastrarPizza(string nome, decimal preco)
        {
            var pizza = new Pizza(nome, preco);
            _dominioServico.Validar(pizza);
            _pizzaRepositorio.Salvar(pizza);
        }

        public void DeletarPizza(int id)
        {
            var pizzaExistente = _pizzaRepositorio.GetPizzaById(id);

            if (pizzaExistente == null)
            {
                throw new Exception("Pizza não encontrada no Banco de Dados");
            }

            _pizzaRepositorio.Deletar(pizzaExistente); 
        }


        public List<Pizza> GetPizzas()
        {
            return _pizzaRepositorio.GetPizzas();
        }

        public List<Pizza> GetPizzasPorNome(string nome)
        {
            return _pizzaRepositorio.GetPizzaByNome(nome);
        }

        public void AlterarPizzas(int id, string nome,  decimal preco)
        {
            _dominioServico.ValidarId(id);

            var pizzaExistente = _pizzaRepositorio.GetPizzaById(id);

            if (pizzaExistente == null)
            {
                throw new Exception("Pizza não Encontrada no Banco de Dados");
            }

            pizzaExistente.Nome = nome;
            pizzaExistente.Preco = preco;

            _dominioServico.Validar(pizzaExistente);
            _pizzaRepositorio.Alterar(pizzaExistente);
        }
    }
}
