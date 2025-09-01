using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Facade.Domain
{
    public class ResumoRelatorio
    {
        public int TotalVendas { get; set; }
        public int TotalClientes { get; set; }
        public int TotalProdutosVendidos { get; set; }
        public decimal ValorTotalVendas { get; set; }
        public string CaminhoArquivo { get; set; } = string.Empty;

        public ResumoRelatorio() {
            TotalVendas = 0;
            TotalClientes = 0;
            TotalProdutosVendidos = 0;
            ValorTotalVendas = 0;
        }
    }
}
