using DocumentFormat.OpenXml.Drawing;
using PetShop.ToolBox.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace PetShop.ToolBox
{
    public static class VerificarCamposObrigatorios
    {
        /// <summary>
        /// Verifica se o valor do Control não está vazio
        /// </summary>
        private static bool ControlPreenchido(Control control)
        {
            if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(TextBoxBorderColored))
            {
                if (string.IsNullOrWhiteSpace((control as TextBox).Text))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (control.GetType() == typeof(MaskedTextBox))
            {
                if (!(control as MaskedTextBox).MaskCompleted)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (control.GetType() == typeof(ComboBox) || control.GetType() == typeof(ComboBoxFlatBordered))
            {
                if (string.IsNullOrWhiteSpace((control as ComboBox).Text))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            else if (control.GetType() == typeof(CheckBox))
            {
                if (!(control as CheckBox).Checked)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica se os controles estão preenchidos e ativa ou desativa o botão referenciado inserindo a descrição do ToolTip
        /// </summary>
        /// <param name="button">Botão de ação para ser Ativado ou Desativado</param>
        /// <param name="ListaControles">Lista dos controles obrigatórios, e a respectica string de erro para ser exibida no ToolTip</param>
        /// 
        public static void ChecarCampos(Button button, Dictionary<Control, string> ListaControles, ToolTip toolTip)
        {

            void DesativarBotao(string toolTipText)
            {
                button.Enabled = false;
                toolTip.SetToolTip(button, toolTipText);
            }

            void AtivarBotao()
            {
                if (button.Enabled == false)
                {
                    button.Enabled = true;
                    toolTip.SetToolTip(button, null);
                }
            }

            if (ListaControles.Any(control => ControlPreenchido(control.Key) == false))
            {
                if (ListaControles.Any(control => (string)control.Key.Tag == "obrigatorioAlternativa") == false)
                {
                    DesativarBotao(ListaControles.Where(control => ControlPreenchido(control.Key) == false).First().Value);
                }
                else
                {
                    if (ListaControles.Where(control => (string)control.Key.Tag != "obrigatorioAlternativa").Any(control => ControlPreenchido(control.Key) == false))
                    {
                        DesativarBotao(ListaControles.First(control => (string)control.Key.Tag != "obrigatorioAlternativa" && ControlPreenchido(control.Key) == false).Value);
                    }
                    else if (ListaControles.Where(control => (string)control.Key.Tag != "obrigatorioAlternativa").Any(control => ControlPreenchido(control.Key) == false) == false && ListaControles.Where(control => (string)control.Key.Tag == "obrigatorioAlternativa").Any(control => ControlPreenchido(control.Key)) == false)
                    {
                        DesativarBotao(ListaControles.Where(control => (string)control.Key.Tag == "obrigatorioAlternativa").First(control => ControlPreenchido(control.Key) == false).Value);
                    }
                    else
                    {
                        AtivarBotao();
                    }
                }
            }
            else
            {
                AtivarBotao();
            }
        }
        /// <summary>
        /// Limpa o texto dos controles MaskedTextBox opcionais que não estejam completos
        /// </summary>
        public static void LimparCamposOpcionais(List<MaskedTextBox> ListaMaskedTextsOpcionais)
        {
            foreach (MaskedTextBox maskedTextBox in ListaMaskedTextsOpcionais)
            {
                if (!maskedTextBox.MaskCompleted)
                {
                    maskedTextBox.Clear();
                    maskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                }
            }
        }
    }
}

