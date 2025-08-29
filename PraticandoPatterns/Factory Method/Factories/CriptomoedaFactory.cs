using PraticandoPatterns.Factory_Method.Interfaces;
using PraticandoPatterns.Factory_Method.Models.PraticandoPatterns.Factory.Models;

namespace PraticandoPatterns.Factory_Method.Factories
{
    public class CriptomoedaFactory : IPagamentoFactory
    {
        public IPagamento CriarPagamento() => new PagamentoCriptomoeda();
    }
}
