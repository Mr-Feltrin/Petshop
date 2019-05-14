namespace PetShop
{
    partial class PesquisaProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaProdutos));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.listaProduto = new System.Windows.Forms.DataGridView();
            this.groupBox_pesquisar_nome_cliente = new System.Windows.Forms.GroupBox();
            this.labelMarcaProduto = new System.Windows.Forms.Label();
            this.textBoxPesquisarMarcaProduto = new System.Windows.Forms.TextBox();
            this.textBoxPesquisarNomeProduto = new System.Windows.Forms.TextBox();
            this.labelPesquisarProduto = new System.Windows.Forms.Label();
            this.btnAdicionarClienteFornecedor = new System.Windows.Forms.Button();
            this.btnEditarClienteFornecedor = new System.Windows.Forms.Button();
            this.btnExcluirClienteFornecedor = new System.Windows.Forms.Button();
            this.btnImprimirClienteFornecedor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxEmEstoque = new System.Windows.Forms.PictureBox();
            this.labelEmEstoque = new System.Windows.Forms.Label();
            this.labelBaixoEstoque = new System.Windows.Forms.Label();
            this.pictureBoxBaixoEstoque = new System.Windows.Forms.PictureBox();
            this.labelSemEstoque = new System.Windows.Forms.Label();
            this.pictureBoxSemEstoque = new System.Windows.Forms.PictureBox();
            this.groupBoxLegendaCores = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelEstoqueIndefinido = new System.Windows.Forms.Label();
            this.groupBoxFiltrar = new System.Windows.Forms.GroupBox();
            this.comboBoxFiltrarLista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProduto)).BeginInit();
            this.groupBox_pesquisar_nome_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaixoEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSemEstoque)).BeginInit();
            this.groupBoxLegendaCores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.listaProduto);
            this.groupBox.Location = new System.Drawing.Point(12, 75);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1129, 585);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // listaProduto
            // 
            this.listaProduto.AllowUserToAddRows = false;
            this.listaProduto.AllowUserToDeleteRows = false;
            this.listaProduto.AllowUserToResizeColumns = false;
            this.listaProduto.AllowUserToResizeRows = false;
            this.listaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listaProduto.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaProduto.DefaultCellStyle = dataGridViewCellStyle2;
            this.listaProduto.Location = new System.Drawing.Point(9, 19);
            this.listaProduto.MultiSelect = false;
            this.listaProduto.Name = "listaProduto";
            this.listaProduto.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listaProduto.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaProduto.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.listaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaProduto.Size = new System.Drawing.Size(1114, 551);
            this.listaProduto.TabIndex = 1;
            // 
            // groupBox_pesquisar_nome_cliente
            // 
            this.groupBox_pesquisar_nome_cliente.Controls.Add(this.labelMarcaProduto);
            this.groupBox_pesquisar_nome_cliente.Controls.Add(this.textBoxPesquisarMarcaProduto);
            this.groupBox_pesquisar_nome_cliente.Controls.Add(this.textBoxPesquisarNomeProduto);
            this.groupBox_pesquisar_nome_cliente.Controls.Add(this.labelPesquisarProduto);
            this.groupBox_pesquisar_nome_cliente.Location = new System.Drawing.Point(12, 12);
            this.groupBox_pesquisar_nome_cliente.Name = "groupBox_pesquisar_nome_cliente";
            this.groupBox_pesquisar_nome_cliente.Size = new System.Drawing.Size(752, 57);
            this.groupBox_pesquisar_nome_cliente.TabIndex = 8;
            this.groupBox_pesquisar_nome_cliente.TabStop = false;
            // 
            // labelMarcaProduto
            // 
            this.labelMarcaProduto.AutoSize = true;
            this.labelMarcaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarcaProduto.Location = new System.Drawing.Point(478, 11);
            this.labelMarcaProduto.Name = "labelMarcaProduto";
            this.labelMarcaProduto.Size = new System.Drawing.Size(179, 16);
            this.labelMarcaProduto.TabIndex = 9;
            this.labelMarcaProduto.Text = "Pesquisar Marca do Produto";
            // 
            // textBoxPesquisarMarcaProduto
            // 
            this.textBoxPesquisarMarcaProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPesquisarMarcaProduto.Location = new System.Drawing.Point(481, 30);
            this.textBoxPesquisarMarcaProduto.Name = "textBoxPesquisarMarcaProduto";
            this.textBoxPesquisarMarcaProduto.Size = new System.Drawing.Size(265, 20);
            this.textBoxPesquisarMarcaProduto.TabIndex = 10;
            // 
            // textBoxPesquisarNomeProduto
            // 
            this.textBoxPesquisarNomeProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPesquisarNomeProduto.Location = new System.Drawing.Point(6, 30);
            this.textBoxPesquisarNomeProduto.Name = "textBoxPesquisarNomeProduto";
            this.textBoxPesquisarNomeProduto.Size = new System.Drawing.Size(469, 20);
            this.textBoxPesquisarNomeProduto.TabIndex = 9;
            // 
            // labelPesquisarProduto
            // 
            this.labelPesquisarProduto.AutoSize = true;
            this.labelPesquisarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisarProduto.Location = new System.Drawing.Point(3, 11);
            this.labelPesquisarProduto.Name = "labelPesquisarProduto";
            this.labelPesquisarProduto.Size = new System.Drawing.Size(178, 16);
            this.labelPesquisarProduto.TabIndex = 8;
            this.labelPesquisarProduto.Text = "Pesquisar Nome do Produto";
            // 
            // btnAdicionarClienteFornecedor
            // 
            this.btnAdicionarClienteFornecedor.AutoSize = true;
            this.btnAdicionarClienteFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarClienteFornecedor.FlatAppearance.BorderSize = 0;
            this.btnAdicionarClienteFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarClienteFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarClienteFornecedor.Image = global::PetShop.Properties.Resources.adicionar_list;
            this.btnAdicionarClienteFornecedor.Location = new System.Drawing.Point(853, 16);
            this.btnAdicionarClienteFornecedor.Name = "btnAdicionarClienteFornecedor";
            this.btnAdicionarClienteFornecedor.Size = new System.Drawing.Size(77, 55);
            this.btnAdicionarClienteFornecedor.TabIndex = 9;
            this.btnAdicionarClienteFornecedor.Text = "Adicionar";
            this.btnAdicionarClienteFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarClienteFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionarClienteFornecedor.UseVisualStyleBackColor = false;
            this.btnAdicionarClienteFornecedor.Click += new System.EventHandler(this.BtnAdicionarClienteFornecedor_Click);
            // 
            // btnEditarClienteFornecedor
            // 
            this.btnEditarClienteFornecedor.AutoSize = true;
            this.btnEditarClienteFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarClienteFornecedor.FlatAppearance.BorderSize = 0;
            this.btnEditarClienteFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarClienteFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarClienteFornecedor.Image = global::PetShop.Properties.Resources.editar_list;
            this.btnEditarClienteFornecedor.Location = new System.Drawing.Point(936, 16);
            this.btnEditarClienteFornecedor.Name = "btnEditarClienteFornecedor";
            this.btnEditarClienteFornecedor.Size = new System.Drawing.Size(55, 55);
            this.btnEditarClienteFornecedor.TabIndex = 10;
            this.btnEditarClienteFornecedor.Text = "Editar";
            this.btnEditarClienteFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarClienteFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarClienteFornecedor.UseVisualStyleBackColor = false;
            this.btnEditarClienteFornecedor.Click += new System.EventHandler(this.BtnEditarClienteFornecedor_Click);
            // 
            // btnExcluirClienteFornecedor
            // 
            this.btnExcluirClienteFornecedor.AutoSize = true;
            this.btnExcluirClienteFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirClienteFornecedor.FlatAppearance.BorderSize = 0;
            this.btnExcluirClienteFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirClienteFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirClienteFornecedor.Image = global::PetShop.Properties.Resources.deletar_list;
            this.btnExcluirClienteFornecedor.Location = new System.Drawing.Point(997, 16);
            this.btnExcluirClienteFornecedor.Name = "btnExcluirClienteFornecedor";
            this.btnExcluirClienteFornecedor.Size = new System.Drawing.Size(61, 55);
            this.btnExcluirClienteFornecedor.TabIndex = 11;
            this.btnExcluirClienteFornecedor.Text = "Excluir";
            this.btnExcluirClienteFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirClienteFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirClienteFornecedor.UseVisualStyleBackColor = false;
            this.btnExcluirClienteFornecedor.Click += new System.EventHandler(this.BtnExcluirClienteFornecedor_Click);
            // 
            // btnImprimirClienteFornecedor
            // 
            this.btnImprimirClienteFornecedor.AutoSize = true;
            this.btnImprimirClienteFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirClienteFornecedor.FlatAppearance.BorderSize = 0;
            this.btnImprimirClienteFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirClienteFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirClienteFornecedor.Image = global::PetShop.Properties.Resources.imprimir_list;
            this.btnImprimirClienteFornecedor.Location = new System.Drawing.Point(1064, 14);
            this.btnImprimirClienteFornecedor.Name = "btnImprimirClienteFornecedor";
            this.btnImprimirClienteFornecedor.Size = new System.Drawing.Size(71, 57);
            this.btnImprimirClienteFornecedor.TabIndex = 12;
            this.btnImprimirClienteFornecedor.Text = "Imprimir";
            this.btnImprimirClienteFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimirClienteFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimirClienteFornecedor.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::PetShop.Properties.Resources.codigo_barras;
            this.button1.Location = new System.Drawing.Point(770, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 55);
            this.button1.TabIndex = 13;
            this.button1.Text = "CodBarras";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBoxEmEstoque
            // 
            this.pictureBoxEmEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(234)))), ((int)(((byte)(105)))));
            this.pictureBoxEmEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxEmEstoque.Location = new System.Drawing.Point(96, 16);
            this.pictureBoxEmEstoque.Name = "pictureBoxEmEstoque";
            this.pictureBoxEmEstoque.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxEmEstoque.TabIndex = 14;
            this.pictureBoxEmEstoque.TabStop = false;
            // 
            // labelEmEstoque
            // 
            this.labelEmEstoque.AutoSize = true;
            this.labelEmEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmEstoque.Location = new System.Drawing.Point(6, 16);
            this.labelEmEstoque.Name = "labelEmEstoque";
            this.labelEmEstoque.Size = new System.Drawing.Size(84, 16);
            this.labelEmEstoque.TabIndex = 11;
            this.labelEmEstoque.Text = "Em Estoque:";
            // 
            // labelBaixoEstoque
            // 
            this.labelBaixoEstoque.AutoSize = true;
            this.labelBaixoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaixoEstoque.Location = new System.Drawing.Point(140, 16);
            this.labelBaixoEstoque.Name = "labelBaixoEstoque";
            this.labelBaixoEstoque.Size = new System.Drawing.Size(98, 16);
            this.labelBaixoEstoque.TabIndex = 15;
            this.labelBaixoEstoque.Text = "Baixo Estoque:";
            // 
            // pictureBoxBaixoEstoque
            // 
            this.pictureBoxBaixoEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBoxBaixoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBaixoEstoque.Location = new System.Drawing.Point(244, 16);
            this.pictureBoxBaixoEstoque.Name = "pictureBoxBaixoEstoque";
            this.pictureBoxBaixoEstoque.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxBaixoEstoque.TabIndex = 16;
            this.pictureBoxBaixoEstoque.TabStop = false;
            // 
            // labelSemEstoque
            // 
            this.labelSemEstoque.AutoSize = true;
            this.labelSemEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemEstoque.Location = new System.Drawing.Point(296, 16);
            this.labelSemEstoque.Name = "labelSemEstoque";
            this.labelSemEstoque.Size = new System.Drawing.Size(92, 16);
            this.labelSemEstoque.TabIndex = 17;
            this.labelSemEstoque.Text = "Sem Estoque:";
            // 
            // pictureBoxSemEstoque
            // 
            this.pictureBoxSemEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(97)))));
            this.pictureBoxSemEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxSemEstoque.Location = new System.Drawing.Point(394, 16);
            this.pictureBoxSemEstoque.Name = "pictureBoxSemEstoque";
            this.pictureBoxSemEstoque.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxSemEstoque.TabIndex = 18;
            this.pictureBoxSemEstoque.TabStop = false;
            // 
            // groupBoxLegendaCores
            // 
            this.groupBoxLegendaCores.Controls.Add(this.pictureBox1);
            this.groupBoxLegendaCores.Controls.Add(this.labelEstoqueIndefinido);
            this.groupBoxLegendaCores.Controls.Add(this.labelEmEstoque);
            this.groupBoxLegendaCores.Controls.Add(this.pictureBoxSemEstoque);
            this.groupBoxLegendaCores.Controls.Add(this.pictureBoxEmEstoque);
            this.groupBoxLegendaCores.Controls.Add(this.labelSemEstoque);
            this.groupBoxLegendaCores.Controls.Add(this.labelBaixoEstoque);
            this.groupBoxLegendaCores.Controls.Add(this.pictureBoxBaixoEstoque);
            this.groupBoxLegendaCores.Location = new System.Drawing.Point(12, 666);
            this.groupBoxLegendaCores.Name = "groupBoxLegendaCores";
            this.groupBoxLegendaCores.Size = new System.Drawing.Size(578, 39);
            this.groupBoxLegendaCores.TabIndex = 19;
            this.groupBoxLegendaCores.TabStop = false;
            this.groupBoxLegendaCores.Text = "Legenda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(549, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // labelEstoqueIndefinido
            // 
            this.labelEstoqueIndefinido.AutoSize = true;
            this.labelEstoqueIndefinido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstoqueIndefinido.Location = new System.Drawing.Point(453, 16);
            this.labelEstoqueIndefinido.Name = "labelEstoqueIndefinido";
            this.labelEstoqueIndefinido.Size = new System.Drawing.Size(90, 16);
            this.labelEstoqueIndefinido.TabIndex = 19;
            this.labelEstoqueIndefinido.Text = "Não Definido:";
            // 
            // groupBoxFiltrar
            // 
            this.groupBoxFiltrar.Controls.Add(this.comboBoxFiltrarLista);
            this.groupBoxFiltrar.Controls.Add(this.label1);
            this.groupBoxFiltrar.Location = new System.Drawing.Point(814, 667);
            this.groupBoxFiltrar.Name = "groupBoxFiltrar";
            this.groupBoxFiltrar.Size = new System.Drawing.Size(327, 38);
            this.groupBoxFiltrar.TabIndex = 20;
            this.groupBoxFiltrar.TabStop = false;
            // 
            // comboBoxFiltrarLista
            // 
            this.comboBoxFiltrarLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltrarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltrarLista.FormattingEnabled = true;
            this.comboBoxFiltrarLista.Items.AddRange(new object[] {
            "Em Estoque",
            "Baixo Estoque",
            "Sem Estoque",
            "Não Definido",
            "Todos os Registros"});
            this.comboBoxFiltrarLista.Location = new System.Drawing.Point(110, 11);
            this.comboBoxFiltrarLista.Name = "comboBoxFiltrarLista";
            this.comboBoxFiltrarLista.Size = new System.Drawing.Size(211, 24);
            this.comboBoxFiltrarLista.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Filtrar Lista por:";
            // 
            // PesquisaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 716);
            this.Controls.Add(this.groupBoxFiltrar);
            this.Controls.Add(this.groupBoxLegendaCores);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImprimirClienteFornecedor);
            this.Controls.Add(this.btnExcluirClienteFornecedor);
            this.Controls.Add(this.btnEditarClienteFornecedor);
            this.Controls.Add(this.btnAdicionarClienteFornecedor);
            this.Controls.Add(this.groupBox_pesquisar_nome_cliente);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PesquisaProdutos";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Produtos";
            this.Load += new System.EventHandler(this.PesquisaProdutos_Load);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaProduto)).EndInit();
            this.groupBox_pesquisar_nome_cliente.ResumeLayout(false);
            this.groupBox_pesquisar_nome_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaixoEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSemEstoque)).EndInit();
            this.groupBoxLegendaCores.ResumeLayout(false);
            this.groupBoxLegendaCores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxFiltrar.ResumeLayout(false);
            this.groupBoxFiltrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox_pesquisar_nome_cliente;
        private System.Windows.Forms.TextBox textBoxPesquisarNomeProduto;
        private System.Windows.Forms.Label labelPesquisarProduto;
        private System.Windows.Forms.Label labelMarcaProduto;
        private System.Windows.Forms.TextBox textBoxPesquisarMarcaProduto;
        private System.Windows.Forms.Button btnAdicionarClienteFornecedor;
        private System.Windows.Forms.Button btnEditarClienteFornecedor;
        private System.Windows.Forms.Button btnExcluirClienteFornecedor;
        private System.Windows.Forms.Button btnImprimirClienteFornecedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxEmEstoque;
        private System.Windows.Forms.Label labelEmEstoque;
        private System.Windows.Forms.Label labelBaixoEstoque;
        private System.Windows.Forms.PictureBox pictureBoxBaixoEstoque;
        private System.Windows.Forms.Label labelSemEstoque;
        private System.Windows.Forms.PictureBox pictureBoxSemEstoque;
        private System.Windows.Forms.GroupBox groupBoxLegendaCores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelEstoqueIndefinido;
        private System.Windows.Forms.GroupBox groupBoxFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFiltrarLista;
        private System.Windows.Forms.DataGridView listaProduto;
    }
}