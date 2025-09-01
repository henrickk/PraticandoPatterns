using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoPatterns.Facade.Domain
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public List<ItemVenda> Itens { get; set; } = new List<ItemVenda>();
        public decimal ValorTotal
        {
            get { return Itens.Sum(i => i.PrecoUnitario * i.Quantidade); }
        }
    }
}
