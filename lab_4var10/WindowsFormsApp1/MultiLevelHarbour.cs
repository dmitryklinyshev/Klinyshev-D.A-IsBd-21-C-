using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class MultiLevelHarbour
    {

        List<Harbour<ITransport>> parkingStages;

        private const int countPlaces = 15;

        public MultiLevelHarbour(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Harbour<ITransport>>();
            for(int i =0; i < countStages; ++i)
            {
                parkingStages.Add(new Harbour<ITransport>(countPlaces, pictureWidth, pictureHeight));

            }
                       
        }

        public Harbour<ITransport> this [int ind]
        {
            get
            {
                if(ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

    }
}
