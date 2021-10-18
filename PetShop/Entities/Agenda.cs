using PetShop.Entities.Enums;
using PetShop.Entities.Exceptions;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace PetShop.Entities
{
    class Agenda
    {
        private static SqlCeConnection Connection;
        public int IdAgenda { get; set; }
        public DateTime DataAgendamento { get; set; }
        public Servico ServicoId { get; set; }
        public Animal AnimalId { get; set; }
        public Cliente ClienteId { get; set; }

        public Agenda(DateTime dataAgendamento, Servico servicoId, Animal animalId, Cliente clienteId)
        {
            DataAgendamento = dataAgendamento;
            ServicoId = servicoId;
            AnimalId = animalId;
            ClienteId = clienteId;
        }

        public Agenda(int id)
        {
            BuscarAgendamento(id);
        }

        private void BuscarAgendamento(int id)
        {
            using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
            {
                try
                {
                    Connection.Open();
                    SqlCeCommand Command = Connection.CreateCommand();
                    Command.CommandText = "SELECT * FROM Agenda WHERE Id = @Id";
                    Command.Parameters.AddWithValue("@Id", id);
                    using (SqlCeDataReader Reader = Command.ExecuteResultSet(ResultSetOptions.Scrollable))
                    {
                        if (Reader.HasRows)
                        {
                            while (Reader.Read())
                            {
                                IdAgenda = (int)Reader["Id"];
                                DataAgendamento = (DateTime)Reader["Data"];
                                ServicoId = new Servico((int)Reader["ServicoId"]);
                                AnimalId = new Animal((int)Reader["AnimalId"]);
                            }
                        }
                        else
                        {
                            throw new SqlCeResultException();

                        }
                    }
                    Command.CommandText = "SELECT Animal.ClienteId FROM Animal WHERE Animal.Id = @Id";
                    Command.Parameters["@Id"].Value = AnimalId.Id;
                    using (SqlCeDataReader reader = Command.ExecuteResultSet(ResultSetOptions.Scrollable))
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ClienteId = new Cliente((int)reader["ClienteId"]);
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
                    MessageBox.Show($"Falha no banco de dados ao buscar Agendamento: {e.Message}");
                    throw e;
                }
                catch (SqlCeResultException e)
                {
                    MessageBox.Show($"Falha no banco de dados ao buscar Agendamento: {e.Message}");
                    throw e;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ocorreu um erro na aplicação ao buscar por Agendamento: {e.Message}", "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw e;
                }
            }
        }

        public void AdicionarEditarAgendamento(TipoOperacao operacao)
        {
            using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
            {
                try
                {
                    Connection.Open();
                    SqlCeCommand Command = Connection.CreateCommand();
                    if (operacao == TipoOperacao.Adicionar)
                    {
                        Command.CommandText = "INSERT INTO Agenda (Data, ServicoId, AnimalId) VALUES (@Data, @ServicoId, @AnimalId)";
                    }
                    else if (operacao == TipoOperacao.Editar)
                    {
                        Command.CommandText = "UPDATE Agenda SET Data = @Data, ServicoId = @ServicoId, AnimalId = @AnimalId WHERE Id = @Id";
                        Command.Parameters.AddWithValue("@Id", IdAgenda);
                    }
                    Command.Parameters.AddWithValue("@Data", DataAgendamento);
                    Command.Parameters.AddWithValue("@ServicoId", ServicoId.Id);
                    Command.Parameters.AddWithValue("@AnimalId", AnimalId.Id);
                    if (Command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("O agendamento foi salvo", "Salvar Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlCeException e)
                {
                    MessageBox.Show($"Erro ao inserir no banco de dados: {e.Message}");
                    ErrorLogger.CreateErrorLog(e);
                }
            }
        }

        public static void RemoverAgendamento(int id)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "DELETE FROM Agenda WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Agendamento removido", "Remover agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Falha ao acessar o banco de dados: {e.Message}");
                ErrorLogger.CreateErrorLog(e);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Falha na aplicação: {e.Message}");
                ErrorLogger.CreateErrorLog(e);
            }
        }

        public static void RemoverAgendamento()
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "DELETE FROM Agenda";
                    if (command.ExecuteNonQuery() > 0)
                    {
                        FormNotificacao formNotificacao = new FormNotificacao();
                        formNotificacao.ShowAlert("Os registros de Agenda foram limpos", TipoNotificacao.Confirmar, "Limpar tabela de Agenda");
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Falha ao acessar o banco de dados: {e.Message}");
                ErrorLogger.CreateErrorLog(e);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Falha na aplicação: {e.Message}");
                ErrorLogger.CreateErrorLog(e);
            }
        }

        public static void RemoverAgendamento(DateTime data)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "DELETE FROM Agenda WHERE Data < @Data";
                    command.Parameters.AddWithValue("@Data", data);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        FormNotificacao formNotificacao = new FormNotificacao();
                        formNotificacao.ShowAlert("Os registros de Agenda foram limpos", TipoNotificacao.Confirmar, "Limpar tabela de Agenda");
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Ocorreu um erro no banco de dados ao limpar os agendamentos: {e.Message}");
                ErrorLogger.CreateErrorLog(e);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação ao limpar os agendamentos: {e.Message}");
                ErrorLogger.CreateErrorLog(e);
            }
        }

        public static DataTable ListarAgendamentos()
        {
            DataTable data = new DataTable();
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT Agenda.Id, Agenda.Data, Servicos.NomeServico, Clientes.Nome as Cliente, Animal.Nome as NomeAnimal FROM Agenda INNER JOIN Animal ON Agenda.AnimalId = Animal.Id INNER JOIN Clientes ON Animal.ClienteId = Clientes.Id INNER JOIN Servicos ON Animal.ServicoId = Servicos.Id";
                    command.ExecuteNonQuery();
                    SqlCeDataAdapter sqlCeData = new SqlCeDataAdapter(command);
                    sqlCeData.Fill(data);
                    data.Columns.Add("Horario", typeof(TimeSpan));
                    foreach (DataRow hora in data.Rows)
                    {
                        hora["Horario"] = new TimeSpan(((DateTime)hora["Data"]).Hour, ((DateTime)hora["Data"]).Minute, ((DateTime)hora["Data"]).Second);
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro ao acessar o banco de dados: {e.Message},", "Erro ao exibir agendamentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            return data;
        }

        public static DataTable ListarAgendamentos(DateTime dataInicial, DateTime DataFinal)
        {
            DataTable data = new DataTable();
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT Agenda.Id, Agenda.Data, Servicos.NomeServico, Clientes.Nome as Cliente, Animal.Nome as NomeAnimal FROM Agenda INNER JOIN Animal ON Agenda.AnimalId = Animal.Id INNER JOIN Clientes ON Animal.ClienteId = Clientes.Id INNER JOIN Servicos ON Agenda.ServicoId = Servicos.Id WHERE Agenda.Data BETWEEN @dataInicial AND @dataFinal";
                    command.Parameters.AddWithValue("@dataInicial", dataInicial.Date);
                    command.Parameters.AddWithValue("@dataFinal", DataFinal.Date + new TimeSpan(23, 59, 59));
                    command.ExecuteNonQuery();
                    SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command);
                    dataAdapter.Fill(data);
                    data.Columns.Add("Horario", typeof(TimeSpan));
                    foreach (DataRow hora in data.Rows)
                    {
                        hora["Horario"] = new TimeSpan(((DateTime)hora["Data"]).Hour, ((DateTime)hora["Data"]).Minute, ((DateTime)hora["Data"]).Second);
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro no banco de dados: {e.Message}", "Falha ao listar agendamentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro na aplicação: {e.Message}", "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            return data;
        }
    }
}
