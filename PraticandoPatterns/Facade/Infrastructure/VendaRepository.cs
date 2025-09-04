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
            var vendas = new List<Venda>
            {
                new Venda { Id = 1, Data = new DateTime(2024, 1, 15) },
                new Venda { Id = 2, Data = new DateTime(2024, 2, 20) },
                new Venda { Id = 3, Data = new DateTime(2024, 3, 10) },
                new Venda { Id = 4, Data = new DateTime(2024, 4, 5) },
            };
            return vendas.Where(v => v.Data >= filtro.DataInicio && v.Data <= filtro.DataFim);
        }
    }
}
