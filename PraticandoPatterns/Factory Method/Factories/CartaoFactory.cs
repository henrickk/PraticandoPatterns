using PraticandoPatterns.Factory_Method.Interfaces;
using PraticandoPatterns.Factory_Method.Models.PraticandoPatterns.Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Factory_Method.Factories
{
    public class CartaoFactory : IPagamentoFactory
    {
        public IPagamento CriarPagamento() => new PagamentoCartao();
    }
}
