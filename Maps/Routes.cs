using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Maps
{
    public class Routes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Сoordinates { get; set; }
        public virtual Marker MarkerId { get;private set; }
    }
}