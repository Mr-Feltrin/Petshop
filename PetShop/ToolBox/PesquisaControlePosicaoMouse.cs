using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.ToolBox
{
    public static class PesquisaControlePosicaoMouse
    {
        private static Control EncontrarControleNoPoint(Control container, Point pos)
        {
            Control child;
            foreach (Control c in container.Controls)
            {
                if (c.Visible && c.Bounds.Contains(pos))
                {
                    child = EncontrarControleNoPoint(c, new Point(pos.X - c.Left, pos.Y - c.Top));
                    if (child == null)
                    {
                        return c;
                    }
                    else
                    {
                        return child;
                    }
                }
            }
            return null;
        }
        
        /// <summary>
        /// Procurar um controle sobre o mouse
        /// </summary>
        /// <param name="form">Form atual</param>
        /// <returns>Retorna o controle abaixo do mouse caso não seja Null</returns>
        public static Control EncontrarControleNoCursor(Form form)
        {
            Point pos = Cursor.Position;
            if (form.Bounds.Contains(pos))
            {
                return EncontrarControleNoPoint(form, form.PointToClient(pos));
            }
            return null;
        }
    }
}
