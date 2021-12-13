using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPropelledArtillery
{
    public class CombatVehicle : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки боевой машины
        /// </summary>
        protected readonly int combatVehicleWidth = 100;

        /// <summary>
        /// Высота отрисовки боевой машины
        /// </summary>
        protected readonly int combatVehicleHeight = 60;

        /// <summary>
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        protected readonly char separator = ';';

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес боевой машины</param>
        /// <param name="mainColor">Основной цвет корпуса</param>
        public CombatVehicle(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public CombatVehicle(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        /// <summary>
        /// Конструктор с изменением размеров боевой машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес боевой машины</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="combatVehicleWidth">Ширина отрисовки боевой машины</param>
        /// <param name="combatVehicleHeight">Высота отрисовки боевой машины</param>
        protected CombatVehicle(int maxSpeed, float weight, Color mainColor, int combatVehicleWidth, int
        combatVehicleHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.combatVehicleWidth = combatVehicleWidth;
            this.combatVehicleHeight = combatVehicleHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - combatVehicleWidth)
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
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - combatVehicleHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            SolidBrush body = new SolidBrush(MainColor);
            //тело боевой машины
            g.FillRectangle(body, _startPosX, _startPosY + 20, combatVehicleWidth, 20);
            g.FillRectangle(body, _startPosX + 30, _startPosY, 40, 20);
            //гусеница
            SolidBrush caterpillar = new SolidBrush(Color.DarkGreen);          //цвет гусеницы
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
        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
    }
}
