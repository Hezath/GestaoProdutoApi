using System.Collections.Generic;
using System.Linq;
using GestaoProduto.Domain.Models;
using GestaoProduto.Infra.Context;

namespace GestaoProduto.Infra.Repositories
{
    public class ProdutoRepository : Repository<Produto>
    {
        public ProdutoRepository(AppDbContext context) : base(context)
        {}

        public override Produto GetById(int id)
        {
            var query = _context.Set<Produto>().Where(e => e.Id == id);

            if(query.Any())
                return query.First();

            return null;
        }

        public override IEnumerable<Produto> GetAll()
        {
            var query = _context.Set<Produto>();

            return query.Any() ? query.ToList() : new List<Produto>();
        }
    }
}