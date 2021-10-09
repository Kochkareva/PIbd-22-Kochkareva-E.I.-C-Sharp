using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPropelledArtillery
{
    /// <summary>
    /// Класс отрисовки самоходной артиллерийской установки 
    /// </summary>
    class SelfPropelledArtillery
    {
        /// <summary>
        /// Левая координата отрисовки артиллерийской установки 
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки артиллерийской установки 
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        ///<summary>
        /// Ширина отрисовки артиллерийской установки 
        /// </summary>
        private readonly int artilleryWidth = 100;
        /// <summary>
        /// Высота отрисовки артиллерийской установки
        /// </summary>
        private readonly int artilleryHeight = 60;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес артиллерийской установки
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия боекомплекта
        /// </summary>
        public bool Ammunition { private set; get; }
        /// <summary>
        /// Признак наличия боевого орудия
        /// </summary>
        public bool Gun { private set; get; }

        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес артиллерийской установки</param>
        /// <param name="mainColor">Основной цвет </param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="ammunition">Признак наличия боекомплекта</param>
        /// <param name="gun">Признак наличия боевого орудия</para
        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool ammunition, bool gun)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Ammunition = ammunition;
            Gun = gun;
        }
        /// <summary>
        /// Установка позиции артиллерийской установки
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - artilleryWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if(_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - artilleryHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка артиллерийской установки
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            SolidBrush body = new SolidBrush(MainColor);
            //тело самоходной артиллерийской установки
            g.FillRectangle(body, _startPosX, _startPosY + 20, artilleryWidth, 20);
            g.FillRectangle(body, _startPosX + 30, _startPosY, 40, 20);
            //гусеница
            SolidBrush caterpillar = new SolidBrush(Color.DarkGreen);          //цвет гусеницы танка
            g.FillEllipse(caterpillar, _startPosX, _startPosY + 39, 20, 20);
            g.FillEllipse(caterpillar, _startPosX + 80, _startPosY + 39, 20, 20);
            g.FillRectangle(caterpillar, _startPosX + 10, _startPosY + 39, 80, 20);
            SolidBrush detals = new SolidBrush(Color.Black);  //цвет колес в гусенице
            g.FillEllipse(detals, _startPosX + 5, _startPosY + 40, 16, 16);
            g.FillEllipse(detals, _startPosX + 80, _startPosY + 40, 16, 16);
            g.FillEllipse(detals, _startPosX + 23, _startPosY + 45, 12, 12);
            g.FillEllipse(detals, _startPosX + 38, _startPosY + 45, 12, 12);
            g.FillEllipse(detals, _startPosX + 53, _startPosY + 45, 12, 12);
            g.FillEllipse(detals, _startPosX + 68, _startPosY + 45, 12, 12);
            if (Ammunition)
            {
                SolidBrush ammunit = new SolidBrush(DopColor);
                g.FillRectangle(ammunit, _startPosX + 85, _startPosY + 10, 15, 10);
            }
            if (Gun)
            {
                SolidBrush guns = new SolidBrush(DopColor);
                g.FillRectangle(guns, _startPosX, _startPosY + 5, 30, 5);
            }
        }
    }
}

