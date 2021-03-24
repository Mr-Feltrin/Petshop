using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using PetShop.Entities.Enums;

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
                    using (SqlCeDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Id = (int)reader["Id"];
                            AnimalId = new Animal((int)reader["AnimalId"]);
                            VacinaId = new Vacina((int)reader["VacinaId"]);
                            DataVacina = (DateTime)reader["DataVacina"];
                        }
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro no banco de dados: {e.Message}", "Falha nos dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Falha na aplicação: {e.Message}", "Erro no programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void AdicionarEditarVacinacao(TipoOperacao operacao)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    if (operacao == TipoOperacao.Adicionar)
                    {
                        command.CommandText = "INSERT INTO Vacinacao (AnimalId, VacinaId, DataVacina) VALUES (@AnimalId, @VacinaId, @DataVacina)";
                    }
                    else if (operacao == TipoOperacao.Editar)
                    {
                        command.CommandText = "UPDATE Vacinacao SET AnimalId = @AnimalId, VacinaId = @VacinaId, DataVacina = @DataVacina WHERE Id = @Id";
                        command.Parameters.AddWithValue("@Id", Id);
                    }
                    command.Parameters.AddWithValue("@AnimalId", AnimalId.Id);
                    command.Parameters.AddWithValue("@VacinaId", VacinaId.Id);
                    command.Parameters.AddWithValue("@DataVacina", DataVacina);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        if (operacao == TipoOperacao.Editar)
                        {
                            MessageBox.Show("Os dados de vacinação foram modificados", "Editar Vacinação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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

        public static DataTable ListarVacinacoes()
        {
            DataTable data = new DataTable();
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT Vacinacao.Id, Vacinas.Imunologia, Vacinacao.DataVacina, Animal.Nome as NomeAnimal, Clientes.Nome as NomeCliente, Animal.Especie, Animal.Raca, Animal.Sexo FROM Vacinacao INNER JOIN Animal ON Vacinacao.AnimalId = Animal.Id INNER JOIN Clientes ON Animal.ClienteId = Clientes.Id INNER JOIN Vacinas ON Vacinacao.VacinaId = Vacinas.Id";
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
