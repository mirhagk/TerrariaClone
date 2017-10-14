using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    enum Transparency
    {
        Translucent
    }
    class GraphicsConfiguration
    {
        public static GraphicsConfiguration Config;

        internal Image createCompatibleImage(int width, int height, Transparency transparency)
        {
            throw new NotImplementedException();
        }
    }
}
