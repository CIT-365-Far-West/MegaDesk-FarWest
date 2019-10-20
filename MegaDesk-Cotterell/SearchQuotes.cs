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
using Newtonsoft.Json;

namespace MegaDesk_Cotterell
{
    public partial class SearchQuotes : Form
    {
        List<DeskQuote> quotes = new List<DeskQuote>();
        AllQuotes allQuotes = new AllQuotes();
        public SearchQuotes()
        {
            InitializeComponent();
            quotes = allQuotes.RetrieveAllQuotes();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void surfaceMaterialCmbo_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<DeskQuote> selectedQuotes = new List<DeskQuote>();
            foreach (DeskQuote quote in quotes)
            {
                if (quote.desk.SurfaceMaterial == surfaceMaterialCmbo.Text)
                {
                    selectedQuotes.Add(quote);
                }
            }
            foreach (DeskQuote quote in selectedQuotes)
            {
                string[] filtered = allQuotes.FilterQuote(quote);
                dataGridView1.Rows.Add(filtered);
            }
                
        }
    }
}
