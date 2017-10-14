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
    public class Inventory
    {

        public int i, j, k, x, y, n, px, py, selection, width, height;
        double fpx, fpy;
        short r;

        [NonSerialized]
        public Image image, box, box_selected;
        Font font = new Font("Chalkboard", Font.Plain, 12);

        [NonSerialized]
        Graphics2D g2;

        public short[] ids;
        public short[] nums;
        public short[] durs;
        short[][] list_thing;
        short[][] r1;
        short[] r2;

        int trolx = 37;
        int troly = 17;

        public int CX, CY;

        bool valid = false;

        ItemCollection ic;

        Dictionary<String, short[][]> RECIPES;

        public Inventory()
        {
            ids = new short[40];
            nums = new short[40];
            durs = new short[40];
            for (i = 0; i < 40; i++)
            {
                ids[i] = 0;
                nums[i] = 0;
                durs[i] = 0;
            }
            selection = 0;
            image = new Image(466, 190);
            box = loadImage("interface/inventory.png");
            box_selected = loadImage("interface/inventory_selected.png");
            g2 = image.createGraphics();
            for (x = 0; x < 10; x++)
            {
                for (y = 0; y < 4; y++)
                {
                    if (x == 0 && y == 0)
                    {
                        g2.drawImage(box_selected,
                            x * 46 + 6, y * 46 + 6, x * 46 + 46, y * 46 + 46,
                            0, 0, 40, 40,
                            null);
                        if (y == 0)
                        {
                            g2.setFont(font);
                            g2.setColor(Color.Black);
                            g2.drawString(f(x) + " ", x * 46 + trolx, y * 46 + troly);
                        }
                    }
                    else
                    {
                        g2.drawImage(box,
                            x * 46 + 6, y * 46 + 6, x * 46 + 46, y * 46 + 46,
                            0, 0, 40, 40,
                            null);
                        if (y == 0)
                        {
                            g2.setFont(font);
                            g2.setColor(Color.Black);
                            g2.drawString(f(x) + " ", x * 46 + trolx, y * 46 + troly);
                        }
                    }
                }
            }

            RECIPES = new Dictionary<string, short[][]>();

            short[][] list_thing1 = new short[][]{
            new short[]{15, 15, 15,
                0, 15, 0,
            0, 15, 0, 154, 1}, // Wooden Pick
            new short[]{2, 2, 2,
                0, 15, 0,
            0, 15, 0, 157, 1}, // Stone Pick
            new short[]{29, 29, 29,
                0, 15, 0,
            0, 15, 0, 7, 1}, // Copper Pick
            new short[]{30, 30, 30,
                0, 15, 0,
            0, 15, 0, 8, 1}, // Iron Pick
            new short[]{31, 31, 31,
                0, 15, 0,
            0, 15, 0, 9, 1}, // Silver Pick
            new short[]{32, 32, 32,
                0, 15, 0,
            0, 15, 0, 10, 1}, // Gold Pick
            new short[]{60, 60, 60,
                0, 15, 0,
            0, 15, 0, 51, 1}, // Zinc Pick
            new short[]{61, 61, 61,
                0, 15, 0,
            0, 15, 0, 54, 1}, // Rhymestone Pick
            new short[]{62, 62, 62,
                0, 15, 0,
            0, 15, 0, 57, 1}, // Obdurite Pick
            new short[]{73, 73, 73,
                0, 15, 0,
            0, 15, 0, 169, 1}, // Magnetite Pick
            new short[]{69, 69, 69,
                0, 15, 0,
            0, 15, 0, 172, 1}, // Irradium Pick
            new short[]{15, 15, 0,
                15, 15, 0,
            0, 15, 0, 155, 1}, // Wooden Axe
            new short[]{0, 15, 15,
                0, 15, 15,
            0, 15, 0, 155, 1},
            new short[]{15, 15, 0,
                15, 15, 0,
            15, 0, 0, 155, 1},
            new short[]{0, 15, 15,
                0, 15, 15,
            0, 0, 15, 155, 1},
            new short[]{2, 2, 0,
                2, 15, 0,
            0, 15, 0, 158, 1}, // Stone Axe
            new short[]{0, 2, 2,
                0, 15, 2,
            0, 15, 0, 158, 1},
            new short[]{2, 2, 0,
                15, 2, 0,
            15, 0, 0, 158, 1},
            new short[]{0, 2, 2,
                0, 2, 15,
            0, 0, 15, 158, 1},
            new short[]{29, 29, 0,
                29, 15, 0,
            0, 15, 0, 11, 1}, // Copper Axe
            new short[]{0, 29, 29,
                0, 15, 29,
            0, 15, 0, 11, 1},
            new short[]{29, 29, 0,
                15, 29, 0,
            15, 0, 0, 11, 1},
            new short[]{0, 29, 29,
                0, 29, 15,
            0, 0, 15, 11, 1},
            new short[]{30, 30, 0,
                30, 15, 0,
            0, 15, 0, 11, 1}, // Iron Axe
            new short[]{0, 30, 30,
                0, 15, 30,
            0, 15, 0, 11, 1},
            new short[]{30, 30, 0,
                15, 30, 0,
            15, 0, 0, 11, 1},
            new short[]{0, 30, 30,
                0, 30, 15,
            0, 0, 15, 11, 1},
            new short[]{31, 31, 0,
                31, 15, 0,
            0, 15, 0, 11, 1}, // Silver Axe
            new short[]{0, 31, 31,
                0, 15, 31,
            0, 15, 0, 11, 1},
            new short[]{31, 31, 0,
                15, 31, 0,
            15, 0, 0, 11, 1},
            new short[]{0, 31, 31,
                0, 31, 15,
            0, 0, 15, 11, 1},
            new short[]{32, 32, 0,
                32, 15, 0,
            0, 15, 0, 11, 1}, // Gold Axe
            new short[]{0, 32, 32,
                0, 15, 32,
            0, 15, 0, 11, 1},
            new short[]{32, 32, 0,
                15, 32, 0,
            15, 0, 0, 11, 1},
            new short[]{0, 32, 32,
                0, 32, 15,
            0, 0, 15, 11, 1},
            new short[]{60, 60, 0,
                60, 15, 0,
            0, 15, 0, 52, 1}, // Zinc Axe
            new short[]{0, 60, 60,
                0, 15, 60,
            0, 15, 0, 52, 1},
            new short[]{60, 60, 0,
                15, 60, 0,
            15, 0, 0, 52, 1},
            new short[]{0, 60, 60,
                0, 60, 15,
            0, 0, 15, 52, 1},
            new short[]{61, 61, 0,
                61, 15, 0,
            0, 15, 0, 55, 1}, // Rhymestone Axe
            new short[]{0, 61, 61,
                0, 15, 61,
            0, 15, 0, 55, 1},
            new short[]{61, 61, 0,
                15, 61, 0,
            15, 0, 0, 55, 1},
            new short[]{0, 61, 61,
                0, 61, 15,
            0, 0, 15, 55, 1},
            new short[]{62, 62, 0,
                62, 15, 0,
            0, 15, 0, 58, 1}, // Obdurite Axe
            new short[]{0, 62, 62,
                0, 15, 62,
            0, 15, 0, 58, 1},
            new short[]{62, 62, 0,
                15, 62, 0,
            15, 0, 0, 58, 1},
            new short[]{0, 62, 62,
                0, 62, 15,
            0, 0, 15, 58, 1},
            new short[]{73, 73, 0,
                73, 15, 0,
            0, 15, 0, 170, 1}, // Magnetite Axe
            new short[]{0, 73, 73,
                0, 15, 73,
            0, 15, 0, 170, 1},
            new short[]{73, 73, 0,
                15, 73, 0,
            15, 0, 0, 170, 1},
            new short[]{0, 73, 73,
                0, 73, 15,
            0, 0, 15, 170, 1},
            new short[]{69, 69, 0,
                69, 15, 0,
            0, 15, 0, 169, 1}, // Irradium Axe
            new short[]{0, 69, 69,
                0, 15, 69,
            0, 15, 0, 169, 1},
            new short[]{69, 69, 0,
                15, 69, 0,
            15, 0, 0, 169, 1},
            new short[]{0, 69, 69,
                0, 69, 15,
            0, 0, 15, 169, 1},
            new short[]{15, 0, 0,
                15, 0, 0,
            15, 0, 0, 156, 1}, // Wooden Sword
            new short[]{0, 15, 0,
                0, 15, 0,
            0, 15, 0, 156, 1},
            new short[]{0, 0, 15,
                0, 0, 15,
            0, 0, 15, 156, 1},
            new short[]{2, 0, 0,
                2, 0, 0,
            15, 0, 0, 159, 1}, // Stone Sword
            new short[]{0, 2, 0,
                0, 2, 0,
            0, 15, 0, 159, 1},
            new short[]{0, 0, 2,
                0, 0, 2,
            0, 0, 15, 159, 1},
            new short[]{29, 0, 0,
                29, 0, 0,
            15, 0, 0, 16, 1}, // Copper Sword
            new short[]{0, 29, 0,
                0, 29, 0,
            0, 15, 0, 16, 1},
            new short[]{0, 0, 29,
                0, 0, 29,
            0, 0, 15, 16, 1},
            new short[]{30, 0, 0,
                30, 0, 0,
            15, 0, 0, 17, 1}, // Iron Sword
            new short[]{0, 30, 0,
                0, 30, 0,
            0, 15, 0, 17, 1},
            new short[]{0, 0, 30,
                0, 0, 30,
            0, 0, 15, 17, 1},
            new short[]{31, 0, 0,
                31, 0, 0,
            15, 0, 0, 18, 1}, // Silver Sword
            new short[]{0, 31, 0,
                0, 31, 0,
            0, 15, 0, 18, 1},
            new short[]{0, 0, 31,
                0, 0, 31,
            0, 0, 15, 18, 1},
            new short[]{32, 0, 0,
                32, 0, 0,
            15, 0, 0, 19, 1}, // Gold Sword
            new short[]{0, 32, 0,
                0, 32, 0,
            0, 15, 0, 19, 1},
            new short[]{0, 0, 32,
                0, 0, 32,
            0, 0, 15, 19, 1},
            new short[]{38, 0, 0,
                38, 0, 0,
            15, 0, 0, 19, 1}, // Zinc Sword
            new short[]{0, 38, 0,
                0, 38, 0,
            0, 15, 0, 19, 1},
            new short[]{0, 0, 38,
                0, 0, 38,
            0, 0, 15, 19, 1},
            new short[]{39, 0, 0,
                39, 0, 0,
            15, 0, 0, 19, 1}, // Rhymestone Sword
            new short[]{0, 39, 0,
                0, 39, 0,
            0, 15, 0, 19, 1},
            new short[]{0, 0, 39,
                0, 0, 39,
            0, 0, 15, 19, 1},
            new short[]{40, 0, 0,
                40, 0, 0,
            15, 0, 0, 19, 1}, // Obdurite Sword
            new short[]{0, 40, 0,
                0, 40, 0,
            0, 15, 0, 19, 1},
            new short[]{0, 0, 40,
                0, 0, 40,
            0, 0, 15, 19, 1},
            new short[]{73, 0, 0,
                73, 0, 0,
            15, 0, 0, 171, 1}, // Magnetite Sword
            new short[]{0, 73, 0,
                0, 73, 0,
            0, 15, 0, 171, 1},
            new short[]{0, 0, 73,
                0, 0, 73,
            0, 0, 15, 171, 1},
            new short[]{69, 0, 0,
                69, 0, 0,
            15, 0, 0, 174, 1}, // Irradium Sword
            new short[]{0, 69, 0,
                0, 69, 0,
            0, 15, 0, 174, 1},
            new short[]{0, 0, 69,
                0, 0, 69,
            0, 0, 15, 174, 1},
            new short[]{63, 0, 63,
                0, 63, 0,
            0, 63, 0, 190, 1}, // Wrench
            new short[]{15, 0, 0,
                2, 0, 0,
            175, 0, 0, 178, 1}, // Lever
            new short[]{0, 15, 0,
                0, 2, 0,
            0, 175, 0, 178, 1},
            new short[]{0, 0, 15,
                0, 0, 2,
            0, 0, 175, 178, 1},
            new short[]{29, 29, 29,
                29, 0, 29,
            0, 0, 0, 105, 1}, // Copper Helmet
            new short[]{0, 0, 0,
                29, 29, 29,
            29, 0, 29, 105, 1},
            new short[]{29, 0, 29,
                29, 29, 29,
            29, 29, 29, 106, 1}, // Copper Chestplate
            new short[]{29, 29, 29,
                29, 0, 29,
            29, 0, 29, 107, 1}, // Copper Leggings
            new short[]{29, 0, 29,
                29, 0, 29,
            0, 0, 0, 108, 1}, // Copper Greaves
            new short[]{0, 0, 0,
                29, 0, 29,
            29, 0, 29, 108, 1},
            new short[]{30, 30, 30,
                30, 0, 30,
            0, 0, 0, 109, 1}, // Iron Helmet
            new short[]{0, 0, 0,
                30, 30, 30,
            30, 0, 30, 109, 1},
            new short[]{30, 0, 30,
                30, 30, 30,
            30, 30, 30, 110, 1}, // Iron Chestplate
            new short[]{30, 30, 30,
                30, 0, 30,
            30, 0, 30, 111, 1}, // Iron Leggings
            new short[]{30, 0, 30,
                30, 0, 30,
            0, 0, 0, 112, 1}, // Iron Greaves
            new short[]{0, 0, 0,
                30, 0, 30,
            30, 0, 30, 112, 1},
            new short[]{31, 31, 31,
                31, 0, 31,
            0, 0, 0, 113, 1}, // Silver Helmet
            new short[]{0, 0, 0,
                31, 31, 31,
            31, 0, 31, 113, 1},
            new short[]{31, 0, 31,
                31, 31, 31,
            31, 31, 31, 114, 1}, // Silver Chestplate
            new short[]{31, 31, 31,
                31, 0, 31,
            31, 0, 31, 115, 1}, // Silver Leggings
            new short[]{31, 0, 31,
                31, 0, 31,
            0, 0, 0, 116, 1}, // Silver Greaves
            new short[]{0, 0, 0,
                31, 0, 31,
            31, 0, 31, 116, 1},
            new short[]{32, 32, 32,
                32, 0, 32,
            0, 0, 0, 117, 1}, // Gold Helmet
            new short[]{0, 0, 0,
                32, 32, 32,
            32, 0, 32, 117, 1},
            new short[]{32, 0, 32,
                32, 32, 32,
            32, 32, 32, 118, 1}, // Gold Chestplate
            new short[]{32, 32, 32,
                32, 0, 32,
            32, 0, 32, 119, 1}, // Gold Leggings
            new short[]{32, 0, 32,
                32, 0, 32,
            0, 0, 0, 120, 1}, // Gold Greaves
            new short[]{0, 0, 0,
                32, 0, 32,
            32, 0, 32, 120, 1},
            new short[]{60, 60, 60,
                60, 0, 60,
            0, 0, 0, 121, 1}, // Zinc Helmet
            new short[]{0, 0, 0,
                60, 60, 60,
            60, 0, 60, 121, 1},
            new short[]{60, 0, 60,
                60, 60, 60,
            60, 60, 60, 122, 1}, // Zinc Chestplate
            new short[]{60, 60, 60,
                60, 0, 60,
            60, 0, 60, 123, 1}, // Zinc Leggings
            new short[]{60, 0, 60,
                60, 0, 60,
            0, 0, 0, 124, 1}, // Zinc Greaves
            new short[]{0, 0, 0,
                60, 0, 60,
            60, 0, 60, 124, 1},
            new short[]{61, 61, 61,
                61, 0, 61,
            0, 0, 0, 125, 1}, // Rhymestone Helmet
            new short[]{0, 0, 0,
                61, 61, 61,
            61, 0, 61, 125, 1},
            new short[]{61, 0, 61,
                61, 61, 61,
            61, 61, 61, 126, 1}, // Rhymestone Chestplate
            new short[]{61, 61, 61,
                61, 0, 61,
            61, 0, 61, 127, 1}, // Rhymestone Leggings
            new short[]{61, 0, 61,
                61, 0, 61,
            0, 0, 0, 128, 1}, // Rhymestone Greaves
            new short[]{0, 0, 0,
                61, 0, 61,
            61, 0, 61, 128, 1},
            new short[]{62, 62, 62,
                62, 0, 62,
            0, 0, 0, 129, 1}, // Obdurite Helmet
            new short[]{0, 0, 0,
                62, 62, 62,
            62, 0, 62, 129, 1},
            new short[]{62, 0, 62,
                62, 62, 62,
            62, 62, 62, 130, 1}, // Obdurite Chestplate
            new short[]{62, 62, 62,
                62, 0, 62,
            62, 0, 62, 131, 1}, // Obdurite Leggings
            new short[]{62, 0, 62,
                62, 0, 62,
            0, 0, 0, 132, 1}, // Obdurite Greaves
            new short[]{0, 0, 0,
                62, 0, 62,
            62, 0, 62, 132, 1},
            new short[]{63, 63, 63,
                63, 0, 63,
            0, 0, 0, 133, 1}, // Aluminum Helmet
            new short[]{0, 0, 0,
                63, 63, 63,
            63, 0, 63, 133, 1},
            new short[]{63, 0, 63,
                63, 63, 63,
            63, 63, 63, 134, 1}, // Aluminum Chestplate
            new short[]{63, 63, 63,
                63, 0, 63,
            63, 0, 63, 135, 1}, // Aluminum Leggings
            new short[]{63, 0, 63,
                63, 0, 63,
            0, 0, 0, 136, 1}, // Aluminum Greaves
            new short[]{0, 0, 0,
                63, 0, 63,
            63, 0, 63, 136, 1},
            new short[]{64, 64, 64,
                64, 0, 64,
            0, 0, 0, 137, 1}, // Lead Helmet
            new short[]{0, 0, 0,
                64, 64, 64,
            64, 0, 64, 137, 1},
            new short[]{64, 0, 64,
                64, 64, 64,
            64, 64, 64, 138, 1}, // Lead Chestplate
            new short[]{64, 64, 64,
                64, 0, 64,
            64, 0, 64, 139, 1}, // Lead Leggings
            new short[]{64, 0, 64,
                64, 0, 64,
            0, 0, 0, 140, 1}, // Lead Greaves
            new short[]{0, 0, 0,
                64, 0, 64,
            64, 0, 64, 140, 1},
            new short[]{15, 15, 15,
                15, 0, 15,
            15, 15, 15, 21, 1}, // Wooden Chest
            new short[]{2, 2, 2,
                2, 21, 2,
            2, 2, 2, 22, 1}, // Stone Chest
            new short[]{29, 29, 29,
                29, 22, 29,
            29, 29, 29, 23, 1}, // Copper Chest
            new short[]{30, 30, 30,
                30, 22, 30,
            30, 30, 30, 24, 1}, // Iron Chest
            new short[]{31, 31, 31,
                31, 22, 31,
            31, 31, 31, 25, 1}, // Silver Chest
            new short[]{32, 32, 32,
                32, 22, 32,
            32, 32, 32, 26, 1}, // Gold Chest
            new short[]{60, 60, 60,
                60, 22, 60,
            60, 60, 60, 151, 1}, // Zinc Chest
            new short[]{61, 61, 61,
                61, 22, 61,
            61, 61, 61, 152, 1}, // Rhymestone Chest
            new short[]{62, 62, 62,
                62, 22, 62,
            62, 62, 62, 153, 1}, // Obdurite Chest
            new short[]{76, 76, 76,
                76, 34, 76,
            76, 175, 76, 177, 1}, // Zythium Lamp
            new short[]{76, 76, 76,
                175, 44, 175,
            76, 76, 76, 180, 1}, // Zythium Amplifier
            new short[]{76, 76, 76,
                44, 175, 44,
            76, 76, 76, 181, 1}, // Zythium Inverter
            new short[]{76, 175, 76,
                175, 175, 175,
            76, 175, 76, 186, 1}, // Zythium Delayer
            new short[]{15, 15, 0,
                15, 15, 0,
            0, 0, 0, 20, 1}, // Workbench
            new short[]{0, 15, 15,
                0, 15, 15,
            0, 0, 0, 20, 1},
            new short[]{0, 0, 0,
                15, 15, 0,
            15, 15, 0, 20, 1},
            new short[]{0, 0, 0,
                0, 15, 15,
            0, 15, 15, 20, 1},
            new short[]{160, 160, 0,
                160, 160, 0,
            0, 0, 0, 15, 1}, // Bark -> Wood
            new short[]{0, 160, 160,
                0, 160, 160,
            0, 0, 0, 15, 1},
            new short[]{0, 0, 0,
                160, 160, 0,
            160, 160, 0, 15, 1},
            new short[]{0, 0, 0,
                0, 160, 160,
            0, 160, 160, 15, 1},
            new short[]{2, 2, 0,
                2, 2, 0,
            0, 0, 0, 161, 4}, // Cobblestone
            new short[]{0, 2, 2,
                0, 2, 2,
            0, 0, 0, 161, 4},
            new short[]{0, 0, 0,
                2, 2, 0,
            2, 2, 0, 161, 4},
            new short[]{0, 0, 0,
                0, 2, 2,
            0, 2, 2, 161, 4},
            new short[]{162, 162, 0,
                162, 162, 0,
            0, 0, 0, 163, 4}, // Chiseled Cobblestone
            new short[]{0, 162, 162,
                0, 162, 162,
            0, 0, 0, 163, 4},
            new short[]{0, 0, 0,
                162, 162, 0,
            162, 162, 0, 163, 4},
            new short[]{0, 0, 0,
                0, 162, 162,
            0, 162, 162, 163, 4},
            new short[]{163, 163, 0,
                163, 163, 0,
            0, 0, 0, 164, 4}, // Stone Bricks
            new short[]{0, 163, 163,
                0, 163, 163,
            0, 0, 0, 164, 4},
            new short[]{0, 0, 0,
                163, 163, 0,
            163, 163, 0, 164, 4},
            new short[]{0, 0, 0,
                0, 163, 163,
            0, 163, 163, 164, 4},
            new short[]{2, 2, 2,
                2, 0, 2,
            2, 2, 2, 27, 1}, // Furnace
            new short[]{67, 67, 67,
                0, 0, 0,
            0, 0, 0, 175, 10}, // Zythium Wire
            new short[]{0, 0, 0,
                67, 67, 67,
            0, 0, 0, 175, 20},
            new short[]{0, 0, 0,
                0, 0, 0,
            67, 67, 67, 175, 20},
            new short[]{2, 0, 0,
                0, 2, 0,
            0, 0, 0, 33, 1}, // Stone Lighter
            new short[]{0, 2, 0,
                0, 0, 2,
            0, 0, 0, 33, 1},
            new short[]{0, 0, 0,
                2, 0, 0,
            0, 2, 0, 33, 1},
            new short[]{0, 0, 0,
                0, 2, 0,
            0, 0, 2, 33, 1},
            new short[]{0, 2, 0,
                2, 0, 0,
            0, 0, 0, 33, 1},
            new short[]{0, 0, 2,
                0, 2, 0,
            0, 0, 0, 33, 1},
            new short[]{0, 0, 0,
                0, 2, 0,
            2, 0, 0, 33, 1},
            new short[]{0, 0, 0,
                0, 0, 2,
            0, 2, 0, 33, 1},
            new short[]{15, 0, 0,
                15, 0, 0,
            0, 0, 0, 35, 4},  // Wooden Torch
            new short[]{0, 15, 0,
                0, 15, 0,
            0, 0, 0, 35, 4},
            new short[]{0, 0, 15,
                0, 0, 15,
            0, 0, 0, 35, 4},
            new short[]{0, 0, 0,
                15, 0, 0,
            15, 0, 0, 35, 4},
            new short[]{0, 0, 0,
                0, 15, 0,
            0, 15, 0, 35, 4},
            new short[]{0, 0, 0,
                0, 0, 15,
            0, 0, 15, 35, 4},
            new short[]{28, 0, 0,
                15, 0, 0,
            0, 0, 0, 36, 4}, // Coal Torch
            new short[]{0, 28, 0,
                0, 15, 0,
            0, 0, 0, 36, 4},
            new short[]{0, 0, 28,
                0, 0, 15,
            0, 0, 0, 36, 4},
            new short[]{0, 0, 0,
                28, 0, 0,
            15, 0, 0, 36, 4},
            new short[]{0, 0, 0,
                0, 28, 0,
            0, 15, 0, 36, 4},
            new short[]{0, 0, 0,
                0, 0, 28,
            0, 0, 15, 36, 4},
            new short[]{34, 0, 0,
                15, 0, 0,
            0, 0, 0, 37, 4}, // Lumenstone Torch
            new short[]{0, 34, 0,
                0, 15, 0,
            0, 0, 0, 37, 4},
            new short[]{0, 0, 34,
                0, 0, 15,
            0, 0, 0, 37, 4},
            new short[]{0, 0, 0,
                34, 0, 0,
            15, 0, 0, 37, 4},
            new short[]{0, 0, 0,
                0, 34, 0,
            0, 15, 0, 37, 4},
            new short[]{0, 0, 0,
                0, 0, 34,
            0, 0, 15, 37, 4},
            new short[]{44, 0, 0,
                15, 0, 0,
            0, 0, 0, 176, 4}, // Zythium Torch
            new short[]{0, 44, 0,
                0, 15, 0,
            0, 0, 0, 176, 4},
            new short[]{0, 0, 44,
                0, 0, 15,
            0, 0, 0, 176, 4},
            new short[]{0, 0, 0,
                44, 0, 0,
            15, 0, 0, 176, 4},
            new short[]{0, 0, 0,
                0, 44, 0,
            0, 15, 0, 176, 4},
            new short[]{0, 0, 0,
                0, 0, 44,
            0, 0, 15, 176, 4},
            new short[]{15, 15, 0,
                0, 0, 0,
            0, 0, 0, 183, 1}, // Wooden Pressure Plate
            new short[]{0, 15, 15,
                0, 0, 0,
            0, 0, 0, 183, 1},
            new short[]{0, 0, 0,
                15, 15, 0,
            0, 0, 0, 183, 1},
            new short[]{0, 0, 0,
                0, 15, 15,
            0, 0, 0, 183, 1},
            new short[]{0, 0, 0,
                0, 0, 0,
            15, 15, 0, 183, 1},
            new short[]{0, 0, 0,
                0, 0, 0,
            0, 15, 15, 183, 1},
            new short[]{2, 2, 0,
                0, 0, 0,
            0, 0, 0, 184, 1}, // Stone Pressure Plate
            new short[]{0, 2, 2,
                0, 0, 0,
            0, 0, 0, 184, 1},
            new short[]{0, 0, 0,
                2, 2, 0,
            0, 0, 0, 184, 1},
            new short[]{0, 0, 0,
                0, 2, 2,
            0, 0, 0, 184, 1},
            new short[]{0, 0, 0,
                0, 0, 0,
            2, 2, 0, 184, 1},
            new short[]{0, 0, 0,
                0, 0, 0,
            0, 2, 2, 184, 1},
            new short[]{162, 44, 162,
                0, 175, 0,
            0, 0, 0, 185, 1}, // Zythium Pressure Plate
            new short[]{0, 0, 0,
                162, 44, 162,
            0, 175, 0, 185, 1}
        };

            RECIPES.Add("workbench", list_thing1);

            short[][] list_thing2 = new short[][]{
            new short[]{15, 15,
                15, 15, 20, 1}, // Workbench
            new short[]{160, 160,
                160, 160, 15, 1}, // Bark -> Wood
            new short[]{2, 2,
                2, 2, 161, 4}, // Cobblestone
            new short[]{162, 162,
                162, 162, 163, 4}, // Chiseled Cobblestone
            new short[]{163, 163,
                163, 163, 164, 4}, // Stone Bricks
            new short[]{2, 0,
                0, 2, 33, 1}, // Stone Lighter
            new short[]{0, 2,
                2, 0, 33, 1},
            new short[]{15, 0,
                15, 0, 35, 4},  // Wooden Torch
            new short[]{0, 15,
                0, 15, 35, 4},
            new short[]{28, 0,
                15, 0, 36, 4}, // Coal Torch
            new short[]{0, 28,
                0, 15, 36, 4},
            new short[]{34, 0,
                15, 0, 37, 4}, // Lumenstone Torch
            new short[]{0, 34,
                0, 15, 37, 4},
            new short[]{44, 0,
                15, 0, 176, 4}, // Zythium Torch
            new short[]{0, 44,
                0, 15, 176, 4},
            new short[]{15, 15,
                0, 0, 183, 1}, // Wooden Pressure Plate
            new short[]{0, 0,
                15, 15, 183, 1},
            new short[]{2, 2,
                0, 0, 184, 1}, // Stone Pressure Plate
            new short[]{0, 0,
                2, 2, 184, 1}
        };

            RECIPES.Add("cic", list_thing2);

            short[][] list_thing3 = new short[][]{
            new short[]{15, 167, 0, 0, 0, 0, 0, 0, 0,
        168, 1},
            new short[]{162, 0, 0, 0, 0, 0, 0, 0, 0,
        182, 1}
        };

            RECIPES.Add("shapeless", list_thing3);

            short[][] list_thing4 = new short[][]{
            new short[]{15, 167, 0, 0,
        168, 1},
            new short[]{162, 0, 0, 0,
        182, 1}
        };

            RECIPES.Add("shapeless_cic", list_thing4);
        }

        public int addItem(short item, short quantity)
        {
            if (TerrariaClone.getTOOLDURS().ContainsKey(item))
            {
                return addItem(item, quantity, TerrariaClone.getTOOLDURS()[item]);
            }
            else
            {
                return addItem(item, quantity, (short)0);
            }
        }

        public int addItem(short item, short quantity, short durability)
        {
            for (i = 0; i < 40; i++)
            {
                if (ids[i] == item && nums[i] < TerrariaClone.getMAXSTACKS()[ids[i]])
                {
                    if (TerrariaClone.getMAXSTACKS()[ids[i]] - nums[i] >= quantity)
                    {
                        nums[i] += quantity;
                        update(i);
                        return 0;
                    }
                    else
                    {
                        quantity -= (short)(TerrariaClone.getMAXSTACKS()[ids[i]] - nums[i]);
                        nums[i] = TerrariaClone.getMAXSTACKS()[ids[i]];
                        update(i);
                    }
                }
            }
            for (i = 0; i < 40; i++)
            {
                if (ids[i] == 0)
                {
                    ids[i] = item;
                    if (quantity <= TerrariaClone.getMAXSTACKS()[ids[i]])
                    {
                        nums[i] = quantity;
                        durs[i] = durability;
                        update(i);
                        return 0;
                    }
                    else
                    {
                        nums[i] = TerrariaClone.getMAXSTACKS()[ids[i]];
                        durs[i] = durability;
                        quantity -= TerrariaClone.getMAXSTACKS()[ids[i]];
                    }
                }
            }
            return quantity;
        }

        public int removeItem(short item, short quantity)
        {
            for (i = 0; i < 40; i++)
            {
                if (ids[i] == item)
                {
                    if (nums[i] <= quantity)
                    {
                        nums[i] -= quantity;
                        if (nums[i] == 0)
                        {
                            ids[i] = 0;
                        }
                        update(i);
                        return 0;
                    }
                    else
                    {
                        quantity -= nums[i];
                        nums[i] = 0;
                        ids[i] = 0;
                        update(i);
                    }
                }
            }
            return quantity;
        }

        public int addLocation(int i, short item, short quantity, short durability)
        {
            if (ids[i] == item)
            {
                if (TerrariaClone.getMAXSTACKS()[ids[i]] - nums[i] >= quantity)
                {
                    nums[i] += quantity;
                    update(i);
                    return 0;
                }
                else
                {
                    quantity -= (short)(TerrariaClone.getMAXSTACKS()[ids[i]] - nums[i]);
                    nums[i] = TerrariaClone.getMAXSTACKS()[ids[i]];
                    update(i);
                }
            }
            else
            {
                if (quantity <= TerrariaClone.getMAXSTACKS()[ids[i]])
                {
                    ids[i] = item;
                    nums[i] = quantity;
                    durs[i] = durability;
                    update(i);
                    return 0;
                }
                else
                {
                    quantity -= TerrariaClone.getMAXSTACKS()[ids[i]];
                    return quantity;
                }
            }
            return quantity;
        }

        public int removeLocation(int i, short quantity)
        {
            if (nums[i] >= quantity)
            {
                nums[i] -= quantity;
                if (nums[i] == 0)
                {
                    ids[i] = 0;
                }
                update(i);
                return 0;
            }
            else
            {
                quantity -= nums[i];
                nums[i] = 0;
                ids[i] = 0;
                update(i);
            }
            return quantity;
        }

        public void reloadImage()
        {
            image = new Image(466, 190);
            box = loadImage("interface/inventory.png");
            box_selected = loadImage("interface/inventory_selected.png");
            g2 = image.createGraphics();
            for (x = 0; x < 10; x++)
            {
                for (y = 0; y < 4; y++)
                {
                    if (x == 0 && y == 0)
                    {
                        g2.drawImage(box_selected,
                            x * 46 + 6, y * 46 + 6, x * 46 + 46, y * 46 + 46,
                            0, 0, 40, 40,
                            null);
                        if (y == 0)
                        {
                            g2.setFont(font);
                            g2.setColor(Color.Black);
                            g2.drawString(f(x) + " ", x * 46 + trolx, y * 46 + troly);
                        }
                    }
                    else
                    {
                        g2.drawImage(box,
                            x * 46 + 6, y * 46 + 6, x * 46 + 46, y * 46 + 46,
                            0, 0, 40, 40,
                            null);
                        if (y == 0)
                        {
                            g2.setFont(font);
                            g2.setColor(Color.Black);
                            g2.drawString(f(x) + " ", x * 46 + trolx, y * 46 + troly);
                        }
                    }
                }
            }
            for (i = 0; i < 40; i++)
            {
                update(i);
            }
        }

        public void update(int i)
        {
            py = (int)(i / 10);
            px = i - (py * 10);
            for (x = px * 46 + 6; x < px * 46 + 46; x++)
            {
                for (y = py * 46 + 6; y < py * 46 + 46; y++)
                {
                    image.setRGB(x, y, 9539985);
                }
            }
            g2 = image.createGraphics();
            if (i == selection)
            {
                g2.drawImage(box_selected,
                    px * 46 + 6, py * 46 + 6, px * 46 + 46, py * 46 + 46,
                    0, 0, 40, 40,
                    null);
                if (py == 0)
                {
                    g2.setFont(font);
                    g2.setColor(Color.Black);
                    g2.drawString(f(px) + " ", px * 46 + trolx, py * 46 + troly);
                }
            }
            else
            {
                g2.drawImage(box,
                    px * 46 + 6, py * 46 + 6, px * 46 + 46, py * 46 + 46,
                    0, 0, 40, 40,
                    null);
                if (py == 0)
                {
                    g2.setFont(font);
                    g2.setColor(Color.Black);
                    g2.drawString(f(px) + " ", px * 46 + trolx, py * 46 + troly);
                }
            }
            if (ids[i] != 0)
            {
                width = TerrariaClone.getItemImgs()[ids[i]].Width;
                height = TerrariaClone.getItemImgs()[ids[i]].Height;
                g2.drawImage(TerrariaClone.getItemImgs()[ids[i]],
                    px * 46 + 14 + ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), py * 46 + 14 + ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2), px * 46 + 38 - ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), py * 46 + 38 - ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2),
                    0, 0, width, height,
                    null);

                if (nums[i] > 1)
                {
                    g2.setFont(font);
                    g2.setColor(Color.White);
                    g2.drawString(nums[i] + " ", px * 46 + 15, py * 46 + 40);
                }
            }
        }

        public void select(int i)
        {
            if (i == 0)
            {
                n = selection;
                selection = 9;
                update(n);
                update(9);
            }
            else
            {
                n = selection;
                selection = i - 1;
                update(n);
                update(i - 1);
            }
        }

        public void select2(int i)
        {
            n = selection;
            selection = i;
            update(n);
            update(i);
        }

        public short tool()
        {
            return ids[selection];
        }

        public void renderCollection(ItemCollection ic)
        {
            if (ic.type.Equals("cic"))
            {
                if (ic.image == null)
                {
                    ic.image = loadImage("interface/cic.png");
                    for (i = 0; i < 4; i++)
                    {
                        updateIC(ic, i);
                    }
                }
            }
            if (ic.type.Equals("armor"))
            {
                if (ic.image == null)
                {
                    ic.image = loadImage("interface/armor.png");
                    CX = 1;
                    CY = 4;
                    for (i = 0; i < 4; i++)
                    {
                        updateIC(ic, i);
                    }
                }
            }
            if (ic.type.Equals("workbench"))
            {
                if (ic.image == null)
                {
                    ic.image = loadImage("interface/workbench.png");
                    for (i = 0; i < 9; i++)
                    {
                        updateIC(ic, i);
                    }
                }
            }
            if (ic.type.Equals("wooden_chest"))
            {
                if (ic.image == null)
                {
                    ic.image = loadImage("interface/wooden_chest.png");
                    CX = 3;
                    CY = 3;
                    for (i = 0; i < 9; i++)
                    {
                        updateIC(ic, i);
                    }
                }
            }
            if (ic.type.Equals("stone_chest"))
            {
                if (ic.image == null)
                {
                    ic.image = loadImage("interface/stone_chest.png");
                    CX = 5;
                    CY = 3;
                    for (i = 0; i < 15; i++)
                    {
                        updateIC(ic, i);
                    }
                }
            }
            if (ic.type.Equals("copper_chest"))
            {
                if (ic.image == null)
                {
                    ic.image = loadImage("interface/copper_chest.png");
                    CX = 5;
                    CY = 4;
                    for (i = 0; i < 20; i++)
                    {
                        updateIC(ic, i);
                    }
                }
            }
            if (ic.type.Equals("iron_chest"))
            {
                if (ic.image == null)
                {
                    ic.image = loadImage("interface/iron_chest.png");
                    CX = 7;
                    CY = 4;
                    for (i = 0; i < 28; i++)
                    {
                        updateIC(ic, i);
                    }
                }
            }
            if (ic.type.Equals("silver_chest"))
            {
                if (ic.image == null)
                {
                    ic.image = loadImage("interface/silver_chest.png");
                    CX = 7;
                    CY = 5;
                    for (i = 0; i < 35; i++)
                    {
                        updateIC(ic, i);
                    }
                }
            }
            if (ic.type.Equals("gold_chest"))
            {
                if (ic.image == null)
                {
                    ic.image = loadImage("interface/gold_chest.png");
                    CX = 7;
                    CY = 6;
                    for (i = 0; i < 42; i++)
                    {
                        updateIC(ic, i);
                    }
                }
            }
            if (ic.type.Equals("zinc_chest"))
            {
                if (ic.image == null)
                {
                    ic.image = loadImage("interface/zinc_chest.png");
                    CX = 7;
                    CY = 8;
                    for (i = 0; i < 56; i++)
                    {
                        updateIC(ic, i);
                    }
                }
            }
            if (ic.type.Equals("rhymestone_chest"))
            {
                if (ic.image == null)
                {
                    ic.image = loadImage("interface/rhymestone_chest.png");
                    CX = 8;
                    CY = 9;
                    for (i = 0; i < 72; i++)
                    {
                        updateIC(ic, i);
                    }
                }
            }
            if (ic.type.Equals("obdurite_chest"))
            {
                if (ic.image == null)
                {
                    ic.image = loadImage("interface/obdurite_chest.png");
                    CX = 10;
                    CY = 10;
                    for (i = 0; i < 100; i++)
                    {
                        updateIC(ic, i);
                    }
                }
            }
            if (ic.type.Equals("furnace"))
            {
                if (ic.image == null)
                {
                    ic.image = loadImage("interface/furnace.png");
                    for (i = -1; i < 4; i++)
                    {
                        updateIC(ic, i);
                    }
                }
            }
        }

        public int addLocationIC(ItemCollection ic, int i, short item, short quantity)
        {
            return addLocationIC(ic, i, item, quantity, (short)0);
        }

        public int addLocationIC(ItemCollection ic, int i, short item, short quantity, short durability)
        {
            if (ic.ids[i] == item)
            {
                if (TerrariaClone.getMAXSTACKS()[ic.ids[i]] - ic.nums[i] >= quantity)
                {
                    ic.nums[i] += quantity;
                    if (ic.image != null)
                    {
                        updateIC(ic, i);
                    }
                    return 0;
                }
                else
                {
                    quantity -= (short)(TerrariaClone.getMAXSTACKS()[ic.ids[i]] - ic.nums[i]);
                    ic.nums[i] = TerrariaClone.getMAXSTACKS()[ic.ids[i]];
                    if (ic.image != null)
                    {
                        updateIC(ic, i);
                    }
                }
            }
            else
            {
                if (quantity <= TerrariaClone.getMAXSTACKS()[ic.ids[i]])
                {
                    ic.ids[i] = item;
                    ic.nums[i] = quantity;
                    ic.durs[i] = durability;
                    if (ic.image != null)
                    {
                        updateIC(ic, i);
                    }
                    return 0;
                }
                else
                {
                    quantity -= TerrariaClone.getMAXSTACKS()[ic.ids[i]];
                    return quantity;
                }
            }
            return quantity;
        }

        public int removeLocationIC(ItemCollection ic, int i, short quantity)
        {
            if (ic.nums[i] >= quantity)
            {
                ic.nums[i] -= quantity;
                if (ic.nums[i] == 0)
                {
                    ic.ids[i] = 0;
                }
                if (ic.image != null)
                {
                    updateIC(ic, i);
                }
                return 0;
            }
            else
            {
                quantity -= ic.nums[i];
                ic.nums[i] = 0;
                ic.ids[i] = 0;
                if (ic.image != null)
                {
                    updateIC(ic, i);
                }
            }
            return quantity;
        }

        public void updateIC(ItemCollection ic, int i)
        {
            if (ic.type.Equals("cic"))
            {
                py = (int)(i / 2);
                px = i - (py * 2);
                for (x = px * 40; x < px * 40 + 40; x++)
                {
                    for (y = py * 40; y < py * 40 + 40; y++)
                    {
                        ic.image.setRGB(x, y, 9539985);
                    }
                }
                g2 = ic.image.createGraphics();
                g2.drawImage(box,
                    px * 40, py * 40, px * 40 + 40, py * 40 + 40,
                    0, 0, 40, 40,
                    null);
                if (ic.ids[i] != 0)
                {
                    width = TerrariaClone.getItemImgs()[ic.ids[i]].Width;
                    height = TerrariaClone.getItemImgs()[ic.ids[i]].Height;
                    g2.drawImage(TerrariaClone.getItemImgs()[ic.ids[i]],
                        px * 40 + 8 + ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), py * 40 + 8 + ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2), px * 40 + 32 - ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), py * 40 + 32 - ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2),
                        0, 0, width, height,
                        null);
                    if (ic.nums[i] > 1)
                    {
                        g2.setFont(font);
                        g2.setColor(Color.White);
                        g2.drawString(ic.nums[i] + " ", px * 40 + 9, py * 40 + 34);
                    }
                }
                ic.ids[4] = 0;
                ic.ids[4] = 0;
                foreach (short[] r2 in RECIPES["cic"])
                {
                    valid = true;
                    for (i = 0; i < 4; i++)
                    {
                        if (ic.ids[i] != r2[i])
                        {
                            valid = false;
                            break;
                        }
                    }
                    if (valid)
                    {
                        ic.ids[4] = r2[4];
                        ic.nums[4] = r2[5];
                        if (TerrariaClone.getTOOLDURS().ContainsKey(r2[4]))
                            ic.durs[4] = TerrariaClone.getTOOLDURS()[r2[4]];
                        break;
                    }
                }
                List<short> r3 = new List<short>(6);
                foreach (short[] r2 in RECIPES["shapeless_cic"])
                {
                    valid = true;
                    r3.Clear();
                    for (j = 0; j < r2.Length - 2; j++)
                    {
                        r3.Add(r2[j]);
                    }
                    for (j = 0; j < 4; j++)
                    {
                        n = r3.IndexOf(ic.ids[j]);
                        if (n == -1)
                        {
                            valid = false;
                            break;
                        }
                        else
                        {
                            r3.RemoveAt(n);
                        }
                    }
                    if (valid)
                    {
                        ic.ids[4] = r2[r2.Length - 2];
                        ic.nums[4] = r2[r2.Length - 1];
                        if (TerrariaClone.getTOOLDURS().ContainsKey(r2[r2.Length - 2]))
                            ic.durs[4] = TerrariaClone.getTOOLDURS()[r2[r2.Length - 2]];
                        break;
                    }
                }
                for (x = 3 * 40; x < 3 * 40 + 40; x++)
                {
                    for (y = 20; y < 20 + 40; y++)
                    {
                        ic.image.setRGB(x, y, 9539985);
                    }
                }
                g2 = ic.image.createGraphics();
                g2.drawImage(box,
                    3 * 40, 20, 3 * 40 + 40, 20 + 40,
                    0, 0, 40, 40,
                    null);
                if (ic.ids[4] != 0)
                {
                    width = TerrariaClone.getItemImgs()[ic.ids[4]].Width;
                    height = TerrariaClone.getItemImgs()[ic.ids[4]].Height;
                    g2.drawImage(TerrariaClone.getItemImgs()[ic.ids[4]],
                        3 * 40 + 8 + ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), 20 + 8 + ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2), 3 * 40 + 32 - ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), 20 + 32 - ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2),
                        0, 0, width, height,
                        null);

                    if (ic.nums[4] > 1)
                    {
                        g2.setFont(font);
                        g2.setColor(Color.White);
                        g2.drawString(ic.nums[4] + " ", 3 * 40 + 9, 20 + 34);
                    }
                }
            }
            if (ic.type.Equals("armor"))
            {
                py = (int)(i / CX);
                px = i - (py * CX);
                for (x = px * 46; x < px * 46 + 40; x++)
                {
                    for (y = py * 46; y < py * 46 + 40; y++)
                    {
                        ic.image.setRGB(x, y, 9539985);
                    }
                }
                g2 = ic.image.createGraphics();
                g2.drawImage(box,
                    px * 46, py * 46, px * 46 + 40, py * 46 + 40,
                    0, 0, 40, 40,
                    null);
                if (ic.ids[i] != 0)
                {
                    width = TerrariaClone.getItemImgs()[ic.ids[i]].Width;
                    height = TerrariaClone.getItemImgs()[ic.ids[i]].Height;
                    g2.drawImage(TerrariaClone.getItemImgs()[ic.ids[i]],
                        px * 46 + 8 + ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), py * 46 + 8 + ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2), px * 46 + 32 - ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), py * 46 + 32 - ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2),
                        0, 0, width, height,
                        null);

                    if (ic.nums[i] > 1)
                    {
                        g2.setFont(font);
                        g2.setColor(Color.White);
                        g2.drawString(ic.nums[i] + " ", px * 46 + 9, py * 46 + 34);
                    }
                }
            }
            if (ic.type.Equals("workbench"))
            {
                py = (int)(i / 3);
                px = i - (py * 3);
                for (x = px * 40; x < px * 40 + 40; x++)
                {
                    for (y = py * 40; y < py * 40 + 40; y++)
                    {
                        ic.image.setRGB(x, y, 9539985);
                    }
                }
                g2 = ic.image.createGraphics();
                g2.drawImage(box,
                    px * 40, py * 40, px * 40 + 40, py * 40 + 40,
                    0, 0, 40, 40,
                    null);
                if (ic.ids[i] != 0)
                {
                    width = TerrariaClone.getItemImgs()[ic.ids[i]].Width;
                    height = TerrariaClone.getItemImgs()[ic.ids[i]].Height;
                    g2.drawImage(TerrariaClone.getItemImgs()[ic.ids[i]],
                        px * 40 + 8 + ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), py * 40 + 8 + ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2), px * 40 + 32 - ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), py * 40 + 32 - ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2),
                        0, 0, width, height,
                        null);
                    if (ic.nums[i] > 1)
                    {
                        g2.setFont(font);
                        g2.setColor(Color.White);
                        g2.drawString(ic.nums[i] + " ", px * 40 + 9, py * 40 + 34);
                    }
                }
                ic.ids[9] = 0;
                ic.ids[9] = 0;
                foreach (short[] r2 in RECIPES["workbench"])
                {
                    valid = true;
                    for (i = 0; i < 9; i++)
                    {
                        if (ic.ids[i] != r2[i])
                        {
                            valid = false;
                            break;
                        }
                    }
                    if (valid)
                    {
                        ic.ids[9] = r2[9];
                        ic.nums[9] = r2[10];
                        if (TerrariaClone.getTOOLDURS().ContainsKey(r2[9]))
                            ic.durs[9] = TerrariaClone.getTOOLDURS()[r2[9]];
                        break;
                    }
                }
                List<short> r3 = new List<short>(11);
                foreach (short[] r2 in RECIPES["shapeless"])
                {
                    valid = true;
                    r3.Clear();
                    for (j = 0; j < r2.Length - 2; j++)
                    {
                        r3.Add(r2[j]);
                    }
                    for (j = 0; j < 9; j++)
                    {
                        n = r3.IndexOf(ic.ids[j]);
                        if (n == -1)
                        {
                            valid = false;
                            break;
                        }
                        else
                        {
                            r3.RemoveAt(n);
                        }
                    }
                    if (valid)
                    {
                        ic.ids[9] = r2[r2.Length - 2];
                        ic.nums[9] = r2[r2.Length - 1];
                        if (TerrariaClone.getTOOLDURS().ContainsKey(r2[r2.Length - 2]))
                            ic.durs[9] = TerrariaClone.getTOOLDURS()[(short)(r2.Length - 2)];
                        break;
                    }
                }
                for (x = 4 * 40; x < 4 * 40 + 40; x++)
                {
                    for (y = 1 * 40; y < 1 * 40 + 40; y++)
                    {
                        ic.image.setRGB(x, y, 9539985);
                    }
                }
                g2 = ic.image.createGraphics();
                g2.drawImage(box,
                    4 * 40, 1 * 40, 4 * 40 + 40, 1 * 40 + 40,
                    0, 0, 40, 40,
                    null);
                if (ic.ids[9] != 0)
                {
                    width = TerrariaClone.getItemImgs()[ic.ids[9]].Width;
                    height = TerrariaClone.getItemImgs()[ic.ids[9]].Height;
                    g2.drawImage(TerrariaClone.getItemImgs()[ic.ids[9]],
                        4 * 40 + 8 + ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), 1 * 40 + 8 + ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2), 4 * 40 + 32 - ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), 1 * 40 + 32 - ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2),
                        0, 0, width, height,
                        null);

                    if (ic.nums[9] > 1)
                    {
                        g2.setFont(font);
                        g2.setColor(Color.White);
                        g2.drawString(ic.nums[9] + " ", 4 * 40 + 9, 1 * 40 + 34);
                    }
                }
            }
            if (ic.type.Equals("wooden_chest") || ic.type.Equals("stone_chest") ||
                ic.type.Equals("copper_chest") || ic.type.Equals("iron_chest") ||
                ic.type.Equals("silver_chest") || ic.type.Equals("gold_chest") ||
                ic.type.Equals("zinc_chest") || ic.type.Equals("rhymestone_chest") ||
                ic.type.Equals("obdurite_chest"))
            {
                py = (int)(i / CX);
                px = i - (py * CX);
                for (x = px * 46; x < px * 46 + 40; x++)
                {
                    for (y = py * 46; y < py * 46 + 40; y++)
                    {
                        ic.image.setRGB(x, y, 9539985);
                    }
                }
                g2 = ic.image.createGraphics();
                g2.drawImage(box,
                    px * 46, py * 46, px * 46 + 40, py * 46 + 40,
                    0, 0, 40, 40,
                    null);
                if (ic.ids[i] != 0)
                {
                    width = TerrariaClone.getItemImgs()[ic.ids[i]].Width;
                    height = TerrariaClone.getItemImgs()[ic.ids[i]].Height;
                    g2.drawImage(TerrariaClone.getItemImgs()[ic.ids[i]],
                        px * 46 + 8 + ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), py * 46 + 8 + ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2), px * 46 + 32 - ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), py * 46 + 32 - ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2),
                        0, 0, width, height,
                        null);

                    if (ic.nums[i] > 1)
                    {
                        g2.setFont(font);
                        g2.setColor(Color.White);
                        g2.drawString(ic.nums[i] + " ", px * 46 + 9, py * 46 + 34);
                    }
                }
            }
            if (ic.type.Equals("furnace"))
            {
                if (i == -1)
                {
                    for (y = 0; y < 5; y++)
                    {
                        for (x = 0; x < ic.FUELP * 38; x++)
                        {
                            ic.image.setRGB(x + 1, y + 51, new Color(255, 0, 0).PackedValue);
                        }
                        for (x = (int)(ic.FUELP * 38); x < 38; x++)
                        {
                            ic.image.setRGB(x + 1, y + 51, new Color(145, 145, 145).PackedValue);
                        }
                    }
                    for (x = 0; x < 5; x++)
                    {
                        for (y = 0; y < ic.SMELTP * 38; y++)
                        {
                            ic.image.setRGB(x + 40, y + 1, new Color(255, 0, 0).PackedValue);
                        }
                        for (y = (int)(ic.SMELTP * 38); y < 38; y++)
                        {
                            ic.image.setRGB(x + 40, y + 1, new Color(145, 145, 145).PackedValue);
                        }
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        fpx = 0;
                        fpy = 0;
                    }
                    if (i == 1)
                    {
                        fpx = 0;
                        fpy = 1.4;
                    }
                    if (i == 2)
                    {
                        fpx = 0;
                        fpy = 2.4;
                    }
                    if (i == 3)
                    {
                        fpx = 1.4;
                        fpy = 0;
                    }
                    for (x = (int)(fpx * 40); x < fpx * 40 + 40; x++)
                    {
                        for (y = (int)(fpy * 40); y < fpy * 40 + 40; y++)
                        {
                            ic.image.setRGB(x, y, 9539985);
                        }
                    }
                    g2 = ic.image.createGraphics();
                    g2.drawImage(box,
                        (int)(fpx * 40), (int)(fpy * 40), (int)(fpx * 40 + 40), (int)(fpy * 40 + 40),
                        0, 0, 40, 40,
                        null);
                    if (ic.ids[i] != 0)
                    {
                        width = TerrariaClone.getItemImgs()[ic.ids[i]].Width;
                        height = TerrariaClone.getItemImgs()[ic.ids[i]].Height;
                        g2.drawImage(TerrariaClone.getItemImgs()[ic.ids[i]],
                            (int)(fpx * 40 + 8 + ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2)), (int)(fpy * 40 + 8 + ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2)), (int)(fpx * 40 + 32 - ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2)), (int)(fpy * 40 + 32 - ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2)),
                            0, 0, width, height,
                            null);

                        if (ic.nums[i] > 1)
                        {
                            g2.setFont(font);
                            g2.setColor(Color.White);
                            g2.drawString(ic.nums[i] + " ", (int)(fpx * 40 + 9), (int)(fpy * 40 + 34));
                        }
                    }
                }
            }
        }

        public void useRecipeWorkbench(ItemCollection ic)
        {
            foreach (short[] r2 in RECIPES["workbench"])
            {
                valid = true;
                for (i = 0; i < 9; i++)
                {
                    if (ic.ids[i] != r2[i])
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid)
                {
                    for (i = 0; i < 9; i++)
                    {
                        removeLocationIC(ic, i, (short)1);
                        updateIC(ic, i);
                    }
                }
            }
            List<short> r3 = new List<short>(11);
            foreach (short[] r2 in RECIPES["shapeless"])
            {
                valid = true;
                r3.Clear();
                for (k = 0; k < r2.Length - 2; k++)
                {
                    r3.Add(r2[k]);
                }
                for (k = 0; k < 9; k++)
                {
                    n = r3.IndexOf(ic.ids[k]);
                    if (n == -1)
                    {
                        valid = false;
                        break;
                    }
                    else
                    {
                        r3.RemoveAt(n);
                    }
                }
                if (valid)
                {
                    r3.Clear();
                    for (k = 0; k < r2.Length - 2; k++)
                    {
                        r3.Add(r2[k]);
                    }
                    for (k = 0; k < 9; k++)
                    {
                        n = r3.IndexOf(ic.ids[k]);
                        r3.RemoveAt(n);
                        removeLocationIC(ic, k, (short)1);
                        updateIC(ic, k);
                    }
                    break;
                }
            }
        }

        public void useRecipeCIC(ItemCollection ic)
        {
            foreach (short[] r2 in RECIPES["cic"])
            {
                valid = true;
                for (i = 0; i < 4; i++)
                {
                    if (ic.ids[i] != r2[i])
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid)
                {
                    for (i = 0; i < 4; i++)
                    {
                        removeLocationIC(ic, i, (short)1);
                        updateIC(ic, i);
                    }
                }
            }
            List<short> r3 = new List<short>(6);
            foreach (short[] r2 in RECIPES["shapeless_cic"])
            {
                valid = true;
                r3.Clear();
                for (k = 0; k < r2.Length - 2; k++)
                {
                    r3.Add(r2[k]);
                }
                for (k = 0; k < 4; k++)
                {
                    n = r3.IndexOf(ic.ids[k]);
                    if (n == -1)
                    {
                        valid = false;
                        break;
                    }
                    else
                    {
                        r3.RemoveAt(n);
                    }
                }
                if (valid)
                {
                    r3.Clear();
                    for (k = 0; k < r2.Length - 2; k++)
                    {
                        r3.Add(r2[k]);
                    }
                    for (k = 0; k < 4; k++)
                    {
                        n = r3.IndexOf(ic.ids[k]);
                        r3.RemoveAt(n);
                        removeLocationIC(ic, k, (short)1);
                        updateIC(ic, k);
                    }
                    break;
                }
            }
        }

        private static Image loadImage(String path)
        {
            Uri url = Util.getResource(path);
            Image image = null;
            try
            {
                image = ImageIO.read(url);
            }
            catch (Exception e)
            {
                Console.WriteLine("[ERROR] could not load image '" + path + "'.");
            }
            return image;
        }

        private static int f(int x)
        {
            if (x == 9)
            {
                return 0;
            }
            return x + 1;
        }

        public static int max(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
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