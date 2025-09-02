using PraticandoPatterns.Facade.Domain;
using PraticandoPatterns.Facade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Facade.Infrastructure
{
    public class VendaRepository : IVendaRepository
    {
        public IEnumerable<Venda> BuscarPor(FiltroRelatorio filtro)
        {
            
        }
    }
}
