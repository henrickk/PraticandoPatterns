using PraticandoPatterns.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Facade.Services
{
    public interface IVendaRepository
    {
        IEnumerable<Venda> BuscarPor(FiltroRelatorio filtro);
    }
}
