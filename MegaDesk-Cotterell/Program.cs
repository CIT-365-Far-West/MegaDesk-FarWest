using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Cotterell
{
    public static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }

        public static string SurfaceMaterialDescr(DesktopMaterial material)
        {
            string materialDesc = "";
            switch (material)
            {
                case DesktopMaterial.Oak:
                    materialDesc = "Oak";
                    break;
                case DesktopMaterial.Laminate:
                    materialDesc = "Laminate";
                    break;

            }
            return materialDesc;
        }

        public static DesktopMaterial SurfaceMaterialId(string materialDesc)
        {
            DesktopMaterial materialId = DesktopMaterial.Oak;
            switch (materialDesc)
            {
                case "Oak":
                    materialId = DesktopMaterial.Oak;
                    break;
                case "Laminate":
                    materialId = DesktopMaterial.Laminate;
                    break;
                case "Pine":
                    materialId = DesktopMaterial.Pine;
                    break;
                case "Rosewood":
                    materialId = DesktopMaterial.Rosewood;
                    break;
                case "Veneer":
                    materialId = DesktopMaterial.Veneer;
                    break;
            }
            return materialId;
        }
    }
}
