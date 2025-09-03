using PraticandoPatterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Observer.Domain
{
    public class NotificadorEmail : IObserver
    {
        public void Atualizar(string produto, int quantidade)
        {
            if (quantidade < 5)
                Console.WriteLine($"[Email] Alerta: Produto {produto} está com baixo estoque ({quantidade} unidades).");
        }
    }
}
