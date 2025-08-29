using PraticandoPatterns.Strategy.Intefaces;

namespace PraticandoPatterns.Strategy.Models
{
    public class PagamentoCriptomoeda : IPagamento
    {
        public decimal CalcularTaxa(decimal valor)
        {
            return valor * 0.02m;
        }
    }
}
