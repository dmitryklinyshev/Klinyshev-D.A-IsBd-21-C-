using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;                                                                                                                                                                                                                                                                                                                                                                              
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static WindowsFormsApp1.Ship;

namespace WindowsFormHarbour {


    public partial class FormHarbour : Form
    {

        MultiLevelHarbour harbour;

        FormBoatConfig form;

        private const int countLevel = 5;


        public FormHarbour()
        {
            InitializeComponent();
            harbour = new MultiLevelHarbour(countLevel, pictureBoxHarbour.Width, pictureBoxHarbour.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень" + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                                Bitmap bmp = new Bitmap(pictureBoxHarbour.Width, pictureBoxHarbour.Height);
                Graphics g = Graphics.FromImage(bmp);
                harbour[listBoxLevels.SelectedIndex].Draw(g);
                pictureBoxHarbour.Image = bmp;
            }
        }


        private void buttonSetBoat_Click(object sender, EventArgs e)
        {
            form = new FormBoatConfig();
            form.AddEvent(AddBoat);
            form.Show();
        }

        private void AddBoat(ITransport boat)
        {
            if(boat != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = harbour[listBoxLevels.SelectedIndex] + boat;
                if(place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
               }
            }
        }

              

        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

         private void buttonTake_Click_1(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var boat = harbour[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);
                    if (boat != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxPrev.Width, pictureBoxPrev.Height);
                        Graphics g = Graphics.FromImage(bmp);
                        boat.setPosition(15, 5, pictureBoxPrev.Width, pictureBoxHarbour.Height);
                        boat.DrawBoat(g);
                        pictureBoxPrev.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxPrev.Width, pictureBoxHarbour.Height);
                        pictureBoxPrev.Image = bmp;
                    }
                    Draw();
                }
            }

        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(harbour.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Сохранить не удалось :( ", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void toolStripLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (harbour.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}
    


