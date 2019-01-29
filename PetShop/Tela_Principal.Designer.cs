namespace PetShop
{
    partial class Tela_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Principal));
            this.menu_principal = new System.Windows.Forms.ToolStrip();
            this.botao_clientes = new System.Windows.Forms.ToolStripButton();
            this.botao_fornecedores = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.botao_agenda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.botao_produtos = new System.Windows.Forms.ToolStripButton();
            this.menu_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_principal
            // 
            this.menu_principal.AllowMerge = false;
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botao_clientes,
            this.botao_fornecedores,
            this.toolStripSeparator,
            this.botao_agenda,
            this.toolStripSeparator1,
            this.botao_produtos});
            this.menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.Size = new System.Drawing.Size(1184, 52);
            this.menu_principal.TabIndex = 0;
            this.menu_principal.Text = "toolStrip1";
            // 
            // botao_clientes
            // 
            this.botao_clientes.BackColor = System.Drawing.Color.Transparent;
            this.botao_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_clientes.Image = ((System.Drawing.Image)(resources.GetObject("botao_clientes.Image")));
            this.botao_clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botao_clientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botao_clientes.Name = "botao_clientes";
            this.botao_clientes.Size = new System.Drawing.Size(63, 49);
            this.botao_clientes.Text = "Clientes";
            this.botao_clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botao_clientes.Click += new System.EventHandler(this.botao_clientes_Click);
            // 
            // botao_fornecedores
            // 
            this.botao_fornecedores.BackColor = System.Drawing.Color.Transparent;
            this.botao_fornecedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_fornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_fornecedores.Image = ((System.Drawing.Image)(resources.GetObject("botao_fornecedores.Image")));
            this.botao_fornecedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botao_fornecedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botao_fornecedores.Name = "botao_fornecedores";
            this.botao_fornecedores.Size = new System.Drawing.Size(63, 49);
            this.botao_fornecedores.Text = "Fornece";
            this.botao_fornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao_fornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.botao_produtos.Image = ((System.Drawing.Image)(resources.GetObject("botao_produtos.Image")));
            this.botao_produtos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botao_produtos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botao_produtos.Name = "botao_produtos";
            this.botao_produtos.Size = new System.Drawing.Size(68, 49);
            this.botao_produtos.Text = "Produtos";
            this.botao_produtos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botao_produtos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botao_produtos.ToolTipText = "Produtos";
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 614);
            this.Controls.Add(this.menu_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Principal";
            this.Text = "Pet Shop";
            this.Load += new System.EventHandler(this.Tela_Principal_Load);
            this.menu_principal.ResumeLayout(false);
            this.menu_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu_principal;
        private System.Windows.Forms.ToolStripButton botao_clientes;
        private System.Windows.Forms.ToolStripButton botao_fornecedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton botao_agenda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton botao_produtos;
    }
}

