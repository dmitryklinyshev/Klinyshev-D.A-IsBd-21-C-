using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormHarbour.SpeedBoat;

namespace WindowsFormsApp1
{
     class Boat : Ship
    {

        

        protected const int boatWidth = 100 ;

        protected const int boatHeight = 60 ;
       

        public Boat(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;

        }

        public override void DrawBoat(Graphics g)
        {

            Pen pen = new Pen(Color.Black);

            g.DrawRectangle(pen, _startPosX - 1, _startPosY + 30, 80, 30);

            Pen pen2 = new Pen(Color.LightSkyBlue);

            g.DrawLine(pen2, _startPosX + 80, _startPosY + 30, _startPosX + 110, _startPosY + 30);
            g.DrawLine(pen2, _startPosX + 80, _startPosY + 60, _startPosX + 110, _startPosY + 30);



            Pen pen1 = new Pen(Color.Gold);
            g.DrawLine(pen1, _startPosX + 70, _startPosY + 10, _startPosX + 110, _startPosY + 30);

            g.DrawRectangle(pen, _startPosX - 15, _startPosY + 15, 15, 15);
            g.DrawArc(pen, _startPosX - 75, _startPosY - 15, 70, 90, 0, 45);
            g.DrawRectangle(pen, _startPosX - 10, _startPosY + 15, 7, 7);
            g.DrawRectangle(pen, _startPosX - 15, _startPosY + 55, 7, 7);


            Brush brBlue = new SolidBrush(Color.Blue);
            g.FillRectangle(brBlue, _startPosX - 1, _startPosY + 30, 80, 25);

            Brush brGray = new SolidBrush(Color.Gray);
            g.FillRectangle(brGray, _startPosX - 1, _startPosY + 50, 80, 10);



            Brush brRed = new SolidBrush(Color.Red);
            g.FillRectangle(brRed, _startPosX - 15, _startPosY + 15, 15, 15);

            Brush brYellow = new SolidBrush(Color.Yellow);
            g.FillRectangle(brYellow, _startPosX - 10, _startPosY + 15, 7, 7);

            Brush brBlack = new SolidBrush(Color.Black);
            g.FillRectangle(brBlack, _startPosX - 15, _startPosY + 55, 7, 7);




        }

        public override void moveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - boatHeight)
                    {
                        _startPosY += step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - boatWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;

            }
        }

       
    }
}

