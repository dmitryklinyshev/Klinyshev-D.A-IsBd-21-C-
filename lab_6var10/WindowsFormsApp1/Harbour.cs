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
        private Dictionary<int, T> _places;

        private int MaxCount;

        private int _placeSizeWidth = 250;
        private int _placeSizeHeight = 80;

        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }

        public Harbour(int sizes, int pictureWidth, int pictureHeight)
        {
            MaxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureHeight = pictureHeight;
            PictureWidth = pictureWidth;
        }

        public static int operator + (Harbour<T> h, T boat)
        {
            if (h._places.Count == h.MaxCount)
            {
                return -1;
            }
            for(int i = 0; i < h.MaxCount; i++)
            {
                if (h.CheckFreePlace(i))
                {
                    h._places.Add(i, boat);
                        h._places[i].setPosition(5 + i / 5 * h._placeSizeWidth + 5, i % 5 * h._placeSizeHeight + 15
                        , h.PictureWidth,  h.PictureHeight);
                    return i;

                }
            }
            return -1;
        }

        public static T operator - (Harbour<T> h, int index)
        {
            if(index < 0 || index > h._places.Count)
            {
                return null;
            }

            if (!h.CheckFreePlace(index))
            {
                T boat = h._places[index];
                h._places.Remove(index);
                return boat;
            }

            return null;
        }

        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);   
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for(int i = 0 ; i < keys.Count; i++)
            {
                _places[keys[i]].DrawBoat(g);
            }
        }
     

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);

            g.DrawRectangle(pen, 0, 0, (MaxCount ) * _placeSizeWidth, 480);
            for(int i = 0; i < MaxCount  ; i++)
            {
                for(int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + 110,
                        j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }

        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }   
                return null;
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].setPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5 *
                    _placeSizeHeight + 15, PictureWidth, PictureHeight);
                }
            }
        }
    }
}

