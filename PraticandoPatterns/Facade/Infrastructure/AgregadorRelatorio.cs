using PraticandoPatterns.Facade.Domain;
using PraticandoPatterns.Facade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Facade.Infrastructure
{
    public class AgregadorRelatorio : IAgregadorRelatorio
    {
        public ResumoRelatorio GerarResumo(IEnumerable<Venda> vendas, decimal impostos, decimal descontos)
        {
            
        }
    }
}
