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
            this.btnServicos = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAnimais = new System.Windows.Forms.ToolStripButton();
            this.btnVacinacao = new System.Windows.Forms.ToolStripButton();
            this.btnVacinas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVenda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRelatorios = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnRelatorioVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelatorioProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelatorioVacinas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOpcoes = new System.Windows.Forms.ToolStripButton();
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
            this.TimerAgendamentos = new System.Windows.Forms.Timer(this.components);
            this.timerDataAtual = new System.Windows.Forms.Timer(this.components);
            this.timerBackup = new System.Windows.Forms.Timer(this.components);
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
            this.btnServicos,
            this.btnConsultar,
            this.toolStripSeparator2,
            this.btnAnimais,
            this.btnVacinacao,
            this.btnVacinas,
            this.toolStripSeparator3,
            this.btnVenda,
            this.toolStripSeparator4,
            this.btnRelatorios,
            this.toolStripSeparator5,
            this.btnOpcoes});
            this.menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.ShowItemToolTips = false;
            this.menu_principal.Size = new System.Drawing.Size(1184, 54);
            this.menu_principal.TabIndex = 0;
            this.menu_principal.Text = "toolStrip1";
            // 
            // btnMenuPesquisaClientes
            // 
            this.btnMenuPesquisaClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuPesquisaClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuPesquisaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPesquisaClientes.Image = global::PetShop.Properties.Resources.clientes;
            this.btnMenuPesquisaClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenuPesquisaClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenuPesquisaClientes.Name = "btnMenuPesquisaClientes";
            this.btnMenuPesquisaClientes.Size = new System.Drawing.Size(63, 51);
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
            this.btnMenuFornecedores.Image = global::PetShop.Properties.Resources.fornecedor;
            this.btnMenuFornecedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMenuFornecedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenuFornecedores.Name = "btnMenuFornecedores";
            this.btnMenuFornecedores.Size = new System.Drawing.Size(63, 51);
            this.btnMenuFornecedores.Text = "Fornece";
            this.btnMenuFornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuFornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMenuFornecedores.Click += new System.EventHandler(this.btnMenuFornecedores_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 54);
            // 
            // botao_agenda
            // 
            this.botao_agenda.BackColor = System.Drawing.Color.Transparent;
            this.botao_agenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_agenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_agenda.Image = global::PetShop.Properties.Resources.agenda;
            this.botao_agenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botao_agenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botao_agenda.Name = "botao_agenda";
            this.botao_agenda.Size = new System.Drawing.Size(59, 51);
            this.botao_agenda.Text = "Agenda";
            this.botao_agenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao_agenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botao_agenda.Click += new System.EventHandler(this.Botao_agenda_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // botao_produtos
            // 
            this.botao_produtos.BackColor = System.Drawing.Color.Transparent;
            this.botao_produtos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_produtos.Image = global::PetShop.Properties.Resources.produtos30x30;
            this.botao_produtos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botao_produtos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botao_produtos.Name = "botao_produtos";
            this.botao_produtos.Size = new System.Drawing.Size(68, 51);
            this.botao_produtos.Text = "Produtos";
            this.botao_produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao_produtos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botao_produtos.ToolTipText = "Produtos";
            this.botao_produtos.Click += new System.EventHandler(this.Botao_produtos_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.BackColor = System.Drawing.Color.Transparent;
            this.btnServicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.Image = global::PetShop.Properties.Resources.servicos30x30;
            this.btnServicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnServicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(65, 51);
            this.btnServicos.Text = "Serviços";
            this.btnServicos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnServicos.ToolTipText = "Produtos";
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
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
            this.btnConsultar.Size = new System.Drawing.Size(72, 51);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultar.ToolTipText = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
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
            this.btnAnimais.Size = new System.Drawing.Size(62, 51);
            this.btnAnimais.Text = "Animais";
            this.btnAnimais.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnimais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnimais.ToolTipText = "Animais";
            this.btnAnimais.Click += new System.EventHandler(this.BtnAnimais_Click);
            // 
            // btnVacinacao
            // 
            this.btnVacinacao.BackColor = System.Drawing.Color.Transparent;
            this.btnVacinacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVacinacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVacinacao.Image = global::PetShop.Properties.Resources.vacinacao_animal30x30;
            this.btnVacinacao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVacinacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVacinacao.Name = "btnVacinacao";
            this.btnVacinacao.Size = new System.Drawing.Size(77, 51);
            this.btnVacinacao.Text = "Vacinação";
            this.btnVacinacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVacinacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVacinacao.ToolTipText = "Vacinação";
            this.btnVacinacao.Click += new System.EventHandler(this.btnVacinacao_Click);
            // 
            // btnVacinas
            // 
            this.btnVacinas.BackColor = System.Drawing.Color.Transparent;
            this.btnVacinas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVacinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVacinas.Image = global::PetShop.Properties.Resources.vacina30x30;
            this.btnVacinas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVacinas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVacinas.Name = "btnVacinas";
            this.btnVacinas.Size = new System.Drawing.Size(61, 51);
            this.btnVacinas.Text = "Vacinas";
            this.btnVacinas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVacinas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVacinas.ToolTipText = "Vacinas";
            this.btnVacinas.Click += new System.EventHandler(this.btnVacinas_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.Color.Transparent;
            this.btnVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.Image = global::PetShop.Properties.Resources.vendas30x30;
            this.btnVenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(51, 51);
            this.btnVenda.Text = "Venda";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVenda.ToolTipText = "Venda";
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 54);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRelatorioVendas,
            this.btnRelatorioProdutos,
            this.btnRelatorioVacinas});
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.Image = global::PetShop.Properties.Resources.report30x30;
            this.btnRelatorios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRelatorios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(86, 51);
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnRelatorioVendas
            // 
            this.btnRelatorioVendas.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorioVendas.Image = global::PetShop.Properties.Resources.caixa30x30;
            this.btnRelatorioVendas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRelatorioVendas.Name = "btnRelatorioVendas";
            this.btnRelatorioVendas.Size = new System.Drawing.Size(228, 36);
            this.btnRelatorioVendas.Text = "Relatório de Vendas";
            this.btnRelatorioVendas.Click += new System.EventHandler(this.btnRelatorioVendas_Click);
            // 
            // btnRelatorioProdutos
            // 
            this.btnRelatorioProdutos.Image = global::PetShop.Properties.Resources.produtos30x30;
            this.btnRelatorioProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRelatorioProdutos.Name = "btnRelatorioProdutos";
            this.btnRelatorioProdutos.Size = new System.Drawing.Size(228, 36);
            this.btnRelatorioProdutos.Text = "Relatório de Produtos";
            this.btnRelatorioProdutos.Click += new System.EventHandler(this.btnRelatorioProdutos_Click);
            // 
            // btnRelatorioVacinas
            // 
            this.btnRelatorioVacinas.Image = global::PetShop.Properties.Resources.vacina30x30;
            this.btnRelatorioVacinas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRelatorioVacinas.Name = "btnRelatorioVacinas";
            this.btnRelatorioVacinas.Size = new System.Drawing.Size(228, 36);
            this.btnRelatorioVacinas.Text = "Relatório de Vacinas";
            this.btnRelatorioVacinas.Click += new System.EventHandler(this.btnRelatorioVacinas_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 54);
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.btnOpcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcoes.Image = global::PetShop.Properties.Resources.settings30x30;
            this.btnOpcoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOpcoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Size = new System.Drawing.Size(59, 51);
            this.btnOpcoes.Text = "Opções";
            this.btnOpcoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpcoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpcoes.ToolTipText = "Opções";
            this.btnOpcoes.Click += new System.EventHandler(this.btnOpcoes_Click);
            // 
            // status_rodape_principal
            // 
            this.status_rodape_principal.AllowMerge = false;
            this.status_rodape_principal.BackColor = System.Drawing.SystemColors.Window;
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
            this.toolStripStatus_data_completa.Size = new System.Drawing.Size(742, 22);
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
            this.toolStripStatus_agendamentos_atuais.Name = "toolStripStatus_agendamentos_atuais";
            this.toolStripStatus_agendamentos_atuais.Size = new System.Drawing.Size(184, 22);
            this.toolStripStatus_agendamentos_atuais.Text = "Agendamentos para hoje: ";
            this.toolStripStatus_agendamentos_atuais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatus_agendamentos_atuais.Click += new System.EventHandler(this.toolStripStatus_agendamentos_atuais_Click);
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
            this.toolStripStatus_nome_administrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatus_nome_administrador.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripStatus_nome_administrador.Name = "toolStripStatus_nome_administrador";
            this.toolStripStatus_nome_administrador.Size = new System.Drawing.Size(4, 22);
            // 
            // toolStripStatus_nome_sistema
            // 
            this.toolStripStatus_nome_sistema.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatus_nome_sistema.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatus_nome_sistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus_nome_sistema.Name = "toolStripStatus_nome_sistema";
            this.toolStripStatus_nome_sistema.Size = new System.Drawing.Size(109, 22);
            this.toolStripStatus_nome_sistema.Text = "Pet Shop 1.0.2";
            this.toolStripStatus_nome_sistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // horario_atual
            // 
            this.horario_atual.Enabled = true;
            this.horario_atual.Interval = 1000;
            this.horario_atual.Tick += new System.EventHandler(this.Horario_atual_Tick);
            // 
            // TimerAgendamentos
            // 
            this.TimerAgendamentos.Enabled = true;
            this.TimerAgendamentos.Tick += new System.EventHandler(this.TimerAgendamentos_Tick);
            // 
            // timerDataAtual
            // 
            this.timerDataAtual.Interval = 3600000;
            this.timerDataAtual.Tick += new System.EventHandler(this.timerDataAtual_Tick);
            // 
            // timerBackup
            // 
            this.timerBackup.Enabled = true;
            this.timerBackup.Interval = 1800000;
            this.timerBackup.Tick += new System.EventHandler(this.timerBackup_Tick);
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
        private System.Windows.Forms.ToolStripButton btnVacinas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Timer TimerAgendamentos;
        private System.Windows.Forms.Timer timerDataAtual;
        private System.Windows.Forms.ToolStripButton btnVacinacao;
        private System.Windows.Forms.ToolStripButton btnVenda;
        private System.Windows.Forms.ToolStripButton btnServicos;
        private System.Windows.Forms.ToolStripDropDownButton btnRelatorios;
        private System.Windows.Forms.ToolStripMenuItem btnRelatorioVendas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem btnRelatorioProdutos;
        private System.Windows.Forms.ToolStripMenuItem btnRelatorioVacinas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnOpcoes;
        private System.Windows.Forms.Timer timerBackup;
    }
}

