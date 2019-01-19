using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormBoat;
using WindowsFormHarbour;

namespace WindowsFormsApp1
{
    public partial class FormBoatConfig : Form
    {
        ITransport boat = null;

        private event boatDelegate eventAddBoat;

        public FormBoatConfig()
        {
            InitializeComponent();


            panelGreen.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelAque.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        
        private void DrawBoat()
        {
            if (boat != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxBoat.Width, pictureBoxBoat.Height);
                Graphics gr = Graphics.FromImage(bmp);
                boat.setPosition(5, 5, pictureBoxBoat.Width, pictureBoxBoat.Height);
                boat.DrawBoat(gr);
                pictureBoxBoat.Image = bmp;
            }
        }        public void AddEvent(boatDelegate ev)
        {
            if (eventAddBoat == null)
            {
                eventAddBoat = new boatDelegate(ev);
            }
            else
            {
                eventAddBoat += ev;
            }
        }
        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный катер":
                    boat = new Boat(100, 500, Color.White);
                    break;
                case "Гоночный катер":
                    boat = new MotorBoat(100, 500, Color.White, Color.Black, true, true,
                   true);
                    break;
            }
            DrawBoat();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>  
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (boat != null)
            {
                boat.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawBoat();
            }
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (boat != null)
            {
                if (boat is MotorBoat)
                {
                    (boat as MotorBoat).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawBoat();
                }
            }
        }

        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Добавление машины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void labelBoatClick_MouseDown(object sender, MouseEventArgs e)
        {
            labelBoatClick.DoDragDrop(labelBoatClick.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelMotorBoatClick_MouseDown(object sender, MouseEventArgs e)
        {   
            labelMotorBoatClick.DoDragDrop(labelMotorBoatClick.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }   

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddBoat?.Invoke(boat);
            Close();
        }

       
    }
}




