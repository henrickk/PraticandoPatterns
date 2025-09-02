using PraticandoPatterns.Facade.Domain;
using PraticandoPatterns.Facade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Facade.Infrastructure
{
    public class ExportarCsv : IExportadorCsv
    {
        public string Exportar(IEnumerable<Venda> vendas, ResumoRelatorio resumo, string pastaDestino)
        {
            
        }
    }
}
