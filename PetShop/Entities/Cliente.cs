using PetShop.Entities.Enums;
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
        public string Cep { get; set; }
        public string TelefonePrimario { get; set; }
        public string TelefoneSecundario { get; set; }
        public string Celular { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Observacoes { get; set; }

        public Cliente(string nomeCliente, string tipo, string apelido, string endereco, string bairro, string cidade, string uf, string cep, string telefonePrimario, string telefoneSecundario, string celular, string complemento, string email, string cpf, string cnpj, string observacoes)
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

        public Cliente(int idCliente)
        {
            BuscarCliente(idCliente);
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

        public void AdicionarEditarCliente(TipoOperacao operacao)
        {
            try
            {
                connection.Open();
                SqlCeCommand command = connection.CreateCommand();
                if (operacao == TipoOperacao.Adicionar)
                {
                    command.CommandText = "INSERT INTO Clientes (Nome, Tipo, Apelido, Endereco, Bairro, Cidade, Estado, Cep, Telefone_Principal, Telefone_Secundario, Celular, Complemento, Email, Cpf, Cnpj, Observacoes) VALUES (@Nome, @Tipo, @Apelido, @Endereco, @Bairro, @Cidade, @Estado, @Cep, @Telefone_Principal, @Telefone_Secundario, @Celular, @Complemento, @Email, @Cpf, @Cnpj, @Observacoes)";
                }
                else
                {
                    command.CommandText = "UPDATE Clientes SET Nome = @Nome, Tipo = @Tipo, Apelido = @Apelido, Endereco = @Endereco, Bairro = @Bairro, Cidade = @Cidade, Estado = @Estado, Cep = @Cep, Telefone_Principal = @Telefone_Principal, Telefone_Secundario = @Telefone_Secundario, Celular = @Celular, Complemento = @Complemento, Email = @Email, Cpf = @Cpf, Cnpj = @Cnpj, Observacoes = @Observacoes WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", ClienteId);
                }

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
                    MessageBox.Show("Os dados do Cliente foram salvos.", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar as informações do Cliente: " + ex.Message, "Falha no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ExcluirCliente(int idCliente)
        {
            try
            {
                connection.Open();
                SqlCeCommand comando = connection.CreateCommand();
                comando.CommandText = "DELETE FROM Clientes WHERE Id = @Id";
                comando.Parameters.AddWithValue("@Id", idCliente);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente removido", "Remover Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover Cliente: " + ex.Message, "Remover Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void BuscarCliente(int idCliente)
        {
            try
            {
                connection.Open();
                SqlCeCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Clientes WHERE Id = @Id";
                command.Parameters.AddWithValue("@Id", idCliente);
                using (SqlCeDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ClienteId = (int)reader["Id"];
                        NomeCliente = reader["Nome"].ToString();
                        Tipo = reader["Tipo"].ToString();
                        Apelido = reader["Apelido"].ToString();
                        Endereco = reader["Endereco"].ToString();
                        Bairro = reader["Bairro"].ToString();
                        Cidade = reader["Cidade"].ToString();
                        Uf = reader["Estado"].ToString();
                        Cep = reader["Cep"].ToString();
                        TelefonePrimario = reader["Telefone_Principal"].ToString();
                        TelefoneSecundario = reader["Telefone_Secundario"].ToString();
                        Celular = reader["Celular"].ToString();
                        Complemento = reader["Complemento"].ToString();
                        Email = reader["Email"].ToString();
                        Cpf = reader["Cpf"].ToString();
                        Cnpj = reader["Cnpj"].ToString();
                        Observacoes = reader["Observacoes"].ToString();
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show("Falha ao localizar cliente: " + e.Message, "Não foi possível localizar o cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }     
        
    }
}
