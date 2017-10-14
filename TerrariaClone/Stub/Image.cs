using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    public class Image
    {
        public Image(int width, int height) { }
        public int Width => throw new NotImplementedException();
        public int Height => throw new NotImplementedException();
        public Graphics2D createGraphics() => throw new NotImplementedException();
        public void setRGB(int x, int y, uint color) => throw new NotImplementedException();

        internal uint getRGB(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
