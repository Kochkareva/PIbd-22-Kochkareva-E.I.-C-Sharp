using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';
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

        /// <summary>
        /// Сохранение информации по военной технике на базах в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.Write($"BaseCollection{Environment.NewLine}");
                foreach (var level in baseStages)
                {
                    sw.Write($"Base{separator}{level.Key}{Environment.NewLine}");
                    ITransport artillery = null;
                    for (int i = 0; (artillery = level.Value.GetNext(i)) != null; i++)
                    {
                        if (artillery != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (artillery.GetType().Name == "CombatVehicle")
                            {
                                sw.Write($"CombatVehicle{separator}");
                            }
                            if (artillery.GetType().Name == "SelfPropelledArtillery")
                            {
                                sw.Write($"SelfPropelledArtillery{separator}");
                            }
                            //Записываемые параметры
                            sw.Write(artillery + Environment.NewLine);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Загрузка иформации по военной технике на базах из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("Фаил не найден");
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string strs = sr.ReadLine();
                if (strs.Contains("BaseCollection"))
                {
                    //очищаем записи
                    baseStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    throw new FileFormatException("Неверный формат файла");
                }
                Vehicle artillery = null;
                string key = string.Empty;
                for (int i = 1; (strs = sr.ReadLine()) != null; ++i)
                {
                    //идем по считанным записям
                    if (strs.Contains("Base"))
                    {
                        //начинаем новую парковку
                        key = strs.Split(separator)[1];
                        baseStages.Add(key, new Base<Vehicle>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(strs))
                    {
                        continue;
                    }
                    if (strs.Split(separator)[0] == "CombatVehicle")
                    {
                        artillery = new CombatVehicle(strs.Split(separator)[1]);
                    }
                    else if (strs.Split(separator)[0] == "SelfPropelledArtillery")
                    {
                        artillery = new SelfPropelledArtillery(strs.Split(separator)[1]);
                    }
                    if(!(baseStages[key] + artillery))
                    {
                        throw new TypeLoadException("Не удалось загрузить военную технику на базу");
                    }
                }
            }
        }
    }
}
