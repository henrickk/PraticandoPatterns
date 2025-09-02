using PraticandoPatterns.Facade.Domain;
using PraticandoPatterns.Facade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Facade.Infrastructure
{
    public class CalcularDescontos : ICalculadoraDescontos
    {
        public decimal Calcular(IEnumerable<Domain.Venda> vendas)
        {
            // Implementação simples de cálculo de descontos
            if ( NomeProduto == "PROMO")
            {
                vendas.Sum(v => v.ValorTotal * 0.05m); // Exemplo: 5% de desconto sobre o valor total das vendas
            }
            }
        }
}
