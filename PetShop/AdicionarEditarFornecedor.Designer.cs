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
            this.txtTipoFornecimento = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnAdicionarEditarFornecedor = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.enderecos_contato = new System.Windows.Forms.TabPage();
            this.labelFornecedorCelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.labelFornecedorCnpj = new System.Windows.Forms.Label();
            this.labelFornecedorCpf = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelFornecedorEmail = new System.Windows.Forms.Label();
            this.labelFornecedorTelefone = new System.Windows.Forms.Label();
            this.labelFornecedorCep = new System.Windows.Forms.Label();
            this.CombBoxUf = new System.Windows.Forms.ComboBox();
            this.labelFornecedorUf = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.labelFornecedorCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.labelFornecedorBairro = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.labelFornecedorEndereco = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.labelFornecedorApelido = new System.Windows.Forms.Label();
            this.informacoes_observacoes = new System.Windows.Forms.TabPage();
            this.txtObservacoes = new System.Windows.Forms.RichTextBox();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
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
            this.labelTipoFornecimento.TabIndex = 1;
            this.labelTipoFornecimento.Text = "Tipo de Fornecimento*";
            // 
            // txtTipoFornecimento
            // 
            this.txtTipoFornecimento.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipoFornecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoFornecimento.Location = new System.Drawing.Point(427, 48);
            this.txtTipoFornecimento.MaxLength = 500;
            this.txtTipoFornecimento.Name = "txtTipoFornecimento";
            this.txtTipoFornecimento.Size = new System.Drawing.Size(270, 22);
            this.txtTipoFornecimento.TabIndex = 3;
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
            this.btnCancelar.TabIndex = 5;
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
            this.BtnAdicionarEditarFornecedor.TabIndex = 6;
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
            this.tabControl.TabIndex = 4;
            this.tabControl.Tag = "";
            // 
            // enderecos_contato
            // 
            this.enderecos_contato.BackColor = System.Drawing.Color.WhiteSmoke;
            this.enderecos_contato.Controls.Add(this.labelFornecedorCelular);
            this.enderecos_contato.Controls.Add(this.txtCelular);
            this.enderecos_contato.Controls.Add(this.txtCep);
            this.enderecos_contato.Controls.Add(this.txtTelefone);
            this.enderecos_contato.Controls.Add(this.txtCnpj);
            this.enderecos_contato.Controls.Add(this.txtCpf);
            this.enderecos_contato.Controls.Add(this.labelFornecedorCnpj);
            this.enderecos_contato.Controls.Add(this.labelFornecedorCpf);
            this.enderecos_contato.Controls.Add(this.txtEmail);
            this.enderecos_contato.Controls.Add(this.labelFornecedorEmail);
            this.enderecos_contato.Controls.Add(this.labelFornecedorTelefone);
            this.enderecos_contato.Controls.Add(this.labelFornecedorCep);
            this.enderecos_contato.Controls.Add(this.CombBoxUf);
            this.enderecos_contato.Controls.Add(this.labelFornecedorUf);
            this.enderecos_contato.Controls.Add(this.txtCidade);
            this.enderecos_contato.Controls.Add(this.labelFornecedorCidade);
            this.enderecos_contato.Controls.Add(this.txtBairro);
            this.enderecos_contato.Controls.Add(this.labelFornecedorBairro);
            this.enderecos_contato.Controls.Add(this.txtEndereco);
            this.enderecos_contato.Controls.Add(this.labelFornecedorEndereco);
            this.enderecos_contato.Controls.Add(this.txtApelido);
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
            this.labelFornecedorCelular.TabIndex = 14;
            this.labelFornecedorCelular.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtCelular.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(195, 191);
            this.txtCelular.Mask = "(00)90000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(125, 22);
            this.txtCelular.TabIndex = 15;
            this.txtCelular.Click += new System.EventHandler(this.CadastroFornecedorCelular_Click);
            // 
            // txtCep
            // 
            this.txtCep.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtCep.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(550, 139);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(87, 22);
            this.txtCep.TabIndex = 11;
            this.txtCep.Click += new System.EventHandler(this.CadastroFornecedorCep_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefone.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(18, 191);
            this.txtTelefone.Mask = "(00)0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(125, 22);
            this.txtTelefone.TabIndex = 13;
            this.txtTelefone.Click += new System.EventHandler(this.CadastroFornecedorTelefone_Click);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtCnpj.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(382, 191);
            this.txtCnpj.Mask = "00.000.000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(100, 22);
            this.txtCnpj.TabIndex = 17;
            this.txtCnpj.Click += new System.EventHandler(this.CadastroFornecedorCnpj_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.SystemColors.Window;
            this.txtCpf.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(537, 191);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 22);
            this.txtCpf.TabIndex = 19;
            this.txtCpf.Click += new System.EventHandler(this.CadastroFornecedorCpf_Click);
            // 
            // labelFornecedorCnpj
            // 
            this.labelFornecedorCnpj.AutoSize = true;
            this.labelFornecedorCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorCnpj.Location = new System.Drawing.Point(379, 171);
            this.labelFornecedorCnpj.Name = "labelFornecedorCnpj";
            this.labelFornecedorCnpj.Size = new System.Drawing.Size(69, 18);
            this.labelFornecedorCnpj.TabIndex = 16;
            this.labelFornecedorCnpj.Text = "N° CNPJ";
            // 
            // labelFornecedorCpf
            // 
            this.labelFornecedorCpf.AutoSize = true;
            this.labelFornecedorCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorCpf.Location = new System.Drawing.Point(534, 171);
            this.labelFornecedorCpf.Name = "labelFornecedorCpf";
            this.labelFornecedorCpf.Size = new System.Drawing.Size(65, 18);
            this.labelFornecedorCpf.TabIndex = 18;
            this.labelFornecedorCpf.Text = "N° CPF*";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(18, 245);
            this.txtEmail.MaxLength = 500;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(619, 22);
            this.txtEmail.TabIndex = 21;
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
            // CombBoxUf
            // 
            this.CombBoxUf.BackColor = System.Drawing.SystemColors.Window;
            this.CombBoxUf.DropDownHeight = 85;
            this.CombBoxUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombBoxUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombBoxUf.FormattingEnabled = true;
            this.CombBoxUf.IntegralHeight = false;
            this.CombBoxUf.ItemHeight = 16;
            this.CombBoxUf.Items.AddRange(new object[] {
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
            this.CombBoxUf.Location = new System.Drawing.Point(450, 139);
            this.CombBoxUf.Name = "CombBoxUf";
            this.CombBoxUf.Size = new System.Drawing.Size(62, 24);
            this.CombBoxUf.TabIndex = 9;
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
            // labelFornecedorEndereco
            // 
            this.labelFornecedorEndereco.AutoSize = true;
            this.labelFornecedorEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorEndereco.Location = new System.Drawing.Point(15, 66);
            this.labelFornecedorEndereco.Name = "labelFornecedorEndereco";
            this.labelFornecedorEndereco.Size = new System.Drawing.Size(78, 18);
            this.labelFornecedorEndereco.TabIndex = 2;
            this.labelFornecedorEndereco.Text = "Endereço*";
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
            this.informacoes_observacoes.Controls.Add(this.txtObservacoes);
            this.informacoes_observacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacoes_observacoes.Location = new System.Drawing.Point(4, 22);
            this.informacoes_observacoes.Name = "informacoes_observacoes";
            this.informacoes_observacoes.Padding = new System.Windows.Forms.Padding(3);
            this.informacoes_observacoes.Size = new System.Drawing.Size(657, 281);
            this.informacoes_observacoes.TabIndex = 1;
            this.informacoes_observacoes.Text = "Informações / Observações";
            this.informacoes_observacoes.UseVisualStyleBackColor = true;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservacoes.Location = new System.Drawing.Point(6, 6);
            this.txtObservacoes.MaxLength = 500;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(645, 269);
            this.txtObservacoes.TabIndex = 0;
            this.txtObservacoes.Text = "";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.BackColor = System.Drawing.SystemColors.Info;
            this.txtNomeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFornecedor.Location = new System.Drawing.Point(40, 48);
            this.txtNomeFornecedor.MaxLength = 500;
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(332, 22);
            this.txtNomeFornecedor.TabIndex = 2;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(36, 23);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(186, 22);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome do Fornecedor*";
            // 
            // AdicionarEditarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(736, 479);
            this.Controls.Add(this.labelTipoFornecimento);
            this.Controls.Add(this.txtTipoFornecimento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnAdicionarEditarFornecedor);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.txtNomeFornecedor);
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
        private System.Windows.Forms.TextBox txtTipoFornecimento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnAdicionarEditarFornecedor;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage enderecos_contato;
        private System.Windows.Forms.Label labelFornecedorCelular;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label labelFornecedorCnpj;
        private System.Windows.Forms.Label labelFornecedorCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelFornecedorEmail;
        private System.Windows.Forms.Label labelFornecedorTelefone;
        private System.Windows.Forms.Label labelFornecedorCep;
        private System.Windows.Forms.ComboBox CombBoxUf;
        private System.Windows.Forms.Label labelFornecedorUf;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label labelFornecedorCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label labelFornecedorBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label labelFornecedorEndereco;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label labelFornecedorApelido;
        private System.Windows.Forms.TabPage informacoes_observacoes;
        private System.Windows.Forms.RichTextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label labelNome;
    }
}