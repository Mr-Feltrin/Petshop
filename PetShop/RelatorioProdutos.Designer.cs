
namespace PetShop
{
    partial class RelatorioProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioProdutos));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateDataInicial = new System.Windows.Forms.DateTimePicker();
            this.txtPesquisarProduto = new System.Windows.Forms.TextBox();
            this.dateDataFinal = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimirLista = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboFiltrarEntradaSaida = new PetShop.ToolBox.Controls.ComboBoxFlatBordered();
            this.groupBoxLegendaCores = new System.Windows.Forms.GroupBox();
            this.labelEmEstoque = new System.Windows.Forms.Label();
            this.pictureBoxSemEstoque = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmEstoque = new System.Windows.Forms.PictureBox();
            this.labelSemEstoque = new System.Windows.Forms.Label();
            this.DGVRelatorioProdutos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxLegendaCores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSemEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRelatorioProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.9404F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.9404F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.8808F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.23841F));
            this.tableLayoutPanel1.Controls.Add(this.dateDataInicial, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPesquisarProduto, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateDataFinal, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboFiltrarEntradaSaida, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(815, 37);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dateDataInicial
            // 
            this.dateDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDataInicial.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataInicial.Location = new System.Drawing.Point(3, 6);
            this.dateDataInicial.Name = "dateDataInicial";
            this.dateDataInicial.Size = new System.Drawing.Size(137, 25);
            this.dateDataInicial.TabIndex = 0;
            this.dateDataInicial.ValueChanged += new System.EventHandler(this.dateDataInicial_ValueChanged);
            // 
            // txtPesquisarProduto
            // 
            this.txtPesquisarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarProduto.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarProduto.Location = new System.Drawing.Point(484, 6);
            this.txtPesquisarProduto.Name = "txtPesquisarProduto";
            this.txtPesquisarProduto.Size = new System.Drawing.Size(328, 25);
            this.txtPesquisarProduto.TabIndex = 3;
            this.txtPesquisarProduto.TextChanged += new System.EventHandler(this.txtPesquisarProduto_TextChanged);
            // 
            // dateDataFinal
            // 
            this.dateDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDataFinal.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataFinal.Location = new System.Drawing.Point(166, 6);
            this.dateDataFinal.Name = "dateDataFinal";
            this.dateDataFinal.Size = new System.Drawing.Size(137, 25);
            this.dateDataFinal.TabIndex = 1;
            this.dateDataFinal.ValueChanged += new System.EventHandler(this.dateDataFinal_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.btnImprimirLista);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.11765F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.11765F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.04813F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.71658F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(808, 26);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pesquisar Nome do Produto";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filtrar I/O";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Final";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Inicial";
            // 
            // btnImprimirLista
            // 
            this.btnImprimirLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirLista.AutoSize = true;
            this.btnImprimirLista.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirLista.Enabled = false;
            this.btnImprimirLista.FlatAppearance.BorderSize = 0;
            this.btnImprimirLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirLista.Image = global::PetShop.Properties.Resources.imprimir_list;
            this.btnImprimirLista.Location = new System.Drawing.Point(835, 15);
            this.btnImprimirLista.Name = "btnImprimirLista";
            this.btnImprimirLista.Size = new System.Drawing.Size(71, 57);
            this.btnImprimirLista.TabIndex = 1;
            this.btnImprimirLista.Text = "Exportar";
            this.btnImprimirLista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimirLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimirLista.UseVisualStyleBackColor = false;
            this.btnImprimirLista.Click += new System.EventHandler(this.btnImprimirLista_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DGVRelatorioProdutos);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(912, 447);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // comboFiltrarEntradaSaida
            // 
            this.comboFiltrarEntradaSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFiltrarEntradaSaida.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboFiltrarEntradaSaida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltrarEntradaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboFiltrarEntradaSaida.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFiltrarEntradaSaida.FormattingEnabled = true;
            this.comboFiltrarEntradaSaida.Items.AddRange(new object[] {
            "Entrada",
            "Saída",
            "Todos"});
            this.comboFiltrarEntradaSaida.Location = new System.Drawing.Point(329, 4);
            this.comboFiltrarEntradaSaida.Name = "comboFiltrarEntradaSaida";
            this.comboFiltrarEntradaSaida.Size = new System.Drawing.Size(129, 28);
            this.comboFiltrarEntradaSaida.TabIndex = 2;
            this.comboFiltrarEntradaSaida.SelectedIndexChanged += new System.EventHandler(this.comboFiltrarEntradaSaida_SelectedIndexChanged);
            // 
            // groupBoxLegendaCores
            // 
            this.groupBoxLegendaCores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxLegendaCores.Controls.Add(this.labelEmEstoque);
            this.groupBoxLegendaCores.Controls.Add(this.pictureBoxSemEstoque);
            this.groupBoxLegendaCores.Controls.Add(this.pictureBoxEmEstoque);
            this.groupBoxLegendaCores.Controls.Add(this.labelSemEstoque);
            this.groupBoxLegendaCores.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLegendaCores.Location = new System.Drawing.Point(12, 545);
            this.groupBoxLegendaCores.Name = "groupBoxLegendaCores";
            this.groupBoxLegendaCores.Size = new System.Drawing.Size(201, 44);
            this.groupBoxLegendaCores.TabIndex = 8;
            this.groupBoxLegendaCores.TabStop = false;
            this.groupBoxLegendaCores.Text = "Legenda";
            // 
            // labelEmEstoque
            // 
            this.labelEmEstoque.AutoSize = true;
            this.labelEmEstoque.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmEstoque.Location = new System.Drawing.Point(6, 17);
            this.labelEmEstoque.Name = "labelEmEstoque";
            this.labelEmEstoque.Size = new System.Drawing.Size(63, 20);
            this.labelEmEstoque.TabIndex = 0;
            this.labelEmEstoque.Text = "Entrada:";
            // 
            // pictureBoxSemEstoque
            // 
            this.pictureBoxSemEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(97)))));
            this.pictureBoxSemEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxSemEstoque.Location = new System.Drawing.Point(168, 19);
            this.pictureBoxSemEstoque.Name = "pictureBoxSemEstoque";
            this.pictureBoxSemEstoque.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxSemEstoque.TabIndex = 18;
            this.pictureBoxSemEstoque.TabStop = false;
            // 
            // pictureBoxEmEstoque
            // 
            this.pictureBoxEmEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(234)))), ((int)(((byte)(105)))));
            this.pictureBoxEmEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxEmEstoque.Location = new System.Drawing.Point(75, 19);
            this.pictureBoxEmEstoque.Name = "pictureBoxEmEstoque";
            this.pictureBoxEmEstoque.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxEmEstoque.TabIndex = 14;
            this.pictureBoxEmEstoque.TabStop = false;
            // 
            // labelSemEstoque
            // 
            this.labelSemEstoque.AutoSize = true;
            this.labelSemEstoque.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemEstoque.Location = new System.Drawing.Point(112, 17);
            this.labelSemEstoque.Name = "labelSemEstoque";
            this.labelSemEstoque.Size = new System.Drawing.Size(50, 20);
            this.labelSemEstoque.TabIndex = 2;
            this.labelSemEstoque.Text = "Saída:";
            // 
            // DGVRelatorioProdutos
            // 
            this.DGVRelatorioProdutos.AllowUserToAddRows = false;
            this.DGVRelatorioProdutos.AllowUserToDeleteRows = false;
            this.DGVRelatorioProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVRelatorioProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVRelatorioProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVRelatorioProdutos.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRelatorioProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVRelatorioProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVRelatorioProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVRelatorioProdutos.Location = new System.Drawing.Point(6, 12);
            this.DGVRelatorioProdutos.MultiSelect = false;
            this.DGVRelatorioProdutos.Name = "DGVRelatorioProdutos";
            this.DGVRelatorioProdutos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRelatorioProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVRelatorioProdutos.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVRelatorioProdutos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVRelatorioProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVRelatorioProdutos.ShowCellToolTips = false;
            this.DGVRelatorioProdutos.ShowEditingIcon = false;
            this.DGVRelatorioProdutos.Size = new System.Drawing.Size(900, 429);
            this.DGVRelatorioProdutos.TabIndex = 1;
            this.DGVRelatorioProdutos.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DGVRelatorioProdutos_RowPrePaint);
            this.DGVRelatorioProdutos.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DGVRelatorioProdutos_RowStateChanged);
            this.DGVRelatorioProdutos.Sorted += new System.EventHandler(this.DGVRelatorioProdutos_Sorted);
            // 
            // RelatorioProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(936, 598);
            this.Controls.Add(this.groupBoxLegendaCores);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelatorioProdutos";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Produtos";
            this.Load += new System.EventHandler(this.RelatorioProdutos_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RelatorioProdutos_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxLegendaCores.ResumeLayout(false);
            this.groupBoxLegendaCores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSemEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRelatorioProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateDataInicial;
        private System.Windows.Forms.DateTimePicker dateDataFinal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisarProduto;
        private ToolBox.Controls.ComboBoxFlatBordered comboFiltrarEntradaSaida;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimirLista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxLegendaCores;
        private System.Windows.Forms.Label labelEmEstoque;
        private System.Windows.Forms.PictureBox pictureBoxSemEstoque;
        private System.Windows.Forms.PictureBox pictureBoxEmEstoque;
        private System.Windows.Forms.Label labelSemEstoque;
        private System.Windows.Forms.DataGridView DGVRelatorioProdutos;
    }
}