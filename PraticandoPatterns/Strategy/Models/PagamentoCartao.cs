using PraticandoPatterns.Strategy.Intefaces;

namespace PraticandoPatterns.Strategy.Models
{
    public class PagamentoCartao : IPagamento
    {
        public decimal CalcularTaxa(decimal valor)
        {
            return valor * 0.05m; 
        }
    }
}
