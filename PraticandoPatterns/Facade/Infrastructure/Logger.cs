using PraticandoPatterns.Facade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Facade.Infrastructure
{
    public class Logger : ILogger
    {
        public void Erro(string msg, Exception ex)
        {
            Console.WriteLine($"ERRO: {msg} - EXCEÇÃO: {ex.Message}");
        }

        public void Info(string msg)
        {
            Console.WriteLine($"INFO: {msg}");
        }
    }
}
