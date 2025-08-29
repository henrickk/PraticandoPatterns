using PraticandoPatterns.Factory_Method.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Factory_Method.Models
{
    namespace PraticandoPatterns.Factory.Models
    {
        public class PagamentoCartao : IPagamento
        {
            public string Nome => "Cartão";
            public decimal CalcularTaxa(decimal valor) => valor * 0.05m;
        }
    }
}
