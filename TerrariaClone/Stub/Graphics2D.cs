﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    public class Graphics { }
    public class Graphics2D : Graphics
    {
        static Texture2D pixelTexture;

        readonly bool isParentImage;
        int Width;
        int Height;
        RenderTarget2D target;
        public Graphics2D(int width, int height, bool parentImage)
        {
            isParentImage = parentImage;
            Width = width;
            Height = height;
            if (isParentImage)
                target = new RenderTarget2D(graphics, Width, Height);
            if (pixelTexture == null)
            {
                pixelTexture = new Texture2D(graphics, 1, 1);
                pixelTexture.SetData(new Color[] { Color.White });
            }
        }
        GraphicsDevice graphics => Game1.Instance.GraphicsDevice;
        public void drawImage(Image img,
           int dstx1, int dsty1, int dstx2, int dsty2,
           int srcx1, int srcy1, int srcx2, int srcy2,
           object observer)
        {
            Texture2D tex = img.Texture;
            if (tex == null)
            {
                Color[] arr = new Color[img.Width * img.Height];
                img.Graphics.target.GetData(arr);
                tex = new Texture2D(graphics, img.Width, img.Height);
                tex.SetData(arr);
            }
            graphics.SetRenderTarget(target);
            var sb = new SpriteBatch(graphics);
            sb.Begin();
            sb.Draw(tex, new Rectangle(dstx1, dsty1, dstx2 - dstx1, dsty2 - dsty1), new Rectangle(srcx1, srcy1, srcx2 - srcx1, srcy2 - srcy1), Color.White);
            sb.End();
        }
        Color drawColor = Color.White;
        Font drawFont = null;
        public void setFont(Font font) => drawFont = font;
        public void setColor(Color color) => drawColor = color;
        public void drawString(string text, int x, int y)
        {
            //TODO: Do
            //throw new NotImplementedException();
        }
        public static implicit operator GraphicsDevice(Graphics2D source)
        {
            throw new NotImplementedException();
        }

        internal void fillRect(int x, int y, int width, int height)
        {
            graphics.SetRenderTarget(target);
            var sb = new SpriteBatch(graphics);
            sb.Begin();
            sb.Draw(pixelTexture, new Rectangle(x, y, width, height), drawColor);
            sb.End();
        }

        internal void translate(double p1, double p2)
        {
            throw new NotImplementedException();
        }

        internal void rotate(double v)
        {
            throw new NotImplementedException();
        }
    }
}
