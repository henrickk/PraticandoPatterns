using PraticandoPatterns.Factory_Method.Interfaces;

namespace PraticandoPatterns.Factory_Method.Models
{
    namespace PraticandoPatterns.Factory.Models
    {
        public class PagamentoCriptomoeda : IPagamento
        {
            public string Nome => "Criptomoeda";
            public decimal CalcularTaxa(decimal valor) => valor * 0.02m;
        }
    }

}
