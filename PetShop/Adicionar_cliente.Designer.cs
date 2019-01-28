namespace PetShop
{
    partial class Adicionar_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adicionar_cliente));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.nome_completo_cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tipo_cliente = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.enderecos_contato = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.email_cliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.complemento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uf = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nome_endereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nome_apelido_cliente = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.informacoes_observacoes = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.numero_cpf = new System.Windows.Forms.MaskedTextBox();
            this.numero_cpnj = new System.Windows.Forms.MaskedTextBox();
            this.numero_telefone_primario = new System.Windows.Forms.MaskedTextBox();
            this.numero_telefone_secundario = new System.Windows.Forms.MaskedTextBox();
            this.numero_celular = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.enderecos_contato.SuspendLayout();
            this.informacoes_observacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome / Razão Completo";
            // 
            // nome_completo_cliente
            // 
            this.nome_completo_cliente.BackColor = System.Drawing.SystemColors.Info;
            this.nome_completo_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_completo_cliente.Location = new System.Drawing.Point(34, 47);
            this.nome_completo_cliente.Name = "nome_completo_cliente";
            this.nome_completo_cliente.Size = new System.Drawing.Size(332, 22);
            this.nome_completo_cliente.TabIndex = 1;
            this.nome_completo_cliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Segmento do Cliente ou Tipo";
            // 
            // tipo_cliente
            // 
            this.tipo_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_cliente.FormattingEnabled = true;
            this.tipo_cliente.Items.AddRange(new object[] {
            "Cliente Fixo",
            "Fornecedor",
            "Funcionário"});
            this.tipo_cliente.Location = new System.Drawing.Point(456, 47);
            this.tipo_cliente.Name = "tipo_cliente";
            this.tipo_cliente.Size = new System.Drawing.Size(243, 24);
            this.tipo_cliente.TabIndex = 3;
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
            this.enderecos_contato.Controls.Add(this.maskedTextBox1);
            this.enderecos_contato.Controls.Add(this.numero_celular);
            this.enderecos_contato.Controls.Add(this.numero_telefone_secundario);
            this.enderecos_contato.Controls.Add(this.numero_telefone_primario);
            this.enderecos_contato.Controls.Add(this.numero_cpnj);
            this.enderecos_contato.Controls.Add(this.numero_cpf);
            this.enderecos_contato.Controls.Add(this.label14);
            this.enderecos_contato.Controls.Add(this.label13);
            this.enderecos_contato.Controls.Add(this.email_cliente);
            this.enderecos_contato.Controls.Add(this.label12);
            this.enderecos_contato.Controls.Add(this.complemento);
            this.enderecos_contato.Controls.Add(this.label11);
            this.enderecos_contato.Controls.Add(this.label10);
            this.enderecos_contato.Controls.Add(this.label9);
            this.enderecos_contato.Controls.Add(this.label8);
            this.enderecos_contato.Controls.Add(this.label7);
            this.enderecos_contato.Controls.Add(this.uf);
            this.enderecos_contato.Controls.Add(this.label6);
            this.enderecos_contato.Controls.Add(this.cidade);
            this.enderecos_contato.Controls.Add(this.label5);
            this.enderecos_contato.Controls.Add(this.bairro);
            this.enderecos_contato.Controls.Add(this.label4);
            this.enderecos_contato.Controls.Add(this.nome_endereco);
            this.enderecos_contato.Controls.Add(this.label3);
            this.enderecos_contato.Controls.Add(this.nome_apelido_cliente);
            this.enderecos_contato.Controls.Add(this.name_label);
            this.enderecos_contato.Location = new System.Drawing.Point(4, 22);
            this.enderecos_contato.Name = "enderecos_contato";
            this.enderecos_contato.Padding = new System.Windows.Forms.Padding(3);
            this.enderecos_contato.Size = new System.Drawing.Size(657, 300);
            this.enderecos_contato.TabIndex = 0;
            this.enderecos_contato.Text = "Endereços e Contato";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(530, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "N° CNPJ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(363, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "N° CPF";
            // 
            // email_cliente
            // 
            this.email_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_cliente.Location = new System.Drawing.Point(18, 244);
            this.email_cliente.Name = "email_cliente";
            this.email_cliente.Size = new System.Drawing.Size(293, 22);
            this.email_cliente.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "E-mail";
            // 
            // complemento
            // 
            this.complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complemento.Location = new System.Drawing.Point(481, 191);
            this.complemento.Name = "complemento";
            this.complemento.Size = new System.Drawing.Size(156, 22);
            this.complemento.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(478, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Complemento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(325, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "N° Celular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(169, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "2° Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "1° Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(547, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "CEP";
            // 
            // uf
            // 
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
            this.uf.Location = new System.Drawing.Point(450, 137);
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(62, 24);
            this.uf.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "UF";
            // 
            // cidade
            // 
            this.cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade.Location = new System.Drawing.Point(281, 138);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(140, 22);
            this.cidade.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cidade";
            // 
            // bairro
            // 
            this.bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairro.Location = new System.Drawing.Point(18, 138);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(241, 22);
            this.bairro.TabIndex = 5;
            this.bairro.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bairro";
            // 
            // nome_endereco
            // 
            this.nome_endereco.BackColor = System.Drawing.SystemColors.Window;
            this.nome_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_endereco.Location = new System.Drawing.Point(18, 86);
            this.nome_endereco.Name = "nome_endereco";
            this.nome_endereco.Size = new System.Drawing.Size(619, 22);
            this.nome_endereco.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome da Rua / AV";
            // 
            // nome_apelido_cliente
            // 
            this.nome_apelido_cliente.BackColor = System.Drawing.SystemColors.Window;
            this.nome_apelido_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_apelido_cliente.Location = new System.Drawing.Point(18, 37);
            this.nome_apelido_cliente.Name = "nome_apelido_cliente";
            this.nome_apelido_cliente.Size = new System.Drawing.Size(619, 22);
            this.nome_apelido_cliente.TabIndex = 1;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(15, 16);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(183, 17);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Nome Fantasia / Apelido";
            // 
            // informacoes_observacoes
            // 
            this.informacoes_observacoes.Controls.Add(this.richTextBox1);
            this.informacoes_observacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informacoes_observacoes.Location = new System.Drawing.Point(4, 22);
            this.informacoes_observacoes.Name = "informacoes_observacoes";
            this.informacoes_observacoes.Padding = new System.Windows.Forms.Padding(3);
            this.informacoes_observacoes.Size = new System.Drawing.Size(657, 300);
            this.informacoes_observacoes.TabIndex = 1;
            this.informacoes_observacoes.Text = "Informações / Observações";
            this.informacoes_observacoes.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(645, 288);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(519, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adicionar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(34, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numero_cpf
            // 
            this.numero_cpf.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.numero_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_cpf.Location = new System.Drawing.Point(366, 245);
            this.numero_cpf.Mask = "000.000.000-00";
            this.numero_cpf.Name = "numero_cpf";
            this.numero_cpf.Size = new System.Drawing.Size(100, 22);
            this.numero_cpf.TabIndex = 26;
            // 
            // numero_cpnj
            // 
            this.numero_cpnj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_cpnj.Location = new System.Drawing.Point(537, 244);
            this.numero_cpnj.Mask = "00.000.000/0000-00";
            this.numero_cpnj.Name = "numero_cpnj";
            this.numero_cpnj.Size = new System.Drawing.Size(100, 22);
            this.numero_cpnj.TabIndex = 27;
            // 
            // numero_telefone_primario
            // 
            this.numero_telefone_primario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_telefone_primario.Location = new System.Drawing.Point(18, 191);
            this.numero_telefone_primario.Mask = "(00)0000-0000";
            this.numero_telefone_primario.Name = "numero_telefone_primario";
            this.numero_telefone_primario.Size = new System.Drawing.Size(125, 22);
            this.numero_telefone_primario.TabIndex = 28;
            // 
            // numero_telefone_secundario
            // 
            this.numero_telefone_secundario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_telefone_secundario.Location = new System.Drawing.Point(172, 193);
            this.numero_telefone_secundario.Mask = "(00)0000-0000";
            this.numero_telefone_secundario.Name = "numero_telefone_secundario";
            this.numero_telefone_secundario.Size = new System.Drawing.Size(125, 22);
            this.numero_telefone_secundario.TabIndex = 29;
            // 
            // numero_celular
            // 
            this.numero_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_celular.Location = new System.Drawing.Point(328, 191);
            this.numero_celular.Mask = "(00)90000-0000";
            this.numero_celular.Name = "numero_celular";
            this.numero_celular.Size = new System.Drawing.Size(125, 22);
            this.numero_celular.TabIndex = 30;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(550, 138);
            this.maskedTextBox1.Mask = "00000-000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(87, 22);
            this.maskedTextBox1.TabIndex = 31;
            // 
            // Adicionar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(750, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tipo_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nome_completo_cliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Adicionar_cliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar_cliente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Adicionar_cliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.enderecos_contato.ResumeLayout(false);
            this.enderecos_contato.PerformLayout();
            this.informacoes_observacoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome_completo_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tipo_cliente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage enderecos_contato;
        private System.Windows.Forms.TabPage informacoes_observacoes;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox nome_apelido_cliente;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox email_cliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox complemento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox uf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nome_endereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MaskedTextBox numero_cpf;
        private System.Windows.Forms.MaskedTextBox numero_cpnj;
        private System.Windows.Forms.MaskedTextBox numero_telefone_secundario;
        private System.Windows.Forms.MaskedTextBox numero_telefone_primario;
        private System.Windows.Forms.MaskedTextBox numero_celular;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}