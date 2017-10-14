using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    [Serializable]
    public class Entity
    {

        public double x, y, vx, vy, oldx, oldy, n;
        public int ix, iy, ivx, ivy, width, height, bx1, bx2, by1, by2, bcount;
        int i, j, k;
        int BLOCKSIZE = TerrariaClone.getBLOCKSIZE();
        public double mdelay = 0;

        public int thp, hp, ap, atk;

        public short id, num, dur;

        public bool onGround, immune, grounded, onGroundDelay, nohit;

        int dframes, imgDelay;

        public String name, AI, imgState;

        public Rectangle rect;

        public Entity newMob;

        [NonSerialized]
        public Image image;

        public Entity(double x, double y, double vx, double vy, String name)
        {
            this.x = x;
            this.y = y;
            this.vx = vx;
            this.vy = vy;
            this.name = name;
            oldx = x;
            oldy = y;
            ix = (int)x;
            iy = (int)y;
            nohit = false;

            if (name.Equals("blue_bubble")) { thp = 18; ap = 0; atk = 2; AI = "bubble"; }
            if (name.Equals("green_bubble")) { thp = 25; ap = 0; atk = 4; AI = "bubble"; }
            if (name.Equals("red_bubble")) { thp = 40; ap = 0; atk = 6; AI = "bubble"; }
            if (name.Equals("yellow_bubble")) { thp = 65; ap = 1; atk = 9; AI = "bubble"; }
            if (name.Equals("black_bubble")) { thp = 100; ap = 3; atk = 14; AI = "bubble"; }
            if (name.Equals("white_bubble")) { thp = 70; ap = 2; atk = 11; AI = "fast_bubble"; }
            if (name.Equals("zombie")) { thp = 35; ap = 0; atk = 5; AI = "zombie"; }
            if (name.Equals("armored_zombie")) { thp = 45; ap = 2; atk = 7; AI = "zombie"; }
            if (name.Equals("shooting_star")) { thp = 25; ap = 0; atk = 5; AI = "shooting_star"; }
            if (name.Equals("sandbot")) { thp = 50; ap = 2; atk = 3; AI = "sandbot"; }
            if (name.Equals("sandbot_bullet")) { thp = 1; ap = 0; atk = 7; AI = "bullet"; nohit = false; }
            if (name.Equals("snowman")) { thp = 40; ap = 0; atk = 6; AI = "zombie"; }
            if (name.Equals("bat")) { thp = 15; ap = 0; atk = 5; AI = "bat"; };
            if (name.Equals("bee")) { thp = 1; ap = 0; atk = 5; AI = "bee"; };
            if (name.Equals("skeleton")) { thp = 50; ap = 1; atk = 7; AI = "zombie"; };

            if (AI == "bubble" || AI == "fast_bubble" || AI == "shooting_star" || AI == "sandbot" || AI == "bullet" || AI == "bee")
            {
                image = loadImage("sprites/monsters/" + name + "/normal.png");
            }
            if (AI == "zombie")
            {
                image = loadImage("sprites/monsters/" + name + "/right_still.png");
            }
            if (AI == "bat")
            {
                image = loadImage("sprites/monsters/" + name + "/normal_right.png");
            }

            width = image.Width * 2; height = image.Height * 2;

            ix = (int)x;
            iy = (int)y;
            ivx = (int)vx;
            ivy = (int)vy;

            rect = new Rectangle(ix - 1, iy, width + 2, height);

            imgDelay = 0;
            bcount = 0;
            if (AI == "bat")
            {
                imgState = "normal right";
                this.vx = 3;
            }
            else
            {
                imgState = "still right";
            }

            hp = thp;
        }

        public Entity(double x, double y, double vx, double vy, short id, short num) : this(x, y, vx, vy, id, num, (short)0, 0) { }

        public Entity(double x, double y, double vx, double vy, short id, short num, int mdelay) : this(x, y, vx, vy, id, num, (short)0, mdelay) { }

        public Entity(double x, double y, double vx, double vy, short id, short num, short dur) : this(x, y, vx, vy, id, num, dur, 0) { }

        public Entity(double x, double y, double vx, double vy, short id, short num, short dur, int mdelay)
        {
            this.x = x;
            this.y = y;
            this.vx = vx;
            this.vy = vy;
            this.name = name;
            this.id = id;
            this.num = num;
            this.dur = dur;
            this.mdelay = mdelay;
            oldx = x;
            oldy = y;
            ix = (int)x;
            iy = (int)y;

            dframes = 0;

            image = TerrariaClone.getItemImgs()[id];

            width = image.Width * 2; height = image.Height * 2;
        }

        public bool update(int[,] blocks, Player player, int u, int v)
        {
            newMob = null;
            if (name == null)
            {
                if (!onGround)
                {
                    vy = vy + 0.3;
                    if (vy > 7)
                    {
                        vy = 7;
                    }
                }
                if (vx < -0.15)
                {
                    vx = vx + 0.15;
                }
                else if (vx > 0.15)
                {
                    vx = vx - 0.15;
                }
                else
                {
                    vx = 0;
                }
                collide(blocks, player, u, v);
                mdelay -= 1;
            }
            if (AI == "bullet")
            {
                if (collide(blocks, player, u, v))
                {
                    return true;
                }
            }
            if (AI == "zombie")
            {
                if (!onGround)
                {
                    vy = vy + 0.3;
                    if (vy > 7)
                    {
                        vy = 7;
                    }
                }
                if (x > player.x)
                {
                    vx = Math.Max(vx - 0.1, -1.2);
                    if (imgState == "still left" || imgState == "still right" ||
                        imgState == "walk right 1" || imgState == "walk right 2")
                    {
                        imgDelay = 10;
                        imgState = "walk left 2";
                        image = loadImage("sprites/monsters/" + name + "/left_walk.png");
                    }
                    if (imgDelay <= 0)
                    {
                        if (imgState == "walk left 1")
                        {
                            imgDelay = 10;
                            imgState = "walk left 2";
                            image = loadImage("sprites/monsters/" + name + "/left_walk.png");
                        }
                        else
                        {
                            if (imgState == "walk left 2")
                            {
                                imgDelay = 10;
                                imgState = "walk left 1";
                                image = loadImage("sprites/monsters/" + name + "/left_still.png");
                            }
                        }
                    }
                    else
                    {
                        imgDelay = imgDelay - 1;
                    }
                }
                else
                {
                    vx = Math.Min(vx + 0.1, 1.2);
                    if (imgState == "still left" || imgState == "still right" ||
                        imgState == "walk left 1" || imgState == "walk left 2")
                    {
                        imgDelay = 10;
                        imgState = "walk right 2";
                        image = loadImage("sprites/monsters/" + name + "/right_walk.png");
                    }
                    if (imgDelay <= 0)
                    {
                        if (imgState == "walk right 1")
                        {
                            imgDelay = 10;
                            imgState = "walk right 2";
                            image = loadImage("sprites/monsters/" + name + "/right_walk.png");
                        }
                        else
                        {
                            if (imgState == "walk right 2")
                            {
                                imgDelay = 10;
                                imgState = "walk right 1";
                                image = loadImage("sprites/monsters/" + name + "/right_still.png");
                            }
                        }
                    }
                    else
                    {
                        imgDelay = imgDelay - 1;
                    }
                }
                if (!grounded)
                {
                    if (imgState == "still left" || imgState == "walk left 1" ||
                        imgState == "walk left 2")
                    {
                        image = loadImage("sprites/monsters/" + name + "/left_jump.png");
                    }
                    if (imgState == "still right" || imgState == "walk right 1" ||
                        imgState == "walk right 2")
                    {
                        image = loadImage("sprites/monsters/" + name + "/right_jump.png");
                    }
                }
                collide(blocks, player, u, v);
            }
            if (AI == "bubble")
            {
                if (x > player.x)
                {
                    vx = Math.Max(vx - 0.1, -1.2);
                }
                else
                {
                    vx = Math.Min(vx + 0.1, 1.2);
                }
                if (y > player.y)
                {
                    vy = Math.Max(vy - 0.1, -1.2);
                }
                else
                {
                    vy = Math.Min(vy + 0.1, 1.2);
                }
                collide(blocks, player, u, v);
            }
            if (AI == "fast_bubble")
            {
                if (x > player.x)
                {
                    vx = Math.Max(vx - 0.2, -2.4);
                }
                else
                {
                    vx = Math.Min(vx + 0.2, 2.4);
                }
                if (y > player.y)
                {
                    vy = Math.Max(vy - 0.2, -2.4);
                }
                else
                {
                    vy = Math.Min(vy + 0.2, 2.4);
                }
                collide(blocks, player, u, v);
            }
            if (AI == "shooting_star")
            {
                n = Math.Atan2(player.y - y, player.x - x);
                vx += Math.Cos(n) / 10;
                vy += Math.Sin(n) / 10;
                if (vx < -5) vx = -5;
                if (vx > 5) vx = 5;
                if (vy < -5) vy = -5;
                if (vy > 5) vy = 5;
                collide(blocks, player, u, v);
            }
            if (AI == "sandbot")
            {
                if (Math.Sqrt(Math.Pow(player.x - x, 2) + Math.Pow(player.y - y, 2)) > 160)
                {
                    if (x > player.x)
                    {
                        vx = Math.Max(vx - 0.1, -1.2);
                    }
                    else
                    {
                        vx = Math.Min(vx + 0.1, 1.2);
                    }
                    if (y > player.y)
                    {
                        vy = Math.Max(vy - 0.1, -1.2);
                    }
                    else
                    {
                        vy = Math.Min(vy + 0.1, 1.2);
                    }
                }
                else
                {
                    if (x < player.x)
                    {
                        vx = Math.Max(vx - 0.1, -1.2);
                    }
                    else
                    {
                        vx = Math.Min(vx + 0.1, 1.2);
                    }
                    if (y < player.y)
                    {
                        vy = Math.Max(vy - 0.1, -1.2);
                    }
                    else
                    {
                        vy = Math.Min(vy + 0.1, 1.2);
                    }
                }
                bcount += 1;
                if (bcount == 110)
                {
                    image = loadImage("sprites/monsters/" + name + "/ready1.png");
                }
                if (bcount == 130)
                {
                    image = loadImage("sprites/monsters/" + name + "/ready2.png");
                }
                if (bcount == 150)
                {
                    double theta = Math.Atan2(player.y - y, player.x - x);
                    newMob = new Entity(x, y, Math.Cos(theta) * 3.5, Math.Sin(theta) * 3.5, name + "_bullet");
                }
                if (bcount == 170)
                {
                    image = loadImage("sprites/monsters/" + name + "/ready1.png");
                }
                if (bcount == 190)
                {
                    image = loadImage("sprites/monsters/" + name + "/normal.png");
                    bcount = 0;
                }
                collide(blocks, player, u, v);
            }
            if (AI == "bat")
            {
                if (vx > 3)
                {
                    vx = 3;
                }
                if (vx < 3)
                {
                    vx = -3;
                }
                if (y > player.y)
                {
                    vy = Math.Max(vy - 0.05, -2.0);
                }
                else
                {
                    vy = Math.Min(vy + 0.05, 2.0);
                }
                imgDelay -= 1;
                if (vx > 0 && imgState != "normal right")
                {
                    imgState = "normal right";
                    image = loadImage("sprites/monsters/" + name + "/normal_right.png");
                    imgDelay = 10;
                }
                if (vx < 0 && imgState != "normal left")
                {
                    imgState = "normal left";
                    image = loadImage("sprites/monsters/" + name + "/normal_left.png");
                    imgDelay = 10;
                }
                if (imgState == "normal left" && imgDelay <= 0)
                {
                    imgState = "flap left";
                    image = loadImage("sprites/monsters/" + name + "/flap_left.png");
                    imgDelay = 10;
                }
                if (imgState == "normal right" && imgDelay <= 0)
                {
                    imgState = "flap right";
                    image = loadImage("sprites/monsters/" + name + "/flap_right.png");
                    imgDelay = 10;
                }
                if (imgState == "flap left" && imgDelay <= 0)
                {
                    imgState = "normal left";
                    image = loadImage("sprites/monsters/" + name + "/normal_left.png");
                    imgDelay = 10;
                }
                if (imgState == "flap right" && imgDelay <= 0)
                {
                    imgState = "normal right";
                    image = loadImage("sprites/monsters/" + name + "/normal_right.png");
                    imgDelay = 10;
                }
                collide(blocks, player, u, v);
            }
            if (AI == "bee")
            {
                double theta = Math.Atan2(player.y - y, player.x - x);
                vx = Math.Cos(theta) * 2.5;
                vy = Math.Sin(theta) * 2.5;
                collide(blocks, player, u, v);
            }
            return false;
        }

        public bool collide(int[,] blocks, Player player, int u, int v)
        {
            bool rv = false;

            grounded = (onGround || onGroundDelay);

            onGroundDelay = onGround;

            oldx = x; oldy = y;

            x = x + vx;

            for (i = 0; i < 2; i++)
            {
                ix = (int)x;
                iy = (int)y;
                ivx = (int)vx;
                ivy = (int)vy;

                rect = new Rectangle(ix - 1, iy, width + 2, height);

                bx1 = (int)x / BLOCKSIZE; by1 = (int)y / BLOCKSIZE;
                bx2 = (int)(x + width) / BLOCKSIZE; by2 = (int)(y + height) / BLOCKSIZE;

                bx1 = Math.Max(0, bx1); by1 = Math.Max(0, by1);
                bx2 = Math.Min(blocks.GetUpperBound(1) - 1, bx2); by2 = Math.Min(blocks.Length - 1, by2);

                for (i = bx1; i <= bx2; i++)
                {
                    for (j = by1; j <= by2; j++)
                    {
                        if (blocks[j,i] != 0 && TerrariaClone.getBLOCKCD()[blocks[j + v,i + u]])
                        {
                            if (rect.Intersects(new Rectangle(i * BLOCKSIZE, j * BLOCKSIZE, BLOCKSIZE, BLOCKSIZE)))
                            {
                                if (oldx <= i * 16 - width && (vx > 0 || AI == "shooting_star"))
                                {
                                    x = i * 16 - width;
                                    if (AI == "bubble")
                                    {
                                        vx = -vx;
                                    }
                                    else if (AI == "zombie")
                                    {
                                        vx = 0;
                                        if (onGround && player.x > x)
                                        {
                                            vy = -7;
                                        }
                                    }
                                    else if (AI == "bat")
                                    {
                                        vx = -vx;
                                    }
                                    else
                                    {
                                        vx = 0; // right
                                    }
                                    rv = true;
                                }
                                if (oldx >= i * 16 + BLOCKSIZE && (vx < 0 || AI == "shooting_star"))
                                {
                                    x = i * 16 + BLOCKSIZE;
                                    if (AI == "bubble")
                                    {
                                        vx = -vx;
                                    }
                                    else if (AI == "zombie")
                                    {
                                        vx = 0;
                                        if (onGround && player.x < x)
                                        {
                                            vy = -7;
                                        }
                                    }
                                    else if (AI == "bat")
                                    {
                                        vx = -vx;
                                    }
                                    else
                                    {
                                        vx = 0; // left
                                    }
                                    rv = true;
                                }
                            }
                        }
                    }
                }
            }

            y = y + vy;
            onGround = false;

            for (i = 0; i < 2; i++)
            {
                ix = (int)x;
                iy = (int)y;
                ivx = (int)vx;
                ivy = (int)vy;

                rect = new Rectangle(ix, iy - 1, width, height + 2);

                bx1 = (int)x / BLOCKSIZE; by1 = (int)y / BLOCKSIZE;
                bx2 = (int)(x + width) / BLOCKSIZE; by2 = (int)(y + height) / BLOCKSIZE;

                bx1 = Math.Max(0, bx1); by1 = Math.Max(0, by1);
                bx2 = Math.Min(blocks.GetUpperBound(1) - 1, bx2); by2 = Math.Min(blocks.Length - 1, by2);

                for (i = bx1; i <= bx2; i++)
                {
                    for (j = by1; j <= by2; j++)
                    {
                        if (blocks[j,i] != 0 && TerrariaClone.getBLOCKCD()[blocks[j + v,i + u]])
                        {
                            if (rect.Intersects(new Rectangle(i * BLOCKSIZE, j * BLOCKSIZE, BLOCKSIZE, BLOCKSIZE)))
                            {
                                if (oldy <= j * 16 - height && (vy > 0 || AI == "shooting_star"))
                                {
                                    y = j * 16 - height;
                                    onGround = true;
                                    if (AI == "bubble")
                                    {
                                        vy = -vy;
                                    }
                                    else
                                    {
                                        vy = 0; // down
                                    }
                                    rv = true;
                                }
                                if (oldy >= j * 16 + BLOCKSIZE && (vy < 0 || AI == "shooting_star"))
                                {
                                    y = j * 16 + BLOCKSIZE;
                                    if (AI == "bubble")
                                    {
                                        vy = -vy;
                                    }
                                    else
                                    {
                                        vy = 0; // up
                                    }
                                    rv = true;
                                }
                            }
                        }
                    }
                }
            }

            ix = (int)x;
            iy = (int)y;
            ivx = (int)vx;
            ivy = (int)vy;

            rect = new Rectangle(ix - 1, iy - 1, width + 2, height + 2);

            return rv;
        }

        public bool hit(int damage, Player player)
        {
            if (!immune && !nohit)
            {
                hp -= Math.Max(1, damage - ap);
                immune = true;
                if (AI == "shooting_star")
                {
                    if (player.x + player.width / 2 < x + width / 2)
                    {
                        vx = 4;
                    }
                    else
                    {
                        vx = -4;
                    }
                }
                else
                {
                    if (player.x + player.width / 2 < x + width / 2)
                    {
                        vx += 4;
                    }
                    else
                    {
                        vx -= 4;
                    }
                    vy -= 1.2;
                }
            }
            return hp <= 0;
        }

        public List<short> drops()
        {
            List<short> dropList = new List<short>();
            Random random = TerrariaClone.getRandom();
            if (name == "blue_bubble")
            {
                for (i = 0; i < random.Next(3); i++)
                {
                    dropList.Add((short)97);
                }
            }
            if (name == "green_bubble")
            {
                for (i = 0; i < random.Next(3); i++)
                {
                    dropList.Add((short)98);
                }
            }
            if (name == "red_bubble")
            {
                for (i = 0; i < random.Next(3); i++)
                {
                    dropList.Add((short)99);
                }
            }
            if (name == "yellow_bubble")
            {
                for (i = 0; i < random.Next(3); i++)
                {
                    dropList.Add((short)100);
                }
            }
            if (name == "black_bubble")
            {
                for (i = 0; i < random.Next(3); i++)
                {
                    dropList.Add((short)101);
                }
            }
            if (name == "white_bubble")
            {
                for (i = 0; i < random.Next(3); i++)
                {
                    dropList.Add(((short)102));
                }
            }
            if (name == "shooting_star")
            {
                for (i = 0; i < random.Next(2); i++)
                {
                    dropList.Add(((short)103));
                }
            }
            if (name == "zombie")
            {
                for (i = 0; i < random.Next(3); i++)
                {
                    dropList.Add(((short)104));
                }
            }
            if (name == "armored_zombie")
            {
                for (i = 0; i < random.Next(3); i++)
                {
                    dropList.Add(((short)104));
                }
                if (random.Next(15) == 0)
                {
                    dropList.Add(((short)109));
                }
                if (random.Next(15) == 0)
                {
                    dropList.Add(((short)110));
                }
                if (random.Next(15) == 0)
                {
                    dropList.Add(((short)111));
                }
                if (random.Next(15) == 0)
                {
                    dropList.Add(((short)112));
                }
            }
            if (name == "sandbot")
            {
                for (i = 0; i < random.Next(3); i++)
                {
                    dropList.Add(((short)74));
                }
                if (random.Next(2) == 0)
                {
                    dropList.Add(((short)44));
                }
                if (random.Next(6) == 0)
                {
                    dropList.Add(((short)45));
                }
            }
            if (name == "snowman")
            {
                for (i = 0; i < random.Next(3); i++)
                {
                    dropList.Add(((short)75));
                }
            }
            return dropList;
        }

        public void reloadImage()
        {
            if (AI.Equals("bubble") || AI.Equals("shooting_star"))
            {
                image = loadImage("sprites/monsters/" + name + "/normal.png");
            }
            if (AI.Equals("zombie"))
            {
                image = loadImage("sprites/monsters/" + name + "/right_still.png");
            }
        }

        public static Image loadImage(String path)
        {
            var url = Util.getResource(path);
            Image image = null;
            try
            {
                image = ImageIO.read(url);
            }
            catch (Exception e)
            {
                //            Console.WriteLine("[ERROR] could not load image '" + path + "'.");
            }
            return image;
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
