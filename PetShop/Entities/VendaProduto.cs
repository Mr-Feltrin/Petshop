using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entities
{
    class VendaProduto
    {
        public Produto ProdutoId { get; set; }
        public int Quantidade { get; set; }
        private decimal ValorTotal { get { return ProdutoId.ValorProduto * Quantidade; } }
    }
}
