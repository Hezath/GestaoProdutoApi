using GestaoProduto.Domain.Interfaces;

namespace GestaoProduto.Domain.Models
{
    public class ProdutoService
    {
        private readonly IRepository<Produto> _produtoRepository;

        public ProdutoService(IRepository<Produto> produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Create(int id, string descricao, bool? situacao, DateTime? dataFrabricacao, DateTime? dataValidade )
        {
            var produto = _produtoRepository.GetById(id);

            if(produto == null)
            {
                produto = new Produto(descricao, situacao, dataFrabricacao, dataValidade);
                _produtoRepository.Save(produto);
            }
            else
                produto.Update(descricao, situacao, dataFrabricacao, dataValidade);
        }
    }
}