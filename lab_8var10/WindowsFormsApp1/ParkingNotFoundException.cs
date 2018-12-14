using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ParkingNotFoundException: Exception
    {
        public ParkingNotFoundException(int i) : base ("Автомобиль не найден по месту " + i)
        {

        }
    }
}
