using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Factory_Method.Interfaces
{
    public interface IPagamentoFactory
    {
        IPagamento CriarPagamento();
    }
}
