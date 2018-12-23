using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormBoat
{
    public class SpeedBoat
    {
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки автомобиля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        //Высота окна отрисовки
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private const int boatWidth = 100;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private const int boatHeight = 60;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }

    

        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight { private set; get; }

        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего спойлера
        /// </summary>
        public bool FrontSpoiler { private set; get; }

       

        /// <summary>
        /// Признак наличия боковых спойлеров
        /// </summary>
        public bool SideSpoiler { private set; get; }
        /// <summary>
        /// Признак наличия заднего спойлера
        /// </summary>
        public bool BackSpoiler { private set; get; }

        public SpeedBoat(int maxSpeed, float weight, Color mainColor, Color dopColor,
            bool frontSpoiler, bool sideSpoiler, bool backSpoiler)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FrontSpoiler = frontSpoiler;
            SideSpoiler = sideSpoiler;
            BackSpoiler = backSpoiler;

        }

        public void setPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        public void moveTransport(Direction direction)
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

        public void DrawCar(Graphics g)
        {

            Pen pen = new Pen(Color.Black);

            
            g.DrawRectangle(pen, _startPosX - 1, _startPosY + 30, 80, 30);

            Pen pen2 = new Pen(Color.LightSkyBlue);
          
            g.DrawLine(pen2, _startPosX + 80, _startPosY + 30, _startPosX + 110, _startPosY + 30);
            g.DrawLine(pen2, _startPosX + 80, _startPosY + 60, _startPosX + 110, _startPosY + 30);
        


            Pen pen1 = new Pen(Color.Gold);
            g.DrawLine(pen1,_startPosX + 70, _startPosY + 10, _startPosX + 110, _startPosY + 30);

            g.DrawRectangle(pen,_startPosX - 15, _startPosY + 15, 15,15);
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
        }
    }

    

