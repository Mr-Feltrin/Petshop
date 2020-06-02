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
        private MySqlCommand comando;
        private MySqlConnection conn = new MySqlConnection(Properties.Settings.Default.db_caopanheiroConnectionString);

        public AdicionarEditarProdutos(bool operacao, PesquisaProdutos pesquisaProdutos)
        {
            InitializeComponent();
            Operacao = operacao;
            _pesquisaProdutos = pesquisaProdutos;
        }

        public AdicionarEditarProdutos(bool operacao, PesquisaProdutos pesquisaProdutos, string idProduto) : this(operacao, pesquisaProdutos)
        {
            IdProduto = int.Parse(idProduto);
        }

        private void FormatoMonetario(TextBox valor, bool entrada)
        {
            if (entrada)
            {
                if (!string.IsNullOrEmpty(valor.Text))
                {
                    if (valor.Text.Contains("R$"))
                    {
                        valor.Text = valor.Text.Replace("R$", "");
                    }
                    if (valor.Text.Contains("."))
                    {
                        valor.Text = valor.Text.Replace(".", "");
                    }
                    if (valor.Text.Contains(","))
                    {
                        valor.Text = valor.Text.Replace(",", ".");
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(valor.Text))
                {
                    if (double.TryParse(valor.Text, out double value))
                    {
                        valor.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C2}", value);
                    }
                    else
                    {
                        valor.Text = string.Empty;
                        MessageBox.Show("O valor inserido para o preço é inválido", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AdicionarEditarProdutos_Load(object sender, EventArgs e) // Passar pra controllers e usar linq para lista
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
                    try
                    {
                        conn.Open();
                        MySqlCommand comando = conn.CreateCommand();
                        comando.CommandText = "SELECT * FROM produto WHERE id = @id";
                        comando.Parameters.AddWithValue("@id", IdProduto);
                        MySqlDataReader reader = comando.ExecuteReader();
                        if (reader.Read())
                        {
                            codigoProduto.Text = reader.GetString("id");
                            codigoBarrasProduto.Text = reader.GetString("codigo_barras");
                            tipoUnidadeProduto.Text = reader.GetString("unidade");
                            quantidadeProduto.Text = reader.GetString("quantidade");
                            nomeProduto.Text = reader.GetString("nome_produto");
                            referenciaProduto.Text = reader.GetString("referencia");
                            localizacaoProduto.Text = reader.GetString("local_fisico");
                            dataCadastroProduto.Text = reader.GetString("data_modificacao").ToString();
                            marcaProduto.Text = reader.GetString("marca");
                            categoriaProduto.Text = reader.GetString("categoria");
                            estoqueMinimoProduto.Text = reader.GetString("estoque_minimo");
                            estoqueAtualProduto.Text = reader.GetString("estoque_atual");
                            dataValidadeProduto.Text = reader.GetString("data_validade").ToString();
                            valorCustoProduto.Text = reader.GetString("valor_custo");
                            margemAvistaProduto.Text = reader.GetString("margem_avista");
                            precoProduto.Text = reader.GetString("valor_produto");
                            observacoesProduto.Text = reader.GetString("observacoes");
                        }
                        else
                        {
                            MessageBox.Show("O produto a ser editado não se encontra mais na base de dados.", "Erro ao identificar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao acessar o banco de dados: {ex.Message}", "Falha ao editar Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
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
                InsereAtualizaProdutos();
            }
        }


        private void InsereAtualizaProdutos() // Passar pra controller
        {
            try
            {
                conn.Open();
                comando = conn.CreateCommand();
                if (Operacao)
                {
                    comando.CommandText = "INSERT INTO produto (nome_produto, codigo_barras, unidade, quantidade, referencia, local_fisico, data_modificacao, marca, categoria, estoque_minimo, estoque_atual, data_validade, valor_custo, margem_avista, valor_produto, observacoes) VALUES (@nome_produto, @codigo_barras, @unidade, @quantidade, @referencia, @local_fisico, @data_modificacao, @marca, @categoria, @estoque_minimo, @estoque_atual, @data_validade, @valor_custo, @margem_avista, @valor_produto, @observacoes)";
                }
                else
                {
                    comando.CommandText = "UPDATE produto SET nome_produto = @nome_produto, codigo_barras = @codigo_barras, unidade = @unidade, quantidade = @quantidade, referencia = @referencia, local_fisico = @local_fisico, data_modificacao = @data_modificacao, marca = @marca, categoria = @categoria, estoque_minimo = @estoque_minimo, estoque_atual = @estoque_atual, data_validade = @data_validade, valor_custo = @valor_custo, margem_avista = @margem_avista, valor_produto = @valor_produto, observacoes = @observacoes WhERE id = @id";
                    comando.Parameters.AddWithValue("@id", IdProduto);
                }
                comando.Parameters.AddWithValue("@nome_produto", nomeProduto.Text);
                comando.Parameters.AddWithValue("@codigo_barras", codigoBarrasProduto.Text);
                comando.Parameters.AddWithValue("@unidade", tipoUnidadeProduto.Text);
                comando.Parameters.AddWithValue("@quantidade", quantidadeProduto.Text);
                comando.Parameters.AddWithValue("@referencia", referenciaProduto.Text);
                comando.Parameters.AddWithValue("@local_fisico", localizacaoProduto.Text);
                comando.Parameters.AddWithValue("@data_modificacao", DateTime.Parse(DateTime.ParseExact(dataCadastroProduto.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd")));
                comando.Parameters.AddWithValue("@marca", marcaProduto.Text);
                comando.Parameters.AddWithValue("@categoria", categoriaProduto.Text);
                comando.Parameters.AddWithValue("@estoque_minimo", estoqueMinimoProduto.Text);
                comando.Parameters.AddWithValue("@estoque_atual", estoqueAtualProduto.Text);
                comando.Parameters.AddWithValue("@data_validade", DateTime.Parse(DateTime.ParseExact(dataValidadeProduto.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd")));
                comando.Parameters.AddWithValue("@valor_custo", valorCustoProduto.Text.Replace("R$", "").Replace(".", "").Replace(",", "."));
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

        private void QuantidadeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValorCustoProduto_Enter(object sender, EventArgs e)
        {
            FormatoMonetario(valorCustoProduto, true);
        }

        private void ValorCustoProduto_Leave(object sender, EventArgs e)
        {
            FormatoMonetario(valorCustoProduto, false);
        }

        private void PrecoProduto_Enter(object sender, EventArgs e)
        {
            FormatoMonetario(precoProduto, true);
        }

        private void PrecoProduto_Leave(object sender, EventArgs e)
        {
            FormatoMonetario(precoProduto, false);
        }

        private void ValorCustoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
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
    }
}
