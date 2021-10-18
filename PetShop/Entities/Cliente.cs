using PetShop.Entities.Enums;
using PetShop.Entities.Exceptions;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace PetShop.Entities
{
    public class Cliente
    {
        private static SqlCeConnection connection;
        public int Id { get; set; }
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
        public DateTime DataCadastro { get; set; }

        public Cliente(string nomeCliente, string tipo, string apelido, string endereco, string bairro, string cidade, string uf, string cep, string telefonePrimario, string telefoneSecundario, string celular, string complemento, string email, string cpf, string cnpj, string observacoes, DateTime dataCadastro)
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
            DataCadastro = dataCadastro;
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
                using (connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    connection.Open();
                    SqlCeCommand comando = connection.CreateCommand();
                    comando.CommandText = "SELECT * FROM Clientes";
                    comando.ExecuteNonQuery();
                    SqlCeDataAdapter dataadp = new SqlCeDataAdapter(comando);
                    dataadp.Fill(dta);
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show("Erro ao exibir os dados na lista: " + e.Message, "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na aplicação ao exibir os dados na lista: " + e.Message, "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            return dta;
        }

        public void AdicionarEditarCliente(TipoOperacao operacao)
        {
            try
            {
                using (connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    connection.Open();
                    SqlCeCommand command = connection.CreateCommand();
                    if (operacao == TipoOperacao.Adicionar)
                    {
                        command.CommandText = "INSERT INTO Clientes (Nome, Tipo, Apelido, Endereco, Bairro, Cidade, Estado, Cep, Telefone_Principal, Telefone_Secundario, Celular, Complemento, Email, Cpf, Cnpj, Observacoes, DataCadastro) VALUES (@Nome, @Tipo, @Apelido, @Endereco, @Bairro, @Cidade, @Estado, @Cep, @Telefone_Principal, @Telefone_Secundario, @Celular, @Complemento, @Email, @Cpf, @Cnpj, @Observacoes, @DataCadastro)";
                        command.Parameters.AddWithValue("@DataCadastro", DataCadastro);
                    }
                    else
                    {
                        command.CommandText = "UPDATE Clientes SET Nome = @Nome, Tipo = @Tipo, Apelido = @Apelido, Endereco = @Endereco, Bairro = @Bairro, Cidade = @Cidade, Estado = @Estado, Cep = @Cep, Telefone_Principal = @Telefone_Principal, Telefone_Secundario = @Telefone_Secundario, Celular = @Celular, Complemento = @Complemento, Email = @Email, Cpf = @Cpf, Cnpj = @Cnpj, Observacoes = @Observacoes WHERE Id = @Id";
                        command.Parameters.AddWithValue("@Id", Id);
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
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao salvar as informações do Cliente: " + e.Message, "Falha no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
        }

        public static void ExcluirCliente(int idCliente)
        {
            try
            {
                using (connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    connection.Open();
                    SqlCeCommand comando = connection.CreateCommand();
                    comando.CommandText = "DELETE FROM Clientes WHERE Id = @Id";
                    comando.Parameters.AddWithValue("@Id", idCliente);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente removido", "Remover Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao remover Cliente: " + e.Message, "Remover Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
        }

        public static void ExcluirCliente(DateTime data)
        {
            try
            {
                using (connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    connection.Open();
                    SqlCeCommand comando = connection.CreateCommand();
                    comando.CommandText = "DELETE FROM Clientes WHERE DataCadastro < @Data";
                    comando.Parameters.AddWithValue("@Data", data);
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        FormNotificacao formNotificacao = new FormNotificacao();
                        formNotificacao.ShowAlert("Os registros de Clientes foram limpos", TipoNotificacao.Confirmar, "Limpar tabela de Clientes");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Limpar tabela de Clientes: " + e.Message, "Limpar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
        }

        public static void ExcluirCliente()
        {
            try
            {
                using (connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    connection.Open();
                    SqlCeCommand comando = connection.CreateCommand();
                    comando.CommandText = "DELETE FROM Clientes";
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        FormNotificacao formNotificacao = new FormNotificacao();
                        formNotificacao.ShowAlert("Os registros de Clientes foram limpos", TipoNotificacao.Confirmar, "Limpar tabela de Clientes");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Limpar tabela de Clientes: " + e.Message, "Limpar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
        }

        private void BuscarCliente(int idCliente)
        {
            try
            {
                using (connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    connection.Open();
                    SqlCeCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM Clientes WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", idCliente);
                    using (var reader = command.ExecuteResultSet(ResultSetOptions.Scrollable))
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Id = (int)reader["Id"];
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
                        else
                        {
                            throw new SqlCeResultException();
                        }
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro ao buscar Cliente no banco de dados: {e.Message}", "Erro ao buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
            catch (SqlCeResultException e)
            {
                MessageBox.Show($"Erro ao buscar Cliente no banco de dados: {e.Message}", "Erro ao buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro na aplicação ao buscar Cliente: {e.Message}", "Erro ao buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }
    }
}
