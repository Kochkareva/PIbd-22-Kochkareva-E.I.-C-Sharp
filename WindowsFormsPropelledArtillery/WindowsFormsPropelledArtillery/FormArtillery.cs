using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPropelledArtillery
{
    public partial class FormArtillery : Form
    {
        private ITransport combatVehicle;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormArtillery()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Передача боевой машины на форму
        /// </summary>
        /// <param name="combatVehicle"></param>
        public void SetCombatVehicle(ITransport combatVehicle)
        {
            this.combatVehicle = combatVehicle;
            Draw();
        }
        /// <summary>
        /// Метод отрисовки боевой машины
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxArtillery.Width, pictureBoxArtillery.Height);
            Graphics gr = Graphics.FromImage(bmp);
            combatVehicle?.DrawTransport(gr);
            pictureBoxArtillery.Image = bmp;
        }
        
        ///<summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    combatVehicle?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    combatVehicle?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    combatVehicle?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    combatVehicle?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
