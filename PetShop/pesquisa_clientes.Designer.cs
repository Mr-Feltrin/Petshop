namespace PetShop
{
    partial class Pesquisa_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa_clientes));
            this.tabela_pesquisa_usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_pesquisa_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabela_pesquisa_usuarios
            // 
            this.tabela_pesquisa_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_pesquisa_usuarios.Location = new System.Drawing.Point(12, 80);
            this.tabela_pesquisa_usuarios.Name = "tabela_pesquisa_usuarios";
            this.tabela_pesquisa_usuarios.Size = new System.Drawing.Size(1292, 571);
            this.tabela_pesquisa_usuarios.TabIndex = 0;
            // 
            // Pesquisa_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 663);
            this.Controls.Add(this.tabela_pesquisa_usuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pesquisa_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de clientes";
            this.Load += new System.EventHandler(this.Pesquisa_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_pesquisa_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabela_pesquisa_usuarios;
    }
}