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
    public class SelfPropelledArtillery : CombatVehicle 
    {        
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
        public SelfPropelledArtillery(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool ammunition, bool gun) :
        base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            Ammunition = ammunition;
            Gun = gun;
        }

        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        public SelfPropelledArtillery(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Ammunition = Convert.ToBoolean(strs[4]);
                Gun = Convert.ToBoolean(strs[5]);
            }
        }
        /// <summary>
        /// Отрисовка артиллерийской установки
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {
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
            base.DrawTransport(g);
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return
            $"{base.ToString()}{separator}{DopColor.Name}{separator}{Ammunition}{separator}{Gun}";
        }
    }
}

