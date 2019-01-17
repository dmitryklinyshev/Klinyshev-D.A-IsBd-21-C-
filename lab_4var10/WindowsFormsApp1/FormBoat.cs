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
            if (listBoxLevels.SelectedIndex > -1)
            {


                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    var boat = new Boat(100, 1000, colorDialog.Color);
                    int place = harbour[listBoxLevels.SelectedIndex] + boat;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }

        private void buttonSetSpeedBoat_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog colorDopDialog = new ColorDialog();
                    if (colorDopDialog.ShowDialog() == DialogResult.OK)
                    {
                        var boat = new WindowsFormBoat.MotorBoat(100, 1000, colorDialog.Color, colorDopDialog.Color, true, true, true);
                        int place = harbour[listBoxLevels.SelectedIndex] + boat;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }

                }
            }
        }



        private void buttonTake_Click(object sender, EventArgs e)
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
                    } else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxPrev.Width, pictureBoxHarbour.Height);
                        pictureBoxPrev.Image = bmp;
                    }
                    Draw();
                }
            }


        }

        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}

