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

       

        /*private void createClick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            boat = new Boat(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            boat.setPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBoat.Width,
           pictureBoxBoat.Height);
            Draw();

        }

        private void createSportClick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            boat = new SpeedBoat(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
Color.Yellow, true, true, true);
            boat.setPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBoat.Width,
           pictureBoxBoat.Height);
            Draw();
        }

        private void moveClick(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    boat.moveTransport(Direction.Up);
                    break;
                case "buttonDown":
                   boat.moveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    boat.moveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    boat.moveTransport(Direction.Right);
                    break;
            }
            Draw();


        }
        */

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

