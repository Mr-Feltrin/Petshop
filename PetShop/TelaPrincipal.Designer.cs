namespace PetShop
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.menu_principal = new System.Windows.Forms.ToolStrip();
            this.btnMenuPesquisaClientes = new System.Windows.Forms.ToolStripButton();
            this.btnMenuFornecedores = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.botao_agenda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.botao_produtos = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAnimais = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
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
            this.btnMenuPesquisaClientes,
            this.btnMenuFornecedores,
            this.toolStripSeparator,
            this.botao_agenda,
            this.toolStripSeparator1,
            this.botao_produtos,
            this.btnConsultar,
            this.toolStripSeparator2,
            this.btnAnimais,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButton2});
            this.menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.Size = new System.Drawing.Size(1184, 52);
            this.menu_principal.TabIndex = 0;
            this.menu_principal.Text = "toolStrip1";
            // 
            // btnMenuPesquisaClientes
            // 
            this.btnMenuPesquisaClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuPesquisaClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuPesquisaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPesquisaClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuPesquisaClientes.Image")));
            this.btnMenuPesquisaClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenuPesquisaClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenuPesquisaClientes.Name = "btnMenuPesquisaClientes";
            this.btnMenuPesquisaClientes.Size = new System.Drawing.Size(63, 49);
            this.btnMenuPesquisaClientes.Text = "Clientes";
            this.btnMenuPesquisaClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuPesquisaClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMenuPesquisaClientes.Click += new System.EventHandler(this.btnMenuPesquisaClientes_Click);
            // 
            // btnMenuFornecedores
            // 
            this.btnMenuFornecedores.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuFornecedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuFornecedores.Image")));
            this.btnMenuFornecedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenuFornecedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenuFornecedores.Name = "btnMenuFornecedores";
            this.btnMenuFornecedores.Size = new System.Drawing.Size(63, 49);
            this.btnMenuFornecedores.Text = "Fornece";
            this.btnMenuFornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuFornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMenuFornecedores.Click += new System.EventHandler(this.btnMenuFornecedores_Click);
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
            this.botao_agenda.Click += new System.EventHandler(this.Botao_agenda_Click);
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
            this.botao_produtos.Image = global::PetShop.Properties.Resources.produtos;
            this.botao_produtos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botao_produtos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botao_produtos.Name = "botao_produtos";
            this.botao_produtos.Size = new System.Drawing.Size(68, 49);
            this.botao_produtos.Text = "Produtos";
            this.botao_produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao_produtos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botao_produtos.ToolTipText = "Produtos";
            this.botao_produtos.Click += new System.EventHandler(this.Botao_produtos_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = global::PetShop.Properties.Resources.codigo_barras2;
            this.btnConsultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(72, 49);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultar.ToolTipText = "Produtos";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // btnAnimais
            // 
            this.btnAnimais.BackColor = System.Drawing.Color.Transparent;
            this.btnAnimais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimais.Image = global::PetShop.Properties.Resources.animal_small;
            this.btnAnimais.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAnimais.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.Size = new System.Drawing.Size(62, 49);
            this.btnAnimais.Text = "Animais";
            this.btnAnimais.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnimais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnimais.ToolTipText = "Produtos";
            this.btnAnimais.Click += new System.EventHandler(this.BtnAnimais_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::PetShop.Properties.Resources.injecao;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(61, 49);
            this.toolStripButton1.Text = "Vacinas";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "Produtos";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 49);
            this.toolStripButton2.Text = "Atender";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.ToolTipText = "Produtos";
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
            this.toolStripStatus_agendamentos_atuais.Image = global::PetShop.Properties.Resources.agenda;
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
            // TelaPrincipal
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
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripButton btnMenuPesquisaClientes;
        private System.Windows.Forms.ToolStripButton btnMenuFornecedores;
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
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAnimais;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

