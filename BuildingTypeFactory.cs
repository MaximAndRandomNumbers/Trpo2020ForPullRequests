using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /// <summary>
    /// Класс, отвечающий за хранение и добавление типов зданий
    /// </summary>
    class BuildingTypeFactory
    {
        /// <summary>
        /// Текущие типы зданий
        /// </summary>
        static List<BuildingType> buildingTypes = new List<BuildingType>();

        /// <summary>
        /// Метод возвращает тип здания,
        /// этот тип есть в списке, либо создаёт
        /// новый тип, добавляет его в список и возвращает
        /// </summary>
        /// <param name="texture">Текстура здания</param>
        /// <param name="name">Имя здания</param>
        /// <returns>Тип здания</returns>
        public BuildingType getBuildingType(String texture, String name)
        {
            BuildingType currentType = null;

            foreach(BuildingType bt in buildingTypes)
            {
                if (bt.Equals(new BuildingType(texture, name)))
                {
                    currentType = bt;
                    break;
                }
            }
            if(currentType == null)
            {
                currentType = new BuildingType(texture, name);
                buildingTypes.Add(currentType);
            }

            return currentType;
        }
    }
}
