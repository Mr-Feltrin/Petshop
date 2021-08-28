using PetShop.Entities.Exceptions;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace PetShop.Entities
{
    public class VendaServico
    {
        private static SqlCeConnection Connection;
        public int VendaId { get; set; }
        public int ServicoId { get; set; }
        public int Quantidade { get; set; }

        public VendaServico(int vendaId, int servicoId, int quantidade)
        {
            VendaId = vendaId;
            ServicoId = servicoId;
            Quantidade = quantidade;
        }

        public void SalvarVendaServico()
        {
            using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
            {
                try
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "INSERT INTO Vendas_Servicos (VendasId, ServicoId, Quantidade) VALUES (@VendasId, @ServicoId, @Quantidade)";
                    command.Parameters.AddWithValue("@VendasId", VendaId);
                    command.Parameters.AddWithValue("@ServicoId", ServicoId);
                    command.Parameters.AddWithValue("@Quantidade", Quantidade);
                    command.ExecuteNonQuery();
                }
                catch (SqlCeException e)
                {
                    MessageBox.Show($"Erro no banco de dados: {e.Message}", "Erro ao salvar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                    throw e;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Erro na aplicação ao salvar dados: {e.Message}", "Erro ao salvar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                    throw e;
                }
            }
        }

        public static DataTable BuscarServicosVenda(int vendaId)
        {
            DataTable servicosVenda = new DataTable();
            using (Connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
            {
                try
                {
                    Connection.Open();
                    SqlCeCommand command = Connection.CreateCommand();
                    command.CommandText = "SELECT * FROM Vendas_Servicos WHERE VendasId = @VendasId";
                    command.Parameters.AddWithValue("@VendasId", vendaId);
                    command.ExecuteNonQuery();
                    using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(command))
                    {
                        adapter.Fill(servicosVenda);
                    }
                }
                catch (SqlCeException e)
                {
                    MessageBox.Show($"Erro no banco de dados ao procurar serviços de venda: {e.Message}", "Erro ao buscar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Erro na aplicação ao buscar por serviços de venda: {e.Message}", "Erro ao buscar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(e);
                }
            }
            return servicosVenda;
        }
    }
}
