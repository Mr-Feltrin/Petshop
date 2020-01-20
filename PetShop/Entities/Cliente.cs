using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Data;

namespace PetShop.Entities
{
    class Cliente
    {
        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public string Segmento { get; set; }
        public string Apelido { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public int Cep { get; set; }
        public int TelefonePrimario { get; set; }
        public int TelefoneSecundario { get; set; }
        public int Celular { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public int Cpf { get; set; }
        public int Cnpj { get; set; }
        public string Observacoes { get; set; }
        public List<Animal> Animais { get; set; }

        public Cliente(int clienteId, string nomeCliente, string segmento, string apelido, string endereco, string bairro, string cidade, string uf, int cep, int telefonePrimario, int telefoneSecundario, int celular, string complemento, string email, int cpf, int cnpj, string observacoes)
        {
            ClienteId = clienteId;
            NomeCliente = nomeCliente;
            Segmento = segmento;
            Apelido = apelido;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Cep = cep;
            TelefonePrimario = telefonePrimario;
            TelefoneSecundario = telefoneSecundario;
            Celular = celular;
            Complemento = complemento;
            Email = email;
            Cpf = cpf;
            Cnpj = cnpj;
            Observacoes = observacoes;
        }

        public void AdicionarCliente()
        {
            MysqlConnection mysqlConnection = new MysqlConnection($"INSERT INTO animais VALUES = 'nome = {NomeCliente}'");
        }
        
    }
}
