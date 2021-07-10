using PetShop.Entities.Enums;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using PetShop.Entities.Exceptions;

namespace PetShop.Entities
{
    public class Servico
    {
        private static SqlCeConnection Connection;
        public int Id { get; set; }
        public string NomeServico { get; set; }
        public decimal Valor { get; set; }

        public Servico(string nomeServico, decimal valor)
        {
            NomeServico = nomeServico;
            Valor = valor;
        }

        public Servico(int id)
        {
            BuscarServico(id);
        }

        private void BuscarServico(int id)
        {
            using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
            {
                try
                {
                    Connection.Open();
                    SqlCeCommand Command = Connection.CreateCommand();
                    Command.CommandText = "SELECT * FROM Servicos WHERE Id = @Id";
                    Command.Parameters.AddWithValue("@Id", id);
                    using (SqlCeDataReader Reader = Command.ExecuteResultSet(ResultSetOptions.Scrollable))
                    {
                        if (Reader.HasRows)
                        {
                            while (Reader.Read())
                            {
                                Id = (int)Reader["Id"];
                                NomeServico = (string)Reader["NomeServico"];
                                Valor = (decimal)Reader["Valor"];
                            }
                        }
                        else
                        {
                            throw new SqlCeResultException();
                        }
                    }
                }
                catch (SqlCeException e)
                {
                    MessageBox.Show($"Falha ao buscar Serviço no banco de dados: {e.Message}");
                    throw e;
                }
                catch (SqlCeResultException e)
                {
                    MessageBox.Show($"Falha ao buscar Serviço no banco de dados: {e.Message}");
                    throw e;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Falha na aplicação ao buscar Serviço: {e.Message}", "Erro no programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw e;
                }
            }
        }

        public static DataTable ListarServicos()
        {
            DataTable data = new DataTable();
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT * FROM Servicos";
                    command.ExecuteNonQuery();
                    SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command);
                    dataAdapter.Fill(data);
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro no banco de dados: {e.Message}", "Erro ao obter lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação: {e.Message}", "Erro no aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }

        public void AdicionarEditarServico(TipoOperacao operacao)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    if (operacao == TipoOperacao.Adicionar)
                    {
                        command.CommandText = "INSERT INTO Servicos (NomeServico, Valor) VALUES (@NomeServico, @Valor)";
                    }
                    else if (operacao == TipoOperacao.Editar)
                    {
                        command.CommandText = "UPDATE Servicos SET NomeServico = @NomeServico, Valor = @Valor WHERE Id = @Id";
                        command.Parameters.AddWithValue("@Id", Id);
                    }
                    command.Parameters.AddWithValue("@NomeServico", NomeServico);
                    command.Parameters.AddWithValue("@Valor", Valor);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("O Serviço foi salvo", "Salvar Serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro no banco de dados: {e.Message}", "Erro ao salvar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação: {e.Message}", "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ExcluirServico(int id)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "DELETE FROM Servicos WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("O Serviço foi removido", "Remover Serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro no banco de dados: {e.Message}", "Erro ao salvar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação: {e.Message}", "Erro no aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
