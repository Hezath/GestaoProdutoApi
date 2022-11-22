namespace GestaoProduto.Domain.Models
{
    public abstract class BaseEntity
    {
        public int Id {get; private set; }
        public bool Excluido {get; private set; }
    }
}