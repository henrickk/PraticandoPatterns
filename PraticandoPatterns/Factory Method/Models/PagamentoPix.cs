using PraticandoPatterns.Factory_Method.Interfaces;

namespace PraticandoPatterns.Factory_Method.Models
{
    namespace PraticandoPatterns.Factory.Models
    {
        public class PagamentoPix : IPagamento
        {
            public string Nome => "Pix";
            public decimal CalcularTaxa(decimal valor) => valor * 0.01m;
        }
    }

}
