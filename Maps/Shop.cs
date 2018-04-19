using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maps
{
    public class Shop
    {
        public int Id { get; set; }
        public virtual Goods Goods { get; private set; }
        public int GoodsId { get; set; }
        public int Price { get; set; }
    }
}
