
namespace WindowsFormsPropelledArtillery
{
    partial class FormBase
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
            this.pictureBoxBase = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakeCombatVehicle = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonAddBase = new System.Windows.Forms.Button();
            this.listBoxBase = new System.Windows.Forms.ListBox();
            this.buttonDeleteBase = new System.Windows.Forms.Button();
            this.ButtonSetCombatVehicle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBase
            // 
            this.pictureBoxBase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxBase.Location = new System.Drawing.Point(0, 30);
            this.pictureBoxBase.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBase.Name = "pictureBoxBase";
            this.pictureBoxBase.Size = new System.Drawing.Size(805, 453);
            this.pictureBoxBase.TabIndex = 0;
            this.pictureBoxBase.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakeCombatVehicle);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(818, 272);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(113, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать военную технику";
            // 
            // buttonTakeCombatVehicle
            // 
            this.buttonTakeCombatVehicle.Location = new System.Drawing.Point(17, 75);
            this.buttonTakeCombatVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTakeCombatVehicle.Name = "buttonTakeCombatVehicle";
            this.buttonTakeCombatVehicle.Size = new System.Drawing.Size(82, 26);
            this.buttonTakeCombatVehicle.TabIndex = 2;
            this.buttonTakeCombatVehicle.Text = "Забрать";
            this.buttonTakeCombatVehicle.UseVisualStyleBackColor = true;
            this.buttonTakeCombatVehicle.Click += new System.EventHandler(this.buttonTakeCombatVehicle_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(58, 45);
            this.maskedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(42, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(851, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Базы:";
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(818, 24);
            this.textBoxNewLevelName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(107, 20);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // buttonAddBase
            // 
            this.buttonAddBase.Location = new System.Drawing.Point(818, 46);
            this.buttonAddBase.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddBase.Name = "buttonAddBase";
            this.buttonAddBase.Size = new System.Drawing.Size(106, 24);
            this.buttonAddBase.TabIndex = 6;
            this.buttonAddBase.Text = "Добавить базу";
            this.buttonAddBase.UseVisualStyleBackColor = true;
            this.buttonAddBase.Click += new System.EventHandler(this.buttonAddBase_Click);
            // 
            // listBoxBase
            // 
            this.listBoxBase.FormattingEnabled = true;
            this.listBoxBase.Location = new System.Drawing.Point(818, 75);
            this.listBoxBase.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBase.Name = "listBoxBase";
            this.listBoxBase.Size = new System.Drawing.Size(107, 69);
            this.listBoxBase.TabIndex = 7;
            this.listBoxBase.SelectedIndexChanged += new System.EventHandler(this.listBoxBase_SelectedIndexChanged);
            // 
            // buttonDeleteBase
            // 
            this.buttonDeleteBase.Location = new System.Drawing.Point(818, 149);
            this.buttonDeleteBase.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteBase.Name = "buttonDeleteBase";
            this.buttonDeleteBase.Size = new System.Drawing.Size(106, 36);
            this.buttonDeleteBase.TabIndex = 8;
            this.buttonDeleteBase.Text = "Удалить базу";
            this.buttonDeleteBase.UseVisualStyleBackColor = true;
            this.buttonDeleteBase.Click += new System.EventHandler(this.buttonDelBase_Click);
            // 
            // ButtonSetCombatVehicle
            // 
            this.ButtonSetCombatVehicle.Location = new System.Drawing.Point(820, 208);
            this.ButtonSetCombatVehicle.Name = "ButtonSetCombatVehicle";
            this.ButtonSetCombatVehicle.Size = new System.Drawing.Size(98, 44);
            this.ButtonSetCombatVehicle.TabIndex = 9;
            this.ButtonSetCombatVehicle.Text = "Добавить технику";
            this.ButtonSetCombatVehicle.UseVisualStyleBackColor = true;
            this.ButtonSetCombatVehicle.Click += new System.EventHandler(this.ButtonSetCombatVehicle_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file| *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file| *.txt";
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 517);
            this.Controls.Add(this.ButtonSetCombatVehicle);
            this.Controls.Add(this.buttonDeleteBase);
            this.Controls.Add(this.listBoxBase);
            this.Controls.Add(this.buttonAddBase);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxBase);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBase";
            this.Text = "FormBase";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeCombatVehicle;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddBase;
        private System.Windows.Forms.ListBox listBoxBase;
        private System.Windows.Forms.Button buttonDeleteBase;
        private System.Windows.Forms.Button ButtonSetCombatVehicle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}