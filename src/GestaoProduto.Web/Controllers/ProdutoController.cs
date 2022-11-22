using Microsoft.AspNetCore.Mvc;

namespace GestaoProduto.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : Controller
{
    private readonly ProdutoService _produtoService;
    private readonly IRepository<Produto> _produtoRepository; 

    public ProdutoController(ILogger<ProdutoController> logger, ProdutoService produtoService
    ,IRepository<Produto> produtoRepository)
    {
        _produtoService = produtoService;
        _produtoRepository = produtoRepository;
    }

    [HttpGet]
    public IEnumerable<ProdutoDTO> GetProdutos()
    {
        var produtos = _produtoRepository.GetAll();
    
        var resultado = produtos.Select(c => new ProdutoDTO{ Id = c.Id, Nome = c.Nome, Email= c.Email });

        return resultado;
    }


    [HttpGet("{id}")]
    public  ActionResult<Produto> GetProduto(int id)
    {
        var produto =  _produtoRepository.GetById(id);
        if (produto == null)
        {
            return NotFound(new { message = $"Produto de codigo={id} não encontrado" });
        }
        return produto;
    }
}
