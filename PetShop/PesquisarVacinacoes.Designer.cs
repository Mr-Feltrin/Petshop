
namespace PetShop
{
    partial class PesquisarVacinacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarVacinacoes));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.listaVacinacao = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPesquisarCliente = new System.Windows.Forms.TextBox();
            this.txtPesquisarAnimal = new System.Windows.Forms.TextBox();
            this.dateDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dateDataInicial = new System.Windows.Forms.DateTimePicker();
            this.labelPesquisarProduto = new System.Windows.Forms.Label();
            this.btnExcluirVacinacao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdicionarVacinacao = new System.Windows.Forms.Button();
            this.btnImprimirLista = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaVacinacao)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.listaVacinacao);
            this.groupBox.Location = new System.Drawing.Point(12, 100);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(854, 428);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // listaVacinacao
            // 
            this.listaVacinacao.AllowUserToAddRows = false;
            this.listaVacinacao.AllowUserToDeleteRows = false;
            this.listaVacinacao.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listaVacinacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listaVacinacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaVacinacao.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaVacinacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listaVacinacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaVacinacao.DefaultCellStyle = dataGridViewCellStyle3;
            this.listaVacinacao.Location = new System.Drawing.Point(6, 11);
            this.listaVacinacao.MultiSelect = false;
            this.listaVacinacao.Name = "listaVacinacao";
            this.listaVacinacao.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaVacinacao.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listaVacinacao.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaVacinacao.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.listaVacinacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaVacinacao.Size = new System.Drawing.Size(842, 411);
            this.listaVacinacao.TabIndex = 3;
            this.listaVacinacao.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.listaVacinacao_RowStateChanged);
            this.listaVacinacao.SelectionChanged += new System.EventHandler(this.listaVacinacao_SelectionChanged);
            this.listaVacinacao.Sorted += new System.EventHandler(this.listaVacinacao_Sorted);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.46524F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.53476F));
            this.tableLayoutPanel1.Controls.Add(this.txtPesquisarCliente, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPesquisarAnimal, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateDataFinal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateDataInicial, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 29);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtPesquisarCliente
            // 
            this.txtPesquisarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarCliente.Location = new System.Drawing.Point(427, 3);
            this.txtPesquisarCliente.Name = "txtPesquisarCliente";
            this.txtPesquisarCliente.Size = new System.Drawing.Size(163, 22);
            this.txtPesquisarCliente.TabIndex = 18;
            this.txtPesquisarCliente.TextChanged += new System.EventHandler(this.txtPesquisarCliente_TextChanged);
            // 
            // txtPesquisarAnimal
            // 
            this.txtPesquisarAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarAnimal.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarAnimal.Location = new System.Drawing.Point(263, 3);
            this.txtPesquisarAnimal.Name = "txtPesquisarAnimal";
            this.txtPesquisarAnimal.Size = new System.Drawing.Size(158, 22);
            this.txtPesquisarAnimal.TabIndex = 17;
            this.txtPesquisarAnimal.TextChanged += new System.EventHandler(this.txtPesquisarAnimal_TextChanged);
            // 
            // dateDataFinal
            // 
            this.dateDataFinal.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataFinal.Location = new System.Drawing.Point(129, 3);
            this.dateDataFinal.Name = "dateDataFinal";
            this.dateDataFinal.Size = new System.Drawing.Size(128, 22);
            this.dateDataFinal.TabIndex = 16;
            this.dateDataFinal.ValueChanged += new System.EventHandler(this.dateDataFinal_ValueChanged);
            // 
            // dateDataInicial
            // 
            this.dateDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDataInicial.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataInicial.Location = new System.Drawing.Point(3, 3);
            this.dateDataInicial.Name = "dateDataInicial";
            this.dateDataInicial.Size = new System.Drawing.Size(120, 22);
            this.dateDataInicial.TabIndex = 15;
            this.dateDataInicial.ValueChanged += new System.EventHandler(this.dateDataInicial_ValueChanged);
            // 
            // labelPesquisarProduto
            // 
            this.labelPesquisarProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPesquisarProduto.AutoSize = true;
            this.labelPesquisarProduto.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisarProduto.Location = new System.Drawing.Point(3, 0);
            this.labelPesquisarProduto.Name = "labelPesquisarProduto";
            this.labelPesquisarProduto.Size = new System.Drawing.Size(83, 20);
            this.labelPesquisarProduto.TabIndex = 9;
            this.labelPesquisarProduto.Text = "Data Inicial";
            // 
            // btnExcluirVacinacao
            // 
            this.btnExcluirVacinacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirVacinacao.AutoSize = true;
            this.btnExcluirVacinacao.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirVacinacao.Enabled = false;
            this.btnExcluirVacinacao.FlatAppearance.BorderSize = 0;
            this.btnExcluirVacinacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirVacinacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirVacinacao.Image = global::PetShop.Properties.Resources.deletar_list;
            this.btnExcluirVacinacao.Location = new System.Drawing.Point(90, 15);
            this.btnExcluirVacinacao.Name = "btnExcluirVacinacao";
            this.btnExcluirVacinacao.Size = new System.Drawing.Size(61, 57);
            this.btnExcluirVacinacao.TabIndex = 19;
            this.btnExcluirVacinacao.Text = "Excluir";
            this.btnExcluirVacinacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirVacinacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirVacinacao.UseVisualStyleBackColor = false;
            this.btnExcluirVacinacao.Click += new System.EventHandler(this.btnExcluirVacinacao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 82);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.39759F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.60241F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelPesquisarProduto, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(593, 20);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pesquisar por Cliente";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pesquisar por Animal";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data Final";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnAdicionarVacinacao);
            this.groupBox2.Controls.Add(this.btnImprimirLista);
            this.groupBox2.Controls.Add(this.btnExcluirVacinacao);
            this.groupBox2.Location = new System.Drawing.Point(632, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 82);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // btnAdicionarVacinacao
            // 
            this.btnAdicionarVacinacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarVacinacao.AutoSize = true;
            this.btnAdicionarVacinacao.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarVacinacao.FlatAppearance.BorderSize = 0;
            this.btnAdicionarVacinacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarVacinacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarVacinacao.Image = global::PetShop.Properties.Resources.adicionar_list;
            this.btnAdicionarVacinacao.Location = new System.Drawing.Point(7, 15);
            this.btnAdicionarVacinacao.Name = "btnAdicionarVacinacao";
            this.btnAdicionarVacinacao.Size = new System.Drawing.Size(77, 57);
            this.btnAdicionarVacinacao.TabIndex = 12;
            this.btnAdicionarVacinacao.Text = "Adicionar";
            this.btnAdicionarVacinacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarVacinacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionarVacinacao.UseVisualStyleBackColor = false;
            this.btnAdicionarVacinacao.Click += new System.EventHandler(this.btnAdicionarVacinacao_Click);
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
            this.btnImprimirLista.Location = new System.Drawing.Point(157, 15);
            this.btnImprimirLista.Name = "btnImprimirLista";
            this.btnImprimirLista.Size = new System.Drawing.Size(71, 57);
            this.btnImprimirLista.TabIndex = 13;
            this.btnImprimirLista.Text = "Exportar";
            this.btnImprimirLista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimirLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimirLista.UseVisualStyleBackColor = false;
            this.btnImprimirLista.Click += new System.EventHandler(this.btnImprimirLista_Click);
            // 
            // PesquisarVacinacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(878, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(873, 231);
            this.Name = "PesquisarVacinacoes";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Vacinações";
            this.Load += new System.EventHandler(this.ListaVacinacoes_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PesquisarVacinacoes_KeyPress);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaVacinacao)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView listaVacinacao;
        private System.Windows.Forms.Label labelPesquisarProduto;
        private System.Windows.Forms.Button btnExcluirVacinacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnImprimirLista;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPesquisarCliente;
        private System.Windows.Forms.TextBox txtPesquisarAnimal;
        private System.Windows.Forms.DateTimePicker dateDataFinal;
        private System.Windows.Forms.DateTimePicker dateDataInicial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionarVacinacao;
    }
}