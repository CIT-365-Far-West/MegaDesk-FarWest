using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Cotterell
{
    public enum DesktopMaterial { PINE = 50, LAMINATE = 100, VENEER = 125, OAK = 200, ROSEWOOD = 300};
    
    class Desk
    {
        const int WIDTH_MIN = 24;
        const int WIDTH_MAX = 96;
        const int DEPTH_MIN = 12;
        const int DEPTH_MAX = 48;
        const int BASE_PRICE = 200;
        const int PRICE_PER_SQ_IN = 1;
        const int PRICE_PER_DRAWER = 50;

        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public int DeskWidth { get; set; }
        public int DeskDepth { get; set; }
        public int NumDrawers { get; set; }
        public string SurfaceMaterial { get; set; }
        public int NumDays { get; set; }

        public int minWidth { get { return WIDTH_MIN; } }
        public int maxWidth { get { return WIDTH_MAX; } }
        public int minDepth { get { return DEPTH_MIN; } }
        public int maxDepth { get { return DEPTH_MAX; } }
        public int basePrice { get { return BASE_PRICE; } }
        public int priPerSqIn { get { return PRICE_PER_SQ_IN; } }
        public int priPerDra { get { return PRICE_PER_DRAWER; } }
        //public int DesktopPrice { get { return (int)Enum.Parse(typeof(DesktopMaterial), SurfaceMaterial); } }

        public Desk(string firstName, string lastName, int width, int depth, int drawers, string surface, int days)
        {
            CustomerFirstName = firstName;
            CustomerLastName = lastName;
            DeskWidth = width;
            DeskDepth = depth;
            NumDrawers = drawers;
            SurfaceMaterial = surface;
            NumDays = days;
        }
    }

}
