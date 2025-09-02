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
        public decimal Calcular(IEnumerable<Venda> vendas)
        {
            // Implementação simples de cálculo de descontos
            // Aplica 5% de desconto apenas para vendas que possuem pelo menos um item "PROMO"
            decimal desconto = 0m;

            foreach (var venda in vendas)
            {
                if (venda.Itens != null && venda.Itens.Any(item => item.NomeProduto == "PROMO"))
                {
                    desconto += venda.ValorTotal * 0.05m;
                }
            }

            return desconto;
        }
    }
}
