using PraticandoPatterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Observer.Domain
{
    public class SistemaVendas : IObserver
    {
        public void Atualizar(string produto, int quantidade)
        {
            Console.WriteLine($"[Sistema de Vendas] Estoque atualizado para {produto}: {quantidade} unidades.");
        }
    }
}
