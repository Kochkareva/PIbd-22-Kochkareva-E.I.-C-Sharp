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
    public partial class FormCombatVehicleConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная техника
        /// </summary>
        Vehicle artillery = null;

        public Action<Vehicle> eventAddCombatVehicle;

        public FormCombatVehicleConfig()
        {
            InitializeComponent();
            Red.MouseDown += panelColor_MouseDown;
            Yellow.MouseDown += panelColor_MouseDown;
            Black.MouseDown += panelColor_MouseDown;
            White.MouseDown += panelColor_MouseDown;
            Gray.MouseDown += panelColor_MouseDown;
            Orange.MouseDown += panelColor_MouseDown;
            Green.MouseDown += panelColor_MouseDown;
            Blue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddCombatVehicle == null)
            {
                eventAddCombatVehicle = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddCombatVehicle += ev;
            }
        }
        /// <summary>
        /// Отрисовать военную технику
        /// </summary>
        private void DrawCombatVehicle()
        {
            if (artillery != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxCombatVehicle.Width, pictureBoxCombatVehicle.Height);
                Graphics gr = Graphics.FromImage(bmp);
                artillery.SetPosition(5, 5, pictureBoxCombatVehicle.Width, pictureBoxCombatVehicle.Height);
                artillery.DrawTransport(gr);
                pictureBoxCombatVehicle.Image = bmp;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label (броневая машина)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelCombatVehicle_MouseDown(object sender, MouseEventArgs e)
        {
            labelCombatVehicle.DoDragDrop(labelCombatVehicle.Text, DragDropEffects.Move |
                DragDropEffects.Copy);
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label (самоходная артиллерийская установка)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelSelfPropelledArtillery_MouseDown(object sender, MouseEventArgs e)
        {
            labelSelfPropelledArtillery.DoDragDrop(labelSelfPropelledArtillery.Text, DragDropEffects.Move |
                DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelCombatVehicle_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelCombatVehicle_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Броневая машина":
                    artillery = new CombatVehicle((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Самоходная артиллерийская установка":
                    artillery = new SelfPropelledArtillery((int)numericUpDownSpeed.Value,
                        (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxAmmunition.Checked, checkBoxGun.Checked);
                    break;
            }
            DrawCombatVehicle();
        }

        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (artillery != null)
            {
                artillery.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCombatVehicle();
            }
        }

        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (artillery != null)
            {
                if (artillery is SelfPropelledArtillery)
                {
                    (artillery as SelfPropelledArtillery).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawCombatVehicle();
                }
            }
        }
        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        ///<summary>
        /// Добавление военной техники
        /// </summary>
        ///   
        private void buttonOK_Click(object sender, EventArgs e)
        {
            eventAddCombatVehicle?.Invoke(artillery);
            Close();
        }
    }
}
