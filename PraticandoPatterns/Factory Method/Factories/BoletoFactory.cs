using PraticandoPatterns.Factory_Method.Interfaces;
using PraticandoPatterns.Factory_Method.Models.PraticandoPatterns.Factory.Models;

namespace PraticandoPatterns.Factory_Method.Factories
{
    public class BoletoFactory : IPagamentoFactory
    {
        public IPagamento CriarPagamento() => new PagamentoBoleto();
    }
}
