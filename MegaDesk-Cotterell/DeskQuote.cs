using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Cotterell
{
    public class DeskQuote
    {
        public Desk desk;
        public int surfaceArea, surfaceAreaPrice, drawerPrice, surfacePrice, rushPrice, priceQuote;
        public string rushCode;
        public DateTime date = DateTime.Now;

        public DeskQuote()
        {
        }

        public DeskQuote(Desk desk)
        {
            this.desk = desk;
            surfaceArea = desk.DeskWidth * desk.DeskDepth;
            if (surfaceArea > 1000)
                surfaceAreaPrice = surfaceArea * desk.priPerSqIn;
            else
                surfaceAreaPrice = desk.basePrice;

            drawerPrice = desk.NumDrawers * desk.priPerDra;
            surfacePrice = (int)Enum.Parse(typeof(DesktopMaterial), desk.SurfaceMaterial);

            rushCode = desk.NumDays.ToString();
            if (surfaceArea < 1000)
                rushCode += "S";
            else if (surfaceArea <= 2000)
                rushCode += "M";
            else
                rushCode += "L";

            rushPrice = GetRushPrice(rushCode);

            priceQuote = surfaceAreaPrice + drawerPrice + surfacePrice + rushPrice;

        }

        private int[,] GetRushOrder()
        {
            StreamReader reader = new StreamReader("rushOrderPrices.txt");
            int[] rushPrices = new int[9];
            int[,] rushArray = new int[3, 3];
            int count = 0;

            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                int price;
                try
                {
                    price = int.Parse(line);
                    rushPrices[count] = price;
                    count++;
                }
                catch(Exception e)
                {
                    File.WriteAllText("logfile.log", "rushOrderPrices.txt could not be parsed. Exception: " + e.ToString());
                }
            }
            for (int i = 0; i < 9; i++)
            {
                int x, y;
                x = i / 3;
                y = i % 3;
                rushArray[x, y] = rushPrices[i];
            }
            reader.Close();
            return rushArray;
        }
        private int GetRushPrice(string rushCode)
        {
            int[,] c = GetRushOrder();
            switch (rushCode)
            {
                case "3S":
                    return c[0,0];
                case "3M":
                    return c[0,1];
                case "3L":
                    return c[0,2];
                case "5S":
                    return c[1,0];
                case "5M":
                    return c[1,1];
                case "5L":
                    return c[1,2];
                case "7S":
                    return c[2,0];
                case "7M":
                    return c[2,1];
                case "7L":
                    return c[2,2];
                default:
                    return 0;
            }
        }
    }
}
