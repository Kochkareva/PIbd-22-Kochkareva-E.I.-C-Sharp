
namespace WindowsFormsPropelledArtillery
{
    partial class FormCombatVehicleConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSelfPropelledArtillery = new System.Windows.Forms.Label();
            this.labelCombatVehicle = new System.Windows.Forms.Label();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxAmmunition = new System.Windows.Forms.CheckBox();
            this.checkBoxGun = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCombatVehicle = new System.Windows.Forms.Panel();
            this.pictureBoxCombatVehicle = new System.Windows.Forms.PictureBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.Red = new System.Windows.Forms.Panel();
            this.Yellow = new System.Windows.Forms.Panel();
            this.Gray = new System.Windows.Forms.Panel();
            this.Orange = new System.Windows.Forms.Panel();
            this.Black = new System.Windows.Forms.Panel();
            this.White = new System.Windows.Forms.Panel();
            this.Green = new System.Windows.Forms.Panel();
            this.Blue = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.panelCombatVehicle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCombatVehicle)).BeginInit();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSelfPropelledArtillery);
            this.groupBox1.Controls.Add(this.labelCombatVehicle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип военной техники";
            // 
            // labelSelfPropelledArtillery
            // 
            this.labelSelfPropelledArtillery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSelfPropelledArtillery.Location = new System.Drawing.Point(6, 59);
            this.labelSelfPropelledArtillery.Name = "labelSelfPropelledArtillery";
            this.labelSelfPropelledArtillery.Size = new System.Drawing.Size(115, 53);
            this.labelSelfPropelledArtillery.TabIndex = 1;
            this.labelSelfPropelledArtillery.Text = "Самоходная артиллерийская установка";
            this.labelSelfPropelledArtillery.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSelfPropelledArtillery_MouseDown);
            // 
            // labelCombatVehicle
            // 
            this.labelCombatVehicle.AutoSize = true;
            this.labelCombatVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCombatVehicle.Location = new System.Drawing.Point(6, 28);
            this.labelCombatVehicle.Name = "labelCombatVehicle";
            this.labelCombatVehicle.Size = new System.Drawing.Size(115, 17);
            this.labelCombatVehicle.TabIndex = 0;
            this.labelCombatVehicle.Text = "Броневая машина";
            this.labelCombatVehicle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCombatVehicle_MouseDown);
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.checkBoxAmmunition);
            this.groupBoxParameters.Controls.Add(this.checkBoxGun);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxParameters.Controls.Add(this.label2);
            this.groupBoxParameters.Controls.Add(this.label1);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 142);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(306, 134);
            this.groupBoxParameters.TabIndex = 1;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // checkBoxAmmunition
            // 
            this.checkBoxAmmunition.AutoSize = true;
            this.checkBoxAmmunition.Location = new System.Drawing.Point(160, 91);
            this.checkBoxAmmunition.Name = "checkBoxAmmunition";
            this.checkBoxAmmunition.Size = new System.Drawing.Size(107, 19);
            this.checkBoxAmmunition.TabIndex = 5;
            this.checkBoxAmmunition.Text = "Боекомплект";
            this.checkBoxAmmunition.UseVisualStyleBackColor = true;
            // 
            // checkBoxGun
            // 
            this.checkBoxGun.AutoSize = true;
            this.checkBoxGun.Location = new System.Drawing.Point(160, 50);
            this.checkBoxGun.Name = "checkBoxGun";
            this.checkBoxGun.Size = new System.Drawing.Size(115, 19);
            this.checkBoxGun.TabIndex = 4;
            this.checkBoxGun.Text = "Боевое орудие";
            this.checkBoxGun.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(67, 91);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(67, 49);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес техники:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Макс. скорость:";
            // 
            // panelCombatVehicle
            // 
            this.panelCombatVehicle.AllowDrop = true;
            this.panelCombatVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCombatVehicle.Controls.Add(this.pictureBoxCombatVehicle);
            this.panelCombatVehicle.Location = new System.Drawing.Point(172, 12);
            this.panelCombatVehicle.Name = "panelCombatVehicle";
            this.panelCombatVehicle.Size = new System.Drawing.Size(146, 124);
            this.panelCombatVehicle.TabIndex = 2;
            this.panelCombatVehicle.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCombatVehicle_DragDrop);
            this.panelCombatVehicle.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCombatVehicle_DragEnter);
            // 
            // pictureBoxCombatVehicle
            // 
            this.pictureBoxCombatVehicle.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxCombatVehicle.Name = "pictureBoxCombatVehicle";
            this.pictureBoxCombatVehicle.Size = new System.Drawing.Size(120, 99);
            this.pictureBoxCombatVehicle.TabIndex = 0;
            this.pictureBoxCombatVehicle.TabStop = false;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.Blue);
            this.groupBoxColor.Controls.Add(this.Green);
            this.groupBoxColor.Controls.Add(this.White);
            this.groupBoxColor.Controls.Add(this.Black);
            this.groupBoxColor.Controls.Add(this.Orange);
            this.groupBoxColor.Controls.Add(this.Gray);
            this.groupBoxColor.Controls.Add(this.Yellow);
            this.groupBoxColor.Controls.Add(this.Red);
            this.groupBoxColor.Controls.Add(this.labelDopColor);
            this.groupBoxColor.Controls.Add(this.labelBaseColor);
            this.groupBoxColor.Location = new System.Drawing.Point(339, 12);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(235, 181);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(6, 28);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(103, 33);
            this.labelBaseColor.TabIndex = 0;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(126, 28);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(103, 33);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Firebrick;
            this.Red.Location = new System.Drawing.Point(6, 80);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(36, 32);
            this.Red.TabIndex = 2;
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Gold;
            this.Yellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Yellow.Location = new System.Drawing.Point(73, 81);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(36, 32);
            this.Yellow.TabIndex = 3;
            // 
            // Gray
            // 
            this.Gray.BackColor = System.Drawing.Color.Silver;
            this.Gray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Gray.Location = new System.Drawing.Point(6, 130);
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(36, 32);
            this.Gray.TabIndex = 4;
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.SandyBrown;
            this.Orange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Orange.Location = new System.Drawing.Point(73, 130);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(36, 32);
            this.Orange.TabIndex = 5;
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Black.Location = new System.Drawing.Point(126, 80);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(36, 33);
            this.Black.TabIndex = 6;
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.White.Location = new System.Drawing.Point(193, 80);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(36, 32);
            this.White.TabIndex = 7;
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.LightGreen;
            this.Green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Green.Location = new System.Drawing.Point(126, 132);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(36, 30);
            this.Green.TabIndex = 8;
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Blue.Location = new System.Drawing.Point(193, 130);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(36, 32);
            this.Blue.TabIndex = 9;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(493, 253);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(493, 205);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormCombatVehicleConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelCombatVehicle);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCombatVehicleConfig";
            this.Text = "FormCombatVehicleConfig";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.panelCombatVehicle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCombatVehicle)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSelfPropelledArtillery;
        private System.Windows.Forms.Label labelCombatVehicle;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.CheckBox checkBoxAmmunition;
        private System.Windows.Forms.CheckBox checkBoxGun;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCombatVehicle;
        private System.Windows.Forms.PictureBox pictureBoxCombatVehicle;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel Blue;
        private System.Windows.Forms.Panel Green;
        private System.Windows.Forms.Panel White;
        private System.Windows.Forms.Panel Black;
        private System.Windows.Forms.Panel Orange;
        private System.Windows.Forms.Panel Gray;
        private System.Windows.Forms.Panel Yellow;
        private System.Windows.Forms.Panel Red;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}