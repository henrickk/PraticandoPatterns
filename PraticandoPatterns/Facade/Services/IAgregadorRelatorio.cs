using PraticandoPatterns.Facade.Domain;
using PraticandoPatterns.Facade.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Facade.Services
{
    public interface IAgregadorRelatorio
    {
        ResumoRelatorio GerarResumo(IEnumerable<Venda> vendas, decimal impostos, decimal descontos);
    }
}
