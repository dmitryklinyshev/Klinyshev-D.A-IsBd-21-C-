using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormHarbour
{
    class SpeedBoat : Boat
    {
        
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
            : base(maxSpeed, weight, mainColor)
        {
            
            DopColor = dopColor;
            FrontSpoiler = frontSpoiler;
            SideSpoiler = sideSpoiler;
            BackSpoiler = backSpoiler;

        }

             public override void DrawBoat(Graphics g)
        {
            if (FrontSpoiler)
            {
                Brush dop = new SolidBrush(DopColor);
                g.FillRectangle(dop, _startPosX - 35, _startPosY + 75, 70, 70);
            }

            Pen pen = new Pen(Color.Black);
             


            base.DrawBoat(g);

           
        }
    }
}

    

