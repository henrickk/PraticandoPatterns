using PraticandoPatterns.Strategy.Intefaces;

namespace PraticandoPatterns.Strategy.Models
{
    public class Pedido
    {
        public decimal Valor { get; set; }
        public IPagamento FormaPagamento { get; set; }

        public void Processar()
        {
            decimal taxa = FormaPagamento.CalcularTaxa(Valor);
            decimal total = Valor + taxa;
            Console.WriteLine($"Valor do pedido: {Valor:C}, Taxa: {taxa:C}, Total a pagar: {total:C}");
        }
    }
}
