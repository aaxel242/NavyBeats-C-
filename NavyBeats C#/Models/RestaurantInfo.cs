using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavyBeats_C_.Models
{
    public class RestaurantInfo
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Municipality { get; set; }
        public string Email { get; set; }
        public TimeSpan OpeningTime { get; set; }
        public TimeSpan ClosingTime { get; set; }
        public double? Latitud { get; set; }  
        public double? Longitud { get; set; } 
    }
}
