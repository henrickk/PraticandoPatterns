using PraticandoPatterns.Facade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Facade.Facade
{
    public class RelatorioVendasFacade
    {
        private readonly IVendaRepository _vendaRepository;
        private readonly ICalculadoraImpostos _calculadoraImpostos;
        private readonly ICalculadoraDescontos _calculadoraDescontos;
        private readonly IAgregadorRelatorio _agregadorRelatorio;
        private readonly IExportadorCsv _exportadorCsv;
        private readonly INotificadorEmail? _notificadorEmail;
        private readonly ILogger? _logger;

    public RelatorioVendasFacade(
            IVendaRepository vendaRepository,
            ICalculadoraImpostos calculadoraImpostos,
            ICalculadoraDescontos calculadoraDescontos,
            IAgregadorRelatorio agregadorRelatorio,
            IExportadorCsv exportadorCsv,
            INotificadorEmail? notificadorEmail = null,
            ILogger? logger = null)
        {
            _vendaRepository = vendaRepository;
            _calculadoraImpostos = calculadoraImpostos;
            _calculadoraDescontos = calculadoraDescontos;
            _agregadorRelatorio = agregadorRelatorio;
            _exportadorCsv = exportadorCsv;
            _notificadorEmail = notificadorEmail;
            _logger = logger;
        }

        public void GerarRelatorio(DateTime dataInicio, DateTime dataFim, string pastaDestino, string? emailDestino = null)
        {
            try
            {
                _logger?.Info("Iniciando geração de relatório de vendas.");
                var vendas = _vendaRepository.BuscarPor(dataInicio, dataFim);
                _logger?.Info($"Total de vendas obtidas: {vendas.Count()}");
                var impostos = _calculadoraImpostos.Calcular(vendas);
                _logger?.Info($"Total de impostos calculados: {impostos:C}");
                var descontos = _calculadoraDescontos.Calcular(vendas);
                _logger?.Info($"Total de descontos calculados: {descontos:C}");
                var resumo = _agregadorRelatorio.GerarResumo(vendas, impostos, descontos);
                _logger?.Info("Resumo do relatório gerado.");
                var caminhoArquivo = _exportadorCsv.Exportar(vendas, resumo, pastaDestino);
                _logger?.Info($"Relatório exportado para: {caminhoArquivo}");
                if (!string.IsNullOrEmpty(emailDestino) && _notificadorEmail != null)
                {
                    _notificadorEmail.Enviar(emailDestino, "Relatório de Vendas", "Segue em anexo o relatório de vendas.", caminhoArquivo);
                    _logger?.Info($"Relatório enviado por email para: {emailDestino}");
                }
                _logger?.Info("Geração de relatório de vendas concluída com sucesso.");
            }
            catch (Exception ex)
            {
                _logger?.Erro("Erro ao gerar relatório de vendas.", ex);
                throw;
            }
        }
    }
}
