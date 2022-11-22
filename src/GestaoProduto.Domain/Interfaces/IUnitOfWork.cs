using System.Threading.Tasks;

namespace GestaoProduto.Domain.Interfaces
{
    public interface IUnitOfWork
    {
          Task Commit();
    }
}