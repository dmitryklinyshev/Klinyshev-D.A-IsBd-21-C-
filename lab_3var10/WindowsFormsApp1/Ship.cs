using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormHarbour;

using static WindowsFormHarbour.SpeedBoat;

namespace WindowsFormsApp1
{

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    } 

    abstract class Ship : ITransport
    {

      

        protected float _startPosX;
        protected float _startPosY;
        protected float _pictureWidth;
        protected float _pictureHeight;

        public int MaxSpeed { protected set; get; }

        public float Weight { protected set; get; }

        public Color MainColor { protected set; get;}

        public void setPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public abstract void DrawBoat(Graphics g);

       
        public abstract void moveTransport(Direction direction);
    }
}