using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreApp.Models
{
    public class Car
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Wheels { get; set; }

        public int WheelPrice { get; set; }

        public int PurePrice { get; set; }

        public int TotalPrice => WheelPrice * Wheels + PurePrice;
    }
}
