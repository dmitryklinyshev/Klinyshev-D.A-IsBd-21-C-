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
using static WindowsFormBoat.MotorBoat;
using static WindowsFormsApp1.Ship;

namespace WindowsFormBoat { 
    

    public partial class FormBoat : Form
    {
       
        private ITransport boat;

        public FormBoat()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBoat.Width, pictureBoxBoat.Height);
            Graphics g = Graphics.FromImage(bmp);
            boat.DrawBoat(g);
            pictureBoxBoat.Image = bmp;
        }

       

        private void createClick(object sender, EventArgs e)
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
            boat = new MotorBoat(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
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
    }

}

