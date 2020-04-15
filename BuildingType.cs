using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /// <summary>
    /// Класс, описывающий тип здания
    /// </summary>
    class BuildingType
    {
        /// <summary>
        /// Текстура здания
        /// </summary>
        public String Texture { get; }
        /// <summary>
        /// Вид здания
        /// </summary>
        public String Name { get; }

        public BuildingType(String texture, String name)
        {
            Texture = texture;
            Name = name;
        }

        /// <summary>
        /// Переопределяем метод Equals
        /// </summary>
        /// <param name="obj">С чем сравниваем</param>
        /// <returns>Равны или нет</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            BuildingType buildObj = (BuildingType)obj;
            if (buildObj.Name == Name && buildObj.Texture == Texture) return true;
            return false;
        }
    }
}
