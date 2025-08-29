using PraticandoPatterns.Factory_Method.Interfaces;

namespace PraticandoPatterns.Factory_Method.Models
{
    namespace PraticandoPatterns.Factory.Models
    {
        public class PagamentoBoleto : IPagamento
        {
            public string Nome => "Boleto";
            public decimal CalcularTaxa(decimal valor) => 3.00m;
        }
    }

}
