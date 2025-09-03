using PraticandoPatterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Observer.Domain
{
    public class Estoque : IEstoqueSubject
    {
        private readonly List<IObserver> _observers = new();

        public void Registrar(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Remover(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notificar(string produto, int quantidade)
        {
            foreach (var obs in _observers)
            {
                obs.Atualizar(produto, quantidade);
            }
        }

        public void AlterarEstoque(string produto, int quantidade)
        {
            Console.WriteLine($"\n[Estoque] Produto {produto} agora tem {quantidade} unidades.");
            Notificar(produto, quantidade);
        }


    }
}
