namespace PetShop
{
    partial class AdicionarEditarAnimais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarEditarAnimais));
            this.labelDataDeRegistro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisarDono = new System.Windows.Forms.Button();
            this.labelNomeDono = new System.Windows.Forms.Label();
            this.txtNomeDonoAnimal = new System.Windows.Forms.TextBox();
            this.txtDataRegistroAnimal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkSexoMacho = new System.Windows.Forms.CheckBox();
            this.checkSexoFemea = new System.Windows.Forms.CheckBox();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.labelNomeAnimal = new System.Windows.Forms.Label();
            this.checkDisponivelTosa = new System.Windows.Forms.CheckBox();
            this.checkPossuiPedigree = new System.Windows.Forms.CheckBox();
            this.checkAgressivo = new System.Windows.Forms.CheckBox();
            this.checkHiperativo = new System.Windows.Forms.CheckBox();
            this.checkAntissocial = new System.Windows.Forms.CheckBox();
            this.checkObcessivo = new System.Windows.Forms.CheckBox();
            this.btnSalvarCadastro = new System.Windows.Forms.Button();
            this.btnEmitirFicha = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtIdentificacao = new System.Windows.Forms.TextBox();
            this.txtEnderecoFoto = new System.Windows.Forms.TextBox();
            this.txtFobias = new System.Windows.Forms.TextBox();
            this.fotoAnimal = new System.Windows.Forms.PictureBox();
            this.btnPesquisarEspecie = new System.Windows.Forms.Button();
            this.btnPesquisarRaca = new System.Windows.Forms.Button();
            this.btnPesquisarLocalFoto = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtObservacaoRotina = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtObservacaoComportamental = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelFobias = new System.Windows.Forms.Label();
            this.labelEnderecoFoto = new System.Windows.Forms.Label();
            this.labelIdentificacao = new System.Windows.Forms.Label();
            this.labelRaca = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoAnimal)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDataDeRegistro
            // 
            this.labelDataDeRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDataDeRegistro.AutoSize = true;
            this.labelDataDeRegistro.Location = new System.Drawing.Point(11, 16);
            this.labelDataDeRegistro.Name = "labelDataDeRegistro";
            this.labelDataDeRegistro.Size = new System.Drawing.Size(72, 13);
            this.labelDataDeRegistro.TabIndex = 0;
            this.labelDataDeRegistro.Text = "Data Registro";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnPesquisarDono);
            this.groupBox1.Controls.Add(this.labelNomeDono);
            this.groupBox1.Controls.Add(this.txtNomeDonoAnimal);
            this.groupBox1.Controls.Add(this.txtDataRegistroAnimal);
            this.groupBox1.Controls.Add(this.labelDataDeRegistro);
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnPesquisarDono
            // 
            this.btnPesquisarDono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarDono.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarDono.Image")));
            this.btnPesquisarDono.Location = new System.Drawing.Point(509, 21);
            this.btnPesquisarDono.Name = "btnPesquisarDono";
            this.btnPesquisarDono.Size = new System.Drawing.Size(111, 41);
            this.btnPesquisarDono.TabIndex = 4;
            this.btnPesquisarDono.Text = "Pesquisar";
            this.btnPesquisarDono.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarDono.UseVisualStyleBackColor = true;
            this.btnPesquisarDono.Click += new System.EventHandler(this.BtnPesquisarDono_Click);
            // 
            // labelNomeDono
            // 
            this.labelNomeDono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNomeDono.AutoSize = true;
            this.labelNomeDono.Location = new System.Drawing.Point(120, 16);
            this.labelNomeDono.Name = "labelNomeDono";
            this.labelNomeDono.Size = new System.Drawing.Size(190, 13);
            this.labelNomeDono.TabIndex = 3;
            this.labelNomeDono.Text = "Nome do Dono / Proprietário / Cliente*";
            // 
            // txtNomeDonoAnimal
            // 
            this.txtNomeDonoAnimal.AllowDrop = true;
            this.txtNomeDonoAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeDonoAnimal.Enabled = false;
            this.txtNomeDonoAnimal.Location = new System.Drawing.Point(123, 38);
            this.txtNomeDonoAnimal.Name = "txtNomeDonoAnimal";
            this.txtNomeDonoAnimal.Size = new System.Drawing.Size(360, 20);
            this.txtNomeDonoAnimal.TabIndex = 2;
            // 
            // txtDataRegistroAnimal
            // 
            this.txtDataRegistroAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataRegistroAnimal.Enabled = false;
            this.txtDataRegistroAnimal.Location = new System.Drawing.Point(14, 37);
            this.txtDataRegistroAnimal.Name = "txtDataRegistroAnimal";
            this.txtDataRegistroAnimal.Size = new System.Drawing.Size(82, 20);
            this.txtDataRegistroAnimal.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkSexoMacho);
            this.groupBox2.Controls.Add(this.checkSexoFemea);
            this.groupBox2.Controls.Add(this.txtNomeAnimal);
            this.groupBox2.Controls.Add(this.labelNomeAnimal);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // checkSexoMacho
            // 
            this.checkSexoMacho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkSexoMacho.AutoSize = true;
            this.checkSexoMacho.Location = new System.Drawing.Point(463, 38);
            this.checkSexoMacho.Name = "checkSexoMacho";
            this.checkSexoMacho.Size = new System.Drawing.Size(63, 17);
            this.checkSexoMacho.TabIndex = 3;
            this.checkSexoMacho.Text = "Macho*";
            this.checkSexoMacho.UseVisualStyleBackColor = true;
            // 
            // checkSexoFemea
            // 
            this.checkSexoFemea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkSexoFemea.AutoSize = true;
            this.checkSexoFemea.Location = new System.Drawing.Point(549, 38);
            this.checkSexoFemea.Name = "checkSexoFemea";
            this.checkSexoFemea.Size = new System.Drawing.Size(62, 17);
            this.checkSexoFemea.TabIndex = 2;
            this.checkSexoFemea.Text = "Femea*";
            this.checkSexoFemea.UseVisualStyleBackColor = true;
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeAnimal.Location = new System.Drawing.Point(16, 36);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(427, 20);
            this.txtNomeAnimal.TabIndex = 1;
            // 
            // labelNomeAnimal
            // 
            this.labelNomeAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNomeAnimal.AutoSize = true;
            this.labelNomeAnimal.Location = new System.Drawing.Point(13, 16);
            this.labelNomeAnimal.Name = "labelNomeAnimal";
            this.labelNomeAnimal.Size = new System.Drawing.Size(88, 13);
            this.labelNomeAnimal.TabIndex = 0;
            this.labelNomeAnimal.Text = "Nome do Animal*";
            // 
            // checkDisponivelTosa
            // 
            this.checkDisponivelTosa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkDisponivelTosa.AutoSize = true;
            this.checkDisponivelTosa.Location = new System.Drawing.Point(13, 477);
            this.checkDisponivelTosa.Name = "checkDisponivelTosa";
            this.checkDisponivelTosa.Size = new System.Drawing.Size(122, 17);
            this.checkDisponivelTosa.TabIndex = 4;
            this.checkDisponivelTosa.Text = "Disponivel para tosa";
            this.checkDisponivelTosa.UseVisualStyleBackColor = true;
            // 
            // checkPossuiPedigree
            // 
            this.checkPossuiPedigree.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkPossuiPedigree.AutoSize = true;
            this.checkPossuiPedigree.Location = new System.Drawing.Point(13, 500);
            this.checkPossuiPedigree.Name = "checkPossuiPedigree";
            this.checkPossuiPedigree.Size = new System.Drawing.Size(102, 17);
            this.checkPossuiPedigree.TabIndex = 5;
            this.checkPossuiPedigree.Text = "Possui Pedigree";
            this.checkPossuiPedigree.UseVisualStyleBackColor = true;
            // 
            // checkAgressivo
            // 
            this.checkAgressivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkAgressivo.AutoSize = true;
            this.checkAgressivo.Location = new System.Drawing.Point(13, 522);
            this.checkAgressivo.Name = "checkAgressivo";
            this.checkAgressivo.Size = new System.Drawing.Size(72, 17);
            this.checkAgressivo.TabIndex = 8;
            this.checkAgressivo.Text = "Agressivo";
            this.checkAgressivo.UseVisualStyleBackColor = true;
            // 
            // checkHiperativo
            // 
            this.checkHiperativo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkHiperativo.AutoSize = true;
            this.checkHiperativo.Location = new System.Drawing.Point(156, 477);
            this.checkHiperativo.Name = "checkHiperativo";
            this.checkHiperativo.Size = new System.Drawing.Size(74, 17);
            this.checkHiperativo.TabIndex = 9;
            this.checkHiperativo.Text = "Hiperativo";
            this.checkHiperativo.UseVisualStyleBackColor = true;
            // 
            // checkAntissocial
            // 
            this.checkAntissocial.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkAntissocial.AutoSize = true;
            this.checkAntissocial.Location = new System.Drawing.Point(156, 500);
            this.checkAntissocial.Name = "checkAntissocial";
            this.checkAntissocial.Size = new System.Drawing.Size(76, 17);
            this.checkAntissocial.TabIndex = 10;
            this.checkAntissocial.Text = "Anti Social";
            this.checkAntissocial.UseVisualStyleBackColor = true;
            // 
            // checkObcessivo
            // 
            this.checkObcessivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkObcessivo.AutoSize = true;
            this.checkObcessivo.Location = new System.Drawing.Point(156, 523);
            this.checkObcessivo.Name = "checkObcessivo";
            this.checkObcessivo.Size = new System.Drawing.Size(75, 17);
            this.checkObcessivo.TabIndex = 11;
            this.checkObcessivo.Text = "Obsessivo";
            this.checkObcessivo.UseVisualStyleBackColor = true;
            // 
            // btnSalvarCadastro
            // 
            this.btnSalvarCadastro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalvarCadastro.Location = new System.Drawing.Point(461, 470);
            this.btnSalvarCadastro.Name = "btnSalvarCadastro";
            this.btnSalvarCadastro.Size = new System.Drawing.Size(178, 36);
            this.btnSalvarCadastro.TabIndex = 12;
            this.btnSalvarCadastro.Text = "Salvar";
            this.btnSalvarCadastro.UseVisualStyleBackColor = true;
            // 
            // btnEmitirFicha
            // 
            this.btnEmitirFicha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEmitirFicha.Location = new System.Drawing.Point(277, 470);
            this.btnEmitirFicha.Name = "btnEmitirFicha";
            this.btnEmitirFicha.Size = new System.Drawing.Size(178, 36);
            this.btnEmitirFicha.TabIndex = 13;
            this.btnEmitirFicha.Text = "Emitir Ficha";
            this.btnEmitirFicha.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSair.Location = new System.Drawing.Point(461, 512);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(178, 36);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(24, 26);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(259, 20);
            this.txtEspecie.TabIndex = 0;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(24, 72);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(259, 20);
            this.txtRaca.TabIndex = 1;
            // 
            // txtIdentificacao
            // 
            this.txtIdentificacao.Location = new System.Drawing.Point(24, 116);
            this.txtIdentificacao.Name = "txtIdentificacao";
            this.txtIdentificacao.Size = new System.Drawing.Size(326, 20);
            this.txtIdentificacao.TabIndex = 3;
            // 
            // txtEnderecoFoto
            // 
            this.txtEnderecoFoto.Enabled = false;
            this.txtEnderecoFoto.Location = new System.Drawing.Point(24, 160);
            this.txtEnderecoFoto.Name = "txtEnderecoFoto";
            this.txtEnderecoFoto.Size = new System.Drawing.Size(259, 20);
            this.txtEnderecoFoto.TabIndex = 4;
            // 
            // txtFobias
            // 
            this.txtFobias.Location = new System.Drawing.Point(24, 204);
            this.txtFobias.Name = "txtFobias";
            this.txtFobias.Size = new System.Drawing.Size(579, 20);
            this.txtFobias.TabIndex = 6;
            // 
            // fotoAnimal
            // 
            this.fotoAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoAnimal.Location = new System.Drawing.Point(356, 16);
            this.fotoAnimal.Name = "fotoAnimal";
            this.fotoAnimal.Size = new System.Drawing.Size(247, 164);
            this.fotoAnimal.TabIndex = 13;
            this.fotoAnimal.TabStop = false;
            // 
            // btnPesquisarEspecie
            // 
            this.btnPesquisarEspecie.Location = new System.Drawing.Point(289, 24);
            this.btnPesquisarEspecie.Name = "btnPesquisarEspecie";
            this.btnPesquisarEspecie.Size = new System.Drawing.Size(61, 23);
            this.btnPesquisarEspecie.TabIndex = 14;
            this.btnPesquisarEspecie.Text = "Pesquisar";
            this.btnPesquisarEspecie.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarRaca
            // 
            this.btnPesquisarRaca.Location = new System.Drawing.Point(289, 70);
            this.btnPesquisarRaca.Name = "btnPesquisarRaca";
            this.btnPesquisarRaca.Size = new System.Drawing.Size(61, 23);
            this.btnPesquisarRaca.TabIndex = 15;
            this.btnPesquisarRaca.Text = "Pesquisar";
            this.btnPesquisarRaca.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarLocalFoto
            // 
            this.btnPesquisarLocalFoto.Location = new System.Drawing.Point(289, 157);
            this.btnPesquisarLocalFoto.Name = "btnPesquisarLocalFoto";
            this.btnPesquisarLocalFoto.Size = new System.Drawing.Size(61, 23);
            this.btnPesquisarLocalFoto.TabIndex = 16;
            this.btnPesquisarLocalFoto.Text = "Pesquisar";
            this.btnPesquisarLocalFoto.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtObservacaoRotina);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(619, 248);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Obs de Rotina";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtObservacaoRotina
            // 
            this.txtObservacaoRotina.Location = new System.Drawing.Point(3, 3);
            this.txtObservacaoRotina.Name = "txtObservacaoRotina";
            this.txtObservacaoRotina.Size = new System.Drawing.Size(613, 242);
            this.txtObservacaoRotina.TabIndex = 1;
            this.txtObservacaoRotina.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtObservacaoComportamental);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(619, 248);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Obs Comportamental";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtObservacaoComportamental
            // 
            this.txtObservacaoComportamental.Location = new System.Drawing.Point(3, 3);
            this.txtObservacaoComportamental.Name = "txtObservacaoComportamental";
            this.txtObservacaoComportamental.Size = new System.Drawing.Size(613, 242);
            this.txtObservacaoComportamental.TabIndex = 0;
            this.txtObservacaoComportamental.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPesquisarLocalFoto);
            this.tabPage1.Controls.Add(this.btnPesquisarRaca);
            this.tabPage1.Controls.Add(this.btnPesquisarEspecie);
            this.tabPage1.Controls.Add(this.fotoAnimal);
            this.tabPage1.Controls.Add(this.labelFobias);
            this.tabPage1.Controls.Add(this.labelEnderecoFoto);
            this.tabPage1.Controls.Add(this.labelIdentificacao);
            this.tabPage1.Controls.Add(this.labelRaca);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtFobias);
            this.tabPage1.Controls.Add(this.txtEnderecoFoto);
            this.tabPage1.Controls.Add(this.txtIdentificacao);
            this.tabPage1.Controls.Add(this.txtRaca);
            this.tabPage1.Controls.Add(this.txtEspecie);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(619, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informação do Animal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelFobias
            // 
            this.labelFobias.AutoSize = true;
            this.labelFobias.Location = new System.Drawing.Point(23, 188);
            this.labelFobias.Name = "labelFobias";
            this.labelFobias.Size = new System.Drawing.Size(38, 13);
            this.labelFobias.TabIndex = 12;
            this.labelFobias.Text = "Fobias";
            // 
            // labelEnderecoFoto
            // 
            this.labelEnderecoFoto.AutoSize = true;
            this.labelEnderecoFoto.Location = new System.Drawing.Point(21, 144);
            this.labelEnderecoFoto.Name = "labelEnderecoFoto";
            this.labelEnderecoFoto.Size = new System.Drawing.Size(173, 13);
            this.labelEnderecoFoto.TabIndex = 10;
            this.labelEnderecoFoto.Text = "Endereço da Foto / Pesquisar Foto";
            // 
            // labelIdentificacao
            // 
            this.labelIdentificacao.AutoSize = true;
            this.labelIdentificacao.Location = new System.Drawing.Point(21, 100);
            this.labelIdentificacao.Name = "labelIdentificacao";
            this.labelIdentificacao.Size = new System.Drawing.Size(147, 13);
            this.labelIdentificacao.TabIndex = 9;
            this.labelIdentificacao.Text = "Identificação / Cor / Pelagem";
            // 
            // labelRaca
            // 
            this.labelRaca.AutoSize = true;
            this.labelRaca.Location = new System.Drawing.Point(21, 56);
            this.labelRaca.Name = "labelRaca";
            this.labelRaca.Size = new System.Drawing.Size(37, 13);
            this.labelRaca.TabIndex = 8;
            this.labelRaca.Text = "Raça*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Especie*";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 179);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 274);
            this.tabControl1.TabIndex = 3;
            // 
            // AdicionarEditarAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 551);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEmitirFicha);
            this.Controls.Add(this.btnSalvarCadastro);
            this.Controls.Add(this.checkObcessivo);
            this.Controls.Add(this.checkAntissocial);
            this.Controls.Add(this.checkHiperativo);
            this.Controls.Add(this.checkAgressivo);
            this.Controls.Add(this.checkPossuiPedigree);
            this.Controls.Add(this.checkDisponivelTosa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarEditarAnimais";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdicionarEditarAnimais_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoAnimal)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDataDeRegistro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisarDono;
        private System.Windows.Forms.Label labelNomeDono;
        private System.Windows.Forms.TextBox txtNomeDonoAnimal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkSexoMacho;
        private System.Windows.Forms.CheckBox checkSexoFemea;
        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.Label labelNomeAnimal;
        private System.Windows.Forms.CheckBox checkDisponivelTosa;
        private System.Windows.Forms.CheckBox checkPossuiPedigree;
        private System.Windows.Forms.CheckBox checkAgressivo;
        private System.Windows.Forms.CheckBox checkHiperativo;
        private System.Windows.Forms.CheckBox checkAntissocial;
        private System.Windows.Forms.CheckBox checkObcessivo;
        private System.Windows.Forms.Button btnSalvarCadastro;
        private System.Windows.Forms.Button btnEmitirFicha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtDataRegistroAnimal;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RichTextBox txtObservacaoRotina;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox txtObservacaoComportamental;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPesquisarLocalFoto;
        private System.Windows.Forms.Button btnPesquisarRaca;
        private System.Windows.Forms.Button btnPesquisarEspecie;
        private System.Windows.Forms.PictureBox fotoAnimal;
        private System.Windows.Forms.Label labelFobias;
        private System.Windows.Forms.Label labelEnderecoFoto;
        private System.Windows.Forms.Label labelIdentificacao;
        private System.Windows.Forms.Label labelRaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFobias;
        private System.Windows.Forms.TextBox txtEnderecoFoto;
        private System.Windows.Forms.TextBox txtIdentificacao;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TabControl tabControl1;
    }
}