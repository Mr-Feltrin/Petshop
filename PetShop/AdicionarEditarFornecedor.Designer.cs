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
            this.components = new System.ComponentModel.Container();
            this.labelTipoFornecimento = new System.Windows.Forms.Label();
            this.txtTipoFornecimento = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.enderecos_contato = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.labelFornecedorUf = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.labelFornecedorCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.labelFornecedorBairro = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.labelFornecedorEndereco = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.labelFornecedorApelido = new System.Windows.Forms.Label();
            this.CombBoxUf = new PetShop.ToolBox.Controls.ComboBoxFlatBordered();
            this.informacoes_observacoes = new System.Windows.Forms.TabPage();
            this.txtObservacoes = new System.Windows.Forms.RichTextBox();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAdicionarEditarFornecedor = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.enderecos_contato.SuspendLayout();
            this.informacoes_observacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTipoFornecimento
            // 
            this.labelTipoFornecimento.AutoSize = true;
            this.labelTipoFornecimento.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoFornecimento.Location = new System.Drawing.Point(416, 23);
            this.labelTipoFornecimento.Name = "labelTipoFornecimento";
            this.labelTipoFornecimento.Size = new System.Drawing.Size(166, 21);
            this.labelTipoFornecimento.TabIndex = 1;
            this.labelTipoFornecimento.Text = "Tipo de Fornecimento";
            // 
            // txtTipoFornecimento
            // 
            this.txtTipoFornecimento.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipoFornecimento.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoFornecimento.Location = new System.Drawing.Point(420, 47);
            this.txtTipoFornecimento.MaxLength = 500;
            this.txtTipoFornecimento.Name = "txtTipoFornecimento";
            this.txtTipoFornecimento.Size = new System.Drawing.Size(270, 22);
            this.txtTipoFornecimento.TabIndex = 3;
            this.txtTipoFornecimento.TextChanged += new System.EventHandler(this.txtTipoFornecimento_TextChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.enderecos_contato);
            this.tabControl.Controls.Add(this.informacoes_observacoes);
            this.tabControl.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(29, 90);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(665, 311);
            this.tabControl.TabIndex = 4;
            this.tabControl.Tag = "";
            // 
            // enderecos_contato
            // 
            this.enderecos_contato.BackColor = System.Drawing.Color.AliceBlue;
            this.enderecos_contato.Controls.Add(this.label8);
            this.enderecos_contato.Controls.Add(this.label7);
            this.enderecos_contato.Controls.Add(this.label6);
            this.enderecos_contato.Controls.Add(this.label5);
            this.enderecos_contato.Controls.Add(this.label4);
            this.enderecos_contato.Controls.Add(this.label3);
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
            this.enderecos_contato.Controls.Add(this.labelFornecedorUf);
            this.enderecos_contato.Controls.Add(this.txtCidade);
            this.enderecos_contato.Controls.Add(this.labelFornecedorCidade);
            this.enderecos_contato.Controls.Add(this.txtBairro);
            this.enderecos_contato.Controls.Add(this.labelFornecedorBairro);
            this.enderecos_contato.Controls.Add(this.txtEndereco);
            this.enderecos_contato.Controls.Add(this.labelFornecedorEndereco);
            this.enderecos_contato.Controls.Add(this.txtApelido);
            this.enderecos_contato.Controls.Add(this.labelFornecedorApelido);
            this.enderecos_contato.Controls.Add(this.CombBoxUf);
            this.enderecos_contato.Location = new System.Drawing.Point(4, 25);
            this.enderecos_contato.Name = "enderecos_contato";
            this.enderecos_contato.Padding = new System.Windows.Forms.Padding(3);
            this.enderecos_contato.Size = new System.Drawing.Size(657, 282);
            this.enderecos_contato.TabIndex = 0;
            this.enderecos_contato.Text = "Endereço e Contato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(585, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(74, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(468, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(326, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(57, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(78, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "*";
            // 
            // labelFornecedorCelular
            // 
            this.labelFornecedorCelular.AutoSize = true;
            this.labelFornecedorCelular.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorCelular.Location = new System.Drawing.Point(191, 168);
            this.labelFornecedorCelular.Name = "labelFornecedorCelular";
            this.labelFornecedorCelular.Size = new System.Drawing.Size(55, 20);
            this.labelFornecedorCelular.TabIndex = 14;
            this.labelFornecedorCelular.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtCelular.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCelular.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtCep.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtTelefone.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(18, 191);
            this.txtTelefone.Mask = "(00)0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(125, 22);
            this.txtTelefone.TabIndex = 13;
            this.txtTelefone.Click += new System.EventHandler(this.CadastroFornecedorTelefone_Click);
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtCnpj.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCnpj.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtCpf.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(537, 191);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 22);
            this.txtCpf.TabIndex = 19;
            this.txtCpf.Click += new System.EventHandler(this.CadastroFornecedorCpf_Click);
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // labelFornecedorCnpj
            // 
            this.labelFornecedorCnpj.AutoSize = true;
            this.labelFornecedorCnpj.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorCnpj.Location = new System.Drawing.Point(378, 168);
            this.labelFornecedorCnpj.Name = "labelFornecedorCnpj";
            this.labelFornecedorCnpj.Size = new System.Drawing.Size(64, 20);
            this.labelFornecedorCnpj.TabIndex = 16;
            this.labelFornecedorCnpj.Text = "N° CNPJ";
            // 
            // labelFornecedorCpf
            // 
            this.labelFornecedorCpf.AutoSize = true;
            this.labelFornecedorCpf.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorCpf.Location = new System.Drawing.Point(533, 168);
            this.labelFornecedorCpf.Name = "labelFornecedorCpf";
            this.labelFornecedorCpf.Size = new System.Drawing.Size(57, 20);
            this.labelFornecedorCpf.TabIndex = 18;
            this.labelFornecedorCpf.Text = "N° CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(18, 245);
            this.txtEmail.MaxLength = 500;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(619, 22);
            this.txtEmail.TabIndex = 21;
            // 
            // labelFornecedorEmail
            // 
            this.labelFornecedorEmail.AutoSize = true;
            this.labelFornecedorEmail.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorEmail.Location = new System.Drawing.Point(14, 222);
            this.labelFornecedorEmail.Name = "labelFornecedorEmail";
            this.labelFornecedorEmail.Size = new System.Drawing.Size(49, 20);
            this.labelFornecedorEmail.TabIndex = 20;
            this.labelFornecedorEmail.Text = "E-mail";
            // 
            // labelFornecedorTelefone
            // 
            this.labelFornecedorTelefone.AutoSize = true;
            this.labelFornecedorTelefone.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorTelefone.Location = new System.Drawing.Point(14, 168);
            this.labelFornecedorTelefone.Name = "labelFornecedorTelefone";
            this.labelFornecedorTelefone.Size = new System.Drawing.Size(65, 20);
            this.labelFornecedorTelefone.TabIndex = 12;
            this.labelFornecedorTelefone.Text = "Telefone";
            // 
            // labelFornecedorCep
            // 
            this.labelFornecedorCep.AutoSize = true;
            this.labelFornecedorCep.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorCep.Location = new System.Drawing.Point(546, 116);
            this.labelFornecedorCep.Name = "labelFornecedorCep";
            this.labelFornecedorCep.Size = new System.Drawing.Size(35, 20);
            this.labelFornecedorCep.TabIndex = 10;
            this.labelFornecedorCep.Text = "CEP";
            // 
            // labelFornecedorUf
            // 
            this.labelFornecedorUf.AutoSize = true;
            this.labelFornecedorUf.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorUf.Location = new System.Drawing.Point(447, 116);
            this.labelFornecedorUf.Name = "labelFornecedorUf";
            this.labelFornecedorUf.Size = new System.Drawing.Size(26, 20);
            this.labelFornecedorUf.TabIndex = 8;
            this.labelFornecedorUf.Text = "UF";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtCidade.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(281, 139);
            this.txtCidade.MaxLength = 500;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(140, 22);
            this.txtCidade.TabIndex = 7;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            // 
            // labelFornecedorCidade
            // 
            this.labelFornecedorCidade.AutoSize = true;
            this.labelFornecedorCidade.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorCidade.Location = new System.Drawing.Point(277, 116);
            this.labelFornecedorCidade.Name = "labelFornecedorCidade";
            this.labelFornecedorCidade.Size = new System.Drawing.Size(54, 20);
            this.labelFornecedorCidade.TabIndex = 6;
            this.labelFornecedorCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.Window;
            this.txtBairro.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(18, 139);
            this.txtBairro.MaxLength = 500;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(241, 22);
            this.txtBairro.TabIndex = 5;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // labelFornecedorBairro
            // 
            this.labelFornecedorBairro.AutoSize = true;
            this.labelFornecedorBairro.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorBairro.Location = new System.Drawing.Point(14, 116);
            this.labelFornecedorBairro.Name = "labelFornecedorBairro";
            this.labelFornecedorBairro.Size = new System.Drawing.Size(48, 20);
            this.labelFornecedorBairro.TabIndex = 4;
            this.labelFornecedorBairro.Text = "Bairro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndereco.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(18, 86);
            this.txtEndereco.MaxLength = 500;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(619, 22);
            this.txtEndereco.TabIndex = 3;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // labelFornecedorEndereco
            // 
            this.labelFornecedorEndereco.AutoSize = true;
            this.labelFornecedorEndereco.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorEndereco.Location = new System.Drawing.Point(14, 63);
            this.labelFornecedorEndereco.Name = "labelFornecedorEndereco";
            this.labelFornecedorEndereco.Size = new System.Drawing.Size(69, 20);
            this.labelFornecedorEndereco.TabIndex = 2;
            this.labelFornecedorEndereco.Text = "Endereço";
            // 
            // txtApelido
            // 
            this.txtApelido.BackColor = System.Drawing.SystemColors.Window;
            this.txtApelido.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApelido.Location = new System.Drawing.Point(18, 36);
            this.txtApelido.MaxLength = 500;
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(619, 22);
            this.txtApelido.TabIndex = 1;
            // 
            // labelFornecedorApelido
            // 
            this.labelFornecedorApelido.AutoSize = true;
            this.labelFornecedorApelido.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedorApelido.Location = new System.Drawing.Point(14, 13);
            this.labelFornecedorApelido.Name = "labelFornecedorApelido";
            this.labelFornecedorApelido.Size = new System.Drawing.Size(170, 20);
            this.labelFornecedorApelido.TabIndex = 0;
            this.labelFornecedorApelido.Text = "Nome Fantasia / Apelido";
            // 
            // CombBoxUf
            // 
            this.CombBoxUf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CombBoxUf.BackColor = System.Drawing.SystemColors.Window;
            this.CombBoxUf.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CombBoxUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombBoxUf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CombBoxUf.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombBoxUf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CombBoxUf.FormattingEnabled = true;
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
            this.CombBoxUf.Size = new System.Drawing.Size(62, 25);
            this.CombBoxUf.TabIndex = 21;
            this.CombBoxUf.TextChanged += new System.EventHandler(this.CombBoxUf_TextChanged);
            // 
            // informacoes_observacoes
            // 
            this.informacoes_observacoes.BackColor = System.Drawing.Color.AliceBlue;
            this.informacoes_observacoes.Controls.Add(this.txtObservacoes);
            this.informacoes_observacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacoes_observacoes.Location = new System.Drawing.Point(4, 25);
            this.informacoes_observacoes.Name = "informacoes_observacoes";
            this.informacoes_observacoes.Padding = new System.Windows.Forms.Padding(3);
            this.informacoes_observacoes.Size = new System.Drawing.Size(657, 282);
            this.informacoes_observacoes.TabIndex = 1;
            this.informacoes_observacoes.Text = "Informações / Observações";
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
            this.txtNomeFornecedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeFornecedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFornecedor.Location = new System.Drawing.Point(29, 47);
            this.txtNomeFornecedor.MaxLength = 500;
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(332, 22);
            this.txtNomeFornecedor.TabIndex = 2;
            this.txtNomeFornecedor.TextChanged += new System.EventHandler(this.txtNomeFornecedor_TextChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(25, 23);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(162, 21);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome do Fornecedor";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSair.BackColor = System.Drawing.Color.LightCoral;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Image = global::PetShop.Properties.Resources.close;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(29, 407);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(178, 45);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAdicionarEditarFornecedor
            // 
            this.btnAdicionarEditarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdicionarEditarFornecedor.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdicionarEditarFornecedor.Enabled = false;
            this.btnAdicionarEditarFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnAdicionarEditarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarEditarFornecedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarEditarFornecedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdicionarEditarFornecedor.Image = global::PetShop.Properties.Resources.confirm;
            this.btnAdicionarEditarFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarEditarFornecedor.Location = new System.Drawing.Point(512, 407);
            this.btnAdicionarEditarFornecedor.Name = "btnAdicionarEditarFornecedor";
            this.btnAdicionarEditarFornecedor.Size = new System.Drawing.Size(178, 45);
            this.btnAdicionarEditarFornecedor.TabIndex = 18;
            this.btnAdicionarEditarFornecedor.Text = "Salvar";
            this.btnAdicionarEditarFornecedor.UseVisualStyleBackColor = false;
            this.btnAdicionarEditarFornecedor.Click += new System.EventHandler(this.BtnAdicionarEditarFornecedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(181, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(576, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "*";
            // 
            // AdicionarEditarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(719, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionarEditarFornecedor);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.labelTipoFornecimento);
            this.Controls.Add(this.txtTipoFornecimento);
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
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdicionarEditarFornecedor_MouseMove);
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
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdicionarEditarFornecedor;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ToolBox.Controls.ComboBoxFlatBordered CombBoxUf;
    }
}