using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormBoat.SpeedBoat;

namespace WindowsFormBoat { 
    

    public partial class FormBoat : Form
    {
        
        private SpeedBoat speedboat;

        public FormBoat()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBoat.Width, pictureBoxBoat.Height);
            Graphics g = Graphics.FromImage(bmp);
            speedboat.DrawCar(g);
            pictureBoxBoat.Image = bmp;
        }

       

        private void createClick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            speedboat = new SpeedBoat(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
Color.Yellow, true, true, true);
            speedboat.setPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBoat.Width,
           pictureBoxBoat.Height);
            Draw();

        }

        private void moveClick(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    speedboat.moveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    speedboat.moveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    speedboat.moveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    speedboat.moveTransport(Direction.Right);
                    break;
            }
            Draw();


        }

        private void pictureBoxCars_Click(object sender, EventArgs e)
        {

        }

        private void FormBoat_Load(object sender, EventArgs e)
        {

        }
    }
}
