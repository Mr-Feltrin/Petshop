namespace PetShop
{
    partial class Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.dataInicial = new System.Windows.Forms.DateTimePicker();
            this.labelDataInicial = new System.Windows.Forms.Label();
            this.dataFinal = new System.Windows.Forms.DateTimePicker();
            this.labelDataFinal = new System.Windows.Forms.Label();
            this.pesquisaNomeDono = new System.Windows.Forms.TextBox();
            this.labelPesquisarPeloNomeDono = new System.Windows.Forms.Label();
            this.pesquisaNomeAnimal = new System.Windows.Forms.TextBox();
            this.labelPesquisarPeloNomeAnimal = new System.Windows.Forms.Label();
            this.btnNovoHorario = new System.Windows.Forms.Button();
            this.btnExcluirHorario = new System.Windows.Forms.Button();
            this.btnEditarHorario = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.ListaAgendamento = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAgendamento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataInicial
            // 
            this.dataInicial.CustomFormat = "dd/MM/yyyy";
            this.dataInicial.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataInicial.Location = new System.Drawing.Point(10, 38);
            this.dataInicial.Name = "dataInicial";
            this.dataInicial.Size = new System.Drawing.Size(109, 25);
            this.dataInicial.TabIndex = 1;
            this.dataInicial.Value = new System.DateTime(2020, 11, 30, 0, 0, 0, 0);
            // 
            // labelDataInicial
            // 
            this.labelDataInicial.AutoSize = true;
            this.labelDataInicial.BackColor = System.Drawing.Color.Transparent;
            this.labelDataInicial.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataInicial.Location = new System.Drawing.Point(6, 16);
            this.labelDataInicial.Name = "labelDataInicial";
            this.labelDataInicial.Size = new System.Drawing.Size(83, 20);
            this.labelDataInicial.TabIndex = 1;
            this.labelDataInicial.Text = "Data Inicial";
            // 
            // dataFinal
            // 
            this.dataFinal.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFinal.Location = new System.Drawing.Point(142, 39);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.Size = new System.Drawing.Size(109, 25);
            this.dataFinal.TabIndex = 2;
            // 
            // labelDataFinal
            // 
            this.labelDataFinal.AutoSize = true;
            this.labelDataFinal.BackColor = System.Drawing.Color.Transparent;
            this.labelDataFinal.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataFinal.Location = new System.Drawing.Point(138, 16);
            this.labelDataFinal.Name = "labelDataFinal";
            this.labelDataFinal.Size = new System.Drawing.Size(76, 20);
            this.labelDataFinal.TabIndex = 2;
            this.labelDataFinal.Text = "Data Final";
            // 
            // pesquisaNomeDono
            // 
            this.pesquisaNomeDono.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaNomeDono.Location = new System.Drawing.Point(274, 39);
            this.pesquisaNomeDono.Name = "pesquisaNomeDono";
            this.pesquisaNomeDono.Size = new System.Drawing.Size(201, 25);
            this.pesquisaNomeDono.TabIndex = 3;
            // 
            // labelPesquisarPeloNomeDono
            // 
            this.labelPesquisarPeloNomeDono.AutoSize = true;
            this.labelPesquisarPeloNomeDono.BackColor = System.Drawing.Color.Transparent;
            this.labelPesquisarPeloNomeDono.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisarPeloNomeDono.Location = new System.Drawing.Point(268, 16);
            this.labelPesquisarPeloNomeDono.Name = "labelPesquisarPeloNomeDono";
            this.labelPesquisarPeloNomeDono.Size = new System.Drawing.Size(204, 20);
            this.labelPesquisarPeloNomeDono.TabIndex = 3;
            this.labelPesquisarPeloNomeDono.Text = "Pesquisar pelo Nome do Dono";
            // 
            // pesquisaNomeAnimal
            // 
            this.pesquisaNomeAnimal.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaNomeAnimal.Location = new System.Drawing.Point(498, 39);
            this.pesquisaNomeAnimal.Name = "pesquisaNomeAnimal";
            this.pesquisaNomeAnimal.Size = new System.Drawing.Size(243, 25);
            this.pesquisaNomeAnimal.TabIndex = 4;
            // 
            // labelPesquisarPeloNomeAnimal
            // 
            this.labelPesquisarPeloNomeAnimal.AutoSize = true;
            this.labelPesquisarPeloNomeAnimal.BackColor = System.Drawing.Color.Transparent;
            this.labelPesquisarPeloNomeAnimal.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisarPeloNomeAnimal.Location = new System.Drawing.Point(494, 16);
            this.labelPesquisarPeloNomeAnimal.Name = "labelPesquisarPeloNomeAnimal";
            this.labelPesquisarPeloNomeAnimal.Size = new System.Drawing.Size(215, 20);
            this.labelPesquisarPeloNomeAnimal.TabIndex = 4;
            this.labelPesquisarPeloNomeAnimal.Text = "Pesquisar pelo Nome do Animal";
            // 
            // btnNovoHorario
            // 
            this.btnNovoHorario.AutoSize = true;
            this.btnNovoHorario.BackColor = System.Drawing.Color.Lime;
            this.btnNovoHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoHorario.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoHorario.Image = global::PetShop.Properties.Resources.horario_add;
            this.btnNovoHorario.Location = new System.Drawing.Point(771, 18);
            this.btnNovoHorario.Name = "btnNovoHorario";
            this.btnNovoHorario.Size = new System.Drawing.Size(164, 47);
            this.btnNovoHorario.TabIndex = 1;
            this.btnNovoHorario.Text = "Novo Horário";
            this.btnNovoHorario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoHorario.UseVisualStyleBackColor = false;
            this.btnNovoHorario.Click += new System.EventHandler(this.btnNovoHorario_Click);
            // 
            // btnExcluirHorario
            // 
            this.btnExcluirHorario.AutoSize = true;
            this.btnExcluirHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnExcluirHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirHorario.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirHorario.Image = global::PetShop.Properties.Resources.horario_delete;
            this.btnExcluirHorario.Location = new System.Drawing.Point(952, 18);
            this.btnExcluirHorario.Name = "btnExcluirHorario";
            this.btnExcluirHorario.Size = new System.Drawing.Size(164, 47);
            this.btnExcluirHorario.TabIndex = 2;
            this.btnExcluirHorario.Text = "Excluir Horário";
            this.btnExcluirHorario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirHorario.UseVisualStyleBackColor = false;
            // 
            // btnEditarHorario
            // 
            this.btnEditarHorario.AutoSize = true;
            this.btnEditarHorario.BackColor = System.Drawing.Color.Yellow;
            this.btnEditarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarHorario.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarHorario.Image = global::PetShop.Properties.Resources.horario_edit;
            this.btnEditarHorario.Location = new System.Drawing.Point(771, 71);
            this.btnEditarHorario.Name = "btnEditarHorario";
            this.btnEditarHorario.Size = new System.Drawing.Size(164, 49);
            this.btnEditarHorario.TabIndex = 3;
            this.btnEditarHorario.Text = "Alterar Horário";
            this.btnEditarHorario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarHorario.UseVisualStyleBackColor = false;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.AutoSize = true;
            this.btnRelatorio.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Image = global::PetShop.Properties.Resources.printer32x32;
            this.btnRelatorio.Location = new System.Drawing.Point(952, 73);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(166, 47);
            this.btnRelatorio.TabIndex = 4;
            this.btnRelatorio.Text = "Emitir Relatório";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorio.UseVisualStyleBackColor = false;
            // 
            // ListaAgendamento
            // 
            this.ListaAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAgendamento.Location = new System.Drawing.Point(12, 126);
            this.ListaAgendamento.Name = "ListaAgendamento";
            this.ListaAgendamento.Size = new System.Drawing.Size(1104, 497);
            this.ListaAgendamento.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pesquisaNomeAnimal);
            this.groupBox1.Controls.Add(this.labelPesquisarPeloNomeAnimal);
            this.groupBox1.Controls.Add(this.labelDataInicial);
            this.groupBox1.Controls.Add(this.dataInicial);
            this.groupBox1.Controls.Add(this.pesquisaNomeDono);
            this.groupBox1.Controls.Add(this.labelPesquisarPeloNomeDono);
            this.groupBox1.Controls.Add(this.dataFinal);
            this.groupBox1.Controls.Add(this.labelDataFinal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 656);
            this.Controls.Add(this.ListaAgendamento);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnEditarHorario);
            this.Controls.Add(this.btnExcluirHorario);
            this.Controls.Add(this.btnNovoHorario);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Agenda";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaAgendamento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataInicial;
        private System.Windows.Forms.Label labelDataInicial;
        private System.Windows.Forms.DateTimePicker dataFinal;
        private System.Windows.Forms.Label labelDataFinal;
        private System.Windows.Forms.TextBox pesquisaNomeDono;
        private System.Windows.Forms.Label labelPesquisarPeloNomeDono;
        private System.Windows.Forms.TextBox pesquisaNomeAnimal;
        private System.Windows.Forms.Label labelPesquisarPeloNomeAnimal;
        private System.Windows.Forms.Button btnNovoHorario;
        private System.Windows.Forms.Button btnExcluirHorario;
        private System.Windows.Forms.Button btnEditarHorario;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.DataGridView ListaAgendamento;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}