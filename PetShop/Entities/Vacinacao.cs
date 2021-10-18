using PetShop.Entities.Exceptions;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace PetShop.Entities
{
    class Vacinacao
    {
        private static SqlCeConnection Connection;
        public int Id { get; set; }
        public Animal AnimalId { get; set; }
        public Vacina VacinaId { get; set; }
        public DateTime DataVacina { get; set; }
        public Vacinacao(Animal animalId, Vacina vacinaId, DateTime dataVacina)
        {
            AnimalId = animalId;
            VacinaId = vacinaId;
            DataVacina = dataVacina;
        }

        public Vacinacao(int id)
        {
            BuscarVacinacao(id);
        }

        private void BuscarVacinacao(int id)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT * FROM Vacinacao WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlCeDataReader reader = command.ExecuteResultSet(ResultSetOptions.Scrollable))
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Id = (int)reader["Id"];
                                AnimalId = new Animal((int)reader["AnimalId"]);
                                VacinaId = new Vacina((int)reader["VacinaId"]);
                                DataVacina = (DateTime)reader["DataVacina"];
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
                MessageBox.Show($"Erro no banco de dados ao buscar por Vacinação: {e.Message}", "Falha nos dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
            catch (SqlCeResultException e)
            {
                MessageBox.Show($"Erro no banco de dados ao buscar por Vacinação: {e.Message}", "Falha nos dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Falha na aplicação ao buscar por Vacinação: {e.Message}", "Erro no programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }

        public void AdicionarVacinacao()
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "INSERT INTO Vacinacao (AnimalId, VacinaId, DataVacina) VALUES (@AnimalId, @VacinaId, @DataVacina)";
                    command.Parameters.AddWithValue("@AnimalId", AnimalId.Id);
                    command.Parameters.AddWithValue("@VacinaId", VacinaId.Id);
                    command.Parameters.AddWithValue("@DataVacina", DataVacina);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Os dados de vacinação foram salvos", "Adicionar Vacinação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static DataTable ListarVacinacoes(int? animalId = null, DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            DataTable data = new DataTable();
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    if (dataInicial != null && dataFinal != null)
                    {
                        command.CommandText = "SELECT Vacinacao.Id, Vacinas.Imunologia, Vacinacao.DataVacina, Animal.Nome as NomeAnimal, Clientes.Nome as NomeCliente, Animal.Especie, Animal.Raca, Animal.Sexo FROM Vacinacao INNER JOIN Animal ON Vacinacao.AnimalId = Animal.Id INNER JOIN Clientes ON Animal.ClienteId = Clientes.Id INNER JOIN Vacinas ON Vacinacao.VacinaId = Vacinas.Id WHERE Vacinacao.DataVacina BETWEEN @dataInicial AND @dataFinal";
                        command.Parameters.AddWithValue("dataInicial", Convert.ToDateTime(dataInicial).Date);
                        command.Parameters.AddWithValue("dataFinal", Convert.ToDateTime(dataFinal).Date + new TimeSpan(23, 59, 59));
                    }
                    else if (animalId != null)
                    {
                        command.CommandText = "SELECT Vacinacao.Id, Vacinas.Imunologia, Vacinacao.DataVacina, Animal.Nome as NomeAnimal, Clientes.Nome as NomeCliente, Animal.Especie, Animal.Raca, Animal.Sexo FROM Vacinacao INNER JOIN Animal ON Vacinacao.AnimalId = Animal.Id INNER JOIN Clientes ON Animal.ClienteId = Clientes.Id INNER JOIN Vacinas ON Vacinacao.VacinaId = Vacinas.Id WHERE Animal.Id = @AnimalId";
                        command.Parameters.AddWithValue("@AnimalId", animalId);
                    }
                    else
                    {
                        command.CommandText = "SELECT Vacinacao.Id, Vacinas.Imunologia, Vacinacao.DataVacina, Animal.Nome as NomeAnimal, Clientes.Nome as NomeCliente, Animal.Especie, Animal.Raca, Animal.Sexo FROM Vacinacao INNER JOIN Animal ON Vacinacao.AnimalId = Animal.Id INNER JOIN Clientes ON Animal.ClienteId = Clientes.Id INNER JOIN Vacinas ON Vacinacao.VacinaId = Vacinas.Id";
                    }
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

        public static void ExcluirVacinacao(int id)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "DELETE FROM Vacinacao WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("A Vacinacao foi removida", "Remover Vacinacao", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
