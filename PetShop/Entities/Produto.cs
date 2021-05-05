using PetShop.Entities.Enums;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace PetShop.Entities
{
    class Produto
    {
        private static SqlCeConnection Connection;
        public int ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public string CodigoBarras { get; set; }
        public string TipoUnidade { get; set; }
        public int Quantidade { get; set; }
        public string Referencia { get; set; }
        public string Localizacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public float? EstoqueMinimo { get; set; }
        public float EstoqueAtual { get; set; }
        public DateTime DataValidade { get; set; }
        public decimal ValorCusto { get; set; }
        public decimal ValorProduto { get; set; }
        public string Observacoes { get; set; }

        public Produto(string nomeProduto, string codigoBarras, string tipoUnidade, int quantidade, string referencia, string localizacao, DateTime dataCadastro, string marca, string categoria, float estoqueMinimo, float estoqueAtual, DateTime dataValidade, decimal valorCusto, decimal valorProduto, string observacoes)
        {
            NomeProduto = nomeProduto;
            CodigoBarras = codigoBarras;
            TipoUnidade = tipoUnidade;
            Quantidade = quantidade;
            Referencia = referencia;
            Localizacao = localizacao;
            DataCadastro = dataCadastro;
            Marca = marca;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            EstoqueAtual = estoqueAtual;
            DataValidade = dataValidade;
            ValorCusto = valorCusto;
            ValorProduto = valorProduto;
            Observacoes = observacoes;
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
                    using (SqlCeDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProdutoId = (int)reader["Id"];
                            NomeProduto = reader["Nome"].ToString();
                            CodigoBarras = reader["CodigoBarras"].ToString();
                            TipoUnidade = reader["TipoUnidade"].ToString();
                            Quantidade = (int)reader["Quantidade"];
                            Referencia = reader["Referencia"].ToString();
                            Localizacao = reader["Localizacao"].ToString();
                            DataCadastro = (DateTime)reader["DataCadastro"];
                            Marca = reader["Marca"].ToString();
                            Categoria = reader["Categoria"].ToString();
                            EstoqueMinimo = (float)reader.GetDouble(reader.GetOrdinal("EstoqueMinimo"));
                            EstoqueAtual = (float)reader.GetDouble(reader.GetOrdinal("EstoqueAtual"));
                            DataValidade = (DateTime)reader["DataValidade"];
                            ValorCusto = (decimal)reader["ValorCusto"];
                            ValorProduto = (decimal)reader["ValorProduto"];
                            Observacoes = reader["Observacoes"].ToString();
                        }
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro no banco de dados: {e.Message}", "Falha nos dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception x)
            {
                MessageBox.Show($"Falha na aplicação: {x.Message}", "Erro no programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        command.CommandText = "INSERT INTO Produtos (Nome, CodigoBarras, TipoUnidade, Quantidade, Referencia, Localizacao, DataCadastro, Marca, Categoria, EstoqueMinimo, EstoqueAtual, DataValidade, ValorCusto, ValorProduto, Observacoes) VALUES (@Nome, @CodigoBarras, @TipoUnidade, @quantidade, @Referencia, @Localizacao, @DataCadastro, @Marca, @Categoria, @EstoqueMinimo, @EstoqueAtual, @DataValidade, @ValorCusto, @ValorProduto, @Observacoes)";
                    }
                    else if (operacao == TipoOperacao.Editar)
                    {
                        command.CommandText = "UPDATE Produtos SET Nome = @Nome, CodigoBarras = @CodigoBarras, TipoUnidade = @TipoUnidade, Quantidade = @Quantidade, Referencia = @Referencia, Localizacao = @Localizacao, DataCadastro = @DataCadastro, Marca = @Marca, Categoria = @Categoria, EstoqueMinimo = @EstoqueMinimo, EstoqueAtual = @EstoqueAtual, DataValidade = @DataValidade, ValorCusto = @ValorCusto, ValorProduto = @ValorProduto, Observacoes = @Observacoes WHERE Id = @Id";
                        command.Parameters.AddWithValue("@Id", ProdutoId);
                    }
                    command.Parameters.AddWithValue("@Nome", NomeProduto);
                    command.Parameters.AddWithValue("@CodigoBarras", CodigoBarras);
                    command.Parameters.AddWithValue("@TipoUnidade", TipoUnidade);
                    command.Parameters.AddWithValue("@Quantidade", Quantidade);
                    command.Parameters.AddWithValue("@Referencia", Referencia);
                    command.Parameters.AddWithValue("@Localizacao", Localizacao);
                    command.Parameters.AddWithValue("@DataCadastro", DataCadastro);
                    command.Parameters.AddWithValue("@Marca", Marca);
                    command.Parameters.AddWithValue("@Categoria", Categoria);
                    command.Parameters.AddWithValue("EstoqueMinimo", EstoqueMinimo);
                    command.Parameters.AddWithValue("@EstoqueAtual", EstoqueAtual);
                    command.Parameters.AddWithValue("@DataValidade", DataValidade);
                    command.Parameters.AddWithValue("@ValorCusto", ValorCusto);
                    command.Parameters.AddWithValue("@ValorProduto", ValorProduto);
                    command.Parameters.AddWithValue("@Observacoes", Observacoes);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("O Produto foi salvo", "Salvar Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação: {e.Message}", "Erro no aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable ListarProdutos()
        {
            DataTable data = new DataTable();
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT * FROM Produtos";
                    command.ExecuteNonQuery();
                    SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command);
                    dataAdapter.Fill(data);
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro no banco de dados: {e.Message}", "Erro ao exibir dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação: {e.Message}", "Erro no aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação: {e.Message}", "Erro no aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação: {e.Message}", "Erro no aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação: {e.Message}", "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
