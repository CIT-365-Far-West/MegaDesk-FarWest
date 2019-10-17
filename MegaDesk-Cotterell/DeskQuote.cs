using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Cotterell
{
    class DeskQuote
    {
        private int surfaceArea, surfaceAreaPrice, drawerPrice, surfacePrice, rushPrice, priceQuote;
        private string rushCode;


        public DeskQuote(Desk desk)
        {
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

            DateTime date = DateTime.Now;

            var displayQuote = new DisplayQuote();
            displayQuote.Tag = this;
            displayQuote.Show(this);
            hide();

        }

        private int GetRushPrice(string rushCode)
        {
            switch (rushCode)
            {
                case "3S":
                    return 60;
                case "3M":
                    return 70;
                case "3L":
                    return 80;
                case "5S":
                    return 40;
                case "5M":
                    return 50;
                case "5L":
                    return 60;
                case "7S":
                    return 30;
                case "7M":
                    return 35;
                case "7L":
                    return 40;
                default:
                    return 0;
            }
        }
    }
}
