using PraticandoPatterns.Factory_Method.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Factory_Method.Models
{
    public class Pedido
    {
        public decimal Valor { get; set; }
        public IPagamento FormaPagamento { get; set; }

        public void Processar()
        {
            decimal taxa = FormaPagamento.CalcularTaxa(Valor);
            decimal total = Valor + taxa;
            Console.WriteLine($"Valor do pedido: {Valor:C}, Taxa: {taxa:C}, Total: {total:C}");
            Console.WriteLine($"Forma de pagamento: {FormaPagamento.Nome}");
        }
    }
}
