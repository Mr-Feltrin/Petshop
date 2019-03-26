
namespace PetShop
{
    partial class AdicionarEditarProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipoUnidadeProduto = new System.Windows.Forms.ComboBox();
            this.labelTipoUnidade = new System.Windows.Forms.Label();
            this.codigoBarrasProduto = new System.Windows.Forms.TextBox();
            this.labelCodigoBarras = new System.Windows.Forms.Label();
            this.codigoProduto = new System.Windows.Forms.TextBox();
            this.labelCodigoProduto = new System.Windows.Forms.Label();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.nomeProduto = new System.Windows.Forms.TextBox();
            this.labelReferenciaProduto = new System.Windows.Forms.Label();
            this.ReferenciaProduto = new System.Windows.Forms.TextBox();
            this.labelLocalizacaoProduto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelDataCadastroProduto = new System.Windows.Forms.Label();
            this.dataCadastroAtualizacaoProduto = new System.Windows.Forms.TextBox();
            this.labelMarcaProduto = new System.Windows.Forms.Label();
            this.marcaProduto = new System.Windows.Forms.ComboBox();
            this.labelCategoriaProduto = new System.Windows.Forms.Label();
            this.categoriaProduto = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelEstoqueMinimo = new System.Windows.Forms.Label();
            this.estoqueMinimoProduto = new System.Windows.Forms.TextBox();
            this.labelEstoqueAtual = new System.Windows.Forms.Label();
            this.estoqueAtualProduto = new System.Windows.Forms.TextBox();
            this.labelDataValidade = new System.Windows.Forms.Label();
            this.dataValidadeProduto = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.valorCustoProduto = new System.Windows.Forms.TextBox();
            this.labelValorCusto = new System.Windows.Forms.Label();
            this.labelMargemAvista = new System.Windows.Forms.Label();
            this.margemAvistaProduto = new System.Windows.Forms.TextBox();
            this.precoProduto = new System.Windows.Forms.TextBox();
            this.labelPrecoProduto = new System.Windows.Forms.Label();
            this.observacoesProduto = new System.Windows.Forms.RichTextBox();
            this.labelObservacoes = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnAdicionarEditarFornecedor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categoriaProduto);
            this.groupBox1.Controls.Add(this.labelCategoriaProduto);
            this.groupBox1.Controls.Add(this.marcaProduto);
            this.groupBox1.Controls.Add(this.labelMarcaProduto);
            this.groupBox1.Controls.Add(this.dataCadastroAtualizacaoProduto);
            this.groupBox1.Controls.Add(this.labelDataCadastroProduto);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelLocalizacaoProduto);
            this.groupBox1.Controls.Add(this.ReferenciaProduto);
            this.groupBox1.Controls.Add(this.labelReferenciaProduto);
            this.groupBox1.Controls.Add(this.nomeProduto);
            this.groupBox1.Controls.Add(this.labelCodigoBarras);
            this.groupBox1.Controls.Add(this.labelNomeProduto);
            this.groupBox1.Controls.Add(this.tipoUnidadeProduto);
            this.groupBox1.Controls.Add(this.labelTipoUnidade);
            this.groupBox1.Controls.Add(this.codigoBarrasProduto);
            this.groupBox1.Controls.Add(this.codigoProduto);
            this.groupBox1.Controls.Add(this.labelCodigoProduto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tipoUnidadeProduto
            // 
            this.tipoUnidadeProduto.FormattingEnabled = true;
            this.tipoUnidadeProduto.Location = new System.Drawing.Point(520, 42);
            this.tipoUnidadeProduto.Name = "tipoUnidadeProduto";
            this.tipoUnidadeProduto.Size = new System.Drawing.Size(118, 21);
            this.tipoUnidadeProduto.TabIndex = 18;
            // 
            // labelTipoUnidade
            // 
            this.labelTipoUnidade.AutoSize = true;
            this.labelTipoUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoUnidade.Location = new System.Drawing.Point(517, 21);
            this.labelTipoUnidade.Name = "labelTipoUnidade";
            this.labelTipoUnidade.Size = new System.Drawing.Size(121, 18);
            this.labelTipoUnidade.TabIndex = 17;
            this.labelTipoUnidade.Text = "Tipo de Unidade*";
            // 
            // codigoBarrasProduto
            // 
            this.codigoBarrasProduto.BackColor = System.Drawing.SystemColors.Info;
            this.codigoBarrasProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoBarrasProduto.Location = new System.Drawing.Point(170, 42);
            this.codigoBarrasProduto.MaxLength = 500;
            this.codigoBarrasProduto.Name = "codigoBarrasProduto";
            this.codigoBarrasProduto.Size = new System.Drawing.Size(314, 22);
            this.codigoBarrasProduto.TabIndex = 16;
            // 
            // labelCodigoBarras
            // 
            this.labelCodigoBarras.AutoSize = true;
            this.labelCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoBarras.Location = new System.Drawing.Point(167, 21);
            this.labelCodigoBarras.Name = "labelCodigoBarras";
            this.labelCodigoBarras.Size = new System.Drawing.Size(124, 18);
            this.labelCodigoBarras.TabIndex = 3;
            this.labelCodigoBarras.Text = "Código de Barras";
            // 
            // codigoProduto
            // 
            this.codigoProduto.BackColor = System.Drawing.SystemColors.Window;
            this.codigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoProduto.Location = new System.Drawing.Point(20, 42);
            this.codigoProduto.MaxLength = 500;
            this.codigoProduto.Name = "codigoProduto";
            this.codigoProduto.Size = new System.Drawing.Size(112, 22);
            this.codigoProduto.TabIndex = 2;
            // 
            // labelCodigoProduto
            // 
            this.labelCodigoProduto.AutoSize = true;
            this.labelCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoProduto.Location = new System.Drawing.Point(17, 21);
            this.labelCodigoProduto.Name = "labelCodigoProduto";
            this.labelCodigoProduto.Size = new System.Drawing.Size(56, 18);
            this.labelCodigoProduto.TabIndex = 1;
            this.labelCodigoProduto.Text = "Código";
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeProduto.Location = new System.Drawing.Point(17, 77);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(213, 18);
            this.labelNomeProduto.TabIndex = 19;
            this.labelNomeProduto.Text = "Nome / Descrição do Produto*";
            // 
            // nomeProduto
            // 
            this.nomeProduto.BackColor = System.Drawing.SystemColors.Info;
            this.nomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeProduto.Location = new System.Drawing.Point(20, 98);
            this.nomeProduto.MaxLength = 500;
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.Size = new System.Drawing.Size(618, 22);
            this.nomeProduto.TabIndex = 20;
            // 
            // labelReferenciaProduto
            // 
            this.labelReferenciaProduto.AutoSize = true;
            this.labelReferenciaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReferenciaProduto.Location = new System.Drawing.Point(17, 133);
            this.labelReferenciaProduto.Name = "labelReferenciaProduto";
            this.labelReferenciaProduto.Size = new System.Drawing.Size(157, 18);
            this.labelReferenciaProduto.TabIndex = 21;
            this.labelReferenciaProduto.Text = "Referência do Produto";
            // 
            // ReferenciaProduto
            // 
            this.ReferenciaProduto.BackColor = System.Drawing.SystemColors.Window;
            this.ReferenciaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenciaProduto.Location = new System.Drawing.Point(20, 154);
            this.ReferenciaProduto.MaxLength = 500;
            this.ReferenciaProduto.Name = "ReferenciaProduto";
            this.ReferenciaProduto.Size = new System.Drawing.Size(217, 22);
            this.ReferenciaProduto.TabIndex = 22;
            // 
            // labelLocalizacaoProduto
            // 
            this.labelLocalizacaoProduto.AutoSize = true;
            this.labelLocalizacaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalizacaoProduto.Location = new System.Drawing.Point(277, 133);
            this.labelLocalizacaoProduto.Name = "labelLocalizacaoProduto";
            this.labelLocalizacaoProduto.Size = new System.Drawing.Size(88, 18);
            this.labelLocalizacaoProduto.TabIndex = 23;
            this.labelLocalizacaoProduto.Text = "Localização";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(280, 154);
            this.textBox1.MaxLength = 500;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 24;
            // 
            // labelDataCadastroProduto
            // 
            this.labelDataCadastroProduto.AutoSize = true;
            this.labelDataCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataCadastroProduto.Location = new System.Drawing.Point(484, 133);
            this.labelDataCadastroProduto.Name = "labelDataCadastroProduto";
            this.labelDataCadastroProduto.Size = new System.Drawing.Size(130, 18);
            this.labelDataCadastroProduto.TabIndex = 25;
            this.labelDataCadastroProduto.Text = "Data de Cadastro*";
            // 
            // dataCadastroAtualizacaoProduto
            // 
            this.dataCadastroAtualizacaoProduto.BackColor = System.Drawing.SystemColors.Window;
            this.dataCadastroAtualizacaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCadastroAtualizacaoProduto.Location = new System.Drawing.Point(487, 154);
            this.dataCadastroAtualizacaoProduto.MaxLength = 500;
            this.dataCadastroAtualizacaoProduto.Name = "dataCadastroAtualizacaoProduto";
            this.dataCadastroAtualizacaoProduto.Size = new System.Drawing.Size(151, 22);
            this.dataCadastroAtualizacaoProduto.TabIndex = 26;
            // 
            // labelMarcaProduto
            // 
            this.labelMarcaProduto.AutoSize = true;
            this.labelMarcaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarcaProduto.Location = new System.Drawing.Point(17, 192);
            this.labelMarcaProduto.Name = "labelMarcaProduto";
            this.labelMarcaProduto.Size = new System.Drawing.Size(128, 18);
            this.labelMarcaProduto.TabIndex = 27;
            this.labelMarcaProduto.Text = "Marca do Produto";
            // 
            // marcaProduto
            // 
            this.marcaProduto.FormattingEnabled = true;
            this.marcaProduto.Location = new System.Drawing.Point(20, 213);
            this.marcaProduto.Name = "marcaProduto";
            this.marcaProduto.Size = new System.Drawing.Size(291, 21);
            this.marcaProduto.TabIndex = 28;
            // 
            // labelCategoriaProduto
            // 
            this.labelCategoriaProduto.AutoSize = true;
            this.labelCategoriaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoriaProduto.Location = new System.Drawing.Point(366, 192);
            this.labelCategoriaProduto.Name = "labelCategoriaProduto";
            this.labelCategoriaProduto.Size = new System.Drawing.Size(210, 18);
            this.labelCategoriaProduto.TabIndex = 29;
            this.labelCategoriaProduto.Text = "Grupo / Categoria do Produto*";
            // 
            // categoriaProduto
            // 
            this.categoriaProduto.FormattingEnabled = true;
            this.categoriaProduto.Location = new System.Drawing.Point(369, 213);
            this.categoriaProduto.Name = "categoriaProduto";
            this.categoriaProduto.Size = new System.Drawing.Size(269, 21);
            this.categoriaProduto.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataValidadeProduto);
            this.groupBox2.Controls.Add(this.labelDataValidade);
            this.groupBox2.Controls.Add(this.estoqueAtualProduto);
            this.groupBox2.Controls.Add(this.labelEstoqueAtual);
            this.groupBox2.Controls.Add(this.estoqueMinimoProduto);
            this.groupBox2.Controls.Add(this.labelEstoqueMinimo);
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // labelEstoqueMinimo
            // 
            this.labelEstoqueMinimo.AutoSize = true;
            this.labelEstoqueMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstoqueMinimo.Location = new System.Drawing.Point(17, 16);
            this.labelEstoqueMinimo.Name = "labelEstoqueMinimo";
            this.labelEstoqueMinimo.Size = new System.Drawing.Size(116, 18);
            this.labelEstoqueMinimo.TabIndex = 2;
            this.labelEstoqueMinimo.Text = "Estoque Mínimo";
            // 
            // estoqueMinimoProduto
            // 
            this.estoqueMinimoProduto.BackColor = System.Drawing.SystemColors.Window;
            this.estoqueMinimoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estoqueMinimoProduto.Location = new System.Drawing.Point(147, 15);
            this.estoqueMinimoProduto.MaxLength = 500;
            this.estoqueMinimoProduto.Name = "estoqueMinimoProduto";
            this.estoqueMinimoProduto.Size = new System.Drawing.Size(164, 22);
            this.estoqueMinimoProduto.TabIndex = 25;
            // 
            // labelEstoqueAtual
            // 
            this.labelEstoqueAtual.AutoSize = true;
            this.labelEstoqueAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstoqueAtual.Location = new System.Drawing.Point(17, 57);
            this.labelEstoqueAtual.Name = "labelEstoqueAtual";
            this.labelEstoqueAtual.Size = new System.Drawing.Size(105, 18);
            this.labelEstoqueAtual.TabIndex = 26;
            this.labelEstoqueAtual.Text = "Estoque Atual*";
            // 
            // estoqueAtualProduto
            // 
            this.estoqueAtualProduto.BackColor = System.Drawing.SystemColors.Window;
            this.estoqueAtualProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estoqueAtualProduto.Location = new System.Drawing.Point(147, 56);
            this.estoqueAtualProduto.MaxLength = 500;
            this.estoqueAtualProduto.Name = "estoqueAtualProduto";
            this.estoqueAtualProduto.Size = new System.Drawing.Size(164, 22);
            this.estoqueAtualProduto.TabIndex = 27;
            // 
            // labelDataValidade
            // 
            this.labelDataValidade.AutoSize = true;
            this.labelDataValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataValidade.Location = new System.Drawing.Point(17, 99);
            this.labelDataValidade.Name = "labelDataValidade";
            this.labelDataValidade.Size = new System.Drawing.Size(124, 18);
            this.labelDataValidade.TabIndex = 28;
            this.labelDataValidade.Text = "Data de Validade*";
            // 
            // dataValidadeProduto
            // 
            this.dataValidadeProduto.BackColor = System.Drawing.SystemColors.Window;
            this.dataValidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataValidadeProduto.Location = new System.Drawing.Point(147, 98);
            this.dataValidadeProduto.MaxLength = 500;
            this.dataValidadeProduto.Name = "dataValidadeProduto";
            this.dataValidadeProduto.Size = new System.Drawing.Size(164, 22);
            this.dataValidadeProduto.TabIndex = 29;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelPrecoProduto);
            this.groupBox3.Controls.Add(this.precoProduto);
            this.groupBox3.Controls.Add(this.margemAvistaProduto);
            this.groupBox3.Controls.Add(this.labelMargemAvista);
            this.groupBox3.Controls.Add(this.labelValorCusto);
            this.groupBox3.Controls.Add(this.valorCustoProduto);
            this.groupBox3.Location = new System.Drawing.Point(350, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 138);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // valorCustoProduto
            // 
            this.valorCustoProduto.BackColor = System.Drawing.SystemColors.Window;
            this.valorCustoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorCustoProduto.Location = new System.Drawing.Point(196, 16);
            this.valorCustoProduto.MaxLength = 500;
            this.valorCustoProduto.Name = "valorCustoProduto";
            this.valorCustoProduto.Size = new System.Drawing.Size(104, 22);
            this.valorCustoProduto.TabIndex = 26;
            // 
            // labelValorCusto
            // 
            this.labelValorCusto.AutoSize = true;
            this.labelValorCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorCusto.Location = new System.Drawing.Point(74, 17);
            this.labelValorCusto.Name = "labelValorCusto";
            this.labelValorCusto.Size = new System.Drawing.Size(106, 18);
            this.labelValorCusto.TabIndex = 27;
            this.labelValorCusto.Text = "Valor de Custo";
            // 
            // labelMargemAvista
            // 
            this.labelMargemAvista.AutoSize = true;
            this.labelMargemAvista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMargemAvista.Location = new System.Drawing.Point(42, 58);
            this.labelMargemAvista.Name = "labelMargemAvista";
            this.labelMargemAvista.Size = new System.Drawing.Size(138, 18);
            this.labelMargemAvista.TabIndex = 28;
            this.labelMargemAvista.Text = "Margem a Vista (%)";
            // 
            // margemAvistaProduto
            // 
            this.margemAvistaProduto.BackColor = System.Drawing.SystemColors.Window;
            this.margemAvistaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.margemAvistaProduto.Location = new System.Drawing.Point(196, 56);
            this.margemAvistaProduto.MaxLength = 500;
            this.margemAvistaProduto.Name = "margemAvistaProduto";
            this.margemAvistaProduto.Size = new System.Drawing.Size(104, 22);
            this.margemAvistaProduto.TabIndex = 29;
            // 
            // precoProduto
            // 
            this.precoProduto.BackColor = System.Drawing.SystemColors.Window;
            this.precoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoProduto.Location = new System.Drawing.Point(196, 98);
            this.precoProduto.MaxLength = 500;
            this.precoProduto.Name = "precoProduto";
            this.precoProduto.Size = new System.Drawing.Size(104, 22);
            this.precoProduto.TabIndex = 30;
            // 
            // labelPrecoProduto
            // 
            this.labelPrecoProduto.AutoSize = true;
            this.labelPrecoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecoProduto.Location = new System.Drawing.Point(42, 99);
            this.labelPrecoProduto.Name = "labelPrecoProduto";
            this.labelPrecoProduto.Size = new System.Drawing.Size(132, 18);
            this.labelPrecoProduto.TabIndex = 31;
            this.labelPrecoProduto.Text = "Preço do Produto*";
            // 
            // observacoesProduto
            // 
            this.observacoesProduto.Location = new System.Drawing.Point(12, 437);
            this.observacoesProduto.Name = "observacoesProduto";
            this.observacoesProduto.Size = new System.Drawing.Size(663, 184);
            this.observacoesProduto.TabIndex = 3;
            this.observacoesProduto.Text = "";
            // 
            // labelObservacoes
            // 
            this.labelObservacoes.AutoSize = true;
            this.labelObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservacoes.Location = new System.Drawing.Point(9, 416);
            this.labelObservacoes.Name = "labelObservacoes";
            this.labelObservacoes.Size = new System.Drawing.Size(263, 18);
            this.labelObservacoes.TabIndex = 4;
            this.labelObservacoes.Text = "Informações Adicionais / Observações";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::PetShop.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 636);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 52);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnAdicionarEditarFornecedor
            // 
            this.BtnAdicionarEditarFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdicionarEditarFornecedor.AutoSize = true;
            this.BtnAdicionarEditarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionarEditarFornecedor.Image = global::PetShop.Properties.Resources.adicionar;
            this.BtnAdicionarEditarFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdicionarEditarFornecedor.Location = new System.Drawing.Point(625, 639);
            this.BtnAdicionarEditarFornecedor.Name = "BtnAdicionarEditarFornecedor";
            this.BtnAdicionarEditarFornecedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAdicionarEditarFornecedor.Size = new System.Drawing.Size(50, 52);
            this.BtnAdicionarEditarFornecedor.TabIndex = 19;
            this.BtnAdicionarEditarFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdicionarEditarFornecedor.UseVisualStyleBackColor = true;
            // 
            // AdicionarEditarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 709);
            this.Controls.Add(this.BtnAdicionarEditarFornecedor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.labelObservacoes);
            this.Controls.Add(this.observacoesProduto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarEditarProdutos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AdicionarEditarProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCodigoProduto;
        private System.Windows.Forms.Label labelCodigoBarras;
        private System.Windows.Forms.TextBox codigoProduto;
        private System.Windows.Forms.Label labelTipoUnidade;
        private System.Windows.Forms.TextBox codigoBarrasProduto;
        private System.Windows.Forms.ComboBox tipoUnidadeProduto;
        private System.Windows.Forms.Label labelLocalizacaoProduto;
        private System.Windows.Forms.TextBox ReferenciaProduto;
        private System.Windows.Forms.Label labelReferenciaProduto;
        private System.Windows.Forms.TextBox nomeProduto;
        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.ComboBox categoriaProduto;
        private System.Windows.Forms.Label labelCategoriaProduto;
        private System.Windows.Forms.ComboBox marcaProduto;
        private System.Windows.Forms.Label labelMarcaProduto;
        private System.Windows.Forms.TextBox dataCadastroAtualizacaoProduto;
        private System.Windows.Forms.Label labelDataCadastroProduto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox dataValidadeProduto;
        private System.Windows.Forms.Label labelDataValidade;
        private System.Windows.Forms.TextBox estoqueAtualProduto;
        private System.Windows.Forms.Label labelEstoqueAtual;
        private System.Windows.Forms.TextBox estoqueMinimoProduto;
        private System.Windows.Forms.Label labelEstoqueMinimo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelPrecoProduto;
        private System.Windows.Forms.TextBox precoProduto;
        private System.Windows.Forms.TextBox margemAvistaProduto;
        private System.Windows.Forms.Label labelMargemAvista;
        private System.Windows.Forms.Label labelValorCusto;
        private System.Windows.Forms.TextBox valorCustoProduto;
        private System.Windows.Forms.RichTextBox observacoesProduto;
        private System.Windows.Forms.Label labelObservacoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnAdicionarEditarFornecedor;
    }
}