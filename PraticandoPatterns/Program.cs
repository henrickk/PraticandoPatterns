using PraticandoPatterns.Facade.Domain;
using PraticandoPatterns.Facade.Facade;
using PraticandoPatterns.Facade.Infrastructure;
using PraticandoPatterns.Facade.Services;
using PraticandoPatterns.Factory_Method.Factories;
using PraticandoPatterns.Factory_Method.Interfaces;
using PraticandoPatterns.Factory_Method.Models;
using PraticandoPatterns.Observer.Domain;

namespace PraticandoPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Digite o valor do pedido: ");
            //if (!decimal.TryParse(Console.ReadLine(), out var valorPedido))
            //{
            //    Console.WriteLine("Valor inválido!");
            //    return; 
            //}

            //Console.WriteLine("Escolha a forma de pagamento:");
            //Console.WriteLine("1 - Cartão");
            //Console.WriteLine("2 - Pix");
            //Console.WriteLine("3 - Boleto");
            //Console.WriteLine("4 - Criptomoeda");
            //Console.Write($"Opção: ");
            //int.TryParse(Console.ReadLine(), out var opcao);

            //var pagamento = new Dictionary<int, (string Nome, IPagamento)>
            //{
            //    { 1, ("Cartão", new PagamentoCartao()) },
            //    { 2, ("Pix", new PagamentoPix()) },
            //    { 3, ("Boleto", new PagamentoBoleto()) },
            //    { 4, ("Criptomoeda", new PagamentoCriptomoeda()) }
            //};

            //if (pagamento.ContainsKey(opcao))
            //{
            //    Console.WriteLine($"FormaPagamento: {pagamento[opcao].Nome}");

            //    Console.WriteLine($"Processando pagamento via {pagamento[opcao].Nome}...");

            //    var pedido = new Pedido
            //    {
            //        Valor = valorPedido,
            //        FormaPagamento = pagamento[opcao].Item2
            //    };
            //    pedido.Processar();
            //    Console.WriteLine("Pagamento processado com sucesso!");
            //}
            //else
            //{
            //    Console.WriteLine("Opção inválida.");
            //}


            //Exercício Prático - Factory Method
            //Console.Write("Digite o valor do pedido: ");
            //if (!decimal.TryParse(Console.ReadLine(), out var valorPedido))
            //{
            //    Console.WriteLine("Valor inválido!");
            //    return;
            //}

            //Console.WriteLine("Escolha a forma de pagamento:");
            //Console.WriteLine("1 - Cartão");
            //Console.WriteLine("2 - Pix");
            //Console.WriteLine("3 - Boleto");
            //Console.WriteLine("4 - Criptomoeda");
            //Console.Write("Opção: ");

            //if (!int.TryParse(Console.ReadLine(), out var opcao))
            //{
            //    Console.WriteLine("Opção inválida!");
            //    return;
            //}

            //IPagamentoFactory factory = opcao switch
            //{
            //    1 => new CartaoFactory(),
            //    2 => new PixFactory(),
            //    3 => new BoletoFactory(),
            //    4 => new CriptomoedaFactory(),
            //    _ => null
            //};

            //if (factory == null)
            //{
            //    Console.WriteLine("Opção inválida!");
            //    return;
            //}

            //IPagamento pagamento = factory.CriarPagamento();
            //var pedido = new Pedido
            //{
            //    Valor = valorPedido,
            //    FormaPagamento = pagamento
            //};
            //pedido.Processar();
            //Console.WriteLine("Pagamento processado com sucesso!");

            //Exercício Prático - Singleton
            var servicoDeUsuario = new Singleton.Domain.ServicoDeUsuario();
            servicoDeUsuario.CriarUsuario("joao123");
            var servicoDePedido = new Singleton.Domain.ServicoDePedido();
            servicoDePedido.ProcessarPedido(101);


            //Exercício Prático - Facade
            {
                // 1. Criar dependências (injeção manual)
                //IVendaRepository vendaRepository = new VendaRepository();
                //ICalculadoraImpostos calculadoraImpostos = new CalcularImpostos();
                //ICalculadoraDescontos calculadoraDescontos = new CalcularDescontos();
                //IAgregadorRelatorio agregadorRelatorio = new AgregadorRelatorio();
                //IExportadorCsv exportadorCsv = new ExportarCsv();
                //INotificadorEmail notificadorEmail = new NotificacaoEmail();
                //ILogger logger = new Logger();

                // 2. Criar a facade
                //var relatorioFacade = new RelatorioVendasFacade(
                //    vendaRepository,
                //    calculadoraImpostos,
                //    calculadoraDescontos,
                //    agregadorRelatorio,
                //    exportadorCsv,
                //    notificadorEmail,
                //    logger
                //);

                // 3. Definir período e pasta de destino
                //var inicio = new DateTime(2024, 01, 01);
                //var fim = new DateTime(2024, 12, 31);
                //var pastaDestino = Path.Combine(Directory.GetCurrentDirectory(), "Relatorios");

                //if (!Directory.Exists(pastaDestino))
                //    Directory.CreateDirectory(pastaDestino);

                //// 4. Gerar relatório
                //relatorioFacade.GerarRelatorio(inicio, fim, pastaDestino, "teste@exemplo.com");

                //Console.WriteLine("Relatório gerado com sucesso!");

                // Exercício Prático - Observer
                var estoque = new Estoque();

                var vendas = new SistemaVendas();
                var relatorios = new SistemaRelatorios();
                var email = new NotificadorEmail();

                // Registrar observadores
                estoque.Registrar(vendas);
                estoque.Registrar(relatorios);
                estoque.Registrar(email);

                // Alterações de estoque
                estoque.AlterarEstoque("Notebook", 10);
                estoque.AlterarEstoque("Notebook", 4);
                estoque.AlterarEstoque("Mouse", 2);

                Console.WriteLine("\nRemovendo relatório do Observer...");
                estoque.Remover(relatorios);

                estoque.AlterarEstoque("Teclado", 3);
            }
        }
    }
}
