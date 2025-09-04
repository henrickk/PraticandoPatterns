using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraticandoPatterns.Facade.Services;

namespace PraticandoPatterns.Facade.Infrastructure
{
    public class NotificacaoEmail : INotificadorEmail
    {
        public void Enviar(string emailDestino, string assunto, string corpo, string anexoCaminho)
        {
            Console.WriteLine($"Enviando email para: {emailDestino}");
            Console.WriteLine($"Assunto: {assunto}");
            Console.WriteLine($"Corpo: {corpo}");
            Console.WriteLine($"Anexo: {anexoCaminho}");
        }
    }
}
