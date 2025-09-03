using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Observer.Interfaces
{
    public interface IEstoqueSubject
    {
        void Registrar(IObserver observer);
        void Remover(IObserver observer);
        void Notificar(string produto, int quantidade);
    }
}
