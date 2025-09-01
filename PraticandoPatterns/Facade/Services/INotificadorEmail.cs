using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Facade.Services
{
    public interface INotificadorEmail
    {
        void Enviar(string emailDestino, string assunto, string corpo, string anexoCaminho);
    }
}
