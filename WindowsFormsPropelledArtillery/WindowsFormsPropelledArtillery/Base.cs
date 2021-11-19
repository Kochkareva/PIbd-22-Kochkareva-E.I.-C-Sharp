using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPropelledArtillery
{
    /// <summary>
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Base<T> where T : class, ITransport
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private readonly T[] _places;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Размер места на базе (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 160;
        /// <summary>
        /// Размер места на базе (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 80;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер базы - ширина</param>
        /// <param name="picHeight">Рамзер базы - высота</param>
        public Base(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на базу добавляется военная техника
        /// </summary>
        /// <param name="p">База</param>
        /// <param name="combatVehicle">Добавляемая техника</param>
        /// <returns></returns>
        public static int operator +(Base<T> p, T combatVehicle)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                    p._places[i] = combatVehicle;
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с базы забираем военную технику
        /// </summary>
        /// <param name="p">База</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь  объект</param>
        /// <returns></returns>
        public static T operator -(Base<T> p, int index)
        {
            if (index <= p._places.Length)
            {
                T result = p._places[index];
                p._places[index] = null;
                return result;
            }
            return null;
        }

        /// <summary>
        /// Метод отрисовки базы
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.SetPosition(i % (pictureWidth / _placeSizeWidth) * _placeSizeWidth + 5,
                   i / (pictureHeight / _placeSizeHeight) * _placeSizeHeight + 10, pictureWidth, pictureHeight);
                _places[i]?.DrawTransport(g);
            }
        }

        /// <summary>
        /// Метод отрисовки разметки мест на базе
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                    _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
                (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
