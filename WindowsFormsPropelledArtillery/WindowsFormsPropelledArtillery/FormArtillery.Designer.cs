
namespace WindowsFormsPropelledArtillery
{
    partial class FormArtillery
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArtillery));
            this.pictureBoxArtillery = new System.Windows.Forms.PictureBox();
            this.buttonCreateCombatVehicle = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonCreateSelfPropelledArtillery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtillery)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxArtillery
            // 
            this.pictureBoxArtillery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxArtillery.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxArtillery.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxArtillery.Name = "pictureBoxArtillery";
            this.pictureBoxArtillery.Size = new System.Drawing.Size(882, 453);
            this.pictureBoxArtillery.TabIndex = 0;
            this.pictureBoxArtillery.TabStop = false;
            // 
            // buttonCreateCombatVehicle
            // 
            this.buttonCreateCombatVehicle.Location = new System.Drawing.Point(20, 11);
            this.buttonCreateCombatVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateCombatVehicle.Name = "buttonCreateCombatVehicle";
            this.buttonCreateCombatVehicle.Size = new System.Drawing.Size(116, 47);
            this.buttonCreateCombatVehicle.TabIndex = 1;
            this.buttonCreateCombatVehicle.Text = "Создать Боевую машину";
            this.buttonCreateCombatVehicle.UseVisualStyleBackColor = true;
            this.buttonCreateCombatVehicle.Click += new System.EventHandler(this.buttonCreateCombatVehicle_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(823, 390);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(22, 24);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(796, 419);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(22, 24);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(850, 419);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(22, 24);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(823, 419);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(22, 24);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateSelfPropelledArtillery
            // 
            this.buttonCreateSelfPropelledArtillery.Location = new System.Drawing.Point(141, 11);
            this.buttonCreateSelfPropelledArtillery.Name = "buttonCreateSelfPropelledArtillery";
            this.buttonCreateSelfPropelledArtillery.Size = new System.Drawing.Size(143, 47);
            this.buttonCreateSelfPropelledArtillery.TabIndex = 6;
            this.buttonCreateSelfPropelledArtillery.Text = "Создать самоходную артиллерийскую установку";
            this.buttonCreateSelfPropelledArtillery.UseVisualStyleBackColor = true;
            this.buttonCreateSelfPropelledArtillery.Click += new System.EventHandler(this.buttonCreateSelfPropelledArtillery_Click);
            // 
            // FormArtillery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.buttonCreateSelfPropelledArtillery);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreateCombatVehicle);
            this.Controls.Add(this.pictureBoxArtillery);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormArtillery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Самоходная Артиллерийская Установка";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtillery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxArtillery;
        private System.Windows.Forms.Button buttonCreateCombatVehicle;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonCreateSelfPropelledArtillery;
    }
}

