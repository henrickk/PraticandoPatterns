using PraticandoPatterns.Strategy.Intefaces;
using PraticandoPatterns.Strategy.Models;

namespace PraticandoPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do pedido: ");
            if (!decimal.TryParse(Console.ReadLine(), out var valorPedido))
            {
                Console.WriteLine("Valor inválido!");
                return; 
            }

            Console.WriteLine("Escolha a forma de pagamento:");
            Console.WriteLine("1 - Cartão");
            Console.WriteLine("2 - Pix");
            Console.WriteLine("3 - Boleto");
            Console.WriteLine("4 - Criptomoeda");
            Console.Write($"Opção: ");
            int.TryParse(Console.ReadLine(), out var opcao);

            var pagamento = new Dictionary<int, (string Nome, IPagamento)>
            {
                { 1, ("Cartão", new PagamentoCartao()) },
                { 2, ("Pix", new PagamentoPix()) },
                { 3, ("Boleto", new PagamentoBoleto()) },
                { 4, ("Criptomoeda", new PagamentoCriptomoeda()) }
            };

            if (pagamento.ContainsKey(opcao))
            {
                Console.WriteLine($"FormaPagamento: {pagamento[opcao].Nome}");

                Console.WriteLine($"Processando pagamento via {pagamento[opcao].Nome}...");

                var pedido = new Pedido
                {
                    Valor = valorPedido,
                    FormaPagamento = pagamento[opcao].Item2
                };
                pedido.Processar();
                Console.WriteLine("Pagamento processado com sucesso!");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}