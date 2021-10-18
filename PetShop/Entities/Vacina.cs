using PetShop.Entities.Enums;
using PetShop.Entities.Exceptions;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace PetShop.Entities
{
    public class Vacina
    {
        private static SqlCeConnection Connection;
        public int? Id { get; set; }
        public string Imunologia { get; set; }
        public int Doses { get; set; }
        public int ConteudoML { get; set; }
        public string Lote { get; set; }
        public string Fabricante { get; set; }
        public DateTime DataValidade { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorMercado { get; set; }
        public decimal ValorProduto { get; set; }
        public DateTime DataModificacao { get; set; }

        public Vacina(string imunologia, int doses, int conteudoML, string lote, string fabricante, DateTime dataValidade, int quantidade, decimal valorMercado, decimal valorProduto, DateTime dataModificacao)
        {
            Imunologia = imunologia;
            Doses = doses;
            ConteudoML = conteudoML;
            Lote = lote;
            Fabricante = fabricante;
            DataValidade = dataValidade;
            Quantidade = quantidade;
            ValorMercado = valorMercado;
            ValorProduto = valorProduto;
            DataModificacao = dataModificacao;
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
                    using (SqlCeDataReader reader = command.ExecuteResultSet(ResultSetOptions.Scrollable))
                    {
                        if (reader.HasRows)
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
                                Quantidade = (int)reader["Quantidade"];
                                ValorMercado = (decimal)reader["ValorMercado"];
                                ValorProduto = (decimal)reader["ValorProduto"];
                                DataModificacao = (DateTime)reader["DataModificacao"];
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
                MessageBox.Show($"Erro no banco de dados ao buscar por Vacina: {e.Message}", "Falha nos dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
            catch (SqlCeResultException e)
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
                        command.CommandText = "INSERT INTO Vacinas (Doses, ConteudoML, Imunologia, Lote, Fabricante, DataValidade, Quantidade, ValorMercado, ValorProduto, DataModificacao) VALUES (@Doses, @ConteudoML, @Imunologia, @Lote, @Fabricante, @DataValidade, @Quantidade, @ValorMercado, @ValorProduto, @DataModificacao)";
                    }
                    else if (operacao == TipoOperacao.Editar)
                    {
                        command.CommandText = "UPDATE Vacinas SET Doses = @Doses, ConteudoML = @ConteudoML, Imunologia = @Imunologia, Lote = @Lote, Fabricante = @Fabricante, DataValidade = @DataValidade, Quantidade = @Quantidade, ValorMercado = @ValorMercado, ValorProduto = @ValorProduto, DataModificacao = @DataModificacao WHERE Id = @Id";
                        command.Parameters.AddWithValue("@Id", Id);
                    }
                    command.Parameters.AddWithValue("@Doses", Doses);
                    command.Parameters.AddWithValue("@ConteudoML", ConteudoML);
                    command.Parameters.AddWithValue("@Imunologia", Imunologia);
                    command.Parameters.AddWithValue("@Lote", Lote);
                    command.Parameters.AddWithValue("@Fabricante", Fabricante);
                    command.Parameters.AddWithValue("@DataValidade", DataValidade);
                    command.Parameters.AddWithValue("@Quantidade", Quantidade);
                    command.Parameters.AddWithValue("@ValorMercado", ValorMercado);
                    command.Parameters.AddWithValue("@ValorProduto", ValorProduto);
                    command.Parameters.AddWithValue("@DataModificacao", DataModificacao);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("A Vacina foi salva", "Salvar Vacina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (operacao == TipoOperacao.Adicionar)
                    {
                        command.CommandText = "SELECT @@IDENTITY";
                        Id = Convert.ToInt32(command.ExecuteScalar());
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

        public void InserirAbastecimentoVacina(int quantidade)
        {
            if (Id != null)
            {
                try
                {
                    using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                    {
                        Connection.Open();
                        SqlCeCommand command = Connection.CreateCommand();
                        command.CommandText = "INSERT INTO Vacinas_Abastecimento (VacinaId, Quantidade) VALUES (@VacinaId, @Quantidade)";
                        command.Parameters.AddWithValue("@VacinaId", Id);
                        command.Parameters.AddWithValue("@Quantidade", quantidade);
                        if (command.ExecuteNonQuery() > 0 == false)
                        {
                            throw new SqlCeQueryException();
                        }
                    }
                }
                catch (SqlCeException e)
                {
                    MessageBox.Show($"Erro no banco de dados: {e.Message}", "Erro ao salvar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ocorreu um erro na aplicação: {e.Message}", "Erro no aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                }
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
                MessageBox.Show($"Erro no banco de dados ao remover vacina: {e.Message}", "Erro ao remover vacina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação ao remover a vacina: {e.Message}", "Erro no aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ExcluirVacina(DateTime data)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "DELETE FROM Vacinas WHERE DataModificacao < @Data";
                    command.Parameters.AddWithValue("@Data", data);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        FormNotificacao formNotificacao = new FormNotificacao();
                        formNotificacao.ShowAlert("Os registros de Vacinas foram limpos", TipoNotificacao.Confirmar, "Limpar tabela de Vacinas");
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro no banco de dados ao remover vacina: {e.Message}", "Erro ao remover vacina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação ao remover a vacina: {e.Message}", "Erro no aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ExcluirVacina()
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "DELETE FROM Vacinas";
                    if (command.ExecuteNonQuery() > 0)
                    {
                        FormNotificacao formNotificacao = new FormNotificacao();
                        formNotificacao.ShowAlert("Os registros de Vacinas foram limpos", TipoNotificacao.Confirmar, "Limpar tabela de Vacinas");
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro no banco de dados ao remover vacina: {e.Message}", "Erro ao remover vacina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação ao remover a vacina: {e.Message}", "Erro no aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable ListarVacinas(bool apenasEmEstoque = false)
        {
            DataTable data = new DataTable();
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    if (apenasEmEstoque)
                    {
                        command.CommandText = "SELECT Id, Imunologia, ConteudoML, Doses, DataModificacao, Lote, Fabricante, DataValidade, Quantidade, ValorMercado, ValorProduto FROM Vacinas WHERE Quantidade > 0";
                    }
                    else
                    {
                        command.CommandText = "SELECT Id, Imunologia, ConteudoML, Doses, DataModificacao, Lote, Fabricante, DataValidade, Quantidade, ValorMercado, ValorProduto FROM Vacinas";

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

        public static DataTable RelatorioEntradaSaidaVacinas(DateTime dataInicial, DateTime dataFinal)
        {
            DataTable data = new DataTable();
            using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
            {
                try
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT Vacinas.Id, Vacinas.DataModificacao AS DataMovimentacao, CASE WHEN Vacinas_Abastecimento.Quantidade > 0 THEN 'Entrada' ELSE 'Saída' END AS TipoMovimentacao, Vacinas_Abastecimento.Quantidade AS Quantidade, 'Abastecimento' AS TipoOperacao, Vacinas.Imunologia, Vacinas.Doses, Vacinas.ConteudoML, Vacinas.ValorProduto FROM Vacinas_Abastecimento INNER JOIN Vacinas ON Vacinas_Abastecimento.VacinaId = Vacinas.Id WHERE Vacinas.DataModificacao BETWEEN @DataInicial AND @DataFinal UNION SELECT Vacinas.Id, Vendas.DataVenda AS DataMovimentacao, 'Saída' AS TipoMovimentacao, Vendas_Vacinas.Quantidade * -1 AS Quantidade, 'Venda' AS TipoOperacao, Vacinas.Imunologia, Vacinas.Doses, Vacinas.ConteudoML, Vacinas.ValorProduto FROM Vendas_Vacinas INNER JOIN Vacinas ON (Vendas_Vacinas.VacinasId = Vacinas.Id) INNER JOIN Vendas ON (Vendas_Vacinas.VendasId = Vendas.Id) WHERE Vendas.DataVenda BETWEEN @DataInicial AND @DataFinal";
                    command.Parameters.AddWithValue("@DataInicial", dataInicial);
                    command.Parameters.AddWithValue("@DataFinal", dataFinal);
                    command.ExecuteNonQuery();
                    SqlCeDataAdapter sqlCeDataAdapter = new SqlCeDataAdapter(command);
                    sqlCeDataAdapter.Fill(data);
                }
                catch (SqlCeException e)
                {
                    MessageBox.Show($"Erro no banco de dados: {e.Message}", "Erro ao obter lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ocorreu um erro na aplicação: {e.Message}", "Erro no aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                }
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
