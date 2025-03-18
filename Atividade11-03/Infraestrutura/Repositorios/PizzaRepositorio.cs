using Atividade11_03.Dominio.Entidades;
using Atividade11_03.Infraestrutura.Database;
using Atividade11_03.Infraestrutura.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11_03.Infraestrutura.Repositorios
{
    public class PizzaRepositorio : IPizzaRepositorio
    {
        private readonly AppDbContext _context;

        public PizzaRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public void Salvar(Pizza pizza)
        {
            _context.Pizzas.Add(pizza);
            _context.SaveChanges();
        }

        public void Deletar(Pizza pizza)
        {
            _context.Pizzas.Remove(pizza);
            _context.SaveChanges();
        }

        public void Alterar(Pizza pizza)
        {
            var pizzaExistente = _context.Pizzas.Find(pizza.Id);

            if(pizzaExistente == null)
            {
                throw new Exception("Esta Pizza não Existe");
            }

            pizzaExistente.Nome = pizza.Nome;
            pizzaExistente.Preco = pizza.Preco;
        }

        public Pizza? GetPizzaById(int id)
        {
            return _context.Pizzas.Find(id);
        }

        public List<Pizza> GetPizzas()
        {
            return _context.Pizzas.ToList();
        }
    }
}
