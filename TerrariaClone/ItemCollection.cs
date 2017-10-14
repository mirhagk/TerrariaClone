using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaClone
{
    [Serializable]
    public class ItemCollection
    {

        public String type;
        public short[]
            ids, nums, durs;
        [NonSerialized]
        public Image image;
        public double FUELP = 0;
        public double SMELTP = 0;
        public bool F_ON = false;
        short recipeNum;

        public ItemCollection(String type, short[] ids, short[] nums, short[] durs)
        {
            this.type = type;
            this.ids = ids;
            this.nums = nums;
            this.durs = durs;
        }
    }

}
