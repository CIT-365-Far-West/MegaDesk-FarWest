using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Cotterell
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(Desk desk, int surfaceArea, int basePrice, int drawerPrice, int surfacePrice, int rushPrice, int priceQuote,  DateTime date)
        {
            InitializeComponent();
            quoteTitle.Text = "Quote for " + desk.CustomerFirstName + " " + desk.CustomerLastName;
            quoteDate.Text = date.ToString();
            deskSize.Text = desk.DeskWidth.ToString() + " X " + desk.DeskDepth.ToString();
            deskPrice.Text = basePrice.ToString("C0");
            drawers.Text = desk.NumDrawers.ToString();
            drawersPrice.Text = drawerPrice.ToString("C0");
            surfaceMaterial.Text = desk.SurfaceMaterial;
            surfacePriceLabel.Text = surfacePrice.ToString("C0");
            rushOrder.Text = desk.NumDays.ToString();
            rushPriceLabel.Text = rushPrice.ToString("C0");
            total.Text = priceQuote.ToString("C0");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
