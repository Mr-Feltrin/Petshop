using System;
using System.Drawing;
using System.IO;

namespace PetShop.ToolBox
{
    public static class ConversorImagemByte
    {
        public static byte[] ImageToStream(Image image)
        {
            MemoryStream stream = new MemoryStream();
            try
            {
                Bitmap bitmapImage = new Bitmap(image);
                bitmapImage.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return stream.ToArray();
        }

        public static Bitmap RetrieveImage(byte[] image)
        {
            MemoryStream stream = new MemoryStream();
            try
            {
                stream.Write(image, 0, image.Length);
                return new Bitmap(stream);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
