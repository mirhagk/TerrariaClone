using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    public class TextField
    {

        int width, height;
        public String text;
        Font font;
        public Image image;

        public TextField(int width, String text)
        {
            this.width = width;
            this.height = 30;
            this.text = text;
            this.font = new Font("Chalkboard", Font.Bold, 16);
            renderImage();
        }

        public void typeKey(char c)
        {
            text += c;
            renderImage();
        }

        public void deleteKey()
        {
            if (text.Length > 0)
            {
                text = text.Substring(0, text.Length - 1);
                renderImage();
            }
        }

        public void renderImage()
        {
            image = new Image(width, height);

            Graphics2D g2 = (Graphics2D)image.createGraphics();

            g2.setColor(Color.White);
            g2.setFont(font);
            g2.drawString(text, 6, height - 10);

            g2.setColor(Color.Black);
            g2.fillRect(0, 0, width, 3);
            g2.fillRect(0, 0, 3, height);
            g2.fillRect(0, height - 3, width, 3);
            g2.fillRect(width - 3, 0, 3, height);
        }

        public static void print(String text)
        {
            Console.WriteLine(text);
        }

        public static void print(int text)
        {
            Console.WriteLine(text);
        }

        public static void print(double text)
        {
            Console.WriteLine(text);
        }

        public static void print(short text)
        {
            Console.WriteLine(text);
        }

        public static void print(bool text)
        {
            Console.WriteLine(text);
        }

        public static void print(Object text)
        {
            Console.WriteLine(text);
        }
    }
}
