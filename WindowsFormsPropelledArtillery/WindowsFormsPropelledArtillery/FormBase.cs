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
        /// Объект от класса-коллекции баз
        /// </summary>
        private readonly BaseCollection baseCollection;

        public FormBase()
        {
            InitializeComponent();
            baseCollection = new BaseCollection(pictureBoxBase.Width, pictureBoxBase.Height);
            Draw();
        }
        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxBase.SelectedIndex;
            listBoxBase.Items.Clear();
            for (int i = 0; i < baseCollection.Keys.Count; i++)
            {
                listBoxBase.Items.Add(baseCollection.Keys[i]);
            }
            if (listBoxBase.Items.Count > 0 && (index == -1 || index >=
            listBoxBase.Items.Count))
            {
                listBoxBase.SelectedIndex = 0;
            }
            else if (listBoxBase.Items.Count > 0 && index > -1 && index <
            listBoxBase.Items.Count)
            {
                listBoxBase.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Метод отрисовки базы
        /// </summary>
        private void Draw()
        {
            if (listBoxBase.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт
             // не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxBase.Width,
                pictureBoxBase.Height);
                Graphics gr = Graphics.FromImage(bmp);
                baseCollection[listBoxBase.SelectedItem.ToString()].Draw(gr);
                pictureBoxBase.Image = bmp;
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Добавить базу"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBase_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название базы", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            baseCollection.AddBase(textBoxNewLevelName.Text);
            ReloadLevels();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Удалить базу"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelBase_Click(object sender, EventArgs e)
        {
            if (listBoxBase.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку{ listBoxBase.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    baseCollection.DelBase(textBoxNewLevelName.Text);
                    ReloadLevels();
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Поставить бронерованную машину"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetCombatVehicle_Click(object sender, EventArgs e)
        {
            if (listBoxBase.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var combatVehicle = new CombatVehicle(100, 1000, dialog.Color);
                    if (baseCollection[listBoxBase.SelectedItem.ToString()] + combatVehicle)
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
        /// Обработка нажатия кнопки "Поставить самоходную артиллерийскую установку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetSelfPropelledArtillery_Click(object sender, EventArgs e)
        {
            if (listBoxBase.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var combatVehicle = new SelfPropelledArtillery(100, 1000, dialog.Color, dialogDop.Color, true, true);
                        if (baseCollection[listBoxBase.SelectedItem.ToString()] + combatVehicle)
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
        }

        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeCombatVehicle_Click(object sender, EventArgs e)
        {
            if (listBoxBase.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var combatVehicke = baseCollection[listBoxBase.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                if (combatVehicke != null)
                {
                    FormArtillery form = new FormArtillery();
                    form.SetCombatVehicle(combatVehicke);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
