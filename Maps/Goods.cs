using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maps
{
    public class Goods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int СategoryId { get; set; }
        public virtual Сategory Сategory { get; set; }
        public int Price { get; set; }
    }
}