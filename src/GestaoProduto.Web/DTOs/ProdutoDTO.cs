using System.ComponentModel.DataAnnotations;

namespace GestaoProduto.Web.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        public bool? Situacao{ get; set; }
        public DateTime? DataFrabricacao{ get; set; }
        public DateTime? DataValidade{ get; set; }
    }
}