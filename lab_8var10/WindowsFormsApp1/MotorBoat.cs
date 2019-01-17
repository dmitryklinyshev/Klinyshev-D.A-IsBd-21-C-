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
    class MotorBoat : Boat, IComparable<MotorBoat>, IEquatable<MotorBoat>
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

        public MotorBoat(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Backpart = Convert.ToBoolean(strs[4]);
                Engine = Convert.ToBoolean(strs[5]);
                Frontpart = Convert.ToBoolean(strs[6]);

            }

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

        public void setDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Backpart + ";" + Engine + ";" + Frontpart ;
        }

       

        public int CompareTo(MotorBoat other)
        {
            var res = (this is Boat).CompareTo(other is Boat);
            if(res != 0)
            {
                return res;
            }
            if(DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if(Backpart != other.Backpart)
            {
                Backpart.CompareTo(other.Backpart);
            }
            if(Frontpart != other.Frontpart)
            {
                Frontpart.CompareTo(other.Frontpart);
            }
            if(Engine != other.Engine)
            {
                Engine.CompareTo(other.Engine);
            }
            return 0;
        }
        public bool Equals(MotorBoat other)
        {
            var res = (this as Boat).Equals(other as Boat);
            if (!res)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Backpart != other.Backpart)
            {
                return false;
            }
            if (Frontpart != other.Frontpart)
            {
                return false;
            }
            if (Engine != other.Engine)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            MotorBoat carObj = obj as MotorBoat;
            if (carObj == null)
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}


