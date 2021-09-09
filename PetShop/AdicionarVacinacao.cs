using PetShop.Entities;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;

namespace PetShop
{
    public partial class AdicionarEditarVacinacao : Form
    {
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);
        private Animal _AnimalId;
        private Vacina _VacinaId;
        private Animal AnimalId
        {
            get
            {
                return _AnimalId;
            }
            set
            {
                _AnimalId = value;
                if (value != null && VacinaId != null)
                {
                    btnSalvar.Enabled = true;
                }
                else
                {
                    btnSalvar.Enabled = false;
                }
            }
        }
        private Vacina VacinaId
        {
            get
            {
                return _VacinaId;
            }
            set
            {
                _VacinaId = value;
                if (_VacinaId != null && AnimalId != null)
                {
                    btnSalvar.Enabled = true;
                }
                else
                {
                    btnSalvar.Enabled = false;
                }
            }
        }
        private Button btnPesquisarAnimal { get; set; }
        private Button btnPesquisarVacina { get; set; }

        public AdicionarEditarVacinacao()
        {
            InitializeComponent();
        }

        private void AdicionarEditarVacinacao_Load(object sender, EventArgs e)
        {
            txtDataVacinacao.Text = DateTime.Now.ToString("dd/MM/yyyy");
            btnPesquisarAnimal = new Button();
            btnPesquisarAnimal.Size = new Size(25, txtNomeAnimal.ClientSize.Height);
            btnPesquisarAnimal.Dock = DockStyle.Right;
            btnPesquisarAnimal.Cursor = Cursors.Default;
            btnPesquisarAnimal.Image = Properties.Resources.icons8_Browse_Folder_20px_1;
            btnPesquisarAnimal.ImageAlign = ContentAlignment.MiddleCenter;
            btnPesquisarAnimal.FlatStyle = FlatStyle.Flat;
            btnPesquisarAnimal.ForeColor = Color.White;
            btnPesquisarAnimal.BackColor = Color.Transparent;
            btnPesquisarAnimal.FlatAppearance.BorderSize = 0;
            txtNomeAnimal.Controls.Add(btnPesquisarAnimal);
            btnPesquisarAnimal.Click += new EventHandler(btnPesquisarAnimal_Click);
            btnPesquisarVacina = new Button();
            btnPesquisarVacina.Size = new Size(25, txtNomeAnimal.ClientSize.Height);
            btnPesquisarVacina.Dock = DockStyle.Right;
            btnPesquisarVacina.Cursor = Cursors.Default;
            btnPesquisarVacina.Image = Properties.Resources.icons8_Browse_Folder_20px_1;
            btnPesquisarVacina.ImageAlign = ContentAlignment.MiddleCenter;
            btnPesquisarVacina.FlatStyle = FlatStyle.Flat;
            btnPesquisarVacina.ForeColor = Color.White;
            btnPesquisarVacina.BackColor = Color.Transparent;
            btnPesquisarVacina.FlatAppearance.BorderSize = 0;
            txtVacina.Controls.Add(btnPesquisarVacina);
            btnPesquisarVacina.Click += new EventHandler(btnPesquisarVacina_Click);
            txtDataVacinacao.GotFocus += new EventHandler(TextBoxReadOnlyGotFocus);
            txtNomeAnimal.GotFocus += new EventHandler(TextBoxReadOnlyGotFocus);
            txtVacina.GotFocus += new EventHandler(TextBoxReadOnlyGotFocus);
            txtLote.GotFocus += new EventHandler(TextBoxReadOnlyGotFocus);
            txtFabricante.GotFocus += new EventHandler(TextBoxReadOnlyGotFocus);
            txtConteudoMl.GotFocus += new EventHandler(TextBoxReadOnlyGotFocus);
            txtDoses.GotFocus += new EventHandler(TextBoxReadOnlyGotFocus);
            txtDataValidade.GotFocus += new EventHandler(TextBoxReadOnlyGotFocus);
        }

        private void btnPesquisarVacina_Click(object sender, EventArgs e)
        {
            using (ListaVacinas listaVacinas = new ListaVacinas(this))
            {
                listaVacinas.ShowDialog();
            }
        }

        private void btnPesquisarAnimal_Click(object sender, EventArgs e)
        {
            using (ListaDeClientesAnimais listaDeClientesAnimais = new ListaDeClientesAnimais(this))
            {
                listaDeClientesAnimais.ShowDialog();
            }
        }

        private void TextBoxReadOnlyGotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }

        internal void AddAnimal(Animal animal)
        {
            try
            {
                AnimalId = animal;
                txtNomeAnimal.Text = AnimalId.Nome;
            }
            catch
            {
                AnimalId = null;
                txtNomeAnimal.Text = string.Empty;
            }

        }

        internal void AddVacina(Vacina vacina)
        {
            try
            {
                VacinaId = vacina;
                txtVacina.Text = VacinaId.Imunologia;
                txtLote.Text = !string.IsNullOrWhiteSpace(VacinaId.Lote) ? VacinaId.Lote : "N.D";
                txtFabricante.Text = VacinaId.Fabricante;
                txtConteudoMl.Text = VacinaId.ConteudoML.ToString();
                txtDoses.Text = VacinaId.Doses.ToString();
                txtDataValidade.Text = VacinaId.DataValidade.ToString("dd/MM/yyyy");
            }
            catch
            {
                VacinaId = null;
                txtLote.Text = string.Empty;
                txtFabricante.Text = string.Empty;
                txtConteudoMl.Text = string.Empty;
                txtDoses.Text = string.Empty;
                txtDataValidade.Text = string.Empty;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Vacinacao vacinacao = new Vacinacao(AnimalId, VacinaId, DateTime.Now.Date);
            vacinacao.AdicionarVacinacao();
            if (Application.OpenForms.OfType<PesquisarVacinacoes>().Count() == 1)
            {
                Application.OpenForms.OfType<PesquisarVacinacoes>().First().AtualizarListaVacinacoes();
            }
            Close();           
        }
    }
}
