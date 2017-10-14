using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    public static class Util
    {
        public static string getResource(string path)
        {
            return System.IO.Path.ChangeExtension(path, null);
        }
    }
}
