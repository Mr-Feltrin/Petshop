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
            this.DataGridListaProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox_pesquisar_nome_cliente = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPesquisarMarcaProduto = new System.Windows.Forms.TextBox();
            this.txtPesquisarNomeProduto = new System.Windows.Forms.TextBox();
            this.labelMarcaProduto = new System.Windows.Forms.Label();
            this.labelPesquisarProduto = new System.Windows.Forms.Label();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnImprimirLista = new System.Windows.Forms.Button();
            this.btnCodigoBarras = new System.Windows.Forms.Button();
            this.pictureBoxEmEstoque = new System.Windows.Forms.PictureBox();
            this.labelEmEstoque = new System.Windows.Forms.Label();
            this.labelBaixoEstoque = new System.Windows.Forms.Label();
            this.pictureBoxBaixoEstoque = new System.Windows.Forms.PictureBox();
            this.labelSemEstoque = new System.Windows.Forms.Label();
            this.pictureBoxSemEstoque = new System.Windows.Forms.PictureBox();
            this.groupBoxLegendaCores = new System.Windows.Forms.GroupBox();
            this.groupBoxFiltrar = new System.Windows.Forms.GroupBox();
            this.comboBoxFiltrarLista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListaProdutos)).BeginInit();
            this.groupBox_pesquisar_nome_cliente.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaixoEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSemEstoque)).BeginInit();
            this.groupBoxLegendaCores.SuspendLayout();
            this.groupBoxFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.DataGridListaProdutos);
            this.groupBox.Location = new System.Drawing.Point(12, 89);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1129, 571);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // DataGridListaProdutos
            // 
            this.DataGridListaProdutos.AllowUserToAddRows = false;
            this.DataGridListaProdutos.AllowUserToDeleteRows = false;
            this.DataGridListaProdutos.AllowUserToResizeColumns = false;
            this.DataGridListaProdutos.AllowUserToResizeRows = false;
            this.DataGridListaProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridListaProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridListaProdutos.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridListaProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridListaProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridListaProdutos.Location = new System.Drawing.Point(6, 10);
            this.DataGridListaProdutos.MultiSelect = false;
            this.DataGridListaProdutos.Name = "DataGridListaProdutos";
            this.DataGridListaProdutos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridListaProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridListaProdutos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridListaProdutos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridListaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridListaProdutos.Size = new System.Drawing.Size(1117, 555);
            this.DataGridListaProdutos.TabIndex = 3;
            this.DataGridListaProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridListaProdutos_CellDoubleClick);
            this.DataGridListaProdutos.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridListaProdutos_RowPrePaint);
            this.DataGridListaProdutos.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DataGridListaProdutos_RowStateChanged);
            this.DataGridListaProdutos.SelectionChanged += new System.EventHandler(this.DataGridListaProdutos_SelectionChanged);
            this.DataGridListaProdutos.Sorted += new System.EventHandler(this.DataGridListaProdutos_Sorted);
            // 
            // groupBox_pesquisar_nome_cliente
            // 
            this.groupBox_pesquisar_nome_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_pesquisar_nome_cliente.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_pesquisar_nome_cliente.Controls.Add(this.labelMarcaProduto);
            this.groupBox_pesquisar_nome_cliente.Controls.Add(this.labelPesquisarProduto);
            this.groupBox_pesquisar_nome_cliente.Location = new System.Drawing.Point(12, 12);
            this.groupBox_pesquisar_nome_cliente.Name = "groupBox_pesquisar_nome_cliente";
            this.groupBox_pesquisar_nome_cliente.Size = new System.Drawing.Size(752, 71);
            this.groupBox_pesquisar_nome_cliente.TabIndex = 8;
            this.groupBox_pesquisar_nome_cliente.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 479F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 259F));
            this.tableLayoutPanel1.Controls.Add(this.txtPesquisarMarcaProduto, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPesquisarNomeProduto, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(746, 26);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtPesquisarMarcaProduto
            // 
            this.txtPesquisarMarcaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarMarcaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarMarcaProduto.Location = new System.Drawing.Point(490, 3);
            this.txtPesquisarMarcaProduto.Name = "txtPesquisarMarcaProduto";
            this.txtPesquisarMarcaProduto.Size = new System.Drawing.Size(253, 21);
            this.txtPesquisarMarcaProduto.TabIndex = 11;
            this.txtPesquisarMarcaProduto.TextChanged += new System.EventHandler(this.txtPesquisarMarcaProduto_TextChanged);
            // 
            // txtPesquisarNomeProduto
            // 
            this.txtPesquisarNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarNomeProduto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarNomeProduto.Location = new System.Drawing.Point(3, 3);
            this.txtPesquisarNomeProduto.Name = "txtPesquisarNomeProduto";
            this.txtPesquisarNomeProduto.Size = new System.Drawing.Size(473, 21);
            this.txtPesquisarNomeProduto.TabIndex = 10;
            this.txtPesquisarNomeProduto.TextChanged += new System.EventHandler(this.txtPesquisarNomeProduto_TextChanged);
            // 
            // labelMarcaProduto
            // 
            this.labelMarcaProduto.AutoSize = true;
            this.labelMarcaProduto.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarcaProduto.Location = new System.Drawing.Point(489, 12);
            this.labelMarcaProduto.Name = "labelMarcaProduto";
            this.labelMarcaProduto.Size = new System.Drawing.Size(192, 20);
            this.labelMarcaProduto.TabIndex = 9;
            this.labelMarcaProduto.Text = "Pesquisar Marca do Produto";
            // 
            // labelPesquisarProduto
            // 
            this.labelPesquisarProduto.AutoSize = true;
            this.labelPesquisarProduto.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisarProduto.Location = new System.Drawing.Point(2, 12);
            this.labelPesquisarProduto.Name = "labelPesquisarProduto";
            this.labelPesquisarProduto.Size = new System.Drawing.Size(189, 20);
            this.labelPesquisarProduto.TabIndex = 8;
            this.labelPesquisarProduto.Text = "Pesquisar Nome do Produto";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarProduto.AutoSize = true;
            this.btnAdicionarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.FlatAppearance.BorderSize = 0;
            this.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProduto.Image = global::PetShop.Properties.Resources.adicionar_list;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(853, 24);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(77, 57);
            this.btnAdicionarProduto.TabIndex = 9;
            this.btnAdicionarProduto.Text = "Adicionar";
            this.btnAdicionarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionarProduto.UseVisualStyleBackColor = false;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarProduto.AutoSize = true;
            this.btnEditarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarProduto.Enabled = false;
            this.btnEditarProduto.FlatAppearance.BorderSize = 0;
            this.btnEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProduto.Image = global::PetShop.Properties.Resources.editar_list;
            this.btnEditarProduto.Location = new System.Drawing.Point(936, 24);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(55, 57);
            this.btnEditarProduto.TabIndex = 10;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarProduto.UseVisualStyleBackColor = false;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirProduto.AutoSize = true;
            this.btnExcluirProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirProduto.Enabled = false;
            this.btnExcluirProduto.FlatAppearance.BorderSize = 0;
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduto.Image = global::PetShop.Properties.Resources.deletar_list;
            this.btnExcluirProduto.Location = new System.Drawing.Point(997, 24);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(61, 57);
            this.btnExcluirProduto.TabIndex = 11;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirProduto.UseVisualStyleBackColor = false;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnImprimirLista
            // 
            this.btnImprimirLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirLista.AutoSize = true;
            this.btnImprimirLista.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirLista.FlatAppearance.BorderSize = 0;
            this.btnImprimirLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirLista.Image = global::PetShop.Properties.Resources.imprimir_list;
            this.btnImprimirLista.Location = new System.Drawing.Point(1064, 24);
            this.btnImprimirLista.Name = "btnImprimirLista";
            this.btnImprimirLista.Size = new System.Drawing.Size(71, 57);
            this.btnImprimirLista.TabIndex = 12;
            this.btnImprimirLista.Text = "Exportar";
            this.btnImprimirLista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimirLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimirLista.UseVisualStyleBackColor = false;
            this.btnImprimirLista.Click += new System.EventHandler(this.btnImprimirLista_Click);
            // 
            // btnCodigoBarras
            // 
            this.btnCodigoBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCodigoBarras.AutoSize = true;
            this.btnCodigoBarras.BackColor = System.Drawing.Color.Transparent;
            this.btnCodigoBarras.FlatAppearance.BorderSize = 0;
            this.btnCodigoBarras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodigoBarras.Image = global::PetShop.Properties.Resources.codigo_barras;
            this.btnCodigoBarras.Location = new System.Drawing.Point(770, 24);
            this.btnCodigoBarras.Name = "btnCodigoBarras";
            this.btnCodigoBarras.Size = new System.Drawing.Size(84, 57);
            this.btnCodigoBarras.TabIndex = 13;
            this.btnCodigoBarras.Text = "CodBarras";
            this.btnCodigoBarras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCodigoBarras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCodigoBarras.UseVisualStyleBackColor = false;
            this.btnCodigoBarras.Click += new System.EventHandler(this.btnCodigoBarras_Click);
            // 
            // pictureBoxEmEstoque
            // 
            this.pictureBoxEmEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(234)))), ((int)(((byte)(105)))));
            this.pictureBoxEmEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxEmEstoque.Location = new System.Drawing.Point(103, 16);
            this.pictureBoxEmEstoque.Name = "pictureBoxEmEstoque";
            this.pictureBoxEmEstoque.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxEmEstoque.TabIndex = 14;
            this.pictureBoxEmEstoque.TabStop = false;
            // 
            // labelEmEstoque
            // 
            this.labelEmEstoque.AutoSize = true;
            this.labelEmEstoque.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmEstoque.Location = new System.Drawing.Point(6, 13);
            this.labelEmEstoque.Name = "labelEmEstoque";
            this.labelEmEstoque.Size = new System.Drawing.Size(89, 20);
            this.labelEmEstoque.TabIndex = 11;
            this.labelEmEstoque.Text = "Em Estoque:";
            // 
            // labelBaixoEstoque
            // 
            this.labelBaixoEstoque.AutoSize = true;
            this.labelBaixoEstoque.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaixoEstoque.Location = new System.Drawing.Point(140, 13);
            this.labelBaixoEstoque.Name = "labelBaixoEstoque";
            this.labelBaixoEstoque.Size = new System.Drawing.Size(105, 20);
            this.labelBaixoEstoque.TabIndex = 15;
            this.labelBaixoEstoque.Text = "Baixo Estoque:";
            // 
            // pictureBoxBaixoEstoque
            // 
            this.pictureBoxBaixoEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBoxBaixoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBaixoEstoque.Location = new System.Drawing.Point(251, 16);
            this.pictureBoxBaixoEstoque.Name = "pictureBoxBaixoEstoque";
            this.pictureBoxBaixoEstoque.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxBaixoEstoque.TabIndex = 16;
            this.pictureBoxBaixoEstoque.TabStop = false;
            // 
            // labelSemEstoque
            // 
            this.labelSemEstoque.AutoSize = true;
            this.labelSemEstoque.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemEstoque.Location = new System.Drawing.Point(296, 13);
            this.labelSemEstoque.Name = "labelSemEstoque";
            this.labelSemEstoque.Size = new System.Drawing.Size(98, 20);
            this.labelSemEstoque.TabIndex = 17;
            this.labelSemEstoque.Text = "Sem Estoque:";
            // 
            // pictureBoxSemEstoque
            // 
            this.pictureBoxSemEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(97)))));
            this.pictureBoxSemEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxSemEstoque.Location = new System.Drawing.Point(401, 16);
            this.pictureBoxSemEstoque.Name = "pictureBoxSemEstoque";
            this.pictureBoxSemEstoque.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxSemEstoque.TabIndex = 18;
            this.pictureBoxSemEstoque.TabStop = false;
            // 
            // groupBoxLegendaCores
            // 
            this.groupBoxLegendaCores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxLegendaCores.Controls.Add(this.labelEmEstoque);
            this.groupBoxLegendaCores.Controls.Add(this.pictureBoxSemEstoque);
            this.groupBoxLegendaCores.Controls.Add(this.pictureBoxEmEstoque);
            this.groupBoxLegendaCores.Controls.Add(this.labelSemEstoque);
            this.groupBoxLegendaCores.Controls.Add(this.labelBaixoEstoque);
            this.groupBoxLegendaCores.Controls.Add(this.pictureBoxBaixoEstoque);
            this.groupBoxLegendaCores.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLegendaCores.Location = new System.Drawing.Point(12, 666);
            this.groupBoxLegendaCores.Name = "groupBoxLegendaCores";
            this.groupBoxLegendaCores.Size = new System.Drawing.Size(428, 39);
            this.groupBoxLegendaCores.TabIndex = 19;
            this.groupBoxLegendaCores.TabStop = false;
            this.groupBoxLegendaCores.Text = "Legenda";
            // 
            // groupBoxFiltrar
            // 
            this.groupBoxFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFiltrar.Controls.Add(this.comboBoxFiltrarLista);
            this.groupBoxFiltrar.Controls.Add(this.label1);
            this.groupBoxFiltrar.Location = new System.Drawing.Point(814, 666);
            this.groupBoxFiltrar.Name = "groupBoxFiltrar";
            this.groupBoxFiltrar.Size = new System.Drawing.Size(327, 39);
            this.groupBoxFiltrar.TabIndex = 20;
            this.groupBoxFiltrar.TabStop = false;
            // 
            // comboBoxFiltrarLista
            // 
            this.comboBoxFiltrarLista.DisplayMember = "1";
            this.comboBoxFiltrarLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltrarLista.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltrarLista.FormattingEnabled = true;
            this.comboBoxFiltrarLista.Items.AddRange(new object[] {
            "Em Estoque",
            "Baixo Estoque",
            "Sem Estoque",
            "Todos os Registros"});
            this.comboBoxFiltrarLista.Location = new System.Drawing.Point(110, 10);
            this.comboBoxFiltrarLista.Name = "comboBoxFiltrarLista";
            this.comboBoxFiltrarLista.Size = new System.Drawing.Size(211, 25);
            this.comboBoxFiltrarLista.TabIndex = 19;
            this.comboBoxFiltrarLista.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltrarLista_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
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
            this.Controls.Add(this.btnCodigoBarras);
            this.Controls.Add(this.btnImprimirLista);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.groupBox_pesquisar_nome_cliente);
            this.Controls.Add(this.groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1106, 444);
            this.Name = "PesquisaProdutos";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Produtos";
            this.Load += new System.EventHandler(this.PesquisaProdutos_Load);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListaProdutos)).EndInit();
            this.groupBox_pesquisar_nome_cliente.ResumeLayout(false);
            this.groupBox_pesquisar_nome_cliente.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBaixoEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSemEstoque)).EndInit();
            this.groupBoxLegendaCores.ResumeLayout(false);
            this.groupBoxLegendaCores.PerformLayout();
            this.groupBoxFiltrar.ResumeLayout(false);
            this.groupBoxFiltrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox_pesquisar_nome_cliente;
        private System.Windows.Forms.Label labelPesquisarProduto;
        private System.Windows.Forms.Label labelMarcaProduto;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnImprimirLista;
        private System.Windows.Forms.Button btnCodigoBarras;
        private System.Windows.Forms.PictureBox pictureBoxEmEstoque;
        private System.Windows.Forms.Label labelEmEstoque;
        private System.Windows.Forms.Label labelBaixoEstoque;
        private System.Windows.Forms.PictureBox pictureBoxBaixoEstoque;
        private System.Windows.Forms.Label labelSemEstoque;
        private System.Windows.Forms.PictureBox pictureBoxSemEstoque;
        private System.Windows.Forms.GroupBox groupBoxLegendaCores;
        private System.Windows.Forms.GroupBox groupBoxFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFiltrarLista;
        private System.Windows.Forms.TextBox txtPesquisarNomeProduto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPesquisarMarcaProduto;
        private System.Windows.Forms.DataGridView DataGridListaProdutos;
    }
}