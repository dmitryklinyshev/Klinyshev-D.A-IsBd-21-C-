using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.Ship;

namespace WindowsFormsApp1
{
   public interface ITransport
    {

        void setPosition(int x, int y, int width, int height);

        void moveTransport(Direction direction);

        void DrawBoat(Graphics g);
        
    }
}
