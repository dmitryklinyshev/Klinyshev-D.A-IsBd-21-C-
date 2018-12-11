using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class Harbour<T> where T:class , ITransport
    {
        private T[] _places;

        private int _placeSizeWidth = 210;
        private int _placeSizeHeight = 80;

        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }

        public Harbour(int sizes, int pictureWidth, int pictureHeight)
        {
            _places = new T[sizes];
            PictureHeight = pictureHeight;
            PictureWidth = pictureWidth;
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i] = null;
            }
        }

        public static int operator + (Harbour<T> h, T boat)
        {
            for(int i = 0; i < h._places.Length; i++)
            {
                if (h.CheckFreePlace(i))
                {
                    h._places[i] = boat;
                    h._places[i].setPosition(5 + i / 5 * h._placeSizeWidth + 5, i % 5 * h._placeSizeHeight + 15
                        , h.PictureWidth, h.PictureHeight);
                    return i;

                }
            }
            return -1;
        }

        public static T operator - (Harbour<T> h, int index)
        {
            if(index < 0 || index > h._places.Length)
            {
                return null;
            }

            if (!h.CheckFreePlace(index))
            {
                T boat = h._places[index];
                h._places[index] = null;
                return boat;
            }

            return null;
        }
                
        private bool CheckFreePlace(int index)
        {
            return _places[index] == null;   
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for(int i = 0 ; i < _places.Length; i++)
            {
                if (!CheckFreePlace(i))
                {
                    _places[i].DrawBoat(g);
                }
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);

            g.DrawRectangle(pen, 0, 0, (_places.Length / 5) * _placeSizeWidth, 480);
            for(int i = 0; i < _places.Length; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + 110,
                        j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
    }
}
