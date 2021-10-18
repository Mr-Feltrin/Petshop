using PetShop.Entities.Enums;
using PetShop.Entities.Exceptions;
using PetShop.ToolBox;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Windows.Forms;

namespace PetShop.Entities
{
    public class Animal
    {
        private static SqlCeConnection connection;
        public int Id { get; set; }
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
        public decimal Peso { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Situacao { get; set; }

        public Animal(string nome, string sexo, int clienteId, string especie, string raca, string identificacao, string fobias, string disponivelTosa, string possuiPedigree, string agressivo, string hiperativo, string antiSocial, string obsessivo, string observacaoComportamental, string observacaoRotina, DateTime dataRegistro, decimal peso, DateTime dataNascimento, string situacao, Image fotografia1 = null, Image fotografia2 = null, Image fotografia3 = null)
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
            Peso = peso;
            DataNascimento = dataNascimento;
            Situacao = situacao;
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
                using (connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    connection.Open();
                    SqlCeCommand command = connection.CreateCommand();
                    if (operacao == TipoOperacao.Adicionar)
                    {
                        command.CommandText = "INSERT INTO Animal (Nome, Sexo, ClienteId, Especie, Raca, Identificacao, Fobias, Disponivel_tosa, Possui_pedigree, Agressivo, Hiperativo, Anti_social, Obsessivo, Observacao_comportamental, Observacao_rotina, Data_registro, Peso, DataNascimento, Situacao , Fotografia1, Fotografia2, Fotografia3) VALUES (@Nome, @Sexo, @ClienteId, @Especie, @Raca, @Identificacao, @Fobias, @Disponivel_tosa, @Possui_pedigree, @Agressivo, @Hiperativo, @Anti_social, @Obsessivo, @Observacao_comportamental, @Observacao_rotina, @Data_registro, @Peso, @DataNascimento, @Situacao, @Fotografia1, @Fotografia2, @Fotografia3)";
                        command.Parameters.AddWithValue("@Data_registro", DataRegistro);
                    }
                    else
                    {
                        command.CommandText = "UPDATE Animal SET Nome = @Nome, Sexo = @Sexo, ClienteId = @ClienteId, Especie = @Especie, Raca = @Raca, Identificacao = @Identificacao, Fobias = @Fobias, Disponivel_tosa = @Disponivel_tosa, Possui_pedigree = @Possui_pedigree, Agressivo = @Agressivo, Hiperativo = @Hiperativo, Anti_social = @Anti_social, Obsessivo = @Obsessivo, Observacao_comportamental = @Observacao_comportamental, Observacao_rotina = @Observacao_rotina, Peso = @Peso, DataNascimento = @DataNascimento, Situacao = @Situacao, Fotografia1 = @Fotografia1, Fotografia2 = @Fotografia2, Fotografia3 = @Fotografia3 WHERE Id = @Id";
                        command.Parameters.AddWithValue("@Id", Id);
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
                    command.Parameters.AddWithValue("@Peso", Peso);
                    command.Parameters.AddWithValue("@DataNascimento", DataNascimento);
                    command.Parameters.AddWithValue("@Situacao", Situacao);
                    if (Fotografia1 == null)
                    {
                        command.Parameters.AddWithValue("@Fotografia1", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Fotografia1", ConversorImagemByte.ImageToStream(Fotografia1));
                    }
                    if (Fotografia2 == null)
                    {
                        command.Parameters.AddWithValue("@Fotografia2", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Fotografia2", ConversorImagemByte.ImageToStream(Fotografia2));
                    }
                    if (Fotografia3 == null)
                    {
                        command.Parameters.AddWithValue("@Fotografia3", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Fotografia3", ConversorImagemByte.ImageToStream(Fotografia3));
                    }
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Os dados do Animal foram salvos.", "Cadastro de Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show("Erro ao salvar as informações do Animal: " + e.Message, "Falha no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na aplicação ao salvar as informações do Animal: " + e.Message, "Falha no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
        }

        public static DataTable ListarAnimais()
        {
            DataTable dta = new DataTable();
            try
            {
                using (connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    connection.Open();
                    SqlCeCommand comando = connection.CreateCommand();
                    comando.CommandText = "SELECT Animal.Id, Animal.Nome, Animal.Sexo, Clientes.Nome as NomeCliente, Animal.Especie, Animal.Raca, Animal.Identificacao, Animal.Peso, Animal.DataNascimento, Animal.Situacao, Animal.Fobias, Animal.Agressivo, Animal.Hiperativo, Animal.Observacao_rotina, Animal.Data_registro FROM Animal INNER JOIN Clientes ON Animal.ClienteId = Clientes.Id";
                    comando.ExecuteNonQuery();
                    SqlCeDataAdapter dataadp = new SqlCeDataAdapter(comando);
                    dataadp.Fill(dta);
                }
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show("Erro ao exibir os dados na lista: " + ex.Message, "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(ex);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na aplicação ao exibir os dados na lista: " + e.Message, "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            return dta;
        }

        public static DataTable ListarAnimais(int idCliente)
        {
            DataTable dta = new DataTable();
            try
            {
                using (connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    connection.Open();
                    SqlCeCommand comando = connection.CreateCommand();
                    comando.CommandText = "SELECT Animal.Id, Animal.Nome, Animal.Sexo, Clientes.Nome as Dono, Animal.Especie, Animal.Raca, Animal.Identificacao, Animal.Peso, Animal.DataNascimento, Animal.Situacao, Animal.Fobias, Animal.Agressivo, Animal.Hiperativo, Animal.Observacao_rotina, Animal.Data_registro FROM Animal INNER JOIN Clientes ON Animal.ClienteId = Clientes.Id WHERE Animal.ClienteId = @ClienteId";
                    comando.Parameters.AddWithValue("@ClienteId", idCliente);
                    comando.ExecuteNonQuery();
                    SqlCeDataAdapter dataadp = new SqlCeDataAdapter(comando);
                    dataadp.Fill(dta);
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show("Erro ao exibir os dados na lista: " + e.Message, "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Falha na listagem de animais: {e.Message}", "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            return dta;
        }

        public static DataTable ListarRacas()
        {
            DataTable table = new DataTable();
            try
            {
                using (connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    connection.Open();
                    SqlCeCommand comando = connection.CreateCommand();
                    comando.CommandText = "SELECT DISTINCT Raca as Raça from Animal";
                    comando.ExecuteNonQuery();
                    SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(comando);
                    dataAdapter.Fill(table);
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro no banco de dados ao exibir os dados na lista: {e.Message}", "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro na aplicação ao exibir dados na lista: {e.Message}", "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            return table;
        }

        public static DataTable ListarEspecies()
        {
            DataTable table = new DataTable();
            try
            {
                using (connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    connection.Open();
                    SqlCeCommand comando = connection.CreateCommand();
                    comando.CommandText = "SELECT DISTINCT Especie as Espécie from Animal";
                    comando.ExecuteNonQuery();
                    SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(comando);
                    dataAdapter.Fill(table);
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show($"Erro no banco de dados ao exibir os dados na lista: {e.Message}", "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro na aplicação ao exibir os dados na lista: {e.Message}", "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            return table;
        }

        private void BuscarAnimal(int id)
        {
            try
            {
                using (connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    connection.Open();
                    SqlCeCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM Animal WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlCeDataReader reader = command.ExecuteResultSet(ResultSetOptions.Scrollable))
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Id = (int)reader["Id"];
                                Nome = (string)reader["Nome"];
                                Sexo = (string)reader["Sexo"];
                                ClienteId = (int)reader["ClienteId"];
                                Especie = (string)reader["Especie"];
                                Raca = (string)reader["Raca"];
                                Identificacao = (string)reader["Identificacao"];
                                Fobias = (string)reader["Fobias"];
                                DisponivelTosa = reader["Disponivel_tosa"].ToString();
                                PossuiPedigree = (string)reader["Possui_pedigree"];
                                Agressivo = (string)reader["Agressivo"];
                                Hiperativo = (string)reader["Hiperativo"];
                                AntiSocial = (string)reader["Anti_social"];
                                Obsessivo = (string)reader["Obsessivo"];
                                ObservacaoComportamental = (string)reader["Observacao_comportamental"];
                                ObservacaoRotina = (string)reader["Observacao_rotina"];
                                DataRegistro = DateTime.Parse(reader["Data_registro"].ToString());
                                Fotografia1 = reader["Fotografia1"] is DBNull ? null : ConversorImagemByte.RetrieveImage((byte[])reader["Fotografia1"]);
                                Fotografia2 = reader["Fotografia2"] is DBNull ? null : ConversorImagemByte.RetrieveImage((byte[])reader["Fotografia2"]);
                                Fotografia3 = reader["Fotografia3"] is DBNull ? null : ConversorImagemByte.RetrieveImage((byte[])reader["Fotografia3"]);
                                Peso = decimal.Parse(reader["Peso"].ToString());
                                DataNascimento = DateTime.Parse(reader["DataNascimento"].ToString());
                                Situacao = (string)reader["Situacao"];
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
                MessageBox.Show("Falha no banco de dados ao localizar animal: " + e.Message, "Não foi possível localizar o animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
            catch (SqlCeResultException e)
            {
                MessageBox.Show("Falha no banco de dados ao localizar animal: " + e.Message, "Não foi possível localizar o animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha na aplicação ao localizar animal: " + e.Message, "Não foi possível localizar o animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw e;
            }
        }

        public static void ExcluirAnimal(int id)
        {
            try
            {
                using (connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    connection.Open();
                    SqlCeCommand comando = connection.CreateCommand();
                    comando.CommandText = "DELETE FROM Animal WHERE Id = @Id";
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Animal removido", "Remover Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show("Erro ao remover Animal: " + e.Message, "Remover Animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na aplicação ao remover Animal: " + e.Message, "Remover Animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
        }

        public static void ExcluirAnimal(DateTime data)
        {
            try
            {
                using (connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    connection.Open();
                    SqlCeCommand comando = connection.CreateCommand();
                    comando.CommandText = "DELETE FROM Animal WHERE Data_Registro < @Data";
                    comando.Parameters.AddWithValue("@Data", data);
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        FormNotificacao formNotificacao = new FormNotificacao();
                        formNotificacao.ShowAlert("Os registros de Animais foram limpos", TipoNotificacao.Confirmar, "Limpar tabela de Animais");
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show("Erro no banco de dados ao limpar registros de animais: " + e.Message, "Remover Animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na aplicação ao limpar registros de animais: " + e.Message, "Remover Animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
        }

        public static void ExcluirAnimal()
        {
            try
            {
                using (connection = new SqlCeConnection(Properties.Settings.Default.PetShopDbConnectionString))
                {
                    connection.Open();
                    SqlCeCommand comando = connection.CreateCommand();
                    comando.CommandText = "DELETE FROM Animal";
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        FormNotificacao formNotificacao = new FormNotificacao();
                        formNotificacao.ShowAlert("Os registros de Animais foram limpos", TipoNotificacao.Confirmar, "Limpar tabela de Animais");
                    }
                }
            }
            catch (SqlCeException e)
            {
                MessageBox.Show("Erro no banco de dados ao limpar registros de animais: " + e.Message, "Remover Animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na aplicação ao limpar registros de animais: " + e.Message, "Remover Animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorLogger.CreateErrorLog(e);
            }
        }
    }
}


