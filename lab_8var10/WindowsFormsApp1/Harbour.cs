using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormBoat;

namespace WindowsFormsApp1
{
   public class Harbour<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Harbour<T>> where T:class , ITransport
    {
        private Dictionary<int, T> _places;

        private int MaxCount;

        private int _placeSizeWidth = 250;
        private int _placeSizeHeight = 80;

        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }

        private int _currentIndex;
        ///

         public Harbour(int sizes, int pictureWidth, int pictureHeight)
        {
            MaxCount = sizes;
            _places = new Dictionary<int, T>();
        _currentIndex = -1;
        PictureHeight = pictureHeight;
            PictureWidth = pictureWidth;
        }

        public static int operator + (Harbour<T> h, T boat)
        {
            if (h._places.Count == h.MaxCount)
            {
                throw new ParkingOverflowException();
            }
            for(int i = 0; i < h.MaxCount; i++)
            {
                if (h.CheckFreePlace(i))
                {
                    h._places.Add(i, boat);
                    h._places[i].setPosition(5 + i / 5 * h._placeSizeWidth + 5, i % 5 * h._placeSizeHeight + 15
                    , h.PictureWidth, h.PictureHeight);
                    return i;
                }
                else if (boat.GetType() == h._places[i].GetType())
                {
                    if (boat is MotorBoat)
                    {
                        if ((boat as MotorBoat).Equals(h._places[i]))
                        {
                            throw new ParkingAlreadyHaveException();
                        }
                    }
                    else if ((boat as Boat).Equals(h._places[i]))
                    {
                        throw new ParkingAlreadyHaveException();
                    }
                }
             }
          
            return -1;
        }

        public static T operator - (Harbour<T> h, int index)
        {
         

            if (!h.CheckFreePlace(index))
            {
                T boat = h._places[index];
                h._places.Remove(index);
                return boat;
            }

            throw new ParkingNotFoundException(index);
        }

        private bool CheckFreePlace(int index)
        { 
            return !_places.ContainsKey(index);   
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            foreach (var boat in _places)
            {
                boat.Value.DrawBoat(g);
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
                throw new ParkingNotFoundException(ind);
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].setPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5 * _placeSizeHeight + 15, PictureWidth, PictureHeight);
                }
                else
                {
                    throw new ParkingOccupiedPlaceException(ind);
                }
            }
        }

        public T Current
        {
            get
            {
                return _places[_places.Keys.ToList()[_currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            _places.Clear();
        }

        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
        /// </summary>
        public void Reset()
        {
            _currentIndex = -1;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        /// <summary>
        /// Метод интерфейса IComparable
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Harbour<T> other)
        {
            if (_places.Count > other._places.Count)
            {
                return -1;
            }
            else if (_places.Count < other._places.Count)
            {
                return 1;
            }
            else if (_places.Count > 0)
            {
                var thisKeys = _places.Keys.ToList();
                var otherKeys = other._places.Keys.ToList();
                for (int i = 0; i < _places.Count; ++i)
                {
                    if (_places[thisKeys[i]] is Boat && other._places[thisKeys[i]] is MotorBoat)
                    {
                        return 1;
                    }
                    if (_places[thisKeys[i]] is MotorBoat && other._places[thisKeys[i]] is Boat)
                    {
                        return -1;
                    }
                    if (_places[thisKeys[i]] is Boat && other._places[thisKeys[i]] is Boat)
                    {
                        return (_places[thisKeys[i]] is Boat).CompareTo(other._places[thisKeys[i]] is Boat);
                    }
                    if (_places[thisKeys[i]] is MotorBoat && other._places[thisKeys[i]] is MotorBoat)
                    {
                        return (_places[thisKeys[i]] is MotorBoat).CompareTo(other._places[thisKeys[i]] is MotorBoat);
                    }
                }
            }
            return 0;
        }
    }
}

