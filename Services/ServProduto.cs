namespace Ecommerce.Produto
{
    public interface ServProdutoAbstract
    {
        Produto GetProdutoById(int id);
        Produto CreateProduto(ProdutoDTO dto);
        Produto UpdateProdutoQuantidade(UpdateProdutoQuantidadeDTO dto);
    }

    public class ServProduto : ServProdutoAbstract
    {
        private DataContext _dataContext;

        public ServProduto()
        {
            _dataContext = GeradorDeServicos.CarregarContexto();
        }

        public Produto GetProdutoById(int id)
        {
            var produto = _dataContext.Produto.FirstOrDefault(produto => produto.Id == id);

            if (produto == null)
            {
                throw new Exception("Produto não encontrado!");
            }

            return produto;
        }

        public Produto CreateProduto(ProdutoDTO dto)
        {
            var produto = new Produto();

            produto.Id = dto.id;
            produto.Nome = dto.nome;
            produto.Descricao = dto.descricao;
            produto.Imagem = dto.imagem;
            produto.Valor = dto.valor;
            produto.Quantidade = dto.quantidade;

            _dataContext.Add(produto);
            _dataContext.SaveChanges();

            return produto;
        }

        public Produto UpdateProdutoQuantidade(UpdateProdutoQuantidadeDTO dto)
        {
            var produto = _dataContext.Produto.FirstOrDefault(produto => produto.Id == dto.id);

            if (produto == null)
            {
                throw new Exception("Produto não encontrado!");
            }

            produto.Quantidade = dto.quantidade;
            _dataContext.SaveChanges();

            return produto;
        }
    }
}