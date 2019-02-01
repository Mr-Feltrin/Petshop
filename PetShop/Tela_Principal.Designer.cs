namespace PetShop
{
    partial class Tela_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Principal));
            this.menu_principal = new System.Windows.Forms.ToolStrip();
            this.botao_clientes = new System.Windows.Forms.ToolStripButton();
            this.botao_fornecedores = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.botao_agenda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.botao_produtos = new System.Windows.Forms.ToolStripButton();
            this.status_rodape_principal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus_data_completa = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_agendamentos_atuais = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_num_lock = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_caps_lock = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_data = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_horario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_nome_administrador = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_nome_sistema = new System.Windows.Forms.ToolStripStatusLabel();
            this.horario_atual = new System.Windows.Forms.Timer(this.components);
            this.menu_principal.SuspendLayout();
            this.status_rodape_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_principal
            // 
            this.menu_principal.AllowMerge = false;
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botao_clientes,
            this.botao_fornecedores,
            this.toolStripSeparator,
            this.botao_agenda,
            this.toolStripSeparator1,
            this.botao_produtos});
            this.menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.Size = new System.Drawing.Size(1184, 52);
            this.menu_principal.TabIndex = 0;
            this.menu_principal.Text = "toolStrip1";
            // 
            // botao_clientes
            // 
            this.botao_clientes.BackColor = System.Drawing.Color.Transparent;
            this.botao_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_clientes.Image = ((System.Drawing.Image)(resources.GetObject("botao_clientes.Image")));
            this.botao_clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botao_clientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botao_clientes.Name = "botao_clientes";
            this.botao_clientes.Size = new System.Drawing.Size(63, 49);
            this.botao_clientes.Text = "Clientes";
            this.botao_clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botao_clientes.Click += new System.EventHandler(this.Botao_clientes_Click);
            // 
            // botao_fornecedores
            // 
            this.botao_fornecedores.BackColor = System.Drawing.Color.Transparent;
            this.botao_fornecedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_fornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_fornecedores.Image = ((System.Drawing.Image)(resources.GetObject("botao_fornecedores.Image")));
            this.botao_fornecedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botao_fornecedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botao_fornecedores.Name = "botao_fornecedores";
            this.botao_fornecedores.Size = new System.Drawing.Size(63, 49);
            this.botao_fornecedores.Text = "Fornece";
            this.botao_fornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao_fornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 52);
            // 
            // botao_agenda
            // 
            this.botao_agenda.BackColor = System.Drawing.Color.Transparent;
            this.botao_agenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_agenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_agenda.Image = ((System.Drawing.Image)(resources.GetObject("botao_agenda.Image")));
            this.botao_agenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botao_agenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botao_agenda.Name = "botao_agenda";
            this.botao_agenda.Size = new System.Drawing.Size(59, 49);
            this.botao_agenda.Text = "Agenda";
            this.botao_agenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao_agenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // botao_produtos
            // 
            this.botao_produtos.BackColor = System.Drawing.Color.Transparent;
            this.botao_produtos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_produtos.Image = ((System.Drawing.Image)(resources.GetObject("botao_produtos.Image")));
            this.botao_produtos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botao_produtos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botao_produtos.Name = "botao_produtos";
            this.botao_produtos.Size = new System.Drawing.Size(68, 49);
            this.botao_produtos.Text = "Produtos";
            this.botao_produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao_produtos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botao_produtos.ToolTipText = "Produtos";
            // 
            // status_rodape_principal
            // 
            this.status_rodape_principal.AllowMerge = false;
            this.status_rodape_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus_data_completa,
            this.toolStripStatus_agendamentos_atuais,
            this.toolStripStatus_num_lock,
            this.toolStripStatus_caps_lock,
            this.toolStripStatus_data,
            this.toolStripStatus_horario,
            this.toolStripStatus_nome_administrador,
            this.toolStripStatus_nome_sistema});
            this.status_rodape_principal.Location = new System.Drawing.Point(0, 651);
            this.status_rodape_principal.Name = "status_rodape_principal";
            this.status_rodape_principal.Size = new System.Drawing.Size(1184, 27);
            this.status_rodape_principal.SizingGrip = false;
            this.status_rodape_principal.TabIndex = 2;
            this.status_rodape_principal.Text = "statusStrip1";
            // 
            // toolStripStatus_data_completa
            // 
            this.toolStripStatus_data_completa.AutoSize = false;
            this.toolStripStatus_data_completa.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatus_data_completa.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatus_data_completa.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatus_data_completa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatus_data_completa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus_data_completa.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripStatus_data_completa.Name = "toolStripStatus_data_completa";
            this.toolStripStatus_data_completa.Size = new System.Drawing.Size(729, 22);
            this.toolStripStatus_data_completa.Spring = true;
            this.toolStripStatus_data_completa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatus_agendamentos_atuais
            // 
            this.toolStripStatus_agendamentos_atuais.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatus_agendamentos_atuais.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatus_agendamentos_atuais.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatus_agendamentos_atuais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus_agendamentos_atuais.Image = global::PetShop.Properties.Resources.agenda_icon;
            this.toolStripStatus_agendamentos_atuais.Name = "toolStripStatus_agendamentos_atuais";
            this.toolStripStatus_agendamentos_atuais.Size = new System.Drawing.Size(208, 22);
            this.toolStripStatus_agendamentos_atuais.Text = "Agendamentos para hoje: 0";
            this.toolStripStatus_agendamentos_atuais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatus_num_lock
            // 
            this.toolStripStatus_num_lock.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatus_num_lock.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatus_num_lock.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatus_num_lock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus_num_lock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatus_num_lock.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripStatus_num_lock.Name = "toolStripStatus_num_lock";
            this.toolStripStatus_num_lock.Size = new System.Drawing.Size(44, 22);
            this.toolStripStatus_num_lock.Text = "Num";
            // 
            // toolStripStatus_caps_lock
            // 
            this.toolStripStatus_caps_lock.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatus_caps_lock.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatus_caps_lock.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatus_caps_lock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus_caps_lock.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripStatus_caps_lock.Name = "toolStripStatus_caps_lock";
            this.toolStripStatus_caps_lock.Size = new System.Drawing.Size(47, 22);
            this.toolStripStatus_caps_lock.Text = "Caps";
            this.toolStripStatus_caps_lock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatus_data
            // 
            this.toolStripStatus_data.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatus_data.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatus_data.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatus_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus_data.Name = "toolStripStatus_data";
            this.toolStripStatus_data.Size = new System.Drawing.Size(4, 22);
            // 
            // toolStripStatus_horario
            // 
            this.toolStripStatus_horario.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatus_horario.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatus_horario.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatus_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus_horario.Name = "toolStripStatus_horario";
            this.toolStripStatus_horario.Size = new System.Drawing.Size(4, 22);
            // 
            // toolStripStatus_nome_administrador
            // 
            this.toolStripStatus_nome_administrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripStatus_nome_administrador.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatus_nome_administrador.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatus_nome_administrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus_nome_administrador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatus_nome_administrador.Image = global::PetShop.Properties.Resources.administrador_sistema;
            this.toolStripStatus_nome_administrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatus_nome_administrador.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripStatus_nome_administrador.Name = "toolStripStatus_nome_administrador";
            this.toolStripStatus_nome_administrador.Size = new System.Drawing.Size(20, 22);
            // 
            // toolStripStatus_nome_sistema
            // 
            this.toolStripStatus_nome_sistema.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatus_nome_sistema.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatus_nome_sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus_nome_sistema.Image = global::PetShop.Properties.Resources.computador_sistema;
            this.toolStripStatus_nome_sistema.Name = "toolStripStatus_nome_sistema";
            this.toolStripStatus_nome_sistema.Size = new System.Drawing.Size(113, 22);
            this.toolStripStatus_nome_sistema.Text = "Pet Shop 1.0";
            this.toolStripStatus_nome_sistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // horario_atual
            // 
            this.horario_atual.Enabled = true;
            this.horario_atual.Interval = 1000;
            this.horario_atual.Tick += new System.EventHandler(this.Horario_atual_Tick);
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 678);
            this.Controls.Add(this.status_rodape_principal);
            this.Controls.Add(this.menu_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Principal";
            this.Text = "Pet Shop Cãopanheiro";
            this.Load += new System.EventHandler(this.Tela_Principal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tela_Principal_KeyDown);
            this.menu_principal.ResumeLayout(false);
            this.menu_principal.PerformLayout();
            this.status_rodape_principal.ResumeLayout(false);
            this.status_rodape_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu_principal;
        private System.Windows.Forms.ToolStripButton botao_clientes;
        private System.Windows.Forms.ToolStripButton botao_fornecedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton botao_agenda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton botao_produtos;
        private System.Windows.Forms.StatusStrip status_rodape_principal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_data_completa;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_caps_lock;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_num_lock;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_data;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_horario;
        private System.Windows.Forms.Timer horario_atual;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_nome_administrador;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_nome_sistema;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_agendamentos_atuais;
    }
}

