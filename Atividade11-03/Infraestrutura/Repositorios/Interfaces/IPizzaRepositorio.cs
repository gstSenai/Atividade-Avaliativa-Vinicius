using Atividade11_03.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11_03.Infraestrutura.Repositorios.Interfaces
{
    public interface IPizzaRepositorio
    {
        void Salvar(Pizza pizza);

        void Deletar(Pizza pizza);

        void Alterar(Pizza pizza);

        Pizza? GetPizzaById(int id);

        List<Pizza> GetPizzas();
    }
}
