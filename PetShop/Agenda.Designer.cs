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
            this.FiltroDisponibilidade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dataInicial
            // 
            this.dataInicial.CustomFormat = "dd/MM/yyyy";
            this.dataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataInicial.Location = new System.Drawing.Point(12, 40);
            this.dataInicial.Name = "dataInicial";
            this.dataInicial.Size = new System.Drawing.Size(101, 22);
            this.dataInicial.TabIndex = 10;
            this.dataInicial.Value = new System.DateTime(2020, 2, 8, 0, 0, 0, 0);
            // 
            // labelDataInicial
            // 
            this.labelDataInicial.AutoSize = true;
            this.labelDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataInicial.Location = new System.Drawing.Point(12, 21);
            this.labelDataInicial.Name = "labelDataInicial";
            this.labelDataInicial.Size = new System.Drawing.Size(74, 16);
            this.labelDataInicial.TabIndex = 11;
            this.labelDataInicial.Text = "Data Inicial";
            // 
            // dataFinal
            // 
            this.dataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFinal.Location = new System.Drawing.Point(132, 40);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.Size = new System.Drawing.Size(101, 22);
            this.dataFinal.TabIndex = 12;
            // 
            // labelDataFinal
            // 
            this.labelDataFinal.AutoSize = true;
            this.labelDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataFinal.Location = new System.Drawing.Point(129, 20);
            this.labelDataFinal.Name = "labelDataFinal";
            this.labelDataFinal.Size = new System.Drawing.Size(69, 16);
            this.labelDataFinal.TabIndex = 13;
            this.labelDataFinal.Text = "Data Final";
            // 
            // pesquisaNomeDono
            // 
            this.pesquisaNomeDono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaNomeDono.Location = new System.Drawing.Point(254, 39);
            this.pesquisaNomeDono.Name = "pesquisaNomeDono";
            this.pesquisaNomeDono.Size = new System.Drawing.Size(228, 22);
            this.pesquisaNomeDono.TabIndex = 14;
            // 
            // labelPesquisarPeloNomeDono
            // 
            this.labelPesquisarPeloNomeDono.AutoSize = true;
            this.labelPesquisarPeloNomeDono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisarPeloNomeDono.Location = new System.Drawing.Point(251, 20);
            this.labelPesquisarPeloNomeDono.Name = "labelPesquisarPeloNomeDono";
            this.labelPesquisarPeloNomeDono.Size = new System.Drawing.Size(194, 16);
            this.labelPesquisarPeloNomeDono.TabIndex = 15;
            this.labelPesquisarPeloNomeDono.Text = "Pesquisar pelo Nome do Dono";
            // 
            // pesquisaNomeAnimal
            // 
            this.pesquisaNomeAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaNomeAnimal.Location = new System.Drawing.Point(505, 39);
            this.pesquisaNomeAnimal.Name = "pesquisaNomeAnimal";
            this.pesquisaNomeAnimal.Size = new System.Drawing.Size(243, 22);
            this.pesquisaNomeAnimal.TabIndex = 16;
            // 
            // labelPesquisarPeloNomeAnimal
            // 
            this.labelPesquisarPeloNomeAnimal.AutoSize = true;
            this.labelPesquisarPeloNomeAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesquisarPeloNomeAnimal.Location = new System.Drawing.Point(502, 21);
            this.labelPesquisarPeloNomeAnimal.Name = "labelPesquisarPeloNomeAnimal";
            this.labelPesquisarPeloNomeAnimal.Size = new System.Drawing.Size(202, 16);
            this.labelPesquisarPeloNomeAnimal.TabIndex = 17;
            this.labelPesquisarPeloNomeAnimal.Text = "Pesquisar pelo Nome do Animal";
            // 
            // btnNovoHorario
            // 
            this.btnNovoHorario.AutoSize = true;
            this.btnNovoHorario.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNovoHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoHorario.Image = global::PetShop.Properties.Resources.horario_add;
            this.btnNovoHorario.Location = new System.Drawing.Point(771, 21);
            this.btnNovoHorario.Name = "btnNovoHorario";
            this.btnNovoHorario.Size = new System.Drawing.Size(164, 47);
            this.btnNovoHorario.TabIndex = 18;
            this.btnNovoHorario.Text = "Novo Horário";
            this.btnNovoHorario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoHorario.UseVisualStyleBackColor = true;
            this.btnNovoHorario.Click += new System.EventHandler(this.btnNovoHorario_Click);
            // 
            // btnExcluirHorario
            // 
            this.btnExcluirHorario.AutoSize = true;
            this.btnExcluirHorario.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExcluirHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirHorario.Image = global::PetShop.Properties.Resources.horario_delete;
            this.btnExcluirHorario.Location = new System.Drawing.Point(952, 21);
            this.btnExcluirHorario.Name = "btnExcluirHorario";
            this.btnExcluirHorario.Size = new System.Drawing.Size(164, 47);
            this.btnExcluirHorario.TabIndex = 19;
            this.btnExcluirHorario.Text = "Excluir Hoirário";
            this.btnExcluirHorario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirHorario.UseVisualStyleBackColor = true;
            // 
            // btnEditarHorario
            // 
            this.btnEditarHorario.AutoSize = true;
            this.btnEditarHorario.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditarHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarHorario.Image = global::PetShop.Properties.Resources.horario_edit;
            this.btnEditarHorario.Location = new System.Drawing.Point(771, 79);
            this.btnEditarHorario.Name = "btnEditarHorario";
            this.btnEditarHorario.Size = new System.Drawing.Size(164, 49);
            this.btnEditarHorario.TabIndex = 20;
            this.btnEditarHorario.Text = "Alterar Horário";
            this.btnEditarHorario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarHorario.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.AutoSize = true;
            this.btnRelatorio.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Image = global::PetShop.Properties.Resources.printer;
            this.btnRelatorio.Location = new System.Drawing.Point(952, 81);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(164, 47);
            this.btnRelatorio.TabIndex = 21;
            this.btnRelatorio.Text = "Emitir Relatório";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // ListaAgendamento
            // 
            this.ListaAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAgendamento.Location = new System.Drawing.Point(16, 136);
            this.ListaAgendamento.Name = "ListaAgendamento";
            this.ListaAgendamento.Size = new System.Drawing.Size(1101, 508);
            this.ListaAgendamento.TabIndex = 33;
            // 
            // FiltroDisponibilidade
            // 
            this.FiltroDisponibilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroDisponibilidade.FormattingEnabled = true;
            this.FiltroDisponibilidade.Items.AddRange(new object[] {
            "Geral",
            "Disponível",
            "Confirmado"});
            this.FiltroDisponibilidade.Location = new System.Drawing.Point(12, 81);
            this.FiltroDisponibilidade.Name = "FiltroDisponibilidade";
            this.FiltroDisponibilidade.Size = new System.Drawing.Size(144, 24);
            this.FiltroDisponibilidade.TabIndex = 34;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 656);
            this.Controls.Add(this.FiltroDisponibilidade);
            this.Controls.Add(this.ListaAgendamento);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnEditarHorario);
            this.Controls.Add(this.btnExcluirHorario);
            this.Controls.Add(this.btnNovoHorario);
            this.Controls.Add(this.labelPesquisarPeloNomeAnimal);
            this.Controls.Add(this.pesquisaNomeAnimal);
            this.Controls.Add(this.labelPesquisarPeloNomeDono);
            this.Controls.Add(this.pesquisaNomeDono);
            this.Controls.Add(this.labelDataFinal);
            this.Controls.Add(this.dataFinal);
            this.Controls.Add(this.labelDataInicial);
            this.Controls.Add(this.dataInicial);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaAgendamento)).EndInit();
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
        private System.Windows.Forms.ComboBox FiltroDisponibilidade;
    }
}