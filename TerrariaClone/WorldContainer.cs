using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    [Serializable]
    public class WorldContainer
    {

        public int[][,] blocks;
        public Byte[][,] blockds;
        public Byte[,] blockdns;
        public Byte[,] blockbgs;
        public Byte[,] blockts;
        public float[,] lights;
        public float[,,] power;
        public Boolean[,] lsources;
        public List<int> lqx, lqy;
        public Boolean[,] lqd;
        public Boolean[,] drawn, ldrawn, rdrawn;
        public Player player;
        public Inventory inventory;
        public ItemCollection cic;
        public List<Entity> entities;
        public List<Double> cloudsx, cloudsy, cloudsv;
        public List<int> cloudsn;
        public List<int> machinesx, machinesy;

        public int rgnc1;
        public int rgnc2;
        public int layer;
        public int layerTemp;
        public int blockTemp;

        public int mx, my, icx, icy, mining, immune;

        public short moveItem, moveNum, moveItemTemp, moveNumTemp;
        public int msi;

        public double toolAngle, toolSpeed;

        public double timeOfDay;
        public int currentSkyLight;
        public int day;

        public int mobCount;

        public bool ready;
        public bool showTool;
        public bool showInv;
        public bool doMobSpawn;

        public int WIDTH;
        public int HEIGHT;

        public Random random;

        public int WORLDWIDTH;
        public int WORLDHEIGHT;

        public int resunlight;//int resunlight = WIDTH;

        public ItemCollection ic;

        public bool[,] kworlds;

        public ItemCollection[,,] icmatrix;

        public String version;

        public WorldContainer(int[][,] blocks, Byte[][,] blockds, Byte[,] blockdns, Byte[,] blockbgs, Byte[,] blockts,
            float[,] lights, float[,,] power, Boolean[,] drawn, Boolean[,] ldrawn, Boolean[,] rdrawn,
            Player player, Inventory inventory, ItemCollection cic,
            List<Entity> entities, List<Double> cloudsx, List<Double> cloudsy, List<Double> cloudsv, List<int> cloudsn,
            List<int> machinesx, List<int> machinesy, Boolean[,] lsources, List<int> lqx, List<int> lqy, Boolean[,] lqd,
            int rgnc1, int rgnc2, int layer, int layerTemp, int blockTemp,
            int mx, int my, int icx, int icy, int mining, int immune,
            short moveItem, short moveNum, short moveItemTemp, short moveNumTemp, int msi,
            double toolAngle, double toolSpeed, double timeOfDay, int currentSkyLight, int day, int mobCount,
            bool ready, bool showTool, bool showInv, bool doMobSpawn,
            int WIDTH, int HEIGHT, Random random, int WORLDWIDTH, int WORLDHEIGHT,
            int resunlight,
            ItemCollection ic, bool[,] kworlds, ItemCollection[,,] icmatrix, String version)
        {

            this.blocks = blocks;
            this.blockds = blockds;
            this.blockdns = blockdns;
            this.blockbgs = blockbgs;
            this.blockts = blockts;
            this.lights = lights;
            this.power = power;
            this.drawn = drawn;
            this.ldrawn = ldrawn;
            this.rdrawn = rdrawn;
            this.player = player;
            this.inventory = inventory;
            this.cic = cic;
            this.entities = entities;
            this.cloudsx = cloudsx;
            this.cloudsy = cloudsy;
            this.cloudsv = cloudsv;
            this.cloudsn = cloudsn;
            this.machinesx = machinesx;
            this.machinesy = machinesy;
            this.lsources = lsources;
            this.lqx = lqx;
            this.lqy = lqy;
            this.lqd = lqd;
            this.rgnc1 = rgnc1;
            this.rgnc2 = rgnc2;
            this.layer = layer;
            this.layerTemp = layerTemp;
            this.blockTemp = blockTemp;
            this.mx = mx;
            this.my = my;
            this.icx = icx;
            this.icy = icy;
            this.mining = mining;
            this.immune = immune;
            this.moveItem = moveItem;
            this.moveNum = moveNum;
            this.moveItemTemp = moveItemTemp;
            this.moveNumTemp = moveNumTemp;
            this.msi = msi;
            this.toolAngle = toolAngle;
            this.toolSpeed = toolSpeed;
            this.timeOfDay = timeOfDay;
            this.currentSkyLight = currentSkyLight;
            this.day = day;
            this.mobCount = mobCount;
            this.ready = ready;
            this.showTool = showTool;
            this.showInv = showInv;
            this.doMobSpawn = doMobSpawn;
            this.WIDTH = WIDTH;
            this.HEIGHT = HEIGHT;
            this.random = random;
            this.WORLDWIDTH = WORLDWIDTH;
            this.WORLDHEIGHT = WORLDHEIGHT;
            this.resunlight = resunlight;
            this.ic = ic;
            this.kworlds = kworlds;
            this.icmatrix = icmatrix;
            this.version = version;
        }
    }
}
