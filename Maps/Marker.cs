using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Maps
{
    public class Marker
    {
        public int Id { get; set; }
        public string Streets { get; set; }
        public string Сity { get; set; }
        public string Сoordinates { get; set; }
        public virtual Orders OrderId { get;private set; }
    }
  
}