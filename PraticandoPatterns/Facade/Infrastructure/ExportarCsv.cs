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
            var nomeArquivo = $"RelatorioVendas_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
            var caminhoCompleto = Path.Combine(pastaDestino, nomeArquivo);
            using (var writer = new StreamWriter(caminhoCompleto))
            {
                writer.WriteLine("Id,Data,ValorTotal");
                foreach (var venda in vendas)
                {
                    writer.WriteLine($"{venda.Id},{venda.Data:yyyy-MM-dd},{venda.ValorTotal:F2}");
                }
                writer.WriteLine();
                writer.WriteLine("Resumo");
                writer.WriteLine($"Total Vendas,{resumo.TotalVendas}");
                writer.WriteLine($"Total Clientes,{resumo.TotalClientes}");
                writer.WriteLine($"Total Produtos Vendidos,{resumo.TotalProdutosVendidos}");
                writer.WriteLine($"Valor Total Vendas,{resumo.ValorTotalVendas:F2}");
            }
            return caminhoCompleto;
        }
    }
}
