using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Singleton.Models
{
    public class ServicoDeUsuario
    {
        private readonly Services.Logger _logger;
        public ServicoDeUsuario()
        {
            _logger = Services.Logger.Instance;
        }
        public void CriarUsuario(string nomeUsuario)
        {
            _logger.Log($"Criando usuário {nomeUsuario}");
            // Lógica para criar o usuário
            _logger.Log($"Usuário {nomeUsuario} criado com sucesso");
        }
    }
}
