using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Produto
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private ServProdutoAbstract _servProduto;

        public ProdutoController()
        {
            _servProduto = new ServProduto();
        }

        [Route("/api/produto/{id}")]
        [HttpGet]
        public IActionResult GetProdutoById(int id)
        {
            try
            {
                var produto = _servProduto.GetProdutoById(id);
                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("/api/produto")]
        [HttpPost]
        public IActionResult PostProduto(ProdutoDTO dto)
        {
            try
            {
                var produto = _servProduto.CreateProduto(dto);
                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
