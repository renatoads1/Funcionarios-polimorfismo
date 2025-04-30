using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.Entities
{
    public class FuncionariosTerceirizados :Funcionarios
    {
        public double MaterialGasto { get; set; }

        public FuncionariosTerceirizados(string nome, int hora, double valorPorHora, double materialGasto)
            :base(nome, hora, valorPorHora)
        {
            Nome = nome;
            Hora = hora;
            ValorPorHora = valorPorHora;
            MaterialGasto = materialGasto;
        }

        public override double Pagamento()
        {
            var pag =  base.Pagamento(); 
            pag = pag + (MaterialGasto * 0.1);
            return pag;
        }

    }
}
