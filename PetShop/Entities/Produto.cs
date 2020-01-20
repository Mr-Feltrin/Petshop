using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entities
{
    class Produto
    {
        public int ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public int CodigoBarras { get; set; }
        public string TipoUnidade { get; set; }
        public int Quantidade { get; set; }
        public string Referencia { get; set; }
        public string Localizacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public float EstoqueMinimo { get; set; }
        public float EstoqueAtual { get; set; }
        public DateTime DataValidade { get; set; }
        public decimal ValorCusto { get; set; }
        public int MargemAvista { get; set; }
        public decimal ValorProduto { get; set; }
        public string Observacoes { get; set; }

        public Produto(int produtoId, string nomeProduto, int codigoBarras, string tipoUnidade, int quantidade, string referencia, string localizacao, DateTime dataCadastro, string marca, string categoria, float estoqueMinimo, float estoqueAtual, DateTime dataValidade, decimal valorCusto, int margemAvista, decimal valorProduto, string observacoes)
        {
            ProdutoId = produtoId;
            NomeProduto = nomeProduto;
            CodigoBarras = codigoBarras;
            TipoUnidade = tipoUnidade;
            Quantidade = quantidade;
            Referencia = referencia;
            Localizacao = localizacao;
            DataCadastro = dataCadastro;
            Marca = marca;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            EstoqueAtual = estoqueAtual;
            DataValidade = dataValidade;
            ValorCusto = valorCusto;
            MargemAvista = margemAvista;
            ValorProduto = valorProduto;
            Observacoes = observacoes;
        }
    }
}
