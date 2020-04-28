using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;


namespace PetShop
{
    public partial class PesquisaAnimais : Form
    {
        public PesquisaAnimais()
        {
            InitializeComponent();
        }

        private void btnAdicionarClienteFornecedor_Click(object sender, EventArgs e)
        {
            AdicionarEditarAnimais adicionarEditarAnimais = new AdicionarEditarAnimais(true, this);
            adicionarEditarAnimais.ShowDialog(); 
        }

        private void PesquisaAnimais_Load(object sender, EventArgs e)
        {
            /*
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.PetShopConnectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand comando = conn.CreateCommand();
                    comando.CommandText = "SELECT * FROM animal";
                    comando.ExecuteNonQuery();
                    DataTable dta = new DataTable();
                    MySqlDataAdapter dataadp = new MySqlDataAdapter(comando);
                    dataadp.Fill(dta);
                    dta.Columns[0].ColumnName = "Número";
                    dta.Columns[1].ColumnName = "Nome do Animal";
                    dta.Columns[2].ColumnName = "Sexo";
                    dta.Columns[3].ColumnName = "Dono / Responsável";
                    dta.Columns[4].ColumnName = "Espécie";
                    dta.Columns[5].ColumnName = "Raça";
                    dta.Columns[6].ColumnName = "Identificação";
                    dta.Columns[7].ColumnName = "Fobias";
                    dta.Columns[8].ColumnName = "Disponível para Tosa";
                    dta.Columns[9].ColumnName = "Pedrigree";
                    dta.Columns[10].ColumnName = "Agressivo";
                    dta.Columns[11].ColumnName = "Hiperativo";
                    dta.Columns[12].ColumnName = "Anti-Social";
                    dta.Columns[13].ColumnName = "Obcessivo";
                    dta.Columns[14].ColumnName = "Relação de Vacionas";
                    dta.Columns[15].ColumnName = "Observações Comportamentais";
                    dta.Columns[16].ColumnName = "Observação de Rotina";
                    DataTable dtaClone = dta.Clone();
                    foreach (DataColumn data in dtaClone.Columns)
                    {
                        data.DataType = typeof(string);
                    }
                    foreach (DataRow rows in dta.Rows)
                    {
                        dtaClone.ImportRow(rows);
                    }                   
                    foreach (DataRow row in dtaClone.Rows)
                    {
                        if (int.TryParse(row[3] as string, out int n))
                        {
                            comando.CommandText = "SELECT nome_completo FROM cliente WHERE id = @id";
                            comando.Parameters.AddWithValue("@id", row[3].ToString());
                            MySqlDataReader reader = comando.ExecuteReader();
                            if (reader.Read())
                            {
                                row[3] = reader.GetString("nome_completo");
                            }
                        }
                        for (int rowColumn = 7; rowColumn < 14; rowColumn++)
                        {
                            if (row[rowColumn].Equals("False"))
                            {
                                row[rowColumn] = "Não";
                            }
                            else
                            {
                                row[rowColumn] = "Sim";
                            }
                        }
                    }
                    listaAnimais.DataSource = dtaClone;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao exibir os dados na lista: " + ex.Message, "Erro de exibição da lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            */
        }
    }
}
