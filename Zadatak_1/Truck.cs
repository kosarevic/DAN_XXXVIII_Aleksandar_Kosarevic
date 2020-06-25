using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    class Truck
    {

        public int Route { get; set; }
        public double LoadTime { get; set; }
        public string Name { get; set; }

        public Truck()
        {
        }

        public Truck(int route, double loadTime, string name)
        {
            Route = route;
            LoadTime = loadTime;
            Name = name;
        }
    }
}
