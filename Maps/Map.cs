using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maps
{
    public class Map
    {
        public ICollection<Marker> Markers { get; private set; }
        public ICollection<Routes> Route { get; private set; }

        public Map()
        {
            Markers = new List<Marker>();
            Route = new List<Routes>();
        }
    }

}
