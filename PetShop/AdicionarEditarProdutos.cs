using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace PetShop
{
    public partial class AdicionarEditarProdutos : Form
    {
        private readonly bool Operacao; // True == adicionar, false == editar
        private readonly PesquisaProdutos _pesquisaProdutos;
        private readonly int IdProduto;

        public AdicionarEditarProdutos(bool operacao, PesquisaProdutos pesquisaProdutos)
        {
            InitializeComponent();
            Operacao = operacao;
            _pesquisaProdutos = pesquisaProdutos;
        }

        public AdicionarEditarProdutos(bool operacao, PesquisaProdutos pesquisaProdutos, string idProduto):this(operacao, pesquisaProdutos)
        {
            IdProduto = int.Parse(idProduto);
        }

        private void AdicionarEditarProdutos_Load(object sender, EventArgs e)
        {
            if (Operacao == true)
            {
                Text = "Adicionar Produto";
                BtnAdicionarEditarFornecedor.Text = "Adicionar";
            }
            else
            {
                Text = "Editar Produto";
                BtnAdicionarEditarFornecedor.Text = "Atualizar";
                using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.db_caopanheiroConnectionString))
                {

                }
            }
        }

        private void VerificaCamposObrigatorios()
        {
            if (string.IsNullOrWhiteSpace(tipoUnidadeProduto.Text))
            {
                MessageBox.Show("Preencha o campo de Tipo de Unidade", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(quantidadeProduto.Text))
            {
                MessageBox.Show("Preencha o campo de Tipo de Quantidade", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(nomeProduto.Text))
            {
                MessageBox.Show("Preencha o campo Nome / Descrição do Produto", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(dataCadastroProduto.Text))
            {
                MessageBox.Show("Preencha o campo de Data de Cadastro", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(categoriaProduto.Text))
            {
                MessageBox.Show("Preencha o campo de Grupo / Categoria do Produto", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(estoqueAtualProduto.Text))
            {
                MessageBox.Show("Preencha o campo de Estoque Atual", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(dataValidadeProduto.Text))
            {
                MessageBox.Show("Preencha o campo de Data de Validade", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(precoProduto.Text))
            {
                MessageBox.Show("Preencha o campo de Preço do Produto", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                InsereProduto();
            }
        }

        private void InsereProduto()
        {
            using (MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.db_caopanheiroConnectionString))
            {             
                try
                {
                    conn.Open();
                    MySqlCommand comando = conn.CreateCommand();
                    if (Operacao)
                    {
                        comando.CommandText = "INSERT INTO produto (nome_produto,codigo_barras,unidade,quantidade,referencia,local_fisico,data_modificacao,marca,categoria,estoque_minimo,estoque_atual,data_validade,valor_custo,margem_avista,valor_produto,observacoes) VALUES (@nome_produto,@codigo_barras,@unidade,@quantidade,@referencia,@local_fisico,@data_modificacao,@marca,@categoria,@estoque_minimo,@estoque_atual,@data_validade,@valor_custo,@margem_avista,@valor_produto,@observacoes)";
                    }
                    else
                    {

                    }
                    comando.Parameters.AddWithValue("@nome_produto", nomeProduto.Text);
                    comando.Parameters.AddWithValue("@codigo_barras", codigoBarrasProduto.Text);
                    comando.Parameters.AddWithValue("@unidade", tipoUnidadeProduto.Text);
                    comando.Parameters.AddWithValue("@quantidade", quantidadeProduto.Text);
                    comando.Parameters.AddWithValue("@referencia", ReferenciaProduto.Text);
                    comando.Parameters.AddWithValue("@local_fisico", localizacaoProduto.Text);
                    comando.Parameters.AddWithValue("@data_modificacao", DateTime.Parse(DateTime.ParseExact(dataCadastroProduto.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd")));
                    comando.Parameters.AddWithValue("@marca", marcaProduto.Text);
                    comando.Parameters.AddWithValue("@categoria", categoriaProduto.Text);
                    comando.Parameters.AddWithValue("@estoque_minimo", estoqueMinimoProduto.Text);
                    comando.Parameters.AddWithValue("@estoque_atual", estoqueAtualProduto.Text);
                    comando.Parameters.AddWithValue("@data_validade", DateTime.Parse(DateTime.ParseExact(dataValidadeProduto.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd")));
                    comando.Parameters.AddWithValue("@valor_custo",  valorCustoProduto.Text.Replace("R$", "").Replace(".", "").Replace(",", "."));
                    comando.Parameters.AddWithValue("@margem_avista", margemAvistaProduto.Text);
                    comando.Parameters.AddWithValue("@valor_produto", precoProduto.Text.Replace("R$", "").Replace(".", "").Replace(",", "."));
                    comando.Parameters.AddWithValue("@observacoes", observacoesProduto.Text);
                    if (comando.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Os dados do Produto foram salvos.", "Cadastro de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _pesquisaProdutos.ListaProdutos("SELECT * FROM produto");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar as informações do Produto: " + ex.Message, "Falha no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    Close();
                }
            
            }          
        }
   
        private void PrecoProduto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(precoProduto.Text))
            {
                double value;
                if (double.TryParse(precoProduto.Text, out value))
                {
                    precoProduto.Text = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C2}", value);
                }
                else
                {
                    precoProduto.Text = string.Empty;
                    MessageBox.Show("O valor inserido para o preço é inválido, utilize apenas números", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PrecoProduto_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(precoProduto.Text))
            {
                precoProduto.Text = precoProduto.Text.Replace("R$", "");
                precoProduto.Text = precoProduto.Text.Replace(".", "");
                precoProduto.Text = precoProduto.Text.Replace(",", ".");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }    

        private void EstoqueMinimoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void EstoqueAtualProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void MargemAvistaProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnAdicionarEditarFornecedor_Click(object sender, EventArgs e)
        {
            VerificaCamposObrigatorios();
        }

        private void ValorCustoProduto_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(valorCustoProduto.Text))
            {
                valorCustoProduto.Text = valorCustoProduto.Text.Replace("R$", "");
                valorCustoProduto.Text = valorCustoProduto.Text.Replace(".", "");
                valorCustoProduto.Text = valorCustoProduto.Text.Replace(",", ".");
            }        
        }

        private void ValorCustoProduto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(valorCustoProduto.Text))
            {
                double value;
                if (double.TryParse(valorCustoProduto.Text, out value))
                {
                    valorCustoProduto.Text = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C2}", value);
                }
                else
                {
                    valorCustoProduto.Text = string.Empty;
                    MessageBox.Show("O valor inserido para o preço é inválido, utilize apenas números", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }             
        }

        private void ValorCustoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void PrecoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void ValorCustoProduto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void QuantidadeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
