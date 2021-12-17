using System;
using System.Collections;
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
    public class Base<T> : IEnumerator<T>, IEnumerable<T>
        where T : class, ITransport
    {
        /// <summary>
        /// Список объектов, которые храним
        /// </summary>
        private readonly List<T> _places;
        /// <summary>
        /// Максимальное количество мест на базе
        /// </summary>
        private readonly int _maxCount;
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
        /// Текущий элемент для вывода через IEnumerator (будет обращаться по своему индексу к ключу словаря, по которму будет возвращаться запись)
        /// </summary>
        private int _currentIndex;

        public T Current => _places[_currentIndex];

        object IEnumerator.Current => _places[_currentIndex];

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер базы - ширина</param>
        /// <param name="picHeight">Рамзер базы - высота</param>
        public Base(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на базу добавляется военная техника
        /// </summary>
        /// <param name="p">База</param>
        /// <param name="combatVehicle">Добавляемая техника</param>
        /// <returns></returns>
        public static bool operator +(Base<T> p, T combatVehicle)
        {
            if (p._places.Contains(combatVehicle))
            {
                throw new BaseAlreadyHaveException();
            }
            if (p._places.Count < p._maxCount)
            {
                p._places.Add(combatVehicle);
                return true;
            }
            else
            {
                throw new BaseOverflowException();
            }
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
            if (index < p._maxCount && index >= 0)
            {
                T combatVehicle = p._places[index];
                p._places.RemoveAt(index);
                return combatVehicle;
            }
            else
            {
                throw new BaseNotFoundException(index);
            }
        }

        /// <summary>
        /// Метод отрисовки базы
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
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

        /// <summary>
        /// Функция получения элементы из списка
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }

        /// <summary>
        /// Сортировка военной техники на базе
        /// </summary>
        public void Sort() => _places.Sort((IComparer<T>)new ArtilleryComparer());

        /// <summary>
        /// Метод интерфейса IEnumerator, вызываемый при удалении объекта
        /// </summary>
        public void Dispose()
        {
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для перехода к следующему элементу или началу коллекции
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            _currentIndex++;
            return (_currentIndex < _places.Count);
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
        /// </summary>
        public void Reset()
        {
            _currentIndex = -1;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
