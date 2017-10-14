using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    public class Graphics { }
    public class Graphics2D : Graphics
    {
        public void drawImage(Image img,
           int dstx1, int dsty1, int dstx2, int dsty2,
           int srcx1, int srcy1, int srcx2, int srcy2,
           object observer)
            => throw new NotImplementedException();
        public void setFont(Font font) => throw new NotImplementedException();
        public void setColor(Color color) => throw new NotImplementedException();
        public void drawString(string text, int x, int y) => throw new NotImplementedException();
        public static implicit operator GraphicsDevice(Graphics2D source)
        {
            throw new NotImplementedException();
        }

        internal void fillRect(int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        internal void translate(double p1, double p2)
        {
            throw new NotImplementedException();
        }

        internal void rotate(double v)
        {
            throw new NotImplementedException();
        }
    }
}
