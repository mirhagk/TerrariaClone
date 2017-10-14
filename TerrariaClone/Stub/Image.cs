using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    public class Image
    {
        public Image(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public Image(Texture2D texture)
        {
            Texture = texture;
            Width = Texture.Width;
            Height = Texture.Height;
        }
        public int Width { get; }
        public int Height { get; }
        public Texture2D Texture;
        public Graphics2D Graphics;
        public Graphics2D createGraphics()
        {
            return Graphics = new Graphics2D(Width, Height, parentImage: true);
        }
        public void setRGB(int x, int y, uint color)
        {
            if (Texture != null) throw new NotSupportedException();
            if (Graphics == null) createGraphics();
            Graphics.setPixel(x, y, color);
        }

        internal uint getRGB(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
