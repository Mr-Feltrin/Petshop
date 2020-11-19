using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using PetShop.Entities.Enums;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace PetShop.Entities
{
    public class Animal
    {
        private static SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString);
        public int AnimalId { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int ClienteId { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public string Identificacao { get; set; }
        public string Fobias { get; set; }
        public string DisponivelTosa { get; set; }
        public string PossuiPedigree { get; set; }
        public string Agressivo { get; set; }
        public string Hiperativo { get; set; }
        public string AntiSocial { get; set; }
        public string Obsessivo { get; set; }
        public string ObservacaoComportamental { get; set; }
        public string ObservacaoRotina { get; set; }
        public DateTime DataRegistro { get; set; }
        public Image Fotografia1 { get; set; }
        public Image Fotografia2 { get; set; }
        public Image Fotografia3 { get; set; }

        public Animal(string nome, string sexo, int clienteId, string especie, string raca, string identificacao, string fobias, string disponivelTosa, string possuiPedigree, string agressivo, string hiperativo, string antiSocial, string obsessivo, string observacaoComportamental, string observacaoRotina, DateTime dataRegistro, Image fotografia1, Image fotografia2, Image fotografia3)
        {
            Nome = nome;
            Sexo = sexo;
            ClienteId = clienteId;
            Especie = especie;
            Raca = raca;
            Identificacao = identificacao;
            Fobias = fobias;
            DisponivelTosa = disponivelTosa;
            PossuiPedigree = possuiPedigree;
            Agressivo = agressivo;
            Hiperativo = hiperativo;
            AntiSocial = antiSocial;
            Obsessivo = obsessivo;
            ObservacaoComportamental = observacaoComportamental;
            ObservacaoRotina = observacaoRotina;
            DataRegistro = dataRegistro;
            Fotografia1 = fotografia1;
            Fotografia2 = fotografia2;
            Fotografia3 = fotografia3;
        }

        public Animal(int IdAnimal)
        {
            BuscarAnimal(IdAnimal);
        }

        public void AdicionarEditarAnimal(TipoOperacao operacao)
        {
            try
            {
                connection.Open();
                SqlCeCommand command = connection.CreateCommand();
                if (operacao == TipoOperacao.Adicionar)
                {
                    command.CommandText = "INSERT INTO Animal (Nome, Sexo, ClienteId, Especie, Raca, Identificacao, Fobias, Disponivel_tosa, Possui_pedigree, Agressivo, Hiperativo, Anti_social, Obsessivo, Observacao_comportamental, Observacao_rotina, Data_registro) VALUES (@Nome, @Sexo, @ClienteId, @Especie, @Raca, @Identificacao, @Fobias, @Disponivel_tosa, @Possui_pedigree, @Agressivo, @Hiperativo, @Anti_social, @Obsessivo, @Observacao_comportamental, @Observacao_rotina, @Data_registro)";
                    command.Parameters.AddWithValue("@Data_registro", DataRegistro);
                }
                else
                {
                    command.CommandText = "UPDATE Animal SET Nome = @Nome, Sexo = @Sexo, ClienteId = @ClienteId, Especie = @Especie, Raca = @Raca, Identificacao = @Identificacao, Fobias = @Fobias, Disponivel_tosa = @Disponivel_tosa, Possui_pedigree = @Possui_pedigree, Agressivo = @Agressivo, Hiperativo = @Hiperativo, Anti_social = @Anti_social, Obsessivo = @Obsessivo, Observacao_comportamental = @Observacao_comportamental, Observacao_rotina = @Observacao_rotina WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", AnimalId);
                }
                command.Parameters.AddWithValue("@Nome", Nome);
                command.Parameters.AddWithValue("@Sexo", Sexo);
                command.Parameters.AddWithValue("@ClienteId", ClienteId);
                command.Parameters.AddWithValue("@Especie", Especie);
                command.Parameters.AddWithValue("@Raca", Raca);
                command.Parameters.AddWithValue("@Identificacao", Identificacao);
                command.Parameters.AddWithValue("@Fobias", Fobias);
                command.Parameters.AddWithValue("@Disponivel_tosa", DisponivelTosa);
                command.Parameters.AddWithValue("@Possui_pedigree", PossuiPedigree);
                command.Parameters.AddWithValue("@Agressivo", Agressivo);
                command.Parameters.AddWithValue("@Hiperativo", Hiperativo);
                command.Parameters.AddWithValue("@Anti_social", AntiSocial);
                command.Parameters.AddWithValue("@Obsessivo", Obsessivo);
                command.Parameters.AddWithValue("@Observacao_comportamental", ObservacaoComportamental);
                command.Parameters.AddWithValue("Observacao_rotina", ObservacaoRotina);

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Os dados do Animal foram salvos.", "Cadastro de Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar as informações do Animal: " + ex.Message, "Falha no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            finally
            {
                connection.Close();
            }
        }

        public static DataTable ListarAnimais()
        {
            DataTable dta = new DataTable();
            try
            {
                connection.Open();
                SqlCeCommand comando = connection.CreateCommand();              
                comando.CommandText = "SELECT Animal.Id, Animal.Nome, Animal.Sexo, Clientes.Nome as Dono, Animal.Especie, Animal.Raca, Animal.Identificacao, Animal.Fobias, Animal.Agressivo, Animal.Hiperativo, Animal.Observacao_rotina, Animal.Data_registro FROM Animal INNER JOIN Clientes ON Animal.ClienteId = Clientes.Id";
                comando.ExecuteNonQuery();
                SqlCeDataAdapter dataadp = new SqlCeDataAdapter(comando);
                dataadp.Fill(dta);
                dta.Columns["Especie"].ColumnName = "Espécie";
                dta.Columns["Raca"].ColumnName = "Raça";
                dta.Columns["Identificacao"].ColumnName = "Identificação";
                dta.Columns["Observacao_rotina"].ColumnName = "Observação de Rotina";
                dta.Columns["Data_registro"].ColumnName = "Data de Registro";
                
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show("Erro ao exibir os dados na lista: " + ex.Message, "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return dta;
        }

        public static DataTable ListarRacas()
        {
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                SqlCeCommand comando = connection.CreateCommand();
                comando.CommandText = "SELECT Raca as Raça from Animal";
                comando.ExecuteNonQuery();
                SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(comando);
                dataAdapter.Fill(table);
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show("Erro ao exibir os dados na lista: " + ex.Message, "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return table;         
        }

        public static DataTable ListarEspecies()
        {
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                SqlCeCommand comando = connection.CreateCommand();
                comando.CommandText = "SELECT Especie as Espécie from Animal";
                comando.ExecuteNonQuery();
                SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(comando);
                dataAdapter.Fill(table);
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show("Erro ao exibir os dados na lista: " + ex.Message, "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return table;
        }

        private void BuscarAnimal(int id)
        {
            try
            {
                connection.Open();
                SqlCeCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Animal WHERE Id = @Id";
                command.Parameters.AddWithValue("@Id", id);
                using (SqlCeDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AnimalId = (int)reader["Id"];
                        Nome = reader["Nome"].ToString();
                        Sexo = reader["Sexo"].ToString();
                        ClienteId = (int)reader["ClienteId"];
                        Especie = reader["Especie"].ToString();
                        Raca = reader["Raca"].ToString();
                        Identificacao = reader["Identificacao"].ToString();
                        Fobias = reader["Fobias"].ToString();
                        DisponivelTosa = reader["Disponivel_tosa"].ToString();
                        PossuiPedigree = reader["Possui_pedigree"].ToString();
                        Agressivo = reader["Agressivo"].ToString();
                        Hiperativo = reader["Hiperativo"].ToString();
                        AntiSocial = reader["Anti_social"].ToString();
                        Obsessivo = reader["Obsessivo"].ToString();
                        ObservacaoComportamental = reader["Observacao_comportamental"].ToString();
                        ObservacaoRotina = reader["Observacao_rotina"].ToString();
                        DataRegistro = DateTime.Parse(reader["Data_registro"].ToString());
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show("Falha ao localizar animal: " + e.Message, "Não foi possível localizar o animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ExcluirAnimal(int id)
        {
            try
            {
                connection.Open();
                SqlCeCommand comando = connection.CreateCommand();
                comando.CommandText = "DELETE FROM Animal WHERE Id = @Id";
                comando.Parameters.AddWithValue("@Id", id);
                comando.ExecuteNonQuery();
                MessageBox.Show("Animal removido", "Remover Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlCeException e)
            {
                MessageBox.Show("Erro ao remover Animal: " + e.Message, "Remover Animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

