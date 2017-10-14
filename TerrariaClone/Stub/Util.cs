using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    public static class Util
    {
        public static Uri getResource(string path)
        {
            return new Uri(System.IO.Path.GetFullPath($"./{path}"));
        }
    }
}
