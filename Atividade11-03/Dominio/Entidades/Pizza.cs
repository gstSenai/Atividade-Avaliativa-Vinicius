using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11_03.Dominio.Entidades
{
    public class Pizza
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Column("nome")]
        public string Nome { get; set; }

        [Required]
        [Column("preco")]
        public decimal Preco { get; set; }
        
        public Pizza(int id, string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public Pizza(string nome, decimal preco) { 
            Nome = nome;
            Preco = preco;
        }
    }
}
