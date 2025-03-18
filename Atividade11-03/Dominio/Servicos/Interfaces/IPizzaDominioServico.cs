using Atividade11_03.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Atividade11_03.Dominio.Servicos.Interfaces
{
    public interface IPizzaDominioServico
    {
        void Validar(Pizza pizza);

        void ValidarId(int id);
    }
}
