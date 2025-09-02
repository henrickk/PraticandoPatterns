using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Facade.Domain
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public void Validar()
        {
            if (Id != 0 && (string.IsNullOrEmpty(Nome) || Nome.Length < 3))
            {
                throw new ArgumentException("Nome do cliente inválido.");
            }

        }
    }
}
