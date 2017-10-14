using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerrariaClone.Extensions;

namespace TerrariaClone
{
    public class RandConverter
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
            Console.WriteLine("[D]uplicate, [R]andomize, or [O]utline? ");
            char option = Console.ReadLine()[0];
            while (true)
            {
                Console.WriteLine("Generate new textures for: ");
                String name = Console.ReadLine();
                if (name.Equals("exit"))
                {
                    break;
                }
                if (option == 'O')
                {
                    for (int k = 0; k < dirs.Length; k++)
                    {
                        for (int j = 2; j < 6; j++)
                        {
                            Image texture = loadImage("outlines/" + name + "/" + dirs[k] + "1.png");
                            int i, x, y;
                            int[] xy;
                            int[][] coords = new int[IMAGESIZE * IMAGESIZE][];
                            for (int iter = 0; iter < coords.Length; iter++)
                                coords[iter] = new int[2];
                            Image result;
                            for (i = 0; i < 7; i++)
                            {
                                for (x = 0; x < IMAGESIZE; x++)
                                {
                                    for (y = 0; y < IMAGESIZE; y++)
                                    {
                                        coords[x * IMAGESIZE + y][0] = x;
                                        coords[x * IMAGESIZE + y][1] = y;
                                    }
                                }
                                result = new Image(IMAGESIZE, IMAGESIZE);
                                for (x = 0; x < IMAGESIZE; x++)
                                {
                                    for (y = 0; y < IMAGESIZE; y++)
                                    {
                                        xy = coords[x * IMAGESIZE + y];
                                        result.setRGB(xy[0], xy[1], texture.getRGB(x, y));
                                    }
                                }
                                try
                                {
                                    ImageIO.write(result, "png", File.Create("outlines/" + name + "/" + dirs[k] + j + ".png"));
                                }
                                catch (IOException e)
                                {
                                    Console.WriteLine("Error in writing file.");
                                }
                            }
                        }
                    }
                }
                else
                {
                    Image texture = loadImage("blocks/" + name + "/texture1.png");
                    int i, x, y;
                    int[] xy;
                    int[][] coords = new int[IMAGESIZE * IMAGESIZE][];
                    Image result;
                    for (i = 0; i < 7; i++)
                    {
                        for (x = 0; x < IMAGESIZE; x++)
                        {
                            for (y = 0; y < IMAGESIZE; y++)
                            {
                                coords[x * IMAGESIZE + y] = new int[2];
                                coords[x * IMAGESIZE + y][0] = x;
                                coords[x * IMAGESIZE + y][1] = y;
                            }
                        }
                        if (option == 'R')
                        {
                            coords.Shuffle();
                        }
                        result = new Image(IMAGESIZE, IMAGESIZE);
                        for (x = 0; x < IMAGESIZE; x++)
                        {
                            for (y = 0; y < IMAGESIZE; y++)
                            {
                                xy = coords[x * IMAGESIZE + y];
                                result.setRGB(xy[0], xy[1], texture.getRGB(x, y));
                            }
                        }
                        try
                        {
                            ImageIO.write(result, "png", File.Create("blocks/" + name + "/texture" + (i + 2) + ".png"));
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("Error in writing file.");
                        }
                    }
                }
            }
        }

        private static Image loadImage(String path)
        {
            var url = Util.getResource(path);
            Image image = null;
            try
            {
                image = ImageIO.read(url);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: could not load image '" + path + "'.");
            }
            return image;
        }
    }

}
