using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Factory_Method.Interfaces
{
    public interface IPagamento
    {
        decimal CalcularTaxa(decimal valor);
        string Nome { get; }
    }
}
