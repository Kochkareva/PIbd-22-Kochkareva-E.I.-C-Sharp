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
    public partial class FormBase : Form
    {
        /// <summary>
        /// Объект от класса-база
        /// </summary>
        private readonly Base<CombatVehicle> combatBase;
        
        public FormBase()
        {
            InitializeComponent();
            combatBase = new Base<CombatVehicle>(pictureBoxBase.Width, pictureBoxBase.Height);
            Draw();
        }

        /// <summary>
        /// Метод отрисовки базы
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBase.Width, pictureBoxBase.Height);
            Graphics gr = Graphics.FromImage(bmp);
            combatBase.Draw(gr);
            pictureBoxBase.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Поставить бронерованную машину"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetCombatVehicle_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var combatVehicle = new CombatVehicle(100, 1000, dialog.Color);
                if (combatBase + combatVehicle != -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("База переполнена");
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Поставить самоходную артиллерийскую установку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetSelfPropelledArtillery_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var combatVehicle = new SelfPropelledArtillery(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (combatBase + combatVehicle != -1)
                    {
                        Draw();
                    }
                    else
                    {

                        MessageBox.Show("База переполнена");
                    }
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeCombatVehicle_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var combatVehicle = combatBase - Convert.ToInt32(maskedTextBox.Text);
                if (combatVehicle != null)
                {
                    FormArtillery form = new FormArtillery();
                    form.SetCombatVehicle(combatVehicle);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
