namespace WindowsFormBoat
{
    partial class FormBoat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoat));
            this.pictureBoxBoat = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonCreateSport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBoat
            // 
            this.pictureBoxBoat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBoxBoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBoat.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBoat.Name = "pictureBoxBoat";
            this.pictureBoxBoat.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxBoat.TabIndex = 0;
            this.pictureBoxBoat.TabStop = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(107, 24);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(129, 23);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Создать катер";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.createClick);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.oX9AJRa_K2g;
            this.buttonLeft.Location = new System.Drawing.Point(714, 376);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(45, 42);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.UseWaitCursor = true;
            this.buttonLeft.Click += new System.EventHandler(this.moveClick);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.Location = new System.Drawing.Point(765, 327);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(41, 45);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.moveClick);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._64_KLxHnJbw;
            this.buttonDown.Location = new System.Drawing.Point(765, 376);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(41, 42);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.moveClick);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.aB2YFybUJVU;
            this.buttonRight.Location = new System.Drawing.Point(812, 376);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(44, 42);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.moveClick);
            // 
            // buttonCreateSport
            // 
            this.buttonCreateSport.Location = new System.Drawing.Point(283, 24);
            this.buttonCreateSport.Name = "buttonCreateSport";
            this.buttonCreateSport.Size = new System.Drawing.Size(154, 23);
            this.buttonCreateSport.TabIndex = 6;
            this.buttonCreateSport.Text = "Создать гоночный катер";
            this.buttonCreateSport.UseVisualStyleBackColor = true;
            this.buttonCreateSport.Click += new System.EventHandler(this.createSportClick);
            // 
            // FormBoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonCreateSport);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxBoat);
            this.Name = "FormBoat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoatForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        public System.Windows.Forms.PictureBox pictureBoxBoat;
        private System.Windows.Forms.Button buttonCreateSport;
    }
}

