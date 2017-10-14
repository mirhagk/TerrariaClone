using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TerrariaClone
{
    static class ImageIO
    {
        public static Image read(string url)
        {
            return new Image(Game1.Instance.Content.Load<Texture2D>($"textures/{url}"));
        }

        internal static void write(Image texture, string format, FileStream fileStream)
        {
            throw new NotImplementedException();
        }
    }
}
