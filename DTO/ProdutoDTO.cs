namespace Ecommerce.Produto
{
    public class ProdutoDTO
    {
        public int id { get; set; }

        public string? nome { get; set; }

        public string? descricao { get; set; }

        public string? imagem { get; set; }

        public float? valor { get; set; }

        public int? quantidade { get; set; }
    }
}
