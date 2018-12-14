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
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTake = new System.Windows.Forms.Button();
            this.pictureBoxPrev = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSetBoat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Sort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHarbour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrev)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxHarbour
            // 
            this.pictureBoxHarbour.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxHarbour.Location = new System.Drawing.Point(0, 28);
            this.pictureBoxHarbour.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxHarbour.Name = "pictureBoxHarbour";
            this.pictureBoxHarbour.Size = new System.Drawing.Size(901, 539);
            this.pictureBoxHarbour.TabIndex = 0;
            this.pictureBoxHarbour.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(985, 315);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Забрать судно";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(1056, 347);
            this.maskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(36, 22);
            this.maskedTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(973, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Место";
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(977, 379);
            this.buttonTake.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(139, 28);
            this.buttonTake.TabIndex = 6;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click_1);
            // 
            // pictureBoxPrev
            // 
            this.pictureBoxPrev.Location = new System.Drawing.Point(909, 426);
            this.pictureBoxPrev.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPrev.Name = "pictureBoxPrev";
            this.pictureBoxPrev.Size = new System.Drawing.Size(267, 127);
            this.pictureBoxPrev.TabIndex = 7;
            this.pictureBoxPrev.TabStop = false;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(953, 42);
            this.listBoxLevels.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(180, 100);
            this.listBoxLevels.TabIndex = 8;
        
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1013, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Уровни";
            // 
            // buttonSetBoat
            // 
            this.buttonSetBoat.Location = new System.Drawing.Point(953, 150);
            this.buttonSetBoat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetBoat.Name = "buttonSetBoat";
            this.buttonSetBoat.Size = new System.Drawing.Size(181, 71);
            this.buttonSetBoat.TabIndex = 1;
            this.buttonSetBoat.Text = "Добавить водное средство";
            this.buttonSetBoat.UseVisualStyleBackColor = true;
            this.buttonSetBoat.Click += new System.EventHandler(this.buttonSetBoat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1179, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMain
            // 
            this.toolStripMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSave,
            this.toolStripLoad});
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(57, 24);
            this.toolStripMain.Text = "Файл";
            // 
            // toolStripSave
            // 
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(216, 26);
            this.toolStripSave.Text = "Сохранить";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripLoad
            // 
            this.toolStripLoad.Name = "toolStripLoad";
            this.toolStripLoad.Size = new System.Drawing.Size(216, 26);
            this.toolStripLoad.Text = "Загрузить";
            this.toolStripLoad.Click += new System.EventHandler(this.toolStripLoad_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.tx";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.tx";
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(954, 237);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(180, 59);
            this.Sort.TabIndex = 11;
            this.Sort.Text = "Сортировать";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // FormHarbour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 567);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.pictureBoxPrev);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSetBoat);
            this.Controls.Add(this.pictureBoxHarbour);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHarbour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHarbour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrev)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHarbour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.PictureBox pictureBoxPrev;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSetBoat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button Sort;
    }
}

