
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
            this.buttonSetCombatVehicle.Location = new System.Drawing.Point(1090, 12);
            this.buttonSetCombatVehicle.Name = "buttonSetCombatVehicle";
            this.buttonSetCombatVehicle.Size = new System.Drawing.Size(151, 71);
            this.buttonSetCombatVehicle.TabIndex = 1;
            this.buttonSetCombatVehicle.Text = "Поставить бронерованную машину";
            this.buttonSetCombatVehicle.UseVisualStyleBackColor = true;
            this.buttonSetCombatVehicle.Click += new System.EventHandler(this.buttonSetCombatVehicle_Click);
            // 
            // buttonSetSelfPropelledArtillery
            // 
            this.buttonSetSelfPropelledArtillery.Location = new System.Drawing.Point(1090, 89);
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
            this.groupBox1.Location = new System.Drawing.Point(1090, 173);
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
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 558);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBase;
        private System.Windows.Forms.Button buttonSetCombatVehicle;
        private System.Windows.Forms.Button buttonSetSelfPropelledArtillery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeCombatVehicle;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
    }
}