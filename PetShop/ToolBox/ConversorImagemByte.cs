using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace PetShop.ToolBox
{
    public static class ConversorImagemByte
    {
        public static byte[] ImageToStream(string filePath)
        {
            MemoryStream stream = new MemoryStream();
            try
            {
                Bitmap image = new Bitmap(filePath);
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception e)
            {
                return null;
            }
            return stream.ToArray();
        }

        public static Bitmap RetrieveImage(byte[] image)
        {
            MemoryStream stream = new MemoryStream(image);
            return new Bitmap(stream);
        }
    }
}
