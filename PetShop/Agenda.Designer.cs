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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDataFinal = new System.Windows.Forms.Label();
            this.pesquisaNomeDono = new System.Windows.Forms.TextBox();
            this.labelPesquisarPeloNomeDono = new System.Windows.Forms.Label();
            this.pesquisaNomeAnimal = new System.Windows.Forms.TextBox();
            this.labelPesquisarPeloNomeAnimal = new System.Windows.Forms.Label();
            this.btnNovoHorario = new System.Windows.Forms.Button();
            this.btnExcluirHorario = new System.Windows.Forms.Button();
            this.btnEditarHorario = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.filtroGeral = new System.Windows.Forms.CheckBox();
            this.filtroDisponivel = new System.Windows.Forms.CheckBox();
            this.filtroConfirmado = new System.Windows.Forms.CheckBox();
            this.filtroAConfirmar = new System.Windows.Forms.CheckBox();
            this.filtoCancelado = new System.Windows.Forms.CheckBox();
            this.labelFiltrarProcedimento = new System.Windows.Forms.Label();
            this.filtrarProcedimento = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelFiltrarVeterinario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataInicial
            // 
            this.dataInicial.CustomFormat = "dd/MM/yyyy";
            this.dataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataInicial.Location = new System.Drawing.Point(12, 40);
            this.dataInicial.Name = "dataInicial";
            this.dataInicial.Size = new System.Drawing.Size(100, 21);
            this.dataInicial.TabIndex = 10;
            this.dataInicial.Value = new System.DateTime(2019, 5, 16, 20, 33, 49, 0);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker1.TabIndex = 12;
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
            // filtroGeral
            // 
            this.filtroGeral.AutoSize = true;
            this.filtroGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroGeral.Location = new System.Drawing.Point(15, 80);
            this.filtroGeral.Name = "filtroGeral";
            this.filtroGeral.Size = new System.Drawing.Size(60, 20);
            this.filtroGeral.TabIndex = 24;
            this.filtroGeral.Text = "Geral";
            this.filtroGeral.UseVisualStyleBackColor = true;
            // 
            // filtroDisponivel
            // 
            this.filtroDisponivel.AutoSize = true;
            this.filtroDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroDisponivel.Location = new System.Drawing.Point(93, 80);
            this.filtroDisponivel.Name = "filtroDisponivel";
            this.filtroDisponivel.Size = new System.Drawing.Size(91, 20);
            this.filtroDisponivel.TabIndex = 25;
            this.filtroDisponivel.Text = "Disponível";
            this.filtroDisponivel.UseVisualStyleBackColor = true;
            // 
            // filtroConfirmado
            // 
            this.filtroConfirmado.AutoSize = true;
            this.filtroConfirmado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroConfirmado.Location = new System.Drawing.Point(93, 106);
            this.filtroConfirmado.Name = "filtroConfirmado";
            this.filtroConfirmado.Size = new System.Drawing.Size(96, 20);
            this.filtroConfirmado.TabIndex = 26;
            this.filtroConfirmado.Text = "Confirmado";
            this.filtroConfirmado.UseVisualStyleBackColor = true;
            // 
            // filtroAConfirmar
            // 
            this.filtroAConfirmar.AutoSize = true;
            this.filtroAConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroAConfirmar.Location = new System.Drawing.Point(208, 80);
            this.filtroAConfirmar.Name = "filtroAConfirmar";
            this.filtroAConfirmar.Size = new System.Drawing.Size(94, 20);
            this.filtroAConfirmar.TabIndex = 27;
            this.filtroAConfirmar.Text = "A confirmar";
            this.filtroAConfirmar.UseVisualStyleBackColor = true;
            // 
            // filtoCancelado
            // 
            this.filtoCancelado.AutoSize = true;
            this.filtoCancelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtoCancelado.Location = new System.Drawing.Point(209, 106);
            this.filtoCancelado.Name = "filtoCancelado";
            this.filtoCancelado.Size = new System.Drawing.Size(93, 20);
            this.filtoCancelado.TabIndex = 28;
            this.filtoCancelado.Text = "Cancelado";
            this.filtoCancelado.UseVisualStyleBackColor = true;
            // 
            // labelFiltrarProcedimento
            // 
            this.labelFiltrarProcedimento.AutoSize = true;
            this.labelFiltrarProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltrarProcedimento.Location = new System.Drawing.Point(319, 81);
            this.labelFiltrarProcedimento.Name = "labelFiltrarProcedimento";
            this.labelFiltrarProcedimento.Size = new System.Drawing.Size(150, 16);
            this.labelFiltrarProcedimento.TabIndex = 29;
            this.labelFiltrarProcedimento.Text = "Filtrar por procedimento";
            // 
            // filtrarProcedimento
            // 
            this.filtrarProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrarProcedimento.FormattingEnabled = true;
            this.filtrarProcedimento.Location = new System.Drawing.Point(322, 105);
            this.filtrarProcedimento.Name = "filtrarProcedimento";
            this.filtrarProcedimento.Size = new System.Drawing.Size(193, 21);
            this.filtrarProcedimento.TabIndex = 30;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(535, 106);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(213, 21);
            this.comboBox2.TabIndex = 31;
            // 
            // labelFiltrarVeterinario
            // 
            this.labelFiltrarVeterinario.AutoSize = true;
            this.labelFiltrarVeterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltrarVeterinario.Location = new System.Drawing.Point(532, 81);
            this.labelFiltrarVeterinario.Name = "labelFiltrarVeterinario";
            this.labelFiltrarVeterinario.Size = new System.Drawing.Size(132, 16);
            this.labelFiltrarVeterinario.TabIndex = 32;
            this.labelFiltrarVeterinario.Text = "Filtrar por Veterinário";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1101, 508);
            this.dataGridView1.TabIndex = 33;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 656);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelFiltrarVeterinario);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.filtrarProcedimento);
            this.Controls.Add(this.labelFiltrarProcedimento);
            this.Controls.Add(this.filtoCancelado);
            this.Controls.Add(this.filtroAConfirmar);
            this.Controls.Add(this.filtroConfirmado);
            this.Controls.Add(this.filtroDisponivel);
            this.Controls.Add(this.filtroGeral);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnEditarHorario);
            this.Controls.Add(this.btnExcluirHorario);
            this.Controls.Add(this.btnNovoHorario);
            this.Controls.Add(this.labelPesquisarPeloNomeAnimal);
            this.Controls.Add(this.pesquisaNomeAnimal);
            this.Controls.Add(this.labelPesquisarPeloNomeDono);
            this.Controls.Add(this.pesquisaNomeDono);
            this.Controls.Add(this.labelDataFinal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDataInicial);
            this.Controls.Add(this.dataInicial);
            this.Name = "Agenda";
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataInicial;
        private System.Windows.Forms.Label labelDataInicial;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDataFinal;
        private System.Windows.Forms.TextBox pesquisaNomeDono;
        private System.Windows.Forms.Label labelPesquisarPeloNomeDono;
        private System.Windows.Forms.TextBox pesquisaNomeAnimal;
        private System.Windows.Forms.Label labelPesquisarPeloNomeAnimal;
        private System.Windows.Forms.Button btnNovoHorario;
        private System.Windows.Forms.Button btnExcluirHorario;
        private System.Windows.Forms.Button btnEditarHorario;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.CheckBox filtroGeral;
        private System.Windows.Forms.CheckBox filtroDisponivel;
        private System.Windows.Forms.CheckBox filtroConfirmado;
        private System.Windows.Forms.CheckBox filtroAConfirmar;
        private System.Windows.Forms.CheckBox filtoCancelado;
        private System.Windows.Forms.Label labelFiltrarProcedimento;
        private System.Windows.Forms.ComboBox filtrarProcedimento;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelFiltrarVeterinario;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}