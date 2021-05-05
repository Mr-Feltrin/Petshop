using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entities
{
    class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public Cliente ClienteId { get; set; }
        public string Pagamento { get; set; }
        public decimal Desconto { get; set; }
        public List<VendaProduto> Produtos { get; set; }
        public List<Servico> Servicos { get; set; }
        public List<Vacina> Vacinas { get; set; }
    }
}
