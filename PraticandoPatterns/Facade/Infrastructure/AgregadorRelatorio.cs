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
            // Corrigido: Removido ClienteId, pois não existe na Venda. Usando TotalVendas como TotalClientes (ajuste necessário se houver campo correto).
            return new ResumoRelatorio
            {
                TotalVendas = vendas.Count(),
                TotalClientes = vendas.Count(), // Substitua por lógica correta se houver campo de cliente.
                TotalProdutosVendidos = vendas.Sum(v => v.Itens?.Count ?? 0),
                ValorTotalVendas = vendas.Sum(v => v.ValorTotal),
                CaminhoArquivo = null // Adicionado para evitar erro de propriedade ausente.
            };
        }
    }
}
