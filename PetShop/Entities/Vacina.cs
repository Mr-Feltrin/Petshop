using PetShop.Entities.Enums;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace PetShop.Entities
{
    class Vacina
    {
        private static SqlCeConnection Connection;
        public int Id { get; set; }
        public string Imunologia { get; set; }
        public int Doses { get; set; }
        public int ConteudoML { get; set; }
        public string Lote { get; set; }
        public string Fabricante { get; set; }
        public DateTime DataValidade { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorMercado { get; set; }
        public decimal ValorProduto { get; set; }

        public Vacina(string imunologia, int doses, int conteudoML, string lote, string fabricante, DateTime dataValidade, DateTime dataCadastro, int quantidade, decimal valorMercado, decimal valorProduto)
        {
            Imunologia = imunologia;
            Doses = doses;
            ConteudoML = conteudoML;
            Lote = lote;
            Fabricante = fabricante;
            DataValidade = dataValidade;
            DataCadastro = dataCadastro;
            Quantidade = quantidade;
            ValorMercado = valorMercado;
            ValorProduto = valorProduto;
        }

        public Vacina(int id)
        {
            BuscarVacina(id);
        }

        private void BuscarVacina(int id)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT * FROM Vacinas WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlCeDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Id = (int)reader["Id"];
                            Imunologia = (string)reader["Imunologia"];
                            Doses = (int)reader["Doses"];
                            ConteudoML = (int)reader["ConteudoML"];
                            Lote = (string)reader["Lote"];
                            Fabricante = (string)reader["Fabricante"];
                            DataValidade = (DateTime)reader["DataValidade"];
                            DataCadastro = (DateTime)reader["DataCadastro"];
                            Quantidade = (int)reader["Quantidade"];
                            ValorMercado = (decimal)reader["ValorMercado"];
                            ValorProduto = (decimal)reader["ValorProduto"];
                        }
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro no banco de dados ao buscar por Vacina: {e.Message}", "Falha nos dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Falha na aplicação ao buscar por Vacina: {e.Message}", "Erro no programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }

        public void AdicionarEditarVacina(TipoOperacao operacao)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    if (operacao == TipoOperacao.Adicionar)
                    {
                        command.CommandText = "INSERT INTO Vacinas (Doses, ConteudoML, Imunologia, Lote, Fabricante, DataValidade, DataCadastro, Quantidade, ValorMercado, ValorProduto) VALUES (@Doses, @ConteudoML, @Imunologia, @Lote, @Fabricante, @DataValidade, @DataCadastro, @Quantidade, @ValorMercado, @ValorProduto)";
                    }
                    else if (operacao == TipoOperacao.Editar)
                    {
                        command.CommandText = "UPDATE Vacinas SET Doses = @Doses, ConteudoML = @ConteudoML, Imunologia = @Imunologia, Lote = @Lote, Fabricante = @Fabricante, DataValidade = @DataValidade, DataCadastro = @DataCadastro, Quantidade = @Quantidade, ValorMercado = @ValorMercado, ValorProduto = @ValorProduto WHERE Id = @Id";
                        command.Parameters.AddWithValue("@Id", Id);
                    }
                    command.Parameters.AddWithValue("@Doses", Doses);
                    command.Parameters.AddWithValue("@ConteudoML", ConteudoML);
                    command.Parameters.AddWithValue("@Imunologia", Imunologia);
                    command.Parameters.AddWithValue("@Lote", Lote);
                    command.Parameters.AddWithValue("@Fabricante", Fabricante);
                    command.Parameters.AddWithValue("@DataValidade", DataValidade);
                    command.Parameters.AddWithValue("@DataCadastro", DataCadastro);
                    command.Parameters.AddWithValue("@Quantidade", Quantidade);
                    command.Parameters.AddWithValue("@ValorMercado", ValorMercado);
                    command.Parameters.AddWithValue("@ValorProduto", ValorProduto);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("A Vacina foi salva", "Salvar Vacina", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static void ExcluirVacina(int id)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "DELETE FROM Vacinas WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("A vacina foi removida", "Remover Vacina", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public static DataTable ListarVacinas()
        {
            DataTable data = new DataTable();
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT Id, Imunologia, ConteudoML, Doses, DataCadastro, Lote, Fabricante, DataValidade, Quantidade, ValorMercado, ValorProduto FROM Vacinas";
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

        public static DataTable ListarImunologia()
        {
            DataTable data = new DataTable();
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT DISTINCT Imunologia FROM Vacinas";
                    command.ExecuteNonQuery();
                    SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command);
                    dataAdapter.Fill(data);
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
            return data;
        }
    }
}
