
namespace PetShop
{
    partial class PesquisarVacinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarVacinas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPesquisarMarca = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataListaEspecieRaca = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.combBoxTipo = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExportarLista = new System.Windows.Forms.Button();
            this.btnExcluirVacina = new System.Windows.Forms.Button();
            this.btnEditarVacina = new System.Windows.Forms.Button();
            this.btnAdicionarVacina = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaEspecieRaca)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataListaEspecieRaca);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 431);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // labelPesquisarMarca
            // 
            this.labelPesquisarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPesquisarMarca.AutoSize = true;
            this.labelPesquisarMarca.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisarMarca.Location = new System.Drawing.Point(313, 0);
            this.labelPesquisarMarca.Name = "labelPesquisarMarca";
            this.labelPesquisarMarca.Size = new System.Drawing.Size(219, 21);
            this.labelPesquisarMarca.TabIndex = 14;
            this.labelPesquisarMarca.Text = "Pesquisar pela Marca";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.44725F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.55275F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelPesquisarMarca, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(535, 21);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // dataListaEspecieRaca
            // 
            this.dataListaEspecieRaca.AllowUserToAddRows = false;
            this.dataListaEspecieRaca.AllowUserToDeleteRows = false;
            this.dataListaEspecieRaca.AllowUserToResizeColumns = false;
            this.dataListaEspecieRaca.AllowUserToResizeRows = false;
            this.dataListaEspecieRaca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListaEspecieRaca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListaEspecieRaca.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataListaEspecieRaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataListaEspecieRaca.Location = new System.Drawing.Point(6, 15);
            this.dataListaEspecieRaca.MultiSelect = false;
            this.dataListaEspecieRaca.Name = "dataListaEspecieRaca";
            this.dataListaEspecieRaca.ReadOnly = true;
            this.dataListaEspecieRaca.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListaEspecieRaca.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListaEspecieRaca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListaEspecieRaca.Size = new System.Drawing.Size(836, 410);
            this.dataListaEspecieRaca.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.44725F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.55275F));
            this.tableLayoutPanel1.Controls.Add(this.combBoxTipo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMarca, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 30);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // combBoxTipo
            // 
            this.combBoxTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combBoxTipo.FormattingEnabled = true;
            this.combBoxTipo.Location = new System.Drawing.Point(3, 3);
            this.combBoxTipo.Name = "combBoxTipo";
            this.combBoxTipo.Size = new System.Drawing.Size(296, 23);
            this.combBoxTipo.TabIndex = 14;
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(313, 3);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(219, 21);
            this.txtMarca.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.btnExportarLista);
            this.groupBox2.Controls.Add(this.btnExcluirVacina);
            this.groupBox2.Controls.Add(this.btnEditarVacina);
            this.groupBox2.Controls.Add(this.btnAdicionarVacina);
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 84);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnExportarLista
            // 
            this.btnExportarLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarLista.AutoSize = true;
            this.btnExportarLista.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarLista.FlatAppearance.BorderSize = 0;
            this.btnExportarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarLista.Image = global::PetShop.Properties.Resources.imprimir_list;
            this.btnExportarLista.Location = new System.Drawing.Point(771, 19);
            this.btnExportarLista.Name = "btnExportarLista";
            this.btnExportarLista.Size = new System.Drawing.Size(71, 57);
            this.btnExportarLista.TabIndex = 13;
            this.btnExportarLista.Text = "Exportar";
            this.btnExportarLista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportarLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportarLista.UseVisualStyleBackColor = false;
            // 
            // btnExcluirVacina
            // 
            this.btnExcluirVacina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirVacina.AutoSize = true;
            this.btnExcluirVacina.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirVacina.Enabled = false;
            this.btnExcluirVacina.FlatAppearance.BorderSize = 0;
            this.btnExcluirVacina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirVacina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirVacina.Image = global::PetShop.Properties.Resources.deletar_list;
            this.btnExcluirVacina.Location = new System.Drawing.Point(704, 19);
            this.btnExcluirVacina.Name = "btnExcluirVacina";
            this.btnExcluirVacina.Size = new System.Drawing.Size(61, 57);
            this.btnExcluirVacina.TabIndex = 12;
            this.btnExcluirVacina.Text = "Excluir";
            this.btnExcluirVacina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirVacina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluirVacina.UseVisualStyleBackColor = false;
            // 
            // btnEditarVacina
            // 
            this.btnEditarVacina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarVacina.AutoSize = true;
            this.btnEditarVacina.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarVacina.Enabled = false;
            this.btnEditarVacina.FlatAppearance.BorderSize = 0;
            this.btnEditarVacina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarVacina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarVacina.Image = global::PetShop.Properties.Resources.editar_list;
            this.btnEditarVacina.Location = new System.Drawing.Point(643, 19);
            this.btnEditarVacina.Name = "btnEditarVacina";
            this.btnEditarVacina.Size = new System.Drawing.Size(55, 57);
            this.btnEditarVacina.TabIndex = 11;
            this.btnEditarVacina.Text = "Editar";
            this.btnEditarVacina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarVacina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarVacina.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarVacina
            // 
            this.btnAdicionarVacina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarVacina.AutoSize = true;
            this.btnAdicionarVacina.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarVacina.FlatAppearance.BorderSize = 0;
            this.btnAdicionarVacina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarVacina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarVacina.Image = global::PetShop.Properties.Resources.adicionar_list;
            this.btnAdicionarVacina.Location = new System.Drawing.Point(560, 19);
            this.btnAdicionarVacina.Name = "btnAdicionarVacina";
            this.btnAdicionarVacina.Size = new System.Drawing.Size(77, 57);
            this.btnAdicionarVacina.TabIndex = 10;
            this.btnAdicionarVacina.Text = "Adicionar";
            this.btnAdicionarVacina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarVacina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionarVacina.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pesquisar pela Marca";
            // 
            // PesquisarVacinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(733, 577);
            this.Name = "PesquisarVacinas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de vacinas";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaEspecieRaca)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdicionarVacina;
        private System.Windows.Forms.Button btnEditarVacina;
        private System.Windows.Forms.Button btnExcluirVacina;
        private System.Windows.Forms.Button btnExportarLista;
        private System.Windows.Forms.ComboBox combBoxTipo;
        private System.Windows.Forms.DataGridView dataListaEspecieRaca;
        private System.Windows.Forms.Label labelPesquisarMarca;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
    }
}