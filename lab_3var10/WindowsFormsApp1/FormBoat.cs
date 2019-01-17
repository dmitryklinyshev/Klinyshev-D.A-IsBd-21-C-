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
using static WindowsFormHarbour.SpeedBoat;
using static WindowsFormsApp1.Ship;

namespace WindowsFormHarbour { 
    

    public partial class FormHarbour : Form
    {

        Harbour<ITransport> harbour;

        public FormHarbour()
        {
            InitializeComponent();
            harbour = new Harbour<ITransport>(20, pictureBoxHarbour.Width, pictureBoxHarbour.Height);
            Draw();
        }



        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxHarbour.Width, pictureBoxHarbour.Height);
            Graphics g = Graphics.FromImage(bmp);
            harbour.Draw(g);
            pictureBoxHarbour.Image = bmp;
        }
            
        private void buttonSetBoat_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                var boat = new Boat(100, 1000, colorDialog.Color);
                int place = harbour + boat;
                                Draw();
            }
        }

        private void buttonSetSpeedBoat_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog colorDopDialog = new ColorDialog();
                if (colorDopDialog.ShowDialog() == DialogResult.OK)
                { 
                   var boat = new SpeedBoat(100, 1000, colorDialog.Color, colorDopDialog.Color, true, true, true);
                    int place = harbour + boat;
                    Draw();
                }

            }

        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if(maskedTextBox.Text != "")
            {
                var boat = harbour - Convert.ToInt32(maskedTextBox.Text);
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
}

