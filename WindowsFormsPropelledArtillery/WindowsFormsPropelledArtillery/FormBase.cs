﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
                if (MessageBox.Show($"Удалить парковку { listBoxBase.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    baseCollection.DelBase(listBoxBase.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Добавить технику"
        /// </summary>
        private void ButtonSetCombatVehicle_Click(object sender, EventArgs e)
        {
            if (listBoxBase.SelectedIndex > -1)
            {
                var formCombatVehicle = new FormCombatVehicleConfig();
                formCombatVehicle.AddEvent(AddCombatVehicle);
                formCombatVehicle.Show();
            }
        }

        /// <summary>
        /// Метод добавления техники
        /// </summary>
        private void AddCombatVehicle(Vehicle combatVehicle)
        {
            if (combatVehicle != null && listBoxBase.SelectedIndex > -1)
            {
                if ((baseCollection[listBoxBase.SelectedItem.ToString()]) + combatVehicle)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("не удалось поставить");
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
        /// <summary>
        /// Обработка нажатия пункта меню "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (baseCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (baseCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();

                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
