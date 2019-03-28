namespace PetShop
{
    partial class AdicionarEditarFornecedor
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
            this.labelTipoFornecimento = new System.Windows.Forms.Label();
            this.tipoFornecimento = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnAdicionarEditarFornecedor = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.enderecos_contato = new System.Windows.Forms.TabPage();
            this.labelFornecedorCelular = new System.Windows.Forms.Label();
            this.celular = new System.Windows.Forms.MaskedTextBox();
            this.cep = new System.Windows.Forms.MaskedTextBox();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.cnpj = new System.Windows.Forms.MaskedTextBox();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.labelFornecedorCnpj = new System.Windows.Forms.Label();
            this.labelFornecedorCpf = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.labelFornecedorEmail = new System.Windows.Forms.Label();
            this.labelFornecedorTelefone = new System.Windows.Forms.Label();
            this.labelFornecedorCep = new System.Windows.Forms.Label();
            this.uf = new System.Windows.Forms.ComboBox();
            this.labelFornecedorUf = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.TextBox();
            this.labelFornecedorCidade = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.TextBox();
            this.labelFornecedorBairro = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.TextBox();
            this.labelFornecedorEndereco = new System.Windows.Forms.Label();
            this.apelido = new System.Windows.Forms.TextBox();
            this.labelFornecedorApelido = new System.Windows.Forms.Label();
            this.informacoes_observacoes = new System.Windows.Forms.TabPage();
            this.observacoes = new System.Windows.Forms.RichTextBox();
            this.nomeCompleto = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.enderecos_contato.SuspendLayout();
            this.informacoes_observacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTipoFornecimento
            // 
            this.labelTipoFornecimento.AutoSize = true;
            this.labelTipoFornecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoFornecimento.Location = new System.Drawing.Point(423, 23);
            this.labelTipoFornecimento.Name = "labelTipoFornecimento";
            this.labelTipoFornecimento.Size = new System.Drawing.Size(192, 22);
            this.labelTipoFornecimento.TabIndex = 20;
            this.labelTipoFornecimento.Text = "Tipo de Fornecimento*";
            // 
            // tipoFornecimento
            // 
            this.tipoFornecimento.BackColor = System.Drawing.SystemColors.Window;
            this.tipoFornecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoFornecimento.Location = new System.Drawing.Point(427, 48);
            this.tipoFornecimento.MaxLength = 500;
            this.tipoFornecimento.Name = "tipoFornecimento";
            this.tipoFornecimento.Size = new System.Drawing.Size(270, 22);
            this.tipoFornecimento.TabIndex = 19;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::PetShop.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(36, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 52);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnAdicionarEditarFornecedor
            // 
            this.BtnAdicionarEditarFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdicionarEditarFornecedor.AutoSize = true;
            this.BtnAdicionarEditarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionarEditarFornecedor.Image = global::PetShop.Properties.Resources.adicionar;
            this.BtnAdicionarEditarFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdicionarEditarFornecedor.Location = new System.Drawing.Point(651, 403);
            this.BtnAdicionarEditarFornecedor.Name = "BtnAdicionarEditarFornecedor";
            this.BtnAdicionarEditarFornecedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAdicionarEditarFornecedor.Size = new System.Drawing.Size(50, 52);
            this.BtnAdicionarEditarFornecedor.TabIndex = 16;
            this.BtnAdicionarEditarFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdicionarEditarFornecedor.UseVisualStyleBackColor = true;
            this.BtnAdicionarEditarFornecedor.Click += new System.EventHandler(this.BtnAdicionarEditarFornecedor_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.enderecos_contato);
            this.tabControl.Controls.Add(this.informacoes_observacoes);
            this.tabControl.Location = new System.Drawing.Point(36, 90);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(665, 307);
            this.tabControl.TabIndex = 18;
            this.tabControl.Tag = "";
            // 
            // enderecos_contato
            // 
            this.enderecos_contato.BackColor = System.Drawing.Color.WhiteSmoke;
            this.enderecos_contato.Controls.Add(this.labelFornecedorCelular);
            this.enderecos_contato.Controls.Add(this.celular);
            this.enderecos_contato.Controls.Add(this.cep);
            this.enderecos_contato.Controls.Add(this.telefone);
            this.enderecos_contato.Controls.Add(this.cnpj);
            this.enderecos_contato.Controls.Add(this.cpf);
            this.enderecos_contato.Controls.Add(this.labelFornecedorCnpj);
            this.enderecos_contato.Controls.Add(this.labelFornecedorCpf);
            this.enderecos_contato.Controls.Add(this.email);
            this.enderecos_contato.Controls.Add(this.labelFornecedorEmail);
            this.enderecos_contato.Controls.Add(this.labelFornecedorTelefone);
            this.enderecos_contato.Controls.Add(this.labelFornecedorCep);
            this.enderecos_contato.Controls.Add(this.uf);
            this.enderecos_contato.Controls.Add(this.labelFornecedorUf);
            this.enderecos_contato.Controls.Add(this.cidade);
            this.enderecos_contato.Controls.Add(this.labelFornecedorCidade);
            this.enderecos_contato.Controls.Add(this.bairro);
            this.enderecos_contato.Controls.Add(this.labelFornecedorBairro);
            this.enderecos_contato.Controls.Add(this.endereco);
            this.enderecos_contato.Controls.Add(this.labelFornecedorEndereco);
            this.enderecos_contato.Controls.Add(this.apelido);
            this.enderecos_contato.Controls.Add(this.labelFornecedorApelido);
            this.enderecos_contato.Location = new System.Drawing.Point(4, 22);
            this.enderecos_contato.Name = "enderecos_contato";
            this.enderecos_contato.Padding = new System.Windows.Forms.Padding(3);
            this.enderecos_contato.Size = new System.Drawing.Size(657, 281);
            this.enderecos_contato.TabIndex = 0;
            this.enderecos_contato.Text = "Endereço e Contato";
            // 
            // labelFornecedorCelular
            // 
            this.labelFornecedorCelular.AutoSize = true;
            this.labelFornecedorCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorCelular.Location = new System.Drawing.Point(192, 171);
            this.labelFornecedorCelular.Name = "labelFornecedorCelular";
            this.labelFornecedorCelular.Size = new System.Drawing.Size(54, 18);
            this.labelFornecedorCelular.TabIndex = 33;
            this.labelFornecedorCelular.Text = "Celular";
            // 
            // celular
            // 
            this.celular.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.celular.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celular.Location = new System.Drawing.Point(195, 191);
            this.celular.Mask = "(00)90000-0000";
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(125, 22);
            this.celular.TabIndex = 32;
            this.celular.Click += new System.EventHandler(this.CadastroFornecedorCelular_Click);
            // 
            // cep
            // 
            this.cep.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.cep.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cep.Location = new System.Drawing.Point(550, 139);
            this.cep.Mask = "00000-000";
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(87, 22);
            this.cep.TabIndex = 31;
            this.cep.Click += new System.EventHandler(this.CadastroFornecedorCep_Click);
            // 
            // telefone
            // 
            this.telefone.BackColor = System.Drawing.SystemColors.Window;
            this.telefone.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.telefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(18, 191);
            this.telefone.Mask = "(00)0000-0000";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(125, 22);
            this.telefone.TabIndex = 28;
            this.telefone.Click += new System.EventHandler(this.CadastroFornecedorTelefone_Click);
            // 
            // cnpj
            // 
            this.cnpj.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.cnpj.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpj.Location = new System.Drawing.Point(382, 191);
            this.cnpj.Mask = "00.000.000/0000-00";
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(100, 22);
            this.cnpj.TabIndex = 27;
            this.cnpj.Click += new System.EventHandler(this.CadastroFornecedorCnpj_Click);
            // 
            // cpf
            // 
            this.cpf.BackColor = System.Drawing.SystemColors.Window;
            this.cpf.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.cpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(537, 191);
            this.cpf.Mask = "000.000.000-00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(100, 22);
            this.cpf.TabIndex = 26;
            this.cpf.Click += new System.EventHandler(this.CadastroFornecedorCpf_Click);
            // 
            // labelFornecedorCnpj
            // 
            this.labelFornecedorCnpj.AutoSize = true;
            this.labelFornecedorCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorCnpj.Location = new System.Drawing.Point(379, 171);
            this.labelFornecedorCnpj.Name = "labelFornecedorCnpj";
            this.labelFornecedorCnpj.Size = new System.Drawing.Size(69, 18);
            this.labelFornecedorCnpj.TabIndex = 24;
            this.labelFornecedorCnpj.Text = "N° CNPJ";
            // 
            // labelFornecedorCpf
            // 
            this.labelFornecedorCpf.AutoSize = true;
            this.labelFornecedorCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorCpf.Location = new System.Drawing.Point(534, 171);
            this.labelFornecedorCpf.Name = "labelFornecedorCpf";
            this.labelFornecedorCpf.Size = new System.Drawing.Size(65, 18);
            this.labelFornecedorCpf.TabIndex = 22;
            this.labelFornecedorCpf.Text = "N° CPF*";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(18, 245);
            this.email.MaxLength = 500;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(351, 22);
            this.email.TabIndex = 21;
            // 
            // labelFornecedorEmail
            // 
            this.labelFornecedorEmail.AutoSize = true;
            this.labelFornecedorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorEmail.Location = new System.Drawing.Point(15, 225);
            this.labelFornecedorEmail.Name = "labelFornecedorEmail";
            this.labelFornecedorEmail.Size = new System.Drawing.Size(50, 18);
            this.labelFornecedorEmail.TabIndex = 20;
            this.labelFornecedorEmail.Text = "E-mail";
            // 
            // labelFornecedorTelefone
            // 
            this.labelFornecedorTelefone.AutoSize = true;
            this.labelFornecedorTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorTelefone.Location = new System.Drawing.Point(15, 171);
            this.labelFornecedorTelefone.Name = "labelFornecedorTelefone";
            this.labelFornecedorTelefone.Size = new System.Drawing.Size(71, 18);
            this.labelFornecedorTelefone.TabIndex = 12;
            this.labelFornecedorTelefone.Text = "Telefone*";
            // 
            // labelFornecedorCep
            // 
            this.labelFornecedorCep.AutoSize = true;
            this.labelFornecedorCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorCep.Location = new System.Drawing.Point(547, 118);
            this.labelFornecedorCep.Name = "labelFornecedorCep";
            this.labelFornecedorCep.Size = new System.Drawing.Size(39, 18);
            this.labelFornecedorCep.TabIndex = 10;
            this.labelFornecedorCep.Text = "CEP";
            // 
            // uf
            // 
            this.uf.BackColor = System.Drawing.SystemColors.Window;
            this.uf.DropDownHeight = 85;
            this.uf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uf.FormattingEnabled = true;
            this.uf.IntegralHeight = false;
            this.uf.ItemHeight = 16;
            this.uf.Items.AddRange(new object[] {
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
            this.uf.Location = new System.Drawing.Point(450, 139);
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(62, 24);
            this.uf.TabIndex = 9;
            // 
            // labelFornecedorUf
            // 
            this.labelFornecedorUf.AutoSize = true;
            this.labelFornecedorUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorUf.Location = new System.Drawing.Point(447, 118);
            this.labelFornecedorUf.Name = "labelFornecedorUf";
            this.labelFornecedorUf.Size = new System.Drawing.Size(34, 18);
            this.labelFornecedorUf.TabIndex = 8;
            this.labelFornecedorUf.Text = "UF*";
            // 
            // cidade
            // 
            this.cidade.BackColor = System.Drawing.SystemColors.Window;
            this.cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade.Location = new System.Drawing.Point(281, 139);
            this.cidade.MaxLength = 500;
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(140, 22);
            this.cidade.TabIndex = 7;
            // 
            // labelFornecedorCidade
            // 
            this.labelFornecedorCidade.AutoSize = true;
            this.labelFornecedorCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorCidade.Location = new System.Drawing.Point(278, 118);
            this.labelFornecedorCidade.Name = "labelFornecedorCidade";
            this.labelFornecedorCidade.Size = new System.Drawing.Size(60, 18);
            this.labelFornecedorCidade.TabIndex = 6;
            this.labelFornecedorCidade.Text = "Cidade*";
            // 
            // bairro
            // 
            this.bairro.BackColor = System.Drawing.SystemColors.Window;
            this.bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairro.Location = new System.Drawing.Point(18, 139);
            this.bairro.MaxLength = 500;
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(241, 22);
            this.bairro.TabIndex = 5;
            // 
            // labelFornecedorBairro
            // 
            this.labelFornecedorBairro.AutoSize = true;
            this.labelFornecedorBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorBairro.Location = new System.Drawing.Point(15, 118);
            this.labelFornecedorBairro.Name = "labelFornecedorBairro";
            this.labelFornecedorBairro.Size = new System.Drawing.Size(54, 18);
            this.labelFornecedorBairro.TabIndex = 4;
            this.labelFornecedorBairro.Text = "Bairro*";
            // 
            // endereco
            // 
            this.endereco.BackColor = System.Drawing.SystemColors.Window;
            this.endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco.Location = new System.Drawing.Point(18, 86);
            this.endereco.MaxLength = 500;
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(619, 22);
            this.endereco.TabIndex = 3;
            // 
            // labelFornecedorEndereco
            // 
            this.labelFornecedorEndereco.AutoSize = true;
            this.labelFornecedorEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorEndereco.Location = new System.Drawing.Point(15, 66);
            this.labelFornecedorEndereco.Name = "labelFornecedorEndereco";
            this.labelFornecedorEndereco.Size = new System.Drawing.Size(136, 18);
            this.labelFornecedorEndereco.TabIndex = 2;
            this.labelFornecedorEndereco.Text = "Nome da Rua / AV*";
            // 
            // apelido
            // 
            this.apelido.BackColor = System.Drawing.SystemColors.Window;
            this.apelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apelido.Location = new System.Drawing.Point(18, 36);
            this.apelido.MaxLength = 500;
            this.apelido.Name = "apelido";
            this.apelido.Size = new System.Drawing.Size(619, 22);
            this.apelido.TabIndex = 1;
            // 
            // labelFornecedorApelido
            // 
            this.labelFornecedorApelido.AutoSize = true;
            this.labelFornecedorApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorApelido.Location = new System.Drawing.Point(15, 16);
            this.labelFornecedorApelido.Name = "labelFornecedorApelido";
            this.labelFornecedorApelido.Size = new System.Drawing.Size(169, 18);
            this.labelFornecedorApelido.TabIndex = 0;
            this.labelFornecedorApelido.Text = "Nome Fantasia / Apelido";
            // 
            // informacoes_observacoes
            // 
            this.informacoes_observacoes.Controls.Add(this.observacoes);
            this.informacoes_observacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacoes_observacoes.Location = new System.Drawing.Point(4, 22);
            this.informacoes_observacoes.Name = "informacoes_observacoes";
            this.informacoes_observacoes.Padding = new System.Windows.Forms.Padding(3);
            this.informacoes_observacoes.Size = new System.Drawing.Size(657, 281);
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
            this.observacoes.Size = new System.Drawing.Size(645, 269);
            this.observacoes.TabIndex = 0;
            this.observacoes.Text = "";
            // 
            // nomeCompleto
            // 
            this.nomeCompleto.BackColor = System.Drawing.SystemColors.Info;
            this.nomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCompleto.Location = new System.Drawing.Point(40, 48);
            this.nomeCompleto.MaxLength = 500;
            this.nomeCompleto.Name = "nomeCompleto";
            this.nomeCompleto.Size = new System.Drawing.Size(332, 22);
            this.nomeCompleto.TabIndex = 15;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(36, 23);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(186, 22);
            this.labelNome.TabIndex = 14;
            this.labelNome.Text = "Nome do Fornecedor*";
            // 
            // AdicionarEditarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(736, 479);
            this.Controls.Add(this.labelTipoFornecimento);
            this.Controls.Add(this.tipoFornecimento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnAdicionarEditarFornecedor);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.nomeCompleto);
            this.Controls.Add(this.labelNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarEditarFornecedor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AdicionarEditarFornecedor_Load);
            this.tabControl.ResumeLayout(false);
            this.enderecos_contato.ResumeLayout(false);
            this.enderecos_contato.PerformLayout();
            this.informacoes_observacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTipoFornecimento;
        private System.Windows.Forms.TextBox tipoFornecimento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnAdicionarEditarFornecedor;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage enderecos_contato;
        private System.Windows.Forms.Label labelFornecedorCelular;
        private System.Windows.Forms.MaskedTextBox celular;
        private System.Windows.Forms.MaskedTextBox cep;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.MaskedTextBox cnpj;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.Label labelFornecedorCnpj;
        private System.Windows.Forms.Label labelFornecedorCpf;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label labelFornecedorEmail;
        private System.Windows.Forms.Label labelFornecedorTelefone;
        private System.Windows.Forms.Label labelFornecedorCep;
        private System.Windows.Forms.ComboBox uf;
        private System.Windows.Forms.Label labelFornecedorUf;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label labelFornecedorCidade;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.Label labelFornecedorBairro;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.Label labelFornecedorEndereco;
        private System.Windows.Forms.TextBox apelido;
        private System.Windows.Forms.Label labelFornecedorApelido;
        private System.Windows.Forms.TabPage informacoes_observacoes;
        private System.Windows.Forms.RichTextBox observacoes;
        private System.Windows.Forms.TextBox nomeCompleto;
        private System.Windows.Forms.Label labelNome;
    }
}