using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.Entities
{
    public class ProdutoImportado : Produto
    {
        public double AlfandegaImporso { get; set; }

        public ProdutoImportado(string nome, double preco, double alfandegaImporso)
            :base(nome, preco)
        {
            Nome = nome;
            Preco = preco;
            AlfandegaImporso = alfandegaImporso;
        }

        public override string ImprimeEtiqueta()
        {
            return Nome + " - " + Preco.ToString("F2") + " (Alfandega: " + AlfandegaImporso.ToString("F2") + ")";
        }

    }
}
