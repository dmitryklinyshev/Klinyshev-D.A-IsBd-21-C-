namespace WindowsFormHarbour
{
    partial class FormHarbour
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
            this.pictureBoxHarbour = new System.Windows.Forms.PictureBox();
            this.buttonSetBoat = new System.Windows.Forms.Button();
            this.buttonSetSpeedBoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTake = new System.Windows.Forms.Button();
            this.pictureBoxPrev = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHarbour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrev)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHarbour
            // 
            this.pictureBoxHarbour.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxHarbour.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHarbour.Name = "pictureBoxHarbour";
            this.pictureBoxHarbour.Size = new System.Drawing.Size(738, 461);
            this.pictureBoxHarbour.TabIndex = 0;
            this.pictureBoxHarbour.TabStop = false;
            // 
            // buttonSetBoat
            // 
            this.buttonSetBoat.Location = new System.Drawing.Point(754, 12);
            this.buttonSetBoat.Name = "buttonSetBoat";
            this.buttonSetBoat.Size = new System.Drawing.Size(118, 46);
            this.buttonSetBoat.TabIndex = 1;
            this.buttonSetBoat.Text = "Пришвартовать лодку";
            this.buttonSetBoat.UseVisualStyleBackColor = true;
            this.buttonSetBoat.Click += new System.EventHandler(this.buttonSetBoat_Click);
            // 
            // buttonSetSpeedBoat
            // 
            this.buttonSetSpeedBoat.Location = new System.Drawing.Point(754, 79);
            this.buttonSetSpeedBoat.Name = "buttonSetSpeedBoat";
            this.buttonSetSpeedBoat.Size = new System.Drawing.Size(118, 46);
            this.buttonSetSpeedBoat.TabIndex = 2;
            this.buttonSetSpeedBoat.Text = "Пришвартовать катер";
            this.buttonSetSpeedBoat.UseVisualStyleBackColor = true;
            this.buttonSetSpeedBoat.Click += new System.EventHandler(this.buttonSetSpeedBoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(765, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Забрать судно";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(830, 282);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(28, 20);
            this.maskedTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(777, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Место";
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(754, 317);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(104, 23);
            this.buttonTake.TabIndex = 6;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // pictureBoxPrev
            // 
            this.pictureBoxPrev.Location = new System.Drawing.Point(744, 359);
            this.pictureBoxPrev.Name = "pictureBoxPrev";
            this.pictureBoxPrev.Size = new System.Drawing.Size(128, 90);
            this.pictureBoxPrev.TabIndex = 7;
            this.pictureBoxPrev.TabStop = false;
            // 
            // FormHarbour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.pictureBoxPrev);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSetSpeedBoat);
            this.Controls.Add(this.buttonSetBoat);
            this.Controls.Add(this.pictureBoxHarbour);
            this.Name = "FormHarbour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoatForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHarbour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHarbour;
        private System.Windows.Forms.Button buttonSetBoat;
        private System.Windows.Forms.Button buttonSetSpeedBoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.PictureBox pictureBoxPrev;
    }
}

