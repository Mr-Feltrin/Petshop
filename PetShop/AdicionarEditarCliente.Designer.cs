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
            this.labelNomeCompleto = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.combBoxTipo = new System.Windows.Forms.ComboBox();
            this.tabDadosCliente = new System.Windows.Forms.TabControl();
            this.enderecosContato = new System.Windows.Forms.TabPage();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneSecundario = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefonePrimario = new System.Windows.Forms.MaskedTextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.labelCnpj = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.labelCelular = new System.Windows.Forms.Label();
            this.labelTelefoneSecundario = new System.Windows.Forms.Label();
            this.labelTelefonePrimario = new System.Windows.Forms.Label();
            this.labelCep = new System.Windows.Forms.Label();
            this.combBoxUf = new System.Windows.Forms.ComboBox();
            this.labelUf = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.labelApelido = new System.Windows.Forms.Label();
            this.informacoes_observacoes = new System.Windows.Forms.TabPage();
            this.observacoes = new System.Windows.Forms.RichTextBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabDadosCliente.SuspendLayout();
            this.enderecosContato.SuspendLayout();
            this.informacoes_observacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNomeCompleto
            // 
            this.labelNomeCompleto.AutoSize = true;
            this.labelNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCompleto.Location = new System.Drawing.Point(30, 22);
            this.labelNomeCompleto.Name = "labelNomeCompleto";
            this.labelNomeCompleto.Size = new System.Drawing.Size(211, 22);
            this.labelNomeCompleto.TabIndex = 0;
            this.labelNomeCompleto.Text = "Nome / Razão Completo*";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.BackColor = System.Drawing.SystemColors.Info;
            this.txtNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompleto.Location = new System.Drawing.Point(34, 47);
            this.txtNomeCompleto.MaxLength = 500;
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(332, 22);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.Location = new System.Drawing.Point(448, 20);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(250, 22);
            this.labelTipo.TabIndex = 2;
            this.labelTipo.Text = "Segmento do Cliente ou Tipo*";
            // 
            // combBoxTipo
            // 
            this.combBoxTipo.BackColor = System.Drawing.SystemColors.Window;
            this.combBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combBoxTipo.FormattingEnabled = true;
            this.combBoxTipo.Items.AddRange(new object[] {
            "Cliente Comum",
            "Cliente Fixo",
            "Cliente Especial",
            "Funcionário",
            "Não Atender"});
            this.combBoxTipo.Location = new System.Drawing.Point(452, 45);
            this.combBoxTipo.Name = "combBoxTipo";
            this.combBoxTipo.Size = new System.Drawing.Size(243, 24);
            this.combBoxTipo.TabIndex = 3;
            // 
            // tabDadosCliente
            // 
            this.tabDadosCliente.Controls.Add(this.enderecosContato);
            this.tabDadosCliente.Controls.Add(this.informacoes_observacoes);
            this.tabDadosCliente.Location = new System.Drawing.Point(34, 89);
            this.tabDadosCliente.Name = "tabDadosCliente";
            this.tabDadosCliente.SelectedIndex = 0;
            this.tabDadosCliente.Size = new System.Drawing.Size(665, 326);
            this.tabDadosCliente.TabIndex = 4;
            this.tabDadosCliente.Tag = "";
            // 
            // enderecosContato
            // 
            this.enderecosContato.BackColor = System.Drawing.Color.WhiteSmoke;
            this.enderecosContato.Controls.Add(this.txtCep);
            this.enderecosContato.Controls.Add(this.txtCelular);
            this.enderecosContato.Controls.Add(this.txtTelefoneSecundario);
            this.enderecosContato.Controls.Add(this.txtTelefonePrimario);
            this.enderecosContato.Controls.Add(this.txtCnpj);
            this.enderecosContato.Controls.Add(this.txtCpf);
            this.enderecosContato.Controls.Add(this.labelCnpj);
            this.enderecosContato.Controls.Add(this.labelCpf);
            this.enderecosContato.Controls.Add(this.txtEmail);
            this.enderecosContato.Controls.Add(this.labelEmail);
            this.enderecosContato.Controls.Add(this.txtComplemento);
            this.enderecosContato.Controls.Add(this.labelComplemento);
            this.enderecosContato.Controls.Add(this.labelCelular);
            this.enderecosContato.Controls.Add(this.labelTelefoneSecundario);
            this.enderecosContato.Controls.Add(this.labelTelefonePrimario);
            this.enderecosContato.Controls.Add(this.labelCep);
            this.enderecosContato.Controls.Add(this.combBoxUf);
            this.enderecosContato.Controls.Add(this.labelUf);
            this.enderecosContato.Controls.Add(this.txtCidade);
            this.enderecosContato.Controls.Add(this.labelCidade);
            this.enderecosContato.Controls.Add(this.txtBairro);
            this.enderecosContato.Controls.Add(this.labelBairro);
            this.enderecosContato.Controls.Add(this.txtEndereco);
            this.enderecosContato.Controls.Add(this.labelEndereco);
            this.enderecosContato.Controls.Add(this.txtApelido);
            this.enderecosContato.Controls.Add(this.labelApelido);
            this.enderecosContato.Location = new System.Drawing.Point(4, 22);
            this.enderecosContato.Name = "enderecosContato";
            this.enderecosContato.Padding = new System.Windows.Forms.Padding(3);
            this.enderecosContato.Size = new System.Drawing.Size(657, 300);
            this.enderecosContato.TabIndex = 0;
            this.enderecosContato.Text = "Endereço e Contato";
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.SystemColors.Window;
            this.txtCep.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtCep.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(550, 139);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(87, 22);
            this.txtCep.TabIndex = 11;
            this.txtCep.Click += new System.EventHandler(this.Cadastro_cliente_cep_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtCelular.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(328, 191);
            this.txtCelular.Mask = "(00)90000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(125, 22);
            this.txtCelular.TabIndex = 17;
            this.txtCelular.Click += new System.EventHandler(this.Cadastro_cliente_celular_Click);
            // 
            // txtTelefoneSecundario
            // 
            this.txtTelefoneSecundario.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtTelefoneSecundario.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefoneSecundario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneSecundario.Location = new System.Drawing.Point(172, 191);
            this.txtTelefoneSecundario.Mask = "(00)0000-0000";
            this.txtTelefoneSecundario.Name = "txtTelefoneSecundario";
            this.txtTelefoneSecundario.Size = new System.Drawing.Size(125, 22);
            this.txtTelefoneSecundario.TabIndex = 15;
            this.txtTelefoneSecundario.Click += new System.EventHandler(this.Cadastro_cliente_telefone_secundario_Click);
            // 
            // txtTelefonePrimario
            // 
            this.txtTelefonePrimario.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefonePrimario.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtTelefonePrimario.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefonePrimario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonePrimario.Location = new System.Drawing.Point(18, 191);
            this.txtTelefonePrimario.Mask = "(00)0000-0000";
            this.txtTelefonePrimario.Name = "txtTelefonePrimario";
            this.txtTelefonePrimario.Size = new System.Drawing.Size(125, 22);
            this.txtTelefonePrimario.TabIndex = 13;
            this.txtTelefonePrimario.Click += new System.EventHandler(this.Cadastro_cliente_telefone_primario_Click);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtCnpj.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(537, 244);
            this.txtCnpj.Mask = "00.000.000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(100, 22);
            this.txtCnpj.TabIndex = 25;
            this.txtCnpj.Click += new System.EventHandler(this.Cadastro_cliente_cnpj_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.SystemColors.Window;
            this.txtCpf.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(366, 244);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 22);
            this.txtCpf.TabIndex = 23;
            this.txtCpf.Click += new System.EventHandler(this.Cadastro_cliente_cpf_Click);
            // 
            // labelCnpj
            // 
            this.labelCnpj.AutoSize = true;
            this.labelCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelCnpj.Location = new System.Drawing.Point(534, 224);
            this.labelCnpj.Name = "labelCnpj";
            this.labelCnpj.Size = new System.Drawing.Size(69, 18);
            this.labelCnpj.TabIndex = 24;
            this.labelCnpj.Text = "N° CNPJ";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelCpf.Location = new System.Drawing.Point(363, 224);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(59, 18);
            this.labelCpf.TabIndex = 22;
            this.labelCpf.Text = "N° CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(18, 244);
            this.txtEmail.MaxLength = 500;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 22);
            this.txtEmail.TabIndex = 21;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelEmail.Location = new System.Drawing.Point(15, 224);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 18);
            this.labelEmail.TabIndex = 20;
            this.labelEmail.Text = "E-mail";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(481, 191);
            this.txtComplemento.MaxLength = 500;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(156, 22);
            this.txtComplemento.TabIndex = 19;
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelComplemento.Location = new System.Drawing.Point(478, 171);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(102, 18);
            this.labelComplemento.TabIndex = 18;
            this.labelComplemento.Text = "Complemento";
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelCelular.Location = new System.Drawing.Point(325, 171);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(75, 18);
            this.labelCelular.TabIndex = 16;
            this.labelCelular.Text = "N° Celular";
            // 
            // labelTelefoneSecundario
            // 
            this.labelTelefoneSecundario.AutoSize = true;
            this.labelTelefoneSecundario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelTelefoneSecundario.Location = new System.Drawing.Point(169, 171);
            this.labelTelefoneSecundario.Name = "labelTelefoneSecundario";
            this.labelTelefoneSecundario.Size = new System.Drawing.Size(83, 18);
            this.labelTelefoneSecundario.TabIndex = 14;
            this.labelTelefoneSecundario.Text = "2° Telefone";
            // 
            // labelTelefonePrimario
            // 
            this.labelTelefonePrimario.AutoSize = true;
            this.labelTelefonePrimario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefonePrimario.Location = new System.Drawing.Point(15, 171);
            this.labelTelefonePrimario.Name = "labelTelefonePrimario";
            this.labelTelefonePrimario.Size = new System.Drawing.Size(89, 18);
            this.labelTelefonePrimario.TabIndex = 12;
            this.labelTelefonePrimario.Text = "1° Telefone*";
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCep.Location = new System.Drawing.Point(547, 118);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(45, 18);
            this.labelCep.TabIndex = 10;
            this.labelCep.Text = "CEP*";
            // 
            // combBoxUf
            // 
            this.combBoxUf.BackColor = System.Drawing.SystemColors.Window;
            this.combBoxUf.DropDownHeight = 85;
            this.combBoxUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combBoxUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combBoxUf.FormattingEnabled = true;
            this.combBoxUf.IntegralHeight = false;
            this.combBoxUf.ItemHeight = 16;
            this.combBoxUf.Items.AddRange(new object[] {
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
            this.combBoxUf.Location = new System.Drawing.Point(450, 139);
            this.combBoxUf.Name = "combBoxUf";
            this.combBoxUf.Size = new System.Drawing.Size(62, 24);
            this.combBoxUf.TabIndex = 9;
            // 
            // labelUf
            // 
            this.labelUf.AutoSize = true;
            this.labelUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUf.Location = new System.Drawing.Point(447, 118);
            this.labelUf.Name = "labelUf";
            this.labelUf.Size = new System.Drawing.Size(34, 18);
            this.labelUf.TabIndex = 8;
            this.labelUf.Text = "UF*";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(281, 139);
            this.txtCidade.MaxLength = 500;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(140, 22);
            this.txtCidade.TabIndex = 7;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidade.Location = new System.Drawing.Point(278, 118);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(60, 18);
            this.labelCidade.TabIndex = 6;
            this.labelCidade.Text = "Cidade*";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.Window;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(18, 139);
            this.txtBairro.MaxLength = 500;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(241, 22);
            this.txtBairro.TabIndex = 5;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairro.Location = new System.Drawing.Point(15, 118);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(54, 18);
            this.labelBairro.TabIndex = 4;
            this.labelBairro.Text = "Bairro*";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(18, 86);
            this.txtEndereco.MaxLength = 500;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(619, 22);
            this.txtEndereco.TabIndex = 3;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(15, 66);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(136, 18);
            this.labelEndereco.TabIndex = 2;
            this.labelEndereco.Text = "Nome da Rua / AV*";
            // 
            // txtApelido
            // 
            this.txtApelido.BackColor = System.Drawing.SystemColors.Window;
            this.txtApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApelido.Location = new System.Drawing.Point(18, 36);
            this.txtApelido.MaxLength = 500;
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(619, 22);
            this.txtApelido.TabIndex = 1;
            // 
            // labelApelido
            // 
            this.labelApelido.AutoSize = true;
            this.labelApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApelido.Location = new System.Drawing.Point(15, 16);
            this.labelApelido.Name = "labelApelido";
            this.labelApelido.Size = new System.Drawing.Size(169, 18);
            this.labelApelido.TabIndex = 0;
            this.labelApelido.Text = "Nome Fantasia / Apelido";
            // 
            // informacoes_observacoes
            // 
            this.informacoes_observacoes.Controls.Add(this.observacoes);
            this.informacoes_observacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacoes_observacoes.Location = new System.Drawing.Point(4, 22);
            this.informacoes_observacoes.Name = "informacoes_observacoes";
            this.informacoes_observacoes.Padding = new System.Windows.Forms.Padding(3);
            this.informacoes_observacoes.Size = new System.Drawing.Size(657, 300);
            this.informacoes_observacoes.TabIndex = 1;
            this.informacoes_observacoes.Text = "Informações / Observações";
            this.informacoes_observacoes.UseVisualStyleBackColor = true;
            // 
            // observacoes
            // 
            this.observacoes.BackColor = System.Drawing.SystemColors.Window;
            this.observacoes.Location = new System.Drawing.Point(6, 6);
            this.observacoes.MaxLength = 500;
            this.observacoes.Name = "observacoes";
            this.observacoes.Size = new System.Drawing.Size(645, 288);
            this.observacoes.TabIndex = 0;
            this.observacoes.Text = "";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdicionar.AutoSize = true;
            this.BtnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionar.Image = global::PetShop.Properties.Resources.adicionar;
            this.BtnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdicionar.Location = new System.Drawing.Point(649, 424);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAdicionar.Size = new System.Drawing.Size(50, 52);
            this.BtnAdicionar.TabIndex = 6;
            this.BtnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionarEditarCliente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::PetShop.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(34, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 52);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.cadastro_cliente_cancelar_Click);
            // 
            // AdicionarEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(728, 496);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.tabDadosCliente);
            this.Controls.Add(this.combBoxTipo);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.labelNomeCompleto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarEditarCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AdicionarEditarCliente_Load);
            this.tabDadosCliente.ResumeLayout(false);
            this.enderecosContato.ResumeLayout(false);
            this.enderecosContato.PerformLayout();
            this.informacoes_observacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNomeCompleto;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.ComboBox combBoxTipo;
        private System.Windows.Forms.TabControl tabDadosCliente;
        private System.Windows.Forms.TabPage enderecosContato;
        private System.Windows.Forms.TabPage informacoes_observacoes;
        private System.Windows.Forms.Label labelApelido;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelCnpj;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.Label labelCelular;
        private System.Windows.Forms.Label labelTelefoneSecundario;
        private System.Windows.Forms.Label labelTelefonePrimario;
        private System.Windows.Forms.Label labelCep;
        private System.Windows.Forms.ComboBox combBoxUf;
        private System.Windows.Forms.Label labelUf;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.RichTextBox observacoes;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.MaskedTextBox txtTelefoneSecundario;
        private System.Windows.Forms.MaskedTextBox txtTelefonePrimario;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtCep;
        internal System.Windows.Forms.TextBox txtNomeCompleto;
    }
}