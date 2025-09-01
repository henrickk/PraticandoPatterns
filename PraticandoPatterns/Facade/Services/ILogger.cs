using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Facade.Services
{
    public interface ILogger
    {
        void Info(string msg);

        void Erro(string msg, Exception ex);
    }
}
