using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.Entities
{
    public class Funcionarios
    {
        public string Nome { get; set; }
        public int Hora { get; set; }
        public double ValorPorHora { get; set; }

        public Funcionarios()
        {
        }
        public Funcionarios(string nome, int hora, double valorPorHora)
        {
            Nome = nome;
            Hora = hora;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento()
        {
            return Hora * ValorPorHora;
        }
    }
}
