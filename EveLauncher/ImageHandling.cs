using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace EveLauncher
{
    class ImageHandling
    {
        public static Rectangle GetScaledRectangle(Image img, Rectangle thumbRect)
        {

            Size sourceSize = img.Size;
            Size targetSize = thumbRect.Size;
            float scale = Math.Max((float)targetSize.Width / sourceSize.Width, (float)targetSize.Height / sourceSize.Height);
            var rect = new RectangleF();
            rect.Width = scale * sourceSize.Width;
            rect.Height = scale * sourceSize.Height;
            rect.X = (targetSize.Width - rect.Width) / 2;
            rect.Y = (targetSize.Height - rect.Height) / 2;

            return Rectangle.Round(rect);
        }

        public static Image GetResizedImage(Image img, Rectangle rect)
        {
            Bitmap b = new Bitmap(rect.Width, rect.Height);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, 0, 0, rect.Width, rect.Height);
            g.Dispose();

            try
            {
                return (Image)b.Clone();
            }
            finally
            {
                b.Dispose();
                b = null;
                g = null;
            }
        }
    }
}
