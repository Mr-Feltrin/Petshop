using PetShop.Entities.Enums;
using PetShop.Entities.Exceptions;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace PetShop.Entities
{
    public class Venda
    {
        private static SqlCeConnection Connection;
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public Cliente ClienteId { get; set; }
        public string Pagamento { get; set; }
        public decimal Desconto { get; set; }
        public string TipoCartao { get; set; }
        public decimal TotalVenda { get; set; }

        public Venda(DateTime dataVenda, Cliente clienteId, string pagamento, decimal desconto, string tipoCartao, decimal totalVenda)
        {
            DataVenda = dataVenda;
            ClienteId = clienteId;
            Pagamento = pagamento;
            Desconto = desconto;
            TipoCartao = tipoCartao;
            TotalVenda = totalVenda;
        }

        public Venda(int id)
        {
            BuscarVenda(id);
        }

        private void BuscarVenda(int id)
        {
            using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
            {
                try
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT * FROM Vendas WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlCeDataReader reader = command.ExecuteResultSet(ResultSetOptions.Scrollable))
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Id = (int)reader["Id"];
                                DataVenda = (DateTime)reader["DataVenda"];
                                if (!reader.IsDBNull(reader.GetOrdinal("ClienteId")))
                                {
                                    ClienteId = new Cliente((int)reader["ClienteId"]);
                                }
                                var type = reader["ClienteId"].GetType();
                                Pagamento = (string)reader["Pagamento"];
                                Desconto = (decimal)reader["Desconto"];
                                TipoCartao = (string)reader["TipoCartao"];
                                TotalVenda = (decimal)reader["TotalVenda"];
                            }
                        }
                        else
                        {
                            throw new SqlCeResultException();
                        }
                    }
                }
                catch (SqlCeResultException e)
                {
                    MessageBox.Show($"Erro no banco de dados ao buscar por Venda: {e.Message}", "Falha nos dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw e;
                }
                catch (SqlCeException e)
                {
                    MessageBox.Show($"Erro no banco de dados ao buscar por Venda: {e.Message}", "Falha nos dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw e;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Falha na aplicação ao buscar por Venda: {e.Message}", "Erro no programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw e;
                }
            }
        }

        public void AdicionarVenda()
        {
            using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
            {
                try
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "INSERT INTO Vendas (DataVenda, ClienteId, Pagamento, Desconto, TipoCartao, TotalVenda) VALUES (@DataVenda, @ClienteId, @Pagamento, @Desconto, @TipoCartao, @TotalVenda)";
                    command.Parameters.AddWithValue("@DataVenda", DataVenda);
                    if (ClienteId != null)
                    {
                        command.Parameters.AddWithValue("@ClienteId", ClienteId.Id);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ClienteId", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@Pagamento", Pagamento);
                    command.Parameters.AddWithValue("@Desconto", Desconto);
                    command.Parameters.AddWithValue("@TipoCartao", TipoCartao);
                    command.Parameters.AddWithValue("@TotalVenda", TotalVenda);
                    if (!(command.ExecuteNonQuery() > 0))
                    {
                        throw new SqlCeQueryException();
                    }
                    command.CommandText = "SELECT @@IDENTITY";
                    Id = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (SqlCeException e)
                {
                    MessageBox.Show($"Erro no banco de dados: {e.Message}", "Erro ao salvar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                    throw e;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Ocorreu um erro na aplicação: {e.Message}", "Erro na aplicação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                    throw e;
                }
            }
        }

        public static int? SelecionarProximoIdVenda()
        {
            int? ProximoId = null;
            using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
            {
                try
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT IDENT_CURRENT('Vendas') as Id";
                    ProximoId = (int)command.ExecuteScalar();
                }
                catch (SqlCeException e)
                {
                    MessageBox.Show($"Erro no banco de dados ao selecionar próximo número de venda: {e.Message}", "Erro ao retornar numero da venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Erro na aplicação ao selecionar próximo número de venda: {e.Message}", "Erro ao retornar numero da venda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                }
            }
            if (ProximoId != null)
            {
                return ProximoId + 1;
            }
            else
            {
                return null;
            }
        }

        public static DataTable ListarVendas(DateTime dataInicial, DateTime dataFinal)
        {
            DataTable data = new DataTable();
            using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
            {
                try
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT Vendas.Id, Vendas.DataVenda, Clientes.Nome as NomeCliente, COUNT(Vendas_Produtos.VendasId) + COUNT(Vendas_Servicos.VendasId) + COUNT(Vendas_Vacinas.VendasId) as NumeroItens, Vendas.Pagamento, Vendas.Desconto, Vendas.TipoCartao, Vendas.TotalVenda FROM Vendas LEFT JOIN Clientes ON (Vendas.ClienteId = Clientes.Id) LEFT JOIN Vendas_Produtos ON (Vendas.Id = Vendas_Produtos.VendasId) LEFT JOIN Vendas_Servicos ON (Vendas.Id = Vendas_Servicos.VendasId) LEFT JOIN Vendas_Vacinas ON (Vendas.Id = Vendas_Vacinas.VendasId) WHERE Vendas.DataVenda BETWEEN @DataInicial AND @DataFinal GROUP BY Vendas.Id, Vendas.DataVenda, Clientes.Nome, Vendas.Pagamento, Vendas.Desconto, Vendas.TipoCartao, Vendas.TotalVenda";
                    command.Parameters.AddWithValue("@DataInicial", dataInicial.Date);
                    command.Parameters.AddWithValue("@DataFinal", dataFinal.Date);
                    command.ExecuteNonQuery();
                    SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command);
                    dataAdapter.Fill(data);
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

        public static void RemoverVendas()
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "DELETE FROM Vendas";
                    if (command.ExecuteNonQuery() > 0)
                    {
                        FormNotificacao formNotificacao = new FormNotificacao();
                        formNotificacao.ShowAlert("Os registros de Vendas foram limpos", TipoNotificacao.Confirmar, "Limpar tabela de Vendas");
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro no banco de dados ao limpar tabela de vendas: {e.Message}", "Erro ao limpar vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação ao limpar tabela de vendas: {e.Message}", "Erro no aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void RemoverVendas(DateTime data)
        {
            try
            {
                using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "DELETE FROM Vendas WHERE DataVenda < @Data";
                    command.Parameters.AddWithValue("@Data", data);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        FormNotificacao formNotificacao = new FormNotificacao();
                        formNotificacao.ShowAlert("Os registros de Vendas foram limpos", TipoNotificacao.Confirmar, "Limpar tabela de Vendas");
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro no banco de dados ao limpar tabela de vendas: {e.Message}", "Erro ao limpar vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ocorreu um erro na aplicação ao limpar tabela de vendas: {e.Message}", "Erro no aplicativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
