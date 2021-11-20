using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPropelledArtillery
{
    /// <summary>
    /// Класс-коллекция баз
    /// </summary>
    public class BaseCollection
    {
        /// <summary>
        /// Словарь (хранилище) с базами
        /// </summary>
        readonly Dictionary<string, Base<Vehicle>> baseStages;
        /// <summary>
        /// Возвращение списка названий баз
        /// </summary>
        public List<string> Keys => baseStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public BaseCollection(int pictureWidth, int pictureHeight)
        {
            baseStages = new Dictionary<string, Base<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление базы
        /// </summary>
        /// <param name="name">Название базы</param>
        public void AddBase(string name)
        {
            if (!baseStages.ContainsKey(name))
            {
                baseStages.Add(name, new Base<Vehicle>(pictureWidth, pictureHeight));
            }

        }
        /// <summary>
        /// Удаление базы
        /// </summary>
        /// <param name="name">Название базы</param>
        public void DelBase(string name)
        {
            if (baseStages.ContainsKey(name))
            {
                baseStages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к базе
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Base<Vehicle> this[string ind]
        {
            get
            {
                if (baseStages.ContainsKey(ind))
                {
                    return baseStages[ind];
                }
                return null;
            }
        }
    }
}
