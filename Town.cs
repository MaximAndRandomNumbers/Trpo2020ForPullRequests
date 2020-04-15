using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /// <summary>
    /// Класс, описывающий город
    /// </summary>
    class Town
    {
        /// <summary>
        /// Имя города
        /// </summary>
        public String Name { get; }
        /// <summary>
        /// Здания в городе
        /// </summary>
        List<Building> buildings;

        public Town(String name)
        {
            Name = name;
            buildings = new List<Building>();  
        }

        /// <summary>
        /// Метод создаёт новое здание 
        /// и добавляет его в список зданий
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="texture">Текстура</param>
        /// <param name="name">Вид здания</param>
        public void buildHouse(double x, double y, String texture, String name)
        {
            BuildingTypeFactory factory = new BuildingTypeFactory();
            buildings.Add(new Building(x, y, factory.getBuildingType(texture, name)));
        }
    }
}
