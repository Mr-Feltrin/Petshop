using PetShop.Entities.Enums;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using PetShop.Entities.Exceptions;

namespace PetShop.Entities
{
    public class Produto
    {
        private static SqlCeConnection Connection;
        public int? Id { get; set; }
        public string NomeProduto { get; set; }
        public string CodigoBarras { get; set; }
        public string TipoUnidade { get; set; }
        public int Quantidade { get; set; }
        public string Referencia { get; set; }
        public string Localizacao { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public int? EstoqueMinimo { get; set; }
        public int EstoqueAtual { get; set; }
        public DateTime DataValidade { get; set; }
        public decimal ValorCusto { get; set; }
        public decimal ValorProduto { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataAtualizacao { get; set; }

        public Produto(string nomeProduto, string codigoBarras, string tipoUnidade, int quantidade, string referencia, string localizacao, string marca, string categoria, int estoqueMinimo, int estoqueAtual, DateTime dataValidade, decimal valorCusto, decimal valorProduto, string observacoes, DateTime dataAtualizacao)
        {
            NomeProduto = nomeProduto;
            CodigoBarras = codigoBarras;
            TipoUnidade = tipoUnidade;
            Quantidade = quantidade;
            Referencia = referencia;
            Localizacao = localizacao;
            Marca = marca;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            EstoqueAtual = estoqueAtual;
            DataValidade = dataValidade;
            ValorCusto = valorCusto;
            ValorProduto = valorProduto;
            Observacoes = observacoes;
            DataAtualizacao = dataAtualizacao;
        }

        public Produto(int id)
        {
            BuscarProduto(id);
        }

        private void BuscarProduto(int id)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT * FROM Produtos WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlCeDataReader reader = command.ExecuteResultSet(ResultSetOptions.Scrollable))
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Id = (int)reader["Id"];
                                NomeProduto = reader["Nome"].ToString();
                                CodigoBarras = reader["CodigoBarras"].ToString();
                                TipoUnidade = reader["TipoUnidade"].ToString();
                                Quantidade = (int)reader["Quantidade"];
                                Referencia = reader["Referencia"].ToString();
                                Localizacao = reader["Localizacao"].ToString();
                                Marca = reader["Marca"].ToString();
                                Categoria = reader["Categoria"].ToString();
                                EstoqueMinimo = (int)reader["EstoqueMinimo"];
                                EstoqueAtual = (int)reader["EstoqueAtual"];
                                DataValidade = (DateTime)reader["DataValidade"];
                                ValorCusto = (decimal)reader["ValorCusto"];
                                ValorProduto = (decimal)reader["ValorProduto"];
                                Observacoes = reader["Observacoes"].ToString();
                                DataAtualizacao = (DateTime)reader["DataAtualizacao"];
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
                MessageBox.Show($"Erro no banco de dados ao buscar por Produto: {e.Message}", "Falha nos dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
                throw e;
            }
            catch (SqlCeResultException e)
            {
                MessageBox.Show($"Erro no banco de dados ao buscar por Produto: {e.Message}", "Falha nos dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
                throw e;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Falha na aplicação ao buscar por Produto: {e.Message}", "Erro no programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
                throw e;
            }
        }

        public void AdicionarEditarProduto(TipoOperacao operacao)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    if (operacao == TipoOperacao.Adicionar)
                    {
                        command.CommandText = "INSERT INTO Produtos (Nome, CodigoBarras, TipoUnidade, Quantidade, Referencia, Localizacao, Marca, Categoria, EstoqueMinimo, EstoqueAtual, DataValidade, ValorCusto, ValorProduto, Observacoes, DataAtualizacao) VALUES (@Nome, @CodigoBarras, @TipoUnidade, @quantidade, @Referencia, @Localizacao, @Marca, @Categoria, @EstoqueMinimo, @EstoqueAtual, @DataValidade, @ValorCusto, @ValorProduto, @Observacoes, @DataAtualizacao)";
                    }
                    else if (operacao == TipoOperacao.Editar)
                    {
                        command.CommandText = "UPDATE Produtos SET Nome = @Nome, CodigoBarras = @CodigoBarras, TipoUnidade = @TipoUnidade, Quantidade = @Quantidade, Referencia = @Referencia, Localizacao = @Localizacao, Marca = @Marca, Categoria = @Categoria, EstoqueMinimo = @EstoqueMinimo, EstoqueAtual = @EstoqueAtual, DataValidade = @DataValidade, ValorCusto = @ValorCusto, ValorProduto = @ValorProduto, Observacoes = @Observacoes, DataAtualizacao = @DataAtualizacao WHERE Id = @Id";
                        command.Parameters.AddWithValue("@Id", Id);
                    }
                    command.Parameters.AddWithValue("@Nome", NomeProduto);
                    command.Parameters.AddWithValue("@CodigoBarras", CodigoBarras);
                    command.Parameters.AddWithValue("@TipoUnidade", TipoUnidade);
                    command.Parameters.AddWithValue("@Quantidade", Quantidade);
                    command.Parameters.AddWithValue("@Referencia", Referencia);
                    command.Parameters.AddWithValue("@Localizacao", Localizacao);
                    command.Parameters.AddWithValue("@Marca", Marca);
                    command.Parameters.AddWithValue("@Categoria", Categoria);
                    command.Parameters.AddWithValue("EstoqueMinimo", EstoqueMinimo);
                    command.Parameters.AddWithValue("@EstoqueAtual", EstoqueAtual);
                    command.Parameters.AddWithValue("@DataValidade", DataValidade);
                    command.Parameters.AddWithValue("@ValorCusto", ValorCusto);
                    command.Parameters.AddWithValue("@ValorProduto", ValorProduto);
                    command.Parameters.AddWithValue("@Observacoes", Observacoes);
                    command.Parameters.AddWithValue("@DataAtualizacao", DataAtualizacao);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("O Produto foi salvo", "Salvar Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ErrorLogger.CreateErrorLog(e);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação: {e.Message}", "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
        }

        public static void RemoverProduto(int id)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "DELETE FROM Produtos WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("O produto foi removido", "Remover produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void InserirAbastecimento(int quantidade)
        {
            if (Id != null)
            {
                try
                {
                    using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                    {
                        Connection.Open();
                        SqlCeCommand command = Connection.CreateCommand();
                        command.CommandText = "INSERT INTO Produtos_Abastecimento (ProdutoId, Quantidade) VALUES (@ProdutoId, @Quantidade)";
                        command.Parameters.AddWithValue("@ProdutoId", Id);
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

        public static DataTable ListarProdutos(bool apenasEmEstoque = false)
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
                        command.CommandText = "SELECT * FROM Produtos WHERE EstoqueAtual > 0";
                    }
                    else
                    {
                        command.CommandText = "SELECT * FROM Produtos";
                    }
                    command.ExecuteNonQuery();
                    SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command);
                    dataAdapter.Fill(data);
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro no banco de dados ao retornar lista de produtos: {e.Message}", "Erro ao exibir dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação ao retornar a lista de produtos: {e.Message}", "Erro no aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            return data;
        }

        public static DataTable ListarMarcas()
        {
            DataTable data = new DataTable();
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT DISTINCT Marca FROM Produtos";
                    command.ExecuteNonQuery();
                    SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command);
                    dataAdapter.Fill(data);
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
            return data;
        }

        public static DataTable ListarCategorias()
        {
            DataTable data = new DataTable();
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT DISTINCT Categoria FROM Produtos";
                    command.ExecuteNonQuery();
                    SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command);
                    dataAdapter.Fill(data);
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
            return data;
        }

        public static int? BuscarCodigoBarras(string codigoBarras)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT * FROM Produtos WHERE CodigoBarras = @CodigoBarras";
                    command.Parameters.AddWithValue("@CodigoBarras", codigoBarras);
                    object scalar = command.ExecuteScalar();
                    if (scalar != null && scalar.GetType() != typeof(DBNull))
                    {
                        return (int)command.ExecuteScalar();
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Ocorreu um erro no banco de dados: {e.Message}", "Erro no banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação: {e.Message}", "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
                return null;
            }
        }

        public static DataTable RelatorioEntradaSaidaProdutos(DateTime dataInicial, DateTime dataFinal)
        {
            DataTable data = new DataTable();
            using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
            {
                try
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT Produtos.Id, Produtos.DataAtualizacao AS DataMovimentacao, CASE WHEN Produtos_Abastecimento.Quantidade > 0 THEN 'Entrada' ELSE 'Saída' END AS TipoMovimentacao, Produtos_Abastecimento.Quantidade AS Quantidade,'Abastecimento' AS TipoOperacao, Produtos.Nome AS NomeProduto, CAST(Produtos.Quantidade AS NVARCHAR) + ' ' + Produtos.TipoUnidade as Volume, Produtos.Categoria, Produtos.ValorProduto FROM Produtos_Abastecimento INNER JOIN Produtos ON (Produtos_Abastecimento.ProdutoId = Produtos.Id) WHERE Produtos.DataAtualizacao BETWEEN @DataInicial AND @DataFinal UNION SELECT Produtos.Id, Vendas.DataVenda AS DataMovimentacao, 'Saída' AS TipoMovimentacao, Vendas_Produtos.Quantidade * -1 AS Quantidade, 'Venda' AS TipoOperacao, Produtos.Nome AS NomeProduto, CAST(Produtos.Quantidade AS NVARCHAR) + ' ' + Produtos.TipoUnidade as Volume, Produtos.Categoria, Produtos.ValorProduto FROM Vendas_Produtos INNER JOIN Produtos ON (Vendas_Produtos.ProdutosId = Produtos.Id) INNER JOIN Vendas ON (Vendas_Produtos.VendasId = Vendas.Id) WHERE Vendas.DataVenda BETWEEN @DataInicial AND @DataFinal";
                    command.Parameters.AddWithValue("@DataInicial", dataInicial.Date);
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
    }
}
