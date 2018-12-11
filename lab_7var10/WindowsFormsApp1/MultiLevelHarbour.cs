using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormBoat;

namespace WindowsFormsApp1
{
    public class MultiLevelHarbour
    {

        List<Harbour<ITransport>> parkingStages;
        private int pictureWidth;
        private int pictureHeight;
        private const int countPlaces = 15;

        public MultiLevelHarbour(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Harbour<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Harbour<ITransport>(countPlaces, pictureWidth, pictureHeight));

            }

        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    WriteToFile("CountLevels:" + parkingStages.Count + Environment.NewLine, fs);
                    foreach (var level in parkingStages)
                    {
                        WriteToFile("Level" + Environment.NewLine, fs);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            try
                            {
                                var boat = level[i];
                                if (boat != null)
                                {
                                    if (boat.GetType().Name == "Boat")
                                    {
                                        WriteToFile(i + ":Boat:", fs);
                                    }
                                    if (boat.GetType().Name == "MotorBoat")
                                    {
                                        WriteToFile(i + ":MotorBoat:", fs);
                                    }
                                    WriteToFile(boat + Environment.NewLine, fs);
                                }
                            }
                            finally { }
                        }
                    
                    }

                }
            }
            
        }

        public void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        bufferTextFromFile += temp.GetString(b);
                    }
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountLevels"))
            {
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
                if (parkingStages != null)
                {
                    parkingStages.Clear();
                }
                parkingStages = new List<Harbour<ITransport>>(count);
            }
            else
            {
                throw new Exception("Неверный формат файла");
            }
            int counter = -1;
            ITransport boat = null;
            for (int i = 1; i < strs.Length; ++i)
            {
                if (strs[i] == "Level")
                {
                    counter++;
                    parkingStages.Add(new Harbour<ITransport>(countPlaces, pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(':')[1] == "Boat")
                {
                    boat = new Boat(strs[i].Split(':')[2]);

                }
                else if (strs[i].Split(':')[1] == "MotorBoat")
                {
                    boat = new MotorBoat(strs[i].Split(':')[2]);
                }
                parkingStages[counter][Convert.ToInt32(strs[i].Split(':')[0])] = boat;
            }
            return true;
        }



        public Harbour<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

    }
}


