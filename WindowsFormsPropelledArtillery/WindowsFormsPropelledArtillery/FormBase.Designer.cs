
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
            this.buttonSetCombatVehicle = new System.Windows.Forms.Button();
            this.buttonSetSelfPropelledArtillery = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakeCombatVehicle = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonAddBase = new System.Windows.Forms.Button();
            this.listBoxBase = new System.Windows.Forms.ListBox();
            this.buttonDeleteBase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBase
            // 
            this.pictureBoxBase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxBase.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxBase.Name = "pictureBoxBase";
            this.pictureBoxBase.Size = new System.Drawing.Size(1073, 558);
            this.pictureBoxBase.TabIndex = 0;
            this.pictureBoxBase.TabStop = false;
            // 
            // buttonSetCombatVehicle
            // 
            this.buttonSetCombatVehicle.Location = new System.Drawing.Point(1090, 233);
            this.buttonSetCombatVehicle.Name = "buttonSetCombatVehicle";
            this.buttonSetCombatVehicle.Size = new System.Drawing.Size(151, 71);
            this.buttonSetCombatVehicle.TabIndex = 1;
            this.buttonSetCombatVehicle.Text = "Поставить бронерованную машину";
            this.buttonSetCombatVehicle.UseVisualStyleBackColor = true;
            this.buttonSetCombatVehicle.Click += new System.EventHandler(this.buttonSetCombatVehicle_Click);
            // 
            // buttonSetSelfPropelledArtillery
            // 
            this.buttonSetSelfPropelledArtillery.Location = new System.Drawing.Point(1090, 310);
            this.buttonSetSelfPropelledArtillery.Name = "buttonSetSelfPropelledArtillery";
            this.buttonSetSelfPropelledArtillery.Size = new System.Drawing.Size(151, 78);
            this.buttonSetSelfPropelledArtillery.TabIndex = 2;
            this.buttonSetSelfPropelledArtillery.Text = "Поставить самоходную артиллерийскую установку";
            this.buttonSetSelfPropelledArtillery.UseVisualStyleBackColor = true;
            this.buttonSetSelfPropelledArtillery.Click += new System.EventHandler(this.buttonSetSelfPropelledArtillery_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakeCombatVehicle);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1090, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать военную технику";
            // 
            // buttonTakeCombatVehicle
            // 
            this.buttonTakeCombatVehicle.Location = new System.Drawing.Point(22, 77);
            this.buttonTakeCombatVehicle.Name = "buttonTakeCombatVehicle";
            this.buttonTakeCombatVehicle.Size = new System.Drawing.Size(110, 32);
            this.buttonTakeCombatVehicle.TabIndex = 2;
            this.buttonTakeCombatVehicle.Text = "Забрать";
            this.buttonTakeCombatVehicle.UseVisualStyleBackColor = true;
            this.buttonTakeCombatVehicle.Click += new System.EventHandler(this.buttonTakeCombatVehicle_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(78, 49);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(54, 22);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1135, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Базы:";
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(1090, 29);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(141, 22);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // buttonAddBase
            // 
            this.buttonAddBase.Location = new System.Drawing.Point(1090, 57);
            this.buttonAddBase.Name = "buttonAddBase";
            this.buttonAddBase.Size = new System.Drawing.Size(141, 29);
            this.buttonAddBase.TabIndex = 6;
            this.buttonAddBase.Text = "Добавить базу";
            this.buttonAddBase.UseVisualStyleBackColor = true;
            this.buttonAddBase.Click += new System.EventHandler(this.buttonAddBase_Click);
            // 
            // listBoxBase
            // 
            this.listBoxBase.FormattingEnabled = true;
            this.listBoxBase.ItemHeight = 16;
            this.listBoxBase.Location = new System.Drawing.Point(1090, 92);
            this.listBoxBase.Name = "listBoxBase";
            this.listBoxBase.Size = new System.Drawing.Size(141, 84);
            this.listBoxBase.TabIndex = 7;
            this.listBoxBase.Click += new System.EventHandler(this.listBoxBase_SelectedIndexChanged);
            // 
            // buttonDeleteBase
            // 
            this.buttonDeleteBase.Location = new System.Drawing.Point(1090, 183);
            this.buttonDeleteBase.Name = "buttonDeleteBase";
            this.buttonDeleteBase.Size = new System.Drawing.Size(141, 44);
            this.buttonDeleteBase.TabIndex = 8;
            this.buttonDeleteBase.Text = "Удалить базу";
            this.buttonDeleteBase.UseVisualStyleBackColor = true;
            this.buttonDeleteBase.Click += new System.EventHandler(this.buttonDelBase_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 558);
            this.Controls.Add(this.buttonDeleteBase);
            this.Controls.Add(this.listBoxBase);
            this.Controls.Add(this.buttonAddBase);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetSelfPropelledArtillery);
            this.Controls.Add(this.buttonSetCombatVehicle);
            this.Controls.Add(this.pictureBoxBase);
            this.Name = "FormBase";
            this.Text = "FormBase";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBase;
        private System.Windows.Forms.Button buttonSetCombatVehicle;
        private System.Windows.Forms.Button buttonSetSelfPropelledArtillery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeCombatVehicle;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddBase;
        private System.Windows.Forms.ListBox listBoxBase;
        private System.Windows.Forms.Button buttonDeleteBase;
    }
}