using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PetShop.ToolBox
{
    public static class VerificarCamposObrigatorios
    {
        /// <summary>
        /// Verifica se os controles estão preenchidos e ativa ou desativa o botão referenciado inserindo a descrição do ToolTip
        /// </summary>
        /// <param name="button">Botão de ação para ser Ativado ou Desativado</param>
        /// <param name="ListaControles">Lista dos controles obrigatórios, e a respectica string de erro para ser exibida no ToolTip</param>
        /// 
        public static void ChecarCampos(Button button, Dictionary<object, string> ListaControles, ToolTip toolTip)
        {
            void DesativarBotao(KeyValuePair<object, string> obj)
            {
                button.Enabled = false;
                toolTip.SetToolTip(button, obj.Value);             
            }

            foreach (KeyValuePair<object, string> objeto in ListaControles)
            {
                if (objeto.Key.GetType() == typeof(TextBox))
                {
                    if (string.IsNullOrWhiteSpace((objeto.Key as TextBox).Text))
                    {
                        DesativarBotao(objeto);
                        break;
                    }
                    else
                    {
                        button.Enabled = true;
                    }
                }
                else if (objeto.Key.GetType() == typeof(MaskedTextBox))
                {
                    if (!(objeto.Key as MaskedTextBox).MaskCompleted)
                    {
                        DesativarBotao(objeto);
                        break;
                    }
                    else
                    {
                        button.Enabled = true;
                    }
                }
                else if (objeto.Key.GetType() == typeof(ComboBox))
                {
                    if ((objeto.Key as ComboBox).SelectedIndex == -1)
                    {
                        DesativarBotao(objeto);
                        break;
                    }
                    else
                    {
                        button.Enabled = true;
                    }
                }
                
                else if (objeto.Key.GetType() == typeof(CheckBox))
                {
                    if (!(objeto.Key as CheckBox).Checked)
                    {
                        DesativarBotao(objeto);
                        break;
                    }
                    else
                    {
                        button.Enabled = true;
                    }
                }               
            }
        }


        /// <summary>
        /// Limpa o texto dos controles MaskedTextBox opcionais que não estejam completos
        /// </summary>
        /// <param name="ListaMaskedTextsOpcionais">Lista dos campos opcionais</param>
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
