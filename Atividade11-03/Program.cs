using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Atividade11_03.Aplicacao.Servicos.Interfaces;
using Atividade11_03.Dominio.Servicos.Interfaces;
using Atividade11_03.Infraestrutura.Repositorios.Interfaces;
using Atividade11_03.Aplicacao.Servicos;
using Atividade11_03.Infraestrutura.Database;
using Microsoft.EntityFrameworkCore;
using Atividade11_03.Dominio.Servicos;
using Atividade11_03.Infraestrutura.Repositorios;

namespace Atividade11_03
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=pizzaria.db"));

            services.AddScoped<IPizzaDominioServico, PizzaDominioServico>();
            services.AddScoped<IPizzaRepositorio, PizzaRepositorio>();
            services.AddScoped<IPizzaAppServico, PizzaAppServico>();

            var serviceProvider = services.BuildServiceProvider();

            

            ApplicationConfiguration.Initialize();

            Application.Run(new FrmPizzaria(serviceProvider));
            
        }
    }
}
