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

        void ValidarCliente()
        {
            if (Cliente == null)
            {
                throw new ArgumentException("ClienteId fornecido, mas Cliente é nulo.");
            }
        }
    }
}
