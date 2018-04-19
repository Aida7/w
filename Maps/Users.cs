using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maps
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Purse { get; set; }
        public virtual Shop Shop { get; set; }
        public int ShopId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Telephone { get; set; }
    }
}
