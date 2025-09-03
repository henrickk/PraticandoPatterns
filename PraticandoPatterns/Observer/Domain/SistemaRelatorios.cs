using PraticandoPatterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Observer.Domain
{
    public class SistemaRelatorios : IObserver
    {
        public void Atualizar(string produto, int quantidade)
        {
            Console.WriteLine($"[Relatórios] Registrando alteração do produto {produto}: {quantidade} unidades restantes.");
        }
    }
}
