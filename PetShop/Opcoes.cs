using PetShop.Entities;
using PetShop.Entities.Exceptions;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PetShop
{
    public partial class Opcoes : Form
    {
        private Button BtnEnderecoBackup;
        private Button BtnSelecionarDb;
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        public Opcoes()
        {
            InitializeComponent();
        }

        private void Opcoes_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.DbBackUpLocation))
            {
                txtEnderecoBackup.Text = Properties.Settings.Default.DbBackUpLocation;
            }
            if (Properties.Settings.Default.DbBackUpPeriod != new TimeSpan(0))
            {
                if (Properties.Settings.Default.DbBackUpPeriod == new TimeSpan(1, 0, 0))
                {
                    comboTempoBackup.SelectedIndex = 0;
                }
                else if (Properties.Settings.Default.DbBackUpPeriod == new TimeSpan(5, 0, 0))
                {
                    comboTempoBackup.SelectedIndex = 1;
                }
                else if (Properties.Settings.Default.DbBackUpPeriod == new TimeSpan(10, 0, 0))
                {
                    comboTempoBackup.SelectedIndex = 2;
                }
                else if (Properties.Settings.Default.DbBackUpPeriod == new TimeSpan(15, 0, 0))
                {
                    comboTempoBackup.SelectedIndex = 3;
                }
                else if (Properties.Settings.Default.DbBackUpPeriod == new TimeSpan(24, 0, 0))
                {
                    comboTempoBackup.SelectedIndex = 4;
                }
                else if (Properties.Settings.Default.DbBackUpPeriod == new TimeSpan(5, 0, 0, 0))
                {
                    comboTempoBackup.SelectedIndex = 5;
                }
            }
            else
            {
                comboTempoBackup.SelectedIndex = 6;
            }
            // Botão de selecionar local de backup
            BtnEnderecoBackup = new Button
            {
                Size = new Size(25, txtEnderecoBackup.ClientSize.Height),
                Dock = DockStyle.Right,
                Cursor = Cursors.Default,
                Image = Properties.Resources.icons8_Browse_Folder_20px_1,
                ImageAlign = ContentAlignment.MiddleCenter,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.Transparent
            };
            BtnEnderecoBackup.FlatAppearance.BorderSize = 0;
            txtEnderecoBackup.Controls.Add(BtnEnderecoBackup);
            BtnEnderecoBackup.Click += new EventHandler(BtnEnderecoBackup_Click);
            //
            // Botão de selecionar banco de dados para restaurar
            BtnSelecionarDb = new Button
            {
                Size = new Size(25, txtEnderecoBackup.ClientSize.Height),
                Dock = DockStyle.Right,
                Cursor = Cursors.Default,
                Image = Properties.Resources.icons8_Browse_Folder_20px_1,
                ImageAlign = ContentAlignment.MiddleCenter,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.Transparent
            };
            BtnSelecionarDb.FlatAppearance.BorderSize = 0;
            txtRestauracaoDb.Controls.Add(BtnSelecionarDb);
            BtnSelecionarDb.Click += new EventHandler(BtnSelecionarDb_Click);
            //
            comboTempoBackup.SelectedIndexChanged += new EventHandler(comboTempoBackup_SelectedIndexChanged);
            txtEnderecoBackup.GotFocus += new EventHandler(txtEnderecoBackup_GotFocus);
            txtRestauracaoDb.GotFocus += new EventHandler(txtRestauracaoDb_GotFocus);
        }

        private void txtRestauracaoDb_GotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
        }

        private void txtEnderecoBackup_GotFocus(object sender, EventArgs e)
        {
            HideCaret((sender as TextBox).Handle);
        }

        private void comboTempoBackup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.DbBackUpLocation))
            {
                switch (comboTempoBackup.SelectedIndex)
                {
                    case 0:
                        Properties.Settings.Default.DbBackUpPeriod = new TimeSpan(1, 0, 0);
                        break;
                    case 1:
                        Properties.Settings.Default.DbBackUpPeriod = new TimeSpan(5, 0, 0);
                        break;
                    case 2:
                        Properties.Settings.Default.DbBackUpPeriod = new TimeSpan(10, 0, 0);
                        break;
                    case 3:
                        Properties.Settings.Default.DbBackUpPeriod = new TimeSpan(15, 0, 0);
                        break;
                    case 4:
                        Properties.Settings.Default.DbBackUpPeriod = new TimeSpan(24, 0, 0);
                        break;
                    case 5:
                        Properties.Settings.Default.DbBackUpPeriod = new TimeSpan(5, 0, 0, 0);
                        break;
                    case 6:
                        Properties.Settings.Default.DbBackUpPeriod = new TimeSpan(0);
                        break;
                }
            }
            else
            {
                Properties.Settings.Default.DbBackUpPeriod = new TimeSpan(0);
                comboTempoBackup.SelectedIndexChanged -= comboTempoBackup_SelectedIndexChanged;
                comboTempoBackup.SelectedIndex = 6;
                comboTempoBackup.SelectedIndexChanged += comboTempoBackup_SelectedIndexChanged;
                MessageBox.Show("Selecione um diretório de backup antes de selecionar o período de backup", "Selecione um período de backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Properties.Settings.Default.Save();
        }

        private void BtnSelecionarDb_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "SQL Server Compact Edition Database File (.sdf)|*.sdf";
                openFileDialog.FilterIndex = 2;
                openFileDialog.DefaultExt = "sdf";
                try
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtRestauracaoDb.Text = openFileDialog.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao selecionar o arquivo: {ex.Message}", "Erro ao selecionar arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!string.IsNullOrWhiteSpace(txtRestauracaoDb.Text))
            {
                btnRestaurar.Enabled = true;
            }
            else
            {
                btnRestaurar.Enabled = false;
            }
        }

        private void BtnEnderecoBackup_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.ShowNewFolderButton = true;
                if (folderDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    Properties.Settings.Default.DbBackUpLocation = folderDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                    txtEnderecoBackup.Text = Properties.Settings.Default.DbBackUpLocation;
                }
            }
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem certeza que quer realizar a restauração do banco de dados?", "Restauração do banco de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    File.Copy(txtRestauracaoDb.Text, $@"{AppDomain.CurrentDomain.BaseDirectory}Data\PetShopDb.sdf", true);
                    FormNotificacao formNotificacao = new FormNotificacao();
                    formNotificacao.ShowAlert("O banco de dados foi restaurado", Entities.Enums.TipoNotificacao.Informacao, "Restaurar banco de dados");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao restaurar o banco de dados: {ex.Message}", "Erro ao restaurar banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErrorLogger.CreateErrorLog(ex);
                }
            }
        }

        private void comboNomeTabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNomeTabela.SelectedIndex != -1 && comboLimparDados.SelectedIndex != -1)
            {
                btnLimparDb.Enabled = true;
            }
            else
            {
                btnLimparDb.Enabled = false;
            }
        }

        private void comboLimparDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNomeTabela.SelectedIndex != -1 && comboLimparDados.SelectedIndex != -1)
            {
                btnLimparDb.Enabled = true;
            }
            else
            {
                btnLimparDb.Enabled = false;
            }
        }

        private void btnLimparDb_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Tem certeza que deseja remover os registros de {comboNomeTabela.Text} do período de: {comboLimparDados.Text}?", "Limpeza do Banco de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                void ClearTable(Action<DateTime> removeFuncWithDate, Action removeFuncNoDate)
                {

                    switch (comboLimparDados.SelectedIndex)
                    {
                        case 0:
                            removeFuncWithDate(DateTime.Now.Date.AddYears(-2));
                            break;
                        case 1:
                            removeFuncWithDate(DateTime.Now.Date.AddYears(-1));
                            break;
                        case 2:
                            removeFuncWithDate(DateTime.Now.Date.AddMonths(-5));
                            break;
                        case 3:
                            removeFuncWithDate(DateTime.Now.Date.AddMonths(-1));
                            break;
                        case 4:
                            removeFuncWithDate(DateTime.Now.Date.AddDays(-7));
                            break;
                        case 5:
                            removeFuncNoDate();
                            break;
                    }
                }
                switch (comboNomeTabela.SelectedIndex)
                {
                    case 0:
                        ClearTable(new Action<DateTime>(Agenda.RemoverAgendamento), Agenda.RemoverAgendamento);
                        break;
                    case 1:
                        ClearTable(new Action<DateTime>(Animal.ExcluirAnimal), Animal.ExcluirAnimal);
                        break;
                    case 2:
                        ClearTable(new Action<DateTime>(Cliente.ExcluirCliente), Cliente.ExcluirCliente);
                        break;
                    case 3:
                        ClearTable(new Action<DateTime>(Fornecedor.ExcluirFornecedor), Fornecedor.ExcluirFornecedor);
                        break;
                    case 4:
                        ClearTable(new Action<DateTime>(Produto.RemoverProduto), Produto.RemoverProduto);
                        break;
                    case 5:
                        ClearTable(new Action<DateTime>(Vacina.ExcluirVacina), Vacina.ExcluirVacina);
                        break;
                    case 6:
                        ClearTable(new Action<DateTime>(Venda.RemoverVendas), Venda.RemoverVendas);
                        break;
                }
            }
        }
    }
}
