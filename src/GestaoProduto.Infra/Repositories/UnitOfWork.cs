using System.Threading.Tasks;
using GestaoProduto.Domain.Interfaces;
using GestaoProduto.Infra.Context;

namespace GestaoProduto.Infra.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}