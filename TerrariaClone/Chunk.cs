using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    public class Chunk
    {

        public int cx, cy;

        public int[][,] blocks;
        public Byte[][,] blockds;
        public Byte[,] blockdns;
        public Byte[,] blockbgs;
        public Byte[,] blockts;
        public float[,] lights;
        public float[,,] power;
        public Boolean[,] lsources;
        public Byte[,] zqn;
        public Byte[,,] pzqn;
        public Boolean[,,] arbprd;
        public Boolean[,] wcnct;
        public Boolean[,] drawn, rdrawn, ldrawn;

        public Chunk(int cx, int cy)
        {
            this.cx = cx;
            this.cy = cy;

            Object[] rv = World.generateChunk(cx, cy, TerrariaClone.getRandom());
            blocks = (int[][,])rv[0];
            blockds = (Byte[][,])rv[1];
            blockdns = (Byte[,])rv[2];
            blockbgs = (Byte[,])rv[3];
            blockts = (Byte[,])rv[4];
            lights = (float[,])rv[5];
            power = (float[,,])rv[6];
            lsources = (Boolean[,])rv[7];
            zqn = (Byte[,])rv[8];
            pzqn = (Byte[,,])rv[9];
            arbprd = (Boolean[,,])rv[10];
            wcnct = (Boolean[,])rv[11];
            drawn = (Boolean[,])rv[12];
            rdrawn = (Boolean[,])rv[13];
            ldrawn = (Boolean[,])rv[14];
        }
    }

}
