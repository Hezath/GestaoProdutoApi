using System;

namespace GestaoProduto.Domain.Models
{
    public class Produto : BaseEntity
    {
        public string Descricao { get; set; }
        public bool? Situacao { get; set; }
        public DateTime? DataFrabricacao { get; set; }
        public DateTime? DataValidade { get; set; }
        /*Fornecedor*/

        public Produto(string descricao, bool? situacao, DateTime? dataFrabricacao, DateTime? dataValidade)
        {
            ValidarProduto(descricao, dataFrabricacao, dataValidade);
            Descricao = descricao;
            Situacao = situacao;
            DataFrabricacao = DataFrabricacao;
            DataValidade = dataValidade;
        }
        public void Update(string descricao, bool? situacao, DateTime? dataFrabricacao, DateTime? dataValidade)
        {
           ValidarProduto(descricao, dataFrabricacao, dataValidade);
        }


        private void ValidarProduto(string descricao, DateTime? dataFrabricacao, DateTime? dataValidade)
        {
            if(string.IsNullOrEmpty(descricao))
               throw new InvalidOperationException("A descrição é inválido");
            if(DateTime.Compare(dataFrabricacao, dataValidade) >= 0)
                throw new InvalidOperationException("A data de Fabrição é inválida");
        }



    }
}