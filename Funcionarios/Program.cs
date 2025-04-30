
using Funcionarios.Entities;

Produto produto = new Produto("Produto", 10.0);
Produto produtoImportado = new ProdutoImportado("Produto Importado", 20.0, 5.0);
Produto produtoComImposto = new ProdutoImportado("Produto com Imposto", 30.0, 10.0);

Console.WriteLine(produto.ImprimeEtiqueta());
Console.WriteLine(produtoImportado.ImprimeEtiqueta());
Console.WriteLine(produtoComImposto.ImprimeEtiqueta());
