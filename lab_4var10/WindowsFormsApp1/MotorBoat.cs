using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormBoat
{
    class MotorBoat : Boat
    {

        public Color DopColor { private set; get; }

        public bool Frontpart { private set; get; }

        public bool Engine { private set; get; }

        public bool Backpart { private set; get; }

        public MotorBoat(int maxSpeed, float weight, Color mainColor, Color dopColor,
            bool frontPart, bool engine, bool backPart)
            : base(maxSpeed, weight, mainColor)
        {

            DopColor = dopColor;
            Frontpart = frontPart;
            Engine = engine;
            Backpart = backPart;
        }


        public override void DrawBoat(Graphics g)
        {
            if (Backpart)
            {
                Pen pen = new Pen(Color.Black);
                g.DrawArc(pen, _startPosX - 35, _startPosY - 15, 70, 90, 0, 45);
            }

            if (Engine)
            {

                Pen pen = new Pen(Color.Black);
                g.DrawArc(pen, _startPosX - 25, _startPosY - 15, 70, 90, 0, 45);
                g.DrawRectangle(pen, _startPosX + 40, _startPosY + 15, 7, 7);
                g.DrawRectangle(pen, _startPosX + 35, _startPosY + 55, 7, 7);

                Brush brBlack = new SolidBrush(Color.Black);
                g.FillRectangle(brBlack, _startPosX + 25, _startPosY + 55, 7, 7);

                Brush brRed = new SolidBrush(Color.Red);
                g.FillRectangle(brRed, _startPosX + 35, _startPosY + 15, 15, 15);

                Brush brYellow = new SolidBrush(Color.Yellow);
                g.FillRectangle(brYellow, _startPosX + 40, _startPosY + 15, 7, 7);
            }

            if (Frontpart)
            {
                Pen pen1 = new Pen(DopColor);
                g.DrawLine(pen1, _startPosX + 120, _startPosY + 10, _startPosX + 50, _startPosY + 30);

                g.DrawLine(pen1, _startPosX + 120, _startPosY + 30, _startPosX + 120, _startPosY + 10);

                Pen pen = new Pen(DopColor);
                g.DrawLine(pen, _startPosX + 145, _startPosY + 20, _startPosX + 170, _startPosY + 30);
                g.DrawLine(pen, _startPosX + 145, _startPosY + 45, _startPosX + 170, _startPosY + 30);

                Brush dopColor = new SolidBrush(DopColor);
                g.FillRectangle(dopColor, _startPosX + 50, _startPosY + 50, 80, 10);

                Brush brBlack = new SolidBrush(Color.Black);
                g.FillRectangle(brBlack, _startPosX + 35, _startPosY + 55, 7, 7);
            }
            base.DrawBoat(g);
        }
    }
}



