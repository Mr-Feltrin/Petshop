using PetShop.Entities.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FormNotificacao : Form
    {
        private int x { get; set; }
        private int y { get; set; }
        private EnumAction Action { get; set; }
        private TipoNotificacao Notificacao { get; set; }

        private enum EnumAction
        {
            wait,
            start,
            close
        }

        public FormNotificacao()
        {
            InitializeComponent();
        }

        public void ShowAlert(string Message, TipoNotificacao tipoNotificacao, string headerText = null)
        {
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string fname;
            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                FormNotificacao frm = (FormNotificacao)Application.OpenForms[fname];
                if (frm == null)
                {
                    Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(x, y);
                    break;
                }
            }
            x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (tipoNotificacao)
            {
                case TipoNotificacao.Confirmar:
                    pictureBox.Image = Properties.Resources.ok_45x45;
                    BackColor = Color.SeaGreen;
                    break;
                case TipoNotificacao.Erro:
                    pictureBox.Image = Properties.Resources.warning_45x45;
                    BackColor = Color.DarkRed;
                    break;
                case TipoNotificacao.Informacao:
                    pictureBox.Image = Properties.Resources.information_45x45;
                    BackColor = Color.RoyalBlue;
                    break;
                case TipoNotificacao.Agendamento:
                    pictureBox.Image = Properties.Resources.notificacao_agendamento_45x45;
                    BackColor = Color.RoyalBlue;
                    break;
            }
            labelNotificacao.Text = Message;
            labelHeader.Text = headerText;
            Show();
            Notificacao = tipoNotificacao;
            Action = EnumAction.start;
            timer.Interval = 1;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (Action)
            {
                case EnumAction.wait:
                    if (Notificacao != TipoNotificacao.Agendamento)
                    {
                        timer.Interval = 5000;
                        Action = EnumAction.close;
                    }
                    else if (Notificacao == TipoNotificacao.Agendamento)
                    {
                        timer.Interval = 30 * 60 * 1000;
                        Action = EnumAction.close;
                    }
                    break;
                case EnumAction.start:
                    timer.Interval = 1;
                    Opacity += 0.1;
                    if (x < Location.X)
                    {
                        Left--;
                    }
                    else
                    {
                        if (Opacity == 1.0)
                        {
                            Action = EnumAction.wait;
                        }
                    }
                    break;
                case EnumAction.close:
                    timer.Interval = 1;
                    Opacity -= 0.1;
                    Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            timer.Interval = 1;
            Action = EnumAction.close;
        }
    }
}
