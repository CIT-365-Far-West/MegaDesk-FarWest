using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_Cotterell
{
    public partial class DisplayQuote : Form
    {
        Desk desk;
        DeskQuote deskQuote;
        AllQuotes allQuotes = new AllQuotes();
        List<DeskQuote> quotes = new List<DeskQuote>();

        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            desk = deskQuote.desk;
            this.deskQuote = deskQuote;
            quoteTitle.Text = "Quote for " + desk.CustomerFirstName + " " + desk.CustomerLastName;
            quoteDate.Text = deskQuote.date.ToShortDateString();
            deskSize.Text = desk.DeskWidth.ToString() + " X " + desk.DeskDepth.ToString();
            deskPrice.Text = deskQuote.surfaceAreaPrice.ToString("C0");
            drawers.Text = desk.NumDrawers.ToString();
            drawersPrice.Text = deskQuote.drawerPrice.ToString("C0");
            surfaceMaterial.Text = desk.SurfaceMaterial;
            surfacePriceLabel.Text = deskQuote.surfacePrice.ToString("C0");
            rushOrder.Text = desk.NumDays.ToString();
            rushPriceLabel.Text = deskQuote.rushPrice.ToString("C0");
            total.Text = deskQuote.priceQuote.ToString("C0");
            quotes = allQuotes.RetrieveAllQuotes();
            quotes.Add(deskQuote);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            addQuote.Tag = this;
            addQuote.Show(this);
            Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            allQuotes.SaveAllQuotes(quotes);

            MainMenu mainMenu = new MainMenu();
            mainMenu.Tag = this;
            mainMenu.Show(this);
            Hide();
        }
    }
}
