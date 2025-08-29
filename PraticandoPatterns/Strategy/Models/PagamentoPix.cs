using PraticandoPatterns.Strategy.Intefaces;

namespace PraticandoPatterns.Strategy.Models
{
    public class PagamentoPix : IPagamento
    {
        public decimal CalcularTaxa(decimal valor)
        {
            return valor * 0.01m; 
        }
    }
}
