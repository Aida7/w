using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maps
{
    public class Orders
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public virtual Users Users { get; private set; }
        public int UserId { get; set; }
        public int Price { get; set; }
        public DateTime DeliveryTime { get; set; }
        public DateTime TimeofOrder { get; set; }
        public virtual Routes RouteId { get; private set; }
        public int Route { get; set; }
        public virtual TypeMachines TypeMachines{ get; set; }
        public int TypeMachinesId { get; set; }
        public virtual Drivers Drivers { get; set; }
        public int DriverId { get; set; }

    }
}