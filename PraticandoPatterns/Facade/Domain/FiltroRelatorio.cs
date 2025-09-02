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
            ValidarData();
            ValidarCliente();
            ValidarCategoria();
        }

        private void ValidarData()
        {
            if (DataInicio > DataFim)
            {
                throw new ArgumentException("DataInicio não pode ser maior que DataFim.");
            }
            // Adicione outras validações de data conforme necessário
        
        }
        private void ValidarCliente()
        {
            if (ClienteId.HasValue && Cliente == null)
            {
                throw new ArgumentException("ClienteId fornecido, mas Cliente é nulo.");
            }
            // Adicione outras validações de cliente conforme necessário
        }
        private void ValidarCategoria()
        {
            if (!string.IsNullOrWhiteSpace(Categoria))
            {
                var categoriasValidas = new List<string> { "Eletrônicos", "Roupas", "Alimentos" };
                if (!categoriasValidas.Contains(Categoria))
                    throw new ArgumentException("Categoria inválida.");
            }
        }

    }
}
