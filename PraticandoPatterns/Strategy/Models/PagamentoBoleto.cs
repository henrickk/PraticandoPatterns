using PraticandoPatterns.Strategy.Intefaces;

namespace PraticandoPatterns.Strategy.Models
{
    public class PagamentoBoleto : IPagamento
    {
        public decimal CalcularTaxa(decimal valor)
        {
            return 3.00m; 
        }
    }
}
