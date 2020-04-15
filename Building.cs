using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /// <summary>
    /// Класс, описывающий здание
    /// </summary>
    class Building
    {
        /// <summary>
        /// Тип здания
        /// </summary>
        public BuildingType Type { get; }
        /// <summary>
        /// Координата X
        /// </summary>
        public double xCoord { get; }
        /// <summary>
        /// Координата Y
        /// </summary>
        public double yCoord { get; }

        public Building(double x, double y, BuildingType type)
        {
            xCoord = x;
            yCoord = y;
            Type = type;
        }
    }
}
