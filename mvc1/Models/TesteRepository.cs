
namespace mvc1.Models
{
    public class TesteRepositorio : IRepositorio
    {
        private static Produto[] produtos = new Produto[]
        {
            new Produto{ ProdutoId = 10, Nome = "Caneta", Categoria = "MaterialEscolar", Preco = 2},
            new Produto{ ProdutoId = 20, Nome = "Borracha", Categoria = "MaterialEscolar", Preco = 1.5M},
            new Produto{ ProdutoId = 10, Nome = "Estojo", Categoria = "MaterialEscolar", Preco = 3.5M}
        };

        public IEnumerable<Produto> Produtos => produtos;
    }
}