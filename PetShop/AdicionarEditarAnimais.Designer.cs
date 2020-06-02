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
            this.nomeDonoAnimal = new System.Windows.Forms.TextBox();
            this.dataRegistroAnimal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sexoMacho = new System.Windows.Forms.CheckBox();
            this.sexoFemea = new System.Windows.Forms.CheckBox();
            this.nomeAnimal = new System.Windows.Forms.TextBox();
            this.labelNomeAnimal = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPesquisarLocalFoto = new System.Windows.Forms.Button();
            this.btnPesquisarRaca = new System.Windows.Forms.Button();
            this.btnPesquisarEspecie = new System.Windows.Forms.Button();
            this.fotoAnimal = new System.Windows.Forms.PictureBox();
            this.labelFobias = new System.Windows.Forms.Label();
            this.labelEnderecoFoto = new System.Windows.Forms.Label();
            this.labelIdentificacao = new System.Windows.Forms.Label();
            this.labelRaca = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fobias = new System.Windows.Forms.TextBox();
            this.EnderecoFoto = new System.Windows.Forms.TextBox();
            this.identificacao = new System.Windows.Forms.TextBox();
            this.raca = new System.Windows.Forms.TextBox();
            this.especie = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.relacaoVacinas = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.observacaoComportamental = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.observacaoRotina = new System.Windows.Forms.RichTextBox();
            this.disponivelTosa = new System.Windows.Forms.CheckBox();
            this.possuiPedigree = new System.Windows.Forms.CheckBox();
            this.agressivo = new System.Windows.Forms.CheckBox();
            this.hiperativo = new System.Windows.Forms.CheckBox();
            this.antissocial = new System.Windows.Forms.CheckBox();
            this.obcessivo = new System.Windows.Forms.CheckBox();
            this.btnSalvarCadastro = new System.Windows.Forms.Button();
            this.btnEmitirFicha = new System.Windows.Forms.Button();
            this.btnRelatarAtendimento = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoAnimal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.nomeDonoAnimal);
            this.groupBox1.Controls.Add(this.dataRegistroAnimal);
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
            this.helpProvider.SetHelpString(this.btnPesquisarDono, "Pesquise em uma lista de clientes o nome do Proprietário do Animal");
            this.btnPesquisarDono.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarDono.Image")));
            this.btnPesquisarDono.Location = new System.Drawing.Point(509, 21);
            this.btnPesquisarDono.Name = "btnPesquisarDono";
            this.helpProvider.SetShowHelp(this.btnPesquisarDono, true);
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
            // nomeDonoAnimal
            // 
            this.nomeDonoAnimal.AllowDrop = true;
            this.nomeDonoAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomeDonoAnimal.Enabled = false;
            this.helpProvider.SetHelpString(this.nomeDonoAnimal, "Digite o Nome do Proprietário do Animal");
            this.nomeDonoAnimal.Location = new System.Drawing.Point(123, 38);
            this.nomeDonoAnimal.Name = "nomeDonoAnimal";
            this.helpProvider.SetShowHelp(this.nomeDonoAnimal, true);
            this.nomeDonoAnimal.Size = new System.Drawing.Size(360, 20);
            this.nomeDonoAnimal.TabIndex = 2;
            // 
            // dataRegistroAnimal
            // 
            this.dataRegistroAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataRegistroAnimal.Enabled = false;
            this.helpProvider.SetHelpString(this.dataRegistroAnimal, "Data de cadastro atual do Animal");
            this.dataRegistroAnimal.Location = new System.Drawing.Point(14, 37);
            this.dataRegistroAnimal.Name = "dataRegistroAnimal";
            this.helpProvider.SetShowHelp(this.dataRegistroAnimal, true);
            this.dataRegistroAnimal.Size = new System.Drawing.Size(82, 20);
            this.dataRegistroAnimal.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sexoMacho);
            this.groupBox2.Controls.Add(this.sexoFemea);
            this.groupBox2.Controls.Add(this.nomeAnimal);
            this.groupBox2.Controls.Add(this.labelNomeAnimal);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // sexoMacho
            // 
            this.sexoMacho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sexoMacho.AutoSize = true;
            this.helpProvider.SetHelpString(this.sexoMacho, "Selecione esta opção caso o animal for do sexo M");
            this.sexoMacho.Location = new System.Drawing.Point(463, 38);
            this.sexoMacho.Name = "sexoMacho";
            this.helpProvider.SetShowHelp(this.sexoMacho, true);
            this.sexoMacho.Size = new System.Drawing.Size(63, 17);
            this.sexoMacho.TabIndex = 3;
            this.sexoMacho.Text = "Macho*";
            this.sexoMacho.UseVisualStyleBackColor = true;
            // 
            // sexoFemea
            // 
            this.sexoFemea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sexoFemea.AutoSize = true;
            this.helpProvider.SetHelpString(this.sexoFemea, "Selecione esta opção caso o Animal seja do sexo F");
            this.sexoFemea.Location = new System.Drawing.Point(549, 38);
            this.sexoFemea.Name = "sexoFemea";
            this.helpProvider.SetShowHelp(this.sexoFemea, true);
            this.sexoFemea.Size = new System.Drawing.Size(62, 17);
            this.sexoFemea.TabIndex = 2;
            this.sexoFemea.Text = "Femea*";
            this.sexoFemea.UseVisualStyleBackColor = true;
            // 
            // nomeAnimal
            // 
            this.nomeAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpProvider.SetHelpString(this.nomeAnimal, "Digite o nome do Animal para ser cadastrado");
            this.nomeAnimal.Location = new System.Drawing.Point(16, 36);
            this.nomeAnimal.Name = "nomeAnimal";
            this.helpProvider.SetShowHelp(this.nomeAnimal, true);
            this.nomeAnimal.Size = new System.Drawing.Size(427, 20);
            this.nomeAnimal.TabIndex = 1;
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 179);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 274);
            this.tabControl1.TabIndex = 3;
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
            this.tabPage1.Controls.Add(this.fobias);
            this.tabPage1.Controls.Add(this.EnderecoFoto);
            this.tabPage1.Controls.Add(this.identificacao);
            this.tabPage1.Controls.Add(this.raca);
            this.tabPage1.Controls.Add(this.especie);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(619, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informação do Animal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarLocalFoto
            // 
            this.helpProvider.SetHelpString(this.btnPesquisarLocalFoto, "Pesquise uma imagem em seus documentos do animal a ser cadastrado");
            this.btnPesquisarLocalFoto.Location = new System.Drawing.Point(289, 157);
            this.btnPesquisarLocalFoto.Name = "btnPesquisarLocalFoto";
            this.helpProvider.SetShowHelp(this.btnPesquisarLocalFoto, true);
            this.btnPesquisarLocalFoto.Size = new System.Drawing.Size(61, 23);
            this.btnPesquisarLocalFoto.TabIndex = 16;
            this.btnPesquisarLocalFoto.Text = "Pesquisar";
            this.btnPesquisarLocalFoto.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarRaca
            // 
            this.helpProvider.SetHelpString(this.btnPesquisarRaca, "Pesquise em uma lista as raças já cadastradas em outros animais");
            this.btnPesquisarRaca.Location = new System.Drawing.Point(289, 70);
            this.btnPesquisarRaca.Name = "btnPesquisarRaca";
            this.helpProvider.SetShowHelp(this.btnPesquisarRaca, true);
            this.btnPesquisarRaca.Size = new System.Drawing.Size(61, 23);
            this.btnPesquisarRaca.TabIndex = 15;
            this.btnPesquisarRaca.Text = "Pesquisar";
            this.btnPesquisarRaca.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarEspecie
            // 
            this.helpProvider.SetHelpString(this.btnPesquisarEspecie, "Pesquise em uma lista as espécies já cadastradas em outros animais");
            this.btnPesquisarEspecie.Location = new System.Drawing.Point(289, 24);
            this.btnPesquisarEspecie.Name = "btnPesquisarEspecie";
            this.helpProvider.SetShowHelp(this.btnPesquisarEspecie, true);
            this.btnPesquisarEspecie.Size = new System.Drawing.Size(61, 23);
            this.btnPesquisarEspecie.TabIndex = 14;
            this.btnPesquisarEspecie.Text = "Pesquisar";
            this.btnPesquisarEspecie.UseVisualStyleBackColor = true;
            // 
            // fotoAnimal
            // 
            this.fotoAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpProvider.SetHelpString(this.fotoAnimal, "Campo de foto do animal a ser registrado");
            this.fotoAnimal.Location = new System.Drawing.Point(356, 16);
            this.fotoAnimal.Name = "fotoAnimal";
            this.helpProvider.SetShowHelp(this.fotoAnimal, true);
            this.fotoAnimal.Size = new System.Drawing.Size(247, 164);
            this.fotoAnimal.TabIndex = 13;
            this.fotoAnimal.TabStop = false;
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
            // fobias
            // 
            this.helpProvider.SetHelpString(this.fobias, "Digite as fobias do animal caso possua");
            this.fobias.Location = new System.Drawing.Point(24, 204);
            this.fobias.Name = "fobias";
            this.helpProvider.SetShowHelp(this.fobias, true);
            this.fobias.Size = new System.Drawing.Size(579, 20);
            this.fobias.TabIndex = 6;
            // 
            // EnderecoFoto
            // 
            this.EnderecoFoto.Enabled = false;
            this.helpProvider.SetHelpString(this.EnderecoFoto, "Insira o endereço da imagem Completo");
            this.EnderecoFoto.Location = new System.Drawing.Point(24, 160);
            this.EnderecoFoto.Name = "EnderecoFoto";
            this.helpProvider.SetShowHelp(this.EnderecoFoto, true);
            this.EnderecoFoto.Size = new System.Drawing.Size(259, 20);
            this.EnderecoFoto.TabIndex = 4;
            // 
            // identificacao
            // 
            this.helpProvider.SetHelpString(this.identificacao, "Digite uma característica fisica do Animal como identificação, Ex: Cor do pelo");
            this.identificacao.Location = new System.Drawing.Point(24, 116);
            this.identificacao.Name = "identificacao";
            this.helpProvider.SetShowHelp(this.identificacao, true);
            this.identificacao.Size = new System.Drawing.Size(326, 20);
            this.identificacao.TabIndex = 3;
            // 
            // raca
            // 
            this.helpProvider.SetHelpString(this.raca, "Digite a Raça do animal");
            this.raca.Location = new System.Drawing.Point(24, 72);
            this.raca.Name = "raca";
            this.helpProvider.SetShowHelp(this.raca, true);
            this.raca.Size = new System.Drawing.Size(259, 20);
            this.raca.TabIndex = 1;
            // 
            // especie
            // 
            this.helpProvider.SetHelpString(this.especie, "Digite a espécie do Animal");
            this.especie.Location = new System.Drawing.Point(24, 26);
            this.especie.Name = "especie";
            this.helpProvider.SetShowHelp(this.especie, true);
            this.especie.Size = new System.Drawing.Size(259, 20);
            this.especie.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.relacaoVacinas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(619, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Relação de Vacinas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // relacaoVacinas
            // 
            this.relacaoVacinas.Location = new System.Drawing.Point(3, 3);
            this.relacaoVacinas.Name = "relacaoVacinas";
            this.relacaoVacinas.Size = new System.Drawing.Size(613, 242);
            this.relacaoVacinas.TabIndex = 1;
            this.relacaoVacinas.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.observacaoComportamental);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(619, 248);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Obs Comportamental";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // observacaoComportamental
            // 
            this.observacaoComportamental.Location = new System.Drawing.Point(3, 3);
            this.observacaoComportamental.Name = "observacaoComportamental";
            this.observacaoComportamental.Size = new System.Drawing.Size(613, 242);
            this.observacaoComportamental.TabIndex = 0;
            this.observacaoComportamental.Text = "";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.observacaoRotina);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(619, 248);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Obs de Rotina";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // observacaoRotina
            // 
            this.observacaoRotina.Location = new System.Drawing.Point(3, 3);
            this.observacaoRotina.Name = "observacaoRotina";
            this.observacaoRotina.Size = new System.Drawing.Size(613, 242);
            this.observacaoRotina.TabIndex = 1;
            this.observacaoRotina.Text = "";
            // 
            // disponivelTosa
            // 
            this.disponivelTosa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.disponivelTosa.AutoSize = true;
            this.helpProvider.SetHelpString(this.disponivelTosa, "Selecione a opção caso o animal possua disponibilidade para ser tosado");
            this.disponivelTosa.Location = new System.Drawing.Point(13, 477);
            this.disponivelTosa.Name = "disponivelTosa";
            this.helpProvider.SetShowHelp(this.disponivelTosa, true);
            this.disponivelTosa.Size = new System.Drawing.Size(122, 17);
            this.disponivelTosa.TabIndex = 4;
            this.disponivelTosa.Text = "Disponivel para tosa";
            this.disponivelTosa.UseVisualStyleBackColor = true;
            // 
            // possuiPedigree
            // 
            this.possuiPedigree.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.possuiPedigree.AutoSize = true;
            this.helpProvider.SetHelpString(this.possuiPedigree, "Selecione a opção caso o animal possuir pedigree");
            this.possuiPedigree.Location = new System.Drawing.Point(13, 500);
            this.possuiPedigree.Name = "possuiPedigree";
            this.helpProvider.SetShowHelp(this.possuiPedigree, true);
            this.possuiPedigree.Size = new System.Drawing.Size(102, 17);
            this.possuiPedigree.TabIndex = 5;
            this.possuiPedigree.Text = "Possui Pedigree";
            this.possuiPedigree.UseVisualStyleBackColor = true;
            // 
            // agressivo
            // 
            this.agressivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.agressivo.AutoSize = true;
            this.helpProvider.SetHelpString(this.agressivo, "Selecione a opção caso o animal seja agressivo");
            this.agressivo.Location = new System.Drawing.Point(13, 522);
            this.agressivo.Name = "agressivo";
            this.helpProvider.SetShowHelp(this.agressivo, true);
            this.agressivo.Size = new System.Drawing.Size(72, 17);
            this.agressivo.TabIndex = 8;
            this.agressivo.Text = "Agressivo";
            this.agressivo.UseVisualStyleBackColor = true;
            // 
            // hiperativo
            // 
            this.hiperativo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hiperativo.AutoSize = true;
            this.helpProvider.SetHelpString(this.hiperativo, "Selecione a opção caso o animal seja hiperativo");
            this.hiperativo.Location = new System.Drawing.Point(156, 477);
            this.hiperativo.Name = "hiperativo";
            this.helpProvider.SetShowHelp(this.hiperativo, true);
            this.hiperativo.Size = new System.Drawing.Size(74, 17);
            this.hiperativo.TabIndex = 9;
            this.hiperativo.Text = "Hiperativo";
            this.hiperativo.UseVisualStyleBackColor = true;
            // 
            // antissocial
            // 
            this.antissocial.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.antissocial.AutoSize = true;
            this.helpProvider.SetHelpString(this.antissocial, "Selecione a opção caso o animal for Anti-Social");
            this.antissocial.Location = new System.Drawing.Point(156, 500);
            this.antissocial.Name = "antissocial";
            this.helpProvider.SetShowHelp(this.antissocial, true);
            this.antissocial.Size = new System.Drawing.Size(76, 17);
            this.antissocial.TabIndex = 10;
            this.antissocial.Text = "Anti Social";
            this.antissocial.UseVisualStyleBackColor = true;
            // 
            // obcessivo
            // 
            this.obcessivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.obcessivo.AutoSize = true;
            this.helpProvider.SetHelpString(this.obcessivo, "Selecione a opção caso o animal seja obcessivo");
            this.obcessivo.Location = new System.Drawing.Point(156, 523);
            this.obcessivo.Name = "obcessivo";
            this.helpProvider.SetShowHelp(this.obcessivo, true);
            this.obcessivo.Size = new System.Drawing.Size(75, 17);
            this.obcessivo.TabIndex = 11;
            this.obcessivo.Text = "Obsessivo";
            this.obcessivo.UseVisualStyleBackColor = true;
            // 
            // btnSalvarCadastro
            // 
            this.btnSalvarCadastro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.helpProvider.SetHelpString(this.btnSalvarCadastro, "Salve as informações de cadastro do animal");
            this.btnSalvarCadastro.Location = new System.Drawing.Point(461, 470);
            this.btnSalvarCadastro.Name = "btnSalvarCadastro";
            this.helpProvider.SetShowHelp(this.btnSalvarCadastro, true);
            this.btnSalvarCadastro.Size = new System.Drawing.Size(178, 36);
            this.btnSalvarCadastro.TabIndex = 12;
            this.btnSalvarCadastro.Text = "Salvar";
            this.btnSalvarCadastro.UseVisualStyleBackColor = true;
            // 
            // btnEmitirFicha
            // 
            this.btnEmitirFicha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.helpProvider.SetHelpString(this.btnEmitirFicha, "Emita uma ficha de cadastro do animal");
            this.btnEmitirFicha.Location = new System.Drawing.Point(277, 470);
            this.btnEmitirFicha.Name = "btnEmitirFicha";
            this.helpProvider.SetShowHelp(this.btnEmitirFicha, true);
            this.btnEmitirFicha.Size = new System.Drawing.Size(178, 36);
            this.btnEmitirFicha.TabIndex = 13;
            this.btnEmitirFicha.Text = "Emitir Ficha";
            this.btnEmitirFicha.UseVisualStyleBackColor = true;
            // 
            // btnRelatarAtendimento
            // 
            this.btnRelatarAtendimento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.helpProvider.SetHelpString(this.btnRelatarAtendimento, "Montar um retatório de atendimento do animal");
            this.btnRelatarAtendimento.Location = new System.Drawing.Point(277, 512);
            this.btnRelatarAtendimento.Name = "btnRelatarAtendimento";
            this.helpProvider.SetShowHelp(this.btnRelatarAtendimento, true);
            this.btnRelatarAtendimento.Size = new System.Drawing.Size(178, 36);
            this.btnRelatarAtendimento.TabIndex = 14;
            this.btnRelatarAtendimento.Text = "Relatar Atendimento";
            this.btnRelatarAtendimento.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.helpProvider.SetHelpString(this.btnSair, "Cancele o cadastro / edição do registro do animal");
            this.btnSair.Location = new System.Drawing.Point(461, 512);
            this.btnSair.Name = "btnSair";
            this.helpProvider.SetShowHelp(this.btnSair, true);
            this.btnSair.Size = new System.Drawing.Size(178, 36);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // AdicionarEditarAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 551);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRelatarAtendimento);
            this.Controls.Add(this.btnEmitirFicha);
            this.Controls.Add(this.btnSalvarCadastro);
            this.Controls.Add(this.obcessivo);
            this.Controls.Add(this.antissocial);
            this.Controls.Add(this.hiperativo);
            this.Controls.Add(this.agressivo);
            this.Controls.Add(this.possuiPedigree);
            this.Controls.Add(this.disponivelTosa);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoAnimal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDataDeRegistro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisarDono;
        private System.Windows.Forms.Label labelNomeDono;
        private System.Windows.Forms.TextBox nomeDonoAnimal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox sexoMacho;
        private System.Windows.Forms.CheckBox sexoFemea;
        private System.Windows.Forms.TextBox nomeAnimal;
        private System.Windows.Forms.Label labelNomeAnimal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox disponivelTosa;
        private System.Windows.Forms.CheckBox possuiPedigree;
        private System.Windows.Forms.CheckBox agressivo;
        private System.Windows.Forms.CheckBox hiperativo;
        private System.Windows.Forms.CheckBox antissocial;
        private System.Windows.Forms.CheckBox obcessivo;
        private System.Windows.Forms.Button btnSalvarCadastro;
        private System.Windows.Forms.Button btnEmitirFicha;
        private System.Windows.Forms.Button btnRelatarAtendimento;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisarLocalFoto;
        private System.Windows.Forms.Button btnPesquisarRaca;
        private System.Windows.Forms.Button btnPesquisarEspecie;
        private System.Windows.Forms.PictureBox fotoAnimal;
        private System.Windows.Forms.Label labelFobias;
        private System.Windows.Forms.Label labelEnderecoFoto;
        private System.Windows.Forms.Label labelIdentificacao;
        private System.Windows.Forms.Label labelRaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fobias;
        private System.Windows.Forms.TextBox EnderecoFoto;
        private System.Windows.Forms.TextBox identificacao;
        private System.Windows.Forms.TextBox raca;
        private System.Windows.Forms.TextBox especie;
        private System.Windows.Forms.RichTextBox observacaoComportamental;
        private System.Windows.Forms.RichTextBox observacaoRotina;
        private System.Windows.Forms.RichTextBox relacaoVacinas;
        private System.Windows.Forms.TextBox dataRegistroAnimal;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}