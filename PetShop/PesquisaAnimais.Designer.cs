namespace PetShop
{
    partial class PesquisaAnimais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaAnimais));
            this.groupBox_pesquisar_nome_cliente = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_pesquisar_cliente_nome = new System.Windows.Forms.Label();
            this.labelPesquisaNomeAnimal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pesquisaNomeDono = new System.Windows.Forms.TextBox();
            this.pesquisaNomeAnimal = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox_tabela_usuarios = new System.Windows.Forms.GroupBox();
            this.listaAnimais = new System.Windows.Forms.DataGridView();
            this.groupBox_pesquisar_nome_cliente.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_tabela_usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_pesquisar_nome_cliente
            // 
            this.groupBox_pesquisar_nome_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_pesquisar_nome_cliente.Controls.Add(this.tableLayoutPanel2);
            this.groupBox_pesquisar_nome_cliente.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_pesquisar_nome_cliente.Location = new System.Drawing.Point(14, 11);
            this.groupBox_pesquisar_nome_cliente.Name = "groupBox_pesquisar_nome_cliente";
            this.groupBox_pesquisar_nome_cliente.Size = new System.Drawing.Size(705, 65);
            this.groupBox_pesquisar_nome_cliente.TabIndex = 13;
            this.groupBox_pesquisar_nome_cliente.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.06701F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.93299F));
            this.tableLayoutPanel2.Controls.Add(this.Label_pesquisar_cliente_nome, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelPesquisaNomeAnimal, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 11);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(695, 19);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Label_pesquisar_cliente_nome
            // 
            this.Label_pesquisar_cliente_nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_pesquisar_cliente_nome.AutoSize = true;
            this.Label_pesquisar_cliente_nome.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_pesquisar_cliente_nome.Location = new System.Drawing.Point(3, 0);
            this.Label_pesquisar_cliente_nome.Name = "Label_pesquisar_cliente_nome";
            this.Label_pesquisar_cliente_nome.Size = new System.Drawing.Size(324, 19);
            this.Label_pesquisar_cliente_nome.TabIndex = 8;
            this.Label_pesquisar_cliente_nome.Text = "Pesquisar pelo Nome do Dono";
            // 
            // labelPesquisaNomeAnimal
            // 
            this.labelPesquisaNomeAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPesquisaNomeAnimal.AutoSize = true;
            this.labelPesquisaNomeAnimal.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisaNomeAnimal.Location = new System.Drawing.Point(341, 0);
            this.labelPesquisaNomeAnimal.Name = "labelPesquisaNomeAnimal";
            this.labelPesquisaNomeAnimal.Size = new System.Drawing.Size(351, 19);
            this.labelPesquisaNomeAnimal.TabIndex = 9;
            this.labelPesquisaNomeAnimal.Text = "Pesquisar pelo Nome do Animal";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.06701F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.93299F));
            this.tableLayoutPanel1.Controls.Add(this.pesquisaNomeDono, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pesquisaNomeAnimal, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 26);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pesquisaNomeDono
            // 
            this.pesquisaNomeDono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pesquisaNomeDono.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaNomeDono.Location = new System.Drawing.Point(3, 3);
            this.pesquisaNomeDono.Name = "pesquisaNomeDono";
            this.pesquisaNomeDono.Size = new System.Drawing.Size(323, 20);
            this.pesquisaNomeDono.TabIndex = 9;
            this.pesquisaNomeDono.TextChanged += new System.EventHandler(this.pesquisaNomeDono_TextChanged);
            // 
            // pesquisaNomeAnimal
            // 
            this.pesquisaNomeAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pesquisaNomeAnimal.Location = new System.Drawing.Point(340, 3);
            this.pesquisaNomeAnimal.Name = "pesquisaNomeAnimal";
            this.pesquisaNomeAnimal.Size = new System.Drawing.Size(350, 20);
            this.pesquisaNomeAnimal.TabIndex = 10;
            this.pesquisaNomeAnimal.TextChanged += new System.EventHandler(this.pesquisaNomeAnimal_TextChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::PetShop.Properties.Resources.imprimir_list;
            this.btnImprimir.Location = new System.Drawing.Point(951, 17);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(76, 63);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::PetShop.Properties.Resources.deletar_list;
            this.btnExcluir.Location = new System.Drawing.Point(884, 17);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(65, 63);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.AutoSize = true;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::PetShop.Properties.Resources.editar_list;
            this.btnEditar.Location = new System.Drawing.Point(822, 17);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(60, 63);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.AutoSize = true;
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = global::PetShop.Properties.Resources.adicionar_list;
            this.btnAdicionar.Location = new System.Drawing.Point(735, 17);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(83, 63);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionarClienteFornecedor_Click);
            // 
            // groupBox_tabela_usuarios
            // 
            this.groupBox_tabela_usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_tabela_usuarios.Controls.Add(this.listaAnimais);
            this.groupBox_tabela_usuarios.Location = new System.Drawing.Point(12, 86);
            this.groupBox_tabela_usuarios.Name = "groupBox_tabela_usuarios";
            this.groupBox_tabela_usuarios.Size = new System.Drawing.Size(1015, 618);
            this.groupBox_tabela_usuarios.TabIndex = 8;
            this.groupBox_tabela_usuarios.TabStop = false;
            // 
            // listaAnimais
            // 
            this.listaAnimais.AllowUserToAddRows = false;
            this.listaAnimais.AllowUserToDeleteRows = false;
            this.listaAnimais.AllowUserToResizeRows = false;
            this.listaAnimais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaAnimais.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaAnimais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaAnimais.DefaultCellStyle = dataGridViewCellStyle2;
            this.listaAnimais.Location = new System.Drawing.Point(6, 10);
            this.listaAnimais.MultiSelect = false;
            this.listaAnimais.Name = "listaAnimais";
            this.listaAnimais.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaAnimais.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listaAnimais.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaAnimais.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.listaAnimais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaAnimais.Size = new System.Drawing.Size(1003, 602);
            this.listaAnimais.TabIndex = 2;
            this.listaAnimais.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaAnimais_CellDoubleClick);
            this.listaAnimais.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.listaAnimais_ColumnWidthChanged);
            this.listaAnimais.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.listaAnimais_RowStateChanged);
            this.listaAnimais.SelectionChanged += new System.EventHandler(this.listaAnimais_SelectionChanged);
            this.listaAnimais.Sorted += new System.EventHandler(this.listaAnimais_Sorted);
            // 
            // PesquisaAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 716);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.groupBox_pesquisar_nome_cliente);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupBox_tabela_usuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(805, 226);
            this.Name = "PesquisaAnimais";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Animais Cadastrados";
            this.Load += new System.EventHandler(this.PesquisaAnimais_Load);
            this.groupBox_pesquisar_nome_cliente.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox_tabela_usuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaAnimais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_pesquisar_nome_cliente;
        private System.Windows.Forms.TextBox pesquisaNomeDono;
        private System.Windows.Forms.Label Label_pesquisar_cliente_nome;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox groupBox_tabela_usuarios;
        private System.Windows.Forms.Label labelPesquisaNomeAnimal;
        private System.Windows.Forms.TextBox pesquisaNomeAnimal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView listaAnimais;
    }
}