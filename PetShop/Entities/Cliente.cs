using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.Entities
{
    public class Cliente
    {
        private static SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString);
        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public string Tipo { get; set; }
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

        public Cliente(string nomeCliente, string tipo, string apelido, string endereco, string bairro, string cidade, string uf, int cep, int telefonePrimario, int telefoneSecundario, int celular, string complemento, string email, int cpf, int cnpj, string observacoes)
        {
            NomeCliente = nomeCliente;
            Tipo = tipo;
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

        public Cliente(int idCliente, string nomeCliente, string tipo, string apelido, string endereco, string bairro, string cidade, string uf, int cep, int telefonePrimario, int telefoneSecundario, int celular, string complemento, string email, int cpf, int cnpj, string observacoes) : this(nomeCliente, tipo, apelido, endereco, bairro, cidade, uf, cep, telefonePrimario, telefoneSecundario, celular, complemento, email, cpf, cnpj, observacoes)
        {
            ClienteId = idCliente;
        }


        public static DataTable ListarClientes()
        {
            DataTable dta = new DataTable();
            try
            {
                connection.Open();
                SqlCeCommand comando = connection.CreateCommand();
                comando.CommandText = "SELECT * FROM Clientes";
                comando.ExecuteNonQuery();
                SqlCeDataAdapter dataadp = new SqlCeDataAdapter(comando);
                dataadp.Fill(dta);
                dta.Columns["Endereco"].ColumnName = "Endereço";
                dta.Columns["Cep"].ColumnName = "CEP";
                dta.Columns["Telefone_Principal"].ColumnName = "Telefone Principal";
                dta.Columns["Telefone_Secundario"].ColumnName = "Telefone Secundario";
                dta.Columns["Cpf"].ColumnName = "CPF";
                dta.Columns["Cnpj"].ColumnName = "CNPJ";
                dta.Columns["Observacoes"].ColumnName = "Observações";
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show("Erro ao exibir os dados na lista: " + ex.Message, "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return dta;
        }

        public bool AdicionarCliente()
        {
            bool result = false;
            try
            {
                connection.Open();
                SqlCeCommand command = new SqlCeCommand("INSERT INTO Clientes (Nome, Tipo, Apelido, Endereco, Bairro, Cidade, Estado, Cep, Telefone_Principal, Telefone_Secundario, Celular, Complemento, Email, Cpf, Cnpj, Observacoes) VALUES (@Nome, @Tipo, @Apelido, @Endereco, @Bairro, @Cidade, @Estado, @Cep, @Telefone_Principal, @Telefone_Secundario, @Celular, @Complemento, @Email, @Cpf, @Cnpj, @Observacoes)");
                command.Parameters.AddWithValue("@Nome", NomeCliente);
                command.Parameters.AddWithValue("@Tipo", Tipo);
                command.Parameters.AddWithValue("@Apelido", Apelido);
                command.Parameters.AddWithValue("@Endereco", Endereco);
                command.Parameters.AddWithValue("@Bairro", Bairro);
                command.Parameters.AddWithValue("@Cidade", Cidade);
                command.Parameters.AddWithValue("@Estado", Uf);
                command.Parameters.AddWithValue("@Cep", Cep);
                command.Parameters.AddWithValue("@Telefone_Principal", TelefonePrimario);
                command.Parameters.AddWithValue("@Telefone_Secundario", TelefoneSecundario);
                command.Parameters.AddWithValue("@Celular", Celular);
                command.Parameters.AddWithValue("@Complemento", Complemento);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Cpf", Cpf);
                command.Parameters.AddWithValue("@Cnpj", Cnpj);
                command.Parameters.AddWithValue("@Observacoes", Observacoes);   
                if (command.ExecuteNonQuery() > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show("Erro ao salvar as informações do Cliente: " + ex.Message, "Falha no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        
    }
}
