using Microsoft.EntityFrameworkCore;
using Atividade11_03.Dominio.Entidades;
using System;
using System.IO;

namespace Atividade11_03.Infraestrutura.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
             var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pizzaria.db");
             Console.WriteLine($"Banco de dados em: {path}");
             options.UseSqlite($"Data Source={path}");
        }
    }
}
