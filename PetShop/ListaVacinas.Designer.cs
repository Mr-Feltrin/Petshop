
namespace PetShop
{
    partial class ListaVacinas
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
            this.DGVVacinas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisarImunologia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVacinas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVVacinas
            // 
            this.DGVVacinas.AllowUserToAddRows = false;
            this.DGVVacinas.AllowUserToDeleteRows = false;
            this.DGVVacinas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVVacinas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVVacinas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVVacinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVVacinas.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVVacinas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVVacinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVVacinas.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVVacinas.Location = new System.Drawing.Point(18, 107);
            this.DGVVacinas.MultiSelect = false;
            this.DGVVacinas.Name = "DGVVacinas";
            this.DGVVacinas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVVacinas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVVacinas.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVVacinas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVVacinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVVacinas.Size = new System.Drawing.Size(679, 473);
            this.DGVVacinas.TabIndex = 3;
            this.DGVVacinas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVVacinas_CellDoubleClick);
            this.DGVVacinas.SelectionChanged += new System.EventHandler(this.DGVVacinas_SelectionChanged);
            this.DGVVacinas.Sorted += new System.EventHandler(this.DGVVacinas_Sorted);
            this.DGVVacinas.Enter += new System.EventHandler(this.DGVVacinas_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 490);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionar.BackColor = System.Drawing.Color.LightGreen;
            this.btnSelecionar.Enabled = false;
            this.btnSelecionar.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.ForeColor = System.Drawing.Color.Black;
            this.btnSelecionar.Image = global::PetShop.Properties.Resources.confirm;
            this.btnSelecionar.Location = new System.Drawing.Point(557, 599);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(146, 48);
            this.btnSelecionar.TabIndex = 14;
            this.btnSelecionar.Text = "    Selecionar";
            this.btnSelecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::PetShop.Properties.Resources.close;
            this.btnCancelar.Location = new System.Drawing.Point(12, 599);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 48);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "      Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar por Imunologia";
            // 
            // txtPesquisarImunologia
            // 
            this.txtPesquisarImunologia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarImunologia.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarImunologia.Location = new System.Drawing.Point(6, 40);
            this.txtPesquisarImunologia.Name = "txtPesquisarImunologia";
            this.txtPesquisarImunologia.Size = new System.Drawing.Size(679, 26);
            this.txtPesquisarImunologia.TabIndex = 1;
            this.txtPesquisarImunologia.TextChanged += new System.EventHandler(this.txtPesquisarImunologia_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPesquisarImunologia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ListaVacinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(715, 663);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.DGVVacinas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaVacinas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Vacinas";
            this.Load += new System.EventHandler(this.ListaVacinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVacinas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVVacinas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisarImunologia;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}