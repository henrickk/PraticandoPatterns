using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraticandoPatterns.Facade.Domain;

namespace PraticandoPatterns.Facade.Services
{
    public interface IExportadorCsv
    {
       string Exportar(IEnumerable<Venda> vendas, ResumoRelatorio resumo, string pastaDestino);
    }
}
