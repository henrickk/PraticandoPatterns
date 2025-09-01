using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Facade.Domain
{
    public class FiltroRelatorio 
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public string? Categoria { get; set; }

        public void Validar()
        {
            if (DataInicio <= DataFim)
            {
                Console.WriteLine("Data válida.");
            }

            if (!ValidarData())
                throw new ArgumentException("Data inválida: DataInicio > DataFim.");

            ValidarCliente();
            ValidarCategoria();
        }

    }
}
