using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using PetShop.Entities.Exceptions;

namespace PetShop.Entities
{
    public class VendaVacina
    {
        private static SqlCeConnection Connection;
        public int VendaId { get; set; }
        public int VacinaId { get; set; }
        public int Quantidade { get; set; }

        public VendaVacina(int vendaId, int vacinaId, int quantidade)
        {
            VendaId = vendaId;
            VacinaId = vacinaId;
            Quantidade = quantidade;
        }

        public void SalvarVendaVacina()
        {
            using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
            {
                try
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "INSERT INTO Vendas_Vacinas (VendasId, VacinasId, Quantidade) VALUES (@VendasId, @VacinasId, @Quantidade)";
                    command.Parameters.AddWithValue("@VendasId", VendaId);
                    command.Parameters.AddWithValue("@VacinasId", VacinaId);
                    command.Parameters.AddWithValue("@Quantidade", Quantidade);
                    if (!(command.ExecuteNonQuery() > 0))
                    {
                        throw new SqlCeQueryException();
                    }
                    command.Parameters.Clear();
                    command.CommandText = "UPDATE Vacinas SET Quantidade = Quantidade - @Quantidade WHERE Id = @VacinaId";
                    command.Parameters.AddWithValue("@Quantidade", Quantidade);
                    command.Parameters.AddWithValue("@VacinaId", VacinaId);
                    if (!(command.ExecuteNonQuery() > 0))
                    {
                        throw new SqlCeQueryException();
                    }
                }
                catch (SqlCeException e)
                {
                    MessageBox.Show($"Erro no banco de dados ao salvar venda de vacina: {e.Message}", "Erro ao salvar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                    throw e;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Erro na aplicação ao salvar venda de vacinas: {e.Message}", "Erro ao salvar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                    throw e;
                }
            }
        }

        public static DataTable BuscarVacinasVenda(int vendaId)
        {
            DataTable produtosVenda = new DataTable();
            using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
            {
                try
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT * FROM Vendas_Vacinas WHERE VendasId = @VendasId";
                    command.Parameters.AddWithValue("@VendasId", vendaId);
                    command.ExecuteNonQuery();
                    using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(command))
                    {
                        adapter.Fill(produtosVenda);
                    }
                }
                catch (SqlCeException e)
                {
                    MessageBox.Show($"Erro no banco de dados ao buscar por venda de vacinas: {e.Message}", "Erro ao salvar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Erro na aplicação ao buscar por venda de vacinas: {e.Message}", "Erro ao salvar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                }
            }
            return produtosVenda;
        }
    }
}
