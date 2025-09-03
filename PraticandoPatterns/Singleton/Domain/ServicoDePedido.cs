using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Singleton.Domain
{
    public class ServicoDePedido
    {
        private readonly Services.Logger _logger;
        public ServicoDePedido()
        {
            _logger = Services.Logger.Instance;
        }
        public void ProcessarPedido(int pedidoId)
        {
            _logger.Log($"Processando pedido {pedidoId}");
            
            _logger.Log($"Pedido {pedidoId} processado com sucesso");
        }

    }
}
