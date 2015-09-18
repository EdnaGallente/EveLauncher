using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EveLauncher
{
    public class ImageFillBox : Control
    {
        public ImageFillBox()
        {
            SetStyle(ControlStyles.Selectable | ControlStyles.SupportsTransparentBackColor, false);
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.Opaque | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
        }
        private Image image;
        public Image Image
        {
            get { return image; }
            set
            {
                if (image == value) return;
                image = value;
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (image == null)
                e.Graphics.Clear(BackColor);
            else
            {
                Size sourceSize = image.Size, targetSize = ClientSize;
                float scale = Math.Max((float)targetSize.Width / sourceSize.Width, (float)targetSize.Height / sourceSize.Height);
                var rect = new RectangleF();
                rect.Width = scale * sourceSize.Width;
                rect.Height = scale * sourceSize.Height;
                rect.X = (targetSize.Width - rect.Width) / 2;
                rect.Y = (targetSize.Height - rect.Height) / 2;
                e.Graphics.DrawImage(image, rect);
            }
        }
    }
}
