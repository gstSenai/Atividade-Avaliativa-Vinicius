using Atividade11_03.Dominio.Entidades;
using Atividade11_03.Dominio.Servicos.Interfaces;
using Atividade11_03.Infraestrutura.Database; // Importando o AppDbContext
using Microsoft.EntityFrameworkCore;
using System;

namespace Atividade11_03.Dominio.Servicos
{
    public class PizzaDominioServico : IPizzaDominioServico
    {
        private readonly AppDbContext _context; 

        public PizzaDominioServico(AppDbContext context)
        {
            _context = context; 
        }

        public void Validar(Pizza pizza)
        {
            if (string.IsNullOrEmpty(pizza.Nome))
            {
                throw new Exception("Nome é obrigatório");
            }

            if (_context.Pizzas.Any(p => p.Nome == pizza.Nome))
            {
                throw new Exception("Já existe uma pizza com esse nome.");
            }

            if (pizza.Preco <= 0)
            {
                throw new Exception("Valor inválido");
            }
        }

        public void ValidarId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Id inválido");
            }
        }
    }
}
