using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.Entities
{
    public class ProdutoUsado : Produto
    {
        public DateTime DataDeFabricacao { get; set; }

        public ProdutoUsado(string nome, double preco, DateTime dataDeFabricacao)
            : base(nome, preco)
        {
            DataDeFabricacao = dataDeFabricacao;
        }

        public override string ImprimeEtiqueta()
        {
            return Nome + " (usado) - " + Preco.ToString("F2") + " (Data de fabricação: " + DataDeFabricacao.ToString("dd/MM/yyyy") + ")";
        }
    }
}
