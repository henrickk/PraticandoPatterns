using PraticandoPatterns.Facade.Domain;
using PraticandoPatterns.Facade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Facade.Infrastructure
{
    public class CalcularImpostos : ICalculadoraImpostos
    {
        public decimal Calcular(IEnumerable<Venda> vendas)
        {
            return vendas.Sum(v => v.ValorTotal * 0.08m); // Exemplo: 8% de imposto sobre o valor total das vendas
        }
    }
}
