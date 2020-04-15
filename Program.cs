using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Town SaintP = new Town("Saint-Petersburg");
            SaintP.buildHouse(5, 10, "brick", "office");
            SaintP.buildHouse(15, 10, "brick", "shop");
            SaintP.buildHouse(10, 20, "brick", "office");
            SaintP.buildHouse(5, 10, "concrete", "office");
            SaintP.buildHouse(35, 10, "concrete", "school");
            SaintP.buildHouse(45, 10, "brick", "office");
        }
    }
}
