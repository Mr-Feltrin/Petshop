using System;

namespace PetShop
{
    partial class AdicionarEditarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.cadastro_cliente_nome_completo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cadastro_cliente_tipo = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.enderecos_contato = new System.Windows.Forms.TabPage();
            this.cadastro_cliente_cep = new System.Windows.Forms.MaskedTextBox();
            this.cadastro_cliente_celular = new System.Windows.Forms.MaskedTextBox();
            this.cadastro_cliente_telefone_secundario = new System.Windows.Forms.MaskedTextBox();
            this.cadastro_cliente_telefone_primario = new System.Windows.Forms.MaskedTextBox();
            this.cadastro_cliente_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.cadastro_cliente_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label_adicionar_cliente_cnpj = new System.Windows.Forms.Label();
            this.label_adicionar_cliente_cpf = new System.Windows.Forms.Label();
            this.cadastro_cliente_email = new System.Windows.Forms.TextBox();
            this.label_adicionar_cliente_email = new System.Windows.Forms.Label();
            this.cadastro_cliente_complemento = new System.Windows.Forms.TextBox();
            this.label_adicionar_cliente_complemento = new System.Windows.Forms.Label();
            this.label_adicionar_cliente_celular = new System.Windows.Forms.Label();
            this.label_adicionar_cliente_telefone_secundario = new System.Windows.Forms.Label();
            this.label_adicionar_cliente_telefone_primario = new System.Windows.Forms.Label();
            this.label_adicionar_cliente_cep = new System.Windows.Forms.Label();
            this.cadastro_cliente_uf = new System.Windows.Forms.ComboBox();
            this.label_adicionar_cliente_uf = new System.Windows.Forms.Label();
            this.cadastro_cliente_cidade = new System.Windows.Forms.TextBox();
            this.label_adicionar_cliente_cidade = new System.Windows.Forms.Label();
            this.cadastro_cliente_bairro = new System.Windows.Forms.TextBox();
            this.label_adicionar_cliente_bairro = new System.Windows.Forms.Label();
            this.cadastro_cliente_endereco = new System.Windows.Forms.TextBox();
            this.label_adicionar_cliente_endereco = new System.Windows.Forms.Label();
            this.cadastro_cliente_nome_apelido = new System.Windows.Forms.TextBox();
            this.label_adicionar_cliente_nome = new System.Windows.Forms.Label();
            this.informacoes_observacoes = new System.Windows.Forms.TabPage();
            this.cadastro_cliente_observacoes = new System.Windows.Forms.RichTextBox();
            this.BtnAdicionarEditarCliente = new System.Windows.Forms.Button();
            this.cadastro_cliente_cancelar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.enderecos_contato.SuspendLayout();
            this.informacoes_observacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome / Razão Completo*";
            // 
            // cadastro_cliente_nome_completo
            // 
            this.cadastro_cliente_nome_completo.BackColor = System.Drawing.SystemColors.Info;
            this.cadastro_cliente_nome_completo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_nome_completo.Location = new System.Drawing.Point(34, 47);
            this.cadastro_cliente_nome_completo.MaxLength = 500;
            this.cadastro_cliente_nome_completo.Name = "cadastro_cliente_nome_completo";
            this.cadastro_cliente_nome_completo.Size = new System.Drawing.Size(332, 22);
            this.cadastro_cliente_nome_completo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Segmento do Cliente ou Tipo";
            // 
            // cadastro_cliente_tipo
            // 
            this.cadastro_cliente_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cadastro_cliente_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_tipo.FormattingEnabled = true;
            this.cadastro_cliente_tipo.Items.AddRange(new object[] {
            "Cliente Comum",
            "Cliente Fixo",
            "Cliente Especial",
            "Funcionário",
            "Não Atender"});
            this.cadastro_cliente_tipo.Location = new System.Drawing.Point(452, 45);
            this.cadastro_cliente_tipo.Name = "cadastro_cliente_tipo";
            this.cadastro_cliente_tipo.Size = new System.Drawing.Size(243, 24);
            this.cadastro_cliente_tipo.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.enderecos_contato);
            this.tabControl1.Controls.Add(this.informacoes_observacoes);
            this.tabControl1.Location = new System.Drawing.Point(34, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 326);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Tag = "";
            // 
            // enderecos_contato
            // 
            this.enderecos_contato.BackColor = System.Drawing.Color.WhiteSmoke;
            this.enderecos_contato.Controls.Add(this.cadastro_cliente_cep);
            this.enderecos_contato.Controls.Add(this.cadastro_cliente_celular);
            this.enderecos_contato.Controls.Add(this.cadastro_cliente_telefone_secundario);
            this.enderecos_contato.Controls.Add(this.cadastro_cliente_telefone_primario);
            this.enderecos_contato.Controls.Add(this.cadastro_cliente_cnpj);
            this.enderecos_contato.Controls.Add(this.cadastro_cliente_cpf);
            this.enderecos_contato.Controls.Add(this.label_adicionar_cliente_cnpj);
            this.enderecos_contato.Controls.Add(this.label_adicionar_cliente_cpf);
            this.enderecos_contato.Controls.Add(this.cadastro_cliente_email);
            this.enderecos_contato.Controls.Add(this.label_adicionar_cliente_email);
            this.enderecos_contato.Controls.Add(this.cadastro_cliente_complemento);
            this.enderecos_contato.Controls.Add(this.label_adicionar_cliente_complemento);
            this.enderecos_contato.Controls.Add(this.label_adicionar_cliente_celular);
            this.enderecos_contato.Controls.Add(this.label_adicionar_cliente_telefone_secundario);
            this.enderecos_contato.Controls.Add(this.label_adicionar_cliente_telefone_primario);
            this.enderecos_contato.Controls.Add(this.label_adicionar_cliente_cep);
            this.enderecos_contato.Controls.Add(this.cadastro_cliente_uf);
            this.enderecos_contato.Controls.Add(this.label_adicionar_cliente_uf);
            this.enderecos_contato.Controls.Add(this.cadastro_cliente_cidade);
            this.enderecos_contato.Controls.Add(this.label_adicionar_cliente_cidade);
            this.enderecos_contato.Controls.Add(this.cadastro_cliente_bairro);
            this.enderecos_contato.Controls.Add(this.label_adicionar_cliente_bairro);
            this.enderecos_contato.Controls.Add(this.cadastro_cliente_endereco);
            this.enderecos_contato.Controls.Add(this.label_adicionar_cliente_endereco);
            this.enderecos_contato.Controls.Add(this.cadastro_cliente_nome_apelido);
            this.enderecos_contato.Controls.Add(this.label_adicionar_cliente_nome);
            this.enderecos_contato.Location = new System.Drawing.Point(4, 22);
            this.enderecos_contato.Name = "enderecos_contato";
            this.enderecos_contato.Padding = new System.Windows.Forms.Padding(3);
            this.enderecos_contato.Size = new System.Drawing.Size(657, 300);
            this.enderecos_contato.TabIndex = 0;
            this.enderecos_contato.Text = "Endereços e Contato";
            // 
            // cadastro_cliente_cep
            // 
            this.cadastro_cliente_cep.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.cadastro_cliente_cep.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cadastro_cliente_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_cep.Location = new System.Drawing.Point(550, 139);
            this.cadastro_cliente_cep.Mask = "00000-000";
            this.cadastro_cliente_cep.Name = "cadastro_cliente_cep";
            this.cadastro_cliente_cep.Size = new System.Drawing.Size(87, 22);
            this.cadastro_cliente_cep.TabIndex = 31;
            this.cadastro_cliente_cep.Click += new System.EventHandler(this.Cadastro_cliente_cep_Click);
            // 
            // cadastro_cliente_celular
            // 
            this.cadastro_cliente_celular.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.cadastro_cliente_celular.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cadastro_cliente_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_celular.Location = new System.Drawing.Point(328, 191);
            this.cadastro_cliente_celular.Mask = "(00)90000-0000";
            this.cadastro_cliente_celular.Name = "cadastro_cliente_celular";
            this.cadastro_cliente_celular.Size = new System.Drawing.Size(125, 22);
            this.cadastro_cliente_celular.TabIndex = 30;
            this.cadastro_cliente_celular.Click += new System.EventHandler(this.Cadastro_cliente_celular_Click);
            // 
            // cadastro_cliente_telefone_secundario
            // 
            this.cadastro_cliente_telefone_secundario.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.cadastro_cliente_telefone_secundario.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cadastro_cliente_telefone_secundario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_telefone_secundario.Location = new System.Drawing.Point(172, 191);
            this.cadastro_cliente_telefone_secundario.Mask = "(00)0000-0000";
            this.cadastro_cliente_telefone_secundario.Name = "cadastro_cliente_telefone_secundario";
            this.cadastro_cliente_telefone_secundario.Size = new System.Drawing.Size(125, 22);
            this.cadastro_cliente_telefone_secundario.TabIndex = 29;
            this.cadastro_cliente_telefone_secundario.Click += new System.EventHandler(this.Cadastro_cliente_telefone_secundario_Click);
            // 
            // cadastro_cliente_telefone_primario
            // 
            this.cadastro_cliente_telefone_primario.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.cadastro_cliente_telefone_primario.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cadastro_cliente_telefone_primario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_telefone_primario.Location = new System.Drawing.Point(18, 191);
            this.cadastro_cliente_telefone_primario.Mask = "(00)0000-0000";
            this.cadastro_cliente_telefone_primario.Name = "cadastro_cliente_telefone_primario";
            this.cadastro_cliente_telefone_primario.Size = new System.Drawing.Size(125, 22);
            this.cadastro_cliente_telefone_primario.TabIndex = 28;
            this.cadastro_cliente_telefone_primario.Click += new System.EventHandler(this.Cadastro_cliente_telefone_primario_Click);
            // 
            // cadastro_cliente_cnpj
            // 
            this.cadastro_cliente_cnpj.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.cadastro_cliente_cnpj.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cadastro_cliente_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_cnpj.Location = new System.Drawing.Point(537, 244);
            this.cadastro_cliente_cnpj.Mask = "00.000.000/0000-00";
            this.cadastro_cliente_cnpj.Name = "cadastro_cliente_cnpj";
            this.cadastro_cliente_cnpj.Size = new System.Drawing.Size(100, 22);
            this.cadastro_cliente_cnpj.TabIndex = 27;
            this.cadastro_cliente_cnpj.Click += new System.EventHandler(this.Cadastro_cliente_cnpj_Click);
            // 
            // cadastro_cliente_cpf
            // 
            this.cadastro_cliente_cpf.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.cadastro_cliente_cpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cadastro_cliente_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_cpf.Location = new System.Drawing.Point(366, 244);
            this.cadastro_cliente_cpf.Mask = "000.000.000-00";
            this.cadastro_cliente_cpf.Name = "cadastro_cliente_cpf";
            this.cadastro_cliente_cpf.Size = new System.Drawing.Size(100, 22);
            this.cadastro_cliente_cpf.TabIndex = 26;
            this.cadastro_cliente_cpf.Click += new System.EventHandler(this.Cadastro_cliente_cpf_Click);
            // 
            // label_adicionar_cliente_cnpj
            // 
            this.label_adicionar_cliente_cnpj.AutoSize = true;
            this.label_adicionar_cliente_cnpj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adicionar_cliente_cnpj.Location = new System.Drawing.Point(534, 224);
            this.label_adicionar_cliente_cnpj.Name = "label_adicionar_cliente_cnpj";
            this.label_adicionar_cliente_cnpj.Size = new System.Drawing.Size(70, 17);
            this.label_adicionar_cliente_cnpj.TabIndex = 24;
            this.label_adicionar_cliente_cnpj.Text = "N° CNPJ";
            // 
            // label_adicionar_cliente_cpf
            // 
            this.label_adicionar_cliente_cpf.AutoSize = true;
            this.label_adicionar_cliente_cpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adicionar_cliente_cpf.Location = new System.Drawing.Point(363, 224);
            this.label_adicionar_cliente_cpf.Name = "label_adicionar_cliente_cpf";
            this.label_adicionar_cliente_cpf.Size = new System.Drawing.Size(66, 17);
            this.label_adicionar_cliente_cpf.TabIndex = 22;
            this.label_adicionar_cliente_cpf.Text = "N° CPF*";
            // 
            // cadastro_cliente_email
            // 
            this.cadastro_cliente_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_email.Location = new System.Drawing.Point(18, 244);
            this.cadastro_cliente_email.MaxLength = 500;
            this.cadastro_cliente_email.Name = "cadastro_cliente_email";
            this.cadastro_cliente_email.Size = new System.Drawing.Size(293, 22);
            this.cadastro_cliente_email.TabIndex = 21;
            // 
            // label_adicionar_cliente_email
            // 
            this.label_adicionar_cliente_email.AutoSize = true;
            this.label_adicionar_cliente_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adicionar_cliente_email.Location = new System.Drawing.Point(15, 224);
            this.label_adicionar_cliente_email.Name = "label_adicionar_cliente_email";
            this.label_adicionar_cliente_email.Size = new System.Drawing.Size(53, 17);
            this.label_adicionar_cliente_email.TabIndex = 20;
            this.label_adicionar_cliente_email.Text = "E-mail";
            // 
            // cadastro_cliente_complemento
            // 
            this.cadastro_cliente_complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_complemento.Location = new System.Drawing.Point(481, 191);
            this.cadastro_cliente_complemento.MaxLength = 500;
            this.cadastro_cliente_complemento.Name = "cadastro_cliente_complemento";
            this.cadastro_cliente_complemento.Size = new System.Drawing.Size(156, 22);
            this.cadastro_cliente_complemento.TabIndex = 19;
            // 
            // label_adicionar_cliente_complemento
            // 
            this.label_adicionar_cliente_complemento.AutoSize = true;
            this.label_adicionar_cliente_complemento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adicionar_cliente_complemento.Location = new System.Drawing.Point(478, 171);
            this.label_adicionar_cliente_complemento.Name = "label_adicionar_cliente_complemento";
            this.label_adicionar_cliente_complemento.Size = new System.Drawing.Size(108, 17);
            this.label_adicionar_cliente_complemento.TabIndex = 18;
            this.label_adicionar_cliente_complemento.Text = "Complemento";
            // 
            // label_adicionar_cliente_celular
            // 
            this.label_adicionar_cliente_celular.AutoSize = true;
            this.label_adicionar_cliente_celular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adicionar_cliente_celular.Location = new System.Drawing.Point(325, 171);
            this.label_adicionar_cliente_celular.Name = "label_adicionar_cliente_celular";
            this.label_adicionar_cliente_celular.Size = new System.Drawing.Size(82, 17);
            this.label_adicionar_cliente_celular.TabIndex = 16;
            this.label_adicionar_cliente_celular.Text = "N° Celular";
            // 
            // label_adicionar_cliente_telefone_secundario
            // 
            this.label_adicionar_cliente_telefone_secundario.AutoSize = true;
            this.label_adicionar_cliente_telefone_secundario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adicionar_cliente_telefone_secundario.Location = new System.Drawing.Point(169, 171);
            this.label_adicionar_cliente_telefone_secundario.Name = "label_adicionar_cliente_telefone_secundario";
            this.label_adicionar_cliente_telefone_secundario.Size = new System.Drawing.Size(90, 17);
            this.label_adicionar_cliente_telefone_secundario.TabIndex = 14;
            this.label_adicionar_cliente_telefone_secundario.Text = "2° Telefone";
            // 
            // label_adicionar_cliente_telefone_primario
            // 
            this.label_adicionar_cliente_telefone_primario.AutoSize = true;
            this.label_adicionar_cliente_telefone_primario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adicionar_cliente_telefone_primario.Location = new System.Drawing.Point(15, 171);
            this.label_adicionar_cliente_telefone_primario.Name = "label_adicionar_cliente_telefone_primario";
            this.label_adicionar_cliente_telefone_primario.Size = new System.Drawing.Size(97, 17);
            this.label_adicionar_cliente_telefone_primario.TabIndex = 12;
            this.label_adicionar_cliente_telefone_primario.Text = "1° Telefone*";
            // 
            // label_adicionar_cliente_cep
            // 
            this.label_adicionar_cliente_cep.AutoSize = true;
            this.label_adicionar_cliente_cep.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adicionar_cliente_cep.Location = new System.Drawing.Point(547, 118);
            this.label_adicionar_cliente_cep.Name = "label_adicionar_cliente_cep";
            this.label_adicionar_cliente_cep.Size = new System.Drawing.Size(46, 17);
            this.label_adicionar_cliente_cep.TabIndex = 10;
            this.label_adicionar_cliente_cep.Text = "CEP*";
            // 
            // cadastro_cliente_uf
            // 
            this.cadastro_cliente_uf.DropDownHeight = 85;
            this.cadastro_cliente_uf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cadastro_cliente_uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_uf.FormattingEnabled = true;
            this.cadastro_cliente_uf.IntegralHeight = false;
            this.cadastro_cliente_uf.ItemHeight = 16;
            this.cadastro_cliente_uf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "SB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cadastro_cliente_uf.Location = new System.Drawing.Point(450, 139);
            this.cadastro_cliente_uf.Name = "cadastro_cliente_uf";
            this.cadastro_cliente_uf.Size = new System.Drawing.Size(62, 24);
            this.cadastro_cliente_uf.TabIndex = 9;
            // 
            // label_adicionar_cliente_uf
            // 
            this.label_adicionar_cliente_uf.AutoSize = true;
            this.label_adicionar_cliente_uf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adicionar_cliente_uf.Location = new System.Drawing.Point(447, 118);
            this.label_adicionar_cliente_uf.Name = "label_adicionar_cliente_uf";
            this.label_adicionar_cliente_uf.Size = new System.Drawing.Size(35, 17);
            this.label_adicionar_cliente_uf.TabIndex = 8;
            this.label_adicionar_cliente_uf.Text = "UF*";
            // 
            // cadastro_cliente_cidade
            // 
            this.cadastro_cliente_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_cidade.Location = new System.Drawing.Point(281, 139);
            this.cadastro_cliente_cidade.MaxLength = 500;
            this.cadastro_cliente_cidade.Name = "cadastro_cliente_cidade";
            this.cadastro_cliente_cidade.Size = new System.Drawing.Size(140, 22);
            this.cadastro_cliente_cidade.TabIndex = 7;
            // 
            // label_adicionar_cliente_cidade
            // 
            this.label_adicionar_cliente_cidade.AutoSize = true;
            this.label_adicionar_cliente_cidade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adicionar_cliente_cidade.Location = new System.Drawing.Point(278, 118);
            this.label_adicionar_cliente_cidade.Name = "label_adicionar_cliente_cidade";
            this.label_adicionar_cliente_cidade.Size = new System.Drawing.Size(66, 17);
            this.label_adicionar_cliente_cidade.TabIndex = 6;
            this.label_adicionar_cliente_cidade.Text = "Cidade*";
            // 
            // cadastro_cliente_bairro
            // 
            this.cadastro_cliente_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_bairro.Location = new System.Drawing.Point(18, 139);
            this.cadastro_cliente_bairro.MaxLength = 500;
            this.cadastro_cliente_bairro.Name = "cadastro_cliente_bairro";
            this.cadastro_cliente_bairro.Size = new System.Drawing.Size(241, 22);
            this.cadastro_cliente_bairro.TabIndex = 5;
            // 
            // label_adicionar_cliente_bairro
            // 
            this.label_adicionar_cliente_bairro.AutoSize = true;
            this.label_adicionar_cliente_bairro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adicionar_cliente_bairro.Location = new System.Drawing.Point(15, 118);
            this.label_adicionar_cliente_bairro.Name = "label_adicionar_cliente_bairro";
            this.label_adicionar_cliente_bairro.Size = new System.Drawing.Size(62, 17);
            this.label_adicionar_cliente_bairro.TabIndex = 4;
            this.label_adicionar_cliente_bairro.Text = "Bairro*";
            // 
            // cadastro_cliente_endereco
            // 
            this.cadastro_cliente_endereco.BackColor = System.Drawing.SystemColors.Window;
            this.cadastro_cliente_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_endereco.Location = new System.Drawing.Point(18, 86);
            this.cadastro_cliente_endereco.MaxLength = 500;
            this.cadastro_cliente_endereco.Name = "cadastro_cliente_endereco";
            this.cadastro_cliente_endereco.Size = new System.Drawing.Size(619, 22);
            this.cadastro_cliente_endereco.TabIndex = 3;
            // 
            // label_adicionar_cliente_endereco
            // 
            this.label_adicionar_cliente_endereco.AutoSize = true;
            this.label_adicionar_cliente_endereco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adicionar_cliente_endereco.Location = new System.Drawing.Point(15, 66);
            this.label_adicionar_cliente_endereco.Name = "label_adicionar_cliente_endereco";
            this.label_adicionar_cliente_endereco.Size = new System.Drawing.Size(145, 17);
            this.label_adicionar_cliente_endereco.TabIndex = 2;
            this.label_adicionar_cliente_endereco.Text = "Nome da Rua / AV*";
            // 
            // cadastro_cliente_nome_apelido
            // 
            this.cadastro_cliente_nome_apelido.BackColor = System.Drawing.SystemColors.Window;
            this.cadastro_cliente_nome_apelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_nome_apelido.Location = new System.Drawing.Point(18, 36);
            this.cadastro_cliente_nome_apelido.MaxLength = 500;
            this.cadastro_cliente_nome_apelido.Name = "cadastro_cliente_nome_apelido";
            this.cadastro_cliente_nome_apelido.Size = new System.Drawing.Size(619, 22);
            this.cadastro_cliente_nome_apelido.TabIndex = 1;
            // 
            // label_adicionar_cliente_nome
            // 
            this.label_adicionar_cliente_nome.AutoSize = true;
            this.label_adicionar_cliente_nome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adicionar_cliente_nome.Location = new System.Drawing.Point(15, 16);
            this.label_adicionar_cliente_nome.Name = "label_adicionar_cliente_nome";
            this.label_adicionar_cliente_nome.Size = new System.Drawing.Size(183, 17);
            this.label_adicionar_cliente_nome.TabIndex = 0;
            this.label_adicionar_cliente_nome.Text = "Nome Fantasia / Apelido";
            // 
            // informacoes_observacoes
            // 
            this.informacoes_observacoes.Controls.Add(this.cadastro_cliente_observacoes);
            this.informacoes_observacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacoes_observacoes.Location = new System.Drawing.Point(4, 22);
            this.informacoes_observacoes.Name = "informacoes_observacoes";
            this.informacoes_observacoes.Padding = new System.Windows.Forms.Padding(3);
            this.informacoes_observacoes.Size = new System.Drawing.Size(657, 300);
            this.informacoes_observacoes.TabIndex = 1;
            this.informacoes_observacoes.Text = "Informações / Observações";
            this.informacoes_observacoes.UseVisualStyleBackColor = true;
            // 
            // cadastro_cliente_observacoes
            // 
            this.cadastro_cliente_observacoes.BackColor = System.Drawing.SystemColors.Info;
            this.cadastro_cliente_observacoes.Location = new System.Drawing.Point(6, 6);
            this.cadastro_cliente_observacoes.MaxLength = 500;
            this.cadastro_cliente_observacoes.Name = "cadastro_cliente_observacoes";
            this.cadastro_cliente_observacoes.Size = new System.Drawing.Size(645, 288);
            this.cadastro_cliente_observacoes.TabIndex = 0;
            this.cadastro_cliente_observacoes.Text = "";
            // 
            // BtnAdicionarEditarCliente
            // 
            this.BtnAdicionarEditarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdicionarEditarCliente.AutoSize = true;
            this.BtnAdicionarEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionarEditarCliente.Image = global::PetShop.Properties.Resources.adicionar;
            this.BtnAdicionarEditarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdicionarEditarCliente.Location = new System.Drawing.Point(649, 424);
            this.BtnAdicionarEditarCliente.Name = "BtnAdicionarEditarCliente";
            this.BtnAdicionarEditarCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAdicionarEditarCliente.Size = new System.Drawing.Size(50, 52);
            this.BtnAdicionarEditarCliente.TabIndex = 2;
            this.BtnAdicionarEditarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdicionarEditarCliente.UseVisualStyleBackColor = true;
            this.BtnAdicionarEditarCliente.Click += new System.EventHandler(this.BtnAdicionarEditarCliente_Click);
            // 
            // cadastro_cliente_cancelar
            // 
            this.cadastro_cliente_cancelar.AutoSize = true;
            this.cadastro_cliente_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cadastro_cliente_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro_cliente_cancelar.Image = global::PetShop.Properties.Resources.cancelar;
            this.cadastro_cliente_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastro_cliente_cancelar.Location = new System.Drawing.Point(34, 424);
            this.cadastro_cliente_cancelar.Name = "cadastro_cliente_cancelar";
            this.cadastro_cliente_cancelar.Size = new System.Drawing.Size(161, 52);
            this.cadastro_cliente_cancelar.TabIndex = 3;
            this.cadastro_cliente_cancelar.Text = "Cancelar";
            this.cadastro_cliente_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cadastro_cliente_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cadastro_cliente_cancelar.UseVisualStyleBackColor = true;
            this.cadastro_cliente_cancelar.Click += new System.EventHandler(this.cadastro_cliente_cancelar_Click);
            // 
            // AdicionarEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cadastro_cliente_cancelar;
            this.ClientSize = new System.Drawing.Size(728, 496);
            this.Controls.Add(this.cadastro_cliente_cancelar);
            this.Controls.Add(this.BtnAdicionarEditarCliente);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cadastro_cliente_tipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cadastro_cliente_nome_completo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarEditarCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AdicionarEditarCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.enderecos_contato.ResumeLayout(false);
            this.enderecos_contato.PerformLayout();
            this.informacoes_observacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cadastro_cliente_nome_completo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cadastro_cliente_tipo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage enderecos_contato;
        private System.Windows.Forms.TabPage informacoes_observacoes;
        private System.Windows.Forms.Label label_adicionar_cliente_nome;
        private System.Windows.Forms.TextBox cadastro_cliente_nome_apelido;
        private System.Windows.Forms.Button BtnAdicionarEditarCliente;
        private System.Windows.Forms.Button cadastro_cliente_cancelar;
        private System.Windows.Forms.Label label_adicionar_cliente_cnpj;
        private System.Windows.Forms.Label label_adicionar_cliente_cpf;
        private System.Windows.Forms.TextBox cadastro_cliente_email;
        private System.Windows.Forms.Label label_adicionar_cliente_email;
        private System.Windows.Forms.TextBox cadastro_cliente_complemento;
        private System.Windows.Forms.Label label_adicionar_cliente_complemento;
        private System.Windows.Forms.Label label_adicionar_cliente_celular;
        private System.Windows.Forms.Label label_adicionar_cliente_telefone_secundario;
        private System.Windows.Forms.Label label_adicionar_cliente_telefone_primario;
        private System.Windows.Forms.Label label_adicionar_cliente_cep;
        private System.Windows.Forms.ComboBox cadastro_cliente_uf;
        private System.Windows.Forms.Label label_adicionar_cliente_uf;
        private System.Windows.Forms.TextBox cadastro_cliente_cidade;
        private System.Windows.Forms.Label label_adicionar_cliente_cidade;
        private System.Windows.Forms.TextBox cadastro_cliente_bairro;
        private System.Windows.Forms.Label label_adicionar_cliente_bairro;
        private System.Windows.Forms.TextBox cadastro_cliente_endereco;
        private System.Windows.Forms.Label label_adicionar_cliente_endereco;
        private System.Windows.Forms.RichTextBox cadastro_cliente_observacoes;
        private System.Windows.Forms.MaskedTextBox cadastro_cliente_cpf;
        private System.Windows.Forms.MaskedTextBox cadastro_cliente_cnpj;
        private System.Windows.Forms.MaskedTextBox cadastro_cliente_telefone_secundario;
        private System.Windows.Forms.MaskedTextBox cadastro_cliente_telefone_primario;
        private System.Windows.Forms.MaskedTextBox cadastro_cliente_celular;
        private System.Windows.Forms.MaskedTextBox cadastro_cliente_cep;
    }
}