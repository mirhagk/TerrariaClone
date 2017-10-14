using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TerrariaClone
{
    /*

    0    Air
    1    Dirt
    2    Stone
    3    Copper Ore
    4    Iron Ore
    5    Silver Ore
    6    Gold Ore
    7    Wood
    8    Workbench
    9    Wooden Chest
    10    Stone Chest
    11    Copper Chest
    12    Iron Chest
    13    Silver Chest
    14    Gold Chest
    15    Tree
    16    Leaves
    17    Furnace
    18    Coal
    19    Lumenstone
    20    Wooden Torch
    21    Coal Torch
    22    Lumenstone Torch
    23    Furnace (on)
    24    Wooden Torch (left wall)
    25    Wooden Torch (right wall)
    26    Coal Torch (left wall)
    27    Coal Torch (right wall)
    28    Lumenstone Torch (left wall)
    29    Lumenstone Torch (right wall)
    30    Tree (root)
    31    Zinc Ore
    32    Rhymestone Ore
    33    Obdurite Ore
    34    Aluminum Ore
    35    Lead Ore
    36    Uranium Ore
    37    Zythium Ore
    38    Zythium Ore (on)
    39    Silicon Ore
    40    Irradium Ore
    41    Nullstone
    42    Meltstone
    43    Skystone
    44    Magnetite Ore
    45    Sand
    46    Snow
    47    Glass
    48    Sunflower (stage 1)
    49    Sunflower (stage 2)
    50    Sunflower (stage 3)
    51    Moonflower (stage 1)
    52    Moonflower (stage 2)
    53    Moonflower (stage 3)
    54    Dryweed (stage 1)
    55    Dryweed (stage 2)
    56    Dryweed (stage 3)
    57    Greenleaf (stage 1)
    58    Greenleaf (stage 2)
    59    Greenleaf (stage 3)
    60    Frostleaf (stage 1)
    61    Frostleaf (stage 2)
    62    Frostleaf (stage 3)
    63    Caveroot (stage 1)
    64    Caveroot (stage 2)
    65    Caveroot (stage 3)
    66    Skyblossom (stage 1)
    67    Skyblossom (stage 2)
    68    Skyblossom (stage 3)
    69    Void Rot (stage 1)
    70    Void Rot (stage 2)
    71    Void Rot (stage 3)
    72    Grass
    73    Jungle Grass
    74    Swamp Grass
    75    Mud
    76    Sandstone
    77    Marshleaf (stage 1)
    78    Marshleaf (stage 2)
    79    Marshleaf (stage 3)
    80    Zinc Chest
    81    Rhymestone Chest
    82    Obdurite Chest
    83    Tree (no bark)
    84    Cobblestone
    85    Chiseled Stone
    86    Chiseled Cobblestone
    87    Stone Bricks
    88    Clay
    89    Clay Bricks
    90    Varnished Wood
    91    Dirt (transparent)
    92    Magnetite Ore (transparent)
    93    Grass (transparent)
    94    Zythium Wire
    95    Zythium Wire (1 power)
    96    Zythium Wire (2 power)
    97    Zythium Wire (3 power)
    98    Zythium Wire (4 power)
    99    Zythium Wire (5 power)
    100    Zythium Torch
    101    Zythium Torch (left wall)
    102    Zythium Torch (right wall)
    103    Zythium Lamp
    104    Zythium Lamp (on)
    105    Lever
    106    Lever (on)
    107    Lever (left wall)
    108    Lever (left wall, on)
    109    Lever (right wall)
    110    Lever (right wall, on)
    111    Zythium Amplifier (right)
    112    Zythium Amplifier (down)
    113    Zythium Amplifier (left)
    114    Zythium Amplifier (up)
    115    Zythium Amplifier (right, on)
    116    Zythium Amplifier (down, on)
    117    Zythium Amplifier (left, on)
    118    Zythium Amplifier (up, on)
    119    Zythium Inverter (right)
    120    Zythium Inverter (down)
    121    Zythium Inverter (left)
    122    Zythium Inverter (up)
    123    Zythium Inverter (right, on)
    124    Zythium Inverter (down, on)
    125    Zythium Inverter (left, on)
    126    Zythium Inverter (up, on)
    127    Button (left)
    128    Button (left, on)
    129    Button (right)
    130    Button (right, on)
    131    Wooden Pressure Plate
    132    Wooden Pressure Plate (on)
    133    Stone Pressure Plate
    134    Stone Pressure Plate (on)
    135    Zythium Pressure Plate
    136    Zythium Pressure Plate (on)
    137    Zythium Delayer (1 delay, right)
    138    Zythium Delayer (1 delay, down)
    139    Zythium Delayer (1 delay, left)
    140    Zythium Delayer (1 delay, up)
    141    Zythium Delayer (1 delay, right, on)
    142    Zythium Delayer (1 delay, down, on)
    143    Zythium Delayer (1 delay, left, on)
    144    Zythium Delayer (1 delay, up, on)
    145    Zythium Delayer (2 delay, right)
    146    Zythium Delayer (2 delay, down)
    147    Zythium Delayer (2 delay, left)
    148    Zythium Delayer (2 delay, up)
    149    Zythium Delayer (2 delay, right, on)
    150    Zythium Delayer (2 delay, down, on)
    151    Zythium Delayer (2 delay, left, on)
    152    Zythium Delayer (2 delay, up, on)
    153    Zythium Delayer (4 delay, right)
    154    Zythium Delayer (4 delay, down)
    155    Zythium Delayer (4 delay, left)
    156    Zythium Delayer (4 delay, up)
    157    Zythium Delayer (4 delay, right, on)
    158    Zythium Delayer (4 delay, down, on)
    159    Zythium Delayer (4 delay, left, on)
    160    Zythium Delayer (4 delay, up, on)
    161    Zythium Delayer (8 delay, right)
    162    Zythium Delayer (8 delay, down)
    163    Zythium Delayer (8 delay, left)
    164    Zythium Delayer (8 delay, up)
    165    Zythium Delayer (8 delay, right, on)
    166    Zythium Delayer (8 delay, down, on)
    167    Zythium Delayer (8 delay, left, on)
    168    Zythium Delayer (8 delay, up, on)

    0    center
    1    tdown_both
    2    tdown_cw
    3    tdown_ccw
    4    tdown
    5    tup_both
    6    tup_cw
    7    tup_ccw
    8    tup
    9    leftright
    10    tright_both
    11    tright_cw
    12    tright_ccw
    13    tright
    14    upleftdiag
    15    upleft
    16    downleftdiag
    17    downleft
    18    left
    19    tleft_both
    20    tleft_cw
    21    tleft_ccw
    22    tleft
    23    uprightdiag
    24    upright
    25    downrightdiag
    26    downright
    27    right
    28    updown
    29    up
    30    down
    31    single

    0    None
    1    Dirt/None downleft
    2    Dirt/None downright
    3    Dirt/None left
    4    Dirt/None right
    5    Dirt/None up
    6    Dirt/None upleft
    7    Dirt/None upright
    8    Dirt
    9    Stone/Dirt downleft
    10    Stone/Dirt downright
    11    Stone/Dirt left
    12    Stone/Dirt right
    13    Stone/Dirt up
    14    Stone/Dirt upleft
    15    Stone/Dirt upright
    16    Stone
    17    Stone/None down

    0    Empty
    1    Dirt
    2    Stone
    3    Copper Ore
    4    Iron Ore
    5    Silver Ore
    6    Gold Ore
    7    Copper Pick
    8    Iron Pick
    9    Silver Pick
    10    Gold Pick
    11    Copper Axe
    12    Iron Axe
    13    Silver Axe
    14    Gold Axe
    15    Wood
    16    Copper Sword
    17    Iron Sword
    18    Silver Sword
    19    Gold Sword
    20    Workbench
    21    Wooden Chest
    22    Stone Chest
    23    Copper Chest
    24    Iron Chest
    25    Silver Chest
    26    Gold Chest
    27    Furnace
    28    Coal
    29    Copper Ingot
    30    Iron Ingot
    31    Silver Ingot
    32    Gold Ingot
    33    Stone Lighter
    34    Lumenstone
    35    Wooden Torch
    36    Coal Torch
    37    Lumenstone Torch
    38    Zinc Ore
    39    Rhymestone Ore
    40    Obdurite Ore
    41    Aluminum Ore
    42    Lead Ore
    43    Uranium Ore
    44    Zythium Ore
    45    Silicon Ore
    46    Irradium Ore
    47    Nullstone
    48    Meltstone
    49    Skystone
    50    Magnetite Ore
    51    Zinc Pick
    52    Zinc Axe
    53    Zinc Sword
    54    Rhymestone Pick
    55    Rhymestone Axe
    56    Rhymestone Sword
    57    Obdurite Pick
    58    Obdurite Axe
    59    Obdurite Sword
    60    Zinc Ingot
    61    Rhymestone Ingot
    62    Obdurite Ingot
    63    Aluminum Ingot
    64    Lead Ingot
    65    Uranium Bar
    66    Refined Uranium
    67    Zythium Bar
    68    Silicon Bar
    69    Irradium Ingot
    70    Nullstone Bar
    71    Meltstone Bar
    72    Skystone Bar
    73    Magnetite Ingot
    74    Sand
    75    Snow
    76    Glass
    77    Sunflower Seeds
    78    Sunflower
    79    Moonflower Seeds
    80    Moonflower
    81    Dryweed Seeds
    82    Dryweed
    83    Greenleaf Seeds
    84    Greenleaf
    85    Frostleaf Seeds
    86    Frostleaf
    87    Caveroot Seeds
    88    Caveroot
    89    Skyblossom Seeds
    90    Skyblossom
    91    Void Rot Seeds
    92    Void Rot
    93    Mud
    94    Sandstone
    95    Marshleaf Seeds
    96    Marshleaf
    97    Blue Goo
    98    Green Goo
    99    Red Goo
    100    Yellow Goo
    101    Black Goo
    102    White Goo
    103    Astral Shard
    104    Rotten Chunk
    105    Copper Helmet
    106    Copper Chestplate
    107    Copper Leggings
    108    Copper Greaves
    109    Iron Helmet
    110    Iron Chestplate
    111    Iron Leggings
    112    Iron Greaves
    113    Silver Helmet
    114    Silver Chestplate
    115    Silver Leggings
    116    Silver Greaves
    117    Gold Helmet
    118    Gold Chestplate
    119    Gold Leggings
    120    Gold Greaves
    121    Zinc Helmet
    122    Zinc Chestplate
    123    Zinc Leggings
    124    Zinc Greaves
    125    Rhymestone Helmet
    126    Rhymestone Chestplate
    127    Rhymestone Leggings
    128    Rhymestone Greaves
    129    Obdurite Helmet
    130    Obdurite Chestplate
    131    Obdurite Leggings
    132    Obdurite Greaves
    133    Aluminum Helmet
    134    Aluminum Chestplate
    135    Aluminum Leggings
    136    Aluminum Greaves
    137    Lead Helmet
    138    Lead Chestplate
    139    Lead Leggings
    140    Lead Greaves
    141    Zythium Helmet
    142    Zythium Chestplate
    143    Zythium Leggings
    144    Zythium Greaves
    145    Aluminum Pick
    146    Aluminum Axe
    147    Aluminum Sword
    148    Lead Pick
    149    Lead Axe
    150    Lead Sword
    151    Zinc Chest
    152    Rhymestone Chest
    153    Obdurite Chest
    154    Wooden Pick
    155    Wooden Axe
    156    Wooden Sword
    157    Stone Pick
    158    Stone Axe
    159    Stone Sword
    160    Bark
    161    Cobblestone
    162    Chiseled Stone
    163    Chiseled Cobblestone
    164    Stone Bricks
    165    Clay
    166    Clay Bricks
    167    Varnish
    168    Varnished Wood
    169    Magnetite Pick
    170    Magnetite Axe
    171    Magnetite Sword
    172    Irradium Pick
    173    Irradium Axe
    174    Irradium Sword
    175    Zythium Wire
    176    Zythium Torch
    177    Zythium Lamp
    178    Lever
    179    Charcoal
    180    Zythium Amplifier
    181    Zythium Inverter
    182    Button
    183    Wooden Pressure Plate
    184    Stone Pressure Plate
    185    Zythium Pressure Plate
    186    Zythium Delayer (1)
    187    Zythium Delayer (2)
    188    Zythium Delayer (4)
    189    Zythium Delayer (8)
    190    Wrench

    */

    public class TerrariaClone : FakeFrame, ChangeListener, KeyListener, MouseListener, MouseMotionListener, MouseWheelListener
    {

        static GraphicsConfiguration config = GraphicsConfiguration.Config;
        Image screen;
        Color bg;

        int size = CHUNKBLOCKS * 2;

        int[][] cl = new int[][] { new int[] { -1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 } };

        Timer timer, menuTimer, paintTimer;
        FileInfo folder;
        List<String> worldFiles, worldNames;
        String currentWorld;
        TextField newWorldName;

        int[][,] blocks;
        Byte[][,] blockds;
        Byte[,] blockdns;
        Byte[,] blockbgs;
        Byte[,] blockts;
        float[,] lights;
        float[,,] power;
        Boolean[,] lsources;
        List<int> lqx, lqy, pqx, pqy, zqx, zqy, pzqx, pzqy;
        Boolean[,] lqd, zqd, pqd, pzqd;
        Byte[,] zqn;
        Byte[,,] pzqn;
        Boolean[,,] arbprd;
        List<int> updatex, updatey, updatet, updatel;
        Boolean[,] wcnct;
        Boolean[,] drawn, ldrawn, rdrawn;
        Player player;
        Inventory inventory;
        public static ItemCollection cic, armor;
        List<Entity> entities;
        List<Double> cloudsx, cloudsy, cloudsv;
        List<int> cloudsn;
        List<int> machinesx, machinesy;

        Chunk[,] temporarySaveFile;
        Chunk[,] chunkMatrix;

        int rgnc1 = 0;
        int rgnc2 = 0;
        int layer = 1;
        int iclayer;
        int layerTemp;
        int blockTemp;
        Image layerImg;

        Entity entity;
        String state = "loading_graphics";
        String msg = "If you are reading this then\nplease report an error.";
        String mobSpawn;

        int u, v, ou, ov, uNew, vNew;
        int x, y, i, j, k, t, wx, wy, lx, ly, tx, ty, twx, twy, tlx, tly, ux, uy, ux2, uy2, uwx, uwy, uwx2, ulx, uly, ulx2, uly2, ucx, ucy, uclx, ucly, pwx, pwy, icx, icy, n, m, dx, dy, dx2, dy2, mx, my, lsx, lsy, lsn, ax, ay, axl, ayl, nl, vc, xpos, ypos, xpos2, ypos2, x2, y2, rnum, mining, immune, width, height, xmin, xmax, ymin, ymax, intpercent, ground;
        double p, q;
        short s, miningTool;

        short moveItem, moveNum, moveDur, moveItemTemp, moveNumTemp, moveDurTemp;
        int msi = 0;

        double top, bottom, percent;

        double toolAngle, toolSpeed;

        double timeOfDay = 0; // 28000 (before dusk), 32000 (after dusk)
        int currentSkyLight = 28800;
        int day = 0;

        int mobCount = 0;

        Point tp1, tp2, tp3, tp4, tp5;

        int[] mousePos, mousePos2;

        Font font = new Font("Chalkboard", Font.Bold, 12);
        Font mobFont = new Font("Chalkboard", Font.Bold, 16);
        Font loadFont = new Font("Courier", Font.Plain, 12);
        Font menuFont = new Font("Chalkboard", Font.Plain, 30);
        Font worldFont = new Font("Andale Mono", Font.Bold, 16);
        Color CYANISH = new Color(75, 163, 243);
        int loadTextPos = 0;

        Image sun, moon, cloud, logo_white, logo_black, title_screen, select_world, new_world, save_exit;
        Image[] clouds = { loadImage("environment/cloud1.png") };
        Image wcnct_px = loadImage("misc/wcnct.png");

        Thread thread;
        Timer createWorldTimer;
        bool[] queue;

        bool done = false;
        bool ready = true;
        bool showTool = false;
        bool showInv = false;
        bool checkBlocks = true;
        bool mouseClicked = true;
        bool mouseClicked2 = true;
        bool mouseNoLongerClicked = false;
        bool mouseNoLongerClicked2 = false;
        bool addSources = false;
        bool removeSources = false;
        bool beginLight = false;
        bool doMobSpawn = false;
        bool keepLeaf = false;
        bool newWorldFocus = false;
        bool menuPressed = false;
        bool doGenerateWorld = true;
        bool doGrassGrow = false;
        bool reallyAddPower = false;
        bool reallyRemovePower = false;

        static int WIDTH = 2400;
        static int HEIGHT = 2400;

        static int BLOCKSIZE = 16;
        static int IMAGESIZE = 8;
        public static int CHUNKBLOCKS = 96;
        static int CHUNKSIZE = CHUNKBLOCKS * BLOCKSIZE;
        static int PLAYERSIZEX = 20;
        static int PLAYERSIZEY = 46;
        static int seed = new Random().Next();

        static Random random = new Random(seed); // SEED

        static int BRIGHTEST = 21;
        static int PMAX = 10;

        public static bool DEBUG_INSTAMINE = false;
        public static double DEBUG_ACCEL = 1;
        public static bool DEBUG_NOCLIP = false;
        public static bool DEBUG_LIGHT = false;
        public static bool DEBUG_REACH = true;
        public static bool DEBUG_PEACEFUL = true;
        public static int DEBUG_HOSTILE = 1;
        public static bool DEBUG_F1 = false;
        public static bool DEBUG_SPEED = true;
        public static bool DEBUG_FLIGHT = true;
        public static bool DEBUG_INVINCIBLE = true;
        public static int DEBUG_HERBGROW = 1;
        public static int DEBUG_GRASSGROW = 1;
        public static String DEBUG_MOBTEST = null;
        public static bool DEBUG_STATS = true;
        public static String DEBUG_ITEMS = "testing";
        public static bool DEBUG_GPLACE = true;

        static int WORLDWIDTH = WIDTH / CHUNKBLOCKS + 1;
        static int WORLDHEIGHT = HEIGHT / CHUNKBLOCKS + 1;

        static int SUNLIGHTSPEED = 14;

        int resunlight = WIDTH;
        int sunlightlevel = 19;

        ItemCollection ic;

        Image[,] worlds, fworlds;
        bool[,] kworlds;

        Image world;

        ItemCollection[,,] icmatrix;

        Image image, tool, mobImage;

        short[] toolList = { 7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173 };

        String[] blocknames = {"air", "dirt", "stone",
        "copper_ore", "iron_ore", "silver_ore", "gold_ore",
        "wood", "workbench",
        "wooden_chest", "stone_chest",
        "copper_chest", "iron_chest", "silver_chest", "gold_chest",
        "tree", "leaves", "furnace", "coal",
        "lumenstone",
        "wooden_torch", "coal_torch", "lumenstone_torch",
        "furnace_on",
        "wooden_torch_left", "wooden_torch_right",
        "coal_torch_left", "coal_torch_right",
        "lumenstone_torch_left", "lumenstone_torch_right",
        "tree_root",
        "zinc_ore", "rhymestone_ore", "obdurite_ore",
        "aluminum_ore", "lead_ore", "uranium_ore",
        "zythium_ore", "zythium_ore_on", "silicon_ore",
        "irradium_ore", "nullstone", "meltstone", "skystone",
        "magnetite_ore",
        "sand", "snow", "glass",
        "sunflower_stage_1", "sunflower_stage_2", "sunflower_stage_3",
        "moonflower_stage_1", "moonflower_stage_2", "moonflower_stage_3",
        "dryweed_stage_1", "dryweed_stage_2", "dryweed_stage_3",
        "greenleaf_stage_1", "greenleaf_stage_2", "greenleaf_stage_3",
        "frostleaf_stage_1", "frostleaf_stage_2", "frostleaf_stage_3",
        "caveroot_stage_1", "caveroot_stage_2", "caveroot_stage_3",
        "skyblossom_stage_1", "skyblossom_stage_2", "skyblossom_stage_3",
        "void_rot_stage_1", "void_rot_stage_2", "void_rot_stage_3",
        "grass", "jungle_grass", "swamp_grass",
        "mud", "sandstone",
        "marshleaf_stage_1", "marshleaf_stage_2", "marshleaf_stage_3",
        "zinc_chest", "rhymestone_chest", "obdurite_chest",
        "tree_no_bark", "cobblestone",
        "chiseled_stone", "chiseled_cobblestone", "stone_bricks",
        "clay", "clay_bricks", "varnished_wood",
        "dirt_trans", "magnetite_ore_trans", "grass_trans",
        "zythium_wire_0", "zythium_wire_1", "zythium_wire_2", "zythium_wire_3", "zythium_wire_4", "zythium_wire_5",
        "zythium_torch", "zythium_torch_left", "zythium_torch_right", "zythium_lamp", "zythium_lamp_on",
        "lever", "lever_on", "lever_left", "lever_left_on", "lever_right", "lever_right_on",
        "zythium_amplifier_right", "zythium_amplifier_down", "zythium_amplifier_left", "zythium_amplifier_up",
        "zythium_amplifier_right_on", "zythium_amplifier_down_on", "zythium_amplifier_left_on", "zythium_amplifier_up_on",
        "zythium_inverter_right", "zythium_inverter_down", "zythium_inverter_left", "zythium_inverter_up",
        "zythium_inverter_right_on", "zythium_inverter_down_on", "zythium_inverter_left_on", "zythium_inverter_up_on",
        "button_left", "button_left_on", "button_right", "button_right_on", "wooden_pressure_plate", "wooden_pressure_plate_on",
        "stone_pressure_plate", "stone_pressure_plate_on", "zythium_pressure_plate", "zythium_pressure_plate_on",
        "zythium_delayer_1_right", "zythium_delayer_1_down", "zythium_delayer_1_left", "zythium_delayer_1_up",
        "zythium_delayer_1_right_on", "zythium_delayer_1_down_on", "zythium_delayer_1_left_on", "zythium_delayer_1_up_on",
        "zythium_delayer_2_right", "zythium_delayer_2_down", "zythium_delayer_2_left", "zythium_delayer_2_up",
        "zythium_delayer_2_right_on", "zythium_delayer_2_down_on", "zythium_delayer_2_left_on", "zythium_delayer_2_up_on",
        "zythium_delayer_4_right", "zythium_delayer_4_down", "zythium_delayer_4_left", "zythium_delayer_4_up",
        "zythium_delayer_4_right_on", "zythium_delayer_4_down_on", "zythium_delayer_4_left_on", "zythium_delayer_4_up_on",
        "zythium_delayer_8_right", "zythium_delayer_8_down", "zythium_delayer_8_left", "zythium_delayer_8_up",
        "zythium_delayer_8_right_on", "zythium_delayer_8_down_on", "zythium_delayer_8_left_on", "zythium_delayer_8_up_on"};

        String[] dirs = {"center", "tdown_both", "tdown_cw", "tdown_ccw",
        "tdown", "tup_both", "tup_cw", "tup_ccw",
        "tup", "leftright", "tright_both", "tright_cw",
        "tright_ccw", "tright", "upleftdiag", "upleft",
        "downleftdiag", "downleft", "left", "tleft_both",
        "tleft_cw", "tleft_ccw", "tleft", "uprightdiag",
        "upright", "downrightdiag", "downright", "right",
        "updown", "up", "down", "single"};

        String[] ui_items = {"Air", "Dirt", "Stone",
        "Copper Ore", "Iron Ore", "Silver Ore", "Gold Ore",
        "Copper Pick", "Iron Pick", "Silver Pick", "Gold Pick",
        "Copper Axe", "Iron Axe", "Silver Axe", "Gold Axe",
        "Wood", "Copper Sword", "Iron Sword", "Silver Sword", "Gold Sword",
        "Workbench",
        "Wooden Chest", "Stone Chest",
        "Copper Chest", "Iron Chest", "Silver Chest", "Gold Chest",
        "Furnace", "Coal",
        "Copper Ingot", "Iron Ingot", "Silver Ingot", "Gold Ingot",
        "Stone Lighter", "Lumenstone",
        "Wooden Torch", "Coal Torch", "Lumenstone Torch",
        "Zinc Ore", "Rhymestone Ore", "Obdurite Ore",
        "Aluminum Ore", "Lead Ore", "Uranium Ore",
        "Zythium Ore", "Silicon Ore",
        "Irradium Ore", "Nullstone", "Meltstone", "Skystone",
        "Magnetite Ore",
        "Zinc Pick", "Zinc Axe", "Zinc Sword",
        "Rhymestone Pick", "Rhymestone Axe", "Rhymestone Sword",
        "Obdurite Pick", "Obdurite Axe", "Obdurite Sword",
        "Zinc Ingot", "Rhymestone Ingot", "Obdurite Ingot",
        "Aluminum Ingot", "Lead Ingot", "Uranium Bar", "Refined Uranium",
        "Zythium Bar", "Silicon Bar",
        "Irradium Ingot", "Nullstone Bar", "Meltstone Bar", "Skystone Bar",
        "Magnetite Ingot",
        "Sand", "Snow", "Glass",
        "Sunflower Seeds", "Sunflower", "Moonflower Seeds", "Moonflower",
        "Dryweed Seeds", "Dryweed", "Greenleaf Seeds", "Greenleaf",
        "Frostleaf Seeds", "Frostleaf", "Caveroot Seeds", "Caveroot",
        "Skyblossom Seeds", "Skyblossom", "Void Rot Seeds", "Void Rot",
        "Mud", "Sandstone",
        "Marshleaf Seeds", "Marshleaf",
        "Blue Goo", "Green Goo", "Red Goo", "Yellow Goo", "Black Goo", "White Goo",
        "Astral Shard", "Rotten Chunk",
        "Copper Helmet", "Copper Chestplate", "Copper Leggings", "Copper Greaves",
        "Iron Helmet", "Iron Chestplate", "Iron Leggings", "Iron Greaves",
        "Silver Helmet", "Silver Chestplate", "Silver Leggings", "Silver Greaves",
        "Gold Helmet", "Gold Chestplate", "Gold Leggings", "Gold Greaves",
        "Zinc Helmet", "Zinc Chestplate", "Zinc Leggings", "Zinc Greaves",
        "Rhymestone Helmet", "Rhymestone Chestplate", "Rhymestone Leggings", "Rhymestone Greaves",
        "Obdurite Helmet", "Obdurite Chestplate", "Obdurite Leggings", "Obdurite Greaves",
        "Aluminum Helmet", "Aluminum Chestplate", "Aluminum Leggings", "Aluminum Greaves",
        "Lead Helmet", "Lead Chestplate", "Lead Leggings", "Lead Greaves",
        "Zythium Helmet", "Zythium Chestplate", "Zythium Leggings", "Zythium Greaves",
        "Aluminum Pick", "Aluminum Axe", "Aluminum Sword",
        "Lead Pick", "Lead Axe", "Lead Sword",
        "Zinc Chest", "Rhymestone Chest", "Obdurite Chest",
        "Wooden Pick", "Wooden Axe", "Wooden Sword",
        "Stone Pick", "Stone Axe", "Stone Sword",
        "Bark", "Cobblestone",
        "Chiseled Stone", "Chiseled Cobblestone", "Stone Bricks",
        "Clay", "Clay Bricks", "Varnish", "Varnished Wood",
        "Magnetite Pick", "Magnetite Axe", "Magnetite Sword",
        "Irradium Pick", "Irradium Axe", "Irradium Sword",
        "Zythium Wire", "Zythium Torch", "Zythium Lamp", "Lever",
        "Charcoal", "Zythium Amplifier", "Zythium Inverter", "Button",
        "Wooden Pressure Plate", "Stone Pressure Plate", "Zythium Pressure Plate",
        "Zythium Delayer", "Zythium Delayer", "Zythium Delayer", "Zythium Delayer", "Wrench"};

        static String[] items = {"air", "blocks/dirt", "blocks/stone", "ores/copper_ore",
        "ores/iron_ore", "ores/silver_ore", "ores/gold_ore", "tools/copper_pick",
        "tools/iron_pick", "tools/silver_pick", "tools/gold_pick", "tools/copper_axe",
        "tools/iron_axe", "tools/silver_axe", "tools/gold_axe", "blocks/wood",
        "tools/copper_sword", "tools/iron_sword", "tools/silver_sword", "tools/gold_sword",
        "machines/workbench",
        "machines/wooden_chest", "machines/stone_chest",
        "machines/copper_chest", "machines/iron_chest", "machines/silver_chest", "machines/gold_chest",
        "machines/furnace",
        "ores/coal", "ingots/copper_ingot", "ingots/iron_ingot", "ingots/silver_ingot", "ingots/gold_ingot",
        "tools/stone_lighter", "ores/lumenstone",
        "torches/wooden_torch", "torches/coal_torch", "torches/lumenstone_torch",
        "ores/zinc_ore", "ores/rhymestone_ore", "ores/obdurite_ore",
        "ores/aluminum_ore", "ores/lead_ore", "ores/uranium_ore",
        "ores/zythium_ore", "ores/silicon_ore",
        "ores/irradium_ore", "ores/nullstone", "ores/meltstone", "ores/skystone",
        "ores/magnetite_ore",
        "tools/zinc_pick", "tools/zinc_axe", "tools/zinc_sword",
        "tools/rhymestone_pick", "tools/rhymestone_axe", "tools/rhymestone_sword",
        "tools/obdurite_pick", "tools/obdurite_axe", "tools/obdurite_sword",
        "ingots/zinc_ingot", "ingots/rhymestone_ingot", "ingots/obdurite_ingot",
        "ingots/aluminum_ingot", "ingots/lead_ingot", "ingots/uranium_bar", "ingots/refined_uranium",
        "ingots/zythium_bar", "ingots/silicon_bar",
        "ingots/irradium_ingot", "ingots/nullstone_bar", "ingots/meltstone_bar", "ingots/skystone_bar",
        "ingots/magnetite_ingot",
        "blocks/sand", "blocks/snow", "blocks/glass",
        "seeds/sunflower_seeds", "herbs/sunflower", "seeds/moonflower_seeds", "herbs/moonflower",
        "seeds/dryweed_seeds", "herbs/dryweed", "seeds/greenleaf_seeds", "herbs/greenleaf",
        "seeds/frostleaf_seeds", "herbs/frostleaf", "seeds/caveroot_seeds", "herbs/caveroot",
        "seeds/skyblossom_seeds", "herbs/skyblossom", "seeds/void_rot_seeds", "herbs/void_rot",
        "blocks/mud", "blocks/sandstone",
        "seeds/marshleaf_seeds", "herbs/marshleaf",
        "goo/blue_goo", "goo/green_goo", "goo/red_goo", "goo/yellow_goo", "goo/black_goo", "goo/white_goo",
        "goo/astral_shard", "goo/rotten_chunk",
        "armor/copper_helmet", "armor/copper_chestplate", "armor/copper_leggings", "armor/copper_greaves",
        "armor/iron_helmet", "armor/iron_chestplate", "armor/iron_leggings", "armor/iron_greaves",
        "armor/silver_helmet", "armor/silver_chestplate", "armor/silver_leggings", "armor/silver_greaves",
        "armor/gold_helmet", "armor/gold_chestplate", "armor/gold_leggings", "armor/gold_greaves",
        "armor/zinc_helmet", "armor/zinc_chestplate", "armor/zinc_leggings", "armor/zinc_greaves",
        "armor/rhymestone_helmet", "armor/rhymestone_chestplate", "armor/rhymestone_leggings", "armor/rhymestone_greaves",
        "armor/obdurite_helmet", "armor/obdurite_chestplate", "armor/obdurite_leggings", "armor/obdurite_greaves",
        "armor/aluminum_helmet", "armor/aluminum_chestplate", "armor/aluminum_leggings", "armor/aluminum_greaves",
        "armor/lead_helmet", "armor/lead_chestplate", "armor/lead_leggings", "armor/lead_greaves",
        "armor/zythium_helmet", "armor/zythium_chestplate", "armor/zythium_leggings", "armor/zythium_greaves",
        "tools/aluminum_pick", "tools/aluminum_axe", "tools/aluminum_sword",
        "tools/lead_pick", "tools/lead_axe", "tools/lead_sword",
        "machines/zinc_chest", "machines/rhymestone_chest", "machines/obdurite_chest",
        "tools/wooden_pick", "tools/wooden_axe", "tools/wooden_sword",
        "tools/stone_pick", "tools/stone_axe", "tools/stone_sword",
        "goo/bark", "blocks/cobblestone",
        "blocks/chiseled_stone", "blocks/chiseled_cobblestone", "blocks/stone_bricks",
        "blocks/clay", "blocks/clay_bricks", "potions/varnish", "blocks/varnished_wood",
        "tools/magnetite_pick", "tools/magnetite_axe", "tools/magnetite_sword",
        "tools/irradium_pick", "tools/irradium_axe", "tools/irradium_sword",
        "wires/zythium_wire", "torches/zythium_torch", "blocks/zythium_lamp", "misc/lever",
        "dust/charcoal", "wires/zythium_amplifier", "wires/zythium_inverter", "misc/button",
        "misc/wooden_pressure_plate", "misc/stone_pressure_plate", "misc/zythium_pressure_plate",
        "wires/zythium_delayer_1", "wires/zythium_delayer_2", "wires/zythium_delayer_4", "wires/zythium_delayer_8", "tools/wrench"};

        static String version = "0.3_01";

        static bool[] blockcds = { false, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        static bool[] solid = { false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, false, false, false, true, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        static bool[] ltrans = { false, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, false, false, false, false, false, false, false, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        static bool[] powers = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, false, false, false, true, false, true, false, true, false, false, false, false, true, true, true, true, true, true, true, true, false, false, false, false, false, true, false, true, false, true, false, true, false, true, false, false, false, false, true, true, true, true, false, false, false, false, true, true, true, true, false, false, false, false, true, true, true, true, false, false, false, false, true, true, true, true };
        static double[] conducts = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0, 0, 0, -1, -1, -1, 0, -1, 0, -1, 0, -1, -1, -1, -1, 0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, 0, -1, 0, -1, 0, -1, 0, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        static bool[] receives = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, false, false, false, true, true, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true };
        public static bool[] wirec = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true };
        static int[] skycolors = { 28800, 28980, 29160, 29340, 29520, 29700, 29880, 30060, 30240, 30420, 30600, 30780, 30960, 31140, 31320, 31500, 31680, 31860, 32040, 32220, 72000, 72180, 72360, 72540, 72720, 72900, 73080, 73260, 73440, 73620, 73800, 73980, 74160, 74340, 74520, 74700, 74880, 75060, 75240, 75420 };

        static Dictionary<Byte, Image> backgroundImgs;
        static Dictionary<short, Image> itemImgs;
        static Dictionary<short, Dictionary<int, int>> DURABILITY;
        static Dictionary<int, int> dur;
        static Dictionary<int, short[]> BLOCKTOOLS;
        static Dictionary<short, Double> TOOLSPEED;
        static Dictionary<short, int> TOOLDAMAGE;
        static Dictionary<int, short> BLOCKDROPS;
        static Dictionary<short, int> ITEMBLOCKS;
        static Dictionary<int, String> OUTLINES;
        static Dictionary<String, String> UIBLOCKS;
        static Dictionary<String, String> UIENTITIES;
        static Dictionary<int, Boolean> BLOCKCD;
        static Dictionary<short, short> MAXSTACKS;
        static Dictionary<int, int> SKYLIGHTS;
        static Dictionary<int, Color> SKYCOLORS;
        static Dictionary<int, Image> LIGHTLEVELS;
        static Dictionary<String, Image> blockImgs;
        static Dictionary<String, Image> outlineImgs;
        static Dictionary<int, int> BLOCKLIGHTS;
        static Dictionary<int, int> GRASSDIRT;
        static Dictionary<short, int> ARMOR;
        static Dictionary<short, short> TOOLDURS;
        static Dictionary<short, Double> FUELS;
        static Dictionary<int, int> WIREP;
        static Dictionary<int, int> TORCHESL;
        static Dictionary<int, int> TORCHESR;
        static Dictionary<int, Boolean> TORCHESB;
        static Dictionary<int, Boolean> GSUPPORT;
        static Dictionary<short, Double> FSPEED;
        static Dictionary<int, int> DDELAY;

        List<short> FRI1, FRN1, FRI2, FRN2;

        Graphics2D g2, wg2, fwg2, ug2, pg2;

        StreamWriter output, boutput;
        StreamReader input;

        static StreamWriter log;

        public static void main(String[] args)
        {
            //TODO: Make sure converted
            //JFrame f = new JFrame("TerrariaClone: Infinite worlds!");
            //f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            //f.setVisible(true);

            //JApplet ap = new TerrariaClone();
            //ap.setFocusable(true);
            //f.Add("Center", ap);
            //f.pack();

            //ap.init();
        }

        public void init()
        {
            try
            {
                //TODO: Make sure converted
                //setLayout(new BorderLayout());
                bg = Color.Black;

                addKeyListener(this);
                addMouseListener(this);
                addMouseMotionListener(this);
                addMouseWheelListener(this);

                screen = new Image(getWidth(), getHeight());

                queue = new bool[7]; // left[0] right[1] up[2] mouse[3] rightmouse[4] shift[5] down[6]

                mousePos = new int[2];
                mousePos2 = new int[2];

                logo_white = loadImage("interface/logo_white.png");
                logo_black = loadImage("interface/logo_black.png");
                title_screen = loadImage("interface/title_screen.png");
                select_world = loadImage("interface/select_world.png");
                new_world = loadImage("interface/new_world.png");
                save_exit = loadImage("interface/save_exit.png");

                state = "loading_graphics";

                repaint();

                backgroundImgs = new Dictionary<Byte, Image>();

                String[] bgs = {"solid/empty", "dirt_none/downleft", "dirt_none/downright", "dirt_none/left", "dirt_none/right", "dirt_none/up", "dirt_none/upleft", "dirt_none/upright",
                "solid/dirt", "stone_dirt/downleft", "stone_dirt/downright", "stone_dirt/left", "stone_dirt/right", "stone_dirt/up", "stone_dirt/upleft", "stone_dirt/upright",
                "solid/stone", "stone_none/down"};

                for (i = 0; i < bgs.Length; i++)
                {
                    backgroundImgs.Add((byte)i, loadImage("backgrounds/" + bgs[i] + ".png"));
                }

                itemImgs = new Dictionary<short, Image>();

                for (i = 1; i < items.Length; i++)
                {
                    itemImgs.Add((short)i, loadImage("items/" + items[i] + ".png"));
                    if (itemImgs[(short)i] == null)
                    {
                        Console.WriteLine("[ERROR] Could not load item graphic '" + items[i] + "'.");
                    }
                }

                blockImgs = new Dictionary<String, Image>();

                for (i = 1; i < blocknames.Length; i++)
                {
                    for (j = 0; j < 8; j++)
                    {
                        blockImgs.Add("blocks/" + blocknames[i] + "/texture" + (j + 1) + ".png",
                            loadImage("blocks/" + blocknames[i] + "/texture" + (j + 1) + ".png"));
                        if (blockImgs["blocks/" + blocknames[i] + "/texture" + (j + 1) + ".png"] == null)
                        {
                            Console.WriteLine("[ERROR] Could not load block graphic '" + blocknames[i] + "'.");
                        }
                    }
                }

                outlineImgs = new Dictionary<String, Image>();

                String[] outlineNameList = { "default", "wood", "none", "tree", "tree_root", "square", "wire" };

                for (i = 0; i < outlineNameList.Length; i++)
                {
                    for (j = 0; j < dirs.Length; j++)
                    {
                        for (k = 0; k < 5; k++)
                        {
                            outlineImgs.Add("outlines/" + outlineNameList[i] + "/" + dirs[j] + (k + 1) + ".png",
                                loadImage("outlines/" + outlineNameList[i] + "/" + dirs[j] + (k + 1) + ".png"));
                        }
                    }
                }

                DURABILITY = new Dictionary<short, Dictionary<int, int>>();

                codeTooLarge();

                BLOCKTOOLS = new Dictionary<int, short[]>();

                short[][] blocktools = new short[][]{new short[]{},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{11, 12, 13, 14, 52, 55, 58, 146, 149, 155, 158, 170, 173},
                                    new short[]{11, 12, 13, 14, 52, 55, 58, 146, 149, 155, 158, 170, 173},
                                    new short[]{11, 12, 13, 14, 52, 55, 58, 146, 149, 155, 158, 170, 173},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{11, 12, 13, 14, 52, 55, 58, 146, 149, 155, 158, 170, 173},
                                    new short[]{},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{11, 12, 13, 14, 52, 55, 58, 146, 149, 155, 158, 170, 173},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{11, 12, 13, 14, 52, 55, 58, 146, 149, 155, 158, 170, 173},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 11, 12, 13, 14, 51, 52, 54, 55, 57, 58, 145, 146, 148, 149, 154, 155, 157, 158, 169, 170, 172, 173},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{11, 12, 13, 14, 52, 55, 58, 146, 149, 155, 158, 170, 173},
                                    new short[]{11, 12, 13, 14, 52, 55, 58, 146, 149, 155, 158, 170, 173},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172},
                                    new short[]{7, 8, 9, 10, 51, 54, 57, 145, 148, 154, 157, 169, 172}};

                for (i = 0; i < blocktools.Length; i++)
                {
                    for (j = 0; j < blocktools[i].Length; j++)
                    {
                        blocktools[i][j] = (short)blocktools[i][j];
                    }
                }

                for (i = 1; i < blocknames.Length; i++)
                {
                    BLOCKTOOLS.Add(i, blocktools[i]);
                }

                TOOLSPEED = new Dictionary<short, Double>();

                for (i = 1; i < items.Length; i++)
                {
                    TOOLSPEED.Add((short)i, 0.175);
                }

                TOOLSPEED[154] = 0.100;// wood:   P100 S100
                TOOLSPEED[155] = 0.100;
                TOOLSPEED[156] = 0.100;
                TOOLSPEED[157] = 0.110;// stone:  P110 S105
                TOOLSPEED[158] = 0.110;
                TOOLSPEED[159] = 0.105;
                TOOLSPEED[7] = 0.120;  // copper: P120 S110
                TOOLSPEED[11] = 0.120;
                TOOLSPEED[16] = 0.110;
                TOOLSPEED[8] = 0.130;  // iron:   P130 S115
                TOOLSPEED[12] = 0.130;
                TOOLSPEED[17] = 0.115;
                TOOLSPEED[9] = 0.140;  // silver: P140 S120
                TOOLSPEED[13] = 0.140;
                TOOLSPEED[18] = 0.120;
                TOOLSPEED[10] = 0.150; // gold:   P150 S125
                TOOLSPEED[14] = 0.150;
                TOOLSPEED[19] = 0.125;
                TOOLSPEED[51] = 0.160; // zinc:   P160 S130
                TOOLSPEED[52] = 0.160;
                TOOLSPEED[53] = 0.130;
                TOOLSPEED[54] = 0.170; // rhyme:  P170 S135
                TOOLSPEED[55] = 0.170;
                TOOLSPEED[56] = 0.135;
                TOOLSPEED[57] = 0.180; // obdur:  P180 S140
                TOOLSPEED[58] = 0.180;
                TOOLSPEED[59] = 0.140;
                TOOLSPEED[145] = 0.350;// alumin: P250 S175
                TOOLSPEED[146] = 0.350;
                TOOLSPEED[147] = 0.245;
                TOOLSPEED[148] = 0.130;// lead:   P130 S115
                TOOLSPEED[149] = 0.130;
                TOOLSPEED[150] = 0.115;
                TOOLSPEED[169] = 0.250; // magne:  P350 S245
                TOOLSPEED[170] = 0.250;
                TOOLSPEED[171] = 0.175;
                TOOLSPEED[172] = 0.350; // irrad:  P350 S245
                TOOLSPEED[173] = 0.350;
                TOOLSPEED[174] = 0.245;

                TOOLSPEED[33] = 0.125; // stone lighter

                TOOLDAMAGE = new Dictionary<short, int>();

                for (i = 0; i < items.Length; i++)
                {
                    TOOLDAMAGE.Add(((short)i), 1);
                }

                TOOLDAMAGE.Add(((short)7), 2);
                TOOLDAMAGE.Add(((short)8), 3);
                TOOLDAMAGE.Add(((short)9), 3);
                TOOLDAMAGE.Add(((short)10), 4);
                TOOLDAMAGE.Add(((short)11), 3);
                TOOLDAMAGE.Add(((short)12), 4);
                TOOLDAMAGE.Add(((short)13), 5);
                TOOLDAMAGE.Add(((short)14), 6);
                TOOLDAMAGE.Add(((short)16), 5);
                TOOLDAMAGE.Add(((short)17), 8);
                TOOLDAMAGE.Add(((short)18), 13);
                TOOLDAMAGE.Add(((short)19), 18);
                TOOLDAMAGE.Add(((short)51), 6);
                TOOLDAMAGE.Add(((short)52), 9);
                TOOLDAMAGE.Add(((short)53), 24);
                TOOLDAMAGE.Add(((short)54), 8);
                TOOLDAMAGE.Add(((short)55), 11);
                TOOLDAMAGE.Add(((short)56), 30);
                TOOLDAMAGE.Add(((short)57), 10);
                TOOLDAMAGE.Add(((short)58), 15);
                TOOLDAMAGE.Add(((short)59), 38);
                TOOLDAMAGE.Add(((short)145), 7);
                TOOLDAMAGE.Add(((short)146), 10);
                TOOLDAMAGE.Add(((short)147), 27);
                TOOLDAMAGE.Add(((short)148), 4);
                TOOLDAMAGE.Add(((short)149), 5);
                TOOLDAMAGE.Add(((short)150), 9);
                TOOLDAMAGE.Add(((short)154), 1);
                TOOLDAMAGE.Add(((short)155), 1);
                TOOLDAMAGE.Add(((short)156), 3);
                TOOLDAMAGE.Add(((short)157), 1);
                TOOLDAMAGE.Add(((short)158), 2);
                TOOLDAMAGE.Add(((short)159), 4);
                TOOLDAMAGE.Add(((short)57), 20);
                TOOLDAMAGE.Add(((short)58), 30);
                TOOLDAMAGE.Add(((short)59), 75);

                short[] drops = { 0, 1, 2, 3, 4, 5, 6, 15, 20, 21, 22, 23, 24, 25, 26, 15, 0, 27, 28, 34, 35, 36, 37, 27, 35, 35, 36, 36, 37, 37, 0, 38, 39, 40, 41, 42, 43, 44, 44, 45, 46, 47, 48, 49, 50, 74, 75, 0, 0, 0, 78, 0, 0, 80, 0, 0, 82, 0, 0, 84, 0, 0, 86, 0, 0, 88, 0, 0, 90, 0, 0, 92, 1, 1, 93, 93, 94, 0, 0, 96, 151, 152, 153, 15, 161, 162, 163, 164, 165, 166, 168, 1, 50, 1, 175, 175, 175, 175, 175, 175, 176, 176, 176, 177, 177, 178, 178, 178, 178, 178, 178, 180, 180, 180, 180, 180, 180, 180, 180, 181, 181, 181, 181, 181, 181, 181, 181, 182, 182, 182, 182, 183, 183, 184, 184, 185, 185, 186, 186, 186, 186, 186, 186, 186, 186, 187, 187, 187, 187, 187, 187, 187, 187, 188, 188, 188, 188, 188, 188, 188, 188, 189, 189, 189, 189, 189, 189, 189, 189 };

                BLOCKDROPS = new Dictionary<int, short>();

                for (i = 1; i < blocknames.Length; i++)
                {
                    BLOCKDROPS.Add(i, drops[i]);
                }

                int[] itemblocks = { 0, 1, 2, 3, 4, 5, 6, 0, 0, 0, 0, 0, 0, 0, 0, 7, 0, 0, 0, 0, 8, 9, 10, 11, 12, 13, 14, 17, 18, 0, 0, 0, 0, 0, 19, 20, 21, 22, 31, 32, 33, 34, 35, 36, 37, 39, 40, 41, 42, 43, 44, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 45/*72*/, 46, 47, 48, 0, 51, 0, 54, 0, 57, 0, 60, 0, 63, 0, 66, 0, 69, 0, 75, 76, 77, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 80, 81, 82, 0, 0, 0, 0, 0, 0, 0, 84, 85, 86, 87, 88, 89, 0, 90, 0, 0, 0, 0, 0, 0, 94, 100, 103, 105, 0, 111, 119, 127, 131, 133, 135, 137, 145, 153, 161, 0 };

                ITEMBLOCKS = new Dictionary<short, int>();

                for (i = 1; i < items.Length; i++)
                {
                    ITEMBLOCKS.Add(((short)i), itemblocks[i]);
                }

                OUTLINES = new Dictionary<int, String>();

                for (i = 1; i < blocknames.Length; i++)
                {
                    OUTLINES.Add(i, "default");
                }

                OUTLINES.Add(7, "wood");
                OUTLINES.Add(8, "none");
                OUTLINES.Add(9, "none");
                OUTLINES.Add(10, "none");
                OUTLINES.Add(11, "none");
                OUTLINES.Add(12, "none");
                OUTLINES.Add(13, "none");
                OUTLINES.Add(14, "none");
                OUTLINES.Add(15, "tree");
                OUTLINES.Add(17, "none");
                OUTLINES.Add(20, "none");
                OUTLINES.Add(21, "none");
                OUTLINES.Add(22, "none");
                OUTLINES.Add(23, "none");
                OUTLINES.Add(24, "none");
                OUTLINES.Add(25, "none");
                OUTLINES.Add(26, "none");
                OUTLINES.Add(27, "none");
                OUTLINES.Add(28, "none");
                OUTLINES.Add(29, "none");
                OUTLINES.Add(30, "tree_root");
                OUTLINES.Add(47, "square");
                OUTLINES.Add(77, "none");
                OUTLINES.Add(78, "none");
                OUTLINES.Add(79, "none");
                OUTLINES.Add(80, "none");
                OUTLINES.Add(81, "none");
                OUTLINES.Add(82, "none");
                OUTLINES.Add(83, "tree");
                OUTLINES.Add(84, "square");
                OUTLINES.Add(85, "square");
                OUTLINES.Add(86, "square");
                OUTLINES.Add(87, "square");
                OUTLINES.Add(89, "square");
                OUTLINES.Add(90, "wood");
                OUTLINES.Add(94, "wire");
                OUTLINES.Add(95, "wire");
                OUTLINES.Add(96, "wire");
                OUTLINES.Add(97, "wire");
                OUTLINES.Add(98, "wire");
                OUTLINES.Add(99, "wire");
                OUTLINES.Add(100, "none");
                OUTLINES.Add(101, "none");
                OUTLINES.Add(102, "none");
                OUTLINES.Add(103, "square");
                OUTLINES.Add(104, "square");
                OUTLINES.Add(105, "none");
                OUTLINES.Add(106, "none");
                OUTLINES.Add(107, "none");
                OUTLINES.Add(108, "none");
                OUTLINES.Add(109, "none");
                OUTLINES.Add(110, "none");
                OUTLINES.Add(111, "none");
                OUTLINES.Add(112, "none");
                OUTLINES.Add(113, "none");
                OUTLINES.Add(114, "none");
                OUTLINES.Add(115, "none");
                OUTLINES.Add(116, "none");
                OUTLINES.Add(117, "none");
                OUTLINES.Add(118, "none");
                OUTLINES.Add(119, "none");
                OUTLINES.Add(120, "none");
                OUTLINES.Add(121, "none");
                OUTLINES.Add(122, "none");
                OUTLINES.Add(123, "none");
                OUTLINES.Add(124, "none");
                OUTLINES.Add(125, "none");
                OUTLINES.Add(126, "none");
                OUTLINES.Add(127, "none");
                OUTLINES.Add(128, "none");
                OUTLINES.Add(129, "none");
                OUTLINES.Add(130, "none");
                OUTLINES.Add(131, "none");
                OUTLINES.Add(132, "none");
                OUTLINES.Add(133, "none");
                OUTLINES.Add(134, "none");
                OUTLINES.Add(135, "none");
                OUTLINES.Add(136, "none");

                for (i = 48; i < 72; i++)
                {
                    OUTLINES.Add(i, "none");
                }

                for (i = 137; i < 169; i++)
                {
                    OUTLINES.Add(i, "none");
                }

                UIBLOCKS = new Dictionary<String, String>();

                for (i = 1; i < items.Length; i++)
                {
                    UIBLOCKS.Add(items[i], ui_items[i]);
                }

                UIENTITIES = new Dictionary<String, String>();

                UIENTITIES.Add("blue_bubble", "Blue Bubble");
                UIENTITIES.Add("green_bubble", "Green Bubble");
                UIENTITIES.Add("red_bubble", "Red Bubble");
                UIENTITIES.Add("black_bubble", "Black Bubble");
                UIENTITIES.Add("white_bubble", "White Bubble");
                UIENTITIES.Add("zombie", "Zombie");
                UIENTITIES.Add("armored_zombie", "Armored Zombie");
                UIENTITIES.Add("shooting_star", "Shooting Star");
                UIENTITIES.Add("sandbot", "Sandbot");
                UIENTITIES.Add("snowman", "Snowman");
                UIENTITIES.Add("bat", "Bat");
                UIENTITIES.Add("bee", "Bee");
                UIENTITIES.Add("skeleton", "Skeleton");

                BLOCKCD = new Dictionary<int, Boolean>();

                for (i = 1; i < blockcds.Length; i++)
                {
                    BLOCKCD.Add(i, blockcds[i]);
                }

                MAXSTACKS = new Dictionary<short, short>();

                short[] stacks = { 100, 100, 100, 100, 100, 100, 100, 1, 1, 1, 1, 1, 1, 1, 1, 100, 1, 1, 1, 1, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 1, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 1, 1, 1, 1, 1, 1, 1, 1, 1, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 100, 100, 100, 1, 1, 1, 1, 1, 1, 100, 100, 100, 100, 100, 100, 100, 100, 100, 1, 1, 1, 1, 1, 1, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 1 };

                for (i = 0; i < items.Length; i++)
                {
                    MAXSTACKS.Add(((short)i), stacks[i]);
                }

                SKYCOLORS = new Dictionary<int, Color>();

                SKYCOLORS.Add(28800, new Color(71, 154, 230));
                SKYCOLORS.Add(28980, new Color(67, 146, 218));
                SKYCOLORS.Add(29160, new Color(63, 138, 206));
                SKYCOLORS.Add(29340, new Color(60, 130, 194));
                SKYCOLORS.Add(29520, new Color(56, 122, 182));
                SKYCOLORS.Add(29700, new Color(52, 114, 170));
                SKYCOLORS.Add(29880, new Color(48, 105, 157));
                SKYCOLORS.Add(30060, new Color(45, 97, 145));
                SKYCOLORS.Add(30240, new Color(41, 89, 133));
                SKYCOLORS.Add(30420, new Color(37, 81, 121));
                SKYCOLORS.Add(30600, new Color(33, 73, 109));
                SKYCOLORS.Add(30780, new Color(30, 65, 97));
                SKYCOLORS.Add(30960, new Color(26, 57, 85));
                SKYCOLORS.Add(31140, new Color(22, 48, 72));
                SKYCOLORS.Add(31320, new Color(18, 40, 60));
                SKYCOLORS.Add(31500, new Color(15, 32, 48));
                SKYCOLORS.Add(31680, new Color(11, 24, 36));
                SKYCOLORS.Add(31860, new Color(7, 16, 24));
                SKYCOLORS.Add(32040, new Color(3, 8, 12));
                SKYCOLORS.Add(32220, new Color(0, 0, 0));

                SKYCOLORS.Add(72000, new Color(3, 8, 12));
                SKYCOLORS.Add(72180, new Color(7, 16, 24));
                SKYCOLORS.Add(72360, new Color(11, 24, 36));
                SKYCOLORS.Add(72540, new Color(15, 32, 48));
                SKYCOLORS.Add(72720, new Color(18, 40, 60));
                SKYCOLORS.Add(72900, new Color(22, 48, 72));
                SKYCOLORS.Add(73080, new Color(26, 57, 85));
                SKYCOLORS.Add(73260, new Color(30, 65, 97));
                SKYCOLORS.Add(73440, new Color(33, 73, 109));
                SKYCOLORS.Add(73620, new Color(37, 81, 121));
                SKYCOLORS.Add(73800, new Color(41, 89, 133));
                SKYCOLORS.Add(73980, new Color(45, 97, 145));
                SKYCOLORS.Add(74160, new Color(48, 105, 157));
                SKYCOLORS.Add(74340, new Color(52, 114, 170));
                SKYCOLORS.Add(74520, new Color(56, 122, 182));
                SKYCOLORS.Add(74700, new Color(60, 130, 194));
                SKYCOLORS.Add(74880, new Color(63, 138, 206));
                SKYCOLORS.Add(75060, new Color(67, 146, 218));
                SKYCOLORS.Add(75240, new Color(71, 154, 230));
                SKYCOLORS.Add(75420, new Color(75, 163, 243));

                SKYLIGHTS = new Dictionary<int, int>();

                SKYLIGHTS.Add(28883, 18);
                SKYLIGHTS.Add(29146, 17);
                SKYLIGHTS.Add(29409, 16);
                SKYLIGHTS.Add(29672, 15);
                SKYLIGHTS.Add(29935, 14);
                SKYLIGHTS.Add(30198, 13);
                SKYLIGHTS.Add(30461, 12);
                SKYLIGHTS.Add(30724, 11);
                SKYLIGHTS.Add(30987, 10);
                SKYLIGHTS.Add(31250, 9);
                SKYLIGHTS.Add(31513, 8);
                SKYLIGHTS.Add(31776, 7);
                SKYLIGHTS.Add(32039, 6);
                SKYLIGHTS.Add(32302, 5);
                SKYLIGHTS.Add(72093, 6);
                SKYLIGHTS.Add(72336, 7);
                SKYLIGHTS.Add(72639, 8);
                SKYLIGHTS.Add(72912, 9);
                SKYLIGHTS.Add(73185, 10);
                SKYLIGHTS.Add(73458, 11);
                SKYLIGHTS.Add(73731, 12);
                SKYLIGHTS.Add(74004, 13);
                SKYLIGHTS.Add(74277, 14);
                SKYLIGHTS.Add(74550, 15);
                SKYLIGHTS.Add(74823, 16);
                SKYLIGHTS.Add(75096, 17);
                SKYLIGHTS.Add(75369, 18);
                SKYLIGHTS.Add(75642, 19);

                LIGHTLEVELS = new Dictionary<int, Image>();

                for (i = 0; i < 17; i++)
                {
                    LIGHTLEVELS.Add(i, loadImage("light/" + i + ".png"));
                }

                BLOCKLIGHTS = new Dictionary<int, int>();

                for (i = 0; i < blocknames.Length; i++)
                {
                    BLOCKLIGHTS.Add(i, 0);
                }

                BLOCKLIGHTS.Add(19, 21);
                BLOCKLIGHTS.Add(20, 15);
                BLOCKLIGHTS.Add(21, 18);
                BLOCKLIGHTS.Add(22, 21);
                BLOCKLIGHTS.Add(23, 15);
                BLOCKLIGHTS.Add(24, 15);
                BLOCKLIGHTS.Add(25, 15);
                BLOCKLIGHTS.Add(26, 18);
                BLOCKLIGHTS.Add(27, 18);
                BLOCKLIGHTS.Add(28, 21);
                BLOCKLIGHTS.Add(29, 21);
                BLOCKLIGHTS.Add(36, 15);
                BLOCKLIGHTS.Add(36, 15);
                BLOCKLIGHTS.Add(38, 18);
                BLOCKLIGHTS.Add(51, 15);
                BLOCKLIGHTS.Add(52, 15);
                BLOCKLIGHTS.Add(53, 15);
                BLOCKLIGHTS.Add(95, 6);
                BLOCKLIGHTS.Add(96, 7);
                BLOCKLIGHTS.Add(97, 8);
                BLOCKLIGHTS.Add(98, 9);
                BLOCKLIGHTS.Add(99, 10);
                BLOCKLIGHTS.Add(100, 12);
                BLOCKLIGHTS.Add(101, 12);
                BLOCKLIGHTS.Add(102, 12);
                BLOCKLIGHTS.Add(104, 21);
                BLOCKLIGHTS.Add(112, 12);
                BLOCKLIGHTS.Add(114, 12);
                BLOCKLIGHTS.Add(116, 12);
                BLOCKLIGHTS.Add(118, 12);
                BLOCKLIGHTS.Add(123, 12);
                BLOCKLIGHTS.Add(124, 12);
                BLOCKLIGHTS.Add(125, 12);
                BLOCKLIGHTS.Add(126, 12);

                BLOCKLIGHTS.Add(137, 12);
                BLOCKLIGHTS.Add(138, 12);
                BLOCKLIGHTS.Add(139, 12);
                BLOCKLIGHTS.Add(140, 12);
                BLOCKLIGHTS.Add(145, 12);
                BLOCKLIGHTS.Add(146, 12);
                BLOCKLIGHTS.Add(147, 12);
                BLOCKLIGHTS.Add(148, 12);
                BLOCKLIGHTS.Add(153, 12);
                BLOCKLIGHTS.Add(154, 12);
                BLOCKLIGHTS.Add(155, 12);
                BLOCKLIGHTS.Add(156, 12);
                BLOCKLIGHTS.Add(161, 12);
                BLOCKLIGHTS.Add(162, 12);
                BLOCKLIGHTS.Add(163, 12);
                BLOCKLIGHTS.Add(164, 12);

                GRASSDIRT = new Dictionary<int, int>();

                GRASSDIRT.Add(72, 1);
                GRASSDIRT.Add(73, 1);
                GRASSDIRT.Add(74, 75);
                GRASSDIRT.Add(93, 91);

                ARMOR = new Dictionary<short, int>();

                for (i = 0; i < items.Length; i++)
                {
                    ARMOR.Add(((short)i), 0);
                }

                ARMOR.Add(((short)105), 1);
                ARMOR.Add(((short)106), 2);
                ARMOR.Add(((short)107), 1);
                ARMOR.Add(((short)108), 1);
                ARMOR.Add(((short)109), 1);
                ARMOR.Add(((short)110), 3);
                ARMOR.Add(((short)111), 2);
                ARMOR.Add(((short)112), 1);
                ARMOR.Add(((short)113), 2);
                ARMOR.Add(((short)114), 4);
                ARMOR.Add(((short)115), 3);
                ARMOR.Add(((short)116), 1);
                ARMOR.Add(((short)117), 3);
                ARMOR.Add(((short)118), 6);
                ARMOR.Add(((short)119), 5);
                ARMOR.Add(((short)120), 2);
                ARMOR.Add(((short)121), 4);
                ARMOR.Add(((short)122), 7);
                ARMOR.Add(((short)123), 6);
                ARMOR.Add(((short)124), 3);
                ARMOR.Add(((short)125), 5);
                ARMOR.Add(((short)126), 9);
                ARMOR.Add(((short)127), 7);
                ARMOR.Add(((short)128), 4);
                ARMOR.Add(((short)129), 7);
                ARMOR.Add(((short)130), 12);
                ARMOR.Add(((short)131), 10);
                ARMOR.Add(((short)132), 6);
                ARMOR.Add(((short)133), 4);
                ARMOR.Add(((short)134), 7);
                ARMOR.Add(((short)135), 6);
                ARMOR.Add(((short)136), 3);
                ARMOR.Add(((short)137), 2);
                ARMOR.Add(((short)138), 4);
                ARMOR.Add(((short)139), 3);
                ARMOR.Add(((short)140), 1);
                ARMOR.Add(((short)141), 10);
                ARMOR.Add(((short)142), 18);
                ARMOR.Add(((short)143), 14);
                ARMOR.Add(((short)144), 8);

                TOOLDURS = new Dictionary<short, short>();

                TOOLDURS.Add(((short)7), ((short)400));   // copper: P0200 A0200 S0125
                TOOLDURS.Add(((short)8), ((short)500));   // iron:   P0250 A0250 S0150
                TOOLDURS.Add(((short)9), ((short)600));   // silver: P0300 A0300 S0200
                TOOLDURS.Add(((short)10), ((short)800));  // gold:   P0400 A0400 S0300
                TOOLDURS.Add(((short)11), ((short)400));
                TOOLDURS.Add(((short)12), ((short)500));
                TOOLDURS.Add(((short)13), ((short)600));
                TOOLDURS.Add(((short)14), ((short)800));
                TOOLDURS.Add(((short)16), ((short)250));
                TOOLDURS.Add(((short)17), ((short)300));
                TOOLDURS.Add(((short)18), ((short)400));
                TOOLDURS.Add(((short)19), ((short)600));
                TOOLDURS.Add(((short)33), ((short)100));
                TOOLDURS.Add(((short)51), ((short)1100));  // zinc:   P0550 A0550 S0475
                TOOLDURS.Add(((short)52), ((short)1100));
                TOOLDURS.Add(((short)53), ((short)950));
                TOOLDURS.Add(((short)54), ((short)1350));  // rhyme:  P0675 A0675 S0625
                TOOLDURS.Add(((short)55), ((short)1350));
                TOOLDURS.Add(((short)56), ((short)1250));
                TOOLDURS.Add(((short)57), ((short)1600));  // obdur:  P0800 A0800 S0800
                TOOLDURS.Add(((short)58), ((short)1600));
                TOOLDURS.Add(((short)59), ((short)1600));
                TOOLDURS.Add(((short)145), ((short)200)); // alumin: P0100 A0100 S0050
                TOOLDURS.Add(((short)146), ((short)200));
                TOOLDURS.Add(((short)147), ((short)100));
                TOOLDURS.Add(((short)148), ((short)2400));// lead:   P1200 A1200 S0800
                TOOLDURS.Add(((short)149), ((short)2400));
                TOOLDURS.Add(((short)150), ((short)1600));
                TOOLDURS.Add(((short)154), ((short)200)); // wood:   P0100 A0100 S0050
                TOOLDURS.Add(((short)155), ((short)200));
                TOOLDURS.Add(((short)156), ((short)100));
                TOOLDURS.Add(((short)157), ((short)300)); // stone:  P0150 A0150 S0075
                TOOLDURS.Add(((short)158), ((short)300));
                TOOLDURS.Add(((short)159), ((short)150));
                TOOLDURS.Add(((short)169), ((short)1200)); // magne:  P0600 A0600 S0600
                TOOLDURS.Add(((short)170), ((short)1200));
                TOOLDURS.Add(((short)171), ((short)1200));
                TOOLDURS.Add(((short)172), ((short)4000));// irrad:  P2000 A2000 S2000
                TOOLDURS.Add(((short)173), ((short)4000));
                TOOLDURS.Add(((short)174), ((short)4000));
                TOOLDURS.Add(((short)190), ((short)400));

                TOOLDURS.Add(((short)105), ((short)200)); // copper: 0300
                TOOLDURS.Add(((short)106), ((short)200)); // copper: 0300
                TOOLDURS.Add(((short)107), ((short)200)); // copper: 0300
                TOOLDURS.Add(((short)108), ((short)200)); // copper: 0300
                TOOLDURS.Add(((short)109), ((short)200)); // iron:   0400
                TOOLDURS.Add(((short)110), ((short)200)); // iron:   0400
                TOOLDURS.Add(((short)111), ((short)200)); // iron:   0400
                TOOLDURS.Add(((short)112), ((short)200)); // iron:   0400
                TOOLDURS.Add(((short)113), ((short)200)); // silver: 0550
                TOOLDURS.Add(((short)114), ((short)200)); // silver: 0550
                TOOLDURS.Add(((short)115), ((short)200)); // silver: 0550
                TOOLDURS.Add(((short)116), ((short)200)); // silver: 0550
                TOOLDURS.Add(((short)117), ((short)200)); // gold:   0700
                TOOLDURS.Add(((short)118), ((short)200)); // gold:   0700
                TOOLDURS.Add(((short)119), ((short)200)); // gold:   0700
                TOOLDURS.Add(((short)120), ((short)200)); // gold:   0700
                TOOLDURS.Add(((short)121), ((short)200)); // zinc:   0875
                TOOLDURS.Add(((short)122), ((short)200)); // zinc:   0875
                TOOLDURS.Add(((short)123), ((short)200)); // zinc:   0875
                TOOLDURS.Add(((short)124), ((short)200)); // zinc:   0875
                TOOLDURS.Add(((short)125), ((short)200)); // rhyme:  1000
                TOOLDURS.Add(((short)126), ((short)200)); // rhyme:  1000
                TOOLDURS.Add(((short)127), ((short)200)); // rhyme:  1000
                TOOLDURS.Add(((short)128), ((short)200)); // rhyme:  1000
                TOOLDURS.Add(((short)129), ((short)200)); // obdur:  1400
                TOOLDURS.Add(((short)130), ((short)200)); // obdur:  1400
                TOOLDURS.Add(((short)131), ((short)200)); // obdur:  1400
                TOOLDURS.Add(((short)132), ((short)200)); // obdur:  1400
                TOOLDURS.Add(((short)133), ((short)200)); // alumin: 0150
                TOOLDURS.Add(((short)134), ((short)200)); // alumin: 0150
                TOOLDURS.Add(((short)135), ((short)200)); // alumin: 0150
                TOOLDURS.Add(((short)136), ((short)200)); // alumin: 0150
                TOOLDURS.Add(((short)137), ((short)200)); // lead:   2000
                TOOLDURS.Add(((short)138), ((short)200)); // lead:   2000
                TOOLDURS.Add(((short)139), ((short)200)); // lead:   2000
                TOOLDURS.Add(((short)140), ((short)200)); // lead:   2000

                FUELS = new Dictionary<short, Double>();

                FUELS.Add(((short)15), 0.01);
                FUELS.Add(((short)28), 0.001);
                FUELS.Add(((short)160), 0.02);
                FUELS.Add(((short)168), 0.01);
                FUELS.Add(((short)179), 0.0035);
                FUELS.Add(((short)20), 0.0025);
                FUELS.Add(((short)21), 0.00125);
                FUELS.Add(((short)35), 0.02);
                FUELS.Add(((short)36), 0.011);
                FUELS.Add(((short)77), 0.02);
                FUELS.Add(((short)79), 0.02);
                FUELS.Add(((short)81), 0.02);
                FUELS.Add(((short)83), 0.02);
                FUELS.Add(((short)85), 0.02);
                FUELS.Add(((short)87), 0.02);
                FUELS.Add(((short)89), 0.0035);
                FUELS.Add(((short)91), 0.02);
                FUELS.Add(((short)95), 0.02);
                FUELS.Add(((short)78), 0.01);
                FUELS.Add(((short)80), 0.01);
                FUELS.Add(((short)82), 0.01);
                FUELS.Add(((short)84), 0.01);
                FUELS.Add(((short)86), 0.01);
                FUELS.Add(((short)88), 0.01);
                FUELS.Add(((short)90), 0.01);
                FUELS.Add(((short)92), 0.01);
                FUELS.Add(((short)96), 0.01);
                for (i = 97; i < 103; i++)
                {
                    FUELS.Add(((short)i), 0.0035);
                }
                FUELS.Add(((short)154), 0.002);
                FUELS.Add(((short)155), 0.002);
                FUELS.Add(((short)156), 0.00333);

                WIREP = new Dictionary<int, int>();

                WIREP.Add(0, 94);
                WIREP.Add(1, 95);
                WIREP.Add(2, 96);
                WIREP.Add(3, 97);
                WIREP.Add(4, 98);
                WIREP.Add(5, 99);

                TORCHESL = new Dictionary<int, int>();

                TORCHESL.Add(20, 24);
                TORCHESL.Add(21, 26);
                TORCHESL.Add(22, 28);
                TORCHESL.Add(100, 101);
                TORCHESL.Add(105, 107);
                TORCHESL.Add(106, 108);
                TORCHESL.Add(127, 127);
                TORCHESL.Add(128, 128);

                TORCHESR = new Dictionary<int, int>();

                TORCHESR.Add(20, 25);
                TORCHESR.Add(21, 27);
                TORCHESR.Add(22, 29);
                TORCHESR.Add(100, 102);
                TORCHESR.Add(105, 109);
                TORCHESR.Add(106, 110);
                TORCHESR.Add(127, 129);

                TORCHESB = new Dictionary<int, Boolean>();

                for (i = 0; i < blocknames.Length; i++)
                {
                    TORCHESB.Add(i, false);
                }

                TORCHESB.Add(20, true);
                TORCHESB.Add(21, true);
                TORCHESB.Add(22, true);
                TORCHESB.Add(100, true);
                TORCHESB.Add(24, true);
                TORCHESB.Add(26, true);
                TORCHESB.Add(28, true);
                TORCHESB.Add(101, true);
                TORCHESB.Add(25, true);
                TORCHESB.Add(27, true);
                TORCHESB.Add(29, true);
                TORCHESB.Add(102, true);
                TORCHESB.Add(105, true);
                TORCHESB.Add(106, true);
                TORCHESB.Add(107, true);
                TORCHESB.Add(108, true);
                TORCHESB.Add(109, true);
                TORCHESB.Add(110, true);
                TORCHESB.Add(127, true);
                TORCHESB.Add(128, true);
                TORCHESB.Add(129, true);
                TORCHESB.Add(130, true);

                GSUPPORT = new Dictionary<int, Boolean>();

                for (i = 0; i < blocknames.Length; i++)
                {
                    GSUPPORT.Add(i, false);
                }

                GSUPPORT.Add(15, true);
                GSUPPORT.Add(83, true);
                GSUPPORT.Add(20, true);
                GSUPPORT.Add(21, true);
                GSUPPORT.Add(22, true);
                GSUPPORT.Add(77, true);
                GSUPPORT.Add(78, true);
                GSUPPORT.Add(100, true);
                GSUPPORT.Add(105, true);
                GSUPPORT.Add(106, true);
                GSUPPORT.Add(131, true);
                GSUPPORT.Add(132, true);
                GSUPPORT.Add(133, true);
                GSUPPORT.Add(134, true);
                GSUPPORT.Add(135, true);
                GSUPPORT.Add(136, true);

                for (i = 48; i < 73; i++)
                {
                    GSUPPORT.Add(i, true);
                }

                FSPEED = new Dictionary<short, Double>();

                for (i = 0; i < blocknames.Length; i++)
                {
                    FSPEED.Add(((short)i), 0.001);
                }

                FSPEED.Add(((short)85), -0.001);
                FSPEED.Add(((short)86), -0.001);

                DDELAY = new Dictionary<int, int>();

                for (i = 137; i < 145; i++)
                {
                    DDELAY.Add(i, 10);
                }
                for (i = 145; i < 153; i++)
                {
                    DDELAY.Add(i, 20);
                }
                for (i = 153; i < 161; i++)
                {
                    DDELAY.Add(i, 40);
                }
                for (i = 161; i < 169; i++)
                {
                    DDELAY.Add(i, 80);
                }

                sun = loadImage("environment/sun.png");
                moon = loadImage("environment/moon.png");
                FRI1 = new List<short>(0);
                FRN1 = new List<short>(0);
                FRI2 = new List<short>(0);
                FRN2 = new List<short>(0);

                FRI1.Add(((short)3)); FRN1.Add(((short)4)); FRI2.Add(((short)29)); FRN2.Add(((short)1));
                FRI1.Add(((short)4)); FRN1.Add(((short)4)); FRI2.Add(((short)30)); FRN2.Add(((short)1));
                FRI1.Add(((short)5)); FRN1.Add(((short)4)); FRI2.Add(((short)31)); FRN2.Add(((short)1));
                FRI1.Add(((short)6)); FRN1.Add(((short)4)); FRI2.Add(((short)32)); FRN2.Add(((short)1));
                FRI1.Add(((short)38)); FRN1.Add(((short)4)); FRI2.Add(((short)60)); FRN2.Add(((short)1));
                FRI1.Add(((short)39)); FRN1.Add(((short)4)); FRI2.Add(((short)61)); FRN2.Add(((short)1));
                FRI1.Add(((short)40)); FRN1.Add(((short)4)); FRI2.Add(((short)62)); FRN2.Add(((short)1));
                FRI1.Add(((short)41)); FRN1.Add(((short)4)); FRI2.Add(((short)63)); FRN2.Add(((short)1));
                FRI1.Add(((short)42)); FRN1.Add(((short)4)); FRI2.Add(((short)64)); FRN2.Add(((short)1));
                FRI1.Add(((short)43)); FRN1.Add(((short)4)); FRI2.Add(((short)65)); FRN2.Add(((short)1));
                FRI1.Add(((short)44)); FRN1.Add(((short)4)); FRI2.Add(((short)67)); FRN2.Add(((short)1));
                FRI1.Add(((short)45)); FRN1.Add(((short)4)); FRI2.Add(((short)68)); FRN2.Add(((short)1));
                FRI1.Add(((short)46)); FRN1.Add(((short)4)); FRI2.Add(((short)69)); FRN2.Add(((short)1));
                FRI1.Add(((short)47)); FRN1.Add(((short)4)); FRI2.Add(((short)70)); FRN2.Add(((short)1));
                FRI1.Add(((short)48)); FRN1.Add(((short)4)); FRI2.Add(((short)71)); FRN2.Add(((short)1));
                FRI1.Add(((short)49)); FRN1.Add(((short)4)); FRI2.Add(((short)72)); FRN2.Add(((short)1));
                FRI1.Add(((short)50)); FRN1.Add(((short)4)); FRI2.Add(((short)73)); FRN2.Add(((short)1));
                for (i = 8; i > 2; i--)
                {
                    FRI1.Add(((short)74)); FRN1.Add(((short)i)); FRI2.Add(((short)76)); FRN2.Add(((short)i));
                    FRI1.Add(((short)2)); FRN1.Add(((short)i)); FRI2.Add(((short)162)); FRN2.Add(((short)i));
                    FRI1.Add(((short)161)); FRN1.Add(((short)i)); FRI2.Add(((short)163)); FRN2.Add(((short)i));
                    FRI1.Add(((short)165)); FRN1.Add(((short)i)); FRI2.Add(((short)166)); FRN2.Add(((short)i));
                    FRI1.Add(((short)15)); FRN1.Add(((short)i)); FRI2.Add(((short)179)); FRN2.Add(((short)i));
                }
                for (j = 97; j < 103; j++)
                {
                    FRI1.Add(((short)j)); FRN1.Add(((short)1)); FRI2.Add(((short)167)); FRN2.Add(((short)8));
                }

                bg = CYANISH;
                state = "title_screen";

                repaint();

                menuTimer = new Timer(20, null);

                menuTimer.addActionListener((ActionEvent aeOuter) =>
                {
                    try
                    {
                        if (queue[3])
                        {
                            ActionListener mainThread = (ActionEvent ae) =>
                            {
                                try
                                {
                                    if (ready)
                                    {
                                        ready = false;
                                        uNew = (int)((player.x - getWidth() / 2 + player.width) / (double)CHUNKSIZE);
                                        vNew = (int)((player.y - getHeight() / 2 + player.height) / (double)CHUNKSIZE);
                                        if (ou != uNew || ov != vNew)
                                        {
                                            ou = uNew;
                                            ov = vNew;
                                            List<Chunk> chunkTemp = new List<Chunk>(0);
                                            for (twy = 0; twy < 2; twy++)
                                            {
                                                for (twx = 0; twx < 2; twx++)
                                                {
                                                    if (chunkMatrix[twy,twx] != null)
                                                    {
                                                        chunkTemp.Add(chunkMatrix[twy,twx]);
                                                        chunkMatrix[twy,twx] = null;
                                                    }
                                                }
                                            }
                                            for (twy = 0; twy < 2; twy++)
                                            {
                                                for (twx = 0; twx < 2; twx++)
                                                {
                                                    for (i = chunkTemp.Count - 1; i > -1; i--)
                                                    {
                                                        if (chunkTemp[i].cx == twx && chunkTemp[i].cy == twy)
                                                        {
                                                            chunkMatrix[twy,twx] = chunkTemp[i];
                                                            chunkTemp.RemoveAt(i);
                                                            break;
                                                        }
                                                    }
                                                    if (chunkMatrix[twy,twx] == null)
                                                    {
                                                        if (temporarySaveFile[twy,twx] != null)
                                                        {
                                                            chunkMatrix[twy,twx] = temporarySaveFile[twy,twx];
                                                        }
                                                        else
                                                        {
                                                            chunkMatrix[twy,twx] = new Chunk(twx + ou, twy + ov);
                                                        }
                                                    }
                                                }
                                            }
                                            for (i = 0; i < chunkTemp.Count; i++)
                                            {
                                                temporarySaveFile[twy,twx] = chunkTemp[i];
                                            }
                                            chunkTemp = null;
                                            for (twy = 0; twy < 2; twy++)
                                            {
                                                for (twx = 0; twx < 2; twx++)
                                                {
                                                    for (y = 0; y < CHUNKBLOCKS; y++)
                                                    {
                                                        for (x = 0; x < CHUNKBLOCKS; x++)
                                                        {
                                                            for (int l = 0; l < 3; l++)
                                                            {
                                                                blocks[l][twy * CHUNKBLOCKS + y,twx * CHUNKBLOCKS + x] = chunkMatrix[twy,twx].blocks[l][y, x];
                                                                power[l,twy * CHUNKBLOCKS + y,twx * CHUNKBLOCKS + x] = chunkMatrix[twy,twx].power[l,y,x];
                                                                pzqn[l,twy * CHUNKBLOCKS + y,twx * CHUNKBLOCKS + x] = chunkMatrix[twy,twx].pzqn[l,y,x];
                                                                arbprd[l,twy * CHUNKBLOCKS + y,twx * CHUNKBLOCKS + x] = chunkMatrix[twy,twx].arbprd[l,y,x];
                                                                blockds[l][twy * CHUNKBLOCKS + y,twx * CHUNKBLOCKS + x] = chunkMatrix[twy,twx].blockds[l][y,x];
                                                            }
                                                            blockdns[twy * CHUNKBLOCKS + y,twx * CHUNKBLOCKS + x] = chunkMatrix[twy,twx].blockdns[y,x];
                                                            blockbgs[twy * CHUNKBLOCKS + y,twx * CHUNKBLOCKS + x] = chunkMatrix[twy,twx].blockbgs[y,x];
                                                            blockts[twy * CHUNKBLOCKS + y,twx * CHUNKBLOCKS + x] = chunkMatrix[twy,twx].blockts[y,x];
                                                            lights[twy * CHUNKBLOCKS + y,twx * CHUNKBLOCKS + x] = chunkMatrix[twy,twx].lights[y, x];
                                                            lsources[twy * CHUNKBLOCKS + y,twx * CHUNKBLOCKS + x] = chunkMatrix[twy,twx].lsources[y,x];
                                                            zqn[twy * CHUNKBLOCKS + y,twx * CHUNKBLOCKS + x] = chunkMatrix[twy,twx].zqn[y,x];
                                                            wcnct[twy * CHUNKBLOCKS + y,twx * CHUNKBLOCKS + x] = chunkMatrix[twy,twx].wcnct[y,x];
                                                            drawn[twy * CHUNKBLOCKS + y,twx * CHUNKBLOCKS + x] = chunkMatrix[twy,twx].drawn[y,x];
                                                            rdrawn[twy * CHUNKBLOCKS + y,twx * CHUNKBLOCKS + x] = chunkMatrix[twy,twx].rdrawn[y,x];
                                                            ldrawn[twy * CHUNKBLOCKS + y,twx * CHUNKBLOCKS + x] = chunkMatrix[twy,twx].ldrawn[y,x];
                                                        }
                                                    }
                                                    worlds[twy,twx] = null;
                                                }
                                            }
                                        }
                                        u = -ou * CHUNKBLOCKS;
                                        v = -ov * CHUNKBLOCKS;
                                        for (twy = 0; twy < 2; twy++)
                                        {
                                            for (twx = 0; twx < 2; twx++)
                                            {
                                                kworlds[twy,twx] = false;
                                            }
                                        }
                                        bool somevar = false;
                                        for (twy = 0; twy < 2; twy++)
                                        {
                                            for (twx = 0; twx < 2; twx++)
                                            {
                                                int twxc = twx + ou;
                                                int twyc = twy + ov;
                                                if (((player.ix + getWidth() / 2 + player.width >= twxc * CHUNKSIZE &&
                                                      player.ix + getWidth() / 2 + player.width <= twxc * CHUNKSIZE + CHUNKSIZE) ||
                                                     (player.ix - getWidth() / 2 + player.width + BLOCKSIZE >= twxc * CHUNKSIZE &&
                                                      player.ix - getWidth() / 2 + player.width - BLOCKSIZE <= twxc * CHUNKSIZE + CHUNKSIZE)) &&
                                                    ((player.iy + getHeight() / 2 + player.height >= twyc * CHUNKSIZE &&
                                                      player.iy + getHeight() / 2 + player.height <= twyc * CHUNKSIZE + CHUNKSIZE) ||
                                                     (player.iy - getHeight() / 2 + player.height >= twyc * CHUNKSIZE &&
                                                      player.iy - getHeight() / 2 + player.height <= twyc * CHUNKSIZE + CHUNKSIZE)))
                                                {
                                                    kworlds[twy,twx] = true;
                                                    if (worlds[twy,twx] == null)
                                                    {
                                                        worlds[twy,twx] = config.createCompatibleImage(CHUNKSIZE, CHUNKSIZE, Transparency.Translucent);
                                                        fworlds[twy,twx] = config.createCompatibleImage(CHUNKSIZE, CHUNKSIZE, Transparency.Translucent);
                                                        print("Created image at " + twx + " " + twy);
                                                    }
                                                    if (worlds[twy,twx] != null)
                                                    {
                                                        wg2 = worlds[twy,twx].createGraphics();
                                                        fwg2 = fworlds[twy,twx].createGraphics();
                                                        for (tly = Math.Max(twy * CHUNKSIZE, (int)(player.iy - getHeight() / 2 + player.height / 2 + v * BLOCKSIZE) - 64); tly < Math.Min(twy * CHUNKSIZE + CHUNKSIZE, (int)(player.iy + getHeight() / 2 - player.height / 2 + v * BLOCKSIZE) + 128); tly += BLOCKSIZE)
                                                        {
                                                            for (tlx = Math.Max(twx * CHUNKSIZE, (int)(player.ix - getWidth() / 2 + player.width / 2 + u * BLOCKSIZE) - 64); tlx < Math.Min(twx * CHUNKSIZE + CHUNKSIZE, (int)(player.ix + getWidth() / 2 - player.width / 2 + u * BLOCKSIZE) + 112); tlx += BLOCKSIZE)
                                                            {
                                                                tx = (int)(tlx / BLOCKSIZE);
                                                                ty = (int)(tly / BLOCKSIZE);
                                                                if (tx >= 0 && tx < size && ty >= 0 && ty < size)
                                                                {
                                                                    if (!drawn[ty,tx])
                                                                    {
                                                                        somevar = true;
                                                                        blockts[ty,tx] = (byte)random.Next(8);
                                                                        for (y = 0; y < BLOCKSIZE; y++)
                                                                        {
                                                                            for (x = 0; x < BLOCKSIZE; x++)
                                                                            {
                                                                                try
                                                                                {
                                                                                    worlds[twy,twx].setRGB(tx * BLOCKSIZE - twxc * CHUNKSIZE + x, ty * BLOCKSIZE - twyc * CHUNKSIZE + y, 9539985);
                                                                                    fworlds[twy,twx].setRGB(tx * BLOCKSIZE - twxc * CHUNKSIZE + x, ty * BLOCKSIZE - twyc * CHUNKSIZE + y, 9539985);
                                                                                }
                                                                                catch (IndexOutOfRangeException e)
                                                                                {
                                                                                    //
                                                                                }
                                                                            }
                                                                        }
                                                                        if (blockbgs[ty,tx] != 0)
                                                                        {
                                                                            wg2.drawImage(backgroundImgs[blockbgs[ty,tx]],
                                                                                tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                0, 0, IMAGESIZE, IMAGESIZE,
                                                                                null);
                                                                        }
                                                                        for (int l = 0; l < 3; l++)
                                                                        {
                                                                            if (blocks[l][ty,tx] != 0)
                                                                            {
                                                                                if (l == 2)
                                                                                {
                                                                                    fwg2.drawImage(loadBlock(blocks[l][ty,tx], blockds[l][ty,tx], blockdns[ty,tx], blockts[ty,tx], blocknames, dirs, OUTLINES[blocks[l][ty,tx]], tx, ty, l),
                                                                                        tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                        0, 0, IMAGESIZE, IMAGESIZE,
                                                                                        null);
                                                                                }
                                                                                else
                                                                                {
                                                                                    wg2.drawImage(loadBlock(blocks[l][ty,tx], blockds[l][ty,tx], blockdns[ty,tx], blockts[ty,tx], blocknames, dirs, OUTLINES[blocks[l][ty,tx]], tx, ty, l),
                                                                                        tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                        0, 0, IMAGESIZE, IMAGESIZE,
                                                                                        null);
                                                                                }
                                                                            }
                                                                            if (wcnct[ty,tx] && blocks[l][ty,tx] >= 94 && blocks[l][ty,tx] <= 99)
                                                                            {
                                                                                if (l == 2)
                                                                                {
                                                                                    fwg2.drawImage(wcnct_px,
                                                                                        tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                        0, 0, IMAGESIZE, IMAGESIZE,
                                                                                        null);
                                                                                }
                                                                                else
                                                                                {
                                                                                    wg2.drawImage(wcnct_px,
                                                                                        tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                        0, 0, IMAGESIZE, IMAGESIZE,
                                                                                        null);
                                                                                }
                                                                            }
                                                                        }
                                                                        if (!DEBUG_LIGHT)
                                                                        {
                                                                            fwg2.drawImage(LIGHTLEVELS[(int)(float)lights[ty,tx]],
                                                                                tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                0, 0, IMAGESIZE, IMAGESIZE,
                                                                                null);
                                                                        }
                                                                        drawn[ty,tx] = true;
                                                                        rdrawn[ty,tx] = true;
                                                                        ldrawn[ty,tx] = true;
                                                                    }
                                                                    if (!rdrawn[ty,tx])
                                                                    {
                                                                        somevar = true;
                                                                        for (y = 0; y < BLOCKSIZE; y++)
                                                                        {
                                                                            for (x = 0; x < BLOCKSIZE; x++)
                                                                            {
                                                                                try
                                                                                {
                                                                                    worlds[twy,twx].setRGB(tx * BLOCKSIZE - twxc * CHUNKSIZE + x, ty * BLOCKSIZE - twyc * CHUNKSIZE + y, 9539985);
                                                                                    fworlds[twy,twx].setRGB(tx * BLOCKSIZE - twxc * CHUNKSIZE + x, ty * BLOCKSIZE - twyc * CHUNKSIZE + y, 9539985);
                                                                                }
                                                                                catch (IndexOutOfRangeException e)
                                                                                {
                                                                                    //
                                                                                }
                                                                            }
                                                                        }
                                                                        if (blockbgs[ty,tx] != 0)
                                                                        {
                                                                            wg2.drawImage(backgroundImgs[blockbgs[ty,tx]],
                                                                                tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                0, 0, IMAGESIZE, IMAGESIZE,
                                                                                null);
                                                                        }
                                                                        for (int l = 0; l < 3; l++)
                                                                        {
                                                                            if (blocks[l][ty,tx] != 0)
                                                                            {
                                                                                if (l == 2)
                                                                                {
                                                                                    fwg2.drawImage(loadBlock(blocks[l][ty,tx], blockds[l][ty,tx], blockdns[ty,tx], blockts[ty,tx], blocknames, dirs, OUTLINES[blocks[l][ty,tx]], tx, ty, l),
                                                                                        tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                        0, 0, IMAGESIZE, IMAGESIZE,
                                                                                        null);
                                                                                }
                                                                                else
                                                                                {
                                                                                    wg2.drawImage(loadBlock(blocks[l][ty,tx], blockds[l][ty,tx], blockdns[ty,tx], blockts[ty,tx], blocknames, dirs, OUTLINES[blocks[l][ty,tx]], tx, ty, l),
                                                                                        tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                        0, 0, IMAGESIZE, IMAGESIZE,
                                                                                        null);
                                                                                }
                                                                            }
                                                                            if (wcnct[ty,tx] && blocks[l][ty,tx] >= 94 && blocks[l][ty,tx] <= 99)
                                                                            {
                                                                                if (l == 2)
                                                                                {
                                                                                    fwg2.drawImage(wcnct_px,
                                                                                        tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                        0, 0, IMAGESIZE, IMAGESIZE,
                                                                                        null);
                                                                                }
                                                                                else
                                                                                {
                                                                                    wg2.drawImage(wcnct_px,
                                                                                        tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                        0, 0, IMAGESIZE, IMAGESIZE,
                                                                                        null);
                                                                                }
                                                                            }
                                                                        }
                                                                        if (!DEBUG_LIGHT)
                                                                        {
                                                                            fwg2.drawImage(LIGHTLEVELS[(int)(float)lights[ty,tx]],
                                                                                tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                0, 0, IMAGESIZE, IMAGESIZE,
                                                                                null);
                                                                        }
                                                                        drawn[ty,tx] = true;
                                                                        rdrawn[ty,tx] = true;
                                                                        ldrawn[ty,tx] = true;
                                                                    }
                                                                    if (!ldrawn[ty,tx] && random.Next(10) == 0)
                                                                    {
                                                                        somevar = true;
                                                                        for (y = 0; y < BLOCKSIZE; y++)
                                                                        {
                                                                            for (x = 0; x < BLOCKSIZE; x++)
                                                                            {
                                                                                try
                                                                                {
                                                                                    worlds[twy,twx].setRGB(tx * BLOCKSIZE - twxc * CHUNKSIZE + x, ty * BLOCKSIZE - twyc * CHUNKSIZE + y, 9539985);
                                                                                    fworlds[twy,twx].setRGB(tx * BLOCKSIZE - twxc * CHUNKSIZE + x, ty * BLOCKSIZE - twyc * CHUNKSIZE + y, 9539985);
                                                                                }
                                                                                catch (IndexOutOfRangeException e)
                                                                                {
                                                                                    //
                                                                                }
                                                                            }
                                                                        }
                                                                        if (blockbgs[ty,tx] != 0)
                                                                        {
                                                                            wg2.drawImage(backgroundImgs[blockbgs[ty,tx]],
                                                                                tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                0, 0, IMAGESIZE, IMAGESIZE,
                                                                                null);
                                                                        }
                                                                        for (int l = 0; l < 3; l++)
                                                                        {
                                                                            if (blocks[l][ty,tx] != 0)
                                                                            {
                                                                                if (l == 2)
                                                                                {
                                                                                    fwg2.drawImage(loadBlock(blocks[l][ty,tx], blockds[l][ty,tx], blockdns[ty,tx], blockts[ty,tx], blocknames, dirs, OUTLINES[blocks[l][ty,tx]], tx, ty, l),
                                                                                        tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                        0, 0, IMAGESIZE, IMAGESIZE,
                                                                                        null);
                                                                                }
                                                                                else
                                                                                {
                                                                                    wg2.drawImage(loadBlock(blocks[l][ty,tx], blockds[l][ty,tx], blockdns[ty,tx], blockts[ty,tx], blocknames, dirs, OUTLINES[blocks[l][ty,tx]], tx, ty, l),
                                                                                        tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                        0, 0, IMAGESIZE, IMAGESIZE,
                                                                                        null);
                                                                                }
                                                                            }
                                                                            if (wcnct[ty,tx] && blocks[l][ty,tx] >= 94 && blocks[l][ty,tx] <= 99)
                                                                            {
                                                                                if (l == 2)
                                                                                {
                                                                                    fwg2.drawImage(wcnct_px,
                                                                                        tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                        0, 0, IMAGESIZE, IMAGESIZE,
                                                                                        null);
                                                                                }
                                                                                else
                                                                                {
                                                                                    wg2.drawImage(wcnct_px,
                                                                                        tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                        0, 0, IMAGESIZE, IMAGESIZE,
                                                                                        null);
                                                                                }
                                                                            }
                                                                        }
                                                                        if (!DEBUG_LIGHT)
                                                                        {
                                                                            fwg2.drawImage(LIGHTLEVELS[(int)(float)lights[ty,tx]],
                                                                                tx * BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE - twy * CHUNKSIZE, tx * BLOCKSIZE + BLOCKSIZE - twx * CHUNKSIZE, ty * BLOCKSIZE + BLOCKSIZE - twy * CHUNKSIZE,
                                                                                0, 0, IMAGESIZE, IMAGESIZE,
                                                                                null);
                                                                        }
                                                                        drawn[ty,tx] = true;
                                                                        rdrawn[ty,tx] = true;
                                                                        ldrawn[ty,tx] = true;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        if (somevar)
                                        {
                                            print("Drew at least one block.");
                                        }
                                        for (twy = 0; twy < 2; twy++)
                                        {
                                            for (twx = 0; twx < 2; twx++)
                                            {
                                                if (!kworlds[twy,twx] && worlds[twy,twx] != null)
                                                {
                                                    worlds[twy,twx] = null;
                                                    fworlds[twy,twx] = null;
                                                    for (ty = twy * CHUNKBLOCKS; ty < twy * CHUNKBLOCKS + CHUNKBLOCKS; ty++)
                                                    {
                                                        for (tx = twx * CHUNKBLOCKS; tx < twx * CHUNKBLOCKS + CHUNKBLOCKS; tx++)
                                                        {
                                                            if (tx >= 0 && tx < size && ty >= 0 && ty < size)
                                                            {
                                                                drawn[ty,tx] = false;
                                                            }
                                                        }
                                                    }
                                                    print("Destroyed image at " + twx + " " + twy);
                                                }
                                            }
                                        }
                                        updateApp();
                                        updateEnvironment();
                                        player.update(blocks[1], queue, u, v);
                                        if (timeOfDay >= 86400)
                                        {
                                            timeOfDay = 0;
                                            day += 1;
                                        }
                                        repaint();
                                        ready = true;
                                    }
                                }
                                catch (Exception e)
                                {
                                    postError(e);
                                }
                            };
                            timer = new Timer(20, mainThread);

                            if (state.Equals("title_screen") && !menuPressed)
                            {
                                if (mousePos[0] >= 239 && mousePos[0] <= 557)
                                {
                                    if (mousePos[1] >= 213 && mousePos[1] <= 249)
                                    { // singleplayer
                                        findWorlds();
                                        state = "select_world";
                                        repaint();
                                        menuPressed = true;
                                    }
                                }
                            }
                            if (state.Equals("select_world") && !menuPressed)
                            {
                                if (mousePos[0] >= 186 && mousePos[0] <= 615 &&
                                    mousePos[1] >= 458 && mousePos[1] <= 484)
                                { // create new world
                                    state = "new_world";
                                    newWorldName = new TextField(400, "New World");
                                    repaint();
                                    menuPressed = true;
                                }
                                if (mousePos[0] >= 334 && mousePos[0] <= 457 &&
                                    mousePos[1] >= 504 && mousePos[1] <= 530)
                                { // back
                                    state = "title_screen";
                                    repaint();
                                    menuPressed = true;
                                }
                                for (i = 0; i < worldFiles.Count; i++)
                                {
                                    if (mousePos[0] >= 166 && mousePos[0] <= 470 &&
                                        mousePos[1] >= 117 + i * 35 && mousePos[1] <= 152 + i * 35)
                                    { // load world
                                        currentWorld = worldNames[i];
                                        state = "loading_world";
                                        bg = Color.Black;
                                        if (loadWorld(worldFiles[i]))
                                        {
                                            menuTimer.stop();
                                            bg = CYANISH;
                                            state = "ingame";
                                            ready = true;
                                            timer.start();
                                            break;
                                        }
                                    }
                                }
                            }
                            if (state.Equals("new_world") && !menuPressed)
                            {
                                if (mousePos[0] >= 186 && mousePos[0] <= 615 &&
                                    mousePos[1] >= 458 && mousePos[1] <= 484)
                                { // create new world
                                    if (!newWorldName.text.Equals(""))
                                    {
                                        findWorlds();
                                        doGenerateWorld = true;
                                        for (i = 0; i < worldNames.Count; i++)
                                        {
                                            if (newWorldName.text.Equals(worldNames[i]))
                                            {
                                                doGenerateWorld = false;
                                            }
                                        }
                                        if (doGenerateWorld)
                                        {
                                            menuTimer.stop();
                                            bg = Color.Black;
                                            state = "generating_world";
                                            currentWorld = newWorldName.text;
                                            repaint();
                                            ActionListener createWorldThread = (ActionEvent ae) =>
                                            {
                                                try
                                                {
                                                    createNewWorld();
                                                    bg = CYANISH;
                                                    state = "ingame";
                                                    ready = true;
                                                    timer.start();
                                                    createWorldTimer.stop();
                                                }
                                                catch (Exception e)
                                                {
                                                    postError(e);
                                                }
                                            };
                                            createWorldTimer = new Timer(1, createWorldThread);
                                            createWorldTimer.start();
                                        }
                                    }
                                }
                                if (mousePos[0] >= 334 && mousePos[0] <= 457 &&
                                    mousePos[1] >= 504 && mousePos[1] <= 530)
                                { // back
                                    state = "select_world";
                                    repaint();
                                    menuPressed = true;
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        postError(e);
                    }
                });

                menuTimer.start();
            }

            catch (Exception e)
            {
                postError(e);
            }
        }

        public void codeTooLarge()
        {
            int M = int.MaxValue;
            //                     DirStoCopIroSilGolWooWor                  TreLeaFurCoaLum         Fur                     ZinRhyObdAluLeaUraZytZytSilIrrNulMelSkyMagSanSnoGla                                                                        GraJGrSGrMudSSt                  TreCobCStCCoSBrClaCBrVWoTDiTMaTGrZyW
            int[][] durList = new int[][]{ new int[]{0, 2, 4, 4, 4, 4, M, 0, 0, 0, 2, 2, 2, 2, 2, 0, 0, 4, 3, M, 1, 1, 1, 4, 1, 1, 1, 1, 1, 1, 0, M, M, M, 4, M, M, M, M, M, M, M, M, M, M, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 3, 1, 1, 1, 2, 2, 2, 0, 4, 4, 4, 4, 2, 4, 0, 2, M, 2, 1, 1, 1, 1, 1, 1}, // Copper Pick
                           new int[]{0, 2, 4, 4, 4, 4, 4, 0, 0, 0, 2, 2, 2, 2, 2, 0, 0, 4, 3, 4, 1, 1, 1, 4, 1, 1, 1, 1, 1, 1, 0, M, M, M, 4, M, M, M, M, M, M, M, M, 4, 4, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 3, 1, 1, 1, 2, 2, 2, 0, 4, 4, 4, 4, 2, 4, 0, 2, 4, 2, 1, 1, 1, 1, 1, 1}, // Iron Pick
                           new int[]{0, 2, 3, 4, 4, 4, 4, 0, 0, 0, 2, 2, 2, 2, 2, 0, 0, 4, 2, 4, 1, 1, 1, 4, 1, 1, 1, 1, 1, 1, 0, 4, M, M, 3, M, 4, M, M, M, M, M, M, 4, 4, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 1, 1, 1, 2, 2, 2, 0, 3, 3, 3, 3, 2, 3, 0, 2, 4, 2, 1, 1, 1, 1, 1, 1}, // Silver Pick
                           new int[]{0, 2, 3, 3, 3, 4, 4, 0, 0, 0, 2, 2, 2, 2, 2, 0, 0, 3, 2, 4, 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 0, 4, 4, M, 3, 4, 4, M, M, M, M, M, M, 3, 3, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 1, 1, 1, 2, 2, 2, 0, 3, 3, 3, 3, 2, 3, 0, 2, 3, 2, 1, 1, 1, 1, 1, 1}, // Gold Pick
                           new int[]{0, 0, 0, 0, 0, 0, 0, 3, 2, 2, 0, 0, 0, 0, 0, 8, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 8, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 1, 1, 1, 1, 1, 1}, // Copper Axe
                           new int[]{0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 0, 0, 0, 0, 7, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 7, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 1, 1, 1, 1, 1, 1}, // Iron Axe
                           new int[]{0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 0, 0, 0, 0, 7, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 7, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 1, 1, 1, 1, 1, 1}, // Silver Axe
                           new int[]{0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 0, 0, 0, 0, 6, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 6, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 1, 1, 1, 1, 1, 1}, // Gold Axe
                           new int[]{0, 1, 2, 3, 3, 3, 3, 0, 0, 0, 2, 2, 2, 2, 2, 0, 0, 3, 1, 3, 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 0, 4, 4, M, 2, 4, 3, 4, 4, 4, M, M, M, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 2, 2, 2, 0, 2, 2, 2, 2, 1, 2, 0, 1, 3, 1, 1, 1, 1, 1, 1, 1}, // Zinc Pick
                           new int[]{0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 1, 1, 1, 1, 1, 1}, // Zinc Axe
                           new int[]{0, 1, 2, 2, 2, 2, 2, 0, 0, 0, 2, 2, 2, 2, 2, 0, 0, 2, 1, 2, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 0, 3, 3, 4, 1, 3, 2, 3, 3, 3, M, 4, 4, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 0, 2, 2, 2, 2, 1, 2, 0, 1, 2, 1, 1, 1, 1, 1, 1, 1}, // Rhymestone Pick
                           new int[]{0, 0, 0, 0, 0, 0, 0, 1, 2, 2, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1}, // Rhymestone Axe
                           new int[]{0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 2, 2, 2, 2, 2, 0, 0, 2, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 0, 2, 2, 3, 1, 2, 2, 2, 2, 2, 4, 4, 4, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1}, // Obdurite Pick
                           new int[]{0, 0, 0, 0, 0, 0, 0, 1, 2, 2, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1}, // Obdurite Axe
                           new int[]{0, 2, 3, 3, 3, 4, 4, 0, 0, 0, 2, 2, 2, 2, 2, 0, 0, 3, 2, 4, 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 0, 4, 4, M, 3, 4, 4, M, M, M, M, M, M, 3, 3, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 1, 1, 1, 2, 2, 2, 0, 3, 3, 3, 3, 2, 3, 0, 2, 3, 2, 1, 1, 1, 1, 1, 1}, // Aluminum Pick
                           new int[]{0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 0, 0, 0, 0, 6, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 6, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 1, 1, 1, 1, 1, 1}, // Aluminum Axe
                           new int[]{0, 1, 2, 3, 3, 3, 3, 0, 0, 0, 2, 2, 2, 2, 2, 0, 0, 3, 1, 3, 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 0, 4, 4, M, 2, 4, 3, 4, 4, 4, M, M, M, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 2, 2, 2, 0, 2, 2, 2, 2, 1, 2, 0, 1, 3, 1, 1, 1, 1, 1, 1, 1}, // Lead Pick
                           new int[]{0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 1, 1, 1, 1, 1, 1}, // Lead Axe
                           new int[]{0, 4, 6, 6, M, M, M, 0, 0, 0, 4, 4, 4, 4, 4, 0, 0, 6, 5, M, 1, 1, 1, 6, 1, 1, 1, 1, 1, 1, 0, M, M, M, M, M, M, M, M, M, M, M, M, M, M, 4, 4, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4, 4, 4, 4, 5, 1, 1, 1, 4, 4, 4, 0, 6, 6, 6, 6, 4, 6, 0, 4, M, 4, 1, 1, 1, 1, 1, 1}, // Wooden Pick
                           new int[]{0, 0, 0, 0, 0, 0, 0, 5, 4, 4, 0, 0, 0, 0, 0, 15,0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 15,0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 1, 1, 1, 1, 1, 1}, // Wooden Axe
                           new int[]{0, 3, 5, 5, 6, M, M, 0, 0, 0, 3, 3, 3, 3, 3, 0, 0, 5, 4, M, 1, 1, 1, 5, 1, 1, 1, 1, 1, 1, 0, M, M, M, 5, M, M, M, M, M, M, M, M, M, M, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3, 3, 4, 1, 1, 1, 3, 3, 3, 0, 5, 5, 5, 5, 3, 5, 0, 3, M, 3, 1, 1, 1, 1, 1, 1}, // Stone Pick
                           new int[]{0, 0, 0, 0, 0, 0, 0, 4, 3, 3, 0, 0, 0, 0, 0, 11,0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 11,0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 1, 1, 1, 1, 1, 1}, // Stone Axe
                           new int[]{0, 2, 3, 3, 3, 4, 4, 0, 0, 0, 2, 2, 2, 2, 2, 0, 0, 3, 2, 4, 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 0, 4, 4, M, 3, 4, 4, M, M, M, M, M, M, 3, 3, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 1, 1, 1, 2, 2, 2, 0, 3, 3, 3, 3, 2, 3, 0, 2, 3, 2, 1, 1, 1, 1, 1, 1}, // Magnetite Pick
                           new int[]{0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 0, 0, 0, 0, 0, 6, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 6, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 1, 1, 1, 1, 1, 1}, // Magnetite Axe
                           new int[]{0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1}, // Irradium Pick
                           new int[]{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1}};// Irradium Axe

            //                  ZyT      ZyLZyLLev               ZyR                     ZyI                     But         WoP   StP   ZyP   ZyD
            int[][] durLis2 = new int[][]{new int[]{1, 1, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3}, // Copper Pick
                           new int[]{1, 1, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 0, 0, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3}, // Iron Pick
                           new int[]{1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2}, // Silver Pick
                           new int[]{1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2}, // Gold Pick
                           new int[]{1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Copper Axe
                           new int[]{1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Iron Axe
                           new int[]{1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Silver Axe
                           new int[]{1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Gold Axe
                           new int[]{1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2}, // Zinc Pick
                           new int[]{1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Zinc Axe
                           new int[]{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, // Rhymestone Pick
                           new int[]{1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Rhymestone Axe
                           new int[]{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, // Obdurite Pick
                           new int[]{1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Obdurite Axe
                           new int[]{1, 1, 1, 2, 2, 2, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2}, // Aluminum Pick
                           new int[]{1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Aluminum Axe
                           new int[]{1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2}, // Lead Pick
                           new int[]{1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Lead Axe
                           new int[]{1, 1, 1, 5, 5, 5, 1, 1, 1, 1, 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 0, 0, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5}, // Wooden Pick
                           new int[]{1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Wooden Axe
                           new int[]{1, 1, 1, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 0, 0, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4}, // Stone Pick
                           new int[]{1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Stone Axe
                           new int[]{1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2}, // Magnetite Pick
                           new int[]{1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, // Magnetite Axe
                           new int[]{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, // Irradium Pick
                           new int[]{1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};// Irradium Axe

            for (i = 0; i < toolList.Length; i++)
            {
                dur = new Dictionary<int, int>();
                for (j = 0; j < durList[i].Length; j++)
                {
                    dur.Add(j, durList[i][j]);
                }
                for (j = 0; j < durLis2[i].Length; j++)
                {
                    dur.Add(j + 100, durList[i][j]);
                }
                DURABILITY.Add(((short)toolList[i]), dur);
            }
        }

        public void findWorlds()
        {
            //TODO: convert this
            Directory.CreateDirectory("worlds");
            var files = Directory.GetFiles("worlds");
            worldFiles = new List<String>();
            worldNames = new List<String>();
            for (i = 0; i < files.Length; i++)
            {
                if (files[i].EndsWith(".dat"))
                {
                    worldFiles.Add(files[i]);
                    worldNames.Add(files[i].Substring(0, files[i].Length - 4));
                }
            }
        }

        public void createNewWorld()
        {
            temporarySaveFile = new Chunk[WORLDHEIGHT, WORLDWIDTH];
            chunkMatrix = new Chunk[2, 2];

            blocks = new int[3][,];
            for (int i = 0; i < blocks.Length; i++)
                blocks[i] = new int[size, size];
            blockds = new Byte[3][,];
            for (int i = 0; i < blockds.Length; i++)
                blockds[i] = new byte[size, size];
            blockdns = new Byte[size, size];
            blockbgs = new Byte[size, size];
            blockts = new Byte[size, size];
            lights = new float[size, size];
            power = new float[3, size, size];
            lsources = new Boolean[size, size];
            zqn = new Byte[size, size];
            pzqn = new Byte[3, size, size];
            arbprd = new Boolean[3, size, size];
            wcnct = new Boolean[size, size];
            drawn = new Boolean[size, size];
            rdrawn = new Boolean[size, size];
            ldrawn = new Boolean[size, size];

            player = new Player(WIDTH * 0.5 * BLOCKSIZE, 45);

            inventory = new Inventory();

            if (DEBUG_ITEMS != null)
            {
                if (DEBUG_ITEMS.Equals("normal"))
                {
                    inventory.addItem(((short)172), ((short)1));
                    inventory.addItem(((short)173), ((short)1));
                    inventory.addItem(((short)174), ((short)1));
                    inventory.addItem(((short)164), ((short)100));
                    inventory.addItem(((short)35), ((short)100));
                    inventory.addItem(((short)36), ((short)100));
                    inventory.addItem(((short)37), ((short)100));
                    inventory.addItem(((short)20), ((short)5));
                    inventory.addItem(((short)27), ((short)5));
                    inventory.addItem(((short)33), ((short)1));
                    inventory.addItem(((short)28), ((short)100));
                    inventory.addItem(((short)50), ((short)100));
                    inventory.addItem(((short)1), ((short)100));
                    inventory.addItem(((short)2), ((short)100));
                    inventory.addItem(((short)15), ((short)100));
                }
                if (DEBUG_ITEMS.Equals("tools"))
                {
                    inventory.addItem(((short)154), ((short)1));
                    inventory.addItem(((short)155), ((short)1));
                    inventory.addItem(((short)156), ((short)1));
                    inventory.addItem(((short)157), ((short)1));
                    inventory.addItem(((short)158), ((short)1));
                    inventory.addItem(((short)159), ((short)1));
                    inventory.addItem(((short)7), ((short)1));
                    inventory.addItem(((short)11), ((short)1));
                    inventory.addItem(((short)12), ((short)1));
                    inventory.addItem(((short)8), ((short)1));
                    inventory.addItem(((short)13), ((short)1));
                    inventory.addItem(((short)14), ((short)1));
                    inventory.addItem(((short)9), ((short)1));
                    inventory.addItem(((short)16), ((short)1));
                    inventory.addItem(((short)17), ((short)1));
                    inventory.addItem(((short)10), ((short)1));
                    inventory.addItem(((short)18), ((short)1));
                    inventory.addItem(((short)33), ((short)1));
                    inventory.addItem(((short)51), ((short)1));
                    inventory.addItem(((short)52), ((short)1));
                    inventory.addItem(((short)53), ((short)1));
                    inventory.addItem(((short)54), ((short)1));
                    inventory.addItem(((short)55), ((short)1));
                    inventory.addItem(((short)56), ((short)1));
                    inventory.addItem(((short)57), ((short)1));
                    inventory.addItem(((short)58), ((short)1));
                    inventory.addItem(((short)59), ((short)1));
                    inventory.addItem(((short)145), ((short)1));
                    inventory.addItem(((short)146), ((short)1));
                    inventory.addItem(((short)147), ((short)1));
                    inventory.addItem(((short)148), ((short)1));
                    inventory.addItem(((short)149), ((short)1));
                    inventory.addItem(((short)150), ((short)1));
                    inventory.addItem(((short)169), ((short)1));
                    inventory.addItem(((short)170), ((short)1));
                    inventory.addItem(((short)171), ((short)1));
                    inventory.addItem(((short)172), ((short)1));
                    inventory.addItem(((short)173), ((short)1));
                    inventory.addItem(((short)174), ((short)1));

                    inventory.addItem(((short)19), ((short)1));
                }
                if (DEBUG_ITEMS.Equals("testing"))
                {
                    inventory.addItem(((short)172), ((short)1));
                    inventory.addItem(((short)173), ((short)1));
                    inventory.addItem(((short)175), ((short)100));
                    inventory.addItem(((short)15), ((short)100));
                    inventory.addItem(((short)35), ((short)100));
                    inventory.addItem(((short)36), ((short)100));
                    inventory.addItem(((short)37), ((short)100));
                    inventory.addItem(((short)176), ((short)100));
                    inventory.addItem(((short)177), ((short)100));
                    inventory.addItem(((short)178), ((short)100));
                    inventory.addItem(((short)27), ((short)100));
                    inventory.addItem(((short)33), ((short)1));
                    inventory.addItem(((short)86), ((short)100));
                    inventory.addItem(((short)49), ((short)100));
                    inventory.addItem(((short)180), ((short)100));
                    inventory.addItem(((short)181), ((short)100));
                    inventory.addItem(((short)182), ((short)100));
                    inventory.addItem(((short)183), ((short)100));
                    inventory.addItem(((short)184), ((short)100));
                    inventory.addItem(((short)185), ((short)100));
                    inventory.addItem(((short)186), ((short)100));
                    inventory.addItem(((short)187), ((short)100));
                    inventory.addItem(((short)188), ((short)100));
                    inventory.addItem(((short)189), ((short)100));
                    inventory.addItem(((short)190), ((short)1));
                }
            }

            short[] tlist1 = { 0, 0, 0, 0, 0 };
            short[] tlist2 = { 0, 0, 0, 0, 0 };
            short[] tlist3 = { 0, 0, 0, 0, 0 };
            cic = new ItemCollection("cic", tlist1, tlist2, tlist3);
            inventory.renderCollection(cic);

            short[] tlist4 = { 0, 0, 0, 0 };
            short[] tlist5 = { 0, 0, 0, 0 };
            short[] tlist6 = { 0, 0, 0, 0 };
            armor = new ItemCollection("armor", tlist4, tlist5, tlist6);
            inventory.renderCollection(armor);

            toolAngle = 4.7;
            mining = 0;
            miningTool = 0;
            mx = 0; my = 0;
            moveItem = 0; moveNum = 0; moveDur = 0;

            entities = new List<Entity>(0);

            cloudsx = new List<Double>(0);
            cloudsy = new List<Double>(0);
            cloudsv = new List<Double>(0);
            cloudsn = new List<int>(0);

            machinesx = new List<int>(0);
            machinesy = new List<int>(0);

            icmatrix = new ItemCollection[3, HEIGHT, WIDTH];

            worlds = new Image[2,2];
            fworlds = new Image[2,2];
            kworlds = new bool[2,2];

            pqx = new List<int>();
            pqy = new List<int>();

            pmsg("-> Adding light sources...");

            lqx = new List<int>();
            lqy = new List<int>();
            zqx = new List<int>();
            zqy = new List<int>();
            pqx = new List<int>();
            pqy = new List<int>();
            pzqx = new List<int>();
            pzqy = new List<int>();
            updatex = new List<int>();
            updatey = new List<int>();
            updatet = new List<int>();
            updatel = new List<int>();

            for (x = 0; x < WIDTH; x++)
            {
                //            addSunLighting(x, 0);
            }

            for (x = 0; x < WIDTH; x++)
            {
                for (y = 0; y < HEIGHT; y++)
                {
                    //                addBlockLighting(x, y);
                    //                addBlockPower(x, y);
                }
            }

            pmsg("-> Calculating light...");

            resolvePowerMatrix();
            resolveLightMatrix();

            pmsg("Finished generation.");
        }

        public void updateApp()
        {
            mousePos2[0] = mousePos[0] + player.ix - getWidth() / 2 + player.width / 2;
            mousePos2[1] = mousePos[1] + player.iy - getHeight() / 2 + player.height / 2;

            currentSkyLight = skycolors[0];
            for (i = 0; i < skycolors.Length; i++)
            {
                if (timeOfDay >= skycolors[i])
                {
                    currentSkyLight = skycolors[i];
                }
            }
            if (player.y / 16 > HEIGHT * 0.55)
            {
                bg = Color.Black;
            }
            else
            {
                bg = SKYCOLORS[currentSkyLight];
            }

            if (rgnc1 == 0)
            {
                if (rgnc2 == 0)
                {
                    if (player.hp < player.thp)
                    {
                        player.hp += 1;
                        rgnc2 = 125;
                    }
                }
                else
                {
                    rgnc2 -= 1;
                }
            }
            else
            {
                rgnc1 -= 1;
            }

            for (j = 0; j < machinesx.Count; j++)
            {
                x = machinesx[j]; y = machinesy[j];
                for (int l = 0; l < 3; l++)
                {
                    if (icmatrix[l, y, x] != null && icmatrix[l, y, x].type.Equals("furnace"))
                    {
                        if (icmatrix[l, y, x].F_ON)
                        {
                            if (icmatrix[l, y, x].ids[1] == 0)
                            {
                                if (FUELS.ContainsKey(icmatrix[l, y, x].ids[2]))
                                {
                                    inventory.addLocationIC(icmatrix[l, y, x], 1, icmatrix[l, y, x].ids[2], (short)1);
                                    inventory.removeLocationIC(icmatrix[l, y, x], 2, (short)1);
                                    icmatrix[l, y, x].FUELP = 1;
                                }
                                else
                                {
                                    icmatrix[l, y, x].F_ON = false;
                                    removeBlockLighting(x, y);
                                    blocks[l][y, x] = 17;
                                    rdrawn[y, x] = false;
                                }
                            }
                            if (FUELS.ContainsKey(icmatrix[l, y, x].ids[1]))
                            {
                                icmatrix[l, y, x].FUELP -= FUELS[icmatrix[l, y, x].ids[1]];
                                if (icmatrix[l, y, x].FUELP < 0)
                                {
                                    icmatrix[l, y, x].FUELP = 0;
                                    inventory.removeLocationIC(icmatrix[l, y, x], 1, icmatrix[l, y, x].nums[1]);
                                }
                                for (i = 0; i < FRI1.Count; i++)
                                {
                                    if (icmatrix[l, y, x].ids[0] == FRI1[i] && icmatrix[l, y, x].nums[0] >= FRN1[i])
                                    {
                                        icmatrix[l, y, x].SMELTP += FSPEED[icmatrix[l, y, x].ids[1]];
                                        if (icmatrix[l, y, x].SMELTP > 1)
                                        {
                                            icmatrix[l, y, x].SMELTP = 0;
                                            inventory.removeLocationIC(icmatrix[l, y, x], 0, FRN1[i]);
                                            inventory.addLocationIC(icmatrix[l, y, x], 3, FRI2[i], FRN2[i]);
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            icmatrix[l, y, x].SMELTP -= 0.00025;
                            if (icmatrix[l, y, x].SMELTP < 0)
                            {
                                icmatrix[l, y, x].SMELTP = 0;
                            }
                        }
                    }
                }
            }

            if (ic != null && ic.type.Equals("furnace"))
            {
                if (ic.F_ON)
                {
                    if (ic.ids[1] == 0)
                    {
                        if (FUELS.ContainsKey(ic.ids[2]))
                        {
                            inventory.addLocationIC(ic, 1, ic.ids[2], (short)1);
                            inventory.removeLocationIC(ic, 2, (short)1);
                            ic.FUELP = 1;
                        }
                        else
                        {
                            ic.F_ON = false;
                            removeBlockLighting(icx, icy);
                            blocks[iclayer][icy, icx] = 17;
                            rdrawn[icy, icx] = false;
                        }
                    }
                    if (FUELS.ContainsKey(ic.ids[1]))
                    {
                        ic.FUELP -= FUELS[ic.ids[1]];
                        if (ic.FUELP < 0)
                        {
                            ic.FUELP = 0;
                            inventory.removeLocationIC(ic, 1, ic.nums[1]);
                        }
                        for (i = 0; i < FRI1.Count; i++)
                        {
                            if (ic.ids[0] == FRI1[i] && ic.nums[0] >= FRN1[i])
                            {
                                ic.SMELTP += FSPEED[ic.ids[1]];
                                if (ic.SMELTP > 1)
                                {
                                    ic.SMELTP = 0;
                                    inventory.removeLocationIC(ic, 0, FRN1[i]);
                                    inventory.addLocationIC(ic, 3, FRI2[i], FRN2[i]);
                                }
                                break;
                            }
                        }
                    }
                }
                else
                {
                    ic.SMELTP -= 0.00025;
                    if (ic.SMELTP < 0)
                    {
                        ic.SMELTP = 0;
                    }
                }
                inventory.updateIC(ic, -1);
            }
            if (Math.Sqrt(Math.Pow(player.x + player.image.Width - icx * BLOCKSIZE + BLOCKSIZE / 2, 2) + Math.Pow(player.y + player.image.Height - icy * BLOCKSIZE + BLOCKSIZE / 2, 2)) > 160)
            {
                if (ic != null)
                {
                    if (!ic.type.Equals("workbench"))
                    {
                        machinesx.Add(icx);
                        machinesy.Add(icy);
                        icmatrix[iclayer,icy, icx] = new ItemCollection(ic.type, ic.ids, ic.nums, ic.durs);
                    }
                    if (ic.type.Equals("workbench"))
                    {
                        if (player.imgState.Equals("still right") || player.imgState.Equals("walk right 1") || player.imgState.Equals("walk right 2"))
                        {
                            for (i = 0; i < 9; i++)
                            {
                                if (ic.ids[i] != 0)
                                {
                                    entities.Add(new Entity(icx * BLOCKSIZE, icy * BLOCKSIZE, 2, -2, ic.ids[i], ic.nums[i], ic.durs[i], 75));
                                }
                            }
                        }
                        if (player.imgState.Equals("still left") || player.imgState.Equals("walk left 1") || player.imgState.Equals("walk left 2"))
                        {
                            for (i = 0; i < 9; i++)
                            {
                                if (ic.ids[i] != 0)
                                {
                                    entities.Add(new Entity(icx * BLOCKSIZE, icy * BLOCKSIZE, -2, -2, ic.ids[i], ic.nums[i], ic.durs[i], 75));
                                }
                            }
                        }
                    }
                    if (ic.type.Equals("furnace"))
                    {
                        icmatrix[iclayer, icy, icx].FUELP = ic.FUELP;
                        icmatrix[iclayer, icy, icx].SMELTP = ic.SMELTP;
                        icmatrix[iclayer, icy, icx].F_ON = ic.F_ON;
                    }
                    ic = null;
                }
            }

            for (int l = 0; l < 3; l++)
            {
                for (y = 0; y < size; y++)
                {
                    for (x = 0; x < size; x++)
                    {
                        if (random.Next(22500) == 0)
                        {
                            t = 0;
                            switch (blocks[l][y, x])
                            {
                                case 48: if (timeOfDay >= 75913 || timeOfDay < 28883) t = 49; break;
                                case 49: if (timeOfDay >= 75913 || timeOfDay < 28883) t = 50; break;
                                case 51: if (timeOfDay >= 32302 && timeOfDay < 72093) t = 52; break;
                                case 52: if (timeOfDay >= 32302 && timeOfDay < 72093) t = 53; break;
                                case 54: if (checkBiome(x, y).Equals("desert")) t = 55; break;
                                case 55: if (checkBiome(x, y).Equals("desert")) t = 56; break;
                                case 57: if (checkBiome(x, y).Equals("jungle")) t = 58; break;
                                case 58: if (checkBiome(x, y).Equals("jungle")) t = 59; break;
                                case 60: if (checkBiome(x, y).Equals("frost")) t = 61; break;
                                case 61: if (checkBiome(x, y).Equals("frost")) t = 62; break;
                                case 63: if (checkBiome(x, y).Equals("cavern") || y >= 0/*stonelayer[x]*/) t = 64; break;
                                case 64: if (checkBiome(x, y).Equals("cavern") || y >= 0/*stonelayer[x]*/) t = 65; break;
                                case 66: if (y <= HEIGHT * 0.08 && random.Next(3) == 0 || y <= HEIGHT * 0.04) t = 67; break;
                                case 67: if (y <= HEIGHT * 0.08 && random.Next(3) == 0 || y <= HEIGHT * 0.04) t = 68; break;
                                case 69: if (y >= HEIGHT * 0.98) t = 70; break;
                                case 70: if (y >= HEIGHT * 0.98) t = 71; break;
                                case 77: if (checkBiome(x, y).Equals("swamp")) t = 78; break;
                                case 78: if (checkBiome(x, y).Equals("swamp")) t = 79; break;
                                default: break;
                            }
                            if (t != 0)
                            {
                                blocks[l][y, x] = t;
                                drawn[y, x] = false;
                            }
                        }
                    }
                }
            }

            for (int l = 0; l < 3; l++)
            {
                for (y = 0; y < size; y++)
                {
                    for (x = 0; x < size; x++)
                    {
                        if (random.Next(1000) == 0)
                        {
                            if (y >= 1 && y < HEIGHT - 1)
                            {
                                doGrassGrow = false;
                                if (blocks[l][y, x] == 1 && hasOpenSpace(x + u, y + v, l) && blocks[l][y + random.Next(3) - 1 + u, x + random.Next(3) - 1 + v] == 72)
                                {
                                    blocks[l][y, x] = 72;
                                    doGrassGrow = true;
                                }
                                if (blocks[l][y, x] == 1 && hasOpenSpace(x + u, y + v, l) && blocks[l][y + random.Next(3) - 1 + u, x + random.Next(3) - 1 + v] == 73)
                                {
                                    blocks[l][y, x] = 73;
                                    doGrassGrow = true;
                                }
                                if (blocks[l][y, x] == 75 && hasOpenSpace(x + u, y + v, l) && blocks[l][y + random.Next(3) - 1 + u, x + random.Next(3) - 1 + v] == 74)
                                {
                                    blocks[l][y, x] = 74;
                                    doGrassGrow = true;
                                }
                                if (doGrassGrow)
                                {
                                    for (y2 = y - 1; y2 < y + 2; y2++)
                                    {
                                        for (x2 = x - 1; x2 < x + 2; x2++)
                                        {
                                            if (y2 >= 0 && y2 < HEIGHT)
                                            {
                                                drawn[y2, x2] = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for (int l = 0; l < 3; l++)
            {
                for (y = 0; y < size; y++)
                {
                    for (x = 0; x < size; x++)
                    {
                        if (random.Next(1000) == 0)
                        {
                            if (blocks[1][y, x] == 83)
                            {
                                blocks[1][y, x] = 15;
                            }
                        }
                    }
                }
            }

            for (i = updatex.Count - 1; i > -1; i--)
            {
                updatet[i] = updatet[i] - 1;
                if (updatet[i] <= 0)
                {
                    if (blocks[updatel[i]][updatey[i], updatex[i]] == 128)
                    {
                        blockTemp = blocks[updatel[i]][updatey[i], updatex[i]];
                        removeBlockPower(updatex[i], updatey[i], updatel[i]);
                        blocks[updatel[i]][updatey[i], updatex[i]] = 127;
                        rdrawn[updatey[i], updatex[i]] = false;
                    }
                    else if (blocks[updatel[i]][updatey[i], updatex[i]] == 130)
                    {
                        blockTemp = blocks[updatel[i]][updatey[i], updatex[i]];
                        removeBlockPower(updatex[i], updatey[i], updatel[i]);
                        blocks[updatel[i]][updatey[i], updatex[i]] = 129;
                        rdrawn[updatey[i], updatex[i]] = false;
                    }
                    else if (blocks[updatel[i]][updatey[i], updatex[i]] == 132)
                    {
                        blockTemp = blocks[updatel[i]][updatey[i], updatex[i]];
                        removeBlockPower(updatex[i], updatey[i], updatel[i]);
                        blocks[updatel[i]][updatey[i], updatex[i]] = 131;
                        rdrawn[updatey[i], updatex[i]] = false;
                    }
                    else if (blocks[updatel[i]][updatey[i], updatex[i]] == 134)
                    {
                        blockTemp = blocks[updatel[i]][updatey[i], updatex[i]];
                        removeBlockPower(updatex[i], updatey[i], updatel[i]);
                        blocks[updatel[i]][updatey[i], updatex[i]] = 133;
                        rdrawn[updatey[i], updatex[i]] = false;
                    }
                    else if (blocks[updatel[i]][updatey[i], updatex[i]] == 136)
                    {
                        blockTemp = blocks[updatel[i]][updatey[i], updatex[i]];
                        removeBlockPower(updatex[i], updatey[i], updatel[i]);
                        blocks[updatel[i]][updatey[i], updatex[i]] = 135;
                        rdrawn[updatey[i], updatex[i]] = false;
                    }
                    else if (blocks[updatel[i]][updatey[i], updatex[i]] >= 141 && blocks[updatel[i]][updatey[i], updatex[i]] <= 144 || blocks[updatel[i]][updatey[i], updatex[i]] >= 149 && blocks[updatel[i]][updatey[i], updatex[i]] <= 152 ||
                        blocks[updatel[i]][updatey[i], updatex[i]] >= 157 && blocks[updatel[i]][updatey[i], updatex[i]] <= 160 || blocks[updatel[i]][updatey[i], updatex[i]] >= 165 && blocks[updatel[i]][updatey[i], updatex[i]] <= 168)
                    {
                        print("[DEBUG2R]");
                        blockTemp = blocks[updatel[i]][updatey[i], updatex[i]];
                        removeBlockPower(updatex[i], updatey[i], updatel[i], false);
                        blocks[updatel[i]][updatey[i], updatex[i]] -= 4;
                        rdrawn[updatey[i], updatex[i]] = false;
                    }
                    else if (blocks[updatel[i]][updatey[i], updatex[i]] >= 137 && blocks[updatel[i]][updatey[i], updatex[i]] <= 140 || blocks[updatel[i]][updatey[i], updatex[i]] >= 145 && blocks[updatel[i]][updatey[i], updatex[i]] <= 148 ||
                        blocks[updatel[i]][updatey[i], updatex[i]] >= 153 && blocks[updatel[i]][updatey[i], updatex[i]] <= 156 || blocks[updatel[i]][updatey[i], updatex[i]] >= 161 && blocks[updatel[i]][updatey[i], updatex[i]] <= 164)
                    {
                        print("[DEBUG2A]");
                        blocks[updatel[i]][updatey[i], updatex[i]] += 4;
                        power[updatel[i], updatey[i], updatex[i]] = (float)5;
                        addBlockLighting(updatex[i], updatey[i]);
                        addTileToPQueue(updatex[i], updatey[i]);
                        rdrawn[updatey[i], updatex[i]] = false;
                    }
                    updatex.RemoveAt(i);
                    updatey.RemoveAt(i);
                    updatet.RemoveAt(i);
                    updatel.RemoveAt(i);
                }
            }

            if (!DEBUG_PEACEFUL && mobCount < 100)
            {
                if (msi == 1)
                {
                    for (ay = (int)(player.iy / BLOCKSIZE) - 125; ay < (int)(player.iy / BLOCKSIZE) + 125; ay++)
                    {
                        for (ax = (int)(player.ix / BLOCKSIZE) - 125; ax < (int)(player.ix / BLOCKSIZE) + 125; ax++)
                        {
                            if (random.Next((int)(100000 / DEBUG_HOSTILE)) == 0)
                            {
                                xpos = ax + random.Next(20) - 10;
                                ypos = ay + random.Next(20) - 10;
                                xpos2 = ax + random.Next(20) - 10;
                                ypos2 = ay + random.Next(20) - 10;
                                if (xpos > 0 && xpos < WIDTH - 1 && ypos > 0 && ypos < HEIGHT - 1 && (blocks[1][ypos, xpos] == 0 || !blockcds[blocks[1][ypos, xpos]] &&
                                    xpos2 > 0 && xpos2 < WIDTH - 1 && ypos2 > 0 && ypos2 < HEIGHT - 1 && blocks[1][ypos2, xpos2] != 0 && blockcds[blocks[1][ypos2, xpos2]]))
                                {
                                    mobSpawn = null;
                                    if (!checkBiome(xpos, ypos).Equals("underground"))
                                    {
                                        if ((day != 0 || DEBUG_HOSTILE > 1) && (timeOfDay >= 75913 || timeOfDay < 28883))
                                        {
                                            if (random.Next(350) == 0)
                                            {
                                                rnum = random.Next(100);
                                                if (rnum >= 0 && rnum < 45)
                                                {
                                                    mobSpawn = "blue_bubble"; // 45%
                                                }
                                                if (rnum >= 45 && rnum < 85)
                                                {
                                                    mobSpawn = "green_bubble"; // 40%
                                                }
                                                if (rnum >= 85 && rnum < 100)
                                                {
                                                    mobSpawn = "red_bubble"; // 15%
                                                }
                                            }
                                        }
                                        if (timeOfDay >= 32302 && timeOfDay < 72093)
                                        {
                                            if (random.Next(200) == 0)
                                            {
                                                rnum = random.Next(100);
                                                if (rnum >= 0 && rnum < 80)
                                                {
                                                    mobSpawn = "zombie"; // 80%
                                                }
                                                if (rnum >= 80 && rnum < 90)
                                                {
                                                    mobSpawn = "armored_zombie"; // 10%
                                                }
                                                if (rnum >= 90 && rnum < 100)
                                                {
                                                    mobSpawn = "shooting_star"; // 10%
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (random.Next(100) == 0)
                                        {
                                            rnum = random.Next(100);
                                            if (rnum >= 0 && rnum < 25)
                                            {
                                                mobSpawn = "yellow_bubble"; // 25%
                                            }
                                            if (rnum >= 25 && rnum < 45)
                                            {
                                                mobSpawn = "zombie"; // 20%
                                            }
                                            if (rnum >= 45 && rnum < 60)
                                            {
                                                mobSpawn = "armored_zombie"; // 15%
                                            }
                                            if (rnum >= 60 && rnum < 70)
                                            {
                                                mobSpawn = "black_bubble"; // 10%
                                            }
                                            if (rnum >= 70 && rnum < 85)
                                            {
                                                mobSpawn = "bat"; // 15%
                                            }
                                            if (rnum >= 85 && rnum < 100)
                                            {
                                                mobSpawn = "skeleton"; // 15%
                                            }
                                        }
                                    }
                                    if (mobSpawn != null && checkBiome(xpos, ypos).Equals("desert"))
                                    {
                                        if (random.Next(3) == 0)
                                        { // 33% of all spawns in desert
                                            mobSpawn = "sandbot";
                                        }
                                    }
                                    if (mobSpawn != null && checkBiome(xpos, ypos).Equals("frost"))
                                    {
                                        if (random.Next(3) == 0)
                                        { // 33% of all spawns in desert
                                            mobSpawn = "snowman";
                                        }
                                    }
                                    /*                                if (mobSpawn != null && player.y <= HEIGHT*0.08*BLOCKSIZE) {
                                                                        mobSpawn = "white_bubble"; // 100% of all spawns in sky
                                                                    }
                                    */
                                    if (mobSpawn == null)
                                    {
                                        continue;
                                    }
                                    else if (DEBUG_MOBTEST != null) mobSpawn = DEBUG_MOBTEST;
                                    if (mobSpawn.Equals("blue_bubble") || mobSpawn.Equals("green_bubble") || mobSpawn.Equals("red_bubble") || mobSpawn.Equals("yellow_bubble") || mobSpawn.Equals("black_bubble") || mobSpawn.Equals("white_bubble"))
                                    {
                                        xmax = 2;
                                        ymax = 2;
                                    }
                                    if (mobSpawn.Equals("zombie"))
                                    {
                                        xmax = 2;
                                        ymax = 3;
                                    }
                                    if (mobSpawn.Equals("armored_zombie"))
                                    {
                                        xmax = 2;
                                        ymax = 3;
                                    }
                                    if (mobSpawn.Equals("shooting_star"))
                                    {
                                        xmax = 2;
                                        ymax = 2;
                                    }
                                    if (mobSpawn.Equals("sandbot"))
                                    {
                                        xmax = 2;
                                        ymax = 2;
                                    }
                                    if (mobSpawn.Equals("snowman"))
                                    {
                                        xmax = 2;
                                        ymax = 3;
                                    }
                                    if (mobSpawn.Equals("bat"))
                                    {
                                        xmax = 1;
                                        ymax = 1;
                                    }
                                    if (mobSpawn.Equals("bee"))
                                    {
                                        xmax = 1;
                                        ymax = 1;
                                    }
                                    if (mobSpawn.Equals("skeleton"))
                                    {
                                        xmax = 1;
                                        ymax = 3;
                                    }
                                    doMobSpawn = true;
                                    for (x = (int)(xpos / BLOCKSIZE); x < (int)(xpos / BLOCKSIZE + xmax); x++)
                                    {
                                        for (y = (int)(ypos / BLOCKSIZE); y < (int)(ypos / BLOCKSIZE + ymax); y++)
                                        {
                                            if (y > 0 && y < HEIGHT - 1 && blocks[1][y, x] != 0 && blockcds[blocks[1][y, x]])
                                            {
                                                doMobSpawn = false;
                                            }
                                        }
                                    }
                                    if (doMobSpawn)
                                    {
                                        entities.Add(new Entity(xpos * BLOCKSIZE, ypos * BLOCKSIZE, 0, 0, mobSpawn));
                                    }
                                }
                            }
                        }
                    }
                    msi = 0;
                }
                else
                {
                    msi = 1;
                }
            }

            mobCount = 0;

            for (i = entities.Count - 1; i > -1; i--)
            {
                if (entities[i].name != null)
                {
                    mobCount += 1;
                    if (entities[i].ix < player.ix - 2000 || entities[i].ix > player.ix + 2000 ||
                        entities[i].iy < player.iy - 2000 || entities[i].iy > player.iy + 2000)
                    {
                        if (random.Next(500) == 0)
                        {
                            entities.RemoveAt(i);
                        }
                    }
                }
            }

            if (queue[3])
            {
                checkBlocks = true;
                if (showInv)
                {
                    if (mousePos[0] >= getWidth() - save_exit.Width - 24 && mousePos[0] <= getWidth() - 24 &&
                        mousePos[1] >= getHeight() - save_exit.Height - 24 && mousePos[1] <= getHeight() - 24)
                    {
                        if (mouseClicked)
                        {
                            mouseNoLongerClicked = true;
                            saveWorld();
                            state = "title_screen";
                            timer.stop();
                            menuTimer.start();
                            return;
                        }
                    }
                    for (ux = 0; ux < 10; ux++)
                    {
                        for (uy = 0; uy < 4; uy++)
                        {
                            if (mousePos[0] >= ux * 46 + 6 && mousePos[0] < ux * 46 + 46 &&
                                mousePos[1] >= uy * 46 + 6 && mousePos[1] < uy * 46 + 46)
                            {
                                checkBlocks = false;
                                if (mouseClicked)
                                {
                                    mouseNoLongerClicked = true;
                                    if (uy != 0 || inventory.selection != ux || !showTool)
                                    {
                                        moveItemTemp = inventory.ids[uy * 10 + ux];
                                        moveNumTemp = inventory.nums[uy * 10 + ux];
                                        moveDurTemp = inventory.durs[uy * 10 + ux];
                                        if (moveItem == inventory.ids[uy * 10 + ux])
                                        {
                                            moveNum = (short)inventory.addLocation(uy * 10 + ux, moveItem, moveNum, moveDur);
                                            if (moveNum == 0)
                                            {
                                                moveItem = 0;
                                                moveDur = 0;
                                            }
                                        }
                                        else
                                        {
                                            inventory.removeLocation(uy * 10 + ux, inventory.nums[uy * 10 + ux]);
                                            if (moveItem != 0)
                                            {
                                                inventory.addLocation(uy * 10 + ux, moveItem, moveNum, moveDur);
                                            }
                                            moveItem = moveItemTemp;
                                            moveNum = moveNumTemp;
                                            moveDur = moveDurTemp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    for (ux = 0; ux < 2; ux++)
                    {
                        for (uy = 0; uy < 2; uy++)
                        {
                            if (mousePos[0] >= inventory.image.Width + ux * 40 + 75 &&
                                mousePos[0] < inventory.image.Width + ux * 40 + 115 &&
                                mousePos[1] >= uy * 40 + 52 && mousePos[1] < uy * 40 + 92)
                            {
                                checkBlocks = false;
                                if (mouseClicked)
                                {
                                    mouseNoLongerClicked = true;
                                    moveItemTemp = cic.ids[uy * 2 + ux];
                                    moveNumTemp = cic.nums[uy * 2 + ux];
                                    moveDurTemp = cic.durs[uy * 2 + ux];
                                    if (moveItem == cic.ids[uy * 2 + ux])
                                    {
                                        moveNum = (short)inventory.addLocationIC(cic, uy * 2 + ux, moveItem, moveNum, moveDur);
                                        if (moveNum == 0)
                                        {
                                            moveItem = 0;
                                            moveDur = 0;
                                        }
                                    }
                                    else
                                    {
                                        inventory.removeLocationIC(cic, uy * 2 + ux, cic.nums[uy * 2 + ux]);
                                        if (moveItem != 0)
                                        {
                                            inventory.addLocationIC(cic, uy * 2 + ux, moveItem, moveNum, moveDur);
                                        }
                                        moveItem = moveItemTemp;
                                        moveNum = moveNumTemp;
                                        moveDur = moveDurTemp;
                                    }
                                }
                            }
                        }
                    }
                    if (mousePos[0] >= inventory.image.Width + 3 * 40 + 81 &&
                        mousePos[0] < inventory.image.Width + 3 * 40 + 121 &&
                        mousePos[1] >= 20 + 52 && mousePos[1] < 20 + 92)
                    {
                        checkBlocks = false;
                        if (mouseClicked)
                        {
                            if (moveItem == cic.ids[4] && moveNum + cic.nums[4] <= MAXSTACKS[cic.ids[4]])
                            {
                                moveNum += cic.nums[4];
                                inventory.useRecipeCIC(cic);
                            }
                            if (moveItem == 0)
                            {
                                moveItem = cic.ids[4];
                                moveNum = cic.nums[4];
                                if (TOOLDURS.ContainsKey(moveItem))
                                {
                                    moveDur = TOOLDURS[moveItem];
                                }
                                inventory.useRecipeCIC(cic);
                            }
                        }
                    }
                    if (ic != null)
                    {
                        if (ic.type.Equals("workbench"))
                        {
                            for (ux = 0; ux < 3; ux++)
                            {
                                for (uy = 0; uy < 3; uy++)
                                {
                                    if (mousePos[0] >= ux * 40 + 6 && mousePos[0] < ux * 40 + 46 &&
                                        mousePos[1] >= uy * 40 + inventory.image.Height + 46 &&
                                        mousePos[1] < uy * 40 + inventory.image.Height + 86)
                                    {
                                        checkBlocks = false;
                                        if (mouseClicked)
                                        {
                                            mouseNoLongerClicked = true;
                                            moveItemTemp = ic.ids[uy * 3 + ux];
                                            moveNumTemp = ic.nums[uy * 3 + ux];
                                            if (moveItem == ic.ids[uy * 3 + ux])
                                            {
                                                moveNum = (short)inventory.addLocationIC(ic, uy * 3 + ux, moveItem, moveNum, moveDur);
                                                if (moveNum == 0)
                                                {
                                                    moveItem = 0;
                                                }
                                            }
                                            else
                                            {
                                                inventory.removeLocationIC(ic, uy * 3 + ux, ic.nums[uy * 3 + ux]);
                                                if (moveItem != 0)
                                                {
                                                    inventory.addLocationIC(ic, uy * 3 + ux, moveItem, moveNum, moveDur);
                                                }
                                                moveItem = moveItemTemp;
                                                moveNum = moveNumTemp;
                                            }
                                        }
                                    }
                                }
                            }
                            if (mousePos[0] >= 4 * 40 + 6 && mousePos[0] < 4 * 40 + 46 &&
                                mousePos[1] >= 1 * 40 + inventory.image.Height + 46 &&
                                mousePos[1] < 1 * 40 + inventory.image.Height + 86)
                            {
                                checkBlocks = false;
                                if (mouseClicked)
                                {
                                    if (moveItem == ic.ids[9] && moveNum + ic.nums[9] <= MAXSTACKS[ic.ids[9]])
                                    {
                                        moveNum += ic.nums[9];
                                        inventory.useRecipeWorkbench(ic);
                                    }
                                    if (moveItem == 0)
                                    {
                                        moveItem = ic.ids[9];
                                        moveNum = ic.nums[9];
                                        if (TOOLDURS.ContainsKey(moveItem))
                                        {
                                            moveDur = TOOLDURS[moveItem];
                                        }
                                        inventory.useRecipeWorkbench(ic);
                                    }
                                }
                            }
                        }
                        if (ic.type.Equals("wooden_chest") || ic.type.Equals("stone_chest") ||
                            ic.type.Equals("copper_chest") || ic.type.Equals("iron_chest") ||
                            ic.type.Equals("silver_chest") || ic.type.Equals("gold_chest") ||
                            ic.type.Equals("zinc_chest") || ic.type.Equals("rhymestone_chest") ||
                            ic.type.Equals("obdurite_chest"))
                        {
                            for (ux = 0; ux < inventory.CX; ux++)
                            {
                                for (uy = 0; uy < inventory.CY; uy++)
                                {
                                    if (mousePos[0] >= ux * 46 + 6 && mousePos[0] < ux * 46 + 46 &&
                                        mousePos[1] >= uy * 46 + inventory.image.Height + 46 &&
                                        mousePos[1] < uy * 46 + inventory.image.Height + 86)
                                    {
                                        checkBlocks = false;
                                        if (mouseClicked)
                                        {
                                            mouseNoLongerClicked = true;
                                            moveItemTemp = ic.ids[uy * inventory.CX + ux];
                                            moveNumTemp = ic.nums[uy * inventory.CX + ux];
                                            if (moveItem == ic.ids[uy * inventory.CX + ux])
                                            {
                                                moveNum = (short)inventory.addLocationIC(ic, uy * inventory.CX + ux, moveItem, moveNum, moveDur);
                                                if (moveNum == 0)
                                                {
                                                    moveItem = 0;
                                                }
                                            }
                                            else
                                            {
                                                inventory.removeLocationIC(ic, uy * inventory.CX + ux, ic.nums[uy * inventory.CX + ux]);
                                                if (moveItem != 0)
                                                {
                                                    inventory.addLocationIC(ic, uy * inventory.CX + ux, moveItem, moveNum, moveDur);
                                                }
                                                moveItem = moveItemTemp;
                                                moveNum = moveNumTemp;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (ic.type.Equals("furnace"))
                        {
                            if (mousePos[0] >= 6 && mousePos[0] < 46 &&
                                mousePos[1] >= inventory.image.Height + 46 &&
                                mousePos[1] < inventory.image.Height + 86)
                            {
                                checkBlocks = false;
                                if (mouseClicked)
                                {
                                    mouseNoLongerClicked = true;
                                    moveItemTemp = ic.ids[0];
                                    moveNumTemp = ic.nums[0];
                                    if (moveItem == ic.ids[0])
                                    {
                                        moveNum = (short)inventory.addLocationIC(ic, 0, moveItem, moveNum, moveDur);
                                        if (moveNum == 0)
                                        {
                                            moveItem = 0;
                                        }
                                    }
                                    else
                                    {
                                        inventory.removeLocationIC(ic, 0, ic.nums[0]);
                                        if (moveItem != 0)
                                        {
                                            inventory.addLocationIC(ic, 0, moveItem, moveNum, moveDur);
                                        }
                                        moveItem = moveItemTemp;
                                        moveNum = moveNumTemp;
                                        ic.SMELTP = 0;
                                    }
                                }
                            }
                            if (mousePos[0] >= 6 && mousePos[0] < 46 &&
                                mousePos[1] >= inventory.image.Height + 142 &&
                                mousePos[1] < inventory.image.Height + 182)
                            {
                                checkBlocks = false;
                                if (mouseClicked)
                                {
                                    mouseNoLongerClicked = true;
                                    moveItemTemp = ic.ids[2];
                                    moveNumTemp = ic.nums[2];
                                    if (moveItem == ic.ids[2])
                                    {
                                        moveNum = (short)inventory.addLocationIC(ic, 2, moveItem, moveNum, moveDur);
                                        if (moveNum == 0)
                                        {
                                            moveItem = 0;
                                        }
                                    }
                                    else
                                    {
                                        inventory.removeLocationIC(ic, 2, ic.nums[2]);
                                        if (moveItem != 0)
                                        {
                                            inventory.addLocationIC(ic, 2, moveItem, moveNum, moveDur);
                                        }
                                        moveItem = moveItemTemp;
                                        moveNum = moveNumTemp;
                                    }
                                }
                            }
                            if (mousePos[0] >= 62 && mousePos[0] < 102 &&
                                mousePos[1] >= inventory.image.Height + 46 &&
                                mousePos[1] < inventory.image.Height + 86)
                            {
                                checkBlocks = false;
                                if (mouseClicked)
                                {
                                    mouseNoLongerClicked = true;
                                    if (moveItem == 0)
                                    {
                                        moveItem = ic.ids[3];
                                        moveNum = ic.nums[3];
                                        inventory.removeLocationIC(ic, 3, ic.nums[3]);
                                    }
                                    else if (moveItem == ic.ids[3])
                                    {
                                        moveNum += ic.nums[3];
                                        inventory.removeLocationIC(ic, 3, ic.nums[3]);
                                        if (moveNum > MAXSTACKS[moveItem])
                                        {
                                            inventory.addLocationIC(ic, 3, moveItem, (short)(moveNum - MAXSTACKS[moveItem]), moveDur);
                                            moveNum = MAXSTACKS[moveItem];
                                        }
                                    }
                                }
                            }
                        }
                    }
                    for (uy = 0; uy < 4; uy++)
                    {
                        if (mousePos[0] >= inventory.image.Width + 6 && mousePos[0] < inventory.image.Width + 6 + armor.image.Width &&
                            mousePos[1] >= 6 + uy * 46 && mousePos[1] < 6 + uy * 46 + 40)
                        {
                            checkBlocks = false;
                            if (mouseClicked)
                            {
                                mouseNoLongerClicked = true;
                                i = uy;
                                if (uy == 0 && (moveItem == (short)105 || moveItem == (short)109 || moveItem == (short)113 || moveItem == (short)117 ||
                                                moveItem == (short)121 || moveItem == (short)125 || moveItem == (short)129 || moveItem == (short)133 ||
                                                moveItem == (short)137 || moveItem == (short)141) ||
                                    uy == 1 && (moveItem == (short)106 || moveItem == (short)110 || moveItem == (short)114 || moveItem == (short)118 ||
                                                moveItem == (short)122 || moveItem == (short)126 || moveItem == (short)130 || moveItem == (short)134 ||
                                                moveItem == (short)138 || moveItem == (short)142) ||
                                    uy == 2 && (moveItem == (short)107 || moveItem == (short)111 || moveItem == (short)115 || moveItem == (short)119 ||
                                                moveItem == (short)123 || moveItem == (short)127 || moveItem == (short)131 || moveItem == (short)135 ||
                                                moveItem == (short)139 || moveItem == (short)143) ||
                                    uy == 3 && (moveItem == (short)108 || moveItem == (short)112 || moveItem == (short)116 || moveItem == (short)120 ||
                                                moveItem == (short)124 || moveItem == (short)128 || moveItem == (short)132 || moveItem == (short)136 ||
                                                moveItem == (short)140 || moveItem == (short)144))
                                {
                                    if (armor.ids[i] == 0)
                                    {
                                        inventory.addLocationIC(armor, i, moveItem, moveNum, moveDur);
                                        moveItem = 0;
                                        moveNum = 0;
                                    }
                                    else
                                    {
                                        moveItemTemp = armor.ids[i];
                                        moveNumTemp = armor.nums[i];
                                        inventory.removeLocationIC(armor, i, moveNumTemp);
                                        inventory.addLocationIC(armor, i, moveItem, moveNum, moveDur);
                                        moveItem = moveItemTemp;
                                        moveNum = moveNumTemp;
                                    }
                                }
                                else if (moveItem == 0)
                                {
                                    moveItem = armor.ids[i];
                                    moveNum = armor.nums[i];
                                    inventory.removeLocationIC(armor, i, moveNum);
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (ux = 0; ux < 10; ux++)
                    {
                        uy = 0;
                        if (mousePos[0] >= ux * 46 + 6 && mousePos[0] < ux * 46 + 46 &&
                            mousePos[1] >= uy * 46 + 6 && mousePos[1] < uy * 46 + 46)
                        {
                            checkBlocks = false;
                            if (mouseClicked)
                            {
                                mouseNoLongerClicked = true;
                                inventory.select2(ux);
                            }
                        }
                    }
                }
                if (mouseNoLongerClicked)
                {
                    mouseClicked = false;
                }
                if (checkBlocks)
                {
                    if (inventory.tool() != 0 && !showTool)
                    {
                        tool = itemImgs[inventory.tool()];
                        for (i = 0; i < entities.Count; i++)
                        {
                            entities[i].immune = false;
                        }
                        toolSpeed = TOOLSPEED[inventory.tool()];
                        if (inventory.tool() == 169 || inventory.tool() == 170 || inventory.tool() == 171)
                        {
                            toolSpeed *= ((double)inventory.durs[inventory.selection] / TOOLDURS[inventory.ids[inventory.selection]]) * (-0.714) + 1;
                        }
                        showTool = true;
                        toolAngle = 4.7;
                        ux = (int)(mousePos2[0] / BLOCKSIZE);
                        uy = (int)(mousePos2[1] / BLOCKSIZE);
                        ux2 = (int)(mousePos2[0] / BLOCKSIZE);
                        uy2 = (int)(mousePos2[1] / BLOCKSIZE);
                        if (Math.Sqrt(Math.Pow(player.x + player.image.Width - ux2 * BLOCKSIZE + BLOCKSIZE / 2, 2) + Math.Pow(player.y + player.image.Height - uy2 * BLOCKSIZE + BLOCKSIZE / 2, 2)) <= 160 ||
                            Math.Sqrt(Math.Pow(player.x + player.image.Width - ux2 * BLOCKSIZE + BLOCKSIZE / 2 + WIDTH * BLOCKSIZE, 2) + Math.Pow(player.y + player.image.Height - uy2 * BLOCKSIZE + BLOCKSIZE / 2, 2)) <= 160 || DEBUG_REACH)
                        {
                            ucx = ux - CHUNKBLOCKS * ((int)(ux / CHUNKBLOCKS));
                            ucy = uy - CHUNKBLOCKS * ((int)(uy / CHUNKBLOCKS));
                            if (toolList.Contains(inventory.tool()))
                            {
                                if (blocks[layer][uy, ux] != 0 && BLOCKTOOLS[blocks[layer][uy, ux]].Contains(inventory.tool()))
                                {
                                    blockdns[uy, ux] = (byte)random.Next(5);
                                    drawn[uy, ux] = false;
                                    if (ux == mx && uy == my && inventory.tool() == miningTool)
                                    {
                                        mining += 1;
                                        inventory.durs[inventory.selection] -= 1;
                                        breakCurrentBlock();
                                        if (inventory.durs[inventory.selection] <= 0)
                                        {
                                            inventory.removeLocation(inventory.selection, inventory.nums[inventory.selection]);
                                        }
                                    }
                                    else
                                    {
                                        mining = 1;
                                        miningTool = inventory.tool();
                                        inventory.durs[inventory.selection] -= 1;
                                        breakCurrentBlock();
                                        mx = ux;
                                        my = uy;
                                        if (inventory.durs[inventory.selection] <= 0)
                                        {
                                            inventory.removeLocation(inventory.selection, inventory.nums[inventory.selection]);
                                        }
                                    }
                                    ug2 = null;
                                }
                            }
                            else if (inventory.tool() == 33)
                            {
                                if (blocks[layer][uy, ux] == 17 || blocks[layer][uy, ux] == 23)
                                {
                                    if (icmatrix[layer, uy, ux] != null && icmatrix[layer, uy, ux].type.Equals("furnace"))
                                    {
                                        inventory.durs[inventory.selection] -= 1;
                                        icmatrix[layer, uy, ux].F_ON = true;
                                        blocks[layer][uy, ux] = 23;
                                        addBlockLighting(ux, uy);
                                        if (inventory.durs[inventory.selection] <= 0)
                                        {
                                            inventory.removeLocation(inventory.selection, inventory.nums[inventory.selection]);
                                        }
                                        rdrawn[uy, ux] = false;
                                    }
                                    else
                                    {
                                        if (ic != null && ic.type.Equals("furnace"))
                                        {
                                            inventory.durs[inventory.selection] -= 1;
                                            ic.F_ON = true;
                                            blocks[layer][icy, icx] = 23;
                                            addBlockLighting(ux, uy);
                                            rdrawn[icy, icx] = false;
                                            if (inventory.durs[inventory.selection] <= 0)
                                            {
                                                inventory.removeLocation(inventory.selection, inventory.nums[inventory.selection]);
                                            }
                                        }
                                    }
                                }
                            }
                            else if (inventory.tool() == 190)
                            {
                                if (blocks[layer][uy, ux] >= 137 && blocks[layer][uy, ux] <= 160)
                                {
                                    inventory.durs[inventory.selection] -= 1;
                                    blocks[layer][uy, ux] += 8;
                                    rdrawn[uy, ux] = false;
                                    if (inventory.durs[inventory.selection] <= 0)
                                    {
                                        inventory.removeLocation(inventory.selection, inventory.nums[inventory.selection]);
                                    }
                                }
                                else if (blocks[layer][uy, ux] >= 161 && blocks[layer][uy, ux] <= 168)
                                {
                                    inventory.durs[inventory.selection] -= 1;
                                    blocks[layer][uy, ux] -= 24;
                                    rdrawn[uy, ux] = false;
                                    if (inventory.durs[inventory.selection] <= 0)
                                    {
                                        inventory.removeLocation(inventory.selection, inventory.nums[inventory.selection]);
                                    }
                                }
                            }
                            else if (ITEMBLOCKS.ContainsKey(inventory.tool()))//TODO: This was else if (ITEMBLOCKS.get(inventory.tool()) != 0)
                            {
                                blockTemp = ITEMBLOCKS[inventory.tool()];
                                if (uy >= 1 && (blocks[layer][uy, ux] == 0) &&
                                        (layer == 0 && (
                                        blocks[layer][uy, ux - 1] != 0 || blocks[layer][uy, ux + 1] != 0 ||
                                        blocks[layer][uy - 1, ux] != 0 || blocks[layer][uy + 1, ux] != 0 ||
                                        blocks[layer + 1][uy, ux] != 0) ||
                                        layer == 1 && (
                                        blocks[layer][uy, ux - 1] != 0 || blocks[layer][uy, ux + 1] != 0 ||
                                        blocks[layer][uy - 1, ux] != 0 || blocks[layer][uy + 1, ux] != 0 ||
                                        blocks[layer - 1][uy, ux] != 0 || blocks[layer + 1][uy, ux] != 0) ||
                                        layer == 2 && (
                                        blocks[layer][uy, ux - 1] != 0 || blocks[layer][uy, ux + 1] != 0 ||
                                        blocks[layer][uy - 1, ux] != 0 || blocks[layer][uy + 1, ux] != 0 ||
                                        blocks[layer - 1][uy, ux] != 0)) &&
                                        !(blockTemp == 48 && (blocks[layer][uy + 1, ux] != 1 && blocks[layer][uy + 1, ux] != 72 && blocks[layer][uy + 1, ux] != 73) || // sunflower
                                                          blockTemp == 51 && (blocks[layer][uy + 1, ux] != 1 && blocks[layer][uy + 1, ux] != 72 && blocks[layer][uy + 1, ux] != 73) || // moonflower
                                                          blockTemp == 54 && (blocks[layer][uy + 1, ux] != 45) || // dryweed
                                                          blockTemp == 57 && (blocks[layer][uy + 1, ux] != 73) || // greenleaf
                                                          blockTemp == 60 && (blocks[layer][uy + 1, ux] != 46) || // frostleaf
                                                          blockTemp == 63 && (blocks[layer][uy + 1, ux] != 2) || // caveroot
                                                          blockTemp == 66 && (blocks[layer][uy + 1, ux] != 1 && blocks[layer][uy + 1, ux] != 72 && blocks[layer][uy + 1, ux] != 73) || // skyblossom
                                                          blockTemp == 69 && (blocks[layer][uy + 1, ux] != 2)))
                                { // void_rot
                                    if (!(TORCHESL.ContainsKey(blockTemp)) || uy < HEIGHT - 1 && (solid[blocks[layer][uy + 1, ux]] && blockTemp != 127 || solid[blocks[layer][uy, ux + 1]] || solid[blocks[layer][uy, ux - 1]]))
                                    {
                                        if (TORCHESL.ContainsKey(blockTemp))
                                        {
                                            if (solid[blocks[layer][uy + 1, ux]] && blockTemp != 127)
                                            {
                                                blockTemp = blockTemp;
                                            }
                                            else if (solid[blocks[layer][uy, ux - 1]])
                                            {
                                                blockTemp = TORCHESL[blockTemp];
                                            }
                                            else if (solid[blocks[layer][uy, ux + 1]])
                                            {
                                                blockTemp = TORCHESR[blockTemp];
                                            }
                                        }
                                        if (layer == 1 && !DEBUG_GPLACE && blockcds[blockTemp])
                                        {
                                            for (i = 0; i < entities.Count; i++)
                                            {
                                                if (entities[i].name != null && entities[i].rect.Intersects(new Rectangle(ux * BLOCKSIZE, uy * BLOCKSIZE, BLOCKSIZE, BLOCKSIZE)))
                                                {
                                                    blockTemp = 0;
                                                }
                                            }
                                            if (player.rect.Intersects(new Rectangle(ux * BLOCKSIZE, uy * BLOCKSIZE, BLOCKSIZE, BLOCKSIZE)))
                                            {
                                                blockTemp = 0;
                                            }
                                        }
                                        if (blockTemp != 0)
                                        {
                                            blocks[layer][uy, ux] = blockTemp;
                                            if (receives[blocks[layer][uy, ux]])
                                            {
                                                addAdjacentTilesToPQueue(ux, uy);
                                            }
                                            if (powers[blocks[layer][uy, ux]])
                                            {
                                                addBlockPower(ux, uy);
                                            }
                                            if (ltrans[blocks[layer][uy, ux]])
                                            {
                                                removeSunLighting(ux, uy);
                                                redoBlockLighting(ux, uy);
                                            }
                                            addBlockLighting(ux, uy);
                                        }
                                        if (blockTemp != 0)
                                        {
                                            inventory.removeLocation(inventory.selection, (short)1);
                                            blockds[layer] = World.generate2b(blocks[layer], blockds[layer], ux, uy);
                                            for (uly = uy - 1; uly < uy + 2; uly++)
                                            {
                                                for (ulx = ux - 1; ulx < ux + 2; ulx++)
                                                {
                                                    blockdns[uly, ulx] = (byte)random.Next(5);
                                                }
                                            }
                                            for (uly = uy - 1; uly < uy + 2; uly++)
                                            {
                                                for (ulx = ux - 1; ulx < ux + 2; ulx++)
                                                {
                                                    drawn[uly, ulx] = false;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                mouseClicked = true;
            }
            if (queue[4])
            {
                checkBlocks = true;
                if (showInv)
                {
                    for (ux = 0; ux < 10; ux++)
                    {
                        for (uy = 0; uy < 4; uy++)
                        {
                            if (mousePos[0] >= ux * 46 + 6 && mousePos[0] < ux * 46 + 46 &&
                                mousePos[1] >= uy * 46 + 6 && mousePos[1] < uy * 46 + 46)
                            {
                                checkBlocks = false;
                                if (mouseClicked2)
                                {
                                    mouseNoLongerClicked2 = true;
                                    moveItemTemp = inventory.ids[uy * 10 + ux];
                                    moveNumTemp = (short)(inventory.nums[uy * 10 + ux] / 2);
                                    moveDurTemp = inventory.durs[uy * 10 + ux];
                                    if (inventory.ids[uy * 10 + ux] == 0)
                                    {
                                        inventory.addLocation(uy * 10 + ux, moveItem, (short)1, moveDur);
                                        moveNum -= 1;
                                        if (moveNum == 0)
                                        {
                                            moveItem = 0;
                                            moveDur = 0;
                                        }
                                    }
                                    else if (moveItem == 0 && inventory.nums[uy * 10 + ux] != 1)
                                    {
                                        inventory.removeLocation(uy * 10 + ux, (short)(inventory.nums[uy * 10 + ux] / 2));
                                        moveItem = moveItemTemp;
                                        moveNum = moveNumTemp;
                                        moveDur = moveDurTemp;
                                    }
                                    else if (moveItem == inventory.ids[uy * 10 + ux] && inventory.nums[uy * 10 + ux] < MAXSTACKS[inventory.ids[uy * 10 + ux]])
                                    {
                                        inventory.addLocation(uy * 10 + ux, moveItem, (short)1, moveDur);
                                        moveNum -= 1;
                                        if (moveNum == 0)
                                        {
                                            moveItem = 0;
                                            moveDur = 0;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    for (ux = 0; ux < 2; ux++)
                    {
                        for (uy = 0; uy < 2; uy++)
                        {
                            if (mousePos[0] >= inventory.image.Width + ux * 40 + 75 &&
                                mousePos[0] < inventory.image.Width + ux * 40 + 121 &&
                                mousePos[1] >= uy * 40 + 52 && mousePos[1] < uy * 40 + 92)
                            {
                                checkBlocks = false;
                                if (mouseClicked2)
                                {
                                    mouseNoLongerClicked2 = true;
                                    moveItemTemp = cic.ids[uy * 2 + ux];
                                    moveNumTemp = (short)(cic.nums[uy * 2 + ux] / 2);
                                    if (cic.ids[uy * 2 + ux] == 0)
                                    {
                                        inventory.addLocationIC(cic, uy * 2 + ux, moveItem, (short)1, moveDur);
                                        moveNum -= 1;
                                        if (moveNum == 0)
                                        {
                                            moveItem = 0;
                                        }
                                    }
                                    else if (moveItem == 0 && cic.nums[uy * 2 + ux] != 1)
                                    {
                                        inventory.removeLocationIC(cic, uy * 2 + ux, (short)(cic.nums[uy * 2 + ux] / 2));
                                        moveItem = moveItemTemp;
                                        moveNum = moveNumTemp;
                                    }
                                    else if (moveItem == cic.ids[uy * 2 + ux] && cic.nums[uy * 2 + ux] < MAXSTACKS[cic.ids[uy * 2 + ux]])
                                    {
                                        inventory.addLocationIC(cic, uy * 2 + ux, moveItem, (short)1, moveDur);
                                        moveNum -= 1;
                                        if (moveNum == 0)
                                        {
                                            moveItem = 0;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (ic != null)
                    {
                        if (ic.type.Equals("workbench"))
                        {
                            for (ux = 0; ux < 3; ux++)
                            {
                                for (uy = 0; uy < 3; uy++)
                                {
                                    if (mousePos[0] >= ux * 40 + 6 && mousePos[0] < ux * 40 + 46 &&
                                        mousePos[1] >= uy * 40 + inventory.image.Height + 46 &&
                                        mousePos[1] < uy * 40 + inventory.image.Height + 86)
                                    {
                                        checkBlocks = false;
                                        if (mouseClicked2)
                                        {
                                            mouseNoLongerClicked2 = true;
                                            moveItemTemp = ic.ids[uy * 3 + ux];
                                            moveNumTemp = (short)(ic.nums[uy * 3 + ux] / 2);
                                            if (ic.ids[uy * 3 + ux] == 0)
                                            {
                                                inventory.addLocationIC(ic, uy * 3 + ux, moveItem, (short)1, moveDur);
                                                moveNum -= 1;
                                                if (moveNum == 0)
                                                {
                                                    moveItem = 0;
                                                }
                                            }
                                            else if (moveItem == 0 && ic.nums[uy * 3 + ux] != 1)
                                            {
                                                inventory.removeLocationIC(ic, uy * 3 + ux, (short)(ic.nums[uy * 3 + ux] / 2));
                                                moveItem = moveItemTemp;
                                                moveNum = moveNumTemp;
                                            }
                                            else if (moveItem == ic.ids[uy * 3 + ux] && ic.nums[uy * 3 + ux] < MAXSTACKS[ic.ids[uy * 3 + ux]])
                                            {
                                                if (ic.ids[7] == 160 && ic.nums[7] == 51 && moveItem == 165 && uy * 3 + ux == 3 && ic.nums[8] == 0)
                                                {
                                                    inventory.addLocationIC(ic, 8, (short)154, (short)1);
                                                }
                                                else
                                                {
                                                    inventory.addLocationIC(ic, uy * 3 + ux, moveItem, (short)1, moveDur);
                                                    moveNum -= 1;
                                                    if (moveNum == 0)
                                                    {
                                                        moveItem = 0;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (mousePos[0] >= 4 * 40 + 6 && mousePos[0] < 4 * 40 + 46 &&
                                mousePos[1] >= 1 * 40 + inventory.image.Height + 46 &&
                                mousePos[1] < 1 * 40 + inventory.image.Height + 86)
                            {
                                checkBlocks = false;
                                if (mouseClicked2)
                                {
                                    //
                                }
                            }
                        }
                        if (ic.type.Equals("wooden_chest") || ic.type.Equals("stone_chest") ||
                            ic.type.Equals("copper_chest") || ic.type.Equals("iron_chest") ||
                            ic.type.Equals("silver_chest") || ic.type.Equals("gold_chest") ||
                            ic.type.Equals("zinc_chest") || ic.type.Equals("rhymestone_chest") ||
                            ic.type.Equals("obdurite_chest"))
                        {
                            for (ux = 0; ux < inventory.CX; ux++)
                            {
                                for (uy = 0; uy < inventory.CY; uy++)
                                {
                                    if (mousePos[0] >= ux * 46 + 6 && mousePos[0] < ux * 46 + 46 &&
                                        mousePos[1] >= uy * 46 + inventory.image.Height + 46 &&
                                        mousePos[1] < uy * 46 + inventory.image.Height + 86)
                                    {
                                        checkBlocks = false;
                                        if (mouseClicked2)
                                        {
                                            mouseNoLongerClicked2 = true;
                                            moveItemTemp = ic.ids[uy * inventory.CX + ux];
                                            moveNumTemp = (short)(ic.nums[uy * inventory.CX + ux] / 2);
                                            if (ic.ids[uy * inventory.CX + ux] == 0)
                                            {
                                                inventory.addLocationIC(ic, uy * inventory.CX + ux, moveItem, (short)1, moveDur);
                                                moveNum -= 1;
                                                if (moveNum == 0)
                                                {
                                                    moveItem = 0;
                                                }
                                            }
                                            else if (moveItem == 0 && ic.nums[uy * inventory.CX + ux] != 1)
                                            {
                                                inventory.removeLocationIC(ic, uy * inventory.CX + ux, (short)(ic.nums[uy * inventory.CX + ux] / 2));
                                                moveItem = moveItemTemp;
                                                moveNum = moveNumTemp;
                                            }
                                            else if (moveItem == ic.ids[uy * inventory.CX + ux] && ic.nums[uy * inventory.CX + ux] < MAXSTACKS[ic.ids[uy * inventory.CX + ux]])
                                            {
                                                inventory.addLocationIC(ic, uy * inventory.CX + ux, moveItem, (short)1, moveDur);
                                                moveNum -= 1;
                                                if (moveNum == 0)
                                                {
                                                    moveItem = 0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (ic.type.Equals("furnace"))
                        {
                            if (mousePos[0] >= 6 && mousePos[0] < 46 &&
                                mousePos[1] >= inventory.image.Height + 46 &&
                                mousePos[1] < inventory.image.Height + 86)
                            {
                                checkBlocks = false;
                                if (mouseClicked2)
                                {
                                    mouseNoLongerClicked2 = true;
                                    moveItemTemp = ic.ids[0];
                                    moveNumTemp = (short)(ic.nums[0] / 2);
                                    if (ic.ids[0] == 0)
                                    {
                                        inventory.addLocationIC(ic, 0, moveItem, (short)1, moveDur);
                                        moveNum -= 1;
                                        if (moveNum == 0)
                                        {
                                            moveItem = 0;
                                        }
                                    }
                                    else if (moveItem == 0 && ic.nums[0] != 1)
                                    {
                                        inventory.removeLocationIC(ic, 0, (short)(ic.nums[0] / 2));
                                        moveItem = moveItemTemp;
                                        moveNum = moveNumTemp;
                                    }
                                    else if (moveItem == ic.ids[0] && ic.nums[0] < MAXSTACKS[ic.ids[0]])
                                    {
                                        inventory.addLocationIC(ic, 0, moveItem, (short)1, moveDur);
                                        moveNum -= 1;
                                        if (moveNum == 0)
                                        {
                                            moveItem = 0;
                                        }
                                    }
                                }
                            }
                            if (mousePos[0] >= 6 && mousePos[0] < 46 &&
                                mousePos[1] >= inventory.image.Height + 142 &&
                                mousePos[1] < inventory.image.Height + 182)
                            {
                                checkBlocks = false;
                                if (mouseClicked2)
                                {
                                    mouseNoLongerClicked2 = true;
                                    moveItemTemp = ic.ids[2];
                                    moveNumTemp = (short)(ic.nums[2] / 2);
                                    if (ic.ids[2] == 0)
                                    {
                                        inventory.addLocationIC(ic, 2, moveItem, (short)1, moveDur);
                                        moveNum -= 1;
                                        if (moveNum == 0)
                                        {
                                            moveItem = 0;
                                        }
                                    }
                                    else if (moveItem == 0 && ic.nums[2] != 1)
                                    {
                                        inventory.removeLocationIC(ic, 2, (short)(ic.nums[2] / 2));
                                        moveItem = moveItemTemp;
                                        moveNum = moveNumTemp;
                                    }
                                    else if (moveItem == ic.ids[2] && ic.nums[2] < MAXSTACKS[ic.ids[2]])
                                    {
                                        inventory.addLocationIC(ic, 2, moveItem, (short)1, moveDur);
                                        moveNum -= 1;
                                        if (moveNum == 0)
                                        {
                                            moveItem = 0;
                                        }
                                    }
                                }
                            }
                            if (mousePos[0] >= 62 && mousePos[0] < 102 &&
                                mousePos[1] >= inventory.image.Height + 46 &&
                                mousePos[1] < inventory.image.Height + 86)
                            {
                                checkBlocks = false;
                                if (mouseClicked2)
                                {
                                    mouseNoLongerClicked2 = true;
                                    moveItemTemp = ic.ids[3];
                                    moveNumTemp = (short)(ic.nums[3] / 2);
                                    if (moveItem == 0 && ic.nums[3] != 1)
                                    {
                                        inventory.removeLocationIC(ic, 3, (short)(ic.nums[3] / 2));
                                        moveItem = moveItemTemp;
                                        moveNum = moveNumTemp;
                                    }
                                }
                            }
                        }
                    }
                }
                if (checkBlocks)
                {
                    if (!(mousePos2[0] < 0 || mousePos2[0] >= WIDTH * BLOCKSIZE ||
                          mousePos2[1] < 0 || mousePos2[1] >= HEIGHT * BLOCKSIZE))
                    {
                        ux = (int)(mousePos2[0] / BLOCKSIZE);
                        uy = (int)(mousePos2[1] / BLOCKSIZE);
                        if (DEBUG_REACH || Math.Sqrt(Math.Pow(player.x + player.image.Width - ux * BLOCKSIZE + BLOCKSIZE / 2, 2) + Math.Pow(player.y + player.image.Height - uy * BLOCKSIZE + BLOCKSIZE / 2, 2)) <= 160)
                        {
                            ucx = ux - CHUNKBLOCKS * ((int)(ux / CHUNKBLOCKS));
                            ucy = uy - CHUNKBLOCKS * ((int)(uy / CHUNKBLOCKS));
                            if (blocks[layer][uy, ux] >= 8 && blocks[layer][uy, ux] <= 14 || blocks[layer][uy, ux] == 17 || blocks[layer][uy, ux] == 23 || blocks[layer][uy, ux] >= 80 && blocks[layer][uy, ux] <= 82)
                            {
                                if (ic != null)
                                {
                                    if (!ic.type.Equals("workbench"))
                                    {
                                        machinesx.Add(icx);
                                        machinesy.Add(icy);
                                        icmatrix[iclayer, icy, icx] = new ItemCollection(ic.type, ic.ids, ic.nums, ic.durs);
                                    }
                                    if (ic.type.Equals("workbench"))
                                    {
                                        if (player.imgState.Equals("still right") || player.imgState.Equals("walk right 1") || player.imgState.Equals("walk right 2"))
                                        {
                                            for (i = 0; i < 9; i++)
                                            {
                                                if (ic.ids[i] != 0)
                                                {
                                                    entities.Add(new Entity(icx * BLOCKSIZE, icy * BLOCKSIZE, 2, -2, ic.ids[i], ic.nums[i], ic.durs[i], 75));
                                                }
                                            }
                                        }
                                        if (player.imgState.Equals("still left") || player.imgState.Equals("walk left 1") || player.imgState.Equals("walk left 2"))
                                        {
                                            for (i = 0; i < 9; i++)
                                            {
                                                if (ic.ids[i] != 0)
                                                {
                                                    entities.Add(new Entity(icx * BLOCKSIZE, icy * BLOCKSIZE, -2, -2, ic.ids[i], ic.nums[i], ic.durs[i], 75));
                                                }
                                            }
                                        }
                                    }
                                    if (ic.type.Equals("furnace"))
                                    {
                                        icmatrix[iclayer, icy, icx].FUELP = ic.FUELP;
                                        icmatrix[iclayer, icy, icx].SMELTP = ic.SMELTP;
                                        icmatrix[iclayer, icy, icx].F_ON = ic.F_ON;
                                    }
                                    ic = null;
                                }
                                iclayer = layer;
                                for (int l = 0; l < 3; l++)
                                {
                                    if (blocks[l][uy, ux] == 8)
                                    {
                                        short[] tlist1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        if (icmatrix[l, uy, ux] != null && icmatrix[l, uy, ux].type.Equals("workbench"))
                                        {
                                            ic = new ItemCollection("workbench", icmatrix[l, uy, ux].ids, icmatrix[l, uy, ux].nums, icmatrix[l, uy, ux].durs);
                                        }
                                        else
                                        {
                                            ic = new ItemCollection("workbench", tlist1, tlist2, tlist3);
                                        }
                                        icx = ux;
                                        icy = uy;
                                        inventory.renderCollection(ic);
                                        showInv = true;
                                    }
                                    if (blocks[l][uy, ux] == 9)
                                    {
                                        short[] tlist1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        if (icmatrix[l, uy, ux] != null && icmatrix[l, uy, ux].type.Equals("wooden_chest"))
                                        {
                                            ic = new ItemCollection("wooden_chest", icmatrix[l, uy, ux].ids, icmatrix[l, uy, ux].nums, icmatrix[l, uy, ux].durs);
                                        }
                                        else
                                        {
                                            ic = new ItemCollection("wooden_chest", tlist1, tlist2, tlist3);
                                        }
                                        icx = ux;
                                        icy = uy;
                                        inventory.renderCollection(ic);
                                        showInv = true;
                                    }
                                    if (blocks[l][uy, ux] == 10)
                                    {
                                        short[] tlist1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        if (icmatrix[l, uy, ux] != null && icmatrix[l, uy, ux].type.Equals("stone_chest"))
                                        {
                                            ic = new ItemCollection("stone_chest", icmatrix[l, uy, ux].ids, icmatrix[l, uy, ux].nums, icmatrix[l, uy, ux].durs);
                                        }
                                        else
                                        {
                                            ic = new ItemCollection("stone_chest", tlist1, tlist2, tlist3);
                                        }
                                        icx = ux;
                                        icy = uy;
                                        inventory.renderCollection(ic);
                                        showInv = true;
                                    }
                                    if (blocks[l][uy, ux] == 11)
                                    {
                                        short[] tlist1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        if (icmatrix[l, uy, ux] != null && icmatrix[l, uy, ux].type.Equals("copper_chest"))
                                        {
                                            ic = new ItemCollection("copper_chest", icmatrix[l, uy, ux].ids, icmatrix[l, uy, ux].nums, icmatrix[l, uy, ux].durs);
                                        }
                                        else
                                        {
                                            ic = new ItemCollection("copper_chest", tlist1, tlist2, tlist3);
                                        }
                                        icx = ux;
                                        icy = uy;
                                        inventory.renderCollection(ic);
                                        showInv = true;
                                    }
                                    if (blocks[l][uy, ux] == 12)
                                    {
                                        short[] tlist1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        if (icmatrix[l, uy, ux] != null && icmatrix[l, uy, ux].type.Equals("iron_chest"))
                                        {
                                            ic = new ItemCollection("iron_chest", icmatrix[l, uy, ux].ids, icmatrix[l, uy, ux].nums, icmatrix[l, uy, ux].durs);
                                        }
                                        else
                                        {
                                            ic = new ItemCollection("iron_chest", tlist1, tlist2, tlist3);
                                        }
                                        icx = ux;
                                        icy = uy;
                                        inventory.renderCollection(ic);
                                        showInv = true;
                                    }
                                    if (blocks[l][uy, ux] == 13)
                                    {
                                        short[] tlist1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        if (icmatrix[l, uy, ux] != null && icmatrix[l, uy, ux].type.Equals("silver_chest"))
                                        {
                                            ic = new ItemCollection("silver_chest", icmatrix[l, uy, ux].ids, icmatrix[l, uy, ux].nums, icmatrix[l, uy, ux].durs);
                                        }
                                        else
                                        {
                                            ic = new ItemCollection("silver_chest", tlist1, tlist2, tlist3);
                                        }
                                        icx = ux;
                                        icy = uy;
                                        inventory.renderCollection(ic);
                                        showInv = true;
                                    }
                                    if (blocks[l][uy, ux] == 14)
                                    {
                                        short[] tlist1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        if (icmatrix[l, uy, ux] != null && icmatrix[l, uy, ux].type.Equals("gold_chest"))
                                        {
                                            ic = new ItemCollection("gold_chest", icmatrix[l, uy, ux].ids, icmatrix[l, uy, ux].nums, icmatrix[l, uy, ux].durs);
                                        }
                                        else
                                        {
                                            ic = new ItemCollection("gold_chest", tlist1, tlist2, tlist3);
                                        }
                                        icx = ux;
                                        icy = uy;
                                        inventory.renderCollection(ic);
                                        showInv = true;
                                    }
                                    if (blocks[l][uy, ux] == 80)
                                    {
                                        short[] tlist1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        if (icmatrix[l, uy, ux] != null && icmatrix[l, uy, ux].type.Equals("zinc_chest"))
                                        {
                                            ic = new ItemCollection("zinc_chest", icmatrix[l, uy, ux].ids, icmatrix[l, uy, ux].nums, icmatrix[l, uy, ux].durs);
                                        }
                                        else
                                        {
                                            ic = new ItemCollection("zinc_chest", tlist1, tlist2, tlist3);
                                        }
                                        icx = ux;
                                        icy = uy;
                                        inventory.renderCollection(ic);
                                        showInv = true;
                                    }
                                    if (blocks[l][uy, ux] == 81)
                                    {
                                        short[] tlist1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        if (icmatrix[l, uy, ux] != null && icmatrix[l, uy, ux].type.Equals("rhymestone_chest"))
                                        {
                                            ic = new ItemCollection("rhymestone_chest", icmatrix[l, uy, ux].ids, icmatrix[l, uy, ux].nums, icmatrix[l, uy, ux].durs);
                                        }
                                        else
                                        {
                                            ic = new ItemCollection("rhymestone_chest", tlist1, tlist2, tlist3);
                                        }
                                        icx = ux;
                                        icy = uy;
                                        inventory.renderCollection(ic);
                                        showInv = true;
                                    }
                                    if (blocks[l][uy, ux] == 82)
                                    {
                                        short[] tlist1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        short[] tlist3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                                        if (icmatrix[l, uy, ux] != null && icmatrix[l, uy, ux].type.Equals("obdurite_chest"))
                                        {
                                            ic = new ItemCollection("obdurite_chest", icmatrix[l, uy, ux].ids, icmatrix[l, uy, ux].nums, icmatrix[l, uy, ux].durs);
                                        }
                                        else
                                        {
                                            ic = new ItemCollection("obdurite_chest", tlist1, tlist2, tlist3);
                                        }
                                        icx = ux;
                                        icy = uy;
                                        inventory.renderCollection(ic);
                                        showInv = true;
                                    }
                                    if (blocks[l][uy, ux] == 17 || blocks[l][uy, ux] == 23)
                                    {
                                        short[] tlist1 = { 0, 0, 0, 0 };
                                        short[] tlist2 = { 0, 0, 0, 0 };
                                        short[] tlist3 = { 0, 0, 0, 0 };
                                        if (icmatrix[l, uy, ux] != null && icmatrix[l, uy, ux].type.Equals("furnace"))
                                        {
                                            ic = new ItemCollection("furnace", icmatrix[l, uy, ux].ids, icmatrix[l, uy, ux].nums, icmatrix[l, uy, ux].durs);
                                            ic.FUELP = icmatrix[l, uy, ux].FUELP;
                                            ic.SMELTP = icmatrix[l, uy, ux].SMELTP;
                                            ic.F_ON = icmatrix[l, uy, ux].F_ON;
                                            icmatrix[l, uy, ux] = null;
                                        }
                                        else
                                        {
                                            ic = new ItemCollection("furnace", tlist1, tlist2, tlist3);
                                        }
                                        icx = ux;
                                        icy = uy;
                                        inventory.renderCollection(ic);
                                        showInv = true;
                                    }
                                    if (ic != null && blocks[l][uy, ux] != 8)
                                    {
                                        for (i = machinesx.Count - 1; i > -1; i--)
                                        {
                                            if (machinesx[i] == icx && machinesy[i] == icy)
                                            {
                                                machinesx.RemoveAt(i);
                                                machinesy.RemoveAt(i);
                                            }
                                        }
                                    }
                                }
                            }
                            if (blocks[layer][uy, ux] == 15)
                            {
                                if (random.Next(2) == 0)
                                {
                                    entities.Add(new Entity(ux * BLOCKSIZE, uy * BLOCKSIZE, random.NextDouble() * 8 - 4, -3, (short)160, (short)1));
                                }
                                blocks[layer][uy, ux] = 83;
                            }
                            if (mouseClicked2)
                            {
                                mouseNoLongerClicked2 = true;
                                blockTemp = blocks[layer][uy, ux];
                                if (blocks[layer][uy, ux] == 105 || blocks[layer][uy, ux] == 107 || blocks[layer][uy, ux] == 109)
                                {
                                    blocks[layer][uy, ux] += 1;
                                    addBlockPower(ux, uy);
                                    rdrawn[uy, ux] = false;
                                }
                                else if (blocks[layer][uy, ux] == 106 || blocks[layer][uy, ux] == 108 || blocks[layer][uy, ux] == 110)
                                {
                                    removeBlockPower(ux, uy, layer);
                                    if (wcnct[uy, ux])
                                    {
                                        for (int l = 0; l < 3; l++)
                                        {
                                            if (l != layer)
                                            {
                                                rbpRecur(ux, uy, l);
                                            }
                                        }
                                    }
                                    blocks[layer][uy, ux] -= 1;
                                    rdrawn[uy, ux] = false;
                                }
                                if (blocks[layer][uy, ux] >= 94 && blocks[layer][uy, ux] <= 99)
                                {
                                    wcnct[uy, ux] = !wcnct[uy, ux];
                                    rdrawn[uy, ux] = false;
                                    redoBlockPower(ux, uy, layer);
                                }
                                if (blocks[layer][uy, ux] >= 111 && blocks[layer][uy, ux] <= 118)
                                {
                                    removeBlockPower(ux, uy, layer);
                                    if (blocks[layer][uy, ux] >= 111 && blocks[layer][uy, ux] <= 113 || blocks[layer][uy, ux] >= 115 && blocks[layer][uy, ux] <= 117)
                                    {
                                        blocks[layer][uy, ux] += 1;
                                    }
                                    else
                                    {
                                        blocks[layer][uy, ux] -= 3;
                                    }
                                    blockds[layer] = World.generate2b(blocks[layer], blockds[layer], ux, uy);
                                    rdrawn[uy, ux] = false;
                                    addAdjacentTilesToPQueueConditionally(ux, uy);
                                }
                                if (blocks[layer][uy, ux] >= 119 && blocks[layer][uy, ux] <= 126)
                                {
                                    removeBlockPower(ux, uy, layer);
                                    if (blocks[layer][uy, ux] >= 119 && blocks[layer][uy, ux] <= 121 || blocks[layer][uy, ux] >= 123 && blocks[layer][uy, ux] <= 125)
                                    {
                                        blocks[layer][uy, ux] += 1;
                                    }
                                    else
                                    {
                                        blocks[layer][uy, ux] -= 3;
                                    }
                                    blockds[layer] = World.generate2b(blocks[layer], blockds[layer], ux, uy);
                                    rdrawn[uy, ux] = false;
                                    addAdjacentTilesToPQueueConditionally(ux, uy);
                                }
                                if (blocks[layer][uy, ux] == 127 || blocks[layer][uy, ux] == 129)
                                {
                                    blocks[layer][uy, ux] += 1;
                                    addBlockPower(ux, uy);
                                    rdrawn[uy, ux] = false;
                                    print("Srsly?");
                                    updatex.Add(ux);
                                    updatey.Add(uy);
                                    updatet.Add(50);
                                    updatel.Add(layer);
                                }
                                if (blocks[layer][uy, ux] >= 137 && blocks[layer][uy, ux] <= 168)
                                {
                                    if (blocks[layer][uy, ux] >= 137 && blocks[layer][uy, ux] <= 139 || blocks[layer][uy, ux] >= 141 && blocks[layer][uy, ux] <= 143 ||
                                        blocks[layer][uy, ux] >= 145 && blocks[layer][uy, ux] <= 147 || blocks[layer][uy, ux] >= 149 && blocks[layer][uy, ux] <= 151 ||
                                        blocks[layer][uy, ux] >= 153 && blocks[layer][uy, ux] <= 155 || blocks[layer][uy, ux] >= 157 && blocks[layer][uy, ux] <= 159 ||
                                        blocks[layer][uy, ux] >= 161 && blocks[layer][uy, ux] <= 163 || blocks[layer][uy, ux] >= 165 && blocks[layer][uy, ux] <= 167)
                                    {
                                        blocks[layer][uy, ux] += 1;
                                    }
                                    else
                                    {
                                        blocks[layer][uy, ux] -= 3;
                                    }
                                    blockds[layer] = World.generate2b(blocks[layer], blockds[layer], ux, uy);
                                    rdrawn[uy, ux] = false;
                                    redoBlockPower(ux, uy, layer);
                                }
                            }
                        }
                    }
                }
                if (mouseNoLongerClicked2)
                {
                    mouseClicked2 = false;
                }
            }
            else
            {
                mouseClicked2 = true;
            }
            if (showTool)
            {
                toolAngle += toolSpeed;
                if (toolAngle >= 7.8)
                {
                    toolAngle = 4.8;
                    showTool = false;
                }
            }
            if (!DEBUG_INVINCIBLE && player.y / 16 > HEIGHT + 10)
            {
                vc += 1;
                if (vc >= 1 / (Math.Pow(1.001, player.y / 16 - HEIGHT - 10) - 1.0))
                {
                    player.damage(1, false, inventory);
                    vc = 0;
                }
            }
            else
            {
                vc = 0;
            }
            for (i = entities.Count - 1; i >= 0; i--)
            {
                if (entities[i].newMob != null)
                {
                    entities.Add(entities[i].newMob);
                }
                if (entities[i].update(blocks[1], player, u, v))
                {
                    entities.RemoveAt(i);
                }
                else if (player.rect.Intersects(entities[i].rect))
                {
                    if (entities[i].name != null)
                    {
                        if (immune <= 0)
                        {
                            if (!DEBUG_INVINCIBLE)
                            {
                                player.damage(entities[i].atk, true, inventory);
                            }
                            rgnc1 = 750;
                            immune = 40;
                            if (player.x + player.width / 2 < entities[i].x + entities[i].width / 2)
                            {
                                player.vx -= 8;
                            }
                            else
                            {
                                player.vx += 8;
                            }
                            player.vy -= 3.5;
                        }
                    }
                    else if (entities[i].mdelay <= 0)
                    {
                        n = inventory.addItem(entities[i].id, entities[i].num, entities[i].dur);
                        if (n != 0)
                        {
                            entities.Add(new Entity(entities[i].x, entities[i].y, entities[i].vx, entities[i].vy, entities[i].id, (short)(entities[i].num - n), entities[i].dur));
                        }
                        entities.RemoveAt(i);
                    }
                }
            }
            if (player.hp <= 0)
            {
                for (j = 0; j < 40; j++)
                {
                    if (inventory.ids[j] != 0)
                    {
                        entities.Add(new Entity(player.x, player.y, -1, random.NextDouble() * 6 - 3, inventory.ids[j], inventory.nums[j], inventory.durs[j]));
                        inventory.removeLocation(j, inventory.nums[j]);
                    }
                }
                if (ic != null)
                {
                    if (!ic.type.Equals("workbench"))
                    {
                        machinesx.Add(icx);
                        machinesy.Add(icy);
                        icmatrix[iclayer, icy, icx] = new ItemCollection(ic.type, ic.ids, ic.nums, ic.durs);
                    }
                    if (ic.type.Equals("workbench"))
                    {
                        if (player.imgState.Equals("still right") || player.imgState.Equals("walk right 1") || player.imgState.Equals("walk right 2"))
                        {
                            for (i = 0; i < 9; i++)
                            {
                                if (ic.ids[i] != 0)
                                {
                                    entities.Add(new Entity(icx * BLOCKSIZE, icy * BLOCKSIZE, 2, -2, ic.ids[i], ic.nums[i], ic.durs[i], 75));
                                }
                            }
                        }
                        if (player.imgState.Equals("still left") || player.imgState.Equals("walk left 1") || player.imgState.Equals("walk left 2"))
                        {
                            for (i = 0; i < 9; i++)
                            {
                                if (ic.ids[i] != 0)
                                {
                                    entities.Add(new Entity(icx * BLOCKSIZE, icy * BLOCKSIZE, -2, -2, ic.ids[i], ic.nums[i], ic.durs[i], 75));
                                }
                            }
                        }
                    }
                    if (ic.type.Equals("furnace"))
                    {
                        icmatrix[iclayer, icy, icx].FUELP = ic.FUELP;
                        icmatrix[iclayer, icy, icx].SMELTP = ic.SMELTP;
                        icmatrix[iclayer, icy, icx].F_ON = ic.F_ON;
                    }
                    ic = null;
                }
                else
                {
                    if (showInv)
                    {
                        for (i = 0; i < 4; i++)
                        {
                            if (cic.ids[i] != 0)
                            {
                                if (player.imgState.Equals("still right") || player.imgState.Equals("walk right 1") || player.imgState.Equals("walk right 2"))
                                {
                                    entities.Add(new Entity(player.x, player.y, 2, -2, cic.ids[i], cic.nums[i], cic.durs[i], 75));
                                }
                                if (player.imgState.Equals("still left") || player.imgState.Equals("walk left 1") || player.imgState.Equals("walk left 2"))
                                {
                                    entities.Add(new Entity(player.x, player.y, -2, -2, cic.ids[i], cic.nums[i], cic.durs[i], 75));
                                }
                                inventory.removeLocationIC(cic, i, cic.nums[i]);
                            }
                        }
                    }
                    showInv = !showInv;
                }
                if (moveItem != 0)
                {
                    if (player.imgState.Equals("still right") || player.imgState.Equals("walk right 1") || player.imgState.Equals("walk right 2"))
                    {
                        entities.Add(new Entity(player.x, player.y, 2, -2, moveItem, moveNum, moveDur, 75));
                    }
                    if (player.imgState.Equals("still left") || player.imgState.Equals("walk left 1") || player.imgState.Equals("walk left 2"))
                    {
                        entities.Add(new Entity(player.x, player.y, -2, -2, moveItem, moveNum, moveDur, 75));
                    }
                    moveItem = 0;
                    moveNum = 0;
                }
                for (i = 0; i < 4; i++)
                {
                    if (armor.ids[i] != 0)
                    {
                        if (player.imgState.Equals("still right") || player.imgState.Equals("walk right 1") || player.imgState.Equals("walk right 2"))
                        {
                            entities.Add(new Entity(player.x, player.y, 2, -2, armor.ids[i], armor.nums[i], armor.durs[i], 75));
                        }
                        if (player.imgState.Equals("still left") || player.imgState.Equals("walk left 1") || player.imgState.Equals("walk left 2"))
                        {
                            entities.Add(new Entity(player.x, player.y, -2, -2, armor.ids[i], armor.nums[i], armor.durs[i], 75));
                        }
                        inventory.removeLocationIC(armor, i, armor.nums[i]);
                    }
                }
                player.x = WIDTH * 0.5 * BLOCKSIZE;
                player.y = 45;
                player.vx = 0;
                player.vy = 0;
                player.hp = player.thp;
                tool = null;
                showTool = false;
            }
            if (showTool)
            {
                if (player.imgState.Equals("still right") || player.imgState.Equals("walk right 1") || player.imgState.Equals("walk right 2"))
                {
                    tp1 = new Point((int)(player.x + player.width / 2 + 6), (int)(player.y + player.height / 2));
                    tp2 = new Point((int)(player.x + player.width / 2 + 6 + tool.Width * 2 * Math.Cos(toolAngle) + tool.Height * 2 * Math.Sin(toolAngle)),
                                    (int)(player.y + player.height / 2 + tool.Width * 2 * Math.Sin(toolAngle) - tool.Height * 2 * Math.Cos(toolAngle)));
                    tp3 = new Point((int)(player.x + player.width / 2 + 6 + tool.Width * 1 * Math.Cos(toolAngle) + tool.Height * 1 * Math.Sin(toolAngle)),
                                    (int)(player.y + player.height / 2 + tool.Width * 1 * Math.Sin(toolAngle) - tool.Height * 1 * Math.Cos(toolAngle)));
                    tp4 = new Point((int)(player.x + player.width / 2 + 6 + tool.Width * 0.5 * Math.Cos(toolAngle) + tool.Height * 0.5 * Math.Sin(toolAngle)),
                                    (int)(player.y + player.height / 2 + tool.Width * 0.5 * Math.Sin(toolAngle) - tool.Height * 0.5 * Math.Cos(toolAngle)));
                    tp5 = new Point((int)(player.x + player.width / 2 + 6 + tool.Width * 1.5 * Math.Cos(toolAngle) + tool.Height * 1.5 * Math.Sin(toolAngle)),
                                    (int)(player.y + player.height / 2 + tool.Width * 1.5 * Math.Sin(toolAngle) - tool.Height * 1.5 * Math.Cos(toolAngle)));
                }
                if (player.imgState.Equals("still left") || player.imgState.Equals("walk left 1") || player.imgState.Equals("walk left 2"))
                {
                    tp1 = new Point((int)(player.x + player.width / 2 - 6), (int)(player.y + player.height / 2));
                    tp2 = new Point((int)(player.x + player.width / 2 - 6 + tool.Width * 2 * Math.Cos((Math.PI * 1.5) - toolAngle) + tool.Height * 2 * Math.Sin((Math.PI * 1.5) - toolAngle)),
                                    (int)(player.y + player.height / 2 + tool.Width * 2 * Math.Sin((Math.PI * 1.5) - toolAngle) - tool.Height * 2 * Math.Cos((Math.PI * 1.5) - toolAngle)));
                    tp3 = new Point((int)(player.x + player.width / 2 - 6 + tool.Width * 1 * Math.Cos((Math.PI * 1.5) - toolAngle) + tool.Height * 1 * Math.Sin((Math.PI * 1.5) - toolAngle)),
                                    (int)(player.y + player.height / 2 + tool.Width * 1 * Math.Sin((Math.PI * 1.5) - toolAngle) - tool.Height * 1 * Math.Cos((Math.PI * 1.5) - toolAngle)));
                    tp4 = new Point((int)(player.x + player.width / 2 - 6 + tool.Width * 0.5 * Math.Cos((Math.PI * 1.5) - toolAngle) + tool.Height * 0.5 * Math.Sin((Math.PI * 1.5) - toolAngle)),
                                    (int)(player.y + player.height / 2 + tool.Width * 0.5 * Math.Sin((Math.PI * 1.5) - toolAngle) - tool.Height * 0.5 * Math.Cos((Math.PI * 1.5) - toolAngle)));
                    tp5 = new Point((int)(player.x + player.width / 2 - 6 + tool.Width * 1.5 * Math.Cos((Math.PI * 1.5) - toolAngle) + tool.Height * 1.5 * Math.Sin((Math.PI * 1.5) - toolAngle)),
                                    (int)(player.y + player.height / 2 + tool.Width * 1.5 * Math.Sin((Math.PI * 1.5) - toolAngle) - tool.Height * 1.5 * Math.Cos((Math.PI * 1.5) - toolAngle)));
                }
                for (i = entities.Count - 1; i >= 0; i--)
                {
                    if (entities[i].name != null && !entities[i].nohit && showTool && (entities[i].rect.Contains(tp1) || entities[i].rect.Contains(tp2) || entities[i].rect.Contains(tp3) || entities[i].rect.Contains(tp4) || entities[i].rect.Contains(tp5)) && (!entities[i].name.Equals("bee") || random.Next(4) == 0))
                    {
                        if (entities[i].hit(TOOLDAMAGE[inventory.tool()], player))
                        {
                            List<short> dropList = entities[i].drops();
                            for (j = 0; j < dropList.Count; j++)
                            {
                                s = dropList[j];
                                entities.Add(new Entity(entities[i].x, entities[i].y, random.Next(4) - 2, -1, s, (short)1));
                            }
                            entities.RemoveAt(i);
                        }
                        if (!toolList.Contains(inventory.ids[inventory.selection]))
                        {
                            inventory.durs[inventory.selection] -= 1;
                        }
                        else
                        {
                            inventory.durs[inventory.selection] -= 2;
                        }
                        if (inventory.durs[inventory.selection] <= 0)
                        {
                            inventory.removeLocation(inventory.selection, inventory.nums[inventory.selection]);
                        }
                    }
                }
            }

            Rectangle rect;
            int bx1, bx2, by1, by2;
            for (i = -1; i < entities.Count; i++)
            {
                if (i == -1)
                {
                    rect = player.rect;
                    width = player.width;
                    height = player.height;
                    p = player.x;
                    q = player.y;
                }
                else
                {
                    rect = entities[i].rect;
                    width = entities[i].width;
                    height = entities[i].height;
                    p = entities[i].x;
                    q = entities[i].y;
                }
                bx1 = (int)p / BLOCKSIZE; by1 = (int)q / BLOCKSIZE;
                bx2 = (int)(p + width) / BLOCKSIZE; by2 = (int)(q + height) / BLOCKSIZE;

                bx1 = Math.Max(0, bx1); by1 = Math.Max(0, by1);
                bx2 = Math.Min(blocks[0].Length - 1, bx2); by2 = Math.Min(blocks.Length - 1, by2);

                for (x = bx1; x <= bx2; x++)
                {
                    for (y = by1; y <= by2; y++)
                    {
                        if (blocks[layer][y, x] >= 131 && blocks[layer][y, x] <= 136 && (i == -1 || blocks[layer][y, x] <= 134 && (x != -1 && entities[i].name != null || blocks[layer][y, x] <= 132)))
                        {
                            if (blocks[layer][y, x] == 131 || blocks[layer][y, x] == 133 || blocks[layer][y, x] == 135)
                            {
                                blocks[layer][y, x] += 1;
                                rdrawn[y, x] = false;
                                addBlockPower(x, y);
                                print("Srsly?");
                                updatex.Add(x);
                                updatey.Add(y);
                                updatet.Add(0);
                                updatel.Add(0);
                            }
                        }
                    }
                }
            }

            resolvePowerMatrix();
            resolveLightMatrix();
            immune -= 1;
        }

        public bool hasOpenSpace(int x, int y, int l)
        {
            try
            {
                return (blocks[l][y - 1, x - 1] == 0 || !blockcds[blocks[l][y - 1, x - 1]] ||
                        blocks[l][y - 1, x] == 0 || !blockcds[blocks[l][y - 1, x]] ||
                        blocks[l][y - 1, x + 1] == 0 || !blockcds[blocks[l][y - 1, x + 1]] ||
                        blocks[l][y, x - 1] == 0 || !blockcds[blocks[l][y, x - 1]] ||
                        blocks[l][y, x + 1] == 0 || !blockcds[blocks[l][y, x + 1]] ||
                        blocks[l][y + 1, x - 1] == 0 || !blockcds[blocks[l][y + 1, x - 1]] ||
                        blocks[l][y + 1, x] == 0 || !blockcds[blocks[l][y + 1, x]] ||
                        blocks[l][y + 1, x + 1] == 0 || !blockcds[blocks[l][y + 1, x + 1]]);
            }
            catch (IndexOutOfRangeException e)
            {
                return false;
            }
        }

        public static bool hasOpenSpace(int x, int y, int[][] blocks)
        {
            return (blocks[y - 1][x - 1] == 0 || !blockcds[blocks[y - 1][x - 1]] ||
                    blocks[y - 1][x] == 0 || !blockcds[blocks[y - 1][x]] ||
                    blocks[y - 1][x + 1] == 0 || !blockcds[blocks[y - 1][x + 1]] ||
                    blocks[y][x - 1] == 0 || !blockcds[blocks[y][x - 1]] ||
                    blocks[y][x + 1] == 0 || !blockcds[blocks[y][x + 1]] ||
                    blocks[y + 1][x - 1] == 0 || !blockcds[blocks[y + 1][x - 1]] ||
                    blocks[y + 1][x] == 0 || !blockcds[blocks[y + 1][x]] ||
                    blocks[y + 1][x + 1] == 0 || !blockcds[blocks[y + 1][x + 1]]);
        }

        public bool empty(int x, int y)
        {
            return ((blocks[0][y, x] == 0 || BLOCKLIGHTS[blocks[0][y, x]] == 0) && // BLOCKLIGHTS.get(blocks[0][y,x]) == 0)
                    (blocks[1][y, x] == 0 || BLOCKLIGHTS[blocks[1][y, x]] == 0) &&
                    (blocks[2][y, x] == 0 || BLOCKLIGHTS[blocks[2][y, x]] == 0));
        }

        public String checkBiome(int x, int y)
        {
            int desert = 0;
            int frost = 0;
            int swamp = 0;
            int jungle = 0;
            int cavern = 0;
            for (x2 = x - 15; x2 < x + 16; x2++)
            {
                for (y2 = y - 15; y2 < y + 16; y2++)
                {
                    if (x2 + u >= 0 && x2 + u < WIDTH && y2 + v >= 0 && y2 + v < HEIGHT)
                    {
                        if (blocks[1][y2 + v, x2 + u] == 45 || blocks[1][y2 + v, x2 + u] == 76)
                        {
                            desert += 1;
                        }
                        else if (blocks[1][y2 + v, x2 + u] != 0)
                        {
                            desert -= 1;
                        }
                        if (blocks[1][y2 + v, x2 + u] == 1 || blocks[1][y2 + v, x2 + u] == 72 || blocks[1][y2 + v, x2 + u] == 73)
                        {
                            jungle += 1;
                        }
                        else if (blocks[1][y2 + v, x2 + u] != 0)
                        {
                            jungle -= 1;
                        }
                        if (blocks[1][y2 + v, x2 + u] == 74 || blocks[1][y2 + v, x2 + u] == 75)
                        {
                            swamp += 1;
                        }
                        else if (blocks[1][y2 + v, x2 + u] != 0)
                        {
                            swamp -= 1;
                        }
                        if (blocks[1][y2 + v, x2 + u] == 46)
                        {
                            frost += 1;
                        }
                        else if (blocks[1][y2 + v, x2 + u] != 0)
                        {
                            frost -= 1;
                        }
                        if (blockbgs[y2 + v, x2 + u] == 0)
                        {
                            cavern += 1;
                        }
                        if (blocks[1][y2 + v, x2 + u] == 1 || blocks[1][y2 + v, x2 + u] == 2)
                        {
                            cavern += 1;
                        }
                        else
                        {
                            cavern -= 1;
                        }
                    }
                }
            }
            if (desert > 0)
            {
                return "desert";
            }
            if (jungle > 0)
            {
                return "jungle";
            }
            if (swamp > 0)
            {
                return "swamp";
            }
            if (frost > 0)
            {
                return "frost";
            }
            if (cavern > 0)
            {
                return "cavern";
            }
            return "other";
        }

        public void breakCurrentBlock()
        {
            if (DEBUG_INSTAMINE || mining >= DURABILITY[inventory.tool()][blocks[layer][uy, ux]])
            {
                if (blocks[0][uy, ux] == 30)
                {
                    blocks[0][uy, ux] = 0;
                    for (uly = uy - 1; uly < uy + 2; uly++)
                    {
                        for (ulx = ux - 1; ulx < ux + 2; ulx++)
                        {
                            blockdns[uly, ulx] = (byte)random.Next(5);
                        }
                    }
                    for (uly = uy; uly < uy + 3; uly++)
                    {
                        for (ulx = ux - 1; ulx < ux + 2; ulx++)
                        {
                            drawn[uly, ulx] = false;
                        }
                    }
                }
                if (blocks[0][uy + 1, ux] == 30)
                {
                    blocks[0][uy + 1, ux] = 0;
                    for (uly = uy; uly < uy + 3; uly++)
                    {
                        for (ulx = ux - 1; ulx < ux + 2; ulx++)
                        {
                            blockdns[uly, ulx] = (byte)random.Next(5);
                        }
                    }
                    for (uly = uy; uly < uy + 3; uly++)
                    {
                        for (ulx = ux - 1; ulx < ux + 2; ulx++)
                        {
                            drawn[uly, ulx] = false;
                        }
                    }
                }
                if (blocks[layer][uy, ux] >= 8 && blocks[layer][uy, ux] <= 14 || blocks[layer][uy, ux] == 17 || blocks[layer][uy, ux] == 23 || blocks[layer][uy, ux] >= 80 && blocks[layer][uy, ux] <= 82)
                {
                    if (ic != null)
                    {
                        for (i = 0; i < ic.ids.Length; i++)
                        {
                            if (ic.ids[i] != 0 && !(ic.type.Equals("furnace") && i == 1))
                            {
                                entities.Add(new Entity(ux * BLOCKSIZE, uy * BLOCKSIZE, random.NextDouble() * 4 - 2, -2, ic.ids[i], ic.nums[i], ic.durs[i]));
                            }
                        }
                    }
                    if (icmatrix[layer, uy, ux] != null)
                    {
                        for (i = 0; i < icmatrix[layer, uy, ux].ids.Length; i++)
                        {
                            if (icmatrix[layer, uy, ux].ids[i] != 0 && !(icmatrix[layer, uy, ux].type.Equals("furnace") && i == 1))
                            {
                                entities.Add(new Entity(ux * BLOCKSIZE, uy * BLOCKSIZE, random.NextDouble() * 4 - 2, -2, icmatrix[layer, uy, ux].ids[i], icmatrix[layer, uy, ux].nums[i], icmatrix[layer, uy, ux].durs[i]));
                            }
                        }
                        icmatrix[layer, uy, ux] = null;
                    }
                    ic = null;
                    for (i = 0; i < machinesx.Count; i++)
                    {
                        if (machinesx[i] == ux && machinesy[i] == uy)
                        {
                            machinesx.RemoveAt(i);
                            machinesy.RemoveAt(i);
                            break;
                        }
                    }
                }
                if (blocks[layer][uy, ux] != 0 && BLOCKDROPS[blocks[layer][uy, ux]] != 0)//TODO: Consider BLOCKDROPS.get(blocks[layer][uy,ux]) != 0
                {
                    entities.Add(new Entity(ux * BLOCKSIZE, uy * BLOCKSIZE, random.NextDouble() * 4 - 2, -2, BLOCKDROPS[blocks[layer][uy, ux]], (short)1));
                }
                t = 0;
                switch (blocks[layer][uy, ux])
                {
                    case 48: t = 77; n = random.Next(4) - 2; break;
                    case 49: t = 77; n = random.Next(2); break;
                    case 50: t = 77; n = random.Next(3) + 1; break;
                    case 51: t = 79; n = random.Next(4) - 2; break;
                    case 52: t = 79; n = random.Next(2); break;
                    case 53: t = 79; n = random.Next(3) + 1; break;
                    case 54: t = 81; n = random.Next(4) - 2; break;
                    case 55: t = 81; n = random.Next(2); break;
                    case 56: t = 81; n = random.Next(3) + 1; break;
                    case 57: t = 83; n = random.Next(4) - 2; break;
                    case 58: t = 83; n = random.Next(2); break;
                    case 59: t = 83; n = random.Next(3) + 1; break;
                    case 60: t = 85; n = random.Next(4) - 2; break;
                    case 61: t = 85; n = random.Next(2); break;
                    case 62: t = 85; n = random.Next(3) + 1; break;
                    case 63: t = 87; n = random.Next(4) - 2; break;
                    case 64: t = 87; n = random.Next(2); break;
                    case 65: t = 87; n = random.Next(3) + 1; break;
                    case 66: t = 89; n = random.Next(4) - 2; break;
                    case 67: t = 89; n = random.Next(2); break;
                    case 68: t = 89; n = random.Next(3) + 1; break;
                    case 69: t = 91; n = random.Next(4) - 2; break;
                    case 70: t = 91; n = random.Next(2); break;
                    case 71: t = 91; n = random.Next(3) + 1; break;
                    case 77: t = 95; n = random.Next(4) - 2; break;
                    case 78: t = 95; n = random.Next(2); break;
                    case 79: t = 95; n = random.Next(3) + 1; break;
                    default: break;
                }
                if (t != 0)
                {
                    for (i = 0; i < Math.Max(1, n); i++)
                    {
                        entities.Add(new Entity(ux * BLOCKSIZE, uy * BLOCKSIZE, random.NextDouble() * 4 - 2, -2, (short)t, (short)1));
                    }
                }
                removeBlockLighting(ux, uy);
                blockTemp = blocks[layer][uy, ux];
                blocks[layer][uy, ux] = 0;
                if (blockTemp >= 94 && blockTemp <= 99)
                {
                    redoBlockPower(ux, uy, layer);
                }
                if (powers[blockTemp])
                {
                    removeBlockPower(ux, uy, layer);
                }
                if (ltrans[blockTemp])
                {
                    addSunLighting(ux, uy);
                    redoBlockLighting(ux, uy);
                }
                addSunLighting(ux, uy);
                blockds[layer] = World.generate2b(blocks[layer], blockds[layer], ux, uy);
                for (uly = uy - 1; uly < uy + 2; uly++)
                {
                    for (ulx = ux - 1; ulx < ux + 2; ulx++)
                    {
                        blockdns[uly, ulx] = (byte)random.Next(5);
                    }
                }
                for (uly = uy - 1; uly < uy + 2; uly++)
                {
                    for (ulx = ux - 1; ulx < ux + 2; ulx++)
                    {
                        drawn[uly, ulx] = false;
                    }
                }
                for (uly = uy - 4; uly < uy + 5; uly++)
                {
                    for (ulx = ux - 4; ulx < ux + 5; ulx++)
                    {
                        for (int l = 0; l < 3; l += 2)
                        {
                            if (uly >= 0 && uly < HEIGHT && blocks[l][uly, ulx] == 16)
                            {
                                keepLeaf = false;
                                for (uly2 = uly - 4; uly2 < uly + 5; uly2++)
                                {
                                    for (ulx2 = ulx - 4; ulx2 < ulx + 5; ulx2++)
                                    {
                                        if (uly2 >= 0 && uly2 < HEIGHT && (blocks[1][uly2, ulx2] == 15 || blocks[1][uly2, ulx2] == 83))
                                        {
                                            keepLeaf = true;
                                            break;
                                        }
                                    }
                                    if (keepLeaf) break;
                                }
                                if (!keepLeaf)
                                {
                                    blocks[l][uly, ulx] = 0;
                                    blockds[l] = World.generate2b(blocks[l], blockds[l], ulx, uly);
                                    for (uly2 = uly - 1; uly2 < uly + 2; uly2++)
                                    {
                                        for (ulx2 = ulx - 1; ulx2 < ulx + 2; ulx2++)
                                        {
                                            drawn[uly2, ulx2] = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                while (true)
                {
                    if (TORCHESR.ContainsKey(ITEMBLOCKS[BLOCKDROPS[blocks[layer][uy, ux - 1]]]) && TORCHESR[ITEMBLOCKS[BLOCKDROPS[blocks[layer][uy, ux - 1]]]] == blocks[layer][uy, ux - 1] || BLOCKDROPS.ContainsKey(blocks[layer][uy, ux - 1]) && (BLOCKDROPS[blocks[layer][uy, ux - 1]] == 178 || BLOCKDROPS[blocks[layer][uy, ux - 1]] == 182))
                    {
                        entities.Add(new Entity((ux - 1) * BLOCKSIZE, uy * BLOCKSIZE, random.NextDouble() * 4 - 2, -2, BLOCKDROPS[blocks[layer][uy, ux - 1]], (short)1));
                        removeBlockLighting(ux - 1, uy);
                        if (layer == 1)
                        {
                            addSunLighting(ux - 1, uy);
                        }
                        blockTemp = blocks[layer][uy, ux - 1];
                        blocks[layer][uy, ux - 1] = 0;
                        if (blockTemp >= 94 && blockTemp <= 99)
                        {
                            redoBlockPower(ux, uy, layer);
                        }
                        if (powers[blockTemp])
                        {
                            removeBlockPower(ux, uy, layer);
                        }
                        drawn[uy, ux - 1] = false;
                    }
                    if (TORCHESL.ContainsKey(ITEMBLOCKS[BLOCKDROPS[blocks[layer][uy, ux + 1]]]) && TORCHESL[ITEMBLOCKS[BLOCKDROPS[blocks[layer][uy, ux + 1]]]] == blocks[layer][uy, ux + 1] || BLOCKDROPS.ContainsKey(blocks[layer][uy, ux + 1]) && (BLOCKDROPS[blocks[layer][uy, ux + 1]] == 178 || BLOCKDROPS[blocks[layer][uy, ux + 1]] == 182))
                    {
                        entities.Add(new Entity((ux + 1) * BLOCKSIZE, uy * BLOCKSIZE, random.NextDouble() * 4 - 2, -2, BLOCKDROPS[blocks[layer][uy, ux + 1]], (short)1));
                        removeBlockLighting(ux + 1, uy);
                        if (layer == 1)
                        {
                            addSunLighting(ux + 1, uy);
                        }
                        blockTemp = blocks[layer][uy, ux + 1];
                        blocks[layer][uy, ux + 1] = 0;
                        if (blockTemp >= 94 && blockTemp <= 99)
                        {
                            redoBlockPower(ux, uy, layer);
                        }
                        if (powers[blockTemp])
                        {
                            removeBlockPower(ux, uy, layer);
                        }
                        drawn[uy, ux + 1] = false;
                    }
                    uy -= 1;
                    if (uy == -1 || !GSUPPORT[blocks[layer][uy, ux]])
                    {
                        addSunLighting(ux, uy);
                        break;
                    }
                    if (BLOCKDROPS[blocks[layer][uy, ux]] != 0)
                    {
                        entities.Add(new Entity(ux * BLOCKSIZE, uy * BLOCKSIZE, random.NextDouble() * 4 - 2, -2, BLOCKDROPS[blocks[layer][uy, ux]], (short)1));
                    }
                    t = 0;
                    switch (blocks[layer][uy, ux])
                    {
                        case 48: t = 77; n = random.Next(4) - 2; break;
                        case 49: t = 77; n = random.Next(2); break;
                        case 50: t = 77; n = random.Next(3) + 1; break;
                        case 51: t = 79; n = random.Next(4) - 2; break;
                        case 52: t = 79; n = random.Next(2); break;
                        case 53: t = 79; n = random.Next(3) + 1; break;
                        case 54: t = 81; n = random.Next(4) - 2; break;
                        case 55: t = 81; n = random.Next(2); break;
                        case 56: t = 81; n = random.Next(3) + 1; break;
                        case 57: t = 83; n = random.Next(4) - 2; break;
                        case 58: t = 83; n = random.Next(2); break;
                        case 59: t = 83; n = random.Next(3) + 1; break;
                        case 60: t = 85; n = random.Next(4) - 2; break;
                        case 61: t = 85; n = random.Next(2); break;
                        case 62: t = 85; n = random.Next(3) + 1; break;
                        case 63: t = 87; n = random.Next(4) - 2; break;
                        case 64: t = 87; n = random.Next(2); break;
                        case 65: t = 87; n = random.Next(3) + 1; break;
                        case 66: t = 89; n = random.Next(4) - 2; break;
                        case 67: t = 89; n = random.Next(2); break;
                        case 68: t = 89; n = random.Next(3) + 1; break;
                        case 69: t = 91; n = random.Next(4) - 2; break;
                        case 70: t = 91; n = random.Next(2); break;
                        case 71: t = 91; n = random.Next(3) + 1; break;
                        case 77: t = 95; n = random.Next(4) - 2; break;
                        case 78: t = 95; n = random.Next(2); break;
                        case 79: t = 95; n = random.Next(3) + 1; break;
                        default: break;
                    }
                    if (t != 0)
                    {
                        for (i = 0; i < Math.Max(1, n); i++)
                        {
                            entities.Add(new Entity(ux * BLOCKSIZE, uy * BLOCKSIZE, random.NextDouble() * 4 - 2, -2, (short)t, (short)1));
                        }
                    }
                    removeBlockLighting(ux, uy);
                    blockTemp = blocks[layer][uy, ux];
                    blocks[layer][uy, ux] = 0;
                    if (blockTemp >= 94 && blockTemp <= 99)
                    {
                        redoBlockPower(ux, uy, layer);
                    }
                    if (powers[blockTemp])
                    {
                        removeBlockPower(ux, uy, layer);
                    }
                    if (ltrans[blockTemp])
                    {
                        addSunLighting(ux, uy);
                        redoBlockLighting(ux, uy);
                    }
                    addSunLighting(ux, uy);
                    blockds[layer] = World.generate2b(blocks[layer], blockds[layer], ux, uy);
                    for (uly = uy - 1; uly < uy + 2; uly++)
                    {
                        for (ulx = ux - 1; ulx < ux + 2; ulx++)
                        {
                            blockdns[uly, ulx] = (byte)random.Next(5);
                        }
                    }
                    for (uly = uy - 1; uly < uy + 2; uly++)
                    {
                        for (ulx = ux - 1; ulx < ux + 2; ulx++)
                        {
                            drawn[uly, ulx] = false;
                        }
                    }
                    for (uly = uy - 4; uly < uy + 5; uly++)
                    {
                        for (ulx = ux - 4; ulx < ux + 5; ulx++)
                        {
                            for (int l = 0; l < 3; l += 2)
                            {
                                if (uly >= 0 && uly < HEIGHT && blocks[l][uly, ulx] == 16)
                                {
                                    keepLeaf = false;
                                    for (uly2 = uly - 4; uly2 < uly + 5; uly2++)
                                    {
                                        for (ulx2 = ulx - 4; ulx2 < ulx + 5; ulx2++)
                                        {
                                            if (uly2 >= 0 && uly2 < HEIGHT && (blocks[1][uly2, ulx2] == 15 || blocks[1][uly2, ulx2] == 83))
                                            {
                                                keepLeaf = true;
                                                break;
                                            }
                                        }
                                        if (keepLeaf) break;
                                    }
                                    if (!keepLeaf)
                                    {
                                        blocks[l][uly, ulx] = 0;
                                        blockds[l] = World.generate2b(blocks[l], blockds[l], ulx, uly);
                                        for (uly2 = uly - 1; uly2 < uly + 2; uly2++)
                                        {
                                            for (ulx2 = ulx - 1; ulx2 < ulx + 2; ulx2++)
                                            {
                                                drawn[uly2, ulx2] = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                mining = 0;
            }
        }

        public void updateEnvironment()
        {
            timeOfDay += 1.2 * DEBUG_ACCEL;
            for (i = cloudsx.Count - 1; i > -1; i--)
            {
                cloudsx[i] = cloudsx[i] + cloudsv[i];
                if (cloudsx[i] < -250 || cloudsx[i] > getWidth() + 250)
                {
                    cloudsx.RemoveAt(i);
                    cloudsy.RemoveAt(i);
                    cloudsv.RemoveAt(i);
                    cloudsn.RemoveAt(i);
                }
            }
            if (random.Next((int)(1500 / DEBUG_ACCEL)) == 0)
            {
                cloudsn.Add(random.Next(1));
                cloud = clouds[cloudsn[cloudsn.Count - 1]];
                if (random.Next(2) == 0)
                {
                    cloudsx.Add((double)(-cloud.Width * 2));
                    cloudsv.Add((double)(0.1 * DEBUG_ACCEL));
                }
                else
                {
                    cloudsx.Add((double)getWidth());
                    cloudsv.Add((double)(-0.1 * DEBUG_ACCEL));
                }
                cloudsy.Add(random.NextDouble() * (getHeight() - cloud.Height) + cloud.Height);
            }
        }

        public void addBlockLighting(int ux, int uy)
        {
            n = findNonLayeredBlockLightSource(ux, uy);
            if (n != 0)
            {
                addTileToZQueue(ux, uy);
                lights[uy, ux] = Math.Max(lights[uy, ux], n);
                lsources[uy, ux] = true;
                addTileToQueue(ux, uy);
            }
        }

        public void addBlockPower(int ux, int uy)
        {
            if (powers[blocks[1][uy, ux]])
            {
                if (blocks[1][uy, ux] >= 137 && blocks[1][uy, ux] <= 168)
                {
                    print("Whaaat?");
                    updatex.Add(ux);
                    updatey.Add(uy);
                    updatet.Add(DDELAY[blocks[1][uy, ux]]);
                    updatel.Add(1);
                }
                else
                {
                    addTileToPZQueue(ux, uy);
                    power[1, uy, ux] = (float)5;
                    if (conducts[blocks[1][uy, ux]] >= 0 && wcnct[uy, ux])
                    {
                        if (receives[blocks[0][uy, ux]])
                        {
                            power[0, uy, ux] = power[1, uy, ux] - (float)conducts[blocks[1][uy, ux]];
                        }
                        if (receives[blocks[2][uy, ux]])
                        {
                            power[2, uy, ux] = power[1, uy, ux] - (float)conducts[blocks[1][uy, ux]];
                        }
                    }
                    addTileToPQueue(ux, uy);
                }
            }
            if (powers[blocks[0][uy, ux]])
            {
                if (blocks[0][uy, ux] >= 137 && blocks[0][uy, ux] <= 168)
                {
                    print("Whaaat?");
                    updatex.Add(ux);
                    updatey.Add(uy);
                    updatet.Add(DDELAY[blocks[0][uy, ux]]);
                    updatel.Add(0);
                }
                else
                {
                    addTileToPZQueue(ux, uy);
                    power[0, uy, ux] = (float)5;
                    if (conducts[blocks[0][uy, ux]] >= 0 && wcnct[uy, ux])
                    {
                        if (receives[blocks[1][uy, ux]])
                        {
                            power[1, uy, ux] = power[0, uy, ux] - (float)conducts[blocks[0][uy, ux]];
                        }
                        if (receives[blocks[2][uy, ux]])
                        {
                            power[2, uy, ux] = power[0, uy, ux] - (float)conducts[blocks[0][uy, ux]];
                        }
                    }
                    addTileToPQueue(ux, uy);
                }
            }
            if (powers[blocks[2][uy, ux]])
            {
                if (blocks[2][uy, ux] >= 137 && blocks[2][uy, ux] <= 168)
                {
                    print("Whaaat?");
                    updatex.Add(ux);
                    updatey.Add(uy);
                    updatet.Add(DDELAY[blocks[2][uy, ux]]);
                    updatel.Add(2);
                }
                else
                {
                    addTileToPZQueue(ux, uy);
                    power[2, uy, ux] = (float)5;
                    if (conducts[blocks[2][uy, ux]] >= 0 && wcnct[uy, ux])
                    {
                        if (receives[blocks[0][uy, ux]])
                        {
                            power[0, uy, ux] = power[2, uy, ux] - (float)conducts[blocks[2][uy, ux]];
                        }
                        if (receives[blocks[1][uy, ux]])
                        {
                            power[1, uy, ux] = power[2, uy, ux] - (float)conducts[blocks[2][uy, ux]];
                        }
                    }
                    addTileToPQueue(ux, uy);
                }
            }
        }

        public void removeBlockLighting(int ux, int uy)
        {
            removeBlockLighting(ux, uy, layer);
        }

        public void removeBlockLighting(int ux, int uy, int layer)
        {
            n = findNonLayeredBlockLightSource(ux, uy);
            if (n != 0)
            {
                lsources[uy, ux] = isNonLayeredBlockLightSource(ux, uy, layer);
                for (axl = -n; axl < n + 1; axl++)
                {
                    for (ayl = -n; ayl < n + 1; ayl++)
                    {
                        if (Math.Abs(axl) + Math.Abs(ayl) <= n && uy + ayl >= 0 && uy + ayl < HEIGHT && lights[uy + ayl, ux + axl] != 0)
                        {
                            addTileToZQueue(ux + axl, uy + ayl);
                            lights[uy + ayl, ux + axl] = (float)0;
                        }
                    }
                }
                for (axl = -n - BRIGHTEST; axl < n + 1 + BRIGHTEST; axl++)
                {
                    for (ayl = -n - BRIGHTEST; ayl < n + 1 + BRIGHTEST; ayl++)
                    {
                        if (Math.Abs(axl) + Math.Abs(ayl) <= n + BRIGHTEST && uy + ayl >= 0 && uy + ayl < HEIGHT)
                        {
                            if (lsources[uy + ayl, ux + axl])
                            {
                                addTileToQueue(ux + axl, uy + ayl);
                            }
                        }
                    }
                }
            }
        }

        public void rbpRecur(int ux, int uy, int lyr)
        {
            arbprd[lyr, uy, ux] = true;
            print("[rbpR] " + ux + " " + uy);
            addTileToPZQueue(ux, uy);
            bool[] remember = { false, false, false, false };
            int ax3, ay3;
            for (int ir = 0; ir < 4; ir++)
            {
                ax3 = ux + cl[ir][0];
                ay3 = uy + cl[ir][1];
                if (ay3 >= 0 && ay3 < HEIGHT && power[lyr, ay3, ax3] != 0)
                {
                    if (power[lyr, ay3, ax3] != 0 && !(power[lyr, ay3, ax3] == power[lyr,uy, ux] - conducts[blocks[lyr][uy, ux]]) &&
                     (!(blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 || blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126) ||
                      !(blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && ux > ax3 && blocks[lyr][ay3, ax3] != 111 && blocks[lyr][ay3, ax3] != 115 ||
                        blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && uy > ay3 && blocks[lyr][ay3, ax3] != 112 && blocks[lyr][ay3, ax3] != 116 ||
                        blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && ux < ax3 && blocks[lyr][ay3, ax3] != 113 && blocks[lyr][ay3, ax3] != 117 ||
                        blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && uy < ay3 && blocks[lyr][ay3, ax3] != 114 && blocks[lyr][ay3, ax3] != 118) &&
                      !(blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && ux > ax3 && blocks[lyr][ay3, ax3] != 119 && blocks[lyr][ay3, ax3] != 123 ||
                        blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && uy > ay3 && blocks[lyr][ay3, ax3] != 120 && blocks[lyr][ay3, ax3] != 124 ||
                        blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && ux < ax3 && blocks[lyr][ay3, ax3] != 121 && blocks[lyr][ay3, ax3] != 125 ||
                        blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && uy < ay3 && blocks[lyr][ay3, ax3] != 122 && blocks[lyr][ay3, ax3] != 126) &&
                      !(blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && ux > ax3 && blocks[lyr][ay3, ax3] != 137 && blocks[lyr][ay3, ax3] != 141 && blocks[lyr][ay3, ax3] != 145 && blocks[lyr][ay3, ax3] != 149 && blocks[lyr][ay3, ax3] != 153 && blocks[lyr][ay3, ax3] != 157 && blocks[lyr][ay3, ax3] != 161 && blocks[lyr][ay3, ax3] != 165 ||
                        blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && uy > ay3 && blocks[lyr][ay3, ax3] != 138 && blocks[lyr][ay3, ax3] != 142 && blocks[lyr][ay3, ax3] != 146 && blocks[lyr][ay3, ax3] != 150 && blocks[lyr][ay3, ax3] != 154 && blocks[lyr][ay3, ax3] != 158 && blocks[lyr][ay3, ax3] != 162 && blocks[lyr][ay3, ax3] != 166 ||
                        blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && ux < ax3 && blocks[lyr][ay3, ax3] != 139 && blocks[lyr][ay3, ax3] != 143 && blocks[lyr][ay3, ax3] != 147 && blocks[lyr][ay3, ax3] != 151 && blocks[lyr][ay3, ax3] != 155 && blocks[lyr][ay3, ax3] != 159 && blocks[lyr][ay3, ax3] != 163 && blocks[lyr][ay3, ax3] != 167 ||
                        blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && uy < ay3 && blocks[lyr][ay3, ax3] != 140 && blocks[lyr][ay3, ax3] != 144 && blocks[lyr][ay3, ax3] != 148 && blocks[lyr][ay3, ax3] != 152 && blocks[lyr][ay3, ax3] != 156 && blocks[lyr][ay3, ax3] != 160 && blocks[lyr][ay3, ax3] != 164 && blocks[lyr][ay3, ax3] != 168)))
                    {
                        print("Added tile " + ax3 + " " + ay3 + " to PQueue.");
                        addTileToPQueue(ax3, ay3);
                        remember[ir] = true;
                    }
                }
            }
            for (int ir = 0; ir < 4; ir++)
            {
                print("[liek srsly man?] " + ir);
                ax3 = ux + cl[ir][0];
                ay3 = uy + cl[ir][1];
                print("[rpbRecur2] " + ax3 + " " + ay3 + " " + power[lyr, ay3, ax3]);
                if (ay3 >= 0 && ay3 < HEIGHT && power[lyr, ay3, ax3] != 0)
                {
                    print("[rbpRecur] " + power[lyr, ay3, ax3] + " " + power[lyr, uy, ux] + " " + conducts[blocks[lyr][uy, ux]]);
                    if ((power[lyr, ay3, ax3] == power[lyr, uy, ux] - conducts[blocks[lyr][uy, ux]]) &&
                     (!(blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 || blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126) ||
                      !(blocks[lyr][uy, ux] >= 111 && blocks[lyr][uy, ux] <= 118 && ux < ax3 && blocks[lyr][uy, ux] != 111 && blocks[lyr][uy, ux] != 115 ||
                        blocks[lyr][uy, ux] >= 111 && blocks[lyr][uy, ux] <= 118 && uy < ay3 && blocks[lyr][uy, ux] != 112 && blocks[lyr][uy, ux] != 116 ||
                        blocks[lyr][uy, ux] >= 111 && blocks[lyr][uy, ux] <= 118 && ux > ax3 && blocks[lyr][uy, ux] != 113 && blocks[lyr][uy, ux] != 117 ||
                        blocks[lyr][uy, ux] >= 111 && blocks[lyr][uy, ux] <= 118 && uy > ay3 && blocks[lyr][uy, ux] != 114 && blocks[lyr][uy, ux] != 118) &&
                      !(blocks[lyr][uy, ux] >= 119 && blocks[lyr][uy, ux] <= 126 && ux < ax3 && blocks[lyr][uy, ux] != 119 && blocks[lyr][uy, ux] != 123 ||
                        blocks[lyr][uy, ux] >= 119 && blocks[lyr][uy, ux] <= 126 && uy < ay3 && blocks[lyr][uy, ux] != 120 && blocks[lyr][uy, ux] != 124 ||
                        blocks[lyr][uy, ux] >= 119 && blocks[lyr][uy, ux] <= 126 && ux > ax3 && blocks[lyr][uy, ux] != 121 && blocks[lyr][uy, ux] != 125 ||
                        blocks[lyr][uy, ux] >= 119 && blocks[lyr][uy, ux] <= 126 && uy > ay3 && blocks[lyr][uy, ux] != 122 && blocks[lyr][uy, ux] != 126) &&
                      !(blocks[lyr][uy, ux] >= 137 && blocks[lyr][uy, ux] <= 168 && ux < ax3 && blocks[lyr][uy, ux] != 137 && blocks[lyr][uy, ux] != 141 && blocks[lyr][uy, ux] != 145 && blocks[lyr][uy, ux] != 149 && blocks[lyr][uy, ux] != 153 && blocks[lyr][uy, ux] != 157 && blocks[lyr][uy, ux] != 161 && blocks[lyr][uy, ux] != 165 ||
                        blocks[lyr][uy, ux] >= 137 && blocks[lyr][uy, ux] <= 168 && uy < ay3 && blocks[lyr][uy, ux] != 138 && blocks[lyr][uy, ux] != 142 && blocks[lyr][uy, ux] != 146 && blocks[lyr][uy, ux] != 150 && blocks[lyr][uy, ux] != 154 && blocks[lyr][uy, ux] != 158 && blocks[lyr][uy, ux] != 162 && blocks[lyr][uy, ux] != 166 ||
                        blocks[lyr][uy, ux] >= 137 && blocks[lyr][uy, ux] <= 168 && ux > ax3 && blocks[lyr][uy, ux] != 139 && blocks[lyr][uy, ux] != 143 && blocks[lyr][uy, ux] != 147 && blocks[lyr][uy, ux] != 151 && blocks[lyr][uy, ux] != 155 && blocks[lyr][uy, ux] != 159 && blocks[lyr][uy, ux] != 163 && blocks[lyr][uy, ux] != 167 ||
                        blocks[lyr][uy, ux] >= 137 && blocks[lyr][uy, ux] <= 168 && uy > ay3 && blocks[lyr][uy, ux] != 140 && blocks[lyr][uy, ux] != 144 && blocks[lyr][uy, ux] != 148 && blocks[lyr][uy, ux] != 152 && blocks[lyr][uy, ux] != 156 && blocks[lyr][uy, ux] != 160 && blocks[lyr][uy, ux] != 164 && blocks[lyr][uy, ux] != 168)))
                    {
                        if (!arbprd[lyr, ay3, ax3])
                        {
                            rbpRecur(ax3, ay3, lyr);
                            if (conducts[blocks[lyr][ay3, ax3]] >= 0 && wcnct[ay3, ax3])
                            {
                                if (lyr == 0)
                                {
                                    if (receives[blocks[1][ay3, ax3]])
                                    {
                                        rbpRecur(ax3, ay3, 1);
                                        if (powers[blocks[1][ay3, ax3]])
                                        {
                                            addTileToPQueue(ax3, ay3);
                                        }
                                    }
                                    if (receives[blocks[2][ay3, ax3]])
                                    {
                                        rbpRecur(ax3, ay3, 2);
                                        if (powers[blocks[2][ay3, ax3]])
                                        {
                                            addTileToPQueue(ax3, ay3);
                                        }
                                    }
                                }
                                if (lyr == 1)
                                {
                                    if (receives[blocks[0][ay3, ax3]])
                                    {
                                        rbpRecur(ax3, ay3, 0);
                                        if (powers[blocks[0][ay3, ax3]])
                                        {
                                            addTileToPQueue(ax3, ay3);
                                        }
                                    }
                                    if (receives[blocks[2][ay3, ax3]])
                                    {
                                        rbpRecur(ax3, ay3, 2);
                                        if (powers[blocks[2][ay3, ax3]])
                                        {
                                            addTileToPQueue(ax3, ay3);
                                        }
                                    }
                                }
                                if (lyr == 2)
                                {
                                    if (receives[blocks[0][ay3, ax3]])
                                    {
                                        rbpRecur(ax3, ay3, 0);
                                        if (powers[blocks[0][ay3, ax3]])
                                        {
                                            addTileToPQueue(ax3, ay3);
                                        }
                                    }
                                    if (receives[blocks[1][ay3, ax3]])
                                    {
                                        rbpRecur(ax3, ay3, 1);
                                        if (powers[blocks[1][ay3, ax3]])
                                        {
                                            addTileToPQueue(ax3, ay3);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (blocks[lyr][ay3, ax3] == 104 || (blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 || blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 || blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168) &&
                  !(blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && ux < ax3 && blocks[lyr][ay3, ax3] != 111 && blocks[lyr][ay3, ax3] != 115 ||
                    blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && uy < ay3 && blocks[lyr][ay3, ax3] != 112 && blocks[lyr][ay3, ax3] != 116 ||
                    blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && ux > ax3 && blocks[lyr][ay3, ax3] != 113 && blocks[lyr][ay3, ax3] != 117 ||
                    blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && uy > ay3 && blocks[lyr][ay3, ax3] != 114 && blocks[lyr][ay3, ax3] != 118) &&
                  !(blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && ux < ax3 && blocks[lyr][ay3, ax3] != 119 && blocks[lyr][ay3, ax3] != 123 ||
                    blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && uy < ay3 && blocks[lyr][ay3, ax3] != 120 && blocks[lyr][ay3, ax3] != 124 ||
                    blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && ux > ax3 && blocks[lyr][ay3, ax3] != 121 && blocks[lyr][ay3, ax3] != 125 ||
                    blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && uy > ay3 && blocks[lyr][ay3, ax3] != 122 && blocks[lyr][ay3, ax3] != 126) &&
                  !(blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && ux < ax3 && blocks[lyr][ay3, ax3] != 137 && blocks[lyr][ay3, ax3] != 141 && blocks[lyr][ay3, ax3] != 145 && blocks[lyr][ay3, ax3] != 149 && blocks[lyr][ay3, ax3] != 153 && blocks[lyr][ay3, ax3] != 157 && blocks[lyr][ay3, ax3] != 161 && blocks[lyr][ay3, ax3] != 165 ||
                    blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && uy < ay3 && blocks[lyr][ay3, ax3] != 138 && blocks[lyr][ay3, ax3] != 142 && blocks[lyr][ay3, ax3] != 146 && blocks[lyr][ay3, ax3] != 150 && blocks[lyr][ay3, ax3] != 154 && blocks[lyr][ay3, ax3] != 158 && blocks[lyr][ay3, ax3] != 162 && blocks[lyr][ay3, ax3] != 166 ||
                    blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && ux > ax3 && blocks[lyr][ay3, ax3] != 139 && blocks[lyr][ay3, ax3] != 143 && blocks[lyr][ay3, ax3] != 147 && blocks[lyr][ay3, ax3] != 151 && blocks[lyr][ay3, ax3] != 155 && blocks[lyr][ay3, ax3] != 159 && blocks[lyr][ay3, ax3] != 163 && blocks[lyr][ay3, ax3] != 167 ||
                    blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && uy > ay3 && blocks[lyr][ay3, ax3] != 140 && blocks[lyr][ay3, ax3] != 144 && blocks[lyr][ay3, ax3] != 148 && blocks[lyr][ay3, ax3] != 152 && blocks[lyr][ay3, ax3] != 156 && blocks[lyr][ay3, ax3] != 160 && blocks[lyr][ay3, ax3] != 164 && blocks[lyr][ay3, ax3] != 168))
                {
                    if (blocks[lyr][ay3, ax3] >= 123 && blocks[lyr][ay3, ax3] <= 126)
                    {
                        blocks[lyr][ay3, ax3] -= 4;
                        print("Adding power for inverter at (" + ax3 + ", " + ay3 + ").");
                        addBlockPower(ax3, ay3);
                        addBlockLighting(ax3, ay3);
                        rdrawn[ay3, ax3] = false;
                    }
                    removeBlockPower(ax3, ay3, lyr);
                }
            }
            for (int ir = 0; ir < 4; ir++)
            {
                if (remember[ir] && uy + cl[ir][1] >= 0 && uy + cl[ir][1] < HEIGHT)
                {
                    power[lyr, uy + cl[ir][1], ux + cl[ir][0]] = (float)5;
                }
            }
            power[lyr, uy, ux] = (float)0;
            arbprd[lyr, uy, ux] = false;
        }

        public void removeBlockPower(int ux, int uy, int lyr)
        {
            removeBlockPower(ux, uy, lyr, true);
        }

        public void removeBlockPower(int ux, int uy, int lyr, bool turnOffDelayer)
        {
            arbprd[lyr, uy, ux] = true;
            print("[rbp ] " + ux + " " + uy + " " + lyr + " " + turnOffDelayer);
            if (!((blocks[lyr][uy, ux] >= 141 && blocks[lyr][uy, ux] <= 144 || blocks[lyr][uy, ux] >= 149 && blocks[lyr][uy, ux] <= 152 || blocks[lyr][uy, ux] >= 157 && blocks[lyr][uy, ux] <= 160 || blocks[lyr][uy, ux] >= 165 && blocks[lyr][uy, ux] <= 168) && turnOffDelayer))
            {
                int ax3, ay3;
                for (int ir = 0; ir < 4; ir++)
                {
                    ax3 = ux + cl[ir][0];
                    ay3 = uy + cl[ir][1];
                    if (ay3 >= 0 && ay3 < HEIGHT && power[lyr, ay3, ax3] != 0)
                    {
                        if (!(power[lyr, ay3, ax3] == power[lyr, uy, ux] - conducts[blocks[lyr][uy, ux]]) &&
                         (!(blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 || blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126) ||
                          !(blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && ux > ax3 && blocks[lyr][ay3, ax3] != 111 && blocks[lyr][ay3, ax3] != 115 ||
                            blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && uy > ay3 && blocks[lyr][ay3, ax3] != 112 && blocks[lyr][ay3, ax3] != 116 ||
                            blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && ux < ax3 && blocks[lyr][ay3, ax3] != 113 && blocks[lyr][ay3, ax3] != 117 ||
                            blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && uy < ay3 && blocks[lyr][ay3, ax3] != 114 && blocks[lyr][ay3, ax3] != 118) &&
                          !(blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && ux > ax3 && blocks[lyr][ay3, ax3] != 119 && blocks[lyr][ay3, ax3] != 123 ||
                            blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && uy > ay3 && blocks[lyr][ay3, ax3] != 120 && blocks[lyr][ay3, ax3] != 124 ||
                            blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && ux < ax3 && blocks[lyr][ay3, ax3] != 121 && blocks[lyr][ay3, ax3] != 125 ||
                            blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && uy < ay3 && blocks[lyr][ay3, ax3] != 122 && blocks[lyr][ay3, ax3] != 126) &&
                          !(blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && ux > ax3 && blocks[lyr][ay3, ax3] != 137 && blocks[lyr][ay3, ax3] != 141 && blocks[lyr][ay3, ax3] != 145 && blocks[lyr][ay3, ax3] != 149 && blocks[lyr][ay3, ax3] != 153 && blocks[lyr][ay3, ax3] != 157 && blocks[lyr][ay3, ax3] != 161 && blocks[lyr][ay3, ax3] != 165 ||
                            blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && uy > ay3 && blocks[lyr][ay3, ax3] != 138 && blocks[lyr][ay3, ax3] != 142 && blocks[lyr][ay3, ax3] != 146 && blocks[lyr][ay3, ax3] != 150 && blocks[lyr][ay3, ax3] != 154 && blocks[lyr][ay3, ax3] != 158 && blocks[lyr][ay3, ax3] != 162 && blocks[lyr][ay3, ax3] != 166 ||
                            blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && ux < ax3 && blocks[lyr][ay3, ax3] != 139 && blocks[lyr][ay3, ax3] != 143 && blocks[lyr][ay3, ax3] != 147 && blocks[lyr][ay3, ax3] != 151 && blocks[lyr][ay3, ax3] != 155 && blocks[lyr][ay3, ax3] != 159 && blocks[lyr][ay3, ax3] != 163 && blocks[lyr][ay3, ax3] != 167 ||
                            blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && uy < ay3 && blocks[lyr][ay3, ax3] != 140 && blocks[lyr][ay3, ax3] != 144 && blocks[lyr][ay3, ax3] != 148 && blocks[lyr][ay3, ax3] != 152 && blocks[lyr][ay3, ax3] != 156 && blocks[lyr][ay3, ax3] != 160 && blocks[lyr][ay3, ax3] != 164 && blocks[lyr][ay3, ax3] != 168)))
                        {
                            print("Added tile " + ax3 + " " + ay3 + " to PQueue.");
                            addTileToPQueue(ax3, ay3);
                        }
                    }
                }
                for (int ir = 0; ir < 4; ir++)
                {
                    ax3 = ux + cl[ir][0];
                    ay3 = uy + cl[ir][1];
                    print(blocks[lyr][ay3, ax3] + " " + power[lyr, ay3, ax3]);
                    if (ay3 >= 0 && ay3 < HEIGHT && power[lyr, ay3, ax3] != 0)
                    {
                        print(power[lyr, uy, ux] + " " + power[lyr, ay3, ax3] + " " + conducts[blocks[lyr][uy, ux]]);
                        if (power[lyr, ay3, ax3] == power[lyr, uy, ux] - conducts[blocks[lyr][uy, ux]])
                        {
                            if (!(blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 || blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126) ||
                              !(blocks[lyr][uy, ux] >= 111 && blocks[lyr][uy, ux] <= 118 && ux < ax3 && blocks[lyr][uy, ux] != 111 && blocks[lyr][uy, ux] != 115 ||
                                blocks[lyr][uy, ux] >= 111 && blocks[lyr][uy, ux] <= 118 && uy < ay3 && blocks[lyr][uy, ux] != 112 && blocks[lyr][uy, ux] != 116 ||
                                blocks[lyr][uy, ux] >= 111 && blocks[lyr][uy, ux] <= 118 && ux > ax3 && blocks[lyr][uy, ux] != 113 && blocks[lyr][uy, ux] != 117 ||
                                blocks[lyr][uy, ux] >= 111 && blocks[lyr][uy, ux] <= 118 && uy > ay3 && blocks[lyr][uy, ux] != 114 && blocks[lyr][uy, ux] != 118) &&
                              !(blocks[lyr][uy, ux] >= 119 && blocks[lyr][uy, ux] <= 126 && ux < ax3 && blocks[lyr][uy, ux] != 119 && blocks[lyr][uy, ux] != 123 ||
                                blocks[lyr][uy, ux] >= 119 && blocks[lyr][uy, ux] <= 126 && uy < ay3 && blocks[lyr][uy, ux] != 120 && blocks[lyr][uy, ux] != 124 ||
                                blocks[lyr][uy, ux] >= 119 && blocks[lyr][uy, ux] <= 126 && ux > ax3 && blocks[lyr][uy, ux] != 121 && blocks[lyr][uy, ux] != 125 ||
                                blocks[lyr][uy, ux] >= 119 && blocks[lyr][uy, ux] <= 126 && uy > ay3 && blocks[lyr][uy, ux] != 122 && blocks[lyr][uy, ux] != 126) &&
                              !(blocks[lyr][uy, ux] >= 137 && blocks[lyr][uy, ux] <= 168 && ux < ax3 && blocks[lyr][uy, ux] != 137 && blocks[lyr][uy, ux] != 141 && blocks[lyr][uy, ux] != 145 && blocks[lyr][uy, ux] != 149 && blocks[lyr][uy, ux] != 153 && blocks[lyr][uy, ux] != 157 && blocks[lyr][uy, ux] != 161 && blocks[lyr][uy, ux] != 165 ||
                                blocks[lyr][uy, ux] >= 137 && blocks[lyr][uy, ux] <= 168 && uy < ay3 && blocks[lyr][uy, ux] != 138 && blocks[lyr][uy, ux] != 142 && blocks[lyr][uy, ux] != 146 && blocks[lyr][uy, ux] != 150 && blocks[lyr][uy, ux] != 154 && blocks[lyr][uy, ux] != 158 && blocks[lyr][uy, ux] != 162 && blocks[lyr][uy, ux] != 166 ||
                                blocks[lyr][uy, ux] >= 137 && blocks[lyr][uy, ux] <= 168 && ux > ax3 && blocks[lyr][uy, ux] != 139 && blocks[lyr][uy, ux] != 143 && blocks[lyr][uy, ux] != 147 && blocks[lyr][uy, ux] != 151 && blocks[lyr][uy, ux] != 155 && blocks[lyr][uy, ux] != 159 && blocks[lyr][uy, ux] != 163 && blocks[lyr][uy, ux] != 167 ||
                                blocks[lyr][uy, ux] >= 137 && blocks[lyr][uy, ux] <= 168 && uy > ay3 && blocks[lyr][uy, ux] != 140 && blocks[lyr][uy, ux] != 144 && blocks[lyr][uy, ux] != 148 && blocks[lyr][uy, ux] != 152 && blocks[lyr][uy, ux] != 156 && blocks[lyr][uy, ux] != 160 && blocks[lyr][uy, ux] != 164 && blocks[lyr][uy, ux] != 168))
                            {
                                if (!arbprd[lyr, ay3, ax3])
                                {
                                    rbpRecur(ax3, ay3, lyr);
                                    if (conducts[blocks[lyr][ay3, ax3]] >= 0 && wcnct[ay3, ax3])
                                    {
                                        if (lyr == 0)
                                        {
                                            if (receives[blocks[1][ay3, ax3]])
                                            {
                                                rbpRecur(ax3, ay3, 1);
                                                if (powers[blocks[1][ay3, ax3]])
                                                {
                                                    addTileToPQueue(ax3, ay3);
                                                }
                                            }
                                            if (receives[blocks[2][ay3, ax3]])
                                            {
                                                rbpRecur(ax3, ay3, 2);
                                                if (powers[blocks[2][ay3, ax3]])
                                                {
                                                    addTileToPQueue(ax3, ay3);
                                                }
                                            }
                                        }
                                        if (lyr == 1)
                                        {
                                            if (receives[blocks[0][ay3, ax3]])
                                            {
                                                rbpRecur(ax3, ay3, 0);
                                                if (powers[blocks[0][ay3, ax3]])
                                                {
                                                    addTileToPQueue(ax3, ay3);
                                                }
                                            }
                                            if (receives[blocks[2][ay3, ax3]])
                                            {
                                                rbpRecur(ax3, ay3, 2);
                                                if (powers[blocks[2][ay3, ax3]])
                                                {
                                                    addTileToPQueue(ax3, ay3);
                                                }
                                            }
                                        }
                                        if (lyr == 2)
                                        {
                                            if (receives[blocks[0][ay3, ax3]])
                                            {
                                                rbpRecur(ax3, ay3, 0);
                                                if (powers[blocks[0][ay3, ax3]])
                                                {
                                                    addTileToPQueue(ax3, ay3);
                                                }
                                            }
                                            if (receives[blocks[1][ay3, ax3]])
                                            {
                                                rbpRecur(ax3, ay3, 1);
                                                if (powers[blocks[1][ay3, ax3]])
                                                {
                                                    addTileToPQueue(ax3, ay3);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (blocks[lyr][ay3, ax3] == 104 || (blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 || blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 || blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168) &&
                      !(blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && ux < ax3 && blocks[lyr][ay3, ax3] != 111 && blocks[lyr][ay3, ax3] != 115 ||
                        blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && uy < ay3 && blocks[lyr][ay3, ax3] != 112 && blocks[lyr][ay3, ax3] != 116 ||
                        blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && ux > ax3 && blocks[lyr][ay3, ax3] != 113 && blocks[lyr][ay3, ax3] != 117 ||
                        blocks[lyr][ay3, ax3] >= 111 && blocks[lyr][ay3, ax3] <= 118 && uy > ay3 && blocks[lyr][ay3, ax3] != 114 && blocks[lyr][ay3, ax3] != 118) &&
                      !(blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && ux < ax3 && blocks[lyr][ay3, ax3] != 119 && blocks[lyr][ay3, ax3] != 123 ||
                        blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && uy < ay3 && blocks[lyr][ay3, ax3] != 120 && blocks[lyr][ay3, ax3] != 124 ||
                        blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && ux > ax3 && blocks[lyr][ay3, ax3] != 121 && blocks[lyr][ay3, ax3] != 125 ||
                        blocks[lyr][ay3, ax3] >= 119 && blocks[lyr][ay3, ax3] <= 126 && uy > ay3 && blocks[lyr][ay3, ax3] != 122 && blocks[lyr][ay3, ax3] != 126) &&
                      !(blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && ux < ax3 && blocks[lyr][ay3, ax3] != 137 && blocks[lyr][ay3, ax3] != 141 && blocks[lyr][ay3, ax3] != 145 && blocks[lyr][ay3, ax3] != 149 && blocks[lyr][ay3, ax3] != 153 && blocks[lyr][ay3, ax3] != 157 && blocks[lyr][ay3, ax3] != 161 && blocks[lyr][ay3, ax3] != 165 ||
                        blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && uy < ay3 && blocks[lyr][ay3, ax3] != 138 && blocks[lyr][ay3, ax3] != 142 && blocks[lyr][ay3, ax3] != 146 && blocks[lyr][ay3, ax3] != 150 && blocks[lyr][ay3, ax3] != 154 && blocks[lyr][ay3, ax3] != 158 && blocks[lyr][ay3, ax3] != 162 && blocks[lyr][ay3, ax3] != 166 ||
                        blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && ux > ax3 && blocks[lyr][ay3, ax3] != 139 && blocks[lyr][ay3, ax3] != 143 && blocks[lyr][ay3, ax3] != 147 && blocks[lyr][ay3, ax3] != 151 && blocks[lyr][ay3, ax3] != 155 && blocks[lyr][ay3, ax3] != 159 && blocks[lyr][ay3, ax3] != 163 && blocks[lyr][ay3, ax3] != 167 ||
                        blocks[lyr][ay3, ax3] >= 137 && blocks[lyr][ay3, ax3] <= 168 && uy > ay3 && blocks[lyr][ay3, ax3] != 140 && blocks[lyr][ay3, ax3] != 144 && blocks[lyr][ay3, ax3] != 148 && blocks[lyr][ay3, ax3] != 152 && blocks[lyr][ay3, ax3] != 156 && blocks[lyr][ay3, ax3] != 160 && blocks[lyr][ay3, ax3] != 164 && blocks[lyr][ay3, ax3] != 168))
                    {
                        if (blocks[lyr][ay3, ax3] >= 123 && blocks[lyr][ay3, ax3] <= 126)
                        {
                            blocks[lyr][ay3, ax3] -= 4;
                            print("Adding power for inverter at (" + ax3 + ", " + ay3 + ").");
                            addBlockPower(ax3, ay3);
                            addBlockLighting(ax3, ay3);
                            rdrawn[ay3, ax3] = false;
                        }
                        arbprd[lyr, uy, ux] = false;
                        removeBlockPower(ax3, ay3, lyr);
                    }
                }
            }
            if (blocks[lyr][uy, ux] == 104)
            {
                removeBlockLighting(ux, uy);
                blocks[lyr][uy, ux] = 103;
                rdrawn[uy, ux] = false;
            }
            if (blocks[lyr][uy, ux] >= 115 && blocks[lyr][uy, ux] <= 118)
            {
                blockTemp = blocks[lyr][uy, ux];
                blocks[lyr][uy, ux] -= 4;
                removeBlockPower(ux, uy, lyr);
                removeBlockLighting(ux, uy);
                rdrawn[uy, ux] = false;
            }
            if (turnOffDelayer && blocks[lyr][uy, ux] >= 137 && blocks[lyr][uy, ux] <= 168)
            {
                print("???");
                updatex.Add(ux);
                updatey.Add(uy);
                updatet.Add(DDELAY[blocks[lyr][uy, ux]]);
                updatel.Add(lyr);
            }
            if (!((blocks[lyr][uy, ux] >= 141 && blocks[lyr][uy, ux] <= 144 || blocks[lyr][uy, ux] >= 149 && blocks[lyr][uy, ux] <= 152 || blocks[lyr][uy, ux] >= 157 && blocks[lyr][uy, ux] <= 160 || blocks[lyr][uy, ux] >= 165 && blocks[lyr][uy, ux] <= 168) && turnOffDelayer))
            {
                power[lyr, uy, ux] = (float)0;
            }
            arbprd[lyr, uy, ux] = false;
        }

        public void redoBlockLighting(int ux, int uy)
        {
            for (ax = -BRIGHTEST; ax < BRIGHTEST + 1; ax++)
            {
                for (ay = -BRIGHTEST; ay < BRIGHTEST + 1; ay++)
                {
                    if (Math.Abs(ax) + Math.Abs(ay) <= BRIGHTEST && uy + ay >= 0 && uy + ay < HEIGHT)
                    {
                        addTileToZQueue(ux + ax, uy + ay);
                        lights[uy + ay, ux + ax] = (float)0;
                    }
                }
            }
            for (ax = -BRIGHTEST * 2; ax < BRIGHTEST * 2 + 1; ax++)
            {
                for (ay = -BRIGHTEST * 2; ay < BRIGHTEST * 2 + 1; ay++)
                {
                    if (Math.Abs(ax) + Math.Abs(ay) <= BRIGHTEST * 2 && uy + ay >= 0 && uy + ay < HEIGHT)
                    {
                        if (lsources[uy + ay, ux + ax])
                        {
                            addTileToQueue(ux + ax, uy + ay);
                        }
                    }
                }
            }
        }

        public void redoBlockPower(int ux, int uy, int lyr)
        {
            if (powers[blocks[lyr][uy, ux]] || blocks[lyr][uy, ux] >= 94 && blocks[lyr][uy, ux] <= 99)
            {
                addAdjacentTilesToPQueue(ux, uy);
            }
            else
            {
                removeBlockPower(ux, uy, lyr);
            }
        }

        public void addSunLighting(int ux, int uy)
        { // And including
            for (y = 0; y < uy; y++)
            {
                if (ltrans[blocks[1][y, ux]])
                {
                    return;
                }
            }
            addSources = false;
            for (y = uy; y < HEIGHT - 1; y++)
            {
                if (ltrans[blocks[1][y + 1, ux - 1]] || ltrans[blocks[1][y + 1, ux + 1]])
                {
                    addSources = true;
                }
                if (addSources)
                {
                    addTileToQueue(ux, y);
                }
                if (ltrans[blocks[1][y, ux]])
                {
                    return;
                }
                addTileToZQueue(ux, y);
                lights[y, ux] = (float)sunlightlevel;
                lsources[y, ux] = true;
            }
        }

        public void removeSunLighting(int ux, int uy)
        { // And including
            n = sunlightlevel;
            for (y = 0; y < uy; y++)
            {
                if (ltrans[blocks[1][y, ux]])
                {
                    return;
                }
            }
            for (y = uy; y < HEIGHT; y++)
            {
                lsources[y, ux] = isBlockLightSource(ux, y);
                if (y != uy && ltrans[blocks[1][y, ux]])
                {
                    break;
                }
            }
            for (ax = -n; ax < n + 1; ax++)
            {
                for (ay = -n; ay < n + (y - uy) + 1; ay++)
                {
                    if (uy + ay >= 0 && uy + ay < WIDTH)
                    {
                        addTileToZQueue(ux + ax, uy + ay);
                        lights[uy + ay, ux + ax] = (float)0;
                    }
                }
            }
            for (ax = -n - BRIGHTEST; ax < n + 1 + BRIGHTEST; ax++)
            {
                for (ay = -n - BRIGHTEST; ay < n + (y - uy) + 1 + BRIGHTEST; ay++)
                {
                    if (uy + ay >= 0 && uy + ay < HEIGHT)
                    {
                        if (lsources[uy + ay, ux + ax])
                        {
                            addTileToQueue(ux + ax, uy + ay);
                        }
                    }
                }
            }
        }

        public bool isReachedBySunlight(int ux, int uy)
        {
            for (ay = 0; ay < uy + 1; ay++)
            {
                if (ltrans[blocks[1][ay, ux]])
                {
                    return false;
                }
            }
            return true;
        }

        public bool isBlockLightSource(int ux, int uy)
        {
            return (blocks[0][uy, ux] != 0 && BLOCKLIGHTS[blocks[0][uy, ux]] != 0 ||
                    blocks[1][uy, ux] != 0 && BLOCKLIGHTS[blocks[1][uy, ux]] != 0 ||
                    blocks[2][uy, ux] != 0 && BLOCKLIGHTS[blocks[2][uy, ux]] != 0);
        }

        public bool isNonLayeredBlockLightSource(int ux, int uy)
        {
            return isNonLayeredBlockLightSource(ux, uy, layer);
        }

        public bool isNonLayeredBlockLightSource(int ux, int uy, int layer)
        {
            return (layer != 0 && blocks[0][uy, ux] != 0 && BLOCKLIGHTS[blocks[0][uy, ux]] != 0 ||
                    layer != 1 && blocks[1][uy, ux] != 0 && BLOCKLIGHTS[blocks[1][uy, ux]] != 0 ||
                    layer != 2 && blocks[2][uy, ux] != 0 && BLOCKLIGHTS[blocks[2][uy, ux]] != 0);
        }

        public int findBlockLightSource(int ux, int uy)
        {
            n = 0;
            if (blocks[0][uy, ux] != 0) n = Math.Max(BLOCKLIGHTS[blocks[0][uy, ux]], n);
            if (blocks[1][uy, ux] != 0) n = Math.Max(BLOCKLIGHTS[blocks[1][uy, ux]], n);
            if (blocks[2][uy, ux] != 0) n = Math.Max(BLOCKLIGHTS[blocks[2][uy, ux]], n);
            return n;
        }

        public int findNonLayeredBlockLightSource(int ux, int uy)
        {
            return findNonLayeredBlockLightSource(ux, uy, layer);
        }

        public int findNonLayeredBlockLightSource(int ux, int uy, int layer)
        {
            n = 0;
            if (blocks[0][uy, ux] != 0) n = Math.Max(BLOCKLIGHTS[blocks[0][uy, ux]], n);
            if (blocks[1][uy, ux] != 0) n = Math.Max(BLOCKLIGHTS[blocks[1][uy, ux]], n);
            if (blocks[2][uy, ux] != 0) n = Math.Max(BLOCKLIGHTS[blocks[2][uy, ux]], n);
            return n;
        }

        public void addTileToQueue(int ux, int uy)
        {
            if (!lqd[uy, ux])
            {
                lqx.Add(ux);
                lqy.Add(uy);
                lqd[uy, ux] = true;
            }
        }

        public void addTileToZQueue(int ux, int uy)
        {
            if (!zqd[uy, ux])
            {
                zqx.Add(ux);
                zqy.Add(uy);
                zqn[uy, ux] = (byte)(float)lights[uy, ux];
                zqd[uy, ux] = true;
            }
        }

        public void addTileToPQueue(int ux, int uy)
        {
            if (!pqd[uy, ux])
            {
                pqx.Add(ux);
                pqy.Add(uy);
                pqd[uy, ux] = true;
            }
        }

        public void addAdjacentTilesToPQueue(int ux, int uy)
        {
            for (int i2 = 0; i2 < 4; i2++)
            {
                if (uy + cl[i2][1] >= 0 && uy + cl[i2][1] < HEIGHT)
                {
                    addTileToPQueue(ux + cl[i2][0], uy + cl[i2][1]);
                }
            }
        }

        public void addAdjacentTilesToPQueueConditionally(int ux, int uy)
        {
            for (int i2 = 0; i2 < 4; i2++)
            {
                for (int l = 0; l < 3; l++)
                {
                    if (uy + cl[i2][1] >= 0 && uy + cl[i2][1] < HEIGHT && power[l, uy + cl[i2][1],ux + cl[i2][0]] > 0)
                    {
                        addTileToPQueue(ux + cl[i2][0], uy + cl[i2][1]);
                    }
                }
            }
        }

        public void addTileToPZQueue(int ux, int uy)
        {
            if (!pzqd[uy, ux])
            {
                pzqx.Add(ux);
                pzqy.Add(uy);
                pzqn[0, uy, ux] = (byte)(float)power[0, uy, ux];
                pzqn[1, uy, ux] = (byte)(float)power[1, uy, ux];
                pzqn[2, uy, ux] = (byte)(float)power[2, uy, ux];
                pzqd[uy, ux] = true;
            }
        }

        public void resolveLightMatrix()
        {
            try
            {
                while (true)
                {
                    x = lqx[0];
                    y = lqy[0];
                    if (lsources[y, x])
                    {
                        n = findBlockLightSource(x, y);
                        if (isReachedBySunlight(x, y))
                        {
                            lights[y, x] = max(lights[y, x], n, sunlightlevel);
                        }
                        else
                        {
                            lights[y, x] = Math.Max(lights[y, x], n);
                        }
                        addTileToZQueue(x, y);
                    }
                    for (i = 0; i < 4; i++)
                    {
                        x2 = x + cl[i][0];
                        y2 = y + cl[i][1];
                        if (y2 >= 0 && y2 < HEIGHT)
                        {
                            if (!ltrans[blocks[1][y2, x2]])
                            {
                                if (lights[y2, x2] <= lights[y, x] - (float)1.0)
                                {
                                    addTileToZQueue(x2, y2);
                                    lights[y2, x2] = lights[y, x] - (float)1.0;
                                    addTileToQueue(x2, y2);
                                }
                            }
                            else
                            {
                                if (lights[y2, x2] <= lights[y, x] - (float)2.0)
                                {
                                    addTileToZQueue(x2, y2);
                                    lights[y2, x2] = lights[y, x] - (float)2.0;
                                    addTileToQueue(x2, y2);
                                }
                            }
                        }
                    }
                    lqx.RemoveAt(0);
                    lqy.RemoveAt(0);
                    lqd[y, x] = false;
                }
            }
            catch (IndexOutOfRangeException e)
            {
                //
            }
            for (i = 0; i < zqx.Count; i++)
            {
                x = zqx[i];
                y = zqy[i];
                if ((int)(float)lights[y, x] != zqn[y, x])
                {
                    rdrawn[y, x] = false;
                }
                zqd[y, x] = false;
            }
            zqx.Clear();
            zqy.Clear();
        }

        public void resolvePowerMatrix()
        {
            try
            {
                while (true)
                {
                    x = pqx[0];
                    y = pqy[0];
                    for (int l = 0; l < 3; l++)
                    {
                        if (powers[blocks[l][y, x]])
                        {
                            if (!(blocks[l][y, x] >= 137 && blocks[l][y, x] <= 168))
                            {
                                addTileToPQueue(x, y);
                                power[l, y, x] = (float)5;
                            }
                        }
                    }
                    for (i = 0; i < 4; i++)
                    {
                        x2 = x + cl[i][0];
                        y2 = y + cl[i][1];
                        if (y2 >= 0 && y2 < HEIGHT)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                if (power[l, y, x] > 0)
                                {
                                    if (conducts[blocks[l][y, x]] >= 0 && receives[blocks[l][y2, x2]] && !(blocks[l][y2, x2] >= 111 && blocks[l][y2, x2] <= 118 && x < x2 && blocks[l][y2, x2] != 111 && blocks[l][y2, x2] != 115 ||
                                                                                                     blocks[l][y2, x2] >= 111 && blocks[l][y2, x2] <= 118 && y < y2 && blocks[l][y2, x2] != 112 && blocks[l][y2, x2] != 116 ||
                                                                                                     blocks[l][y2, x2] >= 111 && blocks[l][y2, x2] <= 118 && x > x2 && blocks[l][y2, x2] != 113 && blocks[l][y2, x2] != 117 ||
                                                                                                     blocks[l][y2, x2] >= 111 && blocks[l][y2, x2] <= 118 && y > y2 && blocks[l][y2, x2] != 114 && blocks[l][y2, x2] != 118) &&
                                                                                                   !(blocks[l][y, x] >= 111 && blocks[l][y, x] <= 118 && x < x2 && blocks[l][y, x] != 111 && blocks[l][y, x] != 115 ||
                                                                                                     blocks[l][y, x] >= 111 && blocks[l][y, x] <= 118 && y < y2 && blocks[l][y, x] != 112 && blocks[l][y, x] != 116 ||
                                                                                                     blocks[l][y, x] >= 111 && blocks[l][y, x] <= 118 && x > x2 && blocks[l][y, x] != 113 && blocks[l][y, x] != 117 ||
                                                                                                     blocks[l][y, x] >= 111 && blocks[l][y, x] <= 118 && y > y2 && blocks[l][y, x] != 114 && blocks[l][y, x] != 118) &&
                                                                                                   !(blocks[l][y2, x2] >= 119 && blocks[l][y2, x2] <= 126 && x < x2 && blocks[l][y2, x2] != 119 && blocks[l][y2, x2] != 123 ||
                                                                                                     blocks[l][y2, x2] >= 119 && blocks[l][y2, x2] <= 126 && y < y2 && blocks[l][y2, x2] != 120 && blocks[l][y2, x2] != 124 ||
                                                                                                     blocks[l][y2, x2] >= 119 && blocks[l][y2, x2] <= 126 && x > x2 && blocks[l][y2, x2] != 121 && blocks[l][y2, x2] != 125 ||
                                                                                                     blocks[l][y2, x2] >= 119 && blocks[l][y2, x2] <= 126 && y > y2 && blocks[l][y2, x2] != 122 && blocks[l][y2, x2] != 126) &&
                                                                                                   !(blocks[l][y, x] >= 119 && blocks[l][y, x] <= 126 && x < x2 && blocks[l][y, x] != 119 && blocks[l][y, x] != 123 ||
                                                                                                     blocks[l][y, x] >= 119 && blocks[l][y, x] <= 126 && y < y2 && blocks[l][y, x] != 120 && blocks[l][y, x] != 124 ||
                                                                                                     blocks[l][y, x] >= 119 && blocks[l][y, x] <= 126 && x > x2 && blocks[l][y, x] != 121 && blocks[l][y, x] != 125 ||
                                                                                                     blocks[l][y, x] >= 119 && blocks[l][y, x] <= 126 && y > y2 && blocks[l][y, x] != 122 && blocks[l][y, x] != 126) &&
                                                                                                   !(blocks[l][y2, x2] >= 137 && blocks[l][y2, x2] <= 168 && x < x2 && blocks[l][y2, x2] != 137 && blocks[l][y2, x2] != 141 && blocks[l][y2, x2] != 145 && blocks[l][y2, x2] != 149 && blocks[l][y2, x2] != 153 && blocks[l][y2, x2] != 157 && blocks[l][y2, x2] != 161 && blocks[l][y2, x2] != 165 ||
                                                                                                     blocks[l][y2, x2] >= 137 && blocks[l][y2, x2] <= 168 && y < y2 && blocks[l][y2, x2] != 138 && blocks[l][y2, x2] != 142 && blocks[l][y2, x2] != 146 && blocks[l][y2, x2] != 150 && blocks[l][y2, x2] != 154 && blocks[l][y2, x2] != 158 && blocks[l][y2, x2] != 162 && blocks[l][y2, x2] != 166 ||
                                                                                                     blocks[l][y2, x2] >= 137 && blocks[l][y2, x2] <= 168 && x > x2 && blocks[l][y2, x2] != 139 && blocks[l][y2, x2] != 143 && blocks[l][y2, x2] != 147 && blocks[l][y2, x2] != 151 && blocks[l][y2, x2] != 155 && blocks[l][y2, x2] != 159 && blocks[l][y2, x2] != 163 && blocks[l][y2, x2] != 167 ||
                                                                                                     blocks[l][y2, x2] >= 137 && blocks[l][y2, x2] <= 168 && y > y2 && blocks[l][y2, x2] != 140 && blocks[l][y2, x2] != 144 && blocks[l][y2, x2] != 148 && blocks[l][y2, x2] != 152 && blocks[l][y2, x2] != 156 && blocks[l][y2, x2] != 160 && blocks[l][y2, x2] != 164 && blocks[l][y2, x2] != 168) &&
                                                                                                   !(blocks[l][y, x] >= 137 && blocks[l][y, x] <= 168 && x < x2 && blocks[l][y, x] != 137 && blocks[l][y, x] != 141 && blocks[l][y, x] != 145 && blocks[l][y, x] != 149 && blocks[l][y, x] != 153 && blocks[l][y, x] != 157 && blocks[l][y, x] != 161 && blocks[l][y, x] != 165 ||
                                                                                                     blocks[l][y, x] >= 137 && blocks[l][y, x] <= 168 && y < y2 && blocks[l][y, x] != 138 && blocks[l][y, x] != 142 && blocks[l][y, x] != 146 && blocks[l][y, x] != 150 && blocks[l][y, x] != 154 && blocks[l][y, x] != 158 && blocks[l][y, x] != 162 && blocks[l][y, x] != 166 ||
                                                                                                     blocks[l][y, x] >= 137 && blocks[l][y, x] <= 168 && x > x2 && blocks[l][y, x] != 139 && blocks[l][y, x] != 143 && blocks[l][y, x] != 147 && blocks[l][y, x] != 151 && blocks[l][y, x] != 155 && blocks[l][y, x] != 159 && blocks[l][y, x] != 163 && blocks[l][y, x] != 167 ||
                                                                                                     blocks[l][y, x] >= 137 && blocks[l][y, x] <= 168 && y > y2 && blocks[l][y, x] != 140 && blocks[l][y, x] != 144 && blocks[l][y, x] != 148 && blocks[l][y, x] != 152 && blocks[l][y, x] != 156 && blocks[l][y, x] != 160 && blocks[l][y, x] != 164 && blocks[l][y, x] != 168))
                                    {
                                        if (power[l, y2, x2] <= power[l, y, x] - conducts[blocks[l][y, x]])
                                        {
                                            addTileToPZQueue(x2, y2);
                                            if (blocks[l][y2, x2] >= 137 && blocks[l][y2, x2] <= 140 ||
                                                blocks[l][y2, x2] >= 145 && blocks[l][y2, x2] <= 148 ||
                                                blocks[l][y2, x2] >= 153 && blocks[l][y2, x2] <= 156 ||
                                                blocks[l][y2, x2] >= 161 && blocks[l][y2, x2] <= 164)
                                            {
                                                print("[DEBUG1]");
                                                updatex.Add(x2);
                                                updatey.Add(y2);
                                                updatet.Add(DDELAY[blocks[l][y2, x2]]);
                                                updatel.Add(l);
                                            }
                                            else
                                            {
                                                power[l, y2, x2] = power[l, y, x] - (float)conducts[blocks[l][y, x]];
                                                if (conducts[blocks[l][y2, x2]] >= 0 && wcnct[y2, x2])
                                                {
                                                    if (l == 0)
                                                    {
                                                        if (receives[blocks[1][y2, x2]])
                                                        {
                                                            power[1, y2, x2] = power[0, y2, x2] - (float)conducts[blocks[0][y2, x2]];
                                                        }
                                                        if (receives[blocks[2][y2, x2]])
                                                        {
                                                            power[2, y2, x2] = power[0, y2, x2] - (float)conducts[blocks[0][y2, x2]];
                                                        }
                                                    }
                                                    if (l == 1)
                                                    {
                                                        if (receives[blocks[0][y2, x2]])
                                                        {
                                                            power[0, y2, x2] = power[1, y2, x2] - (float)conducts[blocks[1][y2, x2]];
                                                        }
                                                        if (receives[blocks[2][y2, x2]])
                                                        {
                                                            power[2, y2, x2] = power[1, y2, x2] - (float)conducts[blocks[1][y2, x2]];
                                                        }
                                                    }
                                                    if (l == 2)
                                                    {
                                                        if (receives[blocks[0][y2, x2]])
                                                        {
                                                            power[0, y2, x2] = power[2, y2, x2] - (float)conducts[blocks[2][y2, x2]];
                                                        }
                                                        if (receives[blocks[1][y2, x2]])
                                                        {
                                                            power[1, y2, x2] = power[2, y2, x2] - (float)conducts[blocks[2][y2, x2]];
                                                        }
                                                    }
                                                }
                                            }
                                            if (!(blocks[l][y2, x2] >= 119 && blocks[l][y2, x2] <= 122))
                                            {
                                                addTileToPQueue(x2, y2);
                                            }
                                        }
                                        if (power[l, y, x] - conducts[blocks[l][y, x]] > 0 && blocks[l][y2, x2] >= 119 && blocks[l][y2, x2] <= 122)
                                        {
                                            removeBlockPower(x2, y2, l);
                                            blocks[l][y2, x2] += 4;
                                            removeBlockLighting(x2, y2);
                                            rdrawn[y2, x2] = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    pqx.RemoveAt(0);
                    pqy.RemoveAt(0);
                    pqd[y, x] = false;
                    for (int l = 0; l < 3; l++)
                    {
                        print("[resolvePowerMatrix] " + x + " " + y + " " + l + " " + blocks[l][y, x] + " " + power[l, y, x]);
                        if (power[l, y, x] > 0)
                        {
                            if (blocks[l][y, x] == 103)
                            {
                                blocks[l][y, x] = 104;
                                addBlockLighting(x, y);
                                rdrawn[y, x] = false;
                            }
                            if (blocks[l][y, x] >= 111 && blocks[l][y, x] <= 114)
                            {
                                print("Processed amplifier at " + x + " " + y);
                                blocks[l][y, x] += 4;
                                addTileToPQueue(x, y);
                                addBlockLighting(x, y);
                                rdrawn[y, x] = false;
                            }
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                //
            }
            for (i = 0; i < pzqx.Count; i++)
            {
                x = pzqx[i];
                y = pzqy[i];
                for (int l = 0; l < 3; l++)
                {
                    if (blocks[l][y, x] >= 94 && blocks[l][y, x] <= 99 && (int)(float)power[l, y, x] != pzqn[l, y, x])
                    {
                        removeBlockLighting(x, y, 0);
                        blocks[l][y, x] = WIREP[(int)(float)power[l, y, x]];
                        addBlockLighting(x, y);
                        rdrawn[y, x] = false;
                    }
                }
                pzqd[y, x] = false;
            }
            pzqx.Clear();
            pzqy.Clear();
        }

        public void paint(Graphics g)
        {
            if (screen == null) return;
            pg2 = screen.createGraphics();
            pg2.setColor(bg);
            pg2.fillRect(0, 0, getWidth(), getHeight());
            if (state.Equals("ingame"))
            {
                /*            if (SKYLIGHTS.get((int)timeOfDay) != null) {
                                sunlightlevel = SKYLIGHTS.get((int)timeOfDay);
                                resunlight = 0;
                            }
                            if (resunlight < WIDTH) {
                                for (ux=resunlight; ux<Math.Min(resunlight+SUNLIGHTSPEED,WIDTH); ux++) {
                                    removeSunLighting(ux, 0);
                                    addSunLighting(ux, 0);
                                }
                                resunlight += SUNLIGHTSPEED;
                            }
                */
                if (player.y / 16 < HEIGHT * 0.5)
                {
                    pg2.translate(getWidth() / 2, getHeight() * 0.85);
                    pg2.rotate((timeOfDay - 70200) / 86400 * Math.PI * 2);

                    pg2.drawImage(sun,
                        (int)(-getWidth() * 0.65), 0, (int)(-getWidth() * 0.65 + sun.Width * 2), sun.Height * 2,
                        0, 0, sun.Width, sun.Height,
                        null);

                    pg2.rotate(Math.PI);

                    pg2.drawImage(moon,
                        (int)(-getWidth() * 0.65), 0, (int)(-getWidth() * 0.65 + moon.Width * 2), moon.Height * 2,
                        0, 0, moon.Width, moon.Height,
                        null);

                    pg2.rotate(-(timeOfDay - 70200) / 86400 * Math.PI * 2 - Math.PI);
                    pg2.translate(-getWidth() / 2, -getHeight() * 0.85);

                    for (i = 0; i < cloudsx.Count; i++)
                    {
                        cloud = clouds[cloudsn[i]];
                        pg2.drawImage(clouds[cloudsn[i]],
                            (int)cloudsx[i], (int)cloudsy[i], (int)cloudsx[i] + cloud.Width * 2, (int)cloudsy[i] + cloud.Height * 2,
                            0, 0, cloud.Width, cloud.Height,
                            null);
                    }
                }

                for (pwy = 0; pwy < 2; pwy++)
                {
                    for (pwx = 0; pwx < 2; pwx++)
                    {
                        int pwxc = pwx + ou;
                        int pwyc = pwy + ov;
                        if (worlds[pwy,pwx] != null)
                        {
                            if (((player.ix + getWidth() / 2 + player.width >= pwxc * CHUNKSIZE &&
                                  player.ix + getWidth() / 2 + player.width <= pwxc * CHUNKSIZE + CHUNKSIZE) ||
                                 (player.ix - getWidth() / 2 + player.width + BLOCKSIZE >= pwxc * CHUNKSIZE &&
                                  player.ix - getWidth() / 2 + player.width - BLOCKSIZE <= pwxc * CHUNKSIZE + CHUNKSIZE)) &&
                                ((player.iy + getHeight() / 2 + player.height >= pwyc * CHUNKSIZE &&
                                  player.iy + getHeight() / 2 + player.height <= pwyc * CHUNKSIZE + CHUNKSIZE) ||
                                 (player.iy - getHeight() / 2 + player.height >= pwyc * CHUNKSIZE &&
                                  player.iy - getHeight() / 2 + player.height <= pwyc * CHUNKSIZE + CHUNKSIZE)))
                            {
                                pg2.drawImage(worlds[pwy,pwx],
                                    pwxc * CHUNKSIZE - player.ix + getWidth() / 2 - player.width / 2, pwyc * CHUNKSIZE - player.iy + getHeight() / 2 - player.height / 2, pwxc * CHUNKSIZE - player.ix + getWidth() / 2 - player.width / 2 + CHUNKSIZE, pwyc * CHUNKSIZE - player.iy + getHeight() / 2 - player.height / 2 + CHUNKSIZE,
                                    0, 0, CHUNKSIZE, CHUNKSIZE,
                                    null);
                            }
                        }
                    }
                }

                pg2.drawImage(player.image,
                    getWidth() / 2 - player.width / 2, getHeight() / 2 - player.height / 2, getWidth() / 2 + player.width / 2, getHeight() / 2 + player.height / 2,
                    0, 0, player.image.Width, player.image.Height,
                    null);

                for (i = 0; i < entities.Count; i++)
                {
                    entity = entities[i];
                    pg2.drawImage(entity.image,
                        entity.ix - player.ix + getWidth() / 2 - player.width / 2, entity.iy - player.iy + getHeight() / 2 - player.height / 2, entity.ix - player.ix + getWidth() / 2 - player.width / 2 + entity.width, entity.iy - player.iy + getHeight() / 2 - player.height / 2 + entity.height,
                        0, 0, entity.image.Width, entity.image.Height,
                        null);
                    pg2.drawImage(entity.image,
                        entity.ix - player.ix + getWidth() / 2 - player.width / 2 - WIDTH * BLOCKSIZE, entity.iy - player.iy + getHeight() / 2 - player.height / 2, entity.ix - player.ix + getWidth() / 2 - player.width / 2 + entity.width - WIDTH * BLOCKSIZE, entity.iy - player.iy + getHeight() / 2 - player.height / 2 + entity.height,
                        0, 0, entity.image.Width, entity.image.Height,
                        null);
                    pg2.drawImage(entity.image,
                        entity.ix - player.ix + getWidth() / 2 - player.width / 2 + WIDTH * BLOCKSIZE, entity.iy - player.iy + getHeight() / 2 - player.height / 2, entity.ix - player.ix + getWidth() / 2 - player.width / 2 + entity.width + WIDTH * BLOCKSIZE, entity.iy - player.iy + getHeight() / 2 - player.height / 2 + entity.height,
                        0, 0, entity.image.Width, entity.image.Height,
                        null);
                }

                if (showTool && tool != null)
                {
                    if (player.imgState.Equals("still right") || player.imgState.Equals("walk right 1") || player.imgState.Equals("walk right 2"))
                    {
                        pg2.translate(getWidth() / 2 + 6, getHeight() / 2);
                        pg2.rotate(toolAngle);

                        pg2.drawImage(tool,
                            0, -tool.Height * 2, tool.Width * 2, 0,
                            0, 0, tool.Width, tool.Height,
                            null);

                        pg2.rotate(-toolAngle);
                        pg2.translate(-getWidth() / 2 - 6, -getHeight() / 2);
                    }
                    if (player.imgState.Equals("still left") || player.imgState.Equals("walk left 1") || player.imgState.Equals("walk left 2"))
                    {
                        pg2.translate(getWidth() / 2 - 6, getHeight() / 2);
                        pg2.rotate((Math.PI * 1.5) - toolAngle);

                        pg2.drawImage(tool,
                            0, -tool.Height * 2, tool.Width * 2, 0,
                            0, 0, tool.Width, tool.Height,
                            null);

                        pg2.rotate(-((Math.PI * 1.5) - toolAngle));
                        pg2.translate(-getWidth() / 2 + 6, -getHeight() / 2);
                    }
                }

                for (pwy = 0; pwy < 2; pwy++)
                {
                    for (pwx = 0; pwx < 2; pwx++)
                    {
                        int pwxc = pwx + ou;
                        int pwyc = pwy + ov;
                        if (fworlds[pwy,pwx] != null)
                        {
                            if (((player.ix + getWidth() / 2 + player.width >= pwxc * CHUNKSIZE &&
                                  player.ix + getWidth() / 2 + player.width <= pwxc * CHUNKSIZE + CHUNKSIZE) ||
                                 (player.ix - getWidth() / 2 + player.width + BLOCKSIZE >= pwxc * CHUNKSIZE &&
                                  player.ix - getWidth() / 2 + player.width - BLOCKSIZE <= pwxc * CHUNKSIZE + CHUNKSIZE)) &&
                                ((player.iy + getHeight() / 2 + player.height >= pwyc * CHUNKSIZE &&
                                  player.iy + getHeight() / 2 + player.height <= pwyc * CHUNKSIZE + CHUNKSIZE) ||
                                 (player.iy - getHeight() / 2 + player.height >= pwyc * CHUNKSIZE &&
                                  player.iy - getHeight() / 2 + player.height <= pwyc * CHUNKSIZE + CHUNKSIZE)))
                            {
                                pg2.drawImage(fworlds[pwy,pwx],
                                    pwxc * CHUNKSIZE - player.ix + getWidth() / 2 - player.width / 2, pwyc * CHUNKSIZE - player.iy + getHeight() / 2 - player.height / 2, pwxc * CHUNKSIZE - player.ix + getWidth() / 2 - player.width / 2 + CHUNKSIZE, pwyc * CHUNKSIZE - player.iy + getHeight() / 2 - player.height / 2 + CHUNKSIZE,
                                    0, 0, CHUNKSIZE, CHUNKSIZE,
                                    null);
                            }
                        }
                    }
                }

                if (showInv)
                {
                    pg2.drawImage(inventory.image,
                        0, 0, inventory.image.Width, (int)inventory.image.Height,
                        0, 0, inventory.image.Width, (int)inventory.image.Height,
                        null);
                    pg2.drawImage(armor.image,
                        inventory.image.Width + 6, 6, inventory.image.Width + 6 + armor.image.Width, 6 + armor.image.Height,
                        0, 0, armor.image.Width, armor.image.Height,
                        null);
                    pg2.drawImage(cic.image,
                        inventory.image.Width + 75, 52, inventory.image.Width + 75 + cic.image.Width, 52 + cic.image.Height,
                        0, 0, cic.image.Width, cic.image.Height,
                        null);
                }
                else
                {
                    pg2.drawImage(inventory.image,
                        0, 0, inventory.image.Width, (int)inventory.image.Height / 4,
                        0, 0, inventory.image.Width, (int)inventory.image.Height / 4,
                        null);
                }

                if (ic != null)
                {
                    pg2.drawImage(ic.image,
                        6, inventory.image.Height + 46, 6 + ic.image.Width, inventory.image.Height + 46 + ic.image.Height,
                        0, 0, ic.image.Width, ic.image.Height,
                        null);
                }

                if (layer == 0)
                {
                    layerImg = loadImage("interface/layersB.png");
                }
                if (layer == 1)
                {
                    layerImg = loadImage("interface/layersN.png");
                }
                if (layer == 2)
                {
                    layerImg = loadImage("interface/layersF.png");
                }

                pg2.drawImage(layerImg,
                    inventory.image.Width + 58, 6, inventory.image.Width + 58 + layerImg.Width, 6 + layerImg.Height,
                    0, 0, layerImg.Width, layerImg.Height,
                    null);

                if (showInv)
                {
                    pg2.drawImage(save_exit,
                        getWidth() - save_exit.Width - 24, getHeight() - save_exit.Height - 24, getWidth() - 24, getHeight() - 24,
                        0, 0, save_exit.Width, save_exit.Height,
                        null);
                }

                if (moveItem != 0)
                {
                    width = itemImgs[moveItem].Width;
                    height = itemImgs[moveItem].Height;
                    pg2.drawImage(itemImgs[moveItem],
                        mousePos[0] + 12 + ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), mousePos[1] + 12 + ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2), mousePos[0] + 36 - ((int)(24 - (double)12 / max(width, height, 12) * width * 2) / 2), mousePos[1] + 36 - ((int)(24 - (double)12 / max(width, height, 12) * height * 2) / 2),
                        0, 0, width, height,
                        null);
                    if (moveNum > 1)
                    {
                        pg2.setFont(font);
                        pg2.setColor(Color.White);
                        pg2.drawString(moveNum + " ", mousePos[0] + 13, mousePos[1] + 38);
                    }
                }
                for (i = 0; i < entities.Count; i++)
                {
                    if (UIENTITIES.ContainsKey(entities[i].name) && entities[i].rect != null && entities[i].rect.Contains(new Point(mousePos2[0], mousePos2[1])))
                    {
                        pg2.setFont(mobFont);
                        pg2.setColor(Color.White);
                        pg2.drawString(UIENTITIES[entities[i].name] + " (" + entities[i].hp + "/" + entities[i].thp + ")", mousePos[0], mousePos[1]);
                        break;
                    }
                }
                if (showInv)
                {
                    ymax = 4;
                }
                else
                {
                    ymax = 1;
                }
                for (ux = 0; ux < 10; ux++)
                {
                    for (uy = 0; uy < ymax; uy++)
                    {
                        if (mousePos[0] >= ux * 46 + 6 && mousePos[0] <= ux * 46 + 46 &&
                            mousePos[1] >= uy * 46 + 6 && mousePos[1] <= uy * 46 + 46 && inventory.ids[uy * 10 + ux] != 0)
                        {
                            pg2.setFont(mobFont);
                            pg2.setColor(Color.White);
                            if (TOOLDURS.ContainsKey((short)inventory.ids[uy * 10 + ux]))
                            {
                                pg2.drawString(UIBLOCKS[items[inventory.ids[uy * 10 + ux]]] + " (" + (int)((double)inventory.durs[uy * 10 + ux] / TOOLDURS[inventory.ids[uy * 10 + ux]] * 100) + "%)", mousePos[0], mousePos[1]);
                            }
                            else
                            {
                                pg2.drawString(UIBLOCKS[items[inventory.ids[uy * 10 + ux]]], mousePos[0], mousePos[1]);
                            }
                        }
                    }
                }
                pg2.setFont(mobFont);
                pg2.setColor(Color.White);
                pg2.drawString("Health: " + player.hp + "/" + player.thp, getWidth() - 125, 20);
                pg2.drawString("Armor: " + player.sumArmor(), getWidth() - 125, 40);
                if (DEBUG_STATS)
                {
                    pg2.drawString("(" + ((int)player.ix / 16) + ", " + ((int)player.iy / 16) + ")", getWidth() - 125, 60);
                    if (player.iy >= 0 && player.iy < HEIGHT * BLOCKSIZE)
                    {
                        pg2.drawString(checkBiome((int)player.ix / 16 + u, (int)player.iy / 16 + v) + " " + lights[(int)player.iy / 16 + v, (int)player.ix / 16 + u], getWidth() - 125, 80);
                    }
                }
                if (showInv)
                {
                    for (ux = 0; ux < 2; ux++)
                    {
                        for (uy = 0; uy < 2; uy++)
                        {
                            if (mousePos[0] >= inventory.image.Width + ux * 40 + 75 &&
                                mousePos[0] < inventory.image.Width + ux * 40 + 115 &&
                                mousePos[1] >= uy * 40 + 52 && mousePos[1] < uy * 40 + 92 && cic.ids[uy * 2 + ux] != 0)
                            {
                                pg2.setFont(mobFont);
                                pg2.setColor(Color.White);
                                if (TOOLDURS.ContainsKey((short)cic.ids[uy * 2 + ux]))
                                {
                                    pg2.drawString(UIBLOCKS[items[cic.ids[uy * 2 + ux]]] + " (" + (int)((double)cic.durs[uy * 2 + ux] / TOOLDURS[cic.ids[uy * 2 + ux]] * 100) + "%)", mousePos[0], mousePos[1]);
                                }
                                else
                                {
                                    pg2.drawString(UIBLOCKS[items[cic.ids[uy * 2 + ux]]], mousePos[0], mousePos[1]);
                                }
                            }
                        }
                    }
                    if (mousePos[0] >= inventory.image.Width + 3 * 40 + 75 &&
                        mousePos[0] < inventory.image.Width + 3 * 40 + 115 &&
                        mousePos[1] >= 20 + 52 && mousePos[1] < 20 + 92 && cic.ids[4] != 0)
                    {
                        pg2.setFont(mobFont);
                        pg2.setColor(Color.White);
                        if (TOOLDURS.ContainsKey((short)cic.ids[4]))
                        {
                            pg2.drawString(UIBLOCKS[items[cic.ids[4]]] + " (" + (int)((double)cic.durs[4] / TOOLDURS[cic.ids[4]] * 100) + "%)", mousePos[0], mousePos[1]);
                        }
                        else
                        {
                            pg2.drawString(UIBLOCKS[items[cic.ids[4]]], mousePos[0], mousePos[1]);
                        }
                    }
                    for (uy = 0; uy < 4; uy++)
                    {
                        if (mousePos[0] >= inventory.image.Width + 6 && mousePos[0] < inventory.image.Width + 6 + armor.image.Width &&
                            mousePos[1] >= 6 + uy * 46 && mousePos[1] < 6 + uy * 46 + 46 && armor.ids[uy] != 0)
                        {
                            pg2.setFont(mobFont);
                            pg2.setColor(Color.White);
                            if (TOOLDURS.ContainsKey((short)armor.ids[uy]))
                            {
                                pg2.drawString(UIBLOCKS[items[armor.ids[uy]]] + " (" + (int)((double)armor.durs[uy] / TOOLDURS[armor.ids[uy]] * 100) + "%)", mousePos[0], mousePos[1]);
                            }
                            else
                            {
                                pg2.drawString(UIBLOCKS[items[armor.ids[uy]]], mousePos[0], mousePos[1]);
                            }
                        }
                    }
                }
                if (ic != null)
                {
                    if (ic.type.Equals("workbench"))
                    {
                        for (ux = 0; ux < 3; ux++)
                        {
                            for (uy = 0; uy < 3; uy++)
                            {
                                if (mousePos[0] >= ux * 40 + 6 && mousePos[0] < ux * 40 + 46 &&
                                    mousePos[1] >= uy * 40 + inventory.image.Height + 46 &&
                                    mousePos[1] < uy * 40 + inventory.image.Height + 86 &&
                                    ic.ids[uy * 3 + ux] != 0)
                                {
                                    pg2.setFont(mobFont);
                                    pg2.setColor(Color.White);
                                    if (TOOLDURS.ContainsKey((short)ic.ids[uy * 3 + ux]))
                                    {
                                        pg2.drawString(UIBLOCKS[items[ic.ids[uy * 3 + ux]]] + " (" + (int)((double)ic.durs[uy * 3 + ux] / TOOLDURS[ic.ids[uy * 3 + ux]] * 100) + "%)", mousePos[0], mousePos[1]);
                                    }
                                    else
                                    {
                                        pg2.drawString(UIBLOCKS[items[ic.ids[uy * 3 + ux]]], mousePos[0], mousePos[1]);
                                    }
                                }
                            }
                        }
                        if (mousePos[0] >= 4 * 40 + 6 && mousePos[0] < 4 * 40 + 46 &&
                            mousePos[1] >= 1 * 40 + inventory.image.Height + 46 &&
                            mousePos[1] < 1 * 40 + inventory.image.Height + 86 &&
                            ic.ids[9] != 0)
                        {
                            pg2.setFont(mobFont);
                            pg2.setColor(Color.White);
                            if (TOOLDURS.ContainsKey((short)ic.ids[9]))
                            {
                                pg2.drawString(UIBLOCKS[items[ic.ids[9]]] + " (" + (int)((double)ic.durs[9] / TOOLDURS[ic.ids[9]] * 100) + "%)", mousePos[0], mousePos[1]);
                            }
                            else
                            {
                                pg2.drawString(UIBLOCKS[items[ic.ids[9]]], mousePos[0], mousePos[1]);
                            }
                        }
                    }
                    if (ic.type.Equals("wooden_chest") || ic.type.Equals("stone_chest") ||
                        ic.type.Equals("copper_chest") || ic.type.Equals("iron_chest") ||
                        ic.type.Equals("silver_chest") || ic.type.Equals("gold_chest") ||
                        ic.type.Equals("zinc_chest") || ic.type.Equals("rhymestone_chest") ||
                        ic.type.Equals("obdurite_chest"))
                    {
                        for (ux = 0; ux < inventory.CX; ux++)
                        {
                            for (uy = 0; uy < inventory.CY; uy++)
                            {
                                if (mousePos[0] >= ux * 46 + 6 && mousePos[0] < ux * 46 + 46 &&
                                    mousePos[1] >= uy * 46 + inventory.image.Height + 46 &&
                                    mousePos[1] < uy * 46 + inventory.image.Height + 86 &&
                                    ic.ids[uy * inventory.CX + ux] != 0)
                                {
                                    pg2.setFont(mobFont);
                                    pg2.setColor(Color.White);
                                    if (TOOLDURS.ContainsKey((short)ic.ids[uy * inventory.CX + ux]))
                                    {
                                        pg2.drawString(UIBLOCKS[items[ic.ids[uy * inventory.CX + ux]]] + " (" + (int)((double)ic.durs[uy * inventory.CX + ux] / TOOLDURS[ic.ids[uy * inventory.CX + ux]] * 100) + "%)", mousePos[0], mousePos[1]);
                                    }
                                    else
                                    {
                                        pg2.drawString(UIBLOCKS[items[ic.ids[uy * inventory.CX + ux]]], mousePos[0], mousePos[1]);
                                    }
                                }
                            }
                        }
                    }
                    if (ic.type.Equals("furnace"))
                    {
                        if (mousePos[0] >= 6 && mousePos[0] < 46 &&
                            mousePos[1] >= inventory.image.Height + 46 && mousePos[1] < inventory.image.Height + 86 &&
                            ic.ids[0] != 0)
                        {
                            pg2.setFont(mobFont);
                            pg2.setColor(Color.White);
                            if (TOOLDURS.ContainsKey((short)ic.ids[0]))
                            {
                                pg2.drawString(UIBLOCKS[items[ic.ids[0]]] + " (" + (int)((double)ic.durs[0] / TOOLDURS[ic.ids[0]] * 100) + "%)", mousePos[0], mousePos[1]);
                            }
                            else
                            {
                                pg2.drawString(UIBLOCKS[items[ic.ids[0]]], mousePos[0], mousePos[1]);
                            }
                        }
                        if (mousePos[0] >= 6 && mousePos[0] < 46 &&
                            mousePos[1] >= inventory.image.Height + 102 && mousePos[1] < inventory.image.Height + 142 &&
                            ic.ids[1] != 0)
                        {
                            pg2.setFont(mobFont);
                            pg2.setColor(Color.White);
                            if (TOOLDURS.ContainsKey((short)ic.ids[1]))
                            {
                                pg2.drawString(UIBLOCKS[items[ic.ids[1]]] + " (" + (int)((double)ic.durs[1] / TOOLDURS[ic.ids[1]] * 100) + "%)", mousePos[1], mousePos[1]);
                            }
                            else
                            {
                                pg2.drawString(UIBLOCKS[items[ic.ids[1]]], mousePos[0], mousePos[1]);
                            }
                        }
                        if (mousePos[0] >= 6 && mousePos[0] < 46 &&
                            mousePos[1] >= inventory.image.Height + 142 && mousePos[1] < inventory.image.Height + 182 &&
                            ic.ids[2] != 0)
                        {
                            pg2.setFont(mobFont);
                            pg2.setColor(Color.White);
                            if (TOOLDURS.ContainsKey((short)ic.ids[2]))
                            {
                                pg2.drawString(UIBLOCKS[items[ic.ids[2]]] + " (" + (int)((double)ic.durs[2] / TOOLDURS[ic.ids[2]] * 100) + "%)", mousePos[2], mousePos[1]);
                            }
                            else
                            {
                                pg2.drawString(UIBLOCKS[items[ic.ids[2]]], mousePos[0], mousePos[1]);
                            }
                        }
                        if (mousePos[0] >= 62 && mousePos[0] < 102 &&
                            mousePos[1] >= inventory.image.Height + 46 && mousePos[1] < inventory.image.Height + 86 &&
                            ic.ids[3] != 0)
                        {
                            pg2.setFont(mobFont);
                            pg2.setColor(Color.White);
                            if (TOOLDURS.ContainsKey((short)ic.ids[3]))
                            {
                                pg2.drawString(UIBLOCKS[items[ic.ids[3]]] + " (" + (int)((double)ic.durs[3] / TOOLDURS[ic.ids[3]] * 100) + "%)", mousePos[3], mousePos[1]);
                            }
                            else
                            {
                                pg2.drawString(UIBLOCKS[items[ic.ids[3]]], mousePos[0], mousePos[1]);
                            }
                        }
                    }
                }
            }
            if (state.Equals("loading_graphics"))
            {
                pg2.setFont(loadFont);
                pg2.setColor(Color.Green);
                pg2.drawString("Loading graphics... Please wait.", getWidth() / 2 - 200, getHeight() / 2 - 5);
            }
            if (state.Equals("title_screen"))
            {
                pg2.drawImage(title_screen,
                    0, 0, getWidth(), getHeight(),
                    0, 0, getWidth(), getHeight(),
                    null);
            }
            if (state.Equals("select_world"))
            {
                pg2.drawImage(select_world,
                    0, 0, getWidth(), getHeight(),
                    0, 0, getWidth(), getHeight(),
                    null);
                for (i = 0; i < worldNames.Count; i++)
                {
                    pg2.setFont(worldFont);
                    pg2.setColor(Color.Black);
                    pg2.drawString(worldNames[i], 180, 140 + i * 35);
                    pg2.fillRect(166, 150 + i * 35, 470, 3);
                }
            }
            if (state.Equals("new_world"))
            {
                pg2.drawImage(new_world,
                    0, 0, getWidth(), getHeight(),
                    0, 0, getWidth(), getHeight(),
                    null);
                pg2.drawImage(newWorldName.image,
                    200, 240, 600, 270,
                    0, 0, 400, 30,
                    null);
            }
            if (state.Equals("generating_world"))
            {
                pg2.setFont(loadFont);
                pg2.setColor(Color.Green);
                pg2.drawString("Generating new world... Please wait.", getWidth() / 2 - 200, getHeight() / 2 - 5);
            }
            ((Graphics2D)g).drawImage(screen,
                0, 0, getWidth(), getHeight(),
                0, 0, getWidth(), getHeight(),
                null);
        }

        public bool loadWorld(String worldFile)
        {
            //TODO: Convert this
            //try
            //{
            //    FileStream fileIn = File.OpenRead("worlds/" + worldFile);
            //    ObjectInputStream in = new ObjectInputStream(fileIn);
            //    WorldContainer wc = (WorldContainer) in.readObject();
            //in.close();
            //    fileIn.close();
            //    emptyWorldContainer(wc);
            //    return true;
            //}
            //catch (Exception e)
            //{
            //    return false;
            //}
            return true;
        }

        public void saveWorld()
        {
            //TODO: Convert this
            //try
            //{
            //    WorldContainer wc = createWorldContainer();
            //    FileOutputStream fileOut = new FileOutputStream("worlds/" + currentWorld + ".dat");
            //    ObjectOutputStream out = new ObjectOutputStream(fileOut);
            //out.writeObject(wc);
            //out.close();
            //    fileOut.close();
            //}
            //catch (IOException e)
            //{
            //    e.printStackTrace();
            //}
        }

        public void emptyWorldContainer(WorldContainer wc)
        {
            blocks = wc.blocks;
            blockds = wc.blockds;
            blockdns = wc.blockdns;
            blockbgs = wc.blockbgs;
            blockts = wc.blockts;
            lights = wc.lights;
            power = wc.power;
            resetDrawn();
            player = wc.player;
            inventory = wc.inventory;
            cic = wc.cic;
            entities = wc.entities;
            cloudsx = wc.cloudsx;
            cloudsy = wc.cloudsy;
            cloudsv = wc.cloudsv;
            cloudsn = wc.cloudsn;
            machinesx = wc.machinesx;
            machinesy = wc.machinesy;
            lsources = wc.lsources;
            lqx = wc.lqx;
            lqy = wc.lqy;
            lqd = wc.lqd;
            rgnc1 = wc.rgnc1;
            rgnc2 = wc.rgnc2;
            layer = wc.layer;
            layerTemp = wc.layerTemp;
            blockTemp = wc.blockTemp;
            mx = wc.mx;
            my = wc.my;
            icx = wc.icx;
            icy = wc.icy;
            mining = wc.mining;
            immune = wc.immune;
            moveItem = wc.moveItem;
            moveNum = wc.moveNum;
            moveItemTemp = wc.moveItemTemp;
            moveNumTemp = wc.moveNumTemp;
            msi = wc.msi;
            toolAngle = wc.toolAngle;
            toolSpeed = wc.toolSpeed;
            timeOfDay = wc.timeOfDay;
            currentSkyLight = wc.currentSkyLight;
            day = wc.day;
            mobCount = wc.mobCount;
            ready = wc.ready;
            showTool = wc.showTool;
            showInv = wc.showInv;
            doMobSpawn = wc.doMobSpawn;
            WIDTH = wc.WIDTH;
            HEIGHT = wc.HEIGHT;
            random = wc.random;
            WORLDWIDTH = wc.WORLDWIDTH;
            WORLDHEIGHT = wc.WORLDHEIGHT;
            resunlight = wc.resunlight;
            kworlds = wc.kworlds;
            ic = wc.ic;
            icmatrix = wc.icmatrix;
            version = wc.version;
            player.reloadImage();
            inventory.reloadImage();
            if (cic != null)
            {
                inventory.renderCollection(cic);
            }
            else
            {
                short[] tlist1 = { 0, 0, 0, 0, 0 };
                short[] tlist2 = { 0, 0, 0, 0, 0 };
                short[] tlist3 = { 0, 0, 0, 0, 0 };
                cic = new ItemCollection("cic", tlist1, tlist2, tlist3);
                inventory.renderCollection(cic);
            }
            if (ic != null)
            {
                inventory.renderCollection(ic);
            }
            for (i = 0; i < entities.Count; i++)
            {
                entities[i].reloadImage();
            }
            worlds = new Image[WORLDHEIGHT, WORLDWIDTH];
            fworlds = new Image[WORLDHEIGHT, WORLDWIDTH];
        }

        public void resetDrawn()
        {
            drawn = new Boolean[HEIGHT, WIDTH];
            for (y = 0; y < HEIGHT; y++)
            {
                for (x = 0; x < WIDTH; x++)
                {
                    drawn[y, x] = false;
                }
            }
            ldrawn = new Boolean[HEIGHT, WIDTH];
            for (y = 0; y < HEIGHT; y++)
            {
                for (x = 0; x < WIDTH; x++)
                {
                    ldrawn[y, x] = false;
                }
            }
            rdrawn = new Boolean[HEIGHT, WIDTH];
            for (y = 0; y < HEIGHT; y++)
            {
                for (x = 0; x < WIDTH; x++)
                {
                    rdrawn[y, x] = false;
                }
            }
        }

        public WorldContainer createWorldContainer()
        {
            return (new WorldContainer(blocks, blockds, blockdns, blockbgs, blockts,
                                      lights, power, drawn, ldrawn, rdrawn,
                                      player, inventory, cic,
                                      entities, cloudsx, cloudsy, cloudsv, cloudsn,
                                      machinesx, machinesy, lsources, lqx, lqy, lqd,
                                      rgnc1, rgnc2, layer, layerTemp, blockTemp,
                                      mx, my, icx, icy, mining, immune,
                                      moveItem, moveNum, moveItemTemp, moveNumTemp, msi,
                                      toolAngle, toolSpeed, timeOfDay, currentSkyLight, day, mobCount,
                                      ready, showTool, showInv, doMobSpawn,
                                      WIDTH, HEIGHT, random, WORLDWIDTH, WORLDHEIGHT,
                                      resunlight,
                                      ic, kworlds, icmatrix, version));
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
                //
            }
            return image;
        }

        public Image loadBlock(int type, Byte dir, Byte dirn, Byte tnum,
            String[] blocknames, String[] dirs, String outlineName, int x, int y, int lyr)
        {
            int fx, fy;
            int dir_is = (int)dir;
            String dir_s = dirs[dir_is];
            int dir_i = (int)dirn;
            Image outline = outlineImgs["outlines/" + outlineName + "/" + dir_s + (dir_i + 1) + ".png"];
            String bName = blocknames[type];
            Image texture = blockImgs["blocks/" + bName + "/texture" + (tnum + 1) + ".png"];
            Image image = config.createCompatibleImage(IMAGESIZE, IMAGESIZE, Transparency.Translucent);
            if (GRASSDIRT.ContainsKey(type))
            {
                Image dirtOriginal = blockImgs["blocks/" + blocknames[GRASSDIRT[type]] + "/texture" + (tnum + 1) + ".png"];
                Image dirt = config.createCompatibleImage(IMAGESIZE, IMAGESIZE, Transparency.Translucent);
                for (dy = 0; dy < IMAGESIZE; dy++)
                {
                    for (dx = 0; dx < IMAGESIZE; dx++)
                    {
                        dirt.setRGB(dx, dy, dirtOriginal.getRGB(dx, dy));
                    }
                }
                int dn = GRASSDIRT[type];
                bool left = (blocks[lyr][y, x - 1] == 0 || !blockcds[blocks[lyr][y, x - 1]]);// && (blocks[lyr][y-1][x] != dn && blocks[lyr][y+1][x] != dn) && (blocks[lyr][y-1][x-1] != dn && blocks[lyr][y+1][x-1] != dn);
                bool right = (blocks[lyr][y, x + 1] == 0 || !blockcds[blocks[lyr][y, x + 1]]);// && (blocks[lyr][y-1][x] != dn && blocks[lyr][y+1][x] != dn) && (blocks[lyr][y-1][x+1] != dn && blocks[lyr][y+1][x+1] != dn);
                bool up = (blocks[lyr][y - 1, x] == 0 || !blockcds[blocks[lyr][y - 1, x]]);// && (blocks[lyr][y][x-1] != dn && blocks[lyr][y][x+1] != dn) && (blocks[lyr][y-1][x-1] != dn && blocks[lyr][y-1][x+1] != dn);
                bool down = (blocks[lyr][y + 1, x] == 0 || !blockcds[blocks[lyr][y + 1, x]]);// && (blocks[lyr][y][x-1] != dn && blocks[lyr][y][x+1] != dn) && (blocks[lyr][y+1][x-1] != dn && blocks[lyr][y+1][x+1] != dn);
                bool upleft = (blocks[lyr][y - 1, x - 1] == 0 || !blockcds[blocks[lyr][y - 1, x - 1]]);// && (blocks[lyr][y-1][x] != dn && blocks[lyr][y][x-1] != dn && blocks[lyr][y-1][x-1] != dn && blocks[lyr][y-2][x] != dn && blocks[lyr][y][x-2] != dn);
                bool upright = (blocks[lyr][y - 1, x + 1] == 0 || !blockcds[blocks[lyr][y - 1, x + 1]]);// && (blocks[lyr][y-1][x] != dn && blocks[lyr][y][x+1] != dn && blocks[lyr][y-1][x+1] != dn && blocks[lyr][y-2][x] != dn && blocks[lyr][y][x+2] != dn);
                bool downleft = (blocks[lyr][y + 1, x - 1] == 0 || !blockcds[blocks[lyr][y + 1, x - 1]]);// && (blocks[lyr][y+1][x] != dn && blocks[lyr][y][x-1] != dn && blocks[lyr][y+1][x-1] != dn && blocks[lyr][y+2][x] != dn && blocks[lyr][y][x-2] != dn);
                bool downright = (blocks[lyr][y + 1, x + 1] == 0 || !blockcds[blocks[lyr][y + 1, x + 1]]);// && (blocks[lyr][y+1][x] != dn && blocks[lyr][y][x+1] != dn && blocks[lyr][y+1][x+1] != dn && blocks[lyr][y+2][x] != dn && blocks[lyr][y][x+2] != dn);
                int[,] pixm = new int[IMAGESIZE, IMAGESIZE];
                for (dy = 0; dy < 8; dy++)
                {
                    for (dx = 0; dx < 8; dx++)
                    {
                        pixm[dy, dx] = 0;
                    }
                }
                if (left)
                {
                    pixm[3, 0] = 255;
                    pixm[4, 0] = 255;
                }
                if (right)
                {
                    pixm[3, 7] = 255;
                    pixm[4, 7] = 255;
                }
                if (up)
                {
                    pixm[0, 3] = 255;
                    pixm[0, 4] = 255;
                }
                if (down)
                {
                    pixm[7, 3] = 255;
                    pixm[7, 4] = 255;
                }
                if (upleft)
                {
                    pixm[0, 0] = 255;
                }
                if (upright)
                {
                    pixm[0, 7] = 255;
                }
                if (downleft)
                {
                    pixm[7, 0] = 255;
                }
                if (downright)
                {
                    pixm[7, 7] = 255;
                }
                if (left && up)
                {
                    for (dy = 0; dy < 4; dy++)
                    {
                        pixm[dy, 0] = 255;
                    }
                    for (dx = 0; dx < 4; dx++)
                    {
                        pixm[0, dx] = 255;
                    }
                }
                if (up && right)
                {
                    for (dx = 4; dx < 8; dx++)
                    {
                        pixm[0, dx] = 255;
                    }
                    for (dy = 0; dy < 4; dy++)
                    {
                        pixm[dy, 7] = 255;
                    }
                }
                if (right && down)
                {
                    for (dy = 4; dy < 8; dy++)
                    {
                        pixm[dy, 7] = 255;
                    }
                    for (dx = 4; dx < 8; dx++)
                    {
                        pixm[7, dx] = 255;
                    }
                }
                if (down && left)
                {
                    for (dx = 0; dx < 4; dx++)
                    {
                        pixm[7, dx] = 255;
                    }
                    for (dy = 4; dy < 8; dy++)
                    {
                        pixm[dy, 0] = 255;
                    }
                }
                for (dy = 0; dy < 8; dy++)
                {
                    for (dx = 0; dx < 8; dx++)
                    {
                        if (pixm[dy, dx] == 255)
                        {
                            for (dy2 = 0; dy2 < 8; dy2++)
                            {
                                for (dx2 = 0; dx2 < 8; dx2++)
                                {
                                    n = (int)(255 - 32 * Math.Sqrt(Math.Pow(dx - dx2, 2) + Math.Pow(dy - dy2, 2)));
                                    if (pixm[dy2, dx2] < n)
                                    {
                                        pixm[dy2, dx2] = n;
                                    }
                                }
                            }
                        }
                    }
                }
                for (dy = 0; dy < 8; dy++)
                {
                    for (dx = 0; dx < 8; dx++)
                    {
                        dirt.setRGB(dx, dy, new Color((int)(pixm[dy, dx] / 255.0 * new Color(texture.getRGB(dx, dy)).R + (1 - pixm[dy, dx] / 255.0) * new Color(dirt.getRGB(dx, dy)).R),
                                                      (int)(pixm[dy, dx] / 255.0 * new Color(texture.getRGB(dx, dy)).G + (1 - pixm[dy, dx] / 255.0) * new Color(dirt.getRGB(dx, dy)).G),
                                                      (int)(pixm[dy, dx] / 255.0 * new Color(texture.getRGB(dx, dy)).B + (1 - pixm[dy, dx] / 255.0) * new Color(dirt.getRGB(dx, dy)).B)).PackedValue);
                    }
                }
                texture = dirt;
            }
            for (fy = 0; fy < IMAGESIZE; fy++)
            {
                for (fx = 0; fx < IMAGESIZE; fx++)
                {
                    if (outline.getRGB(fx, fy) == 4294902015 || outline.getRGB(fx, fy) == 4294918399)//if (outline.getRGB(fx, fy) == -65281 || outline.getRGB(fx, fy) == -48897)
                    {
                        image.setRGB(fx, fy, texture.getRGB(fx, fy));
                    }
                    else if (outline.getRGB(fx, fy) == 4278190080)//else if (outline.getRGB(fx, fy) == -16777216)
                    {
                        image.setRGB(fx, fy, 4278190080);//image.setRGB(fx, fy, -16777216);
                    }
                }
            }
            return image;
        }

        public void keyPressed(KeyEvent key)
        {
            if (key.getKeyCode() == key.VK_LEFT || key.getKeyCode() == key.VK_A)
            {
                queue[0] = true;
            }
            if (key.getKeyCode() == key.VK_RIGHT || key.getKeyCode() == key.VK_D)
            {
                queue[1] = true;
            }
            if (key.getKeyCode() == key.VK_UP || key.getKeyCode() == key.VK_W)
            {
                queue[2] = true;
            }
            if (key.getKeyCode() == key.VK_DOWN || key.getKeyCode() == key.VK_S)
            {
                queue[6] = true;
            }
            if (key.getKeyCode() == key.VK_SHIFT)
            {
                queue[5] = true;
            }
            if (state.Equals("ingame"))
            {
                if (key.getKeyCode() == key.VK_ESCAPE)
                {
                    if (ic != null)
                    {
                        if (!ic.type.Equals("workbench"))
                        {
                            machinesx.Add(icx);
                            machinesy.Add(icy);
                            icmatrix[iclayer, icy, icx] = new ItemCollection(ic.type, ic.ids, ic.nums, ic.durs);
                        }
                        if (ic.type.Equals("workbench"))
                        {
                            if (player.imgState.Equals("still right") || player.imgState.Equals("walk right 1") || player.imgState.Equals("walk right 2"))
                            {
                                for (i = 0; i < 9; i++)
                                {
                                    if (ic.ids[i] != 0)
                                    {
                                        entities.Add(new Entity(icx * BLOCKSIZE, icy * BLOCKSIZE, 2, -2, ic.ids[i], ic.nums[i], ic.durs[i], 75));
                                    }
                                }
                            }
                            if (player.imgState.Equals("still left") || player.imgState.Equals("walk left 1") || player.imgState.Equals("walk left 2"))
                            {
                                for (i = 0; i < 9; i++)
                                {
                                    if (ic.ids[i] != 0)
                                    {
                                        entities.Add(new Entity(icx * BLOCKSIZE, icy * BLOCKSIZE, -2, -2, ic.ids[i], ic.nums[i], ic.durs[i], 75));
                                    }
                                }
                            }
                        }
                        if (ic.type.Equals("furnace"))
                        {
                            icmatrix[iclayer, icy, icx].FUELP = ic.FUELP;
                            icmatrix[iclayer, icy, icx].SMELTP = ic.SMELTP;
                            icmatrix[iclayer, icy, icx].F_ON = ic.F_ON;
                        }
                        ic = null;
                    }
                    else
                    {
                        if (showInv)
                        {
                            for (i = 0; i < 4; i++)
                            {
                                if (cic.ids[i] != 0)
                                {
                                    if (player.imgState.Equals("still right") || player.imgState.Equals("walk right 1") || player.imgState.Equals("walk right 2"))
                                    {
                                        entities.Add(new Entity(player.x, player.y, 2, -2, cic.ids[i], cic.nums[i], cic.durs[i], 75));
                                    }
                                    if (player.imgState.Equals("still left") || player.imgState.Equals("walk left 1") || player.imgState.Equals("walk left 2"))
                                    {
                                        entities.Add(new Entity(player.x, player.y, -2, -2, cic.ids[i], cic.nums[i], cic.durs[i], 75));
                                    }
                                    inventory.removeLocationIC(cic, i, cic.nums[i]);
                                }
                            }
                        }
                        showInv = !showInv;
                    }
                    if (moveItem != 0)
                    {
                        if (player.imgState.Equals("still right") || player.imgState.Equals("walk right 1") || player.imgState.Equals("walk right 2"))
                        {
                            entities.Add(new Entity(player.x, player.y, 2, -2, moveItem, moveNum, moveDur, 75));
                        }
                        if (player.imgState.Equals("still left") || player.imgState.Equals("walk left 1") || player.imgState.Equals("walk left 2"))
                        {
                            entities.Add(new Entity(player.x, player.y, -2, -2, moveItem, moveNum, moveDur, 75));
                        }
                        moveItem = 0;
                        moveNum = 0;
                    }
                }
                if (!showTool)
                {
                    if (key.getKeyCode() == key.VK_1)
                    {
                        inventory.select(1);
                    }
                    if (key.getKeyCode() == key.VK_2)
                    {
                        inventory.select(2);
                    }
                    if (key.getKeyCode() == key.VK_3)
                    {
                        inventory.select(3);
                    }
                    if (key.getKeyCode() == key.VK_4)
                    {
                        inventory.select(4);
                    }
                    if (key.getKeyCode() == key.VK_5)
                    {
                        inventory.select(5);
                    }
                    if (key.getKeyCode() == key.VK_6)
                    {
                        inventory.select(6);
                    }
                    if (key.getKeyCode() == key.VK_7)
                    {
                        inventory.select(7);
                    }
                    if (key.getKeyCode() == key.VK_8)
                    {
                        inventory.select(8);
                    }
                    if (key.getKeyCode() == key.VK_9)
                    {
                        inventory.select(9);
                    }
                    if (key.getKeyCode() == key.VK_0)
                    {
                        inventory.select(0);
                    }
                }
            }
            char c = (char)0;
            if (key.getKeyCode() == key.VK_Q) c = 'q';
            if (key.getKeyCode() == key.VK_W) c = 'w';
            if (key.getKeyCode() == key.VK_E) c = 'e';
            if (key.getKeyCode() == key.VK_R) c = 'r';
            if (key.getKeyCode() == key.VK_T) c = 't';
            if (key.getKeyCode() == key.VK_Y) c = 'y';
            if (key.getKeyCode() == key.VK_U) c = 'u';
            if (key.getKeyCode() == key.VK_I) c = 'i';
            if (key.getKeyCode() == key.VK_O) c = 'o';
            if (key.getKeyCode() == key.VK_P) c = 'p';
            if (key.getKeyCode() == key.VK_A) c = 'a';
            if (key.getKeyCode() == key.VK_S) c = 's';
            if (key.getKeyCode() == key.VK_D) c = 'd';
            if (key.getKeyCode() == key.VK_F) c = 'f';
            if (key.getKeyCode() == key.VK_G) c = 'g';
            if (key.getKeyCode() == key.VK_H) c = 'h';
            if (key.getKeyCode() == key.VK_J) c = 'j';
            if (key.getKeyCode() == key.VK_K) c = 'k';
            if (key.getKeyCode() == key.VK_L) c = 'l';
            if (key.getKeyCode() == key.VK_Z) c = 'z';
            if (key.getKeyCode() == key.VK_X) c = 'x';
            if (key.getKeyCode() == key.VK_C) c = 'c';
            if (key.getKeyCode() == key.VK_V) c = 'v';
            if (key.getKeyCode() == key.VK_B) c = 'b';
            if (key.getKeyCode() == key.VK_N) c = 'n';
            if (key.getKeyCode() == key.VK_M) c = 'm';
            if (key.getKeyCode() == key.VK_1) c = '1';
            if (key.getKeyCode() == key.VK_2) c = '2';
            if (key.getKeyCode() == key.VK_3) c = '3';
            if (key.getKeyCode() == key.VK_4) c = '4';
            if (key.getKeyCode() == key.VK_5) c = '5';
            if (key.getKeyCode() == key.VK_6) c = '6';
            if (key.getKeyCode() == key.VK_7) c = '7';
            if (key.getKeyCode() == key.VK_8) c = '8';
            if (key.getKeyCode() == key.VK_9) c = '9';
            if (key.getKeyCode() == key.VK_0) c = '0';
            if (key.getKeyCode() == key.VK_SPACE) c = ' ';
            if (key.getKeyCode() == 192) c = '`';
            if (key.getKeyCode() == key.VK_MINUS) c = '-';
            if (key.getKeyCode() == key.VK_EQUALS) c = '=';
            if (key.getKeyCode() == key.VK_OPEN_BRACKET) c = '[';
            if (key.getKeyCode() == key.VK_CLOSE_BRACKET) c = ']';
            if (key.getKeyCode() == key.VK_BACK_SLASH) c = '\\';
            if (key.getKeyCode() == key.VK_COLON) c = ':';
            if (key.getKeyCode() == key.VK_QUOTE) c = '\'';
            if (key.getKeyCode() == key.VK_COMMA) c = ',';
            if (key.getKeyCode() == key.VK_PERIOD) c = '.';
            if (key.getKeyCode() == key.VK_SLASH) c = '/';

            if (queue[5])
            {
                if (c == 'q') c = 'Q';
                if (c == 'w') c = 'W';
                if (c == 'e') c = 'E';
                if (c == 'r') c = 'R';
                if (c == 't') c = 'T';
                if (c == 'y') c = 'Y';
                if (c == 'u') c = 'U';
                if (c == 'i') c = 'I';
                if (c == 'o') c = 'O';
                if (c == 'p') c = 'P';
                if (c == 'a') c = 'A';
                if (c == 's') c = 'S';
                if (c == 'd') c = 'D';
                if (c == 'f') c = 'F';
                if (c == 'g') c = 'G';
                if (c == 'h') c = 'H';
                if (c == 'j') c = 'J';
                if (c == 'k') c = 'K';
                if (c == 'l') c = 'L';
                if (c == 'z') c = 'Z';
                if (c == 'x') c = 'X';
                if (c == 'c') c = 'C';
                if (c == 'v') c = 'V';
                if (c == 'b') c = 'B';
                if (c == 'n') c = 'N';
                if (c == 'm') c = 'M';
                if (c == '1') c = '!';
                if (c == '2') c = '@';
                if (c == '3') c = '#';
                if (c == '4') c = '$';
                if (c == '5') c = '%';
                if (c == '6') c = '^';
                if (c == '7') c = '&';
                if (c == '8') c = '*';
                if (c == '9') c = '(';
                if (c == '0') c = ')';
                if (c == ' ') c = ' ';
                if (c == '`') c = '~';
                if (c == '-') c = '_';
                if (c == '=') c = '+';
                if (c == '[') c = '{';
                if (c == ']') c = '}';
                if (c == '\\') c = '|';
                if (c == ';') c = ')';
                if (c == '\'') c = '"';
                if (c == ',') c = '<';
                if (c == '.') c = '>';
                if (c == '/') c = '?';
            }

            if (state.Equals("new_world") && !newWorldFocus)
            {
                if (c != 0)
                {
                    newWorldName.typeKey(c);
                    repaint();
                }

                if (key.getKeyCode() == 8)
                {
                    newWorldName.deleteKey();
                    repaint();
                }
            }

            if (key.getKeyCode() == key.VK_EQUALS && layer < 2)
            {
                layer += 1;
            }
            if (key.getKeyCode() == key.VK_MINUS && layer > 0)
            {
                layer -= 1;
            }
        }

        public void keyReleased(KeyEvent key)
        {
            if (key.getKeyCode() == key.VK_LEFT || key.getKeyCode() == key.VK_A)
            {
                queue[0] = false;
            }
            if (key.getKeyCode() == key.VK_RIGHT || key.getKeyCode() == key.VK_D)
            {
                queue[1] = false;
            }
            if (key.getKeyCode() == key.VK_UP || key.getKeyCode() == key.VK_W)
            {
                queue[2] = false;
            }
            if (key.getKeyCode() == key.VK_SHIFT)
            {
                queue[5] = false;
            }
            if (key.getKeyCode() == key.VK_DOWN || key.getKeyCode() == key.VK_S)
            {
                queue[6] = false;
            }
        }

        public void mousePressed(MouseEvent e)
        {
            if (!queue[3])
            {
                queue[3] = e.getButton() == MouseEvent.BUTTON1;
            }
            if (!queue[4])
            {
                queue[4] = e.getButton() == MouseEvent.BUTTON3;
            }
        }

        public void mouseReleased(MouseEvent e)
        {
            queue[3] = false;
            queue[4] = false;
            menuPressed = false;
        }

        public void mouseMoved(MouseEvent e)
        {
            if (mousePos != null)
            {
                mousePos[0] = e.getX();
                mousePos[1] = e.getY();
            }
        }

        public void mouseDragged(MouseEvent e)
        {
            mousePos[0] = e.getX();
            mousePos[1] = e.getY();
        }

        public Dimension getPreferredSize()
        {
            return new Dimension(800, 600);
        }

        public static int getBLOCKSIZE()
        {
            return BLOCKSIZE;
        }

        public static int getIMAGESIZE()
        {
            return IMAGESIZE;
        }

        public static int getPLAYERSIZEX()
        {
            return PLAYERSIZEX;
        }

        public static int getPLAYERSIZEY()
        {
            return PLAYERSIZEY;
        }

        public static bool[] getBLOCKCDS()
        {
            return blockcds;
        }

        public static Dictionary<int, Boolean> getBLOCKCD()
        {
            return BLOCKCD;
        }

        public static Dictionary<short, short> getTOOLDURS()
        {
            return TOOLDURS;
        }

        public static Dictionary<short, short> getMAXSTACKS()
        {
            return MAXSTACKS;
        }

        public static Random getRandom()
        {
            return random;
        }

        public static Dictionary<short, Image> getItemImgs()
        {
            return itemImgs;
        }

        public static String[] getItems()
        {
            return items;
        }

        public static Dictionary<short, int> getARMOR()
        {
            return ARMOR;
        }

        public void keyTyped(KeyEvent key)
        {
            //
        }

        public void stateChanged(ChangeEvent e)
        {
            //
        }

        public void mouseEntered(MouseEvent e)
        {
            //
        }

        public void mouseExited(MouseEvent e)
        {
            //
        }

        public void mouseWheelMoved(MouseWheelEvent e)
        {
            //
        }

        public void update()
        {
            //
        }

        public static void pmsg(String msg)
        {
            Console.WriteLine(msg);
        }

        /*    public void pmsg(String msg) {
                pg2 = (Graphics2D) screen.createGraphics();
                if (logo_white != null && msg != null && loadTextPos != 0) {
                    pg2.drawImage(logo_white,
                        getWidth()/2-logo_white.getWidth()/2, 50, getWidth()/2+logo_white.getWidth()/2, logo_white.getHeight()+50,
                        0, 0, logo_white.getWidth(), logo_white.getHeight(),
                        null);
                    pg2.setFont(loadFont);
                    pg2.setColor(Color.GREEN);
                    pg2.drawString(msg, getWidth()/2-200, 100+loadTextPos*13);
                    if (msg.Equals("Created by Radon Rosborough.")) {
                        loadTextPos += 2;
                    }
                    else {
                        loadTextPos += 1;
                    }
                }
                else {
                    pg2.clearRect(0, 0, getWidth(), getHeight());
                    loadTextPos = 1;
                }
            }
        */
        public static void postError(Exception e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Exception in thread " + e.TargetSite.DeclaringType.Name);
            if (e.Message != null)
            {
                sb.Append(": ");
                sb.Append(e.Message);
            }
            sb.Append(e.StackTrace);
            try
            {
                log = new StreamWriter("log.txt");
                log.Write(sb.ToString());
                log.Close();
            }
            catch (IOException e2)
            {
                //
            }
            finally
            {
                Console.WriteLine(sb.ToString());
            }
        }

        public static int max(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        public static float max(float a, float b, float c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        public static double max(double a, double b, double c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        public static int max(int a, int b, int c, int d)
        {
            return Math.Max(Math.Max(a, b), Math.Max(c, d));
        }

        public static float max(float a, float b, float c, float d)
        {
            return Math.Max(Math.Max(a, b), Math.Max(c, d));
        }

        public static double max(double a, double b, double c, double d)
        {
            return Math.Max(Math.Max(a, b), Math.Max(c, d));
        }

        public static int mod(int a, int q)
        {
            return ((a % q) + q) % q;
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
