using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    public class LightConverter
    {

        static int BLOCKSIZE = 16;
        static int IMAGESIZE = 8;

        static String[] dirs = {"center", "tdown_both", "tdown_cw", "tdown_ccw",
        "tdown", "tup_both", "tup_cw", "tup_ccw",
        "tup", "leftright", "tright_both", "tright_cw",
        "tright_ccw", "tright", "upleftdiag", "upleft",
        "downleftdiag", "downleft", "left", "tleft_both",
        "tleft_cw", "tleft_ccw", "tleft", "uprightdiag",
        "upright", "downrightdiag", "downright", "right",
        "updown", "up", "down", "single"};

        public static void main(String[] args)
        {
            for (int i = 0; i < 17; i++)
            {
                Console.WriteLine("Generate new textures [" + i + "] for: ");
                String name = Console.ReadLine();
                Image light = loadImage("light/" + i + ".png");
                for (int j = 1; j < 9; j++)
                {
                    Image texture = loadImage("blocks/" + name + "/texture" + j + ".png");
                    texture.createGraphics().drawImage(light,
                        0, 0, IMAGESIZE, IMAGESIZE,
                        0, 0, IMAGESIZE, IMAGESIZE,
                        null);
                    try
                    {
                        ImageIO.write(texture, "png", File.Create("blocks/" + name + "/texture" + j + ".png"));
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("Error in writing file.");
                    }
                }
            }
        }

        private static Image loadImage(String path)
        {
            Uri url = Util.getResource(path);
        Image image = null;
        try {
            image = ImageIO.read(url);
        }
        catch (Exception e) {
            Console.WriteLine("Error: could not load image '" + path + "'.");
}
        return image;
    }
}

}
