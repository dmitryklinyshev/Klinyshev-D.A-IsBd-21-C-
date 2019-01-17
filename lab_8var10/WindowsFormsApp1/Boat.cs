using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    class Boat : Ship, IComparable<Boat>, IEquatable<Boat>
    {

        protected const int boatWidth = 160;

        protected const int boatHeight = 60;
        private string v;

        public Boat(string info)
        {
            string[] strs = info.Split(';');
            if(strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public Boat(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;

        }

      

        public override void DrawBoat(Graphics g)
        {

            Pen pen = new Pen(Color.Black);

            g.DrawRectangle(pen, _startPosX + 50, _startPosY + 30, 80, 25);

            Pen pen2 = new Pen(Color.LightSkyBlue);

            g.DrawLine(pen2, _startPosX + 130, _startPosY + 30, _startPosX + 160, _startPosY + 30);
            g.DrawLine(pen2, _startPosX + 130, _startPosY + 60, _startPosX + 160, _startPosY + 30);

            Pen pen1 = new Pen(Color.Gold);
            g.DrawLine(pen1, _startPosX + 120, _startPosY + 10, _startPosX + 160, _startPosY + 30);


            g.DrawRectangle(pen, _startPosX + 50, _startPosY + 30, 15, 15);

            Brush brBlue = new SolidBrush(MainColor);
            g.FillRectangle(brBlue, _startPosX + 50, _startPosY + 30, 80, 25);

            Brush brGray = new SolidBrush(Color.Gray);
            g.FillRectangle(brGray, _startPosX + 50, _startPosY + 50, 80, 10);

            Pen pen4 = new Pen(Color.Gray);
            pen4.Width = 4.0F;
            g.DrawLine(pen4, _startPosX + 100, _startPosY + 15, _startPosX + 60, _startPosY + 70);

            Brush brGray1 = new SolidBrush(Color.Black);
            g.FillRectangle(brGray1, _startPosX + 57, _startPosY + 70, 8, 5);


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

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }

        public int CompareTo(Boat other)
        {
            if(other == null)
            {
                return 1;
            }
            if(MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if(Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if(MainColor != other.MainColor)
            {
                return MainColor.Name.CompareTo(other.MainColor);
            }
            return 0;
        }
        public bool Equals(Boat other)
        {
            if(other == null)
            {
                return false;
            }
            if(MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if(Weight != other.Weight)
            {
                return false;
            }
            if(MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            Boat boatObj = obj as Boat;
            if(boatObj == null)
            {
                return false;
            }
            else
            {
                return base.Equals(boatObj);
            }
        
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

