
namespace PetShop
{
    partial class Opcoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opcoes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.txtRestauracaoDb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnderecoBackup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimparDb = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboLimparDados = new PetShop.ToolBox.Controls.ComboBoxFlatBordered();
            this.comboNomeTabela = new PetShop.ToolBox.Controls.ComboBoxFlatBordered();
            this.comboTempoBackup = new PetShop.ToolBox.Controls.ComboBoxFlatBordered();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRestaurar);
            this.groupBox1.Controls.Add(this.txtRestauracaoDb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboTempoBackup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEnderecoBackup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BackUp e Restauração";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.SystemColors.Window;
            this.btnRestaurar.Enabled = false;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = global::PetShop.Properties.Resources.restoreDb16x16;
            this.btnRestaurar.Location = new System.Drawing.Point(441, 108);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(119, 42);
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // txtRestauracaoDb
            // 
            this.txtRestauracaoDb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRestauracaoDb.BackColor = System.Drawing.SystemColors.Window;
            this.txtRestauracaoDb.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestauracaoDb.Location = new System.Drawing.Point(14, 116);
            this.txtRestauracaoDb.Name = "txtRestauracaoDb";
            this.txtRestauracaoDb.ReadOnly = true;
            this.txtRestauracaoDb.Size = new System.Drawing.Size(402, 26);
            this.txtRestauracaoDb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Restauração do Banco de Dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tempo de Backup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 2;
            // 
            // txtEnderecoBackup
            // 
            this.txtEnderecoBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnderecoBackup.BackColor = System.Drawing.SystemColors.Window;
            this.txtEnderecoBackup.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoBackup.Location = new System.Drawing.Point(14, 51);
            this.txtEnderecoBackup.Name = "txtEnderecoBackup";
            this.txtEnderecoBackup.ReadOnly = true;
            this.txtEnderecoBackup.Size = new System.Drawing.Size(358, 26);
            this.txtEnderecoBackup.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço de BackUp";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnLimparDb);
            this.groupBox2.Controls.Add(this.comboLimparDados);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboNomeTabela);
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Limpeza do Banco de Dados";
            // 
            // btnLimparDb
            // 
            this.btnLimparDb.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimparDb.Enabled = false;
            this.btnLimparDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparDb.Image = global::PetShop.Properties.Resources.clearDb16x16;
            this.btnLimparDb.Location = new System.Drawing.Point(456, 46);
            this.btnLimparDb.Name = "btnLimparDb";
            this.btnLimparDb.Size = new System.Drawing.Size(104, 42);
            this.btnLimparDb.TabIndex = 4;
            this.btnLimparDb.Text = "Limpar";
            this.btnLimparDb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimparDb.UseVisualStyleBackColor = false;
            this.btnLimparDb.Click += new System.EventHandler(this.btnLimparDb_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(222, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Limpar dados mais antigos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome da Tabela";
            // 
            // comboLimparDados
            // 
            this.comboLimparDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboLimparDados.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboLimparDados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLimparDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboLimparDados.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLimparDados.FormattingEnabled = true;
            this.comboLimparDados.Items.AddRange(new object[] {
            "2 Anos",
            "1 Ano",
            "5 Meses",
            "1 Mês",
            "1 Semana",
            "Todos"});
            this.comboLimparDados.Location = new System.Drawing.Point(226, 53);
            this.comboLimparDados.Name = "comboLimparDados";
            this.comboLimparDados.Size = new System.Drawing.Size(201, 28);
            this.comboLimparDados.TabIndex = 3;
            this.comboLimparDados.SelectedIndexChanged += new System.EventHandler(this.comboLimparDados_SelectedIndexChanged);
            // 
            // comboNomeTabela
            // 
            this.comboNomeTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboNomeTabela.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboNomeTabela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNomeTabela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboNomeTabela.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNomeTabela.FormattingEnabled = true;
            this.comboNomeTabela.Items.AddRange(new object[] {
            "Agenda",
            "Animais",
            "Clientes",
            "Fornecedores",
            "Produtos",
            "Vacinas",
            "Vendas"});
            this.comboNomeTabela.Location = new System.Drawing.Point(14, 53);
            this.comboNomeTabela.Name = "comboNomeTabela";
            this.comboNomeTabela.Size = new System.Drawing.Size(189, 28);
            this.comboNomeTabela.TabIndex = 2;
            this.comboNomeTabela.SelectedIndexChanged += new System.EventHandler(this.comboNomeTabela_SelectedIndexChanged);
            // 
            // comboTempoBackup
            // 
            this.comboTempoBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTempoBackup.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboTempoBackup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTempoBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTempoBackup.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTempoBackup.FormattingEnabled = true;
            this.comboTempoBackup.Items.AddRange(new object[] {
            "1 Hora",
            "5 Horas",
            "10 Horas",
            "15 Horas",
            "Diariamente",
            "Semanalmente",
            "Não Definido"});
            this.comboTempoBackup.Location = new System.Drawing.Point(401, 52);
            this.comboTempoBackup.Name = "comboTempoBackup";
            this.comboTempoBackup.Size = new System.Drawing.Size(159, 25);
            this.comboTempoBackup.TabIndex = 4;
            // 
            // Opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(600, 317);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Opcoes";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções";
            this.Load += new System.EventHandler(this.Opcoes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.TextBox txtRestauracaoDb;
        private System.Windows.Forms.Label label4;
        private ToolBox.Controls.ComboBoxFlatBordered comboTempoBackup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnderecoBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimparDb;
        private ToolBox.Controls.ComboBoxFlatBordered comboLimparDados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private ToolBox.Controls.ComboBoxFlatBordered comboNomeTabela;
    }
}