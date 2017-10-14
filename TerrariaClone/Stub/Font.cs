using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    public class Font
    {
        public Font(string name, string format, int size)
        {
            if (defaultFont==null)
            {
                defaultFont = Game1.Instance.Content.Load<SpriteFont>("fonts/default");
            }
        }
        public SpriteFont SpriteFont => defaultFont;
        static SpriteFont defaultFont;
        public static string Plain { get; } = "Plain";
        public static string Bold { get; } = "Bold";
    }
}
